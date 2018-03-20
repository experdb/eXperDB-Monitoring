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
        Me.lblAlias = New eXperDB.BaseControls.Label()
        Me.txtAlias = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnTest = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.nudCollectSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblIP.FixedHeight = False
        Me.lblIP.FixedWidth = False
        Me.lblIP.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.Location = New System.Drawing.Point(3, 40)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(127, 20)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "F006"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCollectSecond
        '
        Me.nudCollectSecond.BackColor = System.Drawing.SystemColors.Window
        Me.nudCollectSecond.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudCollectSecond.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudCollectSecond.FixedWidth = False
        Me.nudCollectSecond.Location = New System.Drawing.Point(136, 276)
        Me.nudCollectSecond.Maximum = New Decimal(New Integer() {1800, 0, 0, 0})
        Me.nudCollectSecond.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCollectSecond.Name = "nudCollectSecond"
        Me.nudCollectSecond.Necessary = False
        Me.nudCollectSecond.Size = New System.Drawing.Size(193, 21)
        Me.nudCollectSecond.StatusTip = ""
        Me.nudCollectSecond.TabIndex = 13
        Me.nudCollectSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCollectSecond.ThousandsSeparator = True
        Me.nudCollectSecond.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPort.FixedHeight = False
        Me.lblPort.FixedWidth = False
        Me.lblPort.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.White
        Me.lblPort.Location = New System.Drawing.Point(3, 80)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(127, 20)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "F007"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUser.FixedHeight = False
        Me.lblUser.FixedWidth = False
        Me.lblUser.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(3, 120)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(127, 20)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "F008"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPW
        '
        Me.lblPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPW.FixedHeight = False
        Me.lblPW.FixedWidth = False
        Me.lblPW.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.White
        Me.lblPW.Location = New System.Drawing.Point(3, 160)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(127, 20)
        Me.lblPW.TabIndex = 6
        Me.lblPW.Text = "F009"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSvrGatSDly
        '
        Me.lblSvrGatSDly.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrGatSDly.FixedHeight = False
        Me.lblSvrGatSDly.FixedWidth = False
        Me.lblSvrGatSDly.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrGatSDly.ForeColor = System.Drawing.Color.White
        Me.lblSvrGatSDly.Location = New System.Drawing.Point(3, 280)
        Me.lblSvrGatSDly.Name = "lblSvrGatSDly"
        Me.lblSvrGatSDly.Size = New System.Drawing.Size(127, 20)
        Me.lblSvrGatSDly.TabIndex = 12
        Me.lblSvrGatSDly.Text = "F011"
        Me.lblSvrGatSDly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDB
        '
        Me.lblDB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDB.FixedHeight = False
        Me.lblDB.FixedWidth = False
        Me.lblDB.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.White
        Me.lblDB.Location = New System.Drawing.Point(3, 200)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(127, 20)
        Me.lblDB.TabIndex = 8
        Me.lblDB.Text = "F010"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.Window
        Me.txtIP.code = False
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtIP.FixedWidth = False
        Me.txtIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIP.impossibleinput = ""
        Me.txtIP.Location = New System.Drawing.Point(136, 36)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Necessary = False
        Me.txtIP.PossibleInput = "0123456789."
        Me.txtIP.Prefix = ""
        Me.txtIP.Size = New System.Drawing.Size(193, 21)
        Me.txtIP.StatusTip = ""
        Me.txtIP.TabIndex = 1
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
        Me.txtPort.Location = New System.Drawing.Point(136, 76)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Necessary = False
        Me.txtPort.PossibleInput = "0123456789"
        Me.txtPort.Prefix = ""
        Me.txtPort.Size = New System.Drawing.Size(193, 21)
        Me.txtPort.StatusTip = ""
        Me.txtPort.TabIndex = 3
        Me.txtPort.Value = ""
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsr.code = False
        Me.txtUsr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUsr.FixedWidth = False
        Me.txtUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUsr.impossibleinput = ""
        Me.txtUsr.Location = New System.Drawing.Point(136, 116)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Necessary = False
        Me.txtUsr.PossibleInput = ""
        Me.txtUsr.Prefix = ""
        Me.txtUsr.Size = New System.Drawing.Size(193, 21)
        Me.txtUsr.StatusTip = ""
        Me.txtUsr.TabIndex = 5
        Me.txtUsr.Value = ""
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.Window
        Me.txtPW.code = False
        Me.txtPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPW.FixedWidth = False
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPW.impossibleinput = ""
        Me.txtPW.Location = New System.Drawing.Point(136, 156)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Necessary = False
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.PossibleInput = ""
        Me.txtPW.Prefix = ""
        Me.txtPW.Size = New System.Drawing.Size(193, 21)
        Me.txtPW.StatusTip = ""
        Me.txtPW.TabIndex = 7
        Me.txtPW.Value = ""
        '
        'cmbDbnm
        '
        Me.cmbDbnm.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDbnm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbDbnm.FixedWidth = False
        Me.cmbDbnm.FormattingEnabled = True
        Me.cmbDbnm.Location = New System.Drawing.Point(136, 197)
        Me.cmbDbnm.Name = "cmbDbnm"
        Me.cmbDbnm.Necessary = False
        Me.cmbDbnm.Size = New System.Drawing.Size(193, 20)
        Me.cmbDbnm.StatusTip = ""
        Me.cmbDbnm.TabIndex = 9
        Me.cmbDbnm.ValueText = ""
        '
        'lblSchema
        '
        Me.lblSchema.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSchema.FixedHeight = False
        Me.lblSchema.FixedWidth = False
        Me.lblSchema.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSchema.ForeColor = System.Drawing.Color.White
        Me.lblSchema.Location = New System.Drawing.Point(3, 240)
        Me.lblSchema.Name = "lblSchema"
        Me.lblSchema.Size = New System.Drawing.Size(127, 20)
        Me.lblSchema.TabIndex = 10
        Me.lblSchema.Text = "F074"
        Me.lblSchema.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSchema
        '
        Me.cmbSchema.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSchema.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbSchema.FixedWidth = False
        Me.cmbSchema.FormattingEnabled = True
        Me.cmbSchema.Location = New System.Drawing.Point(136, 237)
        Me.cmbSchema.Name = "cmbSchema"
        Me.cmbSchema.Necessary = False
        Me.cmbSchema.Size = New System.Drawing.Size(193, 20)
        Me.cmbSchema.StatusTip = ""
        Me.cmbSchema.TabIndex = 11
        Me.cmbSchema.ValueText = ""
        '
        'lblAlias
        '
        Me.lblAlias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAlias.FixedHeight = False
        Me.lblAlias.FixedWidth = False
        Me.lblAlias.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAlias.ForeColor = System.Drawing.Color.White
        Me.lblAlias.Location = New System.Drawing.Point(3, 320)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(127, 20)
        Me.lblAlias.TabIndex = 14
        Me.lblAlias.Text = "F019"
        Me.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlias.code = False
        Me.txtAlias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAlias.FixedWidth = False
        Me.txtAlias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAlias.impossibleinput = ""
        Me.txtAlias.Location = New System.Drawing.Point(136, 316)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Necessary = False
        Me.txtAlias.PossibleInput = ""
        Me.txtAlias.Prefix = ""
        Me.txtAlias.Size = New System.Drawing.Size(193, 21)
        Me.txtAlias.StatusTip = ""
        Me.txtAlias.TabIndex = 15
        Me.txtAlias.Value = ""
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(365, 50)
        Me.TableLayoutPanel2.TabIndex = 16
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
        Me.StatusLabel.Size = New System.Drawing.Size(319, 50)
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTest, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 425)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(365, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.Gray
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(225, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAct
        '
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.Gray
        Me.btnAct.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAct.Location = New System.Drawing.Point(145, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 1
        Me.btnAct.Text = "F140/F141"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnTest.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTest.FixedHeight = False
        Me.btnTest.FixedWidth = False
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.GraColor = System.Drawing.Color.Gray
        Me.btnTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnTest.Location = New System.Drawing.Point(65, 3)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Radius = 10
        Me.btnTest.Size = New System.Drawing.Size(74, 39)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "F002"
        Me.btnTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTest.UseRound = True
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Black
        Me.tlpSvrChk.ColumnCount = 3
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpSvrChk.Controls.Add(Me.nudCollectSecond, 1, 7)
        Me.tlpSvrChk.Controls.Add(Me.txtAlias, 1, 8)
        Me.tlpSvrChk.Controls.Add(Me.lblAlias, 0, 8)
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
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 53)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 10
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(365, 372)
        Me.tlpSvrChk.TabIndex = 18
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 473)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DBMS Information Control"
        CType(Me.nudCollectSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents lblAlias As eXperDB.BaseControls.Label
    Friend WithEvents txtAlias As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents btnTest As eXperDB.BaseControls.Button
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
End Class
