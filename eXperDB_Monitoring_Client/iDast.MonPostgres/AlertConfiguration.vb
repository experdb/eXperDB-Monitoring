Public Class AlertConfiguration

    Private _InstanceID As Integer = -1
    Property InstanceID As Integer
        Get
            Return _InstanceID
        End Get
        Set(value As Integer)
            _InstanceID = value
        End Set
    End Property



    Public Sub New()
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
    End Sub

    Public Sub New(ByVal intInstanceID As Integer, ByVal dtTable As DataTable, ByVal FixedThresholdDT As DataTable, ByVal dtUserGroup As DataTable)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = intInstanceID

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

        btnUserGroup.Text = p_clsMsgData.fn_GetData("F025")

        If dtTable IsNot Nothing Then
            Setvalue(dtTable, FixedThresholdDT, dtUserGroup)
        End If



    End Sub


    Public Sub Setvalue(ByVal DT As DataTable, ByVal FixedThresholdDT As DataTable, ByVal dtUserGroup As DataTable)

        cmbNotiUsers.Items.Clear()
        If dtUserGroup IsNot Nothing Then
            Dim comboSource As New Dictionary(Of String, String)()
            For Each tmpRow As DataRow In dtUserGroup.Rows
                comboSource.Add(tmpRow.Item("GROUP_ID"), tmpRow.Item("GROUP_NAME"))
            Next
            cmbNotiUsers.DataSource = New BindingSource(comboSource, Nothing)
            cmbNotiUsers.DisplayMember = "Value"
            cmbNotiUsers.ValueMember = "Key"
        End If

        cmbNotiUsers.SelectedIndex = CInt(DT.Rows(0)("USER_GROUP"))
        cmbNotiLevel.SelectedIndex = CInt(DT.Rows(0)("NOTIFICATION_LEVEL"))
        nudNotiCycle.Value = CInt(DT.Rows(0)("NOTIFICATION_CYCLE"))
        txtSender.Text = DT.Rows(0)("NOTIFICATION_SENDER")

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

        For index = 0 To DT.Rows.Count - 1
            Dim valueLeft As Integer = 0
            Dim ValueRight As Integer = 0
            Dim nudValue As Integer = 0
            Dim nudValue_ As Integer = 0
            Dim retentionTime As Integer = 0

            Dim Check As Boolean = False


            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                valueLeft = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If
            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                ValueRight = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                nudValue = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                nudValue_ = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("RETENTION_TIME")) Then
                retentionTime = Convert.ToInt32(DT.Rows(index)("RETENTION_TIME"))
            End If

            If Not IsDBNull(DT.Rows(index)("FIXED_THRESHOLD")) Then
                For index1 = 0 To FixedThresholdDT.Rows.Count - 1
                    If (FixedThresholdDT.Rows(index1)("HCHK_NAME").ToString = DT.Rows(index)("HCHK_NAME").ToString) Then
                        If (DT.Rows(index)("FIXED_THRESHOLD") = FixedThresholdDT.Rows(index1)("FIXED_THRESHOLD").ToString) Then
                            Check = True
                            Exit For
                        Else
                            Check = False
                            Exit For
                        End If
                    End If
                Next
            End If

            Select Case DT.Rows(index)("HCHK_NAME")
                Case "BUFFERHITRATIO"
                    ' Buffer 는 적을 수록 위험 일반적인 것과 반대 
                    dtbBufferhitratio.BarMinValue = ValueRight
                    dtbBufferhitratio.BarMaxValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDuration1.Checked = True
                        nudDuration1.Value = retentionTime
                    End If
                Case "COMMITRATIO"
                    ' Buffer 는 적을 수록 위험 일반적인 것과 반대 
                    dtbCommitratio.BarMinValue = ValueRight
                    dtbCommitratio.BarMaxValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDuration2.Checked = True
                        nudDuration2.Value = retentionTime
                    End If
                Case "SWAPUSAGE"
                    dtbSWAPusedratio.BarMinValue = valueLeft
                    dtbSWAPusedratio.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDuration3.Checked = True
                        nudDuration3.Value = retentionTime
                    End If
                Case "DISKUSAGE"
                    dtbDiskusedratio.BarMinValue = valueLeft
                    dtbDiskusedratio.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDuration4.Checked = True
                        nudDuration4.Value = retentionTime
                    End If
                Case "ACTIVECONNECTION"
                    dtbConnections.BarMinValue = valueLeft
                    dtbConnections.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDuration5.Checked = True
                        nudDuration5.Value = retentionTime
                    End If
                Case "CPUWAIT"
                    dtbCPUwaitratio.BarMinValue = valueLeft
                    dtbCPUwaitratio.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDuration6.Checked = True
                        nudDuration6.Value = retentionTime
                    End If
                Case "REPLICATION_DELAY"
                    dtbReplicationDelay.BarMinValue = valueLeft
                    dtbReplicationDelay.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDuration7.Checked = True
                        nudDuration7.Value = retentionTime
                    End If



                Case "LOCKCNT"
                    cbxLockedtranccnt.Checked = Check
                    nudLockedtranccnt.Value = nudValue
                Case "TRAXIDLECNT"
                    cbxIdletranscnt.Checked = Check
                    nudIdletranscnt.Value = nudValue
                Case "LONGRUNSQL"
                    cbxLongrunsqlsec.Checked = Check
                    nudLongrunsqlsec.Value = nudValue
                Case "UNUSEDINDEX"
                    cbxUnusedindexcnt.Checked = Check
                    nudUnusedindexcnt.Value = nudValue
                Case "LASTVACUUM"
                    cbxLastvacuumDay.Checked = Check
                    nudLastvacuumDay.Value = nudValue
                Case "LASTANALYZE"
                    cbxLastAnalyzeday.Checked = Check
                    nudLastAnalyzeday.Value = nudValue
                Case "CONNECTIONFAIL"
                    cbxConfailedcnt.Checked = Check
                    nudConfailedcnt.Value = nudValue_
            End Select
        Next
    End Sub


    Public Sub Setvalue(ByVal DT As DataTable)

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

        For index = 0 To DT.Rows.Count - 1
            Dim valueLeft As Integer = 0
            Dim ValueRight As Integer = 0
            Dim nudValue As Integer = 0
            Dim nudValue_ As Integer = 0

            Dim Check As Boolean = False

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                valueLeft = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If
            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                ValueRight = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                nudValue = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                nudValue_ = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("FIXED_THRESHOLD")) Then
                If (DT.Rows(index)("FIXED_THRESHOLD") = "1") Then
                    Check = True
                Else
                    Check = False
                End If
            End If

            Select Case DT.Rows(index)("HCHK_NAME")
                Case "BUFFERHITRATIO"
                    ' 적을 수록 위험 일반적인 것과 반대 
                    dtbBufferhitratio.BarMinValue = ValueRight
                    dtbBufferhitratio.BarMaxValue = valueLeft
                Case "COMMITRATIO"
                    ' 적을 수록 위험 일반적인 것과 반대 
                    dtbCommitratio.BarMinValue = ValueRight
                    dtbCommitratio.BarMaxValue = valueLeft
                Case "ACTIVECONNECTION"
                    dtbConnections.BarMinValue = valueLeft
                    dtbConnections.BarMaxValue = ValueRight
                Case "CPUWAIT"
                    dtbCPUwaitratio.BarMaxValue = ValueRight
                    dtbCPUwaitratio.BarMinValue = valueLeft
                Case "SWAPUSAGE"
                    dtbSWAPusedratio.BarMaxValue = ValueRight
                    dtbSWAPusedratio.BarMinValue = valueLeft
                Case "DISKUSAGE"
                    dtbDiskusedratio.BarMaxValue = ValueRight
                    dtbDiskusedratio.BarMinValue = valueLeft
                Case "REPLICATION_DELAY"
                    dtbReplicationDelay.BarMaxValue = ValueRight
                    dtbReplicationDelay.BarMinValue = valueLeft
                Case "LOCKCNT"
                    cbxLockedtranccnt.Checked = Check
                    nudLockedtranccnt.Value = nudValue
                Case "TRAXIDLECNT"
                    cbxIdletranscnt.Checked = Check
                    nudIdletranscnt.Value = nudValue
                Case "LONGRUNSQL"
                    cbxLongrunsqlsec.Checked = Check
                    nudLongrunsqlsec.Value = nudValue
                Case "UNUSEDINDEX"
                    cbxUnusedindexcnt.Checked = Check
                    nudUnusedindexcnt.Value = nudValue
                Case "LASTVACUUM"
                    cbxLastvacuumDay.Checked = Check
                    nudLastvacuumDay.Value = nudValue
                Case "LASTANALYZE"
                    cbxLastAnalyzeday.Checked = Check
                    nudLastAnalyzeday.Value = nudValue
                Case "CONNECTIONFAIL"
                    cbxConfailedcnt.Checked = Check
                    nudConfailedcnt.Value = nudValue_
            End Select
        Next
    End Sub



    Public Function GetValue(ByVal FixedThresholdDT As DataTable) As GetServerAlertConfig
        Dim tmpClass As New GetServerAlertConfig
        tmpClass.InstanceID = _InstanceID
        ' Buffer 는 적을 수록 위험 일반적인 것과 반대 
        tmpClass.BufferRatioNormal = dtbBufferhitratio.BarMinValue
        tmpClass.BufferRatioWarning = dtbBufferhitratio.BarMaxValue
        '  적을 수록 위험 일반적인 것과 반대 
        tmpClass.CommitRatioNormal = dtbCommitratio.BarMinValue
        tmpClass.CommitRatioWarning = dtbCommitratio.BarMaxValue

        tmpClass.ConnectionsNormal = dtbConnections.BarMinValue
        tmpClass.ConnectionsWarning = dtbConnections.BarMaxValue

        tmpClass.CPUwaitRatioNormal = dtbCPUwaitratio.BarMinValue
        tmpClass.CPUwaitRatioWarning = dtbCPUwaitratio.BarMaxValue

        tmpClass.SWAPusedRatioNormal = dtbSWAPusedratio.BarMinValue
        tmpClass.SWAPusedRatioWarning = dtbSWAPusedratio.BarMaxValue

        tmpClass.DiskusedRatioNormal = dtbDiskusedratio.BarMinValue
        tmpClass.DiskusedRatioWarning = dtbDiskusedratio.BarMaxValue

        tmpClass.ReplicationDelayNormal = dtbReplicationDelay.BarMinValue
        tmpClass.ReplicationDelayWarning = dtbReplicationDelay.BarMaxValue

        tmpClass.BufferRatioRTime = nudDuration1.Value
        tmpClass.CommitRatioRTime = nudDuration2.Value
        tmpClass.SWAPusedRatioRTime = nudDuration3.Value
        tmpClass.DiskusedRatioRTime = nudDuration4.Value
        tmpClass.ConnectionsRTime = nudDuration5.Value
        tmpClass.CPUwaitRatioRTime = nudDuration6.Value
        tmpClass.ReplicationDelayRTime = nudDuration7.Value


        tmpClass.LockedTrancCnt = nudLockedtranccnt.Value
        tmpClass.IdleTransCnt = nudIdletranscnt.Value
        tmpClass.LongRunSqlSec = nudLongrunsqlsec.Value
        tmpClass.UnusedIndexCnt = nudUnusedindexcnt.Value
        tmpClass.LastVacuumDay = nudLastvacuumDay.Value
        tmpClass.LastAnalyzeDay = nudLastAnalyzeday.Value
        tmpClass.ConFailedCnt = nudConfailedcnt.Value


        For index = 0 To FixedThresholdDT.Rows.Count - 1

            Select Case FixedThresholdDT.Rows(index)("HCHK_NAME")
                Case "LOCKCNT"
                    tmpClass.LockedtranccntBool = IIf(cbxLockedtranccnt.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "TRAXIDLECNT"
                    tmpClass.IdletranscntBool = IIf(cbxIdletranscnt.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "LONGRUNSQL"
                    tmpClass.LongrunsqlsecBool = IIf(cbxLongrunsqlsec.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "UNUSEDINDEX"
                    tmpClass.UnusedindexcntBool = IIf(cbxUnusedindexcnt.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "LASTVACUUM"
                    tmpClass.LastvacuumDayBool = IIf(cbxLastvacuumDay.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "LASTANALYZE"
                    tmpClass.LastAnalyzedayBool = IIf(cbxLastAnalyzeday.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
                Case "CONNECTIONFAIL"
                    tmpClass.ConfailedcntBool = IIf(cbxConfailedcnt.Checked = True, FixedThresholdDT.Rows(index)("FIXED_THRESHOLD").ToString, "9")
            End Select
        Next

        tmpClass.NotificationLevel = cmbNotiLevel.SelectedIndex
        tmpClass.NotificationGroup = cmbNotiUsers.SelectedIndex
        tmpClass.NotificationCycle = nudNotiCycle.Value
        tmpClass.NotificationSender = txtSender.Text

        Return tmpClass
    End Function


    Public Class GetServerAlertConfig
        Public InstanceID As Integer
        Public BufferRatioNormal As Integer
        Public BufferRatioWarning As Integer
        Public BufferRatioRTime As Integer

        Public CommitRatioNormal As Integer
        Public CommitRatioWarning As Integer
        Public CommitRatioRTime As Integer

        Public ConnectionsNormal As Integer
        Public ConnectionsWarning As Integer
        Public ConnectionsRTime As Integer

        Public CPUwaitRatioNormal As Integer
        Public CPUwaitRatioWarning As Integer
        Public CPUwaitRatioRTime As Integer

        Public SWAPusedRatioNormal As Integer
        Public SWAPusedRatioWarning As Integer
        Public SWAPusedRatioRTime As Integer

        Public DiskusedRatioNormal As Integer
        Public DiskusedRatioWarning As Integer
        Public DiskusedRatioRTime As Integer

        Public ReplicationDelayNormal As Integer
        Public ReplicationDelayWarning As Integer
        Public ReplicationDelayRTime As Integer


        Public LockedTrancCnt As Integer
        Public IdleTransCnt As Integer
        Public LongRunSqlSec As Integer
        Public UnusedIndexCnt As Integer
        Public LastVacuumDay As Integer
        Public LastAnalyzeDay As Integer
        Public ConFailedCnt As Integer

        Public LockedtranccntBool As String
        Public IdletranscntBool As String
        Public LongrunsqlsecBool As String
        Public UnusedindexcntBool As String
        Public LastvacuumDayBool As String
        Public LastAnalyzedayBool As String
        Public ConfailedcntBool As String

        Public NotificationLevel As Integer
        Public NotificationGroup As Integer
        Public NotificationCycle As Integer
        Public NotificationSender As String

    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Dim tmpCls As GetServerAlertConfig = Me.GetValue()

        '  RaiseEvent ABCD(Me, tmpCls)

    End Sub


    Public Event ABCD(ByVal sender As Object, ByVal UsrEvent As GetServerAlertConfig)


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

    Private Sub cbxLastAnalyzeday_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLastAnalyzeday.CheckedChanged
        nudLastAnalyzeday.Enabled = cbxLastAnalyzeday.Checked
    End Sub


    Private Sub cbxDuration1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDuration1.CheckedChanged, cbxDuration2.CheckedChanged, cbxDuration3.CheckedChanged, cbxDuration4.CheckedChanged, cbxDuration5.CheckedChanged, cbxDuration6.CheckedChanged, cbxDuration7.CheckedChanged
        Dim chkTemp As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)
        Select Case chkTemp.Name
            Case "cbxDuration1"
                nudDuration1.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration1.Value = 0
            Case "cbxDuration2"
                nudDuration2.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration2.Value = 0
            Case "cbxDuration3"
                nudDuration3.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration3.Value = 0
            Case "cbxDuration4"
                nudDuration4.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration4.Value = 0
            Case "cbxDuration5"
                nudDuration5.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration5.Value = 0
            Case "cbxDuration6"
                nudDuration6.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration6.Value = 0
            Case "cbxDuration7"
                nudDuration7.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDuration7.Value = 0
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
End Class
