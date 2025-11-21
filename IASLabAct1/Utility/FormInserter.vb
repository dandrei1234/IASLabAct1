Imports MySql.Data.MySqlClient

Public Class FormInserter

    Public Shared Sub InsertPanel(form As Form, panel As Panel)
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        form.TopLevel = False
        panel.Controls.Clear()
        panel.Controls.Add(form)
        form.Show()
    End Sub

End Class