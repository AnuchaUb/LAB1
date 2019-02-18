<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmidterm
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
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblM = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radTypeB = New System.Windows.Forms.RadioButton()
        Me.radTypeA = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalPlace = New System.Windows.Forms.Label()
        Me.lblTotalFunction = New System.Windows.Forms.Label()
        Me.lblTotalEmployee = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(168, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณค่าใช้จ่ายในการจัดการฟาร์มเกษตรอัฉริยะ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ความกว้าง :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(31, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ความยาว :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(120, 51)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(78, 39)
        Me.txtW.TabIndex = 0
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(120, 100)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(78, 39)
        Me.txtH.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(212, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เมตร"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(212, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 33)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เมตร"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblM)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtH)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtW)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 216)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กรุณากรอกขนาดของฟาร์มที่ต้องการ"
        '
        'lblM
        '
        Me.lblM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblM.Location = New System.Drawing.Point(128, 158)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(187, 33)
        Me.lblM.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 33)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ขนาดทั้งหมด : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radTypeB)
        Me.GroupBox2.Controls.Add(Me.radTypeA)
        Me.GroupBox2.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 139)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ประเภทของฟาร์ม"
        '
        'radTypeB
        '
        Me.radTypeB.AutoSize = True
        Me.radTypeB.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radTypeB.Location = New System.Drawing.Point(6, 81)
        Me.radTypeB.Name = "radTypeB"
        Me.radTypeB.Size = New System.Drawing.Size(267, 37)
        Me.radTypeB.TabIndex = 1
        Me.radTypeB.TabStop = True
        Me.radTypeB.Text = "ฟาร์มปลอดภัย   30 บาท/ตารางเมตร"
        Me.radTypeB.UseVisualStyleBackColor = True
        '
        'radTypeA
        '
        Me.radTypeA.AutoSize = True
        Me.radTypeA.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radTypeA.Location = New System.Drawing.Point(6, 38)
        Me.radTypeA.Name = "radTypeA"
        Me.radTypeA.Size = New System.Drawing.Size(268, 37)
        Me.radTypeA.TabIndex = 0
        Me.radTypeA.TabStop = True
        Me.radTypeA.Text = "ฟาร์มปลอดเชื้อ  50 บาท/ตารางเมตร"
        Me.radTypeA.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(478, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 35)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "รายการทั้งหมด : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(406, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 33)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ค่าสร้างฟาร์ม :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(348, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 33)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ค่าสารจุลินทรีย์และปุ๋ย :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(340, 387)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 33)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ค่าจ้างคนงานดูแลฟาร์ม :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPlace
        '
        Me.lblTotalPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPlace.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalPlace.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalPlace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalPlace.Location = New System.Drawing.Point(531, 300)
        Me.lblTotalPlace.Name = "lblTotalPlace"
        Me.lblTotalPlace.Size = New System.Drawing.Size(111, 33)
        Me.lblTotalPlace.TabIndex = 0
        Me.lblTotalPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalFunction
        '
        Me.lblTotalFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalFunction.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalFunction.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalFunction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalFunction.Location = New System.Drawing.Point(531, 341)
        Me.lblTotalFunction.Name = "lblTotalFunction"
        Me.lblTotalFunction.Size = New System.Drawing.Size(111, 33)
        Me.lblTotalFunction.TabIndex = 0
        Me.lblTotalFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalEmployee
        '
        Me.lblTotalEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalEmployee.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalEmployee.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalEmployee.Location = New System.Drawing.Point(531, 387)
        Me.lblTotalEmployee.Name = "lblTotalEmployee"
        Me.lblTotalEmployee.Size = New System.Drawing.Size(111, 33)
        Me.lblTotalEmployee.TabIndex = 0
        Me.lblTotalEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotal.Location = New System.Drawing.Point(475, 429)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(167, 33)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(348, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 33)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "รวมที่ต้องชำระ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCal.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.ForeColor = System.Drawing.Color.White
        Me.btnCal.Location = New System.Drawing.Point(394, 189)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(100, 34)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(355, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(264, 35)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "- ค่าสารจุลินทรีย์และปุ๋ย 5 บาท/ตารางเมตร"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(355, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(318, 73)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "- ค่าจ้างคนงานดูแลฟาร์ม 1 คน/600ตารางเมตร 8000บาท/คน"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(500, 189)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmmidterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotalEmployee)
        Me.Controls.Add(Me.lblTotalFunction)
        Me.Controls.Add(Me.lblTotalPlace)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmidterm"
        Me.Text = "frmmidterm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtW As TextBox
    Friend WithEvents txtH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblM As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radTypeB As RadioButton
    Friend WithEvents radTypeA As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalPlace As Label
    Friend WithEvents lblTotalFunction As Label
    Friend WithEvents lblTotalEmployee As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnClear As Button
End Class
