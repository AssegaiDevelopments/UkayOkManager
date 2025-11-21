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

    Dim clothingType, pname As String
    Dim quantity, discount As Integer
    Dim itemTotal, price, grandTotal As Decimal
    Dim tempStock As New Dictionary(Of String, Integer)
    Dim unselectedColor As Color = Color.FromArgb(23, 77, 113)
    Dim selectedColor As Color = Color.SeaGreen

    Private stocksControl As New ManageStocksControl()
    Private transactionsControl As New ViewTransactionsControl()
    Private cartControl As New CartControl()
    Private expensesControl As New ExpensesControl()
    Private dashboardControl As New DashboardControl()
    Private accountsControl As New AccountsControl()

    Private Sub ShowPanel(panelToShow As Control)
        'pnlMain.SuspendLayout()

        ' Update sidebar button colors; use tag to match panel names
        For Each btn As Button In flpSidebar.Controls.OfType(Of Button)()
            If btn.Tag IsNot Nothing AndAlso btn.Tag.ToString() = panelToShow.Name Then
                btn.BackColor = selectedColor
            Else
                btn.BackColor = unselectedColor
            End If
        Next

        ' Hide everything inside pnlMain first
        For Each ctrl As Control In pnlMain.Controls
            ctrl.Visible = False
        Next

        ' Bring the selected panel/UserControl to front and show it
        panelToShow.Visible = True
        panelToShow.BringToFront()

        'pnlMain.ResumeLayout(False)
    End Sub

    'Change visible panel in pnlMain and update sidebar button colors
    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler expensesControl.ExpensesUpdated, AddressOf dashboardControl.RefreshDashboard

        'add UserControls to main panel to switch
        pnlMain.Controls.Add(stocksControl)
        pnlMain.Controls.Add(transactionsControl)
        pnlMain.Controls.Add(cartControl)
        pnlMain.Controls.Add(expensesControl)
        pnlMain.Controls.Add(dashboardControl)
        pnlMain.Controls.Add(accountsControl)

        stocksControl.Dock = DockStyle.Fill
        transactionsControl.Dock = DockStyle.Fill
        cartControl.Dock = DockStyle.Fill
        expensesControl.Dock = DockStyle.Fill
        dashboardControl.Dock = DockStyle.Fill
        accountsControl.Dock = DockStyle.Fill

        btnDashboardControl.PerformClick()
    End Sub
    'Minimize application
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Exit application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Close()
        Close()
    End Sub

    'Showpanel() buttons
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
End Class