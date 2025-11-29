Module UserActivityMonitor
    Public LoggedUserId As Integer
    Public LoggedUsername As String
    Public LoggedRole As String
    Public LoggedStatus As String


    Public inactivityTimer As New Timer()
    'Public inactivityLimit As Integer = 5 * 60 ' 5 minutes in seconds
    Public inactivityLimit As Integer = 7
    Public remainingTime As Integer = inactivityLimit
    Public currentLabel As Label = LogoutTimeTestForm.lbl ' Label on form to show countdown



    Public Sub SetLoggedUser(UserId As Integer, Username As String, Role As String, Status As String)
        LoggedUserId = UserId
        LoggedUsername = Username
        LoggedRole = Role
        LoggedStatus = Status
    End Sub

    Public Sub Logout(form As Form)
        StopTimer()
        AuditLogging.AddEntry("Logged out", "")
        ClearUserCredentials()
        Form1.Show()
        form.Close()
    End Sub    ' Call this in each form's Load


    Private Sub ClearUserCredentials()
        LoggedUserId = 0
        LoggedUsername = ""
        LoggedRole = ""
        LoggedStatus = ""
    End Sub

    Public Sub SetupInactivityTracking(currentForm As Form)
        'currentLabel = displayLabel
        remainingTime = inactivityLimit

        ' Configure timer to tick every second
        inactivityTimer.Interval = 1000 ' 1 second
        AddHandler inactivityTimer.Tick, AddressOf TimerTick
        inactivityTimer.Start()

        ' Hook form activity
        AddHandler currentForm.MouseMove, Sub() ResetTimer()
        AddHandler currentForm.KeyPress, Sub() ResetTimer()
    End Sub

    ' Reset timer on activity
    Public Sub ResetTimer()
        remainingTime = inactivityLimit
        UpdateLabel()
    End Sub

    ' Called every second
    Private Sub TimerTick(sender As Object, e As EventArgs)
        remainingTime -= 1
        UpdateLabel()

        If remainingTime <= 0 Then
            inactivityTimer.Stop()
            Logout()
        End If
    End Sub

    Public Sub StopTimer()
        inactivityTimer.Stop()
    End Sub

    Private Sub UpdateLabel()
        If currentLabel IsNot Nothing Then
            Dim minutes As Integer = remainingTime \ 60
            Dim seconds As Integer = remainingTime Mod 60
            currentLabel.Text = $"Auto-logout in {minutes:D2}:{seconds:D2}"
        End If
    End Sub

    Private Sub Logout()
        AuditLogging.AddEntry("Session timeout due to inactivity", "")
        ClearUserCredentials()

        StopTimer()

        ' Show login form
        Dim loginForm As New Form1()
        loginForm.Show()

        ' Copy open forms to an array to avoid modifying collection during iteration
        Dim openForms() As Form = Application.OpenForms.Cast(Of Form)().ToArray()

        For Each f As Form In openForms
            If f.Name <> "Form1" Then
                f.Close()
            End If
        Next

        MessageBox.Show("You have been logged out due to inactivity.", "Session Timeout")
    End Sub
End Module