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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSvrList))
        Me.grpSvrLst = New eXperDB.BaseControls.GroupBox()
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
        Me.pnlB = New eXperDB.BaseControls.Panel()
        Me.btnStart = New eXperDB.BaseControls.Button()
        Me.grpMonGrp = New eXperDB.BaseControls.GroupBox()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblGrp1 = New eXperDB.BaseControls.Label()
        Me.lblGrp2 = New eXperDB.BaseControls.Label()
        Me.lblGrp3 = New eXperDB.BaseControls.Label()
        Me.lblGrp4 = New eXperDB.BaseControls.Label()
        Me.txtGrp1 = New eXperDB.BaseControls.TextBox()
        Me.txtGrp2 = New eXperDB.BaseControls.TextBox()
        Me.txtGrp3 = New eXperDB.BaseControls.TextBox()
        Me.txtGrp4 = New eXperDB.BaseControls.TextBox()
        Me.pnlM = New eXperDB.BaseControls.Panel()
        Me.btnGrpSave = New eXperDB.BaseControls.Button()
        Me.grpAgentSVR = New eXperDB.BaseControls.GroupBox()
        Me.pnlSvrAct = New eXperDB.BaseControls.Panel()
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
        Me.grpSvrLst.SuspendLayout()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlB.SuspendLayout()
        Me.grpMonGrp.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlM.SuspendLayout()
        Me.grpAgentSVR.SuspendLayout()
        Me.pnlSvrAct.SuspendLayout()
        Me.pnlAgentInfo.SuspendLayout()
        Me.FormMovePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSvrLst
        '
        Me.grpSvrLst.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSvrLst.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSvrLst.BackColor = System.Drawing.Color.Black
        Me.grpSvrLst.Controls.Add(Me.dgvSvrLst)
        Me.grpSvrLst.Controls.Add(Me.pnlB)
        Me.grpSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.LeftTop = 20
        Edges1.RightBottom = 0
        Edges1.RightTop = 20
        Me.grpSvrLst.EdgeRound = Edges1
        Me.grpSvrLst.FillColor = System.Drawing.Color.Black
        Me.grpSvrLst.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grpSvrLst.LineWidth = 1
        Me.grpSvrLst.Location = New System.Drawing.Point(6, 381)
        Me.grpSvrLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSvrLst.Name = "grpSvrLst"
        Me.grpSvrLst.Padding = New System.Windows.Forms.Padding(3, 14, 3, 3)
        Me.grpSvrLst.Size = New System.Drawing.Size(902, 363)
        Me.grpSvrLst.TabIndex = 12
        Me.grpSvrLst.TabStop = False
        Me.grpSvrLst.Text = "F013"
        Me.grpSvrLst.TitleFont = New System.Drawing.Font("Gulim", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpSvrLst.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpSvrLst.UseGraColor = True
        Me.grpSvrLst.UseRound = True
        Me.grpSvrLst.UseTitle = True
        '
        'dgvSvrLst
        '
        Me.dgvSvrLst.AllowUserToAddRows = False
        Me.dgvSvrLst.AllowUserToDeleteRows = False
        Me.dgvSvrLst.AllowUserToResizeRows = False
        Me.dgvSvrLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSvrLst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSvrLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCollectYN, Me.colAliasNm, Me.colDBNm, Me.colUser, Me.colIP, Me.colPort, Me.colPW, Me.colLstIP, Me.colGrp, Me.colHostNm, Me.colStartTime})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Black
        Me.dgvSvrLst.Location = New System.Drawing.Point(3, 32)
        Me.dgvSvrLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSvrLst.MultiSelect = False
        Me.dgvSvrLst.Name = "dgvSvrLst"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.RowTemplate.Height = 23
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.Size = New System.Drawing.Size(896, 278)
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
        Me.colCollectYN.Width = 80
        '
        'colAliasNm
        '
        Me.colAliasNm.HeaderText = "F019"
        Me.colAliasNm.Name = "colAliasNm"
        Me.colAliasNm.ReadOnly = True
        Me.colAliasNm.Width = 104
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
        'pnlB
        '
        Me.pnlB.BackColor = System.Drawing.Color.Black
        Me.pnlB.Controls.Add(Me.btnStart)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(3, 310)
        Me.pnlB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.Size = New System.Drawing.Size(896, 50)
        Me.pnlB.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnStart.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnStart.FixedHeight = False
        Me.btnStart.FixedWidth = False
        Me.btnStart.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.LightGray
        Me.btnStart.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnStart.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(777, 8)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Radius = 10
        Me.btnStart.Size = New System.Drawing.Size(114, 34)
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
        Me.grpMonGrp.Controls.Add(Me.pnlM)
        Me.grpMonGrp.Dock = System.Windows.Forms.DockStyle.Top
        Edges2.LeftBottom = 0
        Edges2.LeftTop = 20
        Edges2.RightBottom = 0
        Edges2.RightTop = 20
        Me.grpMonGrp.EdgeRound = Edges2
        Me.grpMonGrp.FillColor = System.Drawing.Color.Black
        Me.grpMonGrp.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grpMonGrp.LineWidth = 1
        Me.grpMonGrp.Location = New System.Drawing.Point(6, 222)
        Me.grpMonGrp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMonGrp.Name = "grpMonGrp"
        Me.grpMonGrp.Padding = New System.Windows.Forms.Padding(3, 14, 3, 3)
        Me.grpMonGrp.Size = New System.Drawing.Size(902, 159)
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
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblGrp1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGrp2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGrp3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGrp4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGrp1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGrp2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGrp3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGrp4, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 32)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 79)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'lblGrp1
        '
        Me.lblGrp1.BackColor = System.Drawing.Color.Transparent
        Me.lblGrp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGrp1.FixedHeight = False
        Me.lblGrp1.FixedWidth = False
        Me.lblGrp1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGrp1.ForeColor = System.Drawing.Color.Gray
        Me.lblGrp1.Location = New System.Drawing.Point(4, 1)
        Me.lblGrp1.Name = "lblGrp1"
        Me.lblGrp1.Size = New System.Drawing.Size(216, 29)
        Me.lblGrp1.TabIndex = 0
        Me.lblGrp1.Text = "F026 1"
        Me.lblGrp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrp2
        '
        Me.lblGrp2.BackColor = System.Drawing.Color.Transparent
        Me.lblGrp2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGrp2.FixedHeight = False
        Me.lblGrp2.FixedWidth = False
        Me.lblGrp2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGrp2.ForeColor = System.Drawing.Color.Gray
        Me.lblGrp2.Location = New System.Drawing.Point(227, 1)
        Me.lblGrp2.Name = "lblGrp2"
        Me.lblGrp2.Size = New System.Drawing.Size(216, 29)
        Me.lblGrp2.TabIndex = 1
        Me.lblGrp2.Text = "F026 2"
        Me.lblGrp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrp3
        '
        Me.lblGrp3.BackColor = System.Drawing.Color.Transparent
        Me.lblGrp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGrp3.FixedHeight = False
        Me.lblGrp3.FixedWidth = False
        Me.lblGrp3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGrp3.ForeColor = System.Drawing.Color.Gray
        Me.lblGrp3.Location = New System.Drawing.Point(450, 1)
        Me.lblGrp3.Name = "lblGrp3"
        Me.lblGrp3.Size = New System.Drawing.Size(216, 29)
        Me.lblGrp3.TabIndex = 2
        Me.lblGrp3.Text = "F026 3"
        Me.lblGrp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrp4
        '
        Me.lblGrp4.BackColor = System.Drawing.Color.Transparent
        Me.lblGrp4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGrp4.FixedHeight = False
        Me.lblGrp4.FixedWidth = False
        Me.lblGrp4.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGrp4.ForeColor = System.Drawing.Color.Gray
        Me.lblGrp4.Location = New System.Drawing.Point(673, 1)
        Me.lblGrp4.Name = "lblGrp4"
        Me.lblGrp4.Size = New System.Drawing.Size(219, 29)
        Me.lblGrp4.TabIndex = 3
        Me.lblGrp4.Text = "F026 4"
        Me.lblGrp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGrp1
        '
        Me.txtGrp1.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrp1.code = False
        Me.txtGrp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrp1.FixedWidth = False
        Me.txtGrp1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGrp1.impossibleinput = ""
        Me.txtGrp1.Location = New System.Drawing.Point(4, 35)
        Me.txtGrp1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrp1.Name = "txtGrp1"
        Me.txtGrp1.Necessary = False
        Me.txtGrp1.PossibleInput = ""
        Me.txtGrp1.Prefix = ""
        Me.txtGrp1.Size = New System.Drawing.Size(216, 25)
        Me.txtGrp1.StatusTip = ""
        Me.txtGrp1.TabIndex = 4
        Me.txtGrp1.Text = "Gruop Name1"
        Me.txtGrp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGrp1.Value = ""
        '
        'txtGrp2
        '
        Me.txtGrp2.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrp2.code = False
        Me.txtGrp2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrp2.FixedWidth = False
        Me.txtGrp2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGrp2.impossibleinput = ""
        Me.txtGrp2.Location = New System.Drawing.Point(227, 35)
        Me.txtGrp2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrp2.Name = "txtGrp2"
        Me.txtGrp2.Necessary = False
        Me.txtGrp2.PossibleInput = ""
        Me.txtGrp2.Prefix = ""
        Me.txtGrp2.Size = New System.Drawing.Size(216, 25)
        Me.txtGrp2.StatusTip = ""
        Me.txtGrp2.TabIndex = 5
        Me.txtGrp2.Text = "Gruop Name2"
        Me.txtGrp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGrp2.Value = ""
        '
        'txtGrp3
        '
        Me.txtGrp3.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrp3.code = False
        Me.txtGrp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrp3.FixedWidth = False
        Me.txtGrp3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGrp3.impossibleinput = ""
        Me.txtGrp3.Location = New System.Drawing.Point(450, 35)
        Me.txtGrp3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrp3.Name = "txtGrp3"
        Me.txtGrp3.Necessary = False
        Me.txtGrp3.PossibleInput = ""
        Me.txtGrp3.Prefix = ""
        Me.txtGrp3.Size = New System.Drawing.Size(216, 25)
        Me.txtGrp3.StatusTip = ""
        Me.txtGrp3.TabIndex = 6
        Me.txtGrp3.Text = "Gruop Name3"
        Me.txtGrp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGrp3.Value = ""
        '
        'txtGrp4
        '
        Me.txtGrp4.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrp4.code = False
        Me.txtGrp4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrp4.FixedWidth = False
        Me.txtGrp4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGrp4.impossibleinput = ""
        Me.txtGrp4.Location = New System.Drawing.Point(673, 35)
        Me.txtGrp4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrp4.Name = "txtGrp4"
        Me.txtGrp4.Necessary = False
        Me.txtGrp4.PossibleInput = ""
        Me.txtGrp4.Prefix = ""
        Me.txtGrp4.Size = New System.Drawing.Size(219, 25)
        Me.txtGrp4.StatusTip = ""
        Me.txtGrp4.TabIndex = 7
        Me.txtGrp4.Text = "Gruop Name1"
        Me.txtGrp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGrp4.Value = ""
        '
        'pnlM
        '
        Me.pnlM.BackColor = System.Drawing.Color.Black
        Me.pnlM.Controls.Add(Me.btnGrpSave)
        Me.pnlM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlM.Location = New System.Drawing.Point(3, 111)
        Me.pnlM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlM.Name = "pnlM"
        Me.pnlM.Size = New System.Drawing.Size(896, 45)
        Me.pnlM.TabIndex = 10
        '
        'btnGrpSave
        '
        Me.btnGrpSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrpSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnGrpSave.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnGrpSave.FixedHeight = False
        Me.btnGrpSave.FixedWidth = False
        Me.btnGrpSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnGrpSave.ForeColor = System.Drawing.Color.LightGray
        Me.btnGrpSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrpSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGrpSave.Location = New System.Drawing.Point(775, 9)
        Me.btnGrpSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGrpSave.Name = "btnGrpSave"
        Me.btnGrpSave.Radius = 10
        Me.btnGrpSave.Size = New System.Drawing.Size(114, 34)
        Me.btnGrpSave.TabIndex = 0
        Me.btnGrpSave.Text = "F003"
        Me.btnGrpSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGrpSave.UseRound = True
        Me.btnGrpSave.UseVisualStyleBackColor = True
        '
        'grpAgentSVR
        '
        Me.grpAgentSVR.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpAgentSVR.AlignString = System.Drawing.StringAlignment.Near
        Me.grpAgentSVR.BackColor = System.Drawing.Color.Black
        Me.grpAgentSVR.Controls.Add(Me.pnlSvrAct)
        Me.grpAgentSVR.Controls.Add(Me.pnlAgentInfo)
        Me.grpAgentSVR.Dock = System.Windows.Forms.DockStyle.Top
        Edges3.LeftBottom = 0
        Edges3.LeftTop = 20
        Edges3.RightBottom = 0
        Edges3.RightTop = 20
        Me.grpAgentSVR.EdgeRound = Edges3
        Me.grpAgentSVR.FillColor = System.Drawing.Color.Black
        Me.grpAgentSVR.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grpAgentSVR.LineWidth = 1
        Me.grpAgentSVR.Location = New System.Drawing.Point(6, 37)
        Me.grpAgentSVR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAgentSVR.Name = "grpAgentSVR"
        Me.grpAgentSVR.Padding = New System.Windows.Forms.Padding(3, 14, 3, 3)
        Me.grpAgentSVR.Size = New System.Drawing.Size(902, 185)
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
        Me.pnlSvrAct.Controls.Add(Me.btnConSave)
        Me.pnlSvrAct.Controls.Add(Me.btnConTest)
        Me.pnlSvrAct.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSvrAct.Location = New System.Drawing.Point(3, 129)
        Me.pnlSvrAct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSvrAct.Name = "pnlSvrAct"
        Me.pnlSvrAct.Size = New System.Drawing.Size(896, 45)
        Me.pnlSvrAct.TabIndex = 5
        '
        'btnConSave
        '
        Me.btnConSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnConSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnConSave.ForeColor = System.Drawing.Color.LightGray
        Me.btnConSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConSave.Location = New System.Drawing.Point(780, 4)
        Me.btnConSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConSave.Name = "btnConSave"
        Me.btnConSave.Radius = 10
        Me.btnConSave.Size = New System.Drawing.Size(100, 27)
        Me.btnConSave.TabIndex = 3
        Me.btnConSave.Text = "F003"
        Me.btnConSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConSave.UseRound = True
        Me.btnConSave.UseVisualStyleBackColor = True
        '
        'btnConTest
        '
        Me.btnConTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnConTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConTest.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnConTest.ForeColor = System.Drawing.Color.LightGray
        Me.btnConTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConTest.Location = New System.Drawing.Point(665, 4)
        Me.btnConTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConTest.Name = "btnConTest"
        Me.btnConTest.Radius = 10
        Me.btnConTest.Size = New System.Drawing.Size(100, 27)
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
        Me.pnlAgentInfo.Size = New System.Drawing.Size(896, 97)
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
        Me.cmbSvrDBNm.Location = New System.Drawing.Point(227, 69)
        Me.cmbSvrDBNm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSvrDBNm.Name = "cmbSvrDBNm"
        Me.cmbSvrDBNm.Necessary = False
        Me.cmbSvrDBNm.PossibleInput = ""
        Me.cmbSvrDBNm.Prefix = ""
        Me.cmbSvrDBNm.Size = New System.Drawing.Size(216, 25)
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
        Me.lblSvrIP.Size = New System.Drawing.Size(216, 31)
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
        Me.lblSvrPort.Location = New System.Drawing.Point(450, 1)
        Me.lblSvrPort.Name = "lblSvrPort"
        Me.lblSvrPort.Size = New System.Drawing.Size(216, 31)
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
        Me.lblSvrUsr.Size = New System.Drawing.Size(216, 31)
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
        Me.lblSvrPwd.Location = New System.Drawing.Point(450, 33)
        Me.lblSvrPwd.Name = "lblSvrPwd"
        Me.lblSvrPwd.Size = New System.Drawing.Size(216, 31)
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
        Me.lblSvrDBNm.Size = New System.Drawing.Size(216, 31)
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
        Me.txtSvrIP.Location = New System.Drawing.Point(227, 5)
        Me.txtSvrIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrIP.Name = "txtSvrIP"
        Me.txtSvrIP.Necessary = False
        Me.txtSvrIP.PossibleInput = "1234567890."
        Me.txtSvrIP.Prefix = ""
        Me.txtSvrIP.Size = New System.Drawing.Size(216, 25)
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
        Me.txtSvrPort.Location = New System.Drawing.Point(673, 5)
        Me.txtSvrPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrPort.Name = "txtSvrPort"
        Me.txtSvrPort.Necessary = False
        Me.txtSvrPort.PossibleInput = "0123456789"
        Me.txtSvrPort.Prefix = ""
        Me.txtSvrPort.Size = New System.Drawing.Size(219, 25)
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
        Me.txtSvrUsr.Location = New System.Drawing.Point(227, 37)
        Me.txtSvrUsr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrUsr.Name = "txtSvrUsr"
        Me.txtSvrUsr.Necessary = False
        Me.txtSvrUsr.PossibleInput = ""
        Me.txtSvrUsr.Prefix = ""
        Me.txtSvrUsr.Size = New System.Drawing.Size(216, 25)
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
        Me.txtSvrPwd.Location = New System.Drawing.Point(673, 37)
        Me.txtSvrPwd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSvrPwd.Name = "txtSvrPwd"
        Me.txtSvrPwd.Necessary = False
        Me.txtSvrPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSvrPwd.PossibleInput = ""
        Me.txtSvrPwd.Prefix = ""
        Me.txtSvrPwd.Size = New System.Drawing.Size(219, 25)
        Me.txtSvrPwd.StatusTip = ""
        Me.txtSvrPwd.TabIndex = 4
        Me.txtSvrPwd.Value = ""
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
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
        Me.FormMovePanel2.Size = New System.Drawing.Size(902, 31)
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
        Me.FormControlBox2.Location = New System.Drawing.Point(855, 0)
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
        'frmSvrList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(914, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpSvrLst)
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
        Me.grpSvrLst.ResumeLayout(False)
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlB.ResumeLayout(False)
        Me.grpMonGrp.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlM.ResumeLayout(False)
        Me.grpAgentSVR.ResumeLayout(False)
        Me.grpAgentSVR.PerformLayout()
        Me.pnlSvrAct.ResumeLayout(False)
        Me.pnlAgentInfo.ResumeLayout(False)
        Me.pnlAgentInfo.PerformLayout()
        Me.FormMovePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSvrLst As BaseControls.GroupBox
    Friend WithEvents pnlB As BaseControls.Panel
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
    Friend WithEvents lblGrp1 As eXperDB.BaseControls.Label
    Friend WithEvents lblGrp2 As eXperDB.BaseControls.Label
    Friend WithEvents lblGrp3 As eXperDB.BaseControls.Label
    Friend WithEvents lblGrp4 As eXperDB.BaseControls.Label
    Friend WithEvents txtGrp1 As eXperDB.BaseControls.TextBox
    Friend WithEvents txtGrp2 As eXperDB.BaseControls.TextBox
    Friend WithEvents txtGrp3 As eXperDB.BaseControls.TextBox
    Friend WithEvents txtGrp4 As eXperDB.BaseControls.TextBox
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
    Friend WithEvents cmbSvrDBNm As eXperDB.BaseControls.TextBox

End Class
