Imports MySql.Data.MySqlClient

Public Class Database

    Public Shared Inventory As InventorySQL = New InventorySQL()

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
    End Function

    Public Shared Sub InsertToDGV(dgv As DataGridView, query As String)
        'Dim query As String = "SELECT id, username, password, status, role FROM users_tbl"
        Try
            Using conn = GetConnection()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()

                dgv.DataSource = Nothing
                dgv.Rows.Clear()

                adapter.Fill(table)
                dgv.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
