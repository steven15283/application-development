Public Class Form1


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim ficaTax As Decimal
        Dim yearEarnings As Decimal
        Dim currentEarnings As Decimal



        Decimal.TryParse(year2DateEarnings.Text, yearEarnings)
        Decimal.TryParse(currentEarningsBox.Text, currentEarnings)

        If yearEarnings > 113700 Then
            ficaTax = 113700 - (yearEarnings * 0.062) + (currentEarnings * 0.0145)
            currentFICATaxLabel.Text = ficaTax.ToString("C2")
        End If
        If yearEarnings < 113700 Then
            ficaTax = currentEarnings * 0.0765
            currentFICATaxLabel.Text = ficaTax.ToString("C2")
        End If

    End Sub
End Class
