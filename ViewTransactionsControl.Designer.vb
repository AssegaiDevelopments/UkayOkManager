<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTransactionsControl
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label9 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnCloseDetails = New Button()
        dgvTransactionItems = New DataGridView()
        lblRemarks = New Label()
        lblStatus = New Label()
        lblTransactionType = New Label()
        lblUsername = New Label()
        lblPaymentMethod = New Label()
        lblTransactionDate = New Label()
        lblTotalAmount = New Label()
        lblTransactionID = New Label()
        pnlDetails = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        btnRefresh = New Button()
        dgvTransactions = New DataGridView()
        BufferedPanel1 = New BufferedPanel()
        BufferedPanel2 = New BufferedPanel()
        GroupBox1 = New GroupBox()
        txtSearchUser = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        chkDateFrom = New CheckBox()
        nudMinAmount = New NumericUpDown()
        nudMaxAmount = New NumericUpDown()
        Label12 = New Label()
        dtpFromDate = New DateTimePicker()
        Label11 = New Label()
        dtpToDate = New DateTimePicker()
        btnResetFilters = New Button()
        chkDateTo = New CheckBox()
        btnApplyFilters = New Button()
        cmbStatus = New ComboBox()
        cmbPaymentMethod = New ComboBox()
        Label10 = New Label()
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).BeginInit()
        pnlDetails.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        BufferedPanel1.SuspendLayout()
        BufferedPanel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(nudMinAmount, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMaxAmount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(524, 5)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 15)
        Label9.TabIndex = 17
        Label9.Text = "Detailed View"
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ImageAlign = ContentAlignment.BottomCenter
        Label7.Location = New Point(760, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 28)
        Label7.TabIndex = 16
        Label7.Text = "Total Amount:"
        Label7.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(522, 66)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 15
        Label8.Text = "Status:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(467, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 14
        Label5.Text = "Transaction Type:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(530, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 13
        Label6.Text = "Date:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(123, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 12
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(84, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 11
        Label3.Text = "Payment Method:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(102, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 10
        Label4.Text = "Transaction ID:"
        ' 
        ' btnCloseDetails
        ' 
        btnCloseDetails.Cursor = Cursors.Hand
        btnCloseDetails.FlatStyle = FlatStyle.Flat
        btnCloseDetails.Location = New Point(0, 1)
        btnCloseDetails.Margin = New Padding(3, 3, 3, 6)
        btnCloseDetails.Name = "btnCloseDetails"
        btnCloseDetails.Size = New Size(30, 30)
        btnCloseDetails.TabIndex = 9
        btnCloseDetails.Text = "x"
        btnCloseDetails.UseVisualStyleBackColor = True
        ' 
        ' dgvTransactionItems
        ' 
        dgvTransactionItems.BackgroundColor = Color.White
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.MediumAquamarine
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvTransactionItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvTransactionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionItems.Location = New Point(37, 115)
        dgvTransactionItems.Name = "dgvTransactionItems"
        dgvTransactionItems.ReadOnly = True
        dgvTransactionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactionItems.Size = New Size(1068, 294)
        dgvTransactionItems.TabIndex = 8
        ' 
        ' lblRemarks
        ' 
        lblRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI", 9F)
        lblRemarks.Location = New Point(792, 1)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(52, 28)
        lblRemarks.TabIndex = 7
        lblRemarks.Text = "Remarks"
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.Left
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(571, 65)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(46, 17)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status"
        ' 
        ' lblTransactionType
        ' 
        lblTransactionType.Anchor = AnchorStyles.Left
        lblTransactionType.AutoSize = True
        lblTransactionType.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionType.Location = New Point(571, 35)
        lblTransactionType.Name = "lblTransactionType"
        lblTransactionType.Size = New Size(108, 17)
        lblTransactionType.TabIndex = 5
        lblTransactionType.Text = "TransactionType"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.Left
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblUsername.Location = New Point(193, 35)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 17)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.Anchor = AnchorStyles.Left
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblPaymentMethod.Location = New Point(193, 65)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(110, 17)
        lblPaymentMethod.TabIndex = 3
        lblPaymentMethod.Text = "PaymentMethod"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.Anchor = AnchorStyles.Left
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionDate.Location = New Point(571, 6)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(108, 17)
        lblTransactionDate.TabIndex = 2
        lblTransactionDate.Text = "TransactionDate"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Dock = DockStyle.Fill
        lblTotalAmount.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.ForeColor = Color.PeachPuff
        lblTotalAmount.Location = New Point(760, 59)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(117, 29)
        lblTotalAmount.TabIndex = 1
        lblTotalAmount.Text = "Total Amount"
        lblTotalAmount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.Anchor = AnchorStyles.Left
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionID.Location = New Point(193, 6)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(93, 17)
        lblTransactionID.TabIndex = 0
        lblTransactionID.Text = "TransactionID"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.AutoSize = True
        pnlDetails.BackColor = Color.SteelBlue
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(TableLayoutPanel1)
        pnlDetails.Controls.Add(Label9)
        pnlDetails.Controls.Add(btnCloseDetails)
        pnlDetails.Controls.Add(dgvTransactionItems)
        pnlDetails.Dock = DockStyle.Bottom
        pnlDetails.ForeColor = Color.White
        pnlDetails.Location = New Point(0, 268)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(1135, 414)
        pnlDetails.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TableLayoutPanel1.Controls.Add(Label4, 0, 0)
        TableLayoutPanel1.Controls.Add(lblTransactionID, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(Label8, 2, 2)
        TableLayoutPanel1.Controls.Add(lblUsername, 1, 1)
        TableLayoutPanel1.Controls.Add(Label5, 2, 1)
        TableLayoutPanel1.Controls.Add(lblStatus, 3, 2)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(Label6, 2, 0)
        TableLayoutPanel1.Controls.Add(lblPaymentMethod, 1, 2)
        TableLayoutPanel1.Controls.Add(lblTransactionType, 3, 1)
        TableLayoutPanel1.Controls.Add(lblTransactionDate, 3, 0)
        TableLayoutPanel1.Controls.Add(lblRemarks, 4, 0)
        TableLayoutPanel1.Controls.Add(Label7, 4, 1)
        TableLayoutPanel1.Controls.Add(lblTotalAmount, 4, 2)
        TableLayoutPanel1.Location = New Point(126, 20)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(881, 89)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(59, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 25)
        Label1.TabIndex = 6
        Label1.Text = "Transactions History"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Transparent
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(18, 8)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(33, 35)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "⟳"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AllowUserToDeleteRows = False
        dgvTransactions.AllowUserToOrderColumns = True
        dgvTransactions.BackgroundColor = Color.White
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.MediumAquamarine
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Dock = DockStyle.Fill
        dgvTransactions.Location = New Point(20, 172)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(1095, 96)
        dgvTransactions.TabIndex = 4
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.Controls.Add(dgvTransactions)
        BufferedPanel1.Controls.Add(BufferedPanel2)
        BufferedPanel1.Dock = DockStyle.Fill
        BufferedPanel1.Location = New Point(0, 0)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Padding = New Padding(20, 0, 20, 0)
        BufferedPanel1.Size = New Size(1135, 268)
        BufferedPanel1.TabIndex = 8
        ' 
        ' BufferedPanel2
        ' 
        BufferedPanel2.Controls.Add(GroupBox1)
        BufferedPanel2.Controls.Add(btnRefresh)
        BufferedPanel2.Controls.Add(Label1)
        BufferedPanel2.Dock = DockStyle.Top
        BufferedPanel2.Location = New Point(20, 0)
        BufferedPanel2.Name = "BufferedPanel2"
        BufferedPanel2.Size = New Size(1095, 172)
        BufferedPanel2.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtSearchUser)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(chkDateFrom)
        GroupBox1.Controls.Add(nudMinAmount)
        GroupBox1.Controls.Add(nudMaxAmount)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(dtpFromDate)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(dtpToDate)
        GroupBox1.Controls.Add(btnResetFilters)
        GroupBox1.Controls.Add(chkDateTo)
        GroupBox1.Controls.Add(btnApplyFilters)
        GroupBox1.Controls.Add(cmbStatus)
        GroupBox1.Controls.Add(cmbPaymentMethod)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Dock = DockStyle.Bottom
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(0, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1095, 123)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' txtSearchUser
        ' 
        txtSearchUser.Anchor = AnchorStyles.None
        txtSearchUser.Location = New Point(747, 61)
        txtSearchUser.Name = "txtSearchUser"
        txtSearchUser.Size = New Size(191, 23)
        txtSearchUser.TabIndex = 7
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(574, 16)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 15)
        Label13.TabIndex = 21
        Label13.Text = "Payment Method"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.ForeColor = Color.White
        Label14.Location = New Point(574, 69)
        Label14.Name = "Label14"
        Label14.Size = New Size(39, 15)
        Label14.TabIndex = 22
        Label14.Text = "Status"
        ' 
        ' chkDateFrom
        ' 
        chkDateFrom.Anchor = AnchorStyles.None
        chkDateFrom.AutoSize = True
        chkDateFrom.ForeColor = Color.White
        chkDateFrom.Location = New Point(300, 12)
        chkDateFrom.Name = "chkDateFrom"
        chkDateFrom.Size = New Size(81, 19)
        chkDateFrom.TabIndex = 12
        chkDateFrom.Text = "Date From"
        chkDateFrom.UseVisualStyleBackColor = True
        ' 
        ' nudMinAmount
        ' 
        nudMinAmount.Anchor = AnchorStyles.None
        nudMinAmount.Location = New Point(59, 36)
        nudMinAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        nudMinAmount.Name = "nudMinAmount"
        nudMinAmount.Size = New Size(146, 23)
        nudMinAmount.TabIndex = 8
        ' 
        ' nudMaxAmount
        ' 
        nudMaxAmount.Anchor = AnchorStyles.None
        nudMaxAmount.Location = New Point(59, 87)
        nudMaxAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        nudMaxAmount.Name = "nudMaxAmount"
        nudMaxAmount.Size = New Size(146, 23)
        nudMaxAmount.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(94, 69)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 15)
        Label12.TabIndex = 20
        Label12.Text = "Max Amount:"
        ' 
        ' dtpFromDate
        ' 
        dtpFromDate.Anchor = AnchorStyles.None
        dtpFromDate.Location = New Point(300, 34)
        dtpFromDate.Name = "dtpFromDate"
        dtpFromDate.Size = New Size(200, 23)
        dtpFromDate.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(92, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(81, 15)
        Label11.TabIndex = 19
        Label11.Text = "Min. Amount:"
        ' 
        ' dtpToDate
        ' 
        dtpToDate.Anchor = AnchorStyles.None
        dtpToDate.Location = New Point(300, 92)
        dtpToDate.Name = "dtpToDate"
        dtpToDate.Size = New Size(200, 23)
        dtpToDate.TabIndex = 11
        ' 
        ' btnResetFilters
        ' 
        btnResetFilters.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnResetFilters.ForeColor = Color.Black
        btnResetFilters.Location = New Point(978, 69)
        btnResetFilters.Name = "btnResetFilters"
        btnResetFilters.Size = New Size(90, 36)
        btnResetFilters.TabIndex = 18
        btnResetFilters.Text = "Reset Filters"
        btnResetFilters.UseVisualStyleBackColor = True
        ' 
        ' chkDateTo
        ' 
        chkDateTo.Anchor = AnchorStyles.None
        chkDateTo.AutoSize = True
        chkDateTo.ForeColor = Color.White
        chkDateTo.Location = New Point(300, 67)
        chkDateTo.Name = "chkDateTo"
        chkDateTo.Size = New Size(65, 19)
        chkDateTo.TabIndex = 13
        chkDateTo.Text = "Date To"
        chkDateTo.UseVisualStyleBackColor = True
        ' 
        ' btnApplyFilters
        ' 
        btnApplyFilters.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnApplyFilters.ForeColor = Color.Black
        btnApplyFilters.Location = New Point(978, 27)
        btnApplyFilters.Name = "btnApplyFilters"
        btnApplyFilters.Size = New Size(90, 36)
        btnApplyFilters.TabIndex = 17
        btnApplyFilters.Text = "Apply Filters"
        btnApplyFilters.UseVisualStyleBackColor = True
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.None
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"All", "Completed", "Pending"})
        cmbStatus.Location = New Point(574, 87)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 23)
        cmbStatus.TabIndex = 14
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.Anchor = AnchorStyles.None
        cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Items.AddRange(New Object() {"All", "Cash", "GCash"})
        cmbPaymentMethod.Location = New Point(574, 37)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(121, 23)
        cmbPaymentMethod.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(747, 43)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 15)
        Label10.TabIndex = 15
        Label10.Text = "User:"
        ' 
        ' ViewTransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Transparent
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(BufferedPanel1)
        Controls.Add(pnlDetails)
        Name = "ViewTransactionsControl"
        Size = New Size(1135, 682)
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).EndInit()
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        BufferedPanel1.ResumeLayout(False)
        BufferedPanel2.ResumeLayout(False)
        BufferedPanel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudMinAmount, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMaxAmount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCloseDetails As Button
    Friend WithEvents dgvTransactionItems As DataGridView
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTransactionType As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BufferedPanel1 As BufferedPanel
    Friend WithEvents BufferedPanel2 As BufferedPanel
    Friend WithEvents btnResetFilters As Button
    Friend WithEvents btnApplyFilters As Button
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents chkDateTo As CheckBox
    Friend WithEvents chkDateFrom As CheckBox
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents nudMaxAmount As NumericUpDown
    Friend WithEvents nudMinAmount As NumericUpDown
    Friend WithEvents txtSearchUser As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label

End Class
