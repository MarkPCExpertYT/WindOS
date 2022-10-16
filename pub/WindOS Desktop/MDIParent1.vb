Public Class MDIForm1
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DirListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles DirListBox1.SelectedValueChanged
        FileListBox1.Path = DirListBox1.Path
    End Sub
    Private Sub FileListBox1_DoubleClick(sender As Object, e As EventArgs) Handles FileListBox1.DoubleClick
        Try
            Process.Start(DirListBox1.Path + "\" + FileListBox1.FileName)
        Catch ex As Exception
            MsgBox(DirListBox1.Path + "\" + FileListBox1.FileName + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub DirListBox1_DoubleClick(sender As Object, e As EventArgs) Handles DirListBox1.DoubleClick
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
