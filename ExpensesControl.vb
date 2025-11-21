Imports Microsoft.Data.SqlClient
Imports ScottPlot
Public Class ExpensesControl
    Dim adapter As SqlDataAdapter
    Dim paymentStatus() As String = {"Paid", "Unpaid"}
    Dim category() As String = {"Utilities", "Rent", "Salaries", "Supplies", "Maintenance", "Miscellaneous"}
    Dim categoryFilter() As String = {"All", "Utilities", "Rent", "Salaries", "Supplies", "Maintenance", "Miscellaneous"}
    Dim paymentFilter() As String = {"All", "Paid", "Unpaid"}

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
            gbAddUpdateExpense.Enabled = False
            btnRemoveExpense.Enabled = False
            btnAddExpense.Enabled = False
            btnMarkAsPaid.Enabled = False
        End If
    End Sub
    'end of admin/employee logic

    'Return total paid and unpaid expenses specifically for dashboard access
    Public ReadOnly Property TotalPaid As Decimal
        Get
            Return _totalPaid
        End Get
    End Property

    Public ReadOnly Property TotalUnpaid As Decimal
        Get
            Return _totalUnpaid
        End Get
    End Property

    ' Update _totalPaid and _totalUnpaid in RecalculateTotalsFromTable
    Private _totalPaid As Decimal
    Private _totalUnpaid As Decimal

    'public event to notify dashboard of updates
    Public Event ExpensesUpdated()

    ' Set logged in user and apply restrictions


    ' Get total expenses with optional filters
    Public Function GetExpenseTotal(Optional status As String = Nothing, Optional fromDate As Date? = Nothing, Optional toDate As Date? = Nothing) As Decimal
        Dim total As Decimal = 0D

        Try
            Using con As New SqlConnection(connectAs)
                con.Open()
                Dim query As String = "SELECT SUM(Amount) FROM Expenses WHERE 1=1"

                ' Add filters
                If Not String.IsNullOrEmpty(status) Then
                    query &= " AND Status = @status"
                End If

                If fromDate.HasValue Then
                    query &= " AND Date >= @fromDate"
                End If

                If toDate.HasValue Then
                    query &= " AND Date <= @toDate"
                End If

                Using cmd As New SqlCommand(query, con)
                    If Not String.IsNullOrEmpty(status) Then cmd.Parameters.AddWithValue("@status", status)
                    If fromDate.HasValue Then cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date)
                    If toDate.HasValue Then cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date)

                    Dim result = cmd.ExecuteScalar()
                    total = If(IsDBNull(result), 0D, Convert.ToDecimal(result))
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching expense total: " & ex.Message)
        End Try

        Return total
    End Function


    Public Sub LoadComboBoxes()
        cbPaymentStatus.Items.Clear()
        cbPaymentStatus.Items.AddRange(paymentStatus)
        cbPaymentStatus.SelectedIndex = 1

        cbExpensesCategory.Items.Clear()
        cbExpensesCategory.Items.AddRange(category)
        cbExpensesCategory.SelectedIndex = 0

        cbFilterCategory.Items.Clear()
        cbFilterCategory.Items.AddRange(categoryFilter)
        cbFilterCategory.SelectedIndex = 0

        cbFilterStatus.Items.Clear()
        cbFilterStatus.Items.AddRange(paymentFilter)
        cbFilterStatus.SelectedIndex = 0
    End Sub
    Private Sub ExpensesControl_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeExpenses()
    End Sub

    'initialize expenses datagridview
    Public Sub InitializeExpenses()
        dgvExpenses.AllowUserToAddRows = False
        dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExpenses.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        chartCategoryExpenses.Plot.Title()
        chartDailyExpenses.Plot.DataBackground.Color = Colors.White
        LoadComboBoxes()
        LoadExpenses()
        LoadDailyExpenseChart()
        LoadCategoryChart()
        RecalculateTotalsFromTable()
        ApplyRoleRestrictions()
    End Sub

    Private Sub RecalculateTotalsFromTable()
        Try
            Dim table As DataTable = TryCast(dgvExpenses.DataSource, DataTable)
            If table Is Nothing OrElse table.Rows.Count = 0 Then
                lblTotalUnpaid.Text = "₱0.00"
                lblTotalPaid.Text = "₱0.00"
                Return
            End If

            ' total unpaid
            Dim totalUnpaid As Decimal = table.AsEnumerable().
            Where(Function(r) Not r.IsNull("Status") AndAlso String.Equals(Convert.ToString(r("Status")), "Unpaid", StringComparison.OrdinalIgnoreCase)).
            Sum(Function(r) If(r.IsNull("Amount"), 0D, Convert.ToDecimal(r("Amount"))))

            ' total paid
            Dim totalPaid As Decimal = table.AsEnumerable().
            Where(Function(r) Not r.IsNull("Status") AndAlso String.Equals(Convert.ToString(r("Status")), "Paid", StringComparison.OrdinalIgnoreCase)).
            Sum(Function(r) If(r.IsNull("Amount"), 0D, Convert.ToDecimal(r("Amount"))))

            lblTotalUnpaid.Text = totalUnpaid.ToString("₱#,##0.00")
            lblTotalPaid.Text = totalPaid.ToString("₱#,##0.00")

            'put totalpaid and totalunpaid to public so dashboard can access
            _totalPaid = totalPaid
            _totalUnpaid = totalUnpaid
        Catch ex As Exception
            MessageBox.Show("Error calculating totals: " & ex.Message)
        End Try
    End Sub


    'load expenses from database into datagridview
    Private Sub LoadExpenses()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "
                SELECT ExpenseID, Date, Description, Amount, AddedBy, DueDate, Status, PaidDate, Category
                FROM Expenses
                ORDER BY Date DESC"
                Dim adapterLocal As New SqlDataAdapter(query, con)
                Dim table As New DataTable()
                adapterLocal.Fill(table)

                dgvExpenses.DataSource = table

                If dgvExpenses.Columns.Contains("ExpenseID") Then
                    dgvExpenses.Columns("ExpenseID").Visible = False
                End If
            End Using

            ' Visual formatting
            With dgvExpenses
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                If .Columns.Contains("Amount") Then .Columns("Amount").DefaultCellStyle.Format = "₱#,##0.00"
                If .Columns.Contains("Date") Then .Columns("Date").DefaultCellStyle.Format = "yyyy-MM-dd"
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

            ' Safely compute totals from the bound DataTable
            RecalculateTotalsFromTable()

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
            RaiseEvent ExpensesUpdated()
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
            RaiseEvent ExpensesUpdated()
            LoadExpenses()
        End If
    End Sub
    'apply filters to expenses
    Private Sub ApplyFilters()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "SELECT ExpenseID, Date, Description, Amount, AddedBy, DueDate, Status, PaidDate, Category FROM Expenses WHERE 1=1"
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                If chkUseDateFilter.Checked Then
                    query &= " AND Date BETWEEN @from AND @to"
                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date)
                End If

                If cbFilterCategory.SelectedIndex > 0 Then
                    query &= " AND Category = @category"
                    cmd.Parameters.AddWithValue("@category", cbFilterCategory.Text)
                End If

                If cbFilterStatus.SelectedIndex > 0 Then
                    query &= " AND Status = @status"
                    cmd.Parameters.AddWithValue("@status", cbFilterStatus.Text)
                End If

                query &= " ORDER BY Date DESC"
                cmd.CommandText = query

                Dim table As New DataTable()
                Dim adapterLocal As New SqlDataAdapter(cmd)
                adapterLocal.Fill(table)

                dgvExpenses.DataSource = table

                ' Recompute totals safely for the filtered results
                RecalculateTotalsFromTable()
                lblPaidMode.Text = "Total Paid Expenses (Filtered)"
                lblUnpaidMode.Text = "Total Unpaid Expenses (Filtered)"
            End Using

        Catch ex As Exception
            MessageBox.Show("Error applying filters: " & ex.Message)
        End Try
    End Sub

    'reset filters to default
    Private Sub ResetFilters()
        chkUseDateFilter.Checked = False
        dtpFrom.Value = DateTime.Now
        dtpTo.Value = DateTime.Now
        cbFilterCategory.SelectedIndex = 0
        cbFilterStatus.SelectedIndex = 0
        lblPaidMode.Text = "Total Paid Expenses"
        lblUnpaidMode.Text = "Total Unpaid Expenses"
        LoadExpenses()
    End Sub
    'load category expense chart
    Private Sub LoadCategoryChart()
        Dim categories As New List(Of String)
        Dim amounts As New List(Of Double)

        ' --- Fetch data ---
        Using con As New SqlConnection(connectAs)
            con.Open()
            Dim query As String = "
            SELECT Category, SUM(Amount) AS TotalAmount
            FROM Expenses
            GROUP BY Category
            ORDER BY Category;"
            Using cmd As New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        categories.Add(reader("Category").ToString())
                        amounts.Add(Convert.ToDouble(reader("TotalAmount")))
                    End While
                End Using
            End Using
        End Using

        ' --- Reset chart if no data ---
        chartCategoryExpenses.Plot.Clear()
        If categories.Count = 0 Then
            chartCategoryExpenses.Refresh()
            Return
        End If

        ' --- Create Pie Chart with Labels ---
        Dim pie = chartCategoryExpenses.Plot.Add.Pie(amounts.ToArray())

        ' THIS IS WHERE LABELS GET ADDED (ScottPlot 5)

        ' Optional: show percentages inside slice

        pie.DonutFraction = 0 ' full pie

        ' Legend — will show slice names
        chartCategoryExpenses.Plot.Legend.IsVisible = True

        ' Hide axes
        chartCategoryExpenses.Plot.HideAxesAndGrid()

        ' Fix bounds
        chartCategoryExpenses.Plot.Axes.SetLimits(-1.5, 1.5, -1.5, 1.5)

        ' Disable zoom/pan
        chartCategoryExpenses.UserInputProcessor.IsEnabled = False

        ' Title
        chartCategoryExpenses.Plot.Title("Expenses by Category")

        chartCategoryExpenses.Refresh()
    End Sub


    'load daily expense chart for last 30 days
    Private Sub LoadDailyExpenseChart()
        ' containers
        Dim x As New List(Of Double)
        Dim y As New List(Of Double)

        ' Query daily totals for the last 30 days
        Using con As New SqlConnection(connectAs)
            con.Open()

            Dim query As String = "
            SELECT CAST(Date AS DATE) AS Day,
                   SUM(Amount) AS Total
            FROM Expenses
            WHERE Date >= DATEADD(day, -29, CAST(GETDATE() AS DATE))
            GROUP BY CAST(Date AS DATE)
            ORDER BY Day;"

            Using cmd As New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' convert date to OADate for ScottPlot date axis
                        x.Add(reader.GetDateTime(0).ToOADate())
                        y.Add(Convert.ToDouble(reader("Total")))
                    End While
                End Using
            End Using
        End Using

        ' Draw the line chart
        chartDailyExpenses.Plot.Clear()
        If x.Count = 0 Then
            chartDailyExpenses.Refresh()
            Return
        End If

        chartDailyExpenses.Plot.Add.Scatter(x.ToArray(), y.ToArray())
        chartDailyExpenses.Plot.Title("Daily Expenses (Last 30 Days)")
        chartDailyExpenses.Plot.XLabel("Date")
        chartDailyExpenses.Plot.YLabel("₱")
        chartDailyExpenses.Plot.Axes.DateTimeTicksBottom() ' format X axis as dates
        chartDailyExpenses.Plot.Axes.Margins(0, 0)
        chartDailyExpenses.Refresh()
    End Sub

    'marks selected expense as paid
    Private Sub btnMarkAsPaid_Click(sender As Object, e As EventArgs) Handles btnMarkAsPaid.Click
        If dgvExpenses.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an expense to mark as paid.")
            Return
        End If

        Dim row = dgvExpenses.SelectedRows(0)
        Dim expenseId As Integer = Convert.ToInt32(row.Cells("ExpenseID").Value)
        Dim currentStatus As String = If(row.Cells("Status").Value Is Nothing OrElse IsDBNull(row.Cells("Status").Value), "", row.Cells("Status").Value.ToString())

        If String.Equals(currentStatus, "Paid", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This expense is already marked as paid.")
            Return
        End If

        If MessageBox.Show("Mark this expense as paid?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Using con As New SqlConnection(connectAs)
            Using cmd As New SqlCommand("
            UPDATE Expenses 
            SET Status = 'Paid',
                PaidDate = GETDATE()
            WHERE ExpenseID = @id;", con)
                cmd.Parameters.AddWithValue("@id", expenseId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Reload and refresh charts/totals
        LoadExpenses()
        LoadDailyExpenseChart()
        LoadCategoryChart()
        RaiseEvent ExpensesUpdated()

        MessageBox.Show("Expense marked as paid.")
    End Sub

    'Update selected expense
    Private Sub btnUpdateExpenses_Click(sender As Object, e As EventArgs) Handles btnUpdateExpenses.Click
        If dgvExpenses.SelectedRows.Count = 0 Then
            MessageBox.Show("Select an expense to update.")
            Return
        End If

        Dim row = dgvExpenses.SelectedRows(0)
        Dim expenseId As Integer = Convert.ToInt32(row.Cells("ExpenseID").Value)

        If String.IsNullOrWhiteSpace(txtbDescription.Text) Then
            MessageBox.Show("Please enter a description.")
            Return
        End If

        If nudExpenseAmount.Value <= 0 Then
            MessageBox.Show("Amount must be greater than zero.")
            Return
        End If

        If dtpExpensesDueDate.Value < DateTime.Now Then
            MessageBox.Show("Due date cannot be in the past.")
            Return
        End If

        Using con As New SqlConnection(connectAs)
            Using cmd As New SqlCommand("
            UPDATE Expenses SET
                Description = @desc,
                Amount = @amount,
                DueDate = @due,
                Status = @status,
                Category = @cat,
                PaidDate = CASE WHEN @status = 'Paid' THEN GETDATE() ELSE NULL END
            WHERE ExpenseID = @id;", con)

                cmd.Parameters.AddWithValue("@desc", txtbDescription.Text)
                cmd.Parameters.AddWithValue("@amount", nudExpenseAmount.Value)
                cmd.Parameters.AddWithValue("@due", dtpExpensesDueDate.Value)
                cmd.Parameters.AddWithValue("@status", cbPaymentStatus.Text.ToString())
                cmd.Parameters.AddWithValue("@cat", cbExpensesCategory.Text.ToString())
                cmd.Parameters.AddWithValue("@id", expenseId)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadExpenses()
        LoadDailyExpenseChart()
        LoadCategoryChart()
        RaiseEvent ExpensesUpdated()
        MessageBox.Show("Expense updated successfully.")
    End Sub


    'Handles selection change in datagridview to populate fields; used with update button
    Private Sub dgvExpenses_SelectionChanged(sender As Object, e As EventArgs) Handles dgvExpenses.SelectionChanged
        If dgvExpenses.SelectedRows.Count = 0 Then Return
        Dim row = dgvExpenses.SelectedRows(0)
        'Description
        txtbDescription.Text = row.Cells("Description").Value.ToString()
        'Amount (handle DBNull)
        Dim amtObj = row.Cells("Amount").Value
        nudExpenseAmount.Value = If(IsDBNull(amtObj), 0D, Convert.ToDecimal(amtObj))
        'Due Date (handle DBNull)
        Dim dueObj = row.Cells("DueDate").Value
        If IsDBNull(dueObj) Then
            dtpExpensesDueDate.Value = DateTime.Now
        Else
            dtpExpensesDueDate.Value = Convert.ToDateTime(dueObj)
        End If
        'Category
        cbExpensesCategory.SelectedItem = row.Cells("Category").Value.ToString()
        'Status
        cbPaymentStatus.SelectedItem = row.Cells("Status").Value.ToString()
    End Sub

    ' Export expenses to CSV (Document Comma Separated Values) file
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        ' Prompt user for save location
        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.FileName = "Expenses_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                Using writer As New IO.StreamWriter(sfd.FileName)
                    Dim table As New DataTable()

                    ' 1️ Decide what data to export
                    If chkExportAll.Checked Then
                        ' Fetch all expenses from DB
                        Using con As New SqlConnection(connectAs)
                            con.Open()
                            Dim query As String = "
                            SELECT ExpenseID, Date, Description, Amount, AddedBy, DueDate, Status, PaidDate, Category
                            FROM Expenses
                            ORDER BY Date DESC"
                            Dim adapter As New SqlDataAdapter(query, con)
                            adapter.Fill(table)
                        End Using
                    Else
                        ' Export only the current DataGridView content
                        table = CType(dgvExpenses.DataSource, DataTable).Copy()
                    End If

                    ' 2️ Write header row
                    Dim headers As New List(Of String)
                    For Each col As DataColumn In table.Columns
                        headers.Add(col.ColumnName)
                    Next
                    writer.WriteLine(String.Join(",", headers))

                    ' 3️ Write data rows
                    Dim totalAmount As Decimal = 0D
                    For Each row As DataRow In table.Rows
                        Dim cells As New List(Of String)
                        For Each col As DataColumn In table.Columns
                            Dim value = row(col)
                            Dim cellText = If(value Is Nothing OrElse IsDBNull(value), "", value.ToString())
                            ' Escape quotes and commas
                            cellText = cellText.Replace("""", """""")
                            If cellText.Contains(",") Or cellText.Contains("""") Then
                                cellText = $"""{cellText}"""
                            End If
                            cells.Add(cellText)
                        Next
                        ' Sum total amount for "Amount" column
                        If table.Columns.Contains("Amount") Then
                            totalAmount += If(IsDBNull(row("Amount")), 0D, Convert.ToDecimal(row("Amount")))
                        End If
                        writer.WriteLine(String.Join(",", cells))
                    Next

                    ' 4️ Add totals row
                    If table.Columns.Contains("Amount") Then
                        Dim totalRow As New List(Of String)
                        For Each col As DataColumn In table.Columns
                            If col.ColumnName = "Amount" Then
                                totalRow.Add(totalAmount.ToString("₱#,##0.00"))
                            Else
                                totalRow.Add("") ' leave other columns empty
                            End If
                        Next
                        writer.WriteLine(String.Join(",", totalRow))
                    End If
                End Using

                MessageBox.Show("Expenses exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error exporting CSV: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        ResetFilters()
    End Sub

    Private Sub btnApplyFilters_Click(sender As Object, e As EventArgs) Handles btnApplyFilters.Click
        ApplyFilters()
    End Sub


End Class
