<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertList
    Inherits Monitoring.frmMonBase

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpAlertList = New eXperDB.BaseControls.GroupBox()
        Me.tlpBottom = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpAlert = New eXperDB.BaseControls.GroupBox()
        Me.dgvAlertList = New eXperDB.BaseControls.DataGridView()
        Me.tlpHead = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnConfig = New eXperDB.BaseControls.Button()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblServer = New eXperDB.BaseControls.Label()
        Me.cmbServer = New eXperDB.BaseControls.ComboBox()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.cmbLevel = New eXperDB.BaseControls.ComboBox()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.lblLevel = New eXperDB.BaseControls.Label()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.lblCheck = New eXperDB.BaseControls.Label()
        Me.cmbCheck = New eXperDB.BaseControls.ComboBox()
        Me.btnCheck = New eXperDB.BaseControls.Button()
        Me.tlpMain = New eXperDB.BaseControls.TableLayoutPanel()
        Me.spnlMain = New System.Windows.Forms.SplitContainer()
        Me.coldgvAlertSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.coldgvAlertHostName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertINSTANCEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertHCHKREGREQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertRegDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertYN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpAlertList.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.grpAlert.SuspendLayout()
        CType(Me.dgvAlertList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpHead.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        CType(Me.spnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlMain.Panel1.SuspendLayout()
        Me.spnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAlertList
        '
        Me.grpAlertList.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpAlertList.AlignString = System.Drawing.StringAlignment.Near
        Me.grpAlertList.BackColor = System.Drawing.Color.Black
        Me.grpAlertList.Controls.Add(Me.tlpBottom)
        Me.grpAlertList.Dock = System.Windows.Forms.DockStyle.Fill
        Edges2.LeftBottom = 0
        Edges2.RightBottom = 0
        Me.grpAlertList.EdgeRound = Edges2
        Me.grpAlertList.FillColor = System.Drawing.Color.Black
        Me.grpAlertList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.248828!)
        Me.grpAlertList.Icon = Nothing
        Me.grpAlertList.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpAlertList.LineWidth = 1
        Me.grpAlertList.Location = New System.Drawing.Point(3, 4)
        Me.grpAlertList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAlertList.Name = "grpAlertList"
        Me.grpAlertList.Padding = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.tlpMain.SetRowSpan(Me.grpAlertList, 2)
        Me.grpAlertList.Size = New System.Drawing.Size(1538, 923)
        Me.grpAlertList.TabIndex = 1
        Me.grpAlertList.TabStop = False
        Me.grpAlertList.Text = "F255"
        Me.grpAlertList.TitleFont = New System.Drawing.Font("Arial", 11.80804!, System.Drawing.FontStyle.Bold)
        Me.grpAlertList.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpAlertList.UseGraColor = False
        Me.grpAlertList.UseRound = True
        Me.grpAlertList.UseTitle = True
        '
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.Black
        Me.tlpBottom.ColumnCount = 2
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Controls.Add(Me.grpAlert, 0, 1)
        Me.tlpBottom.Controls.Add(Me.tlpHead, 0, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Font = New System.Drawing.Font("Gulim", 12.29418!)
        Me.tlpBottom.Location = New System.Drawing.Point(3, 28)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 2
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.807235!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.19276!))
        Me.tlpBottom.Size = New System.Drawing.Size(1532, 892)
        Me.tlpBottom.TabIndex = 0
        '
        'grpAlert
        '
        Me.grpAlert.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpAlert.AlignString = System.Drawing.StringAlignment.Near
        Me.grpAlert.BackColor = System.Drawing.Color.Black
        Me.tlpBottom.SetColumnSpan(Me.grpAlert, 2)
        Me.grpAlert.Controls.Add(Me.dgvAlertList)
        Me.grpAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.RightBottom = 0
        Me.grpAlert.EdgeRound = Edges1
        Me.grpAlert.FillColor = System.Drawing.Color.Black
        Me.grpAlert.Font = New System.Drawing.Font("Gulim", 11.64405!)
        Me.grpAlert.Icon = CType(resources.GetObject("grpAlert.Icon"), System.Drawing.Icon)
        Me.grpAlert.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpAlert.LineWidth = 1
        Me.grpAlert.Location = New System.Drawing.Point(3, 46)
        Me.grpAlert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAlert.Name = "grpAlert"
        Me.grpAlert.Size = New System.Drawing.Size(1526, 842)
        Me.grpAlert.TabIndex = 4
        Me.grpAlert.TabStop = False
        Me.grpAlert.Text = "F255"
        Me.grpAlert.TitleFont = New System.Drawing.Font("Arial", 11.80804!)
        Me.grpAlert.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpAlert.UseGraColor = True
        Me.grpAlert.UseRound = True
        Me.grpAlert.UseTitle = False
        '
        'dgvAlertList
        '
        Me.dgvAlertList.AllowUserToAddRows = False
        Me.dgvAlertList.AllowUserToDeleteRows = False
        Me.dgvAlertList.AllowUserToOrderColumns = True
        Me.dgvAlertList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlertList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvAlertList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAlertList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAlertList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlertList.ColumnHeadersHeight = 30
        Me.dgvAlertList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAlertList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvAlertSel, Me.coldgvAlertHostName, Me.coldgvAlertINSTANCEID, Me.coldgvAlertHCHKREGREQ, Me.coldgvAlertRegDate, Me.coldgvAlertTime, Me.coldgvAlertType, Me.coldgvAlertLevel, Me.coldgvAlertMessage, Me.coldgvAlertYN, Me.coldgvAlertComment, Me.coldgvAlertIP, Me.coldgvAlertDT})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlertList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAlertList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlertList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAlertList.EnableHeadersVisualStyles = False
        Me.dgvAlertList.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvAlertList.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvAlertList.Location = New System.Drawing.Point(3, 26)
        Me.dgvAlertList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAlertList.Name = "dgvAlertList"
        Me.dgvAlertList.RowHeadersVisible = False
        Me.dgvAlertList.RowHeadersWidth = 45
        Me.dgvAlertList.RowTemplate.Height = 23
        Me.dgvAlertList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlertList.Size = New System.Drawing.Size(1520, 813)
        Me.dgvAlertList.TabIndex = 10
        Me.dgvAlertList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvAlertList.UseTagValueMatchColor = False
        '
        'tlpHead
        '
        Me.tlpHead.ColumnCount = 15
        Me.tlpBottom.SetColumnSpan(Me.tlpHead, 2)
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpHead.Controls.Add(Me.btnConfig, 13, 1)
        Me.tlpHead.Controls.Add(Me.btnExcel, 14, 1)
        Me.tlpHead.Controls.Add(Me.dtpSt, 8, 1)
        Me.tlpHead.Controls.Add(Me.lblServer, 1, 1)
        Me.tlpHead.Controls.Add(Me.cmbServer, 2, 1)
        Me.tlpHead.Controls.Add(Me.lblDuration, 7, 1)
        Me.tlpHead.Controls.Add(Me.cmbLevel, 4, 1)
        Me.tlpHead.Controls.Add(Me.btnQuery, 11, 1)
        Me.tlpHead.Controls.Add(Me.dtpEd, 10, 1)
        Me.tlpHead.Controls.Add(Me.lblLevel, 3, 1)
        Me.tlpHead.Controls.Add(Me.lblDuration2, 9, 1)
        Me.tlpHead.Controls.Add(Me.lblCheck, 5, 1)
        Me.tlpHead.Controls.Add(Me.cmbCheck, 6, 1)
        Me.tlpHead.Controls.Add(Me.btnCheck, 12, 1)
        Me.tlpHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHead.Font = New System.Drawing.Font("Gulim", 12.27167!)
        Me.tlpHead.Location = New System.Drawing.Point(3, 3)
        Me.tlpHead.Name = "tlpHead"
        Me.tlpHead.RowCount = 2
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHead.Size = New System.Drawing.Size(1526, 36)
        Me.tlpHead.TabIndex = 5
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.Black
        Me.btnConfig.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnConfig.FixedHeight = False
        Me.btnConfig.FixedWidth = False
        Me.btnConfig.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnConfig.ForeColor = System.Drawing.Color.LightGray
        Me.btnConfig.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfig.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConfig.Location = New System.Drawing.Point(1309, 5)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Radius = 5
        Me.btnConfig.Size = New System.Drawing.Size(114, 27)
        Me.btnConfig.TabIndex = 26
        Me.btnConfig.Text = "F264"
        Me.btnConfig.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfig.UseRound = True
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Black
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnExcel.ForeColor = System.Drawing.Color.LightGray
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExcel.Location = New System.Drawing.Point(1429, 5)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(94, 27)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.Text = "F142"
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseRound = True
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(775, 7)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(150, 25)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 19
        '
        'lblServer
        '
        Me.lblServer.BackColor = System.Drawing.Color.Black
        Me.lblServer.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblServer.FixedHeight = False
        Me.lblServer.FixedWidth = False
        Me.lblServer.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.lblServer.ForeColor = System.Drawing.Color.LightGray
        Me.lblServer.Location = New System.Drawing.Point(-5, 1)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(94, 35)
        Me.lblServer.TabIndex = 23
        Me.lblServer.Text = "F033"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbServer
        '
        Me.cmbServer.BackColor = System.Drawing.SystemColors.Window
        Me.cmbServer.DisplayMember = "All"
        Me.cmbServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServer.FixedWidth = False
        Me.cmbServer.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Location = New System.Drawing.Point(95, 8)
        Me.cmbServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Necessary = False
        Me.cmbServer.Size = New System.Drawing.Size(134, 23)
        Me.cmbServer.StatusTip = ""
        Me.cmbServer.TabIndex = 17
        Me.cmbServer.ValueText = ""
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.lblDuration.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration.Location = New System.Drawing.Point(675, 1)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(94, 35)
        Me.lblDuration.TabIndex = 25
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLevel.DisplayMember = "All"
        Me.cmbLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevel.FixedWidth = False
        Me.cmbLevel.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"All", "Critical", "Warning"})
        Me.cmbLevel.Location = New System.Drawing.Point(335, 8)
        Me.cmbLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Necessary = False
        Me.cmbLevel.Size = New System.Drawing.Size(114, 23)
        Me.cmbLevel.StatusTip = ""
        Me.cmbLevel.TabIndex = 17
        Me.cmbLevel.ValueText = ""
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.Black
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnQuery.ForeColor = System.Drawing.Color.LightGray
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(1109, 5)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(94, 27)
        Me.btnQuery.TabIndex = 10
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(949, 7)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(150, 25)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 21
        '
        'lblLevel
        '
        Me.lblLevel.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLevel.FixedHeight = False
        Me.lblLevel.FixedWidth = False
        Me.lblLevel.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.lblLevel.ForeColor = System.Drawing.Color.LightGray
        Me.lblLevel.Location = New System.Drawing.Point(235, 1)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(94, 35)
        Me.lblLevel.TabIndex = 23
        Me.lblLevel.Text = "F247"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("Gulim", 7.882284!)
        Me.lblDuration2.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration2.Location = New System.Drawing.Point(935, 1)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(8, 35)
        Me.lblDuration2.TabIndex = 20
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCheck
        '
        Me.lblCheck.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblCheck.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCheck.FixedHeight = False
        Me.lblCheck.FixedWidth = False
        Me.lblCheck.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.lblCheck.ForeColor = System.Drawing.Color.LightGray
        Me.lblCheck.Location = New System.Drawing.Point(455, 1)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(94, 35)
        Me.lblCheck.TabIndex = 23
        Me.lblCheck.Text = "F262"
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCheck
        '
        Me.cmbCheck.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCheck.DisplayMember = "All"
        Me.cmbCheck.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCheck.FixedWidth = False
        Me.cmbCheck.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbCheck.FormattingEnabled = True
        Me.cmbCheck.Items.AddRange(New Object() {"All", "Checked", "Unchecked"})
        Me.cmbCheck.Location = New System.Drawing.Point(555, 8)
        Me.cmbCheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCheck.Name = "cmbCheck"
        Me.cmbCheck.Necessary = False
        Me.cmbCheck.Size = New System.Drawing.Size(114, 23)
        Me.cmbCheck.StatusTip = ""
        Me.cmbCheck.TabIndex = 17
        Me.cmbCheck.ValueText = ""
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Black
        Me.btnCheck.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCheck.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCheck.FixedHeight = False
        Me.btnCheck.FixedWidth = False
        Me.btnCheck.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnCheck.ForeColor = System.Drawing.Color.LightGray
        Me.btnCheck.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCheck.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCheck.Location = New System.Drawing.Point(1209, 5)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Radius = 5
        Me.btnCheck.Size = New System.Drawing.Size(94, 27)
        Me.btnCheck.TabIndex = 10
        Me.btnCheck.Text = "F262"
        Me.btnCheck.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCheck.UseRound = True
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.grpAlertList, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Gulim", 12.29418!)
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.020252!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.97975!))
        Me.tlpMain.Size = New System.Drawing.Size(1544, 931)
        Me.tlpMain.TabIndex = 11
        '
        'spnlMain
        '
        Me.spnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spnlMain.Font = New System.Drawing.Font("Gulim", 13.00051!)
        Me.spnlMain.Location = New System.Drawing.Point(2, 29)
        Me.spnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spnlMain.Name = "spnlMain"
        Me.spnlMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spnlMain.Panel1
        '
        Me.spnlMain.Panel1.Controls.Add(Me.tlpMain)
        Me.spnlMain.Panel1.Font = New System.Drawing.Font("Gulim", 13.00051!)
        '
        'spnlMain.Panel2
        '
        Me.spnlMain.Panel2.Font = New System.Drawing.Font("Gulim", 1.049459!)
        Me.spnlMain.Size = New System.Drawing.Size(1544, 969)
        Me.spnlMain.SplitterDistance = 931
        Me.spnlMain.SplitterWidth = 5
        Me.spnlMain.TabIndex = 12
        '
        'coldgvAlertSel
        '
        Me.coldgvAlertSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvAlertSel.DataPropertyName = "ACCESS_TYPE"
        Me.coldgvAlertSel.FillWeight = 40.0!
        Me.coldgvAlertSel.HeaderText = ""
        Me.coldgvAlertSel.MinimumWidth = 40
        Me.coldgvAlertSel.Name = "coldgvAlertSel"
        Me.coldgvAlertSel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvAlertSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvAlertSel.Width = 40
        '
        'coldgvAlertHostName
        '
        Me.coldgvAlertHostName.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.coldgvAlertHostName.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvAlertHostName.FillWeight = 131.1306!
        Me.coldgvAlertHostName.HeaderText = "F033"
        Me.coldgvAlertHostName.MinimumWidth = 130
        Me.coldgvAlertHostName.Name = "coldgvAlertHostName"
        Me.coldgvAlertHostName.ReadOnly = True
        '
        'coldgvAlertINSTANCEID
        '
        Me.coldgvAlertINSTANCEID.DataPropertyName = "INSTANCE_ID"
        Me.coldgvAlertINSTANCEID.HeaderText = "coldgvAlertINSTANCEID"
        Me.coldgvAlertINSTANCEID.Name = "coldgvAlertINSTANCEID"
        Me.coldgvAlertINSTANCEID.ReadOnly = True
        Me.coldgvAlertINSTANCEID.Visible = False
        '
        'coldgvAlertHCHKREGREQ
        '
        Me.coldgvAlertHCHKREGREQ.DataPropertyName = "HCHK_REG_SEQ"
        Me.coldgvAlertHCHKREGREQ.HeaderText = "coldgvAlertHCHKREGREQ"
        Me.coldgvAlertHCHKREGREQ.Name = "coldgvAlertHCHKREGREQ"
        Me.coldgvAlertHCHKREGREQ.ReadOnly = True
        Me.coldgvAlertHCHKREGREQ.Visible = False
        '
        'coldgvAlertRegDate
        '
        Me.coldgvAlertRegDate.DataPropertyName = "REG_DATE"
        Me.coldgvAlertRegDate.HeaderText = "colRegDate"
        Me.coldgvAlertRegDate.Name = "coldgvAlertRegDate"
        Me.coldgvAlertRegDate.ReadOnly = True
        Me.coldgvAlertRegDate.Visible = False
        '
        'coldgvAlertTime
        '
        Me.coldgvAlertTime.DataPropertyName = "COLLECT_TIME"
        DataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss"
        Me.coldgvAlertTime.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvAlertTime.FillWeight = 171.0869!
        Me.coldgvAlertTime.HeaderText = "F257"
        Me.coldgvAlertTime.MinimumWidth = 170
        Me.coldgvAlertTime.Name = "coldgvAlertTime"
        Me.coldgvAlertTime.ReadOnly = True
        '
        'coldgvAlertType
        '
        Me.coldgvAlertType.DataPropertyName = "HCHK_NAME"
        Me.coldgvAlertType.FillWeight = 120.5725!
        Me.coldgvAlertType.HeaderText = "F258"
        Me.coldgvAlertType.MinimumWidth = 120
        Me.coldgvAlertType.Name = "coldgvAlertType"
        Me.coldgvAlertType.ReadOnly = True
        '
        'coldgvAlertLevel
        '
        Me.coldgvAlertLevel.DataPropertyName = "STATE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "P"
        Me.coldgvAlertLevel.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvAlertLevel.HeaderText = "F247"
        Me.coldgvAlertLevel.MinimumWidth = 100
        Me.coldgvAlertLevel.Name = "coldgvAlertLevel"
        Me.coldgvAlertLevel.ReadOnly = True
        '
        'coldgvAlertMessage
        '
        Me.coldgvAlertMessage.DataPropertyName = "VALUE"
        Me.coldgvAlertMessage.FillWeight = 200.0!
        Me.coldgvAlertMessage.HeaderText = "F259"
        Me.coldgvAlertMessage.MinimumWidth = 200
        Me.coldgvAlertMessage.Name = "coldgvAlertMessage"
        Me.coldgvAlertMessage.ReadOnly = True
        '
        'coldgvAlertYN
        '
        Me.coldgvAlertYN.DataPropertyName = "CHECK_USER_ID"
        Me.coldgvAlertYN.HeaderText = "F262"
        Me.coldgvAlertYN.MinimumWidth = 100
        Me.coldgvAlertYN.Name = "coldgvAlertYN"
        Me.coldgvAlertYN.ReadOnly = True
        '
        'coldgvAlertComment
        '
        Me.coldgvAlertComment.DataPropertyName = "CHECK_COMMENT"
        Me.coldgvAlertComment.FillWeight = 200.0!
        Me.coldgvAlertComment.HeaderText = "F260"
        Me.coldgvAlertComment.MinimumWidth = 200
        Me.coldgvAlertComment.Name = "coldgvAlertComment"
        Me.coldgvAlertComment.ReadOnly = True
        '
        'coldgvAlertIP
        '
        Me.coldgvAlertIP.DataPropertyName = "CHECK_IP"
        Me.coldgvAlertIP.FillWeight = 150.0!
        Me.coldgvAlertIP.HeaderText = "F266"
        Me.coldgvAlertIP.MinimumWidth = 150
        Me.coldgvAlertIP.Name = "coldgvAlertIP"
        Me.coldgvAlertIP.ReadOnly = True
        '
        'coldgvAlertDT
        '
        Me.coldgvAlertDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvAlertDT.DataPropertyName = "CHECK_DT"
        Me.coldgvAlertDT.FillWeight = 170.0!
        Me.coldgvAlertDT.HeaderText = "F261"
        Me.coldgvAlertDT.MinimumWidth = 170
        Me.coldgvAlertDT.Name = "coldgvAlertDT"
        Me.coldgvAlertDT.ReadOnly = True
        '
        'frmAlertList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BaseHeight = 1002
        Me.ClientSize = New System.Drawing.Size(1548, 1000)
        Me.Controls.Add(Me.spnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmAlertList"
        Me.Controls.SetChildIndex(Me.spnlMain, 0)
        Me.grpAlertList.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.grpAlert.ResumeLayout(False)
        CType(Me.dgvAlertList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpHead.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.spnlMain.Panel1.ResumeLayout(False)
        CType(Me.spnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAlertList As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents tlpMain As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpBottom As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents cmbServer As eXperDB.BaseControls.ComboBox
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents spnlMain As System.Windows.Forms.SplitContainer
    Friend WithEvents lblServer As eXperDB.BaseControls.Label
    Friend WithEvents grpAlert As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpHead As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents cmbLevel As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblLevel As eXperDB.BaseControls.Label
    Friend WithEvents lblCheck As eXperDB.BaseControls.Label
    Friend WithEvents cmbCheck As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnCheck As eXperDB.BaseControls.Button
    Friend WithEvents dgvAlertList As eXperDB.BaseControls.DataGridView
    Friend WithEvents btnConfig As eXperDB.BaseControls.Button
    Friend WithEvents coldgvAlertSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents coldgvAlertHostName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertINSTANCEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertHCHKREGREQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertRegDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertMessage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertYN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertComment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertDT As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
