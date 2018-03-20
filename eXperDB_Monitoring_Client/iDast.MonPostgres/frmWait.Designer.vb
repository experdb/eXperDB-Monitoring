<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWait
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWait))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.logEvents = New eXperDB.Controls.LogBox()
        Me.LogBox1 = New eXperDB.Controls.LogBox()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'logEvents
        '
        Me.logEvents.BackColor = System.Drawing.Color.Black
        Me.logEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logEvents.ForeColor = System.Drawing.Color.Lime
        Me.logEvents.LimitLineCount = 1000
        Me.logEvents.Location = New System.Drawing.Point(2, 2)
        Me.logEvents.Name = "logEvents"
        Me.logEvents.ReadOnly = True
        Me.logEvents.Size = New System.Drawing.Size(417, 130)
        Me.logEvents.TabIndex = 10
        Me.logEvents.Text = ""
        '
        'LogBox1
        '
        Me.LogBox1.BackColor = System.Drawing.Color.Black
        Me.LogBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogBox1.ForeColor = System.Drawing.Color.Lime
        Me.LogBox1.LimitLineCount = 1000
        Me.LogBox1.Location = New System.Drawing.Point(2, 132)
        Me.LogBox1.Name = "LogBox1"
        Me.LogBox1.ReadOnly = True
        Me.LogBox1.Size = New System.Drawing.Size(417, 23)
        Me.LogBox1.TabIndex = 11
        Me.LogBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.logEvents)
        Me.Panel1.Controls.Add(Me.LogBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(423, 159)
        Me.Panel1.TabIndex = 12
        '
        'frmWait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(423, 159)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWait"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Message"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents logEvents As eXperDB.Controls.LogBox
    Friend WithEvents LogBox1 As eXperDB.Controls.LogBox
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
End Class
