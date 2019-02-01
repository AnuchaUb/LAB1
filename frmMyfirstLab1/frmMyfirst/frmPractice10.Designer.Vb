<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice10
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(22, 77)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(225, 212)
        Me.lstData.TabIndex = 0
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(260, 311)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 22)
        Me.txtInput.TabIndex = 1
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(366, 311)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(22, 311)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(196, 24)
        Me.cboIndex.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ค่าเฉลี่ย"
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.ForeColor = System.Drawing.Color.White
        Me.lblAvg.Location = New System.Drawing.Point(260, 114)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(184, 97)
        Me.lblAvg.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "โปรแกรมคำนวณค่าเฉลี่ยอาร์เลย์"
        '
        'frmPractice10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 386)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmPractice10"
        Me.Text = "แบบฝึกปฏิบัติสัปดาห์ที่ 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents cboIndex As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label2 As Label
End Class
