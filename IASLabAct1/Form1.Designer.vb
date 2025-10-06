<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        btnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        lbluser = New Label()
        cbpass = New CheckBox()
        Label3 = New Label()
        Label4 = New Label()
        lblpassword = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(82, 215)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(97, 32)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(224, 215)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(97, 30)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(45, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(45, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 21)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(139, 116)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(163, 23)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(139, 171)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(163, 23)
        txtPassword.TabIndex = 1
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' lbluser
        ' 
        lbluser.AutoSize = True
        lbluser.Location = New Point(139, 98)
        lbluser.Name = "lbluser"
        lbluser.Size = New Size(0, 15)
        lbluser.TabIndex = 6
        ' 
        ' cbpass
        ' 
        cbpass.AutoSize = True
        cbpass.BackColor = Color.Transparent
        cbpass.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbpass.ForeColor = SystemColors.ControlLightLight
        cbpass.Location = New Point(308, 173)
        cbpass.Name = "cbpass"
        cbpass.Size = New Size(103, 19)
        cbpass.TabIndex = 8
        cbpass.Text = "Show Password"
        cbpass.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(139, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 9
        Label3.Text = "Login Here"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(97, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(215, 20)
        Label4.TabIndex = 10
        Label4.Text = "No account yet? Register Here."
        ' 
        ' lblpassword
        ' 
        lblpassword.AutoSize = True
        lblpassword.Location = New Point(139, 153)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(0, 15)
        lblpassword.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.blue_background_design_free_vector
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(424, 355)
        Controls.Add(lblpassword)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cbpass)
        Controls.Add(lbluser)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents lbluser As Label
    Friend WithEvents cbpass As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblpassword As Label

End Class
