<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        BufferedPanel1 = New BufferedPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label7 = New Label()
        lDiscount = New Label()
        RoundedPanel1 = New RoundedPanel()
        Label1 = New Label()
        lGrandTotal = New Label()
        GroupBox3 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnAddItemToCart = New Button()
        btnClearCart = New Button()
        btnRemoveItemFromCart = New Button()
        cbClothingType = New ComboBox()
        GroupBox1 = New GroupBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        BufferedPanel4 = New BufferedPanel()
        BufferedPanel5 = New BufferedPanel()
        Label9 = New Label()
        Label6 = New Label()
        nudXQuantity = New NumericUpDown()
        nudYPrice = New NumericUpDown()
        chbxBuyXForYEnabled = New CheckBox()
        Label5 = New Label()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown1 = New NumericUpDown()
        CheckBox1 = New CheckBox()
        BufferedPanel3 = New BufferedPanel()
        Label10 = New Label()
        nudGlobalPrice = New NumericUpDown()
        chkGlobalPriceEnabled = New CheckBox()
        BufferedPanel2 = New BufferedPanel()
        chbxDiscount = New CheckBox()
        nudDiscount = New NumericUpDown()
        GroupBox2 = New GroupBox()
        txtbRemarks = New TextBox()
        Label8 = New Label()
        Label2 = New Label()
        nudQuantity = New NumericUpDown()
        Label3 = New Label()
        lblStock = New Label()
        txtbItemPrice = New TextBox()
        Label4 = New Label()
        dgvCart = New DataGridView()
        btnCheckout = New Button()
        BufferedPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        BufferedPanel4.SuspendLayout()
        BufferedPanel5.SuspendLayout()
        CType(nudXQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudYPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        BufferedPanel3.SuspendLayout()
        CType(nudGlobalPrice, ComponentModel.ISupportInitialize).BeginInit()
        BufferedPanel2.SuspendLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.Controls.Add(TableLayoutPanel3)
        BufferedPanel1.Controls.Add(GroupBox3)
        BufferedPanel1.Controls.Add(dgvCart)
        BufferedPanel1.Controls.Add(btnCheckout)
        BufferedPanel1.Dock = DockStyle.Fill
        BufferedPanel1.Location = New Point(0, 0)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Size = New Size(1135, 682)
        BufferedPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.0769253F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.6607933F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26.3436127F))
        TableLayoutPanel3.Controls.Add(Label7, 0, 0)
        TableLayoutPanel3.Controls.Add(lDiscount, 2, 0)
        TableLayoutPanel3.Controls.Add(RoundedPanel1, 3, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1135, 100)
        TableLayoutPanel3.TabIndex = 66
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(89, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 100)
        Label7.TabIndex = 64
        Label7.Text = "Cart"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lDiscount
        ' 
        lDiscount.Anchor = AnchorStyles.Bottom
        lDiscount.AutoSize = True
        lDiscount.BackColor = Color.Transparent
        lDiscount.Enabled = False
        lDiscount.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lDiscount.ForeColor = Color.White
        lDiscount.Location = New Point(548, 60)
        lDiscount.Name = "lDiscount"
        lDiscount.Size = New Size(0, 40)
        lDiscount.TabIndex = 39
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        RoundedPanel1.BackColor = Color.FromArgb(CByte(244), CByte(208), CByte(62))
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(lGrandTotal)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(838, 22)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(285, 75)
        RoundedPanel1.TabIndex = 65
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 4
        Label1.Text = "Total"
        ' 
        ' lGrandTotal
        ' 
        lGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lGrandTotal.AutoSize = True
        lGrandTotal.Font = New Font("Consolas", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lGrandTotal.Location = New Point(16, 8)
        lGrandTotal.Name = "lGrandTotal"
        lGrandTotal.Size = New Size(119, 43)
        lGrandTotal.TabIndex = 5
        lGrandTotal.Text = "₱0.00"
        lGrandTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Bottom
        GroupBox3.Controls.Add(TableLayoutPanel1)
        GroupBox3.Controls.Add(cbClothingType)
        GroupBox3.Controls.Add(GroupBox1)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(nudQuantity)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(lblStock)
        GroupBox3.Controls.Add(txtbItemPrice)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(16, 517)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1006, 162)
        GroupBox3.TabIndex = 50
        GroupBox3.TabStop = False
        GroupBox3.Text = "Add Items"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnAddItemToCart, 0, 0)
        TableLayoutPanel1.Controls.Add(btnClearCart, 0, 2)
        TableLayoutPanel1.Controls.Add(btnRemoveItemFromCart, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Right
        TableLayoutPanel1.Location = New Point(892, 19)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(111, 140)
        TableLayoutPanel1.TabIndex = 63
        ' 
        ' btnAddItemToCart
        ' 
        btnAddItemToCart.Anchor = AnchorStyles.None
        btnAddItemToCart.BackColor = Color.Transparent
        btnAddItemToCart.Cursor = Cursors.Hand
        btnAddItemToCart.FlatAppearance.MouseOverBackColor = Color.DimGray
        btnAddItemToCart.FlatStyle = FlatStyle.Flat
        btnAddItemToCart.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnAddItemToCart.Location = New Point(9, 3)
        btnAddItemToCart.Name = "btnAddItemToCart"
        btnAddItemToCart.Size = New Size(92, 40)
        btnAddItemToCart.TabIndex = 29
        btnAddItemToCart.Text = "Add Item" & vbCrLf & "+" & ChrW(55357) & ChrW(57042)
        btnAddItemToCart.TextAlign = ContentAlignment.TopCenter
        btnAddItemToCart.UseVisualStyleBackColor = False
        ' 
        ' btnClearCart
        ' 
        btnClearCart.Anchor = AnchorStyles.None
        btnClearCart.BackColor = Color.Transparent
        btnClearCart.Cursor = Cursors.Hand
        btnClearCart.FlatAppearance.MouseOverBackColor = Color.DimGray
        btnClearCart.FlatStyle = FlatStyle.Flat
        btnClearCart.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnClearCart.Location = New Point(9, 95)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(92, 42)
        btnClearCart.TabIndex = 62
        btnClearCart.Text = "Clear Cart" & vbCrLf & ChrW(55357) & ChrW(57042)
        btnClearCart.TextAlign = ContentAlignment.TopCenter
        btnClearCart.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveItemFromCart
        ' 
        btnRemoveItemFromCart.Anchor = AnchorStyles.None
        btnRemoveItemFromCart.BackColor = Color.Transparent
        btnRemoveItemFromCart.Cursor = Cursors.Hand
        btnRemoveItemFromCart.FlatAppearance.MouseOverBackColor = Color.DimGray
        btnRemoveItemFromCart.FlatStyle = FlatStyle.Flat
        btnRemoveItemFromCart.ForeColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRemoveItemFromCart.Location = New Point(9, 49)
        btnRemoveItemFromCart.Name = "btnRemoveItemFromCart"
        btnRemoveItemFromCart.Size = New Size(92, 40)
        btnRemoveItemFromCart.TabIndex = 59
        btnRemoveItemFromCart.Text = "Remove Item" & vbCrLf & "-" & ChrW(55357) & ChrW(57042)
        btnRemoveItemFromCart.TextAlign = ContentAlignment.TopCenter
        btnRemoveItemFromCart.UseVisualStyleBackColor = False
        ' 
        ' cbClothingType
        ' 
        cbClothingType.Anchor = AnchorStyles.None
        cbClothingType.BackColor = Color.White
        cbClothingType.DropDownStyle = ComboBoxStyle.DropDownList
        cbClothingType.Font = New Font("Segoe UI", 12F)
        cbClothingType.Location = New Point(72, 33)
        cbClothingType.Name = "cbClothingType"
        cbClothingType.Size = New Size(140, 29)
        cbClothingType.TabIndex = 30
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(473, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(413, 120)
        GroupBox1.TabIndex = 48
        GroupBox1.TabStop = False
        GroupBox1.Text = "Discount/Promos"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.96401F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.5064259F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 46.5295639F))
        TableLayoutPanel2.Controls.Add(BufferedPanel4, 2, 0)
        TableLayoutPanel2.Controls.Add(BufferedPanel3, 1, 0)
        TableLayoutPanel2.Controls.Add(BufferedPanel2, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 19)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(407, 98)
        TableLayoutPanel2.TabIndex = 53
        ' 
        ' BufferedPanel4
        ' 
        BufferedPanel4.Controls.Add(BufferedPanel5)
        BufferedPanel4.Controls.Add(Label5)
        BufferedPanel4.Controls.Add(NumericUpDown2)
        BufferedPanel4.Controls.Add(NumericUpDown1)
        BufferedPanel4.Controls.Add(CheckBox1)
        BufferedPanel4.Dock = DockStyle.Fill
        BufferedPanel4.Location = New Point(219, 3)
        BufferedPanel4.Name = "BufferedPanel4"
        BufferedPanel4.Size = New Size(185, 92)
        BufferedPanel4.TabIndex = 2
        ' 
        ' BufferedPanel5
        ' 
        BufferedPanel5.Controls.Add(Label9)
        BufferedPanel5.Controls.Add(Label6)
        BufferedPanel5.Controls.Add(nudXQuantity)
        BufferedPanel5.Controls.Add(nudYPrice)
        BufferedPanel5.Controls.Add(chbxBuyXForYEnabled)
        BufferedPanel5.Dock = DockStyle.Fill
        BufferedPanel5.Location = New Point(0, 0)
        BufferedPanel5.Name = "BufferedPanel5"
        BufferedPanel5.Size = New Size(185, 92)
        BufferedPanel5.TabIndex = 54
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label9.Location = New Point(114, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(14, 15)
        Label9.TabIndex = 54
        Label9.Text = "₱"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label6.Location = New Point(32, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 15)
        Label6.TabIndex = 53
        Label6.Text = "Qty."
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' nudXQuantity
        ' 
        nudXQuantity.Enabled = False
        nudXQuantity.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudXQuantity.Location = New Point(11, 38)
        nudXQuantity.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        nudXQuantity.Name = "nudXQuantity"
        nudXQuantity.Size = New Size(70, 23)
        nudXQuantity.TabIndex = 52
        ' 
        ' nudYPrice
        ' 
        nudYPrice.DecimalPlaces = 2
        nudYPrice.Enabled = False
        nudYPrice.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudYPrice.Location = New Point(86, 38)
        nudYPrice.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        nudYPrice.Name = "nudYPrice"
        nudYPrice.Size = New Size(70, 23)
        nudYPrice.TabIndex = 51
        ' 
        ' chbxBuyXForYEnabled
        ' 
        chbxBuyXForYEnabled.BackColor = Color.Transparent
        chbxBuyXForYEnabled.Cursor = Cursors.Hand
        chbxBuyXForYEnabled.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chbxBuyXForYEnabled.Location = New Point(41, 5)
        chbxBuyXForYEnabled.Name = "chbxBuyXForYEnabled"
        chbxBuyXForYEnabled.Size = New Size(87, 41)
        chbxBuyXForYEnabled.TabIndex = 50
        chbxBuyXForYEnabled.Text = "Buy X For Y"
        chbxBuyXForYEnabled.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label5.Location = New Point(25, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 53
        Label5.Text = "Qty."
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Enabled = False
        NumericUpDown2.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        NumericUpDown2.Location = New Point(11, 38)
        NumericUpDown2.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(70, 23)
        NumericUpDown2.TabIndex = 52
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Enabled = False
        NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        NumericUpDown1.Location = New Point(86, 38)
        NumericUpDown1.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(70, 23)
        NumericUpDown1.TabIndex = 51
        ' 
        ' CheckBox1
        ' 
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        CheckBox1.Location = New Point(41, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(87, 41)
        CheckBox1.TabIndex = 50
        CheckBox1.Text = "Buy X For Y"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' BufferedPanel3
        ' 
        BufferedPanel3.Controls.Add(Label10)
        BufferedPanel3.Controls.Add(nudGlobalPrice)
        BufferedPanel3.Controls.Add(chkGlobalPriceEnabled)
        BufferedPanel3.Dock = DockStyle.Fill
        BufferedPanel3.Location = New Point(108, 3)
        BufferedPanel3.Name = "BufferedPanel3"
        BufferedPanel3.Size = New Size(105, 92)
        BufferedPanel3.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label10.Location = New Point(45, 67)
        Label10.Name = "Label10"
        Label10.Size = New Size(14, 15)
        Label10.TabIndex = 55
        Label10.Text = "₱"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' nudGlobalPrice
        ' 
        nudGlobalPrice.DecimalPlaces = 2
        nudGlobalPrice.Enabled = False
        nudGlobalPrice.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudGlobalPrice.Location = New Point(17, 37)
        nudGlobalPrice.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        nudGlobalPrice.Name = "nudGlobalPrice"
        nudGlobalPrice.Size = New Size(70, 23)
        nudGlobalPrice.TabIndex = 49
        ' 
        ' chkGlobalPriceEnabled
        ' 
        chkGlobalPriceEnabled.BackColor = Color.Transparent
        chkGlobalPriceEnabled.Cursor = Cursors.Hand
        chkGlobalPriceEnabled.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chkGlobalPriceEnabled.Location = New Point(11, 3)
        chkGlobalPriceEnabled.Name = "chkGlobalPriceEnabled"
        chkGlobalPriceEnabled.Size = New Size(82, 41)
        chkGlobalPriceEnabled.TabIndex = 48
        chkGlobalPriceEnabled.Text = "All Items X"
        chkGlobalPriceEnabled.UseVisualStyleBackColor = False
        ' 
        ' BufferedPanel2
        ' 
        BufferedPanel2.Controls.Add(chbxDiscount)
        BufferedPanel2.Controls.Add(nudDiscount)
        BufferedPanel2.Dock = DockStyle.Fill
        BufferedPanel2.Location = New Point(3, 3)
        BufferedPanel2.Name = "BufferedPanel2"
        BufferedPanel2.Size = New Size(99, 92)
        BufferedPanel2.TabIndex = 0
        ' 
        ' chbxDiscount
        ' 
        chbxDiscount.Anchor = AnchorStyles.None
        chbxDiscount.BackColor = Color.Transparent
        chbxDiscount.Cursor = Cursors.Hand
        chbxDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chbxDiscount.Location = New Point(11, 5)
        chbxDiscount.Name = "chbxDiscount"
        chbxDiscount.Size = New Size(82, 41)
        chbxDiscount.TabIndex = 37
        chbxDiscount.Text = "Enable % Discount?"
        chbxDiscount.UseVisualStyleBackColor = False
        ' 
        ' nudDiscount
        ' 
        nudDiscount.Anchor = AnchorStyles.None
        nudDiscount.Enabled = False
        nudDiscount.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudDiscount.Location = New Point(15, 52)
        nudDiscount.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        nudDiscount.Name = "nudDiscount"
        nudDiscount.Size = New Size(70, 23)
        nudDiscount.TabIndex = 47
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.Controls.Add(txtbRemarks)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(218, 79)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(249, 66)
        GroupBox2.TabIndex = 49
        GroupBox2.TabStop = False
        GroupBox2.Text = "Remarks"
        ' 
        ' txtbRemarks
        ' 
        txtbRemarks.Dock = DockStyle.Bottom
        txtbRemarks.Location = New Point(3, 40)
        txtbRemarks.Margin = New Padding(50, 0, 50, 0)
        txtbRemarks.Name = "txtbRemarks"
        txtbRemarks.Size = New Size(243, 23)
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
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label2.Location = New Point(32, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 31
        Label2.Text = "Type:"
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Anchor = AnchorStyles.None
        nudQuantity.Font = New Font("Segoe UI", 12F)
        nudQuantity.Location = New Point(134, 114)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(78, 29)
        nudQuantity.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label3.Location = New Point(72, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 33
        Label3.Text = "Quantity:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblStock
        ' 
        lblStock.Anchor = AnchorStyles.None
        lblStock.BackColor = Color.Transparent
        lblStock.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(238, 36)
        lblStock.Name = "lblStock"
        lblStock.RightToLeft = RightToLeft.No
        lblStock.Size = New Size(211, 20)
        lblStock.TabIndex = 42
        lblStock.Text = "0"
        lblStock.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtbItemPrice
        ' 
        txtbItemPrice.Anchor = AnchorStyles.None
        txtbItemPrice.Font = New Font("Segoe UI", 12F)
        txtbItemPrice.Location = New Point(72, 75)
        txtbItemPrice.MaxLength = 7
        txtbItemPrice.Name = "txtbItemPrice"
        txtbItemPrice.Size = New Size(140, 29)
        txtbItemPrice.TabIndex = 35
        txtbItemPrice.Text = "79.00"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label4.Location = New Point(32, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 36
        Label4.Text = "Price:"
        ' 
        ' dgvCart
        ' 
        dgvCart.AllowUserToAddRows = False
        dgvCart.AllowUserToDeleteRows = False
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
        dgvCart.Location = New Point(16, 78)
        dgvCart.Name = "dgvCart"
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(1102, 446)
        dgvCart.TabIndex = 60
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Anchor = AnchorStyles.Bottom
        btnCheckout.BackColor = Color.Transparent
        btnCheckout.Cursor = Cursors.Hand
        btnCheckout.FlatAppearance.BorderColor = Color.Gold
        btnCheckout.FlatAppearance.BorderSize = 3
        btnCheckout.FlatAppearance.MouseOverBackColor = Color.DimGray
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.ForeColor = Color.Gold
        btnCheckout.Location = New Point(1028, 533)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(90, 123)
        btnCheckout.TabIndex = 63
        btnCheckout.Text = "Proceed to Checkout →"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' CartControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(BufferedPanel1)
        Name = "CartControl"
        Size = New Size(1135, 682)
        BufferedPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        BufferedPanel4.ResumeLayout(False)
        BufferedPanel4.PerformLayout()
        BufferedPanel5.ResumeLayout(False)
        BufferedPanel5.PerformLayout()
        CType(nudXQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(nudYPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        BufferedPanel3.ResumeLayout(False)
        BufferedPanel3.PerformLayout()
        CType(nudGlobalPrice, ComponentModel.ISupportInitialize).EndInit()
        BufferedPanel2.ResumeLayout(False)
        CType(nudDiscount, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BufferedPanel1 As BufferedPanel
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRemoveItemFromCart As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents lGrandTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbClothingType As ComboBox
    Friend WithEvents btnAddItemToCart As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents txtbItemPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lDiscount As Label
    Friend WithEvents nudDiscount As NumericUpDown
    Friend WithEvents chbxDiscount As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbRemarks As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents nudGlobalPrice As NumericUpDown
    Friend WithEvents chkGlobalPriceEnabled As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BufferedPanel4 As BufferedPanel
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BufferedPanel3 As BufferedPanel
    Friend WithEvents BufferedPanel2 As BufferedPanel
    Friend WithEvents BufferedPanel5 As BufferedPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudXQuantity As NumericUpDown
    Friend WithEvents nudYPrice As NumericUpDown
    Friend WithEvents chbxBuyXForYEnabled As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel

End Class
