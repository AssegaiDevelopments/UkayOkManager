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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).BeginInit()
        pnlDetails.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
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
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(737, 31)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 17)
        Label7.TabIndex = 16
        Label7.Text = "Total Amount:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(504, 66)
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
        Label5.Location = New Point(449, 37)
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
        Label6.Location = New Point(512, 8)
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
        Label2.Location = New Point(117, 37)
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
        Label3.Location = New Point(78, 66)
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
        Label4.Location = New Point(96, 8)
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
        dgvTransactionItems.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTransactionItems.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.MediumAquamarine
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTransactionItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTransactionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionItems.Location = New Point(37, 117)
        dgvTransactionItems.Name = "dgvTransactionItems"
        dgvTransactionItems.ReadOnly = True
        dgvTransactionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactionItems.Size = New Size(1070, 294)
        dgvTransactionItems.TabIndex = 8
        ' 
        ' lblRemarks
        ' 
        lblRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI", 9F)
        lblRemarks.Location = New Point(768, 2)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(52, 27)
        lblRemarks.TabIndex = 7
        lblRemarks.Text = "Remarks"
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.Left
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(554, 65)
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
        lblTransactionType.Location = New Point(554, 36)
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
        lblUsername.Location = New Point(188, 36)
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
        lblPaymentMethod.Location = New Point(188, 65)
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
        lblTransactionDate.Location = New Point(554, 7)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(108, 17)
        lblTransactionDate.TabIndex = 2
        lblTransactionDate.Text = "TransactionDate"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(737, 60)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(91, 17)
        lblTotalAmount.TabIndex = 1
        lblTotalAmount.Text = "Total Amount"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.Anchor = AnchorStyles.Left
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionID.Location = New Point(188, 7)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(93, 17)
        lblTransactionID.TabIndex = 0
        lblTransactionID.Text = "TransactionID"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.AutoSize = True
        pnlDetails.BackColor = Color.SteelBlue
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
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
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
        TableLayoutPanel1.Location = New Point(125, 22)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(857, 89)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 25)
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
        btnRefresh.Location = New Point(235, 15)
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
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.MediumAquamarine
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(37, 56)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(1070, 468)
        dgvTransactions.TabIndex = 4
        ' 
        ' ViewTransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Transparent
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(pnlDetails)
        Controls.Add(Label1)
        Controls.Add(btnRefresh)
        Controls.Add(dgvTransactions)
        Name = "ViewTransactionsControl"
        Size = New Size(1135, 682)
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).EndInit()
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
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

End Class
