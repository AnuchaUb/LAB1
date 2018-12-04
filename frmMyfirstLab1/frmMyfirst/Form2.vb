Public Class Form2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim salesPC, salesPrinter, salesTotal, comPC, comPrinter, comTotal As Double

        salesPC = Val(txtPC.Text)
        salesPrinter = Val(txtPrinter.Text)
        salesTotal = salesPC + salesPrinter
        lblSalesPC.Text = salesPC.ToString("#,###") + " บาท"
        lblSalesPrinter.Text = salesPrinter.ToString("#,###") + " บาท"
        lblSalesTotal.Text = salesTotal.ToString("#,###") + " บาท"

        comPC = salesPC * (5 / 100)
        comPrinter = salesPrinter * (10 / 100)
        comTotal = comPC + comPrinter
        lblCommisPC.Text = comPC.ToString("#,###") + " บาท"
        lblCommisPrinter.Text = comPrinter.ToString("#,###") + " บาท"
        lblCommisTotal.Text = comTotal.ToString("#,###") + " บาท"


    End Sub
End Class