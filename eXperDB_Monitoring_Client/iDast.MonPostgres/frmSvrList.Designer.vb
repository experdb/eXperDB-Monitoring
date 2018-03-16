<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSvrList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSvrList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbServer = New FlatTabControl.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlAgentInfo = New eXperDB.BaseControls.TableLayoutPanel()
        Me.txtSvrPwd = New eXperDB.BaseControls.TextBox()
        Me.txtSvrPort = New eXperDB.BaseControls.TextBox()
        Me.cmbSvrDBNm = New eXperDB.BaseControls.TextBox()
        Me.txtSvrUsr = New eXperDB.BaseControls.TextBox()
        Me.txtSvrIP = New eXperDB.BaseControls.TextBox()
        Me.lblSvrPwd = New eXperDB.BaseControls.Label()
        Me.lblSvrPort = New eXperDB.BaseControls.Label()
        Me.lblSvrDBNm = New eXperDB.BaseControls.Label()
        Me.lblSvrUsr = New eXperDB.BaseControls.Label()
        Me.lblSvrIP = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnConTest = New eXperDB.BaseControls.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmbGrp = New eXperDB.BaseControls.ComboBox()
        Me.dgvSvrLst = New eXperDB.BaseControls.DataGridView()
        Me.colCollectYN = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAliasNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDBNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPW = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.colLstIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrp = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colHostNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHARole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAHost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCollectPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpSvrList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblSvrList = New eXperDB.BaseControls.Label()
        Me.dgvMonLst = New eXperDB.BaseControls.DataGridView()
        Me.colMonAliasNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonDBNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonPW = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.colMonLstIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonHostNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonHARole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonHAHost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonHAPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonPGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonCollectPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpMonList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblMonList = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpGrp = New eXperDB.BaseControls.TableLayoutPanel()
        Me.rbGrp4 = New eXperDB.BaseControls.RadioButton()
        Me.rbGrp3 = New eXperDB.BaseControls.RadioButton()
        Me.rbGrp2 = New eXperDB.BaseControls.RadioButton()
        Me.rbGrp1 = New eXperDB.BaseControls.RadioButton()
        Me.TableLayoutPanel3 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblGroupName = New eXperDB.BaseControls.Label()
        Me.txtGrp1 = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHistory = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStart = New eXperDB.BaseControls.Button()
        Me.btnGrpSave = New eXperDB.BaseControls.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbServer.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlAgentInfo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpSvrList.SuspendLayout()
        CType(Me.dgvMonLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMonList.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.tlpGrp.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbServer
        '
        Me.tbServer.Controls.Add(Me.TabPage1)
        Me.tbServer.Controls.Add(Me.TabPage2)
        Me.tbServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbServer.Location = New System.Drawing.Point(5, 5)
        Me.tbServer.myBackColor = System.Drawing.Color.Gray
        Me.tbServer.Name = "tbServer"
        Me.tbServer.SelectedIndex = 0
        Me.tbServer.Size = New System.Drawing.Size(894, 623)
        Me.tbServer.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.pnlAgentInfo)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(886, 593)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Collection Server Information"
        '
        'pnlAgentInfo
        '
        Me.pnlAgentInfo.AutoSize = True
        Me.pnlAgentInfo.BackColor = System.Drawing.Color.Gray
        Me.pnlAgentInfo.ColumnCount = 4
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206.0!))
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrPwd, 2, 5)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrPort, 2, 4)
        Me.pnlAgentInfo.Controls.Add(Me.cmbSvrDBNm, 2, 3)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrUsr, 2, 2)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrIP, 2, 1)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrPwd, 1, 5)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrPort, 1, 4)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrDBNm, 1, 3)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrUsr, 1, 2)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrIP, 1, 1)
        Me.pnlAgentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAgentInfo.Location = New System.Drawing.Point(3, 60)
        Me.pnlAgentInfo.Name = "pnlAgentInfo"
        Me.pnlAgentInfo.RowCount = 7
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlAgentInfo.Size = New System.Drawing.Size(880, 485)
        Me.pnlAgentInfo.TabIndex = 4
        '
        'txtSvrPwd
        '
        Me.txtSvrPwd.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrPwd.code = False
        Me.txtSvrPwd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSvrPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrPwd.impossibleinput = ""
        Me.txtSvrPwd.Location = New System.Drawing.Point(177, 196)
        Me.txtSvrPwd.Name = "txtSvrPwd"
        Me.txtSvrPwd.Necessary = False
        Me.txtSvrPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSvrPwd.PossibleInput = ""
        Me.txtSvrPwd.Prefix = ""
        Me.txtSvrPwd.Size = New System.Drawing.Size(150, 21)
        Me.txtSvrPwd.StatusTip = ""
        Me.txtSvrPwd.TabIndex = 4
        Me.txtSvrPwd.Value = ""
        '
        'txtSvrPort
        '
        Me.txtSvrPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrPort.code = False
        Me.txtSvrPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSvrPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrPort.impossibleinput = ""
        Me.txtSvrPort.Location = New System.Drawing.Point(177, 156)
        Me.txtSvrPort.Name = "txtSvrPort"
        Me.txtSvrPort.Necessary = False
        Me.txtSvrPort.PossibleInput = "0123456789"
        Me.txtSvrPort.Prefix = ""
        Me.txtSvrPort.Size = New System.Drawing.Size(150, 21)
        Me.txtSvrPort.StatusTip = ""
        Me.txtSvrPort.TabIndex = 2
        Me.txtSvrPort.Value = ""
        '
        'cmbSvrDBNm
        '
        Me.cmbSvrDBNm.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSvrDBNm.code = False
        Me.cmbSvrDBNm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbSvrDBNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSvrDBNm.impossibleinput = ""
        Me.cmbSvrDBNm.Location = New System.Drawing.Point(177, 116)
        Me.cmbSvrDBNm.Name = "cmbSvrDBNm"
        Me.cmbSvrDBNm.Necessary = False
        Me.cmbSvrDBNm.PossibleInput = ""
        Me.cmbSvrDBNm.Prefix = ""
        Me.cmbSvrDBNm.Size = New System.Drawing.Size(150, 21)
        Me.cmbSvrDBNm.StatusTip = ""
        Me.cmbSvrDBNm.TabIndex = 5
        Me.cmbSvrDBNm.Value = ""
        '
        'txtSvrUsr
        '
        Me.txtSvrUsr.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrUsr.code = False
        Me.txtSvrUsr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSvrUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrUsr.impossibleinput = ""
        Me.txtSvrUsr.Location = New System.Drawing.Point(177, 76)
        Me.txtSvrUsr.Name = "txtSvrUsr"
        Me.txtSvrUsr.Necessary = False
        Me.txtSvrUsr.PossibleInput = ""
        Me.txtSvrUsr.Prefix = ""
        Me.txtSvrUsr.Size = New System.Drawing.Size(150, 21)
        Me.txtSvrUsr.StatusTip = ""
        Me.txtSvrUsr.TabIndex = 3
        Me.txtSvrUsr.Value = ""
        '
        'txtSvrIP
        '
        Me.txtSvrIP.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrIP.code = False
        Me.txtSvrIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSvrIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrIP.impossibleinput = ""
        Me.txtSvrIP.Location = New System.Drawing.Point(177, 36)
        Me.txtSvrIP.Name = "txtSvrIP"
        Me.txtSvrIP.Necessary = False
        Me.txtSvrIP.PossibleInput = "1234567890."
        Me.txtSvrIP.Prefix = ""
        Me.txtSvrIP.Size = New System.Drawing.Size(150, 21)
        Me.txtSvrIP.StatusTip = ""
        Me.txtSvrIP.TabIndex = 1
        Me.txtSvrIP.Value = ""
        '
        'lblSvrPwd
        '
        Me.lblSvrPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrPwd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrPwd.FixedHeight = False
        Me.lblSvrPwd.FixedWidth = False
        Me.lblSvrPwd.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrPwd.ForeColor = System.Drawing.Color.White
        Me.lblSvrPwd.Location = New System.Drawing.Point(77, 193)
        Me.lblSvrPwd.Name = "lblSvrPwd"
        Me.lblSvrPwd.Size = New System.Drawing.Size(94, 27)
        Me.lblSvrPwd.TabIndex = 2
        Me.lblSvrPwd.Text = "F009"
        Me.lblSvrPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSvrPort
        '
        Me.lblSvrPort.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrPort.FixedHeight = False
        Me.lblSvrPort.FixedWidth = False
        Me.lblSvrPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrPort.ForeColor = System.Drawing.Color.White
        Me.lblSvrPort.Location = New System.Drawing.Point(77, 151)
        Me.lblSvrPort.Name = "lblSvrPort"
        Me.lblSvrPort.Size = New System.Drawing.Size(94, 29)
        Me.lblSvrPort.TabIndex = 2
        Me.lblSvrPort.Text = "F007"
        Me.lblSvrPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSvrDBNm
        '
        Me.lblSvrDBNm.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrDBNm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrDBNm.FixedHeight = False
        Me.lblSvrDBNm.FixedWidth = False
        Me.lblSvrDBNm.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrDBNm.ForeColor = System.Drawing.Color.White
        Me.lblSvrDBNm.Location = New System.Drawing.Point(77, 113)
        Me.lblSvrDBNm.Name = "lblSvrDBNm"
        Me.lblSvrDBNm.Size = New System.Drawing.Size(94, 27)
        Me.lblSvrDBNm.TabIndex = 2
        Me.lblSvrDBNm.Text = "F010"
        Me.lblSvrDBNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSvrUsr
        '
        Me.lblSvrUsr.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrUsr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrUsr.FixedHeight = False
        Me.lblSvrUsr.FixedWidth = False
        Me.lblSvrUsr.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrUsr.ForeColor = System.Drawing.Color.White
        Me.lblSvrUsr.Location = New System.Drawing.Point(77, 73)
        Me.lblSvrUsr.Name = "lblSvrUsr"
        Me.lblSvrUsr.Size = New System.Drawing.Size(94, 27)
        Me.lblSvrUsr.TabIndex = 2
        Me.lblSvrUsr.Text = "F008"
        Me.lblSvrUsr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSvrIP
        '
        Me.lblSvrIP.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSvrIP.FixedHeight = False
        Me.lblSvrIP.FixedWidth = False
        Me.lblSvrIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrIP.ForeColor = System.Drawing.Color.White
        Me.lblSvrIP.Location = New System.Drawing.Point(77, 33)
        Me.lblSvrIP.Name = "lblSvrIP"
        Me.lblSvrIP.Size = New System.Drawing.Size(94, 27)
        Me.lblSvrIP.TabIndex = 2
        Me.lblSvrIP.Text = "F006"
        Me.lblSvrIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(880, 57)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.ForeColor = System.Drawing.Color.White
        Me.MsgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(834, 57)
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.Text = "Text"
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnConTest, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 545)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(880, 45)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'btnConTest
        '
        Me.btnConTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnConTest.FixedHeight = False
        Me.btnConTest.FixedWidth = False
        Me.btnConTest.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnConTest.ForeColor = System.Drawing.Color.White
        Me.btnConTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConTest.Location = New System.Drawing.Point(383, 3)
        Me.btnConTest.Name = "btnConTest"
        Me.btnConTest.Radius = 10
        Me.btnConTest.Size = New System.Drawing.Size(110, 39)
        Me.btnConTest.TabIndex = 3
        Me.btnConTest.Text = "F309"
        Me.btnConTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConTest.UseRound = True
        Me.btnConTest.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(886, 593)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Monitoring Server List"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel6)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainer2.Size = New System.Drawing.Size(880, 587)
        Me.SplitContainer2.SplitterDistance = 551
        Me.SplitContainer2.TabIndex = 11
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 144)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbGrp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvSvrLst)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpSvrList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvMonLst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlpMonList)
        Me.SplitContainer1.Size = New System.Drawing.Size(880, 407)
        Me.SplitContainer1.SplitterDistance = 588
        Me.SplitContainer1.TabIndex = 10
        '
        'cmbGrp
        '
        Me.cmbGrp.BackColor = System.Drawing.SystemColors.Window
        Me.cmbGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrp.FixedWidth = False
        Me.cmbGrp.FormattingEnabled = True
        Me.cmbGrp.Location = New System.Drawing.Point(154, 178)
        Me.cmbGrp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbGrp.Name = "cmbGrp"
        Me.cmbGrp.Necessary = False
        Me.cmbGrp.Size = New System.Drawing.Size(135, 20)
        Me.cmbGrp.StatusTip = ""
        Me.cmbGrp.TabIndex = 1
        Me.cmbGrp.ValueText = ""
        Me.cmbGrp.Visible = False
        '
        'dgvSvrLst
        '
        Me.dgvSvrLst.AllowUserToAddRows = False
        Me.dgvSvrLst.AllowUserToDeleteRows = False
        Me.dgvSvrLst.AllowUserToResizeRows = False
        Me.dgvSvrLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSvrLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSvrLst.ColumnHeadersHeight = 30
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCollectYN, Me.colAliasNm, Me.colDBNm, Me.colUser, Me.colIP, Me.colPort, Me.colPW, Me.colLstIP, Me.colGrp, Me.colHostNm, Me.colStartTime, Me.colHARole, Me.colHAHost, Me.colHAPort, Me.colPGV, Me.colCollectPeriod})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Gray
        Me.dgvSvrLst.Location = New System.Drawing.Point(0, 54)
        Me.dgvSvrLst.MultiSelect = False
        Me.dgvSvrLst.Name = "dgvSvrLst"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.RowTemplate.Height = 23
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.Size = New System.Drawing.Size(588, 353)
        Me.dgvSvrLst.TabIndex = 9
        Me.dgvSvrLst.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvSvrLst.UseTagValueMatchColor = False
        '
        'colCollectYN
        '
        Me.colCollectYN.FalseValue = "N"
        Me.colCollectYN.HeaderText = "F018"
        Me.colCollectYN.Name = "colCollectYN"
        Me.colCollectYN.TrueValue = "Y"
        Me.colCollectYN.Width = 75
        '
        'colAliasNm
        '
        Me.colAliasNm.HeaderText = "F019"
        Me.colAliasNm.Name = "colAliasNm"
        Me.colAliasNm.ReadOnly = True
        '
        'colDBNm
        '
        Me.colDBNm.HeaderText = "F010"
        Me.colDBNm.Name = "colDBNm"
        Me.colDBNm.ReadOnly = True
        Me.colDBNm.Width = 130
        '
        'colUser
        '
        Me.colUser.HeaderText = "F008"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        '
        'colIP
        '
        Me.colIP.HeaderText = "F006"
        Me.colIP.Name = "colIP"
        Me.colIP.ReadOnly = True
        Me.colIP.Width = 120
        '
        'colPort
        '
        Me.colPort.HeaderText = "F007"
        Me.colPort.Name = "colPort"
        Me.colPort.ReadOnly = True
        Me.colPort.Width = 70
        '
        'colPW
        '
        Me.colPW.HeaderText = "F009"
        Me.colPW.Name = "colPW"
        Me.colPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.colPW.ReadOnly = True
        Me.colPW.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPW.UseSystemPasswordChar = True
        Me.colPW.Visible = False
        Me.colPW.Width = 5
        '
        'colLstIP
        '
        Me.colLstIP.HeaderText = "F020"
        Me.colLstIP.Name = "colLstIP"
        Me.colLstIP.ReadOnly = True
        Me.colLstIP.Visible = False
        '
        'colGrp
        '
        Me.colGrp.HeaderText = "F025"
        Me.colGrp.Name = "colGrp"
        Me.colGrp.Visible = False
        Me.colGrp.Width = 134
        '
        'colHostNm
        '
        Me.colHostNm.HeaderText = "HOST_NAME"
        Me.colHostNm.Name = "colHostNm"
        Me.colHostNm.ReadOnly = True
        Me.colHostNm.Visible = False
        '
        'colStartTime
        '
        Me.colStartTime.HeaderText = "STARTTIME"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.ReadOnly = True
        Me.colStartTime.Visible = False
        '
        'colHARole
        '
        Me.colHARole.HeaderText = "HAROLE"
        Me.colHARole.Name = "colHARole"
        Me.colHARole.Visible = False
        '
        'colHAHost
        '
        Me.colHAHost.HeaderText = "HAHOST"
        Me.colHAHost.Name = "colHAHost"
        Me.colHAHost.Visible = False
        '
        'colHAPort
        '
        Me.colHAPort.HeaderText = "HAPORT"
        Me.colHAPort.Name = "colHAPort"
        Me.colHAPort.Visible = False
        '
        'colPGV
        '
        Me.colPGV.HeaderText = "PGV"
        Me.colPGV.Name = "colPGV"
        Me.colPGV.Visible = False
        '
        'colCollectPeriod
        '
        Me.colCollectPeriod.DataPropertyName = "COLLECT_PERIOD_SEC"
        Me.colCollectPeriod.HeaderText = "PERIOD"
        Me.colCollectPeriod.Name = "colCollectPeriod"
        Me.colCollectPeriod.ReadOnly = True
        Me.colCollectPeriod.Visible = False
        '
        'tlpSvrList
        '
        Me.tlpSvrList.BackColor = System.Drawing.Color.Gray
        Me.tlpSvrList.ColumnCount = 1
        Me.tlpSvrList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrList.Controls.Add(Me.lblSvrList, 0, 1)
        Me.tlpSvrList.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpSvrList.Location = New System.Drawing.Point(0, 0)
        Me.tlpSvrList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tlpSvrList.Name = "tlpSvrList"
        Me.tlpSvrList.RowCount = 2
        Me.tlpSvrList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.tlpSvrList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrList.Size = New System.Drawing.Size(588, 54)
        Me.tlpSvrList.TabIndex = 6
        '
        'lblSvrList
        '
        Me.lblSvrList.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrList.FixedHeight = False
        Me.lblSvrList.FixedWidth = False
        Me.lblSvrList.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSvrList.ForeColor = System.Drawing.Color.White
        Me.lblSvrList.Location = New System.Drawing.Point(3, 14)
        Me.lblSvrList.Name = "lblSvrList"
        Me.lblSvrList.Size = New System.Drawing.Size(582, 40)
        Me.lblSvrList.TabIndex = 10
        Me.lblSvrList.Text = "F013"
        Me.lblSvrList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMonLst
        '
        Me.dgvMonLst.AllowUserToAddRows = False
        Me.dgvMonLst.AllowUserToDeleteRows = False
        Me.dgvMonLst.AllowUserToResizeRows = False
        Me.dgvMonLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvMonLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMonLst.ColumnHeadersHeight = 30
        Me.dgvMonLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMonLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMonAliasNm, Me.colMonDBNm, Me.colMonUser, Me.colMonIP, Me.colMonPort, Me.colMonPW, Me.colMonLstIP, Me.colMonHostNm, Me.colMonStartTime, Me.colMonHARole, Me.colMonHAHost, Me.colMonHAPort, Me.colMonPGV, Me.colMonCollectPeriod})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonLst.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMonLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMonLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMonLst.EnableHeadersVisualStyles = False
        Me.dgvMonLst.GridColor = System.Drawing.Color.Gray
        Me.dgvMonLst.Location = New System.Drawing.Point(0, 54)
        Me.dgvMonLst.MultiSelect = False
        Me.dgvMonLst.Name = "dgvMonLst"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMonLst.RowHeadersVisible = False
        Me.dgvMonLst.RowTemplate.Height = 23
        Me.dgvMonLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMonLst.Size = New System.Drawing.Size(288, 353)
        Me.dgvMonLst.TabIndex = 12
        Me.dgvMonLst.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvMonLst.UseTagValueMatchColor = False
        '
        'colMonAliasNm
        '
        Me.colMonAliasNm.HeaderText = "F019"
        Me.colMonAliasNm.Name = "colMonAliasNm"
        Me.colMonAliasNm.ReadOnly = True
        '
        'colMonDBNm
        '
        Me.colMonDBNm.HeaderText = "F010"
        Me.colMonDBNm.Name = "colMonDBNm"
        Me.colMonDBNm.ReadOnly = True
        Me.colMonDBNm.Visible = False
        Me.colMonDBNm.Width = 130
        '
        'colMonUser
        '
        Me.colMonUser.HeaderText = "F008"
        Me.colMonUser.Name = "colMonUser"
        Me.colMonUser.ReadOnly = True
        Me.colMonUser.Visible = False
        '
        'colMonIP
        '
        Me.colMonIP.HeaderText = "F006"
        Me.colMonIP.Name = "colMonIP"
        Me.colMonIP.ReadOnly = True
        Me.colMonIP.Width = 120
        '
        'colMonPort
        '
        Me.colMonPort.HeaderText = "F007"
        Me.colMonPort.Name = "colMonPort"
        Me.colMonPort.ReadOnly = True
        Me.colMonPort.Width = 70
        '
        'colMonPW
        '
        Me.colMonPW.HeaderText = "F009"
        Me.colMonPW.Name = "colMonPW"
        Me.colMonPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.colMonPW.ReadOnly = True
        Me.colMonPW.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colMonPW.UseSystemPasswordChar = True
        Me.colMonPW.Visible = False
        Me.colMonPW.Width = 5
        '
        'colMonLstIP
        '
        Me.colMonLstIP.HeaderText = "F020"
        Me.colMonLstIP.Name = "colMonLstIP"
        Me.colMonLstIP.ReadOnly = True
        Me.colMonLstIP.Visible = False
        '
        'colMonHostNm
        '
        Me.colMonHostNm.HeaderText = "HOST_NAME"
        Me.colMonHostNm.Name = "colMonHostNm"
        Me.colMonHostNm.ReadOnly = True
        Me.colMonHostNm.Visible = False
        '
        'colMonStartTime
        '
        Me.colMonStartTime.HeaderText = "STARTTIME"
        Me.colMonStartTime.Name = "colMonStartTime"
        Me.colMonStartTime.ReadOnly = True
        Me.colMonStartTime.Visible = False
        '
        'colMonHARole
        '
        Me.colMonHARole.HeaderText = "HAROLE"
        Me.colMonHARole.Name = "colMonHARole"
        Me.colMonHARole.Visible = False
        '
        'colMonHAHost
        '
        Me.colMonHAHost.HeaderText = "HAHOST"
        Me.colMonHAHost.Name = "colMonHAHost"
        Me.colMonHAHost.Visible = False
        '
        'colMonHAPort
        '
        Me.colMonHAPort.HeaderText = "HAPORT"
        Me.colMonHAPort.Name = "colMonHAPort"
        Me.colMonHAPort.Visible = False
        '
        'colMonPGV
        '
        Me.colMonPGV.HeaderText = "PGV"
        Me.colMonPGV.Name = "colMonPGV"
        Me.colMonPGV.Visible = False
        '
        'colMonCollectPeriod
        '
        Me.colMonCollectPeriod.DataPropertyName = "COLLECT_PERIOD_SEC"
        Me.colMonCollectPeriod.HeaderText = "PERIOD"
        Me.colMonCollectPeriod.Name = "colMonCollectPeriod"
        Me.colMonCollectPeriod.ReadOnly = True
        Me.colMonCollectPeriod.Visible = False
        '
        'tlpMonList
        '
        Me.tlpMonList.BackColor = System.Drawing.Color.Gray
        Me.tlpMonList.ColumnCount = 1
        Me.tlpMonList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMonList.Controls.Add(Me.lblMonList, 0, 1)
        Me.tlpMonList.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpMonList.Location = New System.Drawing.Point(0, 0)
        Me.tlpMonList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tlpMonList.Name = "tlpMonList"
        Me.tlpMonList.RowCount = 2
        Me.tlpMonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.tlpMonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMonList.Size = New System.Drawing.Size(288, 54)
        Me.tlpMonList.TabIndex = 7
        '
        'lblMonList
        '
        Me.lblMonList.BackColor = System.Drawing.Color.Transparent
        Me.lblMonList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonList.FixedHeight = False
        Me.lblMonList.FixedWidth = False
        Me.lblMonList.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonList.ForeColor = System.Drawing.Color.White
        Me.lblMonList.Location = New System.Drawing.Point(3, 14)
        Me.lblMonList.Name = "lblMonList"
        Me.lblMonList.Size = New System.Drawing.Size(282, 40)
        Me.lblMonList.TabIndex = 11
        Me.lblMonList.Text = "F311"
        Me.lblMonList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.tlpGrp, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 57)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(880, 87)
        Me.TableLayoutPanel7.TabIndex = 11
        '
        'tlpGrp
        '
        Me.tlpGrp.BackColor = System.Drawing.Color.Gray
        Me.tlpGrp.ColumnCount = 4
        Me.tlpGrp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpGrp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpGrp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpGrp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpGrp.Controls.Add(Me.rbGrp4, 3, 0)
        Me.tlpGrp.Controls.Add(Me.rbGrp3, 2, 0)
        Me.tlpGrp.Controls.Add(Me.rbGrp2, 1, 0)
        Me.tlpGrp.Controls.Add(Me.rbGrp1, 0, 0)
        Me.tlpGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpGrp.Location = New System.Drawing.Point(3, 37)
        Me.tlpGrp.Name = "tlpGrp"
        Me.tlpGrp.RowCount = 1
        Me.tlpGrp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpGrp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpGrp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpGrp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpGrp.Size = New System.Drawing.Size(874, 47)
        Me.tlpGrp.TabIndex = 9
        '
        'rbGrp4
        '
        Me.rbGrp4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp4.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp4.ForeColor = System.Drawing.Color.White
        Me.rbGrp4.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp4.Location = New System.Drawing.Point(657, 2)
        Me.rbGrp4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbGrp4.Name = "rbGrp4"
        Me.rbGrp4.Radius = 10
        Me.rbGrp4.Size = New System.Drawing.Size(214, 43)
        Me.rbGrp4.TabIndex = 15
        Me.rbGrp4.TabStop = True
        Me.rbGrp4.Text = "F026 1"
        Me.rbGrp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGrp4.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp4.UseRound = True
        Me.rbGrp4.UseVisualStyleBackColor = True
        Me.rbGrp4.Warning = False
        Me.rbGrp4.WarningColor = System.Drawing.Color.Red
        '
        'rbGrp3
        '
        Me.rbGrp3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp3.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp3.ForeColor = System.Drawing.Color.White
        Me.rbGrp3.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp3.Location = New System.Drawing.Point(439, 2)
        Me.rbGrp3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbGrp3.Name = "rbGrp3"
        Me.rbGrp3.Radius = 10
        Me.rbGrp3.Size = New System.Drawing.Size(212, 43)
        Me.rbGrp3.TabIndex = 14
        Me.rbGrp3.TabStop = True
        Me.rbGrp3.Text = "F026 1"
        Me.rbGrp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGrp3.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp3.UseRound = True
        Me.rbGrp3.UseVisualStyleBackColor = True
        Me.rbGrp3.Warning = False
        Me.rbGrp3.WarningColor = System.Drawing.Color.Red
        '
        'rbGrp2
        '
        Me.rbGrp2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp2.ForeColor = System.Drawing.Color.White
        Me.rbGrp2.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp2.Location = New System.Drawing.Point(221, 2)
        Me.rbGrp2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbGrp2.Name = "rbGrp2"
        Me.rbGrp2.Radius = 10
        Me.rbGrp2.Size = New System.Drawing.Size(212, 43)
        Me.rbGrp2.TabIndex = 13
        Me.rbGrp2.TabStop = True
        Me.rbGrp2.Text = "F026 1"
        Me.rbGrp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGrp2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp2.UseRound = True
        Me.rbGrp2.UseVisualStyleBackColor = True
        Me.rbGrp2.Warning = False
        Me.rbGrp2.WarningColor = System.Drawing.Color.Red
        '
        'rbGrp1
        '
        Me.rbGrp1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp1.ForeColor = System.Drawing.Color.White
        Me.rbGrp1.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp1.Location = New System.Drawing.Point(3, 2)
        Me.rbGrp1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbGrp1.Name = "rbGrp1"
        Me.rbGrp1.Radius = 10
        Me.rbGrp1.Size = New System.Drawing.Size(212, 43)
        Me.rbGrp1.TabIndex = 12
        Me.rbGrp1.TabStop = True
        Me.rbGrp1.Text = "F026 1"
        Me.rbGrp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGrp1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rbGrp1.UseRound = True
        Me.rbGrp1.UseVisualStyleBackColor = True
        Me.rbGrp1.Warning = False
        Me.rbGrp1.WarningColor = System.Drawing.Color.Red
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 802.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblGroupName, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtGrp1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(874, 30)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblGroupName
        '
        Me.lblGroupName.BackColor = System.Drawing.Color.Transparent
        Me.lblGroupName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGroupName.FixedHeight = False
        Me.lblGroupName.FixedWidth = False
        Me.lblGroupName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGroupName.ForeColor = System.Drawing.Color.White
        Me.lblGroupName.Location = New System.Drawing.Point(3, 0)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(99, 30)
        Me.lblGroupName.TabIndex = 5
        Me.lblGroupName.Text = "F310"
        Me.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGrp1
        '
        Me.txtGrp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGrp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrp1.code = False
        Me.txtGrp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrp1.FixedWidth = False
        Me.txtGrp1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGrp1.impossibleinput = ""
        Me.txtGrp1.Location = New System.Drawing.Point(108, 3)
        Me.txtGrp1.Name = "txtGrp1"
        Me.txtGrp1.Necessary = False
        Me.txtGrp1.PossibleInput = ""
        Me.txtGrp1.Prefix = ""
        Me.txtGrp1.Size = New System.Drawing.Size(796, 21)
        Me.txtGrp1.StatusTip = ""
        Me.txtGrp1.TabIndex = 4
        Me.txtGrp1.Text = "Gruop Name1"
        Me.txtGrp1.Value = ""
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.MsgLabel2, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnHistory, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(880, 57)
        Me.TableLayoutPanel6.TabIndex = 16
        '
        'MsgLabel2
        '
        Me.MsgLabel2.AutoSize = True
        Me.MsgLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MsgLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel2.ForeColor = System.Drawing.Color.White
        Me.MsgLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel2.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel2.Name = "MsgLabel2"
        Me.MsgLabel2.Size = New System.Drawing.Size(794, 57)
        Me.MsgLabel2.TabIndex = 0
        Me.MsgLabel2.Text = "Text"
        Me.MsgLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 57)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "      "
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Silver
        Me.btnHistory.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnHistory.FixedHeight = False
        Me.btnHistory.FixedWidth = False
        Me.btnHistory.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Yellow
        Me.btnHistory.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.LineColor = System.Drawing.Color.LightGray
        Me.btnHistory.Location = New System.Drawing.Point(843, 22)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Radius = 5
        Me.btnHistory.Size = New System.Drawing.Size(34, 31)
        Me.btnHistory.TabIndex = 17
        Me.btnHistory.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnStart, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnGrpSave, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(880, 32)
        Me.TableLayoutPanel4.TabIndex = 10
        '
        'btnStart
        '
        Me.btnStart.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnStart.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnStart.Enabled = False
        Me.btnStart.FixedHeight = False
        Me.btnStart.FixedWidth = False
        Me.btnStart.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.GraColor = System.Drawing.Color.Gray
        Me.btnStart.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(443, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Radius = 10
        Me.btnStart.Size = New System.Drawing.Size(110, 26)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "F027"
        Me.btnStart.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.UseRound = True
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnGrpSave
        '
        Me.btnGrpSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGrpSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnGrpSave.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnGrpSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGrpSave.FixedHeight = False
        Me.btnGrpSave.FixedWidth = False
        Me.btnGrpSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnGrpSave.ForeColor = System.Drawing.Color.White
        Me.btnGrpSave.GraColor = System.Drawing.Color.Gray
        Me.btnGrpSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGrpSave.Location = New System.Drawing.Point(327, 3)
        Me.btnGrpSave.Name = "btnGrpSave"
        Me.btnGrpSave.Radius = 10
        Me.btnGrpSave.Size = New System.Drawing.Size(110, 26)
        Me.btnGrpSave.TabIndex = 0
        Me.btnGrpSave.Text = "F003"
        Me.btnGrpSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGrpSave.UseRound = True
        Me.btnGrpSave.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewPasswordTextBoxColumn1.HeaderText = "F009"
        Me.DataGridViewPasswordTextBoxColumn1.Name = "DataGridViewPasswordTextBoxColumn1"
        Me.DataGridViewPasswordTextBoxColumn1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DataGridViewPasswordTextBoxColumn1.ReadOnly = True
        Me.DataGridViewPasswordTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPasswordTextBoxColumn1.UseSystemPasswordChar = True
        Me.DataGridViewPasswordTextBoxColumn1.Visible = False
        Me.DataGridViewPasswordTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'frmSvrList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 633)
        Me.Controls.Add(Me.tbServer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSvrList"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Server Setting"
        Me.tbServer.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlAgentInfo.ResumeLayout(False)
        Me.pnlAgentInfo.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpSvrList.ResumeLayout(False)
        CType(Me.dgvMonLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMonList.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.tlpGrp.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlpGrp As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents rbGrp4 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbGrp3 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbGrp2 As eXperDB.BaseControls.RadioButton
    Friend WithEvents btnStart As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel3 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblGroupName As eXperDB.BaseControls.Label
    Friend WithEvents txtGrp1 As eXperDB.BaseControls.TextBox
    Friend WithEvents tlpMonList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents dgvMonLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents colMonAliasNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonDBNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonPW As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents colMonLstIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonHostNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonStartTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonHARole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonHAHost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonHAPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonPGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonCollectPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMonList As eXperDB.BaseControls.Label
    Friend WithEvents tlpSvrList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents dgvSvrLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents colCollectYN As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAliasNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDBNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPW As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents colLstIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGrp As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colHostNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStartTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHARole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAHost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCollectPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSvrList As eXperDB.BaseControls.Label
    Friend WithEvents rbGrp1 As eXperDB.BaseControls.RadioButton
    Friend WithEvents pnlAgentInfo As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents cmbSvrDBNm As eXperDB.BaseControls.TextBox
    Friend WithEvents lblSvrIP As eXperDB.BaseControls.Label
    Friend WithEvents lblSvrUsr As eXperDB.BaseControls.Label
    Friend WithEvents lblSvrDBNm As eXperDB.BaseControls.Label
    Friend WithEvents txtSvrIP As eXperDB.BaseControls.TextBox
    Friend WithEvents txtSvrUsr As eXperDB.BaseControls.TextBox
    Friend WithEvents lblSvrPwd As eXperDB.BaseControls.Label
    Friend WithEvents lblSvrPort As eXperDB.BaseControls.Label
    Friend WithEvents txtSvrPort As eXperDB.BaseControls.TextBox
    Friend WithEvents txtSvrPwd As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel5 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnConTest As eXperDB.BaseControls.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnGrpSave As eXperDB.BaseControls.Button
    Friend WithEvents cmbGrp As eXperDB.BaseControls.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnHistory As eXperDB.BaseControls.Button
    Friend WithEvents tbServer As FlatTabControl.FlatTabControl

End Class
