Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class AddStockForm
    Dim conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        Try
            If cmbFood.SelectedIndex = -1 Then
                MessageBox.Show("Please select a product.", "Error")
                Exit Sub
            End If

            Dim qtyToAdd As Integer
            If Not Integer.TryParse(txtQuantity.Text, qtyToAdd) OrElse qtyToAdd <= 0 Then
                MessageBox.Show("Please enter a valid quantity.", "Error")
                Exit Sub
            End If

            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=user_authentication_db;")
                conn.Open()
                Dim currentQty As Integer
                Dim getQtyQuery As String = "SELECT quantity FROM products_tbl WHERE productname = @name"

                Using cmdGet As New MySqlCommand(getQtyQuery, conn)
                    cmdGet.Parameters.AddWithValue("@name", cmbFood.Text)
                    Dim result = cmdGet.ExecuteScalar()
                    currentQty = Convert.ToInt32(result)
                End Using

                Dim newQty As Integer = currentQty + qtyToAdd

                Dim updateQuery As String = "UPDATE products_tbl SET quantity = @quantity WHERE productname = @name"

                Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                    cmdUpdate.Parameters.AddWithValue("@quantity", newQty)
                    cmdUpdate.Parameters.AddWithValue("@name", cmbFood.Text)
                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Stock Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            cmbFood.SelectedIndex = -1
            txtQuantity.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Inventory_Form.Show()
    End Sub
End Class