Imports MySql.Data.MySqlClient

Public Class Inventory_Form
    Dim selectedId As Integer = 0
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        UserActivityMonitor.ResetTimer()
        Me.Close()
        AddStockForm.Show()
    End Sub

    Public Sub LoadProducts()
        Try
            Using conn As MySqlConnection = Connection.Create()
                conn.Open()

                Dim query As String
                If LoggedRole = "admin" Then
                    query = "SELECT * FROM products_tbl"
                Else
                    query = "SELECT productId, productName, productprice, quantity FROM products_tbl WHERE is_deleted=0"
                End If
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvProducts.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Inventory_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoggedRole = "admin" Then
            btnUpdate.Visible = True
            btnDelete.Visible = True
        ElseIf LoggedRole = "staff" Then
            btnUpdate.Visible = False
            btnDelete.Visible = False
        End If
        LoadProducts()

        UpdateRowInfo(dgvProducts.CurrentRow.Index)
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        UserActivityMonitor.ResetTimer()
        If selectedId = 0 Then
            MessageBox.Show("Please select a row first.")
            Exit Sub
        End If

        Using conn = Connection.Create()
            conn.Open()
            Dim query As String = "UPDATE products_tbl SET is_deleted = 1 WHERE productid = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", selectedId)
            cmd.ExecuteNonQuery()
            AuditLogging.AddEntry("Stock Deleted", "Original Stock: " & pName & ", " & Environment.NewLine & "Price: " & price & ", " & Environment.NewLine & "Quantity: " & quantity)
        End Using

        MessageBox.Show("Item soft-deleted!")
        LoadProducts()
        UserActivityMonitor.ResetTimer()
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            selectedId = CInt(dgvProducts.Rows(e.RowIndex).Cells("productid").Value)

            UpdateRowInfo(e.RowIndex)
        End If
    End Sub

    Private Sub UpdateRowInfo(index As Integer)
        pName = dgvProducts.Rows(index).Cells("productname").Value.ToString()
        price = dgvProducts.Rows(index).Cells("productprice").Value.ToString()
        quantity = dgvProducts.Rows(index).Cells("quantity").Value.ToString()
    End Sub


    Private pName As String = ""
    Private price As String = ""
    Private quantity As Integer = -1


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UserActivityMonitor.ResetTimer()
        If dgvProducts.CurrentRow.Index >= 0 Then
            Dim update As UpdateProductForm = New UpdateProductForm(pName, price, quantity)
            update.Show()
        Else
            MessageBox.Show("No row selected!", "Invalid Product Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        UserActivityMonitor.ResetTimer()
        btnRefresh.Visible = True
        Dim query As String = "SELECT productname, productprice, quantity FROM products_tbl WHERE productname LIKE @productName"
        If txtSearch.Text.Trim() <> "" Then
            Try
                Using conn = Connection.Create()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@productName", txtSearch.Text & "%")

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvProducts.DataSource = table
                    AuditLogging.AddEntry("Search", "username='" & txtSearch.Text & "'")
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        UserActivityMonitor.ResetTimer()
    End Sub
    Private Sub refresh()
        Dim query As String = "SELECT productname, productprice, quantity FROM products_tbl"
        Try
            Using conn As New MySqlConnection("server=LocalHost; userid=root; password=root; database=user_authentication_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UserActivityMonitor.ResetTimer()
        txtSearch.Text = ""
        refresh()
        btnRefresh.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ResetTimer()
        Me.Close()
        If LoggedRole = "admin" Then
            Form2.Show()
        ElseIf LoggedRole = "staff" Then
            Logout(Me)
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        UserActivityMonitor.ResetTimer()
        Dim connString As String = "server=localhost; user id=root; password=root; database=user_authentication_db;"
        Dim conn As New MySqlConnection(connString)
        Dim query As String = "SELECT * FROM products_tbl"

        Try
            conn.Open()

            Using adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

        UserActivityMonitor.ResetTimer()
    End Sub
End Class