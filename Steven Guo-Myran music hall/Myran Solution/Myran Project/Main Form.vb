Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Const OrchestraTicketPrice As Double = 30.84
        Const MainFloorTicketPrice As Double = 34.65
        Const BalconyTicketPrice As Double = 23.83
        Dim orchestraTickets, mainfloorTickets, balconyTickets As Integer
        Dim orchestraRevenue, mainfloorRevenue, balconyRevenue, totalRevenue As Decimal
        Dim orchestraPercent, mainfloorPercent, balconyPercent As Double

        Integer.TryParse(numberOfOrchestra.Text, orchestraTickets)
        Integer.TryParse(numberOfMainFloor.Text, mainfloorTickets)
        Integer.TryParse(numberOfBalcony.Text, balconyTickets)

        orchestraRevenue = orchestraTickets * OrchestraTicketPrice
        mainfloorRevenue = mainfloorTickets * MainFloorTicketPrice
        balconyRevenue = balconyTickets * BalconyTicketPrice

        totalRevenue = orchestraRevenue + mainfloorRevenue + balconyRevenue

        orchestraPercent = orchestraRevenue / totalRevenue
        mainfloorPercent = mainfloorRevenue / totalRevenue
        balconyPercent = balconyRevenue / totalRevenue

        revenueOfOrchestra.Text = "$" & Convert.ToString(orchestraRevenue)
        revenueOfMainFloor.Text = "$" & Convert.ToString(mainfloorRevenue)
        revenueOfBalcony.Text = "$" & Convert.ToString(balconyRevenue)

        percentOfOrchestra.Text = orchestraPercent.ToString("P0")
        percentOfMainFloor.Text = mainfloorPercent.ToString("P0")
        percentOfBalcony.Text = balconyPercent.ToString("P0")

        totalRevenueLabelBox.Text = "$" & Convert.ToString(totalRevenue)

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
