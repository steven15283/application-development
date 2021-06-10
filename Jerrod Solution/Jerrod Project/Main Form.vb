Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub mapleButton_Click(sender As Object, e As EventArgs) Handles mapleButton.Click
        displayPictureBox.Image = maplePictureBox.Image
        addressLabel.Text = "65 Maple"


    End Sub

    Private Sub elmButton_Click(sender As Object, e As EventArgs) Handles elmButton.Click
        displayPictureBox.Image = elmPictureBox.Image
        addressLabel.Text = "2323 elm"
    End Sub
End Class
