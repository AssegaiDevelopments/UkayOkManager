Imports System.ComponentModel
Imports System.Data.Common
Imports System.Data.SqlClient
'Imports Microsoft.Data.SqlClient

Public Class ManageStocksControl
    Inherits UserControl
    Dim con As New SqlConnection(connectAs)
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable()

    'live update stock
    Public Event StocksUpdated()

    Private Sub LoadProducts()

        adapter = New SqlDataAdapter("SELECT * FROM Products", con)
        Dim builder As New SqlCommandBuilder(adapter)  ' Generates automatic SQL UPDATE/INSERT/DELETE
        dt.Clear()
        adapter.Fill(dt)
        dgvStocks.DataSource = dt

    End Sub

    Private Sub ManageStocksControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LoadProducts()
        dgvStocks.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs)
        Try
            adapter.Update(dt)
            RaiseEvent StocksUpdated()
            MessageBox.Show("Changes saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message)
        End Try
    End Sub

    Private Sub btnApplyToCell_Click(sender As Object, e As EventArgs)
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
            Dim rowIndex As Integer = dgvStocks.CurrentCell.RowIndex
            Dim stockColIndex As Integer = dgvStocks.CurrentCell.ColumnIndex
            Dim newValue = CInt(dgvStocks.CurrentCell.Value + nudAddSubtract.Value)

            ' Update DataTable directly
            dt.Rows(rowIndex)("Stock") = newValue

            ' Update the grid visually
            dgvStocks.CurrentCell.Value = newValue
        End If
    End Sub

    Private Sub dgvStocks_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        dgvStocks.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dgvStocks.EndEdit()
    End Sub

    'Private Sub ManageStocks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    If MsgBox("Do you want to save changes before closing?", MsgBoxStyle.YesNo, "Save unsaved changes") = vbYes Then
    '        btnSaveChanges.PerformClick()
    '    Else
    '        Me.Hide()
    '    End If
    'End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs)
        Dim addForm As New AddProductForm
        If addForm.ShowDialog = DialogResult.OK Then
            LoadProducts()
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs)
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

End Class