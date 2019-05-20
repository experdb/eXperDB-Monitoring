Imports System.ComponentModel

Public Class clsAgentEMsg

    Private WithEvents clsSck As clsSocket

    Public Event Progress(ByVal sender As Object, ByVal e As clsSocket.ProgArgs)
    Public Event Complete(ByVal sender As Object, ByVal e As Object)

    Public Sub New(ByVal strIP As String, ByVal intPort As Integer, Optional ByVal intReqTime As Integer = 30000, Optional ByVal intRepTime As Integer = 30000)
        clsSck = New clsSocket(strIP, intPort, intReqTime, intRepTime)

    End Sub

    Private Sub clsSck_Complete(sender As Object, e As clsSocket.Results) Handles clsSck.Complete
        Dim rtnObj As Object = Nothing
        If e.ResponseMsg.Length > 0 Then
            Dim rtnMsg As String = e.ResponseMsg.Substring(10)
            Dim clscm As MsgCommon = Newtonsoft.Json.JsonConvert.DeserializeObject(Of MsgCommon)(rtnMsg)

            Select Case clscm._tran_cd
                'Case "DX006"
                '    Dim rtntmpCls As DX006_REP_TMP = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DX006_REP_TMP)(rtnMsg)
                '    Dim rtnCls As New DX006_REP
                '    If rtntmpCls._tran_res_data IsNot Nothing Then
                '        Dim jArr As Newtonsoft.Json.Linq.JArray = DirectCast(rtntmpCls._tran_res_data, Newtonsoft.Json.Linq.JArray)
                '        If DirectCast(rtntmpCls._tran_res_data, Newtonsoft.Json.Linq.JArray)(0)("_error_cd") Is Nothing Then
                '            rtnCls._tran_sub_cd = DirectCast(jArr(0), Newtonsoft.Json.Linq.JObject)("_tran_sub_cd")
                '            Select Case rtnCls._tran_sub_cd
                '                Case "5"
                '                    For i As Integer = 1 To jArr.Count - 1
                '                        Dim strFileName As String = DirectCast(jArr(i), Newtonsoft.Json.Linq.JObject)("filename")
                '                        Dim strFileTime As String = DirectCast(jArr(i), Newtonsoft.Json.Linq.JObject)("filetime")
                '                        Dim fileLength As ULong = DirectCast(jArr(i), Newtonsoft.Json.Linq.JObject)("len")
                '                        rtnCls.DATAS.Add(New DATALIST(strFileName, strFileTime, fileLength))
                '                    Next
                '                Case "6"
                '                    rtnCls.offSet = DirectCast(jArr(0), Newtonsoft.Json.Linq.JObject)("offset")
                '                    For i As Integer = 1 To jArr.Count - 1
                '                        Dim strLogLine As String = DirectCast(jArr(i), Newtonsoft.Json.Linq.JToken)
                '                        rtnCls.DATAS.Add(New DATALIST(strLogLine, "", 0))
                '                    Next
                '                Case Else
                '            End Select
                '        Else
                '            rtnCls.ERRORS = New ErrorResponse(jArr(0)("_error_cd"), jArr(0)("_error_msg"))
                '        End If
                '    End If
                '    rtnObj = rtnCls
                Case "DX100"
                    rtnObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DX100_REP)(rtnMsg)
                    rtnObj = rtnObj._tran_res_data
            End Select
        Else
            rtnObj = e
        End If

        RaiseEvent Complete(sender, rtnObj)
    End Sub

    Private Sub clsSck_Progress(sender As Object, e As clsSocket.ProgArgs) Handles clsSck.Progress
        RaiseEvent Progress(sender, e)
    End Sub

    Private Function MakeFullEMsg(ByVal strEMsg As String) As String
        Dim intLen As Byte() = System.Text.Encoding.UTF8.GetBytes(strEMsg)

        Dim rtnSTr As String = intLen.Length.ToString("0000000000") & strEMsg
        Return rtnSTr

    End Function

    Private Function MakeBase64(ByVal strValue As String) As String
        Try
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(strValue)
            Return Convert.ToBase64String(bytes)
        Catch ex As Exception
            Return ""
        End Try

    End Function


#Region "Common Class"
    Public Class InstanceConnInfo
        Property targetip As String
        Property targetport As String
        Property username As String
        Property database As String
        Property password As String
        Public Sub New(ByVal strIP As String, ByVal intPort As String, ByVal strUserNm As String, ByVal DBNm As String, ByVal strPW As String)
            targetip = strIP
            targetport = intPort
            username = strUserNm
            database = DBNm
            password = strPW
        End Sub
    End Class
    Public Class ErrorResponse
        Property _error_cd As String
        Property _error_msg As String
        Public Sub New(ByVal errcd As String, ByVal errMsg As String)
            _error_cd = errcd
            _error_msg = errMsg
        End Sub
    End Class

    Public Class MsgCommon
        Property _tran_cd As String
    End Class
    Private _MsgThread As Threading.Thread
#End Region

#Region "DX003 인스턴스접속확인"


    Public Class DX003_REQ
        Property _tran_cd As String = "DX003"
        Property _tran_req_data As New List(Of DX003_InstanceInfo)

        Public Sub New(ByVal strIP As String, ByVal intPort As Integer, ByVal strUserNm As String, ByVal DBNm As String, ByVal strPW As String, ByVal InstanceCnt As String)
            _tran_req_data.Add(New DX003_InstanceInfo(strIP, intPort, strUserNm, DBNm, strPW, InstanceCnt))
        End Sub
    End Class

    Public Class DX003_InstanceInfo

        Property targetip As String
        Property targetport As String
        Property username As String
        Property database As String
        Property password As String
        Property instance_cnt As String
        Public Sub New(ByVal strIP As String, ByVal intPort As String, ByVal strUserNm As String, ByVal DBNm As String, ByVal strPW As String, ByVal InstanceCnt As String)
            targetip = strIP
            targetport = intPort
            username = strUserNm
            database = DBNm
            password = strPW
            instance_cnt = InstanceCnt
        End Sub
    End Class


    Public Class DX003_REP
        Property _tran_cd As String
        Property _tran_res_data As List(Of ErrorResponse)
    End Class

    <Description("DX003 : 인스턴스 접속 확인")> _
    Public Sub SendDX003(ByVal strIp As String, ByVal intPort As Integer, ByVal strUsrNm As String, ByVal DBNm As String, ByVal strPW As String, ByVal InstanceCnt As String)
        Try

            _MsgThread = New Threading.Thread(Sub()
                                                  Dim clsReq As New DX003_REQ(strIp, intPort, strUsrNm, DBNm, strPW, InstanceCnt)

                                                  Dim strReq As String = Newtonsoft.Json.JsonConvert.SerializeObject(clsReq)

                                                  strReq = MakeFullEMsg(strReq)
                                                  clsSck.SendMessage(strReq)
                                              End Sub)
            _MsgThread.Start()

        Catch ex As Exception
            RaiseEvent Complete(Me, New clsSocket.Results(clsSocket.enumResult.Error, "", "", ex.ToString, clsSck.SvrIP, clsSck.SvrPort))

        End Try

    End Sub

#End Region

#Region "DX004 DB 목록 요청 "

    Public Class DX004_REQ
        Property _tran_cd As String = "DX004"
        Property _tran_req_data As New List(Of InstanceConnInfo)
        Public Sub New(ByVal strIP As String, ByVal intPort As Integer, ByVal strUserNm As String, ByVal DBNm As String, ByVal strPW As String)
            _tran_req_data.Add(New InstanceConnInfo(strIP, intPort, strUserNm, DBNm, strPW))
        End Sub

    End Class
    Private Class DX004_REP_TMP
        Property _tran_cd As String
        Property _tran_res_data As Object
    End Class

    Public Class DX004_REP
        Property _tran_cd As String = "DX004"
        Property ERRORS As ErrorResponse
        Property DATAS As New List(Of DBLIST)
    End Class

    Public Class DBLIST
        Property DBName As String
        Property Schema As String()
        Public Sub New(ByVal strDb As String, ByVal strSch As String)
            DBName = strDb
            Schema = strSch.Split("|")

        End Sub
    End Class

    <Description("DX004 : DB목록 요청")> _
    Public Sub SendDX004(ByVal strIp As String, ByVal intPort As Integer, ByVal strUsrNm As String, ByVal strPW As String)
        Try

            _MsgThread = New Threading.Thread(Sub()
                                                  Dim clsReq As New DX004_REQ(strIp, intPort, strUsrNm, "postgres", strPW)

                                                  Dim strReq As String = Newtonsoft.Json.JsonConvert.SerializeObject(clsReq)

                                                  strReq = MakeFullEMsg(strReq)
                                                  clsSck.SendMessage(strReq)
                                              End Sub)
            _MsgThread.Start()
            'Return rtnCls
        Catch ex As Exception
            RaiseEvent Complete(Me, New clsSocket.Results(clsSocket.enumResult.Error, "", "", ex.ToString, clsSck.SvrIP, clsSck.SvrPort))
            'Return Nothing
        End Try
    End Sub

#End Region

#Region "DX006 로그 조회"
    Public Class DX006_REQ
        Property _tran_cd As String = "DX006"
        Property _tran_req_data As New List(Of DX006_instanceList)

        Public Sub New(ByVal intInstance As Integer, ByVal subCommand As String,
                       ByVal dateTime As String, ByVal fileName As String,
                       ByVal intOffset As Integer, ByVal intLength As Integer)

            Dim tmpInstLst As New DX006_instanceList(subCommand, dateTime, fileName, intOffset, intLength)
            tmpInstLst.instance_list.Add(New DX006_instanceList.DX006_instancelist_item(intInstance))
            _tran_req_data.Add(tmpInstLst)
        End Sub

        Class DX006_instanceList
            Property instance_list As New List(Of DX006_instancelist_item)
            Property _tran_sub_cd As String
            Property datetime As String
            Property filename As String
            Property offset As String
            Property len As String
            Public Sub New(ByVal subCommand As String, ByVal strDateTime As String, ByVal strFileName As String,
               ByVal intOffset As Integer, ByVal intLength As Integer)
                _tran_sub_cd = subCommand
                datetime = strDateTime
                filename = strFileName
                offset = intOffset
                len = intLength
            End Sub

            Class DX006_instancelist_item
                Property instance_id As String
                Public Sub New(ByVal intinst As Integer)
                    instance_id = intinst
                End Sub
            End Class
        End Class
    End Class

    Private Class DX006_REP_TMP
        Property _tran_cd As String
        Property _tran_res_data As Object
    End Class

    Public Class DX006_REP
        Property _tran_cd As String = "DX006"
        Property ERRORS As ErrorResponse
        Property _tran_sub_cd As String
        Property offSet As Long
        Property DATAS As New List(Of DATALIST)
    End Class

    Public Class DATALIST
        Property LOGNAME As String
        Property LOGTIME As String
        Property LOGLENGTH As ULong
        Public Sub New(ByVal logFileName As String, ByVal logFileTime As String, ByVal logFileLength As ULong)
            LOGNAME = logFileName
            LOGTIME = logFileTime
            LOGLENGTH = logFileLength
        End Sub
    End Class


    Private _MsgThread006 As Threading.Thread

    <Description("DX006 : 로그 조회")> _
    Public Sub SendDX006(ByVal intInstance As Integer, ByVal subCommand As String,
                         ByVal dateTime As String, ByVal fileName As String,
                         ByVal intOffset As Integer, ByVal intLength As Integer)
        Try
            _MsgThread006 = New Threading.Thread(Sub()
                                                     Dim clsReq As New DX006_REQ(intInstance, subCommand, dateTime, fileName, intOffset, intLength)
                                                     Dim strReq As String = Newtonsoft.Json.JsonConvert.SerializeObject(clsReq)

                                                     strReq = MakeFullEMsg(strReq)
                                                     clsSck.SendMessage(strReq)
                                                 End Sub)
            _MsgThread006.Start()

        Catch ex As Exception
            RaiseEvent Complete(Me, New clsSocket.Results(clsSocket.enumResult.Error, "", "", ex.ToString, clsSck.SvrIP, clsSck.SvrPort))

        End Try
    End Sub

#End Region


#Region "DX005 DB 목록 요청 "

    Public Class DX005_REQ
        Property _tran_cd As String = "DX005"
        Property _tran_req_data As New List(Of DX005_Query)
        Public Sub New(ByVal _instanceID As String, ByVal _username As String, ByVal _database As String, ByVal _password As String, ByVal _sql As String)
            _tran_req_data.Add(New DX005_Query(_instanceID, _username, _database, _password, _sql))
        End Sub
        Class DX005_Query
            Property instance_id As String
            Property username As String
            Property database As String
            Property password As String
            Property sql As String
            Public Sub New(ByVal _instanceID As String, ByVal _username As String, ByVal _database As String, ByVal _password As String, ByVal _sql As String)
                instance_id = _instanceID
                username = _username
                database = _database
                password = _password
                sql = _sql
            End Sub

        End Class

    End Class
    Private Class DX005_REP_TMP
        Property _tran_cd As String
        Property _tran_res_data As Object
    End Class

    Public Class DX005_REP
        Property _tran_cd As String = "DX004"
        Property ERRORS As ErrorResponse
        Property DATAS As New List(Of queryplans)
    End Class

    Public Class queryplans
        Property queryplan As String

        Public Sub New(ByVal _queryplan As String)
            queryplan = _queryplan
        End Sub
    End Class


#End Region

#Region "DX100 Agent 다운로드"

    Public Class DX100_REQ

        Property _tran_cd As String = "DX100"
        Property _tran_req_data As New List(Of DX100_REQ_SUB)

        Public Class DX100_REQ_SUB
            Property offset As Long
            Property blocksize As Long
            Public Sub New(ByVal _Offset As Long, ByVal _BlockSize As Long)
                offset = _Offset
                blocksize = _BlockSize
            End Sub
        End Class

        Public Sub New(ByVal Offset As Long, ByVal BlockSize As Long)
            _tran_req_data.Add(New DX100_REQ_SUB(Offset, BlockSize))
        End Sub

    End Class

    Public Class DX100_REP
        Property _tran_cd As String = "DX100"
        Property _tran_res_data As filedata
    End Class

    Public Class filedata
        Property filename As String
        Property filelength As Integer
        Property sendbyte As Integer
        Property sendbuffer As String
        Property checksum As String
        Property error_cd As String
        Property error_msg As String

        Public Sub New(ByVal _filename As String, ByVal _filelength As Integer, ByVal _sendbyte As String, ByVal _sendbuffer As String, ByVal _checksum As String, ByVal _error_cd As String, ByVal _error_msg As String)
            filename = _filename
            filelength = _filelength
            sendbyte = _sendbyte
            sendbuffer = _sendbuffer
            checksum = _checksum
            error_cd = _error_cd
            error_msg = _error_msg
        End Sub
    End Class

    <Description("DX100 파일 다운로드")> _
    Public Sub SendDX100(ByVal Offset As Long, ByVal BlockSize As Long)
        Try
            _MsgThread = New Threading.Thread(Sub()
                                                  Dim clsReq As New DX100_REQ(Offset, BlockSize)
                                                  Dim strReq As String = Newtonsoft.Json.JsonConvert.SerializeObject(clsReq)
                                                  strReq = MakeFullEMsg(strReq)
                                                  clsSck.SendMessage(strReq)
                                              End Sub)
            _MsgThread.Start()

        Catch ex As Exception
            RaiseEvent Complete(Me, New clsSocket.Results(clsSocket.enumResult.Error, "", "", ex.ToString, clsSck.SvrIP, clsSck.SvrPort))
        End Try
    End Sub

#End Region

    Public Sub Cancel()
        If _MsgThread IsNot Nothing AndAlso _MsgThread.IsAlive Then
            _MsgThread.Abort()
        End If
    End Sub

End Class
