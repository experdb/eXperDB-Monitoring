<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnapshotR
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnapshotR))
        Me.tlpSnapShot = New eXperDB.BaseControls.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkCompare = New eXperDB.BaseControls.CheckBox()
        Me.tlpCluster = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbClusters = New eXperDB.BaseControls.ComboBox()
        Me.Label16 = New eXperDB.BaseControls.Label()
        Me.tlpSnapshot2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnComTo = New eXperDB.BaseControls.Button()
        Me.btnComFrom = New eXperDB.BaseControls.Button()
        Me.radComReportType2 = New eXperDB.BaseControls.RadioButton()
        Me.radComReportType1 = New eXperDB.BaseControls.RadioButton()
        Me.lblComReportType = New eXperDB.BaseControls.Label()
        Me.txtComSnapTo = New eXperDB.BaseControls.TextBox()
        Me.lblComReportTo = New eXperDB.BaseControls.Label()
        Me.txtComSnapFrom = New eXperDB.BaseControls.TextBox()
        Me.lblComReportFrom = New eXperDB.BaseControls.Label()
        Me.tlpSnapshot1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSnapFrom = New eXperDB.BaseControls.Label()
        Me.btnTo = New eXperDB.BaseControls.Button()
        Me.btnFrom = New eXperDB.BaseControls.Button()
        Me.radReportType2 = New eXperDB.BaseControls.RadioButton()
        Me.radReportType1 = New eXperDB.BaseControls.RadioButton()
        Me.lblReportType = New eXperDB.BaseControls.Label()
        Me.txtSnapTo = New eXperDB.BaseControls.TextBox()
        Me.lblReportTo = New eXperDB.BaseControls.Label()
        Me.lblReportFrom = New eXperDB.BaseControls.Label()
        Me.txtSnapFrom = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel7 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnGenerate = New eXperDB.BaseControls.Button()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfig = New eXperDB.BaseControls.Button()
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.btnHistory = New eXperDB.BaseControls.Button()
        Me.tlpSnapShot.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpCluster.SuspendLayout()
        Me.tlpSnapshot2.SuspendLayout()
        Me.tlpSnapshot1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSnapShot
        '
        Me.tlpSnapShot.ColumnCount = 2
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.tlpSnapShot.Controls.Add(Me.tlpCluster, 0, 0)
        Me.tlpSnapShot.Controls.Add(Me.tlpSnapshot2, 0, 3)
        Me.tlpSnapShot.Controls.Add(Me.tlpSnapshot1, 0, 1)
        Me.tlpSnapShot.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpSnapShot.Location = New System.Drawing.Point(3, 47)
        Me.tlpSnapShot.Name = "tlpSnapShot"
        Me.tlpSnapShot.RowCount = 5
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapShot.Size = New System.Drawing.Size(626, 373)
        Me.tlpSnapShot.TabIndex = 16
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.tlpSnapShot.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.chkCompare, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 193)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(620, 44)
        Me.TableLayoutPanel3.TabIndex = 28
        '
        'chkCompare
        '
        Me.chkCompare.AutoSize = True
        Me.chkCompare.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCompare.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkCompare.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkCompare.ForeColor = System.Drawing.Color.White
        Me.chkCompare.LineColor = System.Drawing.Color.Gray
        Me.chkCompare.Location = New System.Drawing.Point(13, 15)
        Me.chkCompare.Name = "chkCompare"
        Me.chkCompare.Radius = 10
        Me.chkCompare.Size = New System.Drawing.Size(104, 16)
        Me.chkCompare.TabIndex = 36
        Me.chkCompare.Text = "Compare To"
        Me.chkCompare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCompare.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCompare.UseVisualStyleBackColor = True
        '
        'tlpCluster
        '
        Me.tlpCluster.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpCluster.ColumnCount = 6
        Me.tlpSnapShot.SetColumnSpan(Me.tlpCluster, 2)
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCluster.Controls.Add(Me.cmbClusters, 2, 1)
        Me.tlpCluster.Controls.Add(Me.Label16, 1, 1)
        Me.tlpCluster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCluster.Location = New System.Drawing.Point(3, 3)
        Me.tlpCluster.Name = "tlpCluster"
        Me.tlpCluster.RowCount = 3
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCluster.Size = New System.Drawing.Size(620, 64)
        Me.tlpCluster.TabIndex = 27
        '
        'cmbClusters
        '
        Me.cmbClusters.BackColor = System.Drawing.SystemColors.Window
        Me.cmbClusters.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbClusters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClusters.FixedWidth = False
        Me.cmbClusters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClusters.FormattingEnabled = True
        Me.cmbClusters.Location = New System.Drawing.Point(123, 27)
        Me.cmbClusters.Name = "cmbClusters"
        Me.cmbClusters.Necessary = False
        Me.cmbClusters.Size = New System.Drawing.Size(154, 20)
        Me.cmbClusters.StatusTip = ""
        Me.cmbClusters.TabIndex = 34
        Me.cmbClusters.ValueText = ""
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.FixedWidth = False
        Me.Label16.LineSpacing = 0.0!
        Me.Label16.Location = New System.Drawing.Point(13, 27)
        Me.Label16.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 21)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Cluster"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlpSnapshot2
        '
        Me.tlpSnapshot2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpSnapshot2.ColumnCount = 8
        Me.tlpSnapShot.SetColumnSpan(Me.tlpSnapshot2, 2)
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot2.Controls.Add(Me.btnComTo, 6, 2)
        Me.tlpSnapshot2.Controls.Add(Me.btnComFrom, 3, 2)
        Me.tlpSnapshot2.Controls.Add(Me.radComReportType2, 4, 1)
        Me.tlpSnapshot2.Controls.Add(Me.radComReportType1, 2, 1)
        Me.tlpSnapshot2.Controls.Add(Me.lblComReportType, 1, 1)
        Me.tlpSnapshot2.Controls.Add(Me.txtComSnapTo, 5, 2)
        Me.tlpSnapshot2.Controls.Add(Me.lblComReportTo, 4, 2)
        Me.tlpSnapshot2.Controls.Add(Me.txtComSnapFrom, 2, 2)
        Me.tlpSnapshot2.Controls.Add(Me.lblComReportFrom, 1, 2)
        Me.tlpSnapshot2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapshot2.Location = New System.Drawing.Point(3, 243)
        Me.tlpSnapshot2.Name = "tlpSnapshot2"
        Me.tlpSnapshot2.RowCount = 4
        Me.tlpSnapshot2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot2.Size = New System.Drawing.Size(620, 134)
        Me.tlpSnapshot2.TabIndex = 26
        '
        'btnComTo
        '
        Me.btnComTo.BackColor = System.Drawing.Color.Silver
        Me.btnComTo.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnComTo.FixedHeight = False
        Me.btnComTo.FixedWidth = False
        Me.btnComTo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnComTo.ForeColor = System.Drawing.Color.Red
        Me.btnComTo.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComTo.Image = CType(resources.GetObject("btnComTo.Image"), System.Drawing.Image)
        Me.btnComTo.LineColor = System.Drawing.Color.LightGray
        Me.btnComTo.Location = New System.Drawing.Point(523, 65)
        Me.btnComTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 1)
        Me.btnComTo.Name = "btnComTo"
        Me.btnComTo.Radius = 5
        Me.btnComTo.Size = New System.Drawing.Size(24, 24)
        Me.btnComTo.TabIndex = 34
        Me.btnComTo.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnComTo.UseVisualStyleBackColor = True
        '
        'btnComFrom
        '
        Me.btnComFrom.BackColor = System.Drawing.Color.Silver
        Me.btnComFrom.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnComFrom.FixedHeight = False
        Me.btnComFrom.FixedWidth = False
        Me.btnComFrom.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnComFrom.ForeColor = System.Drawing.Color.Red
        Me.btnComFrom.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComFrom.Image = CType(resources.GetObject("btnComFrom.Image"), System.Drawing.Image)
        Me.btnComFrom.LineColor = System.Drawing.Color.LightGray
        Me.btnComFrom.Location = New System.Drawing.Point(283, 65)
        Me.btnComFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 1)
        Me.btnComFrom.Name = "btnComFrom"
        Me.btnComFrom.Radius = 5
        Me.btnComFrom.Size = New System.Drawing.Size(24, 24)
        Me.btnComFrom.TabIndex = 33
        Me.btnComFrom.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnComFrom.UseVisualStyleBackColor = True
        '
        'radComReportType2
        '
        Me.radComReportType2.AutoSize = True
        Me.radComReportType2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpSnapshot2.SetColumnSpan(Me.radComReportType2, 2)
        Me.radComReportType2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.radComReportType2.LineColor = System.Drawing.Color.Gray
        Me.radComReportType2.Location = New System.Drawing.Point(313, 31)
        Me.radComReportType2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.radComReportType2.Name = "radComReportType2"
        Me.radComReportType2.Radius = 10
        Me.radComReportType2.Size = New System.Drawing.Size(204, 16)
        Me.radComReportType2.TabIndex = 32
        Me.radComReportType2.TabStop = True
        Me.radComReportType2.Text = "Baseline"
        Me.radComReportType2.UnCheckFillColor = System.Drawing.Color.White
        Me.radComReportType2.UseVisualStyleBackColor = True
        Me.radComReportType2.Warning = False
        Me.radComReportType2.WarningColor = System.Drawing.Color.Red
        '
        'radComReportType1
        '
        Me.radComReportType1.AutoSize = True
        Me.radComReportType1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.radComReportType1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.radComReportType1.LineColor = System.Drawing.Color.Gray
        Me.radComReportType1.Location = New System.Drawing.Point(123, 31)
        Me.radComReportType1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.radComReportType1.Name = "radComReportType1"
        Me.radComReportType1.Radius = 10
        Me.radComReportType1.Size = New System.Drawing.Size(154, 16)
        Me.radComReportType1.TabIndex = 31
        Me.radComReportType1.TabStop = True
        Me.radComReportType1.Text = "Snapshot"
        Me.radComReportType1.UnCheckFillColor = System.Drawing.Color.White
        Me.radComReportType1.UseVisualStyleBackColor = True
        Me.radComReportType1.Warning = False
        Me.radComReportType1.WarningColor = System.Drawing.Color.Red
        '
        'lblComReportType
        '
        Me.lblComReportType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblComReportType.FixedWidth = False
        Me.lblComReportType.LineSpacing = 0.0!
        Me.lblComReportType.Location = New System.Drawing.Point(13, 29)
        Me.lblComReportType.Name = "lblComReportType"
        Me.lblComReportType.Size = New System.Drawing.Size(104, 21)
        Me.lblComReportType.TabIndex = 30
        Me.lblComReportType.Text = "Report Type"
        Me.lblComReportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComSnapTo
        '
        Me.txtComSnapTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtComSnapTo.code = False
        Me.txtComSnapTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtComSnapTo.Enabled = False
        Me.txtComSnapTo.FixedWidth = False
        Me.txtComSnapTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtComSnapTo.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtComSnapTo.Location = New System.Drawing.Point(363, 66)
        Me.txtComSnapTo.Name = "txtComSnapTo"
        Me.txtComSnapTo.Necessary = False
        Me.txtComSnapTo.PossibleInput = "0123456789+"
        Me.txtComSnapTo.Prefix = ""
        Me.txtComSnapTo.Size = New System.Drawing.Size(154, 21)
        Me.txtComSnapTo.StatusTip = ""
        Me.txtComSnapTo.TabIndex = 29
        Me.txtComSnapTo.Value = ""
        '
        'lblComReportTo
        '
        Me.lblComReportTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblComReportTo.FixedHeight = False
        Me.lblComReportTo.FixedWidth = False
        Me.lblComReportTo.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblComReportTo.ForeColor = System.Drawing.Color.White
        Me.lblComReportTo.LineSpacing = 0.0!
        Me.lblComReportTo.Location = New System.Drawing.Point(313, 68)
        Me.lblComReportTo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblComReportTo.Name = "lblComReportTo"
        Me.lblComReportTo.Size = New System.Drawing.Size(44, 20)
        Me.lblComReportTo.TabIndex = 28
        Me.lblComReportTo.Text = "To"
        Me.lblComReportTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComSnapFrom
        '
        Me.txtComSnapFrom.BackColor = System.Drawing.SystemColors.Control
        Me.txtComSnapFrom.code = False
        Me.txtComSnapFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtComSnapFrom.Enabled = False
        Me.txtComSnapFrom.FixedWidth = False
        Me.txtComSnapFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtComSnapFrom.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtComSnapFrom.Location = New System.Drawing.Point(123, 66)
        Me.txtComSnapFrom.MaxByteLength = 16
        Me.txtComSnapFrom.Name = "txtComSnapFrom"
        Me.txtComSnapFrom.Necessary = False
        Me.txtComSnapFrom.PossibleInput = ""
        Me.txtComSnapFrom.Prefix = ""
        Me.txtComSnapFrom.Size = New System.Drawing.Size(154, 21)
        Me.txtComSnapFrom.StatusTip = ""
        Me.txtComSnapFrom.TabIndex = 27
        Me.txtComSnapFrom.Value = ""
        '
        'lblComReportFrom
        '
        Me.lblComReportFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblComReportFrom.FixedHeight = False
        Me.lblComReportFrom.FixedWidth = False
        Me.lblComReportFrom.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblComReportFrom.ForeColor = System.Drawing.Color.White
        Me.lblComReportFrom.LineSpacing = 0.0!
        Me.lblComReportFrom.Location = New System.Drawing.Point(13, 68)
        Me.lblComReportFrom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblComReportFrom.Name = "lblComReportFrom"
        Me.lblComReportFrom.Size = New System.Drawing.Size(104, 20)
        Me.lblComReportFrom.TabIndex = 26
        Me.lblComReportFrom.Text = "From"
        Me.lblComReportFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlpSnapshot1
        '
        Me.tlpSnapshot1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpSnapshot1.ColumnCount = 8
        Me.tlpSnapShot.SetColumnSpan(Me.tlpSnapshot1, 2)
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot1.Controls.Add(Me.lblSnapFrom, 2, 3)
        Me.tlpSnapshot1.Controls.Add(Me.btnTo, 6, 2)
        Me.tlpSnapshot1.Controls.Add(Me.btnFrom, 3, 2)
        Me.tlpSnapshot1.Controls.Add(Me.radReportType2, 4, 1)
        Me.tlpSnapshot1.Controls.Add(Me.radReportType1, 2, 1)
        Me.tlpSnapshot1.Controls.Add(Me.lblReportType, 1, 1)
        Me.tlpSnapshot1.Controls.Add(Me.txtSnapTo, 5, 2)
        Me.tlpSnapshot1.Controls.Add(Me.lblReportTo, 4, 2)
        Me.tlpSnapshot1.Controls.Add(Me.lblReportFrom, 1, 2)
        Me.tlpSnapshot1.Controls.Add(Me.txtSnapFrom, 2, 2)
        Me.tlpSnapshot1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapshot1.Location = New System.Drawing.Point(3, 73)
        Me.tlpSnapshot1.Name = "tlpSnapshot1"
        Me.tlpSnapshot1.RowCount = 4
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSnapshot1.Size = New System.Drawing.Size(620, 114)
        Me.tlpSnapshot1.TabIndex = 25
        '
        'lblSnapFrom
        '
        Me.lblSnapFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSnapFrom.FixedHeight = False
        Me.lblSnapFrom.FixedWidth = False
        Me.lblSnapFrom.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSnapFrom.ForeColor = System.Drawing.Color.White
        Me.lblSnapFrom.LineSpacing = 0.0!
        Me.lblSnapFrom.Location = New System.Drawing.Point(123, 92)
        Me.lblSnapFrom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblSnapFrom.Name = "lblSnapFrom"
        Me.lblSnapFrom.Size = New System.Drawing.Size(154, 20)
        Me.lblSnapFrom.TabIndex = 28
        Me.lblSnapFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSnapFrom.Visible = False
        '
        'btnTo
        '
        Me.btnTo.BackColor = System.Drawing.Color.Silver
        Me.btnTo.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnTo.FixedHeight = False
        Me.btnTo.FixedWidth = False
        Me.btnTo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnTo.ForeColor = System.Drawing.Color.Red
        Me.btnTo.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTo.Image = CType(resources.GetObject("btnTo.Image"), System.Drawing.Image)
        Me.btnTo.LineColor = System.Drawing.Color.LightGray
        Me.btnTo.Location = New System.Drawing.Point(523, 65)
        Me.btnTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 1)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Radius = 5
        Me.btnTo.Size = New System.Drawing.Size(24, 24)
        Me.btnTo.TabIndex = 27
        Me.btnTo.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTo.UseVisualStyleBackColor = True
        '
        'btnFrom
        '
        Me.btnFrom.BackColor = System.Drawing.Color.Silver
        Me.btnFrom.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFrom.FixedHeight = False
        Me.btnFrom.FixedWidth = False
        Me.btnFrom.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnFrom.ForeColor = System.Drawing.Color.Red
        Me.btnFrom.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFrom.Image = CType(resources.GetObject("btnFrom.Image"), System.Drawing.Image)
        Me.btnFrom.LineColor = System.Drawing.Color.LightGray
        Me.btnFrom.Location = New System.Drawing.Point(283, 65)
        Me.btnFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 1)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Radius = 5
        Me.btnFrom.Size = New System.Drawing.Size(24, 24)
        Me.btnFrom.TabIndex = 26
        Me.btnFrom.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFrom.UseVisualStyleBackColor = True
        '
        'radReportType2
        '
        Me.radReportType2.AutoSize = True
        Me.radReportType2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpSnapshot1.SetColumnSpan(Me.radReportType2, 2)
        Me.radReportType2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.radReportType2.LineColor = System.Drawing.Color.Gray
        Me.radReportType2.Location = New System.Drawing.Point(313, 31)
        Me.radReportType2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.radReportType2.Name = "radReportType2"
        Me.radReportType2.Radius = 10
        Me.radReportType2.Size = New System.Drawing.Size(204, 16)
        Me.radReportType2.TabIndex = 25
        Me.radReportType2.TabStop = True
        Me.radReportType2.Text = "Baseline"
        Me.radReportType2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radReportType2.UseVisualStyleBackColor = True
        Me.radReportType2.Warning = False
        Me.radReportType2.WarningColor = System.Drawing.Color.Red
        '
        'radReportType1
        '
        Me.radReportType1.AutoSize = True
        Me.radReportType1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.radReportType1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.radReportType1.LineColor = System.Drawing.Color.Gray
        Me.radReportType1.Location = New System.Drawing.Point(123, 31)
        Me.radReportType1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.radReportType1.Name = "radReportType1"
        Me.radReportType1.Radius = 10
        Me.radReportType1.Size = New System.Drawing.Size(154, 16)
        Me.radReportType1.TabIndex = 24
        Me.radReportType1.TabStop = True
        Me.radReportType1.Text = "Snapshot"
        Me.radReportType1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radReportType1.UseVisualStyleBackColor = True
        Me.radReportType1.Warning = False
        Me.radReportType1.WarningColor = System.Drawing.Color.Red
        '
        'lblReportType
        '
        Me.lblReportType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportType.FixedWidth = False
        Me.lblReportType.LineSpacing = 0.0!
        Me.lblReportType.Location = New System.Drawing.Point(13, 29)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(104, 21)
        Me.lblReportType.TabIndex = 23
        Me.lblReportType.Text = "Report Type"
        Me.lblReportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSnapTo
        '
        Me.txtSnapTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtSnapTo.code = False
        Me.txtSnapTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSnapTo.Enabled = False
        Me.txtSnapTo.FixedWidth = False
        Me.txtSnapTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSnapTo.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtSnapTo.Location = New System.Drawing.Point(363, 66)
        Me.txtSnapTo.Name = "txtSnapTo"
        Me.txtSnapTo.Necessary = False
        Me.txtSnapTo.PossibleInput = "0123456789+"
        Me.txtSnapTo.Prefix = ""
        Me.txtSnapTo.Size = New System.Drawing.Size(154, 21)
        Me.txtSnapTo.StatusTip = ""
        Me.txtSnapTo.TabIndex = 8
        Me.txtSnapTo.Value = ""
        '
        'lblReportTo
        '
        Me.lblReportTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportTo.FixedHeight = False
        Me.lblReportTo.FixedWidth = False
        Me.lblReportTo.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblReportTo.ForeColor = System.Drawing.Color.White
        Me.lblReportTo.LineSpacing = 0.0!
        Me.lblReportTo.Location = New System.Drawing.Point(313, 68)
        Me.lblReportTo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblReportTo.Name = "lblReportTo"
        Me.lblReportTo.Size = New System.Drawing.Size(44, 20)
        Me.lblReportTo.TabIndex = 8
        Me.lblReportTo.Text = "To"
        Me.lblReportTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReportFrom
        '
        Me.lblReportFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportFrom.FixedHeight = False
        Me.lblReportFrom.FixedWidth = False
        Me.lblReportFrom.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblReportFrom.ForeColor = System.Drawing.Color.White
        Me.lblReportFrom.LineSpacing = 0.0!
        Me.lblReportFrom.Location = New System.Drawing.Point(13, 68)
        Me.lblReportFrom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblReportFrom.Name = "lblReportFrom"
        Me.lblReportFrom.Size = New System.Drawing.Size(104, 20)
        Me.lblReportFrom.TabIndex = 0
        Me.lblReportFrom.Text = "From"
        Me.lblReportFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSnapFrom
        '
        Me.txtSnapFrom.BackColor = System.Drawing.SystemColors.Control
        Me.txtSnapFrom.code = False
        Me.txtSnapFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSnapFrom.Enabled = False
        Me.txtSnapFrom.FixedWidth = False
        Me.txtSnapFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSnapFrom.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtSnapFrom.Location = New System.Drawing.Point(123, 66)
        Me.txtSnapFrom.MaxByteLength = 16
        Me.txtSnapFrom.Name = "txtSnapFrom"
        Me.txtSnapFrom.Necessary = False
        Me.txtSnapFrom.PossibleInput = ""
        Me.txtSnapFrom.Prefix = ""
        Me.txtSnapFrom.Size = New System.Drawing.Size(154, 21)
        Me.txtSnapFrom.StatusTip = ""
        Me.txtSnapFrom.TabIndex = 0
        Me.txtSnapFrom.Value = ""
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnGenerate, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel7.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 429)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(626, 46)
        Me.TableLayoutPanel7.TabIndex = 35
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGenerate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGenerate.FixedHeight = False
        Me.btnGenerate.FixedWidth = False
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnGenerate.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(270, 4)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Radius = 10
        Me.btnGenerate.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "F014"
        Me.btnGenerate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGenerate.UseRound = True
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(500, 44)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnHistory, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnConfig, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(626, 44)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.Silver
        Me.btnConfig.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfig.FixedHeight = False
        Me.btnConfig.FixedWidth = False
        Me.btnConfig.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnConfig.ForeColor = System.Drawing.Color.Red
        Me.btnConfig.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfig.Image = CType(resources.GetObject("btnConfig.Image"), System.Drawing.Image)
        Me.btnConfig.LineColor = System.Drawing.Color.LightGray
        Me.btnConfig.Location = New System.Drawing.Point(589, 5)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Radius = 5
        Me.btnConfig.Size = New System.Drawing.Size(34, 34)
        Me.btnConfig.TabIndex = 3
        Me.btnConfig.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Silver
        Me.btnHistory.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHistory.FixedHeight = False
        Me.btnHistory.FixedWidth = False
        Me.btnHistory.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnHistory.ForeColor = System.Drawing.Color.Yellow
        Me.btnHistory.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.LineColor = System.Drawing.Color.LightGray
        Me.btnHistory.Location = New System.Drawing.Point(549, 5)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Radius = 5
        Me.btnHistory.Size = New System.Drawing.Size(34, 34)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'frmSnapshotR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 478)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.tlpSnapShot)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSnapshotR"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SnapshotReport"
        Me.tlpSnapShot.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tlpCluster.ResumeLayout(False)
        Me.tlpSnapshot2.ResumeLayout(False)
        Me.tlpSnapshot2.PerformLayout()
        Me.tlpSnapshot1.ResumeLayout(False)
        Me.tlpSnapshot1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSnapShot As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpCluster As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbClusters As eXperDB.BaseControls.ComboBox
    Friend WithEvents Label16 As eXperDB.BaseControls.Label
    Friend WithEvents tlpSnapshot2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents radComReportType2 As eXperDB.BaseControls.RadioButton
    Friend WithEvents radComReportType1 As eXperDB.BaseControls.RadioButton
    Friend WithEvents lblComReportType As eXperDB.BaseControls.Label
    Friend WithEvents txtComSnapTo As eXperDB.BaseControls.TextBox
    Friend WithEvents lblComReportTo As eXperDB.BaseControls.Label
    Friend WithEvents txtComSnapFrom As eXperDB.BaseControls.TextBox
    Friend WithEvents lblComReportFrom As eXperDB.BaseControls.Label
    Friend WithEvents tlpSnapshot1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents radReportType2 As eXperDB.BaseControls.RadioButton
    Friend WithEvents radReportType1 As eXperDB.BaseControls.RadioButton
    Friend WithEvents lblReportType As eXperDB.BaseControls.Label
    Friend WithEvents txtSnapTo As eXperDB.BaseControls.TextBox
    Friend WithEvents lblReportTo As eXperDB.BaseControls.Label
    Friend WithEvents lblReportFrom As eXperDB.BaseControls.Label
    Friend WithEvents txtSnapFrom As eXperDB.BaseControls.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkCompare As eXperDB.BaseControls.CheckBox
    Friend WithEvents TableLayoutPanel7 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnGenerate As eXperDB.BaseControls.Button
    Friend WithEvents btnComTo As eXperDB.BaseControls.Button
    Friend WithEvents btnComFrom As eXperDB.BaseControls.Button
    Friend WithEvents btnTo As eXperDB.BaseControls.Button
    Friend WithEvents btnFrom As eXperDB.BaseControls.Button
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnConfig As eXperDB.BaseControls.Button
    Friend WithEvents lblSnapFrom As eXperDB.BaseControls.Label
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnHistory As eXperDB.BaseControls.Button
End Class
