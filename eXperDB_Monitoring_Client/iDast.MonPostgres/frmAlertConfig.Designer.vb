<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertConfig
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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertConfig))
        Me.grpMain = New eXperDB.BaseControls.GroupBox()
        Me.tbMain = New FlatTabControl.FlatTabControl()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnHealthInit = New eXperDB.BaseControls.Button()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.pnlAlertConfig = New eXperDB.Controls.FormMovePanel()
        Me.grpMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlAlertConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpMain.AlignString = System.Drawing.StringAlignment.Near
        Me.grpMain.BackColor = System.Drawing.Color.Black
        Me.grpMain.Controls.Add(Me.tbMain)
        Me.grpMain.Controls.Add(Me.Panel2)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMain.EdgeRound = Edges1
        Me.grpMain.FillColor = System.Drawing.Color.Black
        Me.grpMain.ForeColor = System.Drawing.SystemColors.Control
        Me.grpMain.Icon = Nothing
        Me.grpMain.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.grpMain.LineWidth = 1
        Me.grpMain.Location = New System.Drawing.Point(0, 31)
        Me.grpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(874, 710)
        Me.grpMain.TabIndex = 1
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "F199"
        Me.grpMain.TitleFont = New System.Drawing.Font("Gulim", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpMain.TitleGraColor = System.Drawing.Color.DimGray
        Me.grpMain.UseGraColor = True
        Me.grpMain.UseRound = True
        Me.grpMain.UseTitle = False
        '
        'tbMain
        '
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tbMain.ItemSize = New System.Drawing.Size(150, 21)
        Me.tbMain.Location = New System.Drawing.Point(3, 21)
        Me.tbMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbMain.myBackColor = System.Drawing.Color.Black
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(868, 647)
        Me.tbMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbMain.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 668)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 39)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHealthInit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(761, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(104, 31)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Black
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnHealthInit
        '
        Me.btnHealthInit.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnHealthInit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHealthInit.FixedHeight = False
        Me.btnHealthInit.FixedWidth = False
        Me.btnHealthInit.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHealthInit.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnHealthInit.Location = New System.Drawing.Point(541, 4)
        Me.btnHealthInit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHealthInit.Name = "btnHealthInit"
        Me.btnHealthInit.Radius = 10
        Me.btnHealthInit.Size = New System.Drawing.Size(104, 31)
        Me.btnHealthInit.TabIndex = 2
        Me.btnHealthInit.Text = "F226"
        Me.btnHealthInit.UnCheckFillColor = System.Drawing.Color.Black
        Me.btnHealthInit.UseRound = True
        Me.btnHealthInit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(651, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(104, 31)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.Black
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(449, 36)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(79, 65)
        Me.Panel1.TabIndex = 1
        '
        'FormControlBox1
        '
        Me.FormControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox1.CloseBox = New System.Drawing.Rectangle(45, 1, 20, 20)
        Me.FormControlBox1.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.CriticalBox = New System.Drawing.Rectangle(-21, 1, 20, 20)
        Me.FormControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox1.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox1.isCritical = True
        Me.FormControlBox1.isLock = False
        Me.FormControlBox1.isPower = True
        Me.FormControlBox1.isRotation = True
        Me.FormControlBox1.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox1.Location = New System.Drawing.Point(805, 0)
        Me.FormControlBox1.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox1.MaxBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox1.MinBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox1.Name = "FormControlBox1"
        Me.FormControlBox1.PowerBox = New System.Drawing.Rectangle(-43, 1, 20, 20)
        Me.FormControlBox1.RotationBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ShowRectCnt = 3
        Me.FormControlBox1.Size = New System.Drawing.Size(67, 22)
        Me.FormControlBox1.TabIndex = 5
        Me.FormControlBox1.Text = "FormControlBox1"
        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseCriticalBox = True
        Me.FormControlBox1.UseDualBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseMaxBox = True
        Me.FormControlBox1.UseMinBox = True
        Me.FormControlBox1.UsePowerBox = True
        Me.FormControlBox1.UseRotationBox = False
        '
        'pnlAlertConfig
        '
        Me.pnlAlertConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAlertConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAlertConfig.Controls.Add(Me.FormControlBox1)
        Me.pnlAlertConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAlertConfig.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pnlAlertConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pnlAlertConfig.Location = New System.Drawing.Point(0, 0)
        Me.pnlAlertConfig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlAlertConfig.Name = "pnlAlertConfig"
        Me.pnlAlertConfig.Size = New System.Drawing.Size(874, 31)
        Me.pnlAlertConfig.TabIndex = 4
        Me.pnlAlertConfig.Text = "F199"
        '
        'frmAlertConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 748)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.pnlAlertConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAlertConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAlertConfig"
        Me.grpMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlAlertConfig.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbMain As FlatTabControl.FlatTabControl
    Friend WithEvents grpMain As eXperDB.BaseControls.GroupBox
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents pnlAlertConfig As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents btnHealthInit As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
End Class
