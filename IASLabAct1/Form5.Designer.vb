<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        btnBacktoLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(123, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 29)
        Label1.TabIndex = 0
        Label1.Text = "Your Account is still Pending..."
        ' 
        ' btnBacktoLogin
        ' 
        btnBacktoLogin.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBacktoLogin.Location = New Point(221, 151)
        btnBacktoLogin.Name = "btnBacktoLogin"
        btnBacktoLogin.Size = New Size(141, 23)
        btnBacktoLogin.TabIndex = 1
        btnBacktoLogin.Text = "Back to Login"
        btnBacktoLogin.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(619, 399)
        Controls.Add(btnBacktoLogin)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBacktoLogin As Button
End Class
