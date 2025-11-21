<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Form
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
        panel = New Panel()
        btnAddStock = New Button()
        btnDelete = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' panel
        ' 
        panel.Location = New Point(12, 12)
        panel.Name = "panel"
        panel.Size = New Size(776, 351)
        panel.TabIndex = 0
        ' 
        ' btnAddStock
        ' 
        btnAddStock.Location = New Point(59, 369)
        btnAddStock.Name = "btnAddStock"
        btnAddStock.Size = New Size(75, 23)
        btnAddStock.TabIndex = 1
        btnAddStock.Text = "Add Stock"
        btnAddStock.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(166, 369)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Inventory_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnAddStock)
        Controls.Add(panel)
        Name = "Inventory_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory_Form"
        ResumeLayout(False)
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents panel As Panel
    Friend WithEvents btnAddStock As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
