<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertConfigurationHAGroupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertConfigurationHAGroupForm))
        Me.tlpCriticalItem4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxDiskUsedRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration4 = New System.Windows.Forms.Label()
        Me.nudDiskUsedRatioHA = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUDiskUsedRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.dtbDiskusedratioHA = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxSwapUsedRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nudSwapUsedRatioHA = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUSwapUsedRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.dtbSWAPusedratioHA = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxCPUWaitRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration6 = New System.Windows.Forms.Label()
        Me.nudCPUWaitRatioHA = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUCPUWaitRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.dtbCPUwaitratioHA = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxConnectionsHA = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration5 = New System.Windows.Forms.Label()
        Me.nudConnectionsHA = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUConnectionsHA = New eXperDB.BaseControls.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtbConnectionsHA = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.tlpAlertConfigurationMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCriticalItem9 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxMemoryUsedRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.nudMemoryUsedRatioHA = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUMemoryUsedRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.dtbMEMusedratioHA = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem8 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxCPUUtilRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.lblDuration8 = New System.Windows.Forms.Label()
        Me.nudCPUUtilRatioHA = New System.Windows.Forms.NumericUpDown()
        Me.cbxDUCPUUtilRatioHA = New eXperDB.BaseControls.CheckBox()
        Me.dtbCPUutilratioHA = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tlpCriticalItem4.SuspendLayout()
        CType(Me.nudDiskUsedRatioHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem3.SuspendLayout()
        CType(Me.nudSwapUsedRatioHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem6.SuspendLayout()
        CType(Me.nudCPUWaitRatioHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem5.SuspendLayout()
        CType(Me.nudConnectionsHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAlertConfigurationMain.SuspendLayout()
        Me.tlpCriticalItem9.SuspendLayout()
        CType(Me.nudMemoryUsedRatioHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpCriticalItem8.SuspendLayout()
        CType(Me.nudCPUUtilRatioHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpCriticalItem4
        '
        Me.tlpCriticalItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem4.ColumnCount = 4
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem4.Controls.Add(Me.cbxDiskUsedRatioHA, 1, 0)
        Me.tlpCriticalItem4.Controls.Add(Me.lblDuration4, 2, 2)
        Me.tlpCriticalItem4.Controls.Add(Me.nudDiskUsedRatioHA, 1, 2)
        Me.tlpCriticalItem4.Controls.Add(Me.cbxDUDiskUsedRatioHA, 2, 1)
        Me.tlpCriticalItem4.Controls.Add(Me.dtbDiskusedratioHA, 0, 1)
        Me.tlpCriticalItem4.Controls.Add(Me.Label13, 0, 0)
        Me.tlpCriticalItem4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem4.Location = New System.Drawing.Point(3, 363)
        Me.tlpCriticalItem4.Name = "tlpCriticalItem4"
        Me.tlpCriticalItem4.RowCount = 3
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCriticalItem4.Size = New System.Drawing.Size(394, 66)
        Me.tlpCriticalItem4.TabIndex = 49
        Me.tlpCriticalItem4.Visible = False
        '
        'cbxDiskUsedRatioHA
        '
        Me.cbxDiskUsedRatioHA.AutoSize = True
        Me.cbxDiskUsedRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem4.SetColumnSpan(Me.cbxDiskUsedRatioHA, 2)
        Me.cbxDiskUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDiskUsedRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxDiskUsedRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDiskUsedRatioHA.Location = New System.Drawing.Point(40, 0)
        Me.cbxDiskUsedRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDiskUsedRatioHA.Name = "cbxDiskUsedRatioHA"
        Me.cbxDiskUsedRatioHA.Radius = 10
        Me.cbxDiskUsedRatioHA.Size = New System.Drawing.Size(310, 18)
        Me.cbxDiskUsedRatioHA.TabIndex = 57
        Me.cbxDiskUsedRatioHA.Text = "Disk used ratio(%)"
        Me.cbxDiskUsedRatioHA.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxDiskUsedRatioHA.UseVisualStyleBackColor = True
        '
        'lblDuration4
        '
        Me.lblDuration4.AutoSize = True
        Me.lblDuration4.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration4.ForeColor = System.Drawing.Color.White
        Me.lblDuration4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration4.Location = New System.Drawing.Point(353, 36)
        Me.lblDuration4.Name = "lblDuration4"
        Me.lblDuration4.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration4.TabIndex = 56
        Me.lblDuration4.Text = "min"
        Me.lblDuration4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDiskUsedRatioHA
        '
        Me.nudDiskUsedRatioHA.BackColor = System.Drawing.Color.White
        Me.nudDiskUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDiskUsedRatioHA.Enabled = False
        Me.nudDiskUsedRatioHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudDiskUsedRatioHA.Location = New System.Drawing.Point(293, 39)
        Me.nudDiskUsedRatioHA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDiskUsedRatioHA.Name = "nudDiskUsedRatioHA"
        Me.nudDiskUsedRatioHA.Size = New System.Drawing.Size(54, 21)
        Me.nudDiskUsedRatioHA.TabIndex = 55
        Me.nudDiskUsedRatioHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUDiskUsedRatioHA
        '
        Me.cbxDUDiskUsedRatioHA.AutoSize = True
        Me.cbxDUDiskUsedRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem4.SetColumnSpan(Me.cbxDUDiskUsedRatioHA, 2)
        Me.cbxDUDiskUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUDiskUsedRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxDUDiskUsedRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDUDiskUsedRatioHA.Location = New System.Drawing.Point(290, 18)
        Me.cbxDUDiskUsedRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUDiskUsedRatioHA.Name = "cbxDUDiskUsedRatioHA"
        Me.cbxDUDiskUsedRatioHA.Radius = 10
        Me.cbxDUDiskUsedRatioHA.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUDiskUsedRatioHA.TabIndex = 54
        Me.cbxDUDiskUsedRatioHA.Text = "Alert Duration"
        Me.cbxDUDiskUsedRatioHA.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUDiskUsedRatioHA.UseVisualStyleBackColor = True
        '
        'dtbDiskusedratioHA
        '
        Me.dtbDiskusedratioHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbDiskusedratioHA.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratioHA.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbDiskusedratioHA.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbDiskusedratioHA.BarMaxValue = 70
        Me.dtbDiskusedratioHA.BarMinValue = 50
        Me.dtbDiskusedratioHA.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbDiskusedratioHA.CaptionSpacing = 10
        Me.tlpCriticalItem4.SetColumnSpan(Me.dtbDiskusedratioHA, 2)
        Me.dtbDiskusedratioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbDiskusedratioHA.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbDiskusedratioHA.ForeColor = System.Drawing.Color.White
        Me.dtbDiskusedratioHA.Location = New System.Drawing.Point(3, 21)
        Me.dtbDiskusedratioHA.LRPadding = 12
        Me.dtbDiskusedratioHA.Name = "dtbDiskusedratioHA"
        Me.tlpCriticalItem4.SetRowSpan(Me.dtbDiskusedratioHA, 2)
        Me.dtbDiskusedratioHA.Size = New System.Drawing.Size(284, 42)
        Me.dtbDiskusedratioHA.TabIndex = 53
        Me.dtbDiskusedratioHA.Text = "DoubleTrackBarDraw1"
        Me.dtbDiskusedratioHA.TickColor = System.Drawing.Color.Silver
        Me.dtbDiskusedratioHA.TickSpacing = 20
        Me.dtbDiskusedratioHA.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratioHA.TrackHeight = 2
        Me.dtbDiskusedratioHA.TrackToCaptionDistance = 14
        Me.dtbDiskusedratioHA.TrackToTickInterval = 4
        Me.dtbDiskusedratioHA.YPosition = 10
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
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "      "
        '
        'tlpCriticalItem3
        '
        Me.tlpCriticalItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem3.ColumnCount = 4
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem3.Controls.Add(Me.cbxSwapUsedRatioHA, 1, 0)
        Me.tlpCriticalItem3.Controls.Add(Me.Label23, 3, 2)
        Me.tlpCriticalItem3.Controls.Add(Me.nudSwapUsedRatioHA, 2, 2)
        Me.tlpCriticalItem3.Controls.Add(Me.cbxDUSwapUsedRatioHA, 2, 1)
        Me.tlpCriticalItem3.Controls.Add(Me.dtbSWAPusedratioHA, 0, 1)
        Me.tlpCriticalItem3.Controls.Add(Me.Label11, 0, 0)
        Me.tlpCriticalItem3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem3.Location = New System.Drawing.Point(3, 219)
        Me.tlpCriticalItem3.Name = "tlpCriticalItem3"
        Me.tlpCriticalItem3.RowCount = 3
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCriticalItem3.Size = New System.Drawing.Size(394, 66)
        Me.tlpCriticalItem3.TabIndex = 48
        '
        'cbxSwapUsedRatioHA
        '
        Me.cbxSwapUsedRatioHA.AutoSize = True
        Me.cbxSwapUsedRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem3.SetColumnSpan(Me.cbxSwapUsedRatioHA, 2)
        Me.cbxSwapUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxSwapUsedRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxSwapUsedRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxSwapUsedRatioHA.Location = New System.Drawing.Point(40, 0)
        Me.cbxSwapUsedRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxSwapUsedRatioHA.Name = "cbxSwapUsedRatioHA"
        Me.cbxSwapUsedRatioHA.Radius = 10
        Me.cbxSwapUsedRatioHA.Size = New System.Drawing.Size(310, 18)
        Me.cbxSwapUsedRatioHA.TabIndex = 49
        Me.cbxSwapUsedRatioHA.Text = "SWAP used ratio (%)"
        Me.cbxSwapUsedRatioHA.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxSwapUsedRatioHA.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(353, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 30)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "min"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSwapUsedRatioHA
        '
        Me.nudSwapUsedRatioHA.BackColor = System.Drawing.Color.White
        Me.nudSwapUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSwapUsedRatioHA.Enabled = False
        Me.nudSwapUsedRatioHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudSwapUsedRatioHA.Location = New System.Drawing.Point(293, 39)
        Me.nudSwapUsedRatioHA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudSwapUsedRatioHA.Name = "nudSwapUsedRatioHA"
        Me.nudSwapUsedRatioHA.Size = New System.Drawing.Size(54, 21)
        Me.nudSwapUsedRatioHA.TabIndex = 47
        Me.nudSwapUsedRatioHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUSwapUsedRatioHA
        '
        Me.cbxDUSwapUsedRatioHA.AutoSize = True
        Me.cbxDUSwapUsedRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem3.SetColumnSpan(Me.cbxDUSwapUsedRatioHA, 2)
        Me.cbxDUSwapUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUSwapUsedRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxDUSwapUsedRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDUSwapUsedRatioHA.Location = New System.Drawing.Point(290, 18)
        Me.cbxDUSwapUsedRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUSwapUsedRatioHA.Name = "cbxDUSwapUsedRatioHA"
        Me.cbxDUSwapUsedRatioHA.Radius = 10
        Me.cbxDUSwapUsedRatioHA.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUSwapUsedRatioHA.TabIndex = 45
        Me.cbxDUSwapUsedRatioHA.Text = "Alert Duration"
        Me.cbxDUSwapUsedRatioHA.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUSwapUsedRatioHA.UseVisualStyleBackColor = True
        '
        'dtbSWAPusedratioHA
        '
        Me.dtbSWAPusedratioHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbSWAPusedratioHA.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratioHA.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbSWAPusedratioHA.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbSWAPusedratioHA.BarMaxValue = 70
        Me.dtbSWAPusedratioHA.BarMinValue = 50
        Me.dtbSWAPusedratioHA.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbSWAPusedratioHA.CaptionSpacing = 10
        Me.tlpCriticalItem3.SetColumnSpan(Me.dtbSWAPusedratioHA, 2)
        Me.dtbSWAPusedratioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbSWAPusedratioHA.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbSWAPusedratioHA.ForeColor = System.Drawing.Color.White
        Me.dtbSWAPusedratioHA.Location = New System.Drawing.Point(3, 21)
        Me.dtbSWAPusedratioHA.LRPadding = 12
        Me.dtbSWAPusedratioHA.Name = "dtbSWAPusedratioHA"
        Me.tlpCriticalItem3.SetRowSpan(Me.dtbSWAPusedratioHA, 2)
        Me.dtbSWAPusedratioHA.Size = New System.Drawing.Size(284, 42)
        Me.dtbSWAPusedratioHA.TabIndex = 44
        Me.dtbSWAPusedratioHA.Text = "DoubleTrackBarDraw1"
        Me.dtbSWAPusedratioHA.TickColor = System.Drawing.Color.Silver
        Me.dtbSWAPusedratioHA.TickSpacing = 20
        Me.dtbSWAPusedratioHA.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratioHA.TrackHeight = 2
        Me.dtbSWAPusedratioHA.TrackToCaptionDistance = 14
        Me.dtbSWAPusedratioHA.TrackToTickInterval = 4
        Me.dtbSWAPusedratioHA.YPosition = 10
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
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "      "
        '
        'tlpCriticalItem6
        '
        Me.tlpCriticalItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem6.ColumnCount = 4
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem6.Controls.Add(Me.cbxCPUWaitRatioHA, 1, 0)
        Me.tlpCriticalItem6.Controls.Add(Me.lblDuration6, 2, 2)
        Me.tlpCriticalItem6.Controls.Add(Me.nudCPUWaitRatioHA, 1, 2)
        Me.tlpCriticalItem6.Controls.Add(Me.cbxDUCPUWaitRatioHA, 2, 1)
        Me.tlpCriticalItem6.Controls.Add(Me.dtbCPUwaitratioHA, 0, 1)
        Me.tlpCriticalItem6.Controls.Add(Me.Label9, 0, 0)
        Me.tlpCriticalItem6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem6.Location = New System.Drawing.Point(3, 75)
        Me.tlpCriticalItem6.Name = "tlpCriticalItem6"
        Me.tlpCriticalItem6.RowCount = 3
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCriticalItem6.Size = New System.Drawing.Size(394, 66)
        Me.tlpCriticalItem6.TabIndex = 47
        '
        'cbxCPUWaitRatioHA
        '
        Me.cbxCPUWaitRatioHA.AutoSize = True
        Me.cbxCPUWaitRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem6.SetColumnSpan(Me.cbxCPUWaitRatioHA, 2)
        Me.cbxCPUWaitRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCPUWaitRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxCPUWaitRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxCPUWaitRatioHA.Location = New System.Drawing.Point(40, 0)
        Me.cbxCPUWaitRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxCPUWaitRatioHA.Name = "cbxCPUWaitRatioHA"
        Me.cbxCPUWaitRatioHA.Radius = 10
        Me.cbxCPUWaitRatioHA.Size = New System.Drawing.Size(310, 18)
        Me.cbxCPUWaitRatioHA.TabIndex = 44
        Me.cbxCPUWaitRatioHA.Text = "CPU wait ratio (%)"
        Me.cbxCPUWaitRatioHA.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxCPUWaitRatioHA.UseVisualStyleBackColor = True
        '
        'lblDuration6
        '
        Me.lblDuration6.AutoSize = True
        Me.lblDuration6.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration6.ForeColor = System.Drawing.Color.White
        Me.lblDuration6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration6.Location = New System.Drawing.Point(353, 36)
        Me.lblDuration6.Name = "lblDuration6"
        Me.lblDuration6.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration6.TabIndex = 43
        Me.lblDuration6.Text = "min"
        Me.lblDuration6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCPUWaitRatioHA
        '
        Me.nudCPUWaitRatioHA.BackColor = System.Drawing.Color.White
        Me.nudCPUWaitRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCPUWaitRatioHA.Enabled = False
        Me.nudCPUWaitRatioHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudCPUWaitRatioHA.Location = New System.Drawing.Point(293, 39)
        Me.nudCPUWaitRatioHA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCPUWaitRatioHA.Name = "nudCPUWaitRatioHA"
        Me.nudCPUWaitRatioHA.Size = New System.Drawing.Size(54, 21)
        Me.nudCPUWaitRatioHA.TabIndex = 42
        Me.nudCPUWaitRatioHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUCPUWaitRatioHA
        '
        Me.cbxDUCPUWaitRatioHA.AutoSize = True
        Me.cbxDUCPUWaitRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem6.SetColumnSpan(Me.cbxDUCPUWaitRatioHA, 2)
        Me.cbxDUCPUWaitRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUCPUWaitRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxDUCPUWaitRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDUCPUWaitRatioHA.Location = New System.Drawing.Point(290, 18)
        Me.cbxDUCPUWaitRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUCPUWaitRatioHA.Name = "cbxDUCPUWaitRatioHA"
        Me.cbxDUCPUWaitRatioHA.Radius = 10
        Me.cbxDUCPUWaitRatioHA.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUCPUWaitRatioHA.TabIndex = 41
        Me.cbxDUCPUWaitRatioHA.Text = "Alert Duration"
        Me.cbxDUCPUWaitRatioHA.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUCPUWaitRatioHA.UseVisualStyleBackColor = True
        '
        'dtbCPUwaitratioHA
        '
        Me.dtbCPUwaitratioHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbCPUwaitratioHA.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratioHA.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCPUwaitratioHA.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCPUwaitratioHA.BarMaxValue = 70
        Me.dtbCPUwaitratioHA.BarMinValue = 50
        Me.dtbCPUwaitratioHA.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCPUwaitratioHA.CaptionSpacing = 10
        Me.tlpCriticalItem6.SetColumnSpan(Me.dtbCPUwaitratioHA, 2)
        Me.dtbCPUwaitratioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCPUwaitratioHA.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbCPUwaitratioHA.ForeColor = System.Drawing.Color.White
        Me.dtbCPUwaitratioHA.Location = New System.Drawing.Point(3, 21)
        Me.dtbCPUwaitratioHA.LRPadding = 12
        Me.dtbCPUwaitratioHA.Name = "dtbCPUwaitratioHA"
        Me.tlpCriticalItem6.SetRowSpan(Me.dtbCPUwaitratioHA, 2)
        Me.dtbCPUwaitratioHA.Size = New System.Drawing.Size(284, 42)
        Me.dtbCPUwaitratioHA.TabIndex = 40
        Me.dtbCPUwaitratioHA.Text = "DoubleTrackBarDraw1"
        Me.dtbCPUwaitratioHA.TickColor = System.Drawing.Color.Silver
        Me.dtbCPUwaitratioHA.TickSpacing = 20
        Me.dtbCPUwaitratioHA.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratioHA.TrackHeight = 2
        Me.dtbCPUwaitratioHA.TrackToCaptionDistance = 14
        Me.dtbCPUwaitratioHA.TrackToTickInterval = 4
        Me.dtbCPUwaitratioHA.YPosition = 10
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
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "      "
        '
        'tlpCriticalItem5
        '
        Me.tlpCriticalItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem5.ColumnCount = 4
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem5.Controls.Add(Me.cbxConnectionsHA, 1, 0)
        Me.tlpCriticalItem5.Controls.Add(Me.lblDuration5, 2, 2)
        Me.tlpCriticalItem5.Controls.Add(Me.nudConnectionsHA, 1, 2)
        Me.tlpCriticalItem5.Controls.Add(Me.cbxDUConnectionsHA, 2, 1)
        Me.tlpCriticalItem5.Controls.Add(Me.Label7, 0, 0)
        Me.tlpCriticalItem5.Controls.Add(Me.dtbConnectionsHA, 0, 1)
        Me.tlpCriticalItem5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem5.Location = New System.Drawing.Point(3, 291)
        Me.tlpCriticalItem5.Name = "tlpCriticalItem5"
        Me.tlpCriticalItem5.RowCount = 3
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCriticalItem5.Size = New System.Drawing.Size(394, 66)
        Me.tlpCriticalItem5.TabIndex = 46
        '
        'cbxConnectionsHA
        '
        Me.cbxConnectionsHA.AutoSize = True
        Me.cbxConnectionsHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem5.SetColumnSpan(Me.cbxConnectionsHA, 2)
        Me.cbxConnectionsHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxConnectionsHA.ForeColor = System.Drawing.Color.White
        Me.cbxConnectionsHA.LineColor = System.Drawing.Color.Gray
        Me.cbxConnectionsHA.Location = New System.Drawing.Point(40, 0)
        Me.cbxConnectionsHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxConnectionsHA.Name = "cbxConnectionsHA"
        Me.cbxConnectionsHA.Radius = 10
        Me.cbxConnectionsHA.Size = New System.Drawing.Size(310, 18)
        Me.cbxConnectionsHA.TabIndex = 43
        Me.cbxConnectionsHA.Text = "Connections (Count)"
        Me.cbxConnectionsHA.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxConnectionsHA.UseVisualStyleBackColor = True
        '
        'lblDuration5
        '
        Me.lblDuration5.AutoSize = True
        Me.lblDuration5.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration5.ForeColor = System.Drawing.Color.White
        Me.lblDuration5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration5.Location = New System.Drawing.Point(353, 36)
        Me.lblDuration5.Name = "lblDuration5"
        Me.lblDuration5.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration5.TabIndex = 42
        Me.lblDuration5.Text = "min"
        Me.lblDuration5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudConnectionsHA
        '
        Me.nudConnectionsHA.BackColor = System.Drawing.Color.White
        Me.nudConnectionsHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudConnectionsHA.Enabled = False
        Me.nudConnectionsHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudConnectionsHA.Location = New System.Drawing.Point(293, 39)
        Me.nudConnectionsHA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudConnectionsHA.Name = "nudConnectionsHA"
        Me.nudConnectionsHA.Size = New System.Drawing.Size(54, 21)
        Me.nudConnectionsHA.TabIndex = 41
        Me.nudConnectionsHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUConnectionsHA
        '
        Me.cbxDUConnectionsHA.AutoSize = True
        Me.cbxDUConnectionsHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem5.SetColumnSpan(Me.cbxDUConnectionsHA, 2)
        Me.cbxDUConnectionsHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUConnectionsHA.ForeColor = System.Drawing.Color.White
        Me.cbxDUConnectionsHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDUConnectionsHA.Location = New System.Drawing.Point(290, 18)
        Me.cbxDUConnectionsHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUConnectionsHA.Name = "cbxDUConnectionsHA"
        Me.cbxDUConnectionsHA.Radius = 10
        Me.cbxDUConnectionsHA.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUConnectionsHA.TabIndex = 40
        Me.cbxDUConnectionsHA.Text = "Alert Duration"
        Me.cbxDUConnectionsHA.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUConnectionsHA.UseVisualStyleBackColor = True
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
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "      "
        '
        'dtbConnectionsHA
        '
        Me.dtbConnectionsHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbConnectionsHA.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnectionsHA.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbConnectionsHA.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbConnectionsHA.BarMaxValue = 70
        Me.dtbConnectionsHA.BarMinValue = 50
        Me.dtbConnectionsHA.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbConnectionsHA.CaptionSpacing = 10
        Me.tlpCriticalItem5.SetColumnSpan(Me.dtbConnectionsHA, 2)
        Me.dtbConnectionsHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbConnectionsHA.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbConnectionsHA.ForeColor = System.Drawing.Color.White
        Me.dtbConnectionsHA.Location = New System.Drawing.Point(3, 21)
        Me.dtbConnectionsHA.LRPadding = 12
        Me.dtbConnectionsHA.Name = "dtbConnectionsHA"
        Me.tlpCriticalItem5.SetRowSpan(Me.dtbConnectionsHA, 2)
        Me.dtbConnectionsHA.Size = New System.Drawing.Size(284, 42)
        Me.dtbConnectionsHA.TabIndex = 39
        Me.dtbConnectionsHA.Text = "DoubleTrackBarDraw1"
        Me.dtbConnectionsHA.TickColor = System.Drawing.Color.Silver
        Me.dtbConnectionsHA.TickSpacing = 20
        Me.dtbConnectionsHA.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnectionsHA.TrackHeight = 2
        Me.dtbConnectionsHA.TrackToCaptionDistance = 14
        Me.dtbConnectionsHA.TrackToTickInterval = 4
        Me.dtbConnectionsHA.YPosition = 10
        '
        'tlpAlertConfigurationMain
        '
        Me.tlpAlertConfigurationMain.BackColor = System.Drawing.Color.Transparent
        Me.tlpAlertConfigurationMain.ColumnCount = 2
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458.0!))
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem9, 0, 2)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem8, 0, 0)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem6, 0, 1)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem4, 0, 5)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem5, 0, 4)
        Me.tlpAlertConfigurationMain.Controls.Add(Me.tlpCriticalItem3, 0, 3)
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
        Me.tlpAlertConfigurationMain.TabIndex = 3
        '
        'tlpCriticalItem9
        '
        Me.tlpCriticalItem9.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem9.ColumnCount = 4
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem9.Controls.Add(Me.cbxMemoryUsedRatioHA, 1, 0)
        Me.tlpCriticalItem9.Controls.Add(Me.Label27, 3, 2)
        Me.tlpCriticalItem9.Controls.Add(Me.nudMemoryUsedRatioHA, 2, 2)
        Me.tlpCriticalItem9.Controls.Add(Me.cbxDUMemoryUsedRatioHA, 2, 1)
        Me.tlpCriticalItem9.Controls.Add(Me.dtbMEMusedratioHA, 0, 1)
        Me.tlpCriticalItem9.Controls.Add(Me.Label29, 0, 0)
        Me.tlpCriticalItem9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem9.Location = New System.Drawing.Point(3, 147)
        Me.tlpCriticalItem9.Name = "tlpCriticalItem9"
        Me.tlpCriticalItem9.RowCount = 3
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCriticalItem9.Size = New System.Drawing.Size(394, 66)
        Me.tlpCriticalItem9.TabIndex = 52
        '
        'cbxMemoryUsedRatioHA
        '
        Me.cbxMemoryUsedRatioHA.AutoSize = True
        Me.cbxMemoryUsedRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem9.SetColumnSpan(Me.cbxMemoryUsedRatioHA, 2)
        Me.cbxMemoryUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxMemoryUsedRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxMemoryUsedRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxMemoryUsedRatioHA.Location = New System.Drawing.Point(40, 0)
        Me.cbxMemoryUsedRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxMemoryUsedRatioHA.Name = "cbxMemoryUsedRatioHA"
        Me.cbxMemoryUsedRatioHA.Radius = 10
        Me.cbxMemoryUsedRatioHA.Size = New System.Drawing.Size(310, 18)
        Me.cbxMemoryUsedRatioHA.TabIndex = 49
        Me.cbxMemoryUsedRatioHA.Text = "Memory used ratio (%)"
        Me.cbxMemoryUsedRatioHA.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxMemoryUsedRatioHA.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label27.Location = New System.Drawing.Point(353, 36)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 30)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "min"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudMemoryUsedRatioHA
        '
        Me.nudMemoryUsedRatioHA.BackColor = System.Drawing.Color.White
        Me.nudMemoryUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudMemoryUsedRatioHA.Enabled = False
        Me.nudMemoryUsedRatioHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudMemoryUsedRatioHA.Location = New System.Drawing.Point(293, 39)
        Me.nudMemoryUsedRatioHA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMemoryUsedRatioHA.Name = "nudMemoryUsedRatioHA"
        Me.nudMemoryUsedRatioHA.Size = New System.Drawing.Size(54, 21)
        Me.nudMemoryUsedRatioHA.TabIndex = 47
        Me.nudMemoryUsedRatioHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUMemoryUsedRatioHA
        '
        Me.cbxDUMemoryUsedRatioHA.AutoSize = True
        Me.cbxDUMemoryUsedRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem9.SetColumnSpan(Me.cbxDUMemoryUsedRatioHA, 2)
        Me.cbxDUMemoryUsedRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUMemoryUsedRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxDUMemoryUsedRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDUMemoryUsedRatioHA.Location = New System.Drawing.Point(290, 18)
        Me.cbxDUMemoryUsedRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUMemoryUsedRatioHA.Name = "cbxDUMemoryUsedRatioHA"
        Me.cbxDUMemoryUsedRatioHA.Radius = 10
        Me.cbxDUMemoryUsedRatioHA.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUMemoryUsedRatioHA.TabIndex = 45
        Me.cbxDUMemoryUsedRatioHA.Text = "Alert Duration"
        Me.cbxDUMemoryUsedRatioHA.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUMemoryUsedRatioHA.UseVisualStyleBackColor = True
        '
        'dtbMEMusedratioHA
        '
        Me.dtbMEMusedratioHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbMEMusedratioHA.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbMEMusedratioHA.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbMEMusedratioHA.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbMEMusedratioHA.BarMaxValue = 70
        Me.dtbMEMusedratioHA.BarMinValue = 50
        Me.dtbMEMusedratioHA.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbMEMusedratioHA.CaptionSpacing = 10
        Me.tlpCriticalItem9.SetColumnSpan(Me.dtbMEMusedratioHA, 2)
        Me.dtbMEMusedratioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbMEMusedratioHA.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbMEMusedratioHA.ForeColor = System.Drawing.Color.White
        Me.dtbMEMusedratioHA.Location = New System.Drawing.Point(3, 21)
        Me.dtbMEMusedratioHA.LRPadding = 12
        Me.dtbMEMusedratioHA.Name = "dtbMEMusedratioHA"
        Me.tlpCriticalItem9.SetRowSpan(Me.dtbMEMusedratioHA, 2)
        Me.dtbMEMusedratioHA.Size = New System.Drawing.Size(284, 42)
        Me.dtbMEMusedratioHA.TabIndex = 44
        Me.dtbMEMusedratioHA.Text = "DoubleTrackBarDraw1"
        Me.dtbMEMusedratioHA.TickColor = System.Drawing.Color.Silver
        Me.dtbMEMusedratioHA.TickSpacing = 20
        Me.dtbMEMusedratioHA.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbMEMusedratioHA.TrackHeight = 2
        Me.dtbMEMusedratioHA.TrackToCaptionDistance = 14
        Me.dtbMEMusedratioHA.TrackToTickInterval = 4
        Me.dtbMEMusedratioHA.YPosition = 10
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
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "      "
        '
        'tlpCriticalItem8
        '
        Me.tlpCriticalItem8.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpCriticalItem8.ColumnCount = 4
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpCriticalItem8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCriticalItem8.Controls.Add(Me.cbxCPUUtilRatioHA, 1, 0)
        Me.tlpCriticalItem8.Controls.Add(Me.lblDuration8, 2, 2)
        Me.tlpCriticalItem8.Controls.Add(Me.nudCPUUtilRatioHA, 1, 2)
        Me.tlpCriticalItem8.Controls.Add(Me.cbxDUCPUUtilRatioHA, 2, 1)
        Me.tlpCriticalItem8.Controls.Add(Me.dtbCPUutilratioHA, 0, 1)
        Me.tlpCriticalItem8.Controls.Add(Me.Label26, 0, 0)
        Me.tlpCriticalItem8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCriticalItem8.Location = New System.Drawing.Point(3, 3)
        Me.tlpCriticalItem8.Name = "tlpCriticalItem8"
        Me.tlpCriticalItem8.RowCount = 3
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCriticalItem8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCriticalItem8.Size = New System.Drawing.Size(394, 66)
        Me.tlpCriticalItem8.TabIndex = 51
        '
        'cbxCPUUtilRatioHA
        '
        Me.cbxCPUUtilRatioHA.AutoSize = True
        Me.cbxCPUUtilRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem8.SetColumnSpan(Me.cbxCPUUtilRatioHA, 2)
        Me.cbxCPUUtilRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCPUUtilRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxCPUUtilRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxCPUUtilRatioHA.Location = New System.Drawing.Point(40, 0)
        Me.cbxCPUUtilRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxCPUUtilRatioHA.Name = "cbxCPUUtilRatioHA"
        Me.cbxCPUUtilRatioHA.Radius = 10
        Me.cbxCPUUtilRatioHA.Size = New System.Drawing.Size(310, 18)
        Me.cbxCPUUtilRatioHA.TabIndex = 44
        Me.cbxCPUUtilRatioHA.Text = "CPU Util ratio (%)"
        Me.cbxCPUUtilRatioHA.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxCPUUtilRatioHA.UseVisualStyleBackColor = True
        '
        'lblDuration8
        '
        Me.lblDuration8.AutoSize = True
        Me.lblDuration8.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration8.ForeColor = System.Drawing.Color.White
        Me.lblDuration8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration8.Location = New System.Drawing.Point(353, 36)
        Me.lblDuration8.Name = "lblDuration8"
        Me.lblDuration8.Size = New System.Drawing.Size(48, 30)
        Me.lblDuration8.TabIndex = 43
        Me.lblDuration8.Text = "min"
        Me.lblDuration8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCPUUtilRatioHA
        '
        Me.nudCPUUtilRatioHA.BackColor = System.Drawing.Color.White
        Me.nudCPUUtilRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCPUUtilRatioHA.Enabled = False
        Me.nudCPUUtilRatioHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudCPUUtilRatioHA.Location = New System.Drawing.Point(293, 39)
        Me.nudCPUUtilRatioHA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCPUUtilRatioHA.Name = "nudCPUUtilRatioHA"
        Me.nudCPUUtilRatioHA.Size = New System.Drawing.Size(54, 21)
        Me.nudCPUUtilRatioHA.TabIndex = 42
        Me.nudCPUUtilRatioHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxDUCPUUtilRatioHA
        '
        Me.cbxDUCPUUtilRatioHA.AutoSize = True
        Me.cbxDUCPUUtilRatioHA.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpCriticalItem8.SetColumnSpan(Me.cbxDUCPUUtilRatioHA, 2)
        Me.cbxDUCPUUtilRatioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDUCPUUtilRatioHA.ForeColor = System.Drawing.Color.White
        Me.cbxDUCPUUtilRatioHA.LineColor = System.Drawing.Color.Gray
        Me.cbxDUCPUUtilRatioHA.Location = New System.Drawing.Point(290, 18)
        Me.cbxDUCPUUtilRatioHA.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDUCPUUtilRatioHA.Name = "cbxDUCPUUtilRatioHA"
        Me.cbxDUCPUUtilRatioHA.Radius = 10
        Me.cbxDUCPUUtilRatioHA.Size = New System.Drawing.Size(114, 18)
        Me.cbxDUCPUUtilRatioHA.TabIndex = 41
        Me.cbxDUCPUUtilRatioHA.Text = "Alert Duration"
        Me.cbxDUCPUUtilRatioHA.UnCheckFillColor = System.Drawing.Color.DarkGray
        Me.cbxDUCPUUtilRatioHA.UseVisualStyleBackColor = True
        '
        'dtbCPUutilratioHA
        '
        Me.dtbCPUutilratioHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.dtbCPUutilratioHA.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUutilratioHA.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCPUutilratioHA.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCPUutilratioHA.BarMaxValue = 70
        Me.dtbCPUutilratioHA.BarMinValue = 50
        Me.dtbCPUutilratioHA.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCPUutilratioHA.CaptionSpacing = 10
        Me.tlpCriticalItem8.SetColumnSpan(Me.dtbCPUutilratioHA, 2)
        Me.dtbCPUutilratioHA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCPUutilratioHA.Font = New System.Drawing.Font("Gulim", 8.0!)
        Me.dtbCPUutilratioHA.ForeColor = System.Drawing.Color.White
        Me.dtbCPUutilratioHA.Location = New System.Drawing.Point(3, 21)
        Me.dtbCPUutilratioHA.LRPadding = 12
        Me.dtbCPUutilratioHA.Name = "dtbCPUutilratioHA"
        Me.tlpCriticalItem8.SetRowSpan(Me.dtbCPUutilratioHA, 2)
        Me.dtbCPUutilratioHA.Size = New System.Drawing.Size(284, 42)
        Me.dtbCPUutilratioHA.TabIndex = 40
        Me.dtbCPUutilratioHA.Text = "DoubleTrackBarDraw1"
        Me.dtbCPUutilratioHA.TickColor = System.Drawing.Color.Silver
        Me.dtbCPUutilratioHA.TickSpacing = 20
        Me.dtbCPUutilratioHA.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUutilratioHA.TrackHeight = 2
        Me.dtbCPUutilratioHA.TrackToCaptionDistance = 14
        Me.dtbCPUutilratioHA.TrackToTickInterval = 4
        Me.dtbCPUutilratioHA.YPosition = 10
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
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "      "
        '
        'AlertConfigurationHAGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.tlpAlertConfigurationMain)
        Me.DoubleBuffered = True
        Me.Name = "AlertConfigurationHAGroupForm"
        Me.Size = New System.Drawing.Size(868, 650)
        Me.tlpCriticalItem4.ResumeLayout(False)
        Me.tlpCriticalItem4.PerformLayout()
        CType(Me.nudDiskUsedRatioHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem3.ResumeLayout(False)
        Me.tlpCriticalItem3.PerformLayout()
        CType(Me.nudSwapUsedRatioHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem6.ResumeLayout(False)
        Me.tlpCriticalItem6.PerformLayout()
        CType(Me.nudCPUWaitRatioHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem5.ResumeLayout(False)
        Me.tlpCriticalItem5.PerformLayout()
        CType(Me.nudConnectionsHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpAlertConfigurationMain.ResumeLayout(False)
        Me.tlpCriticalItem9.ResumeLayout(False)
        Me.tlpCriticalItem9.PerformLayout()
        CType(Me.nudMemoryUsedRatioHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpCriticalItem8.ResumeLayout(False)
        Me.tlpCriticalItem8.PerformLayout()
        CType(Me.nudCPUUtilRatioHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpCriticalItem6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtbCPUwaitratioHA As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbConnectionsHA As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents tlpCriticalItem4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tlpAlertConfigurationMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtbDiskusedratioHA As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbSWAPusedratioHA As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents nudDiskUsedRatioHA As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUDiskUsedRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxDUSwapUsedRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudCPUWaitRatioHA As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUCPUWaitRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents nudConnectionsHA As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUConnectionsHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblDuration4 As System.Windows.Forms.Label
    Friend WithEvents lblDuration6 As System.Windows.Forms.Label
    Friend WithEvents lblDuration5 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents nudSwapUsedRatioHA As System.Windows.Forms.NumericUpDown
    Friend WithEvents tlpCriticalItem9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents nudMemoryUsedRatioHA As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUMemoryUsedRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbMEMusedratioHA As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tlpCriticalItem8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDuration8 As System.Windows.Forms.Label
    Friend WithEvents nudCPUUtilRatioHA As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxDUCPUUtilRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbCPUutilratioHA As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbxDiskUsedRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxConnectionsHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxSwapUsedRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxCPUWaitRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxMemoryUsedRatioHA As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxCPUUtilRatioHA As eXperDB.BaseControls.CheckBox

End Class
