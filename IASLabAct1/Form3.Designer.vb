<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label4 = New Label()
        txtConfirmPassword = New TextBox()
        btnCreateUser = New Button()
        btnBacktoLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(130, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(130, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(237, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 2
        Label3.Text = "Register Form"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(261, 98)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(168, 23)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(261, 153)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(168, 23)
        txtPassword.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(130, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 5
        Label4.Text = "Confirm Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(261, 207)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(168, 23)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' btnCreateUser
        ' 
        btnCreateUser.Location = New Point(145, 276)
        btnCreateUser.Name = "btnCreateUser"
        btnCreateUser.Size = New Size(116, 23)
        btnCreateUser.TabIndex = 7
        btnCreateUser.Text = "Create User"
        btnCreateUser.UseVisualStyleBackColor = True
        ' 
        ' btnBacktoLogin
        ' 
        btnBacktoLogin.Location = New Point(313, 276)
        btnBacktoLogin.Name = "btnBacktoLogin"
        btnBacktoLogin.Size = New Size(116, 23)
        btnBacktoLogin.TabIndex = 8
        btnBacktoLogin.Text = "Back to Login"
        btnBacktoLogin.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 431)
        Controls.Add(btnBacktoLogin)
        Controls.Add(btnCreateUser)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnBacktoLogin As Button
End Class
