Imports System.Threading

Public Class clsSocket

    Private _intRequestTimeout As Integer = 3000
    Private _intResponseTimeout As Integer = 3000
    Private Const _HEADLEN As Integer = 10
    Private _IP As String
    ReadOnly Property SvrIP As String
        Get
            Return _IP
        End Get
    End Property

    Private _Port As Integer
    ReadOnly Property SvrPort As Integer
        Get
            Return _Port
        End Get
    End Property

    Public Sub New(ByVal strIP As String, ByVal intPort As Integer, Optional ByVal intRequestTimeout As Integer = 60000, Optional ByVal intResponseTimeout As Integer = 60000)
        Try
            _IP = strIP
            _Port = intPort
            _intRequestTimeout = intRequestTimeout
            _intResponseTimeout = intResponseTimeout
        Catch ex As Exception

            GC.Collect()
        End Try
    End Sub

    Public Enum enumStatus
        Start
        Request
        Response
        [End]
        [Error]
    End Enum

    Public Structure ProgArgs
        Dim Status As enumStatus
        Dim StatusMsg As String
        Public Sub New(ByVal enmStatus As enumStatus, ByVal strMsg As String)
            Status = enmStatus
            StatusMsg = strMsg
        End Sub
    End Structure

    Public Enum enumResult
        Complete
        Cancel
        [Error]
    End Enum

    Public Structure Results
        Dim Result As enumResult
        Dim RequestMsg As String
        Dim ResponseMsg As String
        Dim ErrorMsg As String
        Dim IP As String
        Dim Port As Integer
        Public Sub New(ByVal enmResult As enumResult, ByVal strReqMsg As String, ByVal strRepMsg As String, ByVal strErrorMsg As String, ByVal strIP As String, ByVal intPort As Integer)
            Result = enmResult
            RequestMsg = strReqMsg
            ResponseMsg = strRepMsg
            ErrorMsg = strErrorMsg
            IP = strIP
            Port = intPort
        End Sub
    End Structure


    Public Event Progress(ByVal sender As Object, ByVal e As ProgArgs)
    Public Event Complete(ByVal sender As Object, ByVal e As Results)




    Public Function SendMessage(ByVal strMessage As String) As Results
        Dim tClient As System.Net.Sockets.TcpClient
        Dim rtnResult As Results = Nothing
        Dim wh As System.Threading.WaitHandle = Nothing
        RaiseEvent Progress(Me, New ProgArgs(enumStatus.Start, "실행"))
        Try
            tClient = New System.Net.Sockets.TcpClient(_IP, _Port)
            'tClient = New System.Net.Sockets.TcpClient()
            'Dim reslt As System.IAsyncResult = tClient.BeginConnect(_IP, _Port, Nothing, Nothing)
            'wh = reslt.AsyncWaitHandle
            'If Not reslt.AsyncWaitHandle.WaitOne(2000, False) Then
            '    tClient.Close()
            '    Throw New Exception("TCP Request Time out 2000 milliseconds")
            'Else
            '    tClient.EndConnect(reslt)
            'End If
        Catch ex As Exception
            rtnResult = New Results(enumResult.Error, "", "", ex.Message, _IP, _Port)
            RaiseEvent Complete(Me, rtnResult)
            GC.Collect()
            Return rtnResult
        Finally
            If wh IsNot Nothing Then
                wh.Close()
            End If

        End Try



        Dim rtnReqMsg As String = strMessage
        Dim rtnRepMsg As String = ""
        Dim sendBuffLength As Integer = 0
        Dim rtnRepMsgByte(10 * 1024 * 1024) As Byte

        Try
            If tClient Is Nothing Then Return rtnResult

            If tClient.Connected = True Then

                ' 일반 START 
                Using nStream As System.Net.Sockets.NetworkStream = tClient.GetStream
                    If nStream.CanWrite Then

                        Dim Msgs As Byte() = System.Text.Encoding.UTF8.GetBytes(strMessage)
                        '_Log.AddMessage(IDast.LogUtil.clsLog4Net.enmType.Information, System.Text.Encoding.UTF8.GetString(Msgs))
                        RaiseEvent Progress(Me, New ProgArgs(enumStatus.Request, "데이터 전송중......"))
                        nStream.WriteTimeout = _intRequestTimeout
                        nStream.Write(Msgs, 0, Msgs.Length)
                        nStream.Flush()
                        RaiseEvent Progress(Me, New ProgArgs(enumStatus.Request, "전송 완료"))
                    Else
                        rtnResult = New Results(enumResult.Error, "", "", "Can not Request Data", _IP, _Port)
                        RaiseEvent Complete(Me, rtnResult)
                    End If

                    If nStream.CanRead Then
                        RaiseEvent Progress(Me, New ProgArgs(enumStatus.Response, "응답 대기중......"))
                        nStream.ReadTimeout = _intResponseTimeout
                        Dim numByte As Integer = 0
                        Dim totalByte As Integer = 0
                        Dim head(_HEADLEN) As Byte
                        nStream.Read(head, 0, _HEADLEN)
                        Buffer.BlockCopy(head, 0, rtnRepMsgByte, totalByte, numByte)
                        totalByte += 10
                        sendBuffLength = Integer.Parse(System.Text.Encoding.UTF8.GetString(head, 0, _HEADLEN))
                        Do
                            Dim reads(tClient.ReceiveBufferSize) As Byte
                            numByte = nStream.Read(reads, 0, tClient.ReceiveBufferSize)
                            'rtnRepMsg += System.Text.Encoding.UTF8.GetString(reads, 0, numByte)
                            Buffer.BlockCopy(reads, 0, rtnRepMsgByte, totalByte, numByte)
                            totalByte += numByte
                            'RaiseEvent Progress(Me, New ProgArgs(enumStatus.Response, "수신중......"))
                            If Not nStream.DataAvailable Then
                                Thread.Sleep(10)
                            End If
                            'Loop While nStream.DataAvailable
                        Loop While sendBuffLength > totalByte
                        '_Log.AddMessage(IDast.LogUtil.clsLog4Net.enmType.Information, rtnRepMsg)
                        rtnRepMsg = System.Text.Encoding.UTF8.GetString(rtnRepMsgByte, 0, totalByte)
                        RaiseEvent Progress(Me, New ProgArgs(enumStatus.Response, "응답 완료"))
                    Else
                        rtnResult = New Results(enumResult.Error, "", "", "Can not Response Data", _IP, _Port)
                        RaiseEvent Complete(Me, rtnResult)
                    End If
                    ' 응답 받았다는 부분 코딩 해서 넣기 
                    nStream.Close()
                    ' 일반 END 
                End Using

            End If

            ' 일단 테스트용 주석 처리 
            tClient.Close()
            rtnResult = New Results(enumResult.Complete, rtnReqMsg, rtnRepMsg, "", _IP, _Port)
            RaiseEvent Complete(Me, rtnResult)

        Catch ex As Exception
            rtnResult = New Results(enumResult.Error, "", "", ex.ToString, _IP, _Port)
            RaiseEvent Complete(Me, rtnResult)
        Finally

        End Try
        Return rtnResult
    End Function




End Class
