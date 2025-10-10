Imports System.Data.SqlClient

Public Class Dashboard

    Dim clothingType As String
    Dim quantity, discount As Integer
    Dim itemTotal, price, grandTotal As Decimal
    Dim tempStock As New Dictionary(Of String, Integer)


    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()

        Using con As New SqlConnection(connectAs)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT ProductName, Stock FROM Products", con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim pname As String = reader("ProductName").ToString()
                    If pname = "T-Shirt" Then
                        lblStock.Text = "Remaining stock: " & reader("Stock").ToString()
                    End If
                    Dim stock As Integer = Convert.ToInt32(reader("Stock"))
                    tempStock(pname) = stock
                    cbClothingType.Items.Add(pname)
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
        dgvCart.Columns(3).DefaultCellStyle.Format = "N2"

    End Sub

    Public Sub RefreshProductInfo()
        ' Step 1: Update dictionary
        tempStock.Clear()
        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim cmd As New SqlCommand("SELECT ProductName, Stock FROM Products", con)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    tempStock(reader("ProductName").ToString()) = Convert.ToInt32(reader("Stock"))
                End While
            End Using


            ' Step 2: Reset combobox
            Dim cmd2 As New SqlCommand("SELECT ProductName FROM Products WHERE ProductID = 1", con)
            Dim result = cmd2.ExecuteScalar()
            If result IsNot Nothing Then
                cbClothingType.Text = result.ToString()
            End If
        End Using

        ' Step 3: Update stock label
        If tempStock.ContainsKey(cbClothingType.Text) Then
            lblStock.Text = "Remaining stock: " & tempStock(cbClothingType.Text).ToString()
        Else
            lblStock.Text = "N/A"
        End If
    End Sub


    Private Sub btnAddItemToCart_Click(sender As Object, e As EventArgs) Handles btnAddItemToCart.Click
        ' Validate price and quantity
        Dim parsedPrice As Decimal
        If Decimal.TryParse(txtbItemPrice.Text, parsedPrice) AndAlso nudQuantity.Value > 0 Then

            price = parsedPrice
            clothingType = cbClothingType.Text
            quantity = CInt(nudQuantity.Value)

            If Not chbxDiscount.Checked Then
                itemTotal = (quantity * price)
            Else
                itemTotal = (quantity * price) * (1 - (discount * 0.01D))
            End If

            ' Get available stock from DB
            Dim selectedItem As String = cbClothingType.Text
            Dim availableStock As Integer = tempStock(selectedItem)

            If nudQuantity.Value > availableStock Then
                MsgBox("Not enough stock available.")
                Exit Sub
            End If

            ' Check combined quantities already in cart for the same item
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

            ' Add value to DataGridView Cart
            ' Keep the Price cell display-friendly, but Total store numeric
            dgvCart.Rows.Add(clothingType, "₱" & price.ToString("N2"), quantity, itemTotal)

            ' Recalculate grand total from the grid (safer than keeping incremental state)
            RecalculateGrandTotal()
            ' Deduct locally
            tempStock(selectedItem) -= quantity
            lblStock.Text = "Remaining stock: " & tempStock(selectedItem).ToString


            ' Reset inputs (but DON'T reset grandTotal here)
            price = 0
            clothingType = ""
            quantity = 0

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
                lblStock.Text = "Remaining stock: " & reader("Stock").ToString()
                'lblStockAvailable.Text = "Available: " & reader("Stock").ToString()
            End If
            reader.Close()
        End Using
    End Sub

    'Exit application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, Button1.Click
        Login.Close()
        Close()
    End Sub

    'Clear cart and reset grand total
    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        dgvCart.Rows.Clear()
        grandTotal = 0
        lGrandTotal.Text = "₱0.00"
    End Sub

    'Minimize application
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Remove selected item from cart and update stock and grand total
    Private Sub btnRemoveItemFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveItemFromCart.Click
        If dgvCart.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvCart.SelectedRows(0)
            Dim itemName As String = row.Cells("Item").Value.ToString()
            Dim qty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim total As Decimal = Convert.ToDecimal(row.Cells("Total").Value)

            ' Restore local stock
            If tempStock.ContainsKey(itemName) Then tempStock(itemName) += qty
            ' Update grand total
            grandTotal -= total
            lGrandTotal.Text = "₱" & grandTotal.ToString("N2")

            ' Remove row
            dgvCart.Rows.Remove(row)

            ' Update label
            lblStock.Text = "Remaining stock: " & tempStock(itemName)
        Else
            MsgBox("Please select an item to remove.")
        End If
    End Sub

    ' Checkout process: save transaction and items to DB, clear cart
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If dgvCart.Rows.Count = 0 Then
            MsgBox("Your cart is empty!", vbExclamation, "Checkout")
            Exit Sub
        End If

        Dim confirm = MsgBox("Proceed to checkout?", vbYesNo + vbQuestion, "Confirm")
        If confirm = vbNo Then Exit Sub

        Dim totalAmount As Decimal = 0D
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.IsNewRow Then Continue For
            totalAmount += Convert.ToDecimal(row.Cells("Total").Value)
        Next

        Using con As New SqlConnection(connectAs)
            con.Open()

            ' Insert the transaction first
            Dim cmdTrans As New SqlCommand("INSERT INTO Transactions (Username, TotalAmount, PaymentMethod, Status) 
                                        OUTPUT INSERTED.TransactionID
                                        VALUES (@user, @total, @method, @status)", con)

            cmdTrans.Parameters.AddWithValue("@user", "Admin")  ' Replace with your logged-in user variable
            cmdTrans.Parameters.AddWithValue("@total", totalAmount)
            cmdTrans.Parameters.AddWithValue("@method", "Cash")      ' Placeholder, can be combo box later
            cmdTrans.Parameters.AddWithValue("@status", "Completed")

            Dim transactionID As Integer = Convert.ToInt32(cmdTrans.ExecuteScalar())

            ' Insert each item into TransactionItems
            For Each row As DataGridViewRow In dgvCart.Rows
                If row.IsNewRow Then Continue For

                Dim cmdItem As New SqlCommand("INSERT INTO TransactionItems (TransactionID, ProductName, Quantity, Price, Total)
                                           VALUES (@tid, @pname, @qty, @price, @total)", con)
                cmdItem.Parameters.AddWithValue("@tid", transactionID)
                cmdItem.Parameters.AddWithValue("@pname", row.Cells("Item").Value.ToString())
                cmdItem.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells("Quantity").Value))
                cmdItem.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells("Price").Value.ToString().Replace("₱", "")))
                cmdItem.Parameters.AddWithValue("@total", Convert.ToDecimal(row.Cells("Total").Value))
                cmdItem.ExecuteNonQuery()
                ' Update stock after inserting each item
                Dim cmdUpdateStock As New SqlCommand("
                  UPDATE Products 
                  SET Stock = CASE 
                    WHEN Stock >= @qty THEN Stock - @qty 
                    ELSE 0 
                  END
                  WHERE ProductName = @pname", con)

                cmdUpdateStock.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells("Quantity").Value))
                cmdUpdateStock.Parameters.AddWithValue("@pname", row.Cells("Item").Value.ToString())
                cmdUpdateStock.ExecuteNonQuery()

            Next

            'refresh local stock data
            Try
                tempStock.Clear()
                cbClothingType.Items.Clear()

                Dim cmd As New SqlCommand("SELECT ProductName, Stock FROM Products", con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim pname As String = reader("ProductName").ToString()
                    Dim stock As Integer = Convert.ToInt32(reader("Stock"))
                    tempStock(pname) = stock
                    cbClothingType.Items.Add(pname)
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message)
            End Try

        End Using

        MsgBox("Checkout successful! Transaction saved.", vbInformation, "Success")

        dgvCart.Rows.Clear()
        grandTotal = 0
        lGrandTotal.Text = "₱0.00"
        RefreshProductInfo()


    End Sub


    ' Recalculate grand total from dgvCart and update label
    Private Sub RecalculateGrandTotal()
        grandTotal = 0D
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                Dim cellVal = row.Cells("Total").Value
                Dim dec As Decimal = 0D

                If cellVal IsNot Nothing Then
                    If TypeOf cellVal Is Decimal OrElse TypeOf cellVal Is Double OrElse TypeOf cellVal Is Single OrElse TypeOf cellVal Is Integer Then
                        dec = Convert.ToDecimal(cellVal)
                    Else
                        ' If it’s a string (maybe with currency symbol), try to parse safely
                        Dim s As String = cellVal.ToString().Replace("₱", "").Trim()
                        Decimal.TryParse(s, Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, dec)
                    End If
                End If

                grandTotal += dec
            End If
        Next

        lGrandTotal.Text = "₱" & grandTotal.ToString("N2")
    End Sub

    Private Sub btnManageStocks_Click(sender As Object, e As EventArgs) Handles btnManageStocks.Click
        Dim manageStocks As New ManageStocks()
        AddHandler manageStocks.StocksUpdated, AddressOf RefreshProductInfo
        manageStocks.Show()  ' Waits here until form is closed
    End Sub
End Class