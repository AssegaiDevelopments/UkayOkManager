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
        pnlCash.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlGCash.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlCashReceived.BackColor = Color.RosyBrown
        pnlCashReceived.Location = New Point(0, 0)
        pnlCashReceived.Name = "pnlCashReceived"
        pnlCashReceived.Size = New Size(520, 349)
        pnlCashReceived.TabIndex = 3
        pnlCashReceived.Visible = False
        ' 
        ' SelectPayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 344)
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
End Class
