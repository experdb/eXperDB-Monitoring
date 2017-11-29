Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography

Public Class clsAes
    Private Shared ReadOnly _saltSize As Integer = 32
    Private Shared ReadOnly key As String = "806614782046401881849533239202200245775139129381741911552099916998951521678679"
    Public Shared Function Encrypt(plainText As String, key As String) As String
        If String.IsNullOrEmpty(plainText) Then
            Throw New ArgumentNullException("plainText")
        End If

        If String.IsNullOrEmpty(key) Then
            Throw New ArgumentNullException("key")
        End If

        Using keyDerivationFunction = New Rfc2898DeriveBytes(key, _saltSize)
            Dim saltBytes As Byte() = keyDerivationFunction.Salt
            Dim keyBytes As Byte() = keyDerivationFunction.GetBytes(32)
            Dim ivBytes As Byte() = keyDerivationFunction.GetBytes(16)

            Using aesManaged = New AesManaged()
                aesManaged.KeySize = 256

                Using encryptor = aesManaged.CreateEncryptor(keyBytes, ivBytes)
                    Dim memoryStream As MemoryStream = Nothing
                    Dim cryptoStream As CryptoStream = Nothing

                    Return WriteMemoryStream(plainText, saltBytes, encryptor, memoryStream, cryptoStream)
                End Using
            End Using
        End Using
    End Function
    Public Shared Function Encrypt(plainText As String) As String
        If String.IsNullOrEmpty(plainText) Then
            Throw New ArgumentNullException("plainText")
        End If

        If String.IsNullOrEmpty(key) Then
            Throw New ArgumentNullException("key")
        End If

        Using keyDerivationFunction = New Rfc2898DeriveBytes(key, _saltSize)
            Dim saltBytes As Byte() = keyDerivationFunction.Salt
            Dim keyBytes As Byte() = keyDerivationFunction.GetBytes(32)
            Dim ivBytes As Byte() = keyDerivationFunction.GetBytes(16)

            Using aesManaged = New AesManaged()
                aesManaged.KeySize = 256

                Using encryptor = aesManaged.CreateEncryptor(keyBytes, ivBytes)
                    Dim memoryStream As MemoryStream = Nothing
                    Dim cryptoStream As CryptoStream = Nothing

                    Return WriteMemoryStream(plainText, saltBytes, encryptor, memoryStream, cryptoStream)
                End Using
            End Using
        End Using
    End Function
    Public Shared Function Decrypt(ciphertext As String, key As String) As String
        If String.IsNullOrEmpty(ciphertext) Then
            Throw New ArgumentNullException("ciphertext")
        End If

        If String.IsNullOrEmpty(key) Then
            Throw New ArgumentNullException("key")
        End If

        Dim allTheBytes = Convert.FromBase64String(ciphertext)
        Dim saltBytes = allTheBytes.Take(_saltSize).ToArray()
        Dim ciphertextBytes = allTheBytes.Skip(_saltSize).Take(allTheBytes.Length - _saltSize).ToArray()

        Using keyDerivationFunction = New Rfc2898DeriveBytes(key, saltBytes)
            Dim keyBytes = keyDerivationFunction.GetBytes(32)
            Dim ivBytes = keyDerivationFunction.GetBytes(16)

            Return DecryptWithAES(ciphertextBytes, keyBytes, ivBytes)
        End Using
    End Function
    Public Shared Function Decrypt(ciphertext As String) As String
        If String.IsNullOrEmpty(ciphertext) Then
            Throw New ArgumentNullException("ciphertext")
        End If

        If String.IsNullOrEmpty(key) Then
            Throw New ArgumentNullException("key")
        End If

        Dim allTheBytes = Convert.FromBase64String(ciphertext)
        Dim saltBytes = allTheBytes.Take(_saltSize).ToArray()
        Dim ciphertextBytes = allTheBytes.Skip(_saltSize).Take(allTheBytes.Length - _saltSize).ToArray()

        Using keyDerivationFunction = New Rfc2898DeriveBytes(key, saltBytes)
            Dim keyBytes = keyDerivationFunction.GetBytes(32)
            Dim ivBytes = keyDerivationFunction.GetBytes(16)

            Return DecryptWithAES(ciphertextBytes, keyBytes, ivBytes)
        End Using
    End Function
    Private Shared Function WriteMemoryStream(plainText As String, ByRef saltBytes As Byte(), encryptor As ICryptoTransform, ByRef memoryStream As MemoryStream, ByRef cryptoStream As CryptoStream) As String
        Try
            memoryStream = New MemoryStream()

            Try
                cryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

                Using streamWriter = New StreamWriter(cryptoStream)
                    streamWriter.Write(plainText)
                End Using
            Finally
                If cryptoStream IsNot Nothing Then
                    cryptoStream.Dispose()
                End If
            End Try

            Dim cipherTextBytes = memoryStream.ToArray()
            Array.Resize(saltBytes, saltBytes.Length + cipherTextBytes.Length)
            Array.Copy(cipherTextBytes, 0, saltBytes, _saltSize, cipherTextBytes.Length)

            Return Convert.ToBase64String(saltBytes)
        Finally
            If memoryStream IsNot Nothing Then
                memoryStream.Dispose()
            End If
        End Try
    End Function

    Private Shared Function DecryptWithAES(ciphertextBytes As Byte(), keyBytes As Byte(), ivBytes As Byte()) As String
        Using aesManaged = New AesManaged()
            Using decryptor = aesManaged.CreateDecryptor(keyBytes, ivBytes)
                Dim memoryStream As MemoryStream = Nothing
                Dim cryptoStream As CryptoStream = Nothing
                Dim streamReader As StreamReader = Nothing

                Try
                    memoryStream = New MemoryStream(ciphertextBytes)
                    cryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
                    streamReader = New StreamReader(cryptoStream)

                    Return streamReader.ReadToEnd()
                Finally
                    If memoryStream IsNot Nothing Then
                        memoryStream.Dispose()
                        memoryStream = Nothing
                    End If
                End Try
            End Using
        End Using
    End Function
End Class
