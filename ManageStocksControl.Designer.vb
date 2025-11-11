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
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStocks, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 12)
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
        btnRemoveItem.Size = New Size(128, 44)
        btnRemoveItem.TabIndex = 26
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Dock = DockStyle.Fill
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.Location = New Point(3, 53)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(128, 44)
        btnAddItem.TabIndex = 25
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' btnApplyToCell
        ' 
        btnApplyToCell.Anchor = AnchorStyles.Left
        btnApplyToCell.Location = New Point(66, 196)
        btnApplyToCell.Name = "btnApplyToCell"
        btnApplyToCell.Size = New Size(50, 23)
        btnApplyToCell.TabIndex = 24
        btnApplyToCell.Text = "Apply"
        btnApplyToCell.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(29, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 23
        Label1.Text = "Add/Subtract to Stock"
        ' 
        ' nudAddSubtract
        ' 
        nudAddSubtract.Anchor = AnchorStyles.Left
        nudAddSubtract.Font = New Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddSubtract.Location = New Point(31, 169)
        nudAddSubtract.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        nudAddSubtract.Name = "nudAddSubtract"
        nudAddSubtract.Size = New Size(120, 21)
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
        btnSaveChanges.Location = New Point(137, 53)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(129, 44)
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
        TableLayoutPanel1.Controls.Add(btnSaveChanges, 1, 1)
        TableLayoutPanel1.Controls.Add(btnAddItem, 0, 1)
        TableLayoutPanel1.Controls.Add(btnRemoveItem, 0, 0)
        TableLayoutPanel1.Location = New Point(31, 428)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(269, 100)
        TableLayoutPanel1.TabIndex = 29
        ' 
        ' ManageStocksControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg11
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        Controls.Add(btnApplyToCell)
        Controls.Add(Label1)
        Controls.Add(nudAddSubtract)
        Controls.Add(dgvStocks)
        Name = "ManageStocksControl"
        Size = New Size(976, 542)
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStocks, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
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

End Class
