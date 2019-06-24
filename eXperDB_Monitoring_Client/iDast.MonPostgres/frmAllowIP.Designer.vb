<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllowIP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllowIP))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.txtUserName = New eXperDB.BaseControls.TextBox()
        Me.lblUserName = New eXperDB.BaseControls.Label()
        Me.Label2 = New eXperDB.BaseControls.Label()
        Me.txtIP = New eXperDB.BaseControls.TextBox()
        Me.btnUser = New eXperDB.BaseControls.Button()
        Me.lblUserID = New eXperDB.BaseControls.Label()
        Me.lblIP = New eXperDB.BaseControls.Label()
        Me.txtUserID = New eXperDB.BaseControls.TextBox()
        Me.cmbCIDR = New eXperDB.BaseControls.ComboBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(415, 50)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(369, 50)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 198)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(415, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(210, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAct
        '
        Me.btnAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.Transparent
        Me.btnAct.Location = New System.Drawing.Point(130, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 4
        Me.btnAct.Text = "F140/F141"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 7
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpSvrChk.Controls.Add(Me.txtUserName, 2, 2)
        Me.tlpSvrChk.Controls.Add(Me.lblUserName, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.Label2, 3, 3)
        Me.tlpSvrChk.Controls.Add(Me.txtIP, 2, 3)
        Me.tlpSvrChk.Controls.Add(Me.btnUser, 4, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblUserID, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblIP, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.txtUserID, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.cmbCIDR, 4, 3)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 53)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 6
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(415, 145)
        Me.tlpSvrChk.TabIndex = 20
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Control
        Me.txtUserName.code = False
        Me.txtUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUserName.Enabled = False
        Me.txtUserName.FixedWidth = False
        Me.txtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserName.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtUserName.Location = New System.Drawing.Point(133, 53)
        Me.txtUserName.MaxByteLength = 30
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Necessary = False
        Me.txtUserName.PossibleInput = ""
        Me.txtUserName.Prefix = ""
        Me.txtUserName.Size = New System.Drawing.Size(114, 21)
        Me.txtUserName.StatusTip = ""
        Me.txtUserName.TabIndex = 19
        Me.txtUserName.Value = ""
        '
        'lblUserName
        '
        Me.lblUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserName.FixedHeight = False
        Me.lblUserName.FixedWidth = False
        Me.lblUserName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(13, 57)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(114, 20)
        Me.lblUserName.TabIndex = 18
        Me.lblUserName.Text = "F348"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.FixedHeight = False
        Me.Label2.FixedWidth = False
        Me.Label2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(253, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(9, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtIP.code = False
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtIP.FixedWidth = False
        Me.txtIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIP.impossibleinput = ""
        Me.txtIP.Location = New System.Drawing.Point(133, 88)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Necessary = False
        Me.txtIP.PossibleInput = "0123456789."
        Me.txtIP.Prefix = ""
        Me.txtIP.Size = New System.Drawing.Size(114, 21)
        Me.txtIP.StatusTip = ""
        Me.txtIP.TabIndex = 2
        Me.txtIP.Value = ""
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnUser.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tlpSvrChk.SetColumnSpan(Me.btnUser, 2)
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUser.FixedHeight = False
        Me.btnUser.FixedWidth = False
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnUser.LineColor = System.Drawing.Color.Transparent
        Me.btnUser.Location = New System.Drawing.Point(268, 13)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Radius = 10
        Me.btnUser.Size = New System.Drawing.Size(64, 26)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "F008"
        Me.btnUser.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnUser.UseRound = True
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'lblUserID
        '
        Me.lblUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserID.FixedHeight = False
        Me.lblUserID.FixedWidth = False
        Me.lblUserID.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(13, 22)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(114, 20)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "F347"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblIP.FixedHeight = False
        Me.lblIP.FixedWidth = False
        Me.lblIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.Location = New System.Drawing.Point(13, 92)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(114, 20)
        Me.lblIP.TabIndex = 2
        Me.lblIP.Text = "F935"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtUserID.code = False
        Me.txtUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUserID.Enabled = False
        Me.txtUserID.FixedWidth = False
        Me.txtUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserID.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtUserID.Location = New System.Drawing.Point(133, 18)
        Me.txtUserID.MaxByteLength = 16
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Necessary = False
        Me.txtUserID.PossibleInput = ""
        Me.txtUserID.Prefix = ""
        Me.txtUserID.Size = New System.Drawing.Size(114, 21)
        Me.txtUserID.StatusTip = ""
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Value = ""
        '
        'cmbCIDR
        '
        Me.cmbCIDR.BackColor = System.Drawing.SystemColors.Window
        Me.tlpSvrChk.SetColumnSpan(Me.cmbCIDR, 2)
        Me.cmbCIDR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbCIDR.FixedWidth = False
        Me.cmbCIDR.FormattingEnabled = True
        Me.cmbCIDR.Items.AddRange(New Object() {"32", "28", "24", "16"})
        Me.cmbCIDR.Location = New System.Drawing.Point(268, 89)
        Me.cmbCIDR.Name = "cmbCIDR"
        Me.cmbCIDR.Necessary = False
        Me.cmbCIDR.Size = New System.Drawing.Size(64, 20)
        Me.cmbCIDR.StatusTip = ""
        Me.cmbCIDR.TabIndex = 17
        Me.cmbCIDR.ValueText = ""
        '
        'frmAllowIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(421, 246)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAllowIP"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Allowed IP Address"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUserID As eXperDB.BaseControls.Label
    Friend WithEvents lblIP As eXperDB.BaseControls.Label
    Friend WithEvents txtUserID As eXperDB.BaseControls.TextBox
    Friend WithEvents btnUser As eXperDB.BaseControls.Button
    Friend WithEvents txtIP As eXperDB.BaseControls.TextBox
    Friend WithEvents Label2 As eXperDB.BaseControls.Label
    Friend WithEvents cmbCIDR As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblUserName As eXperDB.BaseControls.Label
    Friend WithEvents txtUserName As eXperDB.BaseControls.TextBox
End Class
