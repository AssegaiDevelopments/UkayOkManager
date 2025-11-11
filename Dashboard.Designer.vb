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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnExit = New Button()
        Button1 = New Button()
        btnMinimize = New Button()
        Label5 = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        btnManageStocks = New Button()
        btnViewTransaction = New Button()
        Label6 = New Label()
        pnlCart = New Panel()
        Label8 = New Label()
        txtbRemarks = New TextBox()
        Label7 = New Label()
        btnCheckout = New Button()
        lblStock = New Label()
        btnClearCart = New Button()
        Panel2 = New Panel()
        lGrandTotal = New Label()
        Label1 = New Label()
        lDiscount = New Label()
        tbDiscount = New TrackBar()
        chbxDiscount = New CheckBox()
        Label4 = New Label()
        txtbItemPrice = New TextBox()
        dgvCart = New DataGridView()
        Label3 = New Label()
        nudQuantity = New NumericUpDown()
        Label2 = New Label()
        cbClothingType = New ComboBox()
        btnAddItemToCart = New Button()
        btnRemoveItemFromCart = New Button()
        pnlSidebar = New Panel()
        PictureBox1 = New PictureBox()
        pnlMain = New Panel()
        pnlTransactions = New Panel()
        pnlManageStocks = New Panel()
        pnlNav = New Panel()
        pnlCart.SuspendLayout()
        Panel2.SuspendLayout()
        CType(tbDiscount, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlNav.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(1097, 9)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(26, 26)
        btnExit.TabIndex = 16
        btnExit.Text = "✖"
        btnExit.UseMnemonic = False
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Unispace", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1242, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 26)
        Button1.TabIndex = 16
        Button1.Text = "✖"
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.White
        btnMinimize.Location = New Point(1065, 8)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(26, 27)
        btnMinimize.TabIndex = 17
        btnMinimize.Text = "—"
        btnMinimize.TextAlign = ContentAlignment.BottomCenter
        btnMinimize.UseMnemonic = False
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label5.Location = New Point(-171, 677)
        Label5.Name = "Label5"
        Label5.Size = New Size(1967, 15)
        Label5.TabIndex = 21
        Label5.Text = resources.GetString("Label5.Text")
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' btnManageStocks
        ' 
        btnManageStocks.Anchor = AnchorStyles.Left
        btnManageStocks.BackColor = Color.SeaGreen
        btnManageStocks.Cursor = Cursors.Hand
        btnManageStocks.FlatAppearance.BorderSize = 0
        btnManageStocks.FlatStyle = FlatStyle.Flat
        btnManageStocks.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnManageStocks.ForeColor = Color.White
        btnManageStocks.Location = New Point(0, 102)
        btnManageStocks.Name = "btnManageStocks"
        btnManageStocks.Size = New Size(145, 61)
        btnManageStocks.TabIndex = 0
        btnManageStocks.Text = "📦" & vbCrLf & "Manage Stocks"
        btnManageStocks.UseVisualStyleBackColor = False
        ' 
        ' btnViewTransaction
        ' 
        btnViewTransaction.Anchor = AnchorStyles.Left
        btnViewTransaction.BackColor = Color.DodgerBlue
        btnViewTransaction.Cursor = Cursors.Hand
        btnViewTransaction.FlatAppearance.BorderSize = 0
        btnViewTransaction.FlatStyle = FlatStyle.Flat
        btnViewTransaction.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewTransaction.ForeColor = Color.White
        btnViewTransaction.Location = New Point(0, 169)
        btnViewTransaction.Name = "btnViewTransaction"
        btnViewTransaction.Size = New Size(145, 61)
        btnViewTransaction.TabIndex = 26
        btnViewTransaction.Text = "📠" & vbCrLf & "View Transaction Logs"
        btnViewTransaction.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Miriam Libre", 24F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(23, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(289, 42)
        Label6.TabIndex = 24
        Label6.Text = "Admin Dashboard"
        ' 
        ' pnlCart
        ' 
        pnlCart.BackColor = Color.Transparent
        pnlCart.Controls.Add(Label8)
        pnlCart.Controls.Add(txtbRemarks)
        pnlCart.Controls.Add(Label7)
        pnlCart.Controls.Add(btnCheckout)
        pnlCart.Controls.Add(lblStock)
        pnlCart.Controls.Add(btnClearCart)
        pnlCart.Controls.Add(Panel2)
        pnlCart.Controls.Add(lDiscount)
        pnlCart.Controls.Add(tbDiscount)
        pnlCart.Controls.Add(chbxDiscount)
        pnlCart.Controls.Add(Label4)
        pnlCart.Controls.Add(txtbItemPrice)
        pnlCart.Controls.Add(dgvCart)
        pnlCart.Controls.Add(Label3)
        pnlCart.Controls.Add(nudQuantity)
        pnlCart.Controls.Add(Label2)
        pnlCart.Controls.Add(cbClothingType)
        pnlCart.Controls.Add(btnAddItemToCart)
        pnlCart.Controls.Add(btnRemoveItemFromCart)
        pnlCart.Dock = DockStyle.Fill
        pnlCart.Location = New Point(0, 0)
        pnlCart.Name = "pnlCart"
        pnlCart.Size = New Size(1135, 720)
        pnlCart.TabIndex = 29
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label8.Location = New Point(566, 648)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 46
        Label8.Text = "Remarks:"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtbRemarks
        ' 
        txtbRemarks.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtbRemarks.Location = New Point(566, 666)
        txtbRemarks.Name = "txtbRemarks"
        txtbRemarks.Size = New Size(262, 23)
        txtbRemarks.TabIndex = 45
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Miriam Libre", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(1033, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 35)
        Label7.TabIndex = 44
        Label7.Text = "Cart"
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCheckout.BackColor = Color.Transparent
        btnCheckout.Cursor = Cursors.Hand
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.ForeColor = Color.Gold
        btnCheckout.Location = New Point(890, 603)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(109, 60)
        btnCheckout.TabIndex = 43
        btnCheckout.Text = "Proceed to Checkout →"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' lblStock
        ' 
        lblStock.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblStock.BackColor = Color.Transparent
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(550, 607)
        lblStock.Name = "lblStock"
        lblStock.RightToLeft = RightToLeft.No
        lblStock.Size = New Size(161, 15)
        lblStock.TabIndex = 42
        lblStock.Text = "0"
        lblStock.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnClearCart
        ' 
        btnClearCart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClearCart.BackColor = Color.Transparent
        btnClearCart.Cursor = Cursors.Hand
        btnClearCart.FlatStyle = FlatStyle.Flat
        btnClearCart.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnClearCart.Location = New Point(890, 315)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(92, 43)
        btnClearCart.TabIndex = 41
        btnClearCart.Text = "Clear Cart" & vbCrLf & ChrW(55357) & ChrW(57042)
        btnClearCart.TextAlign = ContentAlignment.TopCenter
        btnClearCart.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(244), CByte(208), CByte(62))
        Panel2.Controls.Add(lGrandTotal)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(890, 523)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(109, 69)
        Panel2.TabIndex = 40
        ' 
        ' lGrandTotal
        ' 
        lGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lGrandTotal.AutoSize = True
        lGrandTotal.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lGrandTotal.Location = New Point(21, 29)
        lGrandTotal.Name = "lGrandTotal"
        lGrandTotal.Size = New Size(48, 18)
        lGrandTotal.TabIndex = 5
        lGrandTotal.Text = "₱0.00"
        lGrandTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 4
        Label1.Text = "Total"
        ' 
        ' lDiscount
        ' 
        lDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lDiscount.AutoSize = True
        lDiscount.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lDiscount.Enabled = False
        lDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        lDiscount.Location = New Point(276, 653)
        lDiscount.Name = "lDiscount"
        lDiscount.Size = New Size(76, 15)
        lDiscount.TabIndex = 39
        lDiscount.Text = "Discount: 0%"
        ' 
        ' tbDiscount
        ' 
        tbDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        tbDiscount.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        tbDiscount.Cursor = Cursors.NoMoveHoriz
        tbDiscount.Enabled = False
        tbDiscount.Location = New Point(257, 630)
        tbDiscount.Maximum = 80
        tbDiscount.Name = "tbDiscount"
        tbDiscount.Size = New Size(116, 45)
        tbDiscount.TabIndex = 38
        tbDiscount.TickStyle = TickStyle.None
        tbDiscount.Value = 1
        ' 
        ' chbxDiscount
        ' 
        chbxDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        chbxDiscount.AutoSize = True
        chbxDiscount.BackColor = Color.Transparent
        chbxDiscount.Cursor = Cursors.Hand
        chbxDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chbxDiscount.Location = New Point(257, 606)
        chbxDiscount.Name = "chbxDiscount"
        chbxDiscount.Size = New Size(116, 19)
        chbxDiscount.TabIndex = 37
        chbxDiscount.Text = "Enable Discount?"
        chbxDiscount.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label4.Location = New Point(381, 635)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 36
        Label4.Text = "Price:"
        ' 
        ' txtbItemPrice
        ' 
        txtbItemPrice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtbItemPrice.Location = New Point(423, 632)
        txtbItemPrice.MaxLength = 7
        txtbItemPrice.Name = "txtbItemPrice"
        txtbItemPrice.Size = New Size(121, 23)
        txtbItemPrice.TabIndex = 35
        txtbItemPrice.Text = "79.00"
        ' 
        ' dgvCart
        ' 
        dgvCart.AllowUserToAddRows = False
        dgvCart.Anchor = AnchorStyles.Right
        dgvCart.BackgroundColor = Color.White
        dgvCart.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.MediumTurquoise
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCart.GridColor = Color.White
        dgvCart.Location = New Point(71, 72)
        dgvCart.Name = "dgvCart"
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(813, 472)
        dgvCart.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label3.Location = New Point(451, 666)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 33
        Label3.Text = "Quantity:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        nudQuantity.Location = New Point(507, 661)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(37, 23)
        nudQuantity.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label2.Location = New Point(383, 609)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 31
        Label2.Text = "Type:"
        ' 
        ' cbClothingType
        ' 
        cbClothingType.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cbClothingType.BackColor = Color.White
        cbClothingType.DropDownStyle = ComboBoxStyle.DropDownList
        cbClothingType.Location = New Point(423, 604)
        cbClothingType.Name = "cbClothingType"
        cbClothingType.Size = New Size(121, 23)
        cbClothingType.TabIndex = 30
        ' 
        ' btnAddItemToCart
        ' 
        btnAddItemToCart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddItemToCart.BackColor = Color.Transparent
        btnAddItemToCart.Cursor = Cursors.Hand
        btnAddItemToCart.FlatStyle = FlatStyle.Flat
        btnAddItemToCart.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnAddItemToCart.Location = New Point(753, 607)
        btnAddItemToCart.Name = "btnAddItemToCart"
        btnAddItemToCart.Size = New Size(75, 43)
        btnAddItemToCart.TabIndex = 29
        btnAddItemToCart.Text = "Add Item" & vbCrLf & "+" & ChrW(55357) & ChrW(57042)
        btnAddItemToCart.TextAlign = ContentAlignment.TopCenter
        btnAddItemToCart.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveItemFromCart
        ' 
        btnRemoveItemFromCart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRemoveItemFromCart.BackColor = Color.Transparent
        btnRemoveItemFromCart.Cursor = Cursors.Hand
        btnRemoveItemFromCart.FlatStyle = FlatStyle.Flat
        btnRemoveItemFromCart.ForeColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRemoveItemFromCart.Location = New Point(890, 266)
        btnRemoveItemFromCart.Name = "btnRemoveItemFromCart"
        btnRemoveItemFromCart.Size = New Size(92, 43)
        btnRemoveItemFromCart.TabIndex = 28
        btnRemoveItemFromCart.Text = "Remove Item" & vbCrLf & "-" & ChrW(55357) & ChrW(57042)
        btnRemoveItemFromCart.TextAlign = ContentAlignment.TopCenter
        btnRemoveItemFromCart.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Controls.Add(btnManageStocks)
        pnlSidebar.Controls.Add(btnViewTransaction)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(145, 720)
        pnlSidebar.TabIndex = 47
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
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(pnlManageStocks)
        pnlMain.Controls.Add(pnlCart)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(145, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1135, 720)
        pnlMain.TabIndex = 47
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.Dock = DockStyle.Fill
        pnlTransactions.Location = New Point(0, 0)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Size = New Size(1135, 720)
        pnlTransactions.TabIndex = 0
        ' 
        ' pnlManageStocks
        ' 
        pnlManageStocks.Dock = DockStyle.Fill
        pnlManageStocks.Location = New Point(0, 0)
        pnlManageStocks.Name = "pnlManageStocks"
        pnlManageStocks.Size = New Size(1135, 720)
        pnlManageStocks.TabIndex = 0
        ' 
        ' pnlNav
        ' 
        pnlNav.Controls.Add(btnMinimize)
        pnlNav.Controls.Add(btnExit)
        pnlNav.Dock = DockStyle.Top
        pnlNav.Location = New Point(145, 0)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(1135, 38)
        pnlNav.TabIndex = 28
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(69), CByte(88), CByte(113))
        BackgroundImage = My.Resources.Resources.bg11
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(pnlNav)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UkayOk Cart"
        WindowState = FormWindowState.Maximized
        pnlCart.ResumeLayout(False)
        pnlCart.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(tbDiscount, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlNav.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents btnManageStocks As Button
    Friend WithEvents btnViewTransaction As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlCart As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbRemarks As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblStock As Label
    Friend WithEvents btnClearCart As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lGrandTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lDiscount As Label
    Friend WithEvents tbDiscount As TrackBar
    Friend WithEvents chbxDiscount As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbItemPrice As TextBox
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents cbClothingType As ComboBox
    Friend WithEvents btnAddItemToCart As Button
    Friend WithEvents btnRemoveItemFromCart As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents pnlManageStocks As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlNav As Panel
End Class
