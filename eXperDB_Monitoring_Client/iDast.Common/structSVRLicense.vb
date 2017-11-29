Public Structure structSVRLicense
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
            _isValidate = False
            Return
        Else
            Dim btKey As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(DecKey)
            strRslt = Decrypt(strLicense, btKey)
        End If

        Try
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
                _isValidate = True
            Else
                _isValidate = False
            End If
        Catch ex As Exception
            _isValidate = False
        End Try

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

    Public Encrypt
    Private _isValidate As Boolean
    ReadOnly Property isValidate As Boolean
        Get
            Return _isValidate
        End Get
    End Property

End Structure
