Imports MySql.Data.MySqlClient

Public Class AuditLogs
    Private Sub AuditLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserActivityMonitor.ResetTimer()
        LoadAuditLogs()
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub

    Private Sub LoadAuditLogs()
        UserActivityMonitor.ResetTimer()
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
        UserActivityMonitor.ResetTimer()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        UserActivityMonitor.ResetTimer()
        Me.Close()
        Form2.Show()
        ResetTimer()
        UserActivityMonitor.ResetTimer()
    End Sub
End Class