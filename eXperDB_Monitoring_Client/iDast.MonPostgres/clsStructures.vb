
Public Class GroupInfo

    Public Sub New(ByVal GrpID As Integer, ByVal strGroupName As String)
        _GroupName = strGroupName
        _ID = GrpID
    End Sub

    Private _ID As Integer = -1
    ''' <summary>
    ''' Group ID 1 , 2 , 3 , 4 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property
    Private _GroupName As String
    ''' <summary>
    ''' 그룹명
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property GroupName As String
        Get
            Return _GroupName
        End Get
    End Property
    Private _Items As New List(Of ServerInfo)
    ''' <summary>
    ''' 그룹에 속한 서버 리스트 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property Items As List(Of ServerInfo)
        Get
            Return _Items
        End Get
    End Property

    Public Function fn_GetServerInstance() As Integer()
        Dim tmpArr As New ArrayList
        For Each SvrInfo As ServerInfo In _Items
            tmpArr.Add(SvrInfo.ID)
        Next
        Return tmpArr.ToArray(GetType(Integer))

    End Function
    ''' <summary>
    ''' 그룹에 속한 서버 정보
    ''' </summary>
    ''' <param name="InstanceID"></param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property items(ByVal InstanceID As Integer) As ServerInfo
        Get
            For Each SvrInfo As ServerInfo In _Items
                If SvrInfo.ID.Equals(InstanceID) Then
                    Return SvrInfo
                End If
            Next
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' 그룹 클래스 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ServerInfo
	   'Robin-Start add HA info 
        'Public Sub New(ByVal intInstanceID As Integer, ByVal strIP As String, ByVal strID As String, ByVal intPort As Integer, ByVal strDBName As String, ByVal AliasName As String, ByVal HostName As String, ByVal stTime As DateTime)
        Public Sub New(ByVal intInstanceID As Integer, ByVal strIP As String, ByVal strID As String, ByVal intPort As Integer, ByVal strDBName As String, ByVal AliasName As String, ByVal HostName As String, ByVal stTime As DateTime, ByVal strHARole As String, ByVal strHAHost As String, ByVal strHAPort As String)
            _InstanceID = intInstanceID
            _IP = strIP
            _ID = strID
            _Port = intPort
            _DBName = strDBName
            _AliasNm = AliasName
            _HostNm = HostName
            _StartTime = stTime
	   'Robin-Start add HA info 
            _HARole = strHARole
            _HAHost = strHAHost
            _HAPort = strHAPort
    	   'Robin-End add HA info end
        End Sub

        Private _InstanceID As Integer = -1
        ''' <summary>
        ''' 서버 ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property InstanceID
            Get
                Return _InstanceID
            End Get
        End Property


        Private _IP As String
        ''' <summary>
        ''' 서버 IP
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property IP As String
            Get
                Return _IP
            End Get
        End Property

        Private _ID As String
        ''' <summary>
        ''' 서버 접속 계정 ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property ID As String
            Get
                Return _ID
            End Get
        End Property

        Private _Port As Integer
        ''' <summary>
        ''' 서버 접속 포트 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property Port As Integer
            Get
                Return _Port
            End Get
        End Property

        Private _DBName As String
        ''' <summary>
        ''' 서버 DataBase 명칭 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property DBName As String
            Get
                Return _DBName
            End Get
        End Property



        Private _AliasNm As String = ""
        ''' <summary>
        ''' 서버 별칭 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property AliasNm As String
            Get
                Return _AliasNm
            End Get
        End Property

        Private _HostNm As String = ""
        ''' <summary>
        ''' Host Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property HostNm As String
            Get
                Return _HostNm
            End Get
        End Property

        Private _StartTime As DateTime = DateTime.MinValue
        ''' <summary>
        ''' 서버 기동 시간 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property StartTime As DateTime
            Get
                Return _StartTime
            End Get
        End Property


        ReadOnly Property ShowNm As String
            Get
                If p_ShowName = clsEnums.ShowName.HostName Then
                    Return _HostNm
                Else
                    Return _AliasNm
                End If
            End Get
        End Property
   'Robin-Start add HA info 
        Private _HARole As String = ""
        ''' <summary>
        ''' HA Host Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property HARole As String
            Get
                Return _HARole
            End Get
        End Property
        Private _HAHost As String = ""
        ''' <summary>
        ''' Host Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property HAHost As String
            Get
                Return _HAHost
            End Get
        End Property
        Private _HAPort As String = ""
        ''' <summary>
        ''' Host Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property HAPort As String
            Get
                Return _HAPort
            End Get
        End Property
   'Robin-end add HA info end
    End Class


  
End Class

Public Class structAgent
    Private _AgentIP As String = ""
    ReadOnly Property AgentIP As String
        Get
            Return _AgentIP
        End Get
    End Property

    Private _AgentPort As Integer = 0
    ReadOnly Property AgentPort As Integer
        Get
            Return _AgentPort
        End Get
    End Property

    Public Sub New(ByVal strIP As String, ByVal intPort As Integer)
        _AgentIP = strIP
        _AgentPort = intPort
    End Sub
End Class

Public Structure License
    Private _Serial As String
    Private _AgentIP As String
    Private _AgentPort As Integer
    Private _DbPort As Integer
    Private _Trial As Boolean
    Private _CoreCnt As Integer
    Private _InstanceCnt As Integer
    Private _CreateDate As Date
    Private _ExpireDate As Date

    ReadOnly Property Serial As String
        Get
            Return _Serial
        End Get
    End Property
    ReadOnly Property AgentIP As String
        Get
            Return _AgentIP
        End Get
    End Property
    ReadOnly Property AgentPort As Integer
        Get
            Return _AgentPort
        End Get
    End Property
    ReadOnly Property DbPort As Integer
        Get
            Return _DbPort
        End Get
    End Property
    ReadOnly Property Trial As Boolean
        Get
            Return _Trial
        End Get
    End Property
    ReadOnly Property CoreCnt As Integer
        Get
            Return _Trial
        End Get
    End Property
    ReadOnly Property InstanceCnt As Integer
        Get
            Return _InstanceCnt
        End Get
    End Property
    ReadOnly Property CreateDate As Date
        Get
            Return _CreateDate
        End Get
    End Property
    ReadOnly Property ExpireDate As Date
        Get
            Return _ExpireDate
        End Get
    End Property





    Public Sub New(ByVal strLicense As String, ByVal DecKey As String)
        Dim strRslt As String = ""
        If DecKey.Length <> 8 Then
            Return
        Else
            Dim btKey As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(DecKey)
            strRslt = Decrypt(strLicense, btKey)

        End If

        If strRslt <> "" Then
            _Serial = strRslt.Substring(0, 24)
            _AgentIP = strRslt.Substring(24, 15)
            _AgentPort = CInt(strRslt.Substring(39, 6))
            _DbPort = CInt(strRslt.Substring(45, 6))
            _Trial = IIf(strRslt.Substring(51, 1) = "Y", True, False)
            _CoreCnt = CInt(strRslt.Substring(52, 5))
            _InstanceCnt = CInt(strRslt.Substring(57, 5))
            Dim tmpStr As String = strRslt.Substring(62, 8)
            _CreateDate = New Date(tmpStr.Substring(0, 4), tmpStr.Substring(4, 2), tmpStr.Substring(6, 2))
            Dim tmpStr1 As String = strRslt.Substring(70, 8)
            _ExpireDate = New Date(tmpStr1.Substring(0, 4), tmpStr1.Substring(4, 2), tmpStr1.Substring(6, 2))
        End If

    End Sub


    Private Function Decrypt(ByVal strValue As String, ByVal DecKey As Byte()) As String
        Try
            Dim rtnValue As String = ""
            If String.IsNullOrEmpty(strValue) = True Then Return ""

            Dim CryptProvider As System.Security.Cryptography.DESCryptoServiceProvider = New System.Security.Cryptography.DESCryptoServiceProvider
            Dim MemStream As System.IO.MemoryStream = New System.IO.MemoryStream(Convert.FromBase64String(strValue))
            Dim CryptStream As System.Security.Cryptography.CryptoStream = New System.Security.Cryptography.CryptoStream(MemStream, CryptProvider.CreateDecryptor(DecKey, DecKey), System.Security.Cryptography.CryptoStreamMode.Read)

            Dim ReaderStream As System.IO.StreamReader = New System.IO.StreamReader(CryptStream)
            rtnValue = ReaderStream.ReadToEnd
            ReaderStream.Close()
            ReaderStream.Dispose()
            CryptStream.Close()
            CryptStream.Dispose()
            CryptProvider.Clear()
            Return rtnValue
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            Return ""
        End Try

    End Function


End Structure
