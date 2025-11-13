'Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class AddProductForm
    Private mouseDown As Boolean
    Private lastLocation As Point

    Private Sub btnConfirmAddItem_Click(sender As Object, e As EventArgs) Handles btnConfirmAddItem.Click
        Using con As New SqlConnection(connectAs)
            Dim cmd As New SqlCommand("INSERT INTO Products (ProductName, Stock, RegularPrice) VALUES (@name, @stock, @price)", con)
            cmd.Parameters.AddWithValue("@name", tbProductName.Text)
            cmd.Parameters.AddWithValue("@stock", nudStock.Value)
            cmd.Parameters.AddWithValue("@price", nudPrice.Value)
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelAddItem_Click(sender As Object, e As EventArgs) Handles btnCancelAddItem.Click
        Me.Close()
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        mouseDown = True
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If mouseDown Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        mouseDown = False
    End Sub

    Private Sub nudStock_ValueChanged(sender As Object, e As EventArgs) Handles nudStock.ValueChanged

    End Sub
End Class