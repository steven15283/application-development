' Project name:         ReDim Project
' Project purpose:      Displays the contents of the elements stored in an array. 
'                       The number of elements can change while the application is running.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private sales(0) As Integer

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the sales amounts stored in an array

        Dim inputSales As String
        Dim salesAmount As Integer
        Dim subscript As Integer

        ' get a sales amount
        inputSales = InputBox("Enter a sales amount. Click Cancel to end.", "ReDim")
        Do While inputSales <> String.Empty
            Integer.TryParse(inputSales, salesAmount)
            ' store the sales amount in the array
            sales(subscript) = salesAmount
            subscript += 1
            ' get the next sales amount
            inputSales = InputBox("Enter a sales amount. Click Cancel to end.", "ReDim")
        Loop

        ' display the sales amounts
        salesListBox.Items.Clear()
        For Each element As Integer In sales
            salesListBox.Items.Add(element)
        Next element

    End Sub
End Class
