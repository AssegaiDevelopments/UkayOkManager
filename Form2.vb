Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AStrClothingType(5) As String
        AStrClothingType(0) = "Shoes"
        AStrClothingType(1) = "T-Shirt"
        AStrClothingType(2) = "Jeans"
        AStrClothingType(3) = "Pants"
        AStrClothingType(4) = "Hoodies"
        AStrClothingType(5) = "Polo"
        Dim i As Integer

        For i = 0 To AStrClothingType.Length - 1
            cbClothingType.Items.Add(AStrClothingType(i))
        Next

        dgvCart.ColumnCount = 4
        dgvCart.Columns(0).Name = "Item"
        dgvCart.Columns(1).Name = "Price"
        dgvCart.Columns(2).Name = "Quantity"
        dgvCart.Columns(3).Name = "Total"
    End Sub

    Dim Discount As Integer
    Dim Price As Decimal
    Dim ClothingType As String
    Dim Quantity As Integer
    Dim Total As Decimal
    Private Sub btnAddItemToCart_Click(sender As Object, e As EventArgs) Handles btnAddItemToCart.Click

        If IsNumeric(txtbItemPrice.Text) Then
            Price = txtbItemPrice.Text
            ClothingType = cbClothingType.Text
            Quantity = nudQuantity.Value
            Total = (Quantity * Price) * (Discount * 0.1)

            dgvCart.Rows.Add(ClothingType, "₱" & Price, Quantity, "₱" & Total)
        Else
            MsgBox("Price value not valid!")
        End If
    End Sub

    Private Sub tbDiscount_Scroll(sender As Object, e As EventArgs) Handles tbDiscount.Scroll
        lDiscount.Text = tbDiscount.Value & "%"
        Discount = tbDiscount.Value
    End Sub

End Class