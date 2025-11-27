Imports Microsoft.Data.SqlClient

Public Class ViewTransactionsControl

    Private adapter As SqlDataAdapter
    Private dt As New DataTable()

    Public Sub InitializeTransactions()
        LoadTransactions()
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

    ' ================================================================
    ' STYLE FOR ITEM GRID (called after DataSource is assigned)
    ' ================================================================
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

    ' ================================================================
    ' LOAD MAIN TRANSACTION LIST
    ' ================================================================
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

    ' ================================================================
    ' STYLE & FORMAT MAIN GRID
    ' ================================================================
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

    ' ================================================================
    ' FORM LOAD
    ' ================================================================
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

    ' ================================================================
    ' EVENTS
    ' ================================================================
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

End Class
