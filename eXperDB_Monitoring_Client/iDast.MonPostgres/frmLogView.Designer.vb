<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
        Me.btnRefresh = New eXperDB.BaseControls.Button()
        Me.dgvLogFileList = New eXperDB.BaseControls.DataGridView()
        Me.coldgvLogFileListName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvLogFileListTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvLogFileListSize = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.dgvLogData = New eXperDB.BaseControls.DataGridView()
        Me.coldgvLogData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLogReadUnit = New eXperDB.BaseControls.Label()
        Me.btnMore = New eXperDB.BaseControls.Button()
        Me.cboLogReadUnit = New eXperDB.BaseControls.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.FileTotalSize = New eXperDB.BaseControls.Label()
        Me.FileTotalCnt_lv = New eXperDB.BaseControls.Label()
        Me.FileTotalCnt = New eXperDB.BaseControls.Label()
        Me.FileTotalSize_lv = New eXperDB.BaseControls.Label()
        Me.RefreshTime = New eXperDB.BaseControls.Label()
        Me.RefreshTime_lv = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpLogFileList = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpLogview = New System.Windows.Forms.Label()
        CType(Me.dgvLogFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLogData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Silver
        Me.btnRefresh.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRefresh.FixedHeight = False
        Me.btnRefresh.FixedWidth = False
        Me.btnRefresh.Font = New System.Drawing.Font("굴림", 9.980699!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.LightGray
        Me.btnRefresh.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(309, 4)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Radius = 5
        Me.btnRefresh.Size = New System.Drawing.Size(34, 32)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvLogFileList
        '
        Me.dgvLogFileList.AllowUserToAddRows = False
        Me.dgvLogFileList.AllowUserToDeleteRows = False
        Me.dgvLogFileList.AllowUserToOrderColumns = True
        Me.dgvLogFileList.AllowUserToResizeRows = False
        Me.dgvLogFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLogFileList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLogFileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 10.07346!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLogFileList.ColumnHeadersHeight = 30
        Me.dgvLogFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLogFileList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvLogFileListName, Me.coldgvLogFileListTime, Me.coldgvLogFileListSize})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 10.07346!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogFileList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLogFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogFileList.EnableHeadersVisualStyles = False
        Me.dgvLogFileList.Font = New System.Drawing.Font("굴림", 10.07346!)
        Me.dgvLogFileList.GridColor = System.Drawing.Color.Gray
        Me.dgvLogFileList.Location = New System.Drawing.Point(0, 157)
        Me.dgvLogFileList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLogFileList.MultiSelect = False
        Me.dgvLogFileList.Name = "dgvLogFileList"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLogFileList.RowHeadersVisible = False
        Me.dgvLogFileList.RowTemplate.Height = 23
        Me.dgvLogFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogFileList.Size = New System.Drawing.Size(346, 347)
        Me.dgvLogFileList.TabIndex = 12
        Me.dgvLogFileList.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvLogFileList.UseTagValueMatchColor = True
        '
        'coldgvLogFileListName
        '
        Me.coldgvLogFileListName.DataPropertyName = "LOGNAME"
        Me.coldgvLogFileListName.HeaderText = "F237"
        Me.coldgvLogFileListName.Name = "coldgvLogFileListName"
        Me.coldgvLogFileListName.ReadOnly = True
        Me.coldgvLogFileListName.Visible = False
        Me.coldgvLogFileListName.Width = 64
        '
        'coldgvLogFileListTime
        '
        Me.coldgvLogFileListTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvLogFileListTime.DataPropertyName = "LOGTIME"
        Me.coldgvLogFileListTime.HeaderText = "F237"
        Me.coldgvLogFileListTime.Name = "coldgvLogFileListTime"
        Me.coldgvLogFileListTime.ReadOnly = True
        '
        'coldgvLogFileListSize
        '
        Me.coldgvLogFileListSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvLogFileListSize.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.Bytes
        Me.coldgvLogFileListSize.DataPropertyName = "LOGLENGTH"
        DataGridViewCellStyle2.Format = "N1"
        Me.coldgvLogFileListSize.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvLogFileListSize.HeaderText = "F238"
        Me.coldgvLogFileListSize.HeaderWord = ""
        Me.coldgvLogFileListSize.Name = "coldgvLogFileListSize"
        Me.coldgvLogFileListSize.ReadOnly = True
        Me.coldgvLogFileListSize.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvLogFileListSize.ShowUnit = True
        Me.coldgvLogFileListSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvLogFileListSize.TailWord = ""
        '
        'dgvLogData
        '
        Me.dgvLogData.AllowUserToAddRows = False
        Me.dgvLogData.AllowUserToDeleteRows = False
        Me.dgvLogData.AllowUserToOrderColumns = True
        Me.dgvLogData.AllowUserToResizeRows = False
        Me.dgvLogData.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLogData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("굴림", 9.066109!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvLogData})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("굴림", 9.066109!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogData.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLogData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogData.EnableHeadersVisualStyles = False
        Me.dgvLogData.Font = New System.Drawing.Font("굴림", 9.066109!)
        Me.dgvLogData.GridColor = System.Drawing.Color.Black
        Me.dgvLogData.Location = New System.Drawing.Point(0, 40)
        Me.dgvLogData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLogData.Name = "dgvLogData"
        Me.dgvLogData.RowHeadersVisible = False
        Me.dgvLogData.RowTemplate.Height = 23
        Me.dgvLogData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogData.Size = New System.Drawing.Size(754, 464)
        Me.dgvLogData.TabIndex = 13
        Me.dgvLogData.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvLogData.UseTagValueMatchColor = False
        '
        'coldgvLogData
        '
        Me.coldgvLogData.DataPropertyName = "LOGNAME"
        Me.coldgvLogData.HeaderText = "F239"
        Me.coldgvLogData.Name = "coldgvLogData"
        Me.coldgvLogData.ReadOnly = True
        Me.coldgvLogData.Width = 59
        '
        'lblLogReadUnit
        '
        Me.lblLogReadUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblLogReadUnit.FixedHeight = False
        Me.lblLogReadUnit.FixedWidth = False
        Me.lblLogReadUnit.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogReadUnit.ForeColor = System.Drawing.Color.White
        Me.lblLogReadUnit.Location = New System.Drawing.Point(437, 0)
        Me.lblLogReadUnit.Name = "lblLogReadUnit"
        Me.lblLogReadUnit.Size = New System.Drawing.Size(114, 40)
        Me.lblLogReadUnit.TabIndex = 17
        Me.lblLogReadUnit.Text = "F241"
        Me.lblLogReadUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnMore.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMore.FixedHeight = False
        Me.btnMore.FixedWidth = False
        Me.btnMore.Font = New System.Drawing.Font("굴림", 9.980699!)
        Me.btnMore.ForeColor = System.Drawing.Color.LightGray
        Me.btnMore.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMore.Image = CType(resources.GetObject("btnMore.Image"), System.Drawing.Image)
        Me.btnMore.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnMore.Location = New System.Drawing.Point(717, 4)
        Me.btnMore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Radius = 5
        Me.btnMore.Size = New System.Drawing.Size(34, 32)
        Me.btnMore.TabIndex = 15
        Me.btnMore.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'cboLogReadUnit
        '
        Me.cboLogReadUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboLogReadUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboLogReadUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogReadUnit.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboLogReadUnit.FormattingEnabled = True
        Me.cboLogReadUnit.Location = New System.Drawing.Point(557, 4)
        Me.cboLogReadUnit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboLogReadUnit.Name = "cboLogReadUnit"
        Me.cboLogReadUnit.Necessary = False
        Me.cboLogReadUnit.Size = New System.Drawing.Size(150, 20)
        Me.cboLogReadUnit.StatusTip = ""
        Me.cboLogReadUnit.TabIndex = 15
        Me.cboLogReadUnit.ValueText = ""
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1104, 50)
        Me.TableLayoutPanel3.TabIndex = 21
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
        Me.MsgLabel.Size = New System.Drawing.Size(598, 50)
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvLogFileList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvLogData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1104, 504)
        Me.SplitContainer1.SplitterDistance = 346
        Me.SplitContainer1.TabIndex = 22
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26175!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.73825!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.FileTotalSize, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.FileTotalCnt_lv, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.FileTotalCnt, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.FileTotalSize_lv, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.RefreshTime, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.RefreshTime_lv, 2, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(346, 117)
        Me.TableLayoutPanel5.TabIndex = 13
        '
        'FileTotalSize
        '
        Me.FileTotalSize.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FileTotalSize.FixedHeight = False
        Me.FileTotalSize.FixedWidth = False
        Me.FileTotalSize.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FileTotalSize.ForeColor = System.Drawing.Color.White
        Me.FileTotalSize.Location = New System.Drawing.Point(18, 40)
        Me.FileTotalSize.Name = "FileTotalSize"
        Me.FileTotalSize.Size = New System.Drawing.Size(110, 30)
        Me.FileTotalSize.TabIndex = 14
        Me.FileTotalSize.Text = "F901"
        Me.FileTotalSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FileTotalCnt_lv
        '
        Me.FileTotalCnt_lv.BackColor = System.Drawing.Color.Transparent
        Me.FileTotalCnt_lv.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.FileTotalCnt_lv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FileTotalCnt_lv.FixedHeight = False
        Me.FileTotalCnt_lv.FixedWidth = False
        Me.FileTotalCnt_lv.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FileTotalCnt_lv.ForeColor = System.Drawing.Color.Yellow
        Me.FileTotalCnt_lv.Location = New System.Drawing.Point(134, 10)
        Me.FileTotalCnt_lv.Name = "FileTotalCnt_lv"
        Me.FileTotalCnt_lv.Size = New System.Drawing.Size(174, 30)
        Me.FileTotalCnt_lv.TabIndex = 2
        Me.FileTotalCnt_lv.Text = "-"
        Me.FileTotalCnt_lv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FileTotalCnt
        '
        Me.FileTotalCnt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FileTotalCnt.FixedHeight = False
        Me.FileTotalCnt.FixedWidth = False
        Me.FileTotalCnt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FileTotalCnt.ForeColor = System.Drawing.Color.White
        Me.FileTotalCnt.Location = New System.Drawing.Point(18, 10)
        Me.FileTotalCnt.Name = "FileTotalCnt"
        Me.FileTotalCnt.Size = New System.Drawing.Size(110, 30)
        Me.FileTotalCnt.TabIndex = 3
        Me.FileTotalCnt.Text = "F900"
        Me.FileTotalCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FileTotalSize_lv
        '
        Me.FileTotalSize_lv.BackColor = System.Drawing.Color.Transparent
        Me.FileTotalSize_lv.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.FileTotalSize_lv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FileTotalSize_lv.FixedHeight = False
        Me.FileTotalSize_lv.FixedWidth = False
        Me.FileTotalSize_lv.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FileTotalSize_lv.ForeColor = System.Drawing.Color.Yellow
        Me.FileTotalSize_lv.Location = New System.Drawing.Point(134, 40)
        Me.FileTotalSize_lv.Name = "FileTotalSize_lv"
        Me.FileTotalSize_lv.Size = New System.Drawing.Size(174, 30)
        Me.FileTotalSize_lv.TabIndex = 15
        Me.FileTotalSize_lv.Text = "-"
        Me.FileTotalSize_lv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RefreshTime
        '
        Me.RefreshTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RefreshTime.FixedHeight = False
        Me.RefreshTime.FixedWidth = False
        Me.RefreshTime.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RefreshTime.ForeColor = System.Drawing.Color.White
        Me.RefreshTime.Location = New System.Drawing.Point(18, 70)
        Me.RefreshTime.Name = "RefreshTime"
        Me.RefreshTime.Size = New System.Drawing.Size(110, 30)
        Me.RefreshTime.TabIndex = 16
        Me.RefreshTime.Text = "F902"
        Me.RefreshTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RefreshTime_lv
        '
        Me.RefreshTime_lv.BackColor = System.Drawing.Color.Transparent
        Me.RefreshTime_lv.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.RefreshTime_lv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RefreshTime_lv.FixedHeight = False
        Me.RefreshTime_lv.FixedWidth = False
        Me.RefreshTime_lv.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RefreshTime_lv.ForeColor = System.Drawing.Color.Yellow
        Me.RefreshTime_lv.Location = New System.Drawing.Point(134, 70)
        Me.RefreshTime_lv.Name = "RefreshTime_lv"
        Me.RefreshTime_lv.Size = New System.Drawing.Size(174, 30)
        Me.RefreshTime_lv.TabIndex = 17
        Me.RefreshTime_lv.Text = "-"
        Me.RefreshTime_lv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnRefresh, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.grpLogFileList, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(346, 40)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "      "
        '
        'grpLogFileList
        '
        Me.grpLogFileList.AutoSize = True
        Me.grpLogFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLogFileList.ForeColor = System.Drawing.Color.White
        Me.grpLogFileList.Location = New System.Drawing.Point(43, 0)
        Me.grpLogFileList.Name = "grpLogFileList"
        Me.grpLogFileList.Size = New System.Drawing.Size(260, 40)
        Me.grpLogFileList.TabIndex = 3
        Me.grpLogFileList.Text = "F235"
        Me.grpLogFileList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnMore, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblLogReadUnit, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.grpLogview, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cboLogReadUnit, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(754, 40)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "      "
        '
        'grpLogview
        '
        Me.grpLogview.AutoSize = True
        Me.grpLogview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLogview.ForeColor = System.Drawing.Color.White
        Me.grpLogview.Location = New System.Drawing.Point(43, 0)
        Me.grpLogview.Name = "grpLogview"
        Me.grpLogview.Size = New System.Drawing.Size(388, 40)
        Me.grpLogview.TabIndex = 3
        Me.grpLogview.Text = "F236"
        Me.grpLogview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLogView
        '
        Me.ClientSize = New System.Drawing.Size(1104, 554)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmLogView"
        Me.Text = "Log Viewer"
        CType(Me.dgvLogFileList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLogData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRefresh As eXperDB.BaseControls.Button
    Friend WithEvents dgvLogFileList As eXperDB.BaseControls.DataGridView
    Friend WithEvents dgvLogData As eXperDB.BaseControls.DataGridView
    Friend WithEvents coldgvLogData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLogReadUnit As eXperDB.BaseControls.Label
    Friend WithEvents btnMore As eXperDB.BaseControls.Button
    Friend WithEvents cboLogReadUnit As eXperDB.BaseControls.ComboBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpLogFileList As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpLogview As System.Windows.Forms.Label
    Friend WithEvents FileTotalCnt_lv As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FileTotalSize As eXperDB.BaseControls.Label
    Friend WithEvents FileTotalCnt As eXperDB.BaseControls.Label
    Friend WithEvents FileTotalSize_lv As eXperDB.BaseControls.Label
    Friend WithEvents coldgvLogFileListName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvLogFileListTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvLogFileListSize As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents RefreshTime As eXperDB.BaseControls.Label
    Friend WithEvents RefreshTime_lv As eXperDB.BaseControls.Label

End Class
