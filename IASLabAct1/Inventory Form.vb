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
End Class