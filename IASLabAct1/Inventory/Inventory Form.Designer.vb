<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvProducts = New DataGridView()
        btnAdd = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        Label1 = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnRefresh = New Button()
        btnBack = New Button()
        btnView = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.AllowUserToResizeColumns = False
        dgvProducts.AllowUserToResizeRows = False
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvProducts.Location = New Point(84, 98)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(439, 248)
        dgvProducts.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(109, 371)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add Stock"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(306, 371)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(205, 371)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(89, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 5
        Label1.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(140, 57)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(191, 23)
        txtSearch.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(337, 60)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(432, 60)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(432, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(412, 371)
        btnView.Name = "btnView"
        btnView.Size = New Size(75, 23)
        btnView.TabIndex = 10
        btnView.Text = "View"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' Inventory_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(604, 450)
        Controls.Add(btnView)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(Label1)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(dgvProducts)
        Name = "Inventory_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory_Form"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnView As Button
End Class
