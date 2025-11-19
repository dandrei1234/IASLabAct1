Public Class AddStockForm
    Public form As Inventory_Form
    Private productIds = New List(Of Integer)

    Private Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim products As List(Of (Id As Integer, Name As String)) = FormInserter.GetProductNames()

        For Each product As (Id As Integer, Name As String) In products
            cmbProduct.Items.Add(product.Name)
            productIds.Add(product.Id)
        Next

        cmbProduct.SelectedIndex = 0
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        form.LoadInventoryList()
    End Sub

    Private Sub ValidateQuantity()
        If Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Quantity must be a valid number.", "Invalid Quantity")
            Exit Sub
        End If
        'For Each c As Char In txtQuantity.Text
        '    If Not IsNumeric(c) Then
        '        MessageBox.Show("Quantity must be a valid number.", "Invalid Quantity")
        '    End If
        'Next

    End Sub
End Class