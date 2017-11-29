Imports System.Security
Imports System.IO
Imports System

Public Class clsSecurity
    Dim _key() As Byte


    Public Sub New(ByVal strSecurityKey As String)
        If Text.ASCIIEncoding.ASCII.GetByteCount(strSecurityKey) <> 8 Then
            Return
        End If

        _key = Text.ASCIIEncoding.ASCII.GetBytes(strSecurityKey)

    End Sub
    Private Function _ChkKeyLength() As Boolean
        If _key.Length <> 8 Then
            Return False
        Else
            Return True
        End If

    End Function




    Public Function Encrypt(ByVal strValue As String) As String
        Try
            Dim rtnValue As String = ""
            If String.IsNullOrEmpty(strValue) = True Then Return ""
            If _ChkKeyLength() = False Then Return ""
            Dim CryptProvider As Cryptography.DESCryptoServiceProvider = New Cryptography.DESCryptoServiceProvider
            Dim MemStream As MemoryStream = New MemoryStream
            Dim CryptStream As Cryptography.CryptoStream = _
                        New Cryptography.CryptoStream(MemStream, CryptProvider.CreateEncryptor(_key, _key), Cryptography.CryptoStreamMode.Write)
            Dim WriterStream As StreamWriter = New StreamWriter(CryptStream)
            WriterStream.Write(strValue)
            WriterStream.Flush()
            CryptStream.FlushFinalBlock()
            WriterStream.Flush()
            rtnValue = Convert.ToBase64String(MemStream.GetBuffer, Base64FormattingOptions.None, CInt(MemStream.Length))
            WriterStream.Close()
            WriterStream.Dispose()
            CryptStream.Close()
            CryptStream.Dispose()
            MemStream.Close()
            MemStream.Dispose()
            CryptProvider.Clear()

            Return rtnValue
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            Return ""
        End Try
    End Function

    Public Function Decrypt(ByVal strValue As String) As String
        Try
            Dim rtnValue As String = ""
            If String.IsNullOrEmpty(strValue) = True Then Return ""
            If _ChkKeyLength() = False Then Return ""
            Dim CryptProvider As Cryptography.DESCryptoServiceProvider = New Cryptography.DESCryptoServiceProvider
            Dim MemStream As MemoryStream = New MemoryStream(Convert.FromBase64String(strValue))
            Dim CryptStream As Cryptography.CryptoStream = New Cryptography.CryptoStream(MemStream, CryptProvider.CreateDecryptor(_key, _key), Cryptography.CryptoStreamMode.Read)

            Dim ReaderStream As StreamReader = New StreamReader(CryptStream)
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
End Class