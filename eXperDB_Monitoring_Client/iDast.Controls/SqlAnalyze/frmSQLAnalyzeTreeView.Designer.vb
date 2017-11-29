<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLAnalyzeTreeView
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridTreeView = New AdvancedDataGridView.TreeGridView()
        Me.Title = New AdvancedDataGridView.TreeGridColumn()
        Me.DataValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Postition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataETC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridTreeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridTreeView
        '
        Me.DataGridTreeView.AllowDrop = True
        Me.DataGridTreeView.AllowUserToAddRows = False
        Me.DataGridTreeView.AllowUserToDeleteRows = False
        Me.DataGridTreeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridTreeView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridTreeView.BackgroundColor = System.Drawing.Color.White
        Me.DataGridTreeView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTreeView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTreeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridTreeView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.DataValue, Me.Postition, Me.DataType, Me.DataETC})
        Me.DataGridTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridTreeView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridTreeView.ImageList = Nothing
        Me.DataGridTreeView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridTreeView.Name = "DataGridTreeView"
        Me.DataGridTreeView.RowHeadersVisible = False
        Me.DataGridTreeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTreeView.ShowLines = False
        Me.DataGridTreeView.Size = New System.Drawing.Size(543, 319)
        Me.DataGridTreeView.TabIndex = 2
        '
        'Title
        '
        Me.Title.DefaultNodeImage = Nothing
        Me.Title.FillWeight = 140.5859!
        Me.Title.HeaderText = "구성"
        Me.Title.Name = "Title"
        Me.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataValue
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataValue.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataValue.FillWeight = 51.40173!
        Me.DataValue.HeaderText = "Value"
        Me.DataValue.Name = "DataValue"
        Me.DataValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Postition
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Postition.DefaultCellStyle = DataGridViewCellStyle3
        Me.Postition.FillWeight = 51.40173!
        Me.Postition.HeaderText = "위치(줄,열)"
        Me.Postition.Name = "Postition"
        Me.Postition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Postition.Visible = False
        '
        'DataType
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataType.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataType.FillWeight = 51.40173!
        Me.DataType.HeaderText = "타입"
        Me.DataType.Name = "DataType"
        Me.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataETC
        '
        Me.DataETC.FillWeight = 51.40173!
        Me.DataETC.HeaderText = "속성"
        Me.DataETC.Name = "DataETC"
        Me.DataETC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataETC.Visible = False
        '
        'frmSQLAnalyzeTreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 319)
        Me.Controls.Add(Me.DataGridTreeView)
        Me.Name = "frmSQLAnalyzeTreeView"
        Me.Text = "frmSQLAnalyzeTreeView"
        CType(Me.DataGridTreeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridTreeView As AdvancedDataGridView.TreeGridView
    Friend WithEvents Title As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents DataValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Postition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataETC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
