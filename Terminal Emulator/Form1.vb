Imports System.Runtime.InteropServices

Public Class Form1
    Private Sub Process1_OutputDataReceived(sender As Object, e As DataReceivedEventArgs) ' Handles Process1.OutputDataReceived
        TextBox2.Text = Process1.StandardOutput.ReadToEnd()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process1.StandardInput.WriteLine(TextBox1.Text)
    End Sub

    Private Sub Process1_Exited(sender As Object, e As EventArgs) Handles Process1.Exited
        TextBox2.Text += Process1.StartInfo.FileName + " exited"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Process1.Start()
    End Sub

    Private Sub Process1_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs) ' Handles Process1.ErrorDataReceived
        TextBox2.Text = Process1.StandardError.ReadToEnd()
    End Sub
End Class
