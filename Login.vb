Imports System.Configuration
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class Login

    Private mouseDowned As Boolean
    Private lastLocation As Point

    Public Function ComputeSha256Hash(rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Public Sub Login()
        Dim username As String = txtbUser.Text
        Dim password As String = ComputeSha256Hash(txtbPassword.Text)

        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim query As String = "SELECT * FROM Users WHERE Username = @username AND PasswordHash = @password"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    MsgBox("Login successful!", vbInformation, "Login Successful!")
                    LoginSuccess()
                Else
                    MsgBox("Invalid username or password.", vbExclamation, "Invalid")
                End If
            End Using
        End Using

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Login()
    End Sub

    Private Sub txtbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Login()
        End If
    End Sub

    Private Sub txtbUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Login()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        LoginSuccess()
    End Sub

    Sub LoginSuccess()
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mouseDowned = True
        lastLocation = e.Location
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseDowned Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseDowned = False
    End Sub

    Private Sub pbbtnLogin_Click(sender As Object, e As EventArgs) Handles pbbtnLogin.Click
        Login()
    End Sub

    Private Sub pbbtnLogin_MouseHover(sender As Object, e As EventArgs) Handles pbbtnLogin.MouseHover
        pbbtnLogin.BackgroundImage = My.Resources.btnlogin_h
        pbbtnLogin.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub pbbtnLogin_MouseLeave(sender As Object, e As EventArgs) Handles pbbtnLogin.MouseLeave
        pbbtnLogin.BackgroundImage = My.Resources.btnlogin2
        pbbtnLogin.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles pbbtnPasswordVisibility.MouseHover
        txtbPassword.PasswordChar = ""
        pbbtnPasswordVisibility.BackgroundImage = My.Resources.visibilityOn
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles pbbtnPasswordVisibility.MouseLeave
        txtbPassword.PasswordChar = "•"
        pbbtnPasswordVisibility.BackgroundImage = My.Resources.visibilityOff
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        'TEMPORARY BACKDOOR REMOVE LATER
        LoginSuccess()
    End Sub
End Class
