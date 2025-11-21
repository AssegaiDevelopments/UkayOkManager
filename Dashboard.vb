'Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System

Public Class Dashboard

    ' Enable double buffering to reduce flickering
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000   ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    ' Make sure this is set BEFORE showing the form
    Public Property LoggedInUserId As String

    ' Other variables
    Dim clothingType, pname As String
    Dim quantity, discount As Integer
    Dim itemTotal, price, grandTotal As Decimal
    Dim tempStock As New Dictionary(Of String, Integer)
    Dim unselectedColor As Color = Color.FromArgb(23, 77, 113)
    Dim selectedColor As Color = Color.SeaGreen

    ' User controls
    Private stocksControl As New ManageStocksControl()
    Private transactionsControl As New ViewTransactionsControl()
    Private cartControl As New CartControl()
    Private expensesControl As New ExpensesControl()
    Private dashboardControl As New DashboardControl()
    Private accountsControl As New AccountsControl()

    ' --- Utility: show a panel and update sidebar ---
    Private Sub ShowPanel(panelToShow As Control)
        For Each btn As Button In flpSidebar.Controls.OfType(Of Button)()
            If btn.Tag IsNot Nothing AndAlso btn.Tag.ToString() = panelToShow.Name Then
                btn.BackColor = selectedColor
            Else
                btn.BackColor = unselectedColor
            End If
        Next

        ' Hide everything first
        For Each ctrl As Control In pnlMain.Controls
            ctrl.Visible = False
        Next

        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    ' --- Initialize dashboard after setting user ID ---
    Public Sub InitializeDashboard(userId As String)
        Me.LoggedInUserId = userId

        ' Add user controls to main panel (if not already added)
        If Not pnlMain.Controls.Contains(stocksControl) Then
            pnlMain.Controls.Add(stocksControl)
            pnlMain.Controls.Add(transactionsControl)
            pnlMain.Controls.Add(cartControl)
            pnlMain.Controls.Add(expensesControl)
            pnlMain.Controls.Add(dashboardControl)
            pnlMain.Controls.Add(accountsControl)

            ' Dock controls
            stocksControl.Dock = DockStyle.Fill
            transactionsControl.Dock = DockStyle.Fill
            cartControl.Dock = DockStyle.Fill
            expensesControl.Dock = DockStyle.Fill
            dashboardControl.Dock = DockStyle.Fill
            accountsControl.Dock = DockStyle.Fill
        End If

        ' Pass user ID to all controls that need it
        stocksControl.LoggedInUserId = userId
        expensesControl.LoggedInUserId = userId
        accountsControl.LoggedInUserId = userId
        ' Other controls can use LoggedInUserId internally as needed

        ' Subscribe to expense updates
        AddHandler expensesControl.ExpensesUpdated, AddressOf dashboardControl.RefreshDashboard

        ' Show the default panel
        btnDashboardControl.PerformClick()
    End Sub


    ' --- Sidebar button events ---
    Private Sub btnManageStocks_Click(sender As Object, e As EventArgs) Handles btnManageStocks.Click
        ShowPanel(stocksControl)
        stocksControl.InitializeStocks()
    End Sub

    Private Sub btnViewTransaction_Click(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        ShowPanel(transactionsControl)
        transactionsControl.InitializeTransactions()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        ShowPanel(cartControl)
        cartControl.InitializeCart()
    End Sub

    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        ShowPanel(expensesControl)
        expensesControl.InitializeExpenses()
    End Sub

    Private Sub btnDashboardControl_Click(sender As Object, e As EventArgs) Handles btnDashboardControl.Click
        ShowPanel(dashboardControl)
        dashboardControl.InitializeDashboard()
    End Sub

    Private Sub btnManageAccounts_Click(sender As Object, e As EventArgs) Handles btnManageAccounts.Click
        ShowPanel(accountsControl)
    End Sub

    ' --- Logout / Exit ---
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Close()
        Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class
