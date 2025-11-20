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
        dgvCart = New DataGridView()
        Label7 = New Label()
        btnRemoveItemFromCart = New Button()
        btnCheckout = New Button()
        btnClearCart = New Button()
        Panel2 = New Panel()
        lGrandTotal = New Label()
        Label1 = New Label()
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
        BufferedPanel1.SuspendLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.Controls.Add(dgvCart)
        BufferedPanel1.Controls.Add(Label7)
        BufferedPanel1.Controls.Add(btnRemoveItemFromCart)
        BufferedPanel1.Controls.Add(btnCheckout)
        BufferedPanel1.Controls.Add(btnClearCart)
        BufferedPanel1.Controls.Add(Panel2)
        BufferedPanel1.Controls.Add(FlowLayoutPanel1)
        BufferedPanel1.Dock = DockStyle.Fill
        BufferedPanel1.Location = New Point(0, 0)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Size = New Size(1135, 682)
        BufferedPanel1.TabIndex = 0
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
        dgvCart.Location = New Point(31, 78)
        dgvCart.Name = "dgvCart"
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(1070, 446)
        dgvCart.TabIndex = 60
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(43, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 31)
        Label7.TabIndex = 64
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
        btnRemoveItemFromCart.Location = New Point(884, 611)
        btnRemoveItemFromCart.Name = "btnRemoveItemFromCart"
        btnRemoveItemFromCart.Size = New Size(92, 43)
        btnRemoveItemFromCart.TabIndex = 59
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
        btnCheckout.Location = New Point(986, 565)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(118, 97)
        btnCheckout.TabIndex = 63
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
        btnClearCart.Location = New Point(890, 562)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(79, 43)
        btnClearCart.TabIndex = 62
        btnClearCart.Text = "Clear Cart" & vbCrLf & ChrW(55357) & ChrW(57042)
        btnClearCart.TextAlign = ContentAlignment.TopCenter
        btnClearCart.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(244), CByte(208), CByte(62))
        Panel2.Controls.Add(lGrandTotal)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(832, 13)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(269, 69)
        Panel2.TabIndex = 61
        ' 
        ' lGrandTotal
        ' 
        lGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lGrandTotal.AutoSize = True
        lGrandTotal.Font = New Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lGrandTotal.Location = New Point(21, 29)
        lGrandTotal.Name = "lGrandTotal"
        lGrandTotal.Size = New Size(95, 34)
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Bottom
        FlowLayoutPanel1.Controls.Add(GroupBox3)
        FlowLayoutPanel1.Controls.Add(GroupBox1)
        FlowLayoutPanel1.Controls.Add(GroupBox2)
        FlowLayoutPanel1.Location = New Point(47, 522)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(825, 147)
        FlowLayoutPanel1.TabIndex = 65
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
        GroupBox3.Size = New Size(330, 137)
        GroupBox3.TabIndex = 50
        GroupBox3.TabStop = False
        GroupBox3.Text = "Add Items"
        ' 
        ' cbClothingType
        ' 
        cbClothingType.BackColor = Color.White
        cbClothingType.DropDownStyle = ComboBoxStyle.DropDownList
        cbClothingType.Font = New Font("Segoe UI", 14.25F)
        cbClothingType.Location = New Point(50, 29)
        cbClothingType.Name = "cbClothingType"
        cbClothingType.Size = New Size(121, 33)
        cbClothingType.TabIndex = 30
        ' 
        ' btnAddItemToCart
        ' 
        btnAddItemToCart.BackColor = Color.Transparent
        btnAddItemToCart.Cursor = Cursors.Hand
        btnAddItemToCart.FlatStyle = FlatStyle.Flat
        btnAddItemToCart.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnAddItemToCart.Location = New Point(249, 86)
        btnAddItemToCart.Name = "btnAddItemToCart"
        btnAddItemToCart.Size = New Size(75, 43)
        btnAddItemToCart.TabIndex = 29
        btnAddItemToCart.Text = "Add Item" & vbCrLf & "+" & ChrW(55357) & ChrW(57042)
        btnAddItemToCart.TextAlign = ContentAlignment.TopCenter
        btnAddItemToCart.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label2.Location = New Point(12, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 31
        Label2.Text = "Type:"
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Font = New Font("Segoe UI", 14.25F)
        nudQuantity.Location = New Point(249, 30)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(37, 33)
        nudQuantity.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label3.Location = New Point(187, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 33
        Label3.Text = "Quantity:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblStock
        ' 
        lblStock.BackColor = Color.Transparent
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(52, 112)
        lblStock.Name = "lblStock"
        lblStock.RightToLeft = RightToLeft.No
        lblStock.Size = New Size(121, 20)
        lblStock.TabIndex = 42
        lblStock.Text = "0"
        lblStock.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtbItemPrice
        ' 
        txtbItemPrice.Font = New Font("Segoe UI", 14.25F)
        txtbItemPrice.Location = New Point(52, 76)
        txtbItemPrice.MaxLength = 7
        txtbItemPrice.Name = "txtbItemPrice"
        txtbItemPrice.Size = New Size(121, 33)
        txtbItemPrice.TabIndex = 35
        txtbItemPrice.Text = "79.00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label4.Location = New Point(10, 94)
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
        GroupBox1.Location = New Point(339, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(153, 100)
        GroupBox1.TabIndex = 48
        GroupBox1.TabStop = False
        GroupBox1.Text = "Discount"
        ' 
        ' lDiscount
        ' 
        lDiscount.AutoSize = True
        lDiscount.BackColor = Color.Transparent
        lDiscount.Enabled = False
        lDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        lDiscount.Location = New Point(38, 70)
        lDiscount.Name = "lDiscount"
        lDiscount.Size = New Size(76, 15)
        lDiscount.TabIndex = 39
        lDiscount.Text = "Discount: 0%"
        ' 
        ' nudDiscount
        ' 
        nudDiscount.Enabled = False
        nudDiscount.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudDiscount.Location = New Point(41, 44)
        nudDiscount.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        nudDiscount.Name = "nudDiscount"
        nudDiscount.Size = New Size(70, 23)
        nudDiscount.TabIndex = 47
        ' 
        ' chbxDiscount
        ' 
        chbxDiscount.AutoSize = True
        chbxDiscount.BackColor = Color.Transparent
        chbxDiscount.Cursor = Cursors.Hand
        chbxDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chbxDiscount.Location = New Point(18, 22)
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
        GroupBox2.Location = New Point(498, 76)
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
        ' CartControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(BufferedPanel1)
        Name = "CartControl"
        Size = New Size(1135, 682)
        BufferedPanel1.ResumeLayout(False)
        BufferedPanel1.PerformLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudDiscount, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BufferedPanel1 As BufferedPanel
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRemoveItemFromCart As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lGrandTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
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

End Class
