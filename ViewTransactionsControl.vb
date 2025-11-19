Imports Microsoft.Data.SqlClient
'Imports System.Data.SqlClient
Public Class ViewTransactionsControl
    Dim adapter As SqlDataAdapter
    Dim dt As New DataTable()

    Public Sub InitializeTransactions()
        LoadTransactions()
    End Sub

    Private Sub ShowTransactionDetails(transactionID As Integer)
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                ' --- Load transaction info ---
                Dim cmd As New SqlCommand("SELECT * FROM Transactions WHERE TransactionID = @id", con)
                cmd.Parameters.AddWithValue("@id", transactionID)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    lblTransactionID.Text = reader("TransactionID").ToString()
                    lblUsername.Text = reader("Username").ToString()
                    lblTotalAmount.Text = "₱" & Convert.ToDecimal(reader("TotalAmount")).ToString("#,##0.00")
                    lblTransactionDate.Text = Convert.ToDateTime(reader("TransactionDate")).ToString("yyyy-MM-dd HH:mm:ss")
                    lblPaymentMethod.Text = reader("PaymentMethod").ToString()
                    lblStatus.Text = reader("Status").ToString()
                    lblTransactionType.Text = reader("TransactionType").ToString()
                    If reader.IsDBNull(reader.GetOrdinal("Remarks")) Then
                        lblRemarks.Text = "No remarks."
                    Else
                        lblRemarks.Text = reader("Remarks").ToString()
                    End If
                End If
                reader.Close()

                ' --- Load items from TransactionItems table ---
                Dim itemAdapter As New SqlDataAdapter("SELECT ProductName, Quantity, Price, Total FROM TransactionItems WHERE TransactionID = @id", con)
                itemAdapter.SelectCommand.Parameters.AddWithValue("@id", transactionID)
                Dim itemTable As New DataTable()
                itemAdapter.Fill(itemTable)

                dgvTransactionItems.DataSource = itemTable
                dgvTransactionItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End Using

            pnlDetails.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading transaction details: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadTransactions()
        Try
            Using con As New SqlConnection(connectAs)
                con.Open()

                Dim query As String = "SELECT * FROM Transactions ORDER BY TransactionDate DESC"
                adapter = New SqlDataAdapter(query, con)
                dt.Clear()
                adapter.Fill(dt)
                dgvTransactions.DataSource = dt
            End Using

            ' --- Column formatting ---
            With dgvTransactions
                ' Hide internal ID
                If .Columns.Contains("TransactionID") Then
                    .Columns("TransactionID").Visible = False
                End If

                ' Rename headers
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

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        End Try
    End Sub

    Private Sub ViewTransactions_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvTransactions.Dock = DockStyle.Fill
        dgvTransactions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.ReadOnly = True
        dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        dgvTransactions.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvTransactions.DefaultCellStyle.Font = New Font("Segoe UI", 9.5)
        dgvTransactions.DefaultCellStyle.ForeColor = Color.Black
        dgvTransactions.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
        dgvTransactions.DefaultCellStyle.SelectionForeColor = Color.Black

        LoadTransactions()
        dgvTransactions.MinimumSize = New Size(600, 300)
        ' Optional: set minimum form size so content isn't too cramped

        pnlDetails.Visible = False
        pnlDetails.Dock = DockStyle.Bottom

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactions()
    End Sub

    Private Sub dgvTransactions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvTransactions.Rows(e.RowIndex)
            Dim transactionID As Integer = selectedRow.Cells("TransactionID").Value
            ShowTransactionDetails(transactionID)
        End If
    End Sub

    Private Sub btnCloseDetails_Click(sender As Object, e As EventArgs) Handles btnCloseDetails.Click
        pnlDetails.Visible = False
    End Sub
End Class
