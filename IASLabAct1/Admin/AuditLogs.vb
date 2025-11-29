Imports MySql.Data.MySqlClient

Public Class AuditLogs
    Private Sub AuditLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserActivityMonitor.ResetTimer()
        LoadAuditLogs()
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub

    Private Sub LoadAuditLogs()
        Try
            Using conn As MySqlConnection = Connection.Create()
                conn.Open()

                Dim adapter As New MySqlDataAdapter("SELECT * FROM audit_trail_tbl", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvAuditLogs.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form2.Show()
        ResetTimer()
    End Sub
End Class