<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonBase))
        Me.tmLock = New System.Windows.Forms.Timer(Me.components)
        Me.FormMovePanel1 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.FormMovePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmLock
        '
        Me.tmLock.Interval = 300000
        '
        'FormMovePanel1
        '
        Me.FormMovePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel1.Controls.Add(Me.FormControlBox1)
        Me.FormMovePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel1.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormMovePanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel1.Location = New System.Drawing.Point(2, 2)
        Me.FormMovePanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel1.Name = "FormMovePanel1"
        Me.FormMovePanel1.Size = New System.Drawing.Size(1914, 27)
        Me.FormMovePanel1.TabIndex = 7
        Me.FormMovePanel1.Text = "eXperDB-Monitoring"
        '
        'FormControlBox1
        '
        Me.FormControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox1.CloseBox = New System.Drawing.Rectangle(177, 1, 20, 20)
        Me.FormControlBox1.ConfigBox = New System.Drawing.Rectangle(89, 1, 20, 20)
        Me.FormControlBox1.CriticalBox = New System.Drawing.Rectangle(45, 1, 20, 20)
        Me.FormControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox1.DualBox = New System.Drawing.Rectangle(155, 1, 20, 20)
        Me.FormControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox1.isCritical = True
        Me.FormControlBox1.isLock = False
        Me.FormControlBox1.isPower = True
        Me.FormControlBox1.isRotation = False
        Me.FormControlBox1.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox1.Location = New System.Drawing.Point(1713, 0)
        Me.FormControlBox1.LockBox = New System.Drawing.Rectangle(67, 1, 20, 20)
        Me.FormControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox1.MaxBox = New System.Drawing.Rectangle(133, 1, 20, 20)
        Me.FormControlBox1.MinBox = New System.Drawing.Rectangle(111, 1, 20, 20)
        Me.FormControlBox1.Name = "FormControlBox1"
        Me.FormControlBox1.PowerBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox1.RotationBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ShowRectCnt = 9
        Me.FormControlBox1.Size = New System.Drawing.Size(199, 22)
        Me.FormControlBox1.TabIndex = 1
        Me.FormControlBox1.Text = "FormControlBox1"
        Me.FormControlBox1.UseConfigBox = True
        Me.FormControlBox1.UseCriticalBox = True
        Me.FormControlBox1.UseDualBox = True
        Me.FormControlBox1.UseLockBox = True
        Me.FormControlBox1.UseMaxBox = True
        Me.FormControlBox1.UseMinBox = True
        Me.FormControlBox1.UsePowerBox = True
        Me.FormControlBox1.UseRotationBox = False
        '
        'frmMonBase
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1918, 1078)
        Me.ControlBox = False
        Me.Controls.Add(Me.FormMovePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonBase"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FormMovePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents FormMovePanel1 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents tmLock As System.Windows.Forms.Timer
End Class
