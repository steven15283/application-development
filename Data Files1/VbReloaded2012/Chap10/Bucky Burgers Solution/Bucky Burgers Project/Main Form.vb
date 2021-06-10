' Project name:         Bucky Burgers Project
' Project purpose:      Add names in proper case 
'                       to a list box and print
'                       the interface
' Created/revised by:   <steven guo> on <4/26/16>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub


    Private Sub fileExitMenuItem_Click(sender As Object, e As EventArgs) Handles fileExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub filePrintMenuItem_Click(sender As Object, e As EventArgs) Handles filePrintMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim fullName As String
        Dim firstName As String
        Dim lastName As String
        Dim index As Integer

        fullName = nameTextBox.Text.Trim
        If fullName = String.Empty Then
            MessageBox.Show("Please enter a name", "Bucky Burgers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            index = fullName.IndexOf(" ")
            If index > -1 Then
                firstName = fullName.Substring(0, index)
                lastName = fullName.Substring(index + 1)
                firstName = firstName.Substring(0, 1).ToUpper & firstName.Substring(1).ToLower
                lastName = lastName.Substring(0, 1).ToUpper & lastName.Substring(1).ToLower
                fullName = firstName & " " & lastName
            Else
                fullName = fullName.Substring(0, 1).ToUpper & fullName.Substring(1).ToLower
            End If
            namesListBox.Items.Add(fullName)
        End If
        nameTextBox.Focus()
        nameTextBox.SelectAll()
    End Sub
End Class
