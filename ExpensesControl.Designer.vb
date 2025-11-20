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
        btnUpdateExpenses = New Button()
        Label7 = New Label()
        cbPaymentStatus = New ComboBox()
        cbExpensesCategory = New ComboBox()
        dtpExpensesDueDate = New DateTimePicker()
        btnRemoveExpense = New Button()
        btnMarkAsPaid = New Button()
        GroupBox2 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnExportCSV = New Button()
        chkExportAll = New CheckBox()
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
        chartDailyExpenses = New ScottPlot.WinForms.FormsPlot()
        chartCategoryExpenses = New ScottPlot.WinForms.FormsPlot()
        RoundedPanel1 = New RoundedPanel()
        lblExpensesMode = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        RoundedPanel2 = New RoundedPanel()
        lbl45 = New Label()
        lblTotalPaidExpenses = New Label()
        Label11 = New Label()
        Label12 = New Label()
        CType(nudExpenseAmount, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtbDescription
        ' 
        txtbDescription.Location = New Point(96, 109)
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
        btnAddExpense.Location = New Point(192, 178)
        btnAddExpense.Name = "btnAddExpense"
        btnAddExpense.Size = New Size(104, 23)
        btnAddExpense.TabIndex = 3
        btnAddExpense.Text = "Add Expense"
        btnAddExpense.UseVisualStyleBackColor = True
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.BackgroundColor = Color.White
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Dock = DockStyle.Bottom
        dgvExpenses.Location = New Point(0, 443)
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.Size = New Size(1135, 239)
        dgvExpenses.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(23, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 6
        Label1.Text = "Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(39, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 7
        Label2.Text = "Amount"
        ' 
        ' lblTotalExpenses
        ' 
        lblTotalExpenses.Anchor = AnchorStyles.None
        lblTotalExpenses.AutoSize = True
        lblTotalExpenses.BackColor = Color.Transparent
        lblTotalExpenses.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalExpenses.ForeColor = Color.IndianRed
        lblTotalExpenses.Location = New Point(3, 18)
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
        GroupBox1.Controls.Add(btnAddExpense)
        GroupBox1.Controls.Add(btnUpdateExpenses)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(cbPaymentStatus)
        GroupBox1.Controls.Add(cbExpensesCategory)
        GroupBox1.Controls.Add(dtpExpensesDueDate)
        GroupBox1.Controls.Add(txtbDescription)
        GroupBox1.Controls.Add(nudExpenseAmount)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(13, 209)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(329, 214)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add/Update Expense"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(35, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 40
        Label5.Text = "Due Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.White
        Label6.Location = New Point(51, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 39
        Label6.Text = "Status"
        ' 
        ' btnUpdateExpenses
        ' 
        btnUpdateExpenses.Cursor = Cursors.Hand
        btnUpdateExpenses.ForeColor = Color.Black
        btnUpdateExpenses.Location = New Point(27, 178)
        btnUpdateExpenses.Name = "btnUpdateExpenses"
        btnUpdateExpenses.Size = New Size(148, 23)
        btnUpdateExpenses.TabIndex = 35
        btnUpdateExpenses.Text = "Update Selected Expense"
        btnUpdateExpenses.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(35, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 38
        Label7.Text = "Category"
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
        cbExpensesCategory.Location = New Point(96, 22)
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
        btnRemoveExpense.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRemoveExpense.Cursor = Cursors.Hand
        btnRemoveExpense.ForeColor = Color.Black
        btnRemoveExpense.Location = New Point(3, 54)
        btnRemoveExpense.Name = "btnRemoveExpense"
        btnRemoveExpense.Size = New Size(120, 32)
        btnRemoveExpense.TabIndex = 34
        btnRemoveExpense.Text = "Remove Expense"
        btnRemoveExpense.UseVisualStyleBackColor = True
        ' 
        ' btnMarkAsPaid
        ' 
        btnMarkAsPaid.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnMarkAsPaid.Cursor = Cursors.Hand
        btnMarkAsPaid.ForeColor = Color.Black
        btnMarkAsPaid.Location = New Point(3, 7)
        btnMarkAsPaid.Name = "btnMarkAsPaid"
        btnMarkAsPaid.Size = New Size(120, 32)
        btnMarkAsPaid.TabIndex = 36
        btnMarkAsPaid.Text = "Mark as paid"
        btnMarkAsPaid.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(365, 213)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(132, 210)
        GroupBox2.TabIndex = 38
        GroupBox2.TabStop = False
        GroupBox2.Text = "Table Controls"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnRemoveExpense, 0, 1)
        TableLayoutPanel1.Controls.Add(btnExportCSV, 0, 2)
        TableLayoutPanel1.Controls.Add(chkExportAll, 0, 3)
        TableLayoutPanel1.Controls.Add(btnMarkAsPaid, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 19)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(126, 188)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnExportCSV
        ' 
        btnExportCSV.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnExportCSV.Cursor = Cursors.Hand
        btnExportCSV.ForeColor = Color.Black
        btnExportCSV.Location = New Point(3, 101)
        btnExportCSV.Name = "btnExportCSV"
        btnExportCSV.Size = New Size(120, 32)
        btnExportCSV.TabIndex = 43
        btnExportCSV.Text = "Export as CSV"
        btnExportCSV.UseVisualStyleBackColor = True
        ' 
        ' chkExportAll
        ' 
        chkExportAll.Location = New Point(3, 144)
        chkExportAll.Name = "chkExportAll"
        chkExportAll.Size = New Size(120, 40)
        chkExportAll.TabIndex = 42
        chkExportAll.Text = "Export Everything?"
        chkExportAll.UseVisualStyleBackColor = True
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
        GroupBox3.Location = New Point(13, 56)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(484, 132)
        GroupBox3.TabIndex = 39
        GroupBox3.TabStop = False
        GroupBox3.Text = "Filter"
        ' 
        ' chkUseDateFilter
        ' 
        chkUseDateFilter.AutoSize = True
        chkUseDateFilter.Location = New Point(25, 82)
        chkUseDateFilter.Name = "chkUseDateFilter"
        chkUseDateFilter.Size = New Size(99, 19)
        chkUseDateFilter.TabIndex = 43
        chkUseDateFilter.Text = "Filter by date?"
        chkUseDateFilter.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(307, 59)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 15)
        Label10.TabIndex = 42
        Label10.Text = "Status"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(291, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 15)
        Label9.TabIndex = 41
        Label9.Text = "Category"
        ' 
        ' cbFilterStatus
        ' 
        cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilterStatus.FormattingEnabled = True
        cbFilterStatus.Location = New Point(352, 54)
        cbFilterStatus.Name = "cbFilterStatus"
        cbFilterStatus.Size = New Size(121, 23)
        cbFilterStatus.TabIndex = 40
        ' 
        ' cbFilterCategory
        ' 
        cbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilterCategory.FormattingEnabled = True
        cbFilterCategory.Location = New Point(352, 25)
        cbFilterCategory.Name = "cbFilterCategory"
        cbFilterCategory.Size = New Size(121, 23)
        cbFilterCategory.TabIndex = 39
        ' 
        ' btnClearFilters
        ' 
        btnClearFilters.Cursor = Cursors.Hand
        btnClearFilters.ForeColor = Color.Black
        btnClearFilters.Location = New Point(255, 94)
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
        btnApplyFilters.Cursor = Cursors.Hand
        btnApplyFilters.ForeColor = Color.Black
        btnApplyFilters.Location = New Point(367, 94)
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
        ' chartDailyExpenses
        ' 
        chartDailyExpenses.BorderStyle = BorderStyle.FixedSingle
        chartDailyExpenses.DisplayScale = 1F
        chartDailyExpenses.Dock = DockStyle.Fill
        chartDailyExpenses.Location = New Point(307, 3)
        chartDailyExpenses.Name = "chartDailyExpenses"
        chartDailyExpenses.Size = New Size(298, 191)
        chartDailyExpenses.TabIndex = 40
        ' 
        ' chartCategoryExpenses
        ' 
        chartCategoryExpenses.BorderStyle = BorderStyle.FixedSingle
        chartCategoryExpenses.DisplayScale = 1F
        chartCategoryExpenses.Dock = DockStyle.Fill
        chartCategoryExpenses.Location = New Point(3, 200)
        chartCategoryExpenses.Name = "chartCategoryExpenses"
        chartCategoryExpenses.Size = New Size(298, 191)
        chartCategoryExpenses.TabIndex = 41
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(lblExpensesMode)
        RoundedPanel1.Controls.Add(lblTotalExpenses)
        RoundedPanel1.Controls.Add(Label12)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Dock = DockStyle.Fill
        RoundedPanel1.Location = New Point(307, 200)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(298, 191)
        RoundedPanel1.TabIndex = 44
        ' 
        ' lblExpensesMode
        ' 
        lblExpensesMode.Anchor = AnchorStyles.None
        lblExpensesMode.AutoSize = True
        lblExpensesMode.BackColor = Color.Transparent
        lblExpensesMode.ForeColor = Color.Black
        lblExpensesMode.Location = New Point(20, 68)
        lblExpensesMode.Name = "lblExpensesMode"
        lblExpensesMode.Size = New Size(124, 15)
        lblExpensesMode.TabIndex = 9
        lblExpensesMode.Text = "Total Unpaid Expenses"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(RoundedPanel2, 0, 0)
        TableLayoutPanel2.Controls.Add(chartDailyExpenses, 1, 0)
        TableLayoutPanel2.Controls.Add(RoundedPanel1, 1, 1)
        TableLayoutPanel2.Controls.Add(chartCategoryExpenses, 0, 1)
        TableLayoutPanel2.Location = New Point(524, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(608, 414)
        TableLayoutPanel2.TabIndex = 45
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.White
        RoundedPanel2.Controls.Add(lbl45)
        RoundedPanel2.Controls.Add(lblTotalPaidExpenses)
        RoundedPanel2.Controls.Add(Label11)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Dock = DockStyle.Fill
        RoundedPanel2.Location = New Point(3, 3)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(298, 191)
        RoundedPanel2.TabIndex = 45
        ' 
        ' lbl45
        ' 
        lbl45.Anchor = AnchorStyles.None
        lbl45.AutoSize = True
        lbl45.BackColor = Color.Transparent
        lbl45.ForeColor = Color.Black
        lbl45.Location = New Point(95, 122)
        lbl45.Name = "lbl45"
        lbl45.Size = New Size(109, 15)
        lbl45.TabIndex = 9
        lbl45.Text = "Total Paid Expenses"
        lbl45.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalPaidExpenses
        ' 
        lblTotalPaidExpenses.Anchor = AnchorStyles.None
        lblTotalPaidExpenses.AutoSize = True
        lblTotalPaidExpenses.BackColor = Color.Transparent
        lblTotalPaidExpenses.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPaidExpenses.ForeColor = Color.Green
        lblTotalPaidExpenses.Location = New Point(88, 70)
        lblTotalPaidExpenses.Name = "lblTotalPaidExpenses"
        lblTotalPaidExpenses.RightToLeft = RightToLeft.No
        lblTotalPaidExpenses.Size = New Size(122, 50)
        lblTotalPaidExpenses.TabIndex = 8
        lblTotalPaidExpenses.Text = " ₱0.00" & vbCrLf
        lblTotalPaidExpenses.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.WhiteSmoke
        Label11.Location = New Point(-48, 98)
        Label11.Name = "Label11"
        Label11.Size = New Size(179, 128)
        Label11.TabIndex = 10
        Label11.Text = "📉"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.WhiteSmoke
        Label12.Location = New Point(125, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(179, 128)
        Label12.TabIndex = 11
        Label12.Text = "📊"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ExpensesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(TableLayoutPanel2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(dgvExpenses)
        ForeColor = Color.White
        Name = "ExpensesControl"
        Size = New Size(1135, 682)
        CType(nudExpenseAmount, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents chartDailyExpenses As ScottPlot.WinForms.FormsPlot
    Friend WithEvents chartCategoryExpenses As ScottPlot.WinForms.FormsPlot
    Friend WithEvents chkExportAll As CheckBox
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lblExpensesMode As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents lbl45 As Label
    Friend WithEvents lblTotalPaidExpenses As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label

End Class
