Public Class frmSessionLock


    Private _Elapseinterval As Integer = 3000  ' 2시간을 기본으로 설정 
    Private _InstanceID As Integer = -1
    Private _tooltip As ToolTip
    Private _SelectedIndex As String
    Private _SelectedGrid As String
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
    Private _AgentCn As eXperDB.ODBC.DXODBC

    ReadOnly Property AgentCn As DXODBC
        Get
            Return _AgentCn
        End Get
    End Property


    Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.DXODBC)

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
        cmbStatus.SelectedIndex = 0
    End Sub



    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"

        btnHistory.Text = p_clsMsgData.fn_GetData("F251")

        '' Current Activity
        'grpCurAct.Text = p_clsMsgData.fn_GetData("F076")
        'dgvCurrentAct.AutoGenerateColumns = False
        'coldgvCurrentActDB.HeaderText = p_clsMsgData.fn_GetData("F104")
        'coldgvCurrentActPID.HeaderText = p_clsMsgData.fn_GetData("F082")
        'coldgvCurrentActUSER.HeaderText = p_clsMsgData.fn_GetData("F134")
        'coldgvCurrentActXACTSTART.HeaderText = p_clsMsgData.fn_GetData("F083")
        'coldgvCurrentActELASPEDTIME.HeaderText = p_clsMsgData.fn_GetData("F135")
        'coldgvCurrentActQUERY.HeaderText = p_clsMsgData.fn_GetData("F084")


        ' lock Information 
        grpLockInfo.Text = p_clsMsgData.fn_GetData("F077")
        dgvLock.AutoGenerateColumns = False
        'colDgvLockSel.HeaderText = p_clsMsgData.fn_GetData("F017")
        colDgvLockDB.HeaderText = p_clsMsgData.fn_GetData("F104")
        colDgvLockBlockedPID.HeaderText = p_clsMsgData.fn_GetData("F195")
        colDgvLockBlockedUser.HeaderText = p_clsMsgData.fn_GetData("F196")
        colDgvLockBlockingPID.HeaderText = p_clsMsgData.fn_GetData("F197")
        colDgvLockBlockingUser.HeaderText = p_clsMsgData.fn_GetData("F198")
        colDgvLockElapse.HeaderText = p_clsMsgData.fn_GetData("F135")
        colDgvLockBlockingQuery.HeaderText = p_clsMsgData.fn_GetData("F225")
        colDgvLockBlockedQuery.HeaderText = p_clsMsgData.fn_GetData("F221")
        colDgvLockMode.HeaderText = p_clsMsgData.fn_GetData("F222")
        colDgvLockQueryStart.HeaderText = p_clsMsgData.fn_GetData("F223")
        colDgvLockXactStart.HeaderText = p_clsMsgData.fn_GetData("F224")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Talble Information

        grpSession.Text = p_clsMsgData.fn_GetData("F313", 0)
        dgvSessionList.AutoGenerateColumns = False
        coldgvSessionListDB.HeaderText = p_clsMsgData.fn_GetData("F090")
        coldgvSessionListPID.HeaderText = p_clsMsgData.fn_GetData("F082")
        coldgvSessionListCpuUsage.HeaderText = p_clsMsgData.fn_GetData("F092")
        coldgvSessionListStTime.HeaderText = p_clsMsgData.fn_GetData("F050")
        coldgvSessionListElapsedTime.HeaderText = p_clsMsgData.fn_GetData("F051")
        coldgvSessionListStatus.HeaderText = p_clsMsgData.fn_GetData("F247")
        coldgvSessionListUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        coldgvSessionListClient.HeaderText = p_clsMsgData.fn_GetData("F248")
        coldgvSessionListApp.HeaderText = p_clsMsgData.fn_GetData("F249")
        coldgvSessionListRead.HeaderText = p_clsMsgData.fn_GetData("F048")
        coldgvSessionListWrite.HeaderText = p_clsMsgData.fn_GetData("F136")
        coldgvSessionListSQL.HeaderText = p_clsMsgData.fn_GetData("F052")


        grpSessionLock.Text = p_clsMsgData.fn_GetData("F246")

        btnExcel.Text = p_clsMsgData.fn_GetData("F142")

        'btnRefresh.Text = p_clsMsgData.fn_GetData("F137")

        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseRotationBox = False
        Me.FormControlBox1.UsePowerBox = False

        ' fit button location
        'Me.btnExcel.Location = New System.Drawing.Point(Me.grpTableInfo.Width - Me.btnExcel.Width - Me.btnExcel.Margin.Right, Me.btnExcel.Margin.Top)
        'Me.lblRefreshTime.Location = New System.Drawing.Point(Me.grpSessionLock.Location.X - Me.lblRefreshTime.Width - Me.lblRefreshTime.Margin.Right, Me.grpSessionLock.Margin.Top + 4)
        'Me.btnExcel.Location = New System.Drawing.Point(1704, 4)

        Me.btnPause.Location = New System.Drawing.Point(Me.grpSessionLock.Width - Me.btnPause.Width - Me.btnPause.Margin.Right, Me.btnPause.Margin.Top)
        Me.btnStop.Location = New System.Drawing.Point(Me.btnPause.Location.X - Me.btnStop.Width - Me.btnStop.Margin.Right, Me.btnPause.Margin.Top)
        Me.btnCancel.Location = New System.Drawing.Point(Me.btnStop.Location.X - Me.btnCancel.Width - Me.btnCancel.Margin.Right, Me.btnPause.Margin.Top)
        Me.btnHistory.Location = New System.Drawing.Point(Me.btnCancel.Location.X - Me.btnHistory.Width - Me.btnHistory.Margin.Right, Me.btnPause.Margin.Top)
        Me.cmbStatus.Location = New System.Drawing.Point(Me.grpSession.Width - Me.cmbStatus.Width - Me.cmbStatus.Margin.Right, Me.cmbStatus.Margin.Top)
        modCommon.FontChange(Me, p_Font)

    End Sub
    ''' <summary>
    ''' Lock info 변경 되었을 경우 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataLockinfo(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 
        'Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView

        ' dgvLock.DataSource = dtView
        'If btnPause.Text = "4" Then Return
        If btnPause.ForeColor = Color.LightGray Then Return

        'Dim topRows As DataRow() = dtTable.Select(String.Format("INSTANCE_ID={0} AND BLOCKED_PID IS NULL", Me.InstanceID), "ORDER_NO ASC")
        Dim Dgv As AdvancedDataGridView.TreeGridView = dgvLock
        Dgv.Nodes.Clear()
        Dim intLockCount As Integer = 0
        Dim HashTbl As New Hashtable
        For Each tmpCol As DataGridViewColumn In Dgv.Columns

            If Not tmpCol.GetType.Equals(GetType(AdvancedDataGridView.TreeGridColumn)) Then
                HashTbl.Add(tmpCol.Index, tmpCol.DataPropertyName)
            End If
        Next


        Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView
        For Each tmpRow As DataRow In dtView.ToTable.Select("BLOCKED_PID IS NULL", "ORDER_NO ASC")
            Dim topNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("DB_NAME"))
            sb_AddTreeGridDatas(topNode, HashTbl, tmpRow)
            intLockCount += 1
            For Each tmpChild As DataRow In dtView.Table.Select(String.Format("BLOCKED_PID IS NOT NULL AND BLOCKING_PID = {0}", tmpRow.Item("BLOCKING_PID")), "ORDER_NO ASC")
                Dim cNOde As AdvancedDataGridView.TreeGridNode = topNode.Nodes.Add(tmpChild.Item("DB_NAME"))
                sb_AddTreeGridDatas(cNOde, HashTbl, tmpChild)

            Next
            topNode.Expand()
            topNode.Cells(0).Value = tmpRow.Item("DB_NAME") & " (" & topNode.Nodes.Count & ")"

        Next

        grpLockInfo.Text = p_clsMsgData.fn_GetData("F077", intLockCount)

        'For Each tmpRow As DataRow In topRows
        '    Dim tvNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("DB_NAME"))
        '    For Each tmpChild As DataRow In dtTable.Select(String.Format("INSTANCE_ID = {0} AND BLOCKED_PID IS NULL

        '    Next

        'modCommon.sb_GridSortChg(dgvLock, srtColidx, srtOrd)
        'dgvLock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        'dgvLock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub


    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub

    ''' <summary>
    ''' BackEnd 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataSession(ByVal dtTable As DataTable)
        'If dtTable Is Nothing Then
        '    dgvSessionList.DataSource = Nothing
        '    Return
        'End If
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 


        '        Me.dgvResUtilPerBackProc.InvokeRowsClear()
        'If btnPause.Text = "4" Then Return
        If btnPause.ForeColor = Color.LightGray Then Return

        Dim strQuery As String = ""
        Dim subQuery As String = IIf(cmbStatus.SelectedIndex, "", String.Format("AND SQL <> '{0}'", "<IDLE>"))
        If cmbStatus.SelectedIndex = 0 Then
            subQuery = ""
        ElseIf cmbStatus.SelectedIndex = 1 Then
            subQuery = String.Format("AND SQL <> '{0}'", "<IDLE>")
        Else
            subQuery = String.Format("AND SQL = '{0}'", "<IDLE>")
        End If

        strQuery = String.Format("INSTANCE_ID = {0} {1}", Me.InstanceID, subQuery)
        'strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)

        Dim dtView As DataView = New DataView(dtTable, strQuery, "CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

        Dim ShowDT As DataTable = Nothing
        If dtView.Count > 0 Then
            ShowDT = dtView.ToTable.AsEnumerable.Take(100).CopyToDataTable
        End If

        If ShowDT Is Nothing Then
            dgvSessionList.DataSource = Nothing
            Return
        End If

        dgvSessionList.DataSource = ShowDT

        grpSession.Text = p_clsMsgData.fn_GetData("F313", dtView.Count)
        modCommon.sb_GridSortChg(dgvSessionList)
        'dgvSessionList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)

    End Sub




    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)

        _frmWait = New frmWait
        _frmWait.TopMost = True
        _frmWait.Show(Me)

        _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)
        _AgentObject.SendDX001(Me.InstanceID)


        'If bckmanual.IsBusy = True Then
        '    bckmanual.CancelAsync()
        '    Return
        'End If
        'bckmanual.RunWorkerAsync()

    End Sub


    Private Sub bckmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bckmanual.DoWork
        If _frmWait IsNot Nothing Then
            _frmWait.AddText("Data select start")
        End If

        bckmanual.ReportProgress(100)

    End Sub

    Private Sub bckmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bckmanual.ProgressChanged
        If p_clsAgentCollect.ThreadManual(Me.InstanceID, 60000) = True Then

        End If
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

            tmpDtSet.Tables.Add(dgvSessionList.GetDataTable("TABLE_INFO"))
            eXperDB.ODBC.DXOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

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
                                            _frmWait.AddText("Agent Running")
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

        If btnPause.ForeColor = Color.LightGray Then
            btnPause.ForeColor = Color.LawnGreen
        Else
            btnPause.ForeColor = Color.LightGray
        End If
        'If btnPause.Text = "4" Then
        '    btnPause.Text = ";"
        'Else
        '    btnPause.Text = "4"
        'End If
    End Sub

    Private Sub dgvLock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLock.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvLock.RowCount <= 0 Then Return
        _SelectedIndex = dgvLock.CurrentRow.Cells(colDgvLockBlockingPID.Index).Value
        _SelectedGrid = 1
        If e.ColumnIndex = colDgvLockBlockedQuery.Index Then
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strQuery = dgvLock.CurrentCell.Value
            strUser = dgvLock.CurrentRow.Cells(colDgvLockBlockedUser.Index).Value
            Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
            frmQuery.ShowDialog(Me)
        ElseIf e.ColumnIndex = colDgvLockBlockingQuery.Index Then
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strQuery = dgvLock.CurrentCell.Value
            strUser = dgvLock.CurrentRow.Cells(colDgvLockBlockingUser.Index).Value
            Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
            frmQuery.ShowDialog(Me)
        End If
    End Sub

    Private Sub dgvLock_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLock.CellMouseClick
        If dgvLock.RowCount <= 0 Then Return
        For i As Integer = 0 To dgvSessionList.Rows.Count - 1
            dgvSessionList.Rows(i).Selected = False
        Next

        _SelectedIndex = dgvLock.CurrentRow.Cells(colDgvLockBlockingPID.Index).Value
        _SelectedGrid = 1
        If e.RowIndex >= 0 Then
            dgvLock.Cursor = Cursors.Hand
            If dgvLock.Rows(e.RowIndex).Selected = False Then
                dgvLock.ClearSelection()
                dgvLock.Rows(e.RowIndex).Selected = True
            End If
            For i As Integer = 0 To dgvLock.ColumnCount - 1
                dgvLock.Rows(e.RowIndex).Cells(i).Style.SelectionBackColor = Color.FromArgb(0, 40, 70)
            Next
        End If
    End Sub

    Private Sub dgvSessionList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessionList.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvSessionList.RowCount <= 0 Then Return
        _SelectedIndex = dgvSessionList.CurrentRow.Cells(coldgvSessionListPID.Index).Value
        _SelectedGrid = 0
        'If e.ColumnIndex = coldgvSessionListSQL.Index Then
        strDb = dgvSessionList.CurrentRow.Cells(coldgvSessionListDB.Index).Value
        strQuery = dgvSessionList.CurrentRow.Cells(coldgvSessionListSQL.Index).Value
        strUser = dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value
        Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub

    Private Sub dgvSessionList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSessionList.CellMouseClick
        If dgvSessionList.RowCount <= 0 Then Return
        For i As Integer = 0 To dgvLock.Rows.Count - 1
            dgvLock.Rows(i).Selected = False
        Next
        _SelectedIndex = dgvSessionList.CurrentRow.Cells(coldgvSessionListPID.Index).Value
        _SelectedGrid = 0
        If e.RowIndex >= 0 Then
            dgvSessionList.Cursor = Cursors.Hand
            If dgvSessionList.Rows(e.RowIndex).Selected = False Then
                dgvSessionList.ClearSelection()
                dgvSessionList.Rows(e.RowIndex).Selected = True
            End If
            For i As Integer = 0 To dgvSessionList.ColumnCount - 1
                dgvSessionList.Rows(e.RowIndex).Cells(i).Style.SelectionBackColor = Color.FromArgb(0, 40, 70)
            Next
        End If
    End Sub

    Private Sub btnPause_MouseHover(sender As Object, e As EventArgs) Handles btnPause.MouseHover
        _tooltip.SetToolTip(btnPause, "Auto Refresh")
    End Sub

    Private Sub btnStop_MouseHover(sender As Object, e As EventArgs) Handles btnStop.MouseHover
        _tooltip.SetToolTip(btnStop, "Kill Session")
    End Sub

    Private Sub btnCancel_MouseHover(sender As Object, e As EventArgs) Handles btnCancel.MouseHover
        _tooltip.SetToolTip(btnCancel, "Cancel Query")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim intPID As Integer
        Dim strRegDate As String
        Dim intActvRegSeq As Integer

        If MsgBox(p_clsMsgData.fn_GetData("M030", intPID), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) <> frmMsgbox.MsgBoxResult.Yes Then
            Return
        End If

        _frmWait = New frmWait
        _frmWait.TopMost = True
        _frmWait.Show(Me)

        If _SelectedGrid = 1 Then
            For Each row As DataGridViewRow In dgvLock.SelectedRows
                intPID = row.Cells(colDgvLockBlockingPID.Index).Value
                strRegDate = row.Cells(colDgvLockRegDate.Index).Value
                intActvRegSeq = row.Cells(colDgvLockActvRegSeq.Index).Value
                _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)
                _AgentObject.SendDX007(Me.InstanceID, intActvRegSeq, intPID, _SelectedGrid, "0", strRegDate.Substring(0, 10).Replace("-", ""))
            Next row
        Else
            For Each row As DataGridViewRow In dgvSessionList.SelectedRows
                intPID = row.Cells(coldgvSessionListPID.Index).Value
                strRegDate = row.Cells(colDgvSessionlistRegDate.Index).Value
                intActvRegSeq = row.Cells(colDgvSessionListActvRegSeq.Index).Value
                _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)
                _AgentObject.SendDX007(Me.InstanceID, intActvRegSeq, intPID, _SelectedGrid, "0", strRegDate.Substring(0, 10).Replace("-", ""))
            Next row
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim intPID As Integer
        Dim strRegDate As String
        Dim intActvRegSeq As Integer

        If MsgBox(p_clsMsgData.fn_GetData("M031", intPID), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) <> frmMsgbox.MsgBoxResult.Yes Then Return

        _frmWait = New frmWait
        _frmWait.TopMost = True
        _frmWait.Show(Me)

        If _SelectedGrid = 1 Then
            For Each row As DataGridViewRow In dgvLock.SelectedRows
                If IsDBNull(row.Cells(colDgvLockBlockedPID.Index).Value) Then
                    intPID = row.Cells(colDgvLockBlockingPID.Index).Value
                    strRegDate = row.Cells(colDgvLockRegDate.Index).Value
                    intActvRegSeq = row.Cells(colDgvLockActvRegSeq.Index).Value
                    _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)
                    _AgentObject.SendDX007(Me.InstanceID, intActvRegSeq, intPID, _SelectedGrid, "1", strRegDate.Substring(0, 10).Replace("-", ""))
                End If
            Next row
        Else
            For Each row As DataGridViewRow In dgvSessionList.SelectedRows
                intPID = row.Cells(coldgvSessionListPID.Index).Value
                strRegDate = row.Cells(colDgvSessionlistRegDate.Index).Value
                intActvRegSeq = row.Cells(colDgvSessionListActvRegSeq.Index).Value
                _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)
                _AgentObject.SendDX007(Me.InstanceID, intActvRegSeq, intPID, _SelectedGrid, "1", strRegDate.Substring(0, 10).Replace("-", ""))
            Next row
        End If

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim BretFrm As frmSessionLockHist = Nothing

        For Each tmpFrm As Form In My.Application.OpenForms
            Dim frmDtl As frmSessionLockHist = TryCast(tmpFrm, frmSessionLockHist)
            If frmDtl IsNot Nothing AndAlso frmDtl.InstanceID = _InstanceID Then
                BretFrm = tmpFrm
                Exit For
            End If
        Next

        If BretFrm Is Nothing Then
            BretFrm = New frmSessionLockHist(_ServerInfo, AgentInfo, _AgentCn)
            BretFrm.Show()
        Else
            BretFrm.Activate()
        End If
    End Sub

    Private Sub frmSessionLock_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.btnPause.Location = New System.Drawing.Point(Me.grpSessionLock.Width - Me.btnPause.Width - Me.btnPause.Margin.Right, Me.btnPause.Margin.Top)
        Me.btnStop.Location = New System.Drawing.Point(Me.btnPause.Location.X - Me.btnStop.Width - Me.btnStop.Margin.Right, Me.btnPause.Margin.Top)
        Me.btnCancel.Location = New System.Drawing.Point(Me.btnStop.Location.X - Me.btnCancel.Width - Me.btnCancel.Margin.Right, Me.btnPause.Margin.Top)
        Me.btnHistory.Location = New System.Drawing.Point(Me.btnCancel.Location.X - Me.btnHistory.Width - Me.btnHistory.Margin.Right, Me.btnPause.Margin.Top)
        Me.cmbStatus.Location = New System.Drawing.Point(Me.grpSession.Width - Me.cmbStatus.Width - Me.cmbStatus.Margin.Right, Me.cmbStatus.Margin.Top)
        modCommon.FontChange(Me, p_Font)
    End Sub
End Class
