Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms

Public Class DebugInterface

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) As Integer
    <DllImport("kernel32")>
    Private Shared Function WritePrivateProfileString(ByVal lpSectionName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long
    End Function

    Private Sub DebugInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.Directory.Exists("W:\") = False Then
            MsgBox("Can't find the WindOS File System. Most of the functions will be unavailable")
            Button1.Enabled = False
            Button2.Enabled = False
            UserLabel.Text = "WindOS FileSystem not found."
            Panel1.Hide()
        Else
            If My.Computer.FileSystem.FileExists("W:\home\default\user.ini") = False Then
                UserLabel.Text = "Running on user: Unknown"
            Else
                UserLabel.Text = "Running on user: " + ReadINI("W:\home\default\user.ini", "UserAccount", "UserName")
            End If
            ProgressBar1.Value = 100
            MsgBox("You have reached the debug interface. If you got here by accident, you can just click OK and close the program.")
            Panel1.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Function ReadINI(Path As String, Section As String, Key As String) As String
        Dim res As Integer
        Dim sb As StringBuilder

        sb = New StringBuilder(500)
        res = GetPrivateProfileString(Section, Key, "", sb, sb.Capacity, Path)

        Return sb.ToString()
    End Function

    Private Function SetIniValue(filename As String, key As String, section As String, Optional defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If WritePrivateProfileString(section, key, defaultValue, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function
End Class
