<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserConfig
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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserConfig))
        Me.FormMovePanel1 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.GroupBox1 = New eXperDB.BaseControls.GroupBox()
        Me.tlpSvrChk = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.lblAdminOldPassword = New eXperDB.BaseControls.Label()
        Me.lblAdminNewPassword = New eXperDB.BaseControls.Label()
        Me.lblAdminRepeatPassword = New eXperDB.BaseControls.Label()
        Me.txtAdminOldPassword = New eXperDB.BaseControls.TextBox()
        Me.txtAdminNewPassword = New eXperDB.BaseControls.TextBox()
        Me.txtAdminRepeatPassword = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel3 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.FormMovePanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.FormMovePanel1.Size = New System.Drawing.Size(394, 31)
        Me.FormMovePanel1.TabIndex = 9
        Me.FormMovePanel1.Text = "eXperDB-Monitoring"
        '
        'FormControlBox1
        '
        Me.FormControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox1.CloseBox = New System.Drawing.Rectangle(45, 1, 20, 20)
        Me.FormControlBox1.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox1.DualBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox1.isCritical = False
        Me.FormControlBox1.isLock = False
        Me.FormControlBox1.isPower = True
        Me.FormControlBox1.isRotation = True
        Me.FormControlBox1.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox1.Location = New System.Drawing.Point(325, 0)
        Me.FormControlBox1.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox1.MaxBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.MinBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox1.Name = "FormControlBox1"
        Me.FormControlBox1.PowerBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.RotationBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ShowRectCnt = 3
        Me.FormControlBox1.Size = New System.Drawing.Size(67, 22)
        Me.FormControlBox1.TabIndex = 1
        Me.FormControlBox1.Text = "FormControlBox1"
        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseDualBox = True
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseMaxBox = False
        Me.FormControlBox1.UseMinBox = True
        Me.FormControlBox1.UsePowerBox = False
        Me.FormControlBox1.UseRotationBox = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(394, 265)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox1.AlignString = System.Drawing.StringAlignment.Near
        Me.GroupBox1.Controls.Add(Me.tlpSvrChk)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.EdgeRound = Edges1
        Me.GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Icon = Nothing
        Me.GroupBox1.LineColor = System.Drawing.Color.DimGray
        Me.GroupBox1.LineWidth = 1
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 204)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox1.TitleGraColor = System.Drawing.Color.DimGray
        Me.GroupBox1.UseGraColor = True
        Me.GroupBox1.UseTitle = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Black
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.tlpSvrChk.Controls.Add(Me.lblAdminOldPassword, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblAdminNewPassword, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblAdminRepeatPassword, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.txtAdminOldPassword, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtAdminNewPassword, 2, 3)
        Me.tlpSvrChk.Controls.Add(Me.txtAdminRepeatPassword, 2, 5)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 21)
        Me.tlpSvrChk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 7
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(382, 180)
        Me.tlpSvrChk.TabIndex = 11
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(291, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(84, 34)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAct
        '
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAct.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAct.ForeColor = System.Drawing.Color.LightGray
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAct.Location = New System.Drawing.Point(191, 4)
        Me.btnAct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(84, 34)
        Me.btnAct.TabIndex = 7
        Me.btnAct.Text = "F003"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'lblAdminOldPassword
        '
        Me.lblAdminOldPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdminOldPassword.FixedHeight = False
        Me.lblAdminOldPassword.FixedWidth = False
        Me.lblAdminOldPassword.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblAdminOldPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAdminOldPassword.Location = New System.Drawing.Point(59, 25)
        Me.lblAdminOldPassword.Name = "lblAdminOldPassword"
        Me.lblAdminOldPassword.Size = New System.Drawing.Size(114, 25)
        Me.lblAdminOldPassword.TabIndex = 0
        Me.lblAdminOldPassword.Text = "F006"
        Me.lblAdminOldPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAdminNewPassword
        '
        Me.lblAdminNewPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdminNewPassword.FixedHeight = False
        Me.lblAdminNewPassword.FixedWidth = False
        Me.lblAdminNewPassword.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblAdminNewPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAdminNewPassword.Location = New System.Drawing.Point(59, 65)
        Me.lblAdminNewPassword.Name = "lblAdminNewPassword"
        Me.lblAdminNewPassword.Size = New System.Drawing.Size(114, 25)
        Me.lblAdminNewPassword.TabIndex = 2
        Me.lblAdminNewPassword.Text = "F007"
        Me.lblAdminNewPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAdminRepeatPassword
        '
        Me.lblAdminRepeatPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdminRepeatPassword.FixedHeight = False
        Me.lblAdminRepeatPassword.FixedWidth = False
        Me.lblAdminRepeatPassword.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblAdminRepeatPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAdminRepeatPassword.Location = New System.Drawing.Point(59, 105)
        Me.lblAdminRepeatPassword.Name = "lblAdminRepeatPassword"
        Me.lblAdminRepeatPassword.Size = New System.Drawing.Size(114, 25)
        Me.lblAdminRepeatPassword.TabIndex = 4
        Me.lblAdminRepeatPassword.Text = "F008"
        Me.lblAdminRepeatPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtAdminOldPassword
        '
        Me.txtAdminOldPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtAdminOldPassword.code = False
        Me.txtAdminOldPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAdminOldPassword.FixedWidth = False
        Me.txtAdminOldPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAdminOldPassword.impossibleinput = ""
        Me.txtAdminOldPassword.Location = New System.Drawing.Point(179, 29)
        Me.txtAdminOldPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminOldPassword.Name = "txtAdminOldPassword"
        Me.txtAdminOldPassword.Necessary = True
        Me.txtAdminOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminOldPassword.PossibleInput = ""
        Me.txtAdminOldPassword.Prefix = ""
        Me.txtAdminOldPassword.Size = New System.Drawing.Size(141, 25)
        Me.txtAdminOldPassword.StatusTip = ""
        Me.txtAdminOldPassword.TabIndex = 1
        Me.txtAdminOldPassword.Value = ""
        '
        'txtAdminNewPassword
        '
        Me.txtAdminNewPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtAdminNewPassword.code = False
        Me.txtAdminNewPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdminNewPassword.FixedWidth = False
        Me.txtAdminNewPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAdminNewPassword.impossibleinput = ""
        Me.txtAdminNewPassword.Location = New System.Drawing.Point(179, 69)
        Me.txtAdminNewPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminNewPassword.Name = "txtAdminNewPassword"
        Me.txtAdminNewPassword.Necessary = True
        Me.txtAdminNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminNewPassword.PossibleInput = ""
        Me.txtAdminNewPassword.Prefix = ""
        Me.txtAdminNewPassword.Size = New System.Drawing.Size(141, 25)
        Me.txtAdminNewPassword.StatusTip = ""
        Me.txtAdminNewPassword.TabIndex = 3
        Me.txtAdminNewPassword.Value = ""
        '
        'txtAdminRepeatPassword
        '
        Me.txtAdminRepeatPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtAdminRepeatPassword.code = False
        Me.txtAdminRepeatPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdminRepeatPassword.FixedWidth = False
        Me.txtAdminRepeatPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAdminRepeatPassword.impossibleinput = ""
        Me.txtAdminRepeatPassword.Location = New System.Drawing.Point(179, 109)
        Me.txtAdminRepeatPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminRepeatPassword.Name = "txtAdminRepeatPassword"
        Me.txtAdminRepeatPassword.Necessary = True
        Me.txtAdminRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminRepeatPassword.PossibleInput = ""
        Me.txtAdminRepeatPassword.Prefix = ""
        Me.txtAdminRepeatPassword.Size = New System.Drawing.Size(141, 25)
        Me.txtAdminRepeatPassword.StatusTip = ""
        Me.txtAdminRepeatPassword.TabIndex = 5
        Me.txtAdminRepeatPassword.Value = ""
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 213)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.2381!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(388, 49)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'frmUserConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(400, 304)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FormMovePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUserConfig"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConnection"
        Me.FormMovePanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormMovePanel1 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents GroupBox1 As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpSvrChk As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblAdminOldPassword As eXperDB.BaseControls.Label
    Friend WithEvents lblAdminNewPassword As eXperDB.BaseControls.Label
    Friend WithEvents lblAdminRepeatPassword As eXperDB.BaseControls.Label
    Friend WithEvents txtAdminOldPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents txtAdminNewPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents txtAdminRepeatPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel3 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
End Class
