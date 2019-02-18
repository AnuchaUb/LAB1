Public Class frmmidterm
    Dim w, h, m, decTypeFarm, i, getpeople, getcpeople As Decimal
    Dim farmfunction, totalplace, employee, total As Decimal

    Private Sub frmmidterm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtW.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 48 Or keyInt = 8 Or keyInt = 46 Then
            Exit Sub
        Else
            MsgBox("กรุณากรอกข้อมูลตัวเลข")
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtH.KeyPress
        Call txtW_KeyPress(sender, e)
    End Sub
    Private Sub txtW_TextChanged(sender As Object, e As EventArgs) Handles txtW.TextChanged
        w = Val(txtW.Text)
        h = Val(txtH.Text)
        m = w * h
        lblM.Text = m & " ตารางเมตร"
    End Sub
    Private Sub txtH_TextChanged(sender As Object, e As EventArgs) Handles txtH.TextChanged
        Call txtW_TextChanged(sender, e)
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        If radTypeA.Checked = True Then
            decTypeFarm = 50
        ElseIf radTypeB.Checked = True Then
            decTypeFarm = 30
        End If
        totalplace = m * decTypeFarm
        farmfunction = (m * 5) * 12
        getpeople = m / 600
        getcpeople = Math.Ceiling(getpeople)
        employee = (8000 * getcpeople) * 12
        total = totalplace + farmfunction + employee
        lblTotalPlace.Text = FormatNumber(totalplace)
        lblTotalFunction.Text = FormatNumber(farmfunction)
        lblTotalEmployee.Text = FormatNumber(getcpeople)
        lblTotal.Text = FormatNumber(total)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtW.Clear()
        txtH.Clear()
        w = 0
        h = 0
        lblM.Text = ""
        lblTotalPlace.Text = ""
        lblTotalFunction.Text = ""
        lblTotalEmployee.Text = ""
        lblTotal.Text = ""
    End Sub
End Class