Imports MySql.Data.MySqlClient

Public Class Inventory_Form
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Close()
        AddStockForm.Show()
    End Sub

    Public Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        LoadProducts()
    End Sub
    Public Sub LoadProducts()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=user_authentication_db;")
                conn.Open()
                Dim query As String = "SELECT * FROM products_tbl"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvProducts.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class