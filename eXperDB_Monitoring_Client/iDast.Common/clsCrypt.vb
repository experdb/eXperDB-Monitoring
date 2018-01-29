Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class ClsCrypt


    Public Const FormatDelimeter As String = "|"
    Public Const ModeDelimeter As String = ","
    '프로그램 타입
    Public Shared ReadOnly iDAST_ProgramType(,) As String = {{"0", "Operation For Oracle"}, _
                                                      {"1", "Operation For PostgreSQL"}, _
                                                      {"2", "Data Migration"}, _
                                                      {"3", "SQL Name Mapper"}, _
                                                      {"4", "Ansi Join Converter"}, _
                                                      {"5", "CRUD&SQL Analysor"}, _
                                                      {"6", "SQL Extractor On Source"}, _
                                                      {"7", "Meta System"}, _
                                                      {"8", "Operation For Tibero"}}

    Public Function EncryptString(ByVal InputText As String, ByVal Password As String) As String

        Try
            ' Rihndael class를 선언하고, 초기화
            Dim RijndaelCipher As New RijndaelManaged()

            ' 입력받은 문자열을 바이트 배열로 변환
            Dim PlainText As Byte() = System.Text.Encoding.Unicode.GetBytes(InputText)

            ' 딕셔너리 공격을 대비해서 키를 더 풀기 어렵게 만들기 위해서 
            ' Salt를 사용한다.
            Dim Salt As Byte() = Encoding.ASCII.GetBytes("@NOHUNGYEOUNG@")

            ' PasswordDeriveBytes 클래스를 사용해서 SecretKey를 얻는다.
            'Dim SecretKey As New PasswordDeriveBytes(Password, Salt)
            Dim SecretKey As New Rfc2898DeriveBytes(Password, Salt)

            ' Create a encryptor from the existing SecretKey bytes.
            ' encryptor 객체를 SecretKey로부터 만든다.
            ' Secret Key에는 32바이트
            ' (Rijndael의 디폴트인 256bit가 바로 32바이트입니다)를 사용하고, 
            ' Initialization Vector로 16바이트
            ' (역시 디폴트인 128비트가 바로 16바이트입니다)를 사용한다.
            Dim Encryptor As ICryptoTransform = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16))

            ' 메모리스트림 객체를 선언,초기화 
            Dim memoryStream As New MemoryStream()

            ' CryptoStream객체를 암호화된 데이터를 쓰기 위한 용도로 선언
            Dim cryptoStream As New CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write)

            ' 암호화 프로세스가 진행된다.
            cryptoStream.Write(PlainText, 0, PlainText.Length)

            ' 암호화 종료
            cryptoStream.FlushFinalBlock()

            ' 암호화된 데이터를 바이트 배열로 담는다.
            Dim CipherBytes As Byte() = memoryStream.ToArray()

            ' 스트림 해제
            memoryStream.Close()
            cryptoStream.Close()

            ' 암호화된 데이터를 Base64 인코딩된 문자열로 변환한다.
            Dim EncryptedData As String = Convert.ToBase64String(CipherBytes)

            ' 최종 결과를 리턴
            Return EncryptedData

        Catch ex As Exception
            Return String.Empty
        End Try

    End Function

    Public Function DecryptString(ByVal InputText As String, ByVal Password As String) As String
        Try
            Dim RijndaelCipher As New RijndaelManaged()

            Dim EncryptedData As Byte() = Convert.FromBase64String(InputText)
            Dim Salt As Byte() = Encoding.ASCII.GetBytes("@NOHUNGYEOUNG@")

            'Dim SecretKey As New PasswordDeriveBytes(Password, Salt)
            Dim SecretKey As New Rfc2898DeriveBytes(Password, Salt)

            ' Decryptor 객체를 만든다.
            Dim Decryptor As ICryptoTransform = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16))

            Dim memoryStream As New MemoryStream(EncryptedData)

            ' 데이터 읽기(복호화이므로) 용도로 cryptoStream객체를 선언, 초기화
            Dim cryptoStream As New CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read)

            ' 복호화된 데이터를 담을 바이트 배열을 선언한다.
            ' 길이는 알 수 없지만, 일단 복호화되기 전의 데이터의 길이보다는
            ' 길지 않을 것이기 때문에 그 길이로 선언한다.
            Dim PlainText As Byte() = New Byte(EncryptedData.Length - 1) {}

            ' 복호화 시작
            Dim DecryptedCount As Integer = cryptoStream.Read(PlainText, 0, PlainText.Length)

            memoryStream.Close()
            cryptoStream.Close()

            ' 복호화된 데이터를 문자열로 바꾼다.
            Dim DecryptedData As String = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount)

            ' 최종 결과 리턴
            Return DecryptedData
        Catch ex As Exception
            Return String.Empty
        End Try

    End Function

    Public Function EncryptStringSHA256(ByVal InputText As String) As String
        Dim sha256Manage As New System.Security.Cryptography.SHA256Managed
        Dim rtnValue As String = Convert.ToBase64String(sha256Manage.ComputeHash(System.Text.Encoding.UTF8.GetBytes(InputText)))
        Return rtnValue

    End Function

    '접속모드 물리명 취득
    Public Function GetModePhscNm(ByVal pIndex As Integer) As String

        Return iDAST_ProgramType(pIndex, 1)

        'If pIndex = 0 Then
        '    Return iDastGlobal.iDAST_ProgramType(0, 1)
        'ElseIf pIndex = 1 Then
        '    Return iDastGlobal.iDAST_ProgramType(1, 1)
        'ElseIf pIndex = 2 Then
        '    Return iDastGlobal.iDAST_ProgramType(2, 1)
        'ElseIf pIndex = 3 Then
        '    Return iDastGlobal.iDAST_ProgramType(3, 1)
        'Else
        '    Return String.Empty
        'End If
    End Function

    Private Key() As Byte
    Private IVV() As Byte
    Public Function TDESImplementation(ByVal encryptionKey As String, ByVal IV As String)
        Key = Encoding.ASCII.GetBytes(encryptionKey)
        IVV = Encoding.ASCII.GetBytes(IV)
    End Function
    Public Function EncryptTDES(ByVal textToEncrypt As String) As String
        Dim tdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        tdes.Key = Key
        tdes.IV = IVV

        Dim buffer() As Byte = Encoding.ASCII.GetBytes(textToEncrypt)
        Return Convert.ToBase64String(tdes.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
    Public Function DecryptTDES(ByVal textToDecrypt As String) As String
        Dim buffer() As Byte = Convert.FromBase64String(textToDecrypt)

        Dim tdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        tdes.Key = Key
        tdes.IV = IVV

        Return Encoding.ASCII.GetString(tdes.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

End Class
