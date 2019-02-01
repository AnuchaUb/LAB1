<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSumScore = New System.Windows.Forms.Label()
        Me.txtLabScore = New System.Windows.Forms.TextBox()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อนักศึกษา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "โปรแกรมคำนวณผลการเรียน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "คะแนนเก็บ (40)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "คะแนนสอบกลางภาค (30)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "คะแนนสอบปลายภาค (30)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "คะแนนเต็ม (100)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(126, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "เกรดที่ได้"
        '
        'lblSumScore
        '
        Me.lblSumScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSumScore.ForeColor = System.Drawing.Color.White
        Me.lblSumScore.Location = New System.Drawing.Point(255, 250)
        Me.lblSumScore.Name = "lblSumScore"
        Me.lblSumScore.Size = New System.Drawing.Size(57, 17)
        Me.lblSumScore.TabIndex = 0
        '
        'txtLabScore
        '
        Me.txtLabScore.Location = New System.Drawing.Point(161, 113)
        Me.txtLabScore.Name = "txtLabScore"
        Me.txtLabScore.Size = New System.Drawing.Size(100, 22)
        Me.txtLabScore.TabIndex = 1
        '
        'txtMidterm
        '
        Me.txtMidterm.Location = New System.Drawing.Point(195, 148)
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(100, 22)
        Me.txtMidterm.TabIndex = 1
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(195, 184)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 22)
        Me.txtFinal.TabIndex = 1
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(132, 78)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(210, 22)
        Me.txtStudentName.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(31, 244)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 59)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "คำนวณเกรด"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblGrade
        '
        Me.lblGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGrade.ForeColor = System.Drawing.Color.White
        Me.lblGrade.Location = New System.Drawing.Point(214, 286)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(57, 17)
        Me.lblGrade.TabIndex = 0
        '
        'frmPractice6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 343)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtMidterm)
        Me.Controls.Add(Me.txtLabScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblSumScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice6"
        Me.Text = "แบบฝึกปฏิบัติสัปดาห์ที่ 6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSumScore As Label
    Friend WithEvents txtLabScore As TextBox
    Friend WithEvents txtMidterm As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblGrade As Label
End Class
