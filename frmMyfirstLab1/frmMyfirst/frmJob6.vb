Public Class frmJob6
    Dim dblStartPrice, dblPaidPrice As Double
    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dblStartPrice = 1250000
        dblPaidPrice = dblStartPrice + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
        lblStartPrice.Text = FormatNumber(dblStartPrice)
    End Sub
    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged
        If chkCarForMe.Checked Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = FormatNumber(dblPaidPrice)
        Else
            If MsgBox("คุณต้องการยกเลิกการซื้อรถใช่หรือไม่", vbYesNo) = vbYes Then
                lblPaidPrice.Text = ""
                chkCarForMe.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkAddItem1.Checked = False
                chkAddItem2.Checked = False
                chkAddItem3.Checked = False
                chkAddItem4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""
            Else
                chkCarForMe.Checked = True


            End If
        End If
    End Sub
    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If (chkFree1.Checked) Then
            dblPaidPrice -= 25000
        Else
            dblPaidPrice += 25000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If (chkFree2.Checked) Then
            dblPaidPrice -= 15000
        Else
            dblPaidPrice += 15000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If (chkFree3.Checked) Then
            dblPaidPrice -= 35000
        Else
            dblPaidPrice += 35000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
    Private Sub chkAddItem1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddItem1.CheckedChanged
        If (chkAddItem1.Checked) Then
            dblPaidPrice += 40000
        Else
            dblPaidPrice -= 40000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
    Private Sub chkAddItem2_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddItem2.CheckedChanged
        If (chkAddItem2.Checked) Then
            dblPaidPrice += 50000
        Else
            dblPaidPrice -= 50000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
    Private Sub chkAddItem3_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddItem3.CheckedChanged
        If (chkAddItem3.Checked) Then
            dblPaidPrice += 20000
        Else
            dblPaidPrice -= 20000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
    Private Sub chkAddItem4_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddItem4.CheckedChanged
        If (chkAddItem4.Checked) Then
            dblPaidPrice += 30000
        Else
            dblPaidPrice -= 30000
        End If
        lblPaidPrice.Text = FormatNumber(dblPaidPrice)
    End Sub
End Class