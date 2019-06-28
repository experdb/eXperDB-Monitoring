<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatementsFilter
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatementsFilter))
        Me.tlpList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnAddStatement = New eXperDB.BaseControls.Button()
        Me.lblServer = New eXperDB.BaseControls.Label()
        Me.txtSQL = New eXperDB.BaseControls.TextBox()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnApply = New eXperDB.BaseControls.Button()
        Me.dgvStatementFilterList = New eXperDB.BaseControls.DataGridView()
        Me.coldgvStatementFilterListStatement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvStatementFilterListDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tlpDesc = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpList.SuspendLayout()
        CType(Me.dgvStatementFilterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDesc.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpList
        '
        Me.tlpList.BackColor = System.Drawing.Color.Transparent
        Me.tlpList.ColumnCount = 10
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpList.Controls.Add(Me.btnAddStatement, 7, 0)
        Me.tlpList.Controls.Add(Me.lblServer, 1, 0)
        Me.tlpList.Controls.Add(Me.txtSQL, 3, 0)
        Me.tlpList.Controls.Add(Me.btnClose, 5, 2)
        Me.tlpList.Controls.Add(Me.btnApply, 3, 2)
        Me.tlpList.Controls.Add(Me.dgvStatementFilterList, 1, 1)
        Me.tlpList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpList.Font = New System.Drawing.Font("Gulim", 12.27167!)
        Me.tlpList.Location = New System.Drawing.Point(0, 50)
        Me.tlpList.Name = "tlpList"
        Me.tlpList.RowCount = 3
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.Size = New System.Drawing.Size(351, 291)
        Me.tlpList.TabIndex = 5
        '
        'btnAddStatement
        '
        Me.btnAddStatement.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAddStatement.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tlpList.SetColumnSpan(Me.btnAddStatement, 2)
        Me.btnAddStatement.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAddStatement.FixedHeight = False
        Me.btnAddStatement.FixedWidth = False
        Me.btnAddStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStatement.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAddStatement.ForeColor = System.Drawing.Color.White
        Me.btnAddStatement.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddStatement.LineColor = System.Drawing.Color.Transparent
        Me.btnAddStatement.Location = New System.Drawing.Point(258, 12)
        Me.btnAddStatement.Name = "btnAddStatement"
        Me.btnAddStatement.Radius = 5
        Me.btnAddStatement.Size = New System.Drawing.Size(84, 25)
        Me.btnAddStatement.TabIndex = 34
        Me.btnAddStatement.Text = "F016"
        Me.btnAddStatement.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddStatement.UseRound = True
        Me.btnAddStatement.UseVisualStyleBackColor = False
        '
        'lblServer
        '
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.tlpList.SetColumnSpan(Me.lblServer, 2)
        Me.lblServer.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblServer.FixedHeight = False
        Me.lblServer.FixedWidth = False
        Me.lblServer.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblServer.ForeColor = System.Drawing.Color.White
        Me.lblServer.LineSpacing = 0.0!
        Me.lblServer.Location = New System.Drawing.Point(8, 11)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(84, 29)
        Me.lblServer.TabIndex = 33
        Me.lblServer.Text = "F332"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSQL
        '
        Me.txtSQL.BackColor = System.Drawing.SystemColors.Window
        Me.txtSQL.code = False
        Me.tlpList.SetColumnSpan(Me.txtSQL, 4)
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSQL.FixedWidth = False
        Me.txtSQL.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.txtSQL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSQL.impossibleinput = "`~!@#$%^&*\{}"
        Me.txtSQL.Location = New System.Drawing.Point(98, 15)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Necessary = False
        Me.txtSQL.PossibleInput = ""
        Me.txtSQL.Prefix = ""
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(154, 22)
        Me.txtSQL.StatusTip = ""
        Me.txtSQL.TabIndex = 32
        Me.txtSQL.Value = ""
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tlpList.SetColumnSpan(Me.btnClose, 2)
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(178, 255)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 5
        Me.btnClose.Size = New System.Drawing.Size(74, 32)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tlpList.SetColumnSpan(Me.btnApply, 2)
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApply.FixedHeight = False
        Me.btnApply.FixedWidth = False
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnApply.LineColor = System.Drawing.Color.Transparent
        Me.btnApply.Location = New System.Drawing.Point(98, 255)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Radius = 5
        Me.btnApply.Size = New System.Drawing.Size(74, 32)
        Me.btnApply.TabIndex = 26
        Me.btnApply.Text = "F014"
        Me.btnApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.UseRound = True
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'dgvStatementFilterList
        '
        Me.dgvStatementFilterList.AllowUserToAddRows = False
        Me.dgvStatementFilterList.AllowUserToDeleteRows = False
        Me.dgvStatementFilterList.AllowUserToOrderColumns = True
        Me.dgvStatementFilterList.AllowUserToResizeRows = False
        Me.dgvStatementFilterList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvStatementFilterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStatementFilterList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStatementFilterList.ColumnHeadersHeight = 30
        Me.dgvStatementFilterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStatementFilterList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvStatementFilterListStatement, Me.coldgvStatementFilterListDel})
        Me.tlpList.SetColumnSpan(Me.dgvStatementFilterList, 8)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStatementFilterList.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStatementFilterList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStatementFilterList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvStatementFilterList.EnableHeadersVisualStyles = False
        Me.dgvStatementFilterList.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvStatementFilterList.GridColor = System.Drawing.Color.Black
        Me.dgvStatementFilterList.Location = New System.Drawing.Point(8, 44)
        Me.dgvStatementFilterList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvStatementFilterList.Name = "dgvStatementFilterList"
        Me.dgvStatementFilterList.RowHeadersVisible = False
        Me.dgvStatementFilterList.RowHeadersWidth = 45
        Me.dgvStatementFilterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStatementFilterList.RowTemplate.Height = 23
        Me.dgvStatementFilterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStatementFilterList.Size = New System.Drawing.Size(334, 203)
        Me.dgvStatementFilterList.TabIndex = 10
        Me.dgvStatementFilterList.TagValueMatchColor = System.Drawing.Color.White
        Me.dgvStatementFilterList.UseTagValueMatchColor = False
        '
        'coldgvStatementFilterListStatement
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvStatementFilterListStatement.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvStatementFilterListStatement.FillWeight = 131.1306!
        Me.coldgvStatementFilterListStatement.Frozen = True
        Me.coldgvStatementFilterListStatement.HeaderText = "F332"
        Me.coldgvStatementFilterListStatement.MinimumWidth = 280
        Me.coldgvStatementFilterListStatement.Name = "coldgvStatementFilterListStatement"
        Me.coldgvStatementFilterListStatement.ReadOnly = True
        Me.coldgvStatementFilterListStatement.Width = 280
        '
        'coldgvStatementFilterListDel
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvStatementFilterListDel.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvStatementFilterListDel.HeaderText = ""
        Me.coldgvStatementFilterListDel.Image = CType(resources.GetObject("coldgvStatementFilterListDel.Image"), System.Drawing.Image)
        Me.coldgvStatementFilterListDel.MinimumWidth = 50
        Me.coldgvStatementFilterListDel.Name = "coldgvStatementFilterListDel"
        Me.coldgvStatementFilterListDel.Width = 50
        '
        'tlpDesc
        '
        Me.tlpDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpDesc.ColumnCount = 2
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.Controls.Add(Me.MsgLabel, 1, 0)
        Me.tlpDesc.Controls.Add(Me.Label1, 0, 0)
        Me.tlpDesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpDesc.Location = New System.Drawing.Point(0, 0)
        Me.tlpDesc.Name = "tlpDesc"
        Me.tlpDesc.RowCount = 1
        Me.tlpDesc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDesc.Size = New System.Drawing.Size(351, 50)
        Me.tlpDesc.TabIndex = 18
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
        Me.MsgLabel.Size = New System.Drawing.Size(305, 50)
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
        'frmStatementsFilter
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 341)
        Me.Controls.Add(Me.tlpList)
        Me.Controls.Add(Me.tlpDesc)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "frmStatementsFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StatementsFiltering"
        Me.tlpList.ResumeLayout(False)
        Me.tlpList.PerformLayout()
        CType(Me.dgvStatementFilterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDesc.ResumeLayout(False)
        Me.tlpDesc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStatementFilterList As eXperDB.BaseControls.DataGridView
    Friend WithEvents tlpList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnApply As eXperDB.BaseControls.Button
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents tlpDesc As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSQL As eXperDB.BaseControls.TextBox
    Friend WithEvents lblServer As eXperDB.BaseControls.Label
    Friend WithEvents btnAddStatement As eXperDB.BaseControls.Button
    Friend WithEvents coldgvStatementFilterListStatement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvStatementFilterListDel As System.Windows.Forms.DataGridViewImageColumn

End Class
