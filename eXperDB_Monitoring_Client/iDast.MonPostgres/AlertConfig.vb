Public Class AlertConfig

    Private _clsQuery As clsQuerys
    Private _alertConfig As AlertConfigurationForm
    Private _alertConfigHAGroup As AlertConfigurationHAGroupForm
    Private _dtInitThreshold As DataTable
    Private _dtThreshold As DataTable
    Public Sub New(ByRef odbcConn As eXperDBODBC)
        ' 이 호출은 디자이너에 필요합니다
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _clsQuery = New clsQuerys(odbcConn)
        initForm()
    End Sub

    Private Sub initForm()
        Me.dgvSvrLst.AutoGenerateColumns = False
        coldgvHostName.HeaderText = p_clsMsgData.fn_GetData("F229")

        lblServerList.Text = p_clsMsgData.fn_GetData("F281")

        btnSave.Text = p_clsMsgData.fn_GetData("F014")
        btnInit.Text = p_clsMsgData.fn_GetData("F226")
        btnSaveAll.Text = p_clsMsgData.fn_GetData("F951")

        rbGrpCluster.Text = p_clsMsgData.fn_GetData("F362")
        rbGrpHAGroup.Text = p_clsMsgData.fn_GetData("F363")
        rbGrpCluster.Checked = True

        'Me.ttChart.SetToolTip(Me.btnAddUserGroup, p_clsMsgData.fn_GetData("F016"))
        'Me.ttChart.SetToolTip(Me.btnDeleteUserGroup, p_clsMsgData.fn_GetData("F015"))
        'Me.ttChart.SetToolTip(Me.btnAddGroup, p_clsMsgData.fn_GetData("F942"))
        'Me.ttChart.SetToolTip(Me.btnModifyGroup, p_clsMsgData.fn_GetData("F943"))
        'Me.ttChart.SetToolTip(Me.btnDeleteGroup, p_clsMsgData.fn_GetData("F944"))
    End Sub

    Private Sub AlertConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadServerList()
            LoadAlertConfiguration(0)
            LoadAlertConfigurationHAGroup(0)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub dgvSvrLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSvrLst.CellClick
        If e.RowIndex >= 0 Then
            SetAlertConfiguration(dgvSvrLst.CurrentRow.Tag)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim HealtLimited As AlertConfigurationForm.GetServerAlertConfig = _alertConfig.GetValue()
        Dim HealtLimitedHG As AlertConfigurationHAGroupForm.GetServerAlertConfig = _alertConfigHAGroup.GetValue()
        Dim InstanceID As Integer = HealtLimited.InstanceID
        SaveAlertConfiguration(HealtLimited, HealtLimitedHG, InstanceID)
        MsgBox(p_clsMsgData.fn_GetData("M028"))
    End Sub

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        SetAlertConfiguration(-1)
    End Sub

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        ShowChooseClusters()
    End Sub

    Private Sub rbGrp_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrpCluster.CheckedChanged, rbGrpHAGroup.CheckedChanged
        Dim RadioButton As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If RadioButton.Checked = False Then Return
        Try
            If dgvSvrLst.CurrentNode.Parent IsNot Nothing Then

            End If

            If rbGrpCluster.Checked = True Then
                For Each tmpNode As AdvancedDataGridView.TreeGridNode In Me.dgvSvrLst.Nodes
                    tmpNode.Expand()
                Next
                _alertConfig.Visible = True
                _alertConfigHAGroup.Visible = False
            Else
                Dim pNode As AdvancedDataGridView.TreeGridNode = dgvSvrLst.CurrentNode
                Dim cNode As AdvancedDataGridView.TreeGridNode
                Do
                    cNode = pNode
                    pNode = cNode.Parent
                Loop While pNode.Parent IsNot Nothing
                'dgvSvrLst.CurrentCell = dgvSvrLst.Item(0, cNode.RowIndex)

                For Each tmpNode As AdvancedDataGridView.TreeGridNode In Me.dgvSvrLst.Nodes
                    tmpNode.Collapse()
                Next
                _alertConfig.Visible = False
                _alertConfigHAGroup.Visible = True
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub dgvSvrLst_NodeCollapsing(sender As Object, e As AdvancedDataGridView.CollapsingEventArgs) Handles dgvSvrLst.NodeCollapsing
        If rbGrpCluster.Checked = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub dgvSvrLst_NodeExpanding(sender As Object, e As AdvancedDataGridView.ExpandingEventArgs) Handles dgvSvrLst.NodeExpanding
        If rbGrpCluster.Checked = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ReadServerList()
        dgvSvrLst.Nodes.Clear()
        If _clsQuery Is Nothing Then Return

        Dim HashTbl As New Hashtable
        For Each tmpCol As DataGridViewColumn In dgvSvrLst.Columns
            If Not tmpCol.GetType.Equals(GetType(AdvancedDataGridView.TreeGridColumn)) And _
               Not tmpCol.GetType.Equals(GetType(DataGridViewImageColumn)) Then
                HashTbl.Add(tmpCol.Index, tmpCol.DataPropertyName)
            End If
        Next

        Try
            Dim dtTable As DataTable = _clsQuery.SelectServerList()
            If dtTable IsNot Nothing Then
                Dim dtView As DataView = dtTable.AsEnumerable.AsDataView
                For Each tmpRow As DataRow In dtView.ToTable.Select("HA_ROLE = 'P' OR HA_ROLE = 'A'")
                    Dim topNode As AdvancedDataGridView.TreeGridNode = dgvSvrLst.Nodes.Add(IIf(p_ShowName = 0, tmpRow.Item("HOST_NAME"), tmpRow.Item("CONN_NAME")))
                    topNode.Tag = tmpRow.Item("INSTANCE_ID")
                    topNode.Image = dbmsImgLst.Images(0)
                    topNode.Height = 45

                    sb_AddTreeGridDatas(topNode, HashTbl, tmpRow)
                    Dim newNode As AdvancedDataGridView.TreeGridNode = topNode
                    newNode.Expand()
                    For i As Integer = 1 To p_NodeLevel - 1
                        If newNode IsNot Nothing Then
                            newNode = sb_AddChildNode(newNode, HashTbl, dtView.Table.Select("HA_ROLE = 'S'"))
                            If newNode IsNot Nothing Then newNode.Expand()
                        End If
                    Next
                Next
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next
    End Sub

    Private Function sb_AddChildNode(ByVal pNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtView As System.Data.DataRow()) As AdvancedDataGridView.TreeGridNode
        Dim newNode As AdvancedDataGridView.TreeGridNode = Nothing
        If pNode.Cells(coldgvHostNameKey.Index).Value.ToString() <> "" Then
            For Each tmpChild As DataRow In DtView
                If (tmpChild.Item("HA_HOST") Like (pNode.Cells(coldgvHostNameKey.Index).Value + "*")) = True Or _
                    tmpChild.Item("HA_HOST") = pNode.Cells(coldgvIP.Index).Value Then
                    newNode = pNode.Nodes.Add(IIf(p_ShowName = 0, tmpChild.Item("HOST_NAME"), tmpChild.Item("CONN_NAME")))
                    newNode.Tag = tmpChild.Item("INSTANCE_ID")
                    newNode.Image = dbmsImgLst.Images(1)
                    newNode.Height = 45
                    sb_AddTreeGridDatas(newNode, ColHashSet, tmpChild)
                End If
            Next
        End If
        Return newNode
    End Function

    Private Sub LoadAlertConfiguration(ByVal nRow As Integer)
        Try
            _dtInitThreshold = _clsQuery.SelectIniFixedThreshold()
            Dim dtUserGroup As DataTable = _clsQuery.SelectMonUserGroup()
            _alertConfig = New AlertConfigurationForm(_clsQuery, _dtInitThreshold, dtUserGroup)
            _alertConfig.Dock = DockStyle.Fill
            _alertConfig.BorderStyle = BorderStyle.FixedSingle
            _alertConfig.Name = "AlertConfiguration"
            _alertConfig.Width = tlpAlertConfig.Width
            _alertConfig.Height = tlpAlertConfig.Height
            _alertConfig.Margin = New Padding(0)
            _alertConfig.Padding = New Padding(0)
            tlpAlertConfig.Controls.Add(_alertConfig, 0, 0)

            _dtThreshold = _clsQuery.SelectHealthLimited(dgvSvrLst.Rows(nRow).Tag)
            If _dtThreshold IsNot Nothing Then
                _alertConfig.Setvalue(_dtThreshold, dgvSvrLst.Rows(nRow).Tag)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub SetAlertConfiguration(ByVal intInstanceID As Integer)
        Try
            Dim dtTable As DataTable = _clsQuery.SelectHealthLimited(intInstanceID)
            If dtTable IsNot Nothing Then
                _alertConfig.Setvalue(dtTable, intInstanceID)
                _alertConfigHAGroup.Setvalue(dtTable, intInstanceID)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub LoadAlertConfigurationHAGroup(ByVal nRow As Integer)
        Try
            _alertConfigHAGroup = New AlertConfigurationHAGroupForm(_clsQuery, _dtInitThreshold)
            _alertConfigHAGroup.Dock = DockStyle.Fill
            _alertConfigHAGroup.BorderStyle = BorderStyle.FixedSingle
            _alertConfigHAGroup.Name = "AlertConfigurationHAGroup"
            _alertConfigHAGroup.Width = tlpAlertConfig.Width
            _alertConfigHAGroup.Height = tlpAlertConfig.Height
            _alertConfigHAGroup.Margin = New Padding(0)
            _alertConfigHAGroup.Padding = New Padding(0)
            _alertConfigHAGroup.Visible = False
            tlpAlertConfig.Controls.Add(_alertConfigHAGroup, 0, 0)

            If _dtThreshold IsNot Nothing Then
                _alertConfigHAGroup.Setvalue(_dtThreshold, dgvSvrLst.Rows(nRow).Tag)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Public Function GetCriticalThreshold_1(ByVal Normal As Integer, ByVal Warning As Integer) As String
        Dim CriticalThreshold As String = String.Empty

        If Normal = Warning Then
            If Normal = 100 Then
                CriticalThreshold = "9"
            ElseIf Normal = 0 Then
                CriticalThreshold = "2"
            Else
                CriticalThreshold = "0"
            End If
        Else
            If Normal = 0 AndAlso Warning = 100 Then
                CriticalThreshold = "1"
            Else
                CriticalThreshold = "0"
            End If

        End If


        Return CriticalThreshold
    End Function

    Public Function GetCriticalThreshold_2(ByVal Warning As Integer, ByVal Normal As Integer) As String
        Dim CriticalThreshold As String = String.Empty

        If Normal = Warning Then
            If Normal = 0 Then
                CriticalThreshold = "9"
            ElseIf Normal = 100 Then
                CriticalThreshold = "2"
            Else
                CriticalThreshold = "0"
            End If
        Else
            If Normal = 0 AndAlso Warning = 100 Then
                CriticalThreshold = "1"
            Else
                CriticalThreshold = "0"
            End If

        End If
        Return CriticalThreshold
    End Function

    Private Sub ShowChooseClusters()

        Dim GrpListServerinfo As New List(Of GroupInfo.ServerInfo)

        Dim grpIdx As Integer = 0

        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            ' 그룹이 선택되어 있을 경우 
            Dim intInstanceID As Integer = tmpRow.Tag
            Dim strIP As String = tmpRow.Cells(coldgvIP.Index).Value
            Dim strAliasNm As String = tmpRow.Cells(coldgvAliasNm.Index).Value
            Dim strHostNm As String = tmpRow.Cells(coldgvHostNameKey.Index).Value
            Dim strHARole As String = tmpRow.Cells(coldgvHARole.Index).Value
            Dim strHAHost As String = tmpRow.Cells(coldgvHAHost.Index).Value

            GrpListServerinfo.Add(New GroupInfo.ServerInfo(intInstanceID, strIP, "", 0, "", strAliasNm, strHostNm, Nothing, strHARole, strHAHost, 0, 0, ""))
        Next

        Dim frmCS As New frmClusterShow(GrpListServerinfo, Nothing, True)
        If frmCS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rtnStruct As structConnection = Nothing
            Dim rtnSchema As String = ""
            Dim rtnCollect As Integer = 0
            Dim strAlias As String = ""

            Dim index As Integer = 0
            Dim HealtLimited As AlertConfigurationForm.GetServerAlertConfig = _alertConfig.GetValue()
            Dim HealtLimitedHG As AlertConfigurationHAGroupForm.GetServerAlertConfig = _alertConfigHAGroup.GetValue()
            For Each tmpSvr As GroupInfo.ServerInfo In GrpListServerinfo
                tmpSvr.Reserved = frmCS.SvrpList(index).Reserved
                If tmpSvr.Reserved = True Then
                    SaveAlertConfiguration(HealtLimited, HealtLimitedHG, tmpSvr.InstanceID)
                End If
                index += 1
            Next
            MsgBox(p_clsMsgData.fn_GetData("M028"))
        End If

        frmCS.Dispose()
    End Sub

    Private Sub SaveAlertConfiguration(ByRef HealtLimited As AlertConfigurationForm.GetServerAlertConfig, ByRef HealtLimitedHG As AlertConfigurationHAGroupForm.GetServerAlertConfig, _
                                       ByVal InstanceID As Integer)

        Dim COC As New Common.ClsObjectCtl
        Dim LastIp As String = COC.GetLocalIP()
        Try
            'Dim Fixed_NULL As String = "NULL"
            _clsQuery.UpdateHealthLimited(InstanceID, "BUFFERHITRATIO", HealtLimited.BufferRatioWarning, HealtLimited.BufferRatioNormal, _
                                          IIf(HealtLimited.BufferRatioCheck, GetCriticalThreshold_2(HealtLimited.BufferRatioWarning, HealtLimited.BufferRatioNormal), 9), LastIp, HealtLimited.BufferRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "COMMITRATIO", HealtLimited.CommitRatioWarning, HealtLimited.CommitRatioNormal, _
                                          IIf(HealtLimited.CommitRatioCheck, GetCriticalThreshold_2(HealtLimited.CommitRatioWarning, HealtLimited.CommitRatioNormal), 9), LastIp, HealtLimited.CommitRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "ACTIVECONNECTION", HealtLimited.ConnectionsNormal, HealtLimited.ConnectionsWarning, _
                                          IIf(HealtLimited.ConnectionsCheck, GetCriticalThreshold_1(HealtLimited.ConnectionsNormal, HealtLimited.ConnectionsWarning), 9), LastIp, HealtLimited.ConnectionsRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "CPUUTIL", HealtLimited.CPUutilRatioNormal, HealtLimited.CPUutilRatioWarning, _
                                          IIf(HealtLimited.CPUutilRatioCheck, GetCriticalThreshold_1(HealtLimited.CPUutilRatioNormal, HealtLimited.CPUutilRatioWarning), 9), LastIp, HealtLimited.CPUutilRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "CPUWAIT", HealtLimited.CPUwaitRatioNormal, HealtLimited.CPUwaitRatioWarning, _
                                          IIf(HealtLimited.CPUwaitRatioCheck, GetCriticalThreshold_1(HealtLimited.CPUwaitRatioNormal, HealtLimited.CPUwaitRatioWarning), 9), LastIp, HealtLimited.CPUwaitRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "MEMUSAGE", HealtLimited.MEMusedRatioNormal, HealtLimited.MEMusedRatioWarning, _
                                          IIf(HealtLimited.MEMusedRatioCheck, GetCriticalThreshold_1(HealtLimited.MEMusedRatioNormal, HealtLimited.MEMusedRatioWarning), 9), LastIp, HealtLimited.MEMusedRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "SWAPUSAGE", HealtLimited.SWAPusedRatioNormal, HealtLimited.SWAPusedRatioWarning, _
                                          IIf(HealtLimited.SWAPusedRatioCheck, GetCriticalThreshold_1(HealtLimited.SWAPusedRatioNormal, HealtLimited.SWAPusedRatioWarning), 9), LastIp, HealtLimited.SWAPusedRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "DISKUSAGE", HealtLimited.DiskusedRatioNormal, HealtLimited.DiskusedRatioWarning, _
                                          IIf(HealtLimited.DiskusedRatioCheck, GetCriticalThreshold_1(HealtLimited.DiskusedRatioNormal, HealtLimited.DiskusedRatioWarning), 9), LastIp, HealtLimited.DiskusedRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "REPLICATION_DELAY", HealtLimited.ReplicationDelayNormal, HealtLimited.ReplicationDelayWarning, _
                                          IIf(HealtLimited.ReplicationDelayCheck, GetCriticalThreshold_1(HealtLimited.ReplicationDelayNormal, HealtLimited.ReplicationDelayWarning), 9), LastIp, HealtLimited.ReplicationDelayRTime)

            'Dim Fixed As Integer = 1
            _clsQuery.UpdateHealthLimited(InstanceID, "LOCKCNT", HealtLimited.LockedTrancCnt, 0, HealtLimited.LockedtranccntBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "TRAXIDLECNT", HealtLimited.IdleTransCnt, 0, HealtLimited.IdletranscntBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "LONGRUNSQL", HealtLimited.LongRunSqlSec, 0, HealtLimited.LongrunsqlsecBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "UNUSEDINDEX", HealtLimited.UnusedIndexCnt, 0, HealtLimited.UnusedindexcntBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "FROZENMAXAGE", 0, HealtLimited.FrozenMaxAge, HealtLimited.FrozenMaxAgeBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "LASTVACUUM", HealtLimited.LastVacuumDay, 0, HealtLimited.LastvacuumDayBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "LASTANALYZE", HealtLimited.LastAnalyzeDay, 0, HealtLimited.LastAnalyzedayBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "CONNECTIONFAIL", 0, HealtLimited.ConFailedCnt, HealtLimited.ConfailedcntBool, LastIp)
            _clsQuery.UpdateHealthLimited(InstanceID, "REPLICATION_SLOT", 0, 1, HealtLimited.ReplSlotBool, LastIp, HealtLimited.ReplSlotRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "VIRTUAL_IP", 0, 1, HealtLimited.VirtualIPBool, LastIp, HealtLimited.VirtualIPRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "HASTATUS", 1, 2, HealtLimited.HAStatusBool, LastIp, HealtLimited.HAStatusRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "WALCNT", 0, HealtLimited.WALCnt, HealtLimited.WALcntBool, LastIp)
            _clsQuery.UpdateHealthLimitedExt(InstanceID, HealtLimited.NotificationLevel, HealtLimited.NotificationGroup, HealtLimited.NotificationCycle, HealtLimited.BusinessName, LastIp)

            _clsQuery.UpdateHealthLimited(InstanceID, "HGCPUUTIL", HealtLimitedHG.CPUutilRatioNormal, HealtLimitedHG.CPUutilRatioWarning, _
                                          IIf(HealtLimitedHG.CPUutilRatioCheck, GetCriticalThreshold_1(HealtLimitedHG.CPUutilRatioNormal, HealtLimitedHG.CPUutilRatioWarning), 9), LastIp, HealtLimitedHG.CPUutilRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "HGCPUWAIT", HealtLimitedHG.CPUwaitRatioNormal, HealtLimitedHG.CPUwaitRatioWarning, _
                                          IIf(HealtLimitedHG.CPUwaitRatioCheck, GetCriticalThreshold_1(HealtLimitedHG.CPUwaitRatioNormal, HealtLimitedHG.CPUwaitRatioWarning), 9), LastIp, HealtLimitedHG.CPUwaitRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "HGMEMUSAGE", HealtLimitedHG.MEMusedRatioNormal, HealtLimitedHG.MEMusedRatioWarning, _
                                          IIf(HealtLimitedHG.MEMusedRatioCheck, GetCriticalThreshold_1(HealtLimitedHG.MEMusedRatioNormal, HealtLimitedHG.MEMusedRatioWarning), 9), LastIp, HealtLimitedHG.MEMusedRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "HGSWAPUSAGE", HealtLimitedHG.SWAPusedRatioNormal, HealtLimitedHG.SWAPusedRatioWarning, _
                                          IIf(HealtLimitedHG.SWAPusedRatioCheck, GetCriticalThreshold_1(HealtLimitedHG.SWAPusedRatioNormal, HealtLimitedHG.SWAPusedRatioWarning), 9), LastIp, HealtLimitedHG.SWAPusedRatioRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "HGACTIVECONNECTION", HealtLimitedHG.ConnectionsNormal, HealtLimitedHG.ConnectionsWarning, _
                                          IIf(HealtLimitedHG.ConnectionsCheck, GetCriticalThreshold_1(HealtLimitedHG.ConnectionsNormal, HealtLimitedHG.ConnectionsWarning), 9), LastIp, HealtLimitedHG.ConnectionsRTime)
            _clsQuery.UpdateHealthLimited(InstanceID, "HGDISKUSAGE", HealtLimitedHG.DiskusedRatioNormal, HealtLimitedHG.DiskusedRatioWarning, _
                                          IIf(HealtLimitedHG.DiskusedRatioCheck, GetCriticalThreshold_1(HealtLimitedHG.DiskusedRatioNormal, HealtLimitedHG.DiskusedRatioWarning), 9), LastIp, HealtLimitedHG.DiskusedRatioRTime)

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
End Class
