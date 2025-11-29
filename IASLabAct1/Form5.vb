Public Class Form5
    Private Sub btnBacktoLogin_Click(sender As Object, e As EventArgs) Handles btnBacktoLogin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub
End Class