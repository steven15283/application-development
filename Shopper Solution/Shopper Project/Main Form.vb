Public Class Form1

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim totalMonthlyPurchase As Decimal
        Dim rewardPoints As Decimal
        Decimal.TryParse(monthlyPurchase.Text, totalMonthlyPurchase)



        If basiccheckBox.Checked Then

            If totalMonthlyPurchase < 100 Then
                rewardPoints = totalMonthlyPurchase * 0.05
                rewardLabel.Text = rewardPoints.ToString("C2")
            Else
                rewardPoints = totalMonthlyPurchase * 0.07
                rewardLabel.Text = rewardPoints.ToString("C2")
            End If

        End If

        If standardcheckBox.Checked Then
            If totalMonthlyPurchase < 150 Then
                rewardPoints = totalMonthlyPurchase * 0.06
                rewardLabel.Text = rewardPoints.ToString("C2")
            ElseIf totalMonthlyPurchase > 150 AndAlso totalMonthlyPurchase < 299.99 Then
                rewardPoints = totalMonthlyPurchase * 0.08
                rewardLabel.Text = rewardPoints.ToString("C2")
            Else
                rewardPoints = totalMonthlyPurchase * 0.1
                rewardLabel.Text = rewardPoints.ToString("C2")
            End If

        End If

        If premiumcheckBox.Checked Then
            If totalMonthlyPurchase < 200 Then
                rewardPoints = totalMonthlyPurchase * 0.07
                rewardLabel.Text = rewardPoints.ToString("C2")
            Else
                rewardPoints = totalMonthlyPurchase * 0.15
                rewardLabel.Text = rewardPoints.ToString("C2")
            End If

        End If

    End Sub
End Class
