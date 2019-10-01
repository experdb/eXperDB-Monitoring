<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreferences))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.spPreference = New eXperDB.BaseControls.SplitContainer()
        Me.tlpMenu = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dgvMenu = New AdvancedDataGridView.TreeGridView()
        Me.coldgvMenuname = New AdvancedDataGridView.TreeGridColumn()
        Me.pnlSpace = New eXperDB.BaseControls.Panel()
        Me.tlpMain = New eXperDB.BaseControls.TableLayoutPanel()
        Me.pnlSpace2 = New eXperDB.BaseControls.Panel()
        Me.tlpForms = New eXperDB.BaseControls.TableLayoutPanel()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.mnuMenu = New eXperDB.BaseControls.ContextMenuStrip()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.spPreference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spPreference.Panel1.SuspendLayout()
        Me.spPreference.Panel2.SuspendLayout()
        Me.spPreference.SuspendLayout()
        Me.tlpMenu.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1264, 50)
        Me.TableLayoutPanel2.TabIndex = 15
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
        Me.TableLayoutPanel2.SetRowSpan(Me.StatusLabel, 2)
        Me.StatusLabel.Size = New System.Drawing.Size(30, 50)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel2.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'mnuImgLst
        '
        Me.mnuImgLst.ImageStream = CType(resources.GetObject("mnuImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.mnuImgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.mnuImgLst.Images.SetKeyName(0, "bullet.png")
        Me.mnuImgLst.Images.SetKeyName(1, "user32.png")
        Me.mnuImgLst.Images.SetKeyName(2, "user24.png")
        Me.mnuImgLst.Images.SetKeyName(3, "btnAlertConfig.png")
        '
        'spPreference
        '
        Me.spPreference.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.spPreference.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spPreference.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spPreference.IsSplitterFixed = True
        Me.spPreference.Location = New System.Drawing.Point(0, 50)
        Me.spPreference.Name = "spPreference"
        '
        'spPreference.Panel1
        '
        Me.spPreference.Panel1.Controls.Add(Me.tlpMenu)
        Me.spPreference.Panel1MinSize = 200
        '
        'spPreference.Panel2
        '
        Me.spPreference.Panel2.Controls.Add(Me.tlpMain)
        Me.spPreference.Size = New System.Drawing.Size(1264, 702)
        Me.spPreference.SplitterDistance = 200
        Me.spPreference.SplitterWidth = 3
        Me.spPreference.TabIndex = 16
        Me.spPreference.TabStop = False
        '
        'tlpMenu
        '
        Me.tlpMenu.ColumnCount = 2
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMenu.Controls.Add(Me.dgvMenu, 0, 1)
        Me.tlpMenu.Controls.Add(Me.pnlSpace, 0, 0)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 2
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(200, 702)
        Me.tlpMenu.TabIndex = 19
        '
        'dgvMenu
        '
        Me.dgvMenu.AllowUserToAddRows = False
        Me.dgvMenu.AllowUserToDeleteRows = False
        Me.dgvMenu.AllowUserToResizeRows = False
        Me.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenu.ColumnHeadersHeight = 10
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvMenuname})
        Me.tlpMenu.SetColumnSpan(Me.dgvMenu, 2)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMenu.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMenu.EnableHeadersVisualStyles = False
        Me.dgvMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvMenu.HideExpandeIcon = False
        Me.dgvMenu.ImageList = Me.mnuImgLst
        Me.dgvMenu.Location = New System.Drawing.Point(3, 8)
        Me.dgvMenu.MultiSelect = False
        Me.dgvMenu.Name = "dgvMenu"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMenu.RowHeadersVisible = False
        Me.dgvMenu.ShowLines = False
        Me.dgvMenu.Size = New System.Drawing.Size(194, 691)
        Me.dgvMenu.TabIndex = 20
        Me.dgvMenu.TabStop = False
        '
        'coldgvMenuname
        '
        Me.coldgvMenuname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvMenuname.DefaultNodeImage = CType(resources.GetObject("coldgvMenuname.DefaultNodeImage"), System.Drawing.Image)
        Me.coldgvMenuname.HeaderText = ""
        Me.coldgvMenuname.Name = "coldgvMenuname"
        Me.coldgvMenuname.ReadOnly = True
        Me.coldgvMenuname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvMenuname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pnlSpace
        '
        Me.pnlSpace.BackColor = System.Drawing.Color.DarkBlue
        Me.tlpMenu.SetColumnSpan(Me.pnlSpace, 5)
        Me.pnlSpace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSpace.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSpace.Location = New System.Drawing.Point(3, 3)
        Me.pnlSpace.Name = "pnlSpace"
        Me.pnlSpace.Radius = 10
        Me.pnlSpace.Size = New System.Drawing.Size(194, 1)
        Me.pnlSpace.TabIndex = 21
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 4
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.pnlSpace2, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpForms, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1061, 702)
        Me.tlpMain.TabIndex = 0
        '
        'pnlSpace2
        '
        Me.pnlSpace2.BackColor = System.Drawing.Color.DarkBlue
        Me.tlpMain.SetColumnSpan(Me.pnlSpace2, 5)
        Me.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSpace2.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSpace2.Location = New System.Drawing.Point(3, 3)
        Me.pnlSpace2.Name = "pnlSpace2"
        Me.pnlSpace2.Radius = 10
        Me.pnlSpace2.Size = New System.Drawing.Size(1055, 1)
        Me.pnlSpace2.TabIndex = 22
        '
        'tlpForms
        '
        Me.tlpForms.AutoSize = True
        Me.tlpForms.ColumnCount = 1
        Me.tlpMain.SetColumnSpan(Me.tlpForms, 4)
        Me.tlpForms.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpForms.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForms.Location = New System.Drawing.Point(0, 5)
        Me.tlpForms.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForms.Name = "tlpForms"
        Me.tlpForms.RowCount = 1
        Me.tlpForms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpForms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpForms.Size = New System.Drawing.Size(1061, 695)
        Me.tlpForms.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 752)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1264, 10)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'mnuMenu
        '
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout, Me.mnuPreferences, Me.mnuVersion})
        Me.mnuMenu.Name = "mnuPopup"
        Me.mnuMenu.Size = New System.Drawing.Size(140, 82)
        '
        'mnuLogout
        '
        Me.mnuLogout.BackColor = System.Drawing.SystemColors.Control
        Me.mnuLogout.Image = CType(resources.GetObject("mnuLogout.Image"), System.Drawing.Image)
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(139, 26)
        Me.mnuLogout.Text = "Logout"
        '
        'mnuPreferences
        '
        Me.mnuPreferences.Image = CType(resources.GetObject("mnuPreferences.Image"), System.Drawing.Image)
        Me.mnuPreferences.Name = "mnuPreferences"
        Me.mnuPreferences.Size = New System.Drawing.Size(139, 26)
        Me.mnuPreferences.Text = "Preferences"
        '
        'mnuVersion
        '
        Me.mnuVersion.Image = CType(resources.GetObject("mnuVersion.Image"), System.Drawing.Image)
        Me.mnuVersion.Name = "mnuVersion"
        Me.mnuVersion.Size = New System.Drawing.Size(139, 26)
        Me.mnuVersion.Text = "Version"
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 762)
        Me.Controls.Add(Me.spPreference)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPreferences"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.spPreference.Panel1.ResumeLayout(False)
        Me.spPreference.Panel2.ResumeLayout(False)
        CType(Me.spPreference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spPreference.ResumeLayout(False)
        Me.tlpMenu.ResumeLayout(False)
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.mnuMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As eXperDB.BaseControls.ContextMenuStrip
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPreferences As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents spPreference As eXperDB.BaseControls.SplitContainer
    Friend WithEvents mnuImgLst As System.Windows.Forms.ImageList
    Friend WithEvents tlpMenu As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents dgvMenu As AdvancedDataGridView.TreeGridView
    Friend WithEvents coldgvMenuname As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents pnlSpace As eXperDB.BaseControls.Panel
    Friend WithEvents tlpMain As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents pnlSpace2 As eXperDB.BaseControls.Panel
    Friend WithEvents tlpForms As eXperDB.BaseControls.TableLayoutPanel
End Class
