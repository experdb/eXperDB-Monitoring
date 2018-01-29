Public Class frmMonActInfo


    Private _Elapseinterval As Integer = 3000  ' 2시간을 기본으로 설정 
    Private _InstanceID As Integer = -1
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


    Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = ServerInfo.InstanceID
        _Elapseinterval = ElapseInterval
        _ServerInfo = ServerInfo
        _AgentInfo = clsAgentInfo





    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
    End Sub



    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"


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
        colDgvLOckLockMode.HeaderText = p_clsMsgData.fn_GetData("F222")
        colDgvLockQueryStart.HeaderText = p_clsMsgData.fn_GetData("F223")
        colDgvLockXactStart.HeaderText = p_clsMsgData.fn_GetData("F224")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' DB Information
        grpDBinfo.Text = p_clsMsgData.fn_GetData("F078", 0)
        dgvDBinfo.AutoGenerateColumns = False
        coldgvDBinfoDB.HeaderText = p_clsMsgData.fn_GetData("F104")
        coldgvDBinfoSIZE.HeaderText = p_clsMsgData.fn_GetData("F105")
        coldgvDBinfoTABLECNT.HeaderText = p_clsMsgData.fn_GetData("F106")
        coldgvDBinfoINDEXCNT.HeaderText = p_clsMsgData.fn_GetData("F107")
        coldgvDBinfoDISKREAD.HeaderText = p_clsMsgData.fn_GetData("F108")
        coldgvDBinfoBUFFERREAD.HeaderText = p_clsMsgData.fn_GetData("F109")
        coldgvDBinfoHITRATIO.HeaderText = p_clsMsgData.fn_GetData("F110")



        'Tablespace Information
        grpTblSpaceInfo.Text = p_clsMsgData.fn_GetData("F079", 0)
        dgvTblSpaceInfo.AutoGenerateColumns = False
        coldgvTblSpaceInfoTABLESPACE.HeaderText = p_clsMsgData.fn_GetData("F111")
        coldgvTblSpaceInfoSIZE.HeaderText = p_clsMsgData.fn_GetData("F112")
        coldgvTblSpaceInfoLOCATION.HeaderText = p_clsMsgData.fn_GetData("F113")
        coldgvTblSpaceInfoDISKSIZE.HeaderText = p_clsMsgData.fn_GetData("F114")
        coldgvTblSpaceInfoDISKUSED.HeaderText = p_clsMsgData.fn_GetData("F115")

        ' Talble Information

        grpTblinfo.Text = p_clsMsgData.fn_GetData("F080", 0)
        dgvTblinfo.AutoGenerateColumns = False
        coldgvTblinfoDB.HeaderText = p_clsMsgData.fn_GetData("F116")
        coldgvTblinfoTABLE.HeaderText = p_clsMsgData.fn_GetData("F117")
        coldgvTblinfoTABLESIZE.HeaderText = p_clsMsgData.fn_GetData("F118")
        coldgvTblinfoINDEXSIZE.HeaderText = p_clsMsgData.fn_GetData("F119")
        coldgvTblinfoINDEXCNT.HeaderText = p_clsMsgData.fn_GetData("F120")
        coldgvTblinfoISTOAST.HeaderText = p_clsMsgData.fn_GetData("F121")
        coldgvTblinfoSEQSCAN.HeaderText = p_clsMsgData.fn_GetData("F122")
        coldgvTblinfoINDEXSCAN.HeaderText = p_clsMsgData.fn_GetData("F123")
        coldgvTblinfoLIVETUPLES.HeaderText = p_clsMsgData.fn_GetData("F124")
        coldgvTblinfoLASTVACUUM.HeaderText = p_clsMsgData.fn_GetData("F125")





        ' Index Information
        grpidxinfo.Text = p_clsMsgData.fn_GetData("F081", 0)
        dgvIdxinfo.AutoGenerateColumns = False
        coldgvIdxinfoDB.HeaderText = p_clsMsgData.fn_GetData("F126")
        coldgvIdxinfoINDEX.HeaderText = p_clsMsgData.fn_GetData("F127")
        coldgvIdxinfoTABLE.HeaderText = p_clsMsgData.fn_GetData("F128")
        coldgvIdxinfoINDEXSIZE.HeaderText = p_clsMsgData.fn_GetData("F129")
        coldgvIdxinfoINDEXSCANCOUNT.HeaderText = p_clsMsgData.fn_GetData("F130")
        coldgvIdxinfoINDEXFETCHEDTUPLES.HeaderText = p_clsMsgData.fn_GetData("F131")
        coldgvIdxinfoUPDATEDTUPLES.HeaderText = p_clsMsgData.fn_GetData("F132")
        coldgvIdxinfoDELETEDTUPLES.HeaderText = p_clsMsgData.fn_GetData("F133")
        coldgvIdxinfoLiveTuples.HeaderText = p_clsMsgData.fn_GetData("F124")


        grpTableInfo.Text = p_clsMsgData.fn_GetData("F138")

        btnExcel.Text = p_clsMsgData.fn_GetData("F142")

        'btnRefresh.Text = p_clsMsgData.fn_GetData("F137")

        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseRotationBox = False
        Me.FormControlBox1.UsePowerBox = False

        ' fit button location
        Me.btnExcel.Location = New System.Drawing.Point(Me.grpTableInfo.Width - Me.btnExcel.Width - Me.btnExcel.Margin.Right, Me.btnExcel.Margin.Top)
        Me.btnRefresh.Location = New System.Drawing.Point(Me.btnExcel.Location.X - Me.btnRefresh.Width - Me.btnRefresh.Margin.Right, Me.btnRefresh.Margin.Top)
        Me.lblRefreshTime.Location = New System.Drawing.Point(Me.btnRefresh.Location.X - Me.lblRefreshTime.Width - Me.lblRefreshTime.Margin.Right, Me.btnRefresh.Margin.Top + 4)
        'Me.btnExcel.Location = New System.Drawing.Point(1704, 4)

        Me.btnPause.Location = New System.Drawing.Point(Me.grpLockInfo.Width - Me.btnPause.Width - Me.btnPause.Margin.Right, Me.btnPause.Margin.Top)


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
        If btnPause.Text = "4" Then Return


        'Dim topRows As DataRow() = dtTable.Select(String.Format("INSTANCE_ID={0} AND BLOCKED_PID IS NULL", Me.InstanceID), "ORDER_NO ASC")
        Dim Dgv As AdvancedDataGridView.TreeGridView = dgvLock
        Dgv.Nodes.Clear()

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
            For Each tmpChild As DataRow In dtView.Table.Select(String.Format("BLOCKED_PID IS NOT NULL AND BLOCKING_PID = {0}", tmpRow.Item("BLOCKING_PID")), "ORDER_NO ASC")
                Dim cNOde As AdvancedDataGridView.TreeGridNode = topNode.Nodes.Add(tmpChild.Item("DB_NAME"))
                sb_AddTreeGridDatas(cNOde, HashTbl, tmpChild)

            Next
            topNode.Expand()
            topNode.Cells(0).Value = tmpRow.Item("DB_NAME") & " (" & topNode.Nodes.Count & ")"

        Next


        'For Each tmpRow As DataRow In topRows
        '    Dim tvNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("DB_NAME"))
        '    For Each tmpChild As DataRow In dtTable.Select(String.Format("INSTANCE_ID = {0} AND BLOCKED_PID IS NULL

        '    Next






        'modCommon.sb_GridSortChg(dgvLock, srtColidx, srtOrd)
        dgvLock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



    End Sub


    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub

    ' ''' <summary>
    ' ''' Current Activity 정보가 변경 되었을 경우
    ' ''' </summary>
    ' ''' <param name="dtTable"></param>
    ' ''' <remarks></remarks>
    'Public Sub SetDataCurrentAct(ByVal dtTable As DataTable)
    '    ' 전체 목록중 내것만 추출 
    '    ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 



    '    Dim dtView As DataView = New DataView(dtTable, "INSTANCE_ID=" & Me.InstanceID, "", DataViewRowState.CurrentRows)


    '    ' 초기화 

    '    dgvCurrentAct.DataSource = dtView



    'End Sub






    ''' <summary>
    ''' table information 정보가 변경 되었을 경우
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataDBinfo(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 


        'Dim dtView As DataView = New DataView(dtTable, "INSTANCE_ID=" & Me.InstanceID, "", DataViewRowState.CurrentRows)

        Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView
        dgvDBinfo.DataSource = dtView ' dtTable.DefaultView


        grpDBinfo.Text = p_clsMsgData.fn_GetData("F078", dtView.Count)


        modCommon.sb_GridSortChg(dgvDBinfo)
        dgvDBinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub


    ''' <summary>
    ''' tablespace information 정보가 변경 되었을 경우
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataTBspaceinfo(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        'Dim dtView As DataView = New DataView(dtTable, "INSTANCE_ID=" & Me.InstanceID, "", DataViewRowState.CurrentRows)
        'dgvTblSpaceInfo.DataSource = dtView
        Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView
        dgvTblSpaceInfo.DataSource = dtView


        grpTblSpaceInfo.Text = p_clsMsgData.fn_GetData("F079", dtView.Count)
        modCommon.sb_GridSortChg(dgvTblSpaceInfo)
        dgvTblSpaceInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)




    End Sub


    ''' <summary>
    ''' table Information 정보가 변경 되었을 경우
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataTBinfo(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        ' Dim dtView As DataView = New DataView(dtTable, "INSTANCE_ID=" & Me.InstanceID, "", DataViewRowState.CurrentRows)

        'dgvTblinfo.DataSource = dtView
        Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView
        dgvTblinfo.DataSource = dtView
        grpTblinfo.Text = p_clsMsgData.fn_GetData("F080", dtView.Count)
        modCommon.sb_GridSortChg(dgvTblinfo)
        dgvTblinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub


    ' ''' <summary>
    ' ''' table Information 정보가 변경 되었을 경우
    ' ''' </summary>
    ' ''' <param name="lst"></param>
    ' ''' <remarks></remarks>
    'Public Sub SetDataTBinfo(ByVal lst As List(Of structTBinfo))
    '    ' 전체 목록중 내것만 추출 
    '    ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 
    '    Dim arrLst As List(Of structTBinfo) = lst.FindAll(Function(tmpData As structTBinfo)
    '                                                          If tmpData.C00_INSTANCE_ID = Me.InstanceID Then
    '                                                              Return True
    '                                                          Else
    '                                                              Return False
    '                                                          End If
    '                                                      End Function)


    '    ' 초기화 
    '    dgvTblinfo.InvokeRowsClear()

    '    If arrLst.Count > 0 Then

    '        dgvTblinfo.Invoke(New MethodInvoker(Sub() dgvTblinfo.SuspendLayout()))


    '        ' Lock info

    '        For Each tmpStruct As structTBinfo In arrLst
    '            Using dgvRow As DataGridViewRow = dgvTblinfo.FindFirstRow(tmpStruct.C00_INSTANCE_ID, coldgvTblinfoTABLE.Index)
    '                If dgvRow Is Nothing Then
    '                    Dim intIDx As Integer = dgvTblinfo.InvokeRowsAdd()


    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoDB.Index).Value = tmpStruct.C01_DB_NAME
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoTABLE.Index).Value = tmpStruct.C02_TABLE_NAME
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoTABLESIZE.Index).Value = tmpStruct.C03_TABLE_SIZE
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoINDEXSIZE.Index).Value = tmpStruct.C04_INDEX_SIZE
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoINDEXCNT.Index).Value = tmpStruct.C05_INDEX_CNT
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoISTOAST.Index).Value = tmpStruct.C06_IS_TOAST

    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoSEQSCAN.Index).Value = tmpStruct.C07_SEQ_SCAN
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoINDEXSCAN.Index).Value = tmpStruct.C08_INDEX_SCAN
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoLIVETUPLES.Index).Value = tmpStruct.C09_LIVE_TUPLE_CNT
    '                    dgvTblinfo.Rows(intIDx).Cells(coldgvTblinfoLASTVACUUM.Index).Value = tmpStruct.C10_LAST_VACUUM

    '                Else

    '                    dgvRow.Cells(coldgvTblinfoDB.Index).Value = tmpStruct.C01_DB_NAME
    '                    dgvRow.Cells(coldgvTblinfoTABLE.Index).Value = tmpStruct.C02_TABLE_NAME
    '                    dgvRow.Cells(coldgvTblinfoTABLESIZE.Index).Value = tmpStruct.C03_TABLE_SIZE
    '                    dgvRow.Cells(coldgvTblinfoINDEXSIZE.Index).Value = tmpStruct.C04_INDEX_SIZE
    '                    dgvRow.Cells(coldgvTblinfoINDEXCNT.Index).Value = tmpStruct.C05_INDEX_CNT
    '                    dgvRow.Cells(coldgvTblinfoISTOAST.Index).Value = tmpStruct.C06_IS_TOAST

    '                    dgvRow.Cells(coldgvTblinfoSEQSCAN.Index).Value = tmpStruct.C07_SEQ_SCAN
    '                    dgvRow.Cells(coldgvTblinfoINDEXSCAN.Index).Value = tmpStruct.C08_INDEX_SCAN
    '                    dgvRow.Cells(coldgvTblinfoLIVETUPLES.Index).Value = tmpStruct.C09_LIVE_TUPLE_CNT
    '                    dgvRow.Cells(coldgvTblinfoLASTVACUUM.Index).Value = tmpStruct.C10_LAST_VACUUM

    '                End If

    '            End Using
    '        Next

    '        modCommon.sb_GridSortChg(dgvTblinfo)
    '        dgvTblinfo.Invoke(New MethodInvoker(Sub() dgvTblinfo.ResumeLayout()))

    '    End If


    'End Sub











    ''' <summary>
    '''  index Information 정보가 변경 되었을 경우
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataIndexinfo(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        'Dim dtView As DataView = New DataView(dtTable, "INSTANCE_ID=" & Me.InstanceID, "", DataViewRowState.CurrentRows)

        'dgvIdxinfo.DataSource = dtView
        Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView

        dgvIdxinfo.DataSource = dtView

        grpidxinfo.Text = p_clsMsgData.fn_GetData("F081", dtView.Count)
        modCommon.sb_GridSortChg(dgvIdxinfo)
        dgvIdxinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

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
            If _frmWait IsNot Nothing Then
                _frmWait.AddText("Data Database Information")
            End If
            Me.SetDataDBinfo(p_clsAgentCollect.infoDataDBinfo)
            If _frmWait IsNot Nothing Then
                _frmWait.AddText("Data Table Information")
            End If
            Me.SetDataTBinfo(p_clsAgentCollect.infoDataTBinfo)
            If _frmWait IsNot Nothing Then
                _frmWait.AddText("Data Table Space Information")
            End If
            Me.SetDataTBspaceinfo(p_clsAgentCollect.infoDataTBspaceinfo)
            If _frmWait IsNot Nothing Then
                _frmWait.AddText("Data Index Information")
            End If
            Me.SetDataIndexinfo(p_clsAgentCollect.infoDataIndexinfo)
            lblRefreshTime.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")


        End If

        If _frmWait IsNot Nothing Then
            _frmWait.Close()
        End If

    End Sub

    Private Sub frmMonActInfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        bckmanual.RunWorkerAsync()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.xls"
        fsd.Filter = "Excel files (*.xls)|*.xls"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strExcelFile As String = fsd.FileName


            Dim tmpDtSet As New DataSet

            tmpDtSet.Tables.Add(dgvTblSpaceInfo.GetDataTable("TABLE_SPACE_INFO"))
            tmpDtSet.Tables.Add(dgvDBinfo.GetDataTable("DATABASE_INFO"))
            tmpDtSet.Tables.Add(dgvTblinfo.GetDataTable("TABLE_INFO"))
            tmpDtSet.Tables.Add(dgvIdxinfo.GetDataTable("INDEX_INFO"))
            eXperDB.ODBC.DXOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strExcelFile)
            End If

        End If


    End Sub

    Private WithEvents _AgentObject As clsAgentEMsg

    Private Sub AgentObject_Complete(sender As Object, e As Object) Handles _AgentObject.Complete


        If e.GetType.Equals(GetType(clsAgentEMsg.DX001_REP)) Then
            Dim rtnValue As clsAgentEMsg.DX001_REP = DirectCast(e, clsAgentEMsg.DX001_REP)

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
                                                    _frmWait.AddText(String.Format("[{0}]{1}", rtnValue._tran_res_data(0)._error_cd, rtnValue._tran_res_data(1)._error_msg))
                                                End If
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


    Private Sub dgvIdxinfo_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs) Handles dgvIdxinfo.CellErrorTextNeeded
        If e.ErrorText <> "" Then

        End If


    End Sub




    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        ' Play webding = "4"   Pause Webding = ";"
        If btnPause.Text = "4" Then
            btnPause.Text = ";"
        Else
            btnPause.Text = "4"
        End If


    End Sub


    Private Sub dgvLock_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLock.CellContentDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""

        If e.ColumnIndex = colDgvLockBlockedQuery.Index Then
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strQuery = dgvLock.CurrentCell.Value
            strUser = dgvLock.CurrentRow.Cells(colDgvLockBlockedUser.Index).Value
        ElseIf e.ColumnIndex = colDgvLockBlockingQuery.Index Then
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strQuery = dgvLock.CurrentCell.Value
            strUser = dgvLock.CurrentRow.Cells(colDgvLockBlockingUser.Index).Value
        End If

        Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
        frmQuery.ShowDialog(Me)

    End Sub

End Class
