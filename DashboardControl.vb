Imports Microsoft.Data.SqlClient
Imports ScottPlot
Imports ScottPlot.Interactivity

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
                Dim queryLastWeekNetProfit As String = "
                      SELECT SUM(TotalAmount) 
                      FROM Transactions 
                      WHERE CAST(TransactionDate AS DATE) BETWEEN @fromDate AND @toDate;"

                Using cmd As New SqlCommand(queryLastWeekNetProfit, con)
                    cmd.Parameters.AddWithValue("@fromDate", Date.Today.AddDays(-6)) ' last 7 days including today
                    cmd.Parameters.AddWithValue("@toDate", Date.Today)
                    Dim result = cmd.ExecuteScalar()
                    netProfitLastWeek = If(IsDBNull(result), 0D, Convert.ToDecimal(result))
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
            lblTotalSalesToday.Text = AppHelpers.FormatCurrency(todaySales)
            lblTotalItemsSold.Text = totalItemsSold.ToString() ' This is not money, so no formatting needed
            lblTodayExpenses.Text = AppHelpers.FormatCurrency(todayExpenses)
            lblTotalExpensesPaid.Text = AppHelpers.FormatCurrency(totalPaid)
            lblTotalExpensesUnpaid.Text = AppHelpers.FormatCurrency(totalUnpaid)
            lblUpcomingExpensesWeek.Text = AppHelpers.FormatCurrency(totalNext7Days)
            lblNetProfit.Text = AppHelpers.FormatCurrency(netProfit)
            lblTotalSalesMonth.Text = AppHelpers.FormatCurrency(totalSalesMonth)
            lblNetProfitLastWeek.Text = AppHelpers.FormatCurrency(netProfitLastWeek)


            ' --- Refresh charts ---
            LoadDailySalesChart()
            LoadCategoryChart()
            LoadHourlyHeatmap()


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
    'LoadHourlyHeatmap()
    Private Sub LoadHourlyHeatmap()
        Dim heatmapData(6, 23) As Double  ' 7 days × 24 hours

        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "
                SELECT 
                    CAST(TransactionDate AS DATE) AS SaleDate,
                    DATEPART(HOUR, TransactionDate) AS SaleHour,
                    SUM(TotalAmount) AS Total
                FROM Transactions
                WHERE TransactionDate >= DATEADD(day, -6, CAST(GETDATE() AS DATE))
                GROUP BY 
                    CAST(TransactionDate AS DATE),
                    DATEPART(HOUR, TransactionDate)
                ORDER BY SaleDate, SaleHour;
            "

                Using cmd As New SqlCommand(query, con)
                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            Dim saleDate As Date = CDate(rdr("SaleDate"))
                            Dim saleHour As Integer = CInt(rdr("SaleHour"))
                            Dim total As Double = CDbl(rdr("Total"))

                            Dim dayIndex As Integer = CInt((saleDate - Date.Today.AddDays(-6)).TotalDays)
                            If dayIndex >= 0 AndAlso dayIndex <= 6 Then
                                If saleHour >= 0 AndAlso saleHour <= 23 Then
                                    heatmapData(dayIndex, saleHour) = total
                                End If
                            End If
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating hourly heatmap: " & ex.Message)
            Return
        End Try


        ' --- DRAW HEATMAP ---
        chartHourly.Plot.Clear()

        Dim hm = chartHourly.Plot.Add.Heatmap(heatmapData)

        ' Gradient (ScottPlot built-in)
        hm.Colormap = New ScottPlot.Colormaps.Thermal()


        ' --- Labels ---
        chartHourly.Plot.Title("Hourly Sales Heatmap (Last 7 Days)")
        chartHourly.Plot.XLabel("Hour of Day")
        chartHourly.Plot.YLabel("Date")

        ' Hours 0–23
        Dim hours = Enumerable.Range(0, 24).Select(Function(h) h.ToString()).ToArray()
        chartHourly.Plot.Axes.Bottom.SetTicks(
        Enumerable.Range(0, 24).Select(Function(i) CDbl(i)).ToArray(),
        hours
    )

        ' Dates for past 7 days
        Dim dateLabels As New List(Of String)
        For i = 6 To 0 Step -1
            Dim d = Date.Today.AddDays(-i)
            dateLabels.Add(d.ToString("MMM dd"))
        Next

        chartHourly.Plot.Axes.Left.SetTicks(
        Enumerable.Range(0, 7).Select(Function(i) CDbl(i)).ToArray(),
        dateLabels.ToArray()
    )

        chartHourly.Plot.HideGrid()
        chartHourly.Plot.Axes.Margins(0, 0)
        chartHourly.UserInputProcessor.IsEnabled = False
        chartHourly.Refresh()
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
        chartSales.Plot.YLabel(AppSettings.CurrentCurrency)
        chartSales.Plot.Axes.DateTimeTicksBottom() ' format X axis as dates
        chartSales.Plot.Axes.Margins(0, 0)
        chartSales.UserInputProcessor.IsEnabled = False
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

    Private Sub LoadTopProductsChart()
        Dim topProducts As New List(Of String)()
        Dim topTotals As New List(Of Double)()

        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim query As String = "
        SELECT TOP 5 ProductName, SUM(Quantity) AS TotalSold
        FROM TransactionItems
        GROUP BY ProductName
        ORDER BY TotalSold DESC;"

            Using cmd As New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        topProducts.Add(reader("ProductName").ToString())
                        topTotals.Add(Convert.ToDouble(reader("TotalSold")))
                    End While
                End Using
            End Using
        End Using

        chartHourly.Plot.Clear()

        If topProducts.Count = 0 Then
            chartHourly.Refresh()
            Return
        End If

        ' ScottPlot horizontal bars use BarH()
        Dim values = topTotals.ToArray()
        Dim positions = Enumerable.Range(0, topProducts.Count).Select(Function(i) CDbl(i)).ToArray()
        Dim hbar = chartHourly.Plot.Add.Bars(values, positions)
        hbar.Horizontal = True
        ' Set labels for each bar
        chartHourly.Plot.Axes.Left.SetTicks(positions, topProducts.ToArray())

        ' Style
        chartHourly.Plot.Title("Top 5 Products Sold")
        chartHourly.Plot.XLabel("Quantity Sold")
        chartHourly.Plot.YLabel("Product")
        chartHourly.Plot.Axes.Margins(left:=0.15) ' leave space for product names
        chartHourly.Refresh()

    End Sub

End Class
