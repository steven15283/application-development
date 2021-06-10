' Project name:         CD Collection Project
' Project purpose:      Allows the user to add and delete list box entries
'                       Reads CD information from a sequential access file
'                       Writes CD information to a sequential access file
' Created/revised by:   <Steven Guo> on <5/5/2016>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'saves the list box information

        Dim outFile As IO.StreamWriter

        'open the file for output
        outFile = IO.File.CreateText("cds.txt")
        'write each CD in the list box
        For Each cd As String In cdsListBox.Items
            outFile.WriteLine(cd)
        Next
        outFile.Close()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fills the list box with data
        'stroed in a sequential access file

        Dim inFile As IO.StreamReader
        Dim fileName As String = "cds.txt"
        Dim cdInfo As String

        'verify taht the file exists
        If IO.File.Exists(fileName) Then
            'open the file for input
            inFile = IO.File.OpenText(fileName)
            'process loop body until end of file
            Do Until inFile.Peek = -1
                'read a  line form the file
                cdInfo = inFile.ReadLine
                'add the line to the list box
                cdsListBox.Items.Add(cdInfo)
            Loop
            inFile.Close()
            'select the first line in the list box
            cdsListBox.SelectedIndex = 0
        Else
            MessageBox.Show("Can't find the cds.txt file", "CD Collection", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        'adds CD information to the list box

        Dim inputName As String
        Dim inputArtist As String
        Dim inputPrice As String
        Dim concatenatedInfo As String
        Dim price As Double

        'get the CD information
        inputName = InputBox("CD name:", "CD Collection")
        inputArtist = InputBox("Artist:", "CD Collection")
        inputPrice = InputBox("Price:", "CD Collection")
        'format the price, then concatenate the
        'input items, using 40 characters for the
        'CD name, 25 characters fr the artist name,
        'and 5 characters for the price
        Double.TryParse(inputPrice, price)
        inputPrice = price.ToString("N2")
        concatenatedInfo = inputName.PadRight(40) & inputArtist.PadRight(25) & inputPrice.PadLeft(5)

        'addd the CD information to the list box
        cdsListBox.Items.Add(concatenatedInfo)
    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        'removes the selected CD from the list box

        Dim index As Integer = cdsListBox.SelectedIndex

        If index <> -1 Then
            cdsListBox.Items.RemoveAt(index)
        End If
    End Sub
End Class
