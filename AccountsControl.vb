Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AccountsControl
    'start of admin/employee logic
    Dim currentUserId As Integer = 0
    Private _loggedInUserId As Integer
    Private _role As String

    Public Property LoggedInUserId As Integer
        Get
            Return _loggedInUserId
        End Get
        Set(value As Integer)
            _loggedInUserId = value
            _role = GetLoggedInUserRole() ' fetch role from DB
            ApplyRoleRestrictions()
        End Set
    End Property

    Private Function GetLoggedInUserRole() As String
        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim query As String = "SELECT Role FROM Users WHERE UserID=@id"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", _loggedInUserId)
                Dim roleObj = cmd.ExecuteScalar()
                Return If(roleObj IsNot Nothing, roleObj.ToString(), String.Empty)
            End Using
        End Using
    End Function

    Private Sub ApplyRoleRestrictions()
        If _loggedInUserId = 0 Then Exit Sub

        Dim role As String = GetLoggedInUserRole() ' fetch from DB
        If role = "Employee" Then
            ' Disable admin-only controls
            gbModifyAccount.Enabled = False
            btnAddUser.Enabled = False
            btnSetUserStatus.Enabled = False
            btnUpdateUserRole.Enabled = False
            txtConfirmPassword.Enabled = False
            txtPassword.Enabled = False
            cbNewRole.Enabled = False
            cbRole.Enabled = False
        End If
    End Sub
    'end of admin/employee logic

    ' Hash Password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            ' Convert to hex string
            Dim sb As New StringBuilder()
            For Each b As Byte In hash
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function


    Private Sub AccountsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub
    Private Sub CenterControlInPanel(control As Control, panel As Panel)
        ' Calculate the center position
        Dim centerX As Integer = (panel.Width - control.Width) \ 2
        Dim centerY As Integer = (panel.Height - control.Height) \ 2

        ' Set the control's location
        control.Location = New Point(centerX, centerY)
    End Sub
    Private Sub InitializeDGV()
        dgvUsers.Columns.Add("colUserID", "ID")
        dgvUsers.Columns.Add("colUsername", "Username")
        dgvUsers.Columns.Add("colRole", "Role")
        dgvUsers.Columns.Add("colStatus", "Status")
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.AllowUserToAddRows = False
    End Sub
    Private Sub LoadUsers()
        cbNewRole.SelectedIndex = 0
        dgvUsers.Rows.Clear()
        dgvUsers.Columns.Clear()
        InitializeDGV()
        ' Load users from database
        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "
            SELECT UserID, Username, Role, IsDisabled 
            FROM Users
            ORDER BY UserID;"

            Using cmd As New SqlCommand(query, con)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        dgvUsers.Rows.Add(
                        r("UserID"),
                        r("Username"),
                        r("Role"),
                        If(Convert.ToBoolean(r("IsDisabled")), "Disabled", "Active")
                    )
                    End While
                End Using
            End Using
        End Using
        'Center dgv in panel
        CenterControlInPanel(dgvUsers, BufferedPanel)
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AddUser(username As String, password As String, role As String)

        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "
            INSERT INTO Users (Username, PasswordHash, Role, IsDisabled)
            VALUES (@u, @p, @r, 0);
        "

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", password)
                cmd.Parameters.AddWithValue("@r", role)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadUsers()
    End Sub
    'Set Selected user status to disabled/enabled
    Private Sub SetUserStatus(userId As Integer, disabled As Boolean)
        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "
            UPDATE Users
            SET IsDisabled = @d
            WHERE UserID = @id;
        "

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@d", If(disabled, 1, 0))
                cmd.Parameters.AddWithValue("@id", userId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadUsers()
    End Sub

    Private Sub UpdateUserRole(userId As Integer, newRole As String)
        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "
            UPDATE Users
            SET Role = @r
            WHERE UserID = @id;
        "

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@r", newRole)
                cmd.Parameters.AddWithValue("@id", userId)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadUsers()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtUsername.Text = "" Or txtUsername.Text = "" Or cbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If
        Dim hashedPassword As String = HashPassword(txtPassword.Text.Trim())
        AddUser(txtUsername.Text.Trim(), hashedPassword, cbRole.SelectedItem.ToString())
    End Sub



    Private Sub btnSetUserStatus_Click(sender As Object, e As EventArgs) Handles btnSetUserStatus.Click
        If dgvUsers.SelectedRows.Count = 0 Then Return
        Dim id As Integer = dgvUsers.SelectedRows(0).Cells("colUserID").Value
        If id = Me.LoggedInUserId Then
            MessageBox.Show("You cannot disable your own account.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim currentStatus As String = dgvUsers.SelectedRows(0).Cells("colStatus").Value

        Dim disable As Boolean = (currentStatus = "Active")
        SetUserStatus(id, disable)
    End Sub

    Private Sub btnUpdateUserRole_Click(sender As Object, e As EventArgs) Handles btnUpdateUserRole.Click
        If dgvUsers.SelectedRows.Count = 0 Then Return
        If cbNewRole.SelectedIndex = -1 Then Return
        Dim id As Integer = dgvUsers.SelectedRows(0).Cells("colUserID").Value
        If id = Me.LoggedInUserId Then
            MessageBox.Show("You cannot change roles of the current account.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim newRole As String = cbNewRole.SelectedItem.ToString()
        UpdateUserRole(id, newRole)
    End Sub

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click
        If dgvUsers.SelectedRows.Count = 0 Then Return

        Dim id As Integer = dgvUsers.SelectedRows(0).Cells("colUserID").Value

        ' Safeguard: prevent removing yourself
        If id = Me.LoggedInUserId Then
            MessageBox.Show("You cannot remove your own account.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "DELETE FROM Users WHERE UserID = @id;"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadUsers()
    End Sub


End Class
