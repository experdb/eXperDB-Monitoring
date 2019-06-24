Public Class UserAccessHistory

    Private _clsQuery As clsQuerys
    Public Sub New(ByRef odbcConn As eXperDBODBC)
        ' 이 호출은 디자이너에 필요합니다
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        'Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()

        'Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        'Dim tmpCn As New eXperDBODBC(dbType, tmpStruct.HostIP, tmpStruct.Port, tmpStruct.UserID, tmpStruct.Password, tmpStruct.DBName)
        _clsQuery = New clsQuerys(odbcConn)
        initForm()
    End Sub

    Private Sub initForm()
        'Me.dgvUserLst.AutoGenerateColumns = False
        lblAccessHistory.Text = p_clsMsgData.fn_GetData("M075")
        lblUserID.Text = p_clsMsgData.fn_GetData("F347")
        lblUserName.Text = p_clsMsgData.fn_GetData("F348")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")

        coldgvActionLogUserID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvActionLogUserName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvActionLogActionType.HeaderText = p_clsMsgData.fn_GetData("F937")
        coldgvActionLogActionDT.HeaderText = p_clsMsgData.fn_GetData("F936")
        coldgvActionLogUserIP.HeaderText = p_clsMsgData.fn_GetData("F935")
        coldgvActionLogCluster.HeaderText = p_clsMsgData.fn_GetData("F229")
        coldgvActionLogClusterIP.HeaderText = p_clsMsgData.fn_GetData("F006")
        coldgvActionLogStatus.HeaderText = p_clsMsgData.fn_GetData("F247")
        coldgvActionLogDetail.HeaderText = p_clsMsgData.fn_GetData("F357")

        Me.ttChart.SetToolTip(Me.btnSearch, p_clsMsgData.fn_GetData("F151"))

        Dim dTable As DataTable = _clsQuery.SelectUser(-1)
        If dTable IsNot Nothing AndAlso dTable.Rows.Count > 0 Then
            Dim comboSourceUserID As New Dictionary(Of String, String)()
            Dim comboSourceUserName As New Dictionary(Of String, String)()
            comboSourceUserID.Add(0, "All")
            comboSourceUserName.Add(0, "All")
            For Each dtRow As DataRow In dTable.Rows
                comboSourceUserID.Add(dtRow.Item("USER_ID"), dtRow.Item("USER_ID"))
                comboSourceUserName.Add(dtRow.Item("USER_NAME"), dtRow.Item("USER_NAME"))
            Next

            cmbUserID.DataSource = New BindingSource(comboSourceUserID, Nothing)
            cmbUserName.DataSource = New BindingSource(comboSourceUserName, Nothing)

            cmbUserID.DisplayMember = "Value"
            cmbUserID.ValueMember = "Value"
            cmbUserName.DisplayMember = "Value"
            cmbUserName.ValueMember = "Value"
            cmbUserID.SelectedIndex = 0
            cmbUserName.SelectedIndex = 0
        End If
        cmbAction.SelectedIndex = 0
        dtpSt.Value = dtpEd.Value.AddHours(-24)
    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadAccessList()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub dgvUserLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActionLog.CellClick
        'If e.ColumnIndex = coldgvUserLstEdit.Index Then

        'ElseIf e.ColumnIndex = coldgvUserLstDelete.Index Then

        'Else

        'End If
    End Sub

    Private Sub ReadAccessList()
        Try
            Dim dtTable As DataTable = _clsQuery.SelectUserAccessInfo(dtpSt.Value, dtpEd.Value, cmbUserID.SelectedValue, cmbUserName.SelectedValue, cmbAction.SelectedItem)
            If dtTable IsNot Nothing Then
                Me.dgvActionLog.AutoGenerateColumns = False
                dgvActionLog.DataSource = dtTable
                'lblAccessHistory.Text = p_clsMsgData.fn_GetData("F351", dtTable.Rows.Count)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            ReadAccessList()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.xls"
        fsd.Filter = "Excel files (*.xls)|*.xls"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strExcelFile As String = fsd.FileName

            Dim tmpDtSet As New DataSet

            tmpDtSet.Tables.Add(dgvActionLog.GetDataTable2("ACTION_LOG"))
            eXperDB.ODBC.eXperDBOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strExcelFile)
            End If

        End If
    End Sub
End Class
