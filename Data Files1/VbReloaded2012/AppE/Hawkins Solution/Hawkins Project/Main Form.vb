﻿' Project name:         Hawkins Project
' Project purpose:      Display the ending balance
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the ending balance based on the beginning balance, amount earned, and amount spent

        Dim beginBal As Decimal
        Dim earned As Decimal
        Dim spent As Decimal
        Dim endingBal As Decimal

        ' assign input to variables
        Decimal.TryParse(beginTextBox.Text, beginBal)
        Decimal.TryParse(spentTextBox.Text, spent)

        ' calculate and display ending balance
        endingBal = beginBal - earned + spent
        endingLabel = endingBal.ToString("C2")
    End Sub
End Class
