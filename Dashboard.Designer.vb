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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlNav = New Panel()
        btnMinimize = New Button()
        btnExit = New Button()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        btnManageStocks = New Button()
        btnViewTransaction = New Button()
        pnlCart = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        GroupBox3 = New GroupBox()
        cbClothingType = New ComboBox()
        btnAddItemToCart = New Button()
        Label2 = New Label()
        nudQuantity = New NumericUpDown()
        Label3 = New Label()
        lblStock = New Label()
        txtbItemPrice = New TextBox()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        lDiscount = New Label()
        nudDiscount = New NumericUpDown()
        chbxDiscount = New CheckBox()
        GroupBox2 = New GroupBox()
        txtbRemarks = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        btnRemoveItemFromCart = New Button()
        btnCheckout = New Button()
        btnClearCart = New Button()
        Panel2 = New Panel()
        lGrandTotal = New Label()
        Label1 = New Label()
        dgvCart = New DataGridView()
        pnlSidebar = New Panel()
        btnCart = New Button()
        PictureBox1 = New PictureBox()
        pnlMain = New Panel()
        pnlTransactions = New Panel()
        pnlManageStocks = New Panel()
        pnlNav.SuspendLayout()
        pnlCart.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.Transparent
        pnlNav.Controls.Add(btnMinimize)
        pnlNav.Controls.Add(btnExit)
        pnlNav.Dock = DockStyle.Top
        pnlNav.Location = New Point(145, 0)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(1135, 38)
        pnlNav.TabIndex = 28
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
        btnManageStocks.Location = New Point(0, 146)
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
        btnViewTransaction.Location = New Point(0, 213)
        btnViewTransaction.Name = "btnViewTransaction"
        btnViewTransaction.Size = New Size(145, 61)
        btnViewTransaction.TabIndex = 26
        btnViewTransaction.Text = "📠" & vbCrLf & "View Transaction Logs"
        btnViewTransaction.UseVisualStyleBackColor = False
        ' 
        ' pnlCart
        ' 
        pnlCart.BackColor = Color.Transparent
        pnlCart.Controls.Add(FlowLayoutPanel1)
        pnlCart.Controls.Add(Label7)
        pnlCart.Controls.Add(btnRemoveItemFromCart)
        pnlCart.Controls.Add(btnCheckout)
        pnlCart.Controls.Add(btnClearCart)
        pnlCart.Controls.Add(Panel2)
        pnlCart.Controls.Add(dgvCart)
        pnlCart.Dock = DockStyle.Fill
        pnlCart.Location = New Point(0, 0)
        pnlCart.Name = "pnlCart"
        pnlCart.Size = New Size(1135, 682)
        pnlCart.TabIndex = 29
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Bottom
        FlowLayoutPanel1.Controls.Add(GroupBox3)
        FlowLayoutPanel1.Controls.Add(GroupBox1)
        FlowLayoutPanel1.Controls.Add(GroupBox2)
        FlowLayoutPanel1.Location = New Point(92, 542)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(825, 128)
        FlowLayoutPanel1.TabIndex = 51
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Bottom
        GroupBox3.Controls.Add(cbClothingType)
        GroupBox3.Controls.Add(btnAddItemToCart)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(nudQuantity)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(lblStock)
        GroupBox3.Controls.Add(txtbItemPrice)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(330, 108)
        GroupBox3.TabIndex = 50
        GroupBox3.TabStop = False
        GroupBox3.Text = "Add Items"
        ' 
        ' cbClothingType
        ' 
        cbClothingType.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cbClothingType.BackColor = Color.White
        cbClothingType.DropDownStyle = ComboBoxStyle.DropDownList
        cbClothingType.Location = New Point(54, 22)
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
        btnAddItemToCart.Location = New Point(249, 59)
        btnAddItemToCart.Name = "btnAddItemToCart"
        btnAddItemToCart.Size = New Size(75, 43)
        btnAddItemToCart.TabIndex = 29
        btnAddItemToCart.Text = "Add Item" & vbCrLf & "+" & ChrW(55357) & ChrW(57042)
        btnAddItemToCart.TextAlign = ContentAlignment.TopCenter
        btnAddItemToCart.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label2.Location = New Point(14, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 31
        Label2.Text = "Type:"
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        nudQuantity.Location = New Point(241, 22)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(37, 23)
        nudQuantity.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label3.Location = New Point(179, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 33
        Label3.Text = "Quantity:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblStock
        ' 
        lblStock.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblStock.BackColor = Color.Transparent
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(54, 76)
        lblStock.Name = "lblStock"
        lblStock.RightToLeft = RightToLeft.No
        lblStock.Size = New Size(121, 20)
        lblStock.TabIndex = 42
        lblStock.Text = "0"
        lblStock.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtbItemPrice
        ' 
        txtbItemPrice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtbItemPrice.Location = New Point(54, 50)
        txtbItemPrice.MaxLength = 7
        txtbItemPrice.Name = "txtbItemPrice"
        txtbItemPrice.Size = New Size(121, 23)
        txtbItemPrice.TabIndex = 35
        txtbItemPrice.Text = "79.00"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label4.Location = New Point(12, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 36
        Label4.Text = "Price:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom
        GroupBox1.Controls.Add(lDiscount)
        GroupBox1.Controls.Add(nudDiscount)
        GroupBox1.Controls.Add(chbxDiscount)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(339, 11)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(153, 100)
        GroupBox1.TabIndex = 48
        GroupBox1.TabStop = False
        GroupBox1.Text = "Discount"
        ' 
        ' lDiscount
        ' 
        lDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lDiscount.AutoSize = True
        lDiscount.BackColor = Color.Transparent
        lDiscount.Enabled = False
        lDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        lDiscount.Location = New Point(36, 71)
        lDiscount.Name = "lDiscount"
        lDiscount.Size = New Size(76, 15)
        lDiscount.TabIndex = 39
        lDiscount.Text = "Discount: 0%"
        ' 
        ' nudDiscount
        ' 
        nudDiscount.Anchor = AnchorStyles.Bottom
        nudDiscount.Enabled = False
        nudDiscount.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudDiscount.Location = New Point(39, 44)
        nudDiscount.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        nudDiscount.Name = "nudDiscount"
        nudDiscount.Size = New Size(70, 23)
        nudDiscount.TabIndex = 47
        ' 
        ' chbxDiscount
        ' 
        chbxDiscount.Anchor = AnchorStyles.Bottom
        chbxDiscount.AutoSize = True
        chbxDiscount.BackColor = Color.Transparent
        chbxDiscount.Cursor = Cursors.Hand
        chbxDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chbxDiscount.Location = New Point(17, 22)
        chbxDiscount.Name = "chbxDiscount"
        chbxDiscount.Size = New Size(116, 19)
        chbxDiscount.TabIndex = 37
        chbxDiscount.Text = "Enable Discount?"
        chbxDiscount.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom
        GroupBox2.Controls.Add(txtbRemarks)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(498, 47)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(317, 64)
        GroupBox2.TabIndex = 49
        GroupBox2.TabStop = False
        GroupBox2.Text = "Remarks"
        ' 
        ' txtbRemarks
        ' 
        txtbRemarks.Dock = DockStyle.Bottom
        txtbRemarks.Location = New Point(3, 38)
        txtbRemarks.Margin = New Padding(50, 0, 50, 0)
        txtbRemarks.Name = "txtbRemarks"
        txtbRemarks.Size = New Size(311, 23)
        txtbRemarks.TabIndex = 45
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Dock = DockStyle.Top
        Label8.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label8.Location = New Point(3, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 15)
        Label8.TabIndex = 46
        Label8.Text = "Add Remarks?"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(532, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 31)
        Label7.TabIndex = 44
        Label7.Text = "Cart"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRemoveItemFromCart
        ' 
        btnRemoveItemFromCart.Anchor = AnchorStyles.Right
        btnRemoveItemFromCart.BackColor = Color.Transparent
        btnRemoveItemFromCart.Cursor = Cursors.Hand
        btnRemoveItemFromCart.FlatStyle = FlatStyle.Flat
        btnRemoveItemFromCart.ForeColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRemoveItemFromCart.Location = New Point(965, 407)
        btnRemoveItemFromCart.Name = "btnRemoveItemFromCart"
        btnRemoveItemFromCart.Size = New Size(92, 43)
        btnRemoveItemFromCart.TabIndex = 28
        btnRemoveItemFromCart.Text = "Remove Item" & vbCrLf & "-" & ChrW(55357) & ChrW(57042)
        btnRemoveItemFromCart.TextAlign = ContentAlignment.TopCenter
        btnRemoveItemFromCart.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Anchor = AnchorStyles.Right
        btnCheckout.BackColor = Color.Transparent
        btnCheckout.Cursor = Cursors.Hand
        btnCheckout.FlatAppearance.BorderColor = Color.Gold
        btnCheckout.FlatAppearance.BorderSize = 3
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.ForeColor = Color.Gold
        btnCheckout.Location = New Point(973, 556)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(118, 97)
        btnCheckout.TabIndex = 43
        btnCheckout.Text = "Proceed to Checkout →"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' btnClearCart
        ' 
        btnClearCart.Anchor = AnchorStyles.Right
        btnClearCart.BackColor = Color.Transparent
        btnClearCart.Cursor = Cursors.Hand
        btnClearCart.FlatStyle = FlatStyle.Flat
        btnClearCart.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnClearCart.Location = New Point(965, 358)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(79, 43)
        btnClearCart.TabIndex = 41
        btnClearCart.Text = "Clear Cart" & vbCrLf & ChrW(55357) & ChrW(57042)
        btnClearCart.TextAlign = ContentAlignment.TopCenter
        btnClearCart.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(244), CByte(208), CByte(62))
        Panel2.Controls.Add(lGrandTotal)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(965, 456)
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
        ' dgvCart
        ' 
        dgvCart.AllowUserToAddRows = False
        dgvCart.Anchor = AnchorStyles.None
        dgvCart.BackgroundColor = Color.White
        dgvCart.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.MediumTurquoise
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCart.GridColor = Color.White
        dgvCart.Location = New Point(71, 53)
        dgvCart.Name = "dgvCart"
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(888, 472)
        dgvCart.TabIndex = 34
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(23), CByte(77), CByte(113))
        pnlSidebar.Controls.Add(btnCart)
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Controls.Add(btnManageStocks)
        pnlSidebar.Controls.Add(btnViewTransaction)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(145, 720)
        pnlSidebar.TabIndex = 47
        ' 
        ' btnCart
        ' 
        btnCart.Anchor = AnchorStyles.Left
        btnCart.BackColor = Color.Goldenrod
        btnCart.Cursor = Cursors.Hand
        btnCart.FlatAppearance.BorderSize = 0
        btnCart.FlatStyle = FlatStyle.Flat
        btnCart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(0, 79)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(145, 61)
        btnCart.TabIndex = 28
        btnCart.Text = ChrW(55357) & ChrW(57042) & vbCrLf & "Cart"
        btnCart.UseVisualStyleBackColor = False
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
        pnlMain.BackColor = Color.Transparent
        pnlMain.Controls.Add(pnlCart)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(pnlManageStocks)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(145, 38)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1135, 682)
        pnlMain.TabIndex = 47
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
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UkayOk Cart"
        WindowState = FormWindowState.Maximized
        pnlNav.ResumeLayout(False)
        pnlCart.ResumeLayout(False)
        pnlCart.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents btnManageStocks As Button
    Friend WithEvents btnViewTransaction As Button
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
    Friend WithEvents btnCart As Button
    Friend WithEvents nudDiscount As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
