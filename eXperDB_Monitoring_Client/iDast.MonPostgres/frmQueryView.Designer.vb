<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueryView
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQueryView))
        Me.RichTextBoxQuery1 = New eXperDB.Controls.RichTextBoxQuery()
        Me.Splitter1 = New eXperDB.BaseControls.Splitter()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.TreeGridView1 = New AdvancedDataGridView.TreeGridView()
        Me.colPlain = New AdvancedDataGridView.TreeGridColumn()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.btnSearch = New eXperDB.BaseControls.Button()
        Me.txtPW = New eXperDB.BaseControls.TextBox()
        Me.lblPw = New eXperDB.BaseControls.Label()
        Me.txtID = New eXperDB.BaseControls.TextBox()
        Me.lblID = New eXperDB.BaseControls.Label()
        Me.txtDB = New eXperDB.BaseControls.TextBox()
        Me.lblDB = New eXperDB.BaseControls.Label()
        Me.FormMovePanel1 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.dgvVariables = New eXperDB.BaseControls.DataGridView()
        Me.colVariable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spnlVariables = New System.Windows.Forms.Splitter()
        Me.Panel1.SuspendLayout()
        CType(Me.TreeGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.FormMovePanel1.SuspendLayout()
        CType(Me.dgvVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBoxQuery1
        '
        Me.RichTextBoxQuery1.AutoWordSelection = True
        Me.RichTextBoxQuery1.BackColor = System.Drawing.Color.Black
        Me.RichTextBoxQuery1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxQuery1.Comments = System.Drawing.Color.Green
        Me.RichTextBoxQuery1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxQuery1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RichTextBoxQuery1.Functions = System.Drawing.Color.Maroon
        Me.RichTextBoxQuery1.HideSelection = False
        Me.RichTextBoxQuery1.KeyWords = System.Drawing.Color.Blue
        Me.RichTextBoxQuery1.Location = New System.Drawing.Point(3, 35)
        Me.RichTextBoxQuery1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBoxQuery1.Name = "RichTextBoxQuery1"
        Me.RichTextBoxQuery1.Numbers = System.Drawing.Color.Magenta
        Me.RichTextBoxQuery1.ReadOnly = True
        Me.RichTextBoxQuery1.Size = New System.Drawing.Size(780, 337)
        Me.RichTextBoxQuery1.StateMents = System.Drawing.Color.Blue
        Me.RichTextBoxQuery1.Strings = System.Drawing.Color.Red
        Me.RichTextBoxQuery1.TabIndex = 9
        Me.RichTextBoxQuery1.Text = ""
        Me.RichTextBoxQuery1.Types = System.Drawing.Color.Brown
        Me.RichTextBoxQuery1.VariableRegex = "\$[a-zA-Z_\d]*\b"
        Me.RichTextBoxQuery1.Variables = System.Drawing.Color.Maroon
        Me.RichTextBoxQuery1.WordWrap = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.DimGray
        Me.Splitter1.CollapseImage = Nothing
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.ExpandImage = Nothing
        Me.Splitter1.Location = New System.Drawing.Point(3, 372)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1023, 9)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TreeGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 381)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 365)
        Me.Panel1.TabIndex = 12
        '
        'TreeGridView1
        '
        Me.TreeGridView1.AllowUserToAddRows = False
        Me.TreeGridView1.AllowUserToDeleteRows = False
        Me.TreeGridView1.AllowUserToResizeColumns = False
        Me.TreeGridView1.AllowUserToResizeRows = False
        Me.TreeGridView1.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TreeGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TreeGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPlain})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TreeGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.TreeGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TreeGridView1.GridColor = System.Drawing.Color.Black
        Me.TreeGridView1.ImageList = Nothing
        Me.TreeGridView1.Location = New System.Drawing.Point(0, 35)
        Me.TreeGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeGridView1.Name = "TreeGridView1"
        Me.TreeGridView1.RowHeadersVisible = False
        Me.TreeGridView1.Size = New System.Drawing.Size(1023, 330)
        Me.TreeGridView1.TabIndex = 10
        '
        'colPlain
        '
        Me.colPlain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPlain.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPlain.DefaultNodeImage = Nothing
        Me.colPlain.HeaderText = "PLAN"
        Me.colPlain.Name = "colPlain"
        Me.colPlain.ReadOnly = True
        Me.colPlain.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPlain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtPW)
        Me.Panel2.Controls.Add(Me.lblPw)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Controls.Add(Me.txtDB)
        Me.Panel2.Controls.Add(Me.lblDB)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1023, 35)
        Me.Panel2.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSearch.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnSearch.FixedHeight = False
        Me.btnSearch.FixedWidth = False
        Me.btnSearch.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.LightGray
        Me.btnSearch.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(908, 0)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Radius = 10
        Me.btnSearch.Size = New System.Drawing.Size(114, 34)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "F151"
        Me.btnSearch.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.UseRound = True
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.Window
        Me.txtPW.code = False
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPW.impossibleinput = ""
        Me.txtPW.Location = New System.Drawing.Point(733, 5)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Necessary = False
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.PossibleInput = ""
        Me.txtPW.Prefix = ""
        Me.txtPW.Size = New System.Drawing.Size(150, 25)
        Me.txtPW.StatusTip = ""
        Me.txtPW.TabIndex = 5
        Me.txtPW.Value = ""
        '
        'lblPw
        '
        Me.lblPw.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPw.ForeColor = System.Drawing.Color.Gray
        Me.lblPw.Location = New System.Drawing.Point(611, 4)
        Me.lblPw.Name = "lblPw"
        Me.lblPw.Size = New System.Drawing.Size(100, 21)
        Me.lblPw.TabIndex = 4
        Me.lblPw.Text = "F009"
        Me.lblPw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.code = False
        Me.txtID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtID.impossibleinput = ""
        Me.txtID.Location = New System.Drawing.Point(429, 5)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Necessary = False
        Me.txtID.PossibleInput = ""
        Me.txtID.Prefix = ""
        Me.txtID.Size = New System.Drawing.Size(150, 25)
        Me.txtID.StatusTip = ""
        Me.txtID.TabIndex = 3
        Me.txtID.Value = ""
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Gray
        Me.lblID.Location = New System.Drawing.Point(307, 4)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(100, 21)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "F008"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDB
        '
        Me.txtDB.BackColor = System.Drawing.SystemColors.Window
        Me.txtDB.code = False
        Me.txtDB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDB.impossibleinput = ""
        Me.txtDB.Location = New System.Drawing.Point(125, 5)
        Me.txtDB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Necessary = False
        Me.txtDB.PossibleInput = ""
        Me.txtDB.Prefix = ""
        Me.txtDB.Size = New System.Drawing.Size(150, 25)
        Me.txtDB.StatusTip = ""
        Me.txtDB.TabIndex = 1
        Me.txtDB.Value = ""
        '
        'lblDB
        '
        Me.lblDB.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.Gray
        Me.lblDB.Location = New System.Drawing.Point(3, 4)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(100, 21)
        Me.lblDB.TabIndex = 0
        Me.lblDB.Text = "F010"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMovePanel1
        '
        Me.FormMovePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel1.Controls.Add(Me.FormControlBox1)
        Me.FormMovePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel1.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel1.Location = New System.Drawing.Point(3, 4)
        Me.FormMovePanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel1.Name = "FormMovePanel1"
        Me.FormMovePanel1.Size = New System.Drawing.Size(1023, 31)
        Me.FormMovePanel1.TabIndex = 8
        Me.FormMovePanel1.Text = "eXperDB-Monitoring"
        '
        'FormControlBox1
        '
        Me.FormControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox1.isCritical = False
        Me.FormControlBox1.isLock = False
        Me.FormControlBox1.isPower = True
        Me.FormControlBox1.isRotation = True
        Me.FormControlBox1.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox1.Location = New System.Drawing.Point(932, 0)
        Me.FormControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox1.Name = "FormControlBox1"
        Me.FormControlBox1.ShowRectCnt = 4
        Me.FormControlBox1.Size = New System.Drawing.Size(89, 22)
        Me.FormControlBox1.TabIndex = 1
        Me.FormControlBox1.Text = "FormControlBox1"
        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseDualBox = True
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseMaxBox = True
        Me.FormControlBox1.UseMinBox = True
        Me.FormControlBox1.UsePowerBox = True
        Me.FormControlBox1.UseRotationBox = True
        '
        'dgvVariables
        '
        Me.dgvVariables.AllowUserToAddRows = False
        Me.dgvVariables.AllowUserToDeleteRows = False
        Me.dgvVariables.AllowUserToOrderColumns = True
        Me.dgvVariables.AllowUserToResizeRows = False
        Me.dgvVariables.BackgroundColor = System.Drawing.Color.Black
        Me.dgvVariables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVariables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Batang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colVariable, Me.colValue, Me.colLine})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Batang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVariables.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVariables.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvVariables.EnableHeadersVisualStyles = False
        Me.dgvVariables.GridColor = System.Drawing.Color.Gray
        Me.dgvVariables.Location = New System.Drawing.Point(791, 35)
        Me.dgvVariables.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvVariables.MultiSelect = False
        Me.dgvVariables.Name = "dgvVariables"
        Me.dgvVariables.RowHeadersVisible = False
        Me.dgvVariables.RowTemplate.Height = 23
        Me.dgvVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVariables.Size = New System.Drawing.Size(235, 337)
        Me.dgvVariables.TabIndex = 13
        Me.dgvVariables.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvVariables.UseTagValueMatchColor = False
        '
        'colVariable
        '
        Me.colVariable.HeaderText = "VARIABLE"
        Me.colVariable.Name = "colVariable"
        Me.colVariable.ReadOnly = True
        '
        'colValue
        '
        Me.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colValue.HeaderText = "VALUES"
        Me.colValue.Name = "colValue"
        '
        'colLine
        '
        Me.colLine.HeaderText = "-"
        Me.colLine.Name = "colLine"
        Me.colLine.ReadOnly = True
        Me.colLine.Visible = False
        Me.colLine.Width = 30
        '
        'spnlVariables
        '
        Me.spnlVariables.BackColor = System.Drawing.Color.DimGray
        Me.spnlVariables.Dock = System.Windows.Forms.DockStyle.Right
        Me.spnlVariables.Location = New System.Drawing.Point(783, 35)
        Me.spnlVariables.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spnlVariables.Name = "spnlVariables"
        Me.spnlVariables.Size = New System.Drawing.Size(8, 337)
        Me.spnlVariables.TabIndex = 14
        Me.spnlVariables.TabStop = False
        '
        'frmQueryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1029, 750)
        Me.Controls.Add(Me.RichTextBoxQuery1)
        Me.Controls.Add(Me.spnlVariables)
        Me.Controls.Add(Me.dgvVariables)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FormMovePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmQueryView"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Text = "frmQueryView"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.TreeGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FormMovePanel1.ResumeLayout(False)
        CType(Me.dgvVariables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormMovePanel1 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents RichTextBoxQuery1 As eXperDB.Controls.RichTextBoxQuery
    Friend WithEvents TreeGridView1 As AdvancedDataGridView.TreeGridView
    Friend WithEvents Splitter1 As eXperDB.BaseControls.Splitter
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents txtPW As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPw As eXperDB.BaseControls.Label
    Friend WithEvents txtID As eXperDB.BaseControls.TextBox
    Friend WithEvents lblID As eXperDB.BaseControls.Label
    Friend WithEvents txtDB As eXperDB.BaseControls.TextBox
    Friend WithEvents lblDB As eXperDB.BaseControls.Label
    Friend WithEvents btnSearch As eXperDB.BaseControls.Button
    Friend WithEvents colPlain As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents dgvVariables As eXperDB.BaseControls.DataGridView
    Friend WithEvents spnlVariables As System.Windows.Forms.Splitter
    Friend WithEvents colVariable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLine As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
