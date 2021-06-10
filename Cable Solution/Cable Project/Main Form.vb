Public Class Form

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        premiumChannelsListBox.SelectedIndex = 0
        connectionsListBox.SelectedIndex = 0
    End Sub

    Private Function GetPrice(ByVal channels As Integer,
                              ByVal connections As Integer,
                              ByRef cableType As Integer) As Double
        Dim Total As Double

        If cableType = 1 Then
            Const processingFee As Double = 4.5
            Const basicServiceFee As Double = 30
            Const premiumChannel As Double = 5
            Total = processingFee + basicServiceFee + (premiumChannel * channels)
            Return Total
        Else
            Const processingFee As Double = 16.5
            Const premiumChannel As Double = 50
            Dim basicServiceFee As Double
            If connections > 10 Then
                basicServiceFee = 80 + (4 * (connections - 10))
            Else
                basicServiceFee = 80
            End If

            Total = processingFee + (premiumChannel * channels) + basicServiceFee
            Return Total

        End If


    End Function

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim cableType As Integer
        Dim channelIndex As Integer
        Dim connectionIndex As Integer
        Dim totalPrice As Double
        If businessRadioButton.Checked Then
            cableType = 0
        ElseIf residentialRadioButton.Checked Then
            cableType = 1
        End If

        channelIndex = premiumChannelsListBox.SelectedIndex
        connectionIndex = connectionsListBox.SelectedIndex
        totalPrice = GetPrice(channelIndex, connectionIndex, cableType)
        totalLabelBox.Text = totalPrice.ToString("C")
    End Sub
End Class
