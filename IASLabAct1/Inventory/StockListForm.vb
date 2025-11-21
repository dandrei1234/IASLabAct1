Public Class StockListForm
    Private Sub StockListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InventorySQL.GetStocksDGV(dgvInventory)
    End Sub
End Class