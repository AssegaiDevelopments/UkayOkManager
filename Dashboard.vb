'Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System

Public Class Dashboard
    ' Enable double buffering to reduce flickering
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000   ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property


    Dim clothingType, pname As String
    Dim quantity, discount As Integer
    Dim itemTotal, price, grandTotal As Decimal
    Dim tempStock As New Dictionary(Of String, Integer)
    Dim unselectedColor As Color = Color.FromArgb(23, 77, 113)
    Dim selectedColor As Color = Color.SeaGreen
    Private stocksControl As New ManageStocksControl()
    Private transactionsControl As New ViewTransactionsControl()
    'Private cartControl As New CartControl()



    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()
        pnlMain.Controls.Add(stocksControl)
        pnlMain.Controls.Add(transactionsControl)

        stocksControl.Dock = DockStyle.Fill
        transactionsControl.Dock = DockStyle.Fill

        Using con As New SqlConnection(connectAs)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT ProductName, Stock FROM Products", con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    pname = reader("ProductName").ToString()
                    If pname IsNot Nothing Then
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

        Try
            dgvCart.ColumnCount = 4
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvCart.Columns(0).Name = "Item"
            dgvCart.Columns(1).Name = "Price"
            dgvCart.Columns(2).Name = "Quantity"
            dgvCart.Columns(3).Name = "Total"
            dgvCart.Columns(3).DefaultCellStyle.Format = "N2"

            cbClothingType.SelectedIndex = 0
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Error: No products available to select. Please add products using the Manage Stocks menu")
        Catch ex As Exception
            MessageBox.Show("Error initializing cart: " & ex.Message)

        End Try


    End Sub
    'Minimize application
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Exit application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Close()
        Close()
    End Sub
    'Change visible panel in pnlMain and update sidebar button colors
    Private Sub ShowPanel(panelToShow As Control)
        pnlMain.SuspendLayout()

        ' Update sidebar button colors; use tag to match panel names
        For Each btn As Button In flpSidebar.Controls.OfType(Of Button)()
            If btn.Tag IsNot Nothing AndAlso btn.Tag.ToString() = panelToShow.Name Then
                btn.BackColor = selectedColor
            Else
                btn.BackColor = unselectedColor
            End If
        Next

        ' Hide everything inside pnlMain first
        For Each ctrl As Control In pnlMain.Controls
            ctrl.Visible = False
        Next

        ' Bring the selected panel/UserControl to front and show it
        panelToShow.Visible = True
        panelToShow.BringToFront()

        pnlMain.ResumeLayout(True)
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
    ' Refresh product info from DB and update stock label
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
        End Using

        ' Step 2: Update stock label
        If tempStock.ContainsKey(cbClothingType.Text) Then
            If tempStock(cbClothingType.Text) >= 5 Then
                lblStock.Text = "Remaining stock: " & tempStock(cbClothingType.Text).ToString()
                lblStock.ForeColor = Color.White
            ElseIf tempStock(cbClothingType.Text) < 5 Then
                lblStock.Text = "Remaining stock: " & tempStock(cbClothingType.Text).ToString()
                lblStock.ForeColor = Color.Orange
            ElseIf tempStock(cbClothingType.Text) = 0 Then
                lblStock.Text = "Not available"
                lblStock.ForeColor = Color.Red
            End If
        Else
            lblStock.Text = "Not available"
            lblStock.ForeColor = Color.Red
        End If
    End Sub
    ' Refresh combo box and local stock dictionary from DB
    Sub refreshComboBoxInfo()
        Using con As New SqlConnection(connectAs)
            con.Open()
            Try
                tempStock.Clear()
                cbClothingType.Items.Clear()

                Dim cmd As New SqlCommand("SELECT ProductName, Stock FROM Products", con)
                Dim reader = cmd.ExecuteReader

                While reader.Read
                    Dim pname = reader("ProductName").ToString
                    Dim stock = Convert.ToInt32(reader("Stock"))
                    tempStock(pname) = stock
                    cbClothingType.Items.Add(pname)
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message)
            End Try
        End Using
    End Sub
    'add item to cart/dgv table
    Private Sub btnAddItemToCart_Click(sender As Object, e As EventArgs) Handles btnAddItemToCart.Click
        ' Validate price and quantity
        Dim parsedPrice As Decimal
        If Decimal.TryParse(txtbItemPrice.Text, parsedPrice) AndAlso nudQuantity.Value > 0 Then

            price = parsedPrice
            clothingType = cbClothingType.Text
            quantity = CInt(nudQuantity.Value)

            If Not chbxDiscount.Checked Or nudDiscount.Value = 0 Or discount = 0 Then
                itemTotal = quantity * price
            Else
                itemTotal = quantity * price * (1 - discount * 0.01D)
            End If

            ' Get available stock from DB
            Dim selectedItem = cbClothingType.Text
            Dim availableStock = tempStock(selectedItem)

            If nudQuantity.Value > availableStock Then
                MsgBox("Not enough stock available.")
                Exit Sub
            End If

            ' Check combined quantities already in cart for the same item
            Dim totalInCart = 0
            For Each row As DataGridViewRow In dgvCart.Rows
                If Not row.IsNewRow AndAlso row.Cells("Item").Value.ToString = clothingType Then
                    totalInCart += Convert.ToInt32(row.Cells("Quantity").Value)
                End If
            Next

            Dim totalRequested = totalInCart + quantity
            If totalRequested > availableStock Then
                MsgBox("Not enough stock available. You already have " & totalInCart &
               " of this item in your cart. Only " & availableStock - totalInCart & " left.")
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
    'discount feature
    Private Sub chbxDiscountEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDiscount.CheckedChanged
        If chbxDiscount.Checked Then
            nudDiscount.Enabled = True
            lDiscount.Enabled = True
        Else
            nudDiscount.Enabled = False
            nudDiscount.Value = 0
            lDiscount.Text = "Discount: 0%"
            lDiscount.Enabled = False

        End If
    End Sub
    'discount value changed
    Private Sub nudDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscount.ValueChanged
        discount = CInt(nudDiscount.Value)
        lDiscount.Text = "Discount: " & discount.ToString & "%"
    End Sub

    'Display price and stock based on selected clothing type
    Private Sub cbClothingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClothingType.SelectedIndexChanged
        Using con As New SqlConnection(connectAs)
            Dim cmd As New SqlCommand("SELECT RegularPrice, Stock FROM Products WHERE ProductName = @name", con)
            cmd.Parameters.AddWithValue("@name", cbClothingType.Text)
            con.Open()
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                txtbItemPrice.Text = reader("RegularPrice").ToString
                lblStock.Text = "Remaining stock: " & reader("Stock").ToString
                RefreshProductInfo()
                'lblStockAvailable.Text = "Available: " & reader("Stock").ToString()
            End If
            reader.Close()
        End Using
    End Sub
    'Clear cart and reset grand total
    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        dgvCart.Rows.Clear()
        grandTotal = 0
        lGrandTotal.Text = "₱0.00"
        RefreshProductInfo()
    End Sub
    ' Remove selected item from cart and update stock and grand total
    Private Sub btnRemoveItemFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveItemFromCart.Click
        If dgvCart.SelectedRows.Count > 0 Then
            Dim row = dgvCart.SelectedRows(0)
            Dim itemName = row.Cells("Item").Value.ToString
            Dim qty = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim total = Convert.ToDecimal(row.Cells("Total").Value)

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

        Dim totalAmount = 0D
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.IsNewRow Then Continue For
            totalAmount += Convert.ToDecimal(row.Cells("Total").Value)
        Next

        Using con As New SqlConnection(connectAs)
            con.Open()

            ' Insert the transaction first
            Dim cmdTrans As New SqlCommand("
            INSERT INTO Transactions 
            (Username, TotalAmount, PaymentMethod, Status, TransactionDate, Remarks, TransactionType)
            OUTPUT INSERTED.TransactionID
            VALUES (@user, @total, @method, @status, @date, @remarks, @type)", con)

            cmdTrans.Parameters.AddWithValue("@user", "Admin")
            cmdTrans.Parameters.AddWithValue("@total", totalAmount)

            'Payment Method
            Dim paymentForm As New SelectPayment
            paymentForm.CartTotal = totalAmount   ' Pass total to the payment window

            If paymentForm.ShowDialog <> DialogResult.OK OrElse Not paymentForm.PaymentConfirmed Then
                MsgBox("Checkout cancelled or not confirmed.", vbExclamation, "Cancelled")
                Exit Sub
            End If

            Dim paymentMethod = paymentForm.SelectedMethod

            cmdTrans.Parameters.AddWithValue("@method", paymentMethod)
            cmdTrans.Parameters.AddWithValue("@status", "Completed")
            cmdTrans.Parameters.AddWithValue("@date", Date.Now)
            If txtbRemarks.Text.IsNullOrWhiteSpace(txtbRemarks.Text) Then
                cmdTrans.Parameters.AddWithValue("@remarks", DBNull.Value)
            Else
                cmdTrans.Parameters.AddWithValue("@remarks", txtbRemarks.Text)             ' remarks
            End If
            cmdTrans.Parameters.AddWithValue("@type", "Sale")               ' e.g. "Sale", "Return", "Exchange", etc.

            Dim transactionID = Convert.ToInt32(cmdTrans.ExecuteScalar)

            'Insert each item into TransactionItems
            For Each row As DataGridViewRow In dgvCart.Rows
                If row.IsNewRow Then Continue For

                Dim cmdItem As New SqlCommand("
                INSERT INTO TransactionItems 
                (TransactionID, ProductName, Quantity, Price, Total)
                VALUES (@tid, @pname, @qty, @price, @total)", con)

                cmdItem.Parameters.AddWithValue("@tid", transactionID)
                cmdItem.Parameters.AddWithValue("@pname", row.Cells("Item").Value.ToString)
                cmdItem.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells("Quantity").Value))
                cmdItem.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells("Price").Value.ToString.Replace("₱", "")))
                cmdItem.Parameters.AddWithValue("@total", Convert.ToDecimal(row.Cells("Total").Value))
                cmdItem.ExecuteNonQuery()

                'Update stock after inserting each item
                Dim cmdUpdateStock As New SqlCommand("
                UPDATE Products 
                SET Stock = CASE 
                    WHEN Stock >= @qty THEN Stock - @qty 
                    ELSE 0 
                END
                WHERE ProductName = @pname", con)

                cmdUpdateStock.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells("Quantity").Value))
                cmdUpdateStock.Parameters.AddWithValue("@pname", row.Cells("Item").Value.ToString)
                cmdUpdateStock.ExecuteNonQuery()
            Next

            ' Refresh local stock data
            refreshComboBoxInfo()
        End Using

        MsgBox("Checkout successful! Transaction saved.", vbInformation, "Success")

        dgvCart.Rows.Clear()
        grandTotal = 0
        lGrandTotal.Text = "₱0.00"
        RefreshProductInfo()
        cbClothingType.SelectedIndex = 0
    End Sub

    'Showpanel() buttons
    Private Sub btnManageStocks_Click(sender As Object, e As EventArgs) Handles btnManageStocks.Click

        ShowPanel(stocksControl)
    End Sub

    Private Sub btnViewTransaction_Click(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        ShowPanel(transactionsControl)
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        refreshComboBoxInfo()
        ShowPanel(pnlCart)
    End Sub

End Class