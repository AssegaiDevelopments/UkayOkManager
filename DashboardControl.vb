Imports Microsoft.Data.SqlClient
Imports ScottPlot

Public Class DashboardControl

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDashboard()
    End Sub
    Private Sub LoadDailySalesChart()

        ' Step 1: Prepare 7-day window (including today)
        Dim last7Days As New List(Of Date)()
        For i = 6 To 0 Step -1
            last7Days.Add(Date.Today.AddDays(-i))
        Next

        Dim salesLookup As New Dictionary(Of Date, Double)()

        ' Step 2: Query database
        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim query As String = "
            SELECT 
                CAST(TransactionDate AS DATE) AS SaleDate,
                SUM(TotalAmount) AS DailyTotal
            FROM Transactions
            WHERE TransactionDate >= DATEADD(day, -6, CAST(GETDATE() AS DATE))
            GROUP BY CAST(TransactionDate AS DATE)
            ORDER BY SaleDate;"

            Dim cmd As New SqlCommand(query, con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim saleDate As Date = Convert.ToDateTime(reader("SaleDate"))
                Dim total As Double = Convert.ToDouble(reader("DailyTotal"))
                salesLookup(saleDate) = total
            End While
        End Using


        ' Step 3: Prepare final plot arrays with missing days = 0
        Dim x As New List(Of Double)()
        Dim y As New List(Of Double)()

        For Each d As Date In last7Days
            x.Add(d.ToOADate())    ' ScottPlot date format
            If salesLookup.ContainsKey(d) Then
                y.Add(salesLookup(d))
            Else
                y.Add(0)           ' no sales on this day
            End If
        Next


        ' Step 4: Plot
        chartSales.Plot.Clear()
        chartSales.Plot.Add.Scatter(x.ToArray(), y.ToArray())
        chartSales.Plot.Title("Sales (Last 7 Days)")
        chartSales.Plot.XLabel("Date")
        chartSales.Plot.YLabel("₱")

        ' Format X axis as dates
        chartSales.Plot.Axes.DateTimeTicksBottom()

        chartSales.Refresh()
    End Sub

    Private Sub LoadCategoryChart()
        Dim categoryNames As New List(Of String)()
        Dim categoryTotals As New List(Of Double)()
        Using con As New SqlConnection(connectAs)
            'query to get total items sold per category
            con.Open()
            Dim query As String = "
            SELECT 
                ProductName,
                COUNT(Quantity) AS TotalSold
            FROM TransactionItems
            GROUP BY ProductName
            ORDER BY ProductName;
            "

            Using cmd As New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        categoryNames.Add(reader("ProductName").ToString())
                        categoryTotals.Add(Convert.ToDouble(reader("TotalSold")))
                    End While
                End Using
            End Using
        End Using
        Dim xPositions = Enumerable.Range(0, categoryNames.Count).Select(Function(i) CDbl(i)).ToArray()
        Dim values = categoryTotals.ToArray()

        '-----------------------------------------
        ' 3. Draw Bar Chart on the ScottPlot chart
        '-----------------------------------------
        chartCategory.Plot.Clear()

        Dim bar = chartCategory.Plot.Add.Bars(xPositions, values)

        ' Add labels under each bar
        chartCategory.Plot.Axes.Bottom.SetTicks(xPositions, categoryNames.ToArray())

        ' Optional visuals

        chartCategory.Plot.Title("Sales by Category")
        chartCategory.Plot.YLabel("Total Items Sold")
        chartCategory.Plot.XLabel("Category")

        chartCategory.Plot.Axes.Margins(0, 0)
        chartCategory.Refresh()
    End Sub

    Public Sub InitializeDashboard()
        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim queryTodaySales As String = "
            SELECT SUM(TotalAmount)
            FROM Transactions
            WHERE CAST(TransactionDate AS DATE) = CAST(GETDATE() AS DATE);"

            Dim queryTotalItemsSold As String = "
            SELECT SUM(Quantity)
            FROM TransactionItems"

            Dim queryTodayExpenses As String = "
            SELECT SUM(Amount)
            FROM Expenses
            WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE);"


            Dim cmdSales As New SqlCommand(queryTodaySales, con)
            Dim cmdItems As New SqlCommand(queryTotalItemsSold, con)
            Dim cmdExpenses As New SqlCommand(queryTodayExpenses, con)

            Dim todaySalesObj = cmdSales.ExecuteScalar()
            Dim itemsSoldObj = cmdItems.ExecuteScalar()
            Dim todayExpensesObj = cmdExpenses.ExecuteScalar()

            Dim todaySales As Decimal = If(IsDBNull(todaySalesObj), 0D, Convert.ToDecimal(todaySalesObj))
            Dim totalItemsSold As Integer = If(IsDBNull(itemsSoldObj), 0, Convert.ToInt32(itemsSoldObj))
            Dim todayExpenses As Decimal = If(IsDBNull(todayExpensesObj), 0D, Convert.ToDecimal(todayExpensesObj))
            Dim NetProfit As Decimal

            lblTotalSalesToday.Text = todaySales.ToString("₱#,##0.00")
            lblTotalItemsSold.Text = totalItemsSold.ToString()
            lblTodayExpenses.Text = todayExpenses.ToString("₱#,##0.00")

            NetProfit = todaySales - todayExpenses
            lblNetProfit.Text = "₱" & NetProfit.ToString("#,##0.00")

        End Using

        LoadDailySalesChart()
        LoadCategoryChart()


    End Sub
End Class
