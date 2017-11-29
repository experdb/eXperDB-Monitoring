<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatchSqlInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatchSqlInfo))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.CtlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DirSqlComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ExecButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeDirButton = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TraceGV = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.WarningImg = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.InfoImg = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RunProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.RunCountStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TreeContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NodeDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.SqlRTB = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CtlToolStrip.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.TraceGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TreeContextMenuStrip.SuspendLayout()
        CType(Me.SqlRTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CtlToolStrip)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(928, 492)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGV
        '
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGV.Location = New System.Drawing.Point(0, 25)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.Size = New System.Drawing.Size(928, 121)
        Me.DataGV.TabIndex = 1
        '
        'CtlToolStrip
        '
        Me.CtlToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.DirSqlComboBox, Me.ExecButton, Me.ToolStripSeparator2, Me.ChangeDirButton})
        Me.CtlToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.CtlToolStrip.Name = "CtlToolStrip"
        Me.CtlToolStrip.Size = New System.Drawing.Size(928, 25)
        Me.CtlToolStrip.TabIndex = 0
        Me.CtlToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripLabel1.Text = "SQL 기본 정보"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'DirSqlComboBox
        '
        Me.DirSqlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DirSqlComboBox.Name = "DirSqlComboBox"
        Me.DirSqlComboBox.Size = New System.Drawing.Size(300, 25)
        '
        'ExecButton
        '
        Me.ExecButton.Image = CType(resources.GetObject("ExecButton.Image"), System.Drawing.Image)
        Me.ExecButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExecButton.Name = "ExecButton"
        Me.ExecButton.Size = New System.Drawing.Size(51, 22)
        Me.ExecButton.Text = "조회"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ChangeDirButton
        '
        Me.ChangeDirButton.Image = CType(resources.GetObject("ChangeDirButton.Image"), System.Drawing.Image)
        Me.ChangeDirButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangeDirButton.Name = "ChangeDirButton"
        Me.ChangeDirButton.Size = New System.Drawing.Size(75, 22)
        Me.ChangeDirButton.Text = "가져오기"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SqlRTB)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TraceGV)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip3)
        Me.SplitContainer2.Size = New System.Drawing.Size(928, 342)
        Me.SplitContainer2.SplitterDistance = 462
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(462, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel2.Text = "SQL 문장"
        '
        'TraceGV
        '
        Me.TraceGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림체", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TraceGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.TraceGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TraceGV.Location = New System.Drawing.Point(0, 25)
        Me.TraceGV.Name = "TraceGV"
        Me.TraceGV.RowTemplate.Height = 23
        Me.TraceGV.Size = New System.Drawing.Size(462, 317)
        Me.TraceGV.TabIndex = 8
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel5, Me.WarningImg, Me.ToolStripLabel6, Me.ToolStripLabel4, Me.InfoImg})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(462, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel3.Text = "Trace 정보"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel5.Text = "수정필요"
        '
        'WarningImg
        '
        Me.WarningImg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.WarningImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WarningImg.Name = "WarningImg"
        Me.WarningImg.Size = New System.Drawing.Size(19, 22)
        Me.WarningImg.Text = "■"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(10, 22)
        Me.ToolStripLabel6.Text = "|"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel4.Text = "확인필요"
        '
        'InfoImg
        '
        Me.InfoImg.ActiveLinkColor = System.Drawing.Color.Red
        Me.InfoImg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.InfoImg.BackColor = System.Drawing.SystemColors.Control
        Me.InfoImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InfoImg.Name = "InfoImg"
        Me.InfoImg.Size = New System.Drawing.Size(19, 22)
        Me.InfoImg.Text = "■"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(928, 492)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(928, 539)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunProgressBar, Me.RunCountStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(928, 22)
        Me.StatusStrip1.TabIndex = 4
        '
        'RunProgressBar
        '
        Me.RunProgressBar.Name = "RunProgressBar"
        Me.RunProgressBar.Size = New System.Drawing.Size(200, 16)
        Me.RunProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'RunCountStatusLabel
        '
        Me.RunCountStatusLabel.Name = "RunCountStatusLabel"
        Me.RunCountStatusLabel.Size = New System.Drawing.Size(26, 17)
        Me.RunCountStatusLabel.Text = "0/0"
        '
        'TreeContextMenuStrip
        '
        Me.TreeContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NodeDelete})
        Me.TreeContextMenuStrip.Name = "TreeContextMenuStrip"
        Me.TreeContextMenuStrip.Size = New System.Drawing.Size(116, 26)
        '
        'NodeDelete
        '
        Me.NodeDelete.Name = "NodeDelete"
        Me.NodeDelete.Size = New System.Drawing.Size(115, 22)
        Me.NodeDelete.Text = "삭제(&D)"
        '
        'SqlRTB
        '
        Me.SqlRTB.AutoIndentExistingLines = False
        Me.SqlRTB.AutoScrollMinSize = New System.Drawing.Size(25, 15)
        Me.SqlRTB.BackBrush = Nothing
        Me.SqlRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SqlRTB.CharHeight = 15
        Me.SqlRTB.CharWidth = 7
        Me.SqlRTB.CommentPrefix = "--"
        Me.SqlRTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SqlRTB.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.SqlRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlRTB.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.SqlRTB.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.SqlRTB.IsReplaceMode = False
        Me.SqlRTB.Language = FastColoredTextBoxNS.Language.SQL
        Me.SqlRTB.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.SqlRTB.Location = New System.Drawing.Point(0, 25)
        Me.SqlRTB.Name = "SqlRTB"
        Me.SqlRTB.Paddings = New System.Windows.Forms.Padding(0)
        Me.SqlRTB.PreferredLineWidth = 80
        Me.SqlRTB.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.SqlRTB.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SqlRTB.Size = New System.Drawing.Size(462, 317)
        Me.SqlRTB.TabIndex = 27
        Me.SqlRTB.Zoom = 100
        '
        'frmCatchSqlInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 539)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmCatchSqlInfo"
        Me.Text = "frmCatchSqlInfo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CtlToolStrip.ResumeLayout(False)
        Me.CtlToolStrip.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.TraceGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TreeContextMenuStrip.ResumeLayout(False)
        CType(Me.SqlRTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CtlToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ExecButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGV As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DirSqlComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ChangeDirButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NodeDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RunProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents RunCountStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TraceGV As System.Windows.Forms.DataGridView
    Friend WithEvents WarningImg As System.Windows.Forms.ToolStripLabel
    Friend WithEvents InfoImg As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SqlRTB As FastColoredTextBoxNS.FastColoredTextBox
End Class
