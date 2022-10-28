<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertConfigurationForm
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertConfigurationForm))
        Me.tlpCriticalItem4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxDiskUsedRatio = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration4 = New System.Windows.Forms.Label()
        Me.nudDiskUsedRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUDiskUsedRatio = New eXperDB.BaseControls.CheckBox()
        Me.dtbDiskusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxSwapUsedRatio = New eXperDB.BaseControls.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nudSwapUsedRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUSwapUsedRatio = New eXperDB.BaseControls.CheckBox()
        Me.dtbSWAPusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxCPUWaitRatio = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration6 = New System.Windows.Forms.Label()
        Me.nudCPUWaitRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUCPUWaitRatio = New eXperDB.BaseControls.CheckBox()
        Me.dtbCPUwaitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxConnections = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration5 = New System.Windows.Forms.Label()
        Me.nudConnections = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUConnections = New eXperDB.BaseControls.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtbConnections = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.tlpCriticalItem2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxCommitRatio = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration2 = New System.Windows.Forms.Label()
        Me.nudCommitRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUCommitRatio = New eXperDB.BaseControls.CheckBox()
        Me.dtbCommitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxBufferHitRatio = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration1 = New System.Windows.Forms.Label()
        Me.nudBufferHitRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUBufferHitRatio = New eXperDB.BaseControls.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtbBufferhitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.tlpWarningItems = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDelayAlert3 = New System.Windows.Forms.Label()
        Me.lblDelayAlert2 = New System.Windows.Forms.Label()
        Me.lblDelayAlert1 = New System.Windows.Forms.Label()
        Me.nudConfailedcnt = New System.Windows.Forms.NumericUpDown()
        Me.cmbVIP = New eXperDB.BaseControls.ComboBox()
        Me.cmbReplSlot = New eXperDB.BaseControls.ComboBox()
        Me.cmbHAStatus = New eXperDB.BaseControls.ComboBox()
        Me.cbxVirtualIP = New eXperDB.BaseControls.CheckBox()
        Me.cbxReplSlot = New eXperDB.BaseControls.CheckBox()
        Me.cbxHAStatus = New eXperDB.BaseControls.CheckBox()
        Me.cbxConfailedcnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxWALcnt = New eXperDB.BaseControls.CheckBox()
        Me.nudWALcnt = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHAClusterAlert = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBusiness = New eXperDB.BaseControls.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnUserGroup = New eXperDB.BaseControls.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbNotiUsers = New eXperDB.BaseControls.ComboBox()
        Me.cmbNotiLevel = New eXperDB.BaseControls.ComboBox()
        Me.nudNotiCycle = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSMSAlert = New System.Windows.Forms.Label()
        Me.lblTxAlert = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblTransactionAlert = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLongSQLFilter = New eXperDB.BaseControls.Button()
        Me.lblLockTransaction = New System.Windows.Forms.Label()
        Me.nudLockTransactionRTime = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxInvalidindex = New eXperDB.BaseControls.CheckBox()
        Me.nudFrozenMaxAgeCritical = New System.Windows.Forms.NumericUpDown()
        Me.nudIdletranscntCritical = New System.Windows.Forms.NumericUpDown()
        Me.nudLongrunsqlsecCritical = New System.Windows.Forms.NumericUpDown()
        Me.nudLockedtranccntCritical = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudFrozenMaxAge = New System.Windows.Forms.NumericUpDown()
        Me.cbxFrozenAge = New eXperDB.BaseControls.CheckBox()
        Me.nudLockedtranccnt = New System.Windows.Forms.NumericUpDown()
        Me.nudLongrunsqlsec = New System.Windows.Forms.NumericUpDown()
        Me.nudLastvacuumDay = New System.Windows.Forms.NumericUpDown()
        Me.nudIdletranscnt = New System.Windows.Forms.NumericUpDown()
        Me.nudUnusedindexcnt = New System.Windows.Forms.NumericUpDown()
        Me.nudLastAnalyzeday = New System.Windows.Forms.NumericUpDown()
        Me.cbxLockedtranccnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxLongrunsqlsec = New eXperDB.BaseControls.CheckBox()
        Me.cbxLastvacuumDay = New eXperDB.BaseControls.CheckBox()
        Me.cbxIdletranscnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxLastAnalyzeday = New eXperDB.BaseControls.CheckBox()
        Me.cbxUnusedindexcnt = New eXperDB.BaseControls.CheckBox()
        Me.tlpAlertConfigurationMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCriticalItem9 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxMemoryUsedRatio = New eXperDB.BaseControls.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.nudMemoryUsedRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUMemoryUsedRatio = New eXperDB.BaseControls.CheckBox()
        Me.dtbMEMusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem8 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxCPUUtilRatio = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration8 = New System.Windows.Forms.Label()
        Me.nudCPUUtilRatio = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUCPUUtilRatio = New eXperDB.BaseControls.CheckBox()
        Me.dtbCPUutilratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem7 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxReplicationDelay = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration7 = New System.Windows.Forms.Label()
        Me.nudReplicationDelay = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUReplicationDelay = New eXperDB.BaseControls.CheckBox()
        Me.dtbReplicationDelay = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem4.SuspendLayout()
        CType(Me.nudDiskUsedRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem3.SuspendLayout()
        CType(Me.nudSwapUsedRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem6.SuspendLayout()
        CType(Me.nudCPUWaitRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem5.SuspendLayout()
        CType(Me.nudConnections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem2.SuspendLayout()
        CType(Me.nudCommitRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem1.SuspendLayout()
        CType(Me.nudBufferHitRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpWarningItems.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.nudConfailedcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWALcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudNotiCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblTransactionAlert.SuspendLayout()
        CType(Me.nudLockTransactionRTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrozenMaxAgeCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIdletranscntCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLongrunsqlsecCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLockedtranccntCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrozenMaxAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLockedtranccnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLongrunsqlsec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastvacuumDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIdletranscnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnusedindexcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastAnalyzeday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAlertConfigurationMain.SuspendLayout()
        Me.tlpCriticalItem9.SuspendLayout()
        CType(Me.nudMemoryUsedRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem8.SuspendLayout()
        CType(Me.nudCPUUtilRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem7.SuspendLayout()
        CType(Me.nudReplicationDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpCriticalItem4
        '
        Me.tlpCriticalItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem4.ColumnCount = 4
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem4.Controls.Add(Me.cbxDiskUsedRatio, 1, 0)
        Me.tlpCriticalItem4.Controls.Add(Me.lblDuration4, 2, 2)
        Me.tlpCriticalItem4.Controls.Add(Me.nudDiskUsedRatio, 1, 2)
        Me.tlpCriticalItem4.Controls.Add(Me.cbxDUDiskUsedRatio, 2, 1)
        Me.tlpCriticalItem4.Controls.Add(Me.dtbDiskusedratio, 0, 1)
        Me.tlpCriticalItem4.Controls.Add(Me.Label13, 0, 0)
        Me.tlpCriticalItem4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem4.Location = New System.Drawing.Point(3, 147)
        Me.tlpCriticalItem4.Name = "tlpCriticalItem4"
        Me.tlpCriticalItem4.RowCount = 3
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem4.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem4.TabIndex = 3
        '
        'cbxDiskUsedRatio
        '
        Me.cbxDiskUsedRatio.AutoSize = True
        Me.cbxDiskUsedRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem4.SetColumnSpan(Me.cbxDiskUsedRatio, 2)
        Me.cbxDiskUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDiskUsedRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDiskUsedRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDiskUsedRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxDiskUsedRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDiskUsedRatio.Name = "cbxDiskUsedRatio"
        Me.cbxDiskUsedRatio.Radius = 10
        Me.cbxDiskUsedRatio.Size = New System.Drawing.Size(308, 18)
        Me.cbxDiskUsedRatio.TabIndex = 1
        Me.cbxDiskUsedRatio.Text = "Disk used ratio(%)"
        Me.cbxDiskUsedRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDiskUsedRatio.UseVisualStyleBackColor = True
        '
        'lblDuration4
        '
        Me.lblDuration4.AutoSize = True
        Me.lblDuration4.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration4.ForeColor = System.Drawing.Color.White
        Me.lblDuration4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration4.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration4.Name = "lblDuration4"
        Me.lblDuration4.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration4.TabIndex = 5
        Me.lblDuration4.Text = "min"
        Me.lblDuration4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDiskUsedRatio
        '
        Me.nudDiskUsedRatio.BackColor = System.Drawing.Color.White
        Me.nudDiskUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDiskUsedRatio.Enabled = False
        Me.nudDiskUsedRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDiskUsedRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudDiskUsedRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDiskUsedRatio.Name = "nudDiskUsedRatio"
        Me.nudDiskUsedRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudDiskUsedRatio.TabIndex = 4
        Me.nudDiskUsedRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUDiskUsedRatio
        '
        Me.cbxDUDiskUsedRatio.AutoSize = True
        Me.cbxDUDiskUsedRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem4.SetColumnSpan(Me.cbxDUDiskUsedRatio, 2)
        Me.cbxDUDiskUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUDiskUsedRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUDiskUsedRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUDiskUsedRatio.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUDiskUsedRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUDiskUsedRatio.Name = "cbxDUDiskUsedRatio"
        Me.cbxDUDiskUsedRatio.Radius = 10
        Me.cbxDUDiskUsedRatio.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUDiskUsedRatio.TabIndex = 3
        Me.cbxDUDiskUsedRatio.Text = "Alert Duration"
        Me.cbxDUDiskUsedRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUDiskUsedRatio.UseVisualStyleBackColor = True
        '
        'dtbDiskusedratio
        '
        Me.dtbDiskusedratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbDiskusedratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbDiskusedratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbDiskusedratio.BarMaxValue = 70
        Me.dtbDiskusedratio.BarMinValue = 50
        Me.dtbDiskusedratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbDiskusedratio.CaptionSpacing = 10
        Me.tlpCriticalItem4.SetColumnSpan(Me.dtbDiskusedratio, 2)
        Me.dtbDiskusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbDiskusedratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbDiskusedratio.ForeColor = System.Drawing.Color.White
        Me.dtbDiskusedratio.Location = New System.Drawing.Point(3, 21)
        Me.dtbDiskusedratio.LRPadding = 12
        Me.dtbDiskusedratio.Name = "dtbDiskusedratio"
        Me.tlpCriticalItem4.SetRowSpan(Me.dtbDiskusedratio, 2)
        Me.dtbDiskusedratio.Size = New System.Drawing.Size(282, 42)
        Me.dtbDiskusedratio.TabIndex = 2
        Me.dtbDiskusedratio.TabStop = False
        Me.dtbDiskusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbDiskusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbDiskusedratio.TickSpacing = 20
        Me.dtbDiskusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratio.TrackHeight = 2
        Me.dtbDiskusedratio.TrackToCaptionDistance = 14
        Me.dtbDiskusedratio.TrackToTickInterval = 4
        Me.dtbDiskusedratio.YPosition = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "      "
        '
        'tlpCriticalItem3
        '
        Me.tlpCriticalItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem3.ColumnCount = 4
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem3.Controls.Add(Me.cbxSwapUsedRatio, 1, 0)
        Me.tlpCriticalItem3.Controls.Add(Me.Label23, 3, 2)
        Me.tlpCriticalItem3.Controls.Add(Me.nudSwapUsedRatio, 2, 2)
        Me.tlpCriticalItem3.Controls.Add(Me.cbxDUSwapUsedRatio, 2, 1)
        Me.tlpCriticalItem3.Controls.Add(Me.dtbSWAPusedratio, 0, 1)
        Me.tlpCriticalItem3.Controls.Add(Me.Label11, 0, 0)
        Me.tlpCriticalItem3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem3.Location = New System.Drawing.Point(3, 507)
        Me.tlpCriticalItem3.Name = "tlpCriticalItem3"
        Me.tlpCriticalItem3.RowCount = 3
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem3.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem3.TabIndex = 8
        '
        'cbxSwapUsedRatio
        '
        Me.cbxSwapUsedRatio.AutoSize = True
        Me.cbxSwapUsedRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem3.SetColumnSpan(Me.cbxSwapUsedRatio, 2)
        Me.cbxSwapUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxSwapUsedRatio.ForeColor = System.Drawing.Color.White
        Me.cbxSwapUsedRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxSwapUsedRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxSwapUsedRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxSwapUsedRatio.Name = "cbxSwapUsedRatio"
        Me.cbxSwapUsedRatio.Radius = 10
        Me.cbxSwapUsedRatio.Size = New System.Drawing.Size(308, 18)
        Me.cbxSwapUsedRatio.TabIndex = 1
        Me.cbxSwapUsedRatio.Text = "SWAP used ratio (%)"
        Me.cbxSwapUsedRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxSwapUsedRatio.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(351, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 30)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "min"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSwapUsedRatio
        '
        Me.nudSwapUsedRatio.BackColor = System.Drawing.Color.White
        Me.nudSwapUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSwapUsedRatio.Enabled = False
        Me.nudSwapUsedRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudSwapUsedRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudSwapUsedRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudSwapUsedRatio.Name = "nudSwapUsedRatio"
        Me.nudSwapUsedRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudSwapUsedRatio.TabIndex = 4
        Me.nudSwapUsedRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUSwapUsedRatio
        '
        Me.cbxDUSwapUsedRatio.AutoSize = True
        Me.cbxDUSwapUsedRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem3.SetColumnSpan(Me.cbxDUSwapUsedRatio, 2)
        Me.cbxDUSwapUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUSwapUsedRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUSwapUsedRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUSwapUsedRatio.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUSwapUsedRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUSwapUsedRatio.Name = "cbxDUSwapUsedRatio"
        Me.cbxDUSwapUsedRatio.Radius = 10
        Me.cbxDUSwapUsedRatio.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUSwapUsedRatio.TabIndex = 3
        Me.cbxDUSwapUsedRatio.Text = "Alert Duration"
        Me.cbxDUSwapUsedRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUSwapUsedRatio.UseVisualStyleBackColor = True
        '
        'dtbSWAPusedratio
        '
        Me.dtbSWAPusedratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbSWAPusedratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbSWAPusedratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbSWAPusedratio.BarMaxValue = 70
        Me.dtbSWAPusedratio.BarMinValue = 50
        Me.dtbSWAPusedratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbSWAPusedratio.CaptionSpacing = 10
        Me.tlpCriticalItem3.SetColumnSpan(Me.dtbSWAPusedratio, 2)
        Me.dtbSWAPusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbSWAPusedratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbSWAPusedratio.ForeColor = System.Drawing.Color.White
        Me.dtbSWAPusedratio.Location = New System.Drawing.Point(3, 21)
        Me.dtbSWAPusedratio.LRPadding = 12
        Me.dtbSWAPusedratio.Name = "dtbSWAPusedratio"
        Me.tlpCriticalItem3.SetRowSpan(Me.dtbSWAPusedratio, 2)
        Me.dtbSWAPusedratio.Size = New System.Drawing.Size(282, 42)
        Me.dtbSWAPusedratio.TabIndex = 2
        Me.dtbSWAPusedratio.TabStop = False
        Me.dtbSWAPusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbSWAPusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbSWAPusedratio.TickSpacing = 20
        Me.dtbSWAPusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratio.TrackHeight = 2
        Me.dtbSWAPusedratio.TrackToCaptionDistance = 14
        Me.dtbSWAPusedratio.TrackToTickInterval = 4
        Me.dtbSWAPusedratio.YPosition = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "      "
        '
        'tlpCriticalItem6
        '
        Me.tlpCriticalItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem6.ColumnCount = 4
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem6.Controls.Add(Me.cbxCPUWaitRatio, 1, 0)
        Me.tlpCriticalItem6.Controls.Add(Me.lblDuration6, 2, 2)
        Me.tlpCriticalItem6.Controls.Add(Me.nudCPUWaitRatio, 1, 2)
        Me.tlpCriticalItem6.Controls.Add(Me.cbxDUCPUWaitRatio, 2, 1)
        Me.tlpCriticalItem6.Controls.Add(Me.dtbCPUwaitratio, 0, 1)
        Me.tlpCriticalItem6.Controls.Add(Me.Label9, 0, 0)
        Me.tlpCriticalItem6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem6.Location = New System.Drawing.Point(3, 363)
        Me.tlpCriticalItem6.Name = "tlpCriticalItem6"
        Me.tlpCriticalItem6.RowCount = 3
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem6.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem6.TabIndex = 6
        '
        'cbxCPUWaitRatio
        '
        Me.cbxCPUWaitRatio.AutoSize = True
        Me.cbxCPUWaitRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem6.SetColumnSpan(Me.cbxCPUWaitRatio, 2)
        Me.cbxCPUWaitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCPUWaitRatio.ForeColor = System.Drawing.Color.White
        Me.cbxCPUWaitRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxCPUWaitRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxCPUWaitRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxCPUWaitRatio.Name = "cbxCPUWaitRatio"
        Me.cbxCPUWaitRatio.Radius = 10
        Me.cbxCPUWaitRatio.Size = New System.Drawing.Size(308, 18)
        Me.cbxCPUWaitRatio.TabIndex = 1
        Me.cbxCPUWaitRatio.Text = "CPU wait ratio (%)"
        Me.cbxCPUWaitRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxCPUWaitRatio.UseVisualStyleBackColor = True
        '
        'lblDuration6
        '
        Me.lblDuration6.AutoSize = True
        Me.lblDuration6.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration6.ForeColor = System.Drawing.Color.White
        Me.lblDuration6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration6.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration6.Name = "lblDuration6"
        Me.lblDuration6.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration6.TabIndex = 5
        Me.lblDuration6.Text = "min"
        Me.lblDuration6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCPUWaitRatio
        '
        Me.nudCPUWaitRatio.BackColor = System.Drawing.Color.White
        Me.nudCPUWaitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCPUWaitRatio.Enabled = False
        Me.nudCPUWaitRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudCPUWaitRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudCPUWaitRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCPUWaitRatio.Name = "nudCPUWaitRatio"
        Me.nudCPUWaitRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudCPUWaitRatio.TabIndex = 4
        Me.nudCPUWaitRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUCPUWaitRatio
        '
        Me.cbxDUCPUWaitRatio.AutoSize = True
        Me.cbxDUCPUWaitRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem6.SetColumnSpan(Me.cbxDUCPUWaitRatio, 2)
        Me.cbxDUCPUWaitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUCPUWaitRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUCPUWaitRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUCPUWaitRatio.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUCPUWaitRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUCPUWaitRatio.Name = "cbxDUCPUWaitRatio"
        Me.cbxDUCPUWaitRatio.Radius = 10
        Me.cbxDUCPUWaitRatio.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUCPUWaitRatio.TabIndex = 3
        Me.cbxDUCPUWaitRatio.Text = "Alert Duration"
        Me.cbxDUCPUWaitRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUCPUWaitRatio.UseVisualStyleBackColor = True
        '
        'dtbCPUwaitratio
        '
        Me.dtbCPUwaitratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbCPUwaitratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCPUwaitratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCPUwaitratio.BarMaxValue = 70
        Me.dtbCPUwaitratio.BarMinValue = 50
        Me.dtbCPUwaitratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCPUwaitratio.CaptionSpacing = 10
        Me.tlpCriticalItem6.SetColumnSpan(Me.dtbCPUwaitratio, 2)
        Me.dtbCPUwaitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCPUwaitratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbCPUwaitratio.ForeColor = System.Drawing.Color.White
        Me.dtbCPUwaitratio.Location = New System.Drawing.Point(3, 21)
        Me.dtbCPUwaitratio.LRPadding = 12
        Me.dtbCPUwaitratio.Name = "dtbCPUwaitratio"
        Me.tlpCriticalItem6.SetRowSpan(Me.dtbCPUwaitratio, 2)
        Me.dtbCPUwaitratio.Size = New System.Drawing.Size(282, 42)
        Me.dtbCPUwaitratio.TabIndex = 2
        Me.dtbCPUwaitratio.TabStop = False
        Me.dtbCPUwaitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCPUwaitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCPUwaitratio.TickSpacing = 20
        Me.dtbCPUwaitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratio.TrackHeight = 2
        Me.dtbCPUwaitratio.TrackToCaptionDistance = 14
        Me.dtbCPUwaitratio.TrackToTickInterval = 4
        Me.dtbCPUwaitratio.YPosition = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "      "
        '
        'tlpCriticalItem5
        '
        Me.tlpCriticalItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem5.ColumnCount = 4
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem5.Controls.Add(Me.cbxConnections, 1, 0)
        Me.tlpCriticalItem5.Controls.Add(Me.lblDuration5, 2, 2)
        Me.tlpCriticalItem5.Controls.Add(Me.nudConnections, 1, 2)
        Me.tlpCriticalItem5.Controls.Add(Me.cbxDUConnections, 2, 1)
        Me.tlpCriticalItem5.Controls.Add(Me.Label7, 0, 0)
        Me.tlpCriticalItem5.Controls.Add(Me.dtbConnections, 0, 1)
        Me.tlpCriticalItem5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem5.Location = New System.Drawing.Point(3, 219)
        Me.tlpCriticalItem5.Name = "tlpCriticalItem5"
        Me.tlpCriticalItem5.RowCount = 3
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem5.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem5.TabIndex = 4
        '
        'cbxConnections
        '
        Me.cbxConnections.AutoSize = True
        Me.cbxConnections.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem5.SetColumnSpan(Me.cbxConnections, 2)
        Me.cbxConnections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxConnections.ForeColor = System.Drawing.Color.White
        Me.cbxConnections.LineColor = System.Drawing.Color.Gray
        Me.cbxConnections.Location = New System.Drawing.Point(40, 0)
        Me.cbxConnections.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxConnections.Name = "cbxConnections"
        Me.cbxConnections.Radius = 10
        Me.cbxConnections.Size = New System.Drawing.Size(308, 18)
        Me.cbxConnections.TabIndex = 1
        Me.cbxConnections.Text = "Connections (Count)"
        Me.cbxConnections.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxConnections.UseVisualStyleBackColor = True
        '
        'lblDuration5
        '
        Me.lblDuration5.AutoSize = True
        Me.lblDuration5.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration5.ForeColor = System.Drawing.Color.White
        Me.lblDuration5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration5.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration5.Name = "lblDuration5"
        Me.lblDuration5.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration5.TabIndex = 5
        Me.lblDuration5.Text = "min"
        Me.lblDuration5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudConnections
        '
        Me.nudConnections.BackColor = System.Drawing.Color.White
        Me.nudConnections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudConnections.Enabled = False
        Me.nudConnections.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudConnections.Location = New System.Drawing.Point(291, 39)
        Me.nudConnections.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudConnections.Name = "nudConnections"
        Me.nudConnections.Size = New System.Drawing.Size(54, 21)
        Me.nudConnections.TabIndex = 4
        Me.nudConnections.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUConnections
        '
        Me.cbxDUConnections.AutoSize = True
        Me.cbxDUConnections.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem5.SetColumnSpan(Me.cbxDUConnections, 2)
        Me.cbxDUConnections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUConnections.ForeColor = System.Drawing.Color.White
        Me.cbxDUConnections.LineColor = System.Drawing.Color.Gray
        Me.cbxDUConnections.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUConnections.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUConnections.Name = "cbxDUConnections"
        Me.cbxDUConnections.Radius = 10
        Me.cbxDUConnections.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUConnections.TabIndex = 3
        Me.cbxDUConnections.Text = "Alert Duration"
        Me.cbxDUConnections.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUConnections.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "      "
        '
        'dtbConnections
        '
        Me.dtbConnections.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbConnections.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnections.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbConnections.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbConnections.BarMaxValue = 70
        Me.dtbConnections.BarMinValue = 50
        Me.dtbConnections.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbConnections.CaptionSpacing = 10
        Me.tlpCriticalItem5.SetColumnSpan(Me.dtbConnections, 2)
        Me.dtbConnections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbConnections.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbConnections.ForeColor = System.Drawing.Color.White
        Me.dtbConnections.Location = New System.Drawing.Point(3, 21)
        Me.dtbConnections.LRPadding = 12
        Me.dtbConnections.Name = "dtbConnections"
        Me.tlpCriticalItem5.SetRowSpan(Me.dtbConnections, 2)
        Me.dtbConnections.Size = New System.Drawing.Size(282, 42)
        Me.dtbConnections.TabIndex = 2
        Me.dtbConnections.TabStop = False
        Me.dtbConnections.Text = "DoubleTrackBarDraw1"
        Me.dtbConnections.TickColor = System.Drawing.Color.Silver
        Me.dtbConnections.TickSpacing = 20
        Me.dtbConnections.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnections.TrackHeight = 2
        Me.dtbConnections.TrackToCaptionDistance = 14
        Me.dtbConnections.TrackToTickInterval = 4
        Me.dtbConnections.YPosition = 10
        '
        'tlpCriticalItem2
        '
        Me.tlpCriticalItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem2.ColumnCount = 4
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem2.Controls.Add(Me.cbxCommitRatio, 1, 0)
        Me.tlpCriticalItem2.Controls.Add(Me.lblDuration2, 2, 2)
        Me.tlpCriticalItem2.Controls.Add(Me.nudCommitRatio, 1, 2)
        Me.tlpCriticalItem2.Controls.Add(Me.cbxDUCommitRatio, 2, 1)
        Me.tlpCriticalItem2.Controls.Add(Me.dtbCommitratio, 0, 1)
        Me.tlpCriticalItem2.Controls.Add(Me.Label5, 0, 0)
        Me.tlpCriticalItem2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem2.Location = New System.Drawing.Point(3, 75)
        Me.tlpCriticalItem2.Name = "tlpCriticalItem2"
        Me.tlpCriticalItem2.RowCount = 3
        Me.tlpCriticalItem2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpCriticalItem2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem2.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem2.TabIndex = 2
        '
        'cbxCommitRatio
        '
        Me.cbxCommitRatio.AutoSize = True
        Me.cbxCommitRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem2.SetColumnSpan(Me.cbxCommitRatio, 2)
        Me.cbxCommitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCommitRatio.ForeColor = System.Drawing.Color.White
        Me.cbxCommitRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxCommitRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxCommitRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxCommitRatio.Name = "cbxCommitRatio"
        Me.cbxCommitRatio.Radius = 10
        Me.cbxCommitRatio.Size = New System.Drawing.Size(308, 16)
        Me.cbxCommitRatio.TabIndex = 1
        Me.cbxCommitRatio.Text = "Commit ratio (%)"
        Me.cbxCommitRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxCommitRatio.UseVisualStyleBackColor = True
        '
        'lblDuration2
        '
        Me.lblDuration2.AutoSize = True
        Me.lblDuration2.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration2.ForeColor = System.Drawing.Color.White
        Me.lblDuration2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration2.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(34, 30)
        Me.lblDuration2.TabIndex = 5
        Me.lblDuration2.Text = "min"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCommitRatio
        '
        Me.nudCommitRatio.BackColor = System.Drawing.Color.White
        Me.nudCommitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCommitRatio.Enabled = False
        Me.nudCommitRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudCommitRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudCommitRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCommitRatio.Name = "nudCommitRatio"
        Me.nudCommitRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudCommitRatio.TabIndex = 4
        Me.nudCommitRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUCommitRatio
        '
        Me.cbxDUCommitRatio.AutoSize = True
        Me.cbxDUCommitRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem2.SetColumnSpan(Me.cbxDUCommitRatio, 2)
        Me.cbxDUCommitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUCommitRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUCommitRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUCommitRatio.Location = New System.Drawing.Point(288, 16)
        Me.cbxDUCommitRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUCommitRatio.Name = "cbxDUCommitRatio"
        Me.cbxDUCommitRatio.Radius = 10
        Me.cbxDUCommitRatio.Size = New System.Drawing.Size(100, 20)
        Me.cbxDUCommitRatio.TabIndex = 3
        Me.cbxDUCommitRatio.Text = "Alert Duration"
        Me.cbxDUCommitRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUCommitRatio.UseVisualStyleBackColor = True
        '
        'dtbCommitratio
        '
        Me.dtbCommitratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbCommitratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCommitratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCommitratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCommitratio.BarMaxValue = 70
        Me.dtbCommitratio.BarMinValue = 50
        Me.dtbCommitratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCommitratio.CaptionSpacing = 10
        Me.tlpCriticalItem2.SetColumnSpan(Me.dtbCommitratio, 2)
        Me.dtbCommitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCommitratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbCommitratio.ForeColor = System.Drawing.Color.White
        Me.dtbCommitratio.Location = New System.Drawing.Point(3, 19)
        Me.dtbCommitratio.LRPadding = 12
        Me.dtbCommitratio.Name = "dtbCommitratio"
        Me.tlpCriticalItem2.SetRowSpan(Me.dtbCommitratio, 2)
        Me.dtbCommitratio.Size = New System.Drawing.Size(282, 44)
        Me.dtbCommitratio.TabIndex = 2
        Me.dtbCommitratio.TabStop = False
        Me.dtbCommitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCommitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCommitratio.TickSpacing = 20
        Me.dtbCommitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCommitratio.TrackColor1 = System.Drawing.Color.Red
        Me.dtbCommitratio.TrackColor3 = System.Drawing.Color.Lime
        Me.dtbCommitratio.TrackHeight = 2
        Me.dtbCommitratio.TrackToCaptionDistance = 14
        Me.dtbCommitratio.TrackToTickInterval = 8
        Me.dtbCommitratio.YPosition = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "      "
        '
        'tlpCriticalItem1
        '
        Me.tlpCriticalItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem1.ColumnCount = 4
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem1.Controls.Add(Me.cbxBufferHitRatio, 1, 0)
        Me.tlpCriticalItem1.Controls.Add(Me.lblDuration1, 2, 2)
        Me.tlpCriticalItem1.Controls.Add(Me.nudBufferHitRatio, 0, 2)
        Me.tlpCriticalItem1.Controls.Add(Me.cbxDUBufferHitRatio, 2, 1)
        Me.tlpCriticalItem1.Controls.Add(Me.Label3, 0, 0)
        Me.tlpCriticalItem1.Controls.Add(Me.dtbBufferhitratio, 0, 1)
        Me.tlpCriticalItem1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem1.Location = New System.Drawing.Point(3, 3)
        Me.tlpCriticalItem1.Name = "tlpCriticalItem1"
        Me.tlpCriticalItem1.RowCount = 3
        Me.tlpCriticalItem1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpCriticalItem1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem1.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem1.TabIndex = 1
        '
        'cbxBufferHitRatio
        '
        Me.cbxBufferHitRatio.AutoSize = True
        Me.cbxBufferHitRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem1.SetColumnSpan(Me.cbxBufferHitRatio, 2)
        Me.cbxBufferHitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxBufferHitRatio.ForeColor = System.Drawing.Color.White
        Me.cbxBufferHitRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxBufferHitRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxBufferHitRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxBufferHitRatio.Name = "cbxBufferHitRatio"
        Me.cbxBufferHitRatio.Radius = 10
        Me.cbxBufferHitRatio.Size = New System.Drawing.Size(308, 16)
        Me.cbxBufferHitRatio.TabIndex = 1
        Me.cbxBufferHitRatio.Text = "Buffer hit ratio (%)"
        Me.cbxBufferHitRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxBufferHitRatio.UseVisualStyleBackColor = True
        '
        'lblDuration1
        '
        Me.lblDuration1.AutoSize = True
        Me.lblDuration1.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration1.ForeColor = System.Drawing.Color.White
        Me.lblDuration1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration1.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration1.Name = "lblDuration1"
        Me.lblDuration1.Size = New System.Drawing.Size(34, 30)
        Me.lblDuration1.TabIndex = 5
        Me.lblDuration1.Text = "min"
        Me.lblDuration1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudBufferHitRatio
        '
        Me.nudBufferHitRatio.BackColor = System.Drawing.Color.White
        Me.nudBufferHitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudBufferHitRatio.Enabled = False
        Me.nudBufferHitRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudBufferHitRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudBufferHitRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudBufferHitRatio.Name = "nudBufferHitRatio"
        Me.nudBufferHitRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudBufferHitRatio.TabIndex = 4
        Me.nudBufferHitRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUBufferHitRatio
        '
        Me.cbxDUBufferHitRatio.AutoSize = True
        Me.cbxDUBufferHitRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem1.SetColumnSpan(Me.cbxDUBufferHitRatio, 2)
        Me.cbxDUBufferHitRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUBufferHitRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUBufferHitRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUBufferHitRatio.Location = New System.Drawing.Point(288, 16)
        Me.cbxDUBufferHitRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUBufferHitRatio.Name = "cbxDUBufferHitRatio"
        Me.cbxDUBufferHitRatio.Radius = 10
        Me.cbxDUBufferHitRatio.Size = New System.Drawing.Size(100, 20)
        Me.cbxDUBufferHitRatio.TabIndex = 3
        Me.cbxDUBufferHitRatio.Text = "Alert Duration"
        Me.cbxDUBufferHitRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUBufferHitRatio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "      "
        '
        'dtbBufferhitratio
        '
        Me.dtbBufferhitratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbBufferhitratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbBufferhitratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbBufferhitratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbBufferhitratio.BarMaxValue = 70
        Me.dtbBufferhitratio.BarMinValue = 50
        Me.dtbBufferhitratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbBufferhitratio.CaptionSpacing = 10
        Me.tlpCriticalItem1.SetColumnSpan(Me.dtbBufferhitratio, 2)
        Me.dtbBufferhitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbBufferhitratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbBufferhitratio.ForeColor = System.Drawing.Color.White
        Me.dtbBufferhitratio.Location = New System.Drawing.Point(3, 19)
        Me.dtbBufferhitratio.LRPadding = 12
        Me.dtbBufferhitratio.Name = "dtbBufferhitratio"
        Me.tlpCriticalItem1.SetRowSpan(Me.dtbBufferhitratio, 2)
        Me.dtbBufferhitratio.Size = New System.Drawing.Size(282, 44)
        Me.dtbBufferhitratio.TabIndex = 2
        Me.dtbBufferhitratio.TabStop = False
        Me.dtbBufferhitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbBufferhitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbBufferhitratio.TickHeight = 4
        Me.dtbBufferhitratio.TickSpacing = 20
        Me.dtbBufferhitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbBufferhitratio.TrackColor1 = System.Drawing.Color.Red
        Me.dtbBufferhitratio.TrackColor3 = System.Drawing.Color.Lime
        Me.dtbBufferhitratio.TrackHeight = 2
        Me.dtbBufferhitratio.TrackToCaptionDistance = 14
        Me.dtbBufferhitratio.TrackToTickInterval = 4
        Me.dtbBufferhitratio.YPosition = 10
        '
        'tlpWarningItems
        '
        Me.tlpWarningItems.BackColor = System.Drawing.Color.Transparent
        Me.tlpWarningItems.ColumnCount = 2
        Me.tlpWarningItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpWarningItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWarningItems.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.tlpWarningItems.Controls.Add(Me.lblHAClusterAlert, 1, 2)
        Me.tlpWarningItems.Controls.Add(Me.Label24, 0, 2)
        Me.tlpWarningItems.Controls.Add(Me.TableLayoutPanel1, 0, 5)
        Me.tlpWarningItems.Controls.Add(Me.Label17, 0, 4)
        Me.tlpWarningItems.Controls.Add(Me.lblSMSAlert, 1, 4)
        Me.tlpWarningItems.Controls.Add(Me.lblTxAlert, 1, 0)
        Me.tlpWarningItems.Controls.Add(Me.Label1, 0, 0)
        Me.tlpWarningItems.Controls.Add(Me.tblTransactionAlert, 0, 1)
        Me.tlpWarningItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWarningItems.Location = New System.Drawing.Point(393, 3)
        Me.tlpWarningItems.Name = "tlpWarningItems"
        Me.tlpWarningItems.RowCount = 6
        Me.tlpAlertConfigurationMain.SetRowSpan(Me.tlpWarningItems, 9)
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.tlpWarningItems.Size = New System.Drawing.Size(472, 642)
        Me.tlpWarningItems.TabIndex = 26
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.tlpWarningItems.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblDelayAlert3, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDelayAlert2, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDelayAlert1, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.nudConfailedcnt, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbVIP, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbReplSlot, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbHAStatus, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxVirtualIP, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxReplSlot, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxHAStatus, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxConfailedcnt, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxWALcnt, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.nudWALcnt, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 3, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 315)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(466, 166)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'lblDelayAlert3
        '
        Me.lblDelayAlert3.AutoSize = True
        Me.lblDelayAlert3.BackColor = System.Drawing.Color.Transparent
        Me.lblDelayAlert3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDelayAlert3.ForeColor = System.Drawing.Color.White
        Me.lblDelayAlert3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDelayAlert3.Location = New System.Drawing.Point(238, 74)
        Me.lblDelayAlert3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.lblDelayAlert3.Name = "lblDelayAlert3"
        Me.lblDelayAlert3.Size = New System.Drawing.Size(116, 12)
        Me.lblDelayAlert3.TabIndex = 8
        Me.lblDelayAlert3.Text = "Alert delay count"
        Me.lblDelayAlert3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDelayAlert2
        '
        Me.lblDelayAlert2.AutoSize = True
        Me.lblDelayAlert2.BackColor = System.Drawing.Color.Transparent
        Me.lblDelayAlert2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDelayAlert2.ForeColor = System.Drawing.Color.White
        Me.lblDelayAlert2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDelayAlert2.Location = New System.Drawing.Point(238, 45)
        Me.lblDelayAlert2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.lblDelayAlert2.Name = "lblDelayAlert2"
        Me.lblDelayAlert2.Size = New System.Drawing.Size(116, 12)
        Me.lblDelayAlert2.TabIndex = 5
        Me.lblDelayAlert2.Text = "Alert delay count"
        Me.lblDelayAlert2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDelayAlert1
        '
        Me.lblDelayAlert1.AutoSize = True
        Me.lblDelayAlert1.BackColor = System.Drawing.Color.Transparent
        Me.lblDelayAlert1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDelayAlert1.ForeColor = System.Drawing.Color.White
        Me.lblDelayAlert1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDelayAlert1.Location = New System.Drawing.Point(238, 16)
        Me.lblDelayAlert1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.lblDelayAlert1.Name = "lblDelayAlert1"
        Me.lblDelayAlert1.Size = New System.Drawing.Size(116, 12)
        Me.lblDelayAlert1.TabIndex = 2
        Me.lblDelayAlert1.Text = "Alert delay count"
        Me.lblDelayAlert1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudConfailedcnt
        '
        Me.nudConfailedcnt.BackColor = System.Drawing.Color.White
        Me.nudConfailedcnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudConfailedcnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudConfailedcnt.Location = New System.Drawing.Point(178, 100)
        Me.nudConfailedcnt.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudConfailedcnt.Name = "nudConfailedcnt"
        Me.nudConfailedcnt.Size = New System.Drawing.Size(54, 21)
        Me.nudConfailedcnt.TabIndex = 10
        Me.nudConfailedcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbVIP
        '
        Me.cmbVIP.BackColor = System.Drawing.SystemColors.Window
        Me.cmbVIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbVIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVIP.FixedWidth = False
        Me.cmbVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVIP.FormattingEnabled = True
        Me.cmbVIP.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbVIP.Location = New System.Drawing.Point(178, 71)
        Me.cmbVIP.Name = "cmbVIP"
        Me.cmbVIP.Necessary = False
        Me.cmbVIP.Size = New System.Drawing.Size(54, 20)
        Me.cmbVIP.StatusTip = ""
        Me.cmbVIP.TabIndex = 7
        Me.cmbVIP.ValueText = ""
        '
        'cmbReplSlot
        '
        Me.cmbReplSlot.BackColor = System.Drawing.SystemColors.Window
        Me.cmbReplSlot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbReplSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReplSlot.FixedWidth = False
        Me.cmbReplSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbReplSlot.FormattingEnabled = True
        Me.cmbReplSlot.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbReplSlot.Location = New System.Drawing.Point(178, 42)
        Me.cmbReplSlot.Name = "cmbReplSlot"
        Me.cmbReplSlot.Necessary = False
        Me.cmbReplSlot.Size = New System.Drawing.Size(54, 20)
        Me.cmbReplSlot.StatusTip = ""
        Me.cmbReplSlot.TabIndex = 4
        Me.cmbReplSlot.ValueText = ""
        '
        'cmbHAStatus
        '
        Me.cmbHAStatus.BackColor = System.Drawing.SystemColors.Window
        Me.cmbHAStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbHAStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHAStatus.FixedWidth = False
        Me.cmbHAStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbHAStatus.FormattingEnabled = True
        Me.cmbHAStatus.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbHAStatus.Location = New System.Drawing.Point(178, 13)
        Me.cmbHAStatus.Name = "cmbHAStatus"
        Me.cmbHAStatus.Necessary = False
        Me.cmbHAStatus.Size = New System.Drawing.Size(54, 20)
        Me.cmbHAStatus.StatusTip = ""
        Me.cmbHAStatus.TabIndex = 1
        Me.cmbHAStatus.ValueText = ""
        '
        'cbxVirtualIP
        '
        Me.cbxVirtualIP.AutoSize = True
        Me.cbxVirtualIP.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxVirtualIP.ForeColor = System.Drawing.Color.White
        Me.cbxVirtualIP.LineColor = System.Drawing.Color.Gray
        Me.cbxVirtualIP.Location = New System.Drawing.Point(8, 71)
        Me.cbxVirtualIP.Name = "cbxVirtualIP"
        Me.cbxVirtualIP.Radius = 10
        Me.cbxVirtualIP.Size = New System.Drawing.Size(102, 16)
        Me.cbxVirtualIP.TabIndex = 6
        Me.cbxVirtualIP.Text = "Virtual IP alert"
        Me.cbxVirtualIP.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxVirtualIP.UseVisualStyleBackColor = True
        '
        'cbxReplSlot
        '
        Me.cbxReplSlot.AutoSize = True
        Me.cbxReplSlot.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxReplSlot.ForeColor = System.Drawing.Color.White
        Me.cbxReplSlot.LineColor = System.Drawing.Color.Gray
        Me.cbxReplSlot.Location = New System.Drawing.Point(8, 42)
        Me.cbxReplSlot.Name = "cbxReplSlot"
        Me.cbxReplSlot.Radius = 10
        Me.cbxReplSlot.Size = New System.Drawing.Size(138, 16)
        Me.cbxReplSlot.TabIndex = 3
        Me.cbxReplSlot.Text = "Replication slot alert"
        Me.cbxReplSlot.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxReplSlot.UseVisualStyleBackColor = True
        '
        'cbxHAStatus
        '
        Me.cbxHAStatus.AutoSize = True
        Me.cbxHAStatus.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxHAStatus.ForeColor = System.Drawing.Color.White
        Me.cbxHAStatus.LineColor = System.Drawing.Color.Gray
        Me.cbxHAStatus.Location = New System.Drawing.Point(8, 13)
        Me.cbxHAStatus.Name = "cbxHAStatus"
        Me.cbxHAStatus.Radius = 10
        Me.cbxHAStatus.Size = New System.Drawing.Size(106, 16)
        Me.cbxHAStatus.TabIndex = 0
        Me.cbxHAStatus.Text = "HA status alert"
        Me.cbxHAStatus.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxHAStatus.UseVisualStyleBackColor = True
        '
        'cbxConfailedcnt
        '
        Me.cbxConfailedcnt.AutoSize = True
        Me.cbxConfailedcnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxConfailedcnt.ForeColor = System.Drawing.Color.White
        Me.cbxConfailedcnt.LineColor = System.Drawing.Color.Gray
        Me.cbxConfailedcnt.Location = New System.Drawing.Point(8, 100)
        Me.cbxConfailedcnt.Name = "cbxConfailedcnt"
        Me.cbxConfailedcnt.Radius = 10
        Me.cbxConfailedcnt.Size = New System.Drawing.Size(157, 16)
        Me.cbxConfailedcnt.TabIndex = 9
        Me.cbxConfailedcnt.Text = "Connection failed count"
        Me.cbxConfailedcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxConfailedcnt.UseVisualStyleBackColor = True
        '
        'cbxWALcnt
        '
        Me.cbxWALcnt.AutoSize = True
        Me.cbxWALcnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxWALcnt.ForeColor = System.Drawing.Color.White
        Me.cbxWALcnt.LineColor = System.Drawing.Color.Gray
        Me.cbxWALcnt.Location = New System.Drawing.Point(8, 129)
        Me.cbxWALcnt.Name = "cbxWALcnt"
        Me.cbxWALcnt.Radius = 10
        Me.cbxWALcnt.Size = New System.Drawing.Size(104, 16)
        Me.cbxWALcnt.TabIndex = 12
        Me.cbxWALcnt.Text = "WAL file count"
        Me.cbxWALcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxWALcnt.UseVisualStyleBackColor = True
        '
        'nudWALcnt
        '
        Me.nudWALcnt.BackColor = System.Drawing.Color.White
        Me.nudWALcnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudWALcnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudWALcnt.Location = New System.Drawing.Point(178, 129)
        Me.nudWALcnt.Maximum = New Decimal(New Integer() {204800, 0, 0, 0})
        Me.nudWALcnt.Name = "nudWALcnt"
        Me.nudWALcnt.Size = New System.Drawing.Size(54, 21)
        Me.nudWALcnt.TabIndex = 13
        Me.nudWALcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(238, 103)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "count"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(238, 132)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 12)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "count"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHAClusterAlert
        '
        Me.lblHAClusterAlert.AutoSize = True
        Me.lblHAClusterAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHAClusterAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHAClusterAlert.ForeColor = System.Drawing.Color.White
        Me.lblHAClusterAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHAClusterAlert.Location = New System.Drawing.Point(40, 284)
        Me.lblHAClusterAlert.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHAClusterAlert.Name = "lblHAClusterAlert"
        Me.lblHAClusterAlert.Size = New System.Drawing.Size(432, 28)
        Me.lblHAClusterAlert.TabIndex = 4
        Me.lblHAClusterAlert.Text = "System alert (Critical Level)"
        Me.lblHAClusterAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label24.Location = New System.Drawing.Point(0, 284)
        Me.Label24.Margin = New System.Windows.Forms.Padding(0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 28)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "      "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.tlpWarningItems.SetColumnSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtBusiness, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUserGroup, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbNotiUsers, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbNotiLevel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudNotiCycle, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 515)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(466, 124)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'txtBusiness
        '
        Me.txtBusiness.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBusiness.code = False
        Me.txtBusiness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBusiness.FixedWidth = False
        Me.txtBusiness.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBusiness.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtBusiness.Location = New System.Drawing.Point(133, 91)
        Me.txtBusiness.MaxByteLength = 16
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Necessary = False
        Me.txtBusiness.PossibleInput = ""
        Me.txtBusiness.Prefix = ""
        Me.txtBusiness.Size = New System.Drawing.Size(84, 21)
        Me.txtBusiness.StatusTip = ""
        Me.txtBusiness.TabIndex = 9
        Me.txtBusiness.Value = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(13, 93)
        Me.Label22.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 12)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Business name"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUserGroup
        '
        Me.btnUserGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnUserGroup.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnUserGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserGroup.FixedWidth = False
        Me.btnUserGroup.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnUserGroup.ForeColor = System.Drawing.Color.White
        Me.btnUserGroup.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnUserGroup.LineColor = System.Drawing.Color.Transparent
        Me.btnUserGroup.Location = New System.Drawing.Point(223, 36)
        Me.btnUserGroup.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnUserGroup.Name = "btnUserGroup"
        Me.btnUserGroup.Radius = 5
        Me.btnUserGroup.Size = New System.Drawing.Size(94, 27)
        Me.btnUserGroup.TabIndex = 4
        Me.btnUserGroup.Text = "F352"
        Me.btnUserGroup.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUserGroup.UseRound = True
        Me.btnUserGroup.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.Location = New System.Drawing.Point(223, 67)
        Me.Label21.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 12)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "min"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNotiUsers
        '
        Me.cmbNotiUsers.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNotiUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNotiUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNotiUsers.FixedWidth = False
        Me.cmbNotiUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNotiUsers.FormattingEnabled = True
        Me.cmbNotiUsers.Location = New System.Drawing.Point(133, 39)
        Me.cmbNotiUsers.Name = "cmbNotiUsers"
        Me.cmbNotiUsers.Necessary = False
        Me.cmbNotiUsers.Size = New System.Drawing.Size(84, 20)
        Me.cmbNotiUsers.StatusTip = ""
        Me.cmbNotiUsers.TabIndex = 3
        Me.cmbNotiUsers.ValueText = ""
        '
        'cmbNotiLevel
        '
        Me.cmbNotiLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNotiLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNotiLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNotiLevel.FixedWidth = False
        Me.cmbNotiLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNotiLevel.FormattingEnabled = True
        Me.cmbNotiLevel.Items.AddRange(New Object() {"None", "Warning", "Critical"})
        Me.cmbNotiLevel.Location = New System.Drawing.Point(133, 13)
        Me.cmbNotiLevel.Name = "cmbNotiLevel"
        Me.cmbNotiLevel.Necessary = False
        Me.cmbNotiLevel.Size = New System.Drawing.Size(84, 20)
        Me.cmbNotiLevel.StatusTip = ""
        Me.cmbNotiLevel.TabIndex = 1
        Me.cmbNotiLevel.ValueText = ""
        '
        'nudNotiCycle
        '
        Me.nudNotiCycle.BackColor = System.Drawing.Color.White
        Me.nudNotiCycle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudNotiCycle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudNotiCycle.Location = New System.Drawing.Point(133, 65)
        Me.nudNotiCycle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudNotiCycle.Name = "nudNotiCycle"
        Me.nudNotiCycle.Size = New System.Drawing.Size(84, 21)
        Me.nudNotiCycle.TabIndex = 6
        Me.nudNotiCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Location = New System.Drawing.Point(13, 15)
        Me.Label20.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 12)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Level"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(13, 67)
        Me.Label19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(114, 12)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Cycle"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(13, 41)
        Me.Label18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 12)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "User Group"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Location = New System.Drawing.Point(0, 484)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 28)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "      "
        '
        'lblSMSAlert
        '
        Me.lblSMSAlert.AutoSize = True
        Me.lblSMSAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSMSAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSMSAlert.ForeColor = System.Drawing.Color.White
        Me.lblSMSAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSMSAlert.Location = New System.Drawing.Point(40, 484)
        Me.lblSMSAlert.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSMSAlert.Name = "lblSMSAlert"
        Me.lblSMSAlert.Size = New System.Drawing.Size(432, 28)
        Me.lblSMSAlert.TabIndex = 7
        Me.lblSMSAlert.Text = "SMS Alert"
        Me.lblSMSAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTxAlert
        '
        Me.lblTxAlert.AutoSize = True
        Me.lblTxAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTxAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTxAlert.ForeColor = System.Drawing.Color.White
        Me.lblTxAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTxAlert.Location = New System.Drawing.Point(40, 0)
        Me.lblTxAlert.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTxAlert.Name = "lblTxAlert"
        Me.lblTxAlert.Size = New System.Drawing.Size(432, 28)
        Me.lblTxAlert.TabIndex = 1
        Me.lblTxAlert.Text = "Transaction alert (Warning Level)"
        Me.lblTxAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "      "
        '
        'tblTransactionAlert
        '
        Me.tblTransactionAlert.BackColor = System.Drawing.Color.Transparent
        Me.tblTransactionAlert.ColumnCount = 7
        Me.tlpWarningItems.SetColumnSpan(Me.tblTransactionAlert, 2)
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tblTransactionAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTransactionAlert.Controls.Add(Me.btnLongSQLFilter, 4, 2)
        Me.tblTransactionAlert.Controls.Add(Me.lblLockTransaction, 5, 1)
        Me.tblTransactionAlert.Controls.Add(Me.nudLockTransactionRTime, 4, 1)
        Me.tblTransactionAlert.Controls.Add(Me.Label6, 4, 0)
        Me.tblTransactionAlert.Controls.Add(Me.cbxInvalidindex, 1, 8)
        Me.tblTransactionAlert.Controls.Add(Me.nudFrozenMaxAgeCritical, 3, 4)
        Me.tblTransactionAlert.Controls.Add(Me.nudIdletranscntCritical, 3, 3)
        Me.tblTransactionAlert.Controls.Add(Me.nudLongrunsqlsecCritical, 3, 2)
        Me.tblTransactionAlert.Controls.Add(Me.nudLockedtranccntCritical, 3, 1)
        Me.tblTransactionAlert.Controls.Add(Me.Label4, 3, 0)
        Me.tblTransactionAlert.Controls.Add(Me.Label2, 2, 0)
        Me.tblTransactionAlert.Controls.Add(Me.nudFrozenMaxAge, 2, 4)
        Me.tblTransactionAlert.Controls.Add(Me.cbxFrozenAge, 1, 4)
        Me.tblTransactionAlert.Controls.Add(Me.nudLockedtranccnt, 2, 1)
        Me.tblTransactionAlert.Controls.Add(Me.nudLongrunsqlsec, 2, 2)
        Me.tblTransactionAlert.Controls.Add(Me.nudLastvacuumDay, 2, 5)
        Me.tblTransactionAlert.Controls.Add(Me.nudIdletranscnt, 2, 3)
        Me.tblTransactionAlert.Controls.Add(Me.nudUnusedindexcnt, 2, 7)
        Me.tblTransactionAlert.Controls.Add(Me.nudLastAnalyzeday, 2, 6)
        Me.tblTransactionAlert.Controls.Add(Me.cbxLockedtranccnt, 1, 1)
        Me.tblTransactionAlert.Controls.Add(Me.cbxLongrunsqlsec, 1, 2)
        Me.tblTransactionAlert.Controls.Add(Me.cbxLastvacuumDay, 1, 5)
        Me.tblTransactionAlert.Controls.Add(Me.cbxIdletranscnt, 1, 3)
        Me.tblTransactionAlert.Controls.Add(Me.cbxLastAnalyzeday, 1, 6)
        Me.tblTransactionAlert.Controls.Add(Me.cbxUnusedindexcnt, 1, 7)
        Me.tblTransactionAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTransactionAlert.Location = New System.Drawing.Point(3, 31)
        Me.tblTransactionAlert.Name = "tblTransactionAlert"
        Me.tblTransactionAlert.RowCount = 10
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50006!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50006!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50006!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50006!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50006!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50006!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50403!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49563!))
        Me.tblTransactionAlert.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblTransactionAlert.Size = New System.Drawing.Size(466, 250)
        Me.tblTransactionAlert.TabIndex = 2
        '
        'btnLongSQLFilter
        '
        Me.btnLongSQLFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnLongSQLFilter.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tblTransactionAlert.SetColumnSpan(Me.btnLongSQLFilter, 2)
        Me.btnLongSQLFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLongSQLFilter.FixedWidth = False
        Me.btnLongSQLFilter.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnLongSQLFilter.ForeColor = System.Drawing.Color.White
        Me.btnLongSQLFilter.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLongSQLFilter.LineColor = System.Drawing.Color.Transparent
        Me.btnLongSQLFilter.Location = New System.Drawing.Point(288, 52)
        Me.btnLongSQLFilter.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnLongSQLFilter.Name = "btnLongSQLFilter"
        Me.btnLongSQLFilter.Radius = 5
        Me.btnLongSQLFilter.Size = New System.Drawing.Size(84, 27)
        Me.btnLongSQLFilter.TabIndex = 24
        Me.btnLongSQLFilter.Text = "F368"
        Me.btnLongSQLFilter.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLongSQLFilter.UseRound = True
        Me.btnLongSQLFilter.UseVisualStyleBackColor = False
        '
        'lblLockTransaction
        '
        Me.lblLockTransaction.AutoSize = True
        Me.lblLockTransaction.BackColor = System.Drawing.Color.Transparent
        Me.lblLockTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLockTransaction.ForeColor = System.Drawing.Color.White
        Me.lblLockTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLockTransaction.Location = New System.Drawing.Point(343, 25)
        Me.lblLockTransaction.Name = "lblLockTransaction"
        Me.lblLockTransaction.Size = New System.Drawing.Size(29, 27)
        Me.lblLockTransaction.TabIndex = 23
        Me.lblLockTransaction.Text = "min"
        Me.lblLockTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudLockTransactionRTime
        '
        Me.nudLockTransactionRTime.BackColor = System.Drawing.Color.White
        Me.nudLockTransactionRTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudLockTransactionRTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockTransactionRTime.Location = New System.Drawing.Point(288, 28)
        Me.nudLockTransactionRTime.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLockTransactionRTime.Name = "nudLockTransactionRTime"
        Me.nudLockTransactionRTime.Size = New System.Drawing.Size(49, 21)
        Me.nudLockTransactionRTime.TabIndex = 22
        Me.nudLockTransactionRTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.tblTransactionAlert.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(288, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Alert Duration"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxInvalidindex
        '
        Me.cbxInvalidindex.AutoSize = True
        Me.cbxInvalidindex.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxInvalidindex.ForeColor = System.Drawing.Color.White
        Me.cbxInvalidindex.LineColor = System.Drawing.Color.Gray
        Me.cbxInvalidindex.Location = New System.Drawing.Point(8, 217)
        Me.cbxInvalidindex.Name = "cbxInvalidindex"
        Me.cbxInvalidindex.Radius = 10
        Me.cbxInvalidindex.Size = New System.Drawing.Size(95, 16)
        Me.cbxInvalidindex.TabIndex = 20
        Me.cbxInvalidindex.Text = "Invalid index"
        Me.cbxInvalidindex.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxInvalidindex.UseVisualStyleBackColor = True
        '
        'nudFrozenMaxAgeCritical
        '
        Me.nudFrozenMaxAgeCritical.BackColor = System.Drawing.Color.White
        Me.nudFrozenMaxAgeCritical.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudFrozenMaxAgeCritical.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudFrozenMaxAgeCritical.Location = New System.Drawing.Point(233, 109)
        Me.nudFrozenMaxAgeCritical.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudFrozenMaxAgeCritical.Name = "nudFrozenMaxAgeCritical"
        Me.nudFrozenMaxAgeCritical.Size = New System.Drawing.Size(49, 21)
        Me.nudFrozenMaxAgeCritical.TabIndex = 13
        Me.nudFrozenMaxAgeCritical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudIdletranscntCritical
        '
        Me.nudIdletranscntCritical.BackColor = System.Drawing.Color.White
        Me.nudIdletranscntCritical.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudIdletranscntCritical.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudIdletranscntCritical.Location = New System.Drawing.Point(233, 82)
        Me.nudIdletranscntCritical.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudIdletranscntCritical.Name = "nudIdletranscntCritical"
        Me.nudIdletranscntCritical.Size = New System.Drawing.Size(49, 21)
        Me.nudIdletranscntCritical.TabIndex = 10
        Me.nudIdletranscntCritical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLongrunsqlsecCritical
        '
        Me.nudLongrunsqlsecCritical.BackColor = System.Drawing.Color.White
        Me.nudLongrunsqlsecCritical.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLongrunsqlsecCritical.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLongrunsqlsecCritical.Location = New System.Drawing.Point(233, 55)
        Me.nudLongrunsqlsecCritical.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLongrunsqlsecCritical.Name = "nudLongrunsqlsecCritical"
        Me.nudLongrunsqlsecCritical.Size = New System.Drawing.Size(49, 21)
        Me.nudLongrunsqlsecCritical.TabIndex = 7
        Me.nudLongrunsqlsecCritical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLockedtranccntCritical
        '
        Me.nudLockedtranccntCritical.BackColor = System.Drawing.Color.White
        Me.nudLockedtranccntCritical.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLockedtranccntCritical.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockedtranccntCritical.Location = New System.Drawing.Point(233, 28)
        Me.nudLockedtranccntCritical.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLockedtranccntCritical.Name = "nudLockedtranccntCritical"
        Me.nudLockedtranccntCritical.Size = New System.Drawing.Size(49, 21)
        Me.nudLockedtranccntCritical.TabIndex = 4
        Me.nudLockedtranccntCritical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(233, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Critical"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(178, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Warning"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudFrozenMaxAge
        '
        Me.nudFrozenMaxAge.BackColor = System.Drawing.Color.White
        Me.nudFrozenMaxAge.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudFrozenMaxAge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudFrozenMaxAge.Location = New System.Drawing.Point(178, 109)
        Me.nudFrozenMaxAge.Name = "nudFrozenMaxAge"
        Me.nudFrozenMaxAge.Size = New System.Drawing.Size(49, 21)
        Me.nudFrozenMaxAge.TabIndex = 12
        Me.nudFrozenMaxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxFrozenAge
        '
        Me.cbxFrozenAge.AutoSize = True
        Me.cbxFrozenAge.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxFrozenAge.ForeColor = System.Drawing.Color.White
        Me.cbxFrozenAge.LineColor = System.Drawing.Color.Gray
        Me.cbxFrozenAge.Location = New System.Drawing.Point(8, 109)
        Me.cbxFrozenAge.Name = "cbxFrozenAge"
        Me.cbxFrozenAge.Radius = 10
        Me.cbxFrozenAge.Size = New System.Drawing.Size(131, 16)
        Me.cbxFrozenAge.TabIndex = 11
        Me.cbxFrozenAge.Text = "Frozen XID age(%)"
        Me.cbxFrozenAge.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxFrozenAge.UseVisualStyleBackColor = True
        '
        'nudLockedtranccnt
        '
        Me.nudLockedtranccnt.BackColor = System.Drawing.Color.White
        Me.nudLockedtranccnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLockedtranccnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockedtranccnt.Location = New System.Drawing.Point(178, 28)
        Me.nudLockedtranccnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLockedtranccnt.Name = "nudLockedtranccnt"
        Me.nudLockedtranccnt.Size = New System.Drawing.Size(49, 21)
        Me.nudLockedtranccnt.TabIndex = 3
        Me.nudLockedtranccnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLongrunsqlsec
        '
        Me.nudLongrunsqlsec.BackColor = System.Drawing.Color.White
        Me.nudLongrunsqlsec.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLongrunsqlsec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLongrunsqlsec.Location = New System.Drawing.Point(178, 55)
        Me.nudLongrunsqlsec.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLongrunsqlsec.Name = "nudLongrunsqlsec"
        Me.nudLongrunsqlsec.Size = New System.Drawing.Size(49, 21)
        Me.nudLongrunsqlsec.TabIndex = 6
        Me.nudLongrunsqlsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLastvacuumDay
        '
        Me.nudLastvacuumDay.BackColor = System.Drawing.Color.White
        Me.nudLastvacuumDay.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLastvacuumDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLastvacuumDay.Location = New System.Drawing.Point(178, 136)
        Me.nudLastvacuumDay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLastvacuumDay.Name = "nudLastvacuumDay"
        Me.nudLastvacuumDay.Size = New System.Drawing.Size(49, 21)
        Me.nudLastvacuumDay.TabIndex = 15
        Me.nudLastvacuumDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudIdletranscnt
        '
        Me.nudIdletranscnt.BackColor = System.Drawing.Color.White
        Me.nudIdletranscnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudIdletranscnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudIdletranscnt.Location = New System.Drawing.Point(178, 82)
        Me.nudIdletranscnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudIdletranscnt.Name = "nudIdletranscnt"
        Me.nudIdletranscnt.Size = New System.Drawing.Size(49, 21)
        Me.nudIdletranscnt.TabIndex = 9
        Me.nudIdletranscnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudUnusedindexcnt
        '
        Me.nudUnusedindexcnt.BackColor = System.Drawing.Color.White
        Me.nudUnusedindexcnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudUnusedindexcnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudUnusedindexcnt.Location = New System.Drawing.Point(178, 190)
        Me.nudUnusedindexcnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudUnusedindexcnt.Name = "nudUnusedindexcnt"
        Me.nudUnusedindexcnt.Size = New System.Drawing.Size(49, 21)
        Me.nudUnusedindexcnt.TabIndex = 19
        Me.nudUnusedindexcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLastAnalyzeday
        '
        Me.nudLastAnalyzeday.BackColor = System.Drawing.Color.White
        Me.nudLastAnalyzeday.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLastAnalyzeday.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLastAnalyzeday.Location = New System.Drawing.Point(178, 163)
        Me.nudLastAnalyzeday.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLastAnalyzeday.Name = "nudLastAnalyzeday"
        Me.nudLastAnalyzeday.Size = New System.Drawing.Size(49, 21)
        Me.nudLastAnalyzeday.TabIndex = 17
        Me.nudLastAnalyzeday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxLockedtranccnt
        '
        Me.cbxLockedtranccnt.AutoSize = True
        Me.cbxLockedtranccnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLockedtranccnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbxLockedtranccnt.ForeColor = System.Drawing.Color.White
        Me.cbxLockedtranccnt.LineColor = System.Drawing.Color.Gray
        Me.cbxLockedtranccnt.Location = New System.Drawing.Point(8, 28)
        Me.cbxLockedtranccnt.Name = "cbxLockedtranccnt"
        Me.cbxLockedtranccnt.Radius = 10
        Me.cbxLockedtranccnt.Size = New System.Drawing.Size(164, 16)
        Me.cbxLockedtranccnt.TabIndex = 2
        Me.cbxLockedtranccnt.Text = "Locked transaction count"
        Me.cbxLockedtranccnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLockedtranccnt.UseVisualStyleBackColor = True
        '
        'cbxLongrunsqlsec
        '
        Me.cbxLongrunsqlsec.AutoSize = True
        Me.cbxLongrunsqlsec.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLongrunsqlsec.ForeColor = System.Drawing.Color.White
        Me.cbxLongrunsqlsec.LineColor = System.Drawing.Color.Gray
        Me.cbxLongrunsqlsec.Location = New System.Drawing.Point(8, 55)
        Me.cbxLongrunsqlsec.Name = "cbxLongrunsqlsec"
        Me.cbxLongrunsqlsec.Radius = 10
        Me.cbxLongrunsqlsec.Size = New System.Drawing.Size(150, 16)
        Me.cbxLongrunsqlsec.TabIndex = 5
        Me.cbxLongrunsqlsec.Text = "Long running sql(sec)"
        Me.cbxLongrunsqlsec.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLongrunsqlsec.UseVisualStyleBackColor = True
        '
        'cbxLastvacuumDay
        '
        Me.cbxLastvacuumDay.AutoSize = True
        Me.cbxLastvacuumDay.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLastvacuumDay.ForeColor = System.Drawing.Color.White
        Me.cbxLastvacuumDay.LineColor = System.Drawing.Color.Gray
        Me.cbxLastvacuumDay.Location = New System.Drawing.Point(8, 136)
        Me.cbxLastvacuumDay.Name = "cbxLastvacuumDay"
        Me.cbxLastvacuumDay.Radius = 10
        Me.cbxLastvacuumDay.Size = New System.Drawing.Size(118, 16)
        Me.cbxLastvacuumDay.TabIndex = 14
        Me.cbxLastvacuumDay.Text = "last vacuum day"
        Me.cbxLastvacuumDay.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLastvacuumDay.UseVisualStyleBackColor = True
        '
        'cbxIdletranscnt
        '
        Me.cbxIdletranscnt.AutoSize = True
        Me.cbxIdletranscnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxIdletranscnt.ForeColor = System.Drawing.Color.White
        Me.cbxIdletranscnt.LineColor = System.Drawing.Color.Gray
        Me.cbxIdletranscnt.Location = New System.Drawing.Point(8, 82)
        Me.cbxIdletranscnt.Name = "cbxIdletranscnt"
        Me.cbxIdletranscnt.Radius = 10
        Me.cbxIdletranscnt.Size = New System.Drawing.Size(159, 16)
        Me.cbxIdletranscnt.TabIndex = 8
        Me.cbxIdletranscnt.Text = "Idle in transaction count"
        Me.cbxIdletranscnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxIdletranscnt.UseVisualStyleBackColor = True
        '
        'cbxLastAnalyzeday
        '
        Me.cbxLastAnalyzeday.AutoSize = True
        Me.cbxLastAnalyzeday.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLastAnalyzeday.ForeColor = System.Drawing.Color.White
        Me.cbxLastAnalyzeday.LineColor = System.Drawing.Color.Gray
        Me.cbxLastAnalyzeday.Location = New System.Drawing.Point(8, 163)
        Me.cbxLastAnalyzeday.Name = "cbxLastAnalyzeday"
        Me.cbxLastAnalyzeday.Radius = 10
        Me.cbxLastAnalyzeday.Size = New System.Drawing.Size(118, 16)
        Me.cbxLastAnalyzeday.TabIndex = 16
        Me.cbxLastAnalyzeday.Text = "last analyze day"
        Me.cbxLastAnalyzeday.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLastAnalyzeday.UseVisualStyleBackColor = True
        '
        'cbxUnusedindexcnt
        '
        Me.cbxUnusedindexcnt.AutoSize = True
        Me.cbxUnusedindexcnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxUnusedindexcnt.ForeColor = System.Drawing.Color.White
        Me.cbxUnusedindexcnt.LineColor = System.Drawing.Color.Gray
        Me.cbxUnusedindexcnt.Location = New System.Drawing.Point(8, 190)
        Me.cbxUnusedindexcnt.Name = "cbxUnusedindexcnt"
        Me.cbxUnusedindexcnt.Radius = 10
        Me.cbxUnusedindexcnt.Size = New System.Drawing.Size(137, 16)
        Me.cbxUnusedindexcnt.TabIndex = 18
        Me.cbxUnusedindexcnt.Text = "Unused index count"
        Me.cbxUnusedindexcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxUnusedindexcnt.UseVisualStyleBackColor = True
        '
        'tlpAlertConfigurationMain
        '
        Me.tlpAlertConfigurationMain.BackColor = System.Drawing.Color.Transparent
        Me.tlpAlertConfigurationMain.ColumnCount = 2
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390.0!))
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458.0!))
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem9, 0, 6)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem8, 0, 4)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpWarningItems, 1, 0)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem6, 0, 5)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem4, 0, 2)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem1, 0, 0)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem5, 0, 3)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem2, 0, 1)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem7, 0, 8)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem3, 0, 7)
        Me.tlpAlertConfigurationMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAlertConfigurationMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpAlertConfigurationMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAlertConfigurationMain.Name = "tlpAlertConfigurationMain"
        Me.tlpAlertConfigurationMain.RowCount = 10
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpAlertConfigurationMain.Size = New System.Drawing.Size(868, 650)
        Me.tlpAlertConfigurationMain.TabIndex = 0
        '
        'tlpCriticalItem9
        '
        Me.tlpCriticalItem9.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem9.ColumnCount = 4
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem9.Controls.Add(Me.cbxMemoryUsedRatio, 1, 0)
        Me.tlpCriticalItem9.Controls.Add(Me.Label27, 3, 2)
        Me.tlpCriticalItem9.Controls.Add(Me.nudMemoryUsedRatio, 2, 2)
        Me.tlpCriticalItem9.Controls.Add(Me.cbxDUMemoryUsedRatio, 2, 1)
        Me.tlpCriticalItem9.Controls.Add(Me.dtbMEMusedratio, 0, 1)
        Me.tlpCriticalItem9.Controls.Add(Me.Label29, 0, 0)
        Me.tlpCriticalItem9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem9.Location = New System.Drawing.Point(3, 435)
        Me.tlpCriticalItem9.Name = "tlpCriticalItem9"
        Me.tlpCriticalItem9.RowCount = 3
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem9.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem9.TabIndex = 7
        '
        'cbxMemoryUsedRatio
        '
        Me.cbxMemoryUsedRatio.AutoSize = True
        Me.cbxMemoryUsedRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem9.SetColumnSpan(Me.cbxMemoryUsedRatio, 2)
        Me.cbxMemoryUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxMemoryUsedRatio.ForeColor = System.Drawing.Color.White
        Me.cbxMemoryUsedRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxMemoryUsedRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxMemoryUsedRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxMemoryUsedRatio.Name = "cbxMemoryUsedRatio"
        Me.cbxMemoryUsedRatio.Radius = 10
        Me.cbxMemoryUsedRatio.Size = New System.Drawing.Size(308, 18)
        Me.cbxMemoryUsedRatio.TabIndex = 1
        Me.cbxMemoryUsedRatio.Text = "Memory used ratio (%)"
        Me.cbxMemoryUsedRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxMemoryUsedRatio.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label27.Location = New System.Drawing.Point(351, 36)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 30)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "min"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudMemoryUsedRatio
        '
        Me.nudMemoryUsedRatio.BackColor = System.Drawing.Color.White
        Me.nudMemoryUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudMemoryUsedRatio.Enabled = False
        Me.nudMemoryUsedRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudMemoryUsedRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudMemoryUsedRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMemoryUsedRatio.Name = "nudMemoryUsedRatio"
        Me.nudMemoryUsedRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudMemoryUsedRatio.TabIndex = 4
        Me.nudMemoryUsedRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUMemoryUsedRatio
        '
        Me.cbxDUMemoryUsedRatio.AutoSize = True
        Me.cbxDUMemoryUsedRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem9.SetColumnSpan(Me.cbxDUMemoryUsedRatio, 2)
        Me.cbxDUMemoryUsedRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUMemoryUsedRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUMemoryUsedRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUMemoryUsedRatio.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUMemoryUsedRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUMemoryUsedRatio.Name = "cbxDUMemoryUsedRatio"
        Me.cbxDUMemoryUsedRatio.Radius = 10
        Me.cbxDUMemoryUsedRatio.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUMemoryUsedRatio.TabIndex = 3
        Me.cbxDUMemoryUsedRatio.Text = "Alert Duration"
        Me.cbxDUMemoryUsedRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUMemoryUsedRatio.UseVisualStyleBackColor = True
        '
        'dtbMEMusedratio
        '
        Me.dtbMEMusedratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbMEMusedratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbMEMusedratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbMEMusedratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbMEMusedratio.BarMaxValue = 70
        Me.dtbMEMusedratio.BarMinValue = 50
        Me.dtbMEMusedratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbMEMusedratio.CaptionSpacing = 10
        Me.tlpCriticalItem9.SetColumnSpan(Me.dtbMEMusedratio, 2)
        Me.dtbMEMusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbMEMusedratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbMEMusedratio.ForeColor = System.Drawing.Color.White
        Me.dtbMEMusedratio.Location = New System.Drawing.Point(3, 21)
        Me.dtbMEMusedratio.LRPadding = 12
        Me.dtbMEMusedratio.Name = "dtbMEMusedratio"
        Me.tlpCriticalItem9.SetRowSpan(Me.dtbMEMusedratio, 2)
        Me.dtbMEMusedratio.Size = New System.Drawing.Size(282, 42)
        Me.dtbMEMusedratio.TabIndex = 2
        Me.dtbMEMusedratio.TabStop = False
        Me.dtbMEMusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbMEMusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbMEMusedratio.TickSpacing = 20
        Me.dtbMEMusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbMEMusedratio.TrackHeight = 2
        Me.dtbMEMusedratio.TrackToCaptionDistance = 14
        Me.dtbMEMusedratio.TrackToTickInterval = 4
        Me.dtbMEMusedratio.YPosition = 10
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label29.Location = New System.Drawing.Point(3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 18)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "      "
        '
        'tlpCriticalItem8
        '
        Me.tlpCriticalItem8.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem8.ColumnCount = 4
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem8.Controls.Add(Me.cbxCPUUtilRatio, 1, 0)
        Me.tlpCriticalItem8.Controls.Add(Me.lblDuration8, 2, 2)
        Me.tlpCriticalItem8.Controls.Add(Me.nudCPUUtilRatio, 1, 2)
        Me.tlpCriticalItem8.Controls.Add(Me.cbxDUCPUUtilRatio, 2, 1)
        Me.tlpCriticalItem8.Controls.Add(Me.dtbCPUutilratio, 0, 1)
        Me.tlpCriticalItem8.Controls.Add(Me.Label26, 0, 0)
        Me.tlpCriticalItem8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem8.Location = New System.Drawing.Point(3, 291)
        Me.tlpCriticalItem8.Name = "tlpCriticalItem8"
        Me.tlpCriticalItem8.RowCount = 3
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem8.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem8.TabIndex = 5
        '
        'cbxCPUUtilRatio
        '
        Me.cbxCPUUtilRatio.AutoSize = True
        Me.cbxCPUUtilRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem8.SetColumnSpan(Me.cbxCPUUtilRatio, 2)
        Me.cbxCPUUtilRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCPUUtilRatio.ForeColor = System.Drawing.Color.White
        Me.cbxCPUUtilRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxCPUUtilRatio.Location = New System.Drawing.Point(40, 0)
        Me.cbxCPUUtilRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxCPUUtilRatio.Name = "cbxCPUUtilRatio"
        Me.cbxCPUUtilRatio.Radius = 10
        Me.cbxCPUUtilRatio.Size = New System.Drawing.Size(308, 18)
        Me.cbxCPUUtilRatio.TabIndex = 1
        Me.cbxCPUUtilRatio.Text = "CPU Util ratio (%)"
        Me.cbxCPUUtilRatio.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxCPUUtilRatio.UseVisualStyleBackColor = True
        '
        'lblDuration8
        '
        Me.lblDuration8.AutoSize = True
        Me.lblDuration8.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration8.ForeColor = System.Drawing.Color.White
        Me.lblDuration8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration8.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration8.Name = "lblDuration8"
        Me.lblDuration8.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration8.TabIndex = 5
        Me.lblDuration8.Text = "min"
        Me.lblDuration8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCPUUtilRatio
        '
        Me.nudCPUUtilRatio.BackColor = System.Drawing.Color.White
        Me.nudCPUUtilRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCPUUtilRatio.Enabled = False
        Me.nudCPUUtilRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudCPUUtilRatio.Location = New System.Drawing.Point(291, 39)
        Me.nudCPUUtilRatio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCPUUtilRatio.Name = "nudCPUUtilRatio"
        Me.nudCPUUtilRatio.Size = New System.Drawing.Size(54, 21)
        Me.nudCPUUtilRatio.TabIndex = 4
        Me.nudCPUUtilRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUCPUUtilRatio
        '
        Me.cbxDUCPUUtilRatio.AutoSize = True
        Me.cbxDUCPUUtilRatio.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem8.SetColumnSpan(Me.cbxDUCPUUtilRatio, 2)
        Me.cbxDUCPUUtilRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUCPUUtilRatio.ForeColor = System.Drawing.Color.White
        Me.cbxDUCPUUtilRatio.LineColor = System.Drawing.Color.Gray
        Me.cbxDUCPUUtilRatio.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUCPUUtilRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUCPUUtilRatio.Name = "cbxDUCPUUtilRatio"
        Me.cbxDUCPUUtilRatio.Radius = 10
        Me.cbxDUCPUUtilRatio.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUCPUUtilRatio.TabIndex = 3
        Me.cbxDUCPUUtilRatio.Text = "Alert Duration"
        Me.cbxDUCPUUtilRatio.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUCPUUtilRatio.UseVisualStyleBackColor = True
        '
        'dtbCPUutilratio
        '
        Me.dtbCPUutilratio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbCPUutilratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUutilratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCPUutilratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCPUutilratio.BarMaxValue = 70
        Me.dtbCPUutilratio.BarMinValue = 50
        Me.dtbCPUutilratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCPUutilratio.CaptionSpacing = 10
        Me.tlpCriticalItem8.SetColumnSpan(Me.dtbCPUutilratio, 2)
        Me.dtbCPUutilratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCPUutilratio.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbCPUutilratio.ForeColor = System.Drawing.Color.White
        Me.dtbCPUutilratio.Location = New System.Drawing.Point(3, 21)
        Me.dtbCPUutilratio.LRPadding = 12
        Me.dtbCPUutilratio.Name = "dtbCPUutilratio"
        Me.tlpCriticalItem8.SetRowSpan(Me.dtbCPUutilratio, 2)
        Me.dtbCPUutilratio.Size = New System.Drawing.Size(282, 42)
        Me.dtbCPUutilratio.TabIndex = 2
        Me.dtbCPUutilratio.TabStop = False
        Me.dtbCPUutilratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCPUutilratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCPUutilratio.TickSpacing = 20
        Me.dtbCPUutilratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUutilratio.TrackHeight = 2
        Me.dtbCPUutilratio.TrackToCaptionDistance = 14
        Me.dtbCPUutilratio.TrackToTickInterval = 4
        Me.dtbCPUutilratio.YPosition = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label26.Location = New System.Drawing.Point(3, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 18)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "      "
        '
        'tlpCriticalItem7
        '
        Me.tlpCriticalItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem7.ColumnCount = 4
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem7.Controls.Add(Me.cbxReplicationDelay, 1, 0)
        Me.tlpCriticalItem7.Controls.Add(Me.lblDuration7, 2, 2)
        Me.tlpCriticalItem7.Controls.Add(Me.nudReplicationDelay, 1, 2)
        Me.tlpCriticalItem7.Controls.Add(Me.cbxDUReplicationDelay, 2, 1)
        Me.tlpCriticalItem7.Controls.Add(Me.dtbReplicationDelay, 0, 1)
        Me.tlpCriticalItem7.Controls.Add(Me.Label16, 0, 0)
        Me.tlpCriticalItem7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem7.Location = New System.Drawing.Point(3, 579)
        Me.tlpCriticalItem7.Name = "tlpCriticalItem7"
        Me.tlpCriticalItem7.RowCount = 3
        Me.tlpCriticalItem7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem7.Size = New System.Drawing.Size(384, 66)
        Me.tlpCriticalItem7.TabIndex = 9
        '
        'cbxReplicationDelay
        '
        Me.cbxReplicationDelay.AutoSize = True
        Me.cbxReplicationDelay.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem7.SetColumnSpan(Me.cbxReplicationDelay, 2)
        Me.cbxReplicationDelay.ForeColor = System.Drawing.Color.White
        Me.cbxReplicationDelay.LineColor = System.Drawing.Color.Gray
        Me.cbxReplicationDelay.Location = New System.Drawing.Point(40, 0)
        Me.cbxReplicationDelay.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxReplicationDelay.Name = "cbxReplicationDelay"
        Me.cbxReplicationDelay.Radius = 10
        Me.cbxReplicationDelay.Size = New System.Drawing.Size(154, 16)
        Me.cbxReplicationDelay.TabIndex = 1
        Me.cbxReplicationDelay.Text = "Replication delay (MB)"
        Me.cbxReplicationDelay.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxReplicationDelay.UseVisualStyleBackColor = True
        '
        'lblDuration7
        '
        Me.lblDuration7.AutoSize = True
        Me.lblDuration7.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration7.ForeColor = System.Drawing.Color.White
        Me.lblDuration7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration7.Location = New System.Drawing.Point(351, 36)
        Me.lblDuration7.Name = "lblDuration7"
        Me.lblDuration7.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration7.TabIndex = 5
        Me.lblDuration7.Text = "min"
        Me.lblDuration7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudReplicationDelay
        '
        Me.nudReplicationDelay.BackColor = System.Drawing.Color.White
        Me.nudReplicationDelay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudReplicationDelay.Enabled = False
        Me.nudReplicationDelay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudReplicationDelay.Location = New System.Drawing.Point(291, 39)
        Me.nudReplicationDelay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudReplicationDelay.Name = "nudReplicationDelay"
        Me.nudReplicationDelay.Size = New System.Drawing.Size(54, 21)
        Me.nudReplicationDelay.TabIndex = 4
        Me.nudReplicationDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUReplicationDelay
        '
        Me.cbxDUReplicationDelay.AutoSize = True
        Me.cbxDUReplicationDelay.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem7.SetColumnSpan(Me.cbxDUReplicationDelay, 2)
        Me.cbxDUReplicationDelay.ForeColor = System.Drawing.Color.White
        Me.cbxDUReplicationDelay.LineColor = System.Drawing.Color.Gray
        Me.cbxDUReplicationDelay.Location = New System.Drawing.Point(288, 18)
        Me.cbxDUReplicationDelay.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUReplicationDelay.Name = "cbxDUReplicationDelay"
        Me.cbxDUReplicationDelay.Radius = 10
        Me.cbxDUReplicationDelay.Size = New System.Drawing.Size(99, 16)
        Me.cbxDUReplicationDelay.TabIndex = 3
        Me.cbxDUReplicationDelay.Text = "Alert Duration"
        Me.cbxDUReplicationDelay.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUReplicationDelay.UseVisualStyleBackColor = True
        '
        'dtbReplicationDelay
        '
        Me.dtbReplicationDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbReplicationDelay.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbReplicationDelay.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbReplicationDelay.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbReplicationDelay.BarMaxValue = 500
        Me.dtbReplicationDelay.BarMinValue = 100
        Me.dtbReplicationDelay.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbReplicationDelay.CaptionSpacing = 10
        Me.tlpCriticalItem7.SetColumnSpan(Me.dtbReplicationDelay, 2)
        Me.dtbReplicationDelay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbReplicationDelay.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbReplicationDelay.ForeColor = System.Drawing.Color.White
        Me.dtbReplicationDelay.Location = New System.Drawing.Point(3, 21)
        Me.dtbReplicationDelay.LRPadding = 12
        Me.dtbReplicationDelay.Name = "dtbReplicationDelay"
        Me.tlpCriticalItem7.SetRowSpan(Me.dtbReplicationDelay, 2)
        Me.dtbReplicationDelay.Size = New System.Drawing.Size(282, 42)
        Me.dtbReplicationDelay.TabIndex = 2
        Me.dtbReplicationDelay.TabStop = False
        Me.dtbReplicationDelay.Text = "DoubleTrackBarDraw1"
        Me.dtbReplicationDelay.TickColor = System.Drawing.Color.Silver
        Me.dtbReplicationDelay.TickSpacing = 20
        Me.dtbReplicationDelay.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbReplicationDelay.TrackHeight = 2
        Me.dtbReplicationDelay.TrackMaxValue = 2000
        Me.dtbReplicationDelay.TrackToCaptionDistance = 14
        Me.dtbReplicationDelay.TrackToTickInterval = 4
        Me.dtbReplicationDelay.YPosition = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "      "
        '
        'AlertConfigurationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.tlpAlertConfigurationMain)
        Me.DoubleBuffered = True
        Me.Name = "AlertConfigurationForm"
        Me.Size = New System.Drawing.Size(868, 650)
        Me.tlpCriticalItem4.ResumeLayout(False)
        Me.tlpCriticalItem4.PerformLayout()
        CType(Me.nudDiskUsedRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem3.ResumeLayout(False)
        Me.tlpCriticalItem3.PerformLayout()
        CType(Me.nudSwapUsedRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem6.ResumeLayout(False)
        Me.tlpCriticalItem6.PerformLayout()
        CType(Me.nudCPUWaitRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem5.ResumeLayout(False)
        Me.tlpCriticalItem5.PerformLayout()
        CType(Me.nudConnections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem2.ResumeLayout(False)
        Me.tlpCriticalItem2.PerformLayout()
        CType(Me.nudCommitRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem1.ResumeLayout(False)
        Me.tlpCriticalItem1.PerformLayout()
        CType(Me.nudBufferHitRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpWarningItems.ResumeLayout(False)
        Me.tlpWarningItems.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.nudConfailedcnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWALcnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudNotiCycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblTransactionAlert.ResumeLayout(False)
        Me.tblTransactionAlert.PerformLayout()
        CType(Me.nudLockTransactionRTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrozenMaxAgeCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIdletranscntCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLongrunsqlsecCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLockedtranccntCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrozenMaxAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLockedtranccnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLongrunsqlsec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastvacuumDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIdletranscnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnusedindexcnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastAnalyzeday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpAlertConfigurationMain.ResumeLayout(False)
        Me.tlpCriticalItem9.ResumeLayout(False)
        Me.tlpCriticalItem9.PerformLayout()
        CType(Me.nudMemoryUsedRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem8.ResumeLayout(False)
        Me.tlpCriticalItem8.PerformLayout()
        CType(Me.nudCPUUtilRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem7.ResumeLayout(False)
        Me.tlpCriticalItem7.PerformLayout()
        CType(Me.nudReplicationDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpCriticalItem6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtbCPUwaitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbConnections As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbCommitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbBufferhitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents tlpWarningItems As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTxAlert As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tblTransactionAlert As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbxConfailedcnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxLastvacuumDay As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxLongrunsqlsec As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxLockedtranccnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudConfailedcnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLastvacuumDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLongrunsqlsec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLockedtranccnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxLastAnalyzeday As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxUnusedindexcnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxIdletranscnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudLastAnalyzeday As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudUnusedindexcnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIdletranscnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents tlpCriticalItem4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tlpAlertConfigurationMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtbDiskusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbSWAPusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents nudDiskUsedRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUDiskUsedRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxDUSwapUsedRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudCPUWaitRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUCPUWaitRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudConnections As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUConnections As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudCommitRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUCommitRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudBufferHitRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUBufferHitRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblDuration1 As System.Windows.Forms.Label
    Friend WithEvents lblDuration4 As System.Windows.Forms.Label
    Friend WithEvents lblDuration6 As System.Windows.Forms.Label
    Friend WithEvents lblDuration5 As System.Windows.Forms.Label
    Friend WithEvents lblDuration2 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDuration7 As System.Windows.Forms.Label
    Friend WithEvents nudReplicationDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUReplicationDelay As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbReplicationDelay As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblSMSAlert As System.Windows.Forms.Label
    Friend WithEvents nudNotiCycle As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbNotiLevel As eXperDB.BaseControls.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbNotiUsers As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnUserGroup As eXperDB.BaseControls.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtBusiness As eXperDB.BaseControls.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents nudSwapUsedRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents tlpCriticalItem9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents nudMemoryUsedRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUMemoryUsedRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbMEMusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDuration8 As System.Windows.Forms.Label
    Friend WithEvents nudCPUUtilRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUCPUUtilRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbCPUutilratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbxVirtualIP As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxReplSlot As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxHAStatus As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblHAClusterAlert As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbxDiskUsedRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxConnections As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxCommitRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxBufferHitRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxSwapUsedRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxCPUWaitRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxMemoryUsedRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxCPUUtilRatio As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxReplicationDelay As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblDelayAlert3 As System.Windows.Forms.Label
    Friend WithEvents lblDelayAlert2 As System.Windows.Forms.Label
    Friend WithEvents lblDelayAlert1 As System.Windows.Forms.Label
    Friend WithEvents cmbVIP As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbReplSlot As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbHAStatus As eXperDB.BaseControls.ComboBox
    Friend WithEvents cbxWALcnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudWALcnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudFrozenMaxAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxFrozenAge As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudFrozenMaxAgeCritical As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIdletranscntCritical As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLongrunsqlsecCritical As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLockedtranccntCritical As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxInvalidindex As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblLockTransaction As System.Windows.Forms.Label
    Friend WithEvents nudLockTransactionRTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLongSQLFilter As eXperDB.BaseControls.Button

End Class
