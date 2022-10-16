Imports System.Windows.Forms

Public Class OpenFileDialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not String.IsNullOrWhiteSpace(FileListBox1.FileName) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DirListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles DirListBox1.SelectedValueChanged
        FileListBox1.Path = DirListBox1.Path
    End Sub

    Private Sub DriveListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveListBox1.SelectedValueChanged
        DirListBox1.Path = DriveListBox1.Drive
        FileListBox1.Path = DriveListBox1.Drive
    End Sub

    Private Sub DriveListBox1_Click(sender As Object, e As EventArgs) Handles DriveListBox1.Click
        DriveListBox1.Refresh()
    End Sub

    Private Sub FileListBox1_DoubleClick(sender As Object, e As EventArgs) Handles FileListBox1.DoubleClick
        If Not String.IsNullOrWhiteSpace(FileListBox1.FileName) Then
            Me.Close()
        End If
    End Sub
End Class
