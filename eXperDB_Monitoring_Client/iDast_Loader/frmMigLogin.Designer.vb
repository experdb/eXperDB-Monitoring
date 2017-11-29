<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmMIGLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMIGLogin))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SchemaNmTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OdbcDriverCB = New System.Windows.Forms.ComboBox()
        Me.DbNameTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerIpTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PortTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SavePwCB = New System.Windows.Forms.CheckBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.LoginHistTGV = New AdvancedDataGridView.TreeGridView()
        Me.Grouping = New AdvancedDataGridView.TreeGridColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OrderbyTSB = New System.Windows.Forms.ToolStripLabel()
        Me.GroupingTSCB = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshTSB = New System.Windows.Forms.ToolStripButton()
        Me.DeleteTSB = New System.Windows.Forms.ToolStripButton()
        Me.ExecBW = New System.ComponentModel.BackgroundWorker()
        Me.USERTYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ODBCDRIVER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVERIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PORT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCHEMA_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DELKEY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.LoginHistTGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SchemaNmTB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OdbcDriverCB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DbNameTB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ServerIpTB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PortTB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SavePwCB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UsernameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PasswordLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Cancel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OK)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LoginHistTGV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(939, 337)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 0
        '
        'SchemaNmTB
        '
        Me.SchemaNmTB.Enabled = False
        Me.SchemaNmTB.Location = New System.Drawing.Point(9, 251)
        Me.SchemaNmTB.MaxLength = 20
        Me.SchemaNmTB.Name = "SchemaNmTB"
        Me.SchemaNmTB.Size = New System.Drawing.Size(155, 21)
        Me.SchemaNmTB.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 12)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Schema Name"
        '
        'OdbcDriverCB
        '
        Me.OdbcDriverCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OdbcDriverCB.FormattingEnabled = True
        Me.OdbcDriverCB.Location = New System.Drawing.Point(9, 108)
        Me.OdbcDriverCB.Name = "OdbcDriverCB"
        Me.OdbcDriverCB.Size = New System.Drawing.Size(288, 20)
        Me.OdbcDriverCB.TabIndex = 4
        '
        'DbNameTB
        '
        Me.DbNameTB.Location = New System.Drawing.Point(9, 202)
        Me.DbNameTB.MaxLength = 20
        Me.DbNameTB.Name = "DbNameTB"
        Me.DbNameTB.Size = New System.Drawing.Size(155, 21)
        Me.DbNameTB.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 12)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Database Name"
        '
        'ServerIpTB
        '
        Me.ServerIpTB.Location = New System.Drawing.Point(9, 154)
        Me.ServerIpTB.MaxLength = 15
        Me.ServerIpTB.Name = "ServerIpTB"
        Me.ServerIpTB.Size = New System.Drawing.Size(288, 21)
        Me.ServerIpTB.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 12)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Server IP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 12)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "ODBC Driver"
        '
        'PortTB
        '
        Me.PortTB.Location = New System.Drawing.Point(171, 202)
        Me.PortTB.MaxLength = 6
        Me.PortTB.Name = "PortTB"
        Me.PortTB.Size = New System.Drawing.Size(126, 21)
        Me.PortTB.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(169, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 12)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Port"
        '
        'SavePwCB
        '
        Me.SavePwCB.AutoSize = True
        Me.SavePwCB.Location = New System.Drawing.Point(110, 68)
        Me.SavePwCB.Name = "SavePwCB"
        Me.SavePwCB.Size = New System.Drawing.Size(100, 16)
        Me.SavePwCB.TabIndex = 3
        Me.SavePwCB.Text = "패스워드 저장"
        Me.SavePwCB.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(9, 15)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(77, 23)
        Me.UsernameLabel.TabIndex = 10
        Me.UsernameLabel.Text = "User(&U)"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(87, 41)
        Me.PasswordTextBox.MaxLength = 100
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(210, 21)
        Me.PasswordTextBox.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(9, 42)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(87, 23)
        Me.PasswordLabel.TabIndex = 13
        Me.PasswordLabel.Text = "Password(&P)"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(156, 287)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(122, 36)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "취소(&C)"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(87, 14)
        Me.UsernameTextBox.MaxLength = 100
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(210, 21)
        Me.UsernameTextBox.TabIndex = 1
        '
        'OK
        '
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK.Location = New System.Drawing.Point(28, 287)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(122, 36)
        Me.OK.TabIndex = 9
        Me.OK.Text = "확인(&O)"
        '
        'LoginHistTGV
        '
        Me.LoginHistTGV.AllowDrop = True
        Me.LoginHistTGV.AllowUserToAddRows = False
        Me.LoginHistTGV.AllowUserToDeleteRows = False
        Me.LoginHistTGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LoginHistTGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LoginHistTGV.BackgroundColor = System.Drawing.Color.White
        Me.LoginHistTGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LoginHistTGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LoginHistTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LoginHistTGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Grouping, Me.USERTYPE, Me.USERID, Me.ODBCDRIVER, Me.SERVERIP, Me.DBNAME, Me.PORT, Me.PASSWD, Me.SCHEMA_NAME, Me.REGDT, Me.DELKEY})
        Me.LoginHistTGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginHistTGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LoginHistTGV.ImageList = Nothing
        Me.LoginHistTGV.Location = New System.Drawing.Point(0, 25)
        Me.LoginHistTGV.Name = "LoginHistTGV"
        Me.LoginHistTGV.RowHeadersVisible = False
        Me.LoginHistTGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LoginHistTGV.Size = New System.Drawing.Size(624, 312)
        Me.LoginHistTGV.TabIndex = 12
        '
        'Grouping
        '
        Me.Grouping.DefaultNodeImage = Nothing
        Me.Grouping.HeaderText = "Grouping"
        Me.Grouping.Name = "Grouping"
        Me.Grouping.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderbyTSB, Me.GroupingTSCB, Me.ToolStripSeparator1, Me.RefreshTSB, Me.DeleteTSB})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(624, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OrderbyTSB
        '
        Me.OrderbyTSB.Name = "OrderbyTSB"
        Me.OrderbyTSB.Size = New System.Drawing.Size(43, 22)
        Me.OrderbyTSB.Text = "그룹핑"
        '
        'GroupingTSCB
        '
        Me.GroupingTSCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GroupingTSCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupingTSCB.Name = "GroupingTSCB"
        Me.GroupingTSCB.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshTSB
        '
        Me.RefreshTSB.Image = CType(resources.GetObject("RefreshTSB.Image"), System.Drawing.Image)
        Me.RefreshTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshTSB.Name = "RefreshTSB"
        Me.RefreshTSB.Size = New System.Drawing.Size(75, 22)
        Me.RefreshTSB.Text = "새로고침"
        '
        'DeleteTSB
        '
        Me.DeleteTSB.Image = CType(resources.GetObject("DeleteTSB.Image"), System.Drawing.Image)
        Me.DeleteTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteTSB.Name = "DeleteTSB"
        Me.DeleteTSB.Size = New System.Drawing.Size(51, 22)
        Me.DeleteTSB.Text = "삭제"
        '
        'ExecBW
        '
        '
        'USERTYPE
        '
        Me.USERTYPE.HeaderText = "USERTYPE"
        Me.USERTYPE.Name = "USERTYPE"
        Me.USERTYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'USERID
        '
        Me.USERID.HeaderText = "USERID"
        Me.USERID.Name = "USERID"
        Me.USERID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ODBCDRIVER
        '
        Me.ODBCDRIVER.HeaderText = "ODBCDRIVER"
        Me.ODBCDRIVER.Name = "ODBCDRIVER"
        Me.ODBCDRIVER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SERVERIP
        '
        Me.SERVERIP.HeaderText = "HOSTIP"
        Me.SERVERIP.Name = "SERVERIP"
        Me.SERVERIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DBNAME
        '
        Me.DBNAME.HeaderText = "DBNAME"
        Me.DBNAME.Name = "DBNAME"
        Me.DBNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PORT
        '
        Me.PORT.HeaderText = "PORT"
        Me.PORT.Name = "PORT"
        Me.PORT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PASSWD
        '
        Me.PASSWD.HeaderText = "PASSWD"
        Me.PASSWD.Name = "PASSWD"
        Me.PASSWD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SCHEMA_NAME
        '
        Me.SCHEMA_NAME.HeaderText = "SCHEMA_NAME"
        Me.SCHEMA_NAME.Name = "SCHEMA_NAME"
        Me.SCHEMA_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'REGDT
        '
        Me.REGDT.HeaderText = "REGDT"
        Me.REGDT.Name = "REGDT"
        Me.REGDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DELKEY
        '
        Me.DELKEY.HeaderText = "DELKEY"
        Me.DELKEY.Name = "DELKEY"
        Me.DELKEY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmMIGLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 337)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmMIGLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.LoginHistTGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SavePwCB As System.Windows.Forms.CheckBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents LoginHistTGV As AdvancedDataGridView.TreeGridView
    Friend WithEvents OrderbyTSB As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupingTSCB As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExecBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents OdbcDriverCB As System.Windows.Forms.ComboBox
    Friend WithEvents DbNameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServerIpTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PortTB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SchemaNmTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Grouping As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents USERTYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ODBCDRIVER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVERIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PORT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSWD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCHEMA_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DELKEY As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
