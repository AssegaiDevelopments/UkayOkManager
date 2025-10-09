Imports System.Data.SqlClient

Public Class Dashboard

    Dim clothingType As String
    Dim quantity, discount As Integer
    Dim itemTotal, price, grandTotal As Decimal
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()

        Using con As New SqlConnection(connectAs)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT ProductName FROM Products", con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    cbClothingType.Items.Add(reader("ProductName").ToString())
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message)
            End Try
        End Using


        dgvCart.ColumnCount = 4
        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCart.Columns(0).Name = "Item"
        dgvCart.Columns(1).Name = "Price"
        dgvCart.Columns(2).Name = "Quantity"
        dgvCart.Columns(3).Name = "Total"
    End Sub

    Private Sub btnAddItemToCart_Click(sender As Object, e As EventArgs) Handles btnAddItemToCart.Click

        If IsNumeric(txtbItemPrice.Text) And Not nudQuantity.Value <= 0 Then



            price = txtbItemPrice.Text
            clothingType = cbClothingType.Text
            quantity = nudQuantity.Value

            If Not chbxDiscount.Checked Then
                itemTotal = (quantity * price)
            Else
                itemTotal = (quantity * price) * (1 - (discount * 0.01))
            End If

            Dim availableStock As Integer = 0
            Using con As New SqlConnection(connectAs)
                con.Open()
                Dim cmd As New SqlCommand("SELECT Stock FROM Products WHERE ProductName = @pname", con)
                cmd.Parameters.AddWithValue("@pname", cbClothingType.Text)
                availableStock = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            Dim totalInCart As Integer = 0
            For Each row As DataGridViewRow In dgvCart.Rows
                If Not row.IsNewRow AndAlso row.Cells("Item").Value.ToString() = clothingType Then
                    totalInCart += Convert.ToInt32(row.Cells("Quantity").Value)
                End If
            Next

            Dim totalRequested As Integer = totalInCart + quantity

            If totalRequested > availableStock Then
                MsgBox("Not enough stock available. You already have " & totalInCart &
           " of this item in your cart. Only " & (availableStock - totalInCart) & " left.")
                Exit Sub
            End If

            lblStock.Text = "Stock: " & (availableStock - totalRequested).ToString()

            'add value to datagridview
            dgvCart.Rows.Add(clothingType, "₱" & price, quantity, itemTotal)
            For Each row As DataGridViewRow In dgvCart.Rows
                If Not row.IsNewRow Then
                    grandTotal += Convert.ToDecimal(row.Cells("Total").Value)
                End If
            Next
            lGrandTotal.Text = "₱" & grandTotal

            price = 0
            clothingType = ""
            quantity = 0
            grandTotal = 0

        ElseIf nudQuantity.Value <= 0 Then
            MsgBox("Quantity value invalid, please enter a quantity greater than 0.")
        Else
            MsgBox("Price value not valid!")
        End If
    End Sub

    Private Sub tbDiscount_Scroll(sender As Object, e As EventArgs) Handles tbDiscount.Scroll
        lDiscount.Text = tbDiscount.Value & "%"
        discount = tbDiscount.Value
    End Sub

    Private Sub chbxDiscountEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDiscount.CheckedChanged
        If chbxDiscount.Checked Then
            tbDiscount.Enabled = True
            lDiscount.Enabled = True
        Else
            tbDiscount.Enabled = False
            tbDiscount.Value = 0
            lDiscount.Text = "0%"
            lDiscount.Enabled = False

        End If
    End Sub

    Private Sub cbClothingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClothingType.SelectedIndexChanged
        Using con As New SqlConnection(connectAs)
            Dim cmd As New SqlCommand("SELECT RegularPrice, Stock FROM Products WHERE ProductName = @name", con)
            cmd.Parameters.AddWithValue("@name", cbClothingType.Text)
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtbItemPrice.Text = reader("RegularPrice").ToString()
                lblStock.Text = "Stock: " & reader("Stock").ToString()
                'lblStockAvailable.Text = "Available: " & reader("Stock").ToString()
            End If
            reader.Close()
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, Button1.Click
        Login.Close()
        Close()
    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        dgvCart.Rows.Clear()
        grandTotal = 0
        lGrandTotal.Text = "₱0.00"
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class