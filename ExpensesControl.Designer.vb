<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpensesControl
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
        dtpExpenseDate = New DateTimePicker()
        txtbDescription = New TextBox()
        nudExpenseAmount = New NumericUpDown()
        btnAddExpense = New Button()
        btnRemoveExpense = New Button()
        dgvExpenses = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        lblTotalExpenses = New Label()
        Label4 = New Label()
        Label3 = New Label()
        CType(nudExpenseAmount, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpExpenseDate
        ' 
        dtpExpenseDate.Format = DateTimePickerFormat.Custom
        dtpExpenseDate.Location = New Point(113, 144)
        dtpExpenseDate.Name = "dtpExpenseDate"
        dtpExpenseDate.Size = New Size(200, 23)
        dtpExpenseDate.TabIndex = 0
        dtpExpenseDate.Value = New Date(2025, 11, 17, 22, 19, 6, 0)
        ' 
        ' txtbDescription
        ' 
        txtbDescription.Location = New Point(113, 86)
        txtbDescription.Name = "txtbDescription"
        txtbDescription.Size = New Size(200, 23)
        txtbDescription.TabIndex = 1
        ' 
        ' nudExpenseAmount
        ' 
        nudExpenseAmount.DecimalPlaces = 2
        nudExpenseAmount.Location = New Point(113, 115)
        nudExpenseAmount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudExpenseAmount.Name = "nudExpenseAmount"
        nudExpenseAmount.Size = New Size(200, 23)
        nudExpenseAmount.TabIndex = 2
        ' 
        ' btnAddExpense
        ' 
        btnAddExpense.ForeColor = Color.Black
        btnAddExpense.Location = New Point(113, 184)
        btnAddExpense.Name = "btnAddExpense"
        btnAddExpense.Size = New Size(84, 23)
        btnAddExpense.TabIndex = 3
        btnAddExpense.Text = "Add Expense"
        btnAddExpense.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveExpense
        ' 
        btnRemoveExpense.ForeColor = Color.Black
        btnRemoveExpense.Location = New Point(484, 184)
        btnRemoveExpense.Name = "btnRemoveExpense"
        btnRemoveExpense.Size = New Size(75, 23)
        btnRemoveExpense.TabIndex = 4
        btnRemoveExpense.Text = "Remove Expense"
        btnRemoveExpense.UseVisualStyleBackColor = True
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.BackgroundColor = SystemColors.ActiveCaption
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Dock = DockStyle.Bottom
        dgvExpenses.Location = New Point(0, 227)
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.Size = New Size(1135, 455)
        dgvExpenses.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(34, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 6
        Label1.Text = "Description: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(47, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 7
        Label2.Text = "Amount:"
        ' 
        ' lblTotalExpenses
        ' 
        lblTotalExpenses.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalExpenses.AutoSize = True
        lblTotalExpenses.BackColor = Color.White
        lblTotalExpenses.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalExpenses.ForeColor = Color.IndianRed
        lblTotalExpenses.Location = New Point(868, 86)
        lblTotalExpenses.Name = "lblTotalExpenses"
        lblTotalExpenses.Size = New Size(122, 50)
        lblTotalExpenses.TabIndex = 8
        lblTotalExpenses.Text = " ₱0.00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(67, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 9
        Label4.Text = "Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(13, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 25)
        Label3.TabIndex = 29
        Label3.Text = "Expenses"
        ' 
        ' ExpensesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(lblTotalExpenses)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvExpenses)
        Controls.Add(btnRemoveExpense)
        Controls.Add(btnAddExpense)
        Controls.Add(nudExpenseAmount)
        Controls.Add(txtbDescription)
        Controls.Add(dtpExpenseDate)
        ForeColor = Color.White
        Name = "ExpensesControl"
        Size = New Size(1135, 682)
        CType(nudExpenseAmount, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpExpenseDate As DateTimePicker
    Friend WithEvents txtbDescription As TextBox
    Friend WithEvents nudExpenseAmount As NumericUpDown
    Friend WithEvents btnAddExpense As Button
    Friend WithEvents btnRemoveExpense As Button
    Friend WithEvents dgvExpenses As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label

End Class
