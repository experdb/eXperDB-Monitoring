Imports System.IO
Imports System.Collections

Public Class ClsMetaDbCtl

    Private CC As New ClsCrypt
    Private _fileName As String

    Public Function MakeEncryptString(ByVal arrList As ArrayList) As String

        Dim outStr As String = String.Empty

        For Each lst In arrList
            outStr = outStr & ClsCrypt.FormatDelimeter & lst.ToString
        Next
        outStr = outStr.TrimStart(ClsCrypt.FormatDelimeter)

        Return CC.EncryptString(outStr, "@NOHUNGYEOUNG@")

    End Function

   


    Private Function ReturnDescriptString(ByVal pStr As String) As ArrayList

        Dim deStr As String() = Nothing
        Dim outAL As ArrayList = New ArrayList
        deStr = CC.DecryptString(pStr, "@NOHUNGYEOUNG@").Split(ClsCrypt.FormatDelimeter)
        For i = 0 To UBound(deStr)
            outAL.Add(deStr(i))
        Next
        Return outAL

    End Function

    '===========================
    'METADB 정보 설정하기
    '===========================
    Public Function SetMetaDbInfo(ByVal WriteFile As String, ByVal strAlias As String, ByVal strData As String, BretAppend As Boolean) As Boolean
        Try

            Using FWriter As New StreamWriter(WriteFile, BretAppend)
                FWriter.WriteLine(CC.EncryptString(strAlias, "@NOHUNGYEOUNG@") & ClsCrypt.FormatDelimeter & CC.EncryptString(strData, "@NOHUNGYEOUNG@"))
            End Using
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    
    Public Function GetMetaDbInfo(ByVal WriteFile As String, ByVal AliasName As String) As ArrayList
        Dim Str As String = String.Empty
        Dim outData As ArrayList = New ArrayList
        Try

            Using FReader = New StreamReader(WriteFile)
                Do Until FReader.EndOfStream
                    Str = FReader.ReadLine
                    If Str.IndexOf(ClsCrypt.FormatDelimeter) > 0 Then
                        Dim tmpAlias As String = Str.Split(ClsCrypt.FormatDelimeter)(0)
                        tmpAlias = CC.DecryptString(tmpAlias, "@NOHUNGYEOUNG@")
                        If tmpAlias.Equals(AliasName) Then
                            Str = Str.Substring(Str.IndexOf(ClsCrypt.FormatDelimeter) + 1)
                            outData = ReturnDescriptString(Str)
                            Return outData
                        End If

                    End If

                Loop
            End Using

            If Str = "" Then
                outData = New ArrayList
            End If

            Return outData
        Catch ex As Exception
            Return outData
        End Try
    End Function

    Public Function GetMetaDbList(ByVal WriteFile As String) As ArrayList
        Dim str As String = String.Empty
        Dim rtnArr As New ArrayList

        Try
            Using Freader As StreamReader = New StreamReader(WriteFile)
                Do Until Freader.EndOfStream
                    str = Freader.ReadLine
                    If str.IndexOf(ClsCrypt.FormatDelimeter) > 0 Then
                        str = str.Split(ClsCrypt.FormatDelimeter)(0)
                        str = CC.DecryptString(str, "@NOHUNGYEOUNG@")
                        rtnArr.Add(str)
                    End If
                Loop
            End Using


        Catch ex As Exception
            GC.Collect()
        Finally

        End Try
        Return rtnArr

    End Function

    Public Function CheckDbInfo(ByVal WriteFile As String) As Boolean
        If GetMetaDbList(WriteFile).Count = 0 Then
            Return False
        End If
        Return True
    End Function

End Class
