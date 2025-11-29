Imports MySql.Data.MySqlClient

Public Class UpdateProductForm
    Private original_pName
    Private original_price
    Private original_quantity

    Public Sub New(productName As String, price As String, quantity As Integer)
        InitializeComponent()
        original_pName = productName
        original_price = price
        original_quantity = quantity
        FillFields(productName, price, quantity)
    End Sub

    Private Sub FillFields(productName As String, price As String, quantity As Integer)
        txtpName.Text = productName
        txtPrice.Text = price
        txtQuantity.Text = quantity
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Inventory_Form.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtpName.Text.Trim().Any(Function(c) Char.IsDigit(c)) Or
            txtpName.Text.Trim() = "" Then
            MessageBox.Show("The Product Name must not be empty, or must only contain letters. Please fix the name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpName.Focus()
            Exit Sub
        End If

        Dim priceValue As Decimal
        If Not Decimal.TryParse(txtPrice.Text, priceValue) OrElse priceValue < 0 Then
            MessageBox.Show("The Product Price must be a number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Exit Sub
        End If
        Dim quantityValue As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantityValue) OrElse quantityValue < 0 Then
            MessageBox.Show("The Quantity must be a whole number.No letters and cannot be a negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Exit Sub
        End If


        Using conn = Connection.Create()
            Dim query As String = "UPDATE products_tbl SET productname=@productname, productprice=@productprice, quantity=@quantity WHERE productname=@original_name"
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@original_name", original_pName)
                    cmd.Parameters.AddWithValue("@productname", txtpName.Text.Trim())
                    cmd.Parameters.AddWithValue("@productprice", priceValue)
                    cmd.Parameters.AddWithValue("@quantity", quantityValue)

                    cmd.ExecuteNonQuery()
                End Using


                AuditLogging.AddEntry("Stock modified", "Previous Stock Values (" & Environment.NewLine &
                original_pName & ", " & Environment.NewLine & "Price: " & original_price & ", " & Environment.NewLine & "Quantity: " & original_quantity & ")" & Environment.NewLine &
                "Current Stock Values (" & Environment.NewLine &
                txtpName.Text.Trim() & ", " & Environment.NewLine & "Price: " & txtPrice.Text & ", " & Environment.NewLine & "Quantity: " & txtQuantity.Text & ")")

                MessageBox.Show("Updated Successfuly.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("We had trouble saving the changes. Please try again or check your database connection. Error details: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub UpdateProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub
End Class