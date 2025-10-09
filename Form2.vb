Imports System.Data.SqlClient

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        Dim AStrClothingType(5) As String
        AStrClothingType(0) = "Shoes"
        AStrClothingType(1) = "T-Shirt"
        AStrClothingType(2) = "Jeans"
        AStrClothingType(3) = "Pants"
        AStrClothingType(4) = "Hoodies"
        AStrClothingType(5) = "Polo"
        Dim i As Integer

        'add clothing types to categories
        For i = 0 To AStrClothingType.Length - 1
            cbClothingType.Items.Add(AStrClothingType(i))
        Next

        dgvCart.ColumnCount = 4
        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCart.Columns(0).Name = "Item"
        dgvCart.Columns(1).Name = "Price"
        dgvCart.Columns(2).Name = "Quantity"
        dgvCart.Columns(3).Name = "Total"
    End Sub

    Dim clothingType As String
    Dim quantity, discount As Integer
    Dim itemTotal, price, grandTotal As Decimal

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

End Class