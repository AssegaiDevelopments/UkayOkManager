<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStocks
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
        dgvStocks = New DataGridView()
        btnSaveChanges = New Button()
        nudAddSubtract = New NumericUpDown()
        Label1 = New Label()
        btnApplyToCell = New Button()
        btnAddItem = New Button()
        btnRemoveItem = New Button()
        btnClose = New Button()
        Label2 = New Label()
        CType(dgvStocks, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvStocks
        ' 
        dgvStocks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        dgvStocks.BackgroundColor = Color.White
        dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStocks.Cursor = Cursors.Hand
        dgvStocks.GridColor = Color.SpringGreen
        dgvStocks.Location = New Point(194, 49)
        dgvStocks.Name = "dgvStocks"
        dgvStocks.Size = New Size(594, 481)
        dgvStocks.TabIndex = 0
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.FromArgb(CByte(243), CByte(182), CByte(80))
        btnSaveChanges.FlatAppearance.BorderColor = Color.FromArgb(CByte(243), CByte(182), CByte(80))
        btnSaveChanges.FlatAppearance.BorderSize = 2
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.ForeColor = Color.Black
        btnSaveChanges.Location = New Point(91, 485)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(97, 32)
        btnSaveChanges.TabIndex = 1
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' nudAddSubtract
        ' 
        nudAddSubtract.Font = New Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudAddSubtract.Location = New Point(31, 169)
        nudAddSubtract.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        nudAddSubtract.Name = "nudAddSubtract"
        nudAddSubtract.Size = New Size(120, 21)
        nudAddSubtract.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(29, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 3
        Label1.Text = "Add/Subtract to Stock"
        ' 
        ' btnApplyToCell
        ' 
        btnApplyToCell.Location = New Point(66, 196)
        btnApplyToCell.Name = "btnApplyToCell"
        btnApplyToCell.Size = New Size(50, 23)
        btnApplyToCell.TabIndex = 4
        btnApplyToCell.Text = "Apply"
        btnApplyToCell.UseVisualStyleBackColor = True
        ' 
        ' btnAddItem
        ' 
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.Location = New Point(12, 424)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(176, 23)
        btnAddItem.TabIndex = 5
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.FlatAppearance.BorderSize = 0
        btnRemoveItem.Location = New Point(12, 453)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(176, 23)
        btnRemoveItem.TabIndex = 6
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Unispace", 9F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(750, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(26, 26)
        btnClose.TabIndex = 18
        btnClose.Text = "✖"
        btnClose.UseMnemonic = False
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 50)
        Label2.TabIndex = 19
        Label2.Text = "Stock" & vbCrLf & "Manager"
        ' 
        ' ManageStocks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg1
        ClientSize = New Size(800, 542)
        Controls.Add(Label2)
        Controls.Add(btnClose)
        Controls.Add(btnRemoveItem)
        Controls.Add(btnAddItem)
        Controls.Add(btnApplyToCell)
        Controls.Add(Label1)
        Controls.Add(nudAddSubtract)
        Controls.Add(btnSaveChanges)
        Controls.Add(dgvStocks)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManageStocks"
        Text = "Manage Stock"
        CType(dgvStocks, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAddSubtract, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents nudAddSubtract As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnApplyToCell As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
End Class
