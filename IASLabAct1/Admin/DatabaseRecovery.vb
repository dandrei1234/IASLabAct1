Imports MySql.Data.MySqlClient

Public Class DatabaseRecovery

    Private Shared Function GetMysqlsdumpLocation() As String
        Return "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"
    End Function

    Private Shared Function GetDatabaseName() As String
        Return "user_authentication_db"
    End Function

    Public Shared Sub RestoreDatabase()
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "SQL Files (*.sql)|*.sql"
        ofd.Title = "Select SQL Backup File"

        If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

        Dim sqlFile As String = ofd.FileName

        Dim script As String = IO.File.ReadAllText(sqlFile)

        Dim commands() As String = script.Split(New String() {";"}, StringSplitOptions.RemoveEmptyEntries)

        Dim connString As String = "server=localhost; userid=root; password=root; database=" & GetDatabaseName() & ";"
        Using conn As New MySqlConnection(connString)
            conn.Open()

            For Each cmdText As String In commands
                Dim cleanCmd As String = cmdText.Trim()

                If cleanCmd <> "" Then
                    Using cmd As New MySqlCommand(cleanCmd, conn)
                        Try
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("Error running command: " & cleanCmd & vbCrLf & ex.Message)
                        End Try
                    End Using
                End If
            Next

            conn.Close()
        End Using

        MessageBox.Show("Database restored successfully from: " & sqlFile)
    End Sub

    Public Shared Sub BackupDatabase()

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "SQL Files (*.sql)|*.sql"
        sfd.Title = "Save MySQL Backup"
        sfd.FileName = $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql"

        If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

        Dim backupFile As String = sfd.FileName

        Dim arguments As String =
        "--user=root --password=root --databases " & GetDatabaseName() & " --result-file=""" & backupFile & """"

        MessageBox.Show("Backup saved to: " & backupFile)
        Try
            Dim p As New Process()
            p.StartInfo.FileName = GetMysqlsdumpLocation()
            p.StartInfo.Arguments = arguments
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = True

            p.Start()
            p.WaitForExit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class