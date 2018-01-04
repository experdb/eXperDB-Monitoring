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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHealthDetail))
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.lblParameter = New eXperDB.BaseControls.Label()
        Me.dgvinfo = New eXperDB.BaseControls.DataGridView()
        Me.lblinfo = New eXperDB.BaseControls.Label()
        Me.lblResult = New eXperDB.BaseControls.Label()
        Me.lblDesc = New eXperDB.BaseControls.Label()
        Me.lblitmNm = New eXperDB.BaseControls.Label()
        Me.lblCurTime = New eXperDB.BaseControls.Label()
        Me.FormMovePanel2 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox2 = New eXperDB.Controls.FormControlBox()
        Me.Label1 = New eXperDB.BaseControls.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormMovePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.FormMovePanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 670)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lblParameter)
        Me.Panel2.Controls.Add(Me.dgvinfo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblinfo)
        Me.Panel2.Controls.Add(Me.lblResult)
        Me.Panel2.Controls.Add(Me.lblDesc)
        Me.Panel2.Controls.Add(Me.lblitmNm)
        Me.Panel2.Controls.Add(Me.lblCurTime)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.Panel2.Size = New System.Drawing.Size(704, 639)
        Me.Panel2.TabIndex = 1
        '
        'lblParameter
        '
        Me.lblParameter.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblParameter.FixedHeight = False
        Me.lblParameter.FixedWidth = False
        Me.lblParameter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblParameter.Location = New System.Drawing.Point(11, 537)
        Me.lblParameter.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblParameter.Name = "lblParameter"
        Me.lblParameter.Size = New System.Drawing.Size(682, 25)
        Me.lblParameter.TabIndex = 8
        Me.lblParameter.Text = "F205"
        Me.lblParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvinfo
        '
        Me.dgvinfo.AllowUserToAddRows = False
        Me.dgvinfo.AllowUserToDeleteRows = False
        Me.dgvinfo.AllowUserToOrderColumns = True
        Me.dgvinfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinfo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvinfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvinfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvinfo.EnableHeadersVisualStyles = False
        Me.dgvinfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvinfo.Location = New System.Drawing.Point(11, 148)
        Me.dgvinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvinfo.Name = "dgvinfo"
        Me.dgvinfo.RowHeadersVisible = False
        Me.dgvinfo.RowTemplate.Height = 23
        Me.dgvinfo.Size = New System.Drawing.Size(682, 389)
        Me.dgvinfo.TabIndex = 7
        Me.dgvinfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvinfo.UseTagValueMatchColor = False
        '
        'lblinfo
        '
        Me.lblinfo.AutoSizeHeight = True
        Me.lblinfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblinfo.FixedHeight = False
        Me.lblinfo.FixedWidth = False
        Me.lblinfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblinfo.Location = New System.Drawing.Point(11, 112)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(682, 18)
        Me.lblinfo.TabIndex = 6
        Me.lblinfo.Text = "F204"
        Me.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResult
        '
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblResult.FixedHeight = False
        Me.lblResult.FixedWidth = False
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblResult.Location = New System.Drawing.Point(11, 87)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(682, 25)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "F203"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDesc
        '
        Me.lblDesc.AutoSizeHeight = True
        Me.lblDesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDesc.FixedHeight = False
        Me.lblDesc.FixedWidth = False
        Me.lblDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDesc.Location = New System.Drawing.Point(11, 62)
        Me.lblDesc.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(682, 25)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "F202"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblitmNm
        '
        Me.lblitmNm.AutoSizeHeight = True
        Me.lblitmNm.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblitmNm.FixedHeight = False
        Me.lblitmNm.FixedWidth = False
        Me.lblitmNm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblitmNm.Location = New System.Drawing.Point(11, 37)
        Me.lblitmNm.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblitmNm.Name = "lblitmNm"
        Me.lblitmNm.Size = New System.Drawing.Size(682, 25)
        Me.lblitmNm.TabIndex = 0
        Me.lblitmNm.Text = "F201"
        Me.lblitmNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurTime
        '
        Me.lblCurTime.AutoSizeHeight = True
        Me.lblCurTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCurTime.FixedHeight = False
        Me.lblCurTime.FixedWidth = False
        Me.lblCurTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblCurTime.Location = New System.Drawing.Point(11, 12)
        Me.lblCurTime.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblCurTime.Name = "lblCurTime"
        Me.lblCurTime.Size = New System.Drawing.Size(682, 25)
        Me.lblCurTime.TabIndex = 0
        Me.lblCurTime.Text = "F206"
        Me.lblCurTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMovePanel2
        '
        Me.FormMovePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel2.Controls.Add(Me.FormControlBox2)
        Me.FormMovePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel2.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel2.Location = New System.Drawing.Point(0, 0)
        Me.FormMovePanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel2.Name = "FormMovePanel2"
        Me.FormMovePanel2.Size = New System.Drawing.Size(704, 31)
        Me.FormMovePanel2.TabIndex = 20
        Me.FormMovePanel2.Text = "eXperDB-Monitoring"
        '
        'FormControlBox2
        '
        Me.FormControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox2.CloseBox = New System.Drawing.Rectangle(45, 1, 20, 20)
        Me.FormControlBox2.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox2.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox2.isCritical = False
        Me.FormControlBox2.isLock = False
        Me.FormControlBox2.isPower = True
        Me.FormControlBox2.isRotation = True
        Me.FormControlBox2.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox2.Location = New System.Drawing.Point(635, 0)
        Me.FormControlBox2.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox2.MaxBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox2.MinBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox2.Name = "FormControlBox2"
        Me.FormControlBox2.PowerBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.RotationBox = New System.Drawing.Rectangle(-21, 1, 20, 20)
        Me.FormControlBox2.ShowRectCnt = 3
        Me.FormControlBox2.Size = New System.Drawing.Size(67, 22)
        Me.FormControlBox2.TabIndex = 1
        Me.FormControlBox2.Text = "FormControlBox2"
        Me.FormControlBox2.UseConfigBox = False
        Me.FormControlBox2.UseCriticalBox = False
        Me.FormControlBox2.UseDualBox = False
        Me.FormControlBox2.UseLockBox = False
        Me.FormControlBox2.UseMaxBox = True
        Me.FormControlBox2.UseMinBox = True
        Me.FormControlBox2.UsePowerBox = False
        Me.FormControlBox2.UseRotationBox = True
        '
        'Label1
        '
        Me.Label1.AutoSizeHeight = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FixedHeight = False
        Me.Label1.FixedWidth = False
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(682, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmHealthDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 678)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHealthDetail"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Text = "frmHealthDetail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormMovePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents FormMovePanel2 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox2 As eXperDB.Controls.FormControlBox
    Friend WithEvents lblinfo As eXperDB.BaseControls.Label
    Friend WithEvents lblitmNm As eXperDB.BaseControls.Label
    Friend WithEvents dgvinfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents lblParameter As eXperDB.BaseControls.Label
    Friend WithEvents lblCurTime As eXperDB.BaseControls.Label
    Friend WithEvents lblDesc As eXperDB.BaseControls.Label
    Friend WithEvents lblResult As eXperDB.BaseControls.Label
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents Label1 As eXperDB.BaseControls.Label
End Class
