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
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbUser
        ' 
        txtbUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtbUser.Font = New Font("Segoe UI", 12F)
        txtbUser.Location = New Point(28, 67)
        txtbUser.MaxLength = 128
        txtbUser.Name = "txtbUser"
        txtbUser.Size = New Size(298, 29)
        txtbUser.TabIndex = 0
        txtbUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtbPassword
        ' 
        txtbPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtbPassword.Font = New Font("Segoe UI", 12F)
        txtbPassword.Location = New Point(28, 136)
        txtbPassword.MaxLength = 128
        txtbPassword.Name = "txtbPassword"
        txtbPassword.PasswordChar = "•"c
        txtbPassword.Size = New Size(298, 29)
        txtbPassword.TabIndex = 1
        txtbPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogin.BackColor = Color.LightGray
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 9F)
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(262, 210)
        btnLogin.Margin = New Padding(0)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(64, 30)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Log-in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtbUser)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(txtbPassword)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Font = New Font("Segoe UI", 11F)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(29, 60)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(363, 266)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Log-in"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Corbel", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(28, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 18)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(28, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 18)
        Label1.TabIndex = 3
        Label1.Text = "User:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.flavor
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(117, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(642, 401)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(70), CByte(88), CByte(113))
        ClientSize = New Size(590, 394)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log-in"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtbUser As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
