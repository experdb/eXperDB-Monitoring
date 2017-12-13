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
        Me.FormMovePanel1 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.tlpSvrChk = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblIP = New eXperDB.BaseControls.Label()
        Me.nudCollectSecond = New eXperDB.BaseControls.NumericUpDown()
        Me.lblPort = New eXperDB.BaseControls.Label()
        Me.lblUser = New eXperDB.BaseControls.Label()
        Me.lblPW = New eXperDB.BaseControls.Label()
        Me.lblSvrGatSDly = New eXperDB.BaseControls.Label()
        Me.lblDB = New eXperDB.BaseControls.Label()
        Me.txtIP = New eXperDB.BaseControls.TextBox()
        Me.txtPort = New eXperDB.BaseControls.TextBox()
        Me.txtUsr = New eXperDB.BaseControls.TextBox()
        Me.txtPW = New eXperDB.BaseControls.TextBox()
        Me.cmbDbnm = New eXperDB.BaseControls.ComboBox()
        Me.lblSchema = New eXperDB.BaseControls.Label()
        Me.cmbSchema = New eXperDB.BaseControls.ComboBox()
        Me.pnlSvrTestAct = New eXperDB.BaseControls.Panel()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnTest = New eXperDB.BaseControls.Button()
        Me.lblAlias = New eXperDB.BaseControls.Label()
        Me.txtAlias = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.FormMovePanel1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        CType(Me.nudCollectSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSvrTestAct.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.FormMovePanel1.Size = New System.Drawing.Size(529, 31)
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
        Me.FormControlBox1.Location = New System.Drawing.Point(460, 0)
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
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Black
        Me.tlpSvrChk.ColumnCount = 1
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Controls.Add(Me.lblIP, 0, 0)
        Me.tlpSvrChk.Controls.Add(Me.nudCollectSecond, 0, 13)
        Me.tlpSvrChk.Controls.Add(Me.lblPort, 0, 2)
        Me.tlpSvrChk.Controls.Add(Me.lblUser, 0, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblPW, 0, 6)
        Me.tlpSvrChk.Controls.Add(Me.lblSvrGatSDly, 0, 12)
        Me.tlpSvrChk.Controls.Add(Me.lblDB, 0, 8)
        Me.tlpSvrChk.Controls.Add(Me.txtIP, 0, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtPort, 0, 3)
        Me.tlpSvrChk.Controls.Add(Me.txtUsr, 0, 5)
        Me.tlpSvrChk.Controls.Add(Me.txtPW, 0, 7)
        Me.tlpSvrChk.Controls.Add(Me.cmbDbnm, 0, 9)
        Me.tlpSvrChk.Controls.Add(Me.lblSchema, 0, 10)
        Me.tlpSvrChk.Controls.Add(Me.cmbSchema, 0, 11)
        Me.tlpSvrChk.Controls.Add(Me.pnlSvrTestAct, 0, 16)
        Me.tlpSvrChk.Controls.Add(Me.lblAlias, 0, 14)
        Me.tlpSvrChk.Controls.Add(Me.txtAlias, 0, 15)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 35)
        Me.tlpSvrChk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 17
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(529, 503)
        Me.tlpSvrChk.TabIndex = 10
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIP.FixedHeight = False
        Me.lblIP.FixedWidth = False
        Me.lblIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.Gray
        Me.lblIP.Location = New System.Drawing.Point(3, 0)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(523, 25)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "F006"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCollectSecond
        '
        Me.nudCollectSecond.BackColor = System.Drawing.SystemColors.Window
        Me.nudCollectSecond.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudCollectSecond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCollectSecond.FixedWidth = False
        Me.nudCollectSecond.Location = New System.Drawing.Point(3, 365)
        Me.nudCollectSecond.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudCollectSecond.Maximum = New Decimal(New Integer() {1800, 0, 0, 0})
        Me.nudCollectSecond.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCollectSecond.Name = "nudCollectSecond"
        Me.nudCollectSecond.Necessary = False
        Me.nudCollectSecond.Size = New System.Drawing.Size(523, 25)
        Me.nudCollectSecond.StatusTip = ""
        Me.nudCollectSecond.TabIndex = 13
        Me.nudCollectSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCollectSecond.ThousandsSeparator = True
        Me.nudCollectSecond.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPort.FixedHeight = False
        Me.lblPort.FixedWidth = False
        Me.lblPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.Gray
        Me.lblPort.Location = New System.Drawing.Point(3, 56)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(523, 25)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "F007"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUser.FixedHeight = False
        Me.lblUser.FixedWidth = False
        Me.lblUser.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Gray
        Me.lblUser.Location = New System.Drawing.Point(3, 112)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(523, 25)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "F008"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPW
        '
        Me.lblPW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPW.FixedHeight = False
        Me.lblPW.FixedWidth = False
        Me.lblPW.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.Gray
        Me.lblPW.Location = New System.Drawing.Point(3, 168)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(523, 25)
        Me.lblPW.TabIndex = 6
        Me.lblPW.Text = "F009"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSvrGatSDly
        '
        Me.lblSvrGatSDly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrGatSDly.FixedHeight = False
        Me.lblSvrGatSDly.FixedWidth = False
        Me.lblSvrGatSDly.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrGatSDly.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrGatSDly.Location = New System.Drawing.Point(3, 336)
        Me.lblSvrGatSDly.Name = "lblSvrGatSDly"
        Me.lblSvrGatSDly.Size = New System.Drawing.Size(523, 25)
        Me.lblSvrGatSDly.TabIndex = 12
        Me.lblSvrGatSDly.Text = "F011"
        Me.lblSvrGatSDly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDB
        '
        Me.lblDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDB.FixedHeight = False
        Me.lblDB.FixedWidth = False
        Me.lblDB.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.Gray
        Me.lblDB.Location = New System.Drawing.Point(3, 224)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(523, 25)
        Me.lblDB.TabIndex = 8
        Me.lblDB.Text = "F010"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.Window
        Me.txtIP.code = False
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIP.FixedWidth = False
        Me.txtIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIP.impossibleinput = ""
        Me.txtIP.Location = New System.Drawing.Point(3, 29)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Necessary = False
        Me.txtIP.PossibleInput = "0123456789."
        Me.txtIP.Prefix = ""
        Me.txtIP.Size = New System.Drawing.Size(523, 25)
        Me.txtIP.StatusTip = ""
        Me.txtIP.TabIndex = 1
        Me.txtIP.Value = ""
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtPort.code = False
        Me.txtPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPort.FixedWidth = False
        Me.txtPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPort.impossibleinput = ""
        Me.txtPort.Location = New System.Drawing.Point(3, 85)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Necessary = False
        Me.txtPort.PossibleInput = "0123456789"
        Me.txtPort.Prefix = ""
        Me.txtPort.Size = New System.Drawing.Size(523, 25)
        Me.txtPort.StatusTip = ""
        Me.txtPort.TabIndex = 3
        Me.txtPort.Value = ""
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsr.code = False
        Me.txtUsr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUsr.FixedWidth = False
        Me.txtUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUsr.impossibleinput = ""
        Me.txtUsr.Location = New System.Drawing.Point(3, 141)
        Me.txtUsr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Necessary = False
        Me.txtUsr.PossibleInput = ""
        Me.txtUsr.Prefix = ""
        Me.txtUsr.Size = New System.Drawing.Size(523, 25)
        Me.txtUsr.StatusTip = ""
        Me.txtUsr.TabIndex = 5
        Me.txtUsr.Value = ""
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.Window
        Me.txtPW.code = False
        Me.txtPW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPW.FixedWidth = False
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPW.impossibleinput = ""
        Me.txtPW.Location = New System.Drawing.Point(3, 197)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Necessary = False
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.PossibleInput = ""
        Me.txtPW.Prefix = ""
        Me.txtPW.Size = New System.Drawing.Size(523, 25)
        Me.txtPW.StatusTip = ""
        Me.txtPW.TabIndex = 7
        Me.txtPW.Value = ""
        '
        'cmbDbnm
        '
        Me.cmbDbnm.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDbnm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDbnm.FixedWidth = False
        Me.cmbDbnm.FormattingEnabled = True
        Me.cmbDbnm.Location = New System.Drawing.Point(3, 253)
        Me.cmbDbnm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDbnm.Name = "cmbDbnm"
        Me.cmbDbnm.Necessary = False
        Me.cmbDbnm.Size = New System.Drawing.Size(523, 23)
        Me.cmbDbnm.StatusTip = ""
        Me.cmbDbnm.TabIndex = 9
        Me.cmbDbnm.ValueText = ""
        '
        'lblSchema
        '
        Me.lblSchema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSchema.FixedHeight = False
        Me.lblSchema.FixedWidth = False
        Me.lblSchema.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSchema.ForeColor = System.Drawing.Color.Gray
        Me.lblSchema.Location = New System.Drawing.Point(3, 280)
        Me.lblSchema.Name = "lblSchema"
        Me.lblSchema.Size = New System.Drawing.Size(523, 25)
        Me.lblSchema.TabIndex = 10
        Me.lblSchema.Text = "F074"
        Me.lblSchema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSchema
        '
        Me.cmbSchema.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSchema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSchema.FixedWidth = False
        Me.cmbSchema.FormattingEnabled = True
        Me.cmbSchema.Location = New System.Drawing.Point(3, 309)
        Me.cmbSchema.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSchema.Name = "cmbSchema"
        Me.cmbSchema.Necessary = False
        Me.cmbSchema.Size = New System.Drawing.Size(523, 23)
        Me.cmbSchema.StatusTip = ""
        Me.cmbSchema.TabIndex = 11
        Me.cmbSchema.ValueText = ""
        '
        'pnlSvrTestAct
        '
        Me.pnlSvrTestAct.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlSvrTestAct.Location = New System.Drawing.Point(3, 452)
        Me.pnlSvrTestAct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSvrTestAct.Name = "pnlSvrTestAct"
        Me.pnlSvrTestAct.Size = New System.Drawing.Size(517, 41)
        Me.pnlSvrTestAct.TabIndex = 16
        '
        'btnAct
        '
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAct.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAct.ForeColor = System.Drawing.Color.LightGray
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAct.Location = New System.Drawing.Point(340, 4)
        Me.btnAct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(84, 33)
        Me.btnAct.TabIndex = 2
        Me.btnAct.Text = "F140/F141"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(430, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(84, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnTest.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTest.FixedHeight = False
        Me.btnTest.FixedWidth = False
        Me.btnTest.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.LightGray
        Me.btnTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnTest.Location = New System.Drawing.Point(3, 4)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Radius = 10
        Me.btnTest.Size = New System.Drawing.Size(84, 33)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "F002"
        Me.btnTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTest.UseRound = True
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lblAlias
        '
        Me.lblAlias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlias.FixedHeight = False
        Me.lblAlias.FixedWidth = False
        Me.lblAlias.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAlias.ForeColor = System.Drawing.Color.Gray
        Me.lblAlias.Location = New System.Drawing.Point(3, 392)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(523, 25)
        Me.lblAlias.TabIndex = 14
        Me.lblAlias.Text = "F019"
        Me.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlias.code = False
        Me.txtAlias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlias.FixedWidth = False
        Me.txtAlias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAlias.impossibleinput = ""
        Me.txtAlias.Location = New System.Drawing.Point(3, 421)
        Me.txtAlias.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Necessary = False
        Me.txtAlias.PossibleInput = ""
        Me.txtAlias.Prefix = ""
        Me.txtAlias.Size = New System.Drawing.Size(523, 25)
        Me.txtAlias.StatusTip = ""
        Me.txtAlias.TabIndex = 15
        Me.txtAlias.Value = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTest, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAct, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 41)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 542)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.FormMovePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmConnection"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Text = "frmConnection"
        Me.FormMovePanel1.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        CType(Me.nudCollectSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSvrTestAct.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormMovePanel1 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents tlpSvrChk As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents pnlSvrTestAct As eXperDB.BaseControls.Panel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnTest As eXperDB.BaseControls.Button
    Friend WithEvents lblIP As eXperDB.BaseControls.Label
    Friend WithEvents nudCollectSecond As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents lblPort As eXperDB.BaseControls.Label
    Friend WithEvents lblUser As eXperDB.BaseControls.Label
    Friend WithEvents lblPW As eXperDB.BaseControls.Label
    Friend WithEvents lblSvrGatSDly As eXperDB.BaseControls.Label
    Friend WithEvents lblDB As eXperDB.BaseControls.Label
    Friend WithEvents txtIP As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPort As eXperDB.BaseControls.TextBox
    Friend WithEvents txtUsr As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPW As eXperDB.BaseControls.TextBox
    Friend WithEvents cmbDbnm As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblSchema As eXperDB.BaseControls.Label
    Friend WithEvents cmbSchema As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents lblAlias As eXperDB.BaseControls.Label
    Friend WithEvents txtAlias As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
End Class
