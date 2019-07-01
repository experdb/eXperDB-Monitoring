<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagement))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPercentageColumn1 = New eXperDB.Controls.DataGridViewPercentageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpUserConfigMain = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvUserLst = New eXperDB.BaseControls.DataGridView()
        Me.coldgvUserLstID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstTel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstNotiPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstAdmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstLastLogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstLock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstPWDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldgvUserLstDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPrivApply = New eXperDB.BaseControls.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrivileges = New System.Windows.Forms.Label()
        Me.chkAll = New eXperDB.BaseControls.CheckBox()
        Me.dgvPrivileges = New eXperDB.BaseControls.DataGridView()
        Me.coldgvPrivilegesGroupID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvPrivilegesGroupName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvPrivilegesEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldgvPrivilegesDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tlpUserlist = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUserCreate = New eXperDB.BaseControls.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserList = New System.Windows.Forms.Label()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpUserConfigMain.SuspendLayout()
        CType(Me.dgvUserLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvPrivileges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpUserlist.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.FillWeight = 131.1306!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Alert Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.FillWeight = 171.0869!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Biz day"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 120.5725!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Biz hour"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewPercentageColumn1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.DataGridViewPercentageColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPercentageColumn1.HeaderText = "Alert Level"
        Me.DataGridViewPercentageColumn1.MinimumWidth = 180
        Me.DataGridViewPercentageColumn1.Name = "DataGridViewPercentageColumn1"
        Me.DataGridViewPercentageColumn1.ReadOnly = True
        Me.DataGridViewPercentageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPercentageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewPercentageColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RETENTION_TIME"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "P"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Alert Level"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RETENTION_TIME"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Alert duration"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CHECK_USER_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cycle"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 95
        '
        'tlpUserConfigMain
        '
        Me.tlpUserConfigMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpUserConfigMain.ColumnCount = 3
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.Controls.Add(Me.dgvUserLst, 0, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.tlpUserConfigMain.Controls.Add(Me.dgvPrivileges, 0, 4)
        Me.tlpUserConfigMain.Controls.Add(Me.tlpUserlist, 0, 0)
        Me.tlpUserConfigMain.Controls.Add(Me.Panel1, 2, 1)
        Me.tlpUserConfigMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserConfigMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserConfigMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUserConfigMain.Name = "tlpUserConfigMain"
        Me.tlpUserConfigMain.RowCount = 7
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 316.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpUserConfigMain.Size = New System.Drawing.Size(1161, 692)
        Me.tlpUserConfigMain.TabIndex = 3
        '
        'dgvUserLst
        '
        Me.dgvUserLst.AllowUserToAddRows = False
        Me.dgvUserLst.AllowUserToDeleteRows = False
        Me.dgvUserLst.AllowUserToResizeRows = False
        Me.dgvUserLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvUserLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUserLst.ColumnHeadersHeight = 24
        Me.dgvUserLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUserLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvUserLstID, Me.coldgvUserLstName, Me.coldgvUserLstPassword, Me.coldgvUserLstTel, Me.coldgvUserLstTel2, Me.coldgvUserLstNotiPhone, Me.coldgvUserLstEmail, Me.coldgvUserLstDept, Me.coldgvUserLstAdmin, Me.coldgvUserLstLastLogin, Me.coldgvUserLstLock, Me.coldgvUserLstPWDT, Me.coldgvUserLstEdit, Me.coldgvUserLstDelete})
        Me.tlpUserConfigMain.SetColumnSpan(Me.dgvUserLst, 3)
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserLst.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUserLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserLst.EnableHeadersVisualStyles = False
        Me.dgvUserLst.GridColor = System.Drawing.Color.Black
        Me.dgvUserLst.Location = New System.Drawing.Point(3, 43)
        Me.dgvUserLst.Name = "dgvUserLst"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUserLst.RowHeadersVisible = False
        Me.dgvUserLst.RowTemplate.Height = 23
        Me.dgvUserLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserLst.Size = New System.Drawing.Size(1155, 294)
        Me.dgvUserLst.TabIndex = 25
        Me.dgvUserLst.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvUserLst.UseTagValueMatchColor = True
        '
        'coldgvUserLstID
        '
        Me.coldgvUserLstID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvUserLstID.DataPropertyName = "USER_ID"
        Me.coldgvUserLstID.HeaderText = "F347"
        Me.coldgvUserLstID.MinimumWidth = 90
        Me.coldgvUserLstID.Name = "coldgvUserLstID"
        Me.coldgvUserLstID.ReadOnly = True
        Me.coldgvUserLstID.Width = 90
        '
        'coldgvUserLstName
        '
        Me.coldgvUserLstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvUserLstName.DataPropertyName = "USER_NAME"
        Me.coldgvUserLstName.HeaderText = "F348"
        Me.coldgvUserLstName.MinimumWidth = 100
        Me.coldgvUserLstName.Name = "coldgvUserLstName"
        Me.coldgvUserLstName.ReadOnly = True
        Me.coldgvUserLstName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'coldgvUserLstPassword
        '
        Me.coldgvUserLstPassword.DataPropertyName = "USER_PASSWORD"
        Me.coldgvUserLstPassword.FillWeight = 45.0!
        Me.coldgvUserLstPassword.HeaderText = "F342"
        Me.coldgvUserLstPassword.MinimumWidth = 100
        Me.coldgvUserLstPassword.Name = "coldgvUserLstPassword"
        Me.coldgvUserLstPassword.ReadOnly = True
        Me.coldgvUserLstPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvUserLstPassword.Visible = False
        '
        'coldgvUserLstTel
        '
        Me.coldgvUserLstTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvUserLstTel.DataPropertyName = "USER_PHONE"
        Me.coldgvUserLstTel.HeaderText = "F349"
        Me.coldgvUserLstTel.MinimumWidth = 108
        Me.coldgvUserLstTel.Name = "coldgvUserLstTel"
        Me.coldgvUserLstTel.ReadOnly = True
        Me.coldgvUserLstTel.Width = 108
        '
        'coldgvUserLstTel2
        '
        Me.coldgvUserLstTel2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvUserLstTel2.DataPropertyName = "USER_PHONE2"
        Me.coldgvUserLstTel2.HeaderText = "F349"
        Me.coldgvUserLstTel2.MinimumWidth = 108
        Me.coldgvUserLstTel2.Name = "coldgvUserLstTel2"
        Me.coldgvUserLstTel2.ReadOnly = True
        Me.coldgvUserLstTel2.Width = 108
        '
        'coldgvUserLstNotiPhone
        '
        Me.coldgvUserLstNotiPhone.DataPropertyName = "USER_NOTI_PHONE"
        Me.coldgvUserLstNotiPhone.HeaderText = "Noti Phone"
        Me.coldgvUserLstNotiPhone.Name = "coldgvUserLstNotiPhone"
        Me.coldgvUserLstNotiPhone.ReadOnly = True
        Me.coldgvUserLstNotiPhone.Visible = False
        Me.coldgvUserLstNotiPhone.Width = 80
        '
        'coldgvUserLstEmail
        '
        Me.coldgvUserLstEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvUserLstEmail.DataPropertyName = "USER_EMAIL"
        Me.coldgvUserLstEmail.HeaderText = "F350"
        Me.coldgvUserLstEmail.MinimumWidth = 140
        Me.coldgvUserLstEmail.Name = "coldgvUserLstEmail"
        Me.coldgvUserLstEmail.ReadOnly = True
        '
        'coldgvUserLstDept
        '
        Me.coldgvUserLstDept.DataPropertyName = "USER_DEPT_NAME"
        Me.coldgvUserLstDept.HeaderText = "F915"
        Me.coldgvUserLstDept.MinimumWidth = 110
        Me.coldgvUserLstDept.Name = "coldgvUserLstDept"
        Me.coldgvUserLstDept.ReadOnly = True
        Me.coldgvUserLstDept.Visible = False
        Me.coldgvUserLstDept.Width = 110
        '
        'coldgvUserLstAdmin
        '
        Me.coldgvUserLstAdmin.DataPropertyName = "USER_ADMIN"
        Me.coldgvUserLstAdmin.HeaderText = "F920"
        Me.coldgvUserLstAdmin.MinimumWidth = 70
        Me.coldgvUserLstAdmin.Name = "coldgvUserLstAdmin"
        Me.coldgvUserLstAdmin.ReadOnly = True
        Me.coldgvUserLstAdmin.Width = 70
        '
        'coldgvUserLstLastLogin
        '
        Me.coldgvUserLstLastLogin.DataPropertyName = "LAST_LOGIN_DT"
        Me.coldgvUserLstLastLogin.HeaderText = "Last Login"
        Me.coldgvUserLstLastLogin.MinimumWidth = 130
        Me.coldgvUserLstLastLogin.Name = "coldgvUserLstLastLogin"
        Me.coldgvUserLstLastLogin.ReadOnly = True
        Me.coldgvUserLstLastLogin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvUserLstLastLogin.Width = 130
        '
        'coldgvUserLstLock
        '
        Me.coldgvUserLstLock.DataPropertyName = "IS_LOCKED_TF"
        Me.coldgvUserLstLock.HeaderText = "Locked"
        Me.coldgvUserLstLock.MinimumWidth = 90
        Me.coldgvUserLstLock.Name = "coldgvUserLstLock"
        Me.coldgvUserLstLock.ReadOnly = True
        Me.coldgvUserLstLock.Width = 90
        '
        'coldgvUserLstPWDT
        '
        Me.coldgvUserLstPWDT.DataPropertyName = "SET_PW_DT"
        Me.coldgvUserLstPWDT.HeaderText = "PW Change"
        Me.coldgvUserLstPWDT.MinimumWidth = 125
        Me.coldgvUserLstPWDT.Name = "coldgvUserLstPWDT"
        Me.coldgvUserLstPWDT.ReadOnly = True
        Me.coldgvUserLstPWDT.Width = 125
        '
        'coldgvUserLstEdit
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        Me.coldgvUserLstEdit.DefaultCellStyle = DataGridViewCellStyle6
        Me.coldgvUserLstEdit.HeaderText = ""
        Me.coldgvUserLstEdit.Image = CType(resources.GetObject("coldgvUserLstEdit.Image"), System.Drawing.Image)
        Me.coldgvUserLstEdit.MinimumWidth = 39
        Me.coldgvUserLstEdit.Name = "coldgvUserLstEdit"
        Me.coldgvUserLstEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvUserLstEdit.Width = 39
        '
        'coldgvUserLstDelete
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.NullValue = Nothing
        Me.coldgvUserLstDelete.DefaultCellStyle = DataGridViewCellStyle7
        Me.coldgvUserLstDelete.HeaderText = ""
        Me.coldgvUserLstDelete.Image = CType(resources.GetObject("coldgvUserLstDelete.Image"), System.Drawing.Image)
        Me.coldgvUserLstDelete.MinimumWidth = 39
        Me.coldgvUserLstDelete.Name = "coldgvUserLstDelete"
        Me.coldgvUserLstDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvUserLstDelete.Width = 39
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.tlpUserConfigMain.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPrivApply, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrivileges, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAll, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 353)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1155, 34)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'btnPrivApply
        '
        Me.btnPrivApply.BackColor = System.Drawing.Color.LightGray
        Me.btnPrivApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrivApply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrivApply.FixedHeight = False
        Me.btnPrivApply.FixedWidth = False
        Me.btnPrivApply.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnPrivApply.ForeColor = System.Drawing.Color.White
        Me.btnPrivApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrivApply.Image = CType(resources.GetObject("btnPrivApply.Image"), System.Drawing.Image)
        Me.btnPrivApply.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnPrivApply.Location = New System.Drawing.Point(1122, 3)
        Me.btnPrivApply.Name = "btnPrivApply"
        Me.btnPrivApply.Radius = 5
        Me.btnPrivApply.Size = New System.Drawing.Size(30, 28)
        Me.btnPrivApply.TabIndex = 4
        Me.btnPrivApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrivApply.UseVisualStyleBackColor = False
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
        Me.Label2.Size = New System.Drawing.Size(34, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "      "
        '
        'lblPrivileges
        '
        Me.lblPrivileges.AutoSize = True
        Me.lblPrivileges.BackColor = System.Drawing.Color.Transparent
        Me.lblPrivileges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrivileges.ForeColor = System.Drawing.Color.White
        Me.lblPrivileges.Location = New System.Drawing.Point(43, 0)
        Me.lblPrivileges.Name = "lblPrivileges"
        Me.lblPrivileges.Size = New System.Drawing.Size(965, 34)
        Me.lblPrivileges.TabIndex = 3
        Me.lblPrivileges.Text = "F918"
        Me.lblPrivileges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkAll, 3)
        Me.chkAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkAll.ForeColor = System.Drawing.Color.White
        Me.chkAll.LineColor = System.Drawing.Color.Gray
        Me.chkAll.Location = New System.Drawing.Point(1014, 3)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Radius = 10
        Me.chkAll.Size = New System.Drawing.Size(102, 28)
        Me.chkAll.TabIndex = 5
        Me.chkAll.Text = "F945"
        Me.chkAll.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'dgvPrivileges
        '
        Me.dgvPrivileges.AllowUserToAddRows = False
        Me.dgvPrivileges.AllowUserToDeleteRows = False
        Me.dgvPrivileges.AllowUserToResizeRows = False
        Me.dgvPrivileges.BackgroundColor = System.Drawing.Color.Black
        Me.dgvPrivileges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrivileges.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPrivileges.ColumnHeadersHeight = 24
        Me.dgvPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrivileges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvPrivilegesGroupID, Me.coldgvPrivilegesGroupName, Me.coldgvPrivilegesEdit, Me.coldgvPrivilegesDelete})
        Me.tlpUserConfigMain.SetColumnSpan(Me.dgvPrivileges, 3)
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrivileges.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvPrivileges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPrivileges.EnableHeadersVisualStyles = False
        Me.dgvPrivileges.GridColor = System.Drawing.Color.Black
        Me.dgvPrivileges.Location = New System.Drawing.Point(3, 393)
        Me.dgvPrivileges.Name = "dgvPrivileges"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrivileges.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvPrivileges.RowHeadersVisible = False
        Me.dgvPrivileges.RowTemplate.Height = 23
        Me.dgvPrivileges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrivileges.Size = New System.Drawing.Size(1155, 310)
        Me.dgvPrivileges.TabIndex = 23
        Me.dgvPrivileges.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvPrivileges.UseTagValueMatchColor = True
        '
        'coldgvPrivilegesGroupID
        '
        Me.coldgvPrivilegesGroupID.DataPropertyName = "GROUP_ID"
        Me.coldgvPrivilegesGroupID.FillWeight = 20.0!
        Me.coldgvPrivilegesGroupID.HeaderText = "F019"
        Me.coldgvPrivilegesGroupID.MinimumWidth = 100
        Me.coldgvPrivilegesGroupID.Name = "coldgvPrivilegesGroupID"
        Me.coldgvPrivilegesGroupID.ReadOnly = True
        Me.coldgvPrivilegesGroupID.Visible = False
        '
        'coldgvPrivilegesGroupName
        '
        Me.coldgvPrivilegesGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvPrivilegesGroupName.DataPropertyName = "GROUP_NAME"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.coldgvPrivilegesGroupName.DefaultCellStyle = DataGridViewCellStyle11
        Me.coldgvPrivilegesGroupName.HeaderText = "F026"
        Me.coldgvPrivilegesGroupName.MinimumWidth = 120
        Me.coldgvPrivilegesGroupName.Name = "coldgvPrivilegesGroupName"
        Me.coldgvPrivilegesGroupName.ReadOnly = True
        Me.coldgvPrivilegesGroupName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvPrivilegesGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coldgvPrivilegesEdit
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = Nothing
        Me.coldgvPrivilegesEdit.DefaultCellStyle = DataGridViewCellStyle12
        Me.coldgvPrivilegesEdit.HeaderText = ""
        Me.coldgvPrivilegesEdit.Image = CType(resources.GetObject("coldgvPrivilegesEdit.Image"), System.Drawing.Image)
        Me.coldgvPrivilegesEdit.MinimumWidth = 39
        Me.coldgvPrivilegesEdit.Name = "coldgvPrivilegesEdit"
        Me.coldgvPrivilegesEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvPrivilegesEdit.Visible = False
        Me.coldgvPrivilegesEdit.Width = 39
        '
        'coldgvPrivilegesDelete
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.NullValue = Nothing
        Me.coldgvPrivilegesDelete.DefaultCellStyle = DataGridViewCellStyle13
        Me.coldgvPrivilegesDelete.HeaderText = ""
        Me.coldgvPrivilegesDelete.Image = CType(resources.GetObject("coldgvPrivilegesDelete.Image"), System.Drawing.Image)
        Me.coldgvPrivilegesDelete.MinimumWidth = 39
        Me.coldgvPrivilegesDelete.Name = "coldgvPrivilegesDelete"
        Me.coldgvPrivilegesDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvPrivilegesDelete.Visible = False
        Me.coldgvPrivilegesDelete.Width = 39
        '
        'tlpUserlist
        '
        Me.tlpUserlist.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserlist.ColumnCount = 5
        Me.tlpUserConfigMain.SetColumnSpan(Me.tlpUserlist, 3)
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpUserlist.Controls.Add(Me.btnUserCreate, 4, 0)
        Me.tlpUserlist.Controls.Add(Me.Label4, 0, 0)
        Me.tlpUserlist.Controls.Add(Me.lblUserList, 1, 0)
        Me.tlpUserlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserlist.Location = New System.Drawing.Point(3, 3)
        Me.tlpUserlist.Name = "tlpUserlist"
        Me.tlpUserlist.RowCount = 1
        Me.tlpUserlist.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserlist.Size = New System.Drawing.Size(1155, 34)
        Me.tlpUserlist.TabIndex = 21
        '
        'btnUserCreate
        '
        Me.btnUserCreate.BackColor = System.Drawing.Color.LightGray
        Me.btnUserCreate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUserCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserCreate.FixedHeight = False
        Me.btnUserCreate.FixedWidth = False
        Me.btnUserCreate.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnUserCreate.ForeColor = System.Drawing.Color.White
        Me.btnUserCreate.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUserCreate.Image = CType(resources.GetObject("btnUserCreate.Image"), System.Drawing.Image)
        Me.btnUserCreate.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnUserCreate.Location = New System.Drawing.Point(1122, 3)
        Me.btnUserCreate.Name = "btnUserCreate"
        Me.btnUserCreate.Radius = 5
        Me.btnUserCreate.Size = New System.Drawing.Size(30, 28)
        Me.btnUserCreate.TabIndex = 4
        Me.btnUserCreate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUserCreate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 34)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "      "
        '
        'lblUserList
        '
        Me.lblUserList.AutoSize = True
        Me.lblUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUserList.ForeColor = System.Drawing.Color.White
        Me.lblUserList.Location = New System.Drawing.Point(43, 0)
        Me.lblUserList.Name = "lblUserList"
        Me.lblUserList.Size = New System.Drawing.Size(1001, 34)
        Me.lblUserList.TabIndex = 3
        Me.lblUserList.Text = "F351"
        Me.lblUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Radius = 10
        Me.Panel1.Size = New System.Drawing.Size(194, 4)
        Me.Panel1.TabIndex = 26
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.tlpUserConfigMain)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserManagement"
        Me.Size = New System.Drawing.Size(1161, 692)
        Me.tlpUserConfigMain.ResumeLayout(false)
        CType(Me.dgvUserLst,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgvPrivileges,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpUserlist.ResumeLayout(false)
        Me.tlpUserlist.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPercentageColumn1 As eXperDB.Controls.DataGridViewPercentageColumn
    Friend WithEvents tlpUserConfigMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPrivApply As eXperDB.BaseControls.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPrivileges As System.Windows.Forms.Label
    Friend WithEvents dgvPrivileges As eXperDB.BaseControls.DataGridView
    Friend WithEvents tlpUserlist As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnUserCreate As eXperDB.BaseControls.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUserList As System.Windows.Forms.Label
    Friend WithEvents dgvUserLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents coldgvPrivilegesGroupID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvPrivilegesGroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvPrivilegesEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents coldgvPrivilegesDelete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents coldgvUserLstID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstTel2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstNotiPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstDept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstAdmin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstLastLogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstLock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstPWDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents coldgvUserLstDelete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents chkAll As eXperDB.BaseControls.CheckBox

End Class
