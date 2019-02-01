Public Class frmLab10
    Dim decSale(4, 2) As Decimal
    Dim saleName(4) As String
    Dim intIndex, intlstdata, pSale(4), a As Integer
    Dim decSumSale As Decimal = 0

    Private Sub frmLab10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIndex.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("ไม่เป็นค่าตัวเลข", "แจ้งเตือน", MessageBoxButtons.OK)
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleA.Focus()

        Else
            a = cboIndex.SelectedIndex
            lstData.SelectedIndex = a
            lstData.Items.RemoveAt(a)
            saleName(a) = Val(txtSaleName.Text)
            decSale(a, 0) = Val(txtSaleA.Text)
            decSale(a, 1) = Val(txtSaleB.Text)
            decSale(a, 2) = Val(txtSaleC.Text)
            For i = 0 To 2
                saleName(a) = txtSaleName.Text
                decSale(a, i) = decSale(a, i)
            Next
            txtSaleName.Clear()
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleName.Focus()
            showData()
        End If
    End Sub
    Private Sub showData()
        Dim sa, sb, sc As Decimal
        lstData.Items.Clear()
        For i = 0 To cboIndex.Items.Count - 1
            lstData.Items.Add(saleName(i) & ", " & decSale(i, 0) & ", " & decSale(i, 1) & ", " & decSale(i, 2))
        Next
        For i = 0 To 4
            sa += decSale(i, 0)
            sb += decSale(i, 1)
            sc += decSale(i, 2)
        Next
        lblSumA.Text = sa
        lblSumB.Text = sb
        lblSumC.Text = sc
        decSumSale = sa + sb + sc
        lblMaxSaleAmount.Text = decSumSale

        Dim max As Decimal = decSale(0, 0) + decSale(0, 1) + decSale(0, 2)
        Dim x As Integer
        For i = 1 To cboIndex.Items.Count - 1
            If max < decSale(i, 0) + decSale(i, 1) + decSale(i, 2) Then
                x = i
            End If
            lblMaxSaleName.Text = saleName(x)
        Next

    End Sub
End Class