' Project name:         Greenview Project
' Project purpose:      Displays a member's monthly dues
' Created/revised by:   <Steven Guo> on <2/28/2016>

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'Calculates the monthly dues, which include'
        'a basic fee and optional additional charges'

        Const TennisChg As Integer = 20
        Const RacquetballChg As Integer = 20
        Dim monthlyDues As Integer

        Integer.TryParse(basicFeeTextBox.Text, monthlyDues)

        ' add any additional charges to the monthly dues
        If tennisCheckBox.Checked = True Then
            monthlyDues += TennisChg
        End If
        If racquetballCheckBox.Checked = True Then
            monthlyDues += RacquetballChg
        End If

        ' display the monthly dues
        duesLabel.Text = monthlyDues.ToString("C2")

    End Sub
End Class
