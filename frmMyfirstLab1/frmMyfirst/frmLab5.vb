Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Double
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = FormatNumber(decTotal)
    End Sub
    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Call txtPrice_TextChanged(sender, e)
    End Sub
    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        If radMember.Checked Then
            gpbPaid.Enabled = True
        Else
            gpbPaid.Enabled = False
            radPaid.Checked = True
        End If
    End Sub
    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        Call radMember_CheckedChanged(sender, e)
    End Sub

    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        Call radMember_CheckedChanged(sender, e)
    End Sub
    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        Call radMember_CheckedChanged(sender, e)
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim chk1 As String = txtProduct.Text
        Dim chk2 As Integer = Val(txtPrice.Text)
        Dim chk3 As Integer = Val(txtUnit.Text)
        If chk1 = "" Or chk2 <= 0 Or chk3 <= 0 Then
            MsgBox("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked And radPaid.Checked Then
                If decTotal < 1000 Then
                    decDiscount = 0 * decTotal
                ElseIf decTotal < 5000 Then
                    decDiscount = 0.05 * decTotal
                ElseIf decTotal < 10000 Then
                    decDiscount = 0.1 * decTotal
                ElseIf decTotal >= 10000 Then
                    decDiscount = 0.15 * decTotal
                End If
                decCredit = 0
                decNet = decTotal - decDiscount
            ElseIf radOther.Checked Then
                decDiscount = 0
                decNet = decTotal - decDiscount
                decCredit = 0
            ElseIf radCredit.Checked Then
                decDiscount = 0
                decNet = decTotal - decDiscount
                decCredit = decNet
            End If
            lblDiscount.Text = FormatNumber(decDiscount)
            lblPaid.Text = FormatNumber(decNet)
            lblCredit.Text = FormatNumber(decCredit)
        End If
    End Sub
End Class