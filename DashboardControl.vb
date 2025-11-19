Imports Microsoft.Data.SqlClient
Imports ScottPlot

Public Class DashboardControl

    Dim days = New Double() {1, 2, 3, 4, 5}
    Dim sales = New Double() {850, 1200, 950, 1800, 2000}

    Dim values = New Double() {850, 1200, 950, 1800, 2000}

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDashboard()
    End Sub

    Public Sub InitializeDashboard()
        chartExpenses.Plot.Clear()
        chartExpenses.Plot.Add.Scatter(days, sales)
        chartExpenses.Plot.Title("Daily Sales")
        chartExpenses.Plot.XLabel("Day")
        chartExpenses.Plot.YLabel("Sales (₱)")
        chartExpenses.Refresh()

        chartSales.Plot.Clear()
        chartSales.Plot.Add.Bars(values)
        chartSales.Plot.Title("Sales Overview")
        chartSales.Plot.Axes.Margins(0, 0)
        chartSales.Refresh()
    End Sub

End Class
