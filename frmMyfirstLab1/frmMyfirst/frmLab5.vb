Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Double
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal.ToString("#,###.##")
    End Sub
    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal.ToString("#,###.##")
    End Sub

    Private Sub radMember_Click(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

        gpbPaid.Enabled = True
    End Sub

    Private Sub radOther_Click(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

        gpbPaid.Enabled = False
        radPaid.Checked = True
    End Sub

    Private Sub radPaid_Click(sender As Object, e As EventArgs) Handles radPaid.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_Click(sender As Object, e As EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim chk1 As String = txtProduct.Text
        Dim chk2 As Integer = Val(txtPrice.Text)
        Dim chk3 As Integer = Val(txtUnit.Text)

        If chk1 = "" Or chk2 <= 0 Or chk3 <= 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked And radPaid.Checked Then
                If lblTotal.Text < 1000 Then
                    decDiscount = 0 * decTotal
                ElseIf lblTotal.Text < 5000 Then
                    decDiscount = 0.05 * decTotal
                ElseIf lblTotal.Text < 10000 Then
                    decDiscount = 0.1 * decTotal
                ElseIf lblTotal.Text > 10000 Then
                    decDiscount = 0.15 * decTotal
                End If
                decNet = decTotal - decDiscount
                decCredit = 0
                lblDiscount.Text = decDiscount.ToString("#,###")
                lblPaid.Text = decNet.ToString("#,###")
                lblCredit.Text = 0
            ElseIf radmember.Checked And radCredit.Checked Or radOther.Checked Then
                decDiscount = 0
                decNet = decTotal - decDiscount
                decCredit = decNet
                lblDiscount.Text = 0
                lblPaid.Text = decNet.ToString("#,###")
                lblCredit.Text = decCredit.ToString("#,###")
            End If
        End If
    End Sub
End Class