<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriticalCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriticalCheck))
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.FormMovePanel1 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.TableLayoutPanel2 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblPause = New eXperDB.BaseControls.Label()
        Me.cmbPauseTime = New eXperDB.BaseControls.ComboBox()
        Me.lblMsg = New eXperDB.BaseControls.Label()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FormMovePanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(328, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(94, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(228, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(94, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 172)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 39)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(425, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FormMovePanel1
        '
        Me.FormMovePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel1.Controls.Add(Me.FormControlBox1)
        Me.FormMovePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel1.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel1.Location = New System.Drawing.Point(3, 4)
        Me.FormMovePanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel1.Name = "FormMovePanel1"
        Me.FormMovePanel1.Size = New System.Drawing.Size(425, 31)
        Me.FormMovePanel1.TabIndex = 8
        Me.FormMovePanel1.Text = "F262"
        '
        'FormControlBox1
        '
        Me.FormControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox1.CloseBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox1.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox1.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox1.isCritical = False
        Me.FormControlBox1.isLock = False
        Me.FormControlBox1.isPower = False
        Me.FormControlBox1.isRotation = True
        Me.FormControlBox1.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox1.Location = New System.Drawing.Point(378, 0)
        Me.FormControlBox1.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox1.MaxBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.MinBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox1.Name = "FormControlBox1"
        Me.FormControlBox1.PowerBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.RotationBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ShowRectCnt = 2
        Me.FormControlBox1.Size = New System.Drawing.Size(45, 22)
        Me.FormControlBox1.TabIndex = 1
        Me.FormControlBox1.Text = "FormControlBox1"
        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseDualBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseMaxBox = False
        Me.FormControlBox1.UseMinBox = True
        Me.FormControlBox1.UsePowerBox = False
        Me.FormControlBox1.UseRotationBox = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblPause, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbPauseTime, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMsg, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 35)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(425, 137)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'lblPause
        '
        Me.lblPause.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPause.FixedWidth = False
        Me.lblPause.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPause.Location = New System.Drawing.Point(13, 90)
        Me.lblPause.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(186, 21)
        Me.lblPause.TabIndex = 14
        Me.lblPause.Text = "F263"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPauseTime
        '
        Me.cmbPauseTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPauseTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbPauseTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPauseTime.FixedWidth = False
        Me.cmbPauseTime.FormattingEnabled = True
        Me.cmbPauseTime.Items.AddRange(New Object() {"Not Set", "5", "30", "60", "120"})
        Me.cmbPauseTime.Location = New System.Drawing.Point(225, 91)
        Me.cmbPauseTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPauseTime.Name = "cmbPauseTime"
        Me.cmbPauseTime.Necessary = False
        Me.cmbPauseTime.Size = New System.Drawing.Size(100, 23)
        Me.cmbPauseTime.StatusTip = ""
        Me.cmbPauseTime.TabIndex = 15
        Me.cmbPauseTime.ValueText = ""
        '
        'lblMsg
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.lblMsg, 3)
        Me.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMsg.FixedHeight = False
        Me.lblMsg.FixedWidth = False
        Me.lblMsg.ForeColor = System.Drawing.Color.DarkGray
        Me.lblMsg.Location = New System.Drawing.Point(13, 20)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(398, 47)
        Me.lblMsg.TabIndex = 16
        Me.lblMsg.Text = "Label1"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCriticalCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(431, 215)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FormMovePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCriticalCheck"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConfig"
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FormMovePanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents FormMovePanel1 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblPause As eXperDB.BaseControls.Label
    Friend WithEvents cmbPauseTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblMsg As eXperDB.BaseControls.Label
End Class
