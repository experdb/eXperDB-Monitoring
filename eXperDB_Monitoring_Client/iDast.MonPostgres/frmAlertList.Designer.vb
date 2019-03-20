<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertList
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertList))
        Me.tlpHead = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblServer = New eXperDB.BaseControls.Label()
        Me.cmbServer = New eXperDB.BaseControls.ComboBox()
        Me.lblLevel = New eXperDB.BaseControls.Label()
        Me.cmbLevel = New eXperDB.BaseControls.ComboBox()
        Me.lblCheck = New eXperDB.BaseControls.Label()
        Me.cmbCheck = New eXperDB.BaseControls.ComboBox()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.btnConfig = New eXperDB.BaseControls.Button()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.btnCheck = New eXperDB.BaseControls.Button()
        Me.dgvAlertList = New eXperDB.BaseControls.DataGridView()
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuGoto = New eXperDB.BaseControls.ContextMenuStrip()
        Me.mnuGotoClusterDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGotoStatementsStats = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGotoReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.tlpHead.SuspendLayout()
        CType(Me.dgvAlertList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.mnuGoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpHead
        '
        Me.tlpHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpHead.ColumnCount = 11
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.Controls.Add(Me.lblServer, 0, 0)
        Me.tlpHead.Controls.Add(Me.cmbServer, 1, 0)
        Me.tlpHead.Controls.Add(Me.lblLevel, 2, 0)
        Me.tlpHead.Controls.Add(Me.cmbLevel, 3, 0)
        Me.tlpHead.Controls.Add(Me.lblCheck, 4, 0)
        Me.tlpHead.Controls.Add(Me.cmbCheck, 5, 0)
        Me.tlpHead.Controls.Add(Me.lblDuration, 0, 1)
        Me.tlpHead.Controls.Add(Me.dtpSt, 1, 1)
        Me.tlpHead.Controls.Add(Me.lblDuration2, 2, 1)
        Me.tlpHead.Controls.Add(Me.dtpEd, 3, 1)
        Me.tlpHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHead.Font = New System.Drawing.Font("Gulim", 12.27167!)
        Me.tlpHead.Location = New System.Drawing.Point(0, 50)
        Me.tlpHead.Name = "tlpHead"
        Me.tlpHead.RowCount = 3
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpHead.Size = New System.Drawing.Size(1095, 96)
        Me.tlpHead.TabIndex = 5
        '
        'lblServer
        '
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.lblServer.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblServer.FixedHeight = False
        Me.lblServer.FixedWidth = False
        Me.lblServer.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblServer.ForeColor = System.Drawing.Color.White
        Me.lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblServer.Location = New System.Drawing.Point(3, 11)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(64, 29)
        Me.lblServer.TabIndex = 23
        Me.lblServer.Text = "F033"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.cmbServer.Location = New System.Drawing.Point(73, 16)
        Me.cmbServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Necessary = False
        Me.cmbServer.Size = New System.Drawing.Size(150, 20)
        Me.cmbServer.StatusTip = ""
        Me.cmbServer.TabIndex = 17
        Me.cmbServer.ValueText = ""
        '
        'lblLevel
        '
        Me.lblLevel.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLevel.FixedHeight = False
        Me.lblLevel.FixedWidth = False
        Me.lblLevel.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLevel.Location = New System.Drawing.Point(229, 11)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(64, 29)
        Me.lblLevel.TabIndex = 23
        Me.lblLevel.Text = "F247"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.cmbLevel.Location = New System.Drawing.Point(299, 16)
        Me.cmbLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Necessary = False
        Me.cmbLevel.Size = New System.Drawing.Size(150, 20)
        Me.cmbLevel.StatusTip = ""
        Me.cmbLevel.TabIndex = 17
        Me.cmbLevel.ValueText = ""
        '
        'lblCheck
        '
        Me.lblCheck.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblCheck.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCheck.FixedHeight = False
        Me.lblCheck.FixedWidth = False
        Me.lblCheck.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblCheck.ForeColor = System.Drawing.Color.White
        Me.lblCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCheck.Location = New System.Drawing.Point(455, 11)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(64, 29)
        Me.lblCheck.TabIndex = 23
        Me.lblCheck.Text = "F262"
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.cmbCheck.Location = New System.Drawing.Point(525, 16)
        Me.cmbCheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCheck.Name = "cmbCheck"
        Me.cmbCheck.Necessary = False
        Me.cmbCheck.Size = New System.Drawing.Size(150, 20)
        Me.cmbCheck.StatusTip = ""
        Me.cmbCheck.TabIndex = 17
        Me.cmbCheck.ValueText = ""
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.White
        Me.lblDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration.Location = New System.Drawing.Point(3, 51)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(64, 29)
        Me.lblDuration.TabIndex = 25
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(73, 54)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(150, 22)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 19
        Me.dtpSt.Value = New Date(2018, 3, 19, 15, 15, 0, 0)
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDuration2.ForeColor = System.Drawing.Color.White
        Me.lblDuration2.Location = New System.Drawing.Point(229, 51)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(64, 29)
        Me.lblDuration2.TabIndex = 20
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(299, 54)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(150, 22)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 21
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfig.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnConfig.FixedHeight = False
        Me.btnConfig.FixedWidth = False
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfig.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConfig.Location = New System.Drawing.Point(698, 14)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Radius = 5
        Me.btnConfig.Size = New System.Drawing.Size(94, 32)
        Me.btnConfig.TabIndex = 26
        Me.btnConfig.Text = "F264"
        Me.btnConfig.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfig.UseRound = True
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExcel.Location = New System.Drawing.Point(998, 14)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(94, 32)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.Text = "F142"
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseRound = True
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuery.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnQuery.ForeColor = System.Drawing.Color.White
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(898, 14)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(94, 32)
        Me.btnQuery.TabIndex = 10
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheck.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCheck.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCheck.FixedHeight = False
        Me.btnCheck.FixedWidth = False
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCheck.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCheck.Location = New System.Drawing.Point(798, 14)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Radius = 5
        Me.btnCheck.Size = New System.Drawing.Size(94, 32)
        Me.btnCheck.TabIndex = 10
        Me.btnCheck.Text = "F262"
        Me.btnCheck.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCheck.UseRound = True
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'dgvAlertList
        '
        Me.dgvAlertList.AllowUserToAddRows = False
        Me.dgvAlertList.AllowUserToDeleteRows = False
        Me.dgvAlertList.AllowUserToOrderColumns = True
        Me.dgvAlertList.AllowUserToResizeRows = False
        Me.dgvAlertList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvAlertList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAlertList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlertList.ColumnHeadersHeight = 30
        Me.dgvAlertList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAlertList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvAlertSel, Me.coldgvAlertHostName, Me.coldgvAlertINSTANCEID, Me.coldgvAlertHCHKREGREQ, Me.coldgvAlertRegDate, Me.coldgvAlertTime, Me.coldgvAlertType, Me.coldgvAlertLevel, Me.coldgvAlertMessage, Me.coldgvAlertYN, Me.coldgvAlertComment, Me.coldgvAlertIP, Me.coldgvAlertDT})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlertList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAlertList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlertList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAlertList.EnableHeadersVisualStyles = False
        Me.dgvAlertList.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvAlertList.GridColor = System.Drawing.Color.Gray
        Me.dgvAlertList.Location = New System.Drawing.Point(0, 146)
        Me.dgvAlertList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAlertList.Name = "dgvAlertList"
        Me.dgvAlertList.RowHeadersVisible = False
        Me.dgvAlertList.RowHeadersWidth = 45
        Me.dgvAlertList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAlertList.RowTemplate.Height = 23
        Me.dgvAlertList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlertList.Size = New System.Drawing.Size(1095, 511)
        Me.dgvAlertList.TabIndex = 10
        Me.dgvAlertList.TagValueMatchColor = System.Drawing.Color.White
        Me.dgvAlertList.UseTagValueMatchColor = False
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
        Me.coldgvAlertHostName.Width = 130
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
        Me.coldgvAlertTime.Width = 170
        '
        'coldgvAlertType
        '
        Me.coldgvAlertType.DataPropertyName = "HCHK_NAME"
        Me.coldgvAlertType.FillWeight = 120.5725!
        Me.coldgvAlertType.HeaderText = "F258"
        Me.coldgvAlertType.MinimumWidth = 120
        Me.coldgvAlertType.Name = "coldgvAlertType"
        Me.coldgvAlertType.ReadOnly = True
        Me.coldgvAlertType.Width = 120
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
        Me.coldgvAlertMessage.Width = 200
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
        Me.coldgvAlertComment.Width = 200
        '
        'coldgvAlertIP
        '
        Me.coldgvAlertIP.DataPropertyName = "CHECK_IP"
        Me.coldgvAlertIP.FillWeight = 150.0!
        Me.coldgvAlertIP.HeaderText = "F266"
        Me.coldgvAlertIP.MinimumWidth = 150
        Me.coldgvAlertIP.Name = "coldgvAlertIP"
        Me.coldgvAlertIP.ReadOnly = True
        Me.coldgvAlertIP.Width = 150
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnConfig, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExcel, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnQuery, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCheck, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1095, 50)
        Me.TableLayoutPanel2.TabIndex = 18
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
        Me.MsgLabel.Size = New System.Drawing.Size(589, 50)
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
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'mnuGoto
        '
        Me.mnuGoto.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuGoto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGotoClusterDetails, Me.mnuGotoStatementsStats, Me.mnuGotoReports})
        Me.mnuGoto.Name = "mnuPopup"
        Me.mnuGoto.Size = New System.Drawing.Size(186, 70)
        '
        'mnuGotoClusterDetails
        '
        Me.mnuGotoClusterDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mnuGotoClusterDetails.Name = "mnuGotoClusterDetails"
        Me.mnuGotoClusterDetails.Size = New System.Drawing.Size(185, 22)
        Me.mnuGotoClusterDetails.Text = "Time line view"
        '
        'mnuGotoStatementsStats
        '
        Me.mnuGotoStatementsStats.Name = "mnuGotoStatementsStats"
        Me.mnuGotoStatementsStats.Size = New System.Drawing.Size(185, 22)
        Me.mnuGotoStatementsStats.Text = "Statements Statistics"
        '
        'mnuGotoReports
        '
        Me.mnuGotoReports.Name = "mnuGotoReports"
        Me.mnuGotoReports.Size = New System.Drawing.Size(185, 22)
        Me.mnuGotoReports.Text = "Cluster Reports"
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'frmAlertList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1095, 657)
        Me.Controls.Add(Me.dgvAlertList)
        Me.Controls.Add(Me.tlpHead)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MinimumSize = New System.Drawing.Size(1020, 0)
        Me.Name = "frmAlertList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alert List"
        Me.tlpHead.ResumeLayout(False)
        CType(Me.dgvAlertList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.mnuGoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAlertList As eXperDB.BaseControls.DataGridView
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
    Friend WithEvents tlpHead As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnConfig As eXperDB.BaseControls.Button
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblServer As eXperDB.BaseControls.Label
    Friend WithEvents cmbServer As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents cmbLevel As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblLevel As eXperDB.BaseControls.Label
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents lblCheck As eXperDB.BaseControls.Label
    Friend WithEvents cmbCheck As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnCheck As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnuGoto As eXperDB.BaseControls.ContextMenuStrip
    Friend WithEvents mnuGotoClusterDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGotoStatementsStats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGotoReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker

End Class
