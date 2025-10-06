Imports System.Text
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Imports System.Security.Cryptography

Public Class Form2
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
    Dim conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT id, username, password, status, role FROM users_tbl"

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
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub UserProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserProfileToolStripMenuItem.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE users_tbl SET username=@username, password=@password, status=@status, role=@role WHERE id=@id"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text))
                cmd.Parameters.AddWithValue("@status", cbStatus.Text)
                cmd.Parameters.AddWithValue("@role", cbRole.Text)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text))
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("User updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim query As String = "SELECT * FROM users_tbl"
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvacc.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query = "DELETE FROM users_tbl WHERE id=@id"
        Try
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text))
                Dim rowsAffected = cmd.ExecuteNonQuery
                If rowsAffected > 0 Then
                    MessageBox.Show("User removed successfully.")
                Else
                    MessageBox.Show("No user found with the specified ID.")
                End If
            End Using
            txtID.Clear()
            cbStatus.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtUsername.Text.Trim()

        If searchText = "" Then
            MessageBox.Show("Please enter a name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "SELECT id,username,role,status FROM users_tbl WHERE username LIKE @search"
        Try
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchText & "%")
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvacc.DataSource = table

            If table.Rows.Count = 0 Then
                MessageBox.Show("No users found with that name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            txtUsername.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvacc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvacc.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvacc.Rows(e.RowIndex)
            txtID.Text = row.Cells("id").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = row.Cells("password").Value.ToString()
            cbStatus.Text = row.Cells("status").Value.ToString()
            cbRole.Text = row.Cells("role").Value.ToString()
        End If
    End Sub

End Class