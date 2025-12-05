Imports System.ComponentModel
Imports System.Data.Common
Imports Microsoft.Data.SqlClient

Public Class ManageStocksControl
    Inherits UserControl
    Dim con As New SqlConnection(connectAs)
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable()

    'start of admin/employee logic
    Private _loggedInUserId As Integer
    Private _role As String

    Public Property LoggedInUserId As Integer
        Get
            Return _loggedInUserId
        End Get
        Set(value As Integer)
            _loggedInUserId = value
            _role = GetLoggedInUserRole() ' fetch role from DB
            ApplyRoleRestrictions()
        End Set
    End Property

    Private Function GetLoggedInUserRole() As String
        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim query As String = "SELECT Role FROM Users WHERE UserID=@id"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", _loggedInUserId)
                Dim roleObj = cmd.ExecuteScalar()
                Return If(roleObj IsNot Nothing, roleObj.ToString(), String.Empty)
            End Using
        End Using
    End Function

    Private Sub ApplyRoleRestrictions()
        If _loggedInUserId = 0 Then Exit Sub

        Dim role As String = GetLoggedInUserRole() ' fetch from DB
        If role = "Employee" Then
            ' Disable admin-only controls
            gbAddProduct.Enabled = False
            gbManageStocks.Enabled = False
            dgvStocks.ReadOnly = True
        End If
    End Sub
    'end of admin/employee logic

    Public Sub InitializeStocks()
        LoadProducts()
        ApplyRoleRestrictions()
    End Sub

    'live update stock
    Public Event StocksUpdated()

    Private Sub LoadProducts()

        adapter = New SqlDataAdapter("SELECT * FROM Products", con)
        Dim builder As New SqlCommandBuilder(adapter)  ' Generates automatic SQL UPDATE/INSERT/DELETE
        dt.Clear()
        adapter.Fill(dt)
        dgvStocks.DataSource = dt
        dgvStocks.AllowUserToAddRows = False

    End Sub

    Private Sub ManageStocksControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LoadProducts()
        dgvStocks.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            adapter.Update(dt)
            RaiseEvent StocksUpdated()
            dgvStocks.GridColor = Color.AliceBlue
            MessageBox.Show("Changes saved successfully!")
            lblChangeConfirm.Text = ""
            dgvStocks.GridColor = Color.White

        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message)
        End Try
    End Sub

    Private Sub btnApplyToCell_Click(sender As Object, e As EventArgs) Handles btnApplyToCell.Click
        If dgvStocks.CurrentCell Is Nothing Then
            MessageBox.Show("Please select a cell to modify.")
            Return
        ElseIf dgvStocks.CurrentCell.ColumnIndex <> 2 Then
            MessageBox.Show("Please select a cell in the 'Stock' column to modify.")
            Return
        ElseIf nudAddSubtract.Value = 0 Then
            MessageBox.Show("Please enter a non-zero value to add or subtract.")
            Return
        ElseIf dgvStocks.CurrentCell.Value + nudAddSubtract.Value < 0 Then
            MessageBox.Show("Stock cannot be negative.")
            Return
        ElseIf nudAddSubtract.Value <> Math.Truncate(nudAddSubtract.Value) Then
            MessageBox.Show("Selected cell does not contain a numeric whole value.")
            nudAddSubtract.Value = 0
        Else
            Dim rowIndex = dgvStocks.CurrentCell.RowIndex
            Dim stockColIndex = dgvStocks.CurrentCell.ColumnIndex
            Dim newValue = CInt(dgvStocks.CurrentCell.Value + nudAddSubtract.Value)

            ' Update DataTable directly
            dt.Rows(rowIndex)("Stock") = newValue

            ' Update the grid visually
            dgvStocks.CurrentCell.Value = newValue
        End If

    End Sub

    Private Sub dgvStocks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStocks.CellValueChanged
        dgvStocks.GridColor = Color.Yellow

        dgvStocks.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dgvStocks.EndEdit()
    End Sub


    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If String.IsNullOrWhiteSpace(tbProductName.Text) Then
            MsgBox("Product name is empty.", vbInformation, "Empty product name")
            Exit Sub
        ElseIf nudPrice.Value <= 0D Then
            MsgBox("Price cannot be zero or lower, please pick a greater number.", vbInformation, "Invalid price")
            Exit Sub
        Else
            Using con As New SqlConnection(connectAs)
                Dim cmd As New SqlCommand("INSERT INTO Products (ProductName, Stock, RegularPrice, Supplier) VALUES (@name, @stock, @price, @supplier)", con)
                cmd.Parameters.AddWithValue("@supplier", tbSupplier.Text)
                cmd.Parameters.AddWithValue("@name", tbProductName.Text)
                cmd.Parameters.AddWithValue("@stock", nudStock.Value)
                cmd.Parameters.AddWithValue("@price", nudPrice.Value)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadProducts()
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If dgvStocks.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product to remove.")
            Return
        End If

        Dim productId As Integer = dgvStocks.SelectedRows(0).Cells("ProductID").Value
        If MessageBox.Show("Delete selected product?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using con As New SqlConnection(connectAs)
                Dim cmd As New SqlCommand("DELETE FROM Products WHERE ProductID=@id", con)
                cmd.Parameters.AddWithValue("@id", productId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadProducts()
        End If
    End Sub

    'catch dgv errors
    Private Sub dgvStocks_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) _
    Handles dgvStocks.DataError

        e.ThrowException = False
        e.Cancel = True
    End Sub

    'price handler
    Private Sub Price_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim tb As TextBox = DirectCast(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then Return
        If Char.IsDigit(e.KeyChar) Then Return

        If e.KeyChar = "."c AndAlso Not tb.Text.Contains("."c) Then Return

        e.Handled = True
    End Sub


    'handle editing
    Private Sub dgvStocks_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
    Handles dgvStocks.EditingControlShowing

        If dgvStocks.CurrentCell Is Nothing Then Exit Sub

        If dgvStocks.Columns(dgvStocks.CurrentCell.ColumnIndex).Name = "RegularPrice" Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)
            If tb IsNot Nothing Then
                RemoveHandler tb.KeyPress, AddressOf Price_KeyPress
                AddHandler tb.KeyPress, AddressOf Price_KeyPress
            End If
        End If

    End Sub


    'edit cell validation
    Private Sub dgvStocks_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) _
    Handles dgvStocks.CellValidating

        If dgvStocks.Columns(e.ColumnIndex).Name <> "RegularPrice" Then Return

        Dim input As String = e.FormattedValue.ToString().Trim()
        Dim value As Decimal

        ' Empty not allowed
        If String.IsNullOrWhiteSpace(input) Then
            dgvStocks.Rows(e.RowIndex).ErrorText = "Price cannot be empty."
            e.Cancel = True
            Return
        End If

        ' Not numeric
        If Not Decimal.TryParse(input, value) Then
            dgvStocks.Rows(e.RowIndex).ErrorText = "Enter a valid number."
            e.Cancel = True
            Return
        End If

        ' Range check
        If value < 0 OrElse value > 10000 Then
            dgvStocks.Rows(e.RowIndex).ErrorText = "Price must be between 0 and 10,000."
            e.Cancel = True
            Return
        End If

        ' No error
        dgvStocks.Rows(e.RowIndex).ErrorText = ""
    End Sub


    'clear errors, validate edited cells    
    Private Sub dgvStocks_CellValidated(sender As Object, e As DataGridViewCellEventArgs) _
    Handles dgvStocks.CellValidated

        dgvStocks.Rows(e.RowIndex).ErrorText = ""
    End Sub



    'normalize decimal values
    Private Sub dgvStocks_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) _
    Handles dgvStocks.CellParsing

        If dgvStocks.Columns(e.ColumnIndex).Name = "RegularPrice" Then
            Dim value As Decimal
            If Decimal.TryParse(e.Value?.ToString(), value) Then
                e.Value = value
                e.ParsingApplied = True
            End If
        End If

    End Sub


End Class