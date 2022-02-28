<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServerInfo))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.btnApplyIP = New eXperDB.BaseControls.Button()
        Me.txtSvrPort = New eXperDB.BaseControls.TextBox()
        Me.txtSvrIP = New eXperDB.BaseControls.TextBox()
        Me.lblSvrPort = New eXperDB.BaseControls.Label()
        Me.lblSvrIP = New eXperDB.BaseControls.Label()
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(442, 50)
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
        Me.StatusLabel.Size = New System.Drawing.Size(396, 50)
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
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 165)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(442, 45)
        Me.TableLayoutPanel3.TabIndex = 17
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
        Me.btnAct.Location = New System.Drawing.Point(144, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 7
        Me.btnAct.Text = "F003"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = False
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
        Me.btnClose.Location = New System.Drawing.Point(224, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.tlpSvrChk.Controls.Add(Me.btnApplyIP, 3, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtSvrPort, 2, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtSvrIP, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblSvrPort, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.lblSvrIP, 1, 1)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 53)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 4
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(442, 112)
        Me.tlpSvrChk.TabIndex = 20
        '
        'btnApplyIP
        '
        Me.btnApplyIP.BackColor = System.Drawing.Color.Transparent
        Me.btnApplyIP.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnApplyIP.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnApplyIP.FixedHeight = False
        Me.btnApplyIP.FixedWidth = False
        Me.btnApplyIP.ForeColor = System.Drawing.Color.White
        Me.btnApplyIP.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnApplyIP.LineColor = System.Drawing.Color.Transparent
        Me.btnApplyIP.Location = New System.Drawing.Point(308, 23)
        Me.btnApplyIP.Name = "btnApplyIP"
        Me.btnApplyIP.Radius = 10
        Me.btnApplyIP.Size = New System.Drawing.Size(119, 29)
        Me.btnApplyIP.TabIndex = 17
        Me.btnApplyIP.Text = "F003"
        Me.btnApplyIP.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnApplyIP.UseRound = True
        Me.btnApplyIP.UseVisualStyleBackColor = False
        '
        'txtSvrPort
        '
        Me.txtSvrPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrPort.code = False
        Me.txtSvrPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSvrPort.FixedWidth = False
        Me.txtSvrPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrPort.impossibleinput = ""
        Me.txtSvrPort.Location = New System.Drawing.Point(148, 58)
        Me.txtSvrPort.MaxLength = 5
        Me.txtSvrPort.Name = "txtSvrPort"
        Me.txtSvrPort.Necessary = False
        Me.txtSvrPort.PossibleInput = "0123456789"
        Me.txtSvrPort.Prefix = ""
        Me.txtSvrPort.Size = New System.Drawing.Size(154, 21)
        Me.txtSvrPort.StatusTip = ""
        Me.txtSvrPort.TabIndex = 2
        Me.txtSvrPort.Value = ""
        '
        'txtSvrIP
        '
        Me.txtSvrIP.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrIP.code = False
        Me.txtSvrIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSvrIP.FixedWidth = False
        Me.txtSvrIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrIP.impossibleinput = ""
        Me.txtSvrIP.Location = New System.Drawing.Point(148, 23)
        Me.txtSvrIP.MaxByteLength = 128
        Me.txtSvrIP.MaxLength = 128
        Me.txtSvrIP.Name = "txtSvrIP"
        Me.txtSvrIP.Necessary = False
        Me.txtSvrIP.PossibleInput = ""
        Me.txtSvrIP.Prefix = ""
        Me.txtSvrIP.Size = New System.Drawing.Size(154, 21)
        Me.txtSvrIP.StatusTip = ""
        Me.txtSvrIP.TabIndex = 1
        Me.txtSvrIP.Value = ""
        '
        'lblSvrPort
        '
        Me.lblSvrPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrPort.FixedHeight = False
        Me.lblSvrPort.FixedWidth = False
        Me.lblSvrPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrPort.ForeColor = System.Drawing.Color.White
        Me.lblSvrPort.LineSpacing = 0.0!
        Me.lblSvrPort.Location = New System.Drawing.Point(13, 55)
        Me.lblSvrPort.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSvrPort.Name = "lblSvrPort"
        Me.lblSvrPort.Size = New System.Drawing.Size(129, 32)
        Me.lblSvrPort.TabIndex = 16
        Me.lblSvrPort.Text = "F978"
        Me.lblSvrPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSvrIP
        '
        Me.lblSvrIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrIP.FixedHeight = False
        Me.lblSvrIP.FixedWidth = False
        Me.lblSvrIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrIP.ForeColor = System.Drawing.Color.White
        Me.lblSvrIP.LineSpacing = 0.0!
        Me.lblSvrIP.Location = New System.Drawing.Point(13, 20)
        Me.lblSvrIP.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSvrIP.Name = "lblSvrIP"
        Me.lblSvrIP.Size = New System.Drawing.Size(129, 32)
        Me.lblSvrIP.TabIndex = 0
        Me.lblSvrIP.Text = "F977"
        Me.lblSvrIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmServerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 213)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServerInfo"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Server Information"
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
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSvrIP As eXperDB.BaseControls.Label
    Friend WithEvents lblSvrPort As eXperDB.BaseControls.Label
    Friend WithEvents txtSvrIP As eXperDB.BaseControls.TextBox
    Friend WithEvents txtSvrPort As eXperDB.BaseControls.TextBox
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents btnApplyIP As eXperDB.BaseControls.Button
End Class
