' Project name:         Just Birthdays Project
' Project purpose:      Displays the total charge
' Created/revised by:   <Steven Guo> on <March 3, 2016>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub guestsTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles guestsTextBox.KeyPress
        ' allows only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fills the list box and selects the first item

        typeListBox.Items.Add("Kid's")
        typeListBox.Items.Add("21st")
        typeListBox.Items.Add("40th")
        typeListBox.Items.Add("Other")
        typeListBox.SelectedIndex = 0

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'displays the total charge

        Dim guests As Integer
        Dim typeIndex As Integer
        Dim guestPrice As Integer
        Dim totalCharge As Integer

        Integer.TryParse(guestsTextBox.Text, guests)
        typeIndex = typeListBox.SelectedIndex

        'determine the price per guest
        Select Case typeIndex
            Case 0
                guestPrice = 11
            Case 1
                guestPrice = 20
            Case 2
                guestPrice = 25
            Case Else
                guestPrice = 15
        End Select

        'calculate and display the total charge
        totalCharge = guests * guestPrice
        totalLabel.Text = totalCharge.ToString("C0")
    End Sub


    Private Sub testDataButton_Click(sender As Object, e As EventArgs) Handles testDataButton.Click
        Dim guests As Integer
        Dim typeIndex As Integer
        Dim guestPrice As Integer
        Dim totalCharge As Integer
        Dim randGen As New Random
        Dim setsOfDataCounter As Integer = 1

        testDataLabel.Text = String.Empty

        Do
            guests = randGen.Next(1, 51)
            typeIndex = randGen.Next(0, 4)

            'determine the price per guest
            Select Case typeIndex
                Case 0
                    guestPrice = 11
                Case 1
                    guestPrice = 20
                Case 2
                    guestPrice = 25
                Case Else
                    guestPrice = 15



            End Select
            'calculate and display the total charge
            totalCharge = guests * guestPrice
            testDataLabel.Text = testDataLabel.Text & typeIndex.ToString & "      " & guests.ToString & "        " & totalCharge.ToString("C0") & ControlChars.NewLine
            setsOfDataCounter += 1

        Loop Until setsOfDataCounter > 10
    End Sub
End Class
