<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHealthDetail
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHealthDetail))
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDesc = New eXperDB.BaseControls.Label()
        Me.lblResult = New eXperDB.BaseControls.Label()
        Me.lblinfo = New eXperDB.BaseControls.Label()
        Me.dgvinfo = New eXperDB.BaseControls.DataGridView()
        Me.lblParameter = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel5 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.lblCurTime = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblitmNm = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 443)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblResult, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblinfo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvinfo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblParameter, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(704, 398)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lblDesc
        '
        Me.lblDesc.AutoSizeHeight = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDesc.FixedHeight = False
        Me.lblDesc.FixedWidth = False
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.LineSpacing = 0.0!
        Me.lblDesc.Location = New System.Drawing.Point(23, 20)
        Me.lblDesc.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(658, 40)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "F202"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult.FixedHeight = False
        Me.lblResult.FixedWidth = False
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblResult.LineSpacing = 0.0!
        Me.lblResult.Location = New System.Drawing.Point(23, 60)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(658, 40)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "F203"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblinfo
        '
        Me.lblinfo.AutoSizeHeight = True
        Me.lblinfo.BackColor = System.Drawing.Color.Transparent
        Me.lblinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblinfo.FixedHeight = False
        Me.lblinfo.FixedWidth = False
        Me.lblinfo.ForeColor = System.Drawing.Color.White
        Me.lblinfo.LineSpacing = 0.0!
        Me.lblinfo.Location = New System.Drawing.Point(23, 100)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(658, 40)
        Me.lblinfo.TabIndex = 6
        Me.lblinfo.Text = "F204"
        Me.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvinfo
        '
        Me.dgvinfo.AllowUserToAddRows = False
        Me.dgvinfo.AllowUserToDeleteRows = False
        Me.dgvinfo.AllowUserToOrderColumns = True
        Me.dgvinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvinfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvinfo.ColumnHeadersHeight = 24
        Me.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinfo.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvinfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvinfo.EnableHeadersVisualStyles = False
        Me.dgvinfo.GridColor = System.Drawing.Color.Black
        Me.dgvinfo.Location = New System.Drawing.Point(23, 144)
        Me.dgvinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvinfo.Name = "dgvinfo"
        Me.dgvinfo.RowHeadersVisible = False
        Me.dgvinfo.RowTemplate.Height = 23
        Me.dgvinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinfo.Size = New System.Drawing.Size(658, 190)
        Me.dgvinfo.TabIndex = 7
        Me.dgvinfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvinfo.UseTagValueMatchColor = False
        '
        'lblParameter
        '
        Me.lblParameter.BackColor = System.Drawing.Color.Transparent
        Me.lblParameter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblParameter.FixedHeight = False
        Me.lblParameter.FixedWidth = False
        Me.lblParameter.ForeColor = System.Drawing.Color.White
        Me.lblParameter.LineSpacing = 0.0!
        Me.lblParameter.Location = New System.Drawing.Point(23, 338)
        Me.lblParameter.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblParameter.Name = "lblParameter"
        Me.lblParameter.Size = New System.Drawing.Size(658, 40)
        Me.lblParameter.TabIndex = 8
        Me.lblParameter.Text = "F205"
        Me.lblParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 398)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(704, 45)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(295, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(114, 39)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "F004"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCurTime
        '
        Me.lblCurTime.AutoSizeHeight = True
        Me.lblCurTime.BackColor = System.Drawing.Color.Transparent
        Me.lblCurTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurTime.FixedHeight = False
        Me.lblCurTime.FixedWidth = False
        Me.lblCurTime.ForeColor = System.Drawing.Color.White
        Me.lblCurTime.LineSpacing = 0.0!
        Me.lblCurTime.Location = New System.Drawing.Point(451, 0)
        Me.lblCurTime.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblCurTime.Name = "lblCurTime"
        Me.lblCurTime.Size = New System.Drawing.Size(250, 50)
        Me.lblCurTime.TabIndex = 0
        Me.lblCurTime.Text = "F206"
        Me.lblCurTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblCurTime, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblitmNm, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(704, 50)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'lblitmNm
        '
        Me.lblitmNm.AutoSize = True
        Me.lblitmNm.BackColor = System.Drawing.Color.Transparent
        Me.lblitmNm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblitmNm.ForeColor = System.Drawing.Color.White
        Me.lblitmNm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblitmNm.Location = New System.Drawing.Point(43, 0)
        Me.lblitmNm.Name = "lblitmNm"
        Me.lblitmNm.Size = New System.Drawing.Size(402, 50)
        Me.lblitmNm.TabIndex = 0
        Me.lblitmNm.Text = "F201"
        Me.lblitmNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "      "
        '
        'frmHealthDetail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHealthDetail"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHealthDetail"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents lblParameter As eXperDB.BaseControls.Label
    Friend WithEvents dgvinfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents lblinfo As eXperDB.BaseControls.Label
    Friend WithEvents lblResult As eXperDB.BaseControls.Label
    Friend WithEvents lblDesc As eXperDB.BaseControls.Label
    Friend WithEvents lblCurTime As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblitmNm As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel5 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
