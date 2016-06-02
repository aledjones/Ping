Public Class Form1

    Private Sub cmdPing_Click(sender As Object, e As EventArgs) Handles cmdPing.Click
        Dim client As New Net.WebClient
        Dim result As String = client.DownloadString("https://toolkit.uelfte.ninja/ping.php")
        listPing.Items.Add(result)
    End Sub
End Class
