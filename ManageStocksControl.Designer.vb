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
        Label2 = New Label()
        btnRemoveItem = New Button()
        btnAddItem = New Button()
        btnApplyToCell = New Button()
        Label1 = New Label()
        nudAddSubtract = New NumericUpDown()
        btnSaveChanges = New Button()
        dgvStocks = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        tbProductName = New TextBox()
        Label4 = New Label()
        nudStock = New NumericUpDown()
        Label5 = New Label()
        nudPrice = New NumericUpDown()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStocks, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(nudStock, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(31, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 50)
        Label2.TabIndex = 28
        Label2.Text = "Stock" & vbCrLf & "Manager"
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.Dock = DockStyle.Fill
        btnRemoveItem.FlatAppearance.BorderSize = 0
        btnRemoveItem.ForeColor = Color.Black
        btnRemoveItem.Location = New Point(3, 3)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(124, 42)
        btnRemoveItem.TabIndex = 26
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = True
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
        ' btnApplyToCell
        ' 
        btnApplyToCell.ForeColor = Color.Black
        btnApplyToCell.Location = New Point(129, 89)
        btnApplyToCell.Name = "btnApplyToCell"
        btnApplyToCell.Size = New Size(112, 50)
        btnApplyToCell.TabIndex = 24
        btnApplyToCell.Text = "Apply to selected"
        btnApplyToCell.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 23
        Label1.Text = "Add/Subtract to Stock"
        ' 
        ' nudAddSubtract
        ' 
        nudAddSubtract.Anchor = AnchorStyles.Left
        nudAddSubtract.Font = New Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddSubtract.Location = New Point(133, 5)
        nudAddSubtract.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        nudAddSubtract.Name = "nudAddSubtract"
        nudAddSubtract.Size = New Size(121, 35)
        nudAddSubtract.TabIndex = 22
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.FromArgb(CByte(243), CByte(182), CByte(80))
        btnSaveChanges.Dock = DockStyle.Fill
        btnSaveChanges.FlatAppearance.BorderColor = Color.FromArgb(CByte(243), CByte(182), CByte(80))
        btnSaveChanges.FlatAppearance.BorderSize = 2
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.ForeColor = Color.Black
        btnSaveChanges.Location = New Point(133, 3)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(124, 42)
        btnSaveChanges.TabIndex = 21
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' dgvStocks
        ' 
        dgvStocks.BackgroundColor = Color.White
        dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStocks.Cursor = Cursors.Hand
        dgvStocks.Dock = DockStyle.Right
        dgvStocks.GridColor = Color.SpringGreen
        dgvStocks.Location = New Point(482, 0)
        dgvStocks.Name = "dgvStocks"
        dgvStocks.Size = New Size(653, 682)
        dgvStocks.TabIndex = 20
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnRemoveItem, 0, 0)
        TableLayoutPanel1.Controls.Add(btnSaveChanges, 1, 0)
        TableLayoutPanel1.Location = New Point(52, 203)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(260, 48)
        TableLayoutPanel1.TabIndex = 29
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
        TableLayoutPanel3.Location = New Point(58, 38)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(260, 45)
        TableLayoutPanel3.TabIndex = 25
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(45, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 8
        Label4.Text = "Stock"
        Label4.TextAlign = ContentAlignment.MiddleLeft
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
        Label5.ForeColor = Color.White
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
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnAddItem)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbProductName)
        GroupBox1.Controls.Add(nudStock)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(nudPrice)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(41, 110)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(371, 215)
        GroupBox1.TabIndex = 31
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Product"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(btnApplyToCell)
        GroupBox2.Controls.Add(TableLayoutPanel3)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(41, 356)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(371, 281)
        GroupBox2.TabIndex = 32
        GroupBox2.TabStop = False
        GroupBox2.Text = "Manage Stocks"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(45, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 26
        Label3.Text = "Item Name"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ManageStocksControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg11
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(dgvStocks)
        Name = "ManageStocksControl"
        Size = New Size(1135, 682)
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStocks, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(nudStock, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnApplyToCell As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nudAddSubtract As NumericUpDown
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label

End Class
