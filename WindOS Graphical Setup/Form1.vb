Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Public Class Form1
    Dim LoadingState As Short = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Show()
        Timer1.Stop()
    End Sub

    Public privateFontCollection As New Drawing.Text.PrivateFontCollection
    Public FamilyName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As IntPtr = Marshal.AllocCoTaskMem(My.Resources.VGASYS.Length - 1)

        'copy the bytes to the unsafe memory block
        Marshal.Copy(My.Resources.VGASYS, 0, data, My.Resources.VGASYS.Length)

        'pass the font to the font collection
        privateFontCollection.AddMemoryFont(data, My.Resources.VGASYS.Length)

        'free the unsafe memory
        Marshal.FreeCoTaskMem(data)

        Dim fnt As Font = New Font(privateFontCollection.Families(0), 12)
        Dim fnt2 As Font = New Font(privateFontCollection.Families(0), 36)
        Label1.Font = fnt
        Label2.Font = fnt2
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If LoadingState = 0 Then
            Label2.Text = "WindOS Setup is loading...

[ ] [o] [ ]"
            LoadingState = 1
        ElseIf LoadingState = 1 Then
            Label2.Text = "WindOS Setup is loading...

[ ] [ ] [o]"
            LoadingState = 2
        ElseIf LoadingState = 2 Then
            Label2.Text = "WindOS Setup is loading...

[o] [ ] [ ]"
            LoadingState = 0
        End If
    End Sub
End Class