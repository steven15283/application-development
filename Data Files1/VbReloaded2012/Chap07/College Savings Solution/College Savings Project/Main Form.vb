' Project name:         College Savings Project
' Project purpose:      Displays the balance in a savings account
' Created/revised by:   <Steven Guo> on <3/28/2016>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate the savings account balance
        ' at the end of 18 years, using a fixed
        ' monthly savings amount and a fixed 
        ' annual interest rate

        Const TermYears As Double = 18
        Dim balance As Double

        balanceListBox.Items.Clear()
        For rates As Double = 0.02 To 0.05 Step 0.01
            balanceListBox.Items.Add(rates.ToString("P0"))
            For deposits As Double = 100 To 200 Step 50
                balance =
                    -Financial.FV(rates / 12, TermYears * 12, deposits)
                balanceListBox.Items.Add(deposits.ToString("C0") & "   " & balance.ToString("C2"))
            Next deposits
            balanceListBox.Items.Add(ControlChars.NewLine)
        Next rates




    End Sub
End Class
