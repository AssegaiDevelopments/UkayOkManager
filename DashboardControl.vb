Imports Microsoft.Data.SqlClient
Imports ScottPlot

Public Class DashboardControl
    'set expenses control reference; subscribe to its update event
    Private expensesControl As ExpensesControl
    Public Sub SetExpensesControl(ctrl As ExpensesControl)
        ' Assign the reference
        expensesControl = ctrl

        ' only add the handler once
        RemoveHandler expensesControl.ExpensesUpdated, AddressOf RefreshDashboard
        AddHandler expensesControl.ExpensesUpdated, AddressOf RefreshDashboard
    End Sub

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
        'total sales today
        Dim todaySales As Decimal = 0D
        'quantity of items sold
        Dim totalItemsSold As Integer = 0
        'expenses due today
        Dim todayExpenses As Decimal = 0D
        'total expenses paid
        Dim totalPaid As Decimal = 0D
        'total expenses unpaid
        Dim totalUnpaid As Decimal = 0D
        Dim netProfit As Decimal = 0D

        Dim upcomingExpenses As Decimal = 0D
        'Expenses for the next 7 days
        Dim totalNext7Days As Decimal = 0D
        'Last Week profit
        Dim netProfitLastWeek As Decimal = 0D
        'Month Sales
        Dim today As Date = Date.Today
        Dim firstDayOfMonth As Date = New Date(today.Year, today.Month, 1)
        Dim totalSalesMonth As Decimal = 0D

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
                'Query Month Sale
                Dim queryMonthSales As String = "
                     SELECT SUM(TotalAmount) 
                     FROM Transactions 
                     WHERE CAST(TransactionDate AS DATE) BETWEEN @fromDate AND @toDate"
                Using cmd As New SqlCommand(queryMonthSales, con)
                    cmd.Parameters.AddWithValue("@fromDate", firstDayOfMonth)
                    cmd.Parameters.AddWithValue("@toDate", today)
                    Dim result = cmd.ExecuteScalar()
                    totalSalesMonth = If(IsDBNull(result), 0D, Convert.ToDecimal(result))
                End Using
            End Using

            ' --- Get expenses from ExpensesControl ---
            ' Make sure expensesControl is not Nothing
            If expensesControl IsNot Nothing Then
                todayExpenses = expensesControl.GetExpenseTotal(fromDate:=today)
                totalPaid = expensesControl.TotalPaid
                totalUnpaid = expensesControl.TotalUnpaid
                totalNext7Days = expensesControl.GetExpenseTotal(fromDate:=Date.Today, toDate:=Date.Today.AddDays(7))


            End If

            ' --- Compute net profit ---
            netProfit = todaySales - todayExpenses

            ' --- Update labels ---
            lblTotalSalesToday.Text = todaySales.ToString("₱#,##0.00")
            lblTotalItemsSold.Text = totalItemsSold.ToString()
            lblTodayExpenses.Text = todayExpenses.ToString("₱#,##0.00")
            lblTotalExpensesPaid.Text = totalPaid.ToString("₱#,##0.00")
            lblTotalExpensesUnpaid.Text = totalUnpaid.ToString("₱#,##0.00")
            lblUpcomingExpensesWeek.Text = totalNext7Days.ToString("₱#,##0.00")
            lblNetProfit.Text = netProfit.ToString("₱#,##0.00")
            lblTotalSalesMonth.Text = totalSalesMonth.ToString("₱#,##0.00")

            ' --- Refresh charts ---
            LoadDailySalesChart()
            LoadCategoryChart()

        Catch ex As Exception
            MessageBox.Show("Dashboard refresh failed: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        ' 7-day window including today
        Dim last7Days As New List(Of Date)()
        For i = 6 To 0 Step -1
            last7Days.Add(Date.Today.AddDays(-i))
        Next

        Dim salesLookup As New Dictionary(Of Date, Double)()

        ' Query sales totals for last 7 days
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()
                Dim query As String = "
            SELECT CAST(TransactionDate AS DATE) AS SaleDate,
                   SUM(TotalAmount) AS DailyTotal
            FROM Transactions
            WHERE TransactionDate >= DATEADD(day, -6, CAST(GETDATE() AS DATE))
            GROUP BY CAST(TransactionDate AS DATE)
            ORDER BY SaleDate;"

                Using cmd As New SqlCommand(query, con)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim saleDate As Date = Convert.ToDateTime(reader("SaleDate"))
                            Dim total As Double = If(IsDBNull(reader("DailyTotal")), 0, Convert.ToDouble(reader("DailyTotal")))
                            salesLookup(saleDate) = total
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading daily sales chart: " & ex.Message)
            Return
        End Try

        ' Prepare arrays for plotting
        Dim x As New List(Of Double)()
        Dim y As New List(Of Double)()

        For Each d As Date In last7Days
            x.Add(d.ToOADate())
            If salesLookup.ContainsKey(d) Then
                y.Add(salesLookup(d))
            Else
                y.Add(0) ' no sales
            End If
        Next

        ' Clear previous plot
        chartSales.Plot.Clear()

        ' Draw line chart
        Dim scatter = chartSales.Plot.Add.Scatter(x.ToArray(), y.ToArray())
        scatter.Color = Colors.SeaGreen
        scatter.LineWidth = 3


        chartSales.Plot.Title("Sales (Last 7 Days)")
        chartSales.Plot.XLabel("Date")
        chartSales.Plot.YLabel("₱")
        chartSales.Plot.Axes.DateTimeTicksBottom() ' format X axis as dates
        chartSales.Plot.Axes.Margins(0, 0)
        chartSales.Refresh()
    End Sub


    ' Requires: Imports ScottPlot
    Private Sub LoadCategoryChart()
        ' --- 1) Query data from DB ---
        Dim categoryNames As New List(Of String)()
        Dim categoryTotals As New List(Of Double)()

        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "
            SELECT ProductName, SUM(Quantity) AS TotalSold
            FROM TransactionItems
            GROUP BY ProductName
            ORDER BY ProductName;"

            Using cmd As New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        categoryNames.Add(reader("ProductName").ToString())
                        categoryTotals.Add(Convert.ToDouble(reader("TotalSold")))
                    End While
                End Using
            End Using
        End Using

        ' --- 2) Clear plot if no data ---
        chartCategory.Plot.Clear()
        If categoryNames.Count = 0 Then
            chartCategory.Refresh()
            Return
        End If

        ' --- 3) Create bars ---
        ' ScottPlot 5 bar positions are 0-based integers
        Dim values = categoryTotals.ToArray()
        chartCategory.Plot.Add.Bars(values)

        ' --- 4) Create tick positions & labels ---
        Dim tickPositions As Double() = Enumerable.Range(0, categoryNames.Count).Select(Function(i) CDbl(i)).ToArray()
        Dim tickLabels As String() = categoryNames.ToArray()

        ' Official ScottPlot 5 way to apply manual category ticks:
        chartCategory.Plot.Axes.Bottom.SetTicks(tickPositions, tickLabels)

        ' --- 5) Style ---
        chartCategory.Plot.Title("Sales by Category")
        chartCategory.Plot.YLabel("Total Items Sold")
        chartCategory.Plot.XLabel("Category")

        chartCategory.Plot.Axes.Margins(bottom:=0)
        chartCategory.Plot.HideGrid()
        chartCategory.UserInputProcessor.IsEnabled = False

        chartCategory.Refresh()
    End Sub








End Class
