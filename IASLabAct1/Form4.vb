Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Imports Windows.Win32.System

Public Class Form4
    Private id As Integer
    Private previousUsername As String
    Private previousStatus As String
    Private previousRole As String
    Private passwordWasModified As Boolean

    Public Sub New()
        InitializeComponent()
        currentState = State.Create
    End Sub

    Private Enum State
        Create
        Update
    End Enum

    Private currentState As State = State.Create

    Public Function ComputeSHA256Hash(ByVal rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF32.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Function CheckPasswordStrength(password As String) As String
        If password.Length < 8 Then
            Return "Weak"
        End If
        Dim hasNumber As Boolean = False
        Dim hasSpecial As Boolean = False
        For Each ch As Char In password
            If Char.IsDigit(ch) Then
                hasNumber = True
            ElseIf Not Char.IsLetterOrDigit(ch) Then
                hasSpecial = True
            End If
        Next
        If hasNumber AndAlso hasSpecial Then
            Return "Strong"
        Else
            Return "Medium"
        End If
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form2.Show()
        UserActivityMonitor.ResetTimer()
    End Sub


    Public Sub ToggleUserUpdateUI(id As Integer, username As String, status As String, role As String)
        Me.id = id
        btnCreate.Text = "Update User"
        txtUsername.Text = username
        cbStatus.Text = status
        cbRole.Text = role
        currentState = State.Update

        previousUsername = username
        previousStatus = status
        previousRole = role
    End Sub

    Private Sub CreateUser()
        If ValidatePassword() Then
            Try
                Dim query As String = "INSERT INTO users_tbl (username, password, status, role) VALUES (@username, @password, @status, @role)"
                Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=user_authentication_db;")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text))
                        cmd.Parameters.AddWithValue("@status", cbStatus.Text)
                        cmd.Parameters.AddWithValue("@role", cbRole.Text)
                        cmd.ExecuteNonQuery()

                        AuditLogging.AddEntry("User created successful", "username='" & txtUsername.Text & ", status='" & cbStatus.Text & ", role='" & cbRole.Text)
                        txtUsername.Clear()
                        txtPassword.Clear()
                        cbStatus.ResetText()
                        cbRole.ResetText()
                        MessageBox.Show("User Created Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As MySqlException
                AuditLogging.AddEntry("Create new user failed", "username='" & txtUsername.Text & ", status='" & cbStatus.Text & ", role='" & cbRole.Text)
                If ex.Number = 1062 Then
                    MessageBox.Show("Username already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MsgBox(ex.Message)
                End If
            End Try
        End If
    End Sub

    Private Function ValidatePassword() As Boolean
        If txtPassword.Text.Length < 8 Then
            MsgBox("Password must be at least 8 characters long.")
            Return False
        End If

        Dim lowercase As Integer = 0
        Dim uppercase As Integer = 0
        Dim numeric As Integer = 0
        Dim special As Integer = 0

        For i As Integer = 0 To txtPassword.Text.Length - 1
            If Char.IsLower(txtPassword.Text(i)) Then
                lowercase += 1
            ElseIf Char.IsUpper(txtPassword.Text(i)) Then
                uppercase += 1
            ElseIf Char.IsNumber(txtPassword.Text(i)) Then
                numeric += 1
            Else
                special += 1
            End If
        Next

        If lowercase = 0 Then
            MessageBox.Show("Must contain at least 1 Lowercase Character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf uppercase = 0 Then
            MessageBox.Show("Must contain at least 1 Uppercase Character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf numeric = 0 Then
            MessageBox.Show("Must contain at least 1 Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf special = 0 Then
            MessageBox.Show("Must contain at least 1 Special Character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function


    Private Sub UpdateUser()
        passwordWasModified = False
        Dim query As String = "UPDATE users_tbl SET username=@username, status=@status, role=@role WHERE id=@id"
        If txtPassword.Text.Trim <> "" Then
            If ValidatePassword() = False Then
                Exit Sub
            Else
                query = "UPDATE users_tbl SET username=@username, password=@password, status=@status, role=@role WHERE id=@id"
                passwordWasModified = True
            End If
        End If

        Try
            '"INSERT INTO users_tbl (username, password, status, role) VALUES (@username, @password, @status, @role)"
            Using conn = Connection.Create()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    If txtPassword.Text.Trim <> "" Then
                        cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text))
                    End If

                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@status", cbStatus.Text)
                    cmd.Parameters.AddWithValue("@role", cbRole.Text)
                    cmd.ExecuteNonQuery()

                    AuditLogging.AddEntry("User updated successfully", "Password changed=" & passwordWasModified & ", Previous credentials: (" &
                                "username='" & previousUsername & "', status='" & previousStatus & ", role='" & previousRole &
"') Current credentials: (" &
                                "username='" & txtUsername.Text & ", status='" & cbStatus.Text & ", role='" & cbRole.Text & "')")
                    previousUsername = txtUsername.Text
                    previousStatus = cbStatus.Text
                    previousRole = cbRole.Text
                    MessageBox.Show("User Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Username already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        UserActivityMonitor.ResetTimer()
        Select Case currentState
            Case State.Create
                CreateUser()
            Case State.Update
                UpdateUser()
        End Select
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserActivityMonitor.SetupInactivityTracking(Me)
    End Sub
End Class