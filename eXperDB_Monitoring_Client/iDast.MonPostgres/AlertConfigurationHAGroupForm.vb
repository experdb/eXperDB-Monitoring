Public Class AlertConfigurationHAGroupForm

    Private _InstanceID As Integer = -1
    Private _dtAC As DataTable
    Private _dtFT As DataTable
    Private _hchkPeriod As Integer = 0
    Public Sub New(ByRef clsQuery As clsQuerys, ByVal FixedThresholdDT As DataTable)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        dtbConnectionsHA.BarMinValue = 0
        dtbConnectionsHA.BarMaxValue = 0
        dtbCPUwaitratioHA.BarMinValue = 0
        dtbCPUwaitratioHA.BarMaxValue = 0
        dtbSWAPusedratioHA.BarMinValue = 0
        dtbSWAPusedratioHA.BarMaxValue = 0
        dtbDiskusedratioHA.BarMinValue = 0
        dtbDiskusedratioHA.BarMaxValue = 0

        _dtFT = FixedThresholdDT
        _hchkPeriod = CInt(_dtFT.Rows(0)("HCHK_PERIOD_SEC"))
    End Sub

    Public Sub Setvalue(ByVal DT As DataTable, ByVal intInstanceID As Integer)
        Dim dataTable As DataTable = DT

        If intInstanceID > 0 Then
            _InstanceID = intInstanceID
            _dtAC = dataTable
        End If

        dtbConnectionsHA.BarMinValue = 0
        dtbConnectionsHA.BarMaxValue = 0
        dtbCPUutilratioHA.BarMinValue = 0
        dtbCPUutilratioHA.BarMaxValue = 0
        dtbCPUwaitratioHA.BarMinValue = 0
        dtbCPUwaitratioHA.BarMaxValue = 0
        dtbMEMusedratioHA.BarMinValue = 0
        dtbMEMusedratioHA.BarMaxValue = 0
        dtbSWAPusedratioHA.BarMinValue = 0
        dtbSWAPusedratioHA.BarMaxValue = 0
        dtbDiskusedratioHA.BarMinValue = 0
        dtbDiskusedratioHA.BarMaxValue = 0

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
                Case "HGACTIVECONNECTION"
                    cbxConnectionsHA.Checked = Check
                    cbxCheckedChanged(cbxConnectionsHA)
                    dtbConnectionsHA.BarMinValue = valueLeft
                    dtbConnectionsHA.BarMaxValue = ValueRight
                    If retentionTime > 0 Then
                        cbxDUConnectionsHA.Checked = True
                        nudConnectionsHA.Value = retentionTime / 60
                    Else
                        cbxDUConnectionsHA.Checked = False
                        nudConnectionsHA.Value = 0
                    End If
                Case "HGCPUWAIT"
                    cbxCPUWaitRatioHA.Checked = Check
                    cbxCheckedChanged(cbxCPUWaitRatioHA)
                    dtbCPUwaitratioHA.BarMaxValue = ValueRight
                    dtbCPUwaitratioHA.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUCPUWaitRatioHA.Checked = True
                        nudCPUWaitRatioHA.Value = retentionTime / 60
                    Else
                        cbxDUCPUWaitRatioHA.Checked = False
                        nudCPUWaitRatioHA.Value = 0
                    End If
                Case "HGSWAPUSAGE"
                    cbxSwapUsedRatioHA.Checked = Check
                    cbxCheckedChanged(cbxSwapUsedRatioHA)
                    dtbSWAPusedratioHA.BarMaxValue = ValueRight
                    dtbSWAPusedratioHA.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUSwapUsedRatioHA.Checked = True
                        nudSwapUsedRatioHA.Value = retentionTime / 60
                    Else
                        cbxDUSwapUsedRatioHA.Checked = False
                        nudSwapUsedRatioHA.Value = 0
                    End If
                Case "HGDISKUSAGE"
                    cbxDiskUsedRatioHA.Checked = Check
                    cbxCheckedChanged(cbxDiskUsedRatioHA)
                    dtbDiskusedratioHA.BarMaxValue = ValueRight
                    dtbDiskusedratioHA.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUDiskUsedRatioHA.Checked = True
                        nudDiskUsedRatioHA.Value = retentionTime / 60
                    Else
                        cbxDUDiskUsedRatioHA.Checked = False
                        nudDiskUsedRatioHA.Value = 0
                    End If
                Case "HGCPUUTIL"
                    cbxCPUUtilRatioHA.Checked = Check
                    cbxCheckedChanged(cbxCPUUtilRatioHA)
                    dtbCPUutilratioHA.BarMaxValue = ValueRight
                    dtbCPUutilratioHA.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUCPUUtilRatioHA.Checked = True
                        nudCPUUtilRatioHA.Value = retentionTime / 60
                    Else
                        cbxDUCPUUtilRatioHA.Checked = False
                        nudCPUUtilRatioHA.Value = 0
                    End If
                Case "HGMEMUSAGE"
                    cbxMemoryUsedRatioHA.Checked = Check
                    cbxCheckedChanged(cbxMemoryUsedRatioHA)
                    dtbMEMusedratioHA.BarMaxValue = ValueRight
                    dtbMEMusedratioHA.BarMinValue = valueLeft
                    If retentionTime > 0 Then
                        cbxDUMemoryUsedRatioHA.Checked = True
                        nudMemoryUsedRatioHA.Value = retentionTime / 60
                    Else
                        cbxDUMemoryUsedRatioHA.Checked = False
                        nudMemoryUsedRatioHA.Value = 0
                    End If
            End Select
        Next
    End Sub

    Public Function GetValue() As GetServerAlertConfig
        Dim tmpClass As New GetServerAlertConfig
        tmpClass.InstanceID = _InstanceID

        tmpClass.ConnectionsNormal = dtbConnectionsHA.BarMinValue
        tmpClass.ConnectionsWarning = dtbConnectionsHA.BarMaxValue
        tmpClass.ConnectionsRTime = nudConnectionsHA.Value * 60
        tmpClass.ConnectionsCheck = cbxConnectionsHA.Checked

        tmpClass.CPUutilRatioNormal = dtbCPUutilratioHA.BarMinValue
        tmpClass.CPUutilRatioWarning = dtbCPUutilratioHA.BarMaxValue
        tmpClass.CPUutilRatioRTime = nudCPUUtilRatioHA.Value * 60
        tmpClass.CPUutilRatioCheck = cbxCPUUtilRatioHA.Checked

        tmpClass.CPUwaitRatioNormal = dtbCPUwaitratioHA.BarMinValue
        tmpClass.CPUwaitRatioWarning = dtbCPUwaitratioHA.BarMaxValue
        tmpClass.CPUwaitRatioRTime = nudCPUWaitRatioHA.Value * 60
        tmpClass.CPUwaitRatioCheck = cbxCPUWaitRatioHA.Checked

        tmpClass.MEMusedRatioNormal = dtbMEMusedratioHA.BarMinValue
        tmpClass.MEMusedRatioWarning = dtbMEMusedratioHA.BarMaxValue
        tmpClass.MEMusedRatioRTime = nudMemoryUsedRatioHA.Value * 60
        tmpClass.MEMusedRatioCheck = cbxMemoryUsedRatioHA.Checked

        tmpClass.SWAPusedRatioNormal = dtbSWAPusedratioHA.BarMinValue
        tmpClass.SWAPusedRatioWarning = dtbSWAPusedratioHA.BarMaxValue
        tmpClass.SWAPusedRatioRTime = nudSwapUsedRatioHA.Value * 60
        tmpClass.SWAPusedRatioCheck = cbxSwapUsedRatioHA.Checked

        tmpClass.DiskusedRatioNormal = dtbDiskusedratioHA.BarMinValue
        tmpClass.DiskusedRatioWarning = dtbDiskusedratioHA.BarMaxValue
        tmpClass.DiskusedRatioRTime = nudDiskUsedRatioHA.Value * 60
        tmpClass.DiskusedRatioCheck = cbxDiskUsedRatioHA.Checked

        Return tmpClass
    End Function

    Public Class GetServerAlertConfig
        Public InstanceID As Integer

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
    End Class

    Private Sub cbxBufferHitRatio_CheckedChanged(sender As Object, e As EventArgs) Handles _
                                                                                        cbxDiskUsedRatioHA.CheckedChanged, _
                                                                                        cbxConnectionsHA.CheckedChanged, _
                                                                                        cbxCPUUtilRatioHA.CheckedChanged, _
                                                                                        cbxCPUWaitRatioHA.CheckedChanged, _
                                                                                        cbxMemoryUsedRatioHA.CheckedChanged, _
                                                                                        cbxSwapUsedRatioHA.CheckedChanged
        Dim checkBox As eXperDB.BaseControls.CheckBox = DirectCast(sender, eXperDB.BaseControls.CheckBox)
        cbxCheckedChanged(checkBox)
    End Sub


    Private Sub cbxDuration1_CheckedChanged(sender As Object, e As EventArgs) Handles _
                                                                                    cbxDUMemoryUsedRatioHA.CheckedChanged, _
                                                                                    cbxDUSwapUsedRatioHA.CheckedChanged, _
                                                                                    cbxDUDiskUsedRatioHA.CheckedChanged, _
                                                                                    cbxDUConnectionsHA.CheckedChanged, _
                                                                                    cbxDUCPUUtilRatioHA.CheckedChanged, _
                                                                                    cbxDUCPUWaitRatioHA.CheckedChanged
        Dim chkTemp As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)
        Select Case chkTemp.Name
            Case "cbxDUSwapUsedRatio"
                nudSwapUsedRatioHA.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudSwapUsedRatioHA.Value = 0
            Case "cbxDUDiskUsedRatio"
                nudDiskUsedRatioHA.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudDiskUsedRatioHA.Value = 0
            Case "cbxDUConnections"
                nudConnectionsHA.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudConnectionsHA.Value = 0
            Case "cbxDUCPUWaitRatio"
                nudCPUWaitRatioHA.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudCPUWaitRatioHA.Value = 0
            Case "cbxDUCPUUtilRatio"
                nudCPUUtilRatioHA.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudCPUUtilRatioHA.Value = 0
            Case "cbxDUMemoryUsedRatio"
                nudMemoryUsedRatioHA.Enabled = chkTemp.Checked
                If chkTemp.Checked = False Then nudMemoryUsedRatioHA.Value = 0
        End Select
    End Sub

    Private Sub cbxCheckedChanged(ByRef checkBox As BaseControls.CheckBox)
        Select Case checkBox.Name
            Case "cbxDiskUsedRatio"
                dtbDiskusedratioHA.Enabled = checkBox.Checked
                cbxDUDiskUsedRatioHA.Enabled = checkBox.Checked
            Case "cbxConnections"
                dtbConnectionsHA.Enabled = checkBox.Checked
                cbxDUConnectionsHA.Enabled = checkBox.Checked
            Case "cbxCPUUtilRatio"
                dtbCPUutilratioHA.Enabled = checkBox.Checked
                cbxDUCPUUtilRatioHA.Enabled = checkBox.Checked
            Case "cbxCPUWaitRatio"
                dtbCPUwaitratioHA.Enabled = checkBox.Checked
                cbxDUCPUWaitRatioHA.Enabled = checkBox.Checked
            Case "cbxMemoryUsedRatio"
                dtbMEMusedratioHA.Enabled = checkBox.Checked
                cbxDUMemoryUsedRatioHA.Enabled = checkBox.Checked
            Case "cbxSwapUsedRatio"
                dtbSWAPusedratioHA.Enabled = checkBox.Checked
                cbxDUSwapUsedRatioHA.Enabled = checkBox.Checked
        End Select
    End Sub
End Class
