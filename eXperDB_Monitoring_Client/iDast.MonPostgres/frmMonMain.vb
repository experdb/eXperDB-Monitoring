Public Class frmMonMain


#Region "Declare"

    Public Enum ActStatus
        Activate = 0
        DeActivate = 1
    End Enum


    Private _GrpList As List(Of GroupInfo)
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property GrpList As List(Of GroupInfo)
        Get
            Return _GrpList
        End Get
    End Property

    Private _AgentCn As eXperDB.ODBC.eXperDBODBC = Nothing
    ''' <summary>
    ''' 정책 서버 Connection 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property AgentCn As eXperDB.ODBC.eXperDBODBC
        Get
            Return _AgentCn
        End Get
    End Property

    Private _ShowHchkNormal As Boolean = True
    Private _ShowHchkWarning As Boolean = True
    Private _ShowHchkCritical As Boolean = True

    Private _ElapseInterval As Integer = 3000
    Private _GroupRotateinterval As Integer = 120000
    Private _IsCollectRunning As Boolean = False
    Private _ElapseCount As Integer = 100
    Private _SelectedAlertLevel As Integer = 0

    Private _isPower As Boolean = True
    Private _isDrawInitialData As Integer = 3
    Private _isDiskAccess As Boolean = True
    Private _isDiskUsage As Boolean = True

    Private _instanceColors() As Color = {System.Drawing.Color.YellowGreen,
                         System.Drawing.Color.Orange,
                         System.Drawing.Color.LightSeaGreen,
                         System.Drawing.Color.Blue,
                         System.Drawing.Color.Brown,
                         System.Drawing.Color.Green,
                         System.Drawing.Color.Purple,
                         System.Drawing.Color.Yellow,
                         System.Drawing.Color.Pink,
                         System.Drawing.Color.PowderBlue,
                         System.Drawing.Color.SkyBlue,
                         System.Drawing.Color.SpringGreen,
                         System.Drawing.Color.GreenYellow,
                         System.Drawing.Color.Violet,
                         System.Drawing.Color.Salmon,
                         System.Drawing.Color.AliceBlue,
                         System.Drawing.Color.Bisque,
                         System.Drawing.Color.BlueViolet,
                         System.Drawing.Color.BurlyWood,
                         System.Drawing.Color.Coral,
                         System.Drawing.Color.Crimson,
                         System.Drawing.Color.DarkOliveGreen,
                         System.Drawing.Color.Fuchsia,
                         System.Drawing.Color.DarkKhaki,
                         System.Drawing.Color.Khaki,
                         System.Drawing.Color.Magenta,
                         System.Drawing.Color.LightSalmon,
                         System.Drawing.Color.Lime,
                         System.Drawing.Color.MediumVioletRed,
                         System.Drawing.Color.LightCoral,
                         System.Drawing.Color.Aquamarine,
                         System.Drawing.Color.MediumSeaGreen,
                         System.Drawing.Color.IndianRed,
                         System.Drawing.Color.LawnGreen,
                         System.Drawing.Color.DarkOrange,
                         System.Drawing.Color.DarkBlue,
                         System.Drawing.Color.Olive,
                         System.Drawing.Color.Plum,
                         System.Drawing.Color.Cyan,
                         System.Drawing.Color.Teal,
                         System.Drawing.Color.CadetBlue,
                         System.Drawing.Color.Chartreuse,
                         System.Drawing.Color.Chocolate,
                         System.Drawing.Color.Coral,
                         System.Drawing.Color.CornflowerBlue,
                         System.Drawing.Color.Cornsilk,
                         System.Drawing.Color.DarkGoldenrod,
                         System.Drawing.Color.FloralWhite,
                         System.Drawing.Color.MediumAquamarine,
                         System.Drawing.Color.Gainsboro,
                         System.Drawing.Color.LightGoldenrodYellow}

    Private _groupColors() As Color = {System.Drawing.Color.AliceBlue,
                     System.Drawing.Color.LightSkyBlue}

    'Private _instanceColors() As Color = {System.Drawing.Color.MidnightBlue,
    '                     System.Drawing.Color.DarkBlue,
    '                     System.Drawing.Color.MediumBlue,
    '                     System.Drawing.Color.Blue,
    '                     System.Drawing.Color.RoyalBlue,
    '                     System.Drawing.Color.DodgerBlue,
    '                     System.Drawing.Color.DeepSkyBlue,
    '                     System.Drawing.Color.SkyBlue,
    '                     System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(252, Byte), Integer)),
    '                     System.Drawing.Color.AliceBlue,
    '                     System.Drawing.Color.Indigo,
    '                     System.Drawing.Color.DarkOrchid,
    '                     System.Drawing.Color.MediumOrchid,
    '                     System.Drawing.Color.Plum,
    '                     System.Drawing.Color.Violet,
    '                     System.Drawing.Color.DarkGreen,
    '                     System.Drawing.Color.SeaGreen,
    '                     System.Drawing.Color.MediumSeaGreen,
    '                     System.Drawing.Color.LimeGreen,
    '                     System.Drawing.Color.PaleGreen,
    '                     System.Drawing.Color.DarkGoldenrod,
    '                     System.Drawing.Color.Goldenrod,
    '                     System.Drawing.Color.Gold,
    '                     System.Drawing.Color.Khaki,
    '                     System.Drawing.Color.LemonChiffon,
    '                     System.Drawing.Color.Maroon,
    '                     System.Drawing.Color.Brown,
    '                     System.Drawing.Color.Firebrick,
    '                     System.Drawing.Color.IndianRed,
    '                     System.Drawing.Color.LightCoral,
    '                     System.Drawing.Color.OrangeRed,
    '                     System.Drawing.Color.Tomato,
    '                     System.Drawing.Color.Coral,
    '                     System.Drawing.Color.LightSalmon,
    '                     System.Drawing.Color.MistyRose,
    '                     System.Drawing.Color.MediumVioletRed,
    '                     System.Drawing.Color.DeepPink,
    '                     System.Drawing.Color.HotPink,
    '                     System.Drawing.Color.LightPink,
    '                     System.Drawing.Color.Pink}


    Private _GrpListServerinfo As List(Of GroupInfo.ServerInfo)
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property GrpListServerinfo As List(Of GroupInfo.ServerInfo)
        Get
            Return _GrpListServerinfo
        End Get
    End Property


    Private _AgentInfo As structAgent
    ReadOnly Property AgentInfo As structAgent
        Get
            Return _AgentInfo
        End Get
    End Property


    Private _ShowCritical As Boolean = True
    Property ShowCritical As Boolean
        Get
            Return _ShowCritical
        End Get
        Set(value As Boolean)
            If Not _ShowCritical.Equals(value) Then
                _ShowCritical = value
                If _ShowCritical = False Then
                    sb_CriticalClose()
                End If

            End If

            If value = True Then
                btnCritical.Image = eXperDB.Monitoring.My.Resources.alert_on
            Else
                btnCritical.Image = eXperDB.Monitoring.My.Resources.alert_off
            End If
        End Set
    End Property
    Private _QuiteCriticalTime As DateTime
    Property CriticalTime As Date
        Get
            Return Me._QuiteCriticalTime
        End Get
        Set(value As Date)
            Me._QuiteCriticalTime = value
        End Set
    End Property
    Private _UseQuiteCriticalTime As Boolean
    Property UseCriticalTime As Boolean
        Get
            Return Me._UseQuiteCriticalTime
        End Get
        Set(value As Boolean)
            Me._UseQuiteCriticalTime = value
        End Set
    End Property
    Private _retainTime As Integer = -30
    Property retainTime As Integer
        Get
            Return _retainTime
        End Get
        Set(value As Integer)
            _retainTime = value
        End Set
    End Property
#End Region


#Region "Form"

#Region "Initialize & Finalize"
    ''' <summary>
    ''' 초기화 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal AgentCn As eXperDB.ODBC.eXperDBODBC, ByVal GrpLst As List(Of GroupInfo), ByVal Elapseinterval As Integer, ByVal GroupRotateinterval As Integer, ByVal clsAgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _AgentCn = AgentCn
        _GrpList = GrpLst

        _ElapseInterval = Elapseinterval
        _GroupRotateinterval = GroupRotateinterval
        tmCollect.Interval = _ElapseInterval
        tmRotateGroup.Interval = _GroupRotateinterval
        _AgentInfo = clsAgentInfo

        ReadConfig()


        _ElapseCount = (60000 / _ElapseInterval) * _GrpList.First.Items.Count * 5 ' 5분
        Me.ShowCritical = True
        'Noh -> Me.ShowCritical = True



    End Sub

    Private Sub ReadConfig()
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        _ShowHchkNormal = clsIni.ReadValue("General", "NORMAL_SHOW", True)
        _ShowHchkWarning = clsIni.ReadValue("General", "WARNING_SHOW", True)
        _ShowHchkCritical = clsIni.ReadValue("General", "CRITICAL_SHOW", True)


        nudBackendcnt.Value = clsIni.ReadValue("FORM", "SESSIONMAIN", 30)

        chkIDLE.Checked = clsIni.ReadValue("FORM", "IDLEMAIN", "False")

        If clsIni.ReadValue("FORM", "ALERTLISTTYPE", "rbCurrent").Equals("rbCurrent") Then
            rbCurrent.Checked = True
            dgvAlertCurr.Visible = True
            dgvAlert.Visible = False
        Else
            rbHistory.Checked = True
            dgvAlertCurr.Visible = False
            dgvAlert.Visible = True
        End If

        If clsIni.ReadValue("FORM", "CPUDISPLAYTYPE", "rbCPURadar").Equals("rbCPURadar") Then
            rbCPURadar.Checked = True
        Else
            rbCPUBar.Checked = True
        End If

        If clsIni.ReadValue("FORM", "MEMDISPLAYTYPE", "rbMEMRadar").Equals("rbMEMRadar") Then
            rbMEMRadar.Checked = True
        Else
            rbMEMBar.Checked = True
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        tlpCPUUtil.Tag = clsIni.ReadValue("CHART", "CPUUTIL", "1")
        tlpSessionActive.Tag = clsIni.ReadValue("CHART", "SESSIONACTIVE", "2")
        tlpLogicalRead.Tag = clsIni.ReadValue("CHART", "LOGICALREAD", "3")
        tlpMEMUsage.Tag = clsIni.ReadValue("CHART", "MEMUSAGE", "4")
        tlpSessionTotal.Tag = clsIni.ReadValue("CHART", "SESSIONTOTAL", "5")
        tlpLogicalWrite.Tag = clsIni.ReadValue("CHART", "LOGICALWRITE", "6")
        tlpSQLRespTmAVG.Tag = clsIni.ReadValue("CHART", "SQLRESPTMAVG", "7")
        tlpLockWait.Tag = clsIni.ReadValue("CHART", "LOCKWAIT", "8")
        tlpTPSTotal.Tag = clsIni.ReadValue("CHART", "TPSTOTAL", "9")
        tlpTPSRollback.Tag = clsIni.ReadValue("CHART", "TPSROLLBACK", "0")
        tlpCPUWait.Tag = clsIni.ReadValue("CHART", "CPUWAIT", "0")
        tlpTPSCommit.Tag = clsIni.ReadValue("CHART", "TPSCOMMIT", "0")
        tlpSQLRespTmMAX.Tag = clsIni.ReadValue("CHART", "SQLRESPTMMAX", "0")
        tlpReplicationDelay.Tag = clsIni.ReadValue("CHART", "REPLICATIONDELAY", "0")
        tlpReplicationDelaySize.Tag = clsIni.ReadValue("CHART", "REPLICATIONDELAYSIZE", "0")

        mnuCPUUtil.Tag = tlpCPUUtil
        mnuMEMUsage.Tag = tlpMEMUsage
        mnuSessionActive.Tag = tlpSessionActive
        mnuLogicalRead.Tag = tlpLogicalRead
        mnuSQLRespTmMAX.Tag = tlpSQLRespTmMAX
        mnuLockWait.Tag = tlpLockWait
        mnuTPSTotal.Tag = tlpTPSTotal
        mnuCPUWait.Tag = tlpCPUWait
        mnuLogicalWrite.Tag = tlpLogicalWrite
        mnuSessionTotal.Tag = tlpSessionTotal
        mnuTPSCommit.Tag = tlpTPSCommit
        mnuTPSRollback.Tag = tlpTPSRollback
        mnuSQLRespTmAVG.Tag = tlpSQLRespTmAVG
        mnuReplicationDelay.Tag = tlpReplicationDelay
        mnuReplicationDelaySize.Tag = tlpReplicationDelaySize

        setTLPPosition(tlpCPUUtil)
        setTLPPosition(tlpCPUWait)
        setTLPPosition(tlpMEMUsage)
        setTLPPosition(tlpLogicalRead)
        setTLPPosition(tlpLogicalWrite)
        setTLPPosition(tlpSessionActive)
        setTLPPosition(tlpSessionTotal)
        setTLPPosition(tlpLockWait)
        setTLPPosition(tlpTPSTotal)
        setTLPPosition(tlpTPSCommit)
        setTLPPosition(tlpTPSRollback)
        setTLPPosition(tlpSQLRespTmMAX)
        setTLPPosition(tlpSQLRespTmAVG)
        setTLPPosition(tlpReplicationDelay)
        setTLPPosition(tlpReplicationDelaySize)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cmbRetention.SelectedIndex = clsIni.ReadValue("General", "RTIME", "0")
        retainTime = (-1) * Convert.ToInt32(cmbRetention.Text)

        dgvSessionInfo.Columns(colDgvSessionInfoCpuUsage.Index).Visible = clsIni.ReadValue("FORM", "MAINMENUCOLUMNADDR", "True")
        dgvSessionInfo.Columns(colDgvSessionInfoTmStart.Index).Visible = clsIni.ReadValue("FORM", "MAINMENUCOLUMNAPP", "True")
        dgvSessionInfo.Columns(colDgvSessionInfoTmElapse.Index).Visible = clsIni.ReadValue("FORM", "MAINMENUCOLUMNWAITEVENT", "True")
    End Sub
    Private Sub frmMonMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TmAni.Stop()
        TmAni.Dispose()
    End Sub

    ''' <summary>
    ''' Form Load 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMonMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 폼 초기화 
        InitForm()
        ' Set Radio Button Group = 처음 시작시 모니터링 서버 목록을 가져와서 존재하는 그룹만 화면에 출력한다. 
        'sb_SetRbGrp(_GrpList)
        ServerName_lv.Text = _GrpList.Item(0).GroupName
        tmCollect.Interval = 1500
        tmCollect.Start()
        ' Timer Thread를 생성하고 돌려줌
        ' Timer Thread 는 
        ' 그룹 라디오 감추고 그룹명을 타이틀에 초기화는 form load에서 
        sb_InitControl()
    End Sub

    ''' <summary>
    ''' 화면 언어 및 컨트롤 초기화 실행 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        'modCommon.FontChange(Me, p_Font)
        Dim iniConfig As New Common.IniFile(p_AppConfigIni)



        ' 상태 이상 정보 
        'grpStausSuminfo.Text = p_clsMsgData.fn_GetData("F028")
        lblNormal.Text = p_clsMsgData.fn_GetData("F029")
        lblWarning.Text = p_clsMsgData.fn_GetData("F030")
        lblCritical.Text = p_clsMsgData.fn_GetData("F031")

        ' 인스턴스 요약정보 
        grpInstSumInfo.Text = p_clsMsgData.fn_GetData("F032")

        ' CPU 정보 
        grpCPU.Text = p_clsMsgData.fn_GetData("F035")
        colGrpCpuSvrNm.HeaderText = p_clsMsgData.fn_GetData("F033")
        colGrpCpuSvrUsage.HeaderText = p_clsMsgData.fn_GetData("F034")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblCPUUtil.Text = grpCPU.Text + " Util"
        lblCPUWait.Text = grpCPU.Text + " Wait"
        lblMEMUsage.Text = p_clsMsgData.fn_GetData("F036")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'radCpu.Style = iniConfig.ReadValue("STYLE", "CPU", 2)
        'radCpu.ItemReverse = iniConfig.ReadValue("STYLE", "CPUREVERSE", False)
        radCpu.Style = p_UserENv.CFG_CPUStyle
        radCpu.ItemReverse = p_UserENv.CFG_CPUReverse
        radCpu.DisplayID = p_UserENv.CFG_CPUStyleDSP

        ' Memory 정보 
        grpMem.Text = p_clsMsgData.fn_GetData("F036")
        colGrpMemSvrNm.HeaderText = p_clsMsgData.fn_GetData("F033")
        colGrpMemSvrUsage.HeaderText = p_clsMsgData.fn_GetData("F034")
        'radMem.Style = iniConfig.ReadValue("STYLE", "MEM", 2)
        'radMem.ItemReverse = iniConfig.ReadValue("STYLE", "MEMREVERSE", False)
        radMem.Style = p_UserENv.CFG_MEMStyle
        radMem.ItemReverse = p_UserENv.CFG_MEMReverse
        radMem.DisplayID = p_UserENv.CFG_MEMStyleDSP

        ''Remove 0202
        '' Request Information
        flpCPUStatus.Text = p_clsMsgData.fn_GetData("F040")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblLogicalRead.Text = flpCPUStatus.Text + " Read"
        lblLogicalWrite.Text = flpCPUStatus.Text + " Write"
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'colDgvReqInfoSvrNm.HeaderText = p_clsMsgData.fn_GetData("F033")
        'colDgvReqInfoInsert.HeaderText = p_clsMsgData.fn_GetData("F053")
        'colDgvReqInfoInsert.HeaderCell.Style.ForeColor = chrReqInfo.Series("INSERT").Color
        'colDgvReqInfoInsert.DefaultCellStyle.ForeColor = chrReqInfo.Series("INSERT").Color
        'colDgvReqInfoInsert.DefaultCellStyle.SelectionForeColor = chrReqInfo.Series("INSERT").Color

        'colDgvReqInfoRead.HeaderText = p_clsMsgData.fn_GetData("F054")
        'colDgvReqInfoRead.HeaderCell.Style.ForeColor = chrReqInfo.Series("READ").Color
        'colDgvReqInfoRead.DefaultCellStyle.ForeColor = chrReqInfo.Series("READ").Color
        'colDgvReqInfoRead.DefaultCellStyle.SelectionForeColor = chrReqInfo.Series("READ").Color

        'colDgvReqInfoUpdate.HeaderText = p_clsMsgData.fn_GetData("F055")
        'colDgvReqInfoUpdate.HeaderCell.Style.ForeColor = chrReqInfo.Series("UPDATE").Color
        'colDgvReqInfoUpdate.DefaultCellStyle.ForeColor = chrReqInfo.Series("UPDATE").Color
        'colDgvReqInfoUpdate.DefaultCellStyle.SelectionForeColor = chrReqInfo.Series("UPDATE").Color

        'colDgvReqInfoDelete.HeaderText = p_clsMsgData.fn_GetData("F056")
        'colDgvReqInfoDelete.HeaderCell.Style.ForeColor = chrReqInfo.Series("DELETE").Color
        'colDgvReqInfoDelete.DefaultCellStyle.ForeColor = chrReqInfo.Series("DELETE").Color
        'colDgvReqInfoDelete.DefaultCellStyle.SelectionForeColor = chrReqInfo.Series("DELETE").Color

        'colDgvReqInfoCommit.HeaderText = p_clsMsgData.fn_GetData("F057")
        'colDgvReqInfoRollback.HeaderText = p_clsMsgData.fn_GetData("F058")




        ' Disk Access
        grpDiskAccess.Text = p_clsMsgData.fn_GetData("F041")
        colDgvDiskAccessSvrNm.HeaderText = p_clsMsgData.fn_GetData("F033")
        colDgvDiskAccessDiskNm.HeaderText = p_clsMsgData.fn_GetData("F085")
        colDgvDiskAccessRate.HeaderText = p_clsMsgData.fn_GetData("F043")

        ' Disk Usage
        grpDiskUsage.Text = p_clsMsgData.fn_GetData("F044")
        colDgvDiskUsageSvrNm.HeaderText = p_clsMsgData.fn_GetData("F033")
        colDgvDiskUsageDiskNm.HeaderText = p_clsMsgData.fn_GetData("F193")
        colDgvDiskUsageTot.HeaderText = p_clsMsgData.fn_GetData("F045")
        colDgvDiskUsageRate.HeaderText = p_clsMsgData.fn_GetData("F046")

        ' Session Chart

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblSessionStatus.Text = p_clsMsgData.fn_GetData("F167")
        lblSesionActive.Text = lblSessionStatus.Text + " Active"
        lblSesionTotal.Text = lblSessionStatus.Text + " Total"
        lblLockWait.Text = p_clsMsgData.fn_GetData("F322")
        lblTPSTotal.Text = p_clsMsgData.fn_GetData("F320")
        lblTPSCommit.Text = p_clsMsgData.fn_GetData("F320") + " Commit"
        lblTPSRollback.Text = p_clsMsgData.fn_GetData("F320") + " Rollback"
        lblSQLRespTmMAX.Text = p_clsMsgData.fn_GetData("F103") + " Max"
        lblSQLRespTmAVG.Text = p_clsMsgData.fn_GetData("F103") + " Avg"
        lblRetention.Text = p_clsMsgData.fn_GetData("F326")
        lblReplicationDelay.Text = p_clsMsgData.fn_GetData("F294") + "(Sec)"
        lblReplicationDelaySize.Text = p_clsMsgData.fn_GetData("F294") + "(MB)"
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' Session Information

        grpSessionInfo.Text = p_clsMsgData.fn_GetData("F312")
        dgvSessionInfo.AutoGenerateColumns = False
        colDgvSessionInfoSvrNm.HeaderText = p_clsMsgData.fn_GetData("F033")
        colDgvSessionInfoRead.HeaderText = p_clsMsgData.fn_GetData("F048")
        colDgvSessioninfoWrite.HeaderText = p_clsMsgData.fn_GetData("F136")
        colDgvSessionInfoCpuUsage.HeaderText = p_clsMsgData.fn_GetData("F049")
        colDgvSessionInfoTmStart.HeaderText = p_clsMsgData.fn_GetData("F050")
        colDgvSessionInfoTmElapse.HeaderText = p_clsMsgData.fn_GetData("F051")
        colDgvSessionInfoSQL.HeaderText = p_clsMsgData.fn_GetData("F052")

        chkIDLE.Text = p_clsMsgData.fn_GetData("F227")
        chkIDLE.Tag = p_clsMsgData.fn_GetSpecificData("F227", "COMMENTS")

        'Health 
        'colDgvHealthSvrNm.HeaderText = p_clsMsgData.fn_GetData("F146")
        'colDgvHealthSvrIP.HeaderText = p_clsMsgData.fn_GetData("F034")
        'colDgvHealthSvrPort.HeaderText = p_clsMsgData.fn_GetData("F007")
        'colDgvHealthSvrStatus.HeaderText = p_clsMsgData.fn_GetData("F063")

        'Alert

        'Me.EspRight.Expand = True
        'Me.pnlRibon.Width = Me.Width * 0.14

        Me.cmbLevel.Location = New System.Drawing.Point(Me.grpAlert.Width - Me.cmbLevel.Width - Me.cmbLevel.Margin.Right, Me.cmbLevel.Margin.Top)
        Me.cmbLevel.SelectedIndex = 0

        Me.ttChart.SetToolTip(Me.btnPower, p_clsMsgData.fn_GetData("F308"))
        Me.ttChart.SetToolTip(Me.btnCritical, p_clsMsgData.fn_GetData("F306"))
        Me.ttChart.SetToolTip(Me.btnLock, p_clsMsgData.fn_GetData("F305"))
        'Me.ttChart.SetToolTip(Me.btnConfig, p_clsMsgData.fn_GetData("F300"))
        Me.ttChart.SetToolTip(Me.btnAlertConfig, p_clsMsgData.fn_GetData("F199"))
        Me.ttChart.SetToolTip(Me.btnReport, p_clsMsgData.fn_GetData("F296"))
        Me.ttChart.SetToolTip(Me.grpAlert, "Alert List")

        rbCurrent.Text = p_clsMsgData.fn_GetData("F282")
        rbHistory.Text = p_clsMsgData.fn_GetData("F283")
        rbCPURadar.Text = "Radar"
        rbCPUBar.Text = "Bar"
        rbMEMRadar.Text = "Radar"
        rbMEMBar.Text = "Bar"
        'modCommon.FontChange(Me, p_Font)

    End Sub


    ' ''' <summary>
    ' ''' Group Radio Button 초기화 
    ' ''' </summary>
    ' ''' <param name="grpLst"></param>
    ' ''' <remarks></remarks>
    'Private Sub sb_SetRbGrp(ByVal grpLst As List(Of GroupInfo))
    '    If grpLst Is Nothing Then Return

    '    ' 그룹 버튼을 Visible을 끈다. 
    '    'For Each tmpCtl As Control In tlpGroup.Controls
    '    '    tmpCtl.Visible = False
    '    'Next


    '    ' 컨트롤의 이름을 변경하고 Tag에 서버 목록을 저장한다. 
    '    ' 인스턴스 정보나 기타 정보는 CheckED
    '    For i As Integer = 0 To grpLst.Count - 1
    '        Dim tmpCtl As BaseControls.RadioButton = tlpGroup.Controls.Find("rbGrp" & i + 1, True)(0)
    '        tmpCtl.Text = grpLst.Item(i).GroupName
    '        tmpCtl.ForeColor = System.Drawing.Color.Gray
    '        tmpCtl.Visible = False '라디오버튼 일시 감춤
    '        ' tag 에 그룹에 속한 서버 리스트를 저장한다. 
    '        ' 버튼 선택시 자신의 Tag 에서 해당 리스트 목록을 가져오기 위함. 
    '        tmpCtl.Tag = GrpList.Item(i)
    '        If i = 0 Then
    '            tmpCtl.Checked = True
    '            tmpCtl.ForeColor = System.Drawing.Color.Yellow
    '        End If
    '    Next

    'End Sub

    ''' <summary>
    ''' 그룹 박스 체크시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbGrp_CheckedChanged(sender As Object, e As EventArgs)

        'For i As Integer = 0 To _GrpList.Count - 1
        '    Dim tmpCtl As BaseControls.RadioButton = tlpGroup.Controls.Find("rbGrp" & i + 1, True)(0)
        '    tmpCtl.ForeColor = System.Drawing.Color.Gray
        '    tmpCtl.BackColor = System.Drawing.Color.Black
        'Next

        Dim selCtl As BaseControls.RadioButton = TryCast(sender, BaseControls.RadioButton)
        If selCtl IsNot Nothing AndAlso selCtl.Checked = True Then
            selCtl.ForeColor = System.Drawing.Color.Yellow
            ' 컨트롤의 Tag에서 인스턴스 정보를 가져온다 
            Dim grpInfo As GroupInfo = selCtl.Tag
            ' 인스턴스에 따른 인스턴스 컨트롤 변경 시작 
            ' 인스턴스 상태 정보를 변경한다. 
            sb_SetInstanceStatus(grpInfo.Items)
            ' CPU 관련 목록을 변경한다. 
            sb_SetGrpCPU(grpInfo.Items)
            ' 메모리 관련 목록을 변경한다. 
            sb_SetGrpMem(grpInfo.Items)
            ' Disk Access , Disk Usage
            sb_setGrpDiskInfos()
            ' Request Info 
            sb_SetGrpReqinfo(grpInfo.Items)

            '서버 Alert ServerInfo
            _GrpListServerinfo = grpInfo.Items

            ' 인스턴스에 따른 인스턴스 컨트롤 변경 종료 
        End If
    End Sub
    ' 그룹 라디오 감추고 그룹명을 타이틀에 초기화는 form load에서 
    Private Sub sb_InitControl()

        ' 컨트롤의 Tag에서 인스턴스 정보를 가져온다 
        Dim grpInfo As GroupInfo = _GrpList.Item(0)

        '서버 Alert ServerInfo
        _GrpListServerinfo = grpInfo.Items

        ' 인스턴스에 따른 인스턴스 컨트롤 변경 시작 
        ' 인스턴스 상태 정보를 변경한다. 
        sb_SetInstanceStatus(grpInfo.Items)
        ' CPU 관련 목록을 변경한다. 
        sb_SetGrpCPU(grpInfo.Items)
        ' 메모리 관련 목록을 변경한다. 
        sb_SetGrpMem(grpInfo.Items)
        ' Disk Access , Disk Usage
        sb_setGrpDiskInfos()
        ' Request Info 
        sb_SetGrpReqinfo(grpInfo.Items)
        ' Lock Info 
        sb_SetGrpLockinfo(grpInfo.Items)
        ' TPS
        sb_SetGrpTPSinfo(grpInfo.Items)
        ' SQL Resp
        sb_SetGrpSQLRespInfo(grpInfo.Items)
        ' Session Stats
        sb_SetSessionStatus(grpInfo.Items)
        ' Replication Delay
        sb_SetGrpReplicationInfo(grpInfo.Items)

        If _GrpListServerinfo.Count < 16 Then
            If bckmanual.IsBusy = True Then
                bckmanual.CancelAsync()
                Return
            End If
            bckmanual.RunWorkerAsync()
        Else
            _isDrawInitialData = 0
        End If

    End Sub
    Private Sub sb_SetGrpReqinfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        For Each tmpSeries As DataVisualization.Charting.Series In Me.chrReqInfo.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList

        For i As Integer = 0 To svrLst.Count - 1
            srtLSt.Add(svrLst.Item(i).InstanceID, i)
            For Each tmpSeries As DataVisualization.Charting.Series In Me.chrReqInfo.Series
                Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                tmpSeries.Points(tmpInt).AxisLabel = svrLst.Item(i).ShowNm
                tmpSeries.Points(tmpInt).Tag = svrLst.Item(i)
            Next
        Next

        If svrLst.Count <= 6 Then
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chrReqInfo.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf svrLst.Count > 6 AndAlso svrLst.Count < 12 Then
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chrReqInfo.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chrReqInfo.ChartAreas(0).InnerPlotPosition.Height = 65
        End If

        Me.chrReqInfo.Tag = srtLSt

        ' group color
        sb_setGroupColorChart(chrReqInfo)

        chrReqInfo.Invalidate()

        'dgvReqInfo.Rows.Clear() '0202

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtLogicalRead, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtLogicalWrite, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub sb_SetGrpLockinfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtLockWait, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
    End Sub

    Private Sub sb_SetGrpTPSinfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtTPSTotal, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtTPSCommit, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtTPSRollback, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
    End Sub
    Private Sub sb_SetGrpSQLRespInfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtSQLRespTmMAX, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtSQLRespTmAVG, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
    End Sub
    Private Sub sb_SetGrpReplicationInfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtReplicationDelay, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtReplicationDelaySize, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub sb_setGroupColorChart(ByRef chart As DataVisualization.Charting.Chart)
        Dim svrLst As List(Of GroupInfo.ServerInfo) = _GrpListServerinfo
        chart.ChartAreas(0).AxisX.CustomLabels.Clear()
        Dim intHAGroupindex As Integer = -1
        Dim intSvrCount As Integer = -1
        Dim vIndex As Integer = 0
        Dim colorIndex As Integer = 0
        For i As Integer = 0 To svrLst.Count - 1
            If svrLst.Item(i).Reserved = True Then
                chart.ChartAreas(0).AxisX.CustomLabels.Add(New DataVisualization.Charting.CustomLabel( _
                                                                          vIndex + 0.5, vIndex + 1.5, svrLst.Item(i).ShowNm, 0, DataVisualization.Charting.LabelMarkStyle.None))
                If intHAGroupindex <> svrLst.Item(i).HAGroupIndex Then
                    colorIndex += 1
                    intHAGroupindex = svrLst.Item(i).HAGroupIndex
                End If
                chart.ChartAreas(0).AxisX.CustomLabels(vIndex).ForeColor = _groupColors(colorIndex Mod 2)
                vIndex += 1
            End If
        Next
    End Sub

    Private Sub sb_SetSessionStatus(ByVal svrLst As List(Of GroupInfo.ServerInfo))

        For Each tmpSeries As DataVisualization.Charting.Series In Me.chtSessionStatus.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList

        For i As Integer = 0 To svrLst.Count - 1
            srtLSt.Add(svrLst.Item(i).InstanceID, i)
            For Each tmpSeries As DataVisualization.Charting.Series In Me.chtSessionStatus.Series
                Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                tmpSeries.Points(tmpInt).AxisLabel = svrLst.Item(i).ShowNm
                tmpSeries.Points(tmpInt).ToolTip = svrLst.Item(i).ShowNm
                tmpSeries.Points(tmpInt).Tag = svrLst.Item(i)
                'tmpSeries.Points(tmpInt).BorderColor = _instanceColors(svrLst.Item(i).HAGroupIndex)                
            Next
        Next

        If svrLst.Count <= 6 Then
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtSessionStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf svrLst.Count > 6 AndAlso svrLst.Count < 12 Then
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtSessionStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chtSessionStatus.ChartAreas(0).InnerPlotPosition.Height = 65
        End If

        Me.chtSessionStatus.Tag = srtLSt

        ' group color
        sb_setGroupColorChart(chtSessionStatus)

        chtSessionStatus.Invalidate()

        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtSessionActive, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtSessionTotal, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next

        ' init_DataSessionStatsInfo(svrLst)
    End Sub

    ''' <summary>
    ''' GrpDiskAccess , grpDiskUsage 초기화 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub sb_setGrpDiskInfos()
        dgvGrpDiskAccess.DataSource = Nothing
        dgvGrpDiskAccess.Rows.Clear()
        dgvGrpDiskUsage.DataSource = Nothing
        dgvGrpDiskUsage.Rows.Clear()
    End Sub






    ''' <summary>
    ''' GrpCPU 컨트롤 초기화 
    ''' </summary>
    ''' <param name="svrLst"></param>
    ''' <remarks></remarks>
    Private Sub sb_SetGrpCPU(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        ' 레이더 보이는 아이템을 모두 삭제한다. 
        radCpu.items.Clear()
        ' 레이더 컨트롤 옆의 Grid도 모두 삭제한다. 
        dgvGrpCpuSvrLst.DataSource = Nothing
        dgvGrpCpuSvrLst.Rows.Clear()

        ' Raider 및 DataGridview의 목록을 초기화로 넣는다. 
        Dim idx As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            'radCpu.items.Add(tmpSvr.InstanceID, tmpSvr.ShowNm, instanceImgLst.Images(idx))
            radCpu.items.Add(tmpSvr.InstanceID, tmpSvr.ShowNm, CPUImgLst.Images(idx), idx + 1)
            Dim idxRow As Integer = dgvGrpCpuSvrLst.Rows.Add()
            dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrID.Index).Value = tmpSvr.InstanceID
            dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrNm.Index).Value = tmpSvr.ShowNm
            dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrUsage.Index).Value = 0.0
            dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrProg.Index).Value = 0.0
            idx += 1
        Next

        DgvRowHeightFill(dgvGrpCpuSvrLst)
        AddHandler dgvGrpCpuSvrLst.SizeChanged, AddressOf DataGridView_SizeChanged

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtCPUUtil, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            AddSeries(Me.chtCPUWait, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''''''< Bar 20190807 Start>'''''''''''''''''''''''''''''''''''''''''''
        For Each tmpSeries As DataVisualization.Charting.Series In Me.chtCPUStatus.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList

        For i As Integer = 0 To svrLst.Count - 1
            srtLSt.Add(svrLst.Item(i).InstanceID, i)
            For Each tmpSeries As DataVisualization.Charting.Series In Me.chtCPUStatus.Series
                Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                tmpSeries.Points(tmpInt).AxisLabel = svrLst.Item(i).ShowNm
                tmpSeries.Points(tmpInt).Tag = svrLst.Item(i)
            Next
        Next

        If svrLst.Count <= 6 Then
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtCPUStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf svrLst.Count > 6 AndAlso svrLst.Count < 12 Then
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtCPUStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chtCPUStatus.ChartAreas(0).InnerPlotPosition.Height = 69
        End If

        ' group color
        sb_setGroupColorChart(chtCPUStatus)

        Me.chtCPUStatus.Tag = srtLSt
        chtCPUStatus.Invalidate()
        '''''''< Bar 20190807 Stop>'''''''''''''''''''''''''''''''''''''''''''

    End Sub
    ''' <summary>
    ''' GrpMem 컨트롤 초기화 
    ''' </summary>
    ''' <param name="svrLst"></param>
    ''' <remarks></remarks>
    Private Sub sb_SetGrpMem(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        ' 레이더 보이는 아이템을 모두 삭제한다. 
        radMem.items.Clear()
        ' 레이더 컨트롤 옆의 Grid도 모두 삭제한다. 
        dgvGrpMemSvrLst.DataSource = Nothing
        dgvGrpMemSvrLst.Rows.Clear()
        ' Raider 및 DataGridview의 목록을 초기화로 넣는다. 
        Dim idx As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            radMem.items.Add(tmpSvr.InstanceID, tmpSvr.ShowNm, CPUImgLst.Images(idx), idx + 1)
            Dim idxRow As Integer = dgvGrpMemSvrLst.Rows.Add()
            dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrID.Index).Value = tmpSvr.InstanceID
            dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrNm.Index).Value = tmpSvr.ShowNm
            dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrUsage.Index).Value = 0.0
            dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrprog.Index).Value = 0
            idx += 1
        Next
        DgvRowHeightFill(dgvGrpMemSvrLst)
        AddHandler dgvGrpMemSvrLst.SizeChanged, AddressOf DataGridView_SizeChanged

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20181119 Start>'''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim index As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            AddSeries(Me.chtMEMUsage, tmpSvr.ShowSeriesNm, tmpSvr.ShowNm, _instanceColors(index), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline)
            index += 1
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20181119 End>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''''''< Bar 20190807 Start>'''''''''''''''''''''''''''''''''''''''''''
        For Each tmpSeries As DataVisualization.Charting.Series In Me.chtMEMStatus.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList

        For i As Integer = 0 To svrLst.Count - 1
            srtLSt.Add(svrLst.Item(i).InstanceID, i)
            For Each tmpSeries As DataVisualization.Charting.Series In Me.chtMEMStatus.Series
                Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                tmpSeries.Points(tmpInt).AxisLabel = svrLst.Item(i).ShowNm
                tmpSeries.Points(tmpInt).Tag = svrLst.Item(i)
            Next
        Next

        If svrLst.Count <= 6 Then
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtMEMStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf svrLst.Count > 6 AndAlso svrLst.Count < 12 Then
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtMEMStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chtMEMStatus.ChartAreas(0).InnerPlotPosition.Height = 69
        End If

        ' group color
        sb_setGroupColorChart(chtMEMStatus)

        Me.chtMEMStatus.Tag = srtLSt
        chtMEMStatus.Invalidate()
        '''''''< Bar 20190807 Stop>'''''''''''''''''''''''''''''''''''''''''''
    End Sub



    ''' <summary>
    ''' 인스턴스 상태 표시 컨트롤을 변경 
    ''' </summary>
    ''' <param name="svrLst"></param>
    ''' <remarks></remarks>
    Private Sub sb_SetInstanceStatus(ByVal svrLst As List(Of GroupInfo.ServerInfo))

        '''''''''''''''''''''''''< instance order >''''''''''''''''''''''''''''''
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        setInstanceOrder(clsIni.ReadValue("General", "INSTANCEORDER", 4))
        ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''
        Try
            'dgvClusters.Columns(coldgvClustersLegend.Index).ToolTipText = p_clsMsgData.fn_GetData("M060")

            Dim topNode As AdvancedDataGridView.TreeGridNode = Nothing
            For i As Integer = 0 To svrLst.Count - 1
                Dim toolTipText As String = svrLst.Item(i).ShowNm & Environment.NewLine & svrLst.Item(i).HostNm & Environment.NewLine & svrLst.Item(i).IP & ":" & svrLst.Item(i).Port
                If svrLst.Item(i).HARole = "P" Or svrLst.Item(i).HARole = "A" Then
                    topNode = dgvClusters.Nodes.Add(svrLst.Item(i).ShowNm)
                    topNode.Tag = svrLst.Item(i)
                    topNode.Image = instanceImgLst.Images(i)
                    If _GrpListServerinfo.Count > 16 Then
                        topNode.Height = (dgvClusters.Height - 50) / _GrpListServerinfo.Count
                    Else
                        topNode.Height = 48
                    End If
                    topNode.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(0)
                    topNode.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(0)
                    topNode.Cells(coldgvClustersServerName.Index).Style.ForeColor = Color.FromArgb(24, 192, 128)
                    topNode.Cells(coldgvClustersServerName.Index).Style.SelectionForeColor = Color.FromArgb(24, 192, 128)
                    topNode.Cells(coldgvClustersServerName.Index).Value = svrLst.Item(i).ShowNm
                    topNode.Cells(coldgvClusterPrimaryHostNm.Index).Value = svrLst.Item(i).HostNm
                    topNode.Cells(coldgvClusterPrimaryHostNm.Index).Tag = svrLst.Item(i).IP
                    topNode.Cells(coldgvClustersLegend.Index).ToolTipText = toolTipText
                    topNode.Cells(coldgvClustersVip2.Index).ToolTipText = toolTipText
                    topNode.Cells(coldgvClustersServerName.Index).ToolTipText = toolTipText
                    topNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(0)

                    topNode.Expand()
                Else
                    For Each tmpRow As DataGridViewRow In Me.dgvClusters.Rows
                        Dim tmpNode As AdvancedDataGridView.TreeGridNode = tmpRow
                        If tmpNode.Cells(coldgvClusterPrimaryHostNm.Index).Value = svrLst.Item(i).HAHost Or _
                           tmpNode.Cells(coldgvClusterPrimaryHostNm.Index).Tag = svrLst.Item(i).HAHost Then
                            Dim cNOde As AdvancedDataGridView.TreeGridNode = tmpNode.Nodes.Add(svrLst.Item(i).ShowNm)
                            cNOde.Tag = svrLst.Item(i)
                            cNOde.Image = instanceImgLst.Images(i)
                            If _GrpListServerinfo.Count > 16 Then
                                cNOde.Height = (dgvClusters.Height - 50) / _GrpListServerinfo.Count
                            Else
                                cNOde.Height = 48
                            End If
                            cNOde.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(0)
                            cNOde.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(0)
                            cNOde.Cells(coldgvClustersServerName.Index).Style.ForeColor = Color.FromArgb(24, 192, 128)
                            cNOde.Cells(coldgvClustersServerName.Index).Style.SelectionForeColor = Color.FromArgb(24, 192, 128)
                            cNOde.Cells(coldgvClustersServerName.Index).Value = svrLst.Item(i).ShowNm
                            cNOde.Cells(coldgvClusterPrimaryHostNm.Index).Value = svrLst.Item(i).HostNm
                            cNOde.Cells(coldgvClusterPrimaryHostNm.Index).Tag = svrLst.Item(i).IP
                            cNOde.Cells(coldgvClustersLegend.Index).ToolTipText = toolTipText
                            cNOde.Cells(coldgvClustersVip2.Index).ToolTipText = toolTipText
                            cNOde.Cells(coldgvClustersServerName.Index).ToolTipText = toolTipText
                            cNOde.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(0)
                            cNOde.Expand()
                            Exit For
                        End If
                    Next

                    'svrLst.Item(i).HAHost



                    'For Each tmpNode As AdvancedDataGridView.TreeGridNode In Me.dgvClusters.Nodes
                    '    If svrLst.Item(i).HAHost = tmpNode.Cells(coldgvClusterPrimaryHostNm.Index).Value Then
                    '        Dim cNOde As AdvancedDataGridView.TreeGridNode = tmpNode.Nodes.Add(svrLst.Item(i).ShowNm)
                    '        cNOde.Tag = svrLst.Item(i)
                    '        cNOde.Image = instanceImgLst.Images(i)
                    '        cNOde.Height = 48
                    '        cNOde.Cells(coldgvClustersLegend.Index).Value = statusImgLst.Images(0)
                    '        cNOde.Cells(coldgvClustersServerName.Index).Value = svrLst.Item(i).ShowNm
                    '        cNOde.Cells(coldgvClusterPrimaryHostNm.Index).Value = svrLst.Item(i).HostNm
                    '        cNOde.Cells(coldgvClustersLegend.Index).ToolTipText = toolTipText
                    '        cNOde.Cells(coldgvClustersServerName.Index).ToolTipText = toolTipText
                    '        cNOde.Cells(coldgvClustersRole.Index).Value = ""
                    '        tmpNode.Expand()
                    '        Exit For
                    '    End If
                    'Next


                End If
            Next

            Me.dgvClusters.Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
        Catch ex As Exception
            GC.Collect()
        End Try
        setInstanceColors()
        ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''
    End Sub


    ''' <summary>
    ''' 인스턴스 상태 표시 컨트롤을 변경 
    ''' </summary>
    ''' <param name="svrLst"></param>
    ''' <remarks></remarks>
    Private Sub sb_SetInstanceStatus_old(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        ' 모든 컨트롤을 Visible을 끈다. 
        'For Each tmpCtl As Control In tlpInstance.Controls
        '    Dim tmpProg3D As Controls.Progress3D = TryCast(tmpCtl, Controls.Progress3D)
        '    If tmpProg3D IsNot Nothing Then
        '        tmpProg3D.Visible = False
        '        tmpProg3D.Tag = Nothing
        '        If tmpProg3D.isSelected Then
        '            tmpProg3D.isSelected = False
        '        End If
        '        tmpProg3D.Value = 0
        '    End If
        'Next
        While (flpInstance.Controls.Count > 0)
            Dim tmpCtl As Progress3D = flpInstance.Controls.Item(0)
            tmpCtl.Items.Clear()
            RemoveHandler tmpCtl.SelectedChanged, AddressOf prog3Dinst1_SelectedChanged
            tmpCtl.Dispose()
        End While
        'For Each tmpCtl As Progress3D In flpInstance.Controls
        'RemoveHandler tmpCtl.SelectedChanged, AddressOf prog3Dinst1_SelectedChanged
        'Next

        flpInstance.Controls.Clear()


        ' 인스턴스 수 만큼 화면에 보여준다. 
        For i As Integer = 0 To svrLst.Count - 1
            Dim tmpCtl As Progress3D = CreateProgress3D("prog3Dinst" & i + 1)
            ' 인스턴스 정보 문자 출력
            Dim strHARole As String = "Single"
            Dim PrimaryID As Integer = 0
            Select Case svrLst.Item(i).HARole
                Case "P"
                    strHARole = "Primary"
                Case "S"
                    strHARole = "Standby"
                    PrimaryID = svrLst.Item(i - 1).InstanceID
            End Select
            tmpCtl.HeadText = strHARole
            tmpCtl.PrimaryId = PrimaryID
            tmpCtl.Text = " "
            tmpCtl.Text += svrLst.Item(i).ShowNm
            tmpCtl.SubText = svrLst.Item(i).IP & " / " & svrLst.Item(i).Port
            tmpCtl.IconColor = _instanceColors(i)
            Dim ipaddr As System.Net.IPAddress = System.Net.IPAddress.Parse(svrLst.Item(i).IP)
            tmpCtl.SubLong = ipaddr.Address
            'tmpCtl.SubText = "IP :" & svrLst.Item(i).IP
            'tmpCtl.SubText2 = "Port :" & svrLst.Item(i).Port
            tmpCtl.Tag = svrLst.Item(i)
            flpInstance.Controls.Add(tmpCtl)
            AddHandler tmpCtl.SelectedChanged, AddressOf prog3Dinst1_SelectedChanged

            'Dim tmpProg As Controls.Progress3D = tlpInstance.Controls("prog3Dinst" & i + 1)
            'tmpProg.Text = svrLst.Item(i).HostNm
            'tmpProg.Tag = svrLst.Item(i)
            'tmpProg.Visible = True
        Next

        'flpInstance_SizeChanged(flpInstance, Nothing)

        Dim BaseCTl As BaseControls.FlowLayoutPanel = flpInstance
        Dim ctlWidth As Integer = (BaseCTl.Width - (2 * 2) - IIf(BaseCTl.VerticalScroll.Visible, 20, 0))
        Dim ctlHeight As Integer = (BaseCTl.Height - (2 * 12)) / 12 - 1 'add vertical margin

        For Each tmpCtl As Progress3D In BaseCTl.Controls
            tmpCtl.Width = ctlWidth
            tmpCtl.Height = ctlHeight
            tmpCtl.Margin = New System.Windows.Forms.Padding(1)
        Next


        '''''''''''''''''''''''''< instance order >''''''''''''''''''''''''''''''
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        setInstanceOrder(clsIni.ReadValue("General", "INSTANCEORDER", 4))
    End Sub



    Private Function CreateProgress3D(ByVal CtlNm As String) As Progress3D
        Dim tmpCtl As New Progress3D
        tmpCtl.Name = CtlNm

        Dim Progress3DItem1 As New Progress3D.Progress3DItem
        Dim Progress3DItem2 As New Progress3D.Progress3DItem
        Dim Progress3DItem3 As New Progress3D.Progress3DItem
        Progress3DItem1.Checked = False
        Progress3DItem1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Progress3DItem1.FillOpacity = 180
        Progress3DItem1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Progress3DItem1.LineOpacity = 50
        Progress3DItem1.Name = Nothing
        Progress3DItem2.Checked = False
        Progress3DItem2.FillColor = System.Drawing.Color.Orange
        Progress3DItem2.FillOpacity = 180
        Progress3DItem2.LineColor = System.Drawing.Color.Orange
        Progress3DItem2.LineOpacity = 50
        Progress3DItem2.Name = Nothing
        Progress3DItem3.Checked = False
        Progress3DItem3.FillColor = System.Drawing.Color.OrangeRed
        Progress3DItem3.FillOpacity = 180
        Progress3DItem3.LineColor = System.Drawing.Color.OrangeRed
        Progress3DItem3.LineOpacity = 50
        Progress3DItem3.Name = Nothing
        tmpCtl.Items.AddRange(New eXperDB.Controls.Progress3D.Progress3DItem() {Progress3DItem1, Progress3DItem2, Progress3DItem3})

        tmpCtl.Width = 78 ' Size = New System.Drawing.Size(78, 123)
        tmpCtl.Height = 123
        tmpCtl.Radius = 5
        tmpCtl.BackColor = System.Drawing.Color.Black
        tmpCtl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        'tmpCtl.Dock = System.Windows.Forms.DockStyle.Fill
        'tmpCtl.FillColor = System.Drawing.Color.Black
        tmpCtl.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        tmpCtl.Font = New System.Drawing.Font("Gulim", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        tmpCtl.ForeColor = System.Drawing.Color.FromArgb(255, CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        tmpCtl.isSelected = False
        tmpCtl.Text = "Server #8"
        tmpCtl.UseAnimation = False
        tmpCtl.UseSelected = True
        tmpCtl.UseTitle = True
        tmpCtl.Value = 0
        tmpCtl.Margin = New Padding(0, 0, 0, 0)


        Return tmpCtl
    End Function





    ''' <summary>
    ''' 프로그램 종료시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMonMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tmRotateGroup.Stop()
        tmCollect.Stop()

        p_clsAgentCollect.Stop()
        ' 열려있는 창을 닫는다. 
        Dim ArrFrm As New ArrayList
        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmLogin) Is Nothing Then
                ArrFrm.Add(tmpFrm)
            End If
        Next

        For Each tmpFrm As Form In ArrFrm
            If TryCast(tmpFrm, frmSvrList) IsNot Nothing Then
                Me.Owner = Nothing
                tmpFrm.Show()
            Else
                tmpFrm.Close()
            End If
        Next
    End Sub

#End Region


    'Noh ->
    ' ''' <summary>
    ' ''' Controls Configuration 버튼 클릭시 메뉴 아이템을 보여준다. 
    ' ''' </summary>
    ' ''' <param name="e"></param>
    ' ''' <remarks></remarks>
    'Private Sub frmMonMain_FormControlConfig(e As Rectangle) Handles Me.FormControlConfig
    '    mnuPopup.Show(New Point(e.X, e.Y + e.Height), ToolStripDropDownDirection.Default)

    'End Sub
    '/ <-noh


    ''' <summary>
    ''' 환경 설정 메뉴 클릭시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuConfig_Click(sender As Object, e As EventArgs) Handles mnuConfig.Click
        'Dim frmConfig As New frmConfig
        'frmConfig.ShowDialog()
        'ReadConfig()


    End Sub



#End Region







    ''' <summary>
    ''' Detail 창 활성 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub prog3Dinst1_SelectedChanged(sender As Object, e As Progress3D.SelectEventArgs)

        If fn_FormisLock(Me, _AgentCn) = True Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
            MsgBox(strMsg)
            e.Cancel = True
            Return
        End If

        If p_clsAgentCollect.AgentState <> clsCollect.AgntState.Activate Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M019")
            MsgBox(strMsg)
            e.Cancel = True
            Return
        End If


        ' Tag에 값을 넝ㅎ어 두었음. 
        ' Dim intInstanceID As Integer = DirectCast(DirectCast(sender, Progress3D).Tag, GroupInfo.ServerInfo).InstanceID
        Dim svrInfo As GroupInfo.ServerInfo = TryCast(TryCast(sender, Progress3D).Tag, GroupInfo.ServerInfo)


        If e.Selected = True Then
            Dim FrmSub As New frmMonDetail(svrInfo, _ElapseInterval, AgentInfo, AgentCn)
            'FrmSub.Owner = Me
            FrmSub.OwnerForm = Me
            FrmSub.Show()
        Else
            For Each tmpFrm As Form In My.Application.OpenForms
                Dim frmDtl As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
                If frmDtl IsNot Nothing AndAlso frmDtl.InstanceID = svrInfo.InstanceID Then
                    If frmDtl.WindowState = FormWindowState.Minimized Then
                        frmDtl.WindowState = FormWindowState.Maximized
                    End If
                    frmDtl.Activate()
                    Exit For
                End If
            Next

            e.Cancel = True
            'End If


        End If

    End Sub

    Public Sub InstanceSelectedChange(ByVal intInstanceID As Integer, ByVal Bret As Boolean)
        For Each tmpRow In Me.dgvClusters.Rows
            If DirectCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID.Equals(intInstanceID) Then
                tmpRow.Cells(coldgvClusterIsOpenSingle.Index).Value = "0"
                Exit For
            End If
        Next
    End Sub

    Public Sub InstanceSelectedChange_old(ByVal intInstanceID As Integer, ByVal Bret As Boolean)
        'For Each tmpCtl As Controls.Progress3D In Me.flpInstance.Controls
        '    If tmpCtl.Visible = True AndAlso _GrpListServerinfo.Item(0).InstanceID.Equals(intInstanceID) Then
        '        tmpCtl.isSelected = Bret
        '        Exit For
        '    End If
        'Next
        For Each tmpCtl As Controls.Progress3D In Me.flpInstance.Controls
            If tmpCtl.Visible = True AndAlso DirectCast(tmpCtl.Tag, GroupInfo.ServerInfo).InstanceID.Equals(intInstanceID) Then
                tmpCtl.isSelected = Bret
                Exit For
            End If
        Next
    End Sub



    ''' <summary>
    ''' alert 환경 설정 메뉴 클릭시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuAlertConfig_Click(sender As Object, e As EventArgs) Handles mnuAlertConfig.Click
        Dim AlertConfig As New frmAlertConfig(GrpListServerinfo)
        AlertConfig.ShowDialog()
    End Sub



#Region "Timer Thread "

    Private WithEvents tmCollect As New Timer
    Private Sub tmCollect_Tick(sender As Object, e As EventArgs) Handles tmCollect.Tick

        Try
            _IsCollectRunning = True


            tmCollect.Stop()
            tmCollect.Dispose()


            initControls(p_clsAgentCollect.AgentState)

            If p_clsAgentCollect.AgentState = clsCollect.AgntState.Activate Then
                If _isDrawInitialData = 0 Then
                    clsAgentCollect_GetDataBackendinfo(p_clsAgentCollect.infoDataBackend)
                    clsAgentCollect_GetDataCpuMem(p_clsAgentCollect.infoDataCpuMem)
                    clsAgentCollect_GetDataDiskInfo(p_clsAgentCollect.infoDataDisk)
                    clsAgentCollect_GetDataLockinfo(p_clsAgentCollect.infoDatalock)
                    clsAgentCollect_GetDataLockCount(p_clsAgentCollect.infoDatalockCount)
                    clsAgentCollect_GetDataSQLRespTmInfo(p_clsAgentCollect.infoDataSQLRespTm)
                    clsAgentCollect_GetDataObjectInfo(p_clsAgentCollect.infoDataObject, p_clsAgentCollect.infoDataSessioninfo)
                    clsAgentCollect_GetDataHealthCheck(p_clsAgentCollect.infoDataHealth)
                    clsAgentCollect_GetDataSessionStatsInfo(p_clsAgentCollect.infoDataSessioninfo)
                    clsAgentCollect_GetDataAlert(p_clsAgentCollect.infoDataAlert)
                    clsAgentCollect_GetDataStatementsInfo(p_clsAgentCollect.infoDataStmt)
                    clsAgentCollect_GetDataReplicationDelayInfo(p_clsAgentCollect.infoDataRepl)
                    StartChartAnimaition()
                Else
                    _isDrawInitialData -= 1
                End If
            Else
                'SerialCheck()

            End If

            'clsAgentCollect_GetDataRequestInfo(p_clsAgentCollect.infoDataRequest)
            'clsAgentCollect_GetDataCurrentActinfo(p_clsAgentCollect.infoDataCurrentAct)
            'clsAgentCollect_GetDataDBinfo(p_clsAgentCollect.infoDataDBinfo)
            'clsAgentCollect_GetDataTBspaceinfo(p_clsAgentCollect.infoDataTBspaceinfo)
            'clsAgentCollect_GetDataTBinfo(p_clsAgentCollect.infoDataTBinfo)
            'clsAgentCollect_GetDataIndexinfo(p_clsAgentCollect.infoDataIndexinfo)

            'logEvents.AppendTextNewLine(String.Format("[{0}] 데이터 정상 로드 완료", Now.ToString("yyyy-MM-dd HH:mm:ss")))

            'Dim msgQueue As Queue(Of String) = p_clsAgentCollect.ThreadMsgQueue
            'Do Until msgQueue.Count = 0
            '    Dim strMSg As String = msgQueue.Dequeue()
            '    logEvents.AppendTextNewLine(strMSg, Color.DarkGray)
            'Loop
        Catch ex As Exception
            GC.Collect()
        Finally

            tmCollect.Interval = _ElapseInterval
            tmCollect.Start()
            _IsCollectRunning = False
        End Try

    End Sub
    Private WithEvents tmRotateGroup As New Timer
    Private Sub tmRotateGroup_Tick(sender As Object, e As EventArgs) Handles tmRotateGroup.Tick

        Try
            If _IsCollectRunning = True Then
                tmRotateGroup.Stop()
                tmRotateGroup.Dispose()
                tmRotateGroup.Interval = 1000
                tmRotateGroup.Start()
                Return
            End If
            tmCollect.Stop()
            tmCollect.Dispose()
            tmRotateGroup.Stop()
            tmRotateGroup.Dispose()

            If _GrpList Is Nothing Then Return

            ' 컨트롤의 이름을 변경하고 Tag에 서버 목록을 저장한다. 
            ' 인스턴스 정보나 기타 정보는 CheckED
            Dim tmpCtl As BaseControls.RadioButton
            Dim CurrentCheckedIndex As Integer = 0
            For i As Integer = 0 To _GrpList.Count - 1
                tmpCtl = tlpCurrent.Controls.Find("rbGrp" & i + 1, True)(0)
                If tmpCtl.Checked Then
                    CurrentCheckedIndex = i
                    Exit For
                End If
            Next
            CurrentCheckedIndex = CurrentCheckedIndex + 1
            If CurrentCheckedIndex > _GrpList.Count - 1 Then
                CurrentCheckedIndex = 0
            End If
            tmpCtl = tlpCurrent.Controls.Find("rbGrp" & CurrentCheckedIndex + 1, True)(0)
            tmpCtl.Tag = GrpList.Item(CurrentCheckedIndex)
            tmpCtl.Checked = True

        Catch ex As Exception
            GC.Collect()
        Finally
            GC.Collect()
            tmRotateGroup.Interval = _GroupRotateinterval
            tmRotateGroup.Start()
            tmCollect.Start()
        End Try

    End Sub

    Private Sub SerialCheck()
        Dim clsQu As New clsQuerys(_AgentCn)
        Dim dtTable As DataTable = clsQu.SelectLicense()
        If dtTable IsNot Nothing Then
            If dtTable.Rows.Count = 0 Then
                p_clsAgentCollect.Stop()
                tmCollect.Stop()
                If MsgBox(p_clsMsgData.fn_GetData("M018")) = frmMsgbox.MsgBoxResult.OK Then
                    Me.Close()
                End If
            Else
                If dtTable.Rows(0).Item(0) <> "2" Then
                    p_clsAgentCollect.Stop()
                    tmCollect.Stop()
                    'tm_Serial.Stop()
                    If MsgBox(p_clsMsgData.fn_GetData("M018")) = frmMsgbox.MsgBoxResult.OK Then
                        Me.Close()
                    End If
                End If
            End If



        End If

    End Sub

    Private Sub clsAgentCollect_GetDataBackendinfo(ByVal dtTable As DataTable)
        ' 하위폼이 있을 경우 하위폼에 던진다. 
        For Each tmpFrm As Form In My.Application.OpenForms
            Dim subFrm As frmSessionLock = TryCast(tmpFrm, frmSessionLock)
            If subFrm IsNot Nothing Then
                subFrm.SetDataSession(dtTable)
            End If
        Next
        If dtTable Is Nothing OrElse dtTable.Rows.Count = 0 Then Return

        Dim strSvrIDInQuery As String = ""

        'For Each tmpCtl As Control In tlpGroup.Controls
        '    If TryCast(tmpCtl, BaseControls.RadioButton) IsNot Nothing _
        '        AndAlso tmpCtl.Visible = True _
        '        AndAlso tmpCtl.Tag IsNot Nothing _
        '        AndAlso DirectCast(tmpCtl, BaseControls.RadioButton).Checked = True Then

        '        Dim tmpGrp As GroupInfo = DirectCast(tmpCtl.Tag, GroupInfo)
        '        strSvrIDInQuery = String.Join(",", tmpGrp.Items.Select(Function(e) e.InstanceID))
        '    End If
        'Next
        ' 그룹정보를 라이오버튼이 아닌 private variable에서 얻음
        Dim tmpGrp As GroupInfo = _GrpList.Item(0)
        strSvrIDInQuery = String.Join(",", tmpGrp.Items.Select(Function(e) e.InstanceID))

        Dim subQuery As String = ""
        If chkIDLE.Checked = False Then
            Dim tmpStr As String = chkIDLE.Tag
            'subQuery = String.Format(" AND SQL <> '{0}'", tmpStr)
            subQuery = String.Format(" AND STATE = '{0}'", "active")
        End If

        Dim dtView As DataView = New DataView(dtTable, String.Format("INSTANCE_ID IN ({0}) {1}", strSvrIDInQuery, subQuery), "CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)
        Dim showDt As DataTable = Nothing
        If dtView.Count > 0 Then
            showDt = dtView.ToTable.AsEnumerable.Take(nudBackendcnt.Value).CopyToDataTable
        End If

        dgvSessionInfo.DataSource = showDt
        dgvSessionInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

        ' 하위폼이 있을 경우 하위폼에 던진다. 

        'For Each tmpFrm As Form In My.Application.OpenForms
        '    Dim subFrm As frmMonDetail = TryCast(tmpFrm, frmMonDetail)

        '    If subFrm IsNot Nothing Then
        '        subFrm.SetDataBackEnd(dtTable)
        '    End If
        'Next

    End Sub

    Private Sub clsAgentCollect_GetDataStatementsInfo(ByVal dtTable As DataTable)
        ' 하위폼이 있을 경우 하위폼에 던진다. 
        For Each tmpFrm As Form In My.Application.OpenForms
            Dim subFrm As frmCurrentStatements = TryCast(tmpFrm, frmCurrentStatements)
            If subFrm IsNot Nothing Then
                subFrm.SetDataStmt(dtTable)
            End If
        Next
    End Sub

    ''' <summary>
    ''' CPU / MEM 관련 정보가 변경되었을 경우 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clsAgentCollect_GetDataCpuMem(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        Dim intInstID As Integer
        Dim MaxCPU As Double = 0
        Dim MaxMEM As Double = 0
        For Each dtRow As DataRow In dtTable.DefaultView.ToTable(True, "INSTANCE_ID", "CPU_MAIN", "WAIT_UTIL_RATE", "MEM_USED_RATE", "SWP_USED_RATE", "HOST_NAME").Rows
            ' GRP CPU
            Try
                intInstID = dtRow.Item("INSTANCE_ID")
                Dim cpuidx As Integer = radCpu.items.IndexOf(intInstID)
                Dim strInstNm As String = dtRow.Item("HOST_NAME")
                If cpuidx >= 0 Then
                    Dim dblCpu As Double = ConvDBL(dtRow.Item("CPU_MAIN"))
                    radCpu.items(cpuidx).Value = dblCpu '  datainfo.C02_CPU_MAIN
                    radCpu.items(cpuidx).Text = strInstNm

                    For Each tmpRow As DataGridViewRow In dgvGrpCpuSvrLst.Rows
                        If tmpRow.Cells(colGrpCpuSvrID.Index).Value = intInstID Then
                            tmpRow.Cells(colGrpCpuSvrNm.Index).Value = strInstNm   'datainfo.C07_SWP_USED_RATE
                            tmpRow.Cells(colGrpCpuSvrUsage.Index).Value = dblCpu / 100  '  datainfo.C02_CPU_MAIN
                            tmpRow.Cells(colGrpCpuSvrProg.Index).Value = dblCpu ' datainfo.C02_CPU_MAIN
                        End If
                    Next

                    'Using tmpRow As DataGridViewRow = dgvGrpCpuSvrLst.FindFirstRow(intInstID, colGrpCpuSvrID.Index)
                    '    tmpRow.Cells(colGrpCpuSvrNm.Index).Value = strInstNm   'datainfo.C07_SWP_USED_RATE
                    '    tmpRow.Cells(colGrpCpuSvrUsage.Index).Value = dblCpu / 100  '  datainfo.C02_CPU_MAIN
                    '    tmpRow.Cells(colGrpCpuSvrProg.Index).Value = dblCpu ' datainfo.C02_CPU_MAIN
                    'End Using

                    ' Bar type 20190806 start
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            If tmpSvr.Reserved = True Then
                                Dim lngUtil As Integer = ConvULong(dtRow.Item("CPU_MAIN"))
                                Dim lngWait As Integer = ConvULong(dtRow.Item("WAIT_UTIL_RATE"))
                                Dim idx As Integer = Me.chtCPUStatus.Tag.Item(intInstID)
                                drawAnimation(Me.chtCPUStatus.Series("Util"), idx, lngUtil)
                                drawAnimation(Me.chtCPUStatus.Series("Wait"), idx, lngWait)
                                Me.chtCPUStatus.Series("Util").Points(idx).Label = CInt(lngUtil)
                                'Me.chtCPUStatus.Series("Wait").Points(idx).Label = CInt(lngWait)

                                Dim lngMem As Integer = ConvULong(dtRow.Item("MEM_USED_RATE"))
                                Dim lngSwap As Integer = ConvULong(dtRow.Item("SWP_USED_RATE"))
                                idx = Me.chtMEMStatus.Tag.Item(intInstID)
                                drawAnimation(Me.chtMEMStatus.Series("Mem"), idx, lngMem)
                                drawAnimation(Me.chtMEMStatus.Series("Swap"), idx, lngSwap)
                                Me.chtMEMStatus.Series("Mem").Points(idx).Label = CInt(lngMem)
                                Me.chtMEMStatus.Series("Swap").Points(idx).Label = CInt(lngSwap)
                                Dim HARole As String = Me.chtCPUStatus.Series(0).Points(idx).Tag.HARoleStatus
                                If HARole = "P" Then
                                    'Me.chtMEMStatus.Series("Mem").Points(idx).BorderColor = Color.WhiteSmoke
                                    'Me.chtMEMStatus.Series("Swap").Points(idx).BorderColor = Color.WhiteSmoke
                                    'Me.chtCPUStatus.Series("Util").Points(idx).BorderColor = Color.WhiteSmoke
                                    'Me.chtCPUStatus.Series("Wait").Points(idx).BorderColor = Color.WhiteSmoke
                                    Me.chtCPUStatus.Series("Util").Points(idx).MarkerColor = Color.MintCream
                                    Me.chtCPUStatus.Series("Util").Points(idx).MarkerSize = 10
                                    Me.chtCPUStatus.Series("Util").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                                    Me.chtMEMStatus.Series("Mem").Points(idx).MarkerColor = Color.MintCream
                                    Me.chtMEMStatus.Series("Mem").Points(idx).MarkerSize = 10
                                    Me.chtMEMStatus.Series("Mem").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                                Else
                                    'Me.chtMEMStatus.Series("Mem").Points(idx).BorderColor = Nothing
                                    'Me.chtMEMStatus.Series("Swap").Points(idx).BorderColor = Nothing
                                    'Me.chtCPUStatus.Series("Util").Points(idx).BorderColor = Nothing
                                    'Me.chtCPUStatus.Series("Wait").Points(idx).BorderColor = Nothing
                                    Me.chtCPUStatus.Series("Util").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.None
                                    Me.chtMEMStatus.Series("Mem").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.None
                                End If
                                MaxCPU = Math.Max(lngUtil, MaxCPU)
                                MaxMEM = Math.Max(lngMem, MaxMEM)
                            End If
                        End If
                    Next
                    ' Bar type 20190806 end

                    ' GRP MEM
                    Dim memidx As Integer = radMem.items.IndexOf(intInstID)
                    Dim dblMem As Double = ConvDBL(dtRow.Item("MEM_USED_RATE"))
                    radMem.items(memidx).Value = dblMem
                    radMem.items(memidx).Text = strInstNm

                    For Each tmpRow As DataGridViewRow In dgvGrpMemSvrLst.Rows
                        If tmpRow.Cells(colGrpMemSvrID.Index).Value = intInstID Then
                            tmpRow.Cells(colGrpMemSvrNm.Index).Value = strInstNm   'datainfo.C07_SWP_USED_RATE
                            tmpRow.Cells(colGrpMemSvrUsage.Index).Value = dblMem / 100   'datainfo.C07_SWP_USED_RATE
                            tmpRow.Cells(colGrpMemSvrprog.Index).Value = dblMem  'datainfo.C07_SWP_USED_RATE
                        End If
                    Next

                    'Using tmpRow As DataGridViewRow = dgvGrpMemSvrLst.FindFirstRow(intInstID, colGrpMemSvrID.Index)
                    '    tmpRow.Cells(colGrpMemSvrNm.Index).Value = strInstNm   'datainfo.C07_SWP_USED_RATE
                    '    tmpRow.Cells(colGrpMemSvrUsage.Index).Value = dblMem / 100   'datainfo.C07_SWP_USED_RATE
                    '    tmpRow.Cells(colGrpMemSvrprog.Index).Value = dblMem  'datainfo.C07_SWP_USED_RATE
                    'End Using
                End If

                If MaxCPU > 0 Then
                    Dim intPri As Integer = MaxCPU \ 5
                    intPri += 1
                    Dim MaxValue As Integer = intPri * 5
                    Me.chtCPUStatus.ChartAreas(0).AxisY.Maximum = IIf(MaxValue > 100, 100, MaxValue)
                    Me.chtCPUStatus.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
                    Me.chtCPUStatus.ChartAreas(0).AxisY.Interval = Me.chtCPUStatus.ChartAreas(0).AxisY.Maximum / 5
                End If
                If MaxMEM > 0 Then
                    Dim intPri As Integer = MaxMEM \ 5
                    intPri += 1
                    Dim MaxValue As Integer = intPri * 5
                    Me.chtMEMStatus.ChartAreas(0).AxisY.Maximum = IIf(MaxValue > 100, 100, MaxValue)
                    Me.chtMEMStatus.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
                    Me.chtMEMStatus.ChartAreas(0).AxisY.Interval = Me.chtMEMStatus.ChartAreas(0).AxisY.Maximum / 5
                End If

            Catch
                GC.Collect()
            End Try
        Next

        ' 컨트롤 색상 변경 
        modCommon.sb_GridProgClrChg(dgvGrpCpuSvrLst)
        sb_GridSortChg(dgvGrpCpuSvrLst, colGrpCpuSvrUsage.Index)
        modCommon.sb_GridProgClrChg(dgvGrpMemSvrLst)
        sb_GridSortChg(dgvGrpMemSvrLst, colGrpMemSvrUsage.Index)
        'DgvRowHeightFill(dgvGrpCpuSvrLst)
        'DgvRowHeightFill(dgvGrpMemSvrLst)


        '''''''< Bar 20180806 Start>'''''''''''''''''''''''''''''''''''''''''''''

        '''''''< Bar 20180806 Stop>'''''''''''''''''''''''''''''''''''''''''''''

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dblRegDt As Double
        Dim MaxPri As Double = 0
        If dtTable IsNot Nothing Then _
            'AndAlso Me.chtCPUUtil.Series(0).Points.Count > 0 Then 'Avoid the problem of not displaying real-time information 
            If dtTable.Rows.Count > 0 Then
                dblRegDt = ConvOADate(dtTable.Rows(0).Item("REG_DATE"))
                For Each dtRow As DataRow In dtTable.DefaultView.ToTable(True, "INSTANCE_ID", "REG_DATE", "CPU_MAIN", "WAIT_UTIL_RATE", "MEM_USED_RATE").Rows
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtCPUUtil, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("CPU_MAIN")))
                            sb_ChartAddPoint(Me.chtCPUWait, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("WAIT_UTIL_RATE")))
                            sb_ChartAddPoint(Me.chtMEMUsage, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("MEM_USED_RATE")))
                        End If
                    Next
                Next
            Else
                dblRegDt = ConvOADate(Now)
                Me.chtCPUUtil.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Me.chtCPUWait.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Me.chtMEMUsage.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
            End If
        End If

        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                Dim NowCnt As Integer = 3
                If Me.chtCPUUtil.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtCPUUtil.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtCPUUtil.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtCPUUtil.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtCPUWait.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtCPUWait.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtCPUWait.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtCPUWait.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtMEMUsage.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtMEMUsage.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtMEMUsage.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtMEMUsage.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
            Next
        Catch ex As Exception
            GC.Collect()
        End Try

        Me.chtCPUUtil.ChartAreas(0).RecalculateAxesScale()
        Me.chtCPUWait.ChartAreas(0).RecalculateAxesScale()
        Me.chtMEMUsage.ChartAreas(0).RecalculateAxesScale()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub


    ''' <summary>
    '''  Disk Information 업데이트 되었을 경우 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clsAgentCollect_GetDataDiskInfo(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return





        Dim UpdTime As Double = Now.ToOADate



        For Each dtRow As DataRow In dtTable.Rows
            ' GRP ACCESS
            Dim intInstID As Integer = dtRow.Item("INSTANCE_ID") ' datainfo.C00_INSTANCE_ID
            Dim strInstNm As String = dtRow.Item("HOST_NAME")
            ' 현재 활성화 목록을 CPU RAIDER 에서 검색한다. 있으면 뿌리고 없으면 뿌리지 않음. 
            ' 추후 개선할 것 
            Dim cpuidx As Integer = radCpu.items.IndexOf(intInstID)
            If cpuidx >= 0 Then
                If dtRow.Item("DISK_NAME") <> "-" Then
                    Dim strDiskNm As String = dtRow.Item("DISK_NAME")
                    Dim strKey As String = intInstID & strDiskNm
                    Dim dblRate As Double = ConvDBL(dtRow.Item("BUSY_RATE"))

                    ' 키로 찾기 위하여 Instance  + Disk Name 으로 키를 넣어둠. 
                    If _isDiskAccess = True Then
                        Using tmpRow As DataGridViewRow = dgvGrpDiskAccess.FindFirstRow(strKey, colDgvDiskAccessKey.Index)
                            If tmpRow Is Nothing Then
                                Dim intIdx As Integer = dgvGrpDiskAccess.Rows.Add() ' dgvGrpDiskAccess.InvokeRowsAdd
                                ' 디스크KEY
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessKey.Index).Value = strKey
                                ' Instance ID
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessKey.Index).Tag = intInstID
                                ' 서버명칭 
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessSvrNm.Index).Value = strInstNm
                                ' 디스크명칭
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessDiskNm.Index).Value = strDiskNm
                                ' 사용률
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessProg.Index).Value = dblRate
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessRate.Index).Value = dblRate / 100
                                ' 마지막 갱신 시간 다 돌고 시간이 다른넘은 삭제한다. -- 기존 데이터를 계속 갱신하게 때문에 삭제에 대한 로직도 필요함. 
                                dgvGrpDiskAccess.Rows(intIdx).Cells(colDgvDiskAccessUpdTime.Index).Value = UpdTime
                            Else
                                ' 사용률
                                tmpRow.Cells(colDgvDiskAccessProg.Index).Value = dblRate
                                tmpRow.Cells(colDgvDiskAccessRate.Index).Value = dblRate / 100
                                ' 마지막 갱신 시간 다 돌고 시간이 다른넘은 삭제한다. -- 기존 데이터를 계속 갱신하게 때문에 삭제에 대한 로직도 필요함. 
                                tmpRow.Cells(colDgvDiskAccessUpdTime.Index).Value = UpdTime
                            End If
                        End Using
                    End If
                End If

                If dtRow.Item("DEVICE_NAME") <> "-" Then
                    Dim strDeviceNm As String = dtRow.Item("DEVICE_NAME")
                    Dim strKey As String = intInstID & strDeviceNm
                    Dim dblTotKb As Double = ConvDBL(dtRow.Item("TOTAL_KB"))
                    Dim dblRate As Double = ConvDBL(dtRow.Item("DISK_USAGE_PER"))

                    ' GRP USAGE
                    If _isDiskUsage = True Then
                        Using tmpRow As DataGridViewRow = dgvGrpDiskUsage.FindFirstRow(strKey, colDgvDiskUsageKey.Index)
                            If tmpRow Is Nothing Then
                                'Dim intIdx As Integer = dgvGrpDiskUsage.InvokeRowsAdd
                                Dim intIDx As Integer = dgvGrpDiskUsage.Rows.Add()
                                ' Key 
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageKey.Index).Value = strKey
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageKey.Index).Tag = intInstID
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageSvrNm.Index).Value = strInstNm
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageDiskNm.Index).Value = strDeviceNm
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageTot.Index).Value = dblTotKb
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageProg.Index).Value = dblRate
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageRate.Index).Value = dblRate / 100
                                dgvGrpDiskUsage.Rows(intIDx).Cells(colDgvDiskUsageUpdTime.Index).Value = UpdTime
                            Else
                                tmpRow.Cells(colDgvDiskUsageTot.Index).Value = dblTotKb
                                tmpRow.Cells(colDgvDiskUsageProg.Index).Value = dblRate
                                tmpRow.Cells(colDgvDiskUsageRate.Index).Value = dblRate / 100
                                tmpRow.Cells(colDgvDiskUsageUpdTime.Index).Value = UpdTime
                            End If

                        End Using
                    End If
                End If
            End If
        Next

        ' 목록에 사라진것 삭제하기 
        If _isDiskAccess = True Then
            dgvGrpDiskAccess.invokeRowsRemoves(UpdTime, colDgvDiskAccessUpdTime.Index, False)
            dgvGrpDiskAccess.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
            ' 컨트롤 색상 변경 
            modCommon.sb_GridProgClrChg(dgvGrpDiskAccess)
            sb_GridSortChg(dgvGrpDiskAccess, colDgvDiskAccessRate.Index)
        End If

        If _isDiskUsage = True Then
            dgvGrpDiskUsage.invokeRowsRemoves(UpdTime, colDgvDiskUsageUpdTime.Index, False)
            dgvGrpDiskUsage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
            ' 컨트롤 색상 변경 
            modCommon.sb_GridProgClrChg(dgvGrpDiskUsage)
            sb_GridSortChg(dgvGrpDiskUsage, colDgvDiskUsageRate.Index)
        End If

        'For Each tmpFrm As Form In My.Application.OpenForms
        '    Dim subFrm As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
        '    If subFrm IsNot Nothing Then
        '        subFrm.SetDataDisk(dtTable)
        '    End If
        'Next


    End Sub

    'Private Delegate Sub delegateChartClear(ByVal Chart As DataVisualization.Charting.Chart)
    ' ''' <summary>
    ' ''' Thread 접근 불가로 인하여 대리자 선언 
    ' ''' </summary>
    ' ''' <param name="Chart"></param>
    ' ''' <remarks></remarks>
    'Private Sub sb_ChartClear(ByVal Chart As DataVisualization.Charting.Chart)
    '    If Chart.InvokeRequired Then
    '        Chart.Invoke(New delegateChartClear(AddressOf sb_ChartClear), Chart)
    '    Else
    '        For Each tmpSeries As DataVisualization.Charting.Series In Chart.Series
    '            tmpSeries.Points.Clear()
    '        Next
    '    End If

    'End Sub

    'Private Delegate Sub delegateChartPointSetY(ByVal Chart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal intY As Double, ByVal strLabel As String)
    Private Sub sb_ChartPointSetY(ByVal Chart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal intY As Double, ByVal strLabel As String)

        'If Chart.InvokeRequired Then
        '    Chart.Invoke(New delegateChartPointSetY(AddressOf sb_ChartPointSetY), Chart, strSeries, intY, strLabel)
        'Else
        Chart.Series(strSeries).Points.Add(intY)
        Chart.Series(strSeries).Label = strLabel
        'End If

    End Sub




    ''' <summary>
    ''' Lock 관련 정보가 업데이트 되었을 경우 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clsAgentCollect_GetDataLockinfo(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return


        ' 하위폼이 있을 경우 하위폼에 던진다. 

        For Each tmpFrm As Form In My.Application.OpenForms
            Dim subFrm As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
            If subFrm IsNot Nothing Then
                subFrm.SetDataLockinfo(dtTable)
            Else
                Dim subFrmSL As frmSessionLock = TryCast(tmpFrm, frmSessionLock)
                If subFrmSL IsNot Nothing Then
                    subFrmSL.SetDataLockinfo(dtTable)
                End If
            End If
        Next

    End Sub

    ''' <summary>
    ''' Lock Wait
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clsAgentCollect_GetDataLockCount(ByVal dtTable As DataTable)

        '0202 change flow chart
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Dim MaxPri As Double = 0
        If dtTable IsNot Nothing Then
            If dtTable.Rows.Count > 0 Then
                dblRegDt = ConvOADate(dtTable.Rows(0).Item("COLLECT_DT"))
                For Each dtRow As DataRow In dtTable.Rows
                    intInstID = dtRow.Item("INSTANCE_ID")
                    'dblRegDt = ConvOADate(dtRow.Item("COLLECT_DT"))
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            Dim lngActiveSessions As Long = ConvULong(dtRow.Item("LOCK_WAIT"))
                            sb_ChartAddPoint(Me.chtLockWait, tmpSvr.ShowSeriesNm, dblRegDt, lngActiveSessions)
                            Dim idx As Integer = Me.chtSessionStatus.Tag.Item(intInstID)
                            Me.chtLockWait.Series(0).Points(idx).SetValueY(lngActiveSessions)
                            MaxPri = Math.Max(lngActiveSessions, MaxPri)
                        End If
                    Next
                Next
            Else
                dblRegDt = ConvOADate(Now)
                For i As Integer = 0 To Me.chtLockWait.Series.Count - 1
                    Me.chtLockWait.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Next
            End If
            sb_ChartAlignYAxies(Me.chtLockWait)
        End If

        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                Dim NowCnt As Integer = 3
                If Me.chtLockWait.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtLockWait.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtLockWait.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtLockWait.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
            Next
        Catch ex As Exception
            GC.Collect()
        End Try

        If MaxPri > 0 Then

            Dim intPri As Integer = MaxPri \ 5
            intPri += 1
            Me.chtSessionStatus.ChartAreas(0).AxisY.Maximum = intPri * 5
            Me.chtSessionStatus.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            Me.chtSessionStatus.ChartAreas(0).AxisY.Interval = Me.chtSessionStatus.ChartAreas(0).AxisY.Maximum / 5
        End If

        Me.chtSessionStatus.ChartAreas(0).RecalculateAxesScale()
    End Sub

    ' ''' <summary>
    ' ''' SQL Response Time 값이 변경 되었을 경우 
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub clsAgentCollect_GetDataSQLRespTmInfo(ByVal dtTable As DataTable)
    '    If dtTable Is Nothing Then Return




    '    ' 하위폼에 값을 던진다. 
    '    For Each tmpFrm As Form In My.Application.OpenForms
    '        Dim subFrm As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
    '        If subFrm IsNot Nothing Then
    '            subFrm.SetDataSQLRespTm(dtTable)
    '        End If
    '    Next

    'End Sub





    ' ''' <summary>
    ' ''' Database information 값이 변경되었을 경우  
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub clsAgentCollect_GetDataDBinfo(ByVal dtTable As DataTable)
    '    If dtTable Is Nothing Then Return



    '        For Each tmpFrm As Form In My.Application.OpenForms
    '            Dim subFrm As frmMonActInfo = TryCast(tmpFrm, frmMonActInfo)
    '            If subFrm IsNot Nothing Then
    '                subFrm.SetDataDBinfo(dtTable)
    '            End If
    '        Next

    'End Sub

    ' ''' <summary>
    ' ''' tablespace Information 값이 변경되었을 경우  
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub clsAgentCollect_GetDataTBspaceinfo(ByVal dtTable As DataTable)
    '    If dtTable Is Nothing Then Return


    '    ' 하위폼에 값을 던진다. 
    '    For Each tmpFrm As Form In My.Application.OpenForms
    '        Dim subFrm As frmMonActInfo = TryCast(tmpFrm, frmMonActInfo)
    '        If subFrm IsNot Nothing Then
    '            subFrm.SetDataTBspaceinfo(dtTable)
    '        End If
    '    Next


    'End Sub



    ' ''' <summary>
    ' ''' table Information 값이 변경되었을 경우  
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub clsAgentCollect_GetDataTBinfo(ByVal dtTable As DataTable)
    '    If dtTable Is Nothing Then Return



    '    ' 하위폼에 값을 던진다. 
    '    For Each tmpFrm As Form In My.Application.OpenForms
    '        Dim subFrm As frmMonActInfo = TryCast(tmpFrm, frmMonActInfo)
    '        If subFrm IsNot Nothing Then
    '            subFrm.SetDataTBinfo(dtTable)
    '        End If
    '    Next

    'End Sub



    ' ''' <summary>
    ' ''' index Information 값이 변경되었을 경우  
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub clsAgentCollect_GetDataIndexinfo(ByVal dtTable As DataTable)
    '    If dtTable Is Nothing Then Return



    '    ' 하위폼에 값을 던진다. 
    '    For Each tmpFrm As Form In My.Application.OpenForms
    '        Dim subFrm As frmMonActInfo = TryCast(tmpFrm, frmMonActInfo)
    '        If subFrm IsNot Nothing Then
    '            subFrm.SetDataIndexinfo(dtTable)
    '        End If
    '    Next

    'End Sub


    Private Sub clsAgentCollect_GetDataSessionStatsInfo(ByVal dtTableSessionStatus As DataTable)

        '0202 change flow chart
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Dim MaxPri As Double = 0
        If dtTableSessionStatus IsNot Nothing Then
            If dtTableSessionStatus.Rows.Count > 0 Then
                dblRegDt = ConvOADate(dtTableSessionStatus.Rows(0).Item("COLLECT_DT"))
                For Each dtRow As DataRow In dtTableSessionStatus.Rows
                    intInstID = dtRow.Item("INSTANCE_ID")
                    'dblRegDt = ConvOADate(dtRow.Item("COLLECT_DT"))
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            If tmpSvr.Reserved = True Then
                                'If chtSessionActive.Series(0).Points.Count > 0 Then'Avoid the problem of not displaying real-time information 
                                sb_ChartAddPoint(Me.chtSessionActive, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("CUR_ACTV_BACKEND_CNT"))) 'Active 세션만
                                sb_ChartAddPoint(Me.chtSessionTotal, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("TOT_BACKEND_CNT")))
                                'End If
                                'Else
                                '    Dim lastYPoint = Me.chtSessionStatus.Series(tmpSvr.ShowSeriesNm).Points.Count - 1
                                '    If lastYPoint > 0 Then
                                '        sb_ChartAddPoint(Me.chtSessionStatus, tmpSvr.ShowSeriesNm, dblRegDt, Me.chtSessionStatus.Series(tmpSvr.ShowSeriesNm).Points(lastYPoint).YValues(0))
                                '        'Me.chtSessionStatus.Series(tmpSvr.ShowNm).Points(4).YValues(0)
                                '        'Me.chtSessionStatus.Series(tmpSvr.ShowNm).Points.Count
                                '    End If
                                Dim lngActiveSessions As Long = ConvULong(dtRow.Item("CUR_ACTV_BACKEND_CNT"))
                                Dim lngTotalSessions As Long = ConvULong(dtRow.Item("TOT_BACKEND_CNT"))

                                Dim idx As Integer = Me.chtSessionStatus.Tag.Item(intInstID)
                                'Me.chtSessionStatus.Series("Active").Points(idx).SetValueY(lngActiveSessions)
                                Me.chtSessionStatus.Series("Active").Points(idx).Label = lngActiveSessions
                                'Me.chtSessionStatus.Series("Total").Points(idx).SetValueY(lngTotalSessions)
                                Me.chtSessionStatus.Series("Total").Points(idx).Label = lngTotalSessions
                                drawAnimation(Me.chtSessionStatus.Series("Active"), idx, lngActiveSessions)
                                drawAnimation(Me.chtSessionStatus.Series("Total"), idx, lngTotalSessions)
                                Dim HARole As String = Me.chtSessionStatus.Series("Active").Points(idx).Tag.HARoleStatus
                                If HARole = "P" Then
                                    Me.chtSessionStatus.Series("Total").Points(idx).MarkerColor = Color.MintCream
                                    Me.chtSessionStatus.Series("Total").Points(idx).MarkerSize = 10
                                    Me.chtSessionStatus.Series("Total").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                                Else
                                    Me.chtSessionStatus.Series("Total").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.None
                                End If
                                MaxPri = Math.Max(lngTotalSessions, MaxPri)
                            End If
                        End If
                    Next
                Next
            Else
                If chtSessionActive.Series(0).Points.Count > 0 Then
                    dblRegDt = ConvOADate(Now)
                    'sb_ChartAddPoint(Me.chtSessionStatus, "", dblRegDt, 0.0)
                    Me.chtSessionActive.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                    Me.chtSessionTotal.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                End If
            End If
            sb_ChartAlignYAxies(Me.chtSessionActive)
            sb_ChartAlignYAxies(Me.chtSessionTotal)
        End If

        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                Dim NowCnt As Integer = 3
                If Me.chtSessionActive.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtSessionActive.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtSessionActive.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtSessionActive.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtSessionTotal.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtSessionTotal.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtSessionTotal.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtSessionTotal.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
            Next
        Catch ex As Exception
            GC.Collect()
        End Try

        'Dim dtTableSession As DataTable = Nothing
        'Dim dtTable As DataTable = Nothing
        'Dim dblRegDt As Double

        'Try
        '    For i As Integer = 0 To 1
        '        dblRegDt = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm")) + i
        '        For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
        '            sb_ChartAddPoint(Me.chtSessionStatus, tmpSvr.ShowNm, dblRegDt, ConvULong(i))
        '        Next
        '    Next
        '    sb_ChartAlignYAxies(Me.chtSessionStatus)
        'Catch ex As Exception
        '    GC.Collect()
        'End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If MaxPri > 0 Then

            Dim intPri As Integer = MaxPri \ 5
            intPri += 1
            Me.chtSessionStatus.ChartAreas(0).AxisY.Maximum = intPri * 5
            Me.chtSessionStatus.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            Me.chtSessionStatus.ChartAreas(0).AxisY.Interval = Me.chtSessionStatus.ChartAreas(0).AxisY.Maximum / 5
        End If

        'Me.chtSessionStatus.ChartAreas(0).RecalculateAxesScale()


    End Sub


    Private Sub clsAgentCollect_GetDataSQLRespTmInfo(ByVal dtTableDataSQLRespTm As DataTable)

        '0202 change flow chart
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Dim MaxPri As Double = 0
        Dim dblMaxScale As Double = 0
        Dim dblAvgScale As Double = 0
        If dtTableDataSQLRespTm IsNot Nothing Then
            'AndAlso chtSQLRespTmAVG.Series(0).Points.Count > 0 Then 'Avoid the problem of not displaying real-time information 
            If dtTableDataSQLRespTm.Rows.Count > 0 Then
                dblRegDt = ConvOADate(dtTableDataSQLRespTm.Rows(0).Item("REG_DATE"))

                For Each dtRow As DataRow In dtTableDataSQLRespTm.Rows
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtSQLRespTmMAX, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("MAX_SQL_ELAPSED_SEC"))) 'Active 세션만
                            sb_ChartAddPoint(Me.chtSQLRespTmAVG, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("AVG_SQL_ELAPSED_SEC")))
                        End If
                    Next
                Next
            Else
                dblRegDt = ConvOADate(Now)
                For i As Integer = 0 To Me.chtSQLRespTmMAX.Series.Count - 1
                    Me.chtSQLRespTmMAX.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Next
                For i As Integer = 0 To Me.chtSQLRespTmAVG.Series.Count - 1
                    Me.chtSQLRespTmAVG.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Next
            End If

        End If

        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                If Me.chtSQLRespTmMAX.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtSQLRespTmMAX.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtSQLRespTmMAX.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtSQLRespTmMAX.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtSQLRespTmAVG.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtSQLRespTmAVG.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtSQLRespTmAVG.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtSQLRespTmAVG.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
            Next
        Catch ex As Exception
            GC.Collect()
        End Try

        Try
            sb_ChartAlignYAxiesWithUnit(Me.chtSQLRespTmMAX)
            sb_ChartAlignYAxiesWithUnit(Me.chtSQLRespTmAVG)
        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub

    Private Sub clsAgentCollect_GetDataReplicationDelayInfo(ByVal dtTableDataReplicationDelay As DataTable)

        '0202 change flow chart
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Dim MaxPri As Double = 0
        Dim dblMaxScale As Double = 0
        Dim dblAvgScale As Double = 0
        If dtTableDataReplicationDelay IsNot Nothing Then
            If dtTableDataReplicationDelay.Rows.Count > 0 Then
                dblRegDt = ConvOADate(dtTableDataReplicationDelay.Rows(0).Item("COLLECT_DT"))

                For Each dtRow As DataRow In dtTableDataReplicationDelay.Rows
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtReplicationDelay, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("REPLAY_LAG"))) 'Active 세션만
                            sb_ChartAddPoint(Me.chtReplicationDelaySize, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("REPLAY_LAG_SIZE")))
                        End If
                    Next
                Next
            Else
                dblRegDt = ConvOADate(Now)
                For i As Integer = 0 To Me.chtReplicationDelay.Series.Count - 1
                    Me.chtReplicationDelay.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Next
                For i As Integer = 0 To Me.chtReplicationDelaySize.Series.Count - 1
                    Me.chtReplicationDelaySize.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Next
            End If
        Else
            dblRegDt = ConvOADate(Now)
            For i As Integer = 0 To Me.chtReplicationDelay.Series.Count - 1
                Me.chtReplicationDelay.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
            Next
            For i As Integer = 0 To Me.chtReplicationDelaySize.Series.Count - 1
                Me.chtReplicationDelaySize.Series(i).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
            Next
        End If

        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                If Me.chtReplicationDelay.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtReplicationDelay.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtReplicationDelay.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtReplicationDelay.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtReplicationDelaySize.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtReplicationDelaySize.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtReplicationDelaySize.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtReplicationDelaySize.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
            Next
        Catch ex As Exception
            GC.Collect()
        End Try

        Try
            sb_ChartAlignYAxiesWithUnit(Me.chtReplicationDelay)
            sb_ChartAlignYAxiesWithUnit(Me.chtReplicationDelaySize)

            Me.chtReplicationDelay.ChartAreas(0).RecalculateAxesScale()
        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub
    '0202 add flow chart
    'Private Sub init_DataSessionStatsInfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
    '    '0202 change flow chart
    '    Dim dtTableSessionStatus As DataTable = Nothing
    '    Dim arrInstanceIDs As New ArrayList
    '    Dim dblRegDt As Double
    '    Dim intInstID As Integer
    '    Dim strInstancIDs As String
    '    Dim clsQu As clsQuerys
    '    Try
    '        clsQu = New clsQuerys(_AgentCn)
    '        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
    '            arrInstanceIDs.Add(tmpSvr.InstanceID)
    '        Next
    '        Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
    '        strInstancIDs = String.Join(",", Instance)
    '        dtTableSessionStatus = clsQu.SelectInitSessionInfoChart(strInstancIDs, New Date(), New Date(), False)
    '        If dtTableSessionStatus IsNot Nothing Then
    '            For Each dtRow As DataRow In dtTableSessionStatus.Rows
    '                dblRegDt = ConvOADate(dtRow.Item("COLLECT_DT"))
    '                intInstID = dtRow.Item("INSTANCE_ID")
    '                For Each tmpSvr As GroupInfo.ServerInfo In svrLst
    '                    If tmpSvr.InstanceID = intInstID Then
    '                        'sb_ChartAddPoint(Me.chtSessionStatus, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("TOT_BACKEND_CNT")))
    '                        sb_ChartAddPoint(Me.chtSessionStatus, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("CUR_ACTV_BACKEND_CNT")))
    '                    Else
    '                        Dim lastYPoint = Me.chtSessionStatus.Series(tmpSvr.ShowSeriesNm).Points.Count - 1
    '                        If lastYPoint > 0 Then
    '                            sb_ChartAddPoint(Me.chtSessionStatus, tmpSvr.ShowSeriesNm, dblRegDt, Me.chtSessionStatus.Series(tmpSvr.ShowSeriesNm).Points(lastYPoint).YValues(0))

    '                        End If
    '                    End If
    '                Next
    '            Next
    '            sb_ChartAlignYAxies(Me.chtSessionStatus)
    '        End If
    '    Catch ex As Exception
    '        GC.Collect()
    '    Finally
    '        clsQu = Nothing
    '    End Try
    'End Sub
    Private _dtTableSessionStatus As DataTable = Nothing
    Private Sub getinitDataSessionStatsInfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        '0202 change flow chart
        Dim arrInstanceIDs As New ArrayList
        Dim strInstancIDs As String
        Dim clsQu As clsQuerys
        Try
            clsQu = New clsQuerys(_AgentCn)
            For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                arrInstanceIDs.Add(tmpSvr.InstanceID)
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            strInstancIDs = String.Join(",", Instance)
            _dtTableSessionStatus = clsQu.SelectInitSessionInfoChart(strInstancIDs, New Date(), New Date(), _ElapseInterval / 1000)
        Catch ex As Exception
            GC.Collect()
            _dtTableSessionStatus = Nothing
        Finally
            clsQu = Nothing
        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private _dtTableCpu As DataTable = Nothing
    Private Sub getinitDataCpu(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        '0202 change flow chart
        Dim arrInstanceIDs As New ArrayList
        Dim strInstancIDs As String
        Dim clsQu As clsQuerys
        Try
            clsQu = New clsQuerys(_AgentCn)
            For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                arrInstanceIDs.Add(tmpSvr.InstanceID)
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            strInstancIDs = String.Join(",", Instance)
            _dtTableCpu = clsQu.SelectInitCPUChart(strInstancIDs, p_ShowName.ToString("d"), _ElapseInterval / 1000)

        Catch ex As Exception
            GC.Collect()
            _dtTableSessionStatus = Nothing
        Finally
            clsQu = Nothing
        End Try
    End Sub

    Private _dtTableLogical As DataTable = Nothing
    Private Sub getinitDataLogical(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        '0202 change flow chart
        Dim arrInstanceIDs As New ArrayList
        Dim strInstancIDs As String
        Dim clsQu As clsQuerys
        Try
            clsQu = New clsQuerys(_AgentCn)
            For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                arrInstanceIDs.Add(tmpSvr.InstanceID)
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            strInstancIDs = String.Join(",", Instance)
            _dtTableLogical = clsQu.SelectInitObjectChart(strInstancIDs, p_ShowName.ToString("d"), Nothing, Nothing, _ElapseInterval / 1000)
        Catch ex As Exception
            GC.Collect()
            _dtTableSessionStatus = Nothing
        Finally
            clsQu = Nothing
        End Try
    End Sub
    Private _dtTableLock As DataTable = Nothing
    Private Sub getinitDataLock(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        '0202 change flow chart
        Dim arrInstanceIDs As New ArrayList
        Dim strInstancIDs As String
        Dim clsQu As clsQuerys
        Try
            clsQu = New clsQuerys(_AgentCn)
            For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                arrInstanceIDs.Add(tmpSvr.InstanceID)
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            strInstancIDs = String.Join(",", Instance)
            _dtTableLock = clsQu.SelectLockCount(strInstancIDs, New Date(), New Date(), False, 3)
        Catch ex As Exception
            GC.Collect()
            _dtTableSessionStatus = Nothing
        Finally
            clsQu = Nothing
        End Try
    End Sub
    Private _dtTableTPS As DataTable = Nothing
    Private Sub getinitDataTPS(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim arrInstanceIDs As New ArrayList
        Dim strInstancIDs As String
        Dim clsQu As clsQuerys
        Try
            clsQu = New clsQuerys(_AgentCn)
            For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                arrInstanceIDs.Add(tmpSvr.InstanceID)
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            strInstancIDs = String.Join(",", Instance)
            _dtTableTPS = clsQu.SelectInitObjectChart(strInstancIDs, p_ShowName.ToString("d"), Nothing, Nothing, _ElapseInterval / 1000)
        Catch ex As Exception
            GC.Collect()
            _dtTableSessionStatus = Nothing
        Finally
            clsQu = Nothing
        End Try
    End Sub

    Private _dtTableSQLResp As DataTable = Nothing
    Private Sub getinitDataSQLResp(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim arrInstanceIDs As New ArrayList
        Dim strInstancIDs As String
        Dim clsQu As clsQuerys
        Try
            clsQu = New clsQuerys(_AgentCn)
            For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                arrInstanceIDs.Add(tmpSvr.InstanceID)
            Next
            Dim Instance As Integer() = arrInstanceIDs.ToArray(GetType(Integer))
            strInstancIDs = String.Join(",", Instance)
            _dtTableSQLResp = clsQu.SelectInitSQLRespTmChart(strInstancIDs, 3)
        Catch ex As Exception
            GC.Collect()
            _dtTableSessionStatus = Nothing
        Finally
            clsQu = Nothing
        End Try
    End Sub

    Private Sub drawDataSessionStatsInfo(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        '0202 change flow chart
        Dim dtTableSessionStatus As DataTable = Nothing
        Dim arrInstanceIDs As New ArrayList
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Try
            If _dtTableSessionStatus IsNot Nothing Then
                For Each dtRow As DataRow In _dtTableSessionStatus.Rows
                    dblRegDt = ConvOADate(dtRow.Item("COLLECT_DATE"))
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtSessionActive, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("CUR_ACTV_BACKEND_CNT")))
                            sb_ChartAddPoint(Me.chtSessionTotal, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("TOT_BACKEND_CNT")))
                        End If
                    Next
                Next
                sb_ChartAlignYAxies(Me.chtSessionActive)
                sb_ChartAlignYAxies(Me.chtSessionTotal)
            End If
        Catch ex As Exception
            GC.Collect()
        Finally

        End Try
    End Sub

    Private Sub drawDataCpu(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim dtTableCpu As DataTable = Nothing
        Dim arrInstanceIDs As New ArrayList
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Try
            If _dtTableCpu IsNot Nothing Then
                For Each dtRow As DataRow In _dtTableCpu.Rows
                    dblRegDt = ConvOADate(dtRow.Item("COLLECT_DATE"))
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtCPUUtil, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("CPU_MAIN")))
                            sb_ChartAddPoint(Me.chtCPUWait, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("WAIT_UTIL_RATE")))
                            sb_ChartAddPoint(Me.chtMEMUsage, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("MEM_USED_RATE")))
                        End If
                    Next
                Next
                Me.chtCPUUtil.ChartAreas(0).RecalculateAxesScale()
                Me.chtCPUWait.ChartAreas(0).RecalculateAxesScale()
                Me.chtMEMUsage.ChartAreas(0).RecalculateAxesScale()
            End If
        Catch ex As Exception
            GC.Collect()
        Finally

        End Try
    End Sub
    Private Sub drawDataLogical(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim arrInstanceIDs As New ArrayList
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Try
            If _dtTableLogical IsNot Nothing Then
                For Each dtRow As DataRow In _dtTableLogical.Rows
                    dblRegDt = ConvOADate(dtRow.Item("COLLECT_DATE"))
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtLogicalRead, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("SELECT_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtLogicalWrite, tmpSvr.ShowSeriesNm, dblRegDt, _
                                             ConvULong(dtRow.Item("INSERT_TUPLES_PER_SEC")) _
                                           + ConvULong(dtRow.Item("UPDATE_TUPLES_PER_SEC")) _
                                           + ConvULong(dtRow.Item("DELETE_TUPLES_PER_SEC")))
                        End If
                    Next
                Next
                sb_ChartAlignYAxies(Me.chtLogicalRead)
                sb_ChartAlignYAxies(Me.chtLogicalWrite)
            End If
        Catch ex As Exception
            GC.Collect()
        Finally

        End Try
    End Sub
    Private Sub drawDataLock(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim arrInstanceIDs As New ArrayList
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Try
            If _dtTableLock IsNot Nothing Then
                For Each dtRow As DataRow In _dtTableLock.Rows
                    dblRegDt = ConvOADate(dtRow.Item("COLLECT_DT"))
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtLockWait, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("LOCK_WAIT")))
                        End If
                    Next
                Next
                sb_ChartAlignYAxies(Me.chtLockWait)
            End If
        Catch ex As Exception
            GC.Collect()
        Finally
        End Try
    End Sub
    Private Sub drawDataTPS(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim arrInstanceIDs As New ArrayList
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Try
            If _dtTableTPS IsNot Nothing Then
                For Each dtRow As DataRow In _dtTableTPS.Rows
                    dblRegDt = ConvOADate(dtRow.Item("COLLECT_DATE"))
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtTPSTotal, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("COMMIT_TUPLES_PER_SEC")) + ConvULong(dtRow.Item("ROLLBACK_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtTPSCommit, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("COMMIT_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtTPSRollback, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("ROLLBACK_TUPLES_PER_SEC")))
                        End If
                    Next
                Next
                sb_ChartAlignYAxies(Me.chtTPSTotal)
                sb_ChartAlignYAxies(Me.chtTPSCommit)
                sb_ChartAlignYAxies(Me.chtTPSRollback)
            End If
        Catch ex As Exception
            GC.Collect()
        Finally
        End Try
    End Sub

    Private Sub drawDataSQLResp(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        Dim arrInstanceIDs As New ArrayList
        Dim dblRegDt As Double
        Dim intInstID As Integer
        Try
            If _dtTableSQLResp IsNot Nothing Then
                Dim dblMaxScale As Double = 0
                Dim dblAvgScale As Double = 0
                For Each dtRow As DataRow In _dtTableSQLResp.Rows
                    dblRegDt = ConvOADate(dtRow.Item("REG_DATE"))
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In svrLst
                        If tmpSvr.InstanceID = intInstID Then
                            Dim dblMax As Double = ConvDBL(dtRow.Item("MAX_SQL_ELAPSED_SEC"))
                            Dim dblAvg As Double = ConvDBL(dtRow.Item("AVG_SQL_ELAPSED_SEC"))
                            sb_ChartAddPoint(Me.chtSQLRespTmMAX, tmpSvr.ShowSeriesNm, dblRegDt, dblMax)
                            sb_ChartAddPoint(Me.chtSQLRespTmAVG, tmpSvr.ShowSeriesNm, dblRegDt, dblAvg)
                        End If
                    Next
                Next

                sb_ChartAlignYAxiesWithUnit(Me.chtSQLRespTmMAX)
                sb_ChartAlignYAxiesWithUnit(Me.chtSQLRespTmAVG)

            End If
        Catch ex As Exception
            GC.Collect()
        Finally
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub clsAgentCollect_GetDataObjectInfo(ByVal dtTableObject As DataTable, ByVal dtTableSession As DataTable)


        If dtTableObject Is Nothing Then Return
        Dim tmpSrtLst As SortedList = TryCast(Me.chrReqInfo.Tag, SortedList)
        Dim intInstID As Integer = 0
        Dim MaxPri As Double = 0 ' lngInsertTuples + lngDeleteTuples + lngUpdatetTuples
        Dim MaxSec As Double = 0 ' lngReadtTuples
        For Each dtRow As DataRow In dtTableObject.Rows
            ' GRP Reqinfo
            ' DgvreqInfo 
            intInstID = dtRow.Item("INSTANCE_ID")
            ' 현재 활성화 목록을 CPU RAIDER 에서 검색한다. 있으면 뿌리고 없으면 뿌리지 않음. 
            ' 추후 개선할 것 
            Dim cpuidx As Integer = radCpu.items.IndexOf(intInstID)
            If cpuidx >= 0 Then
                Dim strInstNm As String = dtRow.Item("HOST_NAME")
                Dim lngInsertTuples As Long = ConvULong(dtRow.Item("INSERT_TUPLES_PER_SEC"))
                Dim lngReadtTuples As Long = ConvULong(dtRow.Item("SELECT_TUPLES_PER_SEC"))
                Dim lngUpdatetTuples As Long = ConvULong(dtRow.Item("UPDATE_TUPLES_PER_SEC"))
                Dim lngDeleteTuples As Long = ConvULong(dtRow.Item("DELETE_TUPLES_PER_SEC"))
                Dim lngCommitTuples As Long = ConvULong(dtRow.Item("COMMIT_TUPLES_PER_SEC"))
                Dim lngRollabckTuples As Long = ConvULong(dtRow.Item("ROLLBACK_TUPLES_PER_SEC"))


                ' Remove 0202
                '' 키로 찾기 위하여 Instance  + Disk Name 으로 키를 넣어둠. 
                'Using tmpRow As DataGridViewRow = dgvReqInfo.FindFirstRow(intInstID, colDgvReqinfoID.Index)
                '    If tmpRow Is Nothing Then
                '        Dim intIdx As Integer = dgvReqInfo.Rows.Add
                '        ' 디스크KEY
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqinfoID.Index).Value = intInstID
                '        ' 서버명칭 
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoSvrNm.Index).Value = strInstNm
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoInsert.Index).Value = lngInsertTuples
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoRead.Index).Value = lngReadtTuples
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoUpdate.Index).Value = lngUpdatetTuples
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoDelete.Index).Value = lngDeleteTuples
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoCommit.Index).Value = lngCommitTuples
                '        dgvReqInfo.Rows(intIdx).Cells(colDgvReqInfoRollback.Index).Value = lngRollabckTuples
                '    Else
                '        tmpRow.Cells(colDgvReqInfoInsert.Index).Value = lngInsertTuples
                '        tmpRow.Cells(colDgvReqInfoRead.Index).Value = lngReadtTuples
                '        tmpRow.Cells(colDgvReqInfoUpdate.Index).Value = lngUpdatetTuples
                '        tmpRow.Cells(colDgvReqInfoDelete.Index).Value = lngDeleteTuples
                '        tmpRow.Cells(colDgvReqInfoCommit.Index).Value = lngCommitTuples
                '        tmpRow.Cells(colDgvReqInfoRollback.Index).Value = lngRollabckTuples

                '    End If
                'End Using
                If tmpSrtLst IsNot Nothing Then
                    Dim idx As Integer = tmpSrtLst.Item(intInstID)
                    'Me.chrReqInfo.Series("INSERT").Points(idx).SetValueY(lngInsertTuples)
                    'Me.chrReqInfo.Series("DELETE").Points(idx).SetValueY(lngDeleteTuples)
                    'Me.chrReqInfo.Series("UPDATE").Points(idx).SetValueY(lngUpdatetTuples)
                    'Me.chrReqInfo.Series("READ").Points(idx).SetValueY(lngReadtTuples)

                    drawAnimation(Me.chrReqInfo.Series("INSERT"), idx, lngInsertTuples)
                    drawAnimation(Me.chrReqInfo.Series("DELETE"), idx, lngDeleteTuples)
                    drawAnimation(Me.chrReqInfo.Series("UPDATE"), idx, lngUpdatetTuples)
                    drawAnimation(Me.chrReqInfo.Series("READ"), idx, lngReadtTuples)



                    MaxPri = Math.Max(lngInsertTuples + lngDeleteTuples + lngUpdatetTuples, MaxPri)
                    MaxSec = Math.Max(lngReadtTuples, MaxSec)

                    Dim HARole As String = Me.chrReqInfo.Series("INSERT").Points(idx).Tag.HARoleStatus
                    If HARole = "P" Then
                        Me.chrReqInfo.Series("READ").Points(idx).MarkerColor = Color.MintCream
                        Me.chrReqInfo.Series("READ").Points(idx).MarkerSize = 10
                        Me.chrReqInfo.Series("READ").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                    Else
                        Me.chrReqInfo.Series("READ").Points(idx).MarkerStyle = DataVisualization.Charting.MarkerStyle.None
                    End If

                    ' Invoke 로 처리함 귀찮 ㅎㅎ
                    'Me.chrReqInfo.Invoke(New MethodInvoker(Sub() Me.chrReqInfo.ChartAreas(0).RecalculateAxesScale()))


                End If

            End If

        Next


        If MaxPri > 0 Then

            Dim intPri As Integer = MaxPri \ 5
            intPri += 1
            Me.chrReqInfo.ChartAreas(0).AxisY.Maximum = intPri * 5
            Me.chrReqInfo.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            Me.chrReqInfo.ChartAreas(0).AxisY.Interval = Me.chrReqInfo.ChartAreas(0).AxisY.Maximum / 5
        End If
        If MaxSec > 0 Then
            Dim intSec As Integer = MaxSec \ 5
            intSec += 1
            Me.chrReqInfo.ChartAreas(0).AxisY2.Maximum = intSec * 5
            Me.chrReqInfo.ChartAreas(0).AxisY2.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            Me.chrReqInfo.ChartAreas(0).AxisY2.Interval = Me.chrReqInfo.ChartAreas(0).AxisY2.Maximum / 5
        End If


        Me.chrReqInfo.ChartAreas(0).RecalculateAxesScale()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dblRegDt As Double
        If dtTableObject IsNot Nothing Then _
           'AndAlso Me.chtTPSTotal.Series(0).Points.Count > 0 Then'Avoid the problem of not displaying real-time information 
            If dtTableObject.Rows.Count > 0 Then
                dblRegDt = ConvOADate(dtTableObject.Rows(0).Item("COLLECT_DT"))
                For Each dtRow As DataRow In dtTableObject.Rows
                    intInstID = dtRow.Item("INSTANCE_ID")
                    For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                        If tmpSvr.InstanceID = intInstID Then
                            sb_ChartAddPoint(Me.chtLogicalRead, tmpSvr.ShowSeriesNm, dblRegDt, ConvDBL(dtRow.Item("SELECT_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtLogicalWrite, tmpSvr.ShowSeriesNm, dblRegDt, _
                                                 ConvULong(dtRow.Item("INSERT_TUPLES_PER_SEC")) _
                                               + ConvULong(dtRow.Item("UPDATE_TUPLES_PER_SEC")) _
                                               + ConvULong(dtRow.Item("DELETE_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtTPSTotal, tmpSvr.ShowSeriesNm, dblRegDt, _
                                                 ConvULong(dtRow.Item("COMMIT_TUPLES_PER_SEC")) + ConvULong(dtRow.Item("ROLLBACK_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtTPSCommit, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("COMMIT_TUPLES_PER_SEC")))
                            sb_ChartAddPoint(Me.chtTPSRollback, tmpSvr.ShowSeriesNm, dblRegDt, ConvULong(dtRow.Item("ROLLBACK_TUPLES_PER_SEC")))
                        End If
                    Next
                Next
            Else
                dblRegDt = ConvOADate(Now)
                Me.chtLogicalRead.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Me.chtLogicalWrite.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Me.chtTPSTotal.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Me.chtTPSCommit.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
                Me.chtTPSRollback.Series(0).Points.AddXY(Date.FromOADate(dblRegDt), 0.0)
            End If
            sb_ChartAlignYAxies(Me.chtLogicalRead)
            sb_ChartAlignYAxies(Me.chtLogicalWrite)
            sb_ChartAlignYAxies(Me.chtTPSTotal)
            sb_ChartAlignYAxies(Me.chtTPSCommit)
            sb_ChartAlignYAxies(Me.chtTPSRollback)
        End If

        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                Dim NowCnt As Integer = 3
                If Me.chtLogicalRead.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtLogicalRead.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtLogicalRead.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtLogicalRead.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtLogicalWrite.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtLogicalWrite.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtLogicalWrite.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtLogicalWrite.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtTPSTotal.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtTPSTotal.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtTPSTotal.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtTPSTotal.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtTPSCommit.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtTPSCommit.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtTPSCommit.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtTPSCommit.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If
                If Me.chtTPSRollback.Series(tmpSvr.ShowSeriesNm).Points.Count > 0 Then
                    Do While CDate(Now.AddMinutes(retainTime)).ToOADate > Me.chtTPSRollback.Series(tmpSvr.ShowSeriesNm).Points.First.XValue
                        Me.chtTPSRollback.Series(tmpSvr.ShowSeriesNm).Points.RemoveAt(0)
                        If Me.chtTPSRollback.Series(tmpSvr.ShowSeriesNm).Points.Count <= 0 Then
                            Exit Do
                        End If
                    Loop
                End If

            Next
        Catch ex As Exception
            GC.Collect()
        End Try

        Me.chtLogicalRead.ChartAreas(0).RecalculateAxesScale()
        Me.chtLogicalWrite.ChartAreas(0).RecalculateAxesScale()
        Me.chtTPSTotal.ChartAreas(0).RecalculateAxesScale()
        Me.chtTPSCommit.ChartAreas(0).RecalculateAxesScale()
        Me.chtTPSRollback.ChartAreas(0).RecalculateAxesScale()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

    'Private Sub clsAgentCollect_GetDataPhysicaliOinfo(ByVal dtTable As DataTable)
    '    If dtTable Is Nothing Then Return




    '    For Each tmpFrm As Form In My.Application.OpenForms
    '        Dim subFrm As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
    '        If subFrm IsNot Nothing Then
    '            subFrm.SetDataPhysicaliO(dtTable)
    '        End If
    '    Next

    'End Sub

    Private Sub clsAgentCollect_GetDataHealthCheck(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return

        Dim CntNormal As Integer = 0  'InstanceMaxVals.Count(Function(r) r.MaxVal = intNormalVal)
        Dim CntWarning As Integer = 0  'InstanceMaxVals.Count(Function(r) r.MaxVal = intWarningVal)
        Dim CntCritical As Integer = 0  'InstanceMaxVals.Count(Function(r) r.MaxVal = intCriticalVal)

        Dim arrSvrIds As New SortedList

        If dtTable.Rows.Count <= 0 Then Return
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        Dim dgvClusterRow As DataGridViewRow = Nothing
        Dim currInstanceID As Integer = 0
        Dim currHostName As String = ""
        Dim prevInstanceID As Integer = 0
        Dim prevHostName As String = ""
        Dim strRole As String = ""
        Dim intLevel As Integer = 0
        Dim strVip As String = ""
        Dim strVip2 As String = ""
        Try
            For Each dtRow As DataRow In dtTable.Rows
                currInstanceID = CInt(dtRow.Item("INSTANCE_ID"))
                currHostName = dtRow.Item("HOST_NAME").ToString
                If prevInstanceID <> currInstanceID Then
                    If prevInstanceID > 0 Then
                        Select Case intLevel
                            Case 0 : CntNormal += 1
                            Case 1 : CntWarning += 1
                            Case 2 : CntCritical += 1 : arrSvrIds.Add(prevInstanceID, prevHostName)
                        End Select
                        If dgvClusterRow.Cells(coldgvClustersServerName.Index).Tag <> intLevel Then
                            dgvClusterRow.Cells(coldgvClustersServerName.Index).Tag = intLevel
                            dgvClusterRow.Cells(coldgvClustersServerName.Index).Style.ForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                            dgvClusterRow.Cells(coldgvClustersServerName.Index).Style.SelectionForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                        End If
                        intLevel = 0
                    End If
                    For Each tmpRow In Me.dgvClusters.Rows
                        If currInstanceID = DirectCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID Then
                            dgvClusterRow = tmpRow
                            strRole = dtRow.Item("HA_ROLE_S").ToString
                            strVip = dtRow.Item("VIRTUAL_IP").ToString
                            strVip2 = dtRow.Item("VIRTUAL_IP2").ToString
                            DirectCast(dgvClusterRow.Tag, GroupInfo.ServerInfo).HARoleStatus = strRole
                            Exit For
                        End If
                    Next
                    prevInstanceID = currInstanceID
                    prevHostName = currHostName
                End If

                If intLevel < (CInt(dtRow.Item("HCHK_VALUE")) / 100 - 1) Then
                    intLevel = (CInt(dtRow.Item("HCHK_VALUE")) / 100 - 1)
                End If

                If strRole = "P" Then
                    If dgvClusterRow.Cells(coldgvClustersRole.Index).Tag <> "P" Then
                        dgvClusterRow.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(1)
                    End If
                    dgvClusterRow.Cells(coldgvClustersRole.Index).Tag = "P"
                ElseIf strRole = "S" Then
                    If dgvClusterRow.Cells(coldgvClustersRole.Index).Tag <> "S" Then
                        dgvClusterRow.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(2)
                    End If
                    dgvClusterRow.Cells(coldgvClustersRole.Index).Tag = "S"
                Else
                    If dgvClusterRow.Cells(coldgvClustersRole.Index).Tag <> "A" Then
                        dgvClusterRow.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(0)
                    End If
                    dgvClusterRow.Cells(coldgvClustersRole.Index).Tag = "A"
                End If

                If dgvClusterRow.Cells(coldgvClustersLegend.Index).Tag <> strVip Then
                    If strVip IsNot Nothing Then
                        dgvClusterRow.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(3)
                    Else
                        dgvClusterRow.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(0)
                    End If
                End If

                dgvClusterRow.Cells(coldgvClustersLegend.Index).Tag = strVip

                If dgvClusterRow.Cells(coldgvClustersVip2.Index).Tag <> strVip2 Then
                    If strVip2 IsNot Nothing Then
                        dgvClusterRow.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(4)
                    Else
                        dgvClusterRow.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(0)
                    End If
                End If
                dgvClusterRow.Cells(coldgvClustersVip2.Index).Tag = strVip2
            Next

            If prevInstanceID > 0 Then
                Select Case intLevel
                    Case 0 : CntNormal += 1
                    Case 1 : CntWarning += 1
                    Case 2 : CntCritical += 1 : arrSvrIds.Add(prevInstanceID, prevHostName)
                End Select
                If dgvClusterRow.Cells(coldgvClustersServerName.Index).Tag <> intLevel Then
                    dgvClusterRow.Cells(coldgvClustersServerName.Index).Tag = intLevel
                    dgvClusterRow.Cells(coldgvClustersServerName.Index).Style.ForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                    dgvClusterRow.Cells(coldgvClustersServerName.Index).Style.SelectionForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                End If
                dgvClusterRow.Cells(coldgvClustersServerName.Index).Tag = intLevel
            End If
        Catch ex As Exception
            GC.Collect()
        End Try
        stopwatch.Stop()
        Console.WriteLine("Time elapsed1: {0}", stopwatch.Elapsed)
        ' Instance 컨트롤에 Tag에 InstanceID 를 넣어 둫었음.]
        ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''

        dgtNumN.Value = CntNormal.ToString().PadLeft(2, "0")
        dgtNumW.Value = CntWarning.ToString.PadLeft(2, "0")
        dgtNumC.Value = CntCritical.ToString.PadLeft(2, "0")

        If CntCritical > 0 Then
            Me.radCpu.AniColorin = Color.Red
            Me.radMem.AniColorin = Color.Red

            If Me.UseCriticalTime = True Then
                If Me.CriticalTime > Now Then
                    Me.ShowCritical = False
                Else
                    Me.ShowCritical = True
                    Me.UseCriticalTime = False
                End If
            End If

            If Me.ShowCritical = True Then
                sb_CriticalShow(arrSvrIds)
            End If
        Else
            Me.radCpu.AniColorin = Color.LimeGreen
            Me.radMem.AniColorin = Color.LimeGreen
            sb_CriticalClose()
        End If

    End Sub

    Private Sub clsAgentCollect_GetDataHealthCheck_old(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        ''Dim tmpDtTable As DataTable = dtTable.DefaultView.ToTable(True, "INSTANCE_ID , MAX(HCHK_VALUE)")

        ' Linq  Group Instance ID , Max 
        Dim InstanceMaxVals = _
            dtTable.AsEnumerable().GroupBy( _
                Function(r) New With {Key .InstanceID = r.Field(Of Integer)("INSTANCE_ID"), _
                              Key .IP = r.Field(Of String)("SERVER_IP"), _
                              Key .Port = r.Field(Of String)("SERVICE_PORT"), _
                              Key .Vip = r.Field(Of String)("VIRTUAL_IP"), _
                              Key .Vip2 = r.Field(Of String)("VIRTUAL_IP2"), _
                              Key .Name = r.Field(Of String)("HOST_NAME"), _
                              Key .HARole = r.Field(Of String)("HA_ROLE"), _
                              Key .HAHost = r.Field(Of String)("HA_HOST"), _
                              Key .HAPort = r.Field(Of String)("HA_PORT"), _
                              Key .HARoleS = r.Field(Of String)("HA_ROLE_S")} _
                         ).[Select]( _
                         Function(grp) _
                             New With {Key .InstanceID = grp.Key.InstanceID, _
                                       Key .IP = grp.Key.IP, _
                                       Key .Port = grp.Key.Port, _
                                       Key .Vip = grp.Key.Vip, _
                                       Key .Vip2 = grp.Key.Vip2, _
                                       Key .Name = grp.Key.Name, _
                                       Key .HARole = grp.Key.HARole, _
                                       Key .HAHost = grp.Key.HAHost, _
                                       Key .HAPort = grp.Key.HAPort, _
                                       Key .HARoleS = grp.Key.HARoleS, _
                                       Key .MaxVal = grp.Max(Function(e) e.Field(Of Integer)("HCHK_VALUE"))} _
                                   )



        ' Linq Group Instance ID A
        'Dim intNormalVal As Integer = CInt(Me.dgtNumN.Value)
        'Dim intWarningVal As Integer = CInt(Me.dgtNumW.Value)
        'Dim intCriticalVal As Integer = CInt(Me.dgtNumC.Value)

        Dim CntNormal As Integer = 0  'InstanceMaxVals.Count(Function(r) r.MaxVal = intNormalVal)
        Dim CntWarning As Integer = 0  'InstanceMaxVals.Count(Function(r) r.MaxVal = intWarningVal)
        Dim CntCritical As Integer = 0  'InstanceMaxVals.Count(Function(r) r.MaxVal = intCriticalVal)

        Dim arrSvrIds As New SortedList

        If InstanceMaxVals.Count > 0 Then
            'For Each tmpCtl As Control In tlpGroup.Controls
            '    If TryCast(tmpCtl, BaseControls.RadioButton) IsNot Nothing AndAlso tmpCtl.Visible = True AndAlso tmpCtl.Tag IsNot Nothing Then
            '        Dim tmpGrp As GroupInfo = DirectCast(tmpCtl.Tag, GroupInfo)
            '        For Each tmpSvrInfo As GroupInfo.ServerInfo In tmpGrp.Items
            '            Dim tmpInstance = InstanceMaxVals.AsEnumerable.Where(Function(e) e.InstanceID = tmpSvrInfo.InstanceID)
            '            If tmpInstance.Count > 0 Then
            '                Select Case tmpInstance(0).MaxVal / 100
            '                    Case 1 : CntNormal += 1
            '                    Case 2 : CntWarning += 1
            '                    Case 3 : CntCritical += 1 : arrSvrIds.Add(tmpInstance(0).InstanceID, tmpInstance(0).Name)
            '                End Select
            '            End If
            '        Next
            '    End If
            'Next
            ' 그룹정보를 라이오버튼이 아닌 private variable에서 얻음
            Dim tmpGrp As GroupInfo = _GrpList.Item(0)
            For Each tmpSvrInfo As GroupInfo.ServerInfo In tmpGrp.Items
                Dim tmpInstance = InstanceMaxVals.AsEnumerable.Where(Function(e) e.InstanceID = tmpSvrInfo.InstanceID)
                If tmpInstance.Count > 0 Then
                    Select Case tmpInstance(0).MaxVal / 100
                        Case 1 : CntNormal += 1
                        Case 2 : CntWarning += 1
                        Case 3 : CntCritical += 1 : arrSvrIds.Add(tmpInstance(0).InstanceID, tmpInstance(0).Name)
                    End Select
                End If
            Next

            ' Instance 컨트롤에 Tag에 InstanceID 를 넣어 둫었음.]
            For Each tmpCtl As Control In flpInstance.Controls
                If tmpCtl.Visible = True AndAlso tmpCtl.GetType.Equals(GetType(Progress3D)) Then
                    Dim intInstID As Integer = DirectCast(tmpCtl.Tag, GroupInfo.ServerInfo).InstanceID
                    If InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID).Count > 0 Then
                        DirectCast(tmpCtl, Progress3D).Value = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).MaxVal / 100
                        ' HA 롤 구분 문자 출력 P or S
                        Dim strHARole As String = "Single"
                        Select Case InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).HARoleS
                            Case "P"
                                strHARole = "Primary"
                            Case "S"
                                strHARole = "Standby"
                        End Select
                        Dim strHARolePrev As String = DirectCast(tmpCtl, Progress3D).HeadText
                        DirectCast(tmpCtl, Progress3D).HeadText = strHARole
                        'strHARole = "Single"
                        'Select Case InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).HARoleS
                        '    Case "P"
                        '        strHARole = "Primary"
                        '    Case "S"
                        '        strHARole = "Standby"
                        'End Select
                        'DirectCast(tmpCtl, Progress3D).HeadText2 = strHARole
                        tmpCtl.Text = " "
                        tmpCtl.Text += InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).Name
                        If DirectCast(tmpCtl, Progress3D).Value > 2 Then
                            DirectCast(tmpCtl, Progress3D).Warning = True
                        Else
                            DirectCast(tmpCtl, Progress3D).Warning = False
                        End If
                        If strHARolePrev <> strHARole Then
                            tmpCtl.Invalidate()
                        End If
                    End If
                End If
            Next
            ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''
            Try
                For Each tmpRow In Me.dgvClusters.Rows
                    Dim tmpNode As AdvancedDataGridView.TreeGridNode = tmpRow
                    Dim intInstID As Integer = DirectCast(tmpNode.Tag, GroupInfo.ServerInfo).InstanceID
                    Dim intLevel As Integer = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).MaxVal / 100 - 1
                    Dim strRole As String = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).HARoleS
                    Dim strVip As String = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).Vip
                    Dim strVip2 As String = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).Vip2
                    'tmpNode.Image = instanceImgLst.Images(intLevel)
                    DirectCast(tmpNode.Tag, GroupInfo.ServerInfo).HARoleStatus = strRole
                    If strRole = "P" Then
                        'tmpNode.Cells(coldgvClustersRole.Index).Value = "P"
                        'tmpNode.Cells(coldgvClustersRole.Index).Style.ForeColor = Color.FromArgb(255, 91, 155, 213)
                        If tmpNode.Cells(coldgvClustersRole.Index).Tag <> "P" Then
                            tmpNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(1)
                        End If
                        tmpNode.Cells(coldgvClustersRole.Index).Tag = "P"
                    ElseIf strRole = "S" Then
                        'tmpNode.Cells(coldgvClustersRole.Index).Value = "S"
                        'tmpNode.Cells(coldgvClustersRole.Index).Style.ForeColor = Color.FromArgb(255, 255, 192, 203)
                        If tmpNode.Cells(coldgvClustersRole.Index).Tag <> "S" Then
                            tmpNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(2)
                        End If
                        tmpNode.Cells(coldgvClustersRole.Index).Tag = "S"
                    Else
                        If tmpNode.Cells(coldgvClustersRole.Index).Tag <> "A" Then
                            tmpNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(0)
                        End If
                        tmpNode.Cells(coldgvClustersRole.Index).Tag = "A"
                    End If

                    If tmpNode.Cells(coldgvClustersLegend.Index).Tag <> strVip Then
                        If strVip IsNot Nothing Then
                            tmpNode.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(3)
                        Else
                            tmpNode.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(0)
                        End If
                    End If
                    tmpNode.Cells(coldgvClustersLegend.Index).Tag = strVip

                    If tmpNode.Cells(coldgvClustersVip2.Index).Tag <> strVip2 Then
                        If strVip2 IsNot Nothing Then
                            tmpNode.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(4)
                        Else
                            tmpNode.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(0)
                        End If
                    End If
                    tmpNode.Cells(coldgvClustersVip2.Index).Tag = strVip2

                    If tmpNode.Cells(coldgvClustersServerName.Index).Tag <> intLevel Then
                        tmpNode.Cells(coldgvClustersServerName.Index).Style.ForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                        tmpNode.Cells(coldgvClustersServerName.Index).Style.SelectionForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                    End If
                    tmpNode.Cells(coldgvClustersServerName.Index).Tag = intLevel

                    If tmpNode.HasChildren Then
                        For Each cNode As AdvancedDataGridView.TreeGridNode In tmpNode.Nodes
                            intInstID = DirectCast(cNode.Tag, GroupInfo.ServerInfo).InstanceID
                            intLevel = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).MaxVal / 100 - 1
                            strRole = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).HARoleS
                            strVip = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).Vip
                            strVip2 = InstanceMaxVals.Where(Function(e) e.InstanceID = intInstID)(0).Vip2

                            If strRole = "P" Then
                                'cNode.Cells(coldgvClustersRole.Index).Value = "P"
                                'cNode.Cells(coldgvClustersRole.Index).Style.ForeColor = Color.FromArgb(255, 91, 155, 213)
                                If cNode.Cells(coldgvClustersRole.Index).Tag <> "P" Then
                                    cNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(1)
                                End If
                                cNode.Cells(coldgvClustersRole.Index).Tag = "P"
                            ElseIf strRole = "S" Then
                                'cNode.Cells(coldgvClustersRole.Index).Value = "S"
                                'cNode.Cells(coldgvClustersRole.Index).Style.ForeColor = Color.FromArgb(255, 255, 192, 203)
                                If cNode.Cells(coldgvClustersRole.Index).Tag <> "S" Then
                                    cNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(2)
                                End If
                                cNode.Cells(coldgvClustersRole.Index).Tag = "S"
                            Else
                                If cNode.Cells(coldgvClustersRole.Index).Tag <> "A" Then
                                    cNode.Cells(coldgvClustersRole.Index).Value = haStatusLst.Images(0)
                                End If
                                cNode.Cells(coldgvClustersRole.Index).Tag = "A"
                            End If
                            'cNode.Image = instanceImgLst.Images(intLevel)
                            If cNode.Cells(coldgvClustersServerName.Index).Tag <> intLevel Then
                                cNode.Cells(coldgvClustersServerName.Index).Style.ForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                                cNode.Cells(coldgvClustersServerName.Index).Style.SelectionForeColor = IIf(intLevel = 0, Color.FromArgb(24, 192, 128), IIf(intLevel = 1, Color.Gold, Color.OrangeRed))
                            End If
                            cNode.Cells(coldgvClustersServerName.Index).Tag = intLevel

                            If cNode.Cells(coldgvClustersVip2.Index).Tag <> strVip Then
                                If strVip IsNot Nothing Then
                                    cNode.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(3)
                                Else
                                    cNode.Cells(coldgvClustersLegend.Index).Value = haStatusLst.Images(0)
                                End If
                            End If
                            cNode.Cells(coldgvClustersLegend.Index).Tag = strVip

                            If cNode.Cells(coldgvClustersVip2.Index).Tag <> strVip2 Then
                                If strVip2 IsNot Nothing Then
                                    cNode.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(4)
                                Else
                                    cNode.Cells(coldgvClustersVip2.Index).Value = haStatusLst.Images(0)
                                End If
                            End If
                            cNode.Cells(coldgvClustersVip2.Index).Tag = strVip2
                        Next
                    End If
                Next
            Catch ex As Exception
                GC.Collect()
            End Try
            ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''
        End If



        dgtNumN.Value = CntNormal.ToString().PadLeft(InstanceMaxVals.Count.ToString.Length, "0")
        dgtNumW.Value = CntWarning.ToString.PadLeft(InstanceMaxVals.Count.ToString.Length, "0")
        dgtNumC.Value = CntCritical.ToString.PadLeft(InstanceMaxVals.Count.ToString.Length, "0")



        ' restore 0202 instance info : robin
        ' remove logevent : robin 0207

        'For Each InstanceMaxVal In InstanceMaxVals
        '    ' GRP CPU
        '    Dim intInstID As Integer = InstanceMaxVal.InstanceID
        '    Dim strStatus As String = fn_GetHealthName(InstanceMaxVal.MaxVal)

        '    Using dgvHealthRow As DataGridViewRow = dgvHealth.FindFirstRow(intInstID, colDgvHealthSvrID.Index)
        '        If dgvHealthRow Is Nothing Then
        '            Dim intIDx As Integer = dgvHealth.Rows.Add

        '            dgvHealth.Rows(intIDx).Cells(colDgvHealthSvrID.Index).Value = InstanceMaxVal.InstanceID
        '            dgvHealth.Rows(intIDx).Cells(colDgvHealthSvrNm.Index).Value = InstanceMaxVal.Name
        '            dgvHealth.Rows(intIDx).Cells(colDgvHealthSvrIP.Index).Value = InstanceMaxVal.IP
        '            dgvHealth.Rows(intIDx).Cells(colDgvHealthSvrPort.Index).Value = InstanceMaxVal.Port
        '            dgvHealth.Rows(intIDx).Cells(colDgvHealthSvrStatus.Index).Value = strStatus
        '            dgvHealth.Rows(intIDx).Cells(colDgvHealthStatusVal.Index).Value = InstanceMaxVal.MaxVal


        '        Else
        '            dgvHealthRow.Cells(colDgvHealthSvrStatus.Index).Value = strStatus
        '            dgvHealthRow.Cells(colDgvHealthStatusVal.Index).Value = InstanceMaxVal.MaxVal
        '        End If

        '    End Using

        'Next



        '' 컨트롤 색상 변경 
        'modCommon.sb_GridProgClrChg(dgvHealth, colDgvHealthStatusVal.Index, p_RageHealthClr)
        'sb_GridSortChg(dgvHealth, colDgvHealthStatusVal.Index)



        If CntCritical > 0 Then

            'Dim arrSvrLst As New ArrayList

            'For Each tmpLst In InstanceMaxVals.Where(Function(r) r.MaxVal = 300)
            'arrSvrLst.Add(tmpLst.Name)
            'arrSvrIds.Add(tmpLst.InstanceID, tmpLst.InstanceID)
            'Next

            'SetGrpWarning(arrSvrIds)


            Me.radCpu.AniColorin = Color.Red
            Me.radMem.AniColorin = Color.Red

            If Me.UseCriticalTime = True Then
                If Me.CriticalTime > Now Then
                    Me.ShowCritical = False
                Else
                    Me.ShowCritical = True
                    Me.UseCriticalTime = False
                End If
            End If

            If Me.ShowCritical = True Then
                sb_CriticalShow(arrSvrIds)
            End If
        Else
            Me.radCpu.AniColorin = Color.LimeGreen
            Me.radMem.AniColorin = Color.LimeGreen
            'For Each tmpCtl As Control In tlpGroup.Controls
            '    If TryCast(tmpCtl, BaseControls.RadioButton) IsNot Nothing Then
            '        DirectCast(tmpCtl, BaseControls.RadioButton).Warning = False
            '    End If
            'Next
            sb_CriticalClose()
        End If


        Try

            ' remove logevent : robin
            ' restore logevent 0202
            ' remove logevent : robin 0207
            'For Each tmpRow As DataRow In dtTable.Rows

            '    Dim intHchkVal As Integer = tmpRow.Item("HCHK_VALUE")
            '    Dim strRegDt As DateTime = IIf(IsDBNull(tmpRow.Item("COLLECT_TIME")), Now, tmpRow.Item("COLLECT_TIME"))
            '    Dim strHost As String = tmpRow.Item("HOST_NAME")
            '    Dim strHchkNm As String = p_clsMsgData.fn_GetData(tmpRow.Item("HCHK_NAME"))
            '    Dim strValue As String = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpRow.Item("VALUE"))
            '    Dim strValueUnit As String = tmpRow.Item("UNIT")
            '    Dim strComment As String = IIf(IsDBNull(tmpRow.Item("COMMENTS")), "", tmpRow.Item("COMMENTS"))
            '    Dim strShowValue As String = "[{0}]{1}-{2} {3}{4} {5}"
            '    strShowValue = String.Format(strShowValue, strRegDt.ToString("HH:mm:ss"), strHost, strHchkNm, strValue, strValueUnit, strComment)



            '    If intHchkVal = 100 AndAlso _ShowHchkNormal Then
            '        Me.logEvents.AppendTextNewLine(strShowValue, Color.Lime)
            '    ElseIf intHchkVal = 200 AndAlso _ShowHchkWarning Then
            '        Me.logEvents.AppendTextNewLine(strShowValue, Color.Orange)
            '    ElseIf intHchkVal = 300 AndAlso _ShowHchkCritical Then
            '        Me.logEvents.AppendTextNewLine(strShowValue, Color.Red)
            '    End If
            'Next

            'move to clsAgentCollect_GetDataAlert 0208
            ''dgvAlert

            'Dim dtRows As DataRow() = dtTable.Select("HCHK_VALUE >= 200")

            'For Each tmpRow As DataRow In dtRows
            '    Dim intInstanceID As Integer = tmpRow.Item("INSTANCE_ID")
            '    Dim intHchkVal As Integer = tmpRow.Item("HCHK_VALUE")
            '    Dim strRegDt As DateTime = IIf(IsDBNull(tmpRow.Item("COLLECT_TIME")), Now, tmpRow.Item("COLLECT_TIME"))
            '    Dim strHost As String = tmpRow.Item("HOST_NAME")
            '    Dim strHchkNm As String = p_clsMsgData.fn_GetData(tmpRow.Item("HCHK_NAME"))
            '    Dim strValue As String = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpRow.Item("VALUE"))
            '    Dim strValueUnit As String = tmpRow.Item("UNIT")
            '    Dim strComment As String = IIf(IsDBNull(tmpRow.Item("COMMENTS")), "", tmpRow.Item("COMMENTS"))
            '    Dim strShowValue As String = "{0}" + Environment.NewLine + "{1}" + Environment.NewLine + "{2}{3}" + Environment.NewLine
            '    strShowValue = String.Format(strShowValue, strRegDt.ToString("yyyy-MM-dd HH:mm:ss"), strHchkNm, strValue, strValueUnit)

            '    While (dgvAlert.Rows.Count > 16)
            '        dgvAlert.Rows.RemoveAt(dgvAlert.Rows.Count - 1)
            '    End While

            '    Dim tempRow = New DataGridViewRow()
            '    dgvAlert.Rows.Insert(0, tempRow)
            '    dgvAlert.Rows(0).Cells(coldgvAlertID.Index).Value = intInstanceID
            '    dgvAlert.Rows(0).Cells(coldgvAlertStatusVal.Index).Value = intHchkVal
            '    dgvAlert.Rows(0).Cells(coldgvAlertHostname.Index).Value = strHost
            '    dgvAlert.Rows(0).Cells(coldgvAlertMsg.Index).Value = strShowValue
            '    'dgvAlert.Rows(0).Cells(coldgvAlertMsg.Index).Style.Font = New Font("Arial", 7, FontStyle.Bold)
            '    'Using dgvAlertRow As DataGridViewRow = dgvAlert.FindFirstRow(intInstanceID, coldgvAlertID.Index)
            '    '    Dim intIDx As Integer = dgvAlert.Rows.Add
            '    '    If dgvAlertRow Is Nothing Then
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertID.Index).Value = intInstanceID
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertStatusVal.Index).Value = intHchkVal
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertHostname.Index).Value = strHost
            '    '        'dgvAlert.Rows(intIDx).Cells(coldgvAlertMsg.Index).Value = "1121212121 abcdefghi   　 　 "
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertMsg.Index).Value = strShowValue
            '    '    Else
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertID.Index).Value = intInstanceID
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertStatusVal.Index).Value = intHchkVal
            '    '        dgvAlert.Rows(intIDx).Cells(coldgvAlertMsg.Index).Value = strShowValue
            '    '    End If
            '    'End Using

            '    ' 컨트롤 색상 변경
            '    modCommon.sb_GridProgClrChg(dgvAlert, coldgvAlertStatusVal.Index, p_RageHealthClr)
            '    sb_GridSortChg(dgvAlert, coldgvAlertStatus.Index)
            'Next

        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        '' 하위폼이 있을 경우 하위폼에 던진다. 

        'For Each tmpFrm As Form In My.Application.OpenForms
        '    Dim subFrm As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
        '    If subFrm IsNot Nothing Then
        '        subFrm.SetDataHealth(dtTable)
        '    End If
        'Next
    End Sub

    'robin add for alert current 0208
    Private Sub clsAgentCollect_GetDataAlert(ByVal dtTable As DataTable)
        If dtTable Is Nothing Then Return
        Try
            'dgvAlert

            'If rbCurrent.Checked = True Then
            '    dgvAlert.Rows.Clear()
            'End If

            If rbCurrent.Checked = True Then
                dgvAlertCurr.Rows.Clear()
            End If

            Dim tmpCondition As String = String.Empty

            If _SelectedAlertLevel = 0 Then
                tmpCondition = "STATE > 200"
            Else
                tmpCondition = ""
            End If

            For Each tmpRow As DataRow In dtTable.Select(tmpCondition)
                Dim intInstanceID As Integer = tmpRow.Item("INSTANCE_ID")
                Dim intHchkVal As Integer = tmpRow.Item("STATE")
                Dim strRegDt As DateTime = IIf(IsDBNull(tmpRow.Item("COLLECT_TIME")), Now, Date.Parse(tmpRow.Item("COLLECT_TIME")))
                Dim strHost As String = tmpRow.Item("HOST_NAME")
                Dim strHchkNm As String = p_clsMsgData.fn_GetData(tmpRow.Item("HCHK_NAME"))

                Dim strValue As String = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpRow.Item("VALUE"))

                If tmpRow.Item("HCHK_NAME").Equals("ACTIVECONNECTION") Or _
                    tmpRow.Item("HCHK_NAME").Equals("CONNECTIONFAIL") Or _
                    tmpRow.Item("HCHK_NAME").Equals("LASTANALYZE") Or _
                    tmpRow.Item("HCHK_NAME").Equals("LASTVACUUM") Or _
                    tmpRow.Item("HCHK_NAME").Equals("HASTATUS") Or _
                    tmpRow.Item("HCHK_NAME").Equals("REPLICATION_SLOT") Or _
                    tmpRow.Item("HCHK_NAME").Equals("VIRTUAL_IP") Or _
                    tmpRow.Item("HCHK_NAME").Equals("LOCKCNT") Or tmpRow.Item("HCHK_NAME").Equals("TRAXIDLECNT") Or _
                    tmpRow.Item("HCHK_NAME").Equals("UNUSEDINDEX") Then
                    Dim tmpValue As Long = tmpRow.Item("VALUE")
                    strValue = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpValue)
                End If

                Dim strValueUnit As String = ""
                If tmpRow.Item("VALUE") <> 99999 Or _
                   tmpRow.Item("HCHK_NAME").Equals("HASTATUS") = False Or _
                   tmpRow.Item("HCHK_NAME").Equals("REPLICATION_SLOT") = False Or _
                   tmpRow.Item("HCHK_NAME").Equals("VIRTUAL_IP") = False Then
                    strValueUnit = tmpRow.Item("UNIT")
                End If
                Dim strShowValue As String = "{0}" + Environment.NewLine + "{1}" + Environment.NewLine + "{2}" + Environment.NewLine + "{3}{4}" + Environment.NewLine
                strShowValue = String.Format(strShowValue, strHost, strRegDt.ToString("yyyy-MM-dd HH:mm:ss"), strHchkNm, strValue, strValueUnit)

                While (dgvAlert.Rows.Count > 200)
                    dgvAlert.Rows.RemoveAt(dgvAlert.Rows.Count - 1)
                End While

                'Dim intAlertCnt As Integer = dgvAlert.Rows.Count - 1
                'Dim bExist As Boolean = False
                'For i As Integer = 0 To intAlertCnt
                '    If dgvAlert.Rows(i).Cells(coldgvAlertID.Index).Value = intInstanceID AndAlso _
                '       dgvAlert.Rows(i).Cells(coldgvAlertMsg.Index).Value.Equals(strShowValue) Then
                '        bExist = True
                '        Exit For
                '    End If
                'Next

                Dim tRow As DataGridViewRow = dgvAlert.FindFirstRow(strShowValue, coldgvAlertMsg.Index)
                If IsNothing(tRow) Or _
                     tRow IsNot Nothing AndAlso tRow.Cells(coldgvAlertID.Index).Value <> intInstanceID Then
                    Dim tempRow = New DataGridViewRow()
                    dgvAlert.Rows.Insert(0, tempRow)
                    dgvAlert.Rows(0).Cells(coldgvAlertID.Index).Value = intInstanceID
                    dgvAlert.Rows(0).Cells(coldgvAlertStatusVal.Index).Value = intHchkVal
                    dgvAlert.Rows(0).Cells(coldgvAlertHostname.Index).Value = strHost
                    dgvAlert.Rows(0).Cells(coldgvAlertMsg.Index).Value = strShowValue
                    dgvAlert.Rows(0).Cells(coldgvAlertCollectDt.Index).Value = strRegDt
                    dgvAlert.Rows(0).Cells(coldgvAlertHchkName.Index).Value = strHchkNm
                End If

                ' 컨트롤 색상 변경
                modCommon.sb_GridProgClrChg(dgvAlert, coldgvAlertStatusVal.Index, p_RageHealthClr)
                'For Each tempRow As DataGridViewRow In dgvAlert.Rows
                '    Dim tmpCellValue As Object = tempRow.Cells(coldgvAlertStatusVal.Index).Value
                '    'If IsNumeric(tmpCellValue) AndAlso tmpCellValue <= 200 Then
                '    tempRow.Cells(coldgvAlertHostname.Index).Style.ForeColor = Color.Green
                '    'End If
                'Next
                sb_GridSortChg(dgvAlert, coldgvAlertStatus.Index)


                If rbCurrent.Checked = True Then
                    Dim tCurrAlertRow As DataGridViewRow = dgvAlertCurr.FindFirstRow(strShowValue, coldgvAlertCurrMsg.Index)
                    If IsNothing(tCurrAlertRow) Or _
                         tRow IsNot Nothing AndAlso tRow.Cells(coldgvAlertCurrID.Index).Value <> intInstanceID Then
                        Dim tempRow = New DataGridViewRow()
                        dgvAlertCurr.Rows.Insert(0, tempRow)
                        dgvAlertCurr.Rows(0).Cells(coldgvAlertCurrID.Index).Value = intInstanceID
                        dgvAlertCurr.Rows(0).Cells(coldgvAlertCurrStatusVal.Index).Value = intHchkVal
                        dgvAlertCurr.Rows(0).Cells(coldgvAlertCurrHostname.Index).Value = strHost
                        dgvAlertCurr.Rows(0).Cells(coldgvAlertCurrMsg.Index).Value = strShowValue
                        dgvAlertCurr.Rows(0).Cells(coldgvAlertCurrCollectDt.Index).Value = strRegDt
                        dgvAlertCurr.Rows(0).Cells(coldgvAlertCurrHchkName.Index).Value = strHchkNm
                    End If

                    ' 컨트롤 색상 변경
                    modCommon.sb_GridProgClrChg(dgvAlertCurr, coldgvAlertCurrStatusVal.Index, p_RageHealthClr)
                    sb_GridSortChg(dgvAlertCurr, coldgvAlertCurrStatus.Index)
                End If
            Next

            Dim intAlertCount As Integer = dgvAlert.Rows.Count
            Dim RemoveDt As Date = Now
            RemoveDt = RemoveDt.AddMinutes(-120)
            For i As Integer = intAlertCount - 1 To 0 Step -1
                Dim AlertDt As Date = dgvAlert.Rows(i).Cells(coldgvAlertCollectDt.Index).Value
                If RemoveDt >= AlertDt Then
                    dgvAlert.Rows.RemoveAt(i)
                End If
            Next
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub



    Private Sub SetGrpWarning(ByVal arrLst As SortedList)

        For Each tmpOpt As Control In tlpCurrent.Controls
            If tmpOpt.GetType.Equals(GetType(BaseControls.RadioButton)) AndAlso tmpOpt.Visible = True Then
                Dim rdBtn As BaseControls.RadioButton = tmpOpt
                Dim grpInfos As GroupInfo = rdBtn.Tag
                Dim BretWarning As Boolean = False
                For Each tmpGrpinfo As GroupInfo.ServerInfo In grpInfos.Items
                    If arrLst.Item(tmpGrpinfo.InstanceID) IsNot Nothing Then
                        BretWarning = True
                        rdBtn.Warning = True
                        Exit For
                    End If
                Next
                If BretWarning = False Then
                    rdBtn.Warning = False
                End If

            End If
        Next

    End Sub







    Private Sub initControls(ByVal AgentStat As clsCollect.AgntState)
        Try

            lblAgentSvrState.Text = TryCast(p_clsAgentCollect.AgentState.GetType().GetMember(p_clsAgentCollect.AgentState.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description

            If AgentStat = clsCollect.AgntState.Activate Then
                lblAgentSvrState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                radCpu.UseAnimation = True
                radMem.UseAnimation = True
            Else
                lblAgentSvrState.ForeColor = Color.OrangeRed
                ' Group Stop 
                'For Each tmpCtl As eXperDB.BaseControls.RadioButton In tlpGroup.Controls
                '    tmpCtl.Warning = False
                'Next

                ' CPU STOP 
                radCpu.UseAnimation = False
                For Each tmpItm As RaiderItem In radCpu.items
                    tmpItm.Value = 0

                Next

                For Each tmpRow As DataGridViewRow In dgvGrpCpuSvrLst.Rows
                    tmpRow.Cells(colGrpCpuSvrProg.Index).Value = 0
                    tmpRow.Cells(colGrpCpuSvrUsage.Index).Value = 0
                    tmpRow.DefaultCellStyle.ForeColor = Color.DarkGray
                    tmpRow.DefaultCellStyle.SelectionForeColor = Color.DarkGray
                Next
                ' MEM STOP 
                radMem.UseAnimation = False

                For Each tmpitm As RaiderItem In radMem.items
                    tmpitm.Value = 0
                Next

                For Each tmpRow As DataGridViewRow In dgvGrpMemSvrLst.Rows
                    tmpRow.Cells(colGrpMemSvrprog.Index).Value = 0
                    tmpRow.Cells(colGrpMemSvrUsage.Index).Value = 0
                    tmpRow.DefaultCellStyle.ForeColor = Color.DarkGray
                    tmpRow.DefaultCellStyle.SelectionForeColor = Color.DarkGray
                Next

                ' HEAL COUNT STOP 
                dgtNumN.Value = 0
                dgtNumW.Value = 0
                dgtNumC.Value = 0


                For Each tmpCtl As Progress3D In flpInstance.Controls
                    tmpCtl.Value = 0
                Next
                ' GRID CLEAR 
                While (dgvGrpDiskAccess.Rows.Count > 1)
                    dgvGrpDiskAccess.Rows.RemoveAt(0)
                End While
                dgvGrpDiskAccess.Rows.Clear()
                While (dgvGrpDiskUsage.Rows.Count > 1)
                    dgvGrpDiskUsage.Rows.RemoveAt(0)
                End While
                dgvGrpDiskUsage.Rows.Clear()
                While (dgvSessionInfo.Rows.Count > 1)
                    dgvSessionInfo.Rows.RemoveAt(0)
                End While
                dgvSessionInfo.DataSource = Nothing
                ' Remove 0202
                'While (dgvReqInfo.Rows.Count > 1)
                '    dgvReqInfo.Rows.RemoveAt(0)
                'End While
                'dgvReqInfo.Rows.Clear()
                'While (dgvHealth.Rows.Count > 1)
                '    dgvHealth.Rows.RemoveAt(0)
                'End While
                'dgvHealth.Rows.Clear()

                ' CHART CLEAR 

                For Each tmpSeries As DataVisualization.Charting.Series In Me.chrReqInfo.Series
                    For Each tmpPt As DataVisualization.Charting.DataPoint In tmpSeries.Points
                        tmpPt.SetValueY(0)
                    Next
                Next


                Me.chrReqInfo.ChartAreas(0).RecalculateAxesScale()





            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try

    End Sub


#End Region

    Private Sub dgvSessionInfo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessionInfo.CellDoubleClick
        If dgvSessionInfo.RowCount <= 0 Then Return
        If e.RowIndex >= 0 Then
            Dim frmQuery As New frmQueryView(_AgentCn, dgvSessionInfo.Rows(e.RowIndex).Cells(colDgvSessionInfoSQL.Index).Value, dgvSessionInfo.Rows(e.RowIndex).Cells(colDgvSessionInfoDBNm.Index).Value, dgvSessionInfo.Rows(e.RowIndex).Cells(colDgvSessionInfoUser.Index).Value, dgvSessionInfo.Rows(e.RowIndex).Cells(colDgvSessionInfoInstID.Index).Value, _AgentInfo)
            frmQuery.ShowDialog(Me)
        End If
    End Sub

    Private Sub mnuReports_Click(sender As Object, e As EventArgs) Handles mnuReports.Click
        Dim frmReport As New frmReports(_AgentCn, _GrpList, _AgentInfo)

        frmReport.Show(Me)


    End Sub

    Public Sub DgvRowHeightFill_old(ByVal ctlDgv As BaseControls.DataGridView)

        Dim height As Integer = Math.Ceiling((ctlDgv.Height - ctlDgv.ColumnHeadersHeight - 2) / ctlDgv.Rows.Count) - 1


        For Each tmpRow As DataGridViewRow In ctlDgv.Rows
            tmpRow.Height = height
        Next
    End Sub


    Public Sub DgvRowHeightFill(ByVal ctlDgv As BaseControls.DataGridView, Optional rowCount As Integer = 0)
        Dim height As Integer = 0
        Dim intRowCount As Integer = rowCount
        If intRowCount = 0 Then
            intRowCount = _GrpListServerinfo.Count
        End If
        If intRowCount <= 20 Then
            height = Math.Ceiling((ctlDgv.Height - ctlDgv.ColumnHeadersHeight - 2) / ctlDgv.Rows.Count) - 1
        Else
            height = 16
        End If
        Dim index As Integer = 0
        For Each tmpRow As DataGridViewRow In ctlDgv.Rows
            tmpRow.Height = height
            'If index < 20 Then
            '    tmpRow.Height = height
            '    tmpRow.Visible = True
            'Else
            '    tmpRow.Height = height
            '    tmpRow.Visible = False
            'End If
            index += 1
        Next
    End Sub

    Private Sub DataGridView_SizeChanged(sender As Object, e As EventArgs)
        Dim ctlDgv As BaseControls.DataGridView = DirectCast(sender, BaseControls.DataGridView)
        If ctlDgv.IsHandleCreated Then
            DgvRowHeightFill(sender)
        End If


    End Sub

    'Private Sub flpInstance_SizeChanged(sender As Object, e As EventArgs) Handles flpInstance.SizeChanged
    '    Dim BaseCTl As BaseControls.FlowLayoutPanel = sender
    '    Dim ctlWidth As Integer = (BaseCTl.Width - (2 * 2) - IIf(BaseCTl.VerticalScroll.Visible, 20, 0))
    '    Dim ctlHeight As Integer = (BaseCTl.Height - (2 * 12)) / 12 - 1 'add vertical margin

    '    For Each tmpCtl As Progress3D In BaseCTl.Controls
    '        tmpCtl.Width = ctlWidth
    '        tmpCtl.Height = ctlHeight
    '        tmpCtl.Margin = New System.Windows.Forms.Padding(1)
    '    Next


    'End Sub


    Private Sub nudBackendcnt_ValueChanged(sender As Object, e As EventArgs) Handles nudBackendcnt.ValueChanged
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("FORM", "SESSIONMAIN", DirectCast(sender, BaseControls.NumericUpDown).Value)


    End Sub

    Private Sub chkIDLE_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDLE.CheckedChanged
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("FORM", "IDLEMAIN", chkIDLE.Checked)
    End Sub

    Private Sub chrReqInfo_GetToolTipText(sender As Object, e As DataVisualization.Charting.ToolTipEventArgs) Handles chrReqInfo.GetToolTipText


        Select Case e.HitTestResult.ChartElementType
            Case DataVisualization.Charting.ChartElementType.Axis, DataVisualization.Charting.ChartElementType.TickMarks
                'Dim result As DataVisualization.Charting.HitTestResult = chrReqInfo.HitTest(e.X, e.Y, DataVisualization.Charting.ChartElementType.DataPoint)
                'If result.ChartElementType = DataVisualization.Charting.ChartElementType.DataPoint Then
                '    e.Text = result.Series.Points(result.PointIndex).AxisLabel & vbCrLf & result.Series.Name & vbCrLf & result.Series.Points(result.PointIndex).XValue.ToString & " : " & result.Series.Points(result.PointIndex).YValues(0).ToString
                'End If

                'Exit Select

            Case DataVisualization.Charting.ChartElementType.AxisLabels

                If e.HitTestResult.Object.GetType.Equals(GetType(DataVisualization.Charting.CustomLabel)) Then
                    e.Text = DirectCast(e.HitTestResult.Object, DataVisualization.Charting.CustomLabel).Text
                End If


            Case DataVisualization.Charting.ChartElementType.DataPoint
                If e.HitTestResult.Object.GetType.Equals(GetType(DataVisualization.Charting.DataPoint)) Then
                    Dim tmpDtp As DataVisualization.Charting.DataPoint = DirectCast(e.HitTestResult.Object, DataVisualization.Charting.DataPoint)
                    ' 메모리 공유 문제 인듯 디버그 시 보이나 ToString 사용하지 않으면 값이 나오지 않음 
                    Dim strServer As String = tmpDtp.AxisLabel.ToString

                    e.Text = String.Format("[{0}]{1}{2} : {3}", strServer, vbCrLf, e.HitTestResult.Series.Name, tmpDtp.YValues(0).ToString("N0"))
                End If


        End Select

    End Sub


    Private Sub chtSessionStatus_GetToolTipText(sender As Object, e As DataVisualization.Charting.ToolTipEventArgs) Handles chtSessionStatus.GetToolTipText, chtCPUStatus.GetToolTipText, chtMEMStatus.GetToolTipText
        Select Case e.HitTestResult.ChartElementType
            Case DataVisualization.Charting.ChartElementType.Axis, DataVisualization.Charting.ChartElementType.TickMarks
            Case DataVisualization.Charting.ChartElementType.AxisLabels
                If e.HitTestResult.Object.GetType.Equals(GetType(DataVisualization.Charting.CustomLabel)) Then
                    e.Text = DirectCast(e.HitTestResult.Object, DataVisualization.Charting.CustomLabel).Text
                End If
            Case DataVisualization.Charting.ChartElementType.DataPoint
                If e.HitTestResult.Object.GetType.Equals(GetType(DataVisualization.Charting.DataPoint)) Then
                    Dim tmpDtp As DataVisualization.Charting.DataPoint = DirectCast(e.HitTestResult.Object, DataVisualization.Charting.DataPoint)
                    ' 메모리 공유 문제 인듯 디버그 시 보이나 ToString 사용하지 않으면 값이 나오지 않음 
                    Dim strServer As String = tmpDtp.AxisLabel.ToString
                    e.Text = String.Format("[{0}]{1}{2} : {3}", strServer, vbCrLf, e.HitTestResult.Series.Name, tmpDtp.YValues(0).ToString("N0"))
                End If
        End Select
    End Sub


    'Private Sub tm_Serial_Tick(sender As Object, e As EventArgs)
    '    tm_Serial.Stop()
    '    Try


    '        Dim clsQry As New clsQuerys(_AgentCn)
    '        Dim dtTable As DataTable = clsQry.SelectSerialKey()
    '        If dtTable IsNot Nothing Then
    '            Dim dtRow As DataRow = dtTable.Rows(0)
    '            Dim strLicData As String = dtRow.Item("LICDATA")
    '            Dim CurDate As Date = dtRow.Item("CURDATETIME")
    '            Dim tmpStruct As New License(strLicData, "WebCash9")
    '            If tmpStruct.ExpireDate.Equals(DateTime.MinValue) Then
    '                MsgBox(p_clsMsgData.fn_GetData("M020"))
    '            Else
    '                Dim intDay As Integer = DateDiff(DateInterval.Day, CurDate, tmpStruct.ExpireDate)
    '                If intDay < 30 Then
    '                    MsgBox(p_clsMsgData.fn_GetData("M019", intDay))

    '                End If
    '            End If

    '        End If
    '    Catch ex As Exception
    '    Finally
    '        tm_Serial.Start()

    '    End Try



    'End Sub
#If 1 Then
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
                 (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr

    Private Const WM_LBUTTONDOWN As Long = &H201

    Private Sub dgvGrpCpuSvrLst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpCpuSvrLst.CellContentClick
        'If e.RowIndex >= 0 And e.RowIndex < flpInstance.Controls.Count Then
        '    For Each tmpCtl As Progress3D In flpInstance.Controls
        '        If dgvGrpCpuSvrLst.Rows(e.RowIndex).Cells(0).Value = tmpCtl.Tag.InstanceID Then
        '            SendMessage(tmpCtl.Handle.ToInt32, WM_LBUTTONDOWN, 1&, 0)
        '            Exit For
        '        End If
        '    Next
        'End If
        If e.RowIndex >= 0 And e.RowIndex < dgvClusters.Rows.Count Then
            For Each tmpRow As DataGridViewRow In dgvClusters.Rows
                If dgvGrpCpuSvrLst.Rows(e.RowIndex).Cells(0).Value = TryCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID Then
                    openMonDetail(tmpRow.Index)
                    Exit For
                End If
            Next
        End If
    End Sub
#End If

    Private Sub dgvGrpCpuSvrLst_CellMouseMove(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGrpCpuSvrLst.CellMouseMove
        If e.RowIndex >= 0 Then
            dgvGrpCpuSvrLst.Cursor = Cursors.Hand
            If dgvGrpCpuSvrLst.Rows(e.RowIndex).Selected = False Then
                dgvGrpCpuSvrLst.ClearSelection()
                dgvGrpCpuSvrLst.Rows(e.RowIndex).Selected = True
            End If
            dgvGrpCpuSvrLst.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Gulim", 9, FontStyle.Bold)
        End If
    End Sub

    Private Sub dgvGrpCpuSvrLst_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrpCpuSvrLst.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgvGrpCpuSvrLst.Cursor = Cursors.Arrow
            If dgvGrpCpuSvrLst.Rows(e.RowIndex).Selected = True Then
                dgvGrpCpuSvrLst.ClearSelection()
                dgvGrpCpuSvrLst.Rows(e.RowIndex).Selected = False
            End If
            dgvGrpCpuSvrLst.Rows(e.RowIndex).DefaultCellStyle.Font = dgvGrpCpuSvrLst.DefaultCellStyle.Font
        End If
    End Sub

    Private Sub dgvGrpMemSvrLst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpMemSvrLst.CellContentClick
        'If e.RowIndex >= 0 And e.RowIndex < flpInstance.Controls.Count Then
        '    For Each tmpCtl As Progress3D In flpInstance.Controls
        '        If dgvGrpMemSvrLst.Rows(e.RowIndex).Cells(0).Value = tmpCtl.Tag.InstanceID Then
        '            SendMessage(tmpCtl.Handle.ToInt32, WM_LBUTTONDOWN, 1&, 0)
        '            Exit For
        '        End If
        '    Next
        'End If

        If e.RowIndex >= 0 And e.RowIndex < dgvClusters.Rows.Count Then
            For Each tmpRow As DataGridViewRow In dgvClusters.Rows
                If dgvGrpMemSvrLst.Rows(e.RowIndex).Cells(0).Value = TryCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID Then
                    openMonDetail(tmpRow.Index)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub dgvGrpMemSvrLst_CellMouseMove(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGrpMemSvrLst.CellMouseMove
        If e.RowIndex >= 0 Then
            dgvGrpMemSvrLst.Cursor = Cursors.Hand
            If dgvGrpMemSvrLst.Rows(e.RowIndex).Selected = False Then
                dgvGrpMemSvrLst.ClearSelection()
                dgvGrpMemSvrLst.Rows(e.RowIndex).Selected = True
            End If
            For i As Integer = 0 To dgvGrpMemSvrLst.ColumnCount - 1
                dgvGrpMemSvrLst.Rows(e.RowIndex).Cells(i).Style.Font = New Font("Gulim", 9, FontStyle.Bold)

            Next
        End If
    End Sub

    Private Sub dgvGrpMemSvrLst_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrpMemSvrLst.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgvGrpMemSvrLst.Cursor = Cursors.Arrow
            If dgvGrpMemSvrLst.Rows(e.RowIndex).Selected = True Then
                dgvGrpMemSvrLst.ClearSelection()
                dgvGrpMemSvrLst.Rows(e.RowIndex).Selected = False
            End If
            For i As Integer = 0 To dgvGrpMemSvrLst.ColumnCount - 1
                dgvGrpMemSvrLst.Rows(e.RowIndex).Cells(i).Style.Font = dgvGrpMemSvrLst.DefaultCellStyle.Font
            Next
        End If
    End Sub

#Region "Ctl "
    ''' <summary>
    ''' Chart Point 등록 
    ''' </summary>
    ''' <param name="MSChart"></param>
    ''' <param name="strSeries"></param>
    ''' <param name="dblX"></param>
    ''' <param name="dblY"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function sb_ChartAddPoint(ByVal MSChart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal dblX As Double, ByVal dblY As Double) As Integer
        Try

            If MSChart.Series(strSeries).Points.Count > 0 AndAlso MSChart.Series(strSeries).Points(MSChart.Series(strSeries).Points.Count - 1).XValue >= dblX Then
                Return MSChart.Series(strSeries).Points.Count
            End If

            Dim rtnValue As Integer = MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), dblY)

            Dim NowCnt As Integer = MSChart.Series(strSeries).Points.Count

            'Do While CDate(Now.AddMinutes(-6)).ToOADate > MSChart.Series(strSeries).Points.First.XValue
            '    MSChart.Series(strSeries).Points.RemoveAt(0)
            '    If MSChart.Series(strSeries).Points.Count <= 0 Then
            '        Exit Do
            '    End If
            'Loop


            'If NowCnt >= _ElapseCount Then '5분간 유지 10분 200
            '    For i As Integer = 0 To NowCnt - _ElapseCount
            '        MSChart.Series(strSeries).Points.RemoveAt(0)
            '    Next
            'End If
            Return rtnValue
        Catch ex As Exception
            Return -1
        Finally
        End Try
    End Function

    Private Sub sb_ChartAlignYAxies(ByVal MSChart As DataVisualization.Charting.Chart)
        Dim dblMaxPri As Double = 0
        Dim dblMaxSec As Double = 0
        For Each tmpSeries As DataVisualization.Charting.Series In MSChart.Series
            If tmpSeries.Points.Count > 0 Then
                If tmpSeries.YAxisType = DataVisualization.Charting.AxisType.Primary Then
                    Dim tmpValue As Double = Double.NaN
                    tmpValue = tmpSeries.Points.FindMaxByValue().YValues(0)
                    dblMaxPri = Math.Max(dblMaxPri, IIf(tmpValue.Equals(Double.NaN), 0, tmpValue))
                Else
                    Dim tmpValue As Double = Double.NaN
                    tmpValue = tmpSeries.Points.FindMaxByValue().YValues(0)
                    dblMaxSec = Math.Max(dblMaxSec, IIf(tmpValue.Equals(Double.NaN), 0, tmpValue))
                End If
            End If
        Next

        If Not dblMaxPri.Equals(Double.NaN) Then
            Dim intValuePri As Integer = dblMaxPri \ 5
            intValuePri += 1

            MSChart.ChartAreas(0).AxisY.Maximum = intValuePri * 5
            MSChart.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            MSChart.ChartAreas(0).AxisY.Interval = MSChart.ChartAreas(0).AxisY.Maximum / 5
        End If

        If Not dblMaxSec.Equals(Double.NaN) Then

            Dim intValueSec As Integer = dblMaxSec \ 5
            MSChart.ChartAreas(0).AxisY2.Maximum = intValueSec * 5
            MSChart.ChartAreas(0).AxisY2.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            MSChart.ChartAreas(0).AxisY2.Interval = MSChart.ChartAreas(0).AxisY2.Maximum / 5
        End If
        MSChart.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Private Sub sb_ChartAlignYAxiesWithUnit(ByVal MSChart As DataVisualization.Charting.Chart)

        Dim dblMaxPri As Double = 0
        Dim dblMaxSec As Double = 0
        For Each tmpSeries As DataVisualization.Charting.Series In MSChart.Series
            If tmpSeries.Points.Count > 0 Then
                If tmpSeries.YAxisType = DataVisualization.Charting.AxisType.Primary Then
                    Dim tmpValue As Double = Double.NaN
                    tmpValue = tmpSeries.Points.FindMaxByValue().YValues(0)
                    dblMaxPri = Math.Max(dblMaxPri, IIf(tmpValue.Equals(Double.NaN), 0, tmpValue))

                Else
                    Dim tmpValue As Double = Double.NaN
                    tmpValue = tmpSeries.Points.FindMaxByValue().YValues(0)
                    dblMaxSec = Math.Max(dblMaxSec, IIf(tmpValue.Equals(Double.NaN), 0, tmpValue))
                End If
            End If
        Next

        If Not dblMaxPri.Equals(Double.NaN) Then
            Dim intValuePri As Integer = dblMaxPri \ 5
            intValuePri += 1
            MSChart.ChartAreas(0).AxisY.Maximum = intValuePri * 5
            MSChart.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            MSChart.ChartAreas(0).AxisY.Interval = MSChart.ChartAreas(0).AxisY.Maximum / 5
        End If

        If Not dblMaxSec.Equals(Double.NaN) Then

            Dim intValueSec As Integer = dblMaxSec \ 5

            MSChart.ChartAreas(0).AxisY2.Maximum = intValueSec * 5
            MSChart.ChartAreas(0).AxisY2.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            MSChart.ChartAreas(0).AxisY2.Interval = MSChart.ChartAreas(0).AxisY2.Maximum / 5
        End If

        If dblMaxPri <= 10 AndAlso dblMaxSec <= 10 Then
            MSChart.ChartAreas(0).AxisY.LabelStyle.Format = "F2"
        Else
            MSChart.ChartAreas(0).AxisY.LabelStyle.Format = "N0"
        End If

        MSChart.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Public Sub AddSeries(ByVal chtName As System.Windows.Forms.DataVisualization.Charting.Chart,
                         ByVal SeriesName As String,
                         ByVal strTitle As String,
                         Optional ByVal LineColor As System.Drawing.Color = Nothing,
                         Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line)
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = chtName.Series.Add(SeriesName.ToUpper)
        Series.BorderWidth = 2
        Series.ChartArea = "ChartArea1"
        Series.ChartType = ChartType
        'Series.Legend = "Legend1"
        Series.Name = SeriesName
        Series.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        'Series.IsXValueIndexed = True
        'Series.CustomProperties = "EmptyPointValue=Zero"

        If Not IsNothing(LineColor) Then
            Series.Color = LineColor
        End If


        'Series.BorderWidth = 2
        'Series.ChartArea = "ChartArea1"
        'Series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        'Series.Color = System.Drawing.Color.Orange
        'Series.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        'Series.Legend = "Legend1"
        'Series.Name = "UPDATE"
        'Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
    End Sub
#End Region

    Private Sub dgvAlert_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlert.CellClick

        If e.RowIndex >= 0 Then
            Dim InstanceID = dgvAlert.Rows(e.RowIndex).Cells(coldgvAlertID.Index).Value
            Dim strCollectDt = dgvAlert.Rows(e.RowIndex).Cells(coldgvAlertCollectDt.Index).Value
            Dim AlertLevel = dgvAlert.Rows(e.RowIndex).Cells(coldgvAlertStatusVal.Index).Value
            Dim tmpSvr As GroupInfo.ServerInfo = Nothing
            Dim BretFrm As frmAlertList = Nothing

            For Each tmpSvr In _GrpListServerinfo
                If tmpSvr.InstanceID = InstanceID Then Exit For
            Next

            For Each tmpFrm As Form In My.Application.OpenForms
                Dim frmDtl As frmAlertList = TryCast(tmpFrm, frmAlertList)
                If frmDtl IsNot Nothing Then
                    BretFrm = tmpFrm
                    Exit For
                End If
            Next

            If BretFrm Is Nothing Then
                BretFrm = New frmAlertList(_GrpListServerinfo, AgentInfo, _AgentCn, InstanceID, AlertLevel, strCollectDt)
                BretFrm.OwnerForm = Me
                BretFrm.Show()
            Else
                BretFrm.Activate()
            End If
        End If
    End Sub


    Private Sub dgvAlertCurr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlertCurr.CellClick

        If e.RowIndex >= 0 Then
            Dim InstanceID = dgvAlertCurr.Rows(e.RowIndex).Cells(coldgvAlertCurrID.Index).Value
            Dim strCollectDt = dgvAlertCurr.Rows(e.RowIndex).Cells(coldgvAlertCurrCollectDt.Index).Value
            Dim AlertLevel = dgvAlertCurr.Rows(e.RowIndex).Cells(coldgvAlertCurrStatusVal.Index).Value
            Dim tmpSvr As GroupInfo.ServerInfo = Nothing
            Dim BretFrm As frmAlertList = Nothing

            For Each tmpSvr In _GrpListServerinfo
                If tmpSvr.InstanceID = InstanceID Then Exit For
            Next

            For Each tmpFrm As Form In My.Application.OpenForms
                Dim frmDtl As frmAlertList = TryCast(tmpFrm, frmAlertList)
                If frmDtl IsNot Nothing Then
                    BretFrm = tmpFrm
                    Exit For
                End If
            Next

            If BretFrm Is Nothing Then
                BretFrm = New frmAlertList(_GrpListServerinfo, AgentInfo, _AgentCn, InstanceID, AlertLevel, strCollectDt)
                BretFrm.OwnerForm = Me
                BretFrm.Show()
            Else
                BretFrm.Activate()
            End If
        End If
    End Sub

    Private Sub cmbLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevel.SelectedIndexChanged
        If cmbLevel.SelectedIndex = 0 Then
            Dim RowCount As Integer = dgvAlert.Rows.Count - 1
            If RowCount >= 0 Then
                For i As Integer = RowCount To 0 Step -1
                    If dgvAlert.Rows(i).Cells(coldgvAlertStatusVal.Index).Value <= 200 Then
                        dgvAlert.Rows.RemoveAt(i)
                    End If
                Next
            End If
        End If
        _SelectedAlertLevel = cmbLevel.SelectedIndex
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Me._isPower = Not _isPower
        Try
            If _isPower = True Then
                p_clsAgentCollect.Start(_AgentCn, _ElapseInterval, p_ShowName)
                tmCollect.Start()
                btnPower.Image = eXperDB.Monitoring.My.Resources.power_hib
            Else
                tmCollect.Stop()
                p_clsAgentCollect.Stop()
                btnPower.Image = eXperDB.Monitoring.My.Resources.power_sus
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnCritical_Click(sender As Object, e As EventArgs) Handles btnCritical.Click
        Me.ShowCritical = Not Me.ShowCritical
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        If Me.isLock = False Then

            Dim bOpenChildForm As Boolean = False
            For Each tmpFrm As Form In My.Application.OpenForms
                If TryCast(tmpFrm, frmMonDetail) IsNot Nothing Or _
                 TryCast(tmpFrm, frmLogView) IsNot Nothing Or _
                 TryCast(tmpFrm, frmHealthDetail) IsNot Nothing Or _
                 TryCast(tmpFrm, frmMonActInfo) IsNot Nothing Or _
                 TryCast(tmpFrm, frmQueryView) IsNot Nothing Or _
                 TryCast(tmpFrm, frmSessionLock) IsNot Nothing Or _
                 TryCast(tmpFrm, frmSessionLockHist) IsNot Nothing Then
                    bOpenChildForm = True
                    Exit For
                End If
            Next

            If bOpenChildForm = True Then
                If MsgBox(p_clsMsgData.fn_GetData("M040"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) <> frmMsgbox.MsgBoxResult.Yes Then
                    Return
                Else
                    Dim arrFrms As New ArrayList
                    For Each tmpFrm As Form In Application.OpenForms
                        If TryCast(tmpFrm, frmCritical) IsNot Nothing Or _
                           TryCast(tmpFrm, frmSvrList) IsNot Nothing Or _
                           TryCast(tmpFrm, frmAlertList) IsNot Nothing Or _
                           TryCast(tmpFrm, frmMonMain) IsNot Nothing Then
                        Else
                            arrFrms.Add(tmpFrm)
                        End If
                    Next

                    For Each tmpFrm As Form In arrFrms
                        tmpFrm.Close()
                    Next
                End If
            End If
            Me.isLock = True
        Else
            If fn_FormisLock(Me, _AgentCn, True) = True Then
                Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
                MsgBox(strMsg)
            End If
        End If
    End Sub


    Private Sub btnAlertConfig_Click(sender As Object, e As EventArgs) Handles btnAlertConfig.Click
        Dim AlertConfig As New frmAlertConfig(GrpListServerinfo)
        AlertConfig.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim frmReport As New frmReports(_AgentCn, _GrpList, _AgentInfo)
        frmReport.Show(Me)
    End Sub

#Region "Warning"
    ''' <summary>
    ''' 경고 메시지 공통 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub sb_CriticalShow(ByVal svrLst As SortedList)
        Dim arrFrms As New ArrayList
        Dim hstWarning As New Hashtable
        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmCritical) IsNot Nothing AndAlso hstWarning.Item(DirectCast(tmpFrm, frmCritical).Tag.ToString) Is Nothing Then
                hstWarning.Add(DirectCast(tmpFrm, frmCritical).Tag.ToString, DirectCast(tmpFrm, frmCritical).Tag.ToString)
            End If
        Next

        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmMonMain) IsNot Nothing Then
                If hstWarning.Item(tmpFrm.Handle.ToString) Is Nothing Then
                    Dim strSvrLst As String = ""
                    If tmpFrm.GetType.Equals(GetType(frmMonMain)) Then
                        For Each tmpStr As String In svrLst.Values
                            If strSvrLst = "" Then
                                strSvrLst = tmpStr
                            Else
                                strSvrLst += " , " & tmpStr
                            End If
                        Next
                    ElseIf tmpFrm.GetType.Equals(GetType(frmMonDetail)) Then
                        If svrLst.Item(DirectCast(tmpFrm, frmMonDetail).InstanceID) IsNot Nothing Then
                            strSvrLst = svrLst.Item(DirectCast(tmpFrm, frmMonDetail).InstanceID)
                        End If

                    ElseIf tmpFrm.GetType.Equals(GetType(frmMonActInfo)) Then
                        If svrLst.Item(DirectCast(tmpFrm, frmMonActInfo).InstanceID) IsNot Nothing Then
                            strSvrLst = svrLst.Item(DirectCast(tmpFrm, frmMonActInfo).InstanceID)
                        End If
                    End If
                    If strSvrLst <> "" Then
                        Dim A As New frmCritical(strSvrLst)
                        A.Location = tmpFrm.Location
                        A.StartPosition = FormStartPosition.Manual
                        A.Size = tmpFrm.Size
                        A.Tag = tmpFrm.Handle.ToString
                        arrFrms.Add(A)
                    End If
                End If

            End If
        Next

        For Each tmpFrm As frmCritical In arrFrms
            Dim sc As Screen = Screen.FromPoint(tmpFrm.Location)
            tmpFrm.Show()
        Next

    End Sub

    Public Sub sb_CriticalClose()
        Dim arrFrms As New ArrayList
        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmCritical) IsNot Nothing Then
                arrFrms.Add(tmpFrm)
            End If
        Next

        For Each tmpFrm As frmCritical In arrFrms
            tmpFrm.Close()
        Next


    End Sub

#End Region

#Region "lock"
    Private _isLock As Boolean = False
    Property isLock As Boolean
        Get
            Return Me._isLock
        End Get
        Set(value As Boolean)
            Me._isLock = value
            If value.Equals(True) Then
                tmLock.Enabled = False
                btnLock.Image = eXperDB.Monitoring.My.Resources.lock_on
            Else
                tmLock.Enabled = True
                btnLock.Image = eXperDB.Monitoring.My.Resources.lock_off
            End If
        End Set
    End Property
    Public Function fn_FormisLock(ByVal frm As Form, ByVal odbcCN As eXperDB.ODBC.eXperDBODBC, Optional ByVal isSet As Boolean = False) As Boolean
        If Me.isLock Then
            Dim frmPw As New frmPassword(odbcCN)
            If frmPw.ShowDialog <> Windows.Forms.DialogResult.OK Then
                Return True
            Else
                If isSet = True Then
                    Me.isLock = False
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub tmLock_Tick(sender As Object, e As EventArgs) Handles tmLock.Tick
        If Me.isLock.Equals(False) Then
            Me.isLock = True
        End If
        tmLock.Enabled = False
    End Sub
#End Region

    Private Sub rbCurrent_CheckedChanged(sender As Object, e As EventArgs) Handles rbCurrent.CheckedChanged, rbHistory.CheckedChanged
        Dim rbTemp As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If rbTemp.Name = "rbCurrent" Then
            If rbTemp.Checked = True Then
                Dim clsIni As New Common.IniFile(p_AppConfigIni)
                clsIni.WriteValue("FORM", "ALERTLISTTYPE", "rbCurrent")
                dgvAlertCurr.Visible = True
                dgvAlert.Visible = False
            Else
                dgvAlertCurr.Visible = False
                dgvAlert.Visible = True
            End If
        Else
            If rbTemp.Checked = True Then
                Dim clsIni As New Common.IniFile(p_AppConfigIni)
                clsIni.WriteValue("FORM", "ALERTLISTTYPE", "rbHistory")
                dgvAlertCurr.Visible = False
                dgvAlert.Visible = True
            Else
                dgvAlertCurr.Visible = True
                dgvAlert.Visible = False
            End If
        End If
    End Sub

    Private Sub bckmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bckmanual.DoWork
        getinitDataSessionStatsInfo(_GrpListServerinfo)
        getinitDataCpu(_GrpListServerinfo)
        getinitDataLogical(_GrpListServerinfo)
        getinitDataLock(_GrpListServerinfo)
        getinitDataTPS(_GrpListServerinfo)
        getinitDataSQLResp(_GrpListServerinfo)
        bckmanual.ReportProgress(100)
    End Sub

    Private Sub bckmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bckmanual.ProgressChanged

    End Sub

    Private Sub bckmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bckmanual.RunWorkerCompleted
        If e.Cancelled = False Then
            If _dtTableSessionStatus IsNot Nothing Then
                drawDataSessionStatsInfo(_GrpListServerinfo)
            End If
            If _dtTableCpu IsNot Nothing Then
                drawDataCpu(_GrpListServerinfo)
            End If
            If _dtTableLogical IsNot Nothing Then
                drawDataLogical(_GrpListServerinfo)
            End If
            If _dtTableLock IsNot Nothing Then
                drawDataLock(_GrpListServerinfo)
            End If
            If _dtTableTPS IsNot Nothing Then
                drawDataTPS(_GrpListServerinfo)
            End If
            If _dtTableSQLResp IsNot Nothing Then
                drawDataSQLResp(_GrpListServerinfo)
            End If
            _isDrawInitialData = 0
        End If
    End Sub

    Private Sub grpAlert_Click(sender As Object, e As EventArgs) Handles grpAlert.Click
        Dim BretFrm As frmAlertList = Nothing

        For Each tmpFrm As Form In My.Application.OpenForms
            Dim frmDtl As frmAlertList = TryCast(tmpFrm, frmAlertList)
            If frmDtl IsNot Nothing Then
                BretFrm = tmpFrm
                Exit For
            End If
        Next

        If BretFrm Is Nothing Then
            BretFrm = New frmAlertList(_GrpListServerinfo, AgentInfo, _AgentCn, 0, 0, Now)
            BretFrm.OwnerForm = Me
            BretFrm.Show()
        Else
            BretFrm.Activate()
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''< Trend 20180918 Start>'''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btnCPUUtil_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCPUUtil.MouseClick, _
                                                                                     btnCPUWait.MouseClick, _
                                                                                     btnMEMUsage.MouseClick, _
                                                                                     btnSessionActive.MouseClick, _
                                                                                     btnSessionTotal.MouseClick, _
                                                                                     btnLogicalRead.MouseClick, _
                                                                                     btnLogicalWrite.MouseClick, _
                                                                                     btnLockWait.MouseClick, _
                                                                                     btnTPSTotal.MouseClick, _
                                                                                     btnTPSCommit.MouseClick, _
                                                                                     btnTPSRollback.MouseClick, _
                                                                                     btnSQLRespTmMAX.MouseClick, _
                                                                                     btnSQLRespTmAVG.MouseClick, _
                                                                                     btnReplicationDelay.MouseClick, _
                                                                                     btnReplicationDelaySize.MouseClick
        Dim lblTemp = DirectCast(sender, System.Windows.Forms.Button)

        ' dilplaying menu image
        For i As Integer = 0 To mnuChart.Items.Count - 1
            Dim tlpSub = DirectCast(mnuChart.Items(i).Tag, System.Windows.Forms.TableLayoutPanel)
            If tlpSub.Visible = True Then
                mnuChart.Items(i).Image = monTypeImgLst.Images(2)
            Else
                mnuChart.Items(i).Image = Nothing
            End If
        Next

        mnuChart.Show(lblTemp, lblTemp.PointToClient(Cursor.Position), ToolStripDropDownDirection.Default)
        mnuChart.Tag = lblTemp.Parent

    End Sub

    Private Sub mnuCPUUtil_Click(sender As Object, e As EventArgs) Handles mnuCPUUtil.Click, mnuCPUWait.Click, _
                                                                           mnuMEMUsage.Click, _
                                                                           mnuSessionActive.Click, mnuSessionTotal.Click, _
                                                                           mnuLogicalRead.Click, mnuLogicalWrite.Click, _
                                                                           mnuLockWait.Click, mnuTPSTotal.Click, _
                                                                           mnuTPSCommit.Click, mnuTPSRollback.Click, _
                                                                           mnuSQLRespTmMAX.Click, mnuSQLRespTmAVG.Click, _
                                                                           mnuReplicationDelay.Click, mnuReplicationDelaySize.Click
        Dim tlpTemp = DirectCast(mnuChart.Tag, System.Windows.Forms.TableLayoutPanel)
        Dim tlpSwap = DirectCast(mnuChart.Tag, System.Windows.Forms.TableLayoutPanel)
        Dim selectmenu = DirectCast(sender, System.Windows.Forms.ToolStripMenuItem)
        Dim index As Integer = tlpTemp.Tag 'old

        If sender.Name = "mnuCPUUtil" Then
            tlpSwap = tlpCPUUtil
        ElseIf sender.Name = "mnuCPUWait" Then
            tlpSwap = tlpCPUWait
        ElseIf sender.Name = "mnuMEMUsage" Then
            tlpSwap = tlpMEMUsage
        ElseIf sender.Name = "mnuSessionActive" Then
            tlpSwap = tlpSessionActive
        ElseIf sender.Name = "mnuSessionTotal" Then
            tlpSwap = tlpSessionTotal
        ElseIf sender.Name = "mnuLogicalRead" Then
            tlpSwap = tlpLogicalRead
        ElseIf sender.Name = "mnuLogicalWrite" Then
            tlpSwap = tlpLogicalWrite
        ElseIf sender.Name = "mnuLockWait" Then
            tlpSwap = tlpLockWait
        ElseIf sender.Name = "mnuTPSTotal" Then
            tlpSwap = tlpTPSTotal
        ElseIf sender.Name = "mnuTPSCommit" Then
            tlpSwap = tlpTPSCommit
        ElseIf sender.Name = "mnuTPSRollback" Then
            tlpSwap = tlpTPSRollback
        ElseIf sender.Name = "mnuSQLRespTmMAX" Then
            tlpSwap = tlpSQLRespTmMAX
        ElseIf sender.Name = "mnuSQLRespTmAVG" Then
            tlpSwap = tlpSQLRespTmAVG
        ElseIf sender.Name = "mnuReplicationDelay" Then
            tlpSwap = tlpReplicationDelay
        ElseIf sender.Name = "mnuReplicationDelaySize" Then
            tlpSwap = tlpReplicationDelaySize
        End If

        tlpTemp.Tag = tlpSwap.Tag 'old
        tlpSwap.Tag = index ' new
        setTLPPosition(tlpTemp)
        setTLPPosition(tlpSwap)

        If tlpCPUUtil.Tag <> 0 Then mnuCPUUtil.Image = monTypeImgLst.Images(2)
        If tlpCPUWait.Tag <> 0 Then mnuCPUWait.Image = monTypeImgLst.Images(2)
        If tlpMEMUsage.Tag <> 0 Then mnuMEMUsage.Image = monTypeImgLst.Images(2)
        If tlpSessionActive.Tag <> 0 Then mnuSessionActive.Image = monTypeImgLst.Images(2)
        If tlpSessionTotal.Tag <> 0 Then mnuSessionTotal.Image = monTypeImgLst.Images(2)
        If tlpLogicalRead.Tag <> 0 Then mnuLogicalRead.Image = monTypeImgLst.Images(2)
        If tlpLogicalWrite.Tag <> 0 Then mnuLogicalWrite.Image = monTypeImgLst.Images(2)
        If tlpTPSTotal.Tag <> 0 Then mnuTPSTotal.Image = monTypeImgLst.Images(2)
        If tlpTPSCommit.Tag <> 0 Then mnuTPSCommit.Image = monTypeImgLst.Images(2)
        If tlpTPSRollback.Tag <> 0 Then mnuTPSRollback.Image = monTypeImgLst.Images(2)
        If tlpSQLRespTmMAX.Tag <> 0 Then mnuSQLRespTmMAX.Image = monTypeImgLst.Images(2)
        If tlpSQLRespTmAVG.Tag <> 0 Then mnuSQLRespTmAVG.Image = monTypeImgLst.Images(2)
        If tlpReplicationDelay.Tag <> 0 Then mnuReplicationDelay.Image = monTypeImgLst.Images(2)
        If tlpReplicationDelaySize.Tag <> 0 Then mnuReplicationDelaySize.Image = monTypeImgLst.Images(2)

        WriteChartPosition()
    End Sub

    Private Sub WriteChartPosition()
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("CHART", "CPUUTIL", tlpCPUUtil.Tag)
        clsIni.WriteValue("CHART", "CPUWAIT", tlpCPUWait.Tag)
        clsIni.WriteValue("CHART", "MEMUSAGE", tlpMEMUsage.Tag)
        clsIni.WriteValue("CHART", "LOGICALREAD", tlpLogicalRead.Tag)
        clsIni.WriteValue("CHART", "LOGICALWRITE", tlpLogicalWrite.Tag)
        clsIni.WriteValue("CHART", "SESSIONACTIVE", tlpSessionActive.Tag)
        clsIni.WriteValue("CHART", "SESSIONTOTAL", tlpSessionTotal.Tag)
        clsIni.WriteValue("CHART", "LOCKWAIT", tlpLockWait.Tag)
        clsIni.WriteValue("CHART", "TPSTOTAL", tlpTPSTotal.Tag)
        clsIni.WriteValue("CHART", "TPSCOMMIT", tlpTPSCommit.Tag)
        clsIni.WriteValue("CHART", "TPSROLLBACK", tlpTPSRollback.Tag)
        clsIni.WriteValue("CHART", "SQLRESPTMMAX", tlpSQLRespTmMAX.Tag)
        clsIni.WriteValue("CHART", "SQLRESPTMAVG", tlpSQLRespTmAVG.Tag)
        clsIni.WriteValue("CHART", "REPLICATIONDELAY", tlpReplicationDelay.Tag)
        clsIni.WriteValue("CHART", "REPLICATIONDELAYSIZE", tlpReplicationDelaySize.Tag)
    End Sub

    Private Sub setTLPPosition(ByRef tlp As System.Windows.Forms.TableLayoutPanel)
        Dim index As Integer = tlp.Tag
        tlp.Visible = True
        Select Case index
            Case 0
                tlpTrend.SetRow(tlp, 0)
                tlpTrend.SetColumn(tlp, 0)
                tlp.Visible = False
            Case 1
                tlpTrend.SetRow(tlp, 1)
                tlpTrend.SetColumn(tlp, 0)
            Case 2
                tlpTrend.SetRow(tlp, 1)
                tlpTrend.SetColumn(tlp, 1)
            Case 3
                tlpTrend.SetRow(tlp, 1)
                tlpTrend.SetColumn(tlp, 2)
            Case 4
                tlpTrend.SetRow(tlp, 2)
                tlpTrend.SetColumn(tlp, 0)
            Case 5
                tlpTrend.SetRow(tlp, 2)
                tlpTrend.SetColumn(tlp, 1)
            Case 6
                tlpTrend.SetRow(tlp, 2)
                tlpTrend.SetColumn(tlp, 2)
            Case 7
                tlpTrend.SetRow(tlp, 3)
                tlpTrend.SetColumn(tlp, 0)
            Case 8
                tlpTrend.SetRow(tlp, 3)
                tlpTrend.SetColumn(tlp, 1)
            Case 9
                tlpTrend.SetRow(tlp, 3)
                tlpTrend.SetColumn(tlp, 2)
        End Select
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''< Trend 20180918 End>'''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btnClusterShow_Click(sender As Object, e As EventArgs) Handles btnClusterShow.Click
        ShowChooseClusters()
    End Sub

    Private Sub cmbRetention_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRetention.SelectedIndexChanged
        retainTime = (-1) * Convert.ToInt32(cmbRetention.Text)
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("General", "RTIME", cmbRetention.SelectedIndex)
    End Sub


    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim lblTemp = DirectCast(sender, System.Windows.Forms.Button)

        mnuSort.Show(lblTemp, lblTemp.PointToClient(Cursor.Position), ToolStripDropDownDirection.Default)
        mnuSort.Tag = lblTemp.Parent
    End Sub

    Private Sub mnuNameAsc_Click(sender As Object, e As EventArgs) Handles mnuNameAsc.Click, mnuNameDesc.Click, _
                                                                       mnuIPAsc.Click, mnuIPDesc.Click, mnuDefaultOrder.Click
        Dim intOrder As Integer = 0
        If sender.Name = "mnuNameAsc" Then
            intOrder = 0
        ElseIf sender.Name = "mnuNameDesc" Then
            intOrder = 1
        ElseIf sender.Name = "mnuIPAsc" Then
            intOrder = 2
        ElseIf sender.Name = "mnuIPDesc" Then
            intOrder = 3
        ElseIf sender.Name = "mnuDefaultOrder" Then
            intOrder = 4
        End If

        setInstanceOrder(intOrder)

        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("General", "INSTANCEORDER", intOrder)
    End Sub


    Private Sub setInstanceOrder(ByVal selectOrder As Integer)
        Try
            Select Case selectOrder
                Case 0
                    Dim TheList =
                    (
                        From this In flpInstance.Controls.OfType(Of Progress3D)() _
                        .Select(Function(item) _
                                New With
                                {
                                    .Progress3D = item,
                                    .text = item.Tag.ShowNm,
                                    .primary = item.PrimaryId
                                })
                    ).OrderBy(Function(x) x.primary) _
                     .ThenBy(Function(x) x.text)

                    For index = 0 To TheList.Count - 1
                        If TheList(index).primary = 0 Then
                            flpInstance.Controls.SetChildIndex( _
                                    TheList(index).Progress3D, index)
                        Else
                            Dim idx = 0
                            For idx = 0 To flpInstance.Controls.Count - 1
                                If flpInstance.Controls(idx).Tag.InstanceID = TheList(index).primary Then
                                    flpInstance.Controls.SetChildIndex(TheList(index).Progress3D, idx + 1)
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Case 1
                    Dim TheList =
                    (
                        From this In flpInstance.Controls.OfType(Of Progress3D) _
                        .Select(Function(item) _
                                New With
                                {
                                    .Progress3D = item,
                                    .text = item.Tag.ShowNm,
                                    .primary = item.PrimaryId
                                })
                    ).OrderBy(Function(x) x.primary) _
                    .ThenByDescending(Function(x) x.text)

                    For index = 0 To TheList.Count - 1
                        If TheList(index).primary = 0 Then
                            flpInstance.Controls.SetChildIndex( _
                                    TheList(index).Progress3D, index)
                        Else
                            Dim idx As Integer = 0
                            For idx = 0 To flpInstance.Controls.Count - 1
                                If flpInstance.Controls(idx).Tag.InstanceID = TheList(index).primary Then
                                    flpInstance.Controls.SetChildIndex(TheList(index).Progress3D, idx + 1)
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Case 2
                    Dim TheList =
                    (
                        From this In flpInstance.Controls.OfType(Of Progress3D) _
                        .Select(Function(item) _
                                New With
                                {
                                    .Progress3D = item,
                                    .number = item.SubLong,
                                    .primary = item.PrimaryId
                                })
                    ).OrderBy(Function(x) x.primary) _
                    .ThenBy(Function(x) x.number)

                    For index = 0 To TheList.Count - 1
                        If TheList(index).primary = 0 Then
                            flpInstance.Controls.SetChildIndex( _
                                    TheList(index).Progress3D, index)
                        Else
                            Dim idx = 0
                            For idx = 0 To flpInstance.Controls.Count - 1
                                If flpInstance.Controls(idx).Tag.InstanceID = TheList(index).primary Then
                                    flpInstance.Controls.SetChildIndex(TheList(index).Progress3D, idx + 1)
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Case 3
                    Dim TheList =
                    (
                        From this In flpInstance.Controls.OfType(Of Progress3D) _
                        .Select(Function(item) _
                                New With
                                {
                                    .Progress3D = item,
                                    .number = item.SubLong,
                                    .primary = item.PrimaryId
                                })
                    ).OrderBy(Function(x) x.primary) _
                    .ThenByDescending(Function(x) x.number)

                    For index = 0 To TheList.Count - 1
                        If TheList(index).primary = 0 Then
                            flpInstance.Controls.SetChildIndex( _
                                    TheList(index).Progress3D, index)
                        Else
                            Dim idx As Integer = 0
                            For idx = 0 To flpInstance.Controls.Count - 1
                                If flpInstance.Controls(idx).Tag.InstanceID = TheList(index).primary Then
                                    flpInstance.Controls.SetChildIndex(TheList(index).Progress3D, idx + 1)
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Case 4
                    Dim svrLst As List(Of GroupInfo.ServerInfo) = _GrpListServerinfo
                    For i As Integer = 0 To svrLst.Count - 1
                        For Each tmpCtl As Controls.Progress3D In Me.flpInstance.Controls
                            If DirectCast(tmpCtl.Tag, GroupInfo.ServerInfo).InstanceID.Equals(svrLst.Item(i).InstanceID) Then
                                flpInstance.Controls.SetChildIndex(tmpCtl, i)
                                Exit For
                            End If
                        Next
                    Next
            End Select
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

    'Progress column chart
    Public Class seriesDelta
        Private _diffSeries As DataVisualization.Charting.Series
        ReadOnly Property diffSeries As DataVisualization.Charting.Series
            Get
                Return _diffSeries
            End Get
        End Property

        Private _diffValue As Double = 0
        ReadOnly Property diffValue As Double
            Get
                Return _diffValue
            End Get
        End Property

        Private _diffIndex As Integer = 0
        ReadOnly Property diffIndex As Double
            Get
                Return _diffIndex
            End Get
        End Property

        Public Sub New(ByRef tmSeries As DataVisualization.Charting.Series, ByVal index As Integer, ByVal dValue As Double)
            _diffSeries = tmSeries
            _diffValue = dValue
            _diffIndex = index
        End Sub
    End Class

    Private WithEvents TmAni As New Timer
    Private _nDivision As Integer = 4
    Private _nAlpha As Integer = 0

    Private _tmSeriesList As New List(Of seriesDelta)

    Private Sub StartChartAnimaition()
        TmAni.Interval = 100
        TmAni.Start()
    End Sub

    Private Sub drawAnimation(ByRef tmpSeries As DataVisualization.Charting.Series, ByVal index As Integer, ByVal dValue As Double)
        Dim delta As Double = (dValue - tmpSeries.Points(index).YValues.Last) / _nDivision
        Dim sd As seriesDelta = New seriesDelta(tmpSeries, index, delta)
        _tmSeriesList.Add(sd)
    End Sub

    Private Sub TmAni_Tick(sender As Object, e As EventArgs) Handles TmAni.Tick
        If _nDivision > 0 Then
            For Each sd As seriesDelta In _tmSeriesList
                If sd.diffValue <> 0 Then
                    Dim nValue = sd.diffSeries.Points(sd.diffIndex).YValues.Last + sd.diffValue
                    sd.diffSeries.Points(sd.diffIndex).SetValueY(IIf(nValue < 0, 0, nValue))
                End If
            Next
            _nDivision -= 1
            ' Bar type 20190806
            Me.chtCPUStatus.ChartAreas(0).RecalculateAxesScale()
            Me.chtMEMStatus.ChartAreas(0).RecalculateAxesScale()
            Me.chtSessionStatus.ChartAreas(0).RecalculateAxesScale()
            Me.chrReqInfo.ChartAreas(0).RecalculateAxesScale()
        Else
            TmAni.Stop()
            _tmSeriesList.Clear()
            _nDivision = 4
        End If
    End Sub

    Private Sub dgvClusters_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvClusters.CellPainting
        If coldgvClustersServerName.Index = e.ColumnIndex AndAlso e.RowIndex = -1 Then
            'Draw column header image
            Dim r32 As New Rectangle(e.CellBounds.Left + 7, 4, 72, 72)
            Dim r96 As New Rectangle(0, 0, 72, 72)
            Dim header As String = dgvClusters.Columns(e.ColumnIndex).HeaderText
            e.PaintBackground(e.CellBounds, True)
            e.PaintContent(e.CellBounds)
            e.Graphics.DrawImage(statusImgLst.Images(3), r32, r96, GraphicsUnit.Pixel)
            e.Handled = True
        End If
    End Sub
    Private isClickdgvClusters As Boolean = True
    Private isNodeCollapsingOrExpanding As Boolean = False
    Private Sub dgvClusters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClusters.CellClick
        If e.RowIndex < 0 Then
            Return
        End If
        ' Check Whether expanding/collapsing by user clicking or by logic
        If isNodeCollapsingOrExpanding = True AndAlso isClickdgvClusters = True Then
            isNodeCollapsingOrExpanding = False
            isClickdgvClusters = True
            Return
        End If
        isNodeCollapsingOrExpanding = False
        isClickdgvClusters = True

        checkPermNopenMondetail(e.RowIndex)
    End Sub

    Private Sub dgvGrpDiskAccess_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpDiskAccess.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        'Dim clsQu As New clsQuerys(_AgentCn)
        Dim dgvClusterRowIndex As Integer = -1

        For Each tmpRow As DataGridViewRow In Me.dgvClusters.Rows
            If DirectCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID.Equals(dgvGrpDiskAccess.Rows(e.RowIndex).Cells(colDgvDiskUsageKey.Index).Tag) Then
                dgvClusterRowIndex = tmpRow.Index
                Exit For
            End If
        Next

        checkPermNopenMondetail(dgvClusterRowIndex)
    End Sub

    Private Sub dgvGrpDiskUsage_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpDiskUsage.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        ''Dim clsQu As New clsQuerys(_AgentCn)
        Dim dgvClusterRowIndex As Integer = -1

        For Each tmpRow As DataGridViewRow In Me.dgvClusters.Rows
            If DirectCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID.Equals(dgvGrpDiskUsage.Rows(e.RowIndex).Cells(colDgvDiskUsageKey.Index).Tag) Then
                dgvClusterRowIndex = tmpRow.Index
                Exit For
            End If
        Next

        checkPermNopenMondetail(dgvClusterRowIndex)
    End Sub

    Private Sub openMonDetail(ByVal rowIndex As Integer)
        If fn_FormisLock(Me, _AgentCn) = True Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
            MsgBox(strMsg)
            Dim tmpSvrInfo As GroupInfo.ServerInfo = TryCast(Me.dgvClusters.Rows(rowIndex).Tag, GroupInfo.ServerInfo)
            AccessLog("cluster_detail", 1, "", tmpSvrInfo.InstanceID)
            Return
        End If

        If p_clsAgentCollect.AgentState <> clsCollect.AgntState.Activate Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M019")
            MsgBox(strMsg)
            Return
        End If

        ' Tag에 값을 넝ㅎ어 두었음. 
        'Dim svrInfo As GroupInfo.ServerInfo = TryCast(Me.dgvClusters.Nodes(e.RowIndex).Tag, GroupInfo.ServerInfo)
        Dim svrInfo As GroupInfo.ServerInfo = TryCast(Me.dgvClusters.Rows(rowIndex).Tag, GroupInfo.ServerInfo)
        AccessLog("cluster_detail", 0, "", svrInfo.InstanceID)
        If dgvClusters.Rows(rowIndex).Cells(coldgvClusterIsOpenSingle.Index).Value <> "1" Then
            Dim FrmSub As New frmMonDetail(svrInfo, _ElapseInterval, AgentInfo, AgentCn)
            FrmSub.OwnerForm = Me
            FrmSub.Show()
        Else
            For Each tmpFrm As Form In My.Application.OpenForms
                Dim frmDtl As frmMonDetail = TryCast(tmpFrm, frmMonDetail)
                If frmDtl IsNot Nothing AndAlso frmDtl.InstanceID = svrInfo.InstanceID Then
                    If frmDtl.WindowState = FormWindowState.Minimized Then
                        frmDtl.WindowState = FormWindowState.Maximized
                    End If
                    frmDtl.Activate()
                    Exit For
                End If
            Next
        End If
        dgvClusters.Rows(rowIndex).Cells(coldgvClusterIsOpenSingle.Index).Value = "1"
    End Sub

    Private Sub dgvClusters_NodeCollapsing(sender As Object, e As AdvancedDataGridView.CollapsingEventArgs) Handles dgvClusters.NodeCollapsing
        'e.Cancel = True
        If e.Node.HasChildren Then
            isNodeCollapsingOrExpanding = True
            Threading.Thread.Sleep(10)
        End If
    End Sub

    Private Sub dgvClusters_NodeExpanding(sender As Object, e As AdvancedDataGridView.ExpandingEventArgs) Handles dgvClusters.NodeExpanding
        If e.Node.HasChildren Then
            isNodeCollapsingOrExpanding = True
            Threading.Thread.Sleep(10)
        End If
    End Sub

    Private sortAscending As Boolean = False
    Private Sub dgvClusters_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvClusters.ColumnHeaderMouseClick
        Try
            For Each tmpNode As AdvancedDataGridView.TreeGridNode In Me.dgvClusters.Nodes
                isClickdgvClusters = False
                tmpNode.Collapse()
            Next
            Me.dgvClusters.Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
            For Each tmpNode As AdvancedDataGridView.TreeGridNode In Me.dgvClusters.Nodes
                isClickdgvClusters = False
                tmpNode.Expand()
            Next
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim lblTemp = DirectCast(sender, System.Windows.Forms.Button)
        Dim ps As System.Drawing.Point = Cursor.Position
        mnuLogout.Text = p_clsMsgData.fn_GetData("F939")
        mnuUserConfig.Text = p_clsMsgData.fn_GetData("M047")
        mnuPreferences.Text = p_clsMsgData.fn_GetData("F952")
        mnuVersion.Text = p_clsMsgData.fn_GetData("F940")
        ps.X -= mnuMenu.Width
        If p_cSession.isAdmin = False Then
            mnuMenu.Items(2).Visible = False
        End If
        mnuMenu.Show(lblTemp, lblTemp.PointToClient(ps), ToolStripDropDownDirection.Default)
        mnuMenu.Tag = lblTemp.Parent
    End Sub

    Private Sub rbCPURadar_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPURadar.CheckedChanged, rbCPUBar.CheckedChanged
        Dim rbTemp As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If rbTemp.Name = "rbCPURadar" Then
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            clsIni.WriteValue("FORM", "CPUDISPLAYTYPE", "rbCPURadar")
            tlpCPU.Visible = True
            chtCPUStatus.Visible = False
        Else
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            clsIni.WriteValue("FORM", "CPUDISPLAYTYPE", "rbCPUBar")
            tlpCPU.Visible = False
            chtCPUStatus.Visible = True
        End If
    End Sub

    Private Sub rbMEMRadar_CheckedChanged(sender As Object, e As EventArgs) Handles rbMEMRadar.CheckedChanged, rbMEMBar.CheckedChanged
        Dim rbTemp As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If rbTemp.Name = "rbMEMRadar" Then
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            clsIni.WriteValue("FORM", "MEMDISPLAYTYPE", "rbMEMRadar")
            tlpMem.Visible = True
            chtMEMStatus.Visible = False
        Else
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            clsIni.WriteValue("FORM", "MEMDISPLAYTYPE", "rbMEMBar")
            tlpMem.Visible = False
            chtMEMStatus.Visible = True
        End If
    End Sub

    Private Sub dgvGrpDiskAccess_MouseEnter(sender As Object, e As EventArgs) Handles dgvGrpDiskAccess.MouseEnter
        dgvGrpDiskAccess.ScrollBars = ScrollBars.Vertical
        dgvGrpDiskAccess.Invalidate()
    End Sub

    Private Sub dgvGrpDiskAccess_MouseLeave(sender As Object, e As EventArgs) Handles dgvGrpDiskAccess.MouseLeave
        dgvGrpDiskAccess.ScrollBars = ScrollBars.None
        dgvGrpDiskAccess.Invalidate()
    End Sub

    Private Sub dgvGrpDiskUsage_MouseEnter(sender As Object, e As EventArgs) Handles dgvGrpDiskUsage.MouseEnter
        dgvGrpDiskUsage.ScrollBars = ScrollBars.Vertical
        dgvGrpDiskUsage.Invalidate()
    End Sub

    Private Sub dgvGrpDiskUsage_MouseLeave(sender As Object, e As EventArgs) Handles dgvGrpDiskUsage.MouseLeave
        dgvGrpDiskUsage.ScrollBars = ScrollBars.None
        dgvGrpDiskUsage.Invalidate()
    End Sub

    Private Sub dgvClusters_MouseEnter(sender As Object, e As EventArgs) Handles dgvClusters.MouseEnter
        dgvClusters.ScrollBars = ScrollBars.Vertical
        dgvClusters.Invalidate()
    End Sub

    Private Sub dgvClusters_MouseLeave(sender As Object, e As EventArgs) Handles dgvClusters.MouseLeave
        dgvClusters.ScrollBars = ScrollBars.None
        dgvClusters.Invalidate()
    End Sub

    Private Sub dgvGrpCpuSvrLst_MouseEnter(sender As Object, e As EventArgs) Handles dgvGrpCpuSvrLst.MouseEnter
        dgvGrpCpuSvrLst.ScrollBars = ScrollBars.Vertical
        dgvGrpCpuSvrLst.Invalidate()
    End Sub

    Private Sub dgvGrpMemSvrLst_MouseLeave(sender As Object, e As EventArgs) Handles dgvGrpMemSvrLst.MouseLeave
        dgvGrpMemSvrLst.ScrollBars = ScrollBars.None
        dgvGrpMemSvrLst.Invalidate()
    End Sub

    Private Sub dgvGrpMemSvrLst_MouseEnter(sender As Object, e As EventArgs) Handles dgvGrpMemSvrLst.MouseEnter
        dgvGrpMemSvrLst.ScrollBars = ScrollBars.Vertical
        dgvGrpMemSvrLst.Invalidate()
    End Sub

    Private Sub dgvGrpCpuSvrLst_MouseLeave(sender As Object, e As EventArgs) Handles dgvGrpCpuSvrLst.MouseLeave
        dgvGrpCpuSvrLst.ScrollBars = ScrollBars.None
        dgvGrpCpuSvrLst.Invalidate()
    End Sub

    Private Sub chtSessionStatus_Click(sender As Object, e As MouseEventArgs) Handles chtSessionStatus.Click, chrReqInfo.Click, chtCPUStatus.Click, chtMEMStatus.Click
        Dim result As DataVisualization.Charting.HitTestResult = Nothing
        Dim selectedDataPoint As DataVisualization.Charting.DataPoint = Nothing
        Dim selectedServerName As String = ""
        Dim dgvClusterRowIndex As Integer = -1

        Dim chartName As String = CType(sender, DataVisualization.Charting.Chart).Name
        Select Case chartName
            Case "chtSessionStatus"
                result = chtSessionStatus.HitTest(e.X, e.Y)
            Case "chrReqInfo"
                result = chrReqInfo.HitTest(e.X, e.Y)
            Case "chtCPUStatus"
                result = chtCPUStatus.HitTest(e.X, e.Y)
            Case "chtMEMStatus"
                result = chtMEMStatus.HitTest(e.X, e.Y)
        End Select

        Select Case result.ChartElementType
            Case DataVisualization.Charting.ChartElementType.DataPoint
                selectedDataPoint = CType(result.Object, DataVisualization.Charting.DataPoint)
                For Each tmpRow As DataGridViewRow In Me.dgvClusters.Rows
                    If DirectCast(tmpRow.Tag, GroupInfo.ServerInfo).InstanceID.Equals(selectedDataPoint.Tag.InstanceID) Then
                        dgvClusterRowIndex = tmpRow.Index
                        Exit For
                    End If
                Next
            Case DataVisualization.Charting.ChartElementType.AxisLabels
                selectedServerName = CType(result.Object, DataVisualization.Charting.CustomLabel).Text
                For Each tmpRow As DataGridViewRow In Me.dgvClusters.Rows
                    If DirectCast(tmpRow.Tag, GroupInfo.ServerInfo).ShowNm.Equals(selectedServerName) Then
                        dgvClusterRowIndex = tmpRow.Index
                        Exit For
                    End If
                Next
            Case Else
                Return
        End Select
        checkPermNopenMondetail(dgvClusterRowIndex)
    End Sub

    Private Sub btnColumns_Click(sender As Object, e As EventArgs) Handles btnColumns.Click
        Dim lblTemp = DirectCast(sender, System.Windows.Forms.Button)
        Dim ps As System.Drawing.Point = Cursor.Position
        ps.X -= mnuBackendColumns.Width
        mnuBackendColumns.Show(lblTemp, lblTemp.PointToClient(Cursor.Position), ToolStripDropDownDirection.Default)
        mnuBackendCPU.Text = p_clsMsgData.fn_GetData("F049")
        mnuBackendStartTime.Text = p_clsMsgData.fn_GetData("F050")
        mnuBackendElapsedTime.Text = p_clsMsgData.fn_GetData("F051")

        If dgvSessionInfo.Columns(colDgvSessionInfoCpuUsage.Index).Visible = True Then
            mnuBackendCPU.Checked = CheckState.Checked
        Else
            mnuBackendCPU.Checked = CheckState.Unchecked
        End If
        If dgvSessionInfo.Columns(colDgvSessionInfoTmStart.Index).Visible = True Then
            mnuBackendStartTime.Checked = CheckState.Checked
        Else
            mnuBackendStartTime.Checked = CheckState.Unchecked
        End If

        If dgvSessionInfo.Columns(colDgvSessionInfoTmElapse.Index).Visible = True Then
            mnuBackendElapsedTime.Checked = CheckState.Checked
        Else
            mnuBackendElapsedTime.Checked = CheckState.Unchecked
        End If
    End Sub

    Private Sub mnuBackendColumns_Click(sender As Object, e As EventArgs) Handles mnuBackendCPU.Click, mnuBackendStartTime.Click, mnuBackendElapsedTime.Click
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        If sender.Name = "mnuBackendCPU" Then
            dgvSessionInfo.Columns(colDgvSessionInfoCpuUsage.Index).Visible = Not dgvSessionInfo.Columns(colDgvSessionInfoCpuUsage.Index).Visible
            clsIni.WriteValue("FORM", "MAINMENUCOLUMNADDR", dgvSessionInfo.Columns(colDgvSessionInfoCpuUsage.Index).Visible)
        ElseIf sender.Name = "mnuBackendStartTime" Then
            dgvSessionInfo.Columns(colDgvSessionInfoTmStart.Index).Visible = Not dgvSessionInfo.Columns(colDgvSessionInfoTmStart.Index).Visible
            clsIni.WriteValue("FORM", "MAINMENUCOLUMNAPP", dgvSessionInfo.Columns(colDgvSessionInfoTmStart.Index).Visible)
        ElseIf sender.Name = "mnuBackendElapsedTime" Then
            dgvSessionInfo.Columns(colDgvSessionInfoTmElapse.Index).Visible = Not dgvSessionInfo.Columns(colDgvSessionInfoTmElapse.Index).Visible
            clsIni.WriteValue("FORM", "MAINMENUCOLUMNWAITEVENT", dgvSessionInfo.Columns(colDgvSessionInfoTmElapse.Index).Visible)
        End If
    End Sub
#Region "menu"
    Private Sub mnuMenu_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click, mnuUserConfig.Click, mnuPreferences.Click, mnuVersion.Click
        Dim BretFrm As Form = Nothing
        Dim stDt As DateTime = Now.AddMinutes(-10)
        Dim edDt As DateTime = Now

        If sender.Name = "mnuLogout" Then
            Me.Owner.Close()
        ElseIf sender.Name = "mnuUserConfig" Then
            If CheckPassword() = False Then Return
            Dim userConfig As New frmConfig(AgentCn)
            userConfig.ShowDialog()
        ElseIf sender.Name = "mnuPreferences" Then
            If CheckPassword() = False Then Return
            Dim Preferences As New frmPreferences(AgentCn)
            Preferences.ShowDialog()
        Else
            Dim version As New frmVersion(AgentCn)
            version.ShowDialog()
        End If

    End Sub
#End Region

#Region "Check permission/password/access log"
    Private Sub checkPermNopenMondetail(ByVal rowIndex As Integer)
        Dim clsQu As New clsQuerys(_AgentCn)

        If p_cSession.loadUserPermission(clsQu) = True Then
            Dim hasPermission As Boolean = p_cSession.checkPermission(p_currentGroup, 1)
            If hasPermission = True Then
                If rowIndex >= 0 Then openMonDetail(rowIndex)
            Else
                MsgBox(p_clsMsgData.fn_GetData("M088"))
                Dim tmpSvrInfo As GroupInfo.ServerInfo = TryCast(Me.dgvClusters.Rows(rowIndex).Tag, GroupInfo.ServerInfo)
                AccessLog("cluster_detail", 1, "", tmpSvrInfo.InstanceID)
            End If
        Else
            MsgBox(p_clsMsgData.fn_GetData("M088"))
            Dim tmpSvrInfo As GroupInfo.ServerInfo = TryCast(Me.dgvClusters.Rows(rowIndex).Tag, GroupInfo.ServerInfo)
            AccessLog("cluster_detail", 1, "Load permission failed", tmpSvrInfo.InstanceID)
        End If
    End Sub

    Private Function CheckPassword() As Boolean
        Dim frmPw As New frmPassword(AgentCn)
        If frmPw.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AccessLog(ByVal strAccessType As String, ByVal intStatus As Integer, _
              Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            Dim clsQu As New clsQuerys(_AgentCn)
            clsQu.InsertUserAccessInfo(p_cSession.UserID, strAccessType, intStatus, strLog, strLocIP, intInstanceID)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region
#Region "Selct Instances"
    Private Sub ShowChooseClusters()
        Dim frmCS As New frmClusterShow(_GrpListServerinfo, _instanceColors)
        If frmCS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rtnStruct As structConnection = Nothing
            Dim rtnSchema As String = ""
            Dim rtnCollect As Integer = 0
            Dim strAlias As String = ""

            Dim index As Integer = 0
            For Each tmpSvr As GroupInfo.ServerInfo In _GrpListServerinfo
                tmpSvr.Reserved = frmCS.SvrpList(index).Reserved
                If tmpSvr.Reserved = True Then
                    chtCPUUtil.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtCPUWait.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtMEMUsage.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtLockWait.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtLogicalRead.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtLogicalWrite.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtSessionActive.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtSessionTotal.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtSQLRespTmAVG.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtSQLRespTmMAX.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtTPSCommit.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtTPSRollback.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtTPSTotal.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtReplicationDelay.Series(tmpSvr.ShowSeriesNm).Enabled = True
                    chtReplicationDelaySize.Series(tmpSvr.ShowSeriesNm).Enabled = True
                Else
                    chtCPUUtil.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtCPUWait.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtMEMUsage.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtLockWait.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtLogicalRead.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtLogicalWrite.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtSessionActive.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtSessionTotal.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtSQLRespTmAVG.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtSQLRespTmMAX.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtTPSCommit.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtTPSRollback.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtTPSTotal.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtReplicationDelay.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    chtReplicationDelaySize.Series(tmpSvr.ShowSeriesNm).Enabled = False
                    'Status Charts
                End If
                index += 1
            Next
            ReinitCharts()
        End If
        frmCS.Dispose()
    End Sub

    Private Sub ReinitCharts()
        _tmSeriesList.Clear()
        ' Cluster list backcolor
        setInstanceColors()
        ' CPU 관련 목록을 변경한다. 
        ResetCPUStatusChart()
        '' 메모리 관련 목록을 변경한다. 
        ResetMEMStatusChart()
        '' Request Info 
        ResetLogicalStatusChart()
        ' Session Stats
        ResetSessionStatusCharts()
    End Sub

    Private Sub setInstanceColors()
        For Each tmpRow As DataGridViewRow In Me.dgvClusters.Rows
            If tmpRow.Tag.Reserved = True Then
                tmpRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(44, Byte), Integer))
                tmpRow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(44, Byte), Integer))
            Else
                tmpRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
                tmpRow.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
            End If
        Next

    End Sub

    Private Sub ResetCPUStatusChart()
        ' 레이더 보이는 아이템을 모두 삭제한다. 
        radCpu.items.Clear()
        ' 레이더 컨트롤 옆의 Grid도 모두 삭제한다. 
        dgvGrpCpuSvrLst.DataSource = Nothing
        dgvGrpCpuSvrLst.Rows.Clear()

        ' Raider 및 DataGridview의 목록을 초기화로 넣는다. 
        Dim idx As Integer = 0
        Dim svrLst As List(Of GroupInfo.ServerInfo) = _GrpListServerinfo
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            If tmpSvr.Reserved = True Then
                radCpu.items.Add(tmpSvr.InstanceID, tmpSvr.ShowNm, CPUImgLst.Images(idx), idx + 1)
                Dim idxRow As Integer = dgvGrpCpuSvrLst.Rows.Add()
                dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrID.Index).Value = tmpSvr.InstanceID
                dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrNm.Index).Value = tmpSvr.ShowNm
                dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrUsage.Index).Value = 0.0
                dgvGrpCpuSvrLst.Rows(idxRow).Cells(colGrpCpuSvrProg.Index).Value = 0.0
                idx += 1
            End If
        Next

        'AddHandler dgvGrpCpuSvrLst.SizeChanged, AddressOf DataGridView_SizeChanged

        '''''''< Bar 20190807 Start>'''''''''''''''''''''''''''''''''''''''''''
        For Each tmpSeries As DataVisualization.Charting.Series In Me.chtCPUStatus.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList
        Dim vIndex As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            If tmpSvr.Reserved = True Then
                srtLSt.Add(tmpSvr.InstanceID, vIndex)
                For Each tmpSeries As DataVisualization.Charting.Series In Me.chtCPUStatus.Series
                    Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                    tmpSeries.Points(tmpInt).AxisLabel = tmpSvr.ShowNm
                    tmpSeries.Points(tmpInt).Tag = tmpSvr
                Next
                vIndex += 1
            End If
        Next

        If srtLSt.Count <= 6 Then
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtCPUStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf srtLSt.Count > 6 AndAlso srtLSt.Count < 12 Then
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtCPUStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtCPUStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chtCPUStatus.ChartAreas(0).InnerPlotPosition.Height = 69
        End If

        'Row height
        DgvRowHeightFill(dgvGrpCpuSvrLst, srtLSt.Count)

        ' group color
        sb_setGroupColorChart(chtCPUStatus)

        Me.chtCPUStatus.Tag = srtLSt
        chtCPUStatus.Invalidate()
        '''''''< Bar 20190807 Stop>'''''''''''''''''''''''''''''''''''''''''''

    End Sub

    Private Sub ResetMEMStatusChart()
        ' 레이더 보이는 아이템을 모두 삭제한다. 
        radMem.items.Clear()
        ' 레이더 컨트롤 옆의 Grid도 모두 삭제한다. 
        dgvGrpMemSvrLst.DataSource = Nothing
        dgvGrpMemSvrLst.Rows.Clear()

        ' Raider 및 DataGridview의 목록을 초기화로 넣는다. 
        Dim idx As Integer = 0
        Dim svrLst As List(Of GroupInfo.ServerInfo) = _GrpListServerinfo
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            If tmpSvr.Reserved = True Then
                radMem.items.Add(tmpSvr.InstanceID, tmpSvr.ShowNm, CPUImgLst.Images(idx), idx + 1)
                Dim idxRow As Integer = dgvGrpMemSvrLst.Rows.Add()
                dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrID.Index).Value = tmpSvr.InstanceID
                dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrNm.Index).Value = tmpSvr.ShowNm
                dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrUsage.Index).Value = 0.0
                dgvGrpMemSvrLst.Rows(idxRow).Cells(colGrpMemSvrprog.Index).Value = 0.0
                idx += 1
            End If
        Next

        For Each tmpSeries As DataVisualization.Charting.Series In Me.chtMEMStatus.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList
        Dim vIndex As Integer = 0
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            If tmpSvr.Reserved = True Then
                srtLSt.Add(tmpSvr.InstanceID, vIndex)
                For Each tmpSeries As DataVisualization.Charting.Series In Me.chtMEMStatus.Series
                    Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                    tmpSeries.Points(tmpInt).AxisLabel = tmpSvr.ShowNm
                    tmpSeries.Points(tmpInt).Tag = tmpSvr
                Next
                vIndex += 1
            End If
        Next

        If srtLSt.Count <= 6 Then
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtMEMStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf srtLSt.Count > 6 AndAlso srtLSt.Count < 12 Then
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtMEMStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtMEMStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chtMEMStatus.ChartAreas(0).InnerPlotPosition.Height = 69
        End If

        'Row height
        DgvRowHeightFill(dgvGrpMemSvrLst, srtLSt.Count)

        ' group color
        sb_setGroupColorChart(chtMEMStatus)

        Me.chtMEMStatus.Tag = srtLSt
        chtMEMStatus.Invalidate()

    End Sub

    Private Sub ResetSessionStatusCharts()
        For Each tmpSeries As DataVisualization.Charting.Series In Me.chtSessionStatus.Series
            tmpSeries.Points.Clear()
        Next
        Dim srtLSt As New SortedList
        Dim vIndex As Integer = 0
        Dim svrLst As List(Of GroupInfo.ServerInfo) = _GrpListServerinfo
        For Each tmpSvr As GroupInfo.ServerInfo In svrLst
            If tmpSvr.Reserved = True Then
                srtLSt.Add(tmpSvr.InstanceID, vIndex)
                For Each tmpSeries As DataVisualization.Charting.Series In Me.chtSessionStatus.Series
                    Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                    tmpSeries.Points(tmpInt).AxisLabel = tmpSvr.ShowNm
                    tmpSeries.Points(tmpInt).ToolTip = tmpSvr.ShowNm
                    tmpSeries.Points(tmpInt).Tag = tmpSvr
                Next
                vIndex += 1
            End If
        Next

        If srtLSt.Count <= 6 Then
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtSessionStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf srtLSt.Count > 6 AndAlso srtLSt.Count < 12 Then
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chtSessionStatus.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chtSessionStatus.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chtSessionStatus.ChartAreas(0).InnerPlotPosition.Height = 65
        End If

        Me.chtSessionStatus.Tag = srtLSt

        ' group color
        sb_setGroupColorChart(chtSessionStatus)
        chtSessionStatus.Invalidate()
    End Sub

    Private Sub ResetLogicalStatusChart()
        For Each tmpSeries As DataVisualization.Charting.Series In Me.chrReqInfo.Series
            tmpSeries.Points.Clear()
        Next
        Dim svrLst As List(Of GroupInfo.ServerInfo) = _GrpListServerinfo
        Dim srtLSt As New SortedList
        Dim vIndex As Integer = 0
        For i As Integer = 0 To svrLst.Count - 1
            If svrLst.Item(i).Reserved = True Then
                srtLSt.Add(svrLst.Item(i).InstanceID, vIndex)
                For Each tmpSeries As DataVisualization.Charting.Series In Me.chrReqInfo.Series
                    Dim tmpInt As Integer = tmpSeries.Points.AddY(0)
                    tmpSeries.Points(tmpInt).AxisLabel = svrLst.Item(i).ShowNm
                    tmpSeries.Points(tmpInt).Tag = svrLst.Item(i)
                Next
                vIndex += 1
            End If
        Next

        If srtLSt.Count <= 6 Then
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chrReqInfo.ChartAreas(0).InnerPlotPosition.Height = 80
        ElseIf srtLSt.Count > 6 AndAlso srtLSt.Count < 12 Then
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.Angle = 0
            Me.chrReqInfo.ChartAreas(0).InnerPlotPosition.Height = 80
        Else
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False
            Me.chrReqInfo.ChartAreas(0).AxisX.LabelStyle.Angle = 45
            Me.chrReqInfo.ChartAreas(0).InnerPlotPosition.Height = 65
        End If

        Me.chrReqInfo.Tag = srtLSt

        ' group color
        sb_setGroupColorChart(chrReqInfo)

        chrReqInfo.Invalidate()
    End Sub
#End Region

    Private Sub btnDiskAccess_Click(sender As Object, e As EventArgs) Handles btnDiskAccess.Click, btnDiskUsage.Click
        If sender.name = "btnDiskAccess" Then
            Me._isDiskAccess = Not _isDiskAccess
            If _isDiskAccess = True Then
                btnDiskAccess.Image = pinImageList.Images(0)
            Else
                btnDiskAccess.Image = pinImageList.Images(1)
            End If
        ElseIf sender.name = "btnDiskUsage" Then
            Me._isDiskUsage = Not _isDiskUsage
            If _isDiskUsage = True Then
                btnDiskUsage.Image = pinImageList.Images(0)
            Else
                btnDiskUsage.Image = pinImageList.Images(1)
            End If
        End If
    End Sub
End Class
