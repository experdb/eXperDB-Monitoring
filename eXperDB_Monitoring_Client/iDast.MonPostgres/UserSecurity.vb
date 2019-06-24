Public Class UserSecurity

    Private _clsQuery As clsQuerys
    Private _valueChanged As Boolean = False
    ReadOnly Property valueChanged As Boolean
        Get
            Return _valueChanged
        End Get
    End Property
    Public Sub New(ByRef odbcConn As eXperDBODBC)
        ' 이 호출은 디자이너에 필요합니다
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _clsQuery = New clsQuerys(odbcConn)
        initForm()
    End Sub
    Private Sub initForm()
        lblAccountPolicy.Text = p_clsMsgData.fn_GetData("F924")
        lblLockAccountFail.Text = p_clsMsgData.fn_GetData("F925")
        lblLockTimeout.Text = p_clsMsgData.fn_GetData("F926")
        lblLockAccountIdle.Text = p_clsMsgData.fn_GetData("F927")
        lblDupLogin.Text = p_clsMsgData.fn_GetData("F928")
        lblPasswordPolicy.Text = p_clsMsgData.fn_GetData("F933")
        lblCombine.Text = p_clsMsgData.fn_GetData("F929")
        lblPasswordLength.Text = p_clsMsgData.fn_GetData("F930")
        lblPasswordExpires.Text = p_clsMsgData.fn_GetData("F931")
        lblAlertPasswordExpires.Text = p_clsMsgData.fn_GetData("F932")
        lblAllowlist.Text = p_clsMsgData.fn_GetData("F934")
        coldgvWhitelistUserID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvWhitelistUserName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvWhitelistIPAddress.HeaderText = p_clsMsgData.fn_GetData("F935")
        btnSave.Text = p_clsMsgData.fn_GetData("F014")
        'Me.dgvUserLst.AutoGenerateColumns = False
        Me.ttChart.SetToolTip(Me.btnAddIP, p_clsMsgData.fn_GetData("F016"))
    End Sub

    Private Sub UserSecurity_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadSecurityConfig()
        ReadAllowList()
    End Sub

    Private Sub btnAddIP_Click(sender As Object, e As EventArgs) Handles btnAddIP.Click
        Dim frmAI As New frmAllowIP(-1)
        If frmAI.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strUserID As String = ""
            Dim strUserName As String = ""
            Dim strIP As String = ""
            Dim strCIDR As String = ""
            frmAI.rtnValue(strUserID, strUserName, strIP, strCIDR)
            AddData(-1, strUserID, strUserName, strIP, strCIDR)
            _valueChanged = True
        End If
        'lblAllowlist.Text = p_clsMsgData.fn_GetData("F351") + " ( " + nCount.ToString + " ) "
    End Sub

    Private Sub nudLockAccountFail_ValueChanged(sender As Object, e As EventArgs) Handles nudLockAccountFail.ValueChanged, nudLockTimeout.ValueChanged, _
                nudLockAccountIdle.ValueChanged, nudPasswordLength.ValueChanged, nudPasswordExpires.ValueChanged, nudAlertPasswordExpires.ValueChanged, chkDupLogin.CheckedChanged, chkCombine.CheckedChanged
        If nudLockAccountFail.Tag IsNot Nothing AndAlso Not nudLockAccountFail.Value.Equals(nudLockAccountFail.Tag) _
            Or nudLockTimeout.Tag IsNot Nothing AndAlso Not nudLockTimeout.Value.Equals(nudLockTimeout.Tag) _
            Or nudLockAccountIdle.Tag IsNot Nothing AndAlso Not nudLockAccountIdle.Value.Equals(nudLockAccountIdle.Tag) _
            Or nudPasswordLength.Tag IsNot Nothing AndAlso Not nudPasswordLength.Value.Equals(nudPasswordLength.Tag) _
            Or nudPasswordExpires.Tag IsNot Nothing AndAlso Not nudPasswordExpires.Value.Equals(nudPasswordExpires.Tag) _
            Or nudAlertPasswordExpires.Tag IsNot Nothing AndAlso Not nudAlertPasswordExpires.Value.Equals(nudAlertPasswordExpires.Tag) _
            Or chkCombine.Tag IsNot Nothing AndAlso Not chkCombine.Checked.Equals(chkCombine.Tag) _
            Or chkDupLogin.Tag IsNot Nothing AndAlso Not chkDupLogin.Checked.Equals(chkDupLogin.Tag) Then
            _valueChanged = True
        End If
    End Sub

    Private Sub dgvWhitelist_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvWhitelist.RowStateChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Apply()
    End Sub

    Private Sub dgvWhitelist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWhitelist.CellClick
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex = coldgvWhitelistDelete.Index Then
            Dim currencyManager As CurrencyManager = TryCast(BindingContext(dgvWhitelist.DataSource), CurrencyManager)
            currencyManager.SuspendBinding()
            dgvWhitelist.Rows(e.RowIndex).Visible = False
            currencyManager.ResumeBinding()
            _valueChanged = True
        End If
    End Sub

    Public Sub Apply()
        Try
            If _clsQuery.BeginTran() Then
                SaveSecurityConfig()
                SaveAllowIP()
                _clsQuery.CommitTran()
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            _clsQuery.RollbackTran()
            MsgBox(p_clsMsgData.fn_GetData("M029"))
            Return
        End Try
        ReadSecurityConfig()
        MsgBox(p_clsMsgData.fn_GetData("M028"))
    End Sub

#Region "Internal functions"
    Private Sub ReadSecurityConfig()
        _valueChanged = False
        Dim dtTable As DataTable = _clsQuery.SelectSecurityConfig()
        Dim AgentInfo As structAgent = Nothing
        If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
            nudLockAccountFail.Value = dtTable.Rows(0).Item("LOGIN_FAIL_CNT").ToString()
            nudLockTimeout.Value = dtTable.Rows(0).Item("LOCK_TIMEOUT").ToString()
            nudLockAccountIdle.Value = dtTable.Rows(0).Item("LOCK_INACT_PERIOD").ToString()
            nudPasswordLength.Value = dtTable.Rows(0).Item("PW_MIN_LENGTH").ToString()
            nudPasswordExpires.Value = dtTable.Rows(0).Item("PW_EXPR_DAYS").ToString()
            nudAlertPasswordExpires.Value = dtTable.Rows(0).Item("PW_EXPR_NOTI_DAYS").ToString()
            chkCombine.Checked = IIf(dtTable.Rows(0).Item("NONALPHANUMERIC_TF").ToString() = "1", True, False)
            chkDupLogin.Checked = IIf(dtTable.Rows(0).Item("ALLOW_DUP_LOGIN_TF").ToString() = "1", True, False)

            'save old values temporary
            nudLockAccountFail.Tag = nudLockAccountFail.Value
            nudLockTimeout.Tag = nudLockTimeout.Value
            nudLockAccountIdle.Tag = nudLockAccountIdle.Value
            nudPasswordLength.Tag = nudPasswordLength.Value
            nudPasswordExpires.Tag = nudPasswordExpires.Value
            nudAlertPasswordExpires.Tag = nudAlertPasswordExpires.Value
            chkCombine.Tag = chkCombine.Checked
            chkDupLogin.Tag = chkDupLogin.Checked
        End If
    End Sub

    Private Sub SaveSecurityConfig()
        If Not nudLockAccountFail.Value.Equals(nudLockAccountFail.Tag) _
        Or Not nudLockTimeout.Value.Equals(nudLockTimeout.Tag) _
        Or Not nudLockAccountIdle.Value.Equals(nudLockAccountIdle.Tag) _
        Or Not nudPasswordLength.Value.Equals(nudPasswordLength.Tag) _
        Or Not nudPasswordExpires.Value.Equals(nudPasswordExpires.Tag) _
        Or Not nudAlertPasswordExpires.Value.Equals(nudAlertPasswordExpires.Tag) _
        Or Not chkCombine.Checked.Equals(chkCombine.Tag) _
        Or Not chkDupLogin.Checked.Equals(chkDupLogin.Tag) Then
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.UpdateSecurityConfig(nudLockAccountFail.Value, nudLockTimeout.Value, nudLockAccountIdle.Value, _
                                         chkCombine.Checked, chkDupLogin.Checked, nudPasswordLength.Value, nudPasswordExpires.Value, _
                                         nudAlertPasswordExpires.Value, strLocIP)
        End If
    End Sub

    Private Sub SaveAllowIP()
        For Each tmpRow As DataGridViewRow In dgvWhitelist.Rows
            Dim strUserID As String = tmpRow.Cells(2).Value
            Dim strIPAddr As String = tmpRow.Cells(4).Value
            
            If tmpRow.Cells(5).Value <> -1 Then
                _clsQuery.InsertAllowIP(strUserID, strIPAddr)
            ElseIf tmpRow.Cells(5).Value = -1 AndAlso tmpRow.Visible = False Then
                _clsQuery.DeleteAllowIP(strUserID, strIPAddr)
            End If
        Next
    End Sub

    Private Sub ReadAllowList()
        Try
            Dim dtTable = _clsQuery.SelectAllowIP()
            If dtTable IsNot Nothing Then
                dgvWhitelist.DataSource = dtTable
                lblAllowlist.Text = p_clsMsgData.fn_GetData("F934") + " ( " + dtTable.Rows.Count.ToString + " ) "
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub AddData(ByVal intRow As Integer, ByVal strUserID As String, ByVal strUserName As String, ByVal strIP As String, ByVal strCIDR As String)
        If intRow >= 0 Then
            Dim tmpRow As DataGridViewRow = dgvWhitelist.Rows(intRow)
            tmpRow.Cells(coldgvWhitelistUserID.Index).Value = strUserID
            tmpRow.Cells(coldgvWhitelistUserName.Index).Value = strUserName
            tmpRow.Cells(coldgvWhitelistIPAddress.Index).Value = strIP + "/" + strCIDR
        Else
            Dim dataTable As DataTable = dgvWhitelist.DataSource
            Dim tmpRow As DataRow = dataTable.NewRow()
            tmpRow.Item("USER_ID") = strUserID
            tmpRow.Item("USER_NAME") = strUserName
            tmpRow.Item("ALLOW_IP") = strIP + "/" + strCIDR
            tmpRow.Item("TAG") = 0
            dataTable.Rows.Add(tmpRow)
            'Dim idxRow As Integer = dgvWhitelist.Rows.Add()
            'dgvWhitelist.fn_DataCellADD(idxRow, coldgvWhitelistUserID.Index, strUserID)
            'dgvWhitelist.fn_DataCellADD(idxRow, coldgvWhitelistUserName.Index, strUserName)
            'dgvWhitelist.fn_DataCellADD(idxRow, coldgvWhitelistIPAddress.Index, strIP + "/" + strCIDR)
            'dgvWhitelist.Rows(idxRow).Tag = -1
        End If
    End Sub
#End Region

End Class
