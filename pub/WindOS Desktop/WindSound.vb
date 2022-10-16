Public Class WindSound
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If String.IsNullOrWhiteSpace(OpenFileDialog1.FileName) = False Then
            player.URL = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("WindSound
A WindOS music player")
    End Sub

    Private Sub player_MediaChange(sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles player.MediaChange
        player.Width = Panel1.Width
        player.Height = Panel1.Height
    End Sub

    Private Sub WindSound_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        player.Width = Panel1.Width
        player.Height = Panel1.Height
    End Sub
End Class
