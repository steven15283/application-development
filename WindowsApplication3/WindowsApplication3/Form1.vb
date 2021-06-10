Public Class Form1
    Dim count As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer = 1
        Dim labelString As String

        Do While count < 11
            Label1.Text += count.ToString() & ", "
            count = count + 2

        Loop

    End Sub
End Class
