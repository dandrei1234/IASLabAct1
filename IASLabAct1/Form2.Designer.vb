<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnLogout = New Button()
        MenuStrip1 = New MenuStrip()
        SettingToolStripMenuItem = New ToolStripMenuItem()
        UserProfileToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        BackupToolStripMenuItem = New ToolStripMenuItem()
        RestoreToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        AuditLogsToolStripMenuItem = New ToolStripMenuItem()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        dgvacc = New DataGridView()
        btnUpdate = New Button()
        btnView = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        txtID = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        cbStatus = New ComboBox()
        cbRole = New ComboBox()
        btnSearch = New Button()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtPassword = New TextBox()
        btnX = New Button()
        MenuStrip1.SuspendLayout()
        CType(dgvacc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(661, 27)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SettingToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(805, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SettingToolStripMenuItem
        ' 
        SettingToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UserProfileToolStripMenuItem, InventoryToolStripMenuItem, ToolStripSeparator1, BackupToolStripMenuItem, RestoreToolStripMenuItem, ToolStripSeparator2, AuditLogsToolStripMenuItem})
        SettingToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        SettingToolStripMenuItem.Size = New Size(65, 20)
        SettingToolStripMenuItem.Text = "Settings"
        ' 
        ' UserProfileToolStripMenuItem
        ' 
        UserProfileToolStripMenuItem.Name = "UserProfileToolStripMenuItem"
        UserProfileToolStripMenuItem.Size = New Size(136, 22)
        UserProfileToolStripMenuItem.Text = "Add Profile"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(136, 22)
        InventoryToolStripMenuItem.Text = "Inventory"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(133, 6)
        ' 
        ' BackupToolStripMenuItem
        ' 
        BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        BackupToolStripMenuItem.Size = New Size(136, 22)
        BackupToolStripMenuItem.Text = "Backup"
        ' 
        ' RestoreToolStripMenuItem
        ' 
        RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        RestoreToolStripMenuItem.Size = New Size(136, 22)
        RestoreToolStripMenuItem.Text = "Restore"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(133, 6)
        ' 
        ' AuditLogsToolStripMenuItem
        ' 
        AuditLogsToolStripMenuItem.Name = "AuditLogsToolStripMenuItem"
        AuditLogsToolStripMenuItem.Size = New Size(136, 22)
        AuditLogsToolStripMenuItem.Text = "Audit Logs"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' dgvacc
        ' 
        dgvacc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvacc.Location = New Point(36, 58)
        dgvacc.Name = "dgvacc"
        dgvacc.Size = New Size(541, 287)
        dgvacc.TabIndex = 2
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(153, 368)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(78, 23)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(260, 368)
        btnView.Name = "btnView"
        btnView.Size = New Size(78, 23)
        btnView.TabIndex = 4
        btnView.Text = "View"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(365, 368)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(78, 23)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(583, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 6
        Label1.Text = "ID:"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(652, 78)
        txtID.Name = "txtID"
        txtID.Size = New Size(58, 23)
        txtID.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(583, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 10
        Label2.Text = "Status:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(583, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 11
        Label3.Text = "Role:"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"pending", "authorized", "unauthorized"})
        cbStatus.Location = New Point(652, 170)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(109, 23)
        cbStatus.TabIndex = 12
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"staff", "admin"})
        cbRole.Location = New Point(652, 204)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(109, 23)
        cbRole.TabIndex = 13
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(652, 252)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(78, 23)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(652, 112)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(109, 23)
        txtUsername.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(583, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 16
        Label4.Text = "Username:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(583, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 18
        Label5.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(652, 141)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(109, 23)
        txtPassword.TabIndex = 17
        ' 
        ' btnX
        ' 
        btnX.Location = New Point(767, 115)
        btnX.Name = "btnX"
        btnX.Size = New Size(20, 20)
        btnX.TabIndex = 19
        btnX.Text = "X"
        btnX.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(805, 441)
        Controls.Add(btnX)
        Controls.Add(Label5)
        Controls.Add(txtPassword)
        Controls.Add(Label4)
        Controls.Add(txtUsername)
        Controls.Add(btnSearch)
        Controls.Add(cbRole)
        Controls.Add(cbStatus)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtID)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnView)
        Controls.Add(btnUpdate)
        Controls.Add(dgvacc)
        Controls.Add(btnLogout)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgvacc, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents dgvacc As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnX As Button
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AuditLogsToolStripMenuItem As ToolStripMenuItem
End Class
