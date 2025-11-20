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
        txtbDescription = New TextBox()
        nudExpenseAmount = New NumericUpDown()
        btnAddExpense = New Button()
        dgvExpenses = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        lblTotalExpenses = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cbPaymentStatus = New ComboBox()
        cbExpensesCategory = New ComboBox()
        dtpExpensesDueDate = New DateTimePicker()
        btnRemoveExpense = New Button()
        btnUpdateExpenses = New Button()
        btnMarkAsPaid = New Button()
        lblMonthlyExpenses = New Label()
        GroupBox2 = New GroupBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        GroupBox3 = New GroupBox()
        chkUseDateFilter = New CheckBox()
        Label10 = New Label()
        Label9 = New Label()
        cbFilterStatus = New ComboBox()
        cbFilterCategory = New ComboBox()
        btnClearFilters = New Button()
        Label8 = New Label()
        Label4 = New Label()
        btnApplyFilters = New Button()
        dtpTo = New DateTimePicker()
        dtpFrom = New DateTimePicker()
        CType(nudExpenseAmount, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtbDescription
        ' 
        txtbDescription.Location = New Point(96, 22)
        txtbDescription.Name = "txtbDescription"
        txtbDescription.Size = New Size(200, 23)
        txtbDescription.TabIndex = 1
        ' 
        ' nudExpenseAmount
        ' 
        nudExpenseAmount.DecimalPlaces = 2
        nudExpenseAmount.Location = New Point(96, 51)
        nudExpenseAmount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudExpenseAmount.Name = "nudExpenseAmount"
        nudExpenseAmount.Size = New Size(200, 23)
        nudExpenseAmount.TabIndex = 2
        ' 
        ' btnAddExpense
        ' 
        btnAddExpense.Cursor = Cursors.Hand
        btnAddExpense.ForeColor = Color.Black
        btnAddExpense.Location = New Point(212, 167)
        btnAddExpense.Name = "btnAddExpense"
        btnAddExpense.Size = New Size(84, 23)
        btnAddExpense.TabIndex = 3
        btnAddExpense.Text = "Add Expense"
        btnAddExpense.UseVisualStyleBackColor = True
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.BackgroundColor = SystemColors.ActiveCaption
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Dock = DockStyle.Bottom
        dgvExpenses.Location = New Point(0, 327)
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.Size = New Size(1135, 355)
        dgvExpenses.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(17, 30)
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
        Label2.Location = New Point(36, 59)
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
        lblTotalExpenses.Location = New Point(975, 55)
        lblTotalExpenses.Name = "lblTotalExpenses"
        lblTotalExpenses.Size = New Size(122, 50)
        lblTotalExpenses.TabIndex = 8
        lblTotalExpenses.Text = " ₱0.00"
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(cbPaymentStatus)
        GroupBox1.Controls.Add(cbExpensesCategory)
        GroupBox1.Controls.Add(dtpExpensesDueDate)
        GroupBox1.Controls.Add(txtbDescription)
        GroupBox1.Controls.Add(nudExpenseAmount)
        GroupBox1.Controls.Add(btnAddExpense)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(13, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(341, 200)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Expense Details"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(32, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 40
        Label5.Text = "Due Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.White
        Label6.Location = New Point(48, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 39
        Label6.Text = "Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(32, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 15)
        Label7.TabIndex = 38
        Label7.Text = "Category:"
        ' 
        ' cbPaymentStatus
        ' 
        cbPaymentStatus.Cursor = Cursors.Hand
        cbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbPaymentStatus.FormattingEnabled = True
        cbPaymentStatus.Location = New Point(96, 138)
        cbPaymentStatus.Name = "cbPaymentStatus"
        cbPaymentStatus.Size = New Size(200, 23)
        cbPaymentStatus.TabIndex = 37
        ' 
        ' cbExpensesCategory
        ' 
        cbExpensesCategory.Cursor = Cursors.Hand
        cbExpensesCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbExpensesCategory.FormattingEnabled = True
        cbExpensesCategory.Location = New Point(96, 109)
        cbExpensesCategory.Name = "cbExpensesCategory"
        cbExpensesCategory.Size = New Size(200, 23)
        cbExpensesCategory.TabIndex = 36
        ' 
        ' dtpExpensesDueDate
        ' 
        dtpExpensesDueDate.Cursor = Cursors.Hand
        dtpExpensesDueDate.Location = New Point(96, 80)
        dtpExpensesDueDate.Name = "dtpExpensesDueDate"
        dtpExpensesDueDate.Size = New Size(200, 23)
        dtpExpensesDueDate.TabIndex = 35
        ' 
        ' btnRemoveExpense
        ' 
        btnRemoveExpense.Cursor = Cursors.Hand
        btnRemoveExpense.ForeColor = Color.Black
        btnRemoveExpense.Location = New Point(223, 3)
        btnRemoveExpense.Name = "btnRemoveExpense"
        btnRemoveExpense.Size = New Size(106, 23)
        btnRemoveExpense.TabIndex = 34
        btnRemoveExpense.Text = "Remove Expense"
        btnRemoveExpense.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateExpenses
        ' 
        btnUpdateExpenses.Cursor = Cursors.Hand
        btnUpdateExpenses.ForeColor = Color.Black
        btnUpdateExpenses.Location = New Point(113, 3)
        btnUpdateExpenses.Name = "btnUpdateExpenses"
        btnUpdateExpenses.Size = New Size(104, 23)
        btnUpdateExpenses.TabIndex = 35
        btnUpdateExpenses.Text = "Update Expenses"
        btnUpdateExpenses.UseVisualStyleBackColor = True
        ' 
        ' btnMarkAsPaid
        ' 
        btnMarkAsPaid.Cursor = Cursors.Hand
        btnMarkAsPaid.ForeColor = Color.Black
        btnMarkAsPaid.Location = New Point(3, 3)
        btnMarkAsPaid.Name = "btnMarkAsPaid"
        btnMarkAsPaid.Size = New Size(104, 23)
        btnMarkAsPaid.TabIndex = 36
        btnMarkAsPaid.Text = "Mark as paid"
        btnMarkAsPaid.UseVisualStyleBackColor = True
        ' 
        ' lblMonthlyExpenses
        ' 
        lblMonthlyExpenses.AutoSize = True
        lblMonthlyExpenses.Location = New Point(961, 238)
        lblMonthlyExpenses.Name = "lblMonthlyExpenses"
        lblMonthlyExpenses.Size = New Size(52, 15)
        lblMonthlyExpenses.TabIndex = 37
        lblMonthlyExpenses.Text = "Monthly"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(FlowLayoutPanel1)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(13, 259)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(341, 55)
        GroupBox2.TabIndex = 38
        GroupBox2.TabStop = False
        GroupBox2.Text = "Table Controls"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnMarkAsPaid)
        FlowLayoutPanel1.Controls.Add(btnUpdateExpenses)
        FlowLayoutPanel1.Controls.Add(btnRemoveExpense)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(3, 19)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(335, 33)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(chkUseDateFilter)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(cbFilterStatus)
        GroupBox3.Controls.Add(cbFilterCategory)
        GroupBox3.Controls.Add(btnClearFilters)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(btnApplyFilters)
        GroupBox3.Controls.Add(dtpTo)
        GroupBox3.Controls.Add(dtpFrom)
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(378, 55)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(529, 259)
        GroupBox3.TabIndex = 39
        GroupBox3.TabStop = False
        GroupBox3.Text = "Filter"
        ' 
        ' chkUseDateFilter
        ' 
        chkUseDateFilter.AutoSize = True
        chkUseDateFilter.Location = New Point(296, 41)
        chkUseDateFilter.Name = "chkUseDateFilter"
        chkUseDateFilter.Size = New Size(99, 19)
        chkUseDateFilter.TabIndex = 43
        chkUseDateFilter.Text = "Filter by date?"
        chkUseDateFilter.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(40, 116)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 15)
        Label10.TabIndex = 42
        Label10.Text = "Status"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(24, 90)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 15)
        Label9.TabIndex = 41
        Label9.Text = "Category"
        ' 
        ' cbFilterStatus
        ' 
        cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilterStatus.FormattingEnabled = True
        cbFilterStatus.Location = New Point(85, 111)
        cbFilterStatus.Name = "cbFilterStatus"
        cbFilterStatus.Size = New Size(121, 23)
        cbFilterStatus.TabIndex = 40
        ' 
        ' cbFilterCategory
        ' 
        cbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilterCategory.FormattingEnabled = True
        cbFilterCategory.Location = New Point(85, 82)
        cbFilterCategory.Name = "cbFilterCategory"
        cbFilterCategory.Size = New Size(121, 23)
        cbFilterCategory.TabIndex = 39
        ' 
        ' btnClearFilters
        ' 
        btnClearFilters.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClearFilters.Cursor = Cursors.Hand
        btnClearFilters.ForeColor = Color.Black
        btnClearFilters.Location = New Point(293, 224)
        btnClearFilters.Name = "btnClearFilters"
        btnClearFilters.Size = New Size(106, 23)
        btnClearFilters.TabIndex = 38
        btnClearFilters.Text = "Reset Filters"
        btnClearFilters.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 57)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 15)
        Label8.TabIndex = 37
        Label8.Text = "End Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 36
        Label4.Text = "Start Date"
        ' 
        ' btnApplyFilters
        ' 
        btnApplyFilters.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnApplyFilters.Cursor = Cursors.Hand
        btnApplyFilters.ForeColor = Color.Black
        btnApplyFilters.Location = New Point(406, 224)
        btnApplyFilters.Name = "btnApplyFilters"
        btnApplyFilters.Size = New Size(106, 23)
        btnApplyFilters.TabIndex = 35
        btnApplyFilters.Text = "Apply Filters"
        btnApplyFilters.UseVisualStyleBackColor = True
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(85, 53)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 23)
        dtpTo.TabIndex = 1
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(85, 27)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 23)
        dtpFrom.TabIndex = 0
        ' 
        ' ExpensesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(lblMonthlyExpenses)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(lblTotalExpenses)
        Controls.Add(dgvExpenses)
        ForeColor = Color.White
        Name = "ExpensesControl"
        Size = New Size(1135, 682)
        CType(nudExpenseAmount, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtbDescription As TextBox
    Friend WithEvents nudExpenseAmount As NumericUpDown
    Friend WithEvents btnAddExpense As Button
    Friend WithEvents dgvExpenses As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbPaymentStatus As ComboBox
    Friend WithEvents cbExpensesCategory As ComboBox
    Friend WithEvents dtpExpensesDueDate As DateTimePicker
    Friend WithEvents btnRemoveExpense As Button
    Friend WithEvents btnUpdateExpenses As Button
    Friend WithEvents btnMarkAsPaid As Button
    Friend WithEvents lblMonthlyExpenses As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnApplyFilters As Button
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents cbFilterStatus As ComboBox
    Friend WithEvents cbFilterCategory As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chkUseDateFilter As CheckBox

End Class
