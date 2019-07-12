<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClusterShow
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClusterShow))
        Me.tlpList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnApply = New eXperDB.BaseControls.Button()
        Me.dgvClusterList = New AdvancedDataGridView.TreeGridView()
        Me.coldgvClusterListShowName = New AdvancedDataGridView.TreeGridColumn()
        Me.coldgvClusterListSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.coldgvClusterListHostName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpList.SuspendLayout()
        CType(Me.dgvClusterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpList
        '
        Me.tlpList.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpList.ColumnCount = 6
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpList.Controls.Add(Me.btnClose, 3, 1)
        Me.tlpList.Controls.Add(Me.btnApply, 2, 1)
        Me.tlpList.Controls.Add(Me.dgvClusterList, 1, 0)
        Me.tlpList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpList.Font = New System.Drawing.Font("Gulim", 12.27167!)
        Me.tlpList.Location = New System.Drawing.Point(0, 50)
        Me.tlpList.Name = "tlpList"
        Me.tlpList.RowCount = 2
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.Size = New System.Drawing.Size(288, 404)
        Me.tlpList.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(147, 368)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 5
        Me.btnClose.Size = New System.Drawing.Size(94, 32)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApply.FixedHeight = False
        Me.btnApply.FixedWidth = False
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnApply.LineColor = System.Drawing.Color.Transparent
        Me.btnApply.Location = New System.Drawing.Point(47, 368)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Radius = 5
        Me.btnApply.Size = New System.Drawing.Size(94, 32)
        Me.btnApply.TabIndex = 26
        Me.btnApply.Text = "F014"
        Me.btnApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.UseRound = True
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'dgvClusterList
        '
        Me.dgvClusterList.AllowUserToAddRows = False
        Me.dgvClusterList.AllowUserToDeleteRows = False
        Me.dgvClusterList.AllowUserToOrderColumns = True
        Me.dgvClusterList.AllowUserToResizeRows = False
        Me.dgvClusterList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvClusterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClusterList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClusterList.ColumnHeadersHeight = 30
        Me.dgvClusterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClusterList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvClusterListShowName, Me.coldgvClusterListSel, Me.coldgvClusterListHostName})
        Me.tlpList.SetColumnSpan(Me.dgvClusterList, 4)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClusterList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClusterList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClusterList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvClusterList.EnableHeadersVisualStyles = False
        Me.dgvClusterList.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvClusterList.GridColor = System.Drawing.Color.Black
        Me.dgvClusterList.ImageList = Nothing
        Me.dgvClusterList.Location = New System.Drawing.Point(7, 4)
        Me.dgvClusterList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvClusterList.Name = "dgvClusterList"
        Me.dgvClusterList.RowHeadersVisible = False
        Me.dgvClusterList.RowHeadersWidth = 45
        Me.dgvClusterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvClusterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClusterList.ShowLines = False
        Me.dgvClusterList.Size = New System.Drawing.Size(274, 356)
        Me.dgvClusterList.TabIndex = 10
        '
        'coldgvClusterListShowName
        '
        Me.coldgvClusterListShowName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvClusterListShowName.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.coldgvClusterListShowName.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvClusterListShowName.DefaultNodeImage = Nothing
        Me.coldgvClusterListShowName.FillWeight = 131.1306!
        Me.coldgvClusterListShowName.HeaderText = "Select clusters"
        Me.coldgvClusterListShowName.MinimumWidth = 190
        Me.coldgvClusterListShowName.Name = "coldgvClusterListShowName"
        Me.coldgvClusterListShowName.ReadOnly = True
        Me.coldgvClusterListShowName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvClusterListShowName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coldgvClusterListSel
        '
        Me.coldgvClusterListSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvClusterListSel.DataPropertyName = "ACCESS_TYPE"
        Me.coldgvClusterListSel.FillWeight = 40.0!
        Me.coldgvClusterListSel.HeaderText = ""
        Me.coldgvClusterListSel.MinimumWidth = 40
        Me.coldgvClusterListSel.Name = "coldgvClusterListSel"
        Me.coldgvClusterListSel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvClusterListSel.Width = 40
        '
        'coldgvClusterListHostName
        '
        Me.coldgvClusterListHostName.HeaderText = ""
        Me.coldgvClusterListHostName.Name = "coldgvClusterListHostName"
        Me.coldgvClusterListHostName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvClusterListHostName.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(288, 50)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.BackColor = System.Drawing.Color.Transparent
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.ForeColor = System.Drawing.Color.White
        Me.MsgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(242, 50)
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.Text = "Text"
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'frmClusterShow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(288, 454)
        Me.Controls.Add(Me.tlpList)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "frmClusterShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clusters "
        Me.tlpList.ResumeLayout(False)
        CType(Me.dgvClusterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvClusterList As AdvancedDataGridView.TreeGridView
    Friend WithEvents tlpList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnApply As eXperDB.BaseControls.Button
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents coldgvClusterListShowName As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents coldgvClusterListHostName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvClusterListSel As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
