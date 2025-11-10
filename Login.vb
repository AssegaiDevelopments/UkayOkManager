Imports System.Configuration
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class Login
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
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
End Class
