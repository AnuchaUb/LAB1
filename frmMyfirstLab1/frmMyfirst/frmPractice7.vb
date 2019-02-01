Public Class frmPractice7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtAdd.Text.Trim = "" Then
            MsgBox("กรุณาใส่ข้อมูล")
        ElseIf Not IsNumeric(txtAdd.text) Then
            MsgBox("กรุณากรอกเฉพาะตัวเลข")
        Else
            lstNumber.Items.Add(txtAdd.Text)
            Call cal_sys()
        End If
        txtAdd.Clear()
        txtAdd.Focus()
    End Sub
    Private Sub cal_sys()
        Dim i, total, min, max, avg As Single
        min = lstNumber.Items(0)
        max = lstNumber.Items(0)
        For i = 0 To lstNumber.Items.Count - 1
            total += Val(lstNumber.Items(i))
            If max < Val(lstNumber.Items(i)) Then
                max = Val(lstNumber.Items(i))
            End If
            If min > Val(lstNumber.Items(i)) Then
                min = Val(lstNumber.Items(i))
            End If
        Next i
        avg = total / lstNumber.Items.Count
        lblTotal.Text = total
        lblMax.Text = max
        lblMin.Text = min
        lblAvg.Text = FormatNumber(avg)
    End Sub
End Class