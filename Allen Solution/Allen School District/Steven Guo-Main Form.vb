Public Class principalName

    Private Sub phoneLabel_Click(sender As Object, e As EventArgs) Handles phoneLabel.Click

    End Sub

    Private Sub primarycenterButton_Click(sender As Object, e As EventArgs) Handles primarycenterButton.Click
        principalTextBox.Text = "George Washington"
        phoneTextBox.Text = "1111111111"
    End Sub

    Private Sub lewisButton_Click(sender As Object, e As EventArgs) Handles lewisButton.Click
        principalTextBox.Text = "George Wershington"
        phoneTextBox.Text = "2222222222"
    End Sub

    Private Sub kaufmanButton_Click(sender As Object, e As EventArgs) Handles kaufmanButton.Click
        principalTextBox.Text = "George Woshington"
        phoneTextBox.Text = "3333333333"
    End Sub

    Private Sub allenButton_Click(sender As Object, e As EventArgs) Handles allenButton.Click
        principalTextBox.Text = "George Wushington"
        phoneTextBox.Text = "4444444444"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
