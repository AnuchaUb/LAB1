Public Class frmPractice8
    Dim saleTotal, commTolal As Decimal
    Private Function getCommission(ByVal a As Decimal) As Decimal
        If a <= 5000 Then
            Return 0
        ElseIf a <= 10000 Then
            Return a * 0.025
        ElseIf a <= 50000 Then
            Return a * 0.05
        Else
            Return a * 0.1
        End If
    End Function
    Private Sub startUp()
        txtName.Clear()
        txtYourSale.Clear()
        txtName.Focus()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim commission As Decimal
        If txtName.Text.Trim = "" Or txtYourSale.Text.Trim = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "", MessageBoxButtons.OK)
            txtName.Focus()
            Exit Sub
        Else
            commission = getCommission(Val(txtYourSale.Text))
            saleTotal += CDec(txtYourSale.Text)
            commTolal += commission
            lstData.Items.Add(txtName.Text & "," & txtYourSale.Text & "," & commission)
            lblSaleTotal.Text = FormatNumber(saleTotal)
            lblCommTotal.Text = FormatNumber(commTolal)
            Call startUp()

        End If
    End Sub

    Private Sub txtYourSale_KeyPress(ByVal sander As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYourSale.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 48 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub
End Class