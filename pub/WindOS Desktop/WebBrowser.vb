Public Class WebBrowser

    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.LoadUrl("https://www.google.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChromiumWebBrowser1.BrowserCore.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChromiumWebBrowser1.BrowserCore.Reload(True)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ChromiumWebBrowser1.BrowserCore.GoForward()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ChromiumWebBrowser1.LoadUrl(TextBox2.Text)
    End Sub

    Private Sub ChromiumWebBrowser1_TitleChanged(sender As Object, e As CefSharp.TitleChangedEventArgs)
        'Me.Text = ChromiumWebBrowser1. + " - WindSurfer"
    End Sub

    Private Sub ChromiumWebBrowser1_AddressChanged(sender As Object, e As CefSharp.AddressChangedEventArgs)
        If ActiveControl.Tag = "panel" Then
            For Each c As Control In Panel1.Controls
                If c.Focused = True Then
                    'do nothing
                End If
            Next
        Else
            TextBox2.Text = ChromiumWebBrowser1.Address
        End If
    End Sub
    Function FindFocussedControl(ByVal ctr As Control) As Control
        Dim container As ContainerControl = TryCast(ctr, ContainerControl)
        Do While (container IsNot Nothing)
            ctr = container.ActiveControl
            container = TryCast(ctr, ContainerControl)
        Loop
        Return ctr
    End Function

    Private Sub ChromiumWebBrowser1_LoadingStateChanged(sender As Object, e As CefSharp.LoadingStateChangedEventArgs)
        If ChromiumWebBrowser1.IsLoading = True Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub WebBrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'ChromiumWebBrowser1.Dispose()
    End Sub

    Private Sub Browser_TitleChanged(sender As Object, e As CefSharp.TitleChangedEventArgs) Handles ChromiumWebBrowser1.TitleChanged
        Me.Text = e.Title + " - WindSurfer"
        TabPage1.Text = e.Title
    End Sub
End Class
