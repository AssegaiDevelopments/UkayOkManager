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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        btnRemoveItemFromCart = New Button()
        btnAddItemToCart = New Button()
        Label1 = New Label()
        cbClothingType = New ComboBox()
        Label2 = New Label()
        nudQuantity = New NumericUpDown()
        Label3 = New Label()
        dgvCart = New DataGridView()
        txtbItemPrice = New TextBox()
        Label4 = New Label()
        chbxDiscount = New CheckBox()
        tbDiscount = New TrackBar()
        lDiscount = New Label()
        Panel1 = New Panel()
        lGrandTotal = New Label()
        btnExit = New Button()
        Button1 = New Button()
        btnMinimize = New Button()
        btnClearCart = New Button()
        lblStock = New Label()
        btnCheckout = New Button()
        Label5 = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        btnManageStocks = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox2 = New PictureBox()
        btnViewTransaction = New Button()
        CType(nudQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbDiscount, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRemoveItemFromCart
        ' 
        btnRemoveItemFromCart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRemoveItemFromCart.Cursor = Cursors.Hand
        btnRemoveItemFromCart.FlatStyle = FlatStyle.Flat
        btnRemoveItemFromCart.ForeColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRemoveItemFromCart.Location = New Point(916, 543)
        btnRemoveItemFromCart.Name = "btnRemoveItemFromCart"
        btnRemoveItemFromCart.Size = New Size(92, 43)
        btnRemoveItemFromCart.TabIndex = 1
        btnRemoveItemFromCart.Text = "Remove Item" & vbCrLf & "-" & ChrW(55357) & ChrW(57042)
        btnRemoveItemFromCart.TextAlign = ContentAlignment.TopCenter
        btnRemoveItemFromCart.UseVisualStyleBackColor = True
        ' 
        ' btnAddItemToCart
        ' 
        btnAddItemToCart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddItemToCart.Cursor = Cursors.Hand
        btnAddItemToCart.FlatStyle = FlatStyle.Flat
        btnAddItemToCart.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnAddItemToCart.Location = New Point(835, 543)
        btnAddItemToCart.Name = "btnAddItemToCart"
        btnAddItemToCart.Size = New Size(75, 43)
        btnAddItemToCart.TabIndex = 3
        btnAddItemToCart.Text = "Add Item" & vbCrLf & "+" & ChrW(55357) & ChrW(57042)
        btnAddItemToCart.TextAlign = ContentAlignment.TopCenter
        btnAddItemToCart.UseVisualStyleBackColor = True
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
        ' cbClothingType
        ' 
        cbClothingType.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cbClothingType.BackColor = Color.White
        cbClothingType.DropDownStyle = ComboBoxStyle.DropDownList
        cbClothingType.Location = New Point(692, 544)
        cbClothingType.Name = "cbClothingType"
        cbClothingType.Size = New Size(121, 23)
        cbClothingType.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label2.Location = New Point(652, 549)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 6
        Label2.Text = "Type:"
        ' 
        ' nudQuantity
        ' 
        nudQuantity.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        nudQuantity.Location = New Point(776, 601)
        nudQuantity.Name = "nudQuantity"
        nudQuantity.Size = New Size(37, 23)
        nudQuantity.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label3.Location = New Point(720, 606)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 8
        Label3.Text = "Quantity:"
        Label3.TextAlign = ContentAlignment.MiddleRight
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
        dgvCart.Location = New Point(504, 60)
        dgvCart.Name = "dgvCart"
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(728, 472)
        dgvCart.TabIndex = 9
        ' 
        ' txtbItemPrice
        ' 
        txtbItemPrice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtbItemPrice.Location = New Point(692, 572)
        txtbItemPrice.MaxLength = 7
        txtbItemPrice.Name = "txtbItemPrice"
        txtbItemPrice.Size = New Size(121, 23)
        txtbItemPrice.TabIndex = 10
        txtbItemPrice.Text = "79.00"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label4.Location = New Point(650, 575)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 11
        Label4.Text = "Price:"
        ' 
        ' chbxDiscount
        ' 
        chbxDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        chbxDiscount.AutoSize = True
        chbxDiscount.Cursor = Cursors.Hand
        chbxDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        chbxDiscount.Location = New Point(526, 546)
        chbxDiscount.Name = "chbxDiscount"
        chbxDiscount.Size = New Size(116, 19)
        chbxDiscount.TabIndex = 12
        chbxDiscount.Text = "Enable Discount?"
        chbxDiscount.UseVisualStyleBackColor = True
        ' 
        ' tbDiscount
        ' 
        tbDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        tbDiscount.Cursor = Cursors.NoMoveHoriz
        tbDiscount.Enabled = False
        tbDiscount.Location = New Point(526, 570)
        tbDiscount.Maximum = 80
        tbDiscount.Name = "tbDiscount"
        tbDiscount.Size = New Size(116, 45)
        tbDiscount.TabIndex = 13
        tbDiscount.TickStyle = TickStyle.None
        tbDiscount.Value = 1
        ' 
        ' lDiscount
        ' 
        lDiscount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lDiscount.AutoSize = True
        lDiscount.Enabled = False
        lDiscount.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        lDiscount.Location = New Point(526, 585)
        lDiscount.Name = "lDiscount"
        lDiscount.Size = New Size(76, 15)
        lDiscount.TabIndex = 14
        lDiscount.Text = "Discount: 0%"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(244), CByte(208), CByte(62))
        Panel1.Controls.Add(lGrandTotal)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1123, 539)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(109, 69)
        Panel1.TabIndex = 15
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
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(1242, 12)
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
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.White
        btnMinimize.Location = New Point(1210, 12)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(26, 26)
        btnMinimize.TabIndex = 17
        btnMinimize.Text = "—"
        btnMinimize.UseMnemonic = False
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' btnClearCart
        ' 
        btnClearCart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClearCart.Cursor = Cursors.Hand
        btnClearCart.FlatStyle = FlatStyle.Flat
        btnClearCart.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnClearCart.Location = New Point(1014, 543)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(83, 43)
        btnClearCart.TabIndex = 18
        btnClearCart.Text = "Clear Cart" & vbCrLf & ChrW(55357) & ChrW(57042)
        btnClearCart.TextAlign = ContentAlignment.TopCenter
        btnClearCart.UseVisualStyleBackColor = True
        ' 
        ' lblStock
        ' 
        lblStock.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblStock.AutoSize = True
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(824, 575)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(0, 15)
        lblStock.TabIndex = 19
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCheckout.Cursor = Cursors.Hand
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.ForeColor = Color.Gold
        btnCheckout.Location = New Point(1123, 614)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(109, 60)
        btnCheckout.TabIndex = 20
        btnCheckout.Text = "Proceed to Checkout →"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.ForeColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        Label5.Location = New Point(-10, 677)
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
        btnManageStocks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnManageStocks.FlatStyle = FlatStyle.Flat
        btnManageStocks.ForeColor = Color.White
        btnManageStocks.Location = New Point(3, 3)
        btnManageStocks.Name = "btnManageStocks"
        btnManageStocks.Size = New Size(110, 50)
        btnManageStocks.TabIndex = 0
        btnManageStocks.Text = "📦" & vbCrLf & "Manage Stocks"
        btnManageStocks.TextAlign = ContentAlignment.TopCenter
        btnManageStocks.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        FlowLayoutPanel1.Controls.Add(btnManageStocks)
        FlowLayoutPanel1.Controls.Add(btnViewTransaction)
        FlowLayoutPanel1.Controls.Add(PictureBox2)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(12, 10)
        FlowLayoutPanel1.Margin = New Padding(3, 10, 3, 10)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(113, 664)
        FlowLayoutPanel1.TabIndex = 23
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.shopee
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(3, 124)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(110, 65)
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' btnViewTransaction
        ' 
        btnViewTransaction.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnViewTransaction.FlatStyle = FlatStyle.Flat
        btnViewTransaction.ForeColor = Color.White
        btnViewTransaction.Location = New Point(3, 59)
        btnViewTransaction.Name = "btnViewTransaction"
        btnViewTransaction.Size = New Size(110, 59)
        btnViewTransaction.TabIndex = 26
        btnViewTransaction.Text = "📠" & vbCrLf & "View Transaction Logs"
        btnViewTransaction.TextAlign = ContentAlignment.TopCenter
        btnViewTransaction.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(69), CByte(88), CByte(113))
        ClientSize = New Size(1280, 720)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label5)
        Controls.Add(btnCheckout)
        Controls.Add(lblStock)
        Controls.Add(btnClearCart)
        Controls.Add(btnMinimize)
        Controls.Add(Button1)
        Controls.Add(btnExit)
        Controls.Add(Panel1)
        Controls.Add(lDiscount)
        Controls.Add(tbDiscount)
        Controls.Add(chbxDiscount)
        Controls.Add(Label4)
        Controls.Add(txtbItemPrice)
        Controls.Add(dgvCart)
        Controls.Add(Label3)
        Controls.Add(nudQuantity)
        Controls.Add(Label2)
        Controls.Add(cbClothingType)
        Controls.Add(btnAddItemToCart)
        Controls.Add(btnRemoveItemFromCart)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UkayOk Cart"
        WindowState = FormWindowState.Maximized
        CType(nudQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        CType(tbDiscount, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnRemoveItemFromCart As Button
    Friend WithEvents btnAddItemToCart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbClothingType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents txtbItemPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chbxDiscount As CheckBox
    Friend WithEvents tbDiscount As TrackBar
    Friend WithEvents lDiscount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lGrandTotal As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents lblStock As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents btnManageStocks As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnViewTransaction As Button
End Class
