<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertCheck))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlertUser = New eXperDB.BaseControls.TextBox()
        Me.lblAlertUser = New eXperDB.BaseControls.Label()
        Me.lblPause = New eXperDB.BaseControls.Label()
        Me.cmbPauseTime = New eXperDB.BaseControls.ComboBox()
        Me.txtAlertComment = New System.Windows.Forms.TextBox()
        Me.lblAlertComment = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 392.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblCheck, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(430, 50)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCheck.ForeColor = System.Drawing.Color.White
        Me.lblCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCheck.Location = New System.Drawing.Point(41, 0)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(386, 50)
        Me.lblCheck.TabIndex = 0
        Me.lblCheck.Text = "Text"
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'txtAlertUser
        '
        Me.txtAlertUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlertUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlertUser.code = False
        Me.txtAlertUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlertUser.Enabled = False
        Me.txtAlertUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAlertUser.impossibleinput = ""
        Me.txtAlertUser.Location = New System.Drawing.Point(103, 13)
        Me.txtAlertUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlertUser.Name = "txtAlertUser"
        Me.txtAlertUser.Necessary = False
        Me.txtAlertUser.PossibleInput = ""
        Me.txtAlertUser.Prefix = ""
        Me.txtAlertUser.Size = New System.Drawing.Size(150, 21)
        Me.txtAlertUser.StatusTip = ""
        Me.txtAlertUser.TabIndex = 15
        Me.txtAlertUser.Value = ""
        '
        'lblAlertUser
        '
        Me.lblAlertUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlertUser.FixedWidth = False
        Me.lblAlertUser.ForeColor = System.Drawing.Color.White
        Me.lblAlertUser.LineSpacing = 0.0!
        Me.lblAlertUser.Location = New System.Drawing.Point(3, 13)
        Me.lblAlertUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.lblAlertUser.Name = "lblAlertUser"
        Me.lblAlertUser.Size = New System.Drawing.Size(94, 21)
        Me.lblAlertUser.TabIndex = 14
        Me.lblAlertUser.Text = "F265"
        Me.lblAlertUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPause
        '
        Me.lblPause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPause.FixedWidth = False
        Me.lblPause.ForeColor = System.Drawing.Color.White
        Me.lblPause.LineSpacing = 0.0!
        Me.lblPause.Location = New System.Drawing.Point(3, 43)
        Me.lblPause.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(94, 21)
        Me.lblPause.TabIndex = 12
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
        Me.cmbPauseTime.Location = New System.Drawing.Point(103, 44)
        Me.cmbPauseTime.Name = "cmbPauseTime"
        Me.cmbPauseTime.Necessary = False
        Me.cmbPauseTime.Size = New System.Drawing.Size(150, 20)
        Me.cmbPauseTime.StatusTip = ""
        Me.cmbPauseTime.TabIndex = 13
        Me.cmbPauseTime.ValueText = ""
        '
        'txtAlertComment
        '
        Me.txtAlertComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlertComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlertComment.Location = New System.Drawing.Point(103, 72)
        Me.txtAlertComment.Multiline = True
        Me.txtAlertComment.Name = "txtAlertComment"
        Me.txtAlertComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlertComment.Size = New System.Drawing.Size(324, 154)
        Me.txtAlertComment.TabIndex = 16
        '
        'lblAlertComment
        '
        Me.lblAlertComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblAlertComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlertComment.FixedHeight = False
        Me.lblAlertComment.FixedWidth = False
        Me.lblAlertComment.ForeColor = System.Drawing.Color.White
        Me.lblAlertComment.LineSpacing = 0.0!
        Me.lblAlertComment.Location = New System.Drawing.Point(3, 71)
        Me.lblAlertComment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.lblAlertComment.Name = "lblAlertComment"
        Me.lblAlertComment.Size = New System.Drawing.Size(94, 158)
        Me.lblAlertComment.TabIndex = 9
        Me.lblAlertComment.Text = "F260"
        Me.lblAlertComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.lblAlertComment, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtAlertComment, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbPauseTime, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblPause, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblAlertUser, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtAlertUser, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(430, 229)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(218, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 5
        Me.btnClose.Size = New System.Drawing.Size(74, 37)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(138, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 5
        Me.btnSave.Size = New System.Drawing.Size(74, 37)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 282)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(430, 45)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'frmAlertCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(436, 330)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlertCheck"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alert Check"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAlertUser As eXperDB.BaseControls.TextBox
    Friend WithEvents lblAlertUser As eXperDB.BaseControls.Label
    Friend WithEvents lblPause As eXperDB.BaseControls.Label
    Friend WithEvents cmbPauseTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents txtAlertComment As System.Windows.Forms.TextBox
    Friend WithEvents lblAlertComment As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCheck As System.Windows.Forms.Label
End Class
