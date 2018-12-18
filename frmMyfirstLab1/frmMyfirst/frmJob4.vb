Public Class frmJob4
    Const decR_BONUS As Double = 0.2, decR_ALLOW = 0.01, decR_TAX = 0.07
    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX
        lblYearSalary.Text = dblYearSalary.ToString("#,###.##")
        lblBonus.Text = dblBonus.ToString("#,###.##")
        lblAllIncomes.Text = dblAllIncome.ToString("#,###.##")
        lblAllowance.Text = dblAllowance.ToString("#,###.##")
        lblTax.Text = dblTax.ToString("#,###.##")
    End Sub
    Private Sub radLongDate_Click(sender As Object, e As EventArgs) Handles radLongDate.Click
        lblDate.Text = Format(Now, "Long date")
    End Sub

    Private Sub radGeneralDate_Click(sender As Object, e As EventArgs) Handles radGeneralDate.Click
        lblDate.Text = Format(Now, "General date")
    End Sub

    Private Sub radShortDate_Click(sender As Object, e As EventArgs) Handles radShortDate.Click
        lblDate.Text = Format(Now, "Short date")
    End Sub
End Class