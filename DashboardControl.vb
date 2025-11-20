Imports Microsoft.Data.SqlClient
Imports ScottPlot

Public Class DashboardControl
    Private expensesControl As ExpensesControl



    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDashboard()
    End Sub
    Public Sub InitializeDashboard()
        ' If an ExpensesControl hasn't been set yet, create one
        If expensesControl Is Nothing Then
            expensesControl = New ExpensesControl()
            ' Add handler so dashboard updates when expenses change
            AddHandler expensesControl.ExpensesUpdated, AddressOf RefreshDashboard
        End If

        ' Initialize the expenses view (loads datagrid, charts, totals)
        expensesControl.InitializeExpenses()

        ' Refresh dashboard metrics and charts
        RefreshDashboard()
    End Sub
    'Refresh dashboard data
    Public Sub RefreshDashboard()
        Dim todaySales As Decimal = 0D
        Dim totalItemsSold As Integer = 0
        Dim todayExpenses As Decimal = 0D
        Dim totalPaid As Decimal = 0D
        Dim totalUnpaid As Decimal = 0D
        Dim netProfit As Decimal = 0D

        Try
            '  Get sales and items sold
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim queryTodaySales As String = "
                SELECT SUM(TotalAmount)
                FROM Transactions
                WHERE CAST(TransactionDate AS DATE) = CAST(GETDATE() AS DATE);"

                Using cmd As New SqlCommand(queryTodaySales, con)
                    Dim obj = cmd.ExecuteScalar()
                    todaySales = If(IsDBNull(obj), 0D, Convert.ToDecimal(obj))
                End Using

                Dim queryTotalItemsSold As String = "SELECT SUM(Quantity) FROM TransactionItems;"
                Using cmd As New SqlCommand(queryTotalItemsSold, con)
                    Dim obj = cmd.ExecuteScalar()
                    totalItemsSold = If(IsDBNull(obj), 0, Convert.ToInt32(obj))
                End Using
            End Using

            ' --- Get expenses from ExpensesControl ---
            ' Make sure expensesControl is not Nothing
            If expensesControl IsNot Nothing Then
                todayExpenses = expensesControl.GetExpenseTotal(fromDate:=Today)
                totalPaid = expensesControl.TotalPaid
                totalUnpaid = expensesControl.TotalUnpaid
            End If

            ' --- Compute net profit ---
            netProfit = todaySales - todayExpenses

            ' --- Update labels ---
            lblTotalSalesToday.Text = todaySales.ToString("₱#,##0.00")
            lblTotalItemsSold.Text = totalItemsSold.ToString()
            lblTodayExpenses.Text = todayExpenses.ToString("₱#,##0.00")
            lblTotalExpensesPaid.Text = totalPaid.ToString("₱#,##0.00")
            lblTotalExpensesUnpaid.Text = totalUnpaid.ToString("₱#,##0.00")
            lblNetProfit.Text = "₱" & netProfit.ToString("#,##0.00")

            ' --- Refresh charts ---
            LoadDailySalesChart()
            LoadCategoryChart()

        Catch ex As Exception
            MessageBox.Show("Dashboard refresh failed: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'set expenses control reference; subscribe to its update event
    Public Sub SetExpensesControl(ctrl As ExpensesControl)
        ' Assign the reference
        expensesControl = ctrl

        ' only add the handler once
        RemoveHandler expensesControl.ExpensesUpdated, AddressOf RefreshDashboard
        AddHandler expensesControl.ExpensesUpdated, AddressOf RefreshDashboard
    End Sub

    'reset dashboard labels and charts
    Private Sub ResetDashboard()
        lblNetProfit.Text = "₱0.00"
        lblNetProfitLastWeek.Text = "₱0.00"

        lblTodayExpenses.Text = "₱0.00"
        lblTotalExpensesUnpaid.Text = "₱0.00"
        lblTotalExpensesPaid.Text = "₱0.00"

        lblTotalItemsSold.Text = "00"
        lblTotalSalesToday.Text = "₱0.00"
        lblTotalSalesMonth.Text = "₱0.00"

        chartCategory.Plot.Clear()
        chartSales.Plot.Clear()

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




End Class
