Imports Microsoft.Data.SqlClient
Imports ScottPlot

Public Class DashboardControl

    Dim days = New Double() {1, 2, 3, 4, 5}
    Dim sales = New Double() {850, 1200, 950, 1800, 2000}

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
    End Sub

End Class
