<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnapshot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnapshot))
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.tlpSnapshot2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New eXperDB.BaseControls.GroupBox()
        Me.tlpBaseline = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvBaselineList = New eXperDB.BaseControls.DataGridView()
        Me.colDGVBLBaseline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBLMinSnap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBLFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBLMaxSnap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBLTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBLKeepTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBLEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDGVBLDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tlpBaselineHead = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddBaseline = New eXperDB.BaseControls.Button()
        Me.lblBaselineIcon = New System.Windows.Forms.Label()
        Me.lblBaseline = New System.Windows.Forms.Label()
        Me.GroupBox1 = New eXperDB.BaseControls.GroupBox()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvSnapshotList = New eXperDB.BaseControls.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSnapshot = New eXperDB.BaseControls.Button()
        Me.lblSnapshotIcon = New System.Windows.Forms.Label()
        Me.lblAccountPolicy = New System.Windows.Forms.Label()
        Me.tlpCluster = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbClusters = New eXperDB.BaseControls.ComboBox()
        Me.lblCluster = New eXperDB.BaseControls.Label()
        Me.tlpSnapShot = New eXperDB.BaseControls.TableLayoutPanel()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.colDgvSnapshotListSnapshotQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvSnapshotListTimeQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tlpSnapshot2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tlpBaseline.SuspendLayout()
        CType(Me.dgvBaselineList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpBaselineHead.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        CType(Me.dgvSnapshotList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpCluster.SuspendLayout()
        Me.tlpSnapShot.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TitleLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(894, 50)
        Me.TableLayoutPanel2.TabIndex = 15
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
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TitleLabel.Location = New System.Drawing.Point(43, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(758, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Text"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpSnapshot2
        '
        Me.tlpSnapshot2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpSnapshot2.ColumnCount = 2
        Me.tlpSnapShot.SetColumnSpan(Me.tlpSnapshot2, 2)
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSnapshot2.Controls.Add(Me.GroupBox2, 1, 0)
        Me.tlpSnapshot2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.tlpSnapshot2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapshot2.Location = New System.Drawing.Point(3, 55)
        Me.tlpSnapshot2.Name = "tlpSnapshot2"
        Me.tlpSnapshot2.RowCount = 2
        Me.tlpSnapshot2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapshot2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot2.Size = New System.Drawing.Size(888, 421)
        Me.tlpSnapshot2.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox2.AlignString = System.Drawing.StringAlignment.Near
        Me.GroupBox2.Controls.Add(Me.tlpBaseline)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.EdgeRound = Edges1
        Me.GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Icon = CType(resources.GetObject("GroupBox2.Icon"), System.Drawing.Icon)
        Me.GroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox2.LineWidth = 1
        Me.GroupBox2.Location = New System.Drawing.Point(247, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tlpSnapshot2.SetRowSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(637, 413)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox2.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.UseGraColor = False
        Me.GroupBox2.UseRound = True
        Me.GroupBox2.UseTitle = False
        '
        'tlpBaseline
        '
        Me.tlpBaseline.BackColor = System.Drawing.Color.Transparent
        Me.tlpBaseline.ColumnCount = 1
        Me.tlpBaseline.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBaseline.Controls.Add(Me.dgvBaselineList, 0, 1)
        Me.tlpBaseline.Controls.Add(Me.tlpBaselineHead, 0, 0)
        Me.tlpBaseline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBaseline.Location = New System.Drawing.Point(3, 14)
        Me.tlpBaseline.Name = "tlpBaseline"
        Me.tlpBaseline.RowCount = 2
        Me.tlpBaseline.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpBaseline.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBaseline.Size = New System.Drawing.Size(631, 396)
        Me.tlpBaseline.TabIndex = 30
        '
        'dgvBaselineList
        '
        Me.dgvBaselineList.AllowUserToAddRows = False
        Me.dgvBaselineList.AllowUserToDeleteRows = False
        Me.dgvBaselineList.AllowUserToOrderColumns = True
        Me.dgvBaselineList.AllowUserToResizeColumns = False
        Me.dgvBaselineList.AllowUserToResizeRows = False
        Me.dgvBaselineList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvBaselineList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBaselineList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBaselineList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBaselineList.ColumnHeadersHeight = 30
        Me.dgvBaselineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBaselineList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDGVBLBaseline, Me.colDGVBLMinSnap, Me.colDGVBLFrom, Me.colDGVBLMaxSnap, Me.colDGVBLTo, Me.colDGVBLKeepTime, Me.colDGVBLEdit, Me.colDGVBLDelete})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBaselineList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBaselineList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBaselineList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvBaselineList.EnableHeadersVisualStyles = False
        Me.dgvBaselineList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvBaselineList.GridColor = System.Drawing.Color.Black
        Me.dgvBaselineList.Location = New System.Drawing.Point(3, 38)
        Me.dgvBaselineList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBaselineList.Name = "dgvBaselineList"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBaselineList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBaselineList.RowHeadersVisible = False
        Me.dgvBaselineList.RowTemplate.Height = 23
        Me.dgvBaselineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBaselineList.Size = New System.Drawing.Size(625, 354)
        Me.dgvBaselineList.TabIndex = 31
        Me.dgvBaselineList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvBaselineList.UseTagValueMatchColor = False
        '
        'colDGVBLBaseline
        '
        Me.colDGVBLBaseline.DataPropertyName = "BASELINE"
        Me.colDGVBLBaseline.Frozen = True
        Me.colDGVBLBaseline.HeaderText = "Baseline"
        Me.colDGVBLBaseline.Name = "colDGVBLBaseline"
        Me.colDGVBLBaseline.ReadOnly = True
        Me.colDGVBLBaseline.Width = 70
        '
        'colDGVBLMinSnap
        '
        Me.colDGVBLMinSnap.DataPropertyName = "MIN_SNAP"
        Me.colDGVBLMinSnap.HeaderText = "Min_snap"
        Me.colDGVBLMinSnap.Name = "colDGVBLMinSnap"
        Me.colDGVBLMinSnap.ReadOnly = True
        Me.colDGVBLMinSnap.Width = 65
        '
        'colDGVBLFrom
        '
        Me.colDGVBLFrom.DataPropertyName = "MIN_SNAP_TIME"
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        Me.colDGVBLFrom.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDGVBLFrom.HeaderText = "From"
        Me.colDGVBLFrom.Name = "colDGVBLFrom"
        Me.colDGVBLFrom.ReadOnly = True
        Me.colDGVBLFrom.Width = 115
        '
        'colDGVBLMaxSnap
        '
        Me.colDGVBLMaxSnap.DataPropertyName = "MAX_SNAP"
        Me.colDGVBLMaxSnap.HeaderText = "Max_snap"
        Me.colDGVBLMaxSnap.Name = "colDGVBLMaxSnap"
        Me.colDGVBLMaxSnap.ReadOnly = True
        Me.colDGVBLMaxSnap.Width = 65
        '
        'colDGVBLTo
        '
        Me.colDGVBLTo.DataPropertyName = "MAX_SNAP_TIME"
        DataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss"
        Me.colDGVBLTo.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDGVBLTo.HeaderText = "To"
        Me.colDGVBLTo.Name = "colDGVBLTo"
        Me.colDGVBLTo.ReadOnly = True
        Me.colDGVBLTo.Width = 115
        '
        'colDGVBLKeepTime
        '
        Me.colDGVBLKeepTime.DataPropertyName = "KEEP_UNTIL_TIME"
        DataGridViewCellStyle4.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colDGVBLKeepTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDGVBLKeepTime.HeaderText = "KeepUntilTime"
        Me.colDGVBLKeepTime.Name = "colDGVBLKeepTime"
        Me.colDGVBLKeepTime.ReadOnly = True
        Me.colDGVBLKeepTime.Width = 115
        '
        'colDGVBLEdit
        '
        Me.colDGVBLEdit.HeaderText = ""
        Me.colDGVBLEdit.Image = CType(resources.GetObject("colDGVBLEdit.Image"), System.Drawing.Image)
        Me.colDGVBLEdit.Name = "colDGVBLEdit"
        Me.colDGVBLEdit.ReadOnly = True
        Me.colDGVBLEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDGVBLEdit.Width = 30
        '
        'colDGVBLDelete
        '
        Me.colDGVBLDelete.HeaderText = ""
        Me.colDGVBLDelete.Image = CType(resources.GetObject("colDGVBLDelete.Image"), System.Drawing.Image)
        Me.colDGVBLDelete.Name = "colDGVBLDelete"
        Me.colDGVBLDelete.ReadOnly = True
        Me.colDGVBLDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDGVBLDelete.Width = 30
        '
        'tlpBaselineHead
        '
        Me.tlpBaselineHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tlpBaselineHead.ColumnCount = 3
        Me.tlpBaselineHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpBaselineHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBaselineHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpBaselineHead.Controls.Add(Me.btnAddBaseline, 2, 0)
        Me.tlpBaselineHead.Controls.Add(Me.lblBaselineIcon, 0, 0)
        Me.tlpBaselineHead.Controls.Add(Me.lblBaseline, 1, 0)
        Me.tlpBaselineHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBaselineHead.Location = New System.Drawing.Point(3, 3)
        Me.tlpBaselineHead.Name = "tlpBaselineHead"
        Me.tlpBaselineHead.RowCount = 1
        Me.tlpBaselineHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBaselineHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpBaselineHead.Size = New System.Drawing.Size(625, 28)
        Me.tlpBaselineHead.TabIndex = 30
        '
        'btnAddBaseline
        '
        Me.btnAddBaseline.BackColor = System.Drawing.Color.Silver
        Me.btnAddBaseline.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddBaseline.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddBaseline.FixedHeight = False
        Me.btnAddBaseline.FixedWidth = False
        Me.btnAddBaseline.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnAddBaseline.ForeColor = System.Drawing.Color.Red
        Me.btnAddBaseline.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddBaseline.Image = CType(resources.GetObject("btnAddBaseline.Image"), System.Drawing.Image)
        Me.btnAddBaseline.LineColor = System.Drawing.Color.LightGray
        Me.btnAddBaseline.Location = New System.Drawing.Point(585, 0)
        Me.btnAddBaseline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddBaseline.Name = "btnAddBaseline"
        Me.btnAddBaseline.Radius = 5
        Me.btnAddBaseline.Size = New System.Drawing.Size(36, 28)
        Me.btnAddBaseline.TabIndex = 5
        Me.btnAddBaseline.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddBaseline.UseVisualStyleBackColor = True
        '
        'lblBaselineIcon
        '
        Me.lblBaselineIcon.AutoSize = True
        Me.lblBaselineIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBaselineIcon.Image = CType(resources.GetObject("lblBaselineIcon.Image"), System.Drawing.Image)
        Me.lblBaselineIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBaselineIcon.Location = New System.Drawing.Point(3, 0)
        Me.lblBaselineIcon.Name = "lblBaselineIcon"
        Me.lblBaselineIcon.Size = New System.Drawing.Size(34, 28)
        Me.lblBaselineIcon.TabIndex = 2
        Me.lblBaselineIcon.Text = "      "
        '
        'lblBaseline
        '
        Me.lblBaseline.AutoSize = True
        Me.lblBaseline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBaseline.ForeColor = System.Drawing.Color.White
        Me.lblBaseline.Location = New System.Drawing.Point(43, 0)
        Me.lblBaseline.Name = "lblBaseline"
        Me.lblBaseline.Size = New System.Drawing.Size(539, 28)
        Me.lblBaseline.TabIndex = 3
        Me.lblBaseline.Text = "Baseline"
        Me.lblBaseline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox1.AlignString = System.Drawing.StringAlignment.Near
        Me.GroupBox1.Controls.Add(Me.tlpSvrChk)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.EdgeRound = Edges2
        Me.GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Icon = CType(resources.GetObject("GroupBox1.Icon"), System.Drawing.Icon)
        Me.GroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.LineWidth = 1
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tlpSnapshot2.SetRowSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(235, 413)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox1.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.UseGraColor = False
        Me.GroupBox1.UseRound = True
        Me.GroupBox1.UseTitle = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 1
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229.0!))
        Me.tlpSvrChk.Controls.Add(Me.dgvSnapshotList, 0, 1)
        Me.tlpSvrChk.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 14)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 2
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(229, 396)
        Me.tlpSvrChk.TabIndex = 30
        '
        'dgvSnapshotList
        '
        Me.dgvSnapshotList.AllowUserToAddRows = False
        Me.dgvSnapshotList.AllowUserToDeleteRows = False
        Me.dgvSnapshotList.AllowUserToOrderColumns = True
        Me.dgvSnapshotList.AllowUserToResizeColumns = False
        Me.dgvSnapshotList.AllowUserToResizeRows = False
        Me.dgvSnapshotList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSnapshotList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSnapshotList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSnapshotList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSnapshotList.ColumnHeadersHeight = 30
        Me.dgvSnapshotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSnapshotList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvSnapshotListSnapshotQ, Me.colDgvSnapshotListTimeQ})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSnapshotList.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSnapshotList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSnapshotList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSnapshotList.EnableHeadersVisualStyles = False
        Me.dgvSnapshotList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvSnapshotList.GridColor = System.Drawing.Color.Black
        Me.dgvSnapshotList.Location = New System.Drawing.Point(3, 38)
        Me.dgvSnapshotList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSnapshotList.Name = "dgvSnapshotList"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSnapshotList.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSnapshotList.RowHeadersVisible = False
        Me.dgvSnapshotList.RowTemplate.Height = 23
        Me.dgvSnapshotList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSnapshotList.Size = New System.Drawing.Size(223, 354)
        Me.dgvSnapshotList.TabIndex = 31
        Me.dgvSnapshotList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvSnapshotList.UseTagValueMatchColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSnapshot, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSnapshotIcon, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAccountPolicy, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(223, 28)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'btnSnapshot
        '
        Me.btnSnapshot.BackColor = System.Drawing.Color.Silver
        Me.btnSnapshot.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSnapshot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSnapshot.FixedHeight = False
        Me.btnSnapshot.FixedWidth = False
        Me.btnSnapshot.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnSnapshot.ForeColor = System.Drawing.Color.Red
        Me.btnSnapshot.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSnapshot.Image = CType(resources.GetObject("btnSnapshot.Image"), System.Drawing.Image)
        Me.btnSnapshot.LineColor = System.Drawing.Color.LightGray
        Me.btnSnapshot.Location = New System.Drawing.Point(183, 0)
        Me.btnSnapshot.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapshot.Name = "btnSnapshot"
        Me.btnSnapshot.Radius = 5
        Me.btnSnapshot.Size = New System.Drawing.Size(40, 28)
        Me.btnSnapshot.TabIndex = 4
        Me.btnSnapshot.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSnapshot.UseVisualStyleBackColor = True
        '
        'lblSnapshotIcon
        '
        Me.lblSnapshotIcon.AutoSize = True
        Me.lblSnapshotIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSnapshotIcon.Image = CType(resources.GetObject("lblSnapshotIcon.Image"), System.Drawing.Image)
        Me.lblSnapshotIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSnapshotIcon.Location = New System.Drawing.Point(3, 0)
        Me.lblSnapshotIcon.Name = "lblSnapshotIcon"
        Me.lblSnapshotIcon.Size = New System.Drawing.Size(34, 28)
        Me.lblSnapshotIcon.TabIndex = 2
        Me.lblSnapshotIcon.Text = "      "
        '
        'lblAccountPolicy
        '
        Me.lblAccountPolicy.AutoSize = True
        Me.lblAccountPolicy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAccountPolicy.ForeColor = System.Drawing.Color.White
        Me.lblAccountPolicy.Location = New System.Drawing.Point(43, 0)
        Me.lblAccountPolicy.Name = "lblAccountPolicy"
        Me.lblAccountPolicy.Size = New System.Drawing.Size(137, 28)
        Me.lblAccountPolicy.TabIndex = 3
        Me.lblAccountPolicy.Text = "Snapshot"
        Me.lblAccountPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpCluster
        '
        Me.tlpCluster.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpCluster.ColumnCount = 5
        Me.tlpSnapShot.SetColumnSpan(Me.tlpCluster, 2)
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCluster.Controls.Add(Me.cmbClusters, 1, 1)
        Me.tlpCluster.Controls.Add(Me.lblCluster, 0, 1)
        Me.tlpCluster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCluster.Location = New System.Drawing.Point(3, 3)
        Me.tlpCluster.Name = "tlpCluster"
        Me.tlpCluster.RowCount = 3
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpCluster.Size = New System.Drawing.Size(888, 46)
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
        Me.cmbClusters.Location = New System.Drawing.Point(113, 14)
        Me.cmbClusters.Name = "cmbClusters"
        Me.cmbClusters.Necessary = False
        Me.cmbClusters.Size = New System.Drawing.Size(154, 20)
        Me.cmbClusters.StatusTip = ""
        Me.cmbClusters.TabIndex = 34
        Me.cmbClusters.ValueText = ""
        '
        'lblCluster
        '
        Me.lblCluster.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCluster.FixedWidth = False
        Me.lblCluster.LineSpacing = 0.0!
        Me.lblCluster.Location = New System.Drawing.Point(3, 14)
        Me.lblCluster.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblCluster.Name = "lblCluster"
        Me.lblCluster.Size = New System.Drawing.Size(104, 21)
        Me.lblCluster.TabIndex = 33
        Me.lblCluster.Text = "Cluster"
        Me.lblCluster.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlpSnapShot
        '
        Me.tlpSnapShot.ColumnCount = 2
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.Controls.Add(Me.tlpCluster, 0, 0)
        Me.tlpSnapShot.Controls.Add(Me.tlpSnapshot2, 0, 1)
        Me.tlpSnapShot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapShot.Location = New System.Drawing.Point(3, 53)
        Me.tlpSnapShot.Name = "tlpSnapShot"
        Me.tlpSnapShot.RowCount = 3
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 427.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSnapShot.Size = New System.Drawing.Size(894, 488)
        Me.tlpSnapShot.TabIndex = 16
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'colDgvSnapshotListSnapshotQ
        '
        Me.colDgvSnapshotListSnapshotQ.DataPropertyName = "SNAPSHOT"
        Me.colDgvSnapshotListSnapshotQ.HeaderText = "Snapshot"
        Me.colDgvSnapshotListSnapshotQ.Name = "colDgvSnapshotListSnapshotQ"
        Me.colDgvSnapshotListSnapshotQ.ReadOnly = True
        Me.colDgvSnapshotListSnapshotQ.Width = 70
        '
        'colDgvSnapshotListTimeQ
        '
        Me.colDgvSnapshotListTimeQ.DataPropertyName = "DATE_TIME"
        DataGridViewCellStyle8.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colDgvSnapshotListTimeQ.DefaultCellStyle = DataGridViewCellStyle8
        Me.colDgvSnapshotListTimeQ.HeaderText = "SnapshotTime"
        Me.colDgvSnapshotListTimeQ.Name = "colDgvSnapshotListTimeQ"
        Me.colDgvSnapshotListTimeQ.ReadOnly = True
        Me.colDgvSnapshotListTimeQ.Width = 130
        '
        'frmSnapshot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 544)
        Me.Controls.Add(Me.tlpSnapShot)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSnapshot"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Snapshot"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tlpSnapshot2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.tlpBaseline.ResumeLayout(False)
        CType(Me.dgvBaselineList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpBaselineHead.ResumeLayout(False)
        Me.tlpBaselineHead.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        CType(Me.dgvSnapshotList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpCluster.ResumeLayout(False)
        Me.tlpSnapShot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tlpSnapShot As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpCluster As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbClusters As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblCluster As eXperDB.BaseControls.Label
    Friend WithEvents tlpSnapshot2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As eXperDB.BaseControls.GroupBox
    Friend WithEvents GroupBox1 As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSnapshotIcon As System.Windows.Forms.Label
    Friend WithEvents lblAccountPolicy As System.Windows.Forms.Label
    Friend WithEvents dgvSnapshotList As eXperDB.BaseControls.DataGridView
    Friend WithEvents btnSnapshot As eXperDB.BaseControls.Button
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents tlpBaseline As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpBaselineHead As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddBaseline As eXperDB.BaseControls.Button
    Friend WithEvents lblBaselineIcon As System.Windows.Forms.Label
    Friend WithEvents lblBaseline As System.Windows.Forms.Label
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvBaselineList As eXperDB.BaseControls.DataGridView
    Friend WithEvents colDGVBLBaseline As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBLMinSnap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBLFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBLMaxSnap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBLTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBLKeepTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBLEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colDGVBLDelete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colDgvSnapshotListSnapshotQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvSnapshotListTimeQ As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
