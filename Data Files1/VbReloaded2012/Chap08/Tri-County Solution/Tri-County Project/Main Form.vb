' Project name:         Tri-County Project
' Project purpose:      Displays a monthly electric bill
' Created/revised by:   <Steven Guo> on <4/7/2016>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub CalcResidentialTotal(ByVal units As Integer,
                                     ByRef charge As Double)
        Const UnitCharge As Double = 0.09
        Const MinFee As Double = 17.65
        charge = units * UnitCharge
        If charge < MinFee Then
            charge = MinFee
        End If
    End Sub

    Private Function GetCommercialTotal(ByVal units As Integer) As Double
        Const UnitCharge As Double = 0.12
        Const MinFee As Double = 21.75
        Dim charge As Double

        charge = units * UnitCharge
        If charge < MinFee Then
            charge = MinFee
        End If
        Return charge
    End Function


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub SelectText(sender As Object, e As EventArgs) Handles currentTextBox.Enter, previousTextBox.Enter

        Dim thisTextBox As TextBox
        thisTextBox = TryCast(sender, TextBox)
        thisTextBox.SelectAll()
    End Sub

    Private Sub CancelKeys(sencer As Object, e As KeyPressEventArgs) Handles currentTextBox.KeyPress, previousTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles currentTextBox.TextChanged, previousTextBox.TextChanged, residentialRadioButton.CheckedChanged, commercialRadioButton.CheckedChanged

        usageLabel.Text = String.Empty
        totalLabel.Text = String.Empty
    End Sub


    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim previous As Integer
        Dim current As Integer
        Dim usage As Integer
        Dim total As Double

        Integer.TryParse(previousTextBox.Text, previous)
        Integer.TryParse(currentTextBox.Text, current)

        If current >= previous Then
            usage = current - previous
            If residentialRadioButton.Checked Then
                Call CalcResidentialTotal(usage, total)
            End If
            usageLabel.Text = usage.ToString("N0")
            totalLabel.Text = total.ToString("C2")
        Else
            MessageBox.Show("The current reading must " & "be greater than or equal to the " & "previous reading.", "Try-County Electricity", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
