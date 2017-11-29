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

    Public Sub New(ByVal intInstanceID As Integer, ByVal dtTable As DataTable, ByVal FixedThresholdDT As DataTable)

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


        If dtTable IsNot Nothing Then
            Setvalue(dtTable, FixedThresholdDT)
        End If



    End Sub


    Public Sub Setvalue(ByVal DT As DataTable, ByVal FixedThresholdDT As DataTable)

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
                Case "COMMITRATIO"
                    ' Buffer 는 적을 수록 위험 일반적인 것과 반대 
                    dtbCommitratio.BarMinValue = ValueRight
                    dtbCommitratio.BarMaxValue = valueLeft
                Case "ACTIVECONNECTION"
                    dtbConnections.BarMinValue = valueLeft
                    dtbConnections.BarMaxValue = ValueRight

                Case "CPUWAIT"
                    dtbCPUwaitratio.BarMinValue = valueLeft
                    dtbCPUwaitratio.BarMaxValue = ValueRight

                Case "SWAPUSAGE"
                    dtbSWAPusedratio.BarMinValue = valueLeft
                    dtbSWAPusedratio.BarMaxValue = ValueRight

                Case "DISKUSAGE"
                    dtbDiskusedratio.BarMinValue = valueLeft
                    dtbDiskusedratio.BarMaxValue = ValueRight

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


        Return tmpClass
    End Function


    Public Class GetServerAlertConfig
        Public InstanceID As Integer
        Public BufferRatioNormal As Integer
        Public BufferRatioWarning As Integer

        Public CommitRatioNormal As Integer
        Public CommitRatioWarning As Integer

        Public ConnectionsNormal As Integer
        Public ConnectionsWarning As Integer

        Public CPUwaitRatioNormal As Integer
        Public CPUwaitRatioWarning As Integer

        Public SWAPusedRatioNormal As Integer
        Public SWAPusedRatioWarning As Integer

        Public DiskusedRatioNormal As Integer
        Public DiskusedRatioWarning As Integer


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

    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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


End Class
