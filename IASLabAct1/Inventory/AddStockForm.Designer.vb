<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStockForm
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
        btnAddStock = New Button()
        txtQuantity = New TextBox()
        cmbFood = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' btnAddStock
        ' 
        btnAddStock.Location = New Point(136, 153)
        btnAddStock.Name = "btnAddStock"
        btnAddStock.Size = New Size(75, 23)
        btnAddStock.TabIndex = 0
        btnAddStock.Text = "Add Stock"
        btnAddStock.UseVisualStyleBackColor = True
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(136, 109)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(85, 23)
        txtQuantity.TabIndex = 1
        ' 
        ' cmbFood
        ' 
        cmbFood.FormattingEnabled = True
        cmbFood.Location = New Point(136, 71)
        cmbFood.Name = "cmbFood"
        cmbFood.Size = New Size(132, 23)
        cmbFood.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 3
        Label1.Text = "Select Food:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 4
        Label2.Text = "Quantity:"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 5
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' AddStockForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(338, 293)
        Controls.Add(btnBack)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbFood)
        Controls.Add(txtQuantity)
        Controls.Add(btnAddStock)
        Name = "AddStockForm"
        Text = "AddStockForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddStock As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cmbFood As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
End Class
