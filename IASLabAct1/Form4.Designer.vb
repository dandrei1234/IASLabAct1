<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnCreate = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cbStatus = New ComboBox()
        cbRole = New ComboBox()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(117, 264)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(106, 23)
        btnCreate.TabIndex = 10
        btnCreate.Text = "Create User"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 3
        Label4.Text = "Status:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 4
        Label5.Text = "Role:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(137, 79)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(137, 23)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(137, 117)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(137, 23)
        txtPassword.TabIndex = 7
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"pending", "authorized", "unauthorized"})
        cbStatus.Location = New Point(137, 156)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(137, 23)
        cbStatus.TabIndex = 8
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"staff", "admin"})
        cbRole.Location = New Point(137, 194)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(137, 23)
        cbRole.TabIndex = 9
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(245, 24)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 15
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 366)
        Controls.Add(btnBack)
        Controls.Add(btnCreate)
        Controls.Add(cbRole)
        Controls.Add(cbStatus)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnBack As Button
End Class
