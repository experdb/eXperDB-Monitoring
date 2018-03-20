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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserConfig))
        Me.tlpSvrChk = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblAdminOldPassword = New eXperDB.BaseControls.Label()
        Me.txtAdminOldPassword = New eXperDB.BaseControls.TextBox()
        Me.txtAdminNewPassword = New eXperDB.BaseControls.TextBox()
        Me.txtAdminRepeatPassword = New eXperDB.BaseControls.TextBox()
        Me.lblAdminNewPassword = New eXperDB.BaseControls.Label()
        Me.lblAdminRepeatPassword = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlB = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlB.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.DarkGray
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpSvrChk.Controls.Add(Me.lblAdminOldPassword, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtAdminOldPassword, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtAdminNewPassword, 2, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtAdminRepeatPassword, 2, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblAdminNewPassword, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.lblAdminRepeatPassword, 1, 3)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 53)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 5
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(377, 191)
        Me.tlpSvrChk.TabIndex = 11
        '
        'lblAdminOldPassword
        '
        Me.lblAdminOldPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAdminOldPassword.FixedHeight = False
        Me.lblAdminOldPassword.FixedWidth = False
        Me.lblAdminOldPassword.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAdminOldPassword.ForeColor = System.Drawing.Color.White
        Me.lblAdminOldPassword.Location = New System.Drawing.Point(47, 40)
        Me.lblAdminOldPassword.Name = "lblAdminOldPassword"
        Me.lblAdminOldPassword.Size = New System.Drawing.Size(121, 20)
        Me.lblAdminOldPassword.TabIndex = 0
        Me.lblAdminOldPassword.Text = "F006"
        Me.lblAdminOldPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtAdminOldPassword
        '
        Me.txtAdminOldPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtAdminOldPassword.code = False
        Me.txtAdminOldPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAdminOldPassword.FixedWidth = False
        Me.txtAdminOldPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAdminOldPassword.impossibleinput = ""
        Me.txtAdminOldPassword.Location = New System.Drawing.Point(174, 36)
        Me.txtAdminOldPassword.Name = "txtAdminOldPassword"
        Me.txtAdminOldPassword.Necessary = True
        Me.txtAdminOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminOldPassword.PossibleInput = ""
        Me.txtAdminOldPassword.Prefix = ""
        Me.txtAdminOldPassword.Size = New System.Drawing.Size(150, 21)
        Me.txtAdminOldPassword.StatusTip = ""
        Me.txtAdminOldPassword.TabIndex = 1
        Me.txtAdminOldPassword.Value = ""
        '
        'txtAdminNewPassword
        '
        Me.txtAdminNewPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtAdminNewPassword.code = False
        Me.txtAdminNewPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAdminNewPassword.FixedWidth = False
        Me.txtAdminNewPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAdminNewPassword.impossibleinput = ""
        Me.txtAdminNewPassword.Location = New System.Drawing.Point(174, 76)
        Me.txtAdminNewPassword.Name = "txtAdminNewPassword"
        Me.txtAdminNewPassword.Necessary = True
        Me.txtAdminNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminNewPassword.PossibleInput = ""
        Me.txtAdminNewPassword.Prefix = ""
        Me.txtAdminNewPassword.Size = New System.Drawing.Size(150, 21)
        Me.txtAdminNewPassword.StatusTip = ""
        Me.txtAdminNewPassword.TabIndex = 3
        Me.txtAdminNewPassword.Value = ""
        '
        'txtAdminRepeatPassword
        '
        Me.txtAdminRepeatPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtAdminRepeatPassword.code = False
        Me.txtAdminRepeatPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAdminRepeatPassword.FixedWidth = False
        Me.txtAdminRepeatPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAdminRepeatPassword.impossibleinput = ""
        Me.txtAdminRepeatPassword.Location = New System.Drawing.Point(174, 116)
        Me.txtAdminRepeatPassword.Name = "txtAdminRepeatPassword"
        Me.txtAdminRepeatPassword.Necessary = True
        Me.txtAdminRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminRepeatPassword.PossibleInput = ""
        Me.txtAdminRepeatPassword.Prefix = ""
        Me.txtAdminRepeatPassword.Size = New System.Drawing.Size(150, 21)
        Me.txtAdminRepeatPassword.StatusTip = ""
        Me.txtAdminRepeatPassword.TabIndex = 5
        Me.txtAdminRepeatPassword.Value = ""
        '
        'lblAdminNewPassword
        '
        Me.lblAdminNewPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAdminNewPassword.FixedHeight = False
        Me.lblAdminNewPassword.FixedWidth = False
        Me.lblAdminNewPassword.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAdminNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblAdminNewPassword.Location = New System.Drawing.Point(47, 80)
        Me.lblAdminNewPassword.Name = "lblAdminNewPassword"
        Me.lblAdminNewPassword.Size = New System.Drawing.Size(121, 20)
        Me.lblAdminNewPassword.TabIndex = 2
        Me.lblAdminNewPassword.Text = "F007"
        Me.lblAdminNewPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAdminRepeatPassword
        '
        Me.lblAdminRepeatPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAdminRepeatPassword.FixedHeight = False
        Me.lblAdminRepeatPassword.FixedWidth = False
        Me.lblAdminRepeatPassword.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAdminRepeatPassword.ForeColor = System.Drawing.Color.White
        Me.lblAdminRepeatPassword.Location = New System.Drawing.Point(47, 120)
        Me.lblAdminRepeatPassword.Name = "lblAdminRepeatPassword"
        Me.lblAdminRepeatPassword.Size = New System.Drawing.Size(121, 20)
        Me.lblAdminRepeatPassword.TabIndex = 4
        Me.lblAdminRepeatPassword.Text = "F008"
        Me.lblAdminRepeatPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(377, 50)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(331, 50)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'pnlB
        '
        Me.pnlB.ColumnCount = 2
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.Controls.Add(Me.btnAct, 0, 0)
        Me.pnlB.Controls.Add(Me.btnClose, 1, 0)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(3, 244)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.RowCount = 1
        Me.pnlB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlB.Size = New System.Drawing.Size(377, 45)
        Me.pnlB.TabIndex = 19
        '
        'btnAct
        '
        Me.btnAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAct.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.Gray
        Me.btnAct.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAct.Location = New System.Drawing.Point(75, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(110, 39)
        Me.btnAct.TabIndex = 0
        Me.btnAct.Text = "F003"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.Gray
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(191, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(110, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmUserConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(383, 292)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.pnlB)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserConfig"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Admin Password"
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSvrChk As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblAdminOldPassword As eXperDB.BaseControls.Label
    Friend WithEvents lblAdminNewPassword As eXperDB.BaseControls.Label
    Friend WithEvents lblAdminRepeatPassword As eXperDB.BaseControls.Label
    Friend WithEvents txtAdminOldPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents txtAdminNewPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents txtAdminRepeatPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
End Class
