Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form4
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
    Private Function CheckPasswordStrength(password As String) As String
        If password.Length < 8 Then
            Return "Weak"
        End If
        Dim hasNumber As Boolean = False
        Dim hasSpecial As Boolean = False
        For Each ch As Char In password
            If Char.IsDigit(ch) Then
                hasNumber = True
            ElseIf Not Char.IsLetterOrDigit(ch) Then
                hasSpecial = True
            End If
        Next
        If hasNumber AndAlso hasSpecial Then
            Return "Strong"
        Else
            Return "Medium"
        End If
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
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
                Dim query As String = "INSERT INTO users_tbl (username, password, status, role) VALUES (@username, @password, @status, @role)"
                Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text))
                        cmd.Parameters.AddWithValue("@status", cbStatus.Text)
                        cmd.Parameters.AddWithValue("@role", cbRole.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("User Created Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsername.Clear()
                        txtPassword.Clear()
                        cbStatus.ResetText()
                        cbRole.ResetText()
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