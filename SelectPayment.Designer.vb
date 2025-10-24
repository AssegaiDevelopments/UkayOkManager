<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPayment
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
        pnlCash = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        pnlGCash = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        btnCancelPayment = New Button()
        pnlCashReceived = New Panel()
        lblChange = New Label()
        Label3 = New Label()
        lblCartTotal = New Label()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        btnConfirmCash = New Button()
        btnBack = New Button()
        txtCashReceived = New TextBox()
        pnlGCashReceived = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        btnConfirmGCash = New Button()
        Label6 = New Label()
        lblCartTotalB = New Label()
        btnBack1 = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        pnlCash.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlGCash.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlCashReceived.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlGCashReceived.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCash
        ' 
        pnlCash.BackColor = Color.Firebrick
        pnlCash.BorderStyle = BorderStyle.FixedSingle
        pnlCash.Controls.Add(PictureBox2)
        pnlCash.Controls.Add(Label1)
        pnlCash.Cursor = Cursors.Hand
        pnlCash.Location = New Point(1, 0)
        pnlCash.Name = "pnlCash"
        pnlCash.Size = New Size(269, 323)
        pnlCash.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.cashicon
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(19, 92)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(215, 150)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 282)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 29)
        Label1.TabIndex = 0
        Label1.Text = "Cash"
        ' 
        ' pnlGCash
        ' 
        pnlGCash.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlGCash.BackColor = Color.AliceBlue
        pnlGCash.BorderStyle = BorderStyle.FixedSingle
        pnlGCash.Controls.Add(PictureBox1)
        pnlGCash.Controls.Add(Label2)
        pnlGCash.Cursor = Cursors.Hand
        pnlGCash.Location = New Point(265, 0)
        pnlGCash.Name = "pnlGCash"
        pnlGCash.Size = New Size(255, 323)
        pnlGCash.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.gcash
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(21, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 115)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Calibri", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(10, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 29)
        Label2.TabIndex = 0
        Label2.Text = "GCash"
        ' 
        ' btnCancelPayment
        ' 
        btnCancelPayment.BackColor = Color.LightGray
        btnCancelPayment.Cursor = Cursors.Hand
        btnCancelPayment.FlatStyle = FlatStyle.Popup
        btnCancelPayment.ForeColor = Color.Black
        btnCancelPayment.Location = New Point(0, 315)
        btnCancelPayment.Name = "btnCancelPayment"
        btnCancelPayment.Size = New Size(522, 34)
        btnCancelPayment.TabIndex = 2
        btnCancelPayment.Text = "Cancel"
        btnCancelPayment.UseVisualStyleBackColor = False
        ' 
        ' pnlCashReceived
        ' 
        pnlCashReceived.BackColor = Color.SteelBlue
        pnlCashReceived.Controls.Add(lblChange)
        pnlCashReceived.Controls.Add(Label3)
        pnlCashReceived.Controls.Add(lblCartTotal)
        pnlCashReceived.Controls.Add(PictureBox3)
        pnlCashReceived.Controls.Add(Label5)
        pnlCashReceived.Controls.Add(Label4)
        pnlCashReceived.Controls.Add(btnConfirmCash)
        pnlCashReceived.Controls.Add(btnBack)
        pnlCashReceived.Controls.Add(txtCashReceived)
        pnlCashReceived.Location = New Point(0, 0)
        pnlCashReceived.Name = "pnlCashReceived"
        pnlCashReceived.Size = New Size(520, 349)
        pnlCashReceived.TabIndex = 3
        pnlCashReceived.Visible = False
        ' 
        ' lblChange
        ' 
        lblChange.BackColor = Color.Gold
        lblChange.Font = New Font("Courier New", 12F, FontStyle.Bold)
        lblChange.ForeColor = Color.Black
        lblChange.Location = New Point(250, 194)
        lblChange.Name = "lblChange"
        lblChange.RightToLeft = RightToLeft.Yes
        lblChange.Size = New Size(102, 26)
        lblChange.TabIndex = 9
        lblChange.Text = "0"
        lblChange.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(167, 196)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(75, 19)
        Label3.TabIndex = 8
        Label3.Text = "Change:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCartTotal
        ' 
        lblCartTotal.BackColor = Color.White
        lblCartTotal.Font = New Font("Courier New", 12F, FontStyle.Bold)
        lblCartTotal.ForeColor = Color.Black
        lblCartTotal.Location = New Point(249, 126)
        lblCartTotal.Name = "lblCartTotal"
        lblCartTotal.RightToLeft = RightToLeft.Yes
        lblCartTotal.Size = New Size(102, 26)
        lblCartTotal.TabIndex = 7
        lblCartTotal.Text = "0"
        lblCartTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.cashicon
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(402, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 79)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(113, 163)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(130, 19)
        Label5.TabIndex = 5
        Label5.Text = "Cash Received:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(154, 128)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.No
        Label4.Size = New Size(88, 19)
        Label4.TabIndex = 4
        Label4.Text = "Cart Total:"
        ' 
        ' btnConfirmCash
        ' 
        btnConfirmCash.Cursor = Cursors.Hand
        btnConfirmCash.FlatStyle = FlatStyle.Flat
        btnConfirmCash.ForeColor = Color.Gold
        btnConfirmCash.Location = New Point(207, 240)
        btnConfirmCash.Name = "btnConfirmCash"
        btnConfirmCash.Size = New Size(145, 72)
        btnConfirmCash.TabIndex = 3
        btnConfirmCash.Text = "Confirm Payment"
        btnConfirmCash.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Cursor = Cursors.Hand
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(0, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 2
        btnBack.Text = "Go back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtCashReceived
        ' 
        txtCashReceived.Font = New Font("Courier New", 12F, FontStyle.Bold)
        txtCashReceived.Location = New Point(249, 162)
        txtCashReceived.Name = "txtCashReceived"
        txtCashReceived.RightToLeft = RightToLeft.Yes
        txtCashReceived.Size = New Size(103, 26)
        txtCashReceived.TabIndex = 1
        ' 
        ' pnlGCashReceived
        ' 
        pnlGCashReceived.Controls.Add(Label8)
        pnlGCashReceived.Controls.Add(Label7)
        pnlGCashReceived.Controls.Add(btnConfirmGCash)
        pnlGCashReceived.Controls.Add(Label6)
        pnlGCashReceived.Controls.Add(lblCartTotalB)
        pnlGCashReceived.Controls.Add(btnBack1)
        pnlGCashReceived.Controls.Add(PictureBox5)
        pnlGCashReceived.Controls.Add(PictureBox4)
        pnlGCashReceived.Location = New Point(0, 0)
        pnlGCashReceived.Name = "pnlGCashReceived"
        pnlGCashReceived.Size = New Size(522, 349)
        pnlGCashReceived.TabIndex = 4
        pnlGCashReceived.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(320, 74)
        Label8.Name = "Label8"
        Label8.Size = New Size(175, 38)
        Label8.TabIndex = 7
        Label8.Text = "UkayOk"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(320, 56)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 18)
        Label7.TabIndex = 6
        Label7.Text = "To:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnConfirmGCash
        ' 
        btnConfirmGCash.Location = New Point(370, 270)
        btnConfirmGCash.Name = "btnConfirmGCash"
        btnConfirmGCash.Size = New Size(138, 63)
        btnConfirmGCash.TabIndex = 5
        btnConfirmGCash.Text = "Confirm Payment"
        btnConfirmGCash.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(320, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 18)
        Label6.TabIndex = 4
        Label6.Text = "Total amount:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCartTotalB
        ' 
        lblCartTotalB.BackColor = Color.LightBlue
        lblCartTotalB.Font = New Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCartTotalB.Location = New Point(320, 172)
        lblCartTotalB.Name = "lblCartTotalB"
        lblCartTotalB.Size = New Size(175, 38)
        lblCartTotalB.TabIndex = 3
        lblCartTotalB.Text = "0.0"
        lblCartTotalB.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnBack1
        ' 
        btnBack1.Cursor = Cursors.Hand
        btnBack1.FlatStyle = FlatStyle.Flat
        btnBack1.Location = New Point(447, 0)
        btnBack1.Name = "btnBack1"
        btnBack1.Size = New Size(75, 23)
        btnBack1.TabIndex = 2
        btnBack1.Text = "Go back"
        btnBack1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.gcash
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(91, 300)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(132, 46)
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.QR
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(1, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(304, 290)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' SelectPayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 344)
        Controls.Add(pnlGCashReceived)
        Controls.Add(pnlCashReceived)
        Controls.Add(btnCancelPayment)
        Controls.Add(pnlGCash)
        Controls.Add(pnlCash)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "SelectPayment"
        StartPosition = FormStartPosition.CenterParent
        Text = "Select Payment Method"
        pnlCash.ResumeLayout(False)
        pnlCash.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlGCash.ResumeLayout(False)
        pnlGCash.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlCashReceived.ResumeLayout(False)
        pnlCashReceived.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlGCashReceived.ResumeLayout(False)
        pnlGCashReceived.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCash As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGCash As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancelPayment As Button
    Friend WithEvents pnlCashReceived As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConfirmCash As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtCashReceived As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label3 As Label
    Public WithEvents lblCartTotal As Label
    Friend WithEvents pnlGCashReceived As Panel
    Friend WithEvents btnBack1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblCartTotalB As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConfirmGCash As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
