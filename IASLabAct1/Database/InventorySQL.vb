Imports MySql.Data.MySqlClient

Public Class InventorySQL
    Private Shared conn As MySqlConnection
    Private Shared cmd As MySqlCommand

    Private Shared productID, quantity As Integer
    Private Shared productName As String

    Private Sub Open()
    End Sub

    Private Shared Sub ExecuteCommand(query As String)
        conn = Database.GetConnection()
        conn.Open()
        Try
            conn = Database.GetConnection()
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

    Public Shared Sub GetStocksDGV(dgv As DataGridView)
        Database.InsertToDGV(dgv, "CALL ReadStocks();")
    End Sub

    Public Shared Function GetProductNames() As List(Of (Id As Integer, Name As String))
        Dim list As New List(Of (Id As Integer, Name As String))
        Using conn = Database.GetConnection()
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
            Using conn = Database.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("CALL AddStock(@productID, @quantity);", conn)
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