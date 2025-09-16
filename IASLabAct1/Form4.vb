Imports System.Security.Cryptography
Imports System.Text
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

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT username, password, status, role FROM users_tbl"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvacc.DataSource = table

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If
        If CheckPasswordStrength(txtPassword.Text) <> "Strong" Then
            MessageBox.Show("Password must be strong before updating. At least 8 characters with a number and a special character.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim hashedPass As String = ComputeSHA256Hash(txtPassword.Text)
        Dim query = "UPDATE users_tbl SET username=@username, password=@password, status=@status, role=@role WHERE id=@id"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", hashedPass)
                    cmd.Parameters.AddWithValue("@status", cbStatus.Text)
                    cmd.Parameters.AddWithValue("@role", cbRole.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class