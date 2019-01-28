<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgres
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CircularProgressControl1 = New ProgressControl.CircularProgressControl()
        Me.pnlProgres = New System.Windows.Forms.Panel()
        Me.lblProgresText = New eXperDB.BaseControls.Label()
        Me.pnlProgres.SuspendLayout
        Me.SuspendLayout
        '
        'CircularProgressControl1
        '
        Me.CircularProgressControl1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressControl1.Interval = 60
        Me.CircularProgressControl1.Location = New System.Drawing.Point(502, 152)
        Me.CircularProgressControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CircularProgressControl1.MinimumSize = New System.Drawing.Size(24, 22)
        Me.CircularProgressControl1.Name = "CircularProgressControl1"
        Me.CircularProgressControl1.Rotation = ProgressControl.CircularProgressControl.Direction.CLOCKWISE
        Me.CircularProgressControl1.Size = New System.Drawing.Size(148, 127)
        Me.CircularProgressControl1.StartAngle = 270
        Me.CircularProgressControl1.TabIndex = 11
        Me.CircularProgressControl1.TickColor = System.Drawing.Color.FromArgb(CType(CType(232,Byte),Integer), CType(CType(232,Byte),Integer), CType(CType(244,Byte),Integer))
        '
        'pnlProgres
        '
        Me.pnlProgres.AutoSize = True
        Me.pnlProgres.BackColor = System.Drawing.Color.Black
        Me.pnlProgres.Controls.Add(Me.lblProgresText)
        Me.pnlProgres.Controls.Add(Me.CircularProgressControl1)
        Me.pnlProgres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProgres.Location = New System.Drawing.Point(0, 0)
        Me.pnlProgres.Name = "pnlProgres"
        Me.pnlProgres.Size = New System.Drawing.Size(1181, 661)
        Me.pnlProgres.TabIndex = 0
        Me.pnlProgres.Visible = False
        '
        'lblProgresText
        '
        Me.lblProgresText.BackColor = System.Drawing.Color.Transparent
        Me.lblProgresText.FixedHeight = False
        Me.lblProgresText.FixedWidth = False
        Me.lblProgresText.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblProgresText.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblProgresText.Location = New System.Drawing.Point(301, 281)
        Me.lblProgresText.Name = "lblProgresText"
        Me.lblProgresText.Size = New System.Drawing.Size(554, 21)
        Me.lblProgresText.TabIndex = 12
        Me.lblProgresText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProgres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1181, 661)
        Me.Controls.Add(Me.pnlProgres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProgres"
        Me.Opacity = 0.5R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmWarning"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.pnlProgres.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Private WithEvents CircularProgressControl1 As ProgressControl.CircularProgressControl
    Friend WithEvents pnlProgres As System.Windows.Forms.Panel
    Friend WithEvents lblProgresText As eXperDB.BaseControls.Label
End Class
