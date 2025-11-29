Public Class AuditLogs
    Private Sub AuditLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub
End Class