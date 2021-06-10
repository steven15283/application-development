' Project name:         Charleston Cable Project
' Project purpose:      Displays a customer's cable bill
' Created/revised by:   <your name> on <current date>

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates a monthly cable bill

        Const Basic As Double = 39.99
        Const Bronze As Double = 44.99
        Const Silver As Double = 59.99
        Const Gold As Double = 74.99
        Const Hbi As Double = 10.0
        Const Showtimer As Double = 11.5
        Const Cinematic As Double = 12.0
        Const Local As Double = 5.0
        Dim cableBill As Double

        ' determine package charge

        If basicRadioButton.Checked Then
            cableBill += Basic
        ElseIf bronzeRadioButton.Checked Then
            cableBill += Bronze
        ElseIf silverRadioButton.Checked Then
            cableBill += Silver
        Else
            cableBill += Gold
        End If

        'add any additional charges
        If hbiCheckBox.Checked Then
            cableBill += Hbi
        End If

        If showtimerCheckBox.Checked Then
            cableBill += Showtimer
        End If

        If cinematicCheckBox.Checked Then
            cableBill += Cinematic
        End If

        If localCheckBox.Checked Then
            cableBill += Local
        End If

        'display the cable bill
        MessageBox.Show("Your monthly cable bill is " & cableBill.ToString("C2"), "Charleston Cable Company", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub
End Class
