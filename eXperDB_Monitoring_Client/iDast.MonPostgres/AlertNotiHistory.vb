Public Class AlertNotiHistory


    Private _AgentIP As String
    Private _AgentPort As Integer
    Private _checkAgentInterval As Integer = 1000
    Private _startDt As String
    Private _applyCount As Integer = 0
    Private crypt As New eXperDB.Common.ClsCrypt
    Private _clsQuery As clsQuerys
    Private _groupID As Integer = -1
    Private _Instances As String
    Private _NotiLevel As Integer
    Private _NotiUser As String
    Private _NotiResult As String
    Private _dtTableNotification As DataTable

    Private _intInstanceId As Integer = 0
    Private WithEvents _ProgresForm As frmProgres
    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    ReadOnly Property SvrpList As List(Of GroupInfo.ServerInfo)
        Get
            Return _SvrpList
        End Get
    End Property
#Region "Form Initialize"


    Public Sub New(ByRef odbcConn As eXperDBODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()

        _clsQuery = New clsQuerys(odbcConn)
        ReadServerList()
        ReadUserList()
        AddHandler Disposed, AddressOf Me.OnDispose
    End Sub

    Private Sub OnDispose(ByVal sender As Object, ByVal e As EventArgs)
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
    End Sub



    Private Sub initForm()
        Me.dgvNotificationLst.AutoGenerateColumns = False

        MsgLabel.Text = p_clsMsgData.fn_GetData("M074")

        btnQuery.Text = p_clsMsgData.fn_GetData("F151")
        lblServer.Text = p_clsMsgData.fn_GetData("F033")
        lblLevel.Text = p_clsMsgData.fn_GetData("F256")
        lblUser.Text = p_clsMsgData.fn_GetData("F348")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")
        lblStatus.Text = p_clsMsgData.fn_GetData("F247")
        lblNotiList.Text = p_clsMsgData.fn_GetData("F358", 0)

        coldgvNotificationLstHostName.HeaderText = p_clsMsgData.fn_GetData("F033")
        coldgvNotificationLstSender.HeaderText = p_clsMsgData.fn_GetData("F354")
        coldgvNotificationLstLevel.HeaderText = p_clsMsgData.fn_GetData("F247")
        coldgvNotificationLstUserID.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvNotificationLstReceiver.HeaderText = p_clsMsgData.fn_GetData("F355")
        coldgvNotificationLstMessages.HeaderText = p_clsMsgData.fn_GetData("F259")
        coldgvNotificationLstIsSuccess.HeaderText = p_clsMsgData.fn_GetData("F356")
        coldgvNotificationLstError.HeaderText = p_clsMsgData.fn_GetData("F357")
        coldgvNotificationLstCollectDt.HeaderText = p_clsMsgData.fn_GetData("F257")

        'modCommon.FontChange(Me, p_Font)
    End Sub

    'Private Sub frmNotiHistory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    _clsQuery.CancelCommand()
    '    If Me.bgmanual.IsBusy = True Then
    '        Me.bgmanual.CancelAsync()
    '    End If
    'End Sub

    Private Sub frmNotiHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpEd.Value = DateTime.Now
        dtpSt.Value = dtpEd.Value.AddMinutes(-60)
        dtpEd.Value = dtpEd.Value.AddMinutes(1)

        cmbServer.SelectedIndex = 0
        cmbLevel.SelectedIndex = 0
        cmbResults.SelectedIndex = 0
    End Sub
#End Region

#Region "Combo List"
    ''' <summary>
    ''' 서버리스트를 불러온다. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadServerList()
        Try
        Dim dtTable As DataTable = _clsQuery.SelectServerList()
            Dim comboSource As New Dictionary(Of String, String)()
            comboSource.Add(0, "All")
            If dtTable IsNot Nothing Then
                For Each tmpRow As DataRow In dtTable.Rows
                    comboSource.Add(tmpRow.Item("INSTANCE_ID"), tmpRow.Item("HOST_NAME"))
                Next

                cmbServer.DataSource = New BindingSource(comboSource, Nothing)
                cmbServer.DisplayMember = "Value"
                cmbServer.ValueMember = "Key"
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadUserList()
        Try
            Dim dtTable As DataTable = _clsQuery.SelectUser(_groupID)
            If dtTable IsNot Nothing Then
                Dim comboSource As New Dictionary(Of String, String)()

                comboSource.Add(0, "All")
                For Each tmpRow As DataRow In dtTable.Rows
                    comboSource.Add(tmpRow.Item("USER_ID"), tmpRow.Item("USER_NAME"))
                Next

                cmbUser.DataSource = New BindingSource(comboSource, Nothing)
                cmbUser.DisplayMember = "Value"
                cmbUser.ValueMember = "Key"
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region

    ''' <summary>
    ''' 적용 버튼을 클릭 하엿을 경우 해당 복록을 DB에 저장한다. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub AddData(ByVal intRow As Integer, ByVal strUserID As String, ByVal strUserName As String, ByRef strPhone As String, ByRef strEmail As String)
        'If intRow >= 0 Then
        '    Dim tmpRow As DataGridViewRow = dgvNotificationLst.Rows(intRow)

        '    tmpRow.Cells(coldgvUserLstID.Index).Value = strUserID
        '    tmpRow.Cells(coldgvUserLstName.Index).Value = strUserName
        '    tmpRow.Cells(coldgvUserLstTel.Index).Value = strPhone
        '    tmpRow.Cells(coldgvUserLstEmail.Index).Value = strEmail
        'Else
        '    Dim tmpIpRow As DataGridViewRow = dgvNotificationLst.FindFirstRow(strUserID, coldgvUserLstID.Index, True)
        '    If tmpIpRow Is Nothing Then
        '        Dim idxRow As Integer = dgvNotificationLst.Rows.Add()
        '        dgvNotificationLst.fn_DataCellADD(idxRow, coldgvUserLstID.Index, strUserID)
        '        dgvNotificationLst.fn_DataCellADD(idxRow, coldgvUserLstName.Index, strUserName)
        '        dgvNotificationLst.fn_DataCellADD(idxRow, coldgvUserLstTel.Index, strPhone)
        '        dgvNotificationLst.fn_DataCellADD(idxRow, coldgvUserLstEmail.Index, strEmail)
        '        dgvNotificationLst.Rows(idxRow).Tag = -1
        '    Else
        '        Dim strMsg As String = p_clsMsgData.fn_GetData("M011")
        '        MsgBox(strMsg)
        '    End If

        'End If
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        If cmbServer.SelectedValue = 0 Then
            Dim arrInstanceIDs As New ArrayList
            'For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            '    arrInstanceIDs.Add(tmpSvr.InstanceID)
            'Next
            For i As Integer = 1 To cmbServer.Items.Count - 1
                arrInstanceIDs.Add(Integer.Parse(cmbServer.Items(i).key.ToString))
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            _Instances = String.Join(",", Instance)
        Else
            _Instances = cmbServer.SelectedValue
        End If

        _NotiLevel = IIf(cmbLevel.SelectedIndex = 0, 300, 200)
        _NotiUser = DirectCast(cmbUser.SelectedItem, KeyValuePair(Of String, String)).Key()
        _NotiUser = IIf(_NotiUser.Equals("0"), "", _NotiUser)
        _NotiResult = IIf(cmbResults.SelectedIndex = 0, "", IIf(cmbResults.SelectedIndex = 1, "true", "false"))
        '_AlertIsCheck = cmbCheck.SelectedIndex

        _ProgresForm = New frmProgres()
        _ProgresForm.Owner = Me.FindForm

        _ProgresForm.Location = Me.Location
        _ProgresForm.Size = Me.Size
        _ProgresForm.Show()

        If bgmanual.IsBusy = True Then
            bgmanual.CancelAsync()
            Return
        End If
        bgmanual.RunWorkerAsync()
    End Sub

    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        bgmanual.ReportProgress(0)
        _dtTableNotification = _clsQuery.SelectNotificationHistory(dtpSt.Value, dtpEd.Value, _Instances, _NotiLevel, _NotiUser, _NotiResult, p_ShowName.ToString("d"))
    End Sub

    Private Sub bgmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgmanual.ProgressChanged
        If e.ProgressPercentage = 0 Then
            If _ProgresForm IsNot Nothing Then
                _ProgresForm.Addtext("Getting alert list")
            End If
        Else
            If _ProgresForm IsNot Nothing Then
                _ProgresForm.Addtext("Complete")
            End If
        End If
    End Sub

    Private Sub bgmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgmanual.RunWorkerCompleted
        If _dtTableNotification IsNot Nothing Then
            dgvNotificationLst.DataSource = _dtTableNotification
            lblNotiList.Text = p_clsMsgData.fn_GetData("F358", _dtTableNotification.Rows.Count)
            'For Each tmpRow As DataRow In _dtTableNotification.Rows
            '    'Dim idxRow As Integer = dgvNotificationLst.Rows.Add()
            '    '' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 
            '    'dgvNotificationLst.Rows(idxRow).Tag = tmpRow.Item("INSTANCE_ID")
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertHostName.Index, tmpRow.Item("HOST_NAME"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertTime.Index, tmpRow.Item("COLLECT_TIME"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertType.Index, tmpRow.Item("HCHK_NAME"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertLevel.Index, IIf((tmpRow.Item("STATE") = 200), "Warning", "Critical"))

            '    'Dim strValue As String = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpRow.Item("VALUE"))
            '    'If tmpRow.Item("HCHK_NAME").Equals("ACTIVECONNECTION") Or _
            '    '    tmpRow.Item("HCHK_NAME").Equals("CONNECTIONFAIL") Or _
            '    '    tmpRow.Item("HCHK_NAME").Equals("LASTANALYZE") Or _
            '    '    tmpRow.Item("HCHK_NAME").Equals("LASTVACUUM") Or _
            '    '    tmpRow.Item("HCHK_NAME").Equals("LOCKCNT") Or tmpRow.Item("HCHK_NAME").Equals("TRAXIDLECNT") Or _
            '    '    tmpRow.Item("HCHK_NAME").Equals("UNUSEDINDEX") Then
            '    '    Dim tmpValue As Long = tmpRow.Item("VALUE")
            '    '    strValue = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpValue)
            '    'End If

            '    'Dim strValueUnit As String = ""
            '    'If tmpRow.Item("VALUE") <> 99999 Then
            '    '    strValueUnit = tmpRow.Item("UNIT")
            '    'End If
            '    'Dim strShowValue As String = "{0} " + "{1}"
            '    'strShowValue = String.Format(strShowValue, strValue, strValueUnit)
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertMessage.Index, strShowValue)
            '    ''dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertYN.Index, IIf(IsDBNull(tmpRow.Item("CHECK_USER_ID")), "Unchecked", "Checked"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertYN.Index, tmpRow.Item("CHECK_USER_ID"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertComment.Index, tmpRow.Item("CHECK_COMMENT"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertIP.Index, tmpRow.Item("CHECK_IP"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertTime.Index, tmpRow.Item("COLLECT_TIME"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertRegDate.Index, tmpRow.Item("REG_DATE"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertHCHKREGREQ.Index, tmpRow.Item("HCHK_REG_SEQ"))
            '    'dgvNotificationLst.fn_DataCellADD(idxRow, coldgvAlertDT.Index, tmpRow.Item("CHECK_DT"))
            'Next
        End If
        _ProgresForm.Close()
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        _ProgresForm = Nothing
    End Sub

End Class