Imports MySql.Data.MySqlClient

Public Class FormInserter
    Public Shared Inventory As InventorySQL = New InventorySQL()

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

    Public Class InventorySQL
        Private Shared conn As MySqlConnection
        Private Shared cmd As MySqlCommand

        Private Shared productID, quantity As Integer
        Private Shared productName As String

        Private Sub Open()
        End Sub

        Private Shared Sub ExecuteCommand(query As String)
            conn = GetConnection()
            conn.Open()
            Try
                conn = GetConnection()
                conn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Sub

        Public Shared Sub AddStock()
            ExecuteCommand("CALL AddStock(@productID, @quantity);")
            cmd.Parameters.AddWithValue("@productID", productID)
            cmd.Parameters.AddWithValue("@quantity", quantity)
            cmd.ExecuteNonQuery()
        End Sub
    End Class


    Public Shared Function GetProductNames() As List(Of (Id As Integer, Name As String))
        Dim list As New List(Of (Id As Integer, Name As String))
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand("CALL GetProductNames();", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim id = reader.GetInt32("productID")
                    Dim name = reader.GetString("productName")
                    list.Add((id, name))
                End While
            End Using
        End Using
        Return list
    End Function


    Public Shared Sub AddStock(productID As Integer, quantity As Integer)
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("AddStock(@productID, @quantity);", conn)
                    cmd.Parameters.AddWithValue("@productID", productID)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class