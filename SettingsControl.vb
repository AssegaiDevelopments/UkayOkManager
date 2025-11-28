Imports Microsoft.Data.SqlClient

Public Class SettingsControl
    ' Controls:
    ' ComboBox: cbCurrency
    ' Button: btnClearExpenses
    ' Button: btnClearTransactions

    Private Sub SettingsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub InitializeSettings()
        cbCurrency.Items.Clear()
        cbCurrency.Items.AddRange(New String() {"₱", "$", "¥", "€"})

        ' Set the saved currency
        cbCurrency.SelectedItem = AppSettings.CurrentCurrency
    End Sub



    Private Sub cbCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCurrency.SelectedIndexChanged
        If cbCurrency.SelectedIndex >= 0 Then
            AppSettings.CurrentCurrency = cbCurrency.SelectedItem.ToString()
            AppSettings.SaveSettings()
        End If
    End Sub

    Private Sub btnClearExpenses_Click(sender As Object, e As EventArgs) Handles btnClearExpenses.Click
        Dim result As DialogResult = MessageBox.Show(
       "WARNING: This will permanently delete ALL expense records from the database." &
       vbCrLf & vbCrLf &
       "This action cannot be undone." &
       vbCrLf & vbCrLf &
       "Are you absolutely sure you want to continue?",
       "Confirm Deletion",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   )

        If result = DialogResult.Yes Then
            Try
                Using con As New SqlConnection(connectAs)
                    con.Open()
                    Using cmd As New SqlCommand("DELETE FROM Expenses", con)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("All expenses have been deleted successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error deleting expenses: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnClearTransactions_Click(sender As Object, e As EventArgs) Handles btnClearTransactions.Click
        Dim result As DialogResult = MessageBox.Show(
        "WARNING: This will permanently delete ALL transactions AND their item records." &
        vbCrLf & vbCrLf &
        "This action is IRREVERSIBLE." &
        vbCrLf &
        "Reports, totals, transaction history, and analytics will be affected." &
        vbCrLf & vbCrLf &
        "Are you absolutely sure you want to proceed?",
        "Critical Warning",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )

        If result = DialogResult.Yes Then

            ' Second layer confirmation
            Dim result2 As DialogResult = MessageBox.Show(
            "FINAL CONFIRMATION:" &
            vbCrLf &
            "Delete ALL transactions permanently?",
            "Confirm Again",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Stop
        )

            If result2 = DialogResult.Yes Then

                Try
                    Using con As New SqlConnection(connectAs)
                        con.Open()

                        ' First remove related items
                        Using cmdDelItems As New SqlCommand("DELETE FROM TransactionItems", con)
                            cmdDelItems.ExecuteNonQuery()
                        End Using

                        ' Then remove main transactions
                        Using cmdDelTrans As New SqlCommand("DELETE FROM Transactions", con)
                            cmdDelTrans.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("All transactions and their items have been deleted.",
                                "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error deleting transactions: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub btnRunFullBackup_Click(sender As Object, e As EventArgs) Handles btnRunFullBackup.Click
        RunFullBackup()
    End Sub
End Class
