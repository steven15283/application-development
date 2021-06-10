Public Class Form1

    Private salespeople() As String = {"Carol Jackson", "Jeremiah Jeffers", "Pat Kowalski", "Jose Gutierrez", "Coulter Smith"}

    Private bonuses() As Integer = {3450, 500, 1200, 2900, 450}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub


    Private Sub reportButton_Click(sender As Object, e As EventArgs) Handles reportButton.Click
        Dim passWord As String
        reportListBox.Items.Clear()
        passWord = InputBox("Password:", "Password Entry")
        If passWord Like "[a-z]##[EM]3[a-d]#" Then
            Const NameHead As String = "Name"
            Const BonusHead As String = "Bonus ($)"
            Dim line As String

            reportListBox.Items.Add(NameHead.PadRight(20) & BonusHead.PadLeft(8))

            For x As Integer = 0 To salespeople.GetUpperBound(0)
                line = salespeople(x).PadRight(20) & bonuses(x).ToString("NO").PadLeft(8)
                reportListBox.Items.Add(line)
            Next x
        Else
            MessageBox.Show("Invalid password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
