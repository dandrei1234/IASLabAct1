<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoutTimeTestForm
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
        lbl = New Label()
        SuspendLayout()
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(12, 9)
        lbl.Name = "lbl"
        lbl.Size = New Size(13, 15)
        lbl.TabIndex = 0
        lbl.Text = "4"
        ' 
        ' LogoutTimeTestForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 33)
        Controls.Add(lbl)
        Name = "LogoutTimeTestForm"
        Text = "LogoutTimeTestForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl As Label
End Class
