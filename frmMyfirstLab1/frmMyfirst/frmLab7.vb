Public Class frmLab7
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub
    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If (txtAdd.Text = "") Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
    End Sub
    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim a As Integer = lstAdd.SelectedIndex
        If lstAdd.Items.Count = 0 Then
            MsgBox("ไม่มีรายการเหลืออยู่ใน ListBox")
        Else
            cboOutput.Items.Add(lstAdd.SelectedItem)
            lstAdd.Items.RemoveAt(a)
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            If lstAdd.Items.Count <> 0 Then
                If lstAdd.Items.Count <= a Then
                    lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                Else
                    lstAdd.SelectedIndex = a
                End If
            End If
        End If
    End Sub
    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstAdd.Items.Count = 0 Then
            MsgBox("ไม่มีรายการเหลืออยู่ใน ListBox")
        Else
            For Each item In lstAdd.Items
                cboOutput.Items.Add(item)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Next
            lstAdd.Items.Clear()
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If cboOutput.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลใน ComboBox")
            cboOutput.Text = ""
            lblOutput.Text = ""
        Else
            lstAdd.Items.Add(cboOutput.SelectedItem)
            cboOutput.Items.Remove(cboOutput.SelectedItem)
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        End If
    End Sub
    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลใน ComboBox")
            cboOutput.Text = ""
        Else
            For Each item In cboOutput.Items
                lstAdd.Items.Add(item)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next
            cboOutput.Items.Clear()
            cboOutput.Text = ""
            lblOutput.Text = ""
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        cboOutput.Text = ""
        txtAdd.Clear()
        lblOutput.Text = ""
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub
End Class