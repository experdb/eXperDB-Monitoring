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


        InitForm()

    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Invoke(New MethodInvoker(Sub()
                                        btnPause.PerformClick()
                                    End Sub))
    End Sub



    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        'FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        'Me.Text += p_clsMsgData.fn_GetData("F138") + " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        Me.Text += " [ " + String.Format("{0}({1}) ", _ServerInfo.ShowNm, _ServerInfo.IP) + "]"
        MsgLabel.Text = p_clsMsgData.fn_GetData("M043")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' DB Information
        lblDBinfo.Text = p_clsMsgData.fn_GetData("F078", 0)
        dgvDBinfo.AutoGenerateColumns = False
        coldgvDBinfoDB.HeaderText = p_clsMsgData.fn_GetData("F104")
        coldgvDBinfoSIZE.HeaderText = p_clsMsgData.fn_GetData("F105")
        coldgvDBinfoTABLECNT.HeaderText = p_clsMsgData.fn_GetData("F106")
        coldgvDBinfoINDEXCNT.HeaderText = p_clsMsgData.fn_GetData("F107")
        coldgvDBinfoDISKREAD.HeaderText = p_clsMsgData.fn_GetData("F108")
        coldgvDBinfoBUFFERREAD.HeaderText = p_clsMsgData.fn_GetData("F109")
        coldgvDBinfoHITRATIO.HeaderText = p_clsMsgData.fn_GetData("F110")


        'Tablespace Information
        lblTblSpaceInfo.Text = p_clsMsgData.fn_GetData("F079", 0)
        dgvTblSpaceInfo.AutoGenerateColumns = False
        coldgvTblSpaceInfoTABLESPACE.HeaderText = p_clsMsgData.fn_GetData("F111")
        coldgvTblSpaceInfoSIZE.HeaderText = p_clsMsgData.fn_GetData("F112")
        coldgvTblSpaceInfoLOCATION.HeaderText = p_clsMsgData.fn_GetData("F113")
        coldgvTblSpaceInfoDISKSIZE.HeaderText = p_clsMsgData.fn_GetData("F114")
        coldgvTblSpaceInfoDISKUSED.HeaderText = p_clsMsgData.fn_GetData("F115")
        coldgvTblSpaceInfoFileSystem.HeaderText = p_clsMsgData.fn_GetData("F271")
        coldgvTblSpaceInfoAvail.HeaderText = p_clsMsgData.fn_GetData("F272")
        coldgvTblSpaceInfoMountPoint.HeaderText = p_clsMsgData.fn_GetData("F273")

        ' Talble Information

        lblTblinfo.Text = p_clsMsgData.fn_GetData("F080", 0)
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
        coldgvTblinfoDEADTUPLES.HeaderText = p_clsMsgData.fn_GetData("F298")
        coldgvTblinfoDEADTUPLERATE.HeaderText = p_clsMsgData.fn_GetData("F299")
        coldgvTblinfoLASTVACUUM.HeaderText = p_clsMsgData.fn_GetData("F125")
        coldgvTblinfoBloatsize.HeaderText = p_clsMsgData.fn_GetData("F318")
        coldgvTblinfoBloatrate.HeaderText = p_clsMsgData.fn_GetData("F319")




        ' Index Information
        lblidxinfo.Text = p_clsMsgData.fn_GetData("F081", 0)
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
        coldgvIdxinfoDeadTuples.HeaderText = p_clsMsgData.fn_GetData("F298")

        btnExcel.Text = p_clsMsgData.fn_GetData("F142")


        For i As Integer = 0 To dgvDBinfo.ColumnCount - 1
            dgvDBinfo.Columns(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
            dgvDBinfo.Columns(i).DefaultCellStyle.ForeColor = System.Drawing.Color.White
            dgvDBinfo.Columns(i).DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            dgvDBinfo.Columns(i).DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Next

        For i As Integer = 0 To dgvTblSpaceInfo.ColumnCount - 1
            dgvTblSpaceInfo.Columns(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
            dgvTblSpaceInfo.Columns(i).DefaultCellStyle.ForeColor = System.Drawing.Color.White
            dgvTblSpaceInfo.Columns(i).DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            dgvTblSpaceInfo.Columns(i).DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Next

        For i As Integer = 0 To dgvTblinfo.ColumnCount - 1
            dgvTblinfo.Columns(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
            dgvTblinfo.Columns(i).DefaultCellStyle.ForeColor = System.Drawing.Color.White
            dgvTblinfo.Columns(i).DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            dgvTblinfo.Columns(i).DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Next

        For i As Integer = 0 To dgvIdxinfo.ColumnCount - 1
            dgvIdxinfo.Columns(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
            dgvIdxinfo.Columns(i).DefaultCellStyle.ForeColor = System.Drawing.Color.White
            dgvIdxinfo.Columns(i).DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            dgvIdxinfo.Columns(i).DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Next

        dgvDBinfo.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvDBinfo.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvTblSpaceInfo.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvTblSpaceInfo.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvTblinfo.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvTblinfo.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvIdxinfo.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvIdxinfo.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)

        'modCommon.FontChange(Me, p_Font)

    End Sub

    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub

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


        lblDBinfo.Text = p_clsMsgData.fn_GetData("F078", dtView.Count)


        modCommon.sb_GridSortChg(dgvDBinfo)
        dgvDBinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub


    ''' <summary>
    ''' tablespace information 정보가 변경 되었을 경우
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataTBspaceinfo(ByVal dtDiskTable As DataTable, ByVal dtTable As DataTable)
        If dtDiskTable Is Nothing Then Return
        If dtTable Is Nothing Then Return
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        dgvTblSpaceInfo.Rows.Clear()
        Try
            'For Each tmpRow As DataRow In dtView.ToTable.Select("BLOCKED_PID IS NULL", "ORDER_NO ASC")
            For Each dtRow As DataRow In dtDiskTable.Select("MOUNT_POINT_DIR <> '-'")
                Dim intInstID As Integer = dtRow.Item("INSTANCE_ID") ' datainfo.C00_INSTANCE_ID
                Dim idxRow As Integer = dgvTblSpaceInfo.Rows.Add()
                Dim strFileSystem As String = dtRow.Item("DISK_NAME")
                Dim strDeviceNm As String = dtRow.Item("MOUNT_POINT_DIR")
                Dim dblTotKb As Double = ConvDBL(dtRow.Item("TOTAL_KB"))
                Dim dblRate As Double = ConvDBL(dtRow.Item("DISK_USAGE_PER"))
                Dim dblAvailKb As Double = ConvDBL(dtRow.Item("AVAIL_KB"))

                dgvTblSpaceInfo.Rows(idxRow).Cells(coldgvTblSpaceInfoFileSystem.Index).Value = strFileSystem
                dgvTblSpaceInfo.Rows(idxRow).Cells(coldgvTblSpaceInfoDISKSIZE.Index).Value = dblTotKb
                dgvTblSpaceInfo.Rows(idxRow).Cells(coldgvTblSpaceInfoDISKUSED.Index).Value = dblRate / 100
                dgvTblSpaceInfo.Rows(idxRow).Cells(coldgvTblSpaceInfoAvail.Index).Value = dblAvailKb
                dgvTblSpaceInfo.Rows(idxRow).Cells(coldgvTblSpaceInfoMountPoint.Index).Value = strDeviceNm
            Next
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try

        For Each dtRow As DataRow In dtTable.Rows
            Dim strLocation As String = dtRow.Item("LOCATION")
            Dim dblTotKb As Double = ConvDBL(dtRow.Item("SIZE"))
            Dim strTablespace As String = dtRow.Item("TABLESPACE")
            Dim bFoundMT As Boolean = False
            Dim intRowIndex As Integer = -1
            intRowIndex = findMountPoint(dtTable)
            If intRowIndex >= 0 Then
                Using dgvRow As DataGridViewRow = dgvTblSpaceInfo.Rows(intRowIndex)
                    If dgvRow.Cells(coldgvTblSpaceInfoTABLESPACE.Index).Value = "" Then
                        dgvRow.Cells(coldgvTblSpaceInfoTABLESPACE.Index).Value = strTablespace
                        dgvRow.Cells(coldgvTblSpaceInfoSIZE.Index).Value = dblTotKb
                        dgvRow.Cells(coldgvTblSpaceInfoLOCATION.Index).Value = strLocation
                    Else
                        Dim intNewRow = dgvRow.Index + 1
                        dgvTblSpaceInfo.Rows.Insert(intNewRow)
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoFileSystem.Index).Value = dgvRow.Cells(coldgvTblSpaceInfoFileSystem.Index).Value
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoDISKSIZE.Index).Value = dgvRow.Cells(coldgvTblSpaceInfoDISKSIZE.Index).Value
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoDISKUSED.Index).Value = dgvRow.Cells(coldgvTblSpaceInfoDISKUSED.Index).Value
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoAvail.Index).Value = dgvRow.Cells(coldgvTblSpaceInfoAvail.Index).Value
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoMountPoint.Index).Value = dgvRow.Cells(coldgvTblSpaceInfoMountPoint.Index).Value
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoTABLESPACE.Index).Value = strTablespace
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoSIZE.Index).Value = dblTotKb
                        dgvTblSpaceInfo.Rows(intNewRow).Cells(coldgvTblSpaceInfoLOCATION.Index).Value = strLocation
                    End If
                End Using
            End If
        Next

        lblTblSpaceInfo.Text = p_clsMsgData.fn_GetData("F079", dtTable.Rows.Count)
        modCommon.sb_GridSortChg(dgvTblSpaceInfo)
        dgvTblSpaceInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


    End Sub

    ''' <summary>
    ''' Find Mount Point index
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <param name="bRootfs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function findMountPoint(ByVal dtTable As DataTable) As Integer
        Dim bRootfs As Boolean = False
        Dim intReturn As Integer = -1
        For Each dtRow As DataRow In dtTable.Rows
            Dim strLocation As String = dtRow.Item("LOCATION")
            For intRow As Integer = 0 To dgvTblSpaceInfo.Rows.Count - 1
                Dim strDeviceNm As String = dgvTblSpaceInfo.Rows(intRow).Cells(coldgvTblSpaceInfoMountPoint.Index).Value
                If strDeviceNm.Equals("/") = False Then
                    If strLocation.IndexOf(strDeviceNm) >= 0 Then
                        intReturn = intRow
                        Return intReturn
                    End If
                End If
            Next
            Dim dgvRow As DataGridViewRow = dgvTblSpaceInfo.FindFirstRow("/", coldgvTblSpaceInfoMountPoint.Index)
            If dgvRow IsNot Nothing Then
                intReturn = dgvRow.Index
            End If
            Return intReturn
        Next
    End Function


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
        lblTblinfo.Text = p_clsMsgData.fn_GetData("F080", dtView.Count)
        modCommon.sb_GridSortChg(dgvTblinfo)
        sb_GridClrChange(dgvTblinfo)
        dgvTblinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub

    Public Function sb_GridClrChange(ByVal Dgv As Windows.Forms.DataGridView) As Boolean
        Threading.Thread.Sleep(1)

        For Each tmpRow As DataGridViewRow In Dgv.Rows

            Dim tmpCellValue As Integer = tmpRow.Cells(coldgvTblinfoBloatTable.Index).Value

            If tmpCellValue > 0 Then
                'tmpRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
                'tmpRow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
                tmpRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
                tmpRow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
                'tmpRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(56, Byte), Integer))
                'tmpRow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(56, Byte), Integer))
            Else
                tmpRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
                tmpRow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            End If
        Next

    End Function


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

        lblidxinfo.Text = p_clsMsgData.fn_GetData("F081", dtView.Count)
        modCommon.sb_GridSortChg(dgvIdxinfo)
        dgvIdxinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnPause.Click

        '_frmWait = New frmWait
        '_frmWait.TopMost = True
        '_frmWait.Show(Me)

        _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)
        _AgentObject.SendDX001(Me.InstanceID)


        If bckmanual.IsBusy = True Then
            bckmanual.CancelAsync()
            Return
        End If
        'bckmanual.RunWorkerAsync()

    End Sub


    Private Sub bckmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bckmanual.DoWork
        'If _frmWait IsNot Nothing Then
        '    _frmWait.AddText("Data select start")
        'End If
        If p_clsAgentCollect.ThreadManual(Me.InstanceID, 60000) = True Then

        End If
        bckmanual.ReportProgress(100)

    End Sub

    Private Sub bckmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bckmanual.ProgressChanged

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
            Me.SetDataTBspaceinfo(p_clsAgentCollect.infoDataDiskUsage, p_clsAgentCollect.infoDataTBspaceinfo)
            If _frmWait IsNot Nothing Then
                _frmWait.AddText("Data Index Information")
            End If
            Me.SetDataIndexinfo(p_clsAgentCollect.infoDataIndexinfo)
            'lblRefreshTime.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")


        End If

        If _frmWait IsNot Nothing Then
            _frmWait.Close()
        End If

        If cbxCheckTableBloat.Checked = True Then
            cbxCheckTableBloat.Checked = False
            cbxCheckTableBloat.Checked = True
        End If
    End Sub

    Private Sub frmMonActInfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'bckmanual.RunWorkerAsync()
        'Me.Invoke(New MethodInvoker(Sub()
        'btnPause.PerformClick()
        'End Sub))

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
            eXperDB.ODBC.eXperDBOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

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

                'Else
                '    Me.Invoke(New MethodInvoker(Sub()
                '                                    If _frmWait IsNot Nothing Then
                '                                        _frmWait.AddText(String.Format("[{0}]{1}", rtnValue._tran_res_data(0)._error_cd, rtnValue._tran_res_data(1)._error_msg))
                '                                    End If
                '                                End Sub))
            End If
            'ElseIf e.GetType.Equals(GetType(clsSocket.Results)) Then
            '    'Me.Invoke(New MethodInvoker(Sub()
            '    '                                If _frmWait IsNot Nothing Then
            '    '                                    _frmWait.AddText(DirectCast(e, clsSocket.Results).ErrorMsg)
            '    '                                End If
            '    '                            End Sub))
            'Else
            '    Me.Invoke(New MethodInvoker(Sub()
            '                                    If _frmWait IsNot Nothing Then
            '                                        _frmWait.AddText("Unknown Error")
            '                                    End If
            '                                End Sub))
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


    Private Sub dgvIdxinfo_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs) Handles dgvIdxinfo.CellErrorTextNeeded
        If e.ErrorText <> "" Then

        End If


    End Sub

    Private Sub cbxCheckTableBloat_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCheckTableBloat.CheckedChanged
        If cbxCheckTableBloat.Checked = True Then
            DirectCast(dgvTblinfo.DataSource, DataView).RowFilter = String.Format("bloat_table = '1'")
        Else
            DirectCast(dgvTblinfo.DataSource, DataView).RowFilter = Nothing
        End If
        sb_GridClrChange(dgvTblinfo)
    End Sub
End Class
