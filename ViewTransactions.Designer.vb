<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTransactions
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
        dgvTransactions = New DataGridView()
        btnRefresh = New Button()
        Label1 = New Label()
        pnlDetails = New Panel()
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
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        pnlDetails.SuspendLayout()
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AllowUserToDeleteRows = False
        dgvTransactions.AllowUserToOrderColumns = True
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(51, 40)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.Size = New Size(784, 468)
        dgvTransactions.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(12, 40)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(33, 35)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "⟳"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Miriam Libre", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 28)
        Label1.TabIndex = 2
        Label1.Text = "Transactions History"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.Bisque
        pnlDetails.Controls.Add(Label9)
        pnlDetails.Controls.Add(Label7)
        pnlDetails.Controls.Add(Label8)
        pnlDetails.Controls.Add(Label5)
        pnlDetails.Controls.Add(Label6)
        pnlDetails.Controls.Add(Label2)
        pnlDetails.Controls.Add(Label3)
        pnlDetails.Controls.Add(Label4)
        pnlDetails.Controls.Add(btnCloseDetails)
        pnlDetails.Controls.Add(dgvTransactionItems)
        pnlDetails.Controls.Add(lblRemarks)
        pnlDetails.Controls.Add(lblStatus)
        pnlDetails.Controls.Add(lblTransactionType)
        pnlDetails.Controls.Add(lblUsername)
        pnlDetails.Controls.Add(lblPaymentMethod)
        pnlDetails.Controls.Add(lblTransactionDate)
        pnlDetails.Controls.Add(lblTotalAmount)
        pnlDetails.Controls.Add(lblTransactionID)
        pnlDetails.Location = New Point(1, 81)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(863, 449)
        pnlDetails.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(22, 4)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 16)
        Label9.TabIndex = 17
        Label9.Text = "Detailed View"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(643, 73)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 17)
        Label7.TabIndex = 16
        Label7.Text = "Total Amount:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic)
        Label8.Location = New Point(566, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 17)
        Label8.TabIndex = 15
        Label8.Text = "Status:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic)
        Label5.Location = New Point(257, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 17)
        Label5.TabIndex = 14
        Label5.Text = "Transaction Type:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic)
        Label6.Location = New Point(257, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 17)
        Label6.TabIndex = 13
        Label6.Text = "Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic)
        Label2.Location = New Point(22, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 12
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic)
        Label3.Location = New Point(22, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 17)
        Label3.TabIndex = 11
        Label3.Text = "Payment Method:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(22, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 17)
        Label4.TabIndex = 10
        Label4.Text = "Transaction ID:"
        ' 
        ' btnCloseDetails
        ' 
        btnCloseDetails.Cursor = Cursors.Hand
        btnCloseDetails.FlatStyle = FlatStyle.Flat
        btnCloseDetails.Location = New Point(0, 1)
        btnCloseDetails.Name = "btnCloseDetails"
        btnCloseDetails.Size = New Size(21, 23)
        btnCloseDetails.TabIndex = 9
        btnCloseDetails.Text = "x"
        btnCloseDetails.UseVisualStyleBackColor = True
        ' 
        ' dgvTransactionItems
        ' 
        dgvTransactionItems.BackgroundColor = SystemColors.ButtonFace
        dgvTransactionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionItems.Location = New Point(22, 93)
        dgvTransactionItems.Name = "dgvTransactionItems"
        dgvTransactionItems.Size = New Size(810, 346)
        dgvTransactionItems.TabIndex = 8
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic)
        lblRemarks.Location = New Point(566, 44)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(56, 17)
        lblRemarks.TabIndex = 7
        lblRemarks.Text = "Remarks"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(607, 27)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(46, 17)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status"
        ' 
        ' lblTransactionType
        ' 
        lblTransactionType.AutoSize = True
        lblTransactionType.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionType.Location = New Point(358, 43)
        lblTransactionType.Name = "lblTransactionType"
        lblTransactionType.Size = New Size(108, 17)
        lblTransactionType.TabIndex = 5
        lblTransactionType.Text = "TransactionType"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblUsername.Location = New Point(85, 45)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 17)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblPaymentMethod.Location = New Point(124, 61)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(110, 17)
        lblPaymentMethod.TabIndex = 3
        lblPaymentMethod.Text = "PaymentMethod"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionDate.Location = New Point(293, 28)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(108, 17)
        lblTransactionDate.TabIndex = 2
        lblTransactionDate.Text = "TransactionDate"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(734, 73)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(91, 17)
        lblTotalAmount.TabIndex = 1
        lblTotalAmount.Text = "Total Amount"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblTransactionID.Location = New Point(110, 27)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(93, 17)
        lblTransactionID.TabIndex = 0
        lblTransactionID.Text = "TransactionID"
        ' 
        ' ViewTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(69), CByte(88), CByte(113))
        ClientSize = New Size(864, 532)
        Controls.Add(pnlDetails)
        Controls.Add(Label1)
        Controls.Add(btnRefresh)
        Controls.Add(dgvTransactions)
        Name = "ViewTransactions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Transactions"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        CType(dgvTransactionItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents btnCloseDetails As Button
    Friend WithEvents dgvTransactionItems As DataGridView
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTransactionType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
