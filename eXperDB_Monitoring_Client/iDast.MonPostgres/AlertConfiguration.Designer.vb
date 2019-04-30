<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertConfiguration))
        Me.tlpCriticalItem4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration4 = New System.Windows.Forms.Label()
        Me.nudDuration4 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration4 = New eXperDB.BaseControls.CheckBox()
        Me.dtbDiskusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration3 = New System.Windows.Forms.Label()
        Me.nudDuration3 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration3 = New eXperDB.BaseControls.CheckBox()
        Me.dtbSWAPusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration6 = New System.Windows.Forms.Label()
        Me.nudDuration6 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration6 = New eXperDB.BaseControls.CheckBox()
        Me.dtbCPUwaitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration5 = New System.Windows.Forms.Label()
        Me.nudDuration5 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration5 = New eXperDB.BaseControls.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtbConnections = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.tlpCriticalItem2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration2 = New System.Windows.Forms.Label()
        Me.nudDuration2 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration2 = New eXperDB.BaseControls.CheckBox()
        Me.dtbCommitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration1 = New System.Windows.Forms.Label()
        Me.nudDuration1 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration1 = New eXperDB.BaseControls.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtbBufferhitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.tlpWarningItems = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSender = New eXperDB.BaseControls.TextBox()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTxAlert = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudLockedtranccnt = New System.Windows.Forms.NumericUpDown()
        Me.nudLongrunsqlsec = New System.Windows.Forms.NumericUpDown()
        Me.nudLastvacuumDay = New System.Windows.Forms.NumericUpDown()
        Me.nudConfailedcnt = New System.Windows.Forms.NumericUpDown()
        Me.nudIdletranscnt = New System.Windows.Forms.NumericUpDown()
        Me.nudUnusedindexcnt = New System.Windows.Forms.NumericUpDown()
        Me.nudLastAnalyzeday = New System.Windows.Forms.NumericUpDown()
        Me.cbxLockedtranccnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxLongrunsqlsec = New eXperDB.BaseControls.CheckBox()
        Me.cbxLastvacuumDay = New eXperDB.BaseControls.CheckBox()
        Me.cbxConfailedcnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxIdletranscnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxLastAnalyzeday = New eXperDB.BaseControls.CheckBox()
        Me.cbxUnusedindexcnt = New eXperDB.BaseControls.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpAlertConfigurationMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCriticalItem7 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration7 = New System.Windows.Forms.Label()
        Me.nudDuration7 = New System.Windows.Forms.NumericUpDown()
        Me.cbxDuration7 = New eXperDB.BaseControls.CheckBox()
        Me.dtbReplicationDelay = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem4.SuspendLayout()
        CType(Me.nudDuration4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem3.SuspendLayout()
        CType(Me.nudDuration3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem6.SuspendLayout()
        CType(Me.nudDuration6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem5.SuspendLayout()
        CType(Me.nudDuration5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem2.SuspendLayout()
        CType(Me.nudDuration2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem1.SuspendLayout()
        CType(Me.nudDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpWarningItems.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudNotiCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.nudLockedtranccnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLongrunsqlsec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastvacuumDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConfailedcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIdletranscnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnusedindexcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastAnalyzeday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAlertConfigurationMain.SuspendLayout()
        Me.tlpCriticalItem7.SuspendLayout()
        CType(Me.nudDuration7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpCriticalItem4
        '
        Me.tlpCriticalItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem4.ColumnCount = 4
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem4.Controls.Add(Me.lblDuration4, 2, 2)
        Me.tlpCriticalItem4.Controls.Add(Me.nudDuration4, 1, 2)
        Me.tlpCriticalItem4.Controls.Add(Me.cbxDuration4, 2, 1)
        Me.tlpCriticalItem4.Controls.Add(Me.dtbDiskusedratio, 0, 1)
        Me.tlpCriticalItem4.Controls.Add(Me.Label12, 1, 0)
        Me.tlpCriticalItem4.Controls.Add(Me.Label13, 0, 0)
        Me.tlpCriticalItem4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem4.Location = New System.Drawing.Point(3, 258)
        Me.tlpCriticalItem4.Name = "tlpCriticalItem4"
        Me.tlpCriticalItem4.RowCount = 3
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem4.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem4.TabIndex = 49
        '
        'lblDuration4
        '
        Me.lblDuration4.AutoSize = True
        Me.lblDuration4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration4.ForeColor = System.Drawing.Color.White
        Me.lblDuration4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration4.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration4.Name = "lblDuration4"
        Me.lblDuration4.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration4.TabIndex = 56
        Me.lblDuration4.Text = "min"
        Me.lblDuration4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration4
        '
        Me.nudDuration4.BackColor = System.Drawing.Color.White
        Me.nudDuration4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration4.Enabled = False
        Me.nudDuration4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration4.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration4.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration4.Name = "nudDuration4"
        Me.nudDuration4.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration4.TabIndex = 55
        Me.nudDuration4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration4
        '
        Me.cbxDuration4.AutoSize = True
        Me.cbxDuration4.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem4.SetColumnSpan(Me.cbxDuration4, 2)
        Me.cbxDuration4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDuration4.ForeColor = System.Drawing.Color.White
        Me.cbxDuration4.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration4.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration4.Name = "cbxDuration4"
        Me.cbxDuration4.Radius = 10
        Me.cbxDuration4.Size = New System.Drawing.Size(129, 21)
        Me.cbxDuration4.TabIndex = 54
        Me.cbxDuration4.Text = "Alert Duration"
        Me.cbxDuration4.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration4.UseVisualStyleBackColor = True
        '
        'dtbDiskusedratio
        '
        Me.dtbDiskusedratio.BackColor = System.Drawing.Color.Gray
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
        Me.dtbDiskusedratio.Location = New System.Drawing.Point(3, 25)
        Me.dtbDiskusedratio.LRPadding = 12
        Me.dtbDiskusedratio.Name = "dtbDiskusedratio"
        Me.tlpCriticalItem4.SetRowSpan(Me.dtbDiskusedratio, 2)
        Me.dtbDiskusedratio.Size = New System.Drawing.Size(338, 51)
        Me.dtbDiskusedratio.TabIndex = 53
        Me.dtbDiskusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbDiskusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbDiskusedratio.TickSpacing = 20
        Me.dtbDiskusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratio.TrackHeight = 4
        Me.dtbDiskusedratio.TrackToCaptionDistance = 18
        Me.dtbDiskusedratio.TrackToTickInterval = 8
        Me.dtbDiskusedratio.YPosition = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(43, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(298, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Disk used ratio"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 22)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "      "
        '
        'tlpCriticalItem3
        '
        Me.tlpCriticalItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem3.ColumnCount = 4
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem3.Controls.Add(Me.lblDuration3, 2, 2)
        Me.tlpCriticalItem3.Controls.Add(Me.nudDuration3, 1, 2)
        Me.tlpCriticalItem3.Controls.Add(Me.cbxDuration3, 2, 1)
        Me.tlpCriticalItem3.Controls.Add(Me.dtbSWAPusedratio, 0, 1)
        Me.tlpCriticalItem3.Controls.Add(Me.Label10, 1, 0)
        Me.tlpCriticalItem3.Controls.Add(Me.Label11, 0, 0)
        Me.tlpCriticalItem3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem3.Location = New System.Drawing.Point(3, 173)
        Me.tlpCriticalItem3.Name = "tlpCriticalItem3"
        Me.tlpCriticalItem3.RowCount = 3
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem3.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem3.TabIndex = 48
        '
        'lblDuration3
        '
        Me.lblDuration3.AutoSize = True
        Me.lblDuration3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration3.ForeColor = System.Drawing.Color.White
        Me.lblDuration3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration3.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration3.Name = "lblDuration3"
        Me.lblDuration3.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration3.TabIndex = 47
        Me.lblDuration3.Text = "min"
        Me.lblDuration3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration3
        '
        Me.nudDuration3.BackColor = System.Drawing.Color.White
        Me.nudDuration3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration3.Enabled = False
        Me.nudDuration3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration3.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration3.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration3.Name = "nudDuration3"
        Me.nudDuration3.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration3.TabIndex = 46
        Me.nudDuration3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration3
        '
        Me.cbxDuration3.AutoSize = True
        Me.cbxDuration3.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem3.SetColumnSpan(Me.cbxDuration3, 2)
        Me.cbxDuration3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDuration3.ForeColor = System.Drawing.Color.White
        Me.cbxDuration3.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration3.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration3.Name = "cbxDuration3"
        Me.cbxDuration3.Radius = 10
        Me.cbxDuration3.Size = New System.Drawing.Size(129, 21)
        Me.cbxDuration3.TabIndex = 45
        Me.cbxDuration3.Text = "Alert Duration"
        Me.cbxDuration3.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration3.UseVisualStyleBackColor = True
        '
        'dtbSWAPusedratio
        '
        Me.dtbSWAPusedratio.BackColor = System.Drawing.Color.Gray
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
        Me.dtbSWAPusedratio.Location = New System.Drawing.Point(3, 25)
        Me.dtbSWAPusedratio.LRPadding = 12
        Me.dtbSWAPusedratio.Name = "dtbSWAPusedratio"
        Me.tlpCriticalItem3.SetRowSpan(Me.dtbSWAPusedratio, 2)
        Me.dtbSWAPusedratio.Size = New System.Drawing.Size(338, 51)
        Me.dtbSWAPusedratio.TabIndex = 44
        Me.dtbSWAPusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbSWAPusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbSWAPusedratio.TickSpacing = 20
        Me.dtbSWAPusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratio.TrackHeight = 4
        Me.dtbSWAPusedratio.TrackToCaptionDistance = 18
        Me.dtbSWAPusedratio.TrackToTickInterval = 8
        Me.dtbSWAPusedratio.YPosition = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(43, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(298, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SWAP used ratio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 22)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "      "
        '
        'tlpCriticalItem6
        '
        Me.tlpCriticalItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem6.ColumnCount = 4
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem6.Controls.Add(Me.lblDuration6, 2, 2)
        Me.tlpCriticalItem6.Controls.Add(Me.nudDuration6, 1, 2)
        Me.tlpCriticalItem6.Controls.Add(Me.cbxDuration6, 2, 1)
        Me.tlpCriticalItem6.Controls.Add(Me.dtbCPUwaitratio, 0, 1)
        Me.tlpCriticalItem6.Controls.Add(Me.Label8, 1, 0)
        Me.tlpCriticalItem6.Controls.Add(Me.Label9, 0, 0)
        Me.tlpCriticalItem6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem6.Location = New System.Drawing.Point(3, 428)
        Me.tlpCriticalItem6.Name = "tlpCriticalItem6"
        Me.tlpCriticalItem6.RowCount = 3
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem6.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem6.TabIndex = 47
        '
        'lblDuration6
        '
        Me.lblDuration6.AutoSize = True
        Me.lblDuration6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration6.ForeColor = System.Drawing.Color.White
        Me.lblDuration6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration6.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration6.Name = "lblDuration6"
        Me.lblDuration6.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration6.TabIndex = 43
        Me.lblDuration6.Text = "min"
        Me.lblDuration6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration6
        '
        Me.nudDuration6.BackColor = System.Drawing.Color.White
        Me.nudDuration6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration6.Enabled = False
        Me.nudDuration6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration6.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration6.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration6.Name = "nudDuration6"
        Me.nudDuration6.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration6.TabIndex = 42
        Me.nudDuration6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration6
        '
        Me.cbxDuration6.AutoSize = True
        Me.cbxDuration6.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem6.SetColumnSpan(Me.cbxDuration6, 2)
        Me.cbxDuration6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDuration6.ForeColor = System.Drawing.Color.White
        Me.cbxDuration6.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration6.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration6.Name = "cbxDuration6"
        Me.cbxDuration6.Radius = 10
        Me.cbxDuration6.Size = New System.Drawing.Size(129, 21)
        Me.cbxDuration6.TabIndex = 41
        Me.cbxDuration6.Text = "Alert Duration"
        Me.cbxDuration6.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration6.UseVisualStyleBackColor = True
        '
        'dtbCPUwaitratio
        '
        Me.dtbCPUwaitratio.BackColor = System.Drawing.Color.Gray
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
        Me.dtbCPUwaitratio.Location = New System.Drawing.Point(3, 25)
        Me.dtbCPUwaitratio.LRPadding = 12
        Me.dtbCPUwaitratio.Name = "dtbCPUwaitratio"
        Me.tlpCriticalItem6.SetRowSpan(Me.dtbCPUwaitratio, 2)
        Me.dtbCPUwaitratio.Size = New System.Drawing.Size(338, 51)
        Me.dtbCPUwaitratio.TabIndex = 40
        Me.dtbCPUwaitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCPUwaitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCPUwaitratio.TickSpacing = 20
        Me.dtbCPUwaitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratio.TrackHeight = 4
        Me.dtbCPUwaitratio.TrackToCaptionDistance = 18
        Me.dtbCPUwaitratio.TrackToTickInterval = 8
        Me.dtbCPUwaitratio.YPosition = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(43, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "CPU wait ratio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "      "
        '
        'tlpCriticalItem5
        '
        Me.tlpCriticalItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem5.ColumnCount = 4
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem5.Controls.Add(Me.lblDuration5, 2, 2)
        Me.tlpCriticalItem5.Controls.Add(Me.nudDuration5, 1, 2)
        Me.tlpCriticalItem5.Controls.Add(Me.cbxDuration5, 2, 1)
        Me.tlpCriticalItem5.Controls.Add(Me.Label6, 1, 0)
        Me.tlpCriticalItem5.Controls.Add(Me.Label7, 0, 0)
        Me.tlpCriticalItem5.Controls.Add(Me.dtbConnections, 0, 1)
        Me.tlpCriticalItem5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem5.Location = New System.Drawing.Point(3, 343)
        Me.tlpCriticalItem5.Name = "tlpCriticalItem5"
        Me.tlpCriticalItem5.RowCount = 3
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem5.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem5.TabIndex = 46
        '
        'lblDuration5
        '
        Me.lblDuration5.AutoSize = True
        Me.lblDuration5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration5.ForeColor = System.Drawing.Color.White
        Me.lblDuration5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration5.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration5.Name = "lblDuration5"
        Me.lblDuration5.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration5.TabIndex = 42
        Me.lblDuration5.Text = "min"
        Me.lblDuration5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration5
        '
        Me.nudDuration5.BackColor = System.Drawing.Color.White
        Me.nudDuration5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration5.Enabled = False
        Me.nudDuration5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration5.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration5.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration5.Name = "nudDuration5"
        Me.nudDuration5.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration5.TabIndex = 41
        Me.nudDuration5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration5
        '
        Me.cbxDuration5.AutoSize = True
        Me.cbxDuration5.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem5.SetColumnSpan(Me.cbxDuration5, 2)
        Me.cbxDuration5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDuration5.ForeColor = System.Drawing.Color.White
        Me.cbxDuration5.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration5.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration5.Name = "cbxDuration5"
        Me.cbxDuration5.Radius = 10
        Me.cbxDuration5.Size = New System.Drawing.Size(129, 21)
        Me.cbxDuration5.TabIndex = 40
        Me.cbxDuration5.Text = "Alert Duration"
        Me.cbxDuration5.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(43, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Connections"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "      "
        '
        'dtbConnections
        '
        Me.dtbConnections.BackColor = System.Drawing.Color.Gray
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
        Me.dtbConnections.Location = New System.Drawing.Point(3, 25)
        Me.dtbConnections.LRPadding = 12
        Me.dtbConnections.Name = "dtbConnections"
        Me.tlpCriticalItem5.SetRowSpan(Me.dtbConnections, 2)
        Me.dtbConnections.Size = New System.Drawing.Size(338, 51)
        Me.dtbConnections.TabIndex = 39
        Me.dtbConnections.Text = "DoubleTrackBarDraw1"
        Me.dtbConnections.TickColor = System.Drawing.Color.Silver
        Me.dtbConnections.TickSpacing = 20
        Me.dtbConnections.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnections.TrackHeight = 4
        Me.dtbConnections.TrackToCaptionDistance = 18
        Me.dtbConnections.TrackToTickInterval = 8
        Me.dtbConnections.YPosition = 10
        '
        'tlpCriticalItem2
        '
        Me.tlpCriticalItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem2.ColumnCount = 4
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem2.Controls.Add(Me.lblDuration2, 2, 2)
        Me.tlpCriticalItem2.Controls.Add(Me.nudDuration2, 1, 2)
        Me.tlpCriticalItem2.Controls.Add(Me.cbxDuration2, 2, 1)
        Me.tlpCriticalItem2.Controls.Add(Me.dtbCommitratio, 0, 1)
        Me.tlpCriticalItem2.Controls.Add(Me.Label4, 1, 0)
        Me.tlpCriticalItem2.Controls.Add(Me.Label5, 0, 0)
        Me.tlpCriticalItem2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem2.Location = New System.Drawing.Point(3, 88)
        Me.tlpCriticalItem2.Name = "tlpCriticalItem2"
        Me.tlpCriticalItem2.RowCount = 3
        Me.tlpCriticalItem2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem2.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem2.TabIndex = 45
        '
        'lblDuration2
        '
        Me.lblDuration2.AutoSize = True
        Me.lblDuration2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration2.ForeColor = System.Drawing.Color.White
        Me.lblDuration2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration2.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration2.TabIndex = 41
        Me.lblDuration2.Text = "min"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration2
        '
        Me.nudDuration2.BackColor = System.Drawing.Color.White
        Me.nudDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration2.Enabled = False
        Me.nudDuration2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration2.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration2.Name = "nudDuration2"
        Me.nudDuration2.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration2.TabIndex = 40
        Me.nudDuration2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration2
        '
        Me.cbxDuration2.AutoSize = True
        Me.cbxDuration2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem2.SetColumnSpan(Me.cbxDuration2, 2)
        Me.cbxDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDuration2.ForeColor = System.Drawing.Color.White
        Me.cbxDuration2.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration2.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration2.Name = "cbxDuration2"
        Me.cbxDuration2.Radius = 10
        Me.cbxDuration2.Size = New System.Drawing.Size(129, 21)
        Me.cbxDuration2.TabIndex = 39
        Me.cbxDuration2.Text = "Alert Duration"
        Me.cbxDuration2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration2.UseVisualStyleBackColor = True
        '
        'dtbCommitratio
        '
        Me.dtbCommitratio.BackColor = System.Drawing.Color.Gray
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
        Me.dtbCommitratio.Location = New System.Drawing.Point(3, 25)
        Me.dtbCommitratio.LRPadding = 12
        Me.dtbCommitratio.Name = "dtbCommitratio"
        Me.tlpCriticalItem2.SetRowSpan(Me.dtbCommitratio, 2)
        Me.dtbCommitratio.Size = New System.Drawing.Size(338, 51)
        Me.dtbCommitratio.TabIndex = 38
        Me.dtbCommitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCommitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCommitratio.TickSpacing = 20
        Me.dtbCommitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCommitratio.TrackColor1 = System.Drawing.Color.Red
        Me.dtbCommitratio.TrackColor3 = System.Drawing.Color.Lime
        Me.dtbCommitratio.TrackHeight = 4
        Me.dtbCommitratio.TrackToCaptionDistance = 18
        Me.dtbCommitratio.TrackToTickInterval = 8
        Me.dtbCommitratio.YPosition = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(43, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Commit ratio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "      "
        '
        'tlpCriticalItem1
        '
        Me.tlpCriticalItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem1.ColumnCount = 4
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem1.Controls.Add(Me.lblDuration1, 2, 2)
        Me.tlpCriticalItem1.Controls.Add(Me.nudDuration1, 0, 2)
        Me.tlpCriticalItem1.Controls.Add(Me.cbxDuration1, 2, 1)
        Me.tlpCriticalItem1.Controls.Add(Me.Label2, 1, 0)
        Me.tlpCriticalItem1.Controls.Add(Me.Label3, 0, 0)
        Me.tlpCriticalItem1.Controls.Add(Me.dtbBufferhitratio, 0, 1)
        Me.tlpCriticalItem1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem1.Location = New System.Drawing.Point(3, 3)
        Me.tlpCriticalItem1.Name = "tlpCriticalItem1"
        Me.tlpCriticalItem1.RowCount = 3
        Me.tlpCriticalItem1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem1.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem1.TabIndex = 44
        '
        'lblDuration1
        '
        Me.lblDuration1.AutoSize = True
        Me.lblDuration1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration1.ForeColor = System.Drawing.Color.White
        Me.lblDuration1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration1.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration1.Name = "lblDuration1"
        Me.lblDuration1.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration1.TabIndex = 29
        Me.lblDuration1.Text = "min"
        Me.lblDuration1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration1
        '
        Me.nudDuration1.BackColor = System.Drawing.Color.White
        Me.nudDuration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration1.Enabled = False
        Me.nudDuration1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration1.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration1.Name = "nudDuration1"
        Me.nudDuration1.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration1.TabIndex = 28
        Me.nudDuration1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration1
        '
        Me.cbxDuration1.AutoSize = True
        Me.cbxDuration1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem1.SetColumnSpan(Me.cbxDuration1, 2)
        Me.cbxDuration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDuration1.ForeColor = System.Drawing.Color.White
        Me.cbxDuration1.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration1.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration1.Name = "cbxDuration1"
        Me.cbxDuration1.Radius = 10
        Me.cbxDuration1.Size = New System.Drawing.Size(129, 21)
        Me.cbxDuration1.TabIndex = 27
        Me.cbxDuration1.Text = "Alert Duration"
        Me.cbxDuration1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(43, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buffer hit ratio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "      "
        '
        'dtbBufferhitratio
        '
        Me.dtbBufferhitratio.BackColor = System.Drawing.Color.Gray
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
        Me.dtbBufferhitratio.Location = New System.Drawing.Point(3, 25)
        Me.dtbBufferhitratio.LRPadding = 12
        Me.dtbBufferhitratio.Name = "dtbBufferhitratio"
        Me.tlpCriticalItem1.SetRowSpan(Me.dtbBufferhitratio, 2)
        Me.dtbBufferhitratio.Size = New System.Drawing.Size(338, 51)
        Me.dtbBufferhitratio.TabIndex = 26
        Me.dtbBufferhitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbBufferhitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbBufferhitratio.TickHeight = 4
        Me.dtbBufferhitratio.TickSpacing = 20
        Me.dtbBufferhitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbBufferhitratio.TrackColor1 = System.Drawing.Color.Red
        Me.dtbBufferhitratio.TrackColor3 = System.Drawing.Color.Lime
        Me.dtbBufferhitratio.TrackHeight = 4
        Me.dtbBufferhitratio.TrackToCaptionDistance = 18
        Me.dtbBufferhitratio.TrackToTickInterval = 8
        Me.dtbBufferhitratio.YPosition = 10
        '
        'tlpWarningItems
        '
        Me.tlpWarningItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpWarningItems.ColumnCount = 2
        Me.tlpWarningItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpWarningItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWarningItems.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.tlpWarningItems.Controls.Add(Me.Label17, 0, 2)
        Me.tlpWarningItems.Controls.Add(Me.Label14, 1, 2)
        Me.tlpWarningItems.Controls.Add(Me.lblTxAlert, 1, 0)
        Me.tlpWarningItems.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.tlpWarningItems.Controls.Add(Me.Label1, 0, 0)
        Me.tlpWarningItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWarningItems.Location = New System.Drawing.Point(488, 3)
        Me.tlpWarningItems.Name = "tlpWarningItems"
        Me.tlpWarningItems.RowCount = 4
        Me.tlpAlertConfigurationMain.SetRowSpan(Me.tlpWarningItems, 7)
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpWarningItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.0!))
        Me.tlpWarningItems.Size = New System.Drawing.Size(372, 589)
        Me.tlpWarningItems.TabIndex = 26
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.tlpWarningItems.SetColumnSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtSender, 2, 4)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 396)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(371, 190)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'txtSender
        '
        Me.txtSender.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSender.code = False
        Me.txtSender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSender.FixedWidth = False
        Me.txtSender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSender.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtSender.Location = New System.Drawing.Point(169, 143)
        Me.txtSender.MaxByteLength = 16
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Necessary = False
        Me.txtSender.PossibleInput = ""
        Me.txtSender.Prefix = ""
        Me.txtSender.Size = New System.Drawing.Size(124, 21)
        Me.txtSender.StatusTip = ""
        Me.txtSender.TabIndex = 62
        Me.txtSender.Value = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Gray
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(39, 145)
        Me.Label22.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 12)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Sender Info"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUserGroup
        '
        Me.btnUserGroup.BackColor = System.Drawing.Color.Gray
        Me.btnUserGroup.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnUserGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserGroup.FixedWidth = False
        Me.btnUserGroup.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnUserGroup.ForeColor = System.Drawing.Color.White
        Me.btnUserGroup.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUserGroup.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnUserGroup.Location = New System.Drawing.Point(299, 60)
        Me.btnUserGroup.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnUserGroup.Name = "btnUserGroup"
        Me.btnUserGroup.Radius = 5
        Me.btnUserGroup.Size = New System.Drawing.Size(94, 27)
        Me.btnUserGroup.TabIndex = 60
        Me.btnUserGroup.Text = "F025"
        Me.btnUserGroup.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUserGroup.UseRound = True
        Me.btnUserGroup.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Gray
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.Location = New System.Drawing.Point(299, 105)
        Me.Label21.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 12)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "min"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNotiUsers
        '
        Me.cmbNotiUsers.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNotiUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNotiUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNotiUsers.FixedWidth = False
        Me.cmbNotiUsers.FormattingEnabled = True
        Me.cmbNotiUsers.Location = New System.Drawing.Point(169, 63)
        Me.cmbNotiUsers.Name = "cmbNotiUsers"
        Me.cmbNotiUsers.Necessary = False
        Me.cmbNotiUsers.Size = New System.Drawing.Size(124, 20)
        Me.cmbNotiUsers.StatusTip = ""
        Me.cmbNotiUsers.TabIndex = 58
        Me.cmbNotiUsers.ValueText = ""
        '
        'cmbNotiLevel
        '
        Me.cmbNotiLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNotiLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNotiLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNotiLevel.FixedWidth = False
        Me.cmbNotiLevel.FormattingEnabled = True
        Me.cmbNotiLevel.Items.AddRange(New Object() {"None", "Warning", "Critical"})
        Me.cmbNotiLevel.Location = New System.Drawing.Point(169, 23)
        Me.cmbNotiLevel.Name = "cmbNotiLevel"
        Me.cmbNotiLevel.Necessary = False
        Me.cmbNotiLevel.Size = New System.Drawing.Size(124, 20)
        Me.cmbNotiLevel.StatusTip = ""
        Me.cmbNotiLevel.TabIndex = 57
        Me.cmbNotiLevel.ValueText = ""
        '
        'nudNotiCycle
        '
        Me.nudNotiCycle.BackColor = System.Drawing.Color.White
        Me.nudNotiCycle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudNotiCycle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudNotiCycle.Location = New System.Drawing.Point(169, 103)
        Me.nudNotiCycle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudNotiCycle.Name = "nudNotiCycle"
        Me.nudNotiCycle.Size = New System.Drawing.Size(124, 21)
        Me.nudNotiCycle.TabIndex = 56
        Me.nudNotiCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Gray
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Location = New System.Drawing.Point(39, 25)
        Me.Label20.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 12)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Level"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Gray
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(39, 105)
        Me.Label19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 12)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Cycle"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(39, 65)
        Me.Label18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 12)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "User Group"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Location = New System.Drawing.Point(3, 363)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 30)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "      "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(43, 363)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(331, 30)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Notification"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTxAlert
        '
        Me.lblTxAlert.AutoSize = True
        Me.lblTxAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTxAlert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTxAlert.ForeColor = System.Drawing.Color.White
        Me.lblTxAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTxAlert.Location = New System.Drawing.Point(43, 0)
        Me.lblTxAlert.Name = "lblTxAlert"
        Me.lblTxAlert.Size = New System.Drawing.Size(331, 30)
        Me.lblTxAlert.TabIndex = 0
        Me.lblTxAlert.Text = "Transaction alert"
        Me.lblTxAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.tlpWarningItems.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.85159!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14842!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.nudLockedtranccnt, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.nudLongrunsqlsec, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.nudLastvacuumDay, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.nudConfailedcnt, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.nudIdletranscnt, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.nudUnusedindexcnt, 2, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.nudLastAnalyzeday, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxLockedtranccnt, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxLongrunsqlsec, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxLastvacuumDay, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxConfailedcnt, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxIdletranscnt, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxLastAnalyzeday, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxUnusedindexcnt, 1, 7)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 9
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(371, 327)
        Me.TableLayoutPanel3.TabIndex = 24
        '
        'nudLockedtranccnt
        '
        Me.nudLockedtranccnt.BackColor = System.Drawing.Color.White
        Me.nudLockedtranccnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLockedtranccnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockedtranccnt.Location = New System.Drawing.Point(214, 23)
        Me.nudLockedtranccnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLockedtranccnt.Name = "nudLockedtranccnt"
        Me.nudLockedtranccnt.Size = New System.Drawing.Size(53, 21)
        Me.nudLockedtranccnt.TabIndex = 7
        Me.nudLockedtranccnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLongrunsqlsec
        '
        Me.nudLongrunsqlsec.BackColor = System.Drawing.Color.White
        Me.nudLongrunsqlsec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLongrunsqlsec.Location = New System.Drawing.Point(214, 65)
        Me.nudLongrunsqlsec.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLongrunsqlsec.Name = "nudLongrunsqlsec"
        Me.nudLongrunsqlsec.Size = New System.Drawing.Size(53, 21)
        Me.nudLongrunsqlsec.TabIndex = 9
        Me.nudLongrunsqlsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLastvacuumDay
        '
        Me.nudLastvacuumDay.BackColor = System.Drawing.Color.White
        Me.nudLastvacuumDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLastvacuumDay.Location = New System.Drawing.Point(214, 107)
        Me.nudLastvacuumDay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLastvacuumDay.Name = "nudLastvacuumDay"
        Me.nudLastvacuumDay.Size = New System.Drawing.Size(53, 21)
        Me.nudLastvacuumDay.TabIndex = 11
        Me.nudLastvacuumDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudConfailedcnt
        '
        Me.nudConfailedcnt.BackColor = System.Drawing.Color.White
        Me.nudConfailedcnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudConfailedcnt.Location = New System.Drawing.Point(214, 149)
        Me.nudConfailedcnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudConfailedcnt.Name = "nudConfailedcnt"
        Me.nudConfailedcnt.Size = New System.Drawing.Size(53, 21)
        Me.nudConfailedcnt.TabIndex = 15
        Me.nudConfailedcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudIdletranscnt
        '
        Me.nudIdletranscnt.BackColor = System.Drawing.Color.White
        Me.nudIdletranscnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudIdletranscnt.Location = New System.Drawing.Point(214, 191)
        Me.nudIdletranscnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudIdletranscnt.Name = "nudIdletranscnt"
        Me.nudIdletranscnt.Size = New System.Drawing.Size(53, 21)
        Me.nudIdletranscnt.TabIndex = 8
        Me.nudIdletranscnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudUnusedindexcnt
        '
        Me.nudUnusedindexcnt.BackColor = System.Drawing.Color.White
        Me.nudUnusedindexcnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudUnusedindexcnt.Location = New System.Drawing.Point(214, 275)
        Me.nudUnusedindexcnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudUnusedindexcnt.Name = "nudUnusedindexcnt"
        Me.nudUnusedindexcnt.Size = New System.Drawing.Size(53, 21)
        Me.nudUnusedindexcnt.TabIndex = 10
        Me.nudUnusedindexcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLastAnalyzeday
        '
        Me.nudLastAnalyzeday.BackColor = System.Drawing.Color.White
        Me.nudLastAnalyzeday.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLastAnalyzeday.Location = New System.Drawing.Point(214, 233)
        Me.nudLastAnalyzeday.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLastAnalyzeday.Name = "nudLastAnalyzeday"
        Me.nudLastAnalyzeday.Size = New System.Drawing.Size(53, 21)
        Me.nudLastAnalyzeday.TabIndex = 13
        Me.nudLastAnalyzeday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxLockedtranccnt
        '
        Me.cbxLockedtranccnt.AutoSize = True
        Me.cbxLockedtranccnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLockedtranccnt.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbxLockedtranccnt.ForeColor = System.Drawing.Color.White
        Me.cbxLockedtranccnt.LineColor = System.Drawing.Color.Gray
        Me.cbxLockedtranccnt.Location = New System.Drawing.Point(39, 23)
        Me.cbxLockedtranccnt.Name = "cbxLockedtranccnt"
        Me.cbxLockedtranccnt.Radius = 10
        Me.cbxLockedtranccnt.Size = New System.Drawing.Size(169, 16)
        Me.cbxLockedtranccnt.TabIndex = 16
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
        Me.cbxLongrunsqlsec.Location = New System.Drawing.Point(39, 65)
        Me.cbxLongrunsqlsec.Name = "cbxLongrunsqlsec"
        Me.cbxLongrunsqlsec.Radius = 10
        Me.cbxLongrunsqlsec.Size = New System.Drawing.Size(165, 16)
        Me.cbxLongrunsqlsec.TabIndex = 17
        Me.cbxLongrunsqlsec.Text = "Long running sql second"
        Me.cbxLongrunsqlsec.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLongrunsqlsec.UseVisualStyleBackColor = True
        '
        'cbxLastvacuumDay
        '
        Me.cbxLastvacuumDay.AutoSize = True
        Me.cbxLastvacuumDay.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLastvacuumDay.ForeColor = System.Drawing.Color.White
        Me.cbxLastvacuumDay.LineColor = System.Drawing.Color.Gray
        Me.cbxLastvacuumDay.Location = New System.Drawing.Point(39, 107)
        Me.cbxLastvacuumDay.Name = "cbxLastvacuumDay"
        Me.cbxLastvacuumDay.Radius = 10
        Me.cbxLastvacuumDay.Size = New System.Drawing.Size(118, 16)
        Me.cbxLastvacuumDay.TabIndex = 18
        Me.cbxLastvacuumDay.Text = "last vacuum day"
        Me.cbxLastvacuumDay.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLastvacuumDay.UseVisualStyleBackColor = True
        '
        'cbxConfailedcnt
        '
        Me.cbxConfailedcnt.AutoSize = True
        Me.cbxConfailedcnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxConfailedcnt.ForeColor = System.Drawing.Color.White
        Me.cbxConfailedcnt.LineColor = System.Drawing.Color.Gray
        Me.cbxConfailedcnt.Location = New System.Drawing.Point(39, 149)
        Me.cbxConfailedcnt.Name = "cbxConfailedcnt"
        Me.cbxConfailedcnt.Radius = 10
        Me.cbxConfailedcnt.Size = New System.Drawing.Size(157, 16)
        Me.cbxConfailedcnt.TabIndex = 19
        Me.cbxConfailedcnt.Text = "Connection failed count"
        Me.cbxConfailedcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxConfailedcnt.UseVisualStyleBackColor = True
        '
        'cbxIdletranscnt
        '
        Me.cbxIdletranscnt.AutoSize = True
        Me.cbxIdletranscnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxIdletranscnt.ForeColor = System.Drawing.Color.White
        Me.cbxIdletranscnt.LineColor = System.Drawing.Color.Gray
        Me.cbxIdletranscnt.Location = New System.Drawing.Point(39, 191)
        Me.cbxIdletranscnt.Name = "cbxIdletranscnt"
        Me.cbxIdletranscnt.Radius = 10
        Me.cbxIdletranscnt.Size = New System.Drawing.Size(159, 16)
        Me.cbxIdletranscnt.TabIndex = 20
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
        Me.cbxLastAnalyzeday.Location = New System.Drawing.Point(39, 233)
        Me.cbxLastAnalyzeday.Name = "cbxLastAnalyzeday"
        Me.cbxLastAnalyzeday.Radius = 10
        Me.cbxLastAnalyzeday.Size = New System.Drawing.Size(118, 16)
        Me.cbxLastAnalyzeday.TabIndex = 22
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
        Me.cbxUnusedindexcnt.Location = New System.Drawing.Point(39, 275)
        Me.cbxUnusedindexcnt.Name = "cbxUnusedindexcnt"
        Me.cbxUnusedindexcnt.Radius = 10
        Me.cbxUnusedindexcnt.Size = New System.Drawing.Size(137, 16)
        Me.cbxUnusedindexcnt.TabIndex = 21
        Me.cbxUnusedindexcnt.Text = "Unused index count"
        Me.cbxUnusedindexcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxUnusedindexcnt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'tlpAlertConfigurationMain
        '
        Me.tlpAlertConfigurationMain.BackColor = System.Drawing.Color.Gray
        Me.tlpAlertConfigurationMain.ColumnCount = 2
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.24!))
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.76!))
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem7, 0, 6)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpWarningItems, 1, 0)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem6, 0, 5)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem4, 0, 3)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem1, 0, 0)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem3, 0, 2)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem5, 0, 4)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem2, 0, 1)
        Me.tlpAlertConfigurationMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAlertConfigurationMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpAlertConfigurationMain.Name = "tlpAlertConfigurationMain"
        Me.tlpAlertConfigurationMain.RowCount = 8
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28523!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28523!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28523!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28523!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28523!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28523!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28863!))
        Me.tlpAlertConfigurationMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpAlertConfigurationMain.Size = New System.Drawing.Size(863, 600)
        Me.tlpAlertConfigurationMain.TabIndex = 3
        '
        'tlpCriticalItem7
        '
        Me.tlpCriticalItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem7.ColumnCount = 4
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tlpCriticalItem7.Controls.Add(Me.lblDuration7, 2, 2)
        Me.tlpCriticalItem7.Controls.Add(Me.nudDuration7, 1, 2)
        Me.tlpCriticalItem7.Controls.Add(Me.cbxDuration7, 2, 1)
        Me.tlpCriticalItem7.Controls.Add(Me.dtbReplicationDelay, 0, 1)
        Me.tlpCriticalItem7.Controls.Add(Me.Label15, 1, 0)
        Me.tlpCriticalItem7.Controls.Add(Me.Label16, 0, 0)
        Me.tlpCriticalItem7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem7.Location = New System.Drawing.Point(3, 513)
        Me.tlpCriticalItem7.Name = "tlpCriticalItem7"
        Me.tlpCriticalItem7.RowCount = 3
        Me.tlpCriticalItem7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpCriticalItem7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem7.Size = New System.Drawing.Size(479, 79)
        Me.tlpCriticalItem7.TabIndex = 50
        '
        'lblDuration7
        '
        Me.lblDuration7.AutoSize = True
        Me.lblDuration7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDuration7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration7.ForeColor = System.Drawing.Color.White
        Me.lblDuration7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration7.Location = New System.Drawing.Point(407, 49)
        Me.lblDuration7.Name = "lblDuration7"
        Me.lblDuration7.Size = New System.Drawing.Size(69, 30)
        Me.lblDuration7.TabIndex = 42
        Me.lblDuration7.Text = "min"
        Me.lblDuration7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDuration7
        '
        Me.nudDuration7.BackColor = System.Drawing.Color.White
        Me.nudDuration7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDuration7.Enabled = False
        Me.nudDuration7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDuration7.Location = New System.Drawing.Point(347, 52)
        Me.nudDuration7.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDuration7.Name = "nudDuration7"
        Me.nudDuration7.Size = New System.Drawing.Size(54, 21)
        Me.nudDuration7.TabIndex = 42
        Me.nudDuration7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDuration7
        '
        Me.cbxDuration7.AutoSize = True
        Me.cbxDuration7.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem7.SetColumnSpan(Me.cbxDuration7, 2)
        Me.cbxDuration7.ForeColor = System.Drawing.Color.White
        Me.cbxDuration7.LineColor = System.Drawing.Color.Gray
        Me.cbxDuration7.Location = New System.Drawing.Point(347, 25)
        Me.cbxDuration7.Name = "cbxDuration7"
        Me.cbxDuration7.Radius = 10
        Me.cbxDuration7.Size = New System.Drawing.Size(99, 16)
        Me.cbxDuration7.TabIndex = 41
        Me.cbxDuration7.Text = "Alert Duration"
        Me.cbxDuration7.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDuration7.UseVisualStyleBackColor = True
        '
        'dtbReplicationDelay
        '
        Me.dtbReplicationDelay.BackColor = System.Drawing.Color.Gray
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
        Me.dtbReplicationDelay.Location = New System.Drawing.Point(3, 25)
        Me.dtbReplicationDelay.LRPadding = 12
        Me.dtbReplicationDelay.Name = "dtbReplicationDelay"
        Me.tlpCriticalItem7.SetRowSpan(Me.dtbReplicationDelay, 2)
        Me.dtbReplicationDelay.Size = New System.Drawing.Size(338, 51)
        Me.dtbReplicationDelay.TabIndex = 40
        Me.dtbReplicationDelay.Text = "DoubleTrackBarDraw1"
        Me.dtbReplicationDelay.TickColor = System.Drawing.Color.Silver
        Me.dtbReplicationDelay.TickSpacing = 20
        Me.dtbReplicationDelay.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbReplicationDelay.TrackHeight = 4
        Me.dtbReplicationDelay.TrackMaxValue = 2000
        Me.dtbReplicationDelay.TrackToCaptionDistance = 18
        Me.dtbReplicationDelay.TrackToTickInterval = 8
        Me.dtbReplicationDelay.YPosition = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(43, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(298, 22)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Replication delay"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 22)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "      "
        '
        'AlertConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.tlpAlertConfigurationMain)
        Me.Name = "AlertConfiguration"
        Me.Size = New System.Drawing.Size(863, 600)
        Me.tlpCriticalItem4.ResumeLayout(False)
        Me.tlpCriticalItem4.PerformLayout()
        CType(Me.nudDuration4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem3.ResumeLayout(False)
        Me.tlpCriticalItem3.PerformLayout()
        CType(Me.nudDuration3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem6.ResumeLayout(False)
        Me.tlpCriticalItem6.PerformLayout()
        CType(Me.nudDuration6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem5.ResumeLayout(False)
        Me.tlpCriticalItem5.PerformLayout()
        CType(Me.nudDuration5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem2.ResumeLayout(False)
        Me.tlpCriticalItem2.PerformLayout()
        CType(Me.nudDuration2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem1.ResumeLayout(False)
        Me.tlpCriticalItem1.PerformLayout()
        CType(Me.nudDuration1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpWarningItems.ResumeLayout(False)
        Me.tlpWarningItems.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudNotiCycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.nudLockedtranccnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLongrunsqlsec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastvacuumDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConfailedcnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIdletranscnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnusedindexcnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastAnalyzeday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpAlertConfigurationMain.ResumeLayout(False)
        Me.tlpCriticalItem7.ResumeLayout(False)
        Me.tlpCriticalItem7.PerformLayout()
        CType(Me.nudDuration7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpCriticalItem6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtbCPUwaitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbConnections As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbCommitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbBufferhitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents tlpWarningItems As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTxAlert As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tlpAlertConfigurationMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtbDiskusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbSWAPusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents nudDuration4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration4 As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudDuration3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration3 As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudDuration6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration6 As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudDuration5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration5 As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudDuration2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration2 As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudDuration1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration1 As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblDuration1 As System.Windows.Forms.Label
    Friend WithEvents lblDuration4 As System.Windows.Forms.Label
    Friend WithEvents lblDuration3 As System.Windows.Forms.Label
    Friend WithEvents lblDuration6 As System.Windows.Forms.Label
    Friend WithEvents lblDuration5 As System.Windows.Forms.Label
    Friend WithEvents lblDuration2 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDuration7 As System.Windows.Forms.Label
    Friend WithEvents nudDuration7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDuration7 As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbReplicationDelay As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nudNotiCycle As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbNotiLevel As eXperDB.BaseControls.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbNotiUsers As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnUserGroup As eXperDB.BaseControls.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSender As eXperDB.BaseControls.TextBox

End Class
