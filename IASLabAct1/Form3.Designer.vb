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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label4 = New Label()
        txtConfirmPassword = New TextBox()
        btnRegister = New Button()
        btnBacktoLogin = New Button()
        cbpass = New CheckBox()
        Label2 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(84, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 19)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(138, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 25)
        Label3.TabIndex = 2
        Label3.Text = "Register Form"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(179, 88)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(168, 23)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(179, 134)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(168, 23)
        txtPassword.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(81, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 5
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(178, 179)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(168, 23)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(97, 234)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(116, 34)
        btnRegister.TabIndex = 7
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnBacktoLogin
        ' 
        btnBacktoLogin.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBacktoLogin.Location = New Point(264, 234)
        btnBacktoLogin.Name = "btnBacktoLogin"
        btnBacktoLogin.Size = New Size(116, 34)
        btnBacktoLogin.TabIndex = 8
        btnBacktoLogin.Text = "Back to Login"
        btnBacktoLogin.UseVisualStyleBackColor = True
        ' 
        ' cbpass
        ' 
        cbpass.AutoSize = True
        cbpass.BackColor = Color.Transparent
        cbpass.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbpass.ForeColor = SystemColors.Control
        cbpass.Location = New Point(353, 136)
        cbpass.Name = "cbpass"
        cbpass.Size = New Size(111, 19)
        cbpass.TabIndex = 9
        cbpass.Text = "Show Password"
        cbpass.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(84, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 19)
        Label2.TabIndex = 10
        Label2.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(47, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 19)
        Label5.TabIndex = 11
        Label5.Text = "Confirm Password:"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(475, 326)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(cbpass)
        Controls.Add(btnBacktoLogin)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBacktoLogin As Button
    Friend WithEvents cbpass As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
