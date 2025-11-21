<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        pnlNav = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnExit = New Button()
        btnMinimize = New Button()
        btnLogOut = New Button()
        PictureBox1 = New PictureBox()
        btnCart = New Button()
        btnViewTransaction = New Button()
        pnlSidebar = New Panel()
        flpSidebar = New FlowLayoutPanel()
        btnDashboardControl = New Button()
        btnManageStocks = New Button()
        btnExpenses = New Button()
        btnManageAccounts = New Button()
        pnlMain = New Panel()
        pnlDashboard = New Panel()
        pnlExpenses = New Panel()
        pnlCart = New Panel()
        pnlTransactions = New Panel()
        pnlManageStocks = New Panel()
        SqlCommand2 = New Microsoft.Data.SqlClient.SqlCommand()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        BufferedPanel1 = New BufferedPanel()
        pnlNav.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        flpSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.Transparent
        pnlNav.Controls.Add(FlowLayoutPanel1)
        pnlNav.Dock = DockStyle.Top
        pnlNav.Location = New Point(145, 0)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(1135, 38)
        pnlNav.TabIndex = 48
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(btnExit)
        FlowLayoutPanel1.Controls.Add(btnMinimize)
        FlowLayoutPanel1.Controls.Add(btnLogOut)
        FlowLayoutPanel1.Dock = DockStyle.Right
        FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New Point(1038, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(97, 38)
        FlowLayoutPanel1.TabIndex = 18
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(68, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(26, 26)
        btnExit.TabIndex = 16
        btnExit.Text = "✖"
        btnExit.UseMnemonic = False
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.White
        btnMinimize.Location = New Point(36, 3)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(26, 27)
        btnMinimize.TabIndex = 17
        btnMinimize.Text = "—"
        btnMinimize.TextAlign = ContentAlignment.BottomCenter
        btnMinimize.UseMnemonic = False
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.BackColor = Color.Transparent
        btnLogOut.Cursor = Cursors.Hand
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.ImageAlign = ContentAlignment.TopCenter
        btnLogOut.Location = New Point(6, 3)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(24, 35)
        btnLogOut.TabIndex = 19
        btnLogOut.Text = "🔑"
        btnLogOut.TextAlign = ContentAlignment.TopCenter
        btnLogOut.UseMnemonic = False
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.mainicon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(23, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' btnCart
        ' 
        btnCart.Anchor = AnchorStyles.Left
        btnCart.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        btnCart.Cursor = Cursors.Hand
        btnCart.FlatAppearance.BorderSize = 0
        btnCart.FlatStyle = FlatStyle.Flat
        btnCart.Font = New Font("Segoe UI Emoji", 9.75F)
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(0, 42)
        btnCart.Margin = New Padding(0)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(145, 42)
        btnCart.TabIndex = 28
        btnCart.Tag = "CartControl"
        btnCart.Text = ChrW(55357) & ChrW(57042) & " Cart"
        btnCart.TextAlign = ContentAlignment.MiddleLeft
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnViewTransaction
        ' 
        btnViewTransaction.Anchor = AnchorStyles.Left
        btnViewTransaction.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        btnViewTransaction.Cursor = Cursors.Hand
        btnViewTransaction.FlatAppearance.BorderSize = 0
        btnViewTransaction.FlatStyle = FlatStyle.Flat
        btnViewTransaction.Font = New Font("Segoe UI Emoji", 9.75F)
        btnViewTransaction.ForeColor = Color.White
        btnViewTransaction.Location = New Point(0, 84)
        btnViewTransaction.Margin = New Padding(0)
        btnViewTransaction.Name = "btnViewTransaction"
        btnViewTransaction.Size = New Size(145, 42)
        btnViewTransaction.TabIndex = 26
        btnViewTransaction.Tag = "ViewTransactionsControl"
        btnViewTransaction.Text = "📠 Transaction Logs"
        btnViewTransaction.TextAlign = ContentAlignment.MiddleLeft
        btnViewTransaction.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        pnlSidebar.Controls.Add(flpSidebar)
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(145, 720)
        pnlSidebar.TabIndex = 50
        ' 
        ' flpSidebar
        ' 
        flpSidebar.Controls.Add(btnDashboardControl)
        flpSidebar.Controls.Add(btnCart)
        flpSidebar.Controls.Add(btnViewTransaction)
        flpSidebar.Controls.Add(btnManageStocks)
        flpSidebar.Controls.Add(btnExpenses)
        flpSidebar.Controls.Add(btnManageAccounts)
        flpSidebar.Dock = DockStyle.Bottom
        flpSidebar.Location = New Point(0, 68)
        flpSidebar.Name = "flpSidebar"
        flpSidebar.Size = New Size(145, 652)
        flpSidebar.TabIndex = 29
        ' 
        ' btnDashboardControl
        ' 
        btnDashboardControl.Anchor = AnchorStyles.Left
        btnDashboardControl.BackColor = Color.SeaGreen
        btnDashboardControl.Cursor = Cursors.Hand
        btnDashboardControl.FlatAppearance.BorderSize = 0
        btnDashboardControl.FlatStyle = FlatStyle.Flat
        btnDashboardControl.Font = New Font("Segoe UI Emoji", 9.75F)
        btnDashboardControl.ForeColor = Color.White
        btnDashboardControl.Location = New Point(0, 0)
        btnDashboardControl.Margin = New Padding(0)
        btnDashboardControl.Name = "btnDashboardControl"
        btnDashboardControl.Size = New Size(145, 42)
        btnDashboardControl.TabIndex = 30
        btnDashboardControl.Tag = "DashboardControl"
        btnDashboardControl.Text = "📈 Dashboard"
        btnDashboardControl.TextAlign = ContentAlignment.MiddleLeft
        btnDashboardControl.UseVisualStyleBackColor = False
        ' 
        ' btnManageStocks
        ' 
        btnManageStocks.Anchor = AnchorStyles.Left
        btnManageStocks.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        btnManageStocks.Cursor = Cursors.Hand
        btnManageStocks.FlatAppearance.BorderSize = 0
        btnManageStocks.FlatStyle = FlatStyle.Flat
        btnManageStocks.Font = New Font("Segoe UI Emoji", 9.75F)
        btnManageStocks.ForeColor = Color.White
        btnManageStocks.Location = New Point(0, 126)
        btnManageStocks.Margin = New Padding(0)
        btnManageStocks.Name = "btnManageStocks"
        btnManageStocks.Size = New Size(145, 42)
        btnManageStocks.TabIndex = 0
        btnManageStocks.Tag = "ManageStocksControl"
        btnManageStocks.Text = "📦 Manage Stocks"
        btnManageStocks.TextAlign = ContentAlignment.MiddleLeft
        btnManageStocks.UseVisualStyleBackColor = False
        ' 
        ' btnExpenses
        ' 
        btnExpenses.Anchor = AnchorStyles.Left
        btnExpenses.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        btnExpenses.Cursor = Cursors.Hand
        btnExpenses.FlatAppearance.BorderSize = 0
        btnExpenses.FlatStyle = FlatStyle.Flat
        btnExpenses.Font = New Font("Segoe UI Emoji", 9.75F)
        btnExpenses.ForeColor = Color.White
        btnExpenses.Location = New Point(0, 168)
        btnExpenses.Margin = New Padding(0)
        btnExpenses.Name = "btnExpenses"
        btnExpenses.Size = New Size(145, 42)
        btnExpenses.TabIndex = 29
        btnExpenses.Tag = "ExpensesControl"
        btnExpenses.Text = "💱 Expenses"
        btnExpenses.TextAlign = ContentAlignment.MiddleLeft
        btnExpenses.UseVisualStyleBackColor = False
        ' 
        ' btnManageAccounts
        ' 
        btnManageAccounts.Anchor = AnchorStyles.Left
        btnManageAccounts.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        btnManageAccounts.Cursor = Cursors.Hand
        btnManageAccounts.FlatAppearance.BorderSize = 0
        btnManageAccounts.FlatStyle = FlatStyle.Flat
        btnManageAccounts.Font = New Font("Segoe UI Emoji", 9.75F)
        btnManageAccounts.ForeColor = Color.White
        btnManageAccounts.Location = New Point(0, 210)
        btnManageAccounts.Margin = New Padding(0)
        btnManageAccounts.Name = "btnManageAccounts"
        btnManageAccounts.Size = New Size(145, 42)
        btnManageAccounts.TabIndex = 31
        btnManageAccounts.Tag = "AccountsControl"
        btnManageAccounts.Text = "👤 Manage Accounts"
        btnManageAccounts.TextAlign = ContentAlignment.MiddleLeft
        btnManageAccounts.UseVisualStyleBackColor = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.Transparent
        pnlMain.Controls.Add(pnlDashboard)
        pnlMain.Controls.Add(pnlExpenses)
        pnlMain.Controls.Add(pnlCart)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(pnlManageStocks)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(145, 38)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1135, 682)
        pnlMain.TabIndex = 49
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.Location = New Point(0, 0)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(1135, 682)
        pnlDashboard.TabIndex = 0
        ' 
        ' pnlExpenses
        ' 
        pnlExpenses.Dock = DockStyle.Fill
        pnlExpenses.Location = New Point(0, 0)
        pnlExpenses.Name = "pnlExpenses"
        pnlExpenses.Size = New Size(1135, 682)
        pnlExpenses.TabIndex = 0
        ' 
        ' pnlCart
        ' 
        pnlCart.BackColor = Color.Transparent
        pnlCart.Dock = DockStyle.Fill
        pnlCart.Location = New Point(0, 0)
        pnlCart.Name = "pnlCart"
        pnlCart.Size = New Size(1135, 682)
        pnlCart.TabIndex = 29
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.BackColor = Color.Transparent
        pnlTransactions.Dock = DockStyle.Fill
        pnlTransactions.Location = New Point(0, 0)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Size = New Size(1135, 682)
        pnlTransactions.TabIndex = 0
        ' 
        ' pnlManageStocks
        ' 
        pnlManageStocks.BackColor = Color.Transparent
        pnlManageStocks.Dock = DockStyle.Fill
        pnlManageStocks.Location = New Point(0, 0)
        pnlManageStocks.Name = "pnlManageStocks"
        pnlManageStocks.Size = New Size(1135, 682)
        pnlManageStocks.TabIndex = 0
        ' 
        ' SqlCommand2
        ' 
        SqlCommand2.CommandTimeout = 30
        SqlCommand2.EnableOptimizedParameterBinding = False
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.BackColor = Color.Transparent
        BufferedPanel1.Dock = DockStyle.Fill
        BufferedPanel1.Location = New Point(0, 0)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Size = New Size(1280, 720)
        BufferedPanel1.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.bg11
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(pnlMain)
        Controls.Add(pnlNav)
        Controls.Add(pnlSidebar)
        Controls.Add(BufferedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UkayOk Cart"
        WindowState = FormWindowState.Maximized
        pnlNav.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        flpSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlNav As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCart As Button
    Friend WithEvents btnViewTransaction As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents flpSidebar As FlowLayoutPanel
    Friend WithEvents btnManageStocks As Button
    Friend WithEvents btnExpenses As Button
    Friend WithEvents btnDashboardControl As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlExpenses As Panel
    Friend WithEvents pnlCart As Panel
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents pnlManageStocks As Panel
    Friend WithEvents SqlCommand2 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents BufferedPanel1 As BufferedPanel
    Friend WithEvents btnManageAccounts As Button
    Friend WithEvents btnLogOut As Button
End Class
