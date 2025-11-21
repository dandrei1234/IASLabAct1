Public Class AddStockForm
    Public form As Inventory_Form
    Private productIds = New List(Of Integer)

    Private Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim products As List(Of (Id As Integer, Name As String)) = InventorySQL.GetProductNames()

        For Each product As (Id As Integer, Name As String) In products
            cmbProduct.Items.Add(product.Name)
            productIds.Add(product.Id)
        Next

        If products.Count > 0 Then
            cmbProduct.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        If IsNumeric(txtQuantity.Text) Or TextValidation.IsNumber(txtQuantity.Text) Then
            'MsgBox("Combo box selection = " & cmbProduct.Items(cmbProduct.SelectedIndex) & "; Selected index = " & cmbProduct.SelectedIndex & "; Product Id = " & productIds(cmbProduct.SelectedIndex))
            InventorySQL.AddStock(productIds(cmbProduct.SelectedIndex), Convert.ToDecimal(txtQuantity.Text))
            MessageBox.Show("Stock Successfully Added", "Stock Added")
        Else
            MsgBox("Not a number")
        End If
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