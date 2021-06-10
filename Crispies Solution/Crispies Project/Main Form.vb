Public Class Form1


    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        pricecolorLabel.BackColor = Color.LightBlue

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Me.Close()

    End Sub

    Private Sub fontButton_Click(sender As Object, e As EventArgs) Handles fontButton.Click
        fontDialog.Font = Me.Font
        fontDialog.ShowDialog()
        Me.Font = fontDialog.Font

    End Sub
End Class
