Public Class frmmidterm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sumCake, getAmount, Price, Discount, Total As Decimal
        If TextBox1.Text.Trim = "" Then
            MsgBox("DDD")
        Else
            getAmount = Val(TextBox1.Text)
            If RadioButton1.Checked = True Then
                Price = 150
            ElseIf RadioButton2.Checked = True Then
                Price = 220
            ElseIf RadioButton3.Checked = True Then
                Price = 350.2
            ElseIf RadioButton4.Checked = True Then
                Price = 400
            ElseIf RadioButton5.Checked = True Then
                Price = 500
            End If
            sumCake = Price * getAmount
            If CheckBox1.Checked = True Then
                Discount = (sumCake * (10 / 100))
            Else
                Discount = 0
            End If
            Total = sumCake - Discount
            Label1.Text = Price.ToString("#,###.##")
            Label2.Text = sumCake.ToString("#,###.##")
            Label3.Text = Discount.ToString("#,###.##")
            Label4.Text = Total.ToString("#,###.##")
        End If
    End Sub
End Class