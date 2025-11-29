
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Dim conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
    Public Function ComputeSHA256Hash(ByVal rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF32.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        LogoutTimeTestForm.Show()

        Dim query As String = "SELECT * FROM users_tbl WHERE username=@username AND password=@password"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text))

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim Id = reader.GetInt32("id")
                Dim username = reader.GetString("username")
                Dim Status = reader.GetString("status")
                Dim role = reader.GetString("role")
                SetLoggedUser(Id, username, role, Status)

                If Status = "authorized" Then
                    AuditLogging.AddEntry(Id, username, role, "User logged in", "Authorized Account")
                    Select Case role
                        Case "admin"
                            MessageBox.Show("Login successful.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Form2.Show()
                            Me.Hide()
                        Case "staff"
                            MessageBox.Show("Login successful. Your account is Authorized.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Inventory_Form.Show()
                            Me.Hide()
                    End Select
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                ElseIf Status = "pending" Then
                    Form5.Show()
                    AuditLogging.AddEntry(Id, username, role, "User logged in", "Pending Account")
                    Me.Hide()
                ElseIf Status = "unauthorized" Then
                    AuditLogging.AddEntry(Id, username, role, "User logged in", "Unauthorized Account")
                    MessageBox.Show("Your account is Denied. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                LoggedStatus = 0
            Else
                LoggedStatus += 1
                AuditLogging.AddEntry(0, "", "staff", "Failed logged in attempt", "Attempted username: " & txtUsername.Text)
                If LoggedStatus >= 3 Then
                    AuditLogging.AddEntry(0, "", "staff", "Failed logged in attempt exceeded", "Attempted username: " & txtUsername.Text)
                    MessageBox.Show("Too many incorrect attempts. The app will now close.", "Un-Authorize User!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Application.Exit()
                Else
                    MessageBox.Show($"Username or password is incorrect.{Environment.NewLine}Attempts left: {3 - LoggedStatus}", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State() = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub lblpassword_Click(sender As Object, e As EventArgs) Handles txtPassword.KeyDown
        If Control.IsKeyLocked(Keys.CapsLock) Then
            lblpassword.Text = "Caps Lock is ON"
            lblpassword.ForeColor = Color.Red
        Else
            lblpassword.Text = ""
        End If
    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.KeyDown
        If Control.IsKeyLocked(Keys.CapsLock) Then
            lbluser.Text = "Caps Lock is ON"
            lbluser.ForeColor = Color.Red
        Else
            lbluser.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbpass.CheckedChanged
        If cbpass.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLoginForm(Me)

        txtPassword.UseSystemPasswordChar = True
        cbpass.Checked = False
        StopTimer()
    End Sub
End Class
