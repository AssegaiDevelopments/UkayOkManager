Imports Microsoft.Data.SqlClient
Public Class ExpensesControl
    Dim adapter As SqlDataAdapter

    'initialize expenses datagridview
    Public Sub InitializeExpenses()
        dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExpenses.DefaultCellStyle.ForeColor = Color.Black
        LoadExpenses()
    End Sub

    'load expenses from database into datagridview
    Private Sub LoadExpenses()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "SELECT * FROM Expenses ORDER BY Date DESC"
                Dim adapter As New SqlDataAdapter(query, con)
                Dim table As New DataTable()
                table.Clear()
                adapter.Fill(table)

                dgvExpenses.DataSource = table

                lblTotalExpenses.Text = dgvExpenses.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) Convert.ToDecimal(row.Cells("Amount").Value)).ToString("₱#,##0.00")
            End Using

            ' Optional formatting
            With dgvExpenses
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If .Columns.Contains("Amount") Then
                    .Columns("Amount").DefaultCellStyle.Format = "₱#,##0.00"
                End If
                If .Columns.Contains("Date") Then
                    .Columns("Date").DefaultCellStyle.Format = "yyyy-MM-dd"
                End If

                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

        Catch ex As Exception
            MessageBox.Show("Error loading expenses: " & ex.Message)
        End Try
    End Sub

    'add expense to database
    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click
        If String.IsNullOrWhiteSpace(txtbDescription.Text) Then
            MessageBox.Show("Please enter a description for the expense.")
            Return
        ElseIf nudExpenseAmount.Value <= 0 Then
            MessageBox.Show("Please enter a valid amount greater than zero.")
            Return
        ElseIf dtpExpenseDate.Value > DateTime.Now Then
            MessageBox.Show("Expense date cannot be in the future.")
            Return
        Else
            Using con As New SqlConnection(connectAs)
                Dim cmd As New SqlCommand("INSERT INTO Expenses (Date, Description, Amount, AddedBy) VALUES (@date, @description, @amount, @addedby)", con)
                cmd.Parameters.AddWithValue("@date", dtpExpenseDate.Value)
                cmd.Parameters.AddWithValue("@description", txtbDescription.Text)
                cmd.Parameters.AddWithValue("@amount", nudExpenseAmount.Value)
                cmd.Parameters.AddWithValue("@addedby", "admin")
                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            ' Refresh the DataGridView
            LoadExpenses()

            ' Optional: Clear inputs
            txtbDescription.Clear()
            nudExpenseAmount.Value = 0
        End If
    End Sub

    'remove expense
    Private Sub btnRemoveExpense_Click(sender As Object, e As EventArgs) Handles btnRemoveExpense.Click
        If dgvExpenses.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product to remove.")
            Return
        End If

        Dim expenseId As Integer = dgvExpenses.SelectedRows(0).Cells("ExpenseID").Value
        If MessageBox.Show("Delete selected expense?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using con As New SqlConnection(connectAs)
                Dim cmd As New SqlCommand("DELETE FROM Expenses WHERE ExpenseID=@id", con)
                cmd.Parameters.AddWithValue("@id", expenseId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadExpenses()
        End If
    End Sub
End Class
