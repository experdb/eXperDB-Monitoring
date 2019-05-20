<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgbox))
        Me.lblMessage = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.btn1 = New eXperDB.BaseControls.Button()
        Me.btn2 = New eXperDB.BaseControls.Button()
        Me.btn3 = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Gray
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.FixedHeight = False
        Me.lblMessage.FixedWidth = False
        Me.lblMessage.Font = New System.Drawing.Font("Gulim", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(3, 53)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(3)
        Me.lblMessage.Size = New System.Drawing.Size(503, 135)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 188)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(503, 45)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn1)
        Me.Panel1.Controls.Add(Me.btn2)
        Me.Panel1.Controls.Add(Me.btn3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(103, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 39)
        Me.Panel1.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn1.FixedHeight = False
        Me.btn1.FixedWidth = False
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn1.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn1.Location = New System.Drawing.Point(67, 0)
        Me.btn1.Name = "btn1"
        Me.btn1.Radius = 10
        Me.btn1.Size = New System.Drawing.Size(110, 39)
        Me.btn1.TabIndex = 3
        Me.btn1.Text = "btn1"
        Me.btn1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn1.UseRound = True
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn2.FixedHeight = False
        Me.btn2.FixedWidth = False
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn2.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn2.Location = New System.Drawing.Point(177, 0)
        Me.btn2.Name = "btn2"
        Me.btn2.Radius = 10
        Me.btn2.Size = New System.Drawing.Size(110, 39)
        Me.btn2.TabIndex = 4
        Me.btn2.Text = "btn2"
        Me.btn2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn2.UseRound = True
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn3.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn3.FixedHeight = False
        Me.btn3.FixedWidth = False
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn3.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btn3.Location = New System.Drawing.Point(287, 0)
        Me.btn3.Name = "btn3"
        Me.btn3.Radius = 10
        Me.btn3.Size = New System.Drawing.Size(110, 39)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "btn3"
        Me.btn3.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn3.UseRound = True
        Me.btn3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 50)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(457, 50)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'frmMsgbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(509, 236)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgbox"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agent Message"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents btn1 As eXperDB.BaseControls.Button
    Friend WithEvents btn2 As eXperDB.BaseControls.Button
    Friend WithEvents btn3 As eXperDB.BaseControls.Button
End Class
