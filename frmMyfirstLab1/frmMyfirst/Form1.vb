Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lblSarary.Text = Val(txtSalary.Text) * 12
        lblTax.Text = Val(lblSarary.Text) * 0.05
        lblTotal.Text = Val(lblSarary.Text) - Val(lblTax.Text)
    End Sub
End Class
