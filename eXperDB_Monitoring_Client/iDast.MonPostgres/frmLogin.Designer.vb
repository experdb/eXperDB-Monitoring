<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlLogin = New eXperDB.BaseControls.Panel()
        Me.lblLoginName = New eXperDB.BaseControls.Label()
        Me.lblLogo = New eXperDB.BaseControls.Label()
        Me.lblLogo2 = New eXperDB.BaseControls.Label()
        Me.lblLogo1 = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkRememberID = New eXperDB.BaseControls.CheckBox()
        Me.Label5 = New eXperDB.BaseControls.Label()
        Me.btnServer = New eXperDB.BaseControls.Button()
        Me.Label6 = New eXperDB.BaseControls.Label()
        Me.Label7 = New eXperDB.BaseControls.Label()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.txtUserID = New eXperDB.BaseControls.TextBox()
        Me.Panel4 = New eXperDB.BaseControls.Panel()
        Me.txtServerIP = New eXperDB.BaseControls.TextBox()
        Me.Panel3 = New eXperDB.BaseControls.Panel()
        Me.txtPassword = New eXperDB.BaseControls.TextBox()
        Me.chkRememberPW = New eXperDB.BaseControls.CheckBox()
        Me.pnlLogin.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlLogin.Controls.Add(Me.chkRememberPW)
        Me.pnlLogin.Controls.Add(Me.lblLoginName)
        Me.pnlLogin.Controls.Add(Me.lblLogo)
        Me.pnlLogin.Controls.Add(Me.lblLogo2)
        Me.pnlLogin.Controls.Add(Me.lblLogo1)
        Me.pnlLogin.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlLogin.Controls.Add(Me.chkRememberID)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.btnServer)
        Me.pnlLogin.Controls.Add(Me.Label6)
        Me.pnlLogin.Controls.Add(Me.Label7)
        Me.pnlLogin.Controls.Add(Me.Panel2)
        Me.pnlLogin.Controls.Add(Me.Panel4)
        Me.pnlLogin.Controls.Add(Me.Panel3)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogin.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Radius = 10
        Me.pnlLogin.Size = New System.Drawing.Size(379, 410)
        Me.pnlLogin.TabIndex = 7
        '
        'lblLoginName
        '
        Me.lblLoginName.FixedHeight = False
        Me.lblLoginName.FixedWidth = False
        Me.lblLoginName.Image = CType(resources.GetObject("lblLoginName.Image"), System.Drawing.Image)
        Me.lblLoginName.LineSpacing = 0.0!
        Me.lblLoginName.Location = New System.Drawing.Point(35, 33)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(306, 77)
        Me.lblLoginName.TabIndex = 10
        '
        'lblLogo
        '
        Me.lblLogo.FixedHeight = False
        Me.lblLogo.FixedWidth = False
        Me.lblLogo.Image = CType(resources.GetObject("lblLogo.Image"), System.Drawing.Image)
        Me.lblLogo.LineSpacing = 0.0!
        Me.lblLogo.Location = New System.Drawing.Point(35, 32)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(70, 77)
        Me.lblLogo.TabIndex = 9
        Me.lblLogo.Visible = False
        '
        'lblLogo2
        '
        Me.lblLogo2.FixedHeight = False
        Me.lblLogo2.FixedWidth = False
        Me.lblLogo2.Font = New System.Drawing.Font("Lobster", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLogo2.LineSpacing = 0.0!
        Me.lblLogo2.Location = New System.Drawing.Point(204, 52)
        Me.lblLogo2.Name = "lblLogo2"
        Me.lblLogo2.Size = New System.Drawing.Size(139, 45)
        Me.lblLogo2.TabIndex = 8
        Me.lblLogo2.Text = "Monitoring"
        Me.lblLogo2.Visible = False
        '
        'lblLogo1
        '
        Me.lblLogo1.FixedHeight = False
        Me.lblLogo1.FixedWidth = False
        Me.lblLogo1.Font = New System.Drawing.Font("Lobster", 20.25!)
        Me.lblLogo1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLogo1.LineSpacing = 0.0!
        Me.lblLogo1.Location = New System.Drawing.Point(100, 52)
        Me.lblLogo1.Name = "lblLogo1"
        Me.lblLogo1.Size = New System.Drawing.Size(150, 47)
        Me.lblLogo1.TabIndex = 8
        Me.lblLogo1.Text = "eXperDB"
        Me.lblLogo1.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogin, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 344)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(379, 66)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Roboto Condensed", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnClose.Location = New System.Drawing.Point(192, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(184, 60)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Roboto Condensed", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnLogin.Location = New System.Drawing.Point(3, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(183, 60)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chkRememberID
        '
        Me.chkRememberID.AutoSize = True
        Me.chkRememberID.BackColor = System.Drawing.Color.Transparent
        Me.chkRememberID.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkRememberID.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.chkRememberID.LineColor = System.Drawing.Color.Gray
        Me.chkRememberID.Location = New System.Drawing.Point(249, 228)
        Me.chkRememberID.Name = "chkRememberID"
        Me.chkRememberID.Radius = 10
        Me.chkRememberID.Size = New System.Drawing.Size(101, 16)
        Me.chkRememberID.TabIndex = 4
        Me.chkRememberID.Text = "Remember ID"
        Me.chkRememberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkRememberID.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkRememberID.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FixedHeight = False
        Me.Label5.FixedWidth = False
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.LineSpacing = 0.0!
        Me.Label5.Location = New System.Drawing.Point(57, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 24)
        Me.Label5.TabIndex = 3
        '
        'btnServer
        '
        Me.btnServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnServer.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnServer.FixedHeight = False
        Me.btnServer.FixedWidth = False
        Me.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServer.ForeColor = System.Drawing.Color.White
        Me.btnServer.GraColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnServer.LineColor = System.Drawing.Color.Transparent
        Me.btnServer.Location = New System.Drawing.Point(247, 139)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Radius = 6
        Me.btnServer.Size = New System.Drawing.Size(91, 32)
        Me.btnServer.TabIndex = 2
        Me.btnServer.Text = "Server"
        Me.btnServer.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnServer.UseRound = True
        Me.btnServer.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FixedHeight = False
        Me.Label6.FixedWidth = False
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.LineSpacing = 0.0!
        Me.Label6.Location = New System.Drawing.Point(58, 268)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FixedHeight = False
        Me.Label7.FixedWidth = False
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.LineSpacing = 0.0!
        Me.Label7.Location = New System.Drawing.Point(57, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtUserID)
        Me.Panel2.GraColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(93, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Radius = 8
        Me.Panel2.Size = New System.Drawing.Size(147, 32)
        Me.Panel2.TabIndex = 3
        Me.Panel2.UseRound = True
        '
        'txtUserID
        '
        Me.txtUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserID.code = False
        Me.txtUserID.FixedWidth = False
        Me.txtUserID.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.txtUserID.ForeColor = System.Drawing.Color.Gray
        Me.txtUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserID.impossibleinput = ""
        Me.txtUserID.Location = New System.Drawing.Point(5, 9)
        Me.txtUserID.MaxByteLength = 16
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Necessary = False
        Me.txtUserID.PossibleInput = ""
        Me.txtUserID.Prefix = ""
        Me.txtUserID.Size = New System.Drawing.Size(140, 16)
        Me.txtUserID.StatusTip = ""
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = "User ID"
        Me.txtUserID.Value = ""
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtServerIP)
        Me.Panel4.GraColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(93, 139)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Radius = 8
        Me.Panel4.Size = New System.Drawing.Size(147, 32)
        Me.Panel4.TabIndex = 1
        Me.Panel4.UseRound = True
        '
        'txtServerIP
        '
        Me.txtServerIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtServerIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtServerIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServerIP.code = False
        Me.txtServerIP.Enabled = False
        Me.txtServerIP.FixedWidth = False
        Me.txtServerIP.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.txtServerIP.ForeColor = System.Drawing.Color.Black
        Me.txtServerIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtServerIP.impossibleinput = ""
        Me.txtServerIP.Location = New System.Drawing.Point(5, 9)
        Me.txtServerIP.MaxByteLength = 16
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Necessary = False
        Me.txtServerIP.PossibleInput = ""
        Me.txtServerIP.Prefix = ""
        Me.txtServerIP.Size = New System.Drawing.Size(140, 16)
        Me.txtServerIP.StatusTip = ""
        Me.txtServerIP.TabIndex = 0
        Me.txtServerIP.TabStop = False
        Me.txtServerIP.Text = "Server Information"
        Me.txtServerIP.Value = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.GraColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(93, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Radius = 8
        Me.Panel3.Size = New System.Drawing.Size(147, 32)
        Me.Panel3.TabIndex = 5
        Me.Panel3.UseRound = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.code = False
        Me.txtPassword.FixedWidth = False
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPassword.impossibleinput = ""
        Me.txtPassword.Location = New System.Drawing.Point(5, 9)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Necessary = False
        Me.txtPassword.PossibleInput = ""
        Me.txtPassword.Prefix = ""
        Me.txtPassword.Size = New System.Drawing.Size(140, 14)
        Me.txtPassword.StatusTip = ""
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Text = "Password"
        Me.txtPassword.Value = ""
        '
        'chkRememberPW
        '
        Me.chkRememberPW.AutoSize = True
        Me.chkRememberPW.BackColor = System.Drawing.Color.Transparent
        Me.chkRememberPW.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkRememberPW.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.chkRememberPW.LineColor = System.Drawing.Color.Gray
        Me.chkRememberPW.Location = New System.Drawing.Point(249, 273)
        Me.chkRememberPW.Name = "chkRememberPW"
        Me.chkRememberPW.Radius = 10
        Me.chkRememberPW.Size = New System.Drawing.Size(108, 16)
        Me.chkRememberPW.TabIndex = 11
        Me.chkRememberPW.Text = "Remember PW"
        Me.chkRememberPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkRememberPW.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkRememberPW.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(379, 410)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As eXperDB.BaseControls.Label
    Friend WithEvents Label6 As eXperDB.BaseControls.Label
    Friend WithEvents txtUserID As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents Panel3 As eXperDB.BaseControls.Panel
    Friend WithEvents txtServerIP As eXperDB.BaseControls.TextBox
    Friend WithEvents Panel4 As eXperDB.BaseControls.Panel
    Friend WithEvents Label7 As eXperDB.BaseControls.Label
    Friend WithEvents btnServer As eXperDB.BaseControls.Button
    Friend WithEvents chkRememberID As eXperDB.BaseControls.CheckBox
    Friend WithEvents pnlLogin As eXperDB.BaseControls.Panel
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblLogo As eXperDB.BaseControls.Label
    Friend WithEvents lblLogo1 As eXperDB.BaseControls.Label
    Friend WithEvents lblLoginName As eXperDB.BaseControls.Label
    Friend WithEvents lblLogo2 As eXperDB.BaseControls.Label
    Friend WithEvents chkRememberPW As eXperDB.BaseControls.CheckBox

End Class
