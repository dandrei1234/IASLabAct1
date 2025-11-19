Public Class Inventory_Form
    Private Sub Inventory_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInserter.GetStocksDGV(dgvInventory)
    End Sub
End Class