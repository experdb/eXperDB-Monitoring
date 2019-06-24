Imports eXperDB

Module clsVariables
    ''' <summary>
    ''' 프로그램 INi 설정 관리 System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Config.ini")
    ''' </summary>
    ''' <remarks></remarks>
    Public p_AppConfigIni As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Config.ini")
    ''' <summary>
    ''' Language DataTable   
    '''  최초 Read 시에 넣는다. ApplicationEvents.vb 
    ''' </summary>
    ''' <remarks></remarks>
    Public p_clsMsgData As clsXmlData

    ''' <summary>
    ''' Postgresql 쿼리 데이터 
    ''' 최초 Read시에 넣는다. ApplicationEvents.vb 
    ''' </summary>
    ''' <remarks></remarks>
    Public p_clsQueryData As clsXmlData

    ''' <summary>
    ''' 로그 관련
    ''' </summary>
    ''' <remarks></remarks>
    Public p_Log As New LogUtil.clsLog4Net

    ''' <summary>
    ''' 프로그램 접속 로그인 계정 관련 
    ''' </summary>
    ''' <remarks></remarks>
    Public p_UseID As String = "ADMIN"


    ''' <summary>
    '''  Agent Collect Thread Class  
    ''' </summary>
    ''' <remarks></remarks>
    Public p_clsAgentCollect As clsCollect


    '    Public p_RageHealthClr As ProgClrArea() = New ProgClrArea() {New ProgClrArea(100, 100, Color.Lime), New ProgClrArea(200, 200, Color.Yellow), New ProgClrArea(300, 300, Color.Red)}
    '    Public p_RageBaseClr As ProgClrArea() = New ProgClrArea() {New ProgClrArea(0, 60, Color.Lime), New ProgClrArea(60, 90, Color.Yellow), New ProgClrArea(90, 100, Color.Red)}
    'Public p_RageHealthClr As ProgClrArea() = New ProgClrArea() {New ProgClrArea(100, 100, Color.LimeGreen), New ProgClrArea(200, 200, Color.Gold), New ProgClrArea(300, 300, Color.Red)}
    'Public p_RageBaseClr As ProgClrArea() = New ProgClrArea() {New ProgClrArea(0, 60, Color.LimeGreen), New ProgClrArea(60, 90, Color.Gold), New ProgClrArea(90, 100, Color.Red)}
    Public p_RageHealthClr As ProgClrArea() = New ProgClrArea() {New ProgClrArea(100, 100, System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(116, Byte), Integer))), New ProgClrArea(200, 200, Color.Gold), New ProgClrArea(300, 300, Color.OrangeRed)}
    Public p_RageBaseClr As ProgClrArea() = New ProgClrArea() {New ProgClrArea(0, 60, System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(116, Byte), Integer))), New ProgClrArea(60, 90, Color.Gold), New ProgClrArea(90, 100, Color.OrangeRed)}


    'Public p_CriticalInterval As Integer = 300000

    'Public p_Font As String = "Gulim"
    Public p_Font As String = "Arial"



    Public p_ShowName As clsEnums.ShowName = clsEnums.ShowName.HostName

    ''' <summary>
    ''' 사용자 환경
    ''' </summary>
    ''' <remarks></remarks>
    Public p_UserENv As clsUserEnv

    Public p_cSession As clsSession

    Public p_currentGroup As Integer

End Module
