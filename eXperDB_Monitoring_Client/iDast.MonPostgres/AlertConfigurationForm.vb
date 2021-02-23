Public Class AlertConfigurationForm

    Private _InstanceID As Integer = -1
    Private _dtAC As DataTable
    Private _dtFT As DataTable
    Private _dtUG As DataTable
    Private _hchkPeriod As Integer = 0
    Public Sub New(ByRef clsQuery As clsQuerys, ByVal FixedThresholdDT As DataTable, ByVal dtUserGroup As DataTable)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        
        dtbBufferhitratio.BarMinValue = 0
        dtbBufferhitratio.BarMaxValue = 0
        dtbCommitratio.BarMinValue = 0
        dtbCommitratio.BarMaxValue = 0
        dtbConnections.BarMinValue = 0
        dtbConnections.BarMaxValue = 0
        dtbCPUwaitratio.BarMinValue = 0
        dtbCPUwaitratio.BarMaxValue = 0
        dtbSWAPusedratio.BarMinValue = 0
        dtbSWAPusedratio.BarMaxValue = 0
        dtbDiskusedratio.BarMinValue = 0
        dtbDiskusedratio.BarMaxValue = 0
        dtbReplicationDelay.BarMinValue = 0
        dtbReplicationDelay.BarMaxValue = 0

        _dtFT = FixedThresholdDT
        _dtUG = dtUserGroup
        _hchkPeriod = CInt(_dtFT.Rows(0)("HCHK_PERIOD_SEC"))
        btnUserGroup.Text = p_clsMsgData.fn_GetData("F352")

        lblDelayAlert1.Text = p_clsMsgData.fn_GetData("F954")
        lblDelayAlert2.Text = p_clsMsgData.fn_GetData("F954")
        lblDelayAlert3.Text = p_clsMsgData.fn_GetData("F954")
    End Sub

    Public Sub Setvalue(ByVal DT As DataTable, ByVal intInstanceID As Integer)
        Dim dataTable As DataTable = DT

        If intInstanceID > 0 Then
            _InstanceID = intInstanceID
            _dtAC = dataTable
        End If

        For i As Integer = 0 To cmbNotiUsers.Items.Count - 1
            If CInt(dataTable.Rows(0)("USER_GROUP")) = DirectCast(cmbNotiUsers.Items(i), KeyValuePair(Of String, String)).Key Then
                cmbNotiUsers.SelectedIndex = i
            End If
        Next
        cmbNotiLevel.SelectedIndex = CInt(dataTable.Rows(0)("NOTIFICATION_LEVEL"))
        nudNotiCycle.Value = CInt(dataTable.Rows(0)("NOTIFICATION_CYCLE"))
        txtBusiness.Text = dataTable.Rows(0)("BUSINESS_NAME")

        dtbBufferhitratio.BarMinValue = 0
        dtbBufferhitratio.BarMaxValue = 0
        dtbCommitratio.BarMinValue = 0
        dtbCommitratio.BarMaxValue = 0
        dtbConnections.BarMinValue = 0
        dtbConnections.BarMaxValue = 0
        dtbCPUutilratio.BarMinValue = 0
        dtbCPUutilratio.BarMaxValue = 0
        dtbCPUwaitratio.BarMinValue = 0
        dtbCPUwaitratio.BarMaxValue = 0
        dtbMEMusedratio.BarMinValue = 0
        dtbMEMusedratio.BarMaxValue = 0
        dtbSWAPusedratio.BarMinValue = 0
        dtbSWAPusedratio.BarMaxValue = 0
        dtbDiskusedratio.BarMinValue = 0
        dtbDiskusedratio.BarMaxValue = 0
        dtbReplicationDelay.BarMinValue = 0
        dtbReplicationDelay.BarMaxValue = 0

        For index = 0 To dataTable.Rows.Count - 1
            Dim valueLeft As Integer = 0
            Dim ValueRight As Integer = 0
            Dim nudValue As Integer = 0
            Dim nudValue_ As Integer = 0
            Dim retentionTime As Integer = 0

            Dim Check As Boolean = False

            If Not IsDBNull(dataTable.Rows(index)("WARNING_THRESHOLD")) Then
                valueLeft = Convert.ToInt32(dataTable.Rows(index)("WARNING_THRESHOLD"))
            End If
            If Not IsDBNull(dataTable.Rows(index)("CRITICAL_THRESHOLD")) Then
                ValueRight = Convert.ToInt32(dataTable.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(dataTable.Rows(index)("WARNING_THRESHOLD")) Then
                nudValue = Convert.ToInt32(dataTable.Rows(index)("WARNING_THRESHOLD"))
            End If

            If Not IsDBNull(dataTable.Rows(index)("CRITICAL_THRESHOLD")) Then
                nudValue_ = Convert.ToInt32(dataTable.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("RETENTION_TIME")) Then
                retentionTime = Convert.ToInt32(DT.Rows(index)("RETENTION_TIME"))
            End If

            If Not IsDBNull(dataTable.Rows(index)("FIXED_THRESHOLD")) Then
                If (dataTable.Rows(index)("FIXED_THRESHOLD") = "2") Or _
                   (dataTable.Rows(index)("FIXED_THRESHOLD") = "1") Or _
                   (dataTable.Rows(index)("FIXED_THRESHOLD") = "0") Then
                    Check = True
                Else
                    Check = False
                End If
            End If

            Select Case dataTable.Rows(index)("HCHK_NAME")
                Case "BUFFERHITRATIO"
                    cbxBufferHitRatio.Checked = Check
                    cbxCheckedChanged(cbxBufferHitRatio)
                    ' 적을 수록 위험 일반적인 것과 반대 
                    dtbBufferhitratio.BarMinValue = ValueRight
                    dtbBufferhitratio.BarMaxValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUBufferHitRatio.Checked = True
                        nudBufferHitRatio.Value = retentionTime / 60
                    Else
                        cbxDUBufferHitRatio.Checked = False
                        nudBufferHitRatio.Value = 0
                    End If
                Case "COMMITRATIO"
                    cbxCommitRatio.Checked = Check
                    cbxCheckedChanged(cbxCommitRatio)
                    ' 적을 수록 위험 일반적인 것과 반대 
                    dtbCommitratio.BarMinValue = ValueRight
                    dtbCommitratio.BarMaxValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUCommitRatio.Checked = True
                        nudCommitRatio.Value = retentionTime / 60
                    Else
                        cbxDUCommitRatio.Checked = False
                        nudCommitRatio.Value = 0
                    End If
                Case "ACTIVECONNECTION"
                    cbxConnections.Checked = Check
                    cbxCheckedChanged(cbxConnections)
                    dtbConnections.BarMinValue = valueLeft
                    dtbConnections.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDUConnections.Checked = True
                        nudConnections.Value = retentionTime / 60
                    Else
                        cbxDUConnections.Checked = False
                        nudConnections.Value = 0
                    End If
                Case "CPUWAIT"
                    cbxCPUWaitRatio.Checked = Check
                    cbxCheckedChanged(cbxCPUWaitRatio)
                    dtbCPUwaitratio.BarMaxValue = ValueRight
                    dtbCPUwaitratio.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUCPUWaitRatio.Checked = True
                        nudCPUWaitRatio.Value = retentionTime / 60
                    Else
                        cbxDUCPUWaitRatio.Checked = False
                        nudCPUWaitRatio.Value = 0
                    End If
                Case "SWAPUSAGE"
                    cbxSwapUsedRatio.Checked = Check
                    cbxCheckedChanged(cbxSwapUsedRatio)
                    dtbSWAPusedratio.BarMaxValue = ValueRight
                    dtbSWAPusedratio.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUSwapUsedRatio.Checked = True
                        nudSwapUsedRatio.Value = retentionTime / 60
                    Else
                        cbxDUSwapUsedRatio.Checked = False
                        nudSwapUsedRatio.Value = 0
                    End If
                Case "DISKUSAGE"
                    cbxDiskUsedRatio.Checked = Check
                    cbxCheckedChanged(cbxDiskUsedRatio)
                    dtbDiskusedratio.BarMaxValue = ValueRight
                    dtbDiskusedratio.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUDiskUsedRatio.Checked = True
                        nudDiskUsedRatio.Value = retentionTime / 60
                    Else
                        cbxDUDiskUsedRatio.Checked = False
                        nudDiskUsedRatio.Value = 0
                    End If
                Case "REPLICATION_DELAY"
                    cbxReplicationDelay.Checked = Check
                    cbxCheckedChanged(cbxReplicationDelay)
                    dtbReplicationDelay.BarMaxValue = ValueRight
                    dtbReplicationDelay.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUReplicationDelay.Checked = True
                        nudReplicationDelay.Value = retentionTime / 60
                    Else
                        cbxDUReplicationDelay.Checked = False
                        nudReplicationDelay.Value = 0
                    End If
                Case "LOCKCNT"
                    cbxLockedtranccnt.Checked = Check
                    nudLockedtranccnt.Value = nudValue
                    nudLockedtranccntCritical.Value = nudValue_
                Case "TRAXIDLECNT"
                    cbxIdletranscnt.Checked = Check
                    nudIdletranscnt.Value = nudValue
                    nudIdletranscntCritical.Value = nudValue_
                Case "LONGRUNSQL"
                    cbxLongrunsqlsec.Checked = Check
                    nudLongrunsqlsec.Value = nudValue
                    nudLongrunsqlsecCritical.Value = nudValue_
                Case "UNUSEDINDEX"
                    cbxUnusedindexcnt.Checked = Check
                    nudUnusedindexcnt.Value = nudValue
                Case "FROZENMAXAGE"
                    cbxFrozenAge.Checked = Check
                    nudFrozenMaxAge.Value = nudValue
                    nudFrozenMaxAgeCritical.Value = nudValue_
                Case "LASTVACUUM"
                    cbxLastvacuumDay.Checked = Check
                    nudLastvacuumDay.Value = nudValue
                Case "LASTANALYZE"
                    cbxLastAnalyzeday.Checked = Check
                    nudLastAnalyzeday.Value = nudValue
                Case "CONNECTIONFAIL"
                    cbxConfailedcnt.Checked = Check
                    nudConfailedcnt.Value = nudValue_
                    '''''
                Case "CPUUTIL"
                    cbxCPUUtilRatio.Checked = Check
                    cbxCheckedChanged(cbxCPUUtilRatio)
                    dtbCPUutilratio.BarMaxValue = ValueRight
                    dtbCPUutilratio.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUCPUUtilRatio.Checked = True
                        nudCPUUtilRatio.Value = retentionTime / 60
                    Else
                        cbxDUCPUUtilRatio.Checked = False
                        nudCPUUtilRatio.Value = 0
                    End If
                Case "MEMUSAGE"
                    cbxMemoryUsedRatio.Checked = Check
                    cbxCheckedChanged(cbxMemoryUsedRatio)
                    dtbMEMusedratio.BarMaxValue = ValueRight
                    dtbMEMusedratio.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUMemoryUsedRatio.Checked = True
                        nudMemoryUsedRatio.Value = retentionTime / 60
                    Else
                        cbxDUMemoryUsedRatio.Checked = False
                        nudMemoryUsedRatio.Value = 0
                    End If
                Case "HASTATUS"
                    cbxHAStatus.Checked = Check
                    If retentionTime > 0 Then
                        Dim alertCondition As Integer = retentionTime / _hchkPeriod
                        cmbHAStatus.SelectedIndex = IIf(alertCondition > 0 AndAlso alertCondition < 4, alertCondition, 0)
                    Else
                        cmbHAStatus.SelectedIndex = 0
                    End If
                Case "REPLICATION_SLOT"
                    cbxReplSlot.Checked = Check
                    If retentionTime > 0 Then
                        Dim alertCondition As Integer = retentionTime / _hchkPeriod
                        cmbReplSlot.SelectedIndex = IIf(alertCondition > 0 AndAlso alertCondition < 4, alertCondition, 0)
                    Else
                        cmbReplSlot.SelectedIndex = 0
                    End If
                Case "VIRTUAL_IP"
                    cbxVirtualIP.Checked = Check
                    If retentionTime > 0 Then
                        Dim alertCondition As Integer = retentionTime / _hchkPeriod
                        cmbVIP.SelectedIndex = IIf(alertCondition > 0 AndAlso alertCondition < 4, alertCondition, 0)
                    Else
                        cmbVIP.SelectedIndex = 0
                    End If
                Case "WALCNT"
                    cbxWALcnt.Checked = Check
                    nudWALcnt.Value = nudValue_
            End Select
        Next
    End Sub



    Public Function GetValue() As GetServerAlertConfig
        Dim tmpClass As New GetServerAlertConfig
        tmpClass.InstanceID = _InstanceID
        ' Buffer 는 적을 수록 위험 일반적인 것과 반대 
        tmpClass.BufferRatioNormal = dtbBufferhitratio.BarMinValue
        tmpClass.BufferRatioWarning = dtbBufferhitratio.BarMaxValue
        tmpClass.BufferRatioRTime = nudBufferHitRatio.Value * 60
        tmpClass.BufferRatioCheck = cbxBufferHitRatio.Checked
        '  적을 수록 위험 일반적인 것과 반대 
        tmpClass.CommitRatioNormal = dtbCommitratio.BarMinValue
        tmpClass.CommitRatioWarning = dtbCommitratio.BarMaxValue
        tmpClass.CommitRatioRTime = nudCommitRatio.Value * 60
        tmpClass.CommitRatioCheck = cbxCommitRatio.Checked

        tmpClass.ConnectionsNormal = dtbConnections.BarMinValue
        tmpClass.ConnectionsWarning = dtbConnections.BarMaxValue
        tmpClass.ConnectionsRTime = nudConnections.Value * 60
        tmpClass.ConnectionsCheck = cbxConnections.Checked

        tmpClass.CPUutilRatioNormal = dtbCPUutilratio.BarMinValue
        tmpClass.CPUutilRatioWarning = dtbCPUutilratio.BarMaxValue
        tmpClass.CPUutilRatioRTime = nudCPUUtilRatio.Value * 60
        tmpClass.CPUutilRatioCheck = cbxCPUUtilRatio.Checked

        tmpClass.CPUwaitRatioNormal = dtbCPUwaitratio.BarMinValue
        tmpClass.CPUwaitRatioWarning = dtbCPUwaitratio.BarMaxValue
        tmpClass.CPUwaitRatioRTime = nudCPUWaitRatio.Value * 60
        tmpClass.CPUwaitRatioCheck = cbxCPUWaitRatio.Checked

        tmpClass.MEMusedRatioNormal = dtbMEMusedratio.BarMinValue
        tmpClass.MEMusedRatioWarning = dtbMEMusedratio.BarMaxValue
        tmpClass.MEMusedRatioRTime = nudMemoryUsedRatio.Value * 60
        tmpClass.MEMusedRatioCheck = cbxMemoryUsedRatio.Checked

        tmpClass.SWAPusedRatioNormal = dtbSWAPusedratio.BarMinValue
        tmpClass.SWAPusedRatioWarning = dtbSWAPusedratio.BarMaxValue
        tmpClass.SWAPusedRatioRTime = nudSwapUsedRatio.Value * 60
        tmpClass.SWAPusedRatioCheck = cbxSwapUsedRatio.Checked

        tmpClass.DiskusedRatioNormal = dtbDiskusedratio.BarMinValue
        tmpClass.DiskusedRatioWarning = dtbDiskusedratio.BarMaxValue
        tmpClass.DiskusedRatioRTime = nudDiskUsedRatio.Value * 60
        tmpClass.DiskusedRatioCheck = cbxDiskUsedRatio.Checked

        tmpClass.ReplicationDelayNormal = dtbReplicationDelay.BarMinValue
        tmpClass.ReplicationDelayWarning = dtbReplicationDelay.BarMaxValue
        tmpClass.ReplicationDelayRTime = nudReplicationDelay.Value * 60
        tmpClass.ReplicationDelayCheck = cbxReplicationDelay.Checked

        tmpClass.LockedTrancCnt = nudLockedtranccnt.Value
        tmpClass.IdleTransCnt = nudIdletranscnt.Value
        tmpClass.LongRunSqlSec = nudLongrunsqlsec.Value
        tmpClass.UnusedIndexCnt = nudUnusedindexcnt.Value
        tmpClass.FrozenMaxAge = nudFrozenMaxAge.Value
        tmpClass.LastVacuumDay = nudLastvacuumDay.Value
        tmpClass.LastAnalyzeDay = nudLastAnalyzeday.Value
        tmpClass.ConFailedCnt = nudConfailedcnt.Value
        tmpClass.WALCnt = nudWALcnt.Value

        tmpClass.LockedTrancCntCritical = nudLockedtranccntCritical.Value
        tmpClass.IdleTransCntCritical = nudIdletranscntCritical.Value
        tmpClass.LongRunSqlSecCritical = nudLongrunsqlsecCritical.Value
        tmpClass.FrozenMaxAgeCritical = nudFrozenMaxAgeCritical.Value

        For index = 0 To _dtFT.Rows.Count - 1

            Select Case _dtFT.Rows(index)("HCHK_NAME")
                Case "LOCKCNT"
                    tmpClass.LockedtranccntBool = IIf(cbxLockedtranccnt.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "TRAXIDLECNT"
                    tmpClass.IdletranscntBool = IIf(cbxIdletranscnt.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "LONGRUNSQL"
                    tmpClass.LongrunsqlsecBool = IIf(cbxLongrunsqlsec.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "UNUSEDINDEX"
                    tmpClass.UnusedindexcntBool = IIf(cbxUnusedindexcnt.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "FROZENMAXAGE"
                    tmpClass.FrozenMaxAgeBool = IIf(cbxFrozenAge.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "2")
                Case "LASTVACUUM"
                    tmpClass.LastvacuumDayBool = IIf(cbxLastvacuumDay.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "LASTANALYZE"
                    tmpClass.LastAnalyzedayBool = IIf(cbxLastAnalyzeday.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "CONNECTIONFAIL"
                    tmpClass.ConfailedcntBool = IIf(cbxConfailedcnt.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                    ''''''
                Case "REPLICATION_SLOT"
                    tmpClass.ReplSlotBool = IIf(cbxReplSlot.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                    tmpClass.ReplSlotRTime = cmbReplSlot.SelectedIndex * _hchkPeriod + 1
                Case "VIRTUAL_IP"
                    tmpClass.VirtualIPBool = IIf(cbxVirtualIP.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                    tmpClass.VirtualIPRTime = cmbVIP.SelectedIndex * _hchkPeriod + 1
                Case "HASTATUS"
                    tmpClass.HAStatusBool = IIf(cbxHAStatus.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                    tmpClass.HAStatusRTime = cmbHAStatus.SelectedIndex * _hchkPeriod + 1
                Case "WALCNT"
                    tmpClass.WALcntBool = IIf(cbxWALcnt.Checked = True, _dtFT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                    'tmpClass.WALCountRTime = cmbVIP.SelectedIndex * _hchkPeriod + 1
            End Select
        Next

        tmpClass.NotificationLevel = cmbNotiLevel.SelectedIndex
        tmpClass.NotificationGroup = cmbNotiUsers.SelectedValue
        tmpClass.NotificationCycle = nudNotiCycle.Value
        tmpClass.BusinessName = txtBusiness.Text

        Return tmpClass
    End Function


    Public Class GetServerAlertConfig
        Public InstanceID As Integer

        Public BufferRatioNormal As Integer
        Public BufferRatioWarning As Integer
        Public BufferRatioRTime As Integer
        Public BufferRatioCheck As Boolean

        Public CommitRatioNormal As Integer
        Public CommitRatioWarning As Integer
        Public CommitRatioRTime As Integer
        Public CommitRatioCheck As Boolean

        Public ConnectionsNormal As Integer
        Public ConnectionsWarning As Integer
        Public ConnectionsRTime As Integer
        Public ConnectionsCheck As Boolean

        Public CPUutilRatioNormal As Integer
        Public CPUutilRatioWarning As Integer
        Public CPUutilRatioRTime As Integer
        Public CPUutilRatioCheck As Boolean

        Public CPUwaitRatioNormal As Integer
        Public CPUwaitRatioWarning As Integer
        Public CPUwaitRatioRTime As Integer
        Public CPUwaitRatioCheck As Boolean

        Public SWAPusedRatioNormal As Integer
        Public SWAPusedRatioWarning As Integer
        Public SWAPusedRatioRTime As Integer
        Public SWAPusedRatioCheck As Boolean

        Public MEMusedRatioNormal As Integer
        Public MEMusedRatioWarning As Integer
        Public MEMusedRatioRTime As Integer
        Public MEMusedRatioCheck As Boolean

        Public DiskusedRatioNormal As Integer
        Public DiskusedRatioWarning As Integer
        Public DiskusedRatioRTime As Integer
        Public DiskusedRatioCheck As Boolean

        Public ReplicationDelayNormal As Integer
        Public ReplicationDelayWarning As Integer
        Public ReplicationDelayRTime As Integer
        Public ReplicationDelayCheck As Boolean

        Public LockedTrancCnt As Integer
        Public IdleTransCnt As Integer
        Public LongRunSqlSec As Integer
        Public UnusedIndexCnt As Integer
        Public FrozenMaxAge As Integer
        Public LastVacuumDay As Integer
        Public LastAnalyzeDay As Integer
        Public ConFailedCnt As Integer
        Public ReplSlotLevel As Integer
        Public VirtualIPLevel As Integer
        Public WALCnt As Integer

        Public LockedtranccntBool As String
        Public IdletranscntBool As String
        Public LongrunsqlsecBool As String
        Public UnusedindexcntBool As String
        Public FrozenMaxAgeBool As String
        Public LastvacuumDayBool As String
        Public LastAnalyzedayBool As String
        Public ConfailedcntBool As String
        Public WALcntBool As String

        Public ReplSlotBool As String
        Public ReplSlotRTime As Integer
        Public VirtualIPBool As String
        Public VirtualIPRTime As Integer
        Public HAStatusBool As String
        Public HAStatusRTime As Integer

        Public NotificationLevel As Integer
        Public NotificationGroup As Integer
        Public NotificationCycle As Integer
        Public BusinessName As String

        Public LockedTrancCntCritical As Integer
        Public IdleTransCntCritical As Integer
        Public LongRunSqlSecCritical As Integer
        Public FrozenMaxAgeCritical As Integer

    End Class

    Private Sub cbxLockedtranccnt_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLockedtranccnt.CheckedChanged
        nudLockedtranccnt.Enabled = cbxLockedtranccnt.Checked
    End Sub

    Private Sub cbxLongrunsqlsec_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLongrunsqlsec.CheckedChanged
        nudLongrunsqlsec.Enabled = cbxLongrunsqlsec.Checked
    End Sub

    Private Sub cbxLastvacuumDay_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLastvacuumDay.CheckedChanged
        nudLastvacuumDay.Enabled = cbxLastvacuumDay.Checked
    End Sub

    Private Sub cbxConfailedcnt_CheckedChanged(sender As Object, e As EventArgs) Handles cbxConfailedcnt.CheckedChanged
        nudConfailedcnt.Enabled = cbxConfailedcnt.Checked
    End Sub

    Private Sub cbxIdletranscnt_CheckedChanged(sender As Object, e As EventArgs) Handles cbxIdletranscnt.CheckedChanged
        nudIdletranscnt.Enabled = cbxIdletranscnt.Checked
    End Sub

    Private Sub cbxUnusedindexcnt_CheckedChanged(sender As Object, e As EventArgs) Handles cbxUnusedindexcnt.CheckedChanged
        nudUnusedindexcnt.Enabled = cbxUnusedindexcnt.Checked
    End Sub

    Private Sub cbxFrozenAge_CheckedChanged(sender As Object, e As EventArgs) Handles cbxFrozenAge.CheckedChanged
        nudFrozenMaxAge.Enabled = cbxFrozenAge.Checked
    End Sub

    Private Sub cbxLastAnalyzeday_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLastAnalyzeday.CheckedChanged
        nudLastAnalyzeday.Enabled = cbxLastAnalyzeday.Checked
    End Sub

    Private Sub cbxWALcnt_CheckedChanged(sender As Object, e As EventArgs) Handles cbxWALcnt.CheckedChanged
        nudWALcnt.Enabled = cbxWALcnt.Checked
    End Sub


    Private Sub cbxBufferHitRatio_CheckedChanged(sender As Object, e As EventArgs) Handles cbxBufferHitRatio.CheckedChanged, _
                                                                                        cbxCommitRatio.CheckedChanged, _
                                                                                        cbxDiskUsedRatio.CheckedChanged, _
                                                                                        cbxConnections.CheckedChanged, _
                                                                                        cbxCPUUtilRatio.CheckedChanged, _
                                                                                        cbxCPUWaitRatio.CheckedChanged, _
                                                                                        cbxMemoryUsedRatio.CheckedChanged, _
                                                                                        cbxSwapUsedRatio.CheckedChanged, _
                                                                                        cbxReplicationDelay.CheckedChanged
        Dim checkBox As eXperDB.BaseControls.CheckBox = DirectCast(sender, eXperDB.BaseControls.CheckBox)
        cbxCheckedChanged(checkBox)
    End Sub


    Private Sub cbxDuration1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDUBufferHitRatio.CheckedChanged, _
                                                                                    cbxDUCommitRatio.CheckedChanged, _
                                                                                    cbxDUMemoryUsedRatio.CheckedChanged, _
                                                                                    cbxDUSwapUsedRatio.CheckedChanged, _
                                                                                    cbxDUDiskUsedRatio.CheckedChanged, _
                                                                                    cbxDUConnections.CheckedChanged, _
                                                                                    cbxDUCPUUtilRatio.CheckedChanged, _
                                                                                    cbxDUCPUWaitRatio.CheckedChanged, _
                                                                                    cbxDUReplicationDelay.CheckedChanged
        Dim chkTemp As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)
        Select Case chkTemp.Name
            Case "cbxDUBufferHitRatio"
                nudBufferHitRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudBufferHitRatio.Value = 0
            Case "cbxDUCommitRatio"
                nudCommitRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudCommitRatio.Value = 0
            Case "cbxDUSwapUsedRatio"
                nudSwapUsedRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudSwapUsedRatio.Value = 0
            Case "cbxDUDiskUsedRatio"
                nudDiskUsedRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDiskUsedRatio.Value = 0
            Case "cbxDUConnections"
                nudConnections.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudConnections.Value = 0
            Case "cbxDUCPUWaitRatio"
                nudCPUWaitRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudCPUWaitRatio.Value = 0
            Case "cbxDUReplicationDelay"
                nudReplicationDelay.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudReplicationDelay.Value = 0
            Case "cbxDUCPUUtilRatio"
                nudCPUUtilRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudCPUUtilRatio.Value = 0
            Case "cbxDUMemoryUsedRatio"
                nudMemoryUsedRatio.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudMemoryUsedRatio.Value = 0
        End Select
    End Sub

    Private Sub btnUserGroup_Click(sender As Object, e As EventArgs) Handles btnUserGroup.Click
        Dim UserGroupForm As New frmUserGroup()
        If UserGroupForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim intUserGroup As Integer = 0
            UserGroupForm.rtnValue(intUserGroup)
            For i As Integer = 0 To cmbNotiUsers.Items.Count - 1
                If CInt(cmbNotiUsers.Items(i).key) = intUserGroup Then
                    cmbNotiUsers.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub nudLockedtranccntCritical_ValueChanged(sender As Object, e As EventArgs) Handles nudLockedtranccntCritical.ValueChanged, _
                                                                                                 nudLongrunsqlsecCritical.ValueChanged, _
                                                                                                 nudIdletranscntCritical.ValueChanged, _
                                                                                                 nudFrozenMaxAgeCritical.ValueChanged
        Dim nudTemp As System.Windows.Forms.NumericUpDown = DirectCast(sender, System.Windows.Forms.NumericUpDown)
        Select Case nudTemp.Name
            Case "nudLockedtranccntCritical"
                If nudTemp.Value < nudLockedtranccnt.Value Then nudTemp.Value = nudLockedtranccnt.Value
            Case "nudLongrunsqlsecCritical"
                If nudTemp.Value < nudLongrunsqlsec.Value Then nudTemp.Value = nudLongrunsqlsec.Value
            Case "nudIdletranscntCritical"
                If nudTemp.Value < nudIdletranscnt.Value Then nudTemp.Value = nudIdletranscnt.Value
            Case "nudFrozenMaxAgeCritical"
                If nudTemp.Value < nudFrozenMaxAge.Value Then nudTemp.Value = nudFrozenMaxAge.Value
        End Select

    End Sub

    Private Sub AlertConfigurationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadComboItems()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub LoadComboItems()
        cmbNotiUsers.Items.Clear()
        If _dtUG IsNot Nothing AndAlso _dtUG.Rows.Count > 0 Then
            Dim comboSource As New Dictionary(Of String, String)()
            Dim i As Integer = 0
            Dim selectedIndex As Integer = 0
            For Each tmpRow As DataRow In _dtUG.Rows
                comboSource.Add(tmpRow.Item("GROUP_ID"), tmpRow.Item("GROUP_NAME"))
            Next
            cmbNotiUsers.DataSource = New BindingSource(comboSource, Nothing)
            cmbNotiUsers.DisplayMember = "Value"
            cmbNotiUsers.SelectedIndex = selectedIndex
            cmbNotiUsers.ValueMember = "Key"
        End If
    End Sub


    Private Sub cbxCheckedChanged(ByRef checkBox As BaseControls.CheckBox)
        Select Case checkBox.Name
            Case "cbxBufferHitRatio"
                dtbBufferhitratio.Enabled = checkBox.Checked
                cbxDUBufferHitRatio.Enabled = checkBox.Checked
                'nudBufferHitRatio.Enabled = checkBox.Checked
            Case "cbxCommitRatio"
                dtbCommitratio.Enabled = checkBox.Checked
                cbxDUBufferHitRatio.Enabled = checkBox.Checked
                'nudBufferHitRatio.Enabled = checkBox.Checked
            Case "cbxDiskUsedRatio"
                dtbDiskusedratio.Enabled = checkBox.Checked
                cbxDUDiskUsedRatio.Enabled = checkBox.Checked
                'nudDiskUsedRatio.Enabled = checkBox.Checked
            Case "cbxConnections"
                dtbConnections.Enabled = checkBox.Checked
                cbxDUConnections.Enabled = checkBox.Checked
                'nudConnections.Enabled = checkBox.Checked
            Case "cbxCPUUtilRatio"
                dtbCPUutilratio.Enabled = checkBox.Checked
                cbxDUCPUUtilRatio.Enabled = checkBox.Checked
                'nudCPUUtilRatio.Enabled = checkBox.Checked
            Case "cbxCPUWaitRatio"
                dtbCPUwaitratio.Enabled = checkBox.Checked
                cbxDUCPUWaitRatio.Enabled = checkBox.Checked
                'nudCPUWaitRatio.Enabled = checkBox.Checked
            Case "cbxMemoryUsedRatio"
                dtbMEMusedratio.Enabled = checkBox.Checked
                cbxDUMemoryUsedRatio.Enabled = checkBox.Checked
                'nudMemoryUsedRatio.Enabled = checkBox.Checked
            Case "cbxSwapUsedRatio"
                dtbSWAPusedratio.Enabled = checkBox.Checked
                cbxDUSwapUsedRatio.Enabled = checkBox.Checked
                'nudSwapUsedRatio.Enabled = checkBox.Checked
            Case "cbxReplicationDelay"
                dtbReplicationDelay.Enabled = checkBox.Checked
                cbxDUReplicationDelay.Enabled = checkBox.Checked
                'nudReplicationDelay.Enabled = checkBox.Checked
        End Select
    End Sub


End Class
