Imports MySql.Data.MySqlClient

Public Class Inventory_Form
    Private addStockForm As AddStockForm
    Private stockListForm As StockListForm

    Private Sub Inventory_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventoryList()
    End Sub

    Public Sub LoadInventoryList()
        btnAddStock.Visible = True

        stockListForm = New StockListForm
        FormInserter.InsertPanel(stockListForm, panel)
    End Sub

    Public Sub LoadAddStockForm()
        btnAddStock.Visible = False

        addStockForm = New AddStockForm()
        addStockForm.form = Me
        FormInserter.InsertPanel(addStockForm, panel)
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        LoadAddStockForm()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query = "DELETE FROM product_tbl WHERE id=@id"
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
End Class