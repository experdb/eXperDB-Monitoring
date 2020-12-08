<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVersion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVersion))
        Me.tlpSvrChk = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.Label2 = New eXperDB.BaseControls.Label()
        Me.lblServerVersionValue = New eXperDB.BaseControls.Label()
        Me.lblClientVersionValue = New eXperDB.BaseControls.Label()
        Me.lblServerVersion = New eXperDB.BaseControls.Label()
        Me.lblClientVersion = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlB = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.Label3 = New eXperDB.BaseControls.Label()
        Me.tlpSvrChk.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlB.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.tlpSvrChk.Controls.Add(Me.Label3, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.btnAct, 3, 2)
        Me.tlpSvrChk.Controls.Add(Me.Label2, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblServerVersionValue, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblClientVersionValue, 2, 2)
        Me.tlpSvrChk.Controls.Add(Me.lblServerVersion, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblClientVersion, 1, 2)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 47)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 7
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(408, 174)
        Me.tlpSvrChk.TabIndex = 11
        '
        'btnAct
        '
        Me.btnAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAct.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAct.Location = New System.Drawing.Point(283, 59)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(83, 30)
        Me.btnAct.TabIndex = 6
        Me.btnAct.Text = "Upgrade"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = False
        Me.btnAct.Visible = False
        '
        'Label2
        '
        Me.tlpSvrChk.SetColumnSpan(Me.Label2, 3)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FixedHeight = False
        Me.Label2.FixedWidth = False
        Me.Label2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.LineSpacing = 0.0!
        Me.Label2.Location = New System.Drawing.Point(11, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Copyright(C) 2011-2020 inzent.com, All rights reserved."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServerVersionValue
        '
        Me.lblServerVersionValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServerVersionValue.FixedHeight = False
        Me.lblServerVersionValue.FixedWidth = False
        Me.lblServerVersionValue.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblServerVersionValue.ForeColor = System.Drawing.Color.White
        Me.lblServerVersionValue.LineSpacing = 0.0!
        Me.lblServerVersionValue.Location = New System.Drawing.Point(183, 20)
        Me.lblServerVersionValue.Name = "lblServerVersionValue"
        Me.lblServerVersionValue.Size = New System.Drawing.Size(94, 36)
        Me.lblServerVersionValue.TabIndex = 4
        Me.lblServerVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClientVersionValue
        '
        Me.lblClientVersionValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClientVersionValue.FixedHeight = False
        Me.lblClientVersionValue.FixedWidth = False
        Me.lblClientVersionValue.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblClientVersionValue.ForeColor = System.Drawing.Color.White
        Me.lblClientVersionValue.LineSpacing = 0.0!
        Me.lblClientVersionValue.Location = New System.Drawing.Point(183, 56)
        Me.lblClientVersionValue.Name = "lblClientVersionValue"
        Me.lblClientVersionValue.Size = New System.Drawing.Size(94, 36)
        Me.lblClientVersionValue.TabIndex = 3
        Me.lblClientVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServerVersion
        '
        Me.lblServerVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServerVersion.FixedHeight = False
        Me.lblServerVersion.FixedWidth = False
        Me.lblServerVersion.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblServerVersion.ForeColor = System.Drawing.Color.White
        Me.lblServerVersion.LineSpacing = 0.0!
        Me.lblServerVersion.Location = New System.Drawing.Point(11, 20)
        Me.lblServerVersion.Name = "lblServerVersion"
        Me.lblServerVersion.Size = New System.Drawing.Size(166, 36)
        Me.lblServerVersion.TabIndex = 0
        Me.lblServerVersion.Text = "Server :"
        Me.lblServerVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClientVersion
        '
        Me.lblClientVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClientVersion.FixedHeight = False
        Me.lblClientVersion.FixedWidth = False
        Me.lblClientVersion.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblClientVersion.ForeColor = System.Drawing.Color.White
        Me.lblClientVersion.LineSpacing = 0.0!
        Me.lblClientVersion.Location = New System.Drawing.Point(11, 56)
        Me.lblClientVersion.Name = "lblClientVersion"
        Me.lblClientVersion.Size = New System.Drawing.Size(166, 36)
        Me.lblClientVersion.TabIndex = 2
        Me.lblClientVersion.Text = "Client :"
        Me.lblClientVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(408, 44)
        Me.TableLayoutPanel2.TabIndex = 17
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
        Me.StatusLabel.Size = New System.Drawing.Size(362, 44)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "eXperDB-Monitoring version"
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
        Me.Label1.Size = New System.Drawing.Size(34, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'pnlB
        '
        Me.pnlB.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlB.ColumnCount = 3
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.Controls.Add(Me.btnClose, 1, 0)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(3, 221)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.RowCount = 1
        Me.pnlB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlB.Size = New System.Drawing.Size(408, 45)
        Me.pnlB.TabIndex = 19
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(157, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(94, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.tlpSvrChk.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FixedHeight = False
        Me.Label3.FixedWidth = False
        Me.Label3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.LineSpacing = 0.0!
        Me.Label3.Location = New System.Drawing.Point(11, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(394, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hompage : http://www.experdb.com"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVersion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 269)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.pnlB)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVersion"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Version"
        Me.tlpSvrChk.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSvrChk As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblServerVersion As eXperDB.BaseControls.Label
    Friend WithEvents lblClientVersion As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents Label2 As eXperDB.BaseControls.Label
    Friend WithEvents lblServerVersionValue As eXperDB.BaseControls.Label
    Friend WithEvents lblClientVersionValue As eXperDB.BaseControls.Label
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents Label3 As eXperDB.BaseControls.Label
End Class
