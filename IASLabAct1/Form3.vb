Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub btnBacktoLogin_Click(sender As Object, e As EventArgs) Handles btnBacktoLogin.Click
        Me.Hide()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        Form1.Show()
    End Sub
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
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password do not match.")
            Exit Sub
        End If
        If txtPassword.Text.Length < 8 Then
            MsgBox("Password must be at least 8 characters long.")
            Exit Sub
        End If
        Try
            Dim lowercase As Integer = 0
            Dim uppercase As Integer = 0
            Dim numeric As Integer = 0
            Dim special As Integer = 0

            For i As Integer = 0 To txtPassword.Text.Length - 1
                If Char.IsLower(txtPassword.Text(i)) Then
                    lowercase += 1
                ElseIf Char.IsUpper(txtPassword.Text(i)) Then
                    uppercase += 1
                ElseIf Char.IsNumber(txtPassword.Text(i)) Then
                    numeric += 1
                Else
                    special += 1
                End If
            Next

            If lowercase = 0 Then
                MessageBox.Show("Must contain at least 1 Lowercase Character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf uppercase = 0 Then
                MessageBox.Show("Must contain at least 1 Uppercase Character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf numeric = 0 Then
                MessageBox.Show("Must contain at least 1 Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf special = 0 Then
                MessageBox.Show("Must contain at least 1 Special Character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim query As String = "INSERT INTO users_tbl(username, password) VALUES (@username, @password)"
                Dim hashedPassword As String = ComputeSHA256Hash(txtPassword.Text)
                Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@password", hashedPassword)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        Form1.Show()
                    End Using
                End Using
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Username already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
End Class