<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProductForm
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
        Label1 = New Label()
        Label2 = New Label()
        txtpName = New TextBox()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        Label3 = New Label()
        btnUpdate = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "Product Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 1
        Label2.Text = "Product Price:"
        ' 
        ' txtpName
        ' 
        txtpName.Location = New Point(159, 36)
        txtpName.Name = "txtpName"
        txtpName.Size = New Size(117, 23)
        txtpName.TabIndex = 2
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(159, 83)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(117, 23)
        txtPrice.TabIndex = 3
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(159, 126)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(117, 23)
        txtQuantity.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 4
        Label3.Text = "Quantity:"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(78, 186)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(176, 186)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' UpdateProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 370)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(txtQuantity)
        Controls.Add(Label3)
        Controls.Add(txtPrice)
        Controls.Add(txtpName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UpdateProductForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpdateProductForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
