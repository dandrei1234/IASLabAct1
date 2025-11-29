Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class AddStockForm
    Dim conn As MySqlConnection = Connection.Create()
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        UserActivityMonitor.ResetTimer()
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

            Using conn As MySqlConnection = Connection.Create()
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
                    AuditLogging.AddEntry("Stock added", "Stock modified: " & cmbFood.Text & ", " & Environment.NewLine & "Added value: " & txtQuantity.Text & ", " & Environment.NewLine & "Current Total stocks " & newQty)
                End Using
            End Using

            MessageBox.Show("Stock Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            cmbFood.SelectedIndex = -1
            txtQuantity.Clear()
            UserActivityMonitor.ResetTimer()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ResetTimer()
        Me.Close()
        Inventory_Form.LoadProducts()
        Inventory_Form.Show()
    End Sub

    Private Sub CreateDefaultFood(noItems As Boolean)
        If noItems Then
            Using conn As MySqlConnection = Connection.Create()
                conn.Open()

                Dim query = "INSERT INTO products_tbl (productname, productPrice, quantity) VALUES" &
                     "('Ground Beef', 30, 20)," &
                     "('Bread Buns', 10, 70)," &
                     "('Cheddar Slices', 10, 50)," &
                     "('Tomato', 8, 22);"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
        FillFoodComboBox()
    End Sub

    Private Sub FillFoodComboBox()
        Dim noItems As Boolean = True

        Using conn As MySqlConnection = Connection.Create()
            conn.Open()

            Dim query As String = "Select productname FROM products_tbl WHERE is_deleted=0"
            If LoggedRole = "admin" Then
                query = "SELECT productname FROM products_tbl"
            End If


            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim item As String

                cmbFood.Items.Clear()

                If reader.HasRows Then
                    noItems = False

                    While reader.Read()
                        item = reader.GetString("productname")
                        cmbFood.Items.Add(item)
                    End While
                Else
                    CreateDefaultFood(noItems)
                End If
            End Using
        End Using
    End Sub

    Private Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillFoodComboBox()
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub
End Class