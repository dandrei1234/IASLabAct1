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
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password do not match.")
            Exit Sub
        End If

        Dim hashedPassword As String = ComputeSHA256Hash(txtPassword.Text)
        Dim query As String = "INSERT INTO users_tbl(username, password) VALUES (@username, @password)"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User registered successfully!")
                    Me.Close()
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtConfirmPassword.Clear()
                    Form1.Show()

                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Username already exists.")
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
End Class