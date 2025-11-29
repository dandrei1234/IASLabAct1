Public Class BackupRestoreTestForm
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        DatabaseRecovery.BackupDatabase()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        DatabaseRecovery.RestoreDatabase()
    End Sub
End Class