Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Module BackupUtils

    ' Use your real connection string
    Public ConnectionString As String = DatabaseConnection.connectAs

    ' List of tables to include in backup
    Private Tables As String() = {
        "Users",
        "Products",
        "Transactions",
        "TransactionItems",
        "Expenses"
    }

    '====================================================================
    ' 1. MAIN BACKUP FUNCTION - CALL THIS FROM A BUTTON
    '====================================================================
    Public Sub RunFullBackup()
        Using dialog As New FolderBrowserDialog()
            dialog.Description = "Select a folder to save your backup files"

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim folder = Path.Combine(dialog.SelectedPath, "Backup_" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"))
                Directory.CreateDirectory(folder)

                BackupCsv(folder)
                BackupSql(Path.Combine(folder, "DatabaseBackup.sql"))

                MessageBox.Show("Backup complete successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub


    '====================================================================
    ' 2. CSV BACKUP
    '====================================================================
    Private Sub BackupCsv(outputFolder As String)
        For Each table In Tables
            Dim dt As New DataTable()

            Using con As New SqlConnection(ConnectionString)
                con.Open()
                Using cmd As New SqlCommand($"SELECT * FROM [{table}]", con)
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            Dim filePath = System.IO.Path.Combine(outputFolder, table & ".csv")
            WriteCsv(dt, filePath)
        Next
    End Sub

    Private Sub WriteCsv(dt As DataTable, filePath As String)
        Using writer As New StreamWriter(filePath, False, Encoding.UTF8)
            ' Header
            writer.WriteLine(String.Join(",", dt.Columns.Cast(Of DataColumn).Select(Function(c) EscapeCsv(c.ColumnName))))

            ' Rows
            For Each row As DataRow In dt.Rows
                Dim vals = row.ItemArray.Select(Function(v) EscapeCsv(v.ToString()))
                writer.WriteLine(String.Join(",", vals))
            Next
        End Using
    End Sub

    Private Function EscapeCsv(value As String) As String
        If value.Contains("""") Then value = value.Replace("""", """""")
        If value.Contains(",") OrElse value.Contains("""") OrElse value.Contains(vbLf) Then
            value = $"""{value}"""
        End If
        Return value
    End Function


    '====================================================================
    ' 3. SQL FULL EXPORT (SCHEMA + INSERTS)
    '====================================================================
    Private Sub BackupSql(outputPath As String)
        Dim sb As New StringBuilder()

        Using con As New SqlConnection(ConnectionString)
            con.Open()

            For Each table In Tables
                sb.AppendLine(GetCreateTableScript(con, table))
                sb.AppendLine()
                sb.AppendLine(GetInsertStatements(con, table))
                sb.AppendLine()
            Next
        End Using

        File.WriteAllText(outputPath, sb.ToString(), Encoding.UTF8)
    End Sub


    '====================================================================
    ' CREATE TABLE / SCHEMA GENERATOR
    '====================================================================
    Private Function GetCreateTableScript(con As SqlConnection, table As String) As String
        Dim sb As New StringBuilder()

        sb.AppendLine($"DROP TABLE IF EXISTS [{table}];")
        sb.AppendLine($"CREATE TABLE [{table}] (")

        Dim colCmd As New SqlCommand("
            SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE 
            FROM INFORMATION_SCHEMA.COLUMNS
            WHERE TABLE_NAME = @T
        ", con)

        colCmd.Parameters.AddWithValue("@T", table)

        Dim columnDefs As New List(Of String)

        Using r = colCmd.ExecuteReader()
            While r.Read()

                Dim colName = "[" & r("COLUMN_NAME") & "]"
                Dim dataType = r("DATA_TYPE").ToString()

                ' Handle variable-length types
                If dataType = "nvarchar" OrElse dataType = "varchar" Then
                    Dim len = If(IsDBNull(r("CHARACTER_MAXIMUM_LENGTH")), "MAX", r("CHARACTER_MAXIMUM_LENGTH").ToString())
                    dataType &= "(" & len & ")"
                End If

                Dim nullable = If(r("IS_NULLABLE").ToString() = "NO", "NOT NULL", "NULL")

                columnDefs.Add($"    {colName} {dataType} {nullable}")
            End While
        End Using

        sb.AppendLine(String.Join("," & vbCrLf, columnDefs))
        sb.AppendLine(");")

        Return sb.ToString()
    End Function


    '====================================================================
    ' INSERT STATEMENT GENERATOR
    '====================================================================
    Private Function GetInsertStatements(con As SqlConnection, table As String) As String
        Dim sb As New StringBuilder()

        Dim dt As New DataTable()
        Using cmd As New SqlCommand($"SELECT * FROM [{table}]", con)
            dt.Load(cmd.ExecuteReader())
        End Using

        If dt.Rows.Count = 0 Then
            Return $"-- No data in table {table}"
        End If

        For Each row As DataRow In dt.Rows
            Dim cols = String.Join(",", dt.Columns.Cast(Of DataColumn).Select(Function(c) "[" & c.ColumnName & "]"))
            Dim vals = String.Join(",", row.ItemArray.Select(Function(v) SqlValue(v)))

            sb.AppendLine($"INSERT INTO [{table}] ({cols}) VALUES ({vals});")
        Next

        Return sb.ToString()
    End Function

    Private Function SqlValue(v As Object) As String
        If v Is DBNull.Value Then Return "NULL"

        If TypeOf v Is String OrElse TypeOf v Is Date OrElse TypeOf v Is DateTime Then
            Return "'" & v.ToString().Replace("'", "''") & "'"
        End If

        Return v.ToString()
    End Function

End Module
