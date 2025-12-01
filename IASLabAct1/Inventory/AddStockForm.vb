Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class AddStockForm
    Dim conn As MySqlConnection = Connection.Create()
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        UserActivityMonitor.ResetTimer()

        UserActivityMonitor.ResetTimer()

        If cmbFood.Text.Trim() = "" Then
            MessageBox.Show("Enter product name.")
            Exit Sub
        End If

        Dim price As Decimal = 0D
        Dim qty As Integer

        If LoggedRole = "admin" Then
            If Not Decimal.TryParse(txtPrice.Text, price) OrElse price < 0 Then
                MessageBox.Show("Enter valid price.")
                Exit Sub
            End If
        End If

        If Not Integer.TryParse(txtQuantity.Text, qty) OrElse qty < 0 Then
            MessageBox.Show("Enter valid quantity.")
            Exit Sub
        End If

        Using conn As MySqlConnection = Connection.Create()
            conn.Open()

            Dim sql As String
            If LoggedRole = "admin" Then
                sql = "INSERT INTO products_tbl (productname, productPrice, quantity) " &
                  "VALUES (@name, @price, @qty);"
            Else
                sql = "INSERT INTO products_tbl (productname, productPrice, quantity) " &
                  "VALUES (@name, 0, @qty);"
            End If

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", cmbFood.Text.Trim())
                cmd.Parameters.AddWithValue("@qty", qty)
                If LoggedRole = "admin" Then
                    cmd.Parameters.AddWithValue("@price", price)
                End If

                cmd.ExecuteNonQuery()

                AuditLogging.AddEntry(
                "Stock added",
                "User role: " & LoggedRole & Environment.NewLine &
                "Stock modified: " & cmbFood.Text & Environment.NewLine &
                "Added value: " & qty.ToString() & Environment.NewLine &
                "Current Total stocks " & qty.ToString()
            )
            End Using
        End Using

        MessageBox.Show("Product added!")
        Inventory_Form.LoadProducts()
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

            Dim query As String = "Select productname FROM products_tbl"
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


        If LoggedRole = "staff" Then

            lblprice.Visible = False
            txtPrice.Visible = False
        Else
            lblprice.Visible = True
            txtPrice.Visible = True
        End If
    End Sub

End Class