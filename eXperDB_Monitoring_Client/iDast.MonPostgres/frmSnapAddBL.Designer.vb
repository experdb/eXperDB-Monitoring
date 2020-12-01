<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnapAddBL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnapAddBL))
        Me.tlpSnapShot = New eXperDB.BaseControls.TableLayoutPanel()
        Me.tlpSnapshot1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudKeepTime = New eXperDB.BaseControls.NumericUpDown()
        Me.dtpKeepTime = New eXperDB.BaseControls.DateTimePicker()
        Me.lblKeepTime = New eXperDB.BaseControls.Label()
        Me.lblBaselineName = New eXperDB.BaseControls.Label()
        Me.txtBaselineName = New eXperDB.BaseControls.TextBox()
        Me.btnTo = New eXperDB.BaseControls.Button()
        Me.btnFrom = New eXperDB.BaseControls.Button()
        Me.txtSnapTo = New eXperDB.BaseControls.TextBox()
        Me.lblReportTo = New eXperDB.BaseControls.Label()
        Me.lblReportFrom = New eXperDB.BaseControls.Label()
        Me.txtSnapFrom = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel7 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnGenerate = New eXperDB.BaseControls.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpSnapShot.SuspendLayout()
        Me.tlpSnapshot1.SuspendLayout()
        CType(Me.nudKeepTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSnapShot
        '
        Me.tlpSnapShot.ColumnCount = 2
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.Controls.Add(Me.tlpSnapshot1, 0, 0)
        Me.tlpSnapShot.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpSnapShot.Location = New System.Drawing.Point(3, 47)
        Me.tlpSnapShot.Name = "tlpSnapShot"
        Me.tlpSnapShot.RowCount = 2
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpSnapShot.Size = New System.Drawing.Size(626, 185)
        Me.tlpSnapShot.TabIndex = 16
        '
        'tlpSnapshot1
        '
        Me.tlpSnapshot1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpSnapshot1.ColumnCount = 8
        Me.tlpSnapShot.SetColumnSpan(Me.tlpSnapshot1, 2)
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot1.Controls.Add(Me.nudKeepTime, 5, 3)
        Me.tlpSnapshot1.Controls.Add(Me.dtpKeepTime, 2, 3)
        Me.tlpSnapshot1.Controls.Add(Me.lblKeepTime, 1, 3)
        Me.tlpSnapshot1.Controls.Add(Me.lblBaselineName, 1, 1)
        Me.tlpSnapshot1.Controls.Add(Me.txtBaselineName, 2, 1)
        Me.tlpSnapshot1.Controls.Add(Me.btnTo, 6, 2)
        Me.tlpSnapshot1.Controls.Add(Me.btnFrom, 3, 2)
        Me.tlpSnapshot1.Controls.Add(Me.txtSnapTo, 5, 2)
        Me.tlpSnapshot1.Controls.Add(Me.lblReportTo, 4, 2)
        Me.tlpSnapshot1.Controls.Add(Me.lblReportFrom, 1, 2)
        Me.tlpSnapshot1.Controls.Add(Me.txtSnapFrom, 2, 2)
        Me.tlpSnapshot1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapshot1.Location = New System.Drawing.Point(3, 3)
        Me.tlpSnapshot1.Name = "tlpSnapshot1"
        Me.tlpSnapshot1.RowCount = 5
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSnapshot1.Size = New System.Drawing.Size(620, 146)
        Me.tlpSnapshot1.TabIndex = 25
        '
        'nudKeepTime
        '
        Me.nudKeepTime.BackColor = System.Drawing.SystemColors.Window
        Me.nudKeepTime.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudKeepTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudKeepTime.FixedWidth = False
        Me.nudKeepTime.Location = New System.Drawing.Point(363, 106)
        Me.nudKeepTime.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudKeepTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKeepTime.Name = "nudKeepTime"
        Me.nudKeepTime.Necessary = False
        Me.nudKeepTime.Size = New System.Drawing.Size(154, 21)
        Me.nudKeepTime.StatusTip = ""
        Me.nudKeepTime.TabIndex = 34
        Me.nudKeepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKeepTime.ThousandsSeparator = True
        Me.nudKeepTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpKeepTime
        '
        Me.dtpKeepTime.BackColor = System.Drawing.SystemColors.Window
        Me.dtpKeepTime.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpKeepTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpKeepTime.FixedWidth = False
        Me.dtpKeepTime.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpKeepTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKeepTime.Location = New System.Drawing.Point(123, 104)
        Me.dtpKeepTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpKeepTime.Name = "dtpKeepTime"
        Me.dtpKeepTime.Necessary = False
        Me.dtpKeepTime.Size = New System.Drawing.Size(154, 22)
        Me.dtpKeepTime.StatusTip = ""
        Me.dtpKeepTime.TabIndex = 33
        '
        'lblKeepTime
        '
        Me.lblKeepTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblKeepTime.FixedHeight = False
        Me.lblKeepTime.FixedWidth = False
        Me.lblKeepTime.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblKeepTime.ForeColor = System.Drawing.Color.White
        Me.lblKeepTime.LineSpacing = 0.0!
        Me.lblKeepTime.Location = New System.Drawing.Point(13, 108)
        Me.lblKeepTime.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblKeepTime.Name = "lblKeepTime"
        Me.lblKeepTime.Size = New System.Drawing.Size(104, 20)
        Me.lblKeepTime.TabIndex = 31
        Me.lblKeepTime.Text = "F958"
        Me.lblKeepTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBaselineName
        '
        Me.lblBaselineName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBaselineName.FixedHeight = False
        Me.lblBaselineName.FixedWidth = False
        Me.lblBaselineName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblBaselineName.ForeColor = System.Drawing.Color.White
        Me.lblBaselineName.LineSpacing = 0.0!
        Me.lblBaselineName.Location = New System.Drawing.Point(13, 28)
        Me.lblBaselineName.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblBaselineName.Name = "lblBaselineName"
        Me.lblBaselineName.Size = New System.Drawing.Size(104, 20)
        Me.lblBaselineName.TabIndex = 29
        Me.lblBaselineName.Text = "Baseline Name"
        Me.lblBaselineName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBaselineName
        '
        Me.txtBaselineName.BackColor = System.Drawing.SystemColors.Control
        Me.txtBaselineName.code = False
        Me.txtBaselineName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtBaselineName.FixedWidth = False
        Me.txtBaselineName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBaselineName.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtBaselineName.Location = New System.Drawing.Point(123, 26)
        Me.txtBaselineName.MaxByteLength = 16
        Me.txtBaselineName.Name = "txtBaselineName"
        Me.txtBaselineName.Necessary = False
        Me.txtBaselineName.PossibleInput = ""
        Me.txtBaselineName.Prefix = ""
        Me.txtBaselineName.Size = New System.Drawing.Size(154, 21)
        Me.txtBaselineName.StatusTip = ""
        Me.txtBaselineName.TabIndex = 28
        Me.txtBaselineName.Value = ""
        '
        'btnTo
        '
        Me.btnTo.BackColor = System.Drawing.Color.Silver
        Me.btnTo.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnTo.FixedHeight = False
        Me.btnTo.FixedWidth = False
        Me.btnTo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnTo.ForeColor = System.Drawing.Color.Red
        Me.btnTo.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTo.Image = CType(resources.GetObject("btnTo.Image"), System.Drawing.Image)
        Me.btnTo.LineColor = System.Drawing.Color.LightGray
        Me.btnTo.Location = New System.Drawing.Point(523, 65)
        Me.btnTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 1)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Radius = 5
        Me.btnTo.Size = New System.Drawing.Size(24, 24)
        Me.btnTo.TabIndex = 27
        Me.btnTo.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTo.UseVisualStyleBackColor = True
        '
        'btnFrom
        '
        Me.btnFrom.BackColor = System.Drawing.Color.Silver
        Me.btnFrom.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFrom.FixedHeight = False
        Me.btnFrom.FixedWidth = False
        Me.btnFrom.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnFrom.ForeColor = System.Drawing.Color.Red
        Me.btnFrom.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFrom.Image = CType(resources.GetObject("btnFrom.Image"), System.Drawing.Image)
        Me.btnFrom.LineColor = System.Drawing.Color.LightGray
        Me.btnFrom.Location = New System.Drawing.Point(283, 65)
        Me.btnFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 1)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Radius = 5
        Me.btnFrom.Size = New System.Drawing.Size(24, 24)
        Me.btnFrom.TabIndex = 26
        Me.btnFrom.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFrom.UseVisualStyleBackColor = True
        '
        'txtSnapTo
        '
        Me.txtSnapTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtSnapTo.code = False
        Me.txtSnapTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSnapTo.Enabled = False
        Me.txtSnapTo.FixedWidth = False
        Me.txtSnapTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSnapTo.impossibleinput = ""
        Me.txtSnapTo.Location = New System.Drawing.Point(363, 66)
        Me.txtSnapTo.Name = "txtSnapTo"
        Me.txtSnapTo.Necessary = False
        Me.txtSnapTo.PossibleInput = ""
        Me.txtSnapTo.Prefix = ""
        Me.txtSnapTo.Size = New System.Drawing.Size(154, 21)
        Me.txtSnapTo.StatusTip = ""
        Me.txtSnapTo.TabIndex = 8
        Me.txtSnapTo.Value = ""
        '
        'lblReportTo
        '
        Me.lblReportTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportTo.FixedHeight = False
        Me.lblReportTo.FixedWidth = False
        Me.lblReportTo.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblReportTo.ForeColor = System.Drawing.Color.White
        Me.lblReportTo.LineSpacing = 0.0!
        Me.lblReportTo.Location = New System.Drawing.Point(313, 68)
        Me.lblReportTo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblReportTo.Name = "lblReportTo"
        Me.lblReportTo.Size = New System.Drawing.Size(44, 20)
        Me.lblReportTo.TabIndex = 8
        Me.lblReportTo.Text = "To"
        Me.lblReportTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReportFrom
        '
        Me.lblReportFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportFrom.FixedHeight = False
        Me.lblReportFrom.FixedWidth = False
        Me.lblReportFrom.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblReportFrom.ForeColor = System.Drawing.Color.White
        Me.lblReportFrom.LineSpacing = 0.0!
        Me.lblReportFrom.Location = New System.Drawing.Point(13, 68)
        Me.lblReportFrom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblReportFrom.Name = "lblReportFrom"
        Me.lblReportFrom.Size = New System.Drawing.Size(104, 20)
        Me.lblReportFrom.TabIndex = 0
        Me.lblReportFrom.Text = "From"
        Me.lblReportFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSnapFrom
        '
        Me.txtSnapFrom.BackColor = System.Drawing.SystemColors.Control
        Me.txtSnapFrom.code = False
        Me.txtSnapFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSnapFrom.Enabled = False
        Me.txtSnapFrom.FixedWidth = False
        Me.txtSnapFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSnapFrom.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtSnapFrom.Location = New System.Drawing.Point(123, 66)
        Me.txtSnapFrom.MaxByteLength = 16
        Me.txtSnapFrom.Name = "txtSnapFrom"
        Me.txtSnapFrom.Necessary = False
        Me.txtSnapFrom.PossibleInput = ""
        Me.txtSnapFrom.Prefix = ""
        Me.txtSnapFrom.Size = New System.Drawing.Size(154, 21)
        Me.txtSnapFrom.StatusTip = ""
        Me.txtSnapFrom.TabIndex = 0
        Me.txtSnapFrom.Value = ""
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnGenerate, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel7.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 203)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(626, 46)
        Me.TableLayoutPanel7.TabIndex = 35
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(316, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(104, 38)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F923"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGenerate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGenerate.FixedHeight = False
        Me.btnGenerate.FixedWidth = False
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnGenerate.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(206, 4)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Radius = 10
        Me.btnGenerate.Size = New System.Drawing.Size(104, 38)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "F956"
        Me.btnGenerate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGenerate.UseRound = True
        Me.btnGenerate.UseVisualStyleBackColor = False
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
        Me.StatusLabel.Size = New System.Drawing.Size(540, 44)
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
        Me.Label1.Size = New System.Drawing.Size(34, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(626, 44)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'frmSnapAddBL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 252)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.tlpSnapShot)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSnapAddBL"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SnapshotReport"
        Me.tlpSnapShot.ResumeLayout(False)
        Me.tlpSnapshot1.ResumeLayout(False)
        Me.tlpSnapshot1.PerformLayout()
        CType(Me.nudKeepTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSnapShot As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnGenerate As eXperDB.BaseControls.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpSnapshot1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBaselineName As eXperDB.BaseControls.Label
    Friend WithEvents txtBaselineName As eXperDB.BaseControls.TextBox
    Friend WithEvents btnTo As eXperDB.BaseControls.Button
    Friend WithEvents btnFrom As eXperDB.BaseControls.Button
    Friend WithEvents txtSnapTo As eXperDB.BaseControls.TextBox
    Friend WithEvents lblReportTo As eXperDB.BaseControls.Label
    Friend WithEvents lblReportFrom As eXperDB.BaseControls.Label
    Friend WithEvents txtSnapFrom As eXperDB.BaseControls.TextBox
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents lblKeepTime As eXperDB.BaseControls.Label
    Friend WithEvents dtpKeepTime As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents nudKeepTime As eXperDB.BaseControls.NumericUpDown
End Class
