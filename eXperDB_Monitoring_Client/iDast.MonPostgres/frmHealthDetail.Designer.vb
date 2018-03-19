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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHealthDetail))
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.lblParameter = New eXperDB.BaseControls.Label()
        Me.dgvinfo = New eXperDB.BaseControls.DataGridView()
        Me.Label1 = New eXperDB.BaseControls.Label()
        Me.lblinfo = New eXperDB.BaseControls.Label()
        Me.lblResult = New eXperDB.BaseControls.Label()
        Me.lblDesc = New eXperDB.BaseControls.Label()
        Me.lblitmNm = New eXperDB.BaseControls.Label()
        Me.lblCurTime = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 630)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblParameter)
        Me.Panel2.Controls.Add(Me.dgvinfo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblinfo)
        Me.Panel2.Controls.Add(Me.lblResult)
        Me.Panel2.Controls.Add(Me.lblDesc)
        Me.Panel2.Controls.Add(Me.lblitmNm)
        Me.Panel2.Controls.Add(Me.lblCurTime)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.Panel2.Size = New System.Drawing.Size(704, 630)
        Me.Panel2.TabIndex = 2
        '
        'lblParameter
        '
        Me.lblParameter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblParameter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblParameter.FixedHeight = False
        Me.lblParameter.FixedWidth = False
        Me.lblParameter.ForeColor = System.Drawing.Color.White
        Me.lblParameter.Location = New System.Drawing.Point(11, 593)
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
        Me.dgvinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvinfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvinfo.ColumnHeadersHeight = 30
        Me.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinfo.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvinfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvinfo.EnableHeadersVisualStyles = False
        Me.dgvinfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvinfo.Location = New System.Drawing.Point(11, 144)
        Me.dgvinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvinfo.Name = "dgvinfo"
        Me.dgvinfo.RowHeadersVisible = False
        Me.dgvinfo.RowTemplate.Height = 23
        Me.dgvinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinfo.Size = New System.Drawing.Size(682, 474)
        Me.dgvinfo.TabIndex = 7
        Me.dgvinfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvinfo.UseTagValueMatchColor = False
        '
        'Label1
        '
        Me.Label1.AutoSizeHeight = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FixedHeight = False
        Me.Label1.FixedWidth = False
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(682, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblinfo
        '
        Me.lblinfo.AutoSizeHeight = True
        Me.lblinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblinfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblinfo.FixedHeight = False
        Me.lblinfo.FixedWidth = False
        Me.lblinfo.ForeColor = System.Drawing.Color.White
        Me.lblinfo.Location = New System.Drawing.Point(11, 112)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(682, 14)
        Me.lblinfo.TabIndex = 6
        Me.lblinfo.Text = "F204"
        Me.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblResult.FixedHeight = False
        Me.lblResult.FixedWidth = False
        Me.lblResult.ForeColor = System.Drawing.Color.White
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
        Me.lblDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDesc.FixedHeight = False
        Me.lblDesc.FixedWidth = False
        Me.lblDesc.ForeColor = System.Drawing.Color.White
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
        Me.lblitmNm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblitmNm.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblitmNm.FixedHeight = False
        Me.lblitmNm.FixedWidth = False
        Me.lblitmNm.ForeColor = System.Drawing.Color.White
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
        Me.lblCurTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCurTime.FixedHeight = False
        Me.lblCurTime.FixedWidth = False
        Me.lblCurTime.ForeColor = System.Drawing.Color.White
        Me.lblCurTime.Location = New System.Drawing.Point(11, 12)
        Me.lblCurTime.MinimumSize = New System.Drawing.Size(0, 25)
        Me.lblCurTime.Name = "lblCurTime"
        Me.lblCurTime.Size = New System.Drawing.Size(682, 25)
        Me.lblCurTime.TabIndex = 0
        Me.lblCurTime.Text = "F206"
        Me.lblCurTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lblSubject, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(704, 40)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubject.ForeColor = System.Drawing.Color.White
        Me.lblSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSubject.Location = New System.Drawing.Point(43, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(658, 40)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Text"
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "      "
        '
        'frmHealthDetail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 678)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHealthDetail"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmHealthDetail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents lblParameter As eXperDB.BaseControls.Label
    Friend WithEvents dgvinfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents Label1 As eXperDB.BaseControls.Label
    Friend WithEvents lblinfo As eXperDB.BaseControls.Label
    Friend WithEvents lblResult As eXperDB.BaseControls.Label
    Friend WithEvents lblDesc As eXperDB.BaseControls.Label
    Friend WithEvents lblitmNm As eXperDB.BaseControls.Label
    Friend WithEvents lblCurTime As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
