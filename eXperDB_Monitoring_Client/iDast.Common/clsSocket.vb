Public Class clsSocket

    Private _intRequestTimeout As Integer = 60000
    Private _intResponseTimeout As Integer = 60000
    Private _IP As String
    Private _Port As String
    Public Sub New(ByVal strIP As String, ByVal intPort As Integer, Optional ByVal intRequestTimeout As Integer = 4000, Optional ByVal intResponseTimeout As Integer = 4000)
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
   
   


    Public Sub SendMessage(ByVal strMessage As String)
        Dim tClient As System.Net.Sockets.TcpClient
        Try
            tClient = New System.Net.Sockets.TcpClient(_IP, _Port)
        Catch ex As Exception
            RaiseEvent Complete(Me, New Results(enumResult.Error, "", "", "Connection Fail", _IP, _Port))
            Return

        End Try
        Dim rtnReqMsg As String = strMessage
        Dim rtnRepMsg As String = ""

        Try
            If tClient Is Nothing Then Return

            If tClient.Connected = True Then


                ' 일반 START 
                Dim nStream As System.Net.Sockets.NetworkStream = tClient.GetStream
                If nStream.CanWrite Then

                    Dim Msgs As Byte() = System.Text.Encoding.UTF8.GetBytes(strMessage)
                    '_Log.AddMessage(IDast.LogUtil.clsLog4Net.enmType.Information, System.Text.Encoding.UTF8.GetString(Msgs))
                    RaiseEvent Progress(Me, New ProgArgs(enumStatus.Request, "데이터 전송중......"))
                    nStream.WriteTimeout = _intRequestTimeout
                    nStream.Write(Msgs, 0, Msgs.Length)
                    nStream.Flush()
                    RaiseEvent Progress(Me, New ProgArgs(enumStatus.Request, "전송 완료"))
                Else
                    RaiseEvent Complete(Me, New Results(enumResult.Error, "", "", "Can not Request Data", _IP, _Port))
                End If

                If nStream.CanRead Then
                    RaiseEvent Progress(Me, New ProgArgs(enumStatus.Response, "응답 대기중......"))
                    nStream.ReadTimeout = _intResponseTimeout
                    Dim numByte As Integer = 0
                    Do
                        Dim reads(tClient.ReceiveBufferSize) As Byte
                        numByte = nStream.Read(reads, 0, tClient.ReceiveBufferSize)
                        rtnRepMsg += System.Text.Encoding.UTF8.GetString(reads, 0, numByte)
                        RaiseEvent Progress(Me, New ProgArgs(enumStatus.Response, "수신중......"))
                    Loop While nStream.DataAvailable
                    '_Log.AddMessage(IDast.LogUtil.clsLog4Net.enmType.Information, rtnRepMsg)
                    RaiseEvent Progress(Me, New ProgArgs(enumStatus.Response, "응답 완료"))
                Else
                    RaiseEvent Complete(Me, New Results(enumResult.Error, "", "", "Can not Response Data", _IP, _Port))
                End If
                ' 응답 받았다는 부분 코딩 해서 넣기 
                nStream.Close()
                ' 일반 END 


            End If

            ' 일단 테스트용 주석 처리 
            tClient.Close()

            RaiseEvent Complete(Me, New Results(enumResult.Complete, rtnReqMsg, rtnRepMsg, "", _IP, _Port))

        Catch ex As Exception

            RaiseEvent Complete(Me, New Results(enumResult.Error, "", "", ex.ToString, _IP, _Port))


        End Try
    End Sub




End Class
