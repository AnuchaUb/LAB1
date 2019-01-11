<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOldTotalScore = New System.Windows.Forms.Label()
        Me.lblOldTotalCredit = New System.Windows.Forms.Label()
        Me.lblOldTotalGPA = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstSubject
        '
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.ItemHeight = 16
        Me.lstSubject.Location = New System.Drawing.Point(35, 71)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(126, 212)
        Me.lstSubject.TabIndex = 0
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 16
        Me.lstScore.Location = New System.Drawing.Point(167, 71)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(126, 212)
        Me.lstScore.TabIndex = 0
        '
        'lstCredit
        '
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.ItemHeight = 16
        Me.lstCredit.Location = New System.Drawing.Point(299, 71)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(126, 212)
        Me.lstCredit.TabIndex = 0
        '
        'lstGrade
        '
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.ItemHeight = 16
        Me.lstGrade.Location = New System.Drawing.Point(431, 71)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(126, 212)
        Me.lstGrade.TabIndex = 0
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(35, 290)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(126, 22)
        Me.txtSubject.TabIndex = 1
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(167, 290)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(126, 22)
        Me.txtScore.TabIndex = 1
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(299, 290)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(126, 22)
        Me.txtCredit.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(431, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(63, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(494, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "คะแนนสะสมก่อนหน้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "หน่วยกิตสะสม"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เกรดเฉลี่ยสะสม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.BackColor = System.Drawing.Color.Navy
        Me.lblOldTotalScore.ForeColor = System.Drawing.Color.White
        Me.lblOldTotalScore.Location = New System.Drawing.Point(185, 330)
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(63, 17)
        Me.lblOldTotalScore.TabIndex = 3
        Me.lblOldTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOldTotalCredit
        '
        Me.lblOldTotalCredit.BackColor = System.Drawing.Color.Navy
        Me.lblOldTotalCredit.ForeColor = System.Drawing.Color.White
        Me.lblOldTotalCredit.Location = New System.Drawing.Point(154, 363)
        Me.lblOldTotalCredit.Name = "lblOldTotalCredit"
        Me.lblOldTotalCredit.Size = New System.Drawing.Size(69, 17)
        Me.lblOldTotalCredit.TabIndex = 3
        Me.lblOldTotalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOldTotalGPA
        '
        Me.lblOldTotalGPA.BackColor = System.Drawing.Color.Navy
        Me.lblOldTotalGPA.ForeColor = System.Drawing.Color.White
        Me.lblOldTotalGPA.Location = New System.Drawing.Point(406, 330)
        Me.lblOldTotalGPA.Name = "lblOldTotalGPA"
        Me.lblOldTotalGPA.Size = New System.Drawing.Size(60, 17)
        Me.lblOldTotalGPA.TabIndex = 3
        Me.lblOldTotalGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BackColor = System.Drawing.Color.Transparent
        Me.lblNewGPA.ForeColor = System.Drawing.Color.Black
        Me.lblNewGPA.Location = New System.Drawing.Point(224, 394)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(69, 17)
        Me.lblNewGPA.TabIndex = 3
        Me.lblNewGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Navy
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "วิชา"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Navy
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(168, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "คะแนนสอบ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Navy
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(299, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "หน่วยกิต"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(431, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "เกรด"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 455)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldTotalGPA)
        Me.Controls.Add(Me.lblOldTotalCredit)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Name = "frmLab8"
        Me.Text = "Lab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSubject As ListBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOldTotalScore As Label
    Friend WithEvents lblOldTotalCredit As Label
    Friend WithEvents lblOldTotalGPA As Label
    Friend WithEvents lblNewGPA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
