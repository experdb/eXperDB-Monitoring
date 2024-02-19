Imports System.ComponentModel

Public Class frmCurrentStatements


    Private _Elapseinterval As Integer = 3000  ' 2시간을 기본으로 설정 
    Private _InstanceID As Integer = -1
    Private _tooltip As ToolTip
    Private _SelectedIndex As String
    Private _SelectedGrid As String
    Private _ListStatements As New List(Of String)
    Private _UseFilter As Boolean
    ReadOnly Property InstanceID As Integer
        Get
            Return _InstanceID
        End Get
    End Property
    Private _ServerInfo As GroupInfo.ServerInfo = Nothing

    Private _AgentInfo As structAgent
    ReadOnly Property AgentInfo As structAgent
        Get
            Return _AgentInfo
        End Get
    End Property
    Private _AgentCn As eXperDB.ODBC.eXperDBODBC

    ReadOnly Property AgentCn As eXperDBODBC
        Get
            Return _AgentCn
        End Get
    End Property


    Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.eXperDBODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = ServerInfo.InstanceID
        _Elapseinterval = ElapseInterval
        _ServerInfo = ServerInfo
        _AgentInfo = clsAgentInfo
        _AgentCn = AgentCn

        _tooltip = New ToolTip()

    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        ReadConfig()
        cbxHideSysSQL.Checked = _UseFilter
    End Sub



    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Me.Text += " [ " + String.Format("{0}({1}) ", _ServerInfo.ShowNm, _ServerInfo.IP) + "]"


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Stmt Information

        dgvStmtList.AutoGenerateColumns = False
        coldgvStmtListDB.HeaderText = p_clsMsgData.fn_GetData("F090")
        coldgvStmtListUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        coldgvStmtListQuery.HeaderText = p_clsMsgData.fn_GetData("F084")

        lblCurrentStatements.Text = p_clsMsgData.fn_GetData("F339", 0)
        lblSort.Text = p_clsMsgData.fn_GetData("F325")

        cbxHideSysSQL.Text = p_clsMsgData.fn_GetData("F331")
        btnEditFiltering.Text = p_clsMsgData.fn_GetData("F333")

        MsgLabel.Text = p_clsMsgData.fn_GetData("M066")

        cmbOrder.SelectedIndex = 0
    End Sub


    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub

    ''' <summary>
    ''' Stmt 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataStmt(ByVal dtTable As DataTable)
        'If dtTable Is Nothing Then
        '    dgvStmtList.DataSource = Nothing
        '    Return
        'End If
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 


        '        Me.dgvResUtilPerBackProc.InvokeRowsClear()
        'If btnPause.Text = "4" Then Return
        If btnPause.ForeColor = Color.Gray Then Return

        Dim strQuery As String = ""
        strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)
        'strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)
        Dim strOrder As String = ""

        '        Dim dtView As DataView = New DataView(dtTable, strQuery, strOrder + " DESC", DataViewRowState.CurrentRows)
        Dim dtView As DataView = Nothing
        Select Case cmbOrder.SelectedIndex
            Case 1 : strOrder = "TOTAL_TIME DESC"
            Case 2 : strOrder = "AVG_TIME DESC"
            Case Else : strOrder = "CALLS DESC"
        End Select
        dtView = New DataView(dtTable, strQuery, strOrder, DataViewRowState.CurrentRows)

        Dim ShowDT As DataTable = Nothing
        If dtView.Count > 0 Then
            ShowDT = dtView.ToTable.AsEnumerable.Take(nudStmtcnt.Value).CopyToDataTable
        End If

        lblCurrentTm.Text = p_clsMsgData.fn_GetData("F344") + ":" + Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim CollectDate As DateTime = ShowDT.Rows(0)("COLLECT_DT")

        lblCollectTime.Text = p_clsMsgData.fn_GetData("F345") + ":" + CollectDate.ToString("yyyy-MM-dd HH:mm:ss")
        If ShowDT Is Nothing Then
            dgvStmtList.DataSource = Nothing
            Return
        End If

        'dgvStmtList.DataSource = ShowDT
        STMTTableBindingSource.DataSource = ShowDT

        lblCurrentStatements.Text = p_clsMsgData.fn_GetData("F339", dtView.Count)

        ' If cbxHideSysSQL.Checked = True Then
        SetRowfilter(cbxHideSysSQL)
        'End If

        lblCurrentStatements.Text = p_clsMsgData.fn_GetData("F339", dgvStmtList.RowCount)

        modCommon.sb_GridSortChg(dgvStmtList)

    End Sub


    Private Sub bckmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bckmanual.DoWork
        If _frmWait IsNot Nothing Then
            _frmWait.AddText("Data select start")
        End If

        bckmanual.ReportProgress(100)

    End Sub

    Private Sub bckmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bckmanual.ProgressChanged

    End Sub

    Private Sub bckmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bckmanual.RunWorkerCompleted
        If e.Cancelled = False Then

        End If

        If _frmWait IsNot Nothing Then
            _frmWait.Close()
        End If
        MsgBox(p_clsMsgData.fn_GetData("M032"))
    End Sub

    Private Sub frmMonActInfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'bckmanual.RunWorkerAsync()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.xls"
        fsd.Filter = "Excel files (*.xls)|*.xls"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strExcelFile As String = fsd.FileName

            Dim tmpDtSet As New DataSet

            tmpDtSet.Tables.Add(dgvStmtList.GetDataTable("STATEMENTS_INFO"))
            eXperDB.ODBC.eXperDBOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strExcelFile)
            End If
        End If
    End Sub

    Private WithEvents _AgentObject As clsAgentEMsg

    Private Sub AgentObject_Complete(sender As Object, e As Object) Handles _AgentObject.Complete
        If e.GetType.Equals(GetType(clsAgentEMsg.DX007_REP)) Then
            Dim rtnValue As clsAgentEMsg.DX007_REP = DirectCast(e, clsAgentEMsg.DX007_REP)

            If rtnValue._tran_res_data IsNot Nothing AndAlso rtnValue._tran_res_data(0)._error_cd Is Nothing Then
                Me.Invoke(New MethodInvoker(Sub()
                                                If bckmanual.IsBusy = True Then
                                                    bckmanual.CancelAsync()
                                                    Return
                                                End If
                                                bckmanual.RunWorkerAsync()
                                            End Sub))

            Else
                Me.Invoke(New MethodInvoker(Sub()
                                                If _frmWait IsNot Nothing Then
                                                    _frmWait.AddText(String.Format("[{0}]{1}", rtnValue._tran_res_data(0)._error_cd, rtnValue._tran_res_data(0)._error_msg))
                                                    _frmWait.Close()
                                                End If
                                                MsgBox(p_clsMsgData.fn_GetData("M033"))
                                            End Sub))
            End If
        ElseIf e.GetType.Equals(GetType(clsSocket.Results)) Then
            Me.Invoke(New MethodInvoker(Sub()
                                            If _frmWait IsNot Nothing Then
                                                _frmWait.AddText(DirectCast(e, clsSocket.Results).ErrorMsg)
                                            End If
                                        End Sub))
        Else
            Me.Invoke(New MethodInvoker(Sub()
                                            If _frmWait IsNot Nothing Then
                                                _frmWait.AddText("Unknown Error")
                                            End If
                                        End Sub))
        End If



    End Sub
    Private WithEvents _frmWait As frmWait
    Private Sub AgentObject_Progress(sender As Object, e As clsSocket.ProgArgs) Handles _AgentObject.Progress
        If e.Status = clsSocket.enumStatus.Start Then
            Me.Invoke(New MethodInvoker(Sub()
                                            If _frmWait IsNot Nothing Then
                                                _frmWait.AddText("Agent Running")
                                            End If
                                        End Sub))
        End If
    End Sub




    Private Sub _frmWait_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _frmWait.FormClosed
        If _AgentObject IsNot Nothing Then
            _AgentObject.Cancel()
            _AgentObject = Nothing
        End If

        If Me.bckmanual.IsBusy = True Then
            Me.bckmanual.CancelAsync()
        End If
        _frmWait = Nothing
    End Sub


    Private Sub dgvIdxinfo_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs)
        If e.ErrorText <> "" Then

        End If

    End Sub



    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        ' Play webding = "4"   Pause Webding = ";"

        If btnPause.ForeColor = Color.Gray Then
            btnPause.ForeColor = Color.Blue
        Else
            btnPause.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub dgvStmtList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStmtList.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvStmtList.RowCount <= 0 Then Return
        _SelectedIndex = dgvStmtList.CurrentRow.Cells(coldgvStmtListCalls.Index).Value
        _SelectedGrid = 0
        'If e.ColumnIndex = coldgvStmtListSQL.Index Then
        strDb = dgvStmtList.CurrentRow.Cells(coldgvStmtListDB.Index).Value
        strQuery = dgvStmtList.CurrentRow.Cells(coldgvStmtListQuery.Index).Value
        strUser = dgvStmtList.CurrentRow.Cells(coldgvStmtListUser.Index).Value
        Dim frmQuery As New frmQueryView(_AgentCn, strQuery, strDb, strUser, Me.InstanceID, Me.AgentInfo)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub

    Private Sub frmSessionLock_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Me.btnPause.Location = New System.Drawing.Point(Me.grpSessionLock.Width - Me.btnPause.Width - Me.btnPause.Margin.Right, Me.btnPause.Margin.Top)
        'Me.btnStop.Location = New System.Drawing.Point(Me.btnPause.Location.X - Me.btnStop.Width - Me.btnStop.Margin.Right, Me.btnPause.Margin.Top)
        'Me.btnCancel.Location = New System.Drawing.Point(Me.btnStop.Location.X - Me.btnCancel.Width - Me.btnCancel.Margin.Right, Me.btnPause.Margin.Top)
        'Me.btnHistory.Location = New System.Drawing.Point(Me.btnCancel.Location.X - Me.btnHistory.Width - Me.btnHistory.Margin.Right, Me.btnPause.Margin.Top)
        'Me.cmbStatus.Location = New System.Drawing.Point(Me.grpSession.Width - Me.cmbStatus.Width - Me.cmbStatus.Margin.Right, Me.cmbStatus.Margin.Top)
        'modCommon.FontChange(Me, p_Font)
    End Sub

    Private Sub txtSQL_TextChanged(sender As Object, e As EventArgs) Handles txtSQL.TextChanged
        Try
            Dim rowFilter As String = String.Format("Convert([{0}], System.String) LIKE '%{1}%'", coldgvStmtListQuery.HeaderText, txtSQL.Text)
            Dim dt As DataTable
            dt = dgvStmtList.DataSource.DataSource
            dt.DefaultView.RowFilter = rowFilter
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

    Private Sub cbxHideSysSQL_CheckedChanged(sender As Object, e As EventArgs) Handles cbxHideSysSQL.CheckedChanged
        Dim rbTemp As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)
        SetRowfilter(rbTemp)
    End Sub
    Private Sub ReadConfig()
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        _UseFilter = clsIni.ReadValue("STATSTATEMENTS", "UseFilter", False)

        Dim StatementFilters As String() = clsIni.ReadValue("STATSTATEMENTS", "StatementFilters", "pg_catalog").Split(New Char() {","c})

        Dim StatementFilter As String
        For Each StatementFilter In StatementFilters
            If Not StatementFilter.Equals("") Then
                _ListStatements.Add(StatementFilter)
            End If
        Next
    End Sub
    Private Sub SetRowfilter(ByRef checkBox As BaseControls.CheckBox)
        Try
            Dim dt As DataTable
            If checkBox.Checked = True Then
                'Dim rowFilter As String = String.Format("Convert([{0}], System.String) NOT LIKE '%{1}%'", coldgvStmtQuery.HeaderText, "application_name")
                Dim rowFilter As String = ""
                Dim rowFilterList As String = ""
                For Each StatementFilter In _ListStatements
                    rowFilterList += String.Format("AND Convert([{0}], System.String) NOT LIKE '%{1}%' ", coldgvStmtListQuery.HeaderText, StatementFilter)
                Next
                rowFilter = String.Format("Convert([{0}], System.String) <> '----' {1}", coldgvStmtListQuery.HeaderText, rowFilterList)
                'dt = dgvStmtList.DataSource.DataSource
                'dt.DefaultView.RowFilter = rowFilter
                Dim data As IBindingListView = TryCast(Me.dgvStmtList.DataSource, IBindingListView)
                data.Filter = rowFilter
                btnEditFiltering.Visible = True
            Else
                Dim data As IBindingListView = TryCast(Me.dgvStmtList.DataSource, IBindingListView)
                data.Filter = Nothing
                btnEditFiltering.Visible = False
            End If

            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            clsIni.WriteValue("STATSTATEMENTS", "UseFilter", True)

        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub

    Private Sub btnEditFiltering_Click(sender As Object, e As EventArgs) Handles btnEditFiltering.Click
        Dim frmCS As New frmStatementsFilter(_ListStatements)
        If frmCS.ShowDialog = Windows.Forms.DialogResult.OK Then
            _ListStatements = frmCS.StatementList
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            Dim StatementFilters As String = ""
            For Each StatementFilter In _ListStatements
                StatementFilters = String.Join(",", StatementFilter)
            Next
            clsIni.WriteValue("STATSTATEMENTS", "StatementFilters", String.Join(",", _ListStatements))
            SetRowfilter(cbxHideSysSQL)
        End If
        frmCS.Dispose()
    End Sub

    ' Displays the drop-down list when the user presses 
    ' ALT+DOWN ARROW or ALT+UP ARROW.
    Private Sub dgvStmtList_KeyDown(ByVal sender As Object, _
        ByVal e As KeyEventArgs) Handles dgvStmtList.KeyDown

        If e.Alt AndAlso (e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Up) Then

            Dim filterCell As DataGridViewAutoFilterColumnHeaderCell = _
                TryCast(dgvStmtList.CurrentCell.OwningColumn.HeaderCell,  _
                DataGridViewAutoFilterColumnHeaderCell)
            If filterCell IsNot Nothing Then
                filterCell.ShowDropDownList()
                e.Handled = True
            End If

        End If

    End Sub
End Class
