' Project name:         Employee List Project
' Project purpose:      Writes employee names to a sequential
'                       access file and reads the names from
'                       the file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub employTextBox_Enter(sender As Object, e As EventArgs) Handles employTextBox.Enter
        employTextBox.SelectAll()
    End Sub

    Private Sub writeButton_Click(sender As Object, e As EventArgs) Handles writeButton.Click
        Dim outFile As IO.StreamWriter
        outFile = IO.File.AppendText("employees.txt")
        outFile.WriteLine(employTextBox.Text)
        outFile.Close()
    End Sub

    Private Sub readButton_Click(sender As Object, e As EventArgs) Handles readButton.Click

        Dim inFile As IO.StreamReader
        Dim fileName As String = "employees.txt"
        Dim employeeNames As String

        inFile = IO.File.OpenText(fileName)

        Do Until inFile.Peek = -1
            employeeNames = inFile.ReadLine
            employListBox.Items.Add(employeeNames)
        Loop
        inFile.Close()
    End Sub

End Class
