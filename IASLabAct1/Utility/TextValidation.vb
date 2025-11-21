Imports System.Text.RegularExpressions

Public Class TextValidation
    Private Shared regex As Regex

    Public Shared Function IsNumber(field As String) As Boolean
        regex = New Regex("(^\d{1,3}(,\d{3})*$)")
        Return regex.Match(field).Success
    End Function
End Class
