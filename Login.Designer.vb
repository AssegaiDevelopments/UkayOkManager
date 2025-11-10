<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        txtbUser = New TextBox()
        txtbPassword = New TextBox()
        btnLogin = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbUser
        ' 
        txtbUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtbUser.BackColor = Color.White
        txtbUser.BorderStyle = BorderStyle.None
        txtbUser.Cursor = Cursors.IBeam
        txtbUser.Font = New Font("Segoe UI", 12F)
        txtbUser.Location = New Point(36, 43)
        txtbUser.MaxLength = 128
        txtbUser.Name = "txtbUser"
        txtbUser.PlaceholderText = "Username"
        txtbUser.Size = New Size(298, 22)
        txtbUser.TabIndex = 0
        ' 
        ' txtbPassword
        ' 
        txtbPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtbPassword.BackColor = Color.White
        txtbPassword.BorderStyle = BorderStyle.None
        txtbPassword.Cursor = Cursors.IBeam
        txtbPassword.Font = New Font("Segoe UI", 12F)
        txtbPassword.Location = New Point(36, 137)
        txtbPassword.MaxLength = 128
        txtbPassword.Name = "txtbPassword"
        txtbPassword.PasswordChar = "•"c
        txtbPassword.PlaceholderText = "Password"
        txtbPassword.Size = New Size(298, 22)
        txtbPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogin.BackColor = Color.LightGray
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 9F)
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(270, 208)
        btnLogin.Margin = New Padding(0)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(64, 30)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Log-in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(txtbPassword)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtbUser)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(12, 181)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(374, 299)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.ovaltextbox
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(21, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(329, 50)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.ovaltextbox
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(21, 119)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(329, 58)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(36, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 37)
        Label1.TabIndex = 5
        Label1.Text = "UkayOk Manager"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.bglogin
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(722, 473)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log-in"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbUser As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label

End Class
