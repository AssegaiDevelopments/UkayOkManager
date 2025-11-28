Imports Microsoft.Data.SqlClient

Public Class ViewTransactionsControl

    Private adapter As SqlDataAdapter
    Private dt As New DataTable()

    Public Sub InitializeTransactions()
        LoadTransactions()
        btnResetFilters.PerformClick()
    End Sub

    ' ================================================================
    ' SHOW DETAILS OF SELECTED TRANSACTION
    ' ================================================================
    Private Sub ShowTransactionDetails(transactionID As Integer)
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                ' ----------------------------------------------------------
                ' Load transaction info
                ' ----------------------------------------------------------
                Using cmd As New SqlCommand("
                    SELECT TransactionID, Username, TotalAmount, TransactionDate,
                           PaymentMethod, Status, TransactionType, Remarks
                    FROM Transactions
                    WHERE TransactionID = @id", con)

                    cmd.Parameters.AddWithValue("@id", transactionID)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblTransactionID.Text = reader("TransactionID").ToString()
                            lblUsername.Text = reader("Username").ToString()
                            lblTotalAmount.Text = "₱" & Convert.ToDecimal(reader("TotalAmount")).ToString("#,##0.00")
                            lblTransactionDate.Text = Convert.ToDateTime(reader("TransactionDate")).ToString("yyyy-MM-dd HH:mm:ss")
                            lblPaymentMethod.Text = reader("PaymentMethod").ToString()
                            lblStatus.Text = reader("Status").ToString()
                            lblTransactionType.Text = reader("TransactionType").ToString()

                            lblRemarks.Text =
                                If(reader.IsDBNull(reader.GetOrdinal("Remarks")),
                                   "No remarks.",
                                   reader("Remarks").ToString())
                        End If
                    End Using
                End Using

                ' ----------------------------------------------------------
                ' Load item details for the transaction
                ' ----------------------------------------------------------
                Dim itemTable As New DataTable()
                Using itemAdapter As New SqlDataAdapter("
                    SELECT ProductName, Quantity, Price, Total
                    FROM TransactionItems
                    WHERE TransactionID = @id", con)

                    itemAdapter.SelectCommand.Parameters.AddWithValue("@id", transactionID)
                    itemAdapter.Fill(itemTable)
                End Using

                dgvTransactionItems.DataSource = itemTable
                dgvTransactionItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ApplyItemGridStyle()

            End Using

            pnlDetails.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading transaction details: " & ex.Message)
        End Try
    End Sub

    ' STYLE FOR ITEM GRID (called after DataSource is assigned)

    Private Sub ApplyItemGridStyle()
        With dgvTransactionItems
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.5)
            .DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black

            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        End With
    End Sub

    ' LOAD MAIN TRANSACTION LIST
    Private Sub LoadTransactions()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                adapter = New SqlDataAdapter("
                    SELECT *
                    FROM Transactions
                    ORDER BY TransactionDate DESC", con)

                dt.Clear()
                adapter.Fill(dt)
                dgvTransactions.DataSource = dt
            End Using

            FormatTransactionGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        End Try
    End Sub

    Private Sub ApplyFilters()
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub

        'store filters in list
        Dim filters As New List(Of String)

        ' --- Username ---
        If Not String.IsNullOrWhiteSpace(txtSearchUser.Text) Then
            filters.Add($"Username LIKE '%{txtSearchUser.Text.Replace("'", "''")}%'")
        End If

        ' --- Amount Min/Max ---  
        Dim minVal As Decimal = nudMinAmount.Value
        Dim maxVal As Decimal = nudMaxAmount.Value

        ' Only apply range filters IF at least one value is non-zero  
        If Not (minVal = 0 AndAlso maxVal = 0) Then

            ' Min only  
            If minVal > 0 AndAlso maxVal = 0 Then
                filters.Add($"TotalAmount >= {minVal}")
            End If

            ' Max only  
            If maxVal > 0 AndAlso minVal = 0 Then
                filters.Add($"TotalAmount <= {maxVal}")
            End If

            ' Both min and max → range filter  
            If minVal > 0 AndAlso maxVal > 0 Then
                filters.Add($"TotalAmount >= {minVal} AND TotalAmount <= {maxVal}")
            End If
        End If


        ' --- Date From ---
        If chkDateFrom.Checked Then
            filters.Add($"TransactionDate >= '#{dtpFromDate.Value:yyyy-MM-dd HH:mm:ss}#'")
        End If

        ' --- Date To ---
        If chkDateTo.Checked Then
            filters.Add($"TransactionDate <= '#{dtpToDate.Value:yyyy-MM-dd HH:mm:ss}#'")
        End If

        ' --- Status ---
        If cmbStatus.SelectedIndex > 0 Then
            filters.Add($"Status = '{cmbStatus.SelectedItem.ToString().Replace("'", "''")}'")
        End If

        ' --- Payment Method ---
        If cmbPaymentMethod.SelectedIndex > 0 Then
            filters.Add($"PaymentMethod = '{cmbPaymentMethod.SelectedItem.ToString().Replace("'", "''")}'")
        End If

        ' Combine all conditions
        Dim finalFilter As String = String.Join(" AND ", filters)

        Dim dv As New DataView(dt)
        dv.RowFilter = finalFilter

        dgvTransactions.DataSource = dv
    End Sub


    ' STYLE & FORMAT MAIN GRID

    Private Sub FormatTransactionGrid()
        With dgvTransactions
            If .Columns.Contains("TransactionID") Then .Columns("TransactionID").Visible = False
            If .Columns.Contains("Username") Then .Columns("Username").HeaderText = "User"

            If .Columns.Contains("TotalAmount") Then
                .Columns("TotalAmount").HeaderText = "Total Amount"
                .Columns("TotalAmount").DefaultCellStyle.Format = "₱#,##0.00"
            End If

            If .Columns.Contains("TransactionDate") Then
                .Columns("TransactionDate").HeaderText = "Date"
                .Columns("TransactionDate").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
            End If

            If .Columns.Contains("PaymentMethod") Then .Columns("PaymentMethod").HeaderText = "Payment"
            If .Columns.Contains("Status") Then .Columns("Status").HeaderText = "Status"

            If .Columns.Contains("DateCreated") Then
                .Columns("DateCreated").HeaderText = "Created On"
                .Columns("DateCreated").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
            End If

            If .Columns.Contains("Remarks") Then .Columns("Remarks").HeaderText = "Remarks"
            If .Columns.Contains("TransactionType") Then .Columns("TransactionType").HeaderText = "Type"
        End With
    End Sub

    ' FORM LOAD

    Private Sub ViewTransactions_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Main transactions grid
        With dgvTransactions
            .Dock = DockStyle.Fill
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.5)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With

        pnlDetails.Dock = DockStyle.Bottom
        pnlDetails.Visible = False

        LoadTransactions()
    End Sub

    ' events
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactions()
    End Sub

    Private Sub dgvTransactions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvTransactions.CellDoubleClick

        If e.RowIndex >= 0 Then
            Dim id As Integer = dgvTransactions.Rows(e.RowIndex).Cells("TransactionID").Value
            ShowTransactionDetails(id)
        End If
    End Sub

    Private Sub btnCloseDetails_Click(sender As Object, e As EventArgs) Handles btnCloseDetails.Click
        pnlDetails.Visible = False
    End Sub

    Private Sub btnApplyFilters_Click(sender As Object, e As EventArgs) Handles btnApplyFilters.Click
        ApplyFilters()
    End Sub

    Private Sub btnResetFilters_Click(sender As Object, e As EventArgs) Handles btnResetFilters.Click
        txtSearchUser.Clear()
        nudMinAmount.Value = 0
        nudMaxAmount.Value = 0
        chkDateFrom.Checked = False
        chkDateTo.Checked = False
        cmbStatus.SelectedIndex = 0
        cmbPaymentMethod.SelectedIndex = 0

        dgvTransactions.DataSource = dt
    End Sub

    Private Sub dgvTransactions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTransactions.CellFormatting
        ' Identify which columns contain currency values
        If dgvTransactions.Columns(e.ColumnIndex).Name = "Amount" OrElse
           dgvTransactions.Columns(e.ColumnIndex).Name = "Price" OrElse
           dgvTransactions.Columns(e.ColumnIndex).Name = "TotalAmount" Then

            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                e.Value = AppHelpers.FormatCurrency(Convert.ToDecimal(e.Value))
                e.FormattingApplied = True
            End If

        End If
    End Sub
End Class
