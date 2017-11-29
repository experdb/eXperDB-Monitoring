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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges4 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges5 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges6 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges7 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.grpTransactionalert = New eXperDB.BaseControls.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxConfailedcnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxLastvacuumDay = New eXperDB.BaseControls.CheckBox()
        Me.cbxLongrunsqlsec = New eXperDB.BaseControls.CheckBox()
        Me.cbxLockedtranccnt = New eXperDB.BaseControls.CheckBox()
        Me.nudConfailedcnt = New System.Windows.Forms.NumericUpDown()
        Me.nudLastvacuumDay = New System.Windows.Forms.NumericUpDown()
        Me.nudLongrunsqlsec = New System.Windows.Forms.NumericUpDown()
        Me.nudLockedtranccnt = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New eXperDB.BaseControls.Button()
        Me.cbxLastAnalyzeday = New eXperDB.BaseControls.CheckBox()
        Me.cbxUnusedindexcnt = New eXperDB.BaseControls.CheckBox()
        Me.cbxIdletranscnt = New eXperDB.BaseControls.CheckBox()
        Me.nudLastAnalyzeday = New System.Windows.Forms.NumericUpDown()
        Me.nudUnusedindexcnt = New System.Windows.Forms.NumericUpDown()
        Me.nudIdletranscnt = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpSWAPusedratio = New eXperDB.BaseControls.GroupBox()
        Me.dtbSWAPusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.grpDiskusedratio = New eXperDB.BaseControls.GroupBox()
        Me.dtbDiskusedratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.grpCommitratio = New eXperDB.BaseControls.GroupBox()
        Me.dtbCommitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.grpBufferhitratio = New eXperDB.BaseControls.GroupBox()
        Me.dtbBufferhitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.grpConnections = New eXperDB.BaseControls.GroupBox()
        Me.dtbConnections = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.grpCPUwaitratio = New eXperDB.BaseControls.GroupBox()
        Me.dtbCPUwaitratio = New eXperDB.Controls.DoubleTrackBarDraw()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.lblAlertconfig = New eXperDB.BaseControls.Label()
        Me.Panel2.SuspendLayout()
        Me.grpTransactionalert.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.nudConfailedcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastvacuumDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLongrunsqlsec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLockedtranccnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastAnalyzeday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnusedindexcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIdletranscnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpSWAPusedratio.SuspendLayout()
        Me.grpDiskusedratio.SuspendLayout()
        Me.grpCommitratio.SuspendLayout()
        Me.grpBufferhitratio.SuspendLayout()
        Me.grpConnections.SuspendLayout()
        Me.grpCPUwaitratio.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.grpTransactionalert)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 216)
        Me.Panel2.TabIndex = 2
        '
        'grpTransactionalert
        '
        Me.grpTransactionalert.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpTransactionalert.AlignString = System.Drawing.StringAlignment.Near
        Me.grpTransactionalert.BackColor = System.Drawing.Color.Black
        Me.grpTransactionalert.Controls.Add(Me.TableLayoutPanel2)
        Me.grpTransactionalert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTransactionalert.EdgeRound = Edges1
        Me.grpTransactionalert.FillColor = System.Drawing.Color.Black
        Me.grpTransactionalert.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpTransactionalert.ForeColor = System.Drawing.Color.White
        Me.grpTransactionalert.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpTransactionalert.LineWidth = 1
        Me.grpTransactionalert.Location = New System.Drawing.Point(0, 0)
        Me.grpTransactionalert.Name = "grpTransactionalert"
        Me.grpTransactionalert.Padding = New System.Windows.Forms.Padding(5, 9, 5, 5)
        Me.grpTransactionalert.Size = New System.Drawing.Size(736, 216)
        Me.grpTransactionalert.TabIndex = 1
        Me.grpTransactionalert.TabStop = False
        Me.grpTransactionalert.Text = "Transaction alert."
        Me.grpTransactionalert.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpTransactionalert.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpTransactionalert.UseGraColor = True
        Me.grpTransactionalert.UseRound = True
        Me.grpTransactionalert.UseTitle = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbxConfailedcnt, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxLastvacuumDay, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxLongrunsqlsec, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxLockedtranccnt, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.nudConfailedcnt, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.nudLastvacuumDay, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.nudLongrunsqlsec, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.nudLockedtranccnt, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxLastAnalyzeday, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxUnusedindexcnt, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxIdletranscnt, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.nudLastAnalyzeday, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.nudUnusedindexcnt, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.nudIdletranscnt, 3, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(726, 188)
        Me.TableLayoutPanel2.TabIndex = 23
        '
        'cbxConfailedcnt
        '
        Me.cbxConfailedcnt.AutoSize = True
        Me.cbxConfailedcnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxConfailedcnt.LineColor = System.Drawing.Color.Gray
        Me.cbxConfailedcnt.Location = New System.Drawing.Point(3, 132)
        Me.cbxConfailedcnt.Name = "cbxConfailedcnt"
        Me.cbxConfailedcnt.Radius = 10
        Me.cbxConfailedcnt.Size = New System.Drawing.Size(164, 16)
        Me.cbxConfailedcnt.TabIndex = 19
        Me.cbxConfailedcnt.Text = "Connection failed cnt"
        Me.cbxConfailedcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxConfailedcnt.UseVisualStyleBackColor = True
        '
        'cbxLastvacuumDay
        '
        Me.cbxLastvacuumDay.AutoSize = True
        Me.cbxLastvacuumDay.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLastvacuumDay.LineColor = System.Drawing.Color.Gray
        Me.cbxLastvacuumDay.Location = New System.Drawing.Point(3, 95)
        Me.cbxLastvacuumDay.Name = "cbxLastvacuumDay"
        Me.cbxLastvacuumDay.Radius = 10
        Me.cbxLastvacuumDay.Size = New System.Drawing.Size(133, 16)
        Me.cbxLastvacuumDay.TabIndex = 18
        Me.cbxLastvacuumDay.Text = "last vacuum day"
        Me.cbxLastvacuumDay.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLastvacuumDay.UseVisualStyleBackColor = True
        '
        'cbxLongrunsqlsec
        '
        Me.cbxLongrunsqlsec.AutoSize = True
        Me.cbxLongrunsqlsec.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLongrunsqlsec.LineColor = System.Drawing.Color.Gray
        Me.cbxLongrunsqlsec.Location = New System.Drawing.Point(3, 58)
        Me.cbxLongrunsqlsec.Name = "cbxLongrunsqlsec"
        Me.cbxLongrunsqlsec.Radius = 10
        Me.cbxLongrunsqlsec.Size = New System.Drawing.Size(164, 16)
        Me.cbxLongrunsqlsec.TabIndex = 17
        Me.cbxLongrunsqlsec.Text = "Long running sql sec"
        Me.cbxLongrunsqlsec.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLongrunsqlsec.UseVisualStyleBackColor = True
        '
        'cbxLockedtranccnt
        '
        Me.cbxLockedtranccnt.AutoSize = True
        Me.cbxLockedtranccnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLockedtranccnt.LineColor = System.Drawing.Color.Gray
        Me.cbxLockedtranccnt.Location = New System.Drawing.Point(3, 21)
        Me.cbxLockedtranccnt.Name = "cbxLockedtranccnt"
        Me.cbxLockedtranccnt.Radius = 10
        Me.cbxLockedtranccnt.Size = New System.Drawing.Size(174, 16)
        Me.cbxLockedtranccnt.TabIndex = 16
        Me.cbxLockedtranccnt.Text = "Locked transaction cnt"
        Me.cbxLockedtranccnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLockedtranccnt.UseVisualStyleBackColor = True
        '
        'nudConfailedcnt
        '
        Me.nudConfailedcnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudConfailedcnt.ForeColor = System.Drawing.Color.White
        Me.nudConfailedcnt.Location = New System.Drawing.Point(220, 132)
        Me.nudConfailedcnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudConfailedcnt.Name = "nudConfailedcnt"
        Me.nudConfailedcnt.Size = New System.Drawing.Size(92, 21)
        Me.nudConfailedcnt.TabIndex = 15
        Me.nudConfailedcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLastvacuumDay
        '
        Me.nudLastvacuumDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudLastvacuumDay.ForeColor = System.Drawing.Color.White
        Me.nudLastvacuumDay.Location = New System.Drawing.Point(220, 95)
        Me.nudLastvacuumDay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLastvacuumDay.Name = "nudLastvacuumDay"
        Me.nudLastvacuumDay.Size = New System.Drawing.Size(92, 21)
        Me.nudLastvacuumDay.TabIndex = 11
        Me.nudLastvacuumDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLongrunsqlsec
        '
        Me.nudLongrunsqlsec.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudLongrunsqlsec.ForeColor = System.Drawing.Color.White
        Me.nudLongrunsqlsec.Location = New System.Drawing.Point(220, 58)
        Me.nudLongrunsqlsec.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLongrunsqlsec.Name = "nudLongrunsqlsec"
        Me.nudLongrunsqlsec.Size = New System.Drawing.Size(92, 21)
        Me.nudLongrunsqlsec.TabIndex = 9
        Me.nudLongrunsqlsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLockedtranccnt
        '
        Me.nudLockedtranccnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudLockedtranccnt.ForeColor = System.Drawing.Color.White
        Me.nudLockedtranccnt.Location = New System.Drawing.Point(220, 21)
        Me.nudLockedtranccnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLockedtranccnt.Name = "nudLockedtranccnt"
        Me.nudLockedtranccnt.Size = New System.Drawing.Size(92, 21)
        Me.nudLockedtranccnt.TabIndex = 7
        Me.nudLockedtranccnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FixedHeight = False
        Me.Button1.FixedWidth = False
        Me.Button1.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.LineColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(365, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Radius = 10
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.UseRound = True
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'cbxLastAnalyzeday
        '
        Me.cbxLastAnalyzeday.AutoSize = True
        Me.cbxLastAnalyzeday.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxLastAnalyzeday.LineColor = System.Drawing.Color.Gray
        Me.cbxLastAnalyzeday.Location = New System.Drawing.Point(365, 95)
        Me.cbxLastAnalyzeday.Name = "cbxLastAnalyzeday"
        Me.cbxLastAnalyzeday.Radius = 10
        Me.cbxLastAnalyzeday.Size = New System.Drawing.Size(134, 16)
        Me.cbxLastAnalyzeday.TabIndex = 22
        Me.cbxLastAnalyzeday.Text = "last analyze day"
        Me.cbxLastAnalyzeday.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLastAnalyzeday.UseVisualStyleBackColor = True
        '
        'cbxUnusedindexcnt
        '
        Me.cbxUnusedindexcnt.AutoSize = True
        Me.cbxUnusedindexcnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxUnusedindexcnt.LineColor = System.Drawing.Color.Gray
        Me.cbxUnusedindexcnt.Location = New System.Drawing.Point(365, 58)
        Me.cbxUnusedindexcnt.Name = "cbxUnusedindexcnt"
        Me.cbxUnusedindexcnt.Radius = 10
        Me.cbxUnusedindexcnt.Size = New System.Drawing.Size(139, 16)
        Me.cbxUnusedindexcnt.TabIndex = 21
        Me.cbxUnusedindexcnt.Text = "Unused index cnt"
        Me.cbxUnusedindexcnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxUnusedindexcnt.UseVisualStyleBackColor = True
        '
        'cbxIdletranscnt
        '
        Me.cbxIdletranscnt.AutoSize = True
        Me.cbxIdletranscnt.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxIdletranscnt.LineColor = System.Drawing.Color.Gray
        Me.cbxIdletranscnt.Location = New System.Drawing.Point(365, 21)
        Me.cbxIdletranscnt.Name = "cbxIdletranscnt"
        Me.cbxIdletranscnt.Radius = 10
        Me.cbxIdletranscnt.Size = New System.Drawing.Size(168, 16)
        Me.cbxIdletranscnt.TabIndex = 20
        Me.cbxIdletranscnt.Text = "Idle in transaction cnt"
        Me.cbxIdletranscnt.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxIdletranscnt.UseVisualStyleBackColor = True
        '
        'nudLastAnalyzeday
        '
        Me.nudLastAnalyzeday.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudLastAnalyzeday.ForeColor = System.Drawing.Color.White
        Me.nudLastAnalyzeday.Location = New System.Drawing.Point(582, 95)
        Me.nudLastAnalyzeday.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLastAnalyzeday.Name = "nudLastAnalyzeday"
        Me.nudLastAnalyzeday.Size = New System.Drawing.Size(92, 21)
        Me.nudLastAnalyzeday.TabIndex = 13
        Me.nudLastAnalyzeday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudUnusedindexcnt
        '
        Me.nudUnusedindexcnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudUnusedindexcnt.ForeColor = System.Drawing.Color.White
        Me.nudUnusedindexcnt.Location = New System.Drawing.Point(582, 58)
        Me.nudUnusedindexcnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudUnusedindexcnt.Name = "nudUnusedindexcnt"
        Me.nudUnusedindexcnt.Size = New System.Drawing.Size(92, 21)
        Me.nudUnusedindexcnt.TabIndex = 10
        Me.nudUnusedindexcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudIdletranscnt
        '
        Me.nudIdletranscnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.nudIdletranscnt.ForeColor = System.Drawing.Color.White
        Me.nudIdletranscnt.Location = New System.Drawing.Point(582, 21)
        Me.nudIdletranscnt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudIdletranscnt.Name = "nudIdletranscnt"
        Me.nudIdletranscnt.Size = New System.Drawing.Size(92, 21)
        Me.nudIdletranscnt.TabIndex = 8
        Me.nudIdletranscnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13587!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86413!))
        Me.TableLayoutPanel1.Controls.Add(Me.grpSWAPusedratio, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.grpDiskusedratio, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.grpCommitratio, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grpBufferhitratio, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grpConnections, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grpCPUwaitratio, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.63388!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.36612!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(736, 250)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'grpSWAPusedratio
        '
        Me.grpSWAPusedratio.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSWAPusedratio.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSWAPusedratio.Controls.Add(Me.dtbSWAPusedratio)
        Me.grpSWAPusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSWAPusedratio.EdgeRound = Edges2
        Me.grpSWAPusedratio.FillColor = System.Drawing.Color.Black
        Me.grpSWAPusedratio.ForeColor = System.Drawing.Color.White
        Me.grpSWAPusedratio.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpSWAPusedratio.LineWidth = 1
        Me.grpSWAPusedratio.Location = New System.Drawing.Point(3, 168)
        Me.grpSWAPusedratio.Name = "grpSWAPusedratio"
        Me.grpSWAPusedratio.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpSWAPusedratio.Size = New System.Drawing.Size(363, 79)
        Me.grpSWAPusedratio.TabIndex = 5
        Me.grpSWAPusedratio.TabStop = False
        Me.grpSWAPusedratio.Text = "SWAP used ratio"
        Me.grpSWAPusedratio.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpSWAPusedratio.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpSWAPusedratio.UseGraColor = True
        Me.grpSWAPusedratio.UseRound = True
        Me.grpSWAPusedratio.UseTitle = True
        '
        'dtbSWAPusedratio
        '
        Me.dtbSWAPusedratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbSWAPusedratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbSWAPusedratio.BarMaxValue = 70
        Me.dtbSWAPusedratio.BarMinValue = 50
        Me.dtbSWAPusedratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbSWAPusedratio.CaptionSpacing = 10
        Me.dtbSWAPusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbSWAPusedratio.ForeColor = System.Drawing.Color.Silver
        Me.dtbSWAPusedratio.Location = New System.Drawing.Point(3, 23)
        Me.dtbSWAPusedratio.Name = "dtbSWAPusedratio"
        Me.dtbSWAPusedratio.Size = New System.Drawing.Size(357, 53)
        Me.dtbSWAPusedratio.TabIndex = 40
        Me.dtbSWAPusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbSWAPusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbSWAPusedratio.TickSpacing = 20
        Me.dtbSWAPusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbSWAPusedratio.TrackHeight = 6
        Me.dtbSWAPusedratio.YPosition = 10
        '
        'grpDiskusedratio
        '
        Me.grpDiskusedratio.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpDiskusedratio.AlignString = System.Drawing.StringAlignment.Near
        Me.grpDiskusedratio.Controls.Add(Me.dtbDiskusedratio)
        Me.grpDiskusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDiskusedratio.EdgeRound = Edges3
        Me.grpDiskusedratio.FillColor = System.Drawing.Color.Black
        Me.grpDiskusedratio.ForeColor = System.Drawing.Color.White
        Me.grpDiskusedratio.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpDiskusedratio.LineWidth = 1
        Me.grpDiskusedratio.Location = New System.Drawing.Point(372, 168)
        Me.grpDiskusedratio.Name = "grpDiskusedratio"
        Me.grpDiskusedratio.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpDiskusedratio.Size = New System.Drawing.Size(361, 79)
        Me.grpDiskusedratio.TabIndex = 4
        Me.grpDiskusedratio.TabStop = False
        Me.grpDiskusedratio.Text = "Disk Used ratio"
        Me.grpDiskusedratio.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpDiskusedratio.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpDiskusedratio.UseGraColor = True
        Me.grpDiskusedratio.UseRound = True
        Me.grpDiskusedratio.UseTitle = True
        '
        'dtbDiskusedratio
        '
        Me.dtbDiskusedratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbDiskusedratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbDiskusedratio.BarMaxValue = 70
        Me.dtbDiskusedratio.BarMinValue = 50
        Me.dtbDiskusedratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbDiskusedratio.CaptionSpacing = 10
        Me.dtbDiskusedratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbDiskusedratio.ForeColor = System.Drawing.Color.Silver
        Me.dtbDiskusedratio.Location = New System.Drawing.Point(3, 23)
        Me.dtbDiskusedratio.Name = "dtbDiskusedratio"
        Me.dtbDiskusedratio.Size = New System.Drawing.Size(355, 53)
        Me.dtbDiskusedratio.TabIndex = 41
        Me.dtbDiskusedratio.Text = "DoubleTrackBarDraw1"
        Me.dtbDiskusedratio.TickColor = System.Drawing.Color.Silver
        Me.dtbDiskusedratio.TickSpacing = 20
        Me.dtbDiskusedratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbDiskusedratio.TrackHeight = 6
        Me.dtbDiskusedratio.YPosition = 10
        '
        'grpCommitratio
        '
        Me.grpCommitratio.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpCommitratio.AlignString = System.Drawing.StringAlignment.Near
        Me.grpCommitratio.Controls.Add(Me.dtbCommitratio)
        Me.grpCommitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCommitratio.EdgeRound = Edges4
        Me.grpCommitratio.FillColor = System.Drawing.Color.Black
        Me.grpCommitratio.ForeColor = System.Drawing.Color.White
        Me.grpCommitratio.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpCommitratio.LineWidth = 1
        Me.grpCommitratio.Location = New System.Drawing.Point(372, 3)
        Me.grpCommitratio.Name = "grpCommitratio"
        Me.grpCommitratio.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpCommitratio.Size = New System.Drawing.Size(361, 74)
        Me.grpCommitratio.TabIndex = 1
        Me.grpCommitratio.TabStop = False
        Me.grpCommitratio.Text = "Commit ratio"
        Me.grpCommitratio.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpCommitratio.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpCommitratio.UseGraColor = True
        Me.grpCommitratio.UseRound = True
        Me.grpCommitratio.UseTitle = True
        '
        'dtbCommitratio
        '
        Me.dtbCommitratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCommitratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCommitratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCommitratio.BarMaxValue = 70
        Me.dtbCommitratio.BarMinValue = 50
        Me.dtbCommitratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCommitratio.CaptionSpacing = 10
        Me.dtbCommitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCommitratio.ForeColor = System.Drawing.Color.Silver
        Me.dtbCommitratio.Location = New System.Drawing.Point(3, 23)
        Me.dtbCommitratio.Name = "dtbCommitratio"
        Me.dtbCommitratio.Size = New System.Drawing.Size(355, 48)
        Me.dtbCommitratio.TabIndex = 37
        Me.dtbCommitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCommitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCommitratio.TickSpacing = 20
        Me.dtbCommitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCommitratio.TrackColor1 = System.Drawing.Color.Red
        Me.dtbCommitratio.TrackColor3 = System.Drawing.Color.Lime
        Me.dtbCommitratio.TrackHeight = 6
        Me.dtbCommitratio.YPosition = 10
        '
        'grpBufferhitratio
        '
        Me.grpBufferhitratio.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpBufferhitratio.AlignString = System.Drawing.StringAlignment.Near
        Me.grpBufferhitratio.Controls.Add(Me.dtbBufferhitratio)
        Me.grpBufferhitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBufferhitratio.EdgeRound = Edges5
        Me.grpBufferhitratio.FillColor = System.Drawing.Color.Black
        Me.grpBufferhitratio.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpBufferhitratio.ForeColor = System.Drawing.Color.White
        Me.grpBufferhitratio.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpBufferhitratio.LineWidth = 1
        Me.grpBufferhitratio.Location = New System.Drawing.Point(3, 3)
        Me.grpBufferhitratio.Name = "grpBufferhitratio"
        Me.grpBufferhitratio.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpBufferhitratio.Size = New System.Drawing.Size(363, 74)
        Me.grpBufferhitratio.TabIndex = 0
        Me.grpBufferhitratio.TabStop = False
        Me.grpBufferhitratio.Text = "Buffer hit ratio"
        Me.grpBufferhitratio.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpBufferhitratio.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpBufferhitratio.UseGraColor = True
        Me.grpBufferhitratio.UseRound = True
        Me.grpBufferhitratio.UseTitle = True
        '
        'dtbBufferhitratio
        '
        Me.dtbBufferhitratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbBufferhitratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbBufferhitratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbBufferhitratio.BarMaxValue = 70
        Me.dtbBufferhitratio.BarMinValue = 50
        Me.dtbBufferhitratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbBufferhitratio.CaptionSpacing = 10
        Me.dtbBufferhitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbBufferhitratio.ForeColor = System.Drawing.Color.Silver
        Me.dtbBufferhitratio.Location = New System.Drawing.Point(3, 23)
        Me.dtbBufferhitratio.Name = "dtbBufferhitratio"
        Me.dtbBufferhitratio.Size = New System.Drawing.Size(357, 48)
        Me.dtbBufferhitratio.TabIndex = 25
        Me.dtbBufferhitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbBufferhitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbBufferhitratio.TickSpacing = 20
        Me.dtbBufferhitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbBufferhitratio.TrackColor1 = System.Drawing.Color.Red
        Me.dtbBufferhitratio.TrackColor3 = System.Drawing.Color.Lime
        Me.dtbBufferhitratio.TrackHeight = 6
        Me.dtbBufferhitratio.YPosition = 10
        '
        'grpConnections
        '
        Me.grpConnections.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpConnections.AlignString = System.Drawing.StringAlignment.Near
        Me.grpConnections.Controls.Add(Me.dtbConnections)
        Me.grpConnections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpConnections.EdgeRound = Edges6
        Me.grpConnections.FillColor = System.Drawing.Color.Black
        Me.grpConnections.ForeColor = System.Drawing.Color.White
        Me.grpConnections.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpConnections.LineWidth = 1
        Me.grpConnections.Location = New System.Drawing.Point(3, 83)
        Me.grpConnections.Name = "grpConnections"
        Me.grpConnections.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpConnections.Size = New System.Drawing.Size(363, 79)
        Me.grpConnections.TabIndex = 2
        Me.grpConnections.TabStop = False
        Me.grpConnections.Text = "Connections"
        Me.grpConnections.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpConnections.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpConnections.UseGraColor = True
        Me.grpConnections.UseRound = True
        Me.grpConnections.UseTitle = True
        '
        'dtbConnections
        '
        Me.dtbConnections.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnections.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbConnections.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbConnections.BarMaxValue = 70
        Me.dtbConnections.BarMinValue = 50
        Me.dtbConnections.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbConnections.CaptionSpacing = 10
        Me.dtbConnections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbConnections.ForeColor = System.Drawing.Color.Silver
        Me.dtbConnections.Location = New System.Drawing.Point(3, 23)
        Me.dtbConnections.Name = "dtbConnections"
        Me.dtbConnections.Size = New System.Drawing.Size(357, 53)
        Me.dtbConnections.TabIndex = 38
        Me.dtbConnections.Text = "DoubleTrackBarDraw1"
        Me.dtbConnections.TickColor = System.Drawing.Color.Silver
        Me.dtbConnections.TickSpacing = 20
        Me.dtbConnections.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbConnections.TrackHeight = 6
        Me.dtbConnections.YPosition = 10
        '
        'grpCPUwaitratio
        '
        Me.grpCPUwaitratio.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpCPUwaitratio.AlignString = System.Drawing.StringAlignment.Near
        Me.grpCPUwaitratio.Controls.Add(Me.dtbCPUwaitratio)
        Me.grpCPUwaitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCPUwaitratio.EdgeRound = Edges7
        Me.grpCPUwaitratio.FillColor = System.Drawing.Color.Black
        Me.grpCPUwaitratio.ForeColor = System.Drawing.Color.White
        Me.grpCPUwaitratio.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpCPUwaitratio.LineWidth = 1
        Me.grpCPUwaitratio.Location = New System.Drawing.Point(372, 83)
        Me.grpCPUwaitratio.Name = "grpCPUwaitratio"
        Me.grpCPUwaitratio.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpCPUwaitratio.Size = New System.Drawing.Size(361, 79)
        Me.grpCPUwaitratio.TabIndex = 3
        Me.grpCPUwaitratio.TabStop = False
        Me.grpCPUwaitratio.Text = "CPU wait ratio"
        Me.grpCPUwaitratio.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpCPUwaitratio.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpCPUwaitratio.UseGraColor = True
        Me.grpCPUwaitratio.UseRound = True
        Me.grpCPUwaitratio.UseTitle = True
        '
        'dtbCPUwaitratio
        '
        Me.dtbCPUwaitratio.BarBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratio.BarColor = System.Drawing.Color.WhiteSmoke
        Me.dtbCPUwaitratio.BarHighLight = System.Drawing.SystemColors.Highlight
        Me.dtbCPUwaitratio.BarMaxValue = 70
        Me.dtbCPUwaitratio.BarMinValue = 50
        Me.dtbCPUwaitratio.BarSize = New System.Drawing.Size(14, 18)
        Me.dtbCPUwaitratio.CaptionSpacing = 10
        Me.dtbCPUwaitratio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtbCPUwaitratio.ForeColor = System.Drawing.Color.Silver
        Me.dtbCPUwaitratio.Location = New System.Drawing.Point(3, 23)
        Me.dtbCPUwaitratio.Name = "dtbCPUwaitratio"
        Me.dtbCPUwaitratio.Size = New System.Drawing.Size(355, 53)
        Me.dtbCPUwaitratio.TabIndex = 39
        Me.dtbCPUwaitratio.Text = "DoubleTrackBarDraw1"
        Me.dtbCPUwaitratio.TickColor = System.Drawing.Color.Silver
        Me.dtbCPUwaitratio.TickSpacing = 20
        Me.dtbCPUwaitratio.TrackBorderColor = System.Drawing.Color.DimGray
        Me.dtbCPUwaitratio.TrackHeight = 6
        Me.dtbCPUwaitratio.YPosition = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAlertconfig)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 23)
        Me.Panel1.TabIndex = 0
        '
        'lblAlertconfig
        '
        Me.lblAlertconfig.BackColor = System.Drawing.Color.Black
        Me.lblAlertconfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlertconfig.FixedHeight = False
        Me.lblAlertconfig.FixedWidth = False
        Me.lblAlertconfig.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAlertconfig.Location = New System.Drawing.Point(0, 0)
        Me.lblAlertconfig.Name = "lblAlertconfig"
        Me.lblAlertconfig.Size = New System.Drawing.Size(736, 23)
        Me.lblAlertconfig.TabIndex = 1
        Me.lblAlertconfig.Text = "Alert configuration"
        Me.lblAlertconfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlertConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AlertConfiguration"
        Me.Size = New System.Drawing.Size(736, 489)
        Me.Panel2.ResumeLayout(False)
        Me.grpTransactionalert.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.nudConfailedcnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastvacuumDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLongrunsqlsec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLockedtranccnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastAnalyzeday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnusedindexcnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIdletranscnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpSWAPusedratio.ResumeLayout(False)
        Me.grpDiskusedratio.ResumeLayout(False)
        Me.grpCommitratio.ResumeLayout(False)
        Me.grpBufferhitratio.ResumeLayout(False)
        Me.grpConnections.ResumeLayout(False)
        Me.grpCPUwaitratio.ResumeLayout(False)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents lblAlertconfig As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents grpBufferhitratio As eXperDB.BaseControls.GroupBox
    Friend WithEvents grpCommitratio As eXperDB.BaseControls.GroupBox
    Friend WithEvents grpTransactionalert As eXperDB.BaseControls.GroupBox
    Friend WithEvents grpSWAPusedratio As eXperDB.BaseControls.GroupBox
    Friend WithEvents grpDiskusedratio As eXperDB.BaseControls.GroupBox
    Friend WithEvents grpConnections As eXperDB.BaseControls.GroupBox
    Friend WithEvents grpCPUwaitratio As eXperDB.BaseControls.GroupBox
    Friend WithEvents nudLockedtranccnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As eXperDB.BaseControls.Button
    Friend WithEvents nudUnusedindexcnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudIdletranscnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLastvacuumDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLongrunsqlsec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLastAnalyzeday As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudConfailedcnt As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbxLockedtranccnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxLastAnalyzeday As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxUnusedindexcnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxLongrunsqlsec As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxLastvacuumDay As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxConfailedcnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents cbxIdletranscnt As eXperDB.BaseControls.CheckBox
    Friend WithEvents dtbBufferhitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbCommitratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbConnections As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbSWAPusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbDiskusedratio As eXperDB.Controls.DoubleTrackBarDraw
    Friend WithEvents dtbCPUwaitratio As eXperDB.Controls.DoubleTrackBarDraw

End Class
