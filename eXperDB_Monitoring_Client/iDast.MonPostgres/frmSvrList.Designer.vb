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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSvrList))
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
        Me.btnStart = New eXperDB.BaseControls.Button()
        Me.grpMonGrp = New eXperDB.BaseControls.GroupBox()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.rbGrp4 = New eXperDB.BaseControls.RadioButton()
        Me.rbGrp3 = New eXperDB.BaseControls.RadioButton()
        Me.rbGrp2 = New eXperDB.BaseControls.RadioButton()
        Me.pnlMB = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel2 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnGrpSave = New eXperDB.BaseControls.Button()
        Me.pnlM = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel3 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblGroupName = New eXperDB.BaseControls.Label()
        Me.txtGrp1 = New eXperDB.BaseControls.TextBox()
        Me.tlpMonList = New eXperDB.BaseControls.TableLayoutPanel()
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
        Me.lblMonList = New eXperDB.BaseControls.Label()
        Me.tlpSvrList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblSvrList = New eXperDB.BaseControls.Label()
        Me.rbGrp1 = New eXperDB.BaseControls.RadioButton()
        Me.grpAgentSVR = New eXperDB.BaseControls.GroupBox()
        Me.pnlSvrAct = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel5 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnConSave = New eXperDB.BaseControls.Button()
        Me.btnConTest = New eXperDB.BaseControls.Button()
        Me.pnlAgentInfo = New eXperDB.BaseControls.TableLayoutPanel()
        Me.cmbSvrDBNm = New eXperDB.BaseControls.TextBox()
        Me.lblSvrIP = New eXperDB.BaseControls.Label()
        Me.lblSvrPort = New eXperDB.BaseControls.Label()
        Me.lblSvrUsr = New eXperDB.BaseControls.Label()
        Me.lblSvrPwd = New eXperDB.BaseControls.Label()
        Me.lblSvrDBNm = New eXperDB.BaseControls.Label()
        Me.txtSvrIP = New eXperDB.BaseControls.TextBox()
        Me.txtSvrPort = New eXperDB.BaseControls.TextBox()
        Me.txtSvrUsr = New eXperDB.BaseControls.TextBox()
        Me.txtSvrPwd = New eXperDB.BaseControls.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormMovePanel2 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox2 = New eXperDB.Controls.FormControlBox()
        Me.TableLayoutPanel4 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.cmbGrp = New eXperDB.BaseControls.ComboBox()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMonGrp.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlMB.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlM.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpMonList.SuspendLayout()
        CType(Me.dgvMonLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpSvrList.SuspendLayout()
        Me.grpAgentSVR.SuspendLayout()
        Me.pnlSvrAct.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.pnlAgentInfo.SuspendLayout()
        Me.FormMovePanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSvrLst
        '
        Me.dgvSvrLst.AllowUserToAddRows = False
        Me.dgvSvrLst.AllowUserToDeleteRows = False
        Me.dgvSvrLst.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvSvrLst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSvrLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSvrLst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSvrLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCollectYN, Me.colAliasNm, Me.colDBNm, Me.colUser, Me.colIP, Me.colPort, Me.colPW, Me.colLstIP, Me.colGrp, Me.colHostNm, Me.colStartTime, Me.colHARole, Me.colHAHost, Me.colHAPort})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Black
        Me.dgvSvrLst.Location = New System.Drawing.Point(4, 36)
        Me.dgvSvrLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSvrLst.MultiSelect = False
        Me.dgvSvrLst.Name = "dgvSvrLst"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.RowTemplate.Height = 23
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.Size = New System.Drawing.Size(691, 369)
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
        'btnStart
        '
        Me.btnStart.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnStart.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStart.Enabled = False
        Me.btnStart.FixedHeight = False
        Me.btnStart.FixedWidth = False
        Me.btnStart.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.LightGray
        Me.btnStart.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnStart.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(972, 9)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Radius = 10
        Me.btnStart.Size = New System.Drawing.Size(114, 32)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "F027"
        Me.btnStart.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnStart.UseRound = True
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'grpMonGrp
        '
        Me.grpMonGrp.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpMonGrp.AlignString = System.Drawing.StringAlignment.Near
        Me.grpMonGrp.BackColor = System.Drawing.Color.Black
        Me.grpMonGrp.Controls.Add(Me.TableLayoutPanel1)
        Me.grpMonGrp.Dock = System.Windows.Forms.DockStyle.Top
        Edges1.LeftBottom = 0
        Edges1.LeftTop = 20
        Edges1.RightBottom = 0
        Edges1.RightTop = 20
        Me.grpMonGrp.EdgeRound = Edges1
        Me.grpMonGrp.FillColor = System.Drawing.Color.Black
        Me.grpMonGrp.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grpMonGrp.LineWidth = 1
        Me.grpMonGrp.Location = New System.Drawing.Point(6, 215)
        Me.grpMonGrp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMonGrp.Name = "grpMonGrp"
        Me.grpMonGrp.Padding = New System.Windows.Forms.Padding(3, 14, 3, 3)
        Me.grpMonGrp.Size = New System.Drawing.Size(1095, 589)
        Me.grpMonGrp.TabIndex = 11
        Me.grpMonGrp.TabStop = False
        Me.grpMonGrp.Text = "F025"
        Me.grpMonGrp.TitleFont = New System.Drawing.Font("Gulim", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpMonGrp.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpMonGrp.UseGraColor = True
        Me.grpMonGrp.UseRound = True
        Me.grpMonGrp.UseTitle = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rbGrp4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rbGrp3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rbGrp2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlMB, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlM, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rbGrp1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 32)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1089, 554)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'rbGrp4
        '
        Me.rbGrp4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp4.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbGrp4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp4.LineColor = System.Drawing.Color.Gray
        Me.rbGrp4.Location = New System.Drawing.Point(819, 3)
        Me.rbGrp4.Name = "rbGrp4"
        Me.rbGrp4.Radius = 10
        Me.rbGrp4.Size = New System.Drawing.Size(267, 34)
        Me.rbGrp4.TabIndex = 15
        Me.rbGrp4.TabStop = True
        Me.rbGrp4.Text = "F026 1"
        Me.rbGrp4.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp4.UseRound = True
        Me.rbGrp4.UseVisualStyleBackColor = True
        Me.rbGrp4.Warning = False
        Me.rbGrp4.WarningColor = System.Drawing.Color.Red
        '
        'rbGrp3
        '
        Me.rbGrp3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp3.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbGrp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp3.LineColor = System.Drawing.Color.Gray
        Me.rbGrp3.Location = New System.Drawing.Point(547, 3)
        Me.rbGrp3.Name = "rbGrp3"
        Me.rbGrp3.Radius = 10
        Me.rbGrp3.Size = New System.Drawing.Size(266, 34)
        Me.rbGrp3.TabIndex = 14
        Me.rbGrp3.TabStop = True
        Me.rbGrp3.Text = "F026 1"
        Me.rbGrp3.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp3.UseRound = True
        Me.rbGrp3.UseVisualStyleBackColor = True
        Me.rbGrp3.Warning = False
        Me.rbGrp3.WarningColor = System.Drawing.Color.Red
        '
        'rbGrp2
        '
        Me.rbGrp2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbGrp2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp2.LineColor = System.Drawing.Color.Gray
        Me.rbGrp2.Location = New System.Drawing.Point(275, 3)
        Me.rbGrp2.Name = "rbGrp2"
        Me.rbGrp2.Radius = 10
        Me.rbGrp2.Size = New System.Drawing.Size(266, 34)
        Me.rbGrp2.TabIndex = 13
        Me.rbGrp2.TabStop = True
        Me.rbGrp2.Text = "F026 1"
        Me.rbGrp2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp2.UseRound = True
        Me.rbGrp2.UseVisualStyleBackColor = True
        Me.rbGrp2.Warning = False
        Me.rbGrp2.WarningColor = System.Drawing.Color.Red
        '
        'pnlMB
        '
        Me.pnlMB.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.pnlMB, 4)
        Me.pnlMB.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlMB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMB.Location = New System.Drawing.Point(3, 510)
        Me.pnlMB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlMB.Name = "pnlMB"
        Me.pnlMB.Size = New System.Drawing.Size(1083, 40)
        Me.pnlMB.TabIndex = 11
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnGrpSave, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1083, 40)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnGrpSave
        '
        Me.btnGrpSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnGrpSave.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnGrpSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGrpSave.FixedHeight = False
        Me.btnGrpSave.FixedWidth = False
        Me.btnGrpSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnGrpSave.ForeColor = System.Drawing.Color.LightGray
        Me.btnGrpSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrpSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGrpSave.Location = New System.Drawing.Point(966, 4)
        Me.btnGrpSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGrpSave.Name = "btnGrpSave"
        Me.btnGrpSave.Radius = 10
        Me.btnGrpSave.Size = New System.Drawing.Size(114, 32)
        Me.btnGrpSave.TabIndex = 0
        Me.btnGrpSave.Text = "F003"
        Me.btnGrpSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGrpSave.UseRound = True
        Me.btnGrpSave.UseVisualStyleBackColor = True
        '
        'pnlM
        '
        Me.pnlM.BackColor = System.Drawing.Color.Black
        Me.pnlM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.pnlM, 4)
        Me.pnlM.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlM.Location = New System.Drawing.Point(3, 49)
        Me.pnlM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlM.Name = "pnlM"
        Me.pnlM.Size = New System.Drawing.Size(1083, 453)
        Me.pnlM.TabIndex = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblGroupName, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtGrp1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.tlpMonList, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.tlpSvrList, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1081, 451)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblGroupName
        '
        Me.lblGroupName.BackColor = System.Drawing.Color.Transparent
        Me.lblGroupName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGroupName.FixedHeight = False
        Me.lblGroupName.FixedWidth = False
        Me.lblGroupName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGroupName.ForeColor = System.Drawing.Color.Gray
        Me.lblGroupName.Location = New System.Drawing.Point(3, 0)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(114, 29)
        Me.lblGroupName.TabIndex = 5
        Me.lblGroupName.Text = "F310"
        Me.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGrp1
        '
        Me.txtGrp1.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrp1.code = False
        Me.txtGrp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtGrp1.FixedWidth = False
        Me.txtGrp1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGrp1.impossibleinput = ""
        Me.txtGrp1.Location = New System.Drawing.Point(123, 4)
        Me.txtGrp1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrp1.Name = "txtGrp1"
        Me.txtGrp1.Necessary = False
        Me.txtGrp1.PossibleInput = ""
        Me.txtGrp1.Prefix = ""
        Me.txtGrp1.Size = New System.Drawing.Size(144, 25)
        Me.txtGrp1.StatusTip = ""
        Me.txtGrp1.TabIndex = 4
        Me.txtGrp1.Text = "Gruop Name1"
        Me.txtGrp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGrp1.Value = ""
        '
        'tlpMonList
        '
        Me.tlpMonList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpMonList.ColumnCount = 1
        Me.tlpMonList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMonList.Controls.Add(Me.dgvMonLst, 0, 1)
        Me.tlpMonList.Controls.Add(Me.lblMonList, 0, 0)
        Me.tlpMonList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMonList.Location = New System.Drawing.Point(713, 38)
        Me.tlpMonList.Name = "tlpMonList"
        Me.tlpMonList.RowCount = 2
        Me.tlpMonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMonList.Size = New System.Drawing.Size(365, 410)
        Me.tlpMonList.TabIndex = 7
        '
        'dgvMonLst
        '
        Me.dgvMonLst.AllowUserToAddRows = False
        Me.dgvMonLst.AllowUserToDeleteRows = False
        Me.dgvMonLst.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvMonLst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMonLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvMonLst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMonLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMonLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMonAliasNm, Me.colMonDBNm, Me.colMonUser, Me.colMonIP, Me.colMonPort, Me.colMonPW, Me.colMonLstIP, Me.colMonHostNm, Me.colMonStartTime, Me.colMonHARole, Me.colMonHAHost, Me.colMonHAPort})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonLst.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMonLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMonLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMonLst.EnableHeadersVisualStyles = False
        Me.dgvMonLst.GridColor = System.Drawing.Color.Black
        Me.dgvMonLst.Location = New System.Drawing.Point(4, 36)
        Me.dgvMonLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvMonLst.MultiSelect = False
        Me.dgvMonLst.Name = "dgvMonLst"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMonLst.RowHeadersVisible = False
        Me.dgvMonLst.RowTemplate.Height = 23
        Me.dgvMonLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMonLst.Size = New System.Drawing.Size(357, 369)
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
        'lblMonList
        '
        Me.lblMonList.BackColor = System.Drawing.Color.Transparent
        Me.lblMonList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonList.FixedHeight = False
        Me.lblMonList.FixedWidth = False
        Me.lblMonList.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonList.ForeColor = System.Drawing.Color.Gray
        Me.lblMonList.Location = New System.Drawing.Point(4, 1)
        Me.lblMonList.Name = "lblMonList"
        Me.lblMonList.Size = New System.Drawing.Size(357, 30)
        Me.lblMonList.TabIndex = 11
        Me.lblMonList.Text = "F311"
        Me.lblMonList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpSvrList
        '
        Me.tlpSvrList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpSvrList.ColumnCount = 1
        Me.TableLayoutPanel3.SetColumnSpan(Me.tlpSvrList, 3)
        Me.tlpSvrList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrList.Controls.Add(Me.dgvSvrLst, 0, 1)
        Me.tlpSvrList.Controls.Add(Me.lblSvrList, 0, 0)
        Me.tlpSvrList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrList.Location = New System.Drawing.Point(3, 38)
        Me.tlpSvrList.Name = "tlpSvrList"
        Me.tlpSvrList.RowCount = 2
        Me.tlpSvrList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSvrList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrList.Size = New System.Drawing.Size(699, 410)
        Me.tlpSvrList.TabIndex = 6
        '
        'lblSvrList
        '
        Me.lblSvrList.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrList.FixedHeight = False
        Me.lblSvrList.FixedWidth = False
        Me.lblSvrList.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSvrList.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrList.Location = New System.Drawing.Point(4, 1)
        Me.lblSvrList.Name = "lblSvrList"
        Me.lblSvrList.Size = New System.Drawing.Size(691, 30)
        Me.lblSvrList.TabIndex = 10
        Me.lblSvrList.Text = "F013"
        Me.lblSvrList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbGrp1
        '
        Me.rbGrp1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrp1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbGrp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrp1.LineColor = System.Drawing.Color.Gray
        Me.rbGrp1.Location = New System.Drawing.Point(3, 3)
        Me.rbGrp1.Name = "rbGrp1"
        Me.rbGrp1.Radius = 10
        Me.rbGrp1.Size = New System.Drawing.Size(266, 34)
        Me.rbGrp1.TabIndex = 12
        Me.rbGrp1.TabStop = True
        Me.rbGrp1.Text = "F026 1"
        Me.rbGrp1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbGrp1.UseRound = True
        Me.rbGrp1.UseVisualStyleBackColor = True
        Me.rbGrp1.Warning = False
        Me.rbGrp1.WarningColor = System.Drawing.Color.Red
        '
        'grpAgentSVR
        '
        Me.grpAgentSVR.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpAgentSVR.AlignString = System.Drawing.StringAlignment.Near
        Me.grpAgentSVR.BackColor = System.Drawing.Color.Black
        Me.grpAgentSVR.Controls.Add(Me.pnlSvrAct)
        Me.grpAgentSVR.Controls.Add(Me.pnlAgentInfo)
        Me.grpAgentSVR.Dock = System.Windows.Forms.DockStyle.Top
        Edges2.LeftBottom = 0
        Edges2.LeftTop = 20
        Edges2.RightBottom = 0
        Edges2.RightTop = 20
        Me.grpAgentSVR.EdgeRound = Edges2
        Me.grpAgentSVR.FillColor = System.Drawing.Color.Black
        Me.grpAgentSVR.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grpAgentSVR.LineWidth = 1
        Me.grpAgentSVR.Location = New System.Drawing.Point(6, 37)
        Me.grpAgentSVR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAgentSVR.Name = "grpAgentSVR"
        Me.grpAgentSVR.Padding = New System.Windows.Forms.Padding(3, 14, 3, 3)
        Me.grpAgentSVR.Size = New System.Drawing.Size(1095, 178)
        Me.grpAgentSVR.TabIndex = 10
        Me.grpAgentSVR.TabStop = False
        Me.grpAgentSVR.Text = "F001"
        Me.grpAgentSVR.TitleFont = New System.Drawing.Font("Gulim", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpAgentSVR.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpAgentSVR.UseGraColor = True
        Me.grpAgentSVR.UseRound = True
        Me.grpAgentSVR.UseTitle = True
        '
        'pnlSvrAct
        '
        Me.pnlSvrAct.BackColor = System.Drawing.Color.Black
        Me.pnlSvrAct.Controls.Add(Me.TableLayoutPanel5)
        Me.pnlSvrAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSvrAct.Location = New System.Drawing.Point(3, 129)
        Me.pnlSvrAct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSvrAct.Name = "pnlSvrAct"
        Me.pnlSvrAct.Size = New System.Drawing.Size(1089, 46)
        Me.pnlSvrAct.TabIndex = 5
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnConSave, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnConTest, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1089, 46)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'btnConSave
        '
        Me.btnConSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnConSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConSave.FixedHeight = False
        Me.btnConSave.FixedWidth = False
        Me.btnConSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnConSave.ForeColor = System.Drawing.Color.LightGray
        Me.btnConSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConSave.Location = New System.Drawing.Point(972, 4)
        Me.btnConSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConSave.Name = "btnConSave"
        Me.btnConSave.Radius = 10
        Me.btnConSave.Size = New System.Drawing.Size(114, 32)
        Me.btnConSave.TabIndex = 3
        Me.btnConSave.Text = "F003"
        Me.btnConSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConSave.UseRound = True
        Me.btnConSave.UseVisualStyleBackColor = True
        '
        'btnConTest
        '
        Me.btnConTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnConTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConTest.FixedHeight = False
        Me.btnConTest.FixedWidth = False
        Me.btnConTest.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnConTest.ForeColor = System.Drawing.Color.LightGray
        Me.btnConTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConTest.Location = New System.Drawing.Point(852, 4)
        Me.btnConTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConTest.Name = "btnConTest"
        Me.btnConTest.Radius = 10
        Me.btnConTest.Size = New System.Drawing.Size(114, 32)
        Me.btnConTest.TabIndex = 3
        Me.btnConTest.Text = "F309"
        Me.btnConTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConTest.UseRound = True
        Me.btnConTest.UseVisualStyleBackColor = True
        '
        'pnlAgentInfo
        '
        Me.pnlAgentInfo.AutoSize = True
        Me.pnlAgentInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnlAgentInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pnlAgentInfo.ColumnCount = 4
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlAgentInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlAgentInfo.Controls.Add(Me.cmbSvrDBNm, 1, 2)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrIP, 0, 0)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrPort, 2, 0)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrUsr, 0, 1)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrPwd, 2, 1)
        Me.pnlAgentInfo.Controls.Add(Me.lblSvrDBNm, 0, 2)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrIP, 1, 0)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrPort, 3, 0)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrUsr, 1, 1)
        Me.pnlAgentInfo.Controls.Add(Me.txtSvrPwd, 3, 1)
        Me.pnlAgentInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAgentInfo.Location = New System.Drawing.Point(3, 32)
        Me.pnlAgentInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlAgentInfo.Name = "pnlAgentInfo"
        Me.pnlAgentInfo.RowCount = 3
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.pnlAgentInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.pnlAgentInfo.Size = New System.Drawing.Size(1089, 97)
        Me.pnlAgentInfo.TabIndex = 2
        '
        'cmbSvrDBNm
        '
        Me.cmbSvrDBNm.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSvrDBNm.code = False
        Me.cmbSvrDBNm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSvrDBNm.FixedWidth = False
        Me.cmbSvrDBNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSvrDBNm.impossibleinput = ""
        Me.cmbSvrDBNm.Location = New System.Drawing.Point(276, 69)
        Me.cmbSvrDBNm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSvrDBNm.Name = "cmbSvrDBNm"
        Me.cmbSvrDBNm.Necessary = False
        Me.cmbSvrDBNm.PossibleInput = ""
        Me.cmbSvrDBNm.Prefix = ""
        Me.cmbSvrDBNm.Size = New System.Drawing.Size(265, 25)
        Me.cmbSvrDBNm.StatusTip = ""
        Me.cmbSvrDBNm.TabIndex = 5
        Me.cmbSvrDBNm.Value = ""
        '
        'lblSvrIP
        '
        Me.lblSvrIP.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrIP.FixedHeight = False
        Me.lblSvrIP.FixedWidth = False
        Me.lblSvrIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrIP.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrIP.Location = New System.Drawing.Point(4, 1)
        Me.lblSvrIP.Name = "lblSvrIP"
        Me.lblSvrIP.Size = New System.Drawing.Size(265, 31)
        Me.lblSvrIP.TabIndex = 2
        Me.lblSvrIP.Text = "F006"
        Me.lblSvrIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSvrPort
        '
        Me.lblSvrPort.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrPort.FixedHeight = False
        Me.lblSvrPort.FixedWidth = False
        Me.lblSvrPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrPort.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrPort.Location = New System.Drawing.Point(548, 1)
        Me.lblSvrPort.Name = "lblSvrPort"
        Me.lblSvrPort.Size = New System.Drawing.Size(265, 31)
        Me.lblSvrPort.TabIndex = 2
        Me.lblSvrPort.Text = "F007"
        Me.lblSvrPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSvrUsr
        '
        Me.lblSvrUsr.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrUsr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrUsr.FixedHeight = False
        Me.lblSvrUsr.FixedWidth = False
        Me.lblSvrUsr.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrUsr.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrUsr.Location = New System.Drawing.Point(4, 33)
        Me.lblSvrUsr.Name = "lblSvrUsr"
        Me.lblSvrUsr.Size = New System.Drawing.Size(265, 31)
        Me.lblSvrUsr.TabIndex = 2
        Me.lblSvrUsr.Text = "F008"
        Me.lblSvrUsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSvrPwd
        '
        Me.lblSvrPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrPwd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrPwd.FixedHeight = False
        Me.lblSvrPwd.FixedWidth = False
        Me.lblSvrPwd.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrPwd.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrPwd.Location = New System.Drawing.Point(548, 33)
        Me.lblSvrPwd.Name = "lblSvrPwd"
        Me.lblSvrPwd.Size = New System.Drawing.Size(265, 31)
        Me.lblSvrPwd.TabIndex = 2
        Me.lblSvrPwd.Text = "F009"
        Me.lblSvrPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSvrDBNm
        '
        Me.lblSvrDBNm.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrDBNm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrDBNm.FixedHeight = False
        Me.lblSvrDBNm.FixedWidth = False
        Me.lblSvrDBNm.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSvrDBNm.ForeColor = System.Drawing.Color.Gray
        Me.lblSvrDBNm.Location = New System.Drawing.Point(4, 65)
        Me.lblSvrDBNm.Name = "lblSvrDBNm"
        Me.lblSvrDBNm.Size = New System.Drawing.Size(265, 31)
        Me.lblSvrDBNm.TabIndex = 2
        Me.lblSvrDBNm.Text = "F010"
        Me.lblSvrDBNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSvrIP
        '
        Me.txtSvrIP.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrIP.code = False
        Me.txtSvrIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSvrIP.FixedWidth = False
        Me.txtSvrIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrIP.impossibleinput = ""
        Me.txtSvrIP.Location = New System.Drawing.Point(276, 5)
        Me.txtSvrIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrIP.Name = "txtSvrIP"
        Me.txtSvrIP.Necessary = False
        Me.txtSvrIP.PossibleInput = "1234567890."
        Me.txtSvrIP.Prefix = ""
        Me.txtSvrIP.Size = New System.Drawing.Size(265, 25)
        Me.txtSvrIP.StatusTip = ""
        Me.txtSvrIP.TabIndex = 1
        Me.txtSvrIP.Value = ""
        '
        'txtSvrPort
        '
        Me.txtSvrPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrPort.code = False
        Me.txtSvrPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSvrPort.FixedWidth = False
        Me.txtSvrPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrPort.impossibleinput = ""
        Me.txtSvrPort.Location = New System.Drawing.Point(820, 5)
        Me.txtSvrPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrPort.Name = "txtSvrPort"
        Me.txtSvrPort.Necessary = False
        Me.txtSvrPort.PossibleInput = "0123456789"
        Me.txtSvrPort.Prefix = ""
        Me.txtSvrPort.Size = New System.Drawing.Size(265, 25)
        Me.txtSvrPort.StatusTip = ""
        Me.txtSvrPort.TabIndex = 2
        Me.txtSvrPort.Value = ""
        '
        'txtSvrUsr
        '
        Me.txtSvrUsr.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrUsr.code = False
        Me.txtSvrUsr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSvrUsr.FixedWidth = False
        Me.txtSvrUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrUsr.impossibleinput = ""
        Me.txtSvrUsr.Location = New System.Drawing.Point(276, 37)
        Me.txtSvrUsr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrUsr.Name = "txtSvrUsr"
        Me.txtSvrUsr.Necessary = False
        Me.txtSvrUsr.PossibleInput = ""
        Me.txtSvrUsr.Prefix = ""
        Me.txtSvrUsr.Size = New System.Drawing.Size(265, 25)
        Me.txtSvrUsr.StatusTip = ""
        Me.txtSvrUsr.TabIndex = 3
        Me.txtSvrUsr.Value = ""
        '
        'txtSvrPwd
        '
        Me.txtSvrPwd.BackColor = System.Drawing.SystemColors.Window
        Me.txtSvrPwd.code = False
        Me.txtSvrPwd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSvrPwd.FixedWidth = False
        Me.txtSvrPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSvrPwd.impossibleinput = ""
        Me.txtSvrPwd.Location = New System.Drawing.Point(820, 37)
        Me.txtSvrPwd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrPwd.Name = "txtSvrPwd"
        Me.txtSvrPwd.Necessary = False
        Me.txtSvrPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSvrPwd.PossibleInput = ""
        Me.txtSvrPwd.Prefix = ""
        Me.txtSvrPwd.Size = New System.Drawing.Size(265, 25)
        Me.txtSvrPwd.StatusTip = ""
        Me.txtSvrPwd.TabIndex = 4
        Me.txtSvrPwd.Value = ""
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn1.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle14
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
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'FormMovePanel2
        '
        Me.FormMovePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel2.Controls.Add(Me.FormControlBox2)
        Me.FormMovePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel2.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel2.Location = New System.Drawing.Point(6, 6)
        Me.FormMovePanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel2.Name = "FormMovePanel2"
        Me.FormMovePanel2.Size = New System.Drawing.Size(1095, 31)
        Me.FormMovePanel2.TabIndex = 19
        Me.FormMovePanel2.Text = "eXperDB-Monitoring"
        '
        'FormControlBox2
        '
        Me.FormControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox2.CloseBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox2.ConfigBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox2.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox2.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox2.isCritical = False
        Me.FormControlBox2.isLock = False
        Me.FormControlBox2.isPower = True
        Me.FormControlBox2.isRotation = True
        Me.FormControlBox2.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox2.Location = New System.Drawing.Point(1048, 0)
        Me.FormControlBox2.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox2.MaxBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.MinBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Name = "FormControlBox2"
        Me.FormControlBox2.PowerBox = New System.Drawing.Rectangle(-43, 1, 20, 20)
        Me.FormControlBox2.RotationBox = New System.Drawing.Rectangle(-21, 1, 20, 20)
        Me.FormControlBox2.ShowRectCnt = 2
        Me.FormControlBox2.Size = New System.Drawing.Size(45, 22)
        Me.FormControlBox2.TabIndex = 1
        Me.FormControlBox2.Text = "FormControlBox2"
        Me.FormControlBox2.UseConfigBox = True
        Me.FormControlBox2.UseCriticalBox = False
        Me.FormControlBox2.UseDualBox = False
        Me.FormControlBox2.UseLockBox = False
        Me.FormControlBox2.UseMaxBox = False
        Me.FormControlBox2.UseMinBox = False
        Me.FormControlBox2.UsePowerBox = True
        Me.FormControlBox2.UseRotationBox = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cmbGrp, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btnStart, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 803)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1095, 54)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'cmbGrp
        '
        Me.cmbGrp.BackColor = System.Drawing.SystemColors.Window
        Me.cmbGrp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrp.FixedWidth = False
        Me.cmbGrp.FormattingEnabled = True
        Me.cmbGrp.Location = New System.Drawing.Point(802, 19)
        Me.cmbGrp.Name = "cmbGrp"
        Me.cmbGrp.Necessary = False
        Me.cmbGrp.Size = New System.Drawing.Size(154, 23)
        Me.cmbGrp.StatusTip = ""
        Me.cmbGrp.TabIndex = 1
        Me.cmbGrp.ValueText = ""
        '
        'frmSvrList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1107, 863)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.grpMonGrp)
        Me.Controls.Add(Me.grpAgentSVR)
        Me.Controls.Add(Me.FormMovePanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSvrList"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB Server List"
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMonGrp.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlMB.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.pnlM.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tlpMonList.ResumeLayout(False)
        CType(Me.dgvMonLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpSvrList.ResumeLayout(False)
        Me.grpAgentSVR.ResumeLayout(False)
        Me.grpAgentSVR.PerformLayout()
        Me.pnlSvrAct.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.pnlAgentInfo.ResumeLayout(False)
        Me.pnlAgentInfo.PerformLayout()
        Me.FormMovePanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As BaseControls.Button
    Friend WithEvents grpAgentSVR As BaseControls.GroupBox
    Friend WithEvents pnlAgentInfo As BaseControls.TableLayoutPanel
    Friend WithEvents lblSvrIP As BaseControls.Label
    Friend WithEvents lblSvrPort As BaseControls.Label
    Friend WithEvents lblSvrUsr As BaseControls.Label
    Friend WithEvents lblSvrPwd As BaseControls.Label
    Friend WithEvents lblSvrDBNm As BaseControls.Label
    Friend WithEvents txtSvrIP As BaseControls.TextBox
    Friend WithEvents txtSvrPort As BaseControls.TextBox
    Friend WithEvents txtSvrUsr As BaseControls.TextBox
    Friend WithEvents txtSvrPwd As BaseControls.TextBox
    Friend WithEvents pnlSvrAct As BaseControls.Panel
    Friend WithEvents btnConSave As BaseControls.Button
    Friend WithEvents btnConTest As BaseControls.Button
    Friend WithEvents grpMonGrp As eXperDB.BaseControls.GroupBox
    Friend WithEvents pnlM As eXperDB.BaseControls.Panel
    Friend WithEvents btnGrpSave As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents txtGrp1 As eXperDB.BaseControls.TextBox
    Friend WithEvents dgvSvrLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormMovePanel2 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox2 As eXperDB.Controls.FormControlBox
    Friend WithEvents cmbSvrDBNm As eXperDB.BaseControls.TextBox
    Friend WithEvents pnlMB As eXperDB.BaseControls.Panel
    Friend WithEvents TableLayoutPanel3 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblGroupName As eXperDB.BaseControls.Label
    Friend WithEvents rbGrp4 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbGrp3 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbGrp2 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbGrp1 As eXperDB.BaseControls.RadioButton
    Friend WithEvents TableLayoutPanel4 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents cmbGrp As eXperDB.BaseControls.ComboBox
    Friend WithEvents tlpSvrList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpMonList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblSvrList As eXperDB.BaseControls.Label
    Friend WithEvents lblMonList As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel5 As eXperDB.BaseControls.TableLayoutPanel
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

End Class
