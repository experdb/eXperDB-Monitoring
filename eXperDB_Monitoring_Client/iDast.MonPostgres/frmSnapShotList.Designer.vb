<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnapshotList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnapshotList))
        Me.tlpSnapshotList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.dgvSnapshotList = New eXperDB.BaseControls.DataGridView()
        Me.colDgvSnapshotListSnapshot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvSnapshotListTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBaselineList = New eXperDB.BaseControls.DataGridView()
        Me.colDGVBaselineListBaseLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBaselineListMinSnap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBaselineListFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBaselineListMaxSnap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBaselineListTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDGVBaselineListKeepTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpSnapshotList.SuspendLayout()
        CType(Me.dgvSnapshotList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBaselineList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpSnapshotList
        '
        Me.tlpSnapshotList.ColumnCount = 1
        Me.tlpSnapshotList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshotList.Controls.Add(Me.btnClose, 0, 1)
        Me.tlpSnapshotList.Controls.Add(Me.dgvSnapshotList, 0, 0)
        Me.tlpSnapshotList.Controls.Add(Me.dgvBaselineList, 0, 0)
        Me.tlpSnapshotList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapshotList.Location = New System.Drawing.Point(3, 3)
        Me.tlpSnapshotList.Name = "tlpSnapshotList"
        Me.tlpSnapshotList.RowCount = 2
        Me.tlpSnapshotList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshotList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSnapshotList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSnapshotList.Size = New System.Drawing.Size(283, 244)
        Me.tlpSnapshotList.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(190, 228)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 3
        Me.btnClose.Size = New System.Drawing.Size(90, 12)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSnapshotList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSnapshotList.ColumnHeadersHeight = 30
        Me.dgvSnapshotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSnapshotList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvSnapshotListSnapshot, Me.colDgvSnapshotListTime})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSnapshotList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSnapshotList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSnapshotList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSnapshotList.EnableHeadersVisualStyles = False
        Me.dgvSnapshotList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvSnapshotList.GridColor = System.Drawing.Color.Black
        Me.dgvSnapshotList.Location = New System.Drawing.Point(3, 193)
        Me.dgvSnapshotList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSnapshotList.Name = "dgvSnapshotList"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSnapshotList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSnapshotList.RowHeadersVisible = False
        Me.dgvSnapshotList.RowTemplate.Height = 23
        Me.dgvSnapshotList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSnapshotList.Size = New System.Drawing.Size(277, 27)
        Me.dgvSnapshotList.TabIndex = 17
        Me.dgvSnapshotList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvSnapshotList.UseTagValueMatchColor = False
        '
        'colDgvSnapshotListSnapshot
        '
        Me.colDgvSnapshotListSnapshot.DataPropertyName = "SNAPSHOT"
        Me.colDgvSnapshotListSnapshot.HeaderText = "Snapshot"
        Me.colDgvSnapshotListSnapshot.Name = "colDgvSnapshotListSnapshot"
        Me.colDgvSnapshotListSnapshot.ReadOnly = True
        Me.colDgvSnapshotListSnapshot.Width = 70
        '
        'colDgvSnapshotListTime
        '
        Me.colDgvSnapshotListTime.DataPropertyName = "DATE_TIME"
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDgvSnapshotListTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDgvSnapshotListTime.HeaderText = "SnapshotTime"
        Me.colDgvSnapshotListTime.Name = "colDgvSnapshotListTime"
        Me.colDgvSnapshotListTime.ReadOnly = True
        Me.colDgvSnapshotListTime.Width = 130
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBaselineList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBaselineList.ColumnHeadersHeight = 30
        Me.dgvBaselineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBaselineList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDGVBaselineListBaseLine, Me.colDGVBaselineListMinSnap, Me.colDGVBaselineListFrom, Me.colDGVBaselineListMaxSnap, Me.colDGVBaselineListTo, Me.colDGVBaselineListKeepTime})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBaselineList.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvBaselineList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBaselineList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvBaselineList.EnableHeadersVisualStyles = False
        Me.dgvBaselineList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvBaselineList.GridColor = System.Drawing.Color.Black
        Me.dgvBaselineList.Location = New System.Drawing.Point(3, 4)
        Me.dgvBaselineList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBaselineList.Name = "dgvBaselineList"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBaselineList.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBaselineList.RowHeadersVisible = False
        Me.dgvBaselineList.RowTemplate.Height = 23
        Me.dgvBaselineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBaselineList.Size = New System.Drawing.Size(277, 181)
        Me.dgvBaselineList.TabIndex = 16
        Me.dgvBaselineList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvBaselineList.UseTagValueMatchColor = False
        '
        'colDGVBaselineListBaseLine
        '
        Me.colDGVBaselineListBaseLine.DataPropertyName = "BASELINE"
        Me.colDGVBaselineListBaseLine.HeaderText = "Baseline"
        Me.colDGVBaselineListBaseLine.Name = "colDGVBaselineListBaseLine"
        Me.colDGVBaselineListBaseLine.ReadOnly = True
        Me.colDGVBaselineListBaseLine.Width = 70
        '
        'colDGVBaselineListMinSnap
        '
        Me.colDGVBaselineListMinSnap.DataPropertyName = "MIN_SNAP"
        Me.colDGVBaselineListMinSnap.HeaderText = "Min_snap"
        Me.colDGVBaselineListMinSnap.Name = "colDGVBaselineListMinSnap"
        Me.colDGVBaselineListMinSnap.Width = 65
        '
        'colDGVBaselineListFrom
        '
        Me.colDGVBaselineListFrom.DataPropertyName = "MIN_SNAP_TIME"
        DataGridViewCellStyle6.Format = "yyyy-MM-dd HH:mm:ss"
        Me.colDGVBaselineListFrom.DefaultCellStyle = DataGridViewCellStyle6
        Me.colDGVBaselineListFrom.HeaderText = "From"
        Me.colDGVBaselineListFrom.Name = "colDGVBaselineListFrom"
        Me.colDGVBaselineListFrom.Width = 130
        '
        'colDGVBaselineListMaxSnap
        '
        Me.colDGVBaselineListMaxSnap.DataPropertyName = "MAX_SNAP"
        Me.colDGVBaselineListMaxSnap.HeaderText = "Max_snap"
        Me.colDGVBaselineListMaxSnap.Name = "colDGVBaselineListMaxSnap"
        Me.colDGVBaselineListMaxSnap.Width = 65
        '
        'colDGVBaselineListTo
        '
        Me.colDGVBaselineListTo.DataPropertyName = "MAX_SNAP_TIME"
        DataGridViewCellStyle7.Format = "yyyy-MM-dd HH:mm:ss"
        Me.colDGVBaselineListTo.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDGVBaselineListTo.HeaderText = "To"
        Me.colDGVBaselineListTo.Name = "colDGVBaselineListTo"
        Me.colDGVBaselineListTo.Width = 130
        '
        'colDGVBaselineListKeepTime
        '
        Me.colDGVBaselineListKeepTime.DataPropertyName = "KEEP_UNTIL_TIME"
        DataGridViewCellStyle8.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colDGVBaselineListKeepTime.DefaultCellStyle = DataGridViewCellStyle8
        Me.colDGVBaselineListKeepTime.HeaderText = "KeepUntilTime"
        Me.colDGVBaselineListKeepTime.Name = "colDGVBaselineListKeepTime"
        Me.colDGVBaselineListKeepTime.ReadOnly = True
        Me.colDGVBaselineListKeepTime.Width = 130
        '
        'frmSnapshotList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpSnapshotList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSnapshotList"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Version"
        Me.tlpSnapshotList.ResumeLayout(False)
        CType(Me.dgvSnapshotList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBaselineList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSnapshotList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents dgvSnapshotList As eXperDB.BaseControls.DataGridView
    Friend WithEvents colDgvSnapshotListSnapshot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvSnapshotListTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvBaselineList As eXperDB.BaseControls.DataGridView
    Friend WithEvents colDGVBaselineListBaseLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBaselineListMinSnap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBaselineListFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBaselineListMaxSnap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBaselineListTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDGVBaselineListKeepTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
End Class
