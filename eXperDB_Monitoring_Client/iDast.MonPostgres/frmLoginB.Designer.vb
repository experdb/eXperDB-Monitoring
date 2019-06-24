<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLoginB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginB))
        Me.pnlDesc = New eXperDB.BaseControls.Panel()
        Me.lblSub = New eXperDB.BaseControls.Label()
        Me.lblDesc3 = New eXperDB.BaseControls.Label()
        Me.lblDesc2 = New eXperDB.BaseControls.Label()
        Me.lblDesc1 = New eXperDB.BaseControls.Label()
        Me.lblMain = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label5 = New eXperDB.BaseControls.Label()
        Me.Label6 = New eXperDB.BaseControls.Label()
        Me.txtUserID = New eXperDB.BaseControls.TextBox()
        Me.txtPassword = New eXperDB.BaseControls.TextBox()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.Panel3 = New eXperDB.BaseControls.Panel()
        Me.txtServerIP = New eXperDB.BaseControls.TextBox()
        Me.Panel4 = New eXperDB.BaseControls.Panel()
        Me.Label7 = New eXperDB.BaseControls.Label()
        Me.btnServer = New eXperDB.BaseControls.Button()
        Me.chkRememberID = New eXperDB.BaseControls.CheckBox()
        Me.pnlDesc.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDesc
        '
        Me.pnlDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDesc.Controls.Add(Me.lblSub)
        Me.pnlDesc.Controls.Add(Me.lblDesc3)
        Me.pnlDesc.Controls.Add(Me.lblDesc2)
        Me.pnlDesc.Controls.Add(Me.lblDesc1)
        Me.pnlDesc.Controls.Add(Me.lblMain)
        Me.pnlDesc.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDesc.Location = New System.Drawing.Point(0, 0)
        Me.pnlDesc.Name = "pnlDesc"
        Me.pnlDesc.Size = New System.Drawing.Size(259, 362)
        Me.pnlDesc.TabIndex = 0
        '
        'lblSub
        '
        Me.lblSub.BackColor = System.Drawing.Color.Transparent
        Me.lblSub.FixedHeight = False
        Me.lblSub.FixedWidth = False
        Me.lblSub.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSub.Location = New System.Drawing.Point(12, 119)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(218, 19)
        Me.lblSub.TabIndex = 0
        Me.lblSub.Text = "for PostgreSQL"
        '
        'lblDesc3
        '
        Me.lblDesc3.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc3.FixedHeight = False
        Me.lblDesc3.FixedWidth = False
        Me.lblDesc3.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDesc3.Location = New System.Drawing.Point(12, 241)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(218, 19)
        Me.lblDesc3.TabIndex = 0
        Me.lblDesc3.Text = "eXperDB-Monitoring"
        '
        'lblDesc2
        '
        Me.lblDesc2.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc2.FixedHeight = False
        Me.lblDesc2.FixedWidth = False
        Me.lblDesc2.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDesc2.Location = New System.Drawing.Point(12, 208)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(218, 19)
        Me.lblDesc2.TabIndex = 0
        Me.lblDesc2.Text = "eXperDB-Monitoring"
        '
        'lblDesc1
        '
        Me.lblDesc1.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc1.FixedHeight = False
        Me.lblDesc1.FixedWidth = False
        Me.lblDesc1.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDesc1.Location = New System.Drawing.Point(12, 175)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(218, 19)
        Me.lblDesc1.TabIndex = 0
        Me.lblDesc1.Text = "eXperDB-Monitoring"
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.FixedHeight = False
        Me.lblMain.FixedWidth = False
        Me.lblMain.Font = New System.Drawing.Font("Roboto Condensed", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMain.Location = New System.Drawing.Point(9, 83)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(246, 43)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "eXperDB-Monitoring"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(259, 296)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(325, 66)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Roboto Condensed", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(165, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(157, 60)
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
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(3, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(156, 60)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FixedHeight = False
        Me.Label5.FixedWidth = False
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(284, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 24)
        Me.Label5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FixedHeight = False
        Me.Label6.FixedWidth = False
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(285, 212)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 4
        '
        'txtUserID
        '
        Me.txtUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtUserID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserID.code = False
        Me.txtUserID.FixedWidth = False
        Me.txtUserID.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.txtUserID.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserID.impossibleinput = ""
        Me.txtUserID.Location = New System.Drawing.Point(3, 9)
        Me.txtUserID.MaxByteLength = 16
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Necessary = False
        Me.txtUserID.PossibleInput = ""
        Me.txtUserID.Prefix = ""
        Me.txtUserID.Size = New System.Drawing.Size(144, 16)
        Me.txtUserID.StatusTip = ""
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = "User ID"
        Me.txtUserID.Value = ""
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.code = False
        Me.txtPassword.FixedWidth = False
        Me.txtPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPassword.impossibleinput = ""
        Me.txtPassword.Location = New System.Drawing.Point(3, 9)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Necessary = False
        Me.txtPassword.PossibleInput = ""
        Me.txtPassword.Prefix = ""
        Me.txtPassword.Size = New System.Drawing.Size(144, 14)
        Me.txtPassword.StatusTip = ""
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Text = "Password"
        Me.txtPassword.Value = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.txtUserID)
        Me.Panel2.Location = New System.Drawing.Point(320, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 32)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Location = New System.Drawing.Point(320, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 32)
        Me.Panel3.TabIndex = 5
        '
        'txtServerIP
        '
        Me.txtServerIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtServerIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtServerIP.BackColor = System.Drawing.Color.AliceBlue
        Me.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServerIP.code = False
        Me.txtServerIP.Enabled = False
        Me.txtServerIP.FixedWidth = False
        Me.txtServerIP.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.txtServerIP.ForeColor = System.Drawing.Color.DimGray
        Me.txtServerIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtServerIP.impossibleinput = ""
        Me.txtServerIP.Location = New System.Drawing.Point(3, 9)
        Me.txtServerIP.MaxByteLength = 16
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Necessary = False
        Me.txtServerIP.PossibleInput = ""
        Me.txtServerIP.Prefix = ""
        Me.txtServerIP.Size = New System.Drawing.Size(144, 16)
        Me.txtServerIP.StatusTip = ""
        Me.txtServerIP.TabIndex = 0
        Me.txtServerIP.TabStop = False
        Me.txtServerIP.Text = "Server Information"
        Me.txtServerIP.Value = ""
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel4.Controls.Add(Me.txtServerIP)
        Me.Panel4.Location = New System.Drawing.Point(320, 83)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(146, 32)
        Me.Panel4.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FixedHeight = False
        Me.Label7.FixedWidth = False
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(284, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 2
        '
        'btnServer
        '
        Me.btnServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnServer.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnServer.FixedHeight = False
        Me.btnServer.FixedWidth = False
        Me.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServer.ForeColor = System.Drawing.Color.White
        Me.btnServer.GraColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnServer.LineColor = System.Drawing.Color.Transparent
        Me.btnServer.Location = New System.Drawing.Point(477, 83)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Radius = 6
        Me.btnServer.Size = New System.Drawing.Size(91, 32)
        Me.btnServer.TabIndex = 2
        Me.btnServer.Text = "Server"
        Me.btnServer.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnServer.UseRound = True
        Me.btnServer.UseVisualStyleBackColor = False
        '
        'chkRememberID
        '
        Me.chkRememberID.AutoSize = True
        Me.chkRememberID.BackColor = System.Drawing.Color.Transparent
        Me.chkRememberID.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkRememberID.ForeColor = System.Drawing.Color.White
        Me.chkRememberID.LineColor = System.Drawing.Color.Gray
        Me.chkRememberID.Location = New System.Drawing.Point(476, 172)
        Me.chkRememberID.Name = "chkRememberID"
        Me.chkRememberID.Radius = 10
        Me.chkRememberID.Size = New System.Drawing.Size(101, 16)
        Me.chkRememberID.TabIndex = 4
        Me.chkRememberID.Text = "Remember ID"
        Me.chkRememberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkRememberID.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkRememberID.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.chkRememberID)
        Me.Controls.Add(Me.btnServer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlDesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1"
        Me.pnlDesc.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlDesc As eXperDB.BaseControls.Panel
    Friend WithEvents lblDesc3 As eXperDB.BaseControls.Label
    Friend WithEvents lblDesc2 As eXperDB.BaseControls.Label
    Friend WithEvents lblDesc1 As eXperDB.BaseControls.Label
    Friend WithEvents lblMain As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents Label5 As eXperDB.BaseControls.Label
    Friend WithEvents Label6 As eXperDB.BaseControls.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtUserID As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents Panel3 As eXperDB.BaseControls.Panel
    Friend WithEvents txtServerIP As eXperDB.BaseControls.TextBox
    Friend WithEvents Panel4 As eXperDB.BaseControls.Panel
    Friend WithEvents Label7 As eXperDB.BaseControls.Label
    Friend WithEvents btnServer As eXperDB.BaseControls.Button
    Friend WithEvents chkRememberID As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblSub As eXperDB.BaseControls.Label

End Class
