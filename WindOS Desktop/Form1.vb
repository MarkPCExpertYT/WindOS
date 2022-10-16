Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Public Class Form1

    Public ReadOnly Property OpenForms As FormCollection
    Public ReadOnly Property BatteryLifePercent As Single
    Public ReadOnly Property BatteryChargeStatus As BatteryChargeStatus
    Dim Svol As Int32 = 30
    Dim DevEnum As New CoreAudio.MMDeviceEnumerator()
    Dim device As CoreAudio.MMDevice = DevEnum.GetDefaultAudioEndpoint(CoreAudio.EDataFlow.eRender, CoreAudio.ERole.eMultimedia)

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) As Integer
    <DllImport("kernel32")>
    Private Shared Function WritePrivateProfileString(ByVal lpSectionName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Clock.Text = TimeOfDay
        If BatteryChargeStatus = BatteryChargeStatus.NoSystemBattery Then
            BatteryLbl.Text = "No System
battery"
            ProgressBar1.Value = 100
        Else
            BatteryLbl.Text = Convert.ToString(BatteryLifePercent * 100.0F) + "%
 "
        End If

        'If IsNothing(ActiveForm) Then
        '   Label1.Text = "WindOS Denali Desktop"
        'Else
        '   Label1.Text = Me.MdiChildren
        'End If

        If My.Computer.Keyboard.CapsLock = True AndAlso My.Computer.Keyboard.AltKeyDown = True Then
            MDIForm1.MdiParent = Me
            WebBrowser.MdiParent = Me
            BreezePad.MdiParent = Me
            WindSound.MdiParent = Me
            DebugInterface.MdiParent = Me
            DebugInterface.Show()
        End If

    End Sub

    Private Sub ChangeWallpaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeWallpaperToolStripMenuItem.Click
        WallpaperDialog.FileName = ""
        WallpaperDialog.ShowDialog()
        If String.IsNullOrWhiteSpace(WallpaperDialog.FileName) Then
            Me.BackgroundImage = My.Resources.leaf_better
        Else
            Me.BackgroundImage = Image.FromFile(WallpaperDialog.FileName)
        End If
    End Sub

    Private Sub ResetWallpaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetWallpaperToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.leaf_better
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Zoom
        ZoomToolStripMenuItem.Checked = True
        StretchToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Stretch
        ZoomToolStripMenuItem.Checked = False
        StretchToolStripMenuItem.Checked = True
        TileToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
    End Sub

    Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Tile
        ZoomToolStripMenuItem.Checked = False
        StretchToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = True
        CenterToolStripMenuItem.Checked = False
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        Me.BackgroundImageLayout = ImageLayout.Center
        ZoomToolStripMenuItem.Checked = False
        StretchToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ContextMenuStrip2.Show(0, Me.Height - Panel1.Height)
        If Panel2.Tag = "false" Then
            Panel2.Location = New Point(0, Me.Height - Panel2.Height - Panel1.Height)
            Panel2.Show()
            Panel2.Tag = "true"
        ElseIf Panel2.Tag = "true" Then
            Panel2.Hide()
            Panel2.Tag = "false"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        MDIForm1.MdiParent = Me
        WebBrowser.MdiParent = Me
        BreezePad.MdiParent = Me
        WindSound.MdiParent = Me
        TrackBar1.Value = device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0F
        VolumeLbl.Text = Convert.ToString(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0F) + "%"

        If My.Computer.FileSystem.FileExists("W:\home\default\user.ini") = False Then
            MsgBox("User file not found, has WindOS loaded correctly?")
            UserLabel.Text = "Running on user: 
Unknown"
        Else
            UserLabel.Text = "Running on user: 
" + ReadINI("W:\home\default\user.ini", "UserAccount", "UserName")
        End If
    End Sub
    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        If ListBox1.SelectedIndex = 0 Then
            MDIForm1.MdiParent = Me
            WebBrowser.MdiParent = Me
            BreezePad.MdiParent = Me
            WindSound.MdiParent = Me
            MDIForm1.Show()
        ElseIf ListBox1.SelectedIndex = 1 Then
            MDIForm1.MdiParent = Me
            WebBrowser.MdiParent = Me
            BreezePad.MdiParent = Me
            WindSound.MdiParent = Me
            WebBrowser.Show()
        ElseIf ListBox1.SelectedIndex = 2 Then
            MDIForm1.MdiParent = Me
            WebBrowser.MdiParent = Me
            BreezePad.MdiParent = Me
            WindSound.MdiParent = Me
            BreezePad.Show()
        ElseIf ListBox1.SelectedIndex = 3 Then
            MDIForm1.MdiParent = Me
            WebBrowser.MdiParent = Me
            BreezePad.MdiParent = Me
            WindSound.MdiParent = Me
            WindSound.Show()
        End If
        Panel2.Hide()
        Panel2.Tag = "false"
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Refresh()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        device.AudioEndpointVolume.MasterVolumeLevelScalar = TrackBar1.Value / 100.0F
        VolumeLbl.Text = Convert.ToString(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0F) + "%"

        If device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0F >= 50 Then
            VolumeIcon.BackgroundImage = My.Resources.volume_high
        ElseIf device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0F <= 50 Then
            VolumeIcon.BackgroundImage = My.Resources.volume_medium
        ElseIf device.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0F <= 1 Then
            VolumeIcon.BackgroundImage = My.Resources.volume_off
        End If
    End Sub

    Function ReadINI(Path As String, Section As String, Key As String) As String

        If My.Computer.FileSystem.FileExists(Path) = False Then
            Return "null"
        End If

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Form1_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Label1.Text = Me.Text
    End Sub

    Function GetValueInMdiForm() As Int32

        Return 0
    End Function
End Class
