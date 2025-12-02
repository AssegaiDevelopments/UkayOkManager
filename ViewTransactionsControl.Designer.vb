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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        TableLayoutPanel2 = New TableLayoutPanel()
        BufferedPanel3 = New BufferedPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        BufferedPanel4 = New BufferedPanel()
        Label1 = New Label()
        btnRefresh = New Button()
        dgvTransactions = New DataGridView()
        BufferedPanel1 = New BufferedPanel()
        BufferedPanel2 = New BufferedPanel()
        GroupBox1 = New GroupBox()
        btnRemoveTrans = New Button()
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
        TableLayoutPanel2.SuspendLayout()
        BufferedPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        BufferedPanel4.SuspendLayout()
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
        Label9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(741, 45)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(131, 25)
        Label9.TabIndex = 17
        Label9.Text = "Detailed View"
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ImageAlign = ContentAlignment.BottomCenter
        Label7.Location = New Point(1085, 50)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 48)
        Label7.TabIndex = 16
        Label7.Text = "Total Amount:"
        Label7.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(742, 110)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 25)
        Label8.TabIndex = 15
        Label8.Text = "Status:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(660, 61)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 25)
        Label5.TabIndex = 14
        Label5.Text = "Transaction Type:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(753, 12)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 25)
        Label6.TabIndex = 13
        Label6.Text = "Date:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(171, 61)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 12
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(114, 110)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 25)
        Label3.TabIndex = 11
        Label3.Text = "Payment Method:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(139, 12)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 25)
        Label4.TabIndex = 10
        Label4.Text = "Transaction ID:"
        ' 
        ' btnCloseDetails
        ' 
        btnCloseDetails.Cursor = Cursors.Hand
        btnCloseDetails.FlatStyle = FlatStyle.Flat
        btnCloseDetails.Location = New Point(-7, 38)
        btnCloseDetails.Margin = New Padding(4, 5, 4, 10)
        btnCloseDetails.Name = "btnCloseDetails"
        btnCloseDetails.Size = New Size(43, 50)
        btnCloseDetails.TabIndex = 9
        btnCloseDetails.Text = "x"
        btnCloseDetails.UseVisualStyleBackColor = True
        ' 
        ' dgvTransactionItems
        ' 
        dgvTransactionItems.BackgroundColor = Color.White
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.MediumAquamarine
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvTransactionItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvTransactionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionItems.Dock = DockStyle.Fill
        dgvTransactionItems.Location = New Point(49, 0)
        dgvTransactionItems.Margin = New Padding(4, 5, 4, 5)
        dgvTransactionItems.Name = "dgvTransactionItems"
        dgvTransactionItems.ReadOnly = True
        dgvTransactionItems.RowHeadersWidth = 62
        dgvTransactionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactionItems.Size = New Size(1513, 381)
        dgvTransactionItems.TabIndex = 8
        ' 
        ' lblRemarks
        ' 
        lblRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI", 9F)
        lblRemarks.Location = New Point(1130, 1)
        lblRemarks.Margin = New Padding(4, 0, 4, 0)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(79, 48)
        lblRemarks.TabIndex = 7
        lblRemarks.Text = "Remarks"
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.Left
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(815, 109)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(67, 28)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status"
        ' 
        ' lblTransactionType
        ' 
        lblTransactionType.Anchor = AnchorStyles.Left
        lblTransactionType.AutoSize = True
        lblTransactionType.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionType.Location = New Point(815, 60)
        lblTransactionType.Margin = New Padding(4, 0, 4, 0)
        lblTransactionType.Name = "lblTransactionType"
        lblTransactionType.Size = New Size(166, 28)
        lblTransactionType.TabIndex = 5
        lblTransactionType.Text = "TransactionType"
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.Left
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblUsername.Location = New Point(275, 60)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(106, 28)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.Anchor = AnchorStyles.Left
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblPaymentMethod.Location = New Point(275, 109)
        lblPaymentMethod.Margin = New Padding(4, 0, 4, 0)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(169, 28)
        lblPaymentMethod.TabIndex = 3
        lblPaymentMethod.Text = "PaymentMethod"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.Anchor = AnchorStyles.Left
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionDate.Location = New Point(815, 11)
        lblTransactionDate.Margin = New Padding(4, 0, 4, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(166, 28)
        lblTransactionDate.TabIndex = 2
        lblTransactionDate.Text = "TransactionDate"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Dock = DockStyle.Fill
        lblTotalAmount.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.ForeColor = Color.PeachPuff
        lblTotalAmount.Location = New Point(1085, 99)
        lblTotalAmount.Margin = New Padding(4, 0, 4, 0)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(169, 48)
        lblTotalAmount.TabIndex = 1
        lblTotalAmount.Text = "Total Amount"
        lblTotalAmount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.Anchor = AnchorStyles.Left
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionID.Location = New Point(275, 11)
        lblTransactionID.Margin = New Padding(4, 0, 4, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(142, 28)
        lblTransactionID.TabIndex = 0
        lblTransactionID.Text = "TransactionID"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.AutoSize = True
        pnlDetails.BackColor = Color.SteelBlue
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(TableLayoutPanel2)
        pnlDetails.Dock = DockStyle.Bottom
        pnlDetails.ForeColor = Color.White
        pnlDetails.Location = New Point(0, 502)
        pnlDetails.Margin = New Padding(4, 5, 4, 5)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(1621, 635)
        pnlDetails.TabIndex = 7
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(BufferedPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(BufferedPanel4, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 38.29787F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 61.70213F))
        TableLayoutPanel2.Size = New Size(1619, 633)
        TableLayoutPanel2.TabIndex = 19
        ' 
        ' BufferedPanel3
        ' 
        BufferedPanel3.BackColor = Color.Transparent
        BufferedPanel3.Controls.Add(TableLayoutPanel1)
        BufferedPanel3.Controls.Add(btnCloseDetails)
        BufferedPanel3.Controls.Add(Label9)
        BufferedPanel3.Dock = DockStyle.Fill
        BufferedPanel3.Location = New Point(4, 5)
        BufferedPanel3.Margin = New Padding(4, 5, 4, 5)
        BufferedPanel3.Name = "BufferedPanel3"
        BufferedPanel3.Size = New Size(1611, 232)
        BufferedPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 177F))
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
        TableLayoutPanel1.Location = New Point(173, 70)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(1259, 148)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' BufferedPanel4
        ' 
        BufferedPanel4.Controls.Add(dgvTransactionItems)
        BufferedPanel4.Dock = DockStyle.Fill
        BufferedPanel4.Location = New Point(4, 247)
        BufferedPanel4.Margin = New Padding(4, 5, 4, 5)
        BufferedPanel4.Name = "BufferedPanel4"
        BufferedPanel4.Padding = New Padding(49, 0, 49, 0)
        BufferedPanel4.Size = New Size(1611, 381)
        BufferedPanel4.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(84, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 37)
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
        btnRefresh.Location = New Point(26, 13)
        btnRefresh.Margin = New Padding(4, 5, 4, 5)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(47, 58)
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.MediumAquamarine
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Dock = DockStyle.Fill
        dgvTransactions.Location = New Point(29, 287)
        dgvTransactions.Margin = New Padding(4, 5, 4, 5)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.RowHeadersWidth = 62
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(1563, 215)
        dgvTransactions.TabIndex = 4
        ' 
        ' BufferedPanel1
        ' 
        BufferedPanel1.Controls.Add(dgvTransactions)
        BufferedPanel1.Controls.Add(BufferedPanel2)
        BufferedPanel1.Dock = DockStyle.Fill
        BufferedPanel1.Location = New Point(0, 0)
        BufferedPanel1.Margin = New Padding(4, 5, 4, 5)
        BufferedPanel1.Name = "BufferedPanel1"
        BufferedPanel1.Padding = New Padding(29, 0, 29, 0)
        BufferedPanel1.Size = New Size(1621, 502)
        BufferedPanel1.TabIndex = 8
        ' 
        ' BufferedPanel2
        ' 
        BufferedPanel2.Controls.Add(GroupBox1)
        BufferedPanel2.Controls.Add(btnRefresh)
        BufferedPanel2.Controls.Add(Label1)
        BufferedPanel2.Dock = DockStyle.Top
        BufferedPanel2.Location = New Point(29, 0)
        BufferedPanel2.Margin = New Padding(4, 5, 4, 5)
        BufferedPanel2.Name = "BufferedPanel2"
        BufferedPanel2.Size = New Size(1563, 287)
        BufferedPanel2.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnRemoveTrans)
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
        GroupBox1.Location = New Point(0, 82)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(1563, 205)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' btnRemoveTrans
        ' 
        btnRemoveTrans.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRemoveTrans.ForeColor = Color.Black
        btnRemoveTrans.Location = New Point(1329, 80)
        btnRemoveTrans.Margin = New Padding(4, 5, 4, 5)
        btnRemoveTrans.Name = "btnRemoveTrans"
        btnRemoveTrans.Size = New Size(180, 60)
        btnRemoveTrans.TabIndex = 23
        btnRemoveTrans.Text = "Remove Transanction"
        btnRemoveTrans.UseVisualStyleBackColor = True
        ' 
        ' txtSearchUser
        ' 
        txtSearchUser.Anchor = AnchorStyles.None
        txtSearchUser.Location = New Point(987, 62)
        txtSearchUser.Margin = New Padding(4, 5, 4, 5)
        txtSearchUser.Name = "txtSearchUser"
        txtSearchUser.Size = New Size(271, 31)
        txtSearchUser.TabIndex = 7
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(740, 25)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(148, 25)
        Label13.TabIndex = 21
        Label13.Text = "Payment Method"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.ForeColor = Color.White
        Label14.Location = New Point(740, 113)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 25)
        Label14.TabIndex = 22
        Label14.Text = "Status"
        ' 
        ' chkDateFrom
        ' 
        chkDateFrom.Anchor = AnchorStyles.None
        chkDateFrom.AutoSize = True
        chkDateFrom.ForeColor = Color.White
        chkDateFrom.Location = New Point(349, 18)
        chkDateFrom.Margin = New Padding(4, 5, 4, 5)
        chkDateFrom.Name = "chkDateFrom"
        chkDateFrom.Size = New Size(122, 29)
        chkDateFrom.TabIndex = 12
        chkDateFrom.Text = "Date From"
        chkDateFrom.UseVisualStyleBackColor = True
        ' 
        ' nudMinAmount
        ' 
        nudMinAmount.Anchor = AnchorStyles.None
        nudMinAmount.Location = New Point(83, 60)
        nudMinAmount.Margin = New Padding(4, 5, 4, 5)
        nudMinAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        nudMinAmount.Name = "nudMinAmount"
        nudMinAmount.Size = New Size(209, 31)
        nudMinAmount.TabIndex = 8
        ' 
        ' nudMaxAmount
        ' 
        nudMaxAmount.Anchor = AnchorStyles.None
        nudMaxAmount.Location = New Point(83, 145)
        nudMaxAmount.Margin = New Padding(4, 5, 4, 5)
        nudMaxAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        nudMaxAmount.Name = "nudMaxAmount"
        nudMaxAmount.Size = New Size(209, 31)
        nudMaxAmount.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(133, 115)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 25)
        Label12.TabIndex = 20
        Label12.Text = "Max Amount:"
        ' 
        ' dtpFromDate
        ' 
        dtpFromDate.Anchor = AnchorStyles.None
        dtpFromDate.Location = New Point(349, 55)
        dtpFromDate.Margin = New Padding(4, 5, 4, 5)
        dtpFromDate.Name = "dtpFromDate"
        dtpFromDate.Size = New Size(284, 31)
        dtpFromDate.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(130, 28)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(120, 25)
        Label11.TabIndex = 19
        Label11.Text = "Min. Amount:"
        ' 
        ' dtpToDate
        ' 
        dtpToDate.Anchor = AnchorStyles.None
        dtpToDate.Location = New Point(349, 151)
        dtpToDate.Margin = New Padding(4, 5, 4, 5)
        dtpToDate.Name = "dtpToDate"
        dtpToDate.Size = New Size(284, 31)
        dtpToDate.TabIndex = 11
        ' 
        ' btnResetFilters
        ' 
        btnResetFilters.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnResetFilters.ForeColor = Color.Black
        btnResetFilters.Location = New Point(1129, 114)
        btnResetFilters.Margin = New Padding(4, 5, 4, 5)
        btnResetFilters.Name = "btnResetFilters"
        btnResetFilters.Size = New Size(129, 60)
        btnResetFilters.TabIndex = 18
        btnResetFilters.Text = "Reset Filters"
        btnResetFilters.UseVisualStyleBackColor = True
        ' 
        ' chkDateTo
        ' 
        chkDateTo.Anchor = AnchorStyles.None
        chkDateTo.AutoSize = True
        chkDateTo.ForeColor = Color.White
        chkDateTo.Location = New Point(349, 110)
        chkDateTo.Margin = New Padding(4, 5, 4, 5)
        chkDateTo.Name = "chkDateTo"
        chkDateTo.Size = New Size(98, 29)
        chkDateTo.TabIndex = 13
        chkDateTo.Text = "Date To"
        chkDateTo.UseVisualStyleBackColor = True
        ' 
        ' btnApplyFilters
        ' 
        btnApplyFilters.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnApplyFilters.ForeColor = Color.Black
        btnApplyFilters.Location = New Point(987, 114)
        btnApplyFilters.Margin = New Padding(4, 5, 4, 5)
        btnApplyFilters.Name = "btnApplyFilters"
        btnApplyFilters.Size = New Size(129, 60)
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
        cmbStatus.Location = New Point(740, 143)
        cmbStatus.Margin = New Padding(4, 5, 4, 5)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(171, 33)
        cmbStatus.TabIndex = 14
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.Anchor = AnchorStyles.None
        cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Items.AddRange(New Object() {"All", "Cash", "GCash"})
        cmbPaymentMethod.Location = New Point(740, 60)
        cmbPaymentMethod.Margin = New Padding(4, 5, 4, 5)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(171, 33)
        cmbPaymentMethod.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(987, 27)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 25)
        Label10.TabIndex = 15
        Label10.Text = "User:"
        ' 
        ' ViewTransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Transparent
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(BufferedPanel1)
        Controls.Add(pnlDetails)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ViewTransactionsControl"
        Size = New Size(1621, 1137)
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).EndInit()
        pnlDetails.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        BufferedPanel3.ResumeLayout(False)
        BufferedPanel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        BufferedPanel4.ResumeLayout(False)
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BufferedPanel3 As BufferedPanel
    Friend WithEvents BufferedPanel4 As BufferedPanel
    Friend WithEvents btnRemoveTrans As Button

End Class
