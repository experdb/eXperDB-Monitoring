<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnection))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnTest = New eXperDB.BaseControls.Button()
        Me.splSlave = New eXperDB.BaseControls.SplitContainer()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStmtSDly = New eXperDB.BaseControls.Label()
        Me.cmbStmtCollectPeriod = New eXperDB.BaseControls.ComboBox()
        Me.cmbHARole = New eXperDB.BaseControls.ComboBox()
        Me.lblHARole = New eXperDB.BaseControls.Label()
        Me.nudCollectSecond = New eXperDB.BaseControls.NumericUpDown()
        Me.txtAlias = New eXperDB.BaseControls.TextBox()
        Me.lblAlias = New eXperDB.BaseControls.Label()
        Me.lblUser = New eXperDB.BaseControls.Label()
        Me.lblSvrGatSDly = New eXperDB.BaseControls.Label()
        Me.lblPW = New eXperDB.BaseControls.Label()
        Me.cmbSchema = New eXperDB.BaseControls.ComboBox()
        Me.lblSchema = New eXperDB.BaseControls.Label()
        Me.cmbDbnm = New eXperDB.BaseControls.ComboBox()
        Me.lblDB = New eXperDB.BaseControls.Label()
        Me.txtPW = New eXperDB.BaseControls.TextBox()
        Me.lblIP = New eXperDB.BaseControls.Label()
        Me.txtUsr = New eXperDB.BaseControls.TextBox()
        Me.lblPort = New eXperDB.BaseControls.Label()
        Me.txtIP = New eXperDB.BaseControls.TextBox()
        Me.txtPort = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPrimary = New eXperDB.BaseControls.Label()
        Me.txtHAREPLHost = New eXperDB.BaseControls.TextBox()
        Me.txtHAPort = New eXperDB.BaseControls.TextBox()
        Me.txtHAHost = New eXperDB.BaseControls.TextBox()
        Me.lblHAREPLHost = New eXperDB.BaseControls.Label()
        Me.lblHAPort = New eXperDB.BaseControls.Label()
        Me.lblHAHost = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.splSlave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splSlave.Panel1.SuspendLayout()
        Me.splSlave.Panel2.SuspendLayout()
        Me.splSlave.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        CType(Me.nudCollectSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(365, 50)
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
        Me.StatusLabel.Size = New System.Drawing.Size(319, 50)
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
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTest, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 602)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(365, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(225, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAct
        '
        Me.btnAct.CheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.Transparent
        Me.btnAct.Location = New System.Drawing.Point(145, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 1
        Me.btnAct.Text = "F140/F141"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.CheckFillColor = System.Drawing.Color.Transparent
        Me.btnTest.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTest.FixedHeight = False
        Me.btnTest.FixedWidth = False
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnTest.LineColor = System.Drawing.Color.Transparent
        Me.btnTest.Location = New System.Drawing.Point(65, 3)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Radius = 10
        Me.btnTest.Size = New System.Drawing.Size(74, 39)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "F002"
        Me.btnTest.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnTest.UseRound = True
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'splSlave
        '
        Me.splSlave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splSlave.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splSlave.Location = New System.Drawing.Point(3, 53)
        Me.splSlave.Name = "splSlave"
        Me.splSlave.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splSlave.Panel1
        '
        Me.splSlave.Panel1.Controls.Add(Me.tlpSvrChk)
        '
        'splSlave.Panel2
        '
        Me.splSlave.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.splSlave.Panel2.Enabled = False
        Me.splSlave.Size = New System.Drawing.Size(365, 549)
        Me.splSlave.SplitterDistance = 390
        Me.splSlave.TabIndex = 18
        Me.splSlave.TabStop = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 3
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpSvrChk.Controls.Add(Me.lblStmtSDly, 0, 8)
        Me.tlpSvrChk.Controls.Add(Me.cmbStmtCollectPeriod, 1, 8)
        Me.tlpSvrChk.Controls.Add(Me.cmbHARole, 1, 10)
        Me.tlpSvrChk.Controls.Add(Me.lblHARole, 0, 10)
        Me.tlpSvrChk.Controls.Add(Me.nudCollectSecond, 1, 7)
        Me.tlpSvrChk.Controls.Add(Me.txtAlias, 1, 9)
        Me.tlpSvrChk.Controls.Add(Me.lblAlias, 0, 9)
        Me.tlpSvrChk.Controls.Add(Me.lblUser, 0, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblSvrGatSDly, 0, 7)
        Me.tlpSvrChk.Controls.Add(Me.lblPW, 0, 4)
        Me.tlpSvrChk.Controls.Add(Me.cmbSchema, 1, 6)
        Me.tlpSvrChk.Controls.Add(Me.lblSchema, 0, 6)
        Me.tlpSvrChk.Controls.Add(Me.cmbDbnm, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblDB, 0, 5)
        Me.tlpSvrChk.Controls.Add(Me.txtPW, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblIP, 0, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtUsr, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblPort, 0, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtIP, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtPort, 1, 2)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(0, 0)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 12
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(365, 390)
        Me.tlpSvrChk.TabIndex = 19
        '
        'lblStmtSDly
        '
        Me.lblStmtSDly.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStmtSDly.FixedHeight = False
        Me.lblStmtSDly.FixedWidth = False
        Me.lblStmtSDly.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblStmtSDly.ForeColor = System.Drawing.Color.White
        Me.lblStmtSDly.LineSpacing = 0.0!
        Me.lblStmtSDly.Location = New System.Drawing.Point(3, 275)
        Me.lblStmtSDly.Name = "lblStmtSDly"
        Me.lblStmtSDly.Size = New System.Drawing.Size(127, 20)
        Me.lblStmtSDly.TabIndex = 19
        Me.lblStmtSDly.Text = "F341"
        Me.lblStmtSDly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbStmtCollectPeriod
        '
        Me.cmbStmtCollectPeriod.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStmtCollectPeriod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbStmtCollectPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStmtCollectPeriod.FixedWidth = False
        Me.cmbStmtCollectPeriod.FormattingEnabled = True
        Me.cmbStmtCollectPeriod.Location = New System.Drawing.Point(136, 272)
        Me.cmbStmtCollectPeriod.Name = "cmbStmtCollectPeriod"
        Me.cmbStmtCollectPeriod.Necessary = False
        Me.cmbStmtCollectPeriod.Size = New System.Drawing.Size(193, 20)
        Me.cmbStmtCollectPeriod.StatusTip = ""
        Me.cmbStmtCollectPeriod.TabIndex = 7
        Me.cmbStmtCollectPeriod.ValueText = ""
        '
        'cmbHARole
        '
        Me.cmbHARole.BackColor = System.Drawing.SystemColors.Window
        Me.cmbHARole.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbHARole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHARole.FixedWidth = False
        Me.cmbHARole.FormattingEnabled = True
        Me.cmbHARole.Items.AddRange(New Object() {"Single", "Primary", "Stand by"})
        Me.cmbHARole.Location = New System.Drawing.Point(136, 342)
        Me.cmbHARole.Name = "cmbHARole"
        Me.cmbHARole.Necessary = False
        Me.cmbHARole.Size = New System.Drawing.Size(193, 20)
        Me.cmbHARole.StatusTip = ""
        Me.cmbHARole.TabIndex = 9
        Me.cmbHARole.ValueText = ""
        '
        'lblHARole
        '
        Me.lblHARole.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHARole.FixedHeight = False
        Me.lblHARole.FixedWidth = False
        Me.lblHARole.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblHARole.ForeColor = System.Drawing.Color.White
        Me.lblHARole.LineSpacing = 0.0!
        Me.lblHARole.Location = New System.Drawing.Point(3, 345)
        Me.lblHARole.Name = "lblHARole"
        Me.lblHARole.Size = New System.Drawing.Size(127, 20)
        Me.lblHARole.TabIndex = 16
        Me.lblHARole.Text = "F288"
        Me.lblHARole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCollectSecond
        '
        Me.nudCollectSecond.BackColor = System.Drawing.SystemColors.Window
        Me.nudCollectSecond.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudCollectSecond.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudCollectSecond.FixedWidth = False
        Me.nudCollectSecond.Location = New System.Drawing.Point(136, 236)
        Me.nudCollectSecond.Maximum = New Decimal(New Integer() {1800, 0, 0, 0})
        Me.nudCollectSecond.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCollectSecond.Name = "nudCollectSecond"
        Me.nudCollectSecond.Necessary = False
        Me.nudCollectSecond.Size = New System.Drawing.Size(193, 21)
        Me.nudCollectSecond.StatusTip = ""
        Me.nudCollectSecond.TabIndex = 6
        Me.nudCollectSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCollectSecond.ThousandsSeparator = True
        Me.nudCollectSecond.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlias.code = False
        Me.txtAlias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAlias.FixedWidth = False
        Me.txtAlias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAlias.impossibleinput = ""
        Me.txtAlias.Location = New System.Drawing.Point(136, 306)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Necessary = False
        Me.txtAlias.PossibleInput = ""
        Me.txtAlias.Prefix = ""
        Me.txtAlias.Size = New System.Drawing.Size(193, 21)
        Me.txtAlias.StatusTip = ""
        Me.txtAlias.TabIndex = 8
        Me.txtAlias.Value = ""
        '
        'lblAlias
        '
        Me.lblAlias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAlias.FixedHeight = False
        Me.lblAlias.FixedWidth = False
        Me.lblAlias.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAlias.ForeColor = System.Drawing.Color.White
        Me.lblAlias.LineSpacing = 0.0!
        Me.lblAlias.Location = New System.Drawing.Point(3, 310)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(127, 20)
        Me.lblAlias.TabIndex = 14
        Me.lblAlias.Text = "F019"
        Me.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUser.FixedHeight = False
        Me.lblUser.FixedWidth = False
        Me.lblUser.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.LineSpacing = 0.0!
        Me.lblUser.Location = New System.Drawing.Point(3, 100)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(127, 20)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "F008"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSvrGatSDly
        '
        Me.lblSvrGatSDly.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrGatSDly.FixedHeight = False
        Me.lblSvrGatSDly.FixedWidth = False
        Me.lblSvrGatSDly.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrGatSDly.ForeColor = System.Drawing.Color.White
        Me.lblSvrGatSDly.LineSpacing = 0.0!
        Me.lblSvrGatSDly.Location = New System.Drawing.Point(3, 240)
        Me.lblSvrGatSDly.Name = "lblSvrGatSDly"
        Me.lblSvrGatSDly.Size = New System.Drawing.Size(127, 20)
        Me.lblSvrGatSDly.TabIndex = 12
        Me.lblSvrGatSDly.Text = "F011"
        Me.lblSvrGatSDly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPW
        '
        Me.lblPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPW.FixedHeight = False
        Me.lblPW.FixedWidth = False
        Me.lblPW.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.White
        Me.lblPW.LineSpacing = 0.0!
        Me.lblPW.Location = New System.Drawing.Point(3, 135)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(127, 20)
        Me.lblPW.TabIndex = 6
        Me.lblPW.Text = "F009"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSchema
        '
        Me.cmbSchema.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSchema.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbSchema.FixedWidth = False
        Me.cmbSchema.FormattingEnabled = True
        Me.cmbSchema.Location = New System.Drawing.Point(136, 202)
        Me.cmbSchema.Name = "cmbSchema"
        Me.cmbSchema.Necessary = False
        Me.cmbSchema.Size = New System.Drawing.Size(193, 20)
        Me.cmbSchema.StatusTip = ""
        Me.cmbSchema.TabIndex = 5
        Me.cmbSchema.ValueText = ""
        '
        'lblSchema
        '
        Me.lblSchema.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSchema.FixedHeight = False
        Me.lblSchema.FixedWidth = False
        Me.lblSchema.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSchema.ForeColor = System.Drawing.Color.White
        Me.lblSchema.LineSpacing = 0.0!
        Me.lblSchema.Location = New System.Drawing.Point(3, 205)
        Me.lblSchema.Name = "lblSchema"
        Me.lblSchema.Size = New System.Drawing.Size(127, 20)
        Me.lblSchema.TabIndex = 10
        Me.lblSchema.Text = "F074"
        Me.lblSchema.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDbnm
        '
        Me.cmbDbnm.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDbnm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbDbnm.FixedWidth = False
        Me.cmbDbnm.FormattingEnabled = True
        Me.cmbDbnm.Location = New System.Drawing.Point(136, 167)
        Me.cmbDbnm.Name = "cmbDbnm"
        Me.cmbDbnm.Necessary = False
        Me.cmbDbnm.Size = New System.Drawing.Size(193, 20)
        Me.cmbDbnm.StatusTip = ""
        Me.cmbDbnm.TabIndex = 4
        Me.cmbDbnm.ValueText = ""
        '
        'lblDB
        '
        Me.lblDB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDB.FixedHeight = False
        Me.lblDB.FixedWidth = False
        Me.lblDB.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.White
        Me.lblDB.LineSpacing = 0.0!
        Me.lblDB.Location = New System.Drawing.Point(3, 170)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(127, 20)
        Me.lblDB.TabIndex = 8
        Me.lblDB.Text = "F010"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.Window
        Me.txtPW.code = False
        Me.txtPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPW.FixedWidth = False
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPW.impossibleinput = ""
        Me.txtPW.Location = New System.Drawing.Point(136, 131)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Necessary = False
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.PossibleInput = ""
        Me.txtPW.Prefix = ""
        Me.txtPW.Size = New System.Drawing.Size(193, 21)
        Me.txtPW.StatusTip = ""
        Me.txtPW.TabIndex = 3
        Me.txtPW.Value = ""
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblIP.FixedHeight = False
        Me.lblIP.FixedWidth = False
        Me.lblIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.LineSpacing = 0.0!
        Me.lblIP.Location = New System.Drawing.Point(3, 30)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(127, 20)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "F006"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsr.code = False
        Me.txtUsr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUsr.FixedWidth = False
        Me.txtUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUsr.impossibleinput = ""
        Me.txtUsr.Location = New System.Drawing.Point(136, 96)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Necessary = False
        Me.txtUsr.PossibleInput = ""
        Me.txtUsr.Prefix = ""
        Me.txtUsr.Size = New System.Drawing.Size(193, 21)
        Me.txtUsr.StatusTip = ""
        Me.txtUsr.TabIndex = 2
        Me.txtUsr.Value = ""
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPort.FixedHeight = False
        Me.lblPort.FixedWidth = False
        Me.lblPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.White
        Me.lblPort.LineSpacing = 0.0!
        Me.lblPort.Location = New System.Drawing.Point(3, 65)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(127, 20)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "F007"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.Window
        Me.txtIP.code = False
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtIP.FixedWidth = False
        Me.txtIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIP.impossibleinput = ""
        Me.txtIP.Location = New System.Drawing.Point(136, 26)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Necessary = False
        Me.txtIP.PossibleInput = "0123456789."
        Me.txtIP.Prefix = ""
        Me.txtIP.Size = New System.Drawing.Size(193, 21)
        Me.txtIP.StatusTip = ""
        Me.txtIP.TabIndex = 0
        Me.txtIP.Value = ""
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtPort.code = False
        Me.txtPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPort.FixedWidth = False
        Me.txtPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPort.impossibleinput = ""
        Me.txtPort.Location = New System.Drawing.Point(136, 61)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Necessary = False
        Me.txtPort.PossibleInput = "0123456789"
        Me.txtPort.Prefix = ""
        Me.txtPort.Size = New System.Drawing.Size(193, 21)
        Me.txtPort.StatusTip = ""
        Me.txtPort.TabIndex = 1
        Me.txtPort.Value = "0"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrimary, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHAREPLHost, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHAPort, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHAHost, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHAREPLHost, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHAPort, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHAHost, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(365, 155)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'lblPrimary
        '
        Me.lblPrimary.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblPrimary, 3)
        Me.lblPrimary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPrimary.FixedHeight = False
        Me.lblPrimary.FixedWidth = False
        Me.lblPrimary.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPrimary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPrimary.LineSpacing = 0.0!
        Me.lblPrimary.Location = New System.Drawing.Point(3, 10)
        Me.lblPrimary.Name = "lblPrimary"
        Me.lblPrimary.Size = New System.Drawing.Size(359, 20)
        Me.lblPrimary.TabIndex = 27
        Me.lblPrimary.Text = "F292"
        Me.lblPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHAREPLHost
        '
        Me.txtHAREPLHost.BackColor = System.Drawing.SystemColors.Window
        Me.txtHAREPLHost.code = False
        Me.txtHAREPLHost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtHAREPLHost.FixedWidth = False
        Me.txtHAREPLHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtHAREPLHost.impossibleinput = ""
        Me.txtHAREPLHost.Location = New System.Drawing.Point(136, 111)
        Me.txtHAREPLHost.Name = "txtHAREPLHost"
        Me.txtHAREPLHost.Necessary = False
        Me.txtHAREPLHost.PossibleInput = ""
        Me.txtHAREPLHost.Prefix = ""
        Me.txtHAREPLHost.Size = New System.Drawing.Size(193, 21)
        Me.txtHAREPLHost.StatusTip = ""
        Me.txtHAREPLHost.TabIndex = 2
        Me.txtHAREPLHost.Value = ""
        Me.txtHAREPLHost.Visible = False
        '
        'txtHAPort
        '
        Me.txtHAPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtHAPort.code = False
        Me.txtHAPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtHAPort.FixedWidth = False
        Me.txtHAPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtHAPort.impossibleinput = ""
        Me.txtHAPort.Location = New System.Drawing.Point(136, 76)
        Me.txtHAPort.Name = "txtHAPort"
        Me.txtHAPort.Necessary = False
        Me.txtHAPort.PossibleInput = "0123456789"
        Me.txtHAPort.Prefix = ""
        Me.txtHAPort.Size = New System.Drawing.Size(193, 21)
        Me.txtHAPort.StatusTip = ""
        Me.txtHAPort.TabIndex = 1
        Me.txtHAPort.Value = ""
        '
        'txtHAHost
        '
        Me.txtHAHost.BackColor = System.Drawing.SystemColors.Window
        Me.txtHAHost.code = False
        Me.txtHAHost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtHAHost.FixedWidth = False
        Me.txtHAHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtHAHost.impossibleinput = ""
        Me.txtHAHost.Location = New System.Drawing.Point(136, 41)
        Me.txtHAHost.Name = "txtHAHost"
        Me.txtHAHost.Necessary = False
        Me.txtHAHost.PossibleInput = ""
        Me.txtHAHost.Prefix = ""
        Me.txtHAHost.Size = New System.Drawing.Size(193, 21)
        Me.txtHAHost.StatusTip = ""
        Me.txtHAHost.TabIndex = 0
        Me.txtHAHost.Value = ""
        '
        'lblHAREPLHost
        '
        Me.lblHAREPLHost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHAREPLHost.FixedHeight = False
        Me.lblHAREPLHost.FixedWidth = False
        Me.lblHAREPLHost.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblHAREPLHost.ForeColor = System.Drawing.Color.White
        Me.lblHAREPLHost.LineSpacing = 0.0!
        Me.lblHAREPLHost.Location = New System.Drawing.Point(3, 115)
        Me.lblHAREPLHost.Name = "lblHAREPLHost"
        Me.lblHAREPLHost.Size = New System.Drawing.Size(127, 20)
        Me.lblHAREPLHost.TabIndex = 23
        Me.lblHAREPLHost.Text = "F291"
        Me.lblHAREPLHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHAREPLHost.Visible = False
        '
        'lblHAPort
        '
        Me.lblHAPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHAPort.FixedHeight = False
        Me.lblHAPort.FixedWidth = False
        Me.lblHAPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblHAPort.ForeColor = System.Drawing.Color.White
        Me.lblHAPort.LineSpacing = 0.0!
        Me.lblHAPort.Location = New System.Drawing.Point(3, 80)
        Me.lblHAPort.Name = "lblHAPort"
        Me.lblHAPort.Size = New System.Drawing.Size(127, 20)
        Me.lblHAPort.TabIndex = 21
        Me.lblHAPort.Text = "F290"
        Me.lblHAPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHAHost
        '
        Me.lblHAHost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHAHost.FixedHeight = False
        Me.lblHAHost.FixedWidth = False
        Me.lblHAHost.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblHAHost.ForeColor = System.Drawing.Color.White
        Me.lblHAHost.LineSpacing = 0.0!
        Me.lblHAHost.Location = New System.Drawing.Point(3, 45)
        Me.lblHAHost.Name = "lblHAHost"
        Me.lblHAHost.Size = New System.Drawing.Size(127, 20)
        Me.lblHAHost.TabIndex = 19
        Me.lblHAHost.Text = "F289"
        Me.lblHAHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 650)
        Me.Controls.Add(Me.splSlave)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database Information"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.splSlave.Panel1.ResumeLayout(False)
        Me.splSlave.Panel2.ResumeLayout(False)
        CType(Me.splSlave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splSlave.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        CType(Me.nudCollectSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents btnTest As eXperDB.BaseControls.Button
    Friend WithEvents splSlave As eXperDB.BaseControls.SplitContainer
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbHARole As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblHARole As eXperDB.BaseControls.Label
    Friend WithEvents nudCollectSecond As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents txtAlias As eXperDB.BaseControls.TextBox
    Friend WithEvents lblAlias As eXperDB.BaseControls.Label
    Friend WithEvents lblUser As eXperDB.BaseControls.Label
    Friend WithEvents lblSvrGatSDly As eXperDB.BaseControls.Label
    Friend WithEvents lblPW As eXperDB.BaseControls.Label
    Friend WithEvents cmbSchema As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblSchema As eXperDB.BaseControls.Label
    Friend WithEvents cmbDbnm As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblDB As eXperDB.BaseControls.Label
    Friend WithEvents txtPW As eXperDB.BaseControls.TextBox
    Friend WithEvents lblIP As eXperDB.BaseControls.Label
    Friend WithEvents txtUsr As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPort As eXperDB.BaseControls.Label
    Friend WithEvents txtIP As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPort As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtHAREPLHost As eXperDB.BaseControls.TextBox
    Friend WithEvents txtHAPort As eXperDB.BaseControls.TextBox
    Friend WithEvents txtHAHost As eXperDB.BaseControls.TextBox
    Friend WithEvents lblHAREPLHost As eXperDB.BaseControls.Label
    Friend WithEvents lblHAPort As eXperDB.BaseControls.Label
    Friend WithEvents lblHAHost As eXperDB.BaseControls.Label
    Friend WithEvents lblPrimary As eXperDB.BaseControls.Label
    Friend WithEvents lblStmtSDly As eXperDB.BaseControls.Label
    Friend WithEvents cmbStmtCollectPeriod As eXperDB.BaseControls.ComboBox
End Class
