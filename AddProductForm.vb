Imports System.Data.SqlClient

Public Class AddProductForm
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
End Class