Imports Microsoft.Data.SqlClient
Imports Microsoft.VisualBasic.DateAndTime
Public Class ExpensesControl
    Dim adapter As SqlDataAdapter
    Dim paymentStatus() As String = {"Paid", "Unpaid"}
    Dim category() As String = {"Utilities", "Rent", "Salaries", "Supplies", "Maintenance", "Miscellaneous"}
    Dim categoryFilter() As String = {"All", "Utilities", "Rent", "Salaries", "Supplies", "Maintenance", "Miscellaneous"}
    Dim paymentFilter() As String = {"All", "Paid", "Unpaid"}

    'load expenses control
    Public Sub LoadComboBoxes()
        cbPaymentStatus.Items.AddRange(paymentStatus)
        cbPaymentStatus.SelectedIndex = 1
        cbExpensesCategory.Items.AddRange(category)
        cbExpensesCategory.SelectedIndex = 0
        cbFilterCategory.Items.AddRange(categoryFilter)
        cbFilterCategory.SelectedIndex = 0
        cbFilterStatus.Items.AddRange(paymentFilter)
        cbFilterStatus.SelectedIndex = 0
    End Sub
    'initialize expenses datagridview
    Public Sub InitializeExpenses()
        dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExpenses.DefaultCellStyle.ForeColor = Color.Black
        LoadComboBoxes()
        LoadExpenses()
    End Sub

    'load expenses from database into datagridview
    Private Sub LoadExpenses()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "
                SELECT ExpenseID, Date, Description, Amount, AddedBy, DueDate, Status, PaidDate, Category
                FROM Expenses
                ORDER BY Date DESC
                "
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
        ElseIf dtpExpensesDueDate.Value < DateTime.Now Then
            MessageBox.Show("Expense due date cannot be in the past.")
            Return
        Else
            Using con As New SqlConnection(connectAs)
                Dim cmd As New SqlCommand("INSERT INTO Expenses (Date, Description, Amount, AddedBy, DueDate, Status, PaidDate, Category) VALUES (@date, @description, @amount, @addedby, @duedate, @status, @paiddate, @category)", con)
                cmd.Parameters.AddWithValue("@date", DateTime.Now)
                cmd.Parameters.AddWithValue("@description", txtbDescription.Text)
                cmd.Parameters.AddWithValue("@amount", nudExpenseAmount.Value)
                cmd.Parameters.AddWithValue("@addedby", "admin")
                cmd.Parameters.AddWithValue("@duedate", dtpExpensesDueDate.Value)
                cmd.Parameters.AddWithValue("@status", cbPaymentStatus.Text.ToString())
                cmd.Parameters.AddWithValue("@paiddate", If(cbPaymentStatus.SelectedItem = "Paid", DateTime.Now, DBNull.Value)) ' If paid, set paid date to now, else null
                cmd.Parameters.AddWithValue("@category", cbExpensesCategory.Text.ToString())

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

    Private Sub ApplyFilters()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "SELECT ExpenseID, Date, Description, Amount, AddedBy, DueDate, Status, PaidDate, Category FROM Expenses WHERE 1=1"
                Dim cmd As New SqlCommand()

                'FILTER: date range
                If chkUseDateFilter.Checked Then
                    query &= " AND Date BETWEEN @from AND @to"
                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date)
                End If

                'FILTER: category
                If cbFilterCategory.SelectedIndex > 0 Then
                    query &= " AND Category = @category"
                    cmd.Parameters.AddWithValue("@category", cbFilterCategory.Text)
                End If

                'FILTER: payment status
                If cbFilterStatus.SelectedIndex > 0 Then
                    query &= " AND Status = @status"
                    cmd.Parameters.AddWithValue("@status", cbFilterStatus.Text)
                End If

                query &= " ORDER BY Date DESC"
                cmd.CommandText = query
                cmd.Connection = con

                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(table)

                dgvExpenses.DataSource = table

                'update total based on filtered results
                lblTotalExpenses.Text = table.AsEnumerable().Sum(Function(r) Convert.ToDecimal(r("Amount"))).ToString("₱#,##0.00")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error applying filters: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetFilters()
        chkUseDateFilter.Checked = False
        dtpFrom.Value = DateTime.Now
        dtpTo.Value = DateTime.Now
        cbFilterCategory.SelectedIndex = 0
        cbFilterStatus.SelectedIndex = 0
        LoadExpenses()
    End Sub

    Private Sub btnMarkAsPaid_Click(sender As Object, e As EventArgs) Handles btnMarkAsPaid.Click

    End Sub

    Private Sub btnUpdateExpenses_Click(sender As Object, e As EventArgs) Handles btnUpdateExpenses.Click

    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        ResetFilters()
    End Sub

    Private Sub btnApplyFilters_Click(sender As Object, e As EventArgs) Handles btnApplyFilters.Click
        ApplyFilters()
    End Sub
End Class
