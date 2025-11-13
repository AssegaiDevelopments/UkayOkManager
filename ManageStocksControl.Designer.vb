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
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Panel1 = New Panel()
        Label3 = New Label()
        tbProductName = New TextBox()
        Panel2 = New Panel()
        Label4 = New Label()
        nudStock = New NumericUpDown()
        Panel3 = New Panel()
        Label5 = New Label()
        nudPrice = New NumericUpDown()
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStocks, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(nudStock, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
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
        btnRemoveItem.Location = New Point(3, 3)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(124, 39)
        btnRemoveItem.TabIndex = 26
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Dock = DockStyle.Fill
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.Location = New Point(133, 3)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(124, 39)
        btnAddItem.TabIndex = 25
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' btnApplyToCell
        ' 
        btnApplyToCell.Dock = DockStyle.Fill
        btnApplyToCell.Location = New Point(133, 53)
        btnApplyToCell.Name = "btnApplyToCell"
        btnApplyToCell.Size = New Size(124, 45)
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
        Label1.Location = New Point(3, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 23
        Label1.Text = "Add/Subtract to Stock"
        ' 
        ' nudAddSubtract
        ' 
        nudAddSubtract.Anchor = AnchorStyles.Left
        nudAddSubtract.Font = New Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddSubtract.Location = New Point(133, 14)
        nudAddSubtract.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        nudAddSubtract.Name = "nudAddSubtract"
        nudAddSubtract.Size = New Size(85, 21)
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
        btnSaveChanges.Location = New Point(133, 48)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(124, 39)
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
        dgvStocks.Location = New Point(323, 0)
        dgvStocks.Name = "dgvStocks"
        dgvStocks.Size = New Size(653, 542)
        dgvStocks.TabIndex = 20
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnRemoveItem, 0, 0)
        TableLayoutPanel1.Controls.Add(btnSaveChanges, 1, 1)
        TableLayoutPanel1.Controls.Add(btnAddItem, 1, 0)
        TableLayoutPanel1.Location = New Point(3, 328)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(260, 90)
        TableLayoutPanel1.TabIndex = 29
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Left
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel2.Location = New Point(31, 102)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.1189728F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 66.88103F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 394F))
        TableLayoutPanel2.Size = New Size(266, 720)
        TableLayoutPanel2.TabIndex = 30
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(btnApplyToCell, 1, 1)
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(nudAddSubtract, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(260, 101)
        TableLayoutPanel3.TabIndex = 25
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel4.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel4.Controls.Add(Panel3, 0, 2)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 110)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle())
        TableLayoutPanel4.RowStyles.Add(New RowStyle())
        TableLayoutPanel4.RowStyles.Add(New RowStyle())
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Size = New Size(260, 212)
        TableLayoutPanel4.TabIndex = 30
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbProductName)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(254, 54)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(-3, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 7
        Label3.Text = "Product Name"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbProductName
        ' 
        tbProductName.Cursor = Cursors.IBeam
        tbProductName.Location = New Point(0, 26)
        tbProductName.MaxLength = 256
        tbProductName.Name = "tbProductName"
        tbProductName.Size = New Size(248, 23)
        tbProductName.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(nudStock)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 63)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(254, 54)
        Panel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(3, 2)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 8
        Label4.Text = "Stock"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudStock
        ' 
        nudStock.Cursor = Cursors.IBeam
        nudStock.Location = New Point(3, 20)
        nudStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudStock.Name = "nudStock"
        nudStock.Size = New Size(121, 23)
        nudStock.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(nudPrice)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 123)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(254, 86)
        Panel3.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(3, 8)
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
        nudPrice.Location = New Point(3, 26)
        nudPrice.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New Size(121, 23)
        nudPrice.TabIndex = 8
        nudPrice.ThousandsSeparator = True
        ' 
        ' ManageStocksControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg11
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label2)
        Controls.Add(dgvStocks)
        Name = "ManageStocksControl"
        Size = New Size(976, 542)
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStocks, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(nudStock, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents nudPrice As NumericUpDown

End Class
