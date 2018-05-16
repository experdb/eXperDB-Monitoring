
Public Structure structConnection
    
    Private _IP As String
    <ComponentModel.Description("접속서버정보")> _
    <ComponentModel.Browsable(False)> _
        ReadOnly Property HostIP As String
        Get
            Return _IP
        End Get
    End Property

    
    Private _ODBCType As eXperDBODBC.enumODBCType
    <ComponentModel.Description("대상 서버 유형 Oracle , SYBASE , MSSQL , DB2 ...")> _
    ReadOnly Property ODBCType As eXperDBODBC.enumODBCType
        Get
            Return _ODBCType
        End Get
    End Property


    Private _Port As Integer
    <ComponentModel.Description("접속포트")> _
    <ComponentModel.Browsable(False)> _
    ReadOnly Property Port As Integer
        Get
            Return _Port
        End Get
    End Property


    Private _DBName As String
    <ComponentModel.Description("데이터베이스명")> _
  <ComponentModel.Browsable(False)> _
    ReadOnly Property DBName As String
        Get
            Return _DBName
        End Get
    End Property


    Private _UserID As String
    <ComponentModel.Description("접속 계정"), _
    ComponentModel.Browsable(False)> _
    ReadOnly Property UserID As String
        Get
            Return _UserID
        End Get
    End Property
    Private _Password As String
    <ComponentModel.Description("비밀번호") _
    , ComponentModel.Browsable(False)> _
    ReadOnly Property Password As String
        Get
            Return _Password
        End Get
    End Property
    <ComponentModel.Browsable(False)> _
    ReadOnly Property ConnectionString() As String
        Get
            Return GetConnectionString()
        End Get
    End Property
    <ComponentModel.Browsable(False)> _
    ReadOnly Property DummyQuery As String
        Get
            Return GetDummyQuery()
        End Get
    End Property

    'Public Sub New(ByVal enmODBCType As IDastODBC.enumODBCType, ByVal strAliasName As String, ByVal strIP As String, ByVal intPort As Integer, ByVal strID As String, ByVal strSID As String)
    '    Initialize(enmODBCType, strAliasName, strIP, intPort, strID, strSID)


    'End Sub

    Public Sub Initialize(ByVal enmODBCType As eXperDBODBC.enumODBCType, ByVal strIP As String, ByVal intPort As Integer, ByVal strUserID As String, ByVal strSID As String, ByVal strPassword As String)
        _ODBCType = enmODBCType
        '_AliasName = strAliasName
        _IP = strIP
        _Port = intPort
        _UserID = strUserID
        _DBName = strSID
        _Password = strPassword
    End Sub

    Public Sub New(ByVal enmODBCName As String, ByVal strIP As String, ByVal intPort As Integer, ByVal strUserID As String, ByVal strSID As String, ByVal strPassword As String)
        Dim enmOdbcType As eXperDBODBC.enumODBCType
        If System.Enum.TryParse(enmODBCName, enmOdbcType) = True Then
            Initialize(enmOdbcType, strIP, intPort, strUserID, strSID, strPassword)
        End If


    End Sub
    Public Sub New(ByVal enmOdbcType As eXperDBODBC.enumODBCType, ByVal strIP As String, ByVal intPort As Integer, ByVal strUserID As String, ByVal strSID As String, ByVal strPassword As String)
        Initialize(enmOdbcType, strIP, intPort, strUserID, strSID, strPassword)

    End Sub



    Public Sub SetUserID(ByVal strUserID As String)
        _UserID = strUserID
    End Sub

    Public Sub SetPassword(ByVal strPw As String)
        _Password = strPw
    End Sub

    Private Function GetConnectionString() As String
        Dim strMain As String = TryCast(_ODBCType.GetType().GetMember(_ODBCType.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
        Dim strValue As String = TryCast(_ODBCType.GetType().GetMember(_ODBCType.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
        Dim tmpStr As String = ""
        Select Case strMain
            Case "POSTGRESQL"
                tmpStr = String.Format("Driver={0};Server={1};Port={2};Database={3};Uid={4};Pwd={5};Connection Timeout=2", strValue, _IP, _Port, _DBName, _UserID, _Password)
            Case "MSSQL"
                tmpStr = String.Format("Driver={0};Server={1},{2};Database={3};Uid={4};Pwd={5};Connection Timeout=3", strValue, _IP, _Port, _DBName, _UserID, _Password)
            Case "ORACLE"
                tmpStr = String.Format("Driver={0};Dbq={1}:{2}/{3};UID={4};PWD={5};", strValue, _IP, _Port, _DBName, _UserID, _Password)
                ' tmpStr = String.Format("Driver={0};Server=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={1})(PORT={2}))(CONNECT_DATA=(SERVER=DEDICATED) (SID={3})));User ID={4};Password={5};Connection Timeout=3", strValue, _IP, _Port, _DBName, _UserID, _Password)
            Case "SYBASE ASE"
                tmpStr = String.Format("Driver={0};NA={1},{2};db={3};uid={4};pwd={5}", strValue, _IP, _Port, _DBName, _UserID, _Password)
            Case "SYBASE IQ"
                tmpStr = String.Format("Driver={0};commlonk=tcpip(host={1};port={2});servername={3};uid={4};pwd={5}", strValue, _IP, _Port, _DBName, _UserID, _Password)
            Case "DB2"
                tmpStr = String.Format("Driver={0};hostname={1};port={2};protocol=TCPIP;Database={3};uid={4};pwd={5}", strValue, _IP, _Port, _DBName, _UserID, _Password)
            Case "TIBERO"
                tmpStr = String.Format("Driver={0};Server={1};PORT={2};Database={3};UID={4};PWD={5}; ", strValue, _IP, _Port, _DBName, _UserID, _Password)
        End Select

        Return tmpStr
    End Function

    Private Function GetDummyQuery() As String
        Dim strMain As String = TryCast(_ODBCType.GetType().GetMember(_ODBCType.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
        Dim strValue As String = TryCast(_ODBCType.GetType().GetMember(_ODBCType.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
        Dim tmpStr As String = ""
        Select Case strMain
            Case "POSTGRESQL"
                tmpStr = "SELECT 1 "
            Case "MSSQL"
                tmpStr = "SELECT 1"
            Case "ORACLE"
                tmpStr = "SELECT 1 FROM DUAL"
            Case "DB2"
                tmpStr = "select  '1' from sysibm.sysdummy1"
            Case "SYBASE ASE", "SYBASE IQ"
                tmpStr = "SELECT '1'"
            Case "TIBERO"
                tmpStr = "SELECT 1 FROM DUAL"


        End Select

        Return tmpStr
    End Function



    'Private Function fn_GetODBCCategory() As String
    '    Return TryCast(_ODBCType.GetType().GetMember(_ODBCType.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
    'End Function

    'Private Function fn_GetODBCDriverName() As String
    '    Return TryCast(_ODBCType.GetType().GetMember(_ODBCType.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
    'End Function

End Structure
