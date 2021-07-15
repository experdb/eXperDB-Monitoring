Public Class frmReportHistory

    Private _odbcConn As eXperDBODBC
    Private _clsQuery As clsQuerys  ' Main Thread용
    Private _intInstanceID As Integer = -1
    Private _startDt As DateTime
    Private _endDt As DateTime
    Private _userID As String = ""
    Private _userName As String = ""
    Private _intType As Integer = -1
    Private _dtTable As DataTable
    Private WithEvents _ProgresForm As frmProgres

    'to make condition variables to reference backgroupd worker
    Private _Instances As String
    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property SvrpList As List(Of GroupInfo.ServerInfo)
        Get
            Return _SvrpList
        End Get
    End Property

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal GrpLst As List(Of GroupInfo), ByVal instanceID As Integer)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _clsQuery = clsQuery

        For Each tmpGrp As GroupInfo In GrpLst
            For Each tmpSvr As GroupInfo.ServerInfo In tmpGrp.Items
                cmbClusters.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
            Next
        Next

        cmbClusters.SelectedValue = instanceID
        Me.ttChart.SetToolTip(Me.btnQuery, p_clsMsgData.fn_GetData("F956", "Snapshot"))

        initForm()
    End Sub

    Private Sub initForm()
        'Me.dgvUserLst.AutoGenerateColumns = False
        lblClusters.Text = p_clsMsgData.fn_GetData("F146")
        lblReportHistory.Text = p_clsMsgData.fn_GetData("M111")
        lblUserID.Text = p_clsMsgData.fn_GetData("F347")
        lblUserName.Text = p_clsMsgData.fn_GetData("F348")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")

        coldgvReportLogUserID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvReportLogUserName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvReportLogActionType.HeaderText = p_clsMsgData.fn_GetData("F937")
        coldgvReportLogActionDT.HeaderText = p_clsMsgData.fn_GetData("F936")
        coldgvReportLogUserIP.HeaderText = p_clsMsgData.fn_GetData("F935")
        coldgvReportLogCluster.HeaderText = p_clsMsgData.fn_GetData("F229")
        coldgvReportLogStatus.HeaderText = p_clsMsgData.fn_GetData("F247")
        coldgvReportLogDetail.HeaderText = p_clsMsgData.fn_GetData("F968")

        Me.ttChart.SetToolTip(Me.btnQuery, p_clsMsgData.fn_GetData("F151"))

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

        'Report, 1:Snapshot, 2:Gen Baseline, 3:Del Baseline, 4:Mod Baseline
        cmbAction.AddValue(0, "All")
        cmbAction.AddValue(1, "Trend")
        dtpSt.Value = dtpEd.Value.AddHours(-24)
    End Sub

    Private Sub frmAlertList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
    End Sub

    Private Sub frmAlertList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Invoke(New MethodInvoker(Sub()
                                            'btnQuery.PerformClick()
                                        End Sub))
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadReportList()
        Try
            _dtTable = _clsQuery.SelectReportInfo(_intInstanceID, _startDt, _endDt, _userID, _userName, _intType)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        _dtTable = Nothing

        _ProgresForm = New frmProgres()
        _ProgresForm.Owner = Me
        _ProgresForm.Location = Me.Location
        _ProgresForm.Size = Me.Size
        _ProgresForm.Show()

        _intInstanceID = cmbClusters.SelectedValue
        _startDt = dtpSt.Value
        _endDt = dtpEd.Value
        _userID = cmbUserID.SelectedValue
        _userName = cmbUserName.SelectedValue
        _intType = cmbAction.SelectedValue

        If bgmanual.IsBusy = True Then
            bgmanual.CancelAsync()
            Return
        End If
        bgmanual.RunWorkerAsync()
    End Sub

    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        bgmanual.ReportProgress(0)
        ReadReportList()
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
        Try
            If _dtTable IsNot Nothing Then
                Me.dgvReportLog.AutoGenerateColumns = False
                dgvReportLog.DataSource = _dtTable
            End If
            _ProgresForm.Close()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        _ProgresForm = Nothing
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.xls"
        fsd.Filter = "Excel files (*.xls)|*.xls"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strExcelFile As String = fsd.FileName

            Dim tmpDtSet As New DataSet

            tmpDtSet.Tables.Add(dgvReportLog.GetDataTable2("ACTION_LOG"))
            eXperDB.ODBC.eXperDBOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strExcelFile)
            End If

        End If
    End Sub

End Class
