<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsControl
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
        dgvUsers = New DataGridView()
        btnRemoveUser = New Button()
        btnAddUser = New Button()
        btnSetUserStatus = New Button()
        btnUpdateUserRole = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        cbRole = New ComboBox()
        lbl = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtConfirmPassword = New TextBox()
        Label4 = New Label()
        cbNewRole = New ComboBox()
        GroupBox1 = New GroupBox()
        gbModifyAccount = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        BufferedPanel = New BufferedPanel()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        gbModifyAccount.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        BufferedPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.Location = New Point(3, 3)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        TableLayoutPanel1.SetRowSpan(dgvUsers, 2)
        dgvUsers.Size = New Size(442, 390)
        dgvUsers.TabIndex = 0
        ' 
        ' btnRemoveUser
        ' 
        btnRemoveUser.Cursor = Cursors.Hand
        btnRemoveUser.ForeColor = Color.Black
        btnRemoveUser.Location = New Point(141, 135)
        btnRemoveUser.Name = "btnRemoveUser"
        btnRemoveUser.Size = New Size(121, 23)
        btnRemoveUser.TabIndex = 1
        btnRemoveUser.Text = "Remove User"
        btnRemoveUser.UseVisualStyleBackColor = True
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Cursor = Cursors.Hand
        btnAddUser.ForeColor = Color.Black
        btnAddUser.Location = New Point(125, 141)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(75, 23)
        btnAddUser.TabIndex = 2
        btnAddUser.Text = "Add User"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' btnSetUserStatus
        ' 
        btnSetUserStatus.Cursor = Cursors.Hand
        btnSetUserStatus.ForeColor = Color.Black
        btnSetUserStatus.Location = New Point(141, 106)
        btnSetUserStatus.Name = "btnSetUserStatus"
        btnSetUserStatus.Size = New Size(121, 23)
        btnSetUserStatus.TabIndex = 3
        btnSetUserStatus.Text = "Enable/Disable Status"
        btnSetUserStatus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateUserRole
        ' 
        btnUpdateUserRole.Cursor = Cursors.Hand
        btnUpdateUserRole.ForeColor = Color.Black
        btnUpdateUserRole.Location = New Point(141, 77)
        btnUpdateUserRole.Name = "btnUpdateUserRole"
        btnUpdateUserRole.Size = New Size(121, 23)
        btnUpdateUserRole.TabIndex = 4
        btnUpdateUserRole.Text = "Update User Role"
        btnUpdateUserRole.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Location = New Point(125, 54)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(170, 23)
        txtPassword.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Location = New Point(125, 25)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(170, 23)
        txtUsername.TabIndex = 6
        ' 
        ' cbRole
        ' 
        cbRole.Cursor = Cursors.Hand
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Admin", "Employee"})
        cbRole.Location = New Point(125, 112)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(121, 23)
        cbRole.TabIndex = 7
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.ForeColor = Color.White
        lbl.Location = New Point(61, 26)
        lbl.Name = "lbl"
        lbl.Size = New Size(60, 15)
        lbl.TabIndex = 8
        lbl.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(61, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 9
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(88, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 10
        Label3.Text = "Role"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 15)
        Label1.TabIndex = 12
        Label1.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Cursor = Cursors.IBeam
        txtConfirmPassword.Location = New Point(125, 83)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "●"c
        txtConfirmPassword.Size = New Size(170, 23)
        txtConfirmPassword.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(61, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 14
        Label4.Text = "Change Role"
        ' 
        ' cbNewRole
        ' 
        cbNewRole.Cursor = Cursors.Hand
        cbNewRole.DropDownStyle = ComboBoxStyle.DropDownList
        cbNewRole.FormattingEnabled = True
        cbNewRole.Items.AddRange(New Object() {"Admin", "Employee"})
        cbNewRole.Location = New Point(141, 49)
        cbNewRole.Name = "cbNewRole"
        cbNewRole.Size = New Size(121, 23)
        cbNewRole.TabIndex = 13
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtConfirmPassword)
        GroupBox1.Controls.Add(btnAddUser)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(cbRole)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(lbl)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Gold
        GroupBox1.Location = New Point(451, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(339, 192)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Account"
        ' 
        ' gbModifyAccount
        ' 
        gbModifyAccount.Controls.Add(cbNewRole)
        gbModifyAccount.Controls.Add(btnRemoveUser)
        gbModifyAccount.Controls.Add(Label4)
        gbModifyAccount.Controls.Add(btnSetUserStatus)
        gbModifyAccount.Controls.Add(btnUpdateUserRole)
        gbModifyAccount.Dock = DockStyle.Fill
        gbModifyAccount.ForeColor = Color.Gold
        gbModifyAccount.Location = New Point(451, 201)
        gbModifyAccount.Name = "gbModifyAccount"
        gbModifyAccount.Size = New Size(339, 192)
        gbModifyAccount.TabIndex = 16
        gbModifyAccount.TabStop = False
        gbModifyAccount.Text = "Modify Account"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 56.52174F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43.47826F))
        TableLayoutPanel1.Controls.Add(dgvUsers, 0, 0)
        TableLayoutPanel1.Controls.Add(gbModifyAccount, 1, 1)
        TableLayoutPanel1.Controls.Add(GroupBox1, 1, 0)
        TableLayoutPanel1.Location = New Point(171, 143)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(793, 396)
        TableLayoutPanel1.TabIndex = 17
        ' 
        ' BufferedPanel
        ' 
        BufferedPanel.Controls.Add(TableLayoutPanel1)
        BufferedPanel.Dock = DockStyle.Fill
        BufferedPanel.Location = New Point(0, 0)
        BufferedPanel.Name = "BufferedPanel"
        BufferedPanel.Size = New Size(1135, 682)
        BufferedPanel.TabIndex = 18
        ' 
        ' AccountsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(BufferedPanel)
        Name = "AccountsControl"
        Size = New Size(1135, 682)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbModifyAccount.ResumeLayout(False)
        gbModifyAccount.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        BufferedPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnRemoveUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnSetUserStatus As Button
    Friend WithEvents btnUpdateUserRole As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbNewRole As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbModifyAccount As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BufferedPanel As BufferedPanel

End Class
