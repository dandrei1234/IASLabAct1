Imports MySql.Data.MySqlClient

Public Class FormInserter

    Private Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
    End Function

    Public Shared Sub InsertPanel(form As Form, panel As Panel)
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        form.TopLevel = False
        panel.Controls.Clear()
        panel.Controls.Add(form)
        form.Show()
    End Sub

    Public Shared Sub InsertToDGV(dgv As DataGridView, query As String)
        'Dim query As String = "SELECT id, username, password, status, role FROM users_tbl"
        Try
            Using conn = GetConnection()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgv.DataSource = table

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub GetStocksDGV(dgv As DataGridView)
        InsertToDGV(dgv, "CALL ReadStocks();")
    End Sub
End Class