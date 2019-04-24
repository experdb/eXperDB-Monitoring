<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertConfigList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpAlertConfigurationMain = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvAlertList = New eXperDB.BaseControls.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPercentageColumn1 = New eXperDB.Controls.DataGridViewPercentageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.coldgvAlertName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertBizDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertBizHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertWarningThreshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertCriticalThreshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertTransMethod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.coldgvAlertTransCycle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAlertTransLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.coldgvAlertTransUser = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tlpAlertConfigurationMain.SuspendLayout()
        CType(Me.dgvAlertList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpAlertConfigurationMain
        '
        Me.tlpAlertConfigurationMain.BackColor = System.Drawing.Color.Gray
        Me.tlpAlertConfigurationMain.ColumnCount = 2
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54316!))
        Me.tlpAlertConfigurationMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45684!))
        Me.tlpAlertConfigurationMain.Controls.Add(Me.dgvAlertList, 0, 0)
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
        Me.tlpAlertConfigurationMain.Size = New System.Drawing.Size(840, 600)
        Me.tlpAlertConfigurationMain.TabIndex = 3
        '
        'dgvAlertList
        '
        Me.dgvAlertList.AllowUserToAddRows = False
        Me.dgvAlertList.AllowUserToDeleteRows = False
        Me.dgvAlertList.AllowUserToOrderColumns = True
        Me.dgvAlertList.AllowUserToResizeRows = False
        Me.dgvAlertList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvAlertList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAlertList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlertList.ColumnHeadersHeight = 30
        Me.dgvAlertList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAlertList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvAlertSel, Me.coldgvAlertName, Me.coldgvAlertBizDay, Me.coldgvAlertBizHour, Me.coldgvAlertWarningThreshold, Me.coldgvAlertCriticalThreshold, Me.coldgvAlertDuration, Me.coldgvAlertTransMethod, Me.coldgvAlertTransCycle, Me.coldgvAlertTransLevel, Me.coldgvAlertTransUser})
        Me.tlpAlertConfigurationMain.SetColumnSpan(Me.dgvAlertList, 2)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlertList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAlertList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlertList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAlertList.EnableHeadersVisualStyles = False
        Me.dgvAlertList.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvAlertList.GridColor = System.Drawing.Color.Black
        Me.dgvAlertList.Location = New System.Drawing.Point(3, 4)
        Me.dgvAlertList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAlertList.Name = "dgvAlertList"
        Me.dgvAlertList.RowHeadersVisible = False
        Me.dgvAlertList.RowHeadersWidth = 45
        Me.dgvAlertList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tlpAlertConfigurationMain.SetRowSpan(Me.dgvAlertList, 7)
        Me.dgvAlertList.RowTemplate.Height = 23
        Me.dgvAlertList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlertList.Size = New System.Drawing.Size(834, 587)
        Me.dgvAlertList.TabIndex = 11
        Me.dgvAlertList.TagValueMatchColor = System.Drawing.Color.White
        Me.dgvAlertList.UseTagValueMatchColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.FillWeight = 131.1306!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Alert Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle8.Format = "yyyy-MM-dd HH:mm:ss"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.FillWeight = 171.0869!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Biz day"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 120.5725!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Biz hour"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewPercentageColumn1
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "P"
        Me.DataGridViewPercentageColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewPercentageColumn1.HeaderText = "Alert Level"
        Me.DataGridViewPercentageColumn1.MinimumWidth = 180
        Me.DataGridViewPercentageColumn1.Name = "DataGridViewPercentageColumn1"
        Me.DataGridViewPercentageColumn1.ReadOnly = True
        Me.DataGridViewPercentageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPercentageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewPercentageColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RETENTION_TIME"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "P"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "Alert Level"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RETENTION_TIME"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Alert duration"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CHECK_USER_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cycle"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 95
        '
        'coldgvAlertSel
        '
        Me.coldgvAlertSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvAlertSel.DataPropertyName = "ACCESS_TYPE"
        Me.coldgvAlertSel.FillWeight = 40.0!
        Me.coldgvAlertSel.HeaderText = "Enable"
        Me.coldgvAlertSel.MinimumWidth = 50
        Me.coldgvAlertSel.Name = "coldgvAlertSel"
        Me.coldgvAlertSel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvAlertSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvAlertSel.Width = 50
        '
        'coldgvAlertName
        '
        Me.coldgvAlertName.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.coldgvAlertName.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvAlertName.FillWeight = 131.1306!
        Me.coldgvAlertName.HeaderText = "Alert Name"
        Me.coldgvAlertName.MinimumWidth = 95
        Me.coldgvAlertName.Name = "coldgvAlertName"
        Me.coldgvAlertName.ReadOnly = True
        Me.coldgvAlertName.Width = 95
        '
        'coldgvAlertBizDay
        '
        DataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss"
        Me.coldgvAlertBizDay.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvAlertBizDay.FillWeight = 171.0869!
        Me.coldgvAlertBizDay.HeaderText = "Biz day"
        Me.coldgvAlertBizDay.MinimumWidth = 100
        Me.coldgvAlertBizDay.Name = "coldgvAlertBizDay"
        Me.coldgvAlertBizDay.ReadOnly = True
        Me.coldgvAlertBizDay.Visible = False
        Me.coldgvAlertBizDay.Width = 200
        '
        'coldgvAlertBizHour
        '
        Me.coldgvAlertBizHour.FillWeight = 120.5725!
        Me.coldgvAlertBizHour.HeaderText = "Biz hour"
        Me.coldgvAlertBizHour.MinimumWidth = 100
        Me.coldgvAlertBizHour.Name = "coldgvAlertBizHour"
        Me.coldgvAlertBizHour.ReadOnly = True
        Me.coldgvAlertBizHour.Visible = False
        '
        'coldgvAlertWarningThreshold
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = Nothing
        Me.coldgvAlertWarningThreshold.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvAlertWarningThreshold.HeaderText = "Warning"
        Me.coldgvAlertWarningThreshold.MinimumWidth = 90
        Me.coldgvAlertWarningThreshold.Name = "coldgvAlertWarningThreshold"
        Me.coldgvAlertWarningThreshold.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvAlertWarningThreshold.Width = 90
        '
        'coldgvAlertCriticalThreshold
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldgvAlertCriticalThreshold.DefaultCellStyle = DataGridViewCellStyle5
        Me.coldgvAlertCriticalThreshold.HeaderText = "Critical"
        Me.coldgvAlertCriticalThreshold.MinimumWidth = 90
        Me.coldgvAlertCriticalThreshold.Name = "coldgvAlertCriticalThreshold"
        '
        'coldgvAlertDuration
        '
        Me.coldgvAlertDuration.DataPropertyName = "RETENTION_TIME"
        Me.coldgvAlertDuration.HeaderText = "Alert duration"
        Me.coldgvAlertDuration.MinimumWidth = 95
        Me.coldgvAlertDuration.Name = "coldgvAlertDuration"
        Me.coldgvAlertDuration.ReadOnly = True
        Me.coldgvAlertDuration.Width = 95
        '
        'coldgvAlertTransMethod
        '
        Me.coldgvAlertTransMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coldgvAlertTransMethod.HeaderText = "SMS/Email"
        Me.coldgvAlertTransMethod.Items.AddRange(New Object() {"none", "SMS", "Email", "All"})
        Me.coldgvAlertTransMethod.Name = "coldgvAlertTransMethod"
        Me.coldgvAlertTransMethod.Width = 95
        '
        'coldgvAlertTransCycle
        '
        Me.coldgvAlertTransCycle.DataPropertyName = "CHECK_USER_ID"
        Me.coldgvAlertTransCycle.HeaderText = "Cycle"
        Me.coldgvAlertTransCycle.MinimumWidth = 95
        Me.coldgvAlertTransCycle.Name = "coldgvAlertTransCycle"
        Me.coldgvAlertTransCycle.ReadOnly = True
        Me.coldgvAlertTransCycle.Width = 95
        '
        'coldgvAlertTransLevel
        '
        Me.coldgvAlertTransLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coldgvAlertTransLevel.HeaderText = "Level"
        Me.coldgvAlertTransLevel.Name = "coldgvAlertTransLevel"
        Me.coldgvAlertTransLevel.Width = 95
        '
        'coldgvAlertTransUser
        '
        Me.coldgvAlertTransUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coldgvAlertTransUser.HeaderText = "User Group"
        Me.coldgvAlertTransUser.Name = "coldgvAlertTransUser"
        Me.coldgvAlertTransUser.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvAlertTransUser.Width = 95
        '
        'AlertConfigList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.tlpAlertConfigurationMain)
        Me.Name = "AlertConfigList"
        Me.Size = New System.Drawing.Size(840, 600)
        Me.tlpAlertConfigurationMain.ResumeLayout(false)
        CType(Me.dgvAlertList,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tlpAlertConfigurationMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvAlertList As eXperDB.BaseControls.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPercentageColumn1 As eXperDB.Controls.DataGridViewPercentageColumn
    Friend WithEvents coldgvAlertSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents coldgvAlertName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertBizDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertBizHour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertWarningThreshold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertCriticalThreshold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertDuration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertTransMethod As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents coldgvAlertTransCycle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAlertTransLevel As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents coldgvAlertTransUser As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
