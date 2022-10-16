Imports System.Windows.Forms

Public Class BreezePad

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        Dim ConfirmationBox As MsgBoxResult = MsgBox("Do you want to save this document?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Confirmation")
        If ConfirmationBox = MsgBoxResult.Yes Then
            Dim OpenFileDialog As New SaveFileDialog
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Dim FileName As String = OpenFileDialog.FileName
                My.Computer.FileSystem.WriteAllText(FileName, TextBox1.Text, False)
            End If
            TextBox1.Clear()
        ElseIf ConfirmationBox = MsgBoxResult.No Then
            TextBox1.Clear()
        End If
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(FileName)
        End If
        'Me.IsMdiContainer = True
        ''OpenFileDialog2.IsMdiContainer = False
        ''OpenFileDialog2.MdiParent = Me
        ''OpenFileDialog2.Show()
        ''TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog2.FileListBox1.FileName)
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        TextBox1.Text.Remove(TextBox1.SelectionStart, TextBox1.SelectionLength)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        My.Computer.Clipboard.SetText(TextBox1.SelectedText)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        If My.Computer.Clipboard.ContainsText = True Then
            TextBox1.Text = TextBox1.Text + My.Computer.Clipboard.GetText
        End If
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub
    Private m_ChildFormNumber As Integer

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        SaveFileDialog.ShowDialog()

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
            My.Computer.FileSystem.WriteAllText(FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub
End Class
