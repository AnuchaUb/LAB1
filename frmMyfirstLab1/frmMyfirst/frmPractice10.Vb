Public Class frmPractice10
    Dim decScore(9), i As Decimal
    Dim decAvg As Decimal

    Private Sub frmPractice10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 9
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
    End Sub
    Private Sub showData()
        lstData.Items.Clear()
        For i = 0 To decScore.Length - 1
            lstData.Items.Add(decScore(i))
        Next
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If Not IsNumeric(txtInput.Text) Then
            MsgBox("กรุณาใส่ค่าเฉพาะตัวเลข")
        Else
            decScore(cboIndex.SelectedIndex) = Val(txtInput.Text)
            showData()
            lblAvg.Text = Str(getAvg())
        End If
        txtInput.Clear()
        txtInput.Focus()
    End Sub

    Private Function getAvg() As Decimal
        Dim decTotal As Decimal = 0
        For i = 0 To decScore.Length - 1
            decTotal += decScore(i)
        Next
        decAvg = decTotal / decScore.Length
        Return decAvg
    End Function
End Class