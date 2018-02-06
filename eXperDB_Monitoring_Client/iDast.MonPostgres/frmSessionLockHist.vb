Public Class frmSessionLockHist

    Private _InstanceID As Integer = -1
    Private _tooltip As ToolTip
    Private _SelectedPID As String
    Private _clsQuery As clsQuerys  ' Main Thread용
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

    Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.DXODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = ServerInfo.InstanceID
        _ServerInfo = ServerInfo
        _AgentInfo = clsAgentInfo
        _clsQuery = New clsQuerys(AgentCn)
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
        Me.Invoke(New MethodInvoker(Sub()
                                        btnQuery.PerformClick()
                                    End Sub))
    End Sub



    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"

        btnQuery.Text = p_clsMsgData.fn_GetData("F151")
        lblType.Text = p_clsMsgData.fn_GetData("F252")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")

        ' lock Information 
        grpLockInfo.Text = p_clsMsgData.fn_GetData("F077")
        dgvLock.AutoGenerateColumns = False
        'colDgvLockSel.HeaderText = p_clsMsgData.fn_GetData("F017")
        coldgvLockCtrlType.HeaderText = p_clsMsgData.fn_GetData("F252")
        coldgvLockCtrlTime.HeaderText = p_clsMsgData.fn_GetData("F253")
        colDgvLockDB.HeaderText = p_clsMsgData.fn_GetData("F104")
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
        coldgvSessionCtrlType.HeaderText = p_clsMsgData.fn_GetData("F252")
        coldgvSessionCtrlTime.HeaderText = p_clsMsgData.fn_GetData("F253")
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

        grpSessionLockHist.Text = p_clsMsgData.fn_GetData("F246")

        btnExcel.Text = p_clsMsgData.fn_GetData("F142")

        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseRotationBox = False
        Me.FormControlBox1.UsePowerBox = False

        ' fit button location
        Me.btnExcel.Location = New System.Drawing.Point(Me.grpSessionLockHist.Width - Me.btnExcel.Width - Me.btnExcel.Margin.Right, Me.btnExcel.Margin.Top)
        Me.btnQuery.Location = New System.Drawing.Point(Me.btnExcel.Location.X - Me.btnQuery.Width - Me.btnQuery.Margin.Right, Me.btnExcel.Margin.Top)
        Me.txtSQL.Location = New System.Drawing.Point(Me.btnQuery.Location.X - Me.txtSQL.Width - Me.txtSQL.Margin.Right, 7)
        Me.lblSQL.Location = New System.Drawing.Point(Me.txtSQL.Location.X - Me.lblSQL.Width - Me.lblSQL.Margin.Right, Me.txtSQL.Margin.Top)
        Me.dtpEd.Location = New System.Drawing.Point(Me.lblSQL.Location.X - Me.dtpEd.Width - Me.dtpEd.Margin.Right, 6)
        Me.lblDuration2.Location = New System.Drawing.Point(Me.dtpEd.Location.X - Me.lblDuration2.Width - Me.lblDuration2.Margin.Right, Me.dtpEd.Margin.Top)
        Me.dtpSt.Location = New System.Drawing.Point(Me.lblDuration2.Location.X - Me.dtpSt.Width - Me.dtpSt.Margin.Right, 6)
        Me.lblDuration.Location = New System.Drawing.Point(Me.dtpSt.Location.X - Me.lblDuration.Width - Me.lblDuration.Margin.Right, Me.dtpSt.Margin.Top)
        Me.txtDatabase.Location = New System.Drawing.Point(Me.lblDuration.Location.X - Me.txtDatabase.Width - Me.txtDatabase.Margin.Right, 7)
        Me.lblDatabase.Location = New System.Drawing.Point(Me.txtDatabase.Location.X - Me.lblDatabase.Width - Me.lblDatabase.Margin.Right, Me.txtDatabase.Margin.Top)
        Me.cmbType.Location = New System.Drawing.Point(Me.lblDatabase.Location.X - Me.cmbType.Width - Me.cmbType.Margin.Right, 6)
        Me.lblType.Location = New System.Drawing.Point(Me.cmbType.Location.X - Me.lblType.Width - Me.lblType.Margin.Right, Me.cmbType.Margin.Top)


        dtpSt.Value = DateTime.Now.AddDays(-1)

        modCommon.FontChange(Me, p_Font)

    End Sub

    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.xls"
        fsd.Filter = "Excel files (*.xls)|*.xls"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strExcelFile As String = fsd.FileName


            Dim tmpDtSet As New DataSet

            tmpDtSet.Tables.Add(dgvSessionList.GetDataTable2("SESSION_HISTORY"))
            tmpDtSet.Tables.Add(GetTreeDataTable2("LOCK_HISTORY"))
            eXperDB.ODBC.DXOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strExcelFile)
            End If

        End If


    End Sub


    Private Sub dgvIdxinfo_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs)
        If e.ErrorText <> "" Then

        End If


    End Sub

    Private Sub dgvLock_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLock.CellContentDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""

        _SelectedPID = dgvLock.CurrentRow.Cells(colDgvLockBlockingPID.Index).Value
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

    Private Sub dgvSessionList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessionList.CellContentDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""

        _SelectedPID = dgvSessionList.CurrentRow.Cells(coldgvSessionListPID.Index).Value
        If e.ColumnIndex = coldgvSessionListSQL.Index Then
            strDb = dgvSessionList.CurrentRow.Cells(coldgvSessionListDB.Index).Value
            strQuery = dgvSessionList.CurrentCell.Value
            strUser = dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value
            Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
            frmQuery.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click

        Dim dtTable As DataTable = _clsQuery.SelectSessionControlHistory(InstanceID, p_ShowName.ToString("d"))
        Dim strQuery As String = ""
        If dtTable IsNot Nothing Then
            If cmbType.SelectedIndex = 1 Then
                strQuery = String.Format("ACCESS_TYPE = '{0}'", "Cancel")
            ElseIf cmbType.SelectedIndex = 2 Then
                strQuery = String.Format("ACCESS_TYPE = '{0}'", "Stop")
            Else
                strQuery = String.Format("1 = 1")
            End If

            If txtDatabase.Text <> "" Then
                strQuery += String.Format(" AND DB_NAME LIKE '%{0}%'", txtDatabase.Text)
            End If

            strQuery += String.Format(" AND CONTROL_TIME >= '{0}' AND CONTROL_TIME <= '{1}'", dtpSt.Value.ToString("yyyy-MM-dd HH:MM:ss"), dtpEd.Value.ToString("yyyy-MM-dd HH:MM:ss"))
            If txtSQL.Text <> "" Then
                strQuery += String.Format(" AND SQL LIKE '%{0}%'", txtSQL.Text)
            End If

            Dim dtView As DataView = New DataView(dtTable, strQuery, "CONTROL_TIME DESC, CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

            Dim ShowDT As DataTable = Nothing
            If dtView.Count > 0 Then
                ShowDT = dtView.ToTable.AsEnumerable.Take(100).CopyToDataTable
            End If

            If ShowDT Is Nothing Then
                dgvSessionList.DataSource = Nothing
            End If

            dgvSessionList.DataSource = ShowDT

            grpSession.Text = p_clsMsgData.fn_GetData("F313", dtView.Count)
            modCommon.sb_GridSortChg(dgvSessionList)
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        dtTable = _clsQuery.SelectLockControlHistory(InstanceID, p_ShowName.ToString("d"))
        If dtTable IsNot Nothing Then
            Dim Dgv As AdvancedDataGridView.TreeGridView = dgvLock
            Dgv.Nodes.Clear()

            Dim HashTbl As New Hashtable
            Dim intLockCount As Integer = 0
            For Each tmpCol As DataGridViewColumn In Dgv.Columns
                If Not tmpCol.GetType.Equals(GetType(AdvancedDataGridView.TreeGridColumn)) Then
                    HashTbl.Add(tmpCol.Index, tmpCol.DataPropertyName)
                End If
            Next

            Dim dtView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView

            If cmbType.SelectedIndex = 1 Then
                strQuery = String.Format("ACCESS_TYPE = '{0}'", "Cancel")
            ElseIf cmbType.SelectedIndex = 2 Then
                strQuery = String.Format("ACCESS_TYPE = '{0}'", "Stop")
            Else
                strQuery = String.Format("1 = 1")
            End If

            If txtDatabase.Text <> "" Then
                strQuery += String.Format(" AND DB_NAME LIKE '%{0}%'", txtDatabase.Text)
            End If

            strQuery += String.Format(" AND CONTROL_TIME >= '{0}' AND CONTROL_TIME <= '{1}'", dtpSt.Value.ToString("yyyy-MM-dd HH:MM:ss"), dtpEd.Value.ToString("yyyy-MM-dd HH:MM:ss"))
            If txtSQL.Text <> "" Then
                strQuery += String.Format(" AND BLOCKING_QUERY LIKE '%{0}%'", txtSQL.Text)
            End If
            Dim subQuery = strQuery + String.Format(" AND BLOCKED_PID IS NULL")

            For Each tmpRow As DataRow In dtView.ToTable.Select(subQuery, "ORDER_NO ASC")
                Dim topNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("DB_NAME"))
                intLockCount += 1
                sb_AddTreeGridDatas(topNode, HashTbl, tmpRow)
                Dim subQuery2 = strQuery + String.Format(" AND BLOCKED_PID IS NOT NULL AND BLOCKING_PID = {0}", tmpRow.Item("BLOCKING_PID"))
                For Each tmpChild As DataRow In dtView.Table.Select(subQuery2, "ORDER_NO ASC")
                    Dim cNOde As AdvancedDataGridView.TreeGridNode = topNode.Nodes.Add(tmpChild.Item("DB_NAME"))
                    sb_AddTreeGridDatas(cNOde, HashTbl, tmpChild)
                Next
                topNode.Expand()
                topNode.Cells(0).Value = tmpRow.Item("DB_NAME") & " (" & topNode.Nodes.Count & ")"
            Next
            grpLockInfo.Text = p_clsMsgData.fn_GetData("F077", intLockCount)
        End If

    End Sub
    Public Function GetTreeDataTable2(ByVal strTblNm As String) As System.Data.DataTable
        If strTblNm = "" Then
            strTblNm = Me.Name
        End If

        Dim dtTable As System.Data.DataTable = New System.Data.DataTable(strTblNm)
        For Each tmpCol As DataGridViewColumn In dgvLock.Columns
            If tmpCol.Visible = True Then
                dtTable.Columns.Add(tmpCol.HeaderText)
            End If
        Next

        For Each tmpRow As DataGridViewRow In dgvLock.Rows

            Dim dtRow As Data.DataRow = dtTable.NewRow
            For Each tmpCol As DataGridViewColumn In dgvLock.Columns
                If tmpCol.Visible = True Then
                    Dim strValue As String = IIf(IsDBNull(tmpRow.Cells(tmpCol.Index).Value), "", tmpRow.Cells(tmpCol.Index).Value)
                    dtRow.Item(tmpCol.HeaderText) = strValue
                End If
            Next
            dtTable.Rows.Add(dtRow)
        Next

        Return dtTable
    End Function
End Class
