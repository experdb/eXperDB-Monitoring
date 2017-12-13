<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgbox))
        Me.lblMessage = New eXperDB.BaseControls.Label()
        Me.Panel4 = New eXperDB.BaseControls.Panel()
        Me.pnl1 = New eXperDB.BaseControls.Panel()
        Me.btn1 = New eXperDB.BaseControls.Button()
        Me.pnl2 = New eXperDB.BaseControls.Panel()
        Me.btn2 = New eXperDB.BaseControls.Button()
        Me.pnl3 = New eXperDB.BaseControls.Panel()
        Me.btn3 = New eXperDB.BaseControls.Button()
        Me.FormMovePanel2 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox2 = New eXperDB.Controls.FormControlBox()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.Panel4.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl3.SuspendLayout()
        Me.FormMovePanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.FixedHeight = False
        Me.lblMessage.FixedWidth = False
        Me.lblMessage.Font = New System.Drawing.Font("Gulim", 13.0!)
        Me.lblMessage.ForeColor = System.Drawing.Color.Gray
        Me.lblMessage.Location = New System.Drawing.Point(0, 31)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMessage.Size = New System.Drawing.Size(619, 170)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pnl1)
        Me.Panel4.Controls.Add(Me.pnl2)
        Me.Panel4.Controls.Add(Me.pnl3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 201)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(619, 35)
        Me.Panel4.TabIndex = 7
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.btn1)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl1.Location = New System.Drawing.Point(313, 0)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(102, 35)
        Me.pnl1.TabIndex = 5
        '
        'btn1
        '
        Me.btn1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn1.FixedHeight = False
        Me.btn1.FixedWidth = False
        Me.btn1.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn1.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn1.Location = New System.Drawing.Point(0, 0)
        Me.btn1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Radius = 10
        Me.btn1.Size = New System.Drawing.Size(102, 35)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "btn1"
        Me.btn1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1.UseRound = True
        Me.btn1.UseVisualStyleBackColor = True
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.btn2)
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl2.Location = New System.Drawing.Point(415, 0)
        Me.pnl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(102, 35)
        Me.pnl2.TabIndex = 6
        '
        'btn2
        '
        Me.btn2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn2.FixedHeight = False
        Me.btn2.FixedWidth = False
        Me.btn2.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn2.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn2.Location = New System.Drawing.Point(0, 0)
        Me.btn2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn2.Name = "btn2"
        Me.btn2.Radius = 10
        Me.btn2.Size = New System.Drawing.Size(102, 35)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "btn2"
        Me.btn2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn2.UseRound = True
        Me.btn2.UseVisualStyleBackColor = True
        '
        'pnl3
        '
        Me.pnl3.Controls.Add(Me.btn3)
        Me.pnl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl3.Location = New System.Drawing.Point(517, 0)
        Me.pnl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(102, 35)
        Me.pnl3.TabIndex = 6
        '
        'btn3
        '
        Me.btn3.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn3.FixedHeight = False
        Me.btn3.FixedWidth = False
        Me.btn3.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn3.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn3.Location = New System.Drawing.Point(0, 0)
        Me.btn3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn3.Name = "btn3"
        Me.btn3.Radius = 10
        Me.btn3.Size = New System.Drawing.Size(102, 35)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "btn3"
        Me.btn3.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn3.UseRound = True
        Me.btn3.UseVisualStyleBackColor = True
        '
        'FormMovePanel2
        '
        Me.FormMovePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel2.Controls.Add(Me.FormControlBox2)
        Me.FormMovePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel2.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel2.Location = New System.Drawing.Point(0, 0)
        Me.FormMovePanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel2.Name = "FormMovePanel2"
        Me.FormMovePanel2.Size = New System.Drawing.Size(619, 31)
        Me.FormMovePanel2.TabIndex = 8
        Me.FormMovePanel2.Text = "eXperDB-Monitoring Agent"
        '
        'FormControlBox2
        '
        Me.FormControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox2.CloseBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox2.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox2.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox2.isCritical = True
        Me.FormControlBox2.isLock = False
        Me.FormControlBox2.isPower = True
        Me.FormControlBox2.isRotation = True
        Me.FormControlBox2.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox2.Location = New System.Drawing.Point(594, 0)
        Me.FormControlBox2.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox2.MaxBox = New System.Drawing.Rectangle(-21, 1, 20, 20)
        Me.FormControlBox2.MinBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Name = "FormControlBox2"
        Me.FormControlBox2.PowerBox = New System.Drawing.Rectangle(-65, 1, 20, 20)
        Me.FormControlBox2.RotationBox = New System.Drawing.Rectangle(-43, 1, 20, 20)
        Me.FormControlBox2.ShowRectCnt = 1
        Me.FormControlBox2.Size = New System.Drawing.Size(23, 22)
        Me.FormControlBox2.TabIndex = 1
        Me.FormControlBox2.Text = "FormControlBox2"
        Me.FormControlBox2.UseConfigBox = False
        Me.FormControlBox2.UseCriticalBox = False
        Me.FormControlBox2.UseDualBox = False
        Me.FormControlBox2.UseLockBox = False
        Me.FormControlBox2.UseMaxBox = True
        Me.FormControlBox2.UseMinBox = False
        Me.FormControlBox2.UsePowerBox = True
        Me.FormControlBox2.UseRotationBox = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Controls.Add(Me.FormMovePanel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 238)
        Me.Panel1.TabIndex = 9
        '
        'frmMsgbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(627, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMsgbox"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMsgbox"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel4.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.pnl3.ResumeLayout(False)
        Me.FormMovePanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn1 As eXperDB.BaseControls.Button
    Friend WithEvents btn2 As eXperDB.BaseControls.Button
    Friend WithEvents btn3 As eXperDB.BaseControls.Button
    Friend WithEvents Panel4 As eXperDB.BaseControls.Panel
    Friend WithEvents pnl1 As eXperDB.BaseControls.Panel
    Friend WithEvents pnl2 As eXperDB.BaseControls.Panel
    Friend WithEvents pnl3 As eXperDB.BaseControls.Panel
    Friend WithEvents lblMessage As eXperDB.BaseControls.Label
    Friend WithEvents FormMovePanel2 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox2 As eXperDB.Controls.FormControlBox
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
End Class
