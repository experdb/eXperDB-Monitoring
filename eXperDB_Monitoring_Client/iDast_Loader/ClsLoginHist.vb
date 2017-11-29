Imports System.IO
Imports DX.Common

Public Class ClsLoginHist
    Private CC As New ClsCrypt
    Private COC As New ClsObjectCtl

    Private LogHistPath As String = String.Empty
    Private LogHistFileName As String = String.Empty
    Private FullName As String = String.Empty
    Private TmpConnHistory As Object
    Private SavePw As Boolean = True

    Public Sub New(ByVal pLoginHistoryPath As String, _
                   ByVal pLoginHistoryFileName As String)

        LogHistPath = pLoginHistoryPath
        LogHistFileName = pLoginHistoryFileName
        FullName = LogHistPath & Path.DirectorySeparatorChar & LogHistFileName

        COC.MakeDir(LogHistPath)
    End Sub

    Public Function getExistLoginFile() As Boolean
        Return (File.Exists(FullName))
    End Function

    'Public Overloads Sub UpdateLoginHistory(ByVal pStructure As modOraGlobal.OraConnHist, ByVal pSavePw As Boolean)

    '    Try
    '        TmpConnHistory = pStructure
    '        SavePw = pSavePw

    '        If File.Exists(FullName) Then '기존 파일이 있으면
    '            LoginHistoryData()
    '        Else ' 기존 파일이 없으면
    '            WriteLoginHistory()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("접속로그 Control 에러!", MsgBoxStyle.Critical, "에러")
    '    End Try

    'End Sub

    Public Overloads Sub UpdateLoginHistory(ByVal pStructure As modLoaderGlobal.OdbcConnHist, ByVal pSavePw As Boolean)

        Try
            TmpConnHistory = pStructure
            SavePw = pSavePw

            If File.Exists(FullName) Then '기존 파일이 있으면
                LoginHistoryData()
            Else ' 기존 파일이 없으면
                WriteLoginHistory()
            End If
        Catch ex As Exception
            MsgBox("접속로그 Control 에러!", MsgBoxStyle.Critical, "에러")
        End Try

    End Sub


    Public Function PopluateLoginHistory() As DataTable
        Dim tDT As DataTable = New DataTable
        Dim Str As String = String.Empty
        Dim deStr As String() = Nothing

        If iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(0, 0) Then '오라클 이면
            With tDT
                .Columns.Clear()
                .Columns.Add(New DataColumn("USERTYPE", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("CONTYPE", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("HOSTIP", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("USERID", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("REALCONSID", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PORT", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PASSWD", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("REGDT", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("DELKEY", System.Type.GetType("System.String")))
            End With

            Using FReader = New StreamReader(FullName)
                Do While Not FReader.Peek = -1
                    Str = FReader.ReadLine
                    deStr = CC.DecryptString(Str, "@NOHUNGYEOUNG@").Split(ClsCrypt.FormatDelimeter)
                    tDT.Rows.Add(deStr(0), deStr(1), deStr(2), deStr(3), deStr(4), deStr(5), deStr(6), deStr(7), Str)
                Loop
            End Using
        ElseIf iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(2, 0) Then 'Any DB 접속이면
            With tDT
                .Columns.Clear()
                .Columns.Add(New DataColumn("USERTYPE", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("USERID", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("ODBCDRIVER", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("SERVERIP", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("DBNAME", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PORT", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PASSWD", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("SCHEMA_NAME", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("REGDT", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("DELKEY", System.Type.GetType("System.String")))
            End With

            Using FReader = New StreamReader(FullName)
                Do While Not FReader.Peek = -1
                    Str = FReader.ReadLine
                    deStr = CC.DecryptString(Str, "@NOHUNGYEOUNG@").Split(ClsCrypt.FormatDelimeter)
                    tDT.Rows.Add(deStr(0), deStr(1), deStr(2), deStr(3), deStr(4), deStr(5), deStr(6), deStr(7), deStr(8), Str)
                Loop
            End Using
        ElseIf iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(7, 0) Then 'ODBC 접속이면
            With tDT
                .Columns.Clear()
                .Columns.Add(New DataColumn("USERTYPE", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PROJECTNAME", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("SYSTEMNAME", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("USERID", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("ODBCDRIVER", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("SERVERIP", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("DBNAME", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PORT", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("PASSWD", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("REGDT", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("DELKEY", System.Type.GetType("System.String")))
            End With

            Using FReader = New StreamReader(FullName)
                Do While Not FReader.Peek = -1
                    Str = FReader.ReadLine
                    deStr = CC.DecryptString(Str, "@NOHUNGYEOUNG@").Split(ClsCrypt.FormatDelimeter)
                    tDT.Rows.Add(deStr(0), deStr(1), deStr(2), deStr(3), deStr(4), deStr(5), deStr(6), deStr(7), deStr(8), deStr(9), Str)
                Loop
            End Using

        End If

        Return tDT
    End Function

    Private Sub LoginHistoryData()

        Dim DataLines As New List(Of String)
        Dim FinDataLines As New List(Of String)
        Try

            '파일에 데이터를 List에 담기
            Dim Str As String = String.Empty
            Using FReader = New StreamReader(FullName)
                Do While Not FReader.Peek = -1
                    Str = FReader.ReadLine
                    DataLines.Add(Str)
                Loop
            End Using

            '리스트에서 추출하기
            Dim deStr As String() = Nothing
            Dim InsertYN As Boolean = True

            For Each line As String In DataLines

                '암호화 해제
                deStr = CC.DecryptString(line, "@NOHUNGYEOUNG@").Split(ClsCrypt.FormatDelimeter)

                If iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(0, 0) Then '오라클 이면
                    '중복Key값 정의하여 같은지 여부 판단
                    Dim CheckConnType As String = String.Empty
                    If TmpConnHistory.ConnInfo.CONTYPE = "TNS" Then
                        CheckConnType = TmpConnHistory.TnsName
                    Else
                        CheckConnType = TmpConnHistory.ConnInfo.REALCONSID
                    End If

                    '데이터 넣을건지 갱신할건지 판단하여 수행
                    If TmpConnHistory.ConnInfo.USERTYPE = deStr(0) And _
                       TmpConnHistory.ConnInfo.CONTYPE = deStr(1) And _
                       TmpConnHistory.HostIP = deStr(2) And _
                       TmpConnHistory.ConnInfo.USERID = deStr(3) And _
                       CheckConnType = deStr(4) And _
                       TmpConnHistory.Port = deStr(5) Then

                        FinDataLines.Add(CC.EncryptString(MakeLoginHistoryFormat, "@NOHUNGYEOUNG@"))
                        InsertYN = False

                    Else
                        FinDataLines.Add(line)
                    End If
                ElseIf iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(2, 0) Then 'Any DB 접속이면
                    '데이터 넣을건지 갱신할건지 판단하여 수행
                    If TmpConnHistory.ConnInfo.USERTYPE = deStr(0) And _
                       TmpConnHistory.ConnInfo.USERID = deStr(1) And _
                       TmpConnHistory.ConnInfo.ODBCDRIVER = deStr(2) And _
                       TmpConnHistory.ConnInfo.SERVERIP = deStr(3) And _
                       TmpConnHistory.ConnInfo.DBNAME = deStr(4) And _
                       TmpConnHistory.ConnInfo.PORT = deStr(5) And _
                       TmpConnHistory.ConnInfo.SCHEMA_NAME = deStr(7) Then

                        FinDataLines.Add(CC.EncryptString(MakeLoginHistoryFormat, "@NOHUNGYEOUNG@"))
                        InsertYN = False

                    Else
                        FinDataLines.Add(line)
                    End If
                ElseIf iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(7, 0) Then '마이그래이션 및 모델링 이면
                    '데이터 넣을건지 갱신할건지 판단하여 수행
                    If TmpConnHistory.ConnInfo.USERTYPE = deStr(0) And _
                       TmpConnHistory.ProjectName = deStr(1) And _
                       TmpConnHistory.SystemName = deStr(2) And _
                       TmpConnHistory.ConnInfo.USERID = deStr(3) And _
                       TmpConnHistory.ConnInfo.ODBCDRIVER = deStr(4) And _
                       TmpConnHistory.ConnInfo.SERVERIP = deStr(5) And _
                       TmpConnHistory.ConnInfo.DBNAME = deStr(6) And _
                       TmpConnHistory.ConnInfo.PORT = deStr(7) Then

                        FinDataLines.Add(CC.EncryptString(MakeLoginHistoryFormat, "@NOHUNGYEOUNG@"))
                        InsertYN = False

                    Else
                        FinDataLines.Add(line)
                    End If

                End If
            Next

            '최종 갱신
            Using FinWrite As New StreamWriter(FullName, False)
                For Each line As String In FinDataLines
                    FinWrite.WriteLine(line)
                Next
                If InsertYN = True Then
                    '암호화한후 파일에 쓰기
                    FinWrite.WriteLine(CC.EncryptString(MakeLoginHistoryFormat, "@NOHUNGYEOUNG@"))
                End If
            End Using

        Catch ex As Exception
            MsgBox("접속로그 Control(Exist) 에러!", MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Public Sub DeleteData(ByVal pDelKey As String)
        Try
            '파일에 데이터를 List에 담기
            Dim Str As String = String.Empty
            Dim DataLines As New List(Of String)
            Using FReader = New StreamReader(FullName)
                Do While Not FReader.Peek = -1
                    Str = FReader.ReadLine
                    If pDelKey <> Str Then
                        DataLines.Add(Str)
                    End If
                Loop
            End Using

            '최종 갱신
            Using FinWrite As New StreamWriter(FullName, False)
                For Each line As String In DataLines
                    FinWrite.WriteLine(line)
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "에러")
        End Try

    End Sub


    Private Sub WriteLoginHistory()
        Dim Str As String = String.Empty
        Try
            Using FWriter As New StreamWriter(FullName, False)
                '대상데이터 암호화
                Str = MakeLoginHistoryFormat()
                FWriter.WriteLine(CC.EncryptString(Str, "@NOHUNGYEOUNG@"))
            End Using
        Catch ex As Exception
            MsgBox("접속로그 Control 에러!", MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Private Function MakeLoginHistoryFormat() As String
        Dim outStr As String = String.Empty
        Dim rePasswd As String = String.Empty

        If SavePw = True Then
            rePasswd = TmpConnHistory.ConnInfo.USERPW
        Else
            rePasswd = String.Empty
        End If

        If iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(0, 0) Then '오라클 이면

            '프로그램타입 | 접속타입 | 호스트ip | 유저id | 서비스명 | 포트 | 패스워드 | 등록일
            If TmpConnHistory.ConnInfo.CONTYPE = "TNS" Then
                outStr = TmpConnHistory.ConnInfo.USERTYPE & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.ConnInfo.CONTYPE & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.HostIP & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.ConnInfo.USERID & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.TnsName & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.Port & ClsCrypt.FormatDelimeter & _
                       rePasswd & ClsCrypt.FormatDelimeter & _
                       Now
            Else
                outStr = TmpConnHistory.ConnInfo.USERTYPE & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.ConnInfo.CONTYPE & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.HostIP & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.ConnInfo.USERID & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.ConnInfo.REALCONSID & ClsCrypt.FormatDelimeter & _
                       TmpConnHistory.Port & ClsCrypt.FormatDelimeter & _
                       rePasswd & ClsCrypt.FormatDelimeter & _
                       Now
            End If
        ElseIf iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(2, 0) Then 'Any DB 접속이면
            outStr = TmpConnHistory.ConnInfo.USERTYPE & ClsCrypt.FormatDelimeter & _
            TmpConnHistory.ConnInfo.USERID & ClsCrypt.FormatDelimeter & _
            TmpConnHistory.ConnInfo.ODBCDRIVER & ClsCrypt.FormatDelimeter & _
            TmpConnHistory.ConnInfo.SERVERIP & ClsCrypt.FormatDelimeter & _
            TmpConnHistory.ConnInfo.DBNAME & ClsCrypt.FormatDelimeter & _
            TmpConnHistory.ConnInfo.PORT & ClsCrypt.FormatDelimeter & _
            rePasswd & ClsCrypt.FormatDelimeter & _
            TmpConnHistory.ConnInfo.SCHEMA_NAME & ClsCrypt.FormatDelimeter & _
            Now
        ElseIf iDAST_CurrentProgramType = ClsCrypt.iDAST_ProgramType(7, 0) Then '마이그래이션 및 모델링 이면

            outStr = TmpConnHistory.ConnInfo.USERTYPE & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.ProjectName & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.SystemName & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.ConnInfo.USERID & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.ConnInfo.ODBCDRIVER & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.ConnInfo.SERVERIP & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.ConnInfo.DBNAME & ClsCrypt.FormatDelimeter & _
                    TmpConnHistory.ConnInfo.PORT & ClsCrypt.FormatDelimeter & _
                    rePasswd & ClsCrypt.FormatDelimeter & _
                    Now

        End If
        Return outStr
    End Function
End Class
