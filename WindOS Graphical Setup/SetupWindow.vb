Imports System.IO.Compression
Imports System.Runtime.InteropServices
Imports System.Text

Public Class SetupWindow
    Public totalbytes As Long
    Public freeBytes As Long
    Public SetupStage As Byte

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) As Integer
    <DllImport("kernel32")>
    Private Shared Function WritePrivateProfileString(ByVal lpSectionName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub SetupWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If SetupStage = 0 Then
            Panel2.Show()
            If IO.Directory.Exists("W:\") = True Then
                ComboBox1.Items.Clear()
                Dim allDrives() As IO.DriveInfo = IO.DriveInfo.GetDrives()
                Dim d As IO.DriveInfo
                For Each d In allDrives

                    If d.IsReady = True Then
                        totalbytes += d.TotalSize
                        freeBytes += d.AvailableFreeSpace
                    End If
                Next
                Dim freeGBs As Long = freeBytes / 1073741824

                ComboBox1.Items.Add("Disk 0 [" + Convert.ToString(freeGBs) + " GB]")
                Panel2.Show()
            Else
                ComboBox1.Items.Clear()
                ComboBox1.Items.Add("No disks found.")
                Button1.Enabled = False
            End If
            SetupStage = 1
        ElseIf SetupStage = 1 Then
            Panel3.Show()
            ZipFile.ExtractToDirectory(Environment.CurrentDirectory + "\main.zip", "W:\")
            Panel4.Show()
        End If
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        SetIniValue("W:\home\default\user.ini", "UserName", "UserAccount", TextBox1.Text)
    End Sub

    Private Sub SetupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
