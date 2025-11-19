Public Class StockListForm
    Private Sub StockListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInserter.GetStocksDGV(dgvInventory)
    End Sub
End Class