Imports System.Configuration
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows

Public Class Form1

    Public Sub Login()
        If txtbUser.Text = "User" And txtbPassword.Text = "Password" Then
            Dim form2 As New Form2()
            Me.Hide()
            form2.Show()
        ElseIf txtbUser.Text <> "User" Then
            MsgBox("Invalid user.", vbExclamation, "Invalid login")
        ElseIf txtbPassword.Text <> "Password" Then
            MsgBox("Incorrect password.", vbExclamation, "Invalid login")
        End If
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim form2 As New Form2()
        Me.Hide()
        form2.Show()
    End Sub
End Class
