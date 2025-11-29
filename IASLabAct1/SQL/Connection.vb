Imports MySql.Data.MySqlClient

Public Class Connection
    Public Shared Function Create()
        Return New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
    End Function

End Class
