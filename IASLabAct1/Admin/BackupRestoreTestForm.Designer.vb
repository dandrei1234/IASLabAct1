<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupRestoreTestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnBackup = New Button()
        btnRestore = New Button()
        SuspendLayout()
        ' 
        ' btnBackup
        ' 
        btnBackup.Location = New Point(442, 177)
        btnBackup.Name = "btnBackup"
        btnBackup.Size = New Size(75, 23)
        btnBackup.TabIndex = 0
        btnBackup.Text = "Backup"
        btnBackup.UseVisualStyleBackColor = True
        ' 
        ' btnRestore
        ' 
        btnRestore.Location = New Point(442, 232)
        btnRestore.Name = "btnRestore"
        btnRestore.Size = New Size(75, 23)
        btnRestore.TabIndex = 0
        btnRestore.Text = "Restore"
        btnRestore.UseVisualStyleBackColor = True
        ' 
        ' BackupRestoreTestForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRestore)
        Controls.Add(btnBackup)
        Name = "BackupRestoreTestForm"
        Text = "BackupRestoreTestForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBackup As Button
    Friend WithEvents btnRestore As Button
End Class
