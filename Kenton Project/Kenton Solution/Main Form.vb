Public Class Form1

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim store As Integer
        Dim payroll As Decimal
        Dim storeAccumulator As Decimal
        Dim companyAccumulator As Decimal

        For stores As Integer = 1 To 3 Step 1
            For numOfpayrolls As Integer = 1 To 5 Step 
                Decimal.TryParse(InputBox("Enter payrolls for store " & stores, "Payrolls for store " & stores), payroll)
                storeAccumulator += payroll
            Next numOfpayrolls
            companyAccumulator += storeAccumulator
            storeAccumulator = 0
        Next stores
        MessageBox.Show("The company's total payroll is: " & companyAccumulator.ToString("C2"), "Total Company Payroll", MessageBoxButtons.OK)
    End Sub

End Class
