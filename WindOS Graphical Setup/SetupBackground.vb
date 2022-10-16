Imports System.Windows.Forms

Public Class SetupBackground
    Private Sub SetupBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupWindow.IsMdiContainer = False
        SetupWindow.MdiParent = Me
        SetupWindow.Show()
    End Sub
End Class
