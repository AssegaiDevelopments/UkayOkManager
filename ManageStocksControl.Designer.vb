<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStocksControl
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BufferedPanel1 = New BufferedPanel()
        RoundedPanel1 = New RoundedPanel()
        gbAddProduct = New GroupBox()
        Label3 = New Label()
        btnAddItem = New Button()
        Label4 = New Label()
        tbProductName = New TextBox()
        nudStock = New NumericUpDown()
        Label5 = New Label()
        nudPrice = New NumericUpDown()
        gbManageStocks = New GroupBox()
        btnApplyToCell = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        nudAddSubtract = New NumericUpDown()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnRemoveItem = New Button()
        btnSaveChanges = New Button()
        dgvStocks = New DataGridView()
        Label2 = New Label()
        BufferedPanel1.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        gbAddProduct.SuspendLayout()
        CType(nudStock, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        gbManageStocks.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvStocks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.BackColor = Color.Transparent
        BufferedPanel1.Controls.Add(RoundedPanel1)
        BufferedPanel1.Controls.Add(dgvStocks)
        BufferedPanel1.Controls.Add(Label2)
        BufferedPanel1.Dock = DockStyle.Fill
        BufferedPanel1.Location = New Point(0, 0)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Size = New Size(1135, 682)
        BufferedPanel1.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(gbAddProduct)
        RoundedPanel1.Controls.Add(gbManageStocks)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(25, 80)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(442, 518)
        RoundedPanel1.TabIndex = 37
        ' 
        ' gbAddProduct
        ' 
        gbAddProduct.BackColor = Color.Transparent
        gbAddProduct.Controls.Add(Label3)
        gbAddProduct.Controls.Add(btnAddItem)
        gbAddProduct.Controls.Add(Label4)
        gbAddProduct.Controls.Add(tbProductName)
        gbAddProduct.Controls.Add(nudStock)
        gbAddProduct.Controls.Add(Label5)
        gbAddProduct.Controls.Add(nudPrice)
        gbAddProduct.FlatStyle = FlatStyle.Flat
        gbAddProduct.ForeColor = Color.Black
        gbAddProduct.Location = New Point(34, 20)
        gbAddProduct.Name = "gbAddProduct"
        gbAddProduct.Size = New Size(361, 215)
        gbAddProduct.TabIndex = 35
        gbAddProduct.TabStop = False
        gbAddProduct.Text = "Add Product"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(45, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 26
        Label3.Text = "Item Name"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Cursor = Cursors.Hand
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.ForeColor = Color.Black
        btnAddItem.Location = New Point(201, 157)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(124, 39)
        btnAddItem.TabIndex = 25
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(45, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 8
        Label4.Text = "Stock"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbProductName
        ' 
        tbProductName.Cursor = Cursors.IBeam
        tbProductName.Font = New Font("Segoe UI", 15.75F)
        tbProductName.Location = New Point(45, 40)
        tbProductName.Margin = New Padding(0)
        tbProductName.MaxLength = 256
        tbProductName.Name = "tbProductName"
        tbProductName.Size = New Size(274, 35)
        tbProductName.TabIndex = 6
        ' 
        ' nudStock
        ' 
        nudStock.Cursor = Cursors.IBeam
        nudStock.Font = New Font("Segoe UI", 15.75F)
        nudStock.Location = New Point(45, 100)
        nudStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudStock.Name = "nudStock"
        nudStock.Size = New Size(121, 35)
        nudStock.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(45, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 9
        Label5.Text = "Price"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudPrice
        ' 
        nudPrice.Cursor = Cursors.IBeam
        nudPrice.DecimalPlaces = 2
        nudPrice.Font = New Font("Segoe UI", 15.75F)
        nudPrice.Location = New Point(45, 160)
        nudPrice.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New Size(121, 35)
        nudPrice.TabIndex = 8
        nudPrice.ThousandsSeparator = True
        ' 
        ' gbManageStocks
        ' 
        gbManageStocks.BackColor = Color.Transparent
        gbManageStocks.Controls.Add(btnApplyToCell)
        gbManageStocks.Controls.Add(TableLayoutPanel3)
        gbManageStocks.Controls.Add(TableLayoutPanel1)
        gbManageStocks.ForeColor = Color.Black
        gbManageStocks.Location = New Point(34, 241)
        gbManageStocks.Name = "gbManageStocks"
        gbManageStocks.Size = New Size(361, 110)
        gbManageStocks.TabIndex = 36
        gbManageStocks.TabStop = False
        gbManageStocks.Text = "Manage Stocks"
        ' 
        ' btnApplyToCell
        ' 
        btnApplyToCell.Cursor = Cursors.Hand
        btnApplyToCell.ForeColor = Color.Black
        btnApplyToCell.Location = New Point(6, 70)
        btnApplyToCell.Name = "btnApplyToCell"
        btnApplyToCell.Size = New Size(121, 32)
        btnApplyToCell.TabIndex = 24
        btnApplyToCell.Text = "Apply to selected"
        btnApplyToCell.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.BackColor = Color.Transparent
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(nudAddSubtract, 1, 0)
        TableLayoutPanel3.Location = New Point(4, 22)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(352, 45)
        TableLayoutPanel3.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 21)
        Label1.TabIndex = 23
        Label1.Text = "Add/Subtract to Stock"
        ' 
        ' nudAddSubtract
        ' 
        nudAddSubtract.Anchor = AnchorStyles.Left
        nudAddSubtract.Font = New Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddSubtract.Location = New Point(179, 5)
        nudAddSubtract.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        nudAddSubtract.Name = "nudAddSubtract"
        nudAddSubtract.Size = New Size(170, 35)
        nudAddSubtract.TabIndex = 22
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnRemoveItem, 0, 0)
        TableLayoutPanel1.Controls.Add(btnSaveChanges, 1, 0)
        TableLayoutPanel1.Location = New Point(130, 69)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(225, 35)
        TableLayoutPanel1.TabIndex = 29
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.Cursor = Cursors.Hand
        btnRemoveItem.Dock = DockStyle.Fill
        btnRemoveItem.FlatAppearance.BorderSize = 0
        btnRemoveItem.ForeColor = Color.Black
        btnRemoveItem.Location = New Point(3, 3)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(106, 29)
        btnRemoveItem.TabIndex = 26
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.FromArgb(CByte(243), CByte(182), CByte(80))
        btnSaveChanges.Cursor = Cursors.Hand
        btnSaveChanges.Dock = DockStyle.Fill
        btnSaveChanges.FlatAppearance.BorderColor = Color.FromArgb(CByte(243), CByte(182), CByte(80))
        btnSaveChanges.FlatAppearance.BorderSize = 2
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.ForeColor = Color.Black
        btnSaveChanges.Location = New Point(115, 3)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(107, 29)
        btnSaveChanges.TabIndex = 21
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' dgvStocks
        ' 
        dgvStocks.BackgroundColor = Color.White
        dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStocks.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.GhostWhite
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStocks.DefaultCellStyle = DataGridViewCellStyle2
        dgvStocks.Dock = DockStyle.Right
        dgvStocks.GridColor = Color.LightCyan
        dgvStocks.Location = New Point(482, 0)
        dgvStocks.Name = "dgvStocks"
        dgvStocks.Size = New Size(653, 682)
        dgvStocks.TabIndex = 33
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 50)
        Label2.TabIndex = 34
        Label2.Text = "Stock" & vbCrLf & "Manager"
        ' 
        ' ManageStocksControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg11
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(BufferedPanel1)
        Name = "ManageStocksControl"
        Size = New Size(1135, 682)
        BufferedPanel1.ResumeLayout(False)
        BufferedPanel1.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        gbAddProduct.ResumeLayout(False)
        gbAddProduct.PerformLayout()
        CType(nudStock, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        gbManageStocks.ResumeLayout(False)
        gbManageStocks.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvStocks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BufferedPanel1 As BufferedPanel
    Friend WithEvents gbManageStocks As GroupBox
    Friend WithEvents btnApplyToCell As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents nudAddSubtract As NumericUpDown
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents gbAddProduct As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel

End Class
