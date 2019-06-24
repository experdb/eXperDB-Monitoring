<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroup))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGroupName = New eXperDB.BaseControls.Label()
        Me.txtGroupName = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(352, 44)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(306, 44)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label1.Size = New System.Drawing.Size(34, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 161)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(352, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(178, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAct
        '
        Me.btnAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.Transparent
        Me.btnAct.Location = New System.Drawing.Point(98, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 0
        Me.btnAct.Text = "F140/F141"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.tlpSvrChk.Controls.Add(Me.lblGroupName, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtGroupName, 2, 1)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 47)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 3
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(352, 114)
        Me.tlpSvrChk.TabIndex = 20
        '
        'lblGroupName
        '
        Me.lblGroupName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGroupName.FixedHeight = False
        Me.lblGroupName.FixedWidth = False
        Me.lblGroupName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGroupName.ForeColor = System.Drawing.Color.White
        Me.lblGroupName.LineSpacing = 0.0!
        Me.lblGroupName.Location = New System.Drawing.Point(13, 50)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(94, 20)
        Me.lblGroupName.TabIndex = 2
        Me.lblGroupName.Text = "F310"
        Me.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroupName
        '
        Me.txtGroupName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtGroupName.code = False
        Me.txtGroupName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtGroupName.FixedWidth = False
        Me.txtGroupName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGroupName.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtGroupName.Location = New System.Drawing.Point(113, 46)
        Me.txtGroupName.MaxByteLength = 30
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Necessary = True
        Me.txtGroupName.PossibleInput = ""
        Me.txtGroupName.Prefix = ""
        Me.txtGroupName.Size = New System.Drawing.Size(134, 21)
        Me.txtGroupName.StatusTip = ""
        Me.txtGroupName.TabIndex = 1
        Me.txtGroupName.Value = ""
        '
        'frmGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(358, 209)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGroup"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Information"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblGroupName As eXperDB.BaseControls.Label
    Friend WithEvents txtGroupName As eXperDB.BaseControls.TextBox
End Class
