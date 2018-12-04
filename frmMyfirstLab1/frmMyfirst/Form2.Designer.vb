<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblPC = New System.Windows.Forms.Label()
        Me.lblPrinter = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCommisTotal = New System.Windows.Forms.Label()
        Me.lblCommisPrinter = New System.Windows.Forms.Label()
        Me.lblCommisPC = New System.Windows.Forms.Label()
        Me.lblSalesTotal = New System.Windows.Forms.Label()
        Me.lblSalesPrinter = New System.Windows.Forms.Label()
        Me.lblSalesPC = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมในการคำนวณยอดขายสินค้า Computer และ Printer"
        '
        'lblPC
        '
        Me.lblPC.ForeColor = System.Drawing.Color.Navy
        Me.lblPC.Location = New System.Drawing.Point(12, 54)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(145, 25)
        Me.lblPC.TabIndex = 0
        Me.lblPC.Text = "Computer Acer Veriton x5 :"
        '
        'lblPrinter
        '
        Me.lblPrinter.ForeColor = System.Drawing.Color.Navy
        Me.lblPrinter.Location = New System.Drawing.Point(12, 79)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(145, 25)
        Me.lblPrinter.TabIndex = 0
        Me.lblPrinter.Text = "Printer HP M529DN :"
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(163, 51)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(93, 20)
        Me.txtPC.TabIndex = 0
        '
        'txtPrinter
        '
        Me.txtPrinter.Location = New System.Drawing.Point(163, 76)
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(93, 20)
        Me.txtPrinter.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(262, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "บาท"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(262, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "บาท"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(Me.lblCommisTotal)
        Me.GroupBox1.Controls.Add(Me.lblCommisPrinter)
        Me.GroupBox1.Controls.Add(Me.lblCommisPC)
        Me.GroupBox1.Controls.Add(Me.lblSalesTotal)
        Me.GroupBox1.Controls.Add(Me.lblSalesPrinter)
        Me.GroupBox1.Controls.Add(Me.lblSalesPC)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 238)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'lblCommisTotal
        '
        Me.lblCommisTotal.AutoSize = True
        Me.lblCommisTotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblCommisTotal.Location = New System.Drawing.Point(117, 179)
        Me.lblCommisTotal.Name = "lblCommisTotal"
        Me.lblCommisTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblCommisTotal.TabIndex = 0
        Me.lblCommisTotal.Text = "?"
        '
        'lblCommisPrinter
        '
        Me.lblCommisPrinter.AutoSize = True
        Me.lblCommisPrinter.ForeColor = System.Drawing.Color.Yellow
        Me.lblCommisPrinter.Location = New System.Drawing.Point(224, 151)
        Me.lblCommisPrinter.Name = "lblCommisPrinter"
        Me.lblCommisPrinter.Size = New System.Drawing.Size(13, 13)
        Me.lblCommisPrinter.TabIndex = 0
        Me.lblCommisPrinter.Text = "?"
        '
        'lblCommisPC
        '
        Me.lblCommisPC.AutoSize = True
        Me.lblCommisPC.ForeColor = System.Drawing.Color.Yellow
        Me.lblCommisPC.Location = New System.Drawing.Point(244, 122)
        Me.lblCommisPC.Name = "lblCommisPC"
        Me.lblCommisPC.Size = New System.Drawing.Size(13, 13)
        Me.lblCommisPC.TabIndex = 0
        Me.lblCommisPC.Text = "?"
        '
        'lblSalesTotal
        '
        Me.lblSalesTotal.AutoSize = True
        Me.lblSalesTotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblSalesTotal.Location = New System.Drawing.Point(94, 95)
        Me.lblSalesTotal.Name = "lblSalesTotal"
        Me.lblSalesTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblSalesTotal.TabIndex = 0
        Me.lblSalesTotal.Text = "?"
        '
        'lblSalesPrinter
        '
        Me.lblSalesPrinter.AutoSize = True
        Me.lblSalesPrinter.ForeColor = System.Drawing.Color.Yellow
        Me.lblSalesPrinter.Location = New System.Drawing.Point(172, 68)
        Me.lblSalesPrinter.Name = "lblSalesPrinter"
        Me.lblSalesPrinter.Size = New System.Drawing.Size(13, 13)
        Me.lblSalesPrinter.TabIndex = 0
        Me.lblSalesPrinter.Text = "?"
        '
        'lblSalesPC
        '
        Me.lblSalesPC.AutoSize = True
        Me.lblSalesPC.ForeColor = System.Drawing.Color.Yellow
        Me.lblSalesPC.Location = New System.Drawing.Point(198, 40)
        Me.lblSalesPC.Name = "lblSalesPC"
        Me.lblSalesPC.Size = New System.Drawing.Size(13, 13)
        Me.lblSalesPC.TabIndex = 0
        Me.lblSalesPC.Text = "?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ค่าคอมมิชชันรวม :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ค่าคอมมิชชัน Printer HP M529DN (10%) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ค่าคอมมิชชัน Computer Acer Veriton x5 (5%) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ยอดขายรวม :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ยอดขาย Printer HP M529DN :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ยอดขาย Computer Acer Veriton x5 :"
        '
        'btnCal
        '
        Me.btnCal.ForeColor = System.Drawing.Color.Green
        Me.btnCal.Location = New System.Drawing.Point(314, 51)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 45)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(489, 357)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPrinter)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPrinter)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents lblPrinter As Label
    Friend WithEvents txtPC As TextBox
    Friend WithEvents txtPrinter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCommisTotal As Label
    Friend WithEvents lblCommisPrinter As Label
    Friend WithEvents lblCommisPC As Label
    Friend WithEvents lblSalesTotal As Label
    Friend WithEvents lblSalesPrinter As Label
    Friend WithEvents lblSalesPC As Label
    Friend WithEvents btnCal As Button
End Class
