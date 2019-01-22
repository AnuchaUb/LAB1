<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice8
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYourSale = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.lblCommTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "พนักงานขาย, ยอดขาย, ค่าคอมมิชชัน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(382, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ยอดขายรวม"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(382, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ค่าคอมมิชชันรวม"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(54, 87)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(322, 196)
        Me.lstData.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(54, 290)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(129, 22)
        Me.txtName.TabIndex = 2
        '
        'txtYourSale
        '
        Me.txtYourSale.Location = New System.Drawing.Point(189, 290)
        Me.txtYourSale.Name = "txtYourSale"
        Me.txtYourSale.Size = New System.Drawing.Size(100, 22)
        Me.txtYourSale.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(301, 289)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 38)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSaleTotal.ForeColor = System.Drawing.Color.Navy
        Me.lblSaleTotal.Location = New System.Drawing.Point(382, 130)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSaleTotal.TabIndex = 0
        Me.lblSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommTotal
        '
        Me.lblCommTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCommTotal.ForeColor = System.Drawing.Color.Navy
        Me.lblCommTotal.Location = New System.Drawing.Point(382, 206)
        Me.lblCommTotal.Name = "lblCommTotal"
        Me.lblCommTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblCommTotal.TabIndex = 0
        Me.lblCommTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPractice8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 410)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtYourSale)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCommTotal)
        Me.Controls.Add(Me.lblSaleTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice8"
        Me.Text = "แบบฝึกปฏิบัติสัปดาห์ที่ 8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstData As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYourSale As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSaleTotal As Label
    Friend WithEvents lblCommTotal As Label
End Class
