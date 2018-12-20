Public Class frmPractice2
    Private Sub frmPractice2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radUs.Checked = False
        radFrench.Checked = False
        radKorea.Checked = False
    End Sub
    Private Sub radUs_Click(sender As Object, e As EventArgs) Handles radUs.Click
        lblResult.Text = Val(txtBath.Text) / 39
    End Sub
    Private Sub radFrench_Click(sender As Object, e As EventArgs) Handles radFrench.Click
        lblResult.Text = Val(txtBath.Text) / 37
    End Sub
    Private Sub radKorea_Click(sender As Object, e As EventArgs) Handles radKorea.Click
        lblResult.Text = Val(txtBath.Text) / 30
    End Sub
    Private Sub radLock_Click(sender As Object, e As EventArgs) Handles radLock.Click
        txtBath.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub radUnlock_Click(sender As Object, e As EventArgs) Handles radUnlock.Click
        txtBath.Enabled = True
        radUs.Enabled = True
        radFrench.Enabled = True
        radKorea.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class