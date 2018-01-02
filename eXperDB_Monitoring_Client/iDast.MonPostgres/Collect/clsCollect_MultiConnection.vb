﻿Public Class clsCollect_MultiConnection
    Private _ThreadMsgQueue As New Queue(Of String)
    ReadOnly Property ThreadMsgQueue As Queue(Of String)

        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)


            Try
                Dim newMsgQueue As Queue(Of String) = New Queue(Of String)(_ThreadMsgQueue)
                SyncLock _ThreadMsgQueue
                    _ThreadMsgQueue.Clear()
                End SyncLock

                Return newMsgQueue
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread BackEnd information Read Exception Error" & ex.ToString)
                Return Nothing
            Finally

                Rw.ReleaseReaderLock()

            End Try
        End Get
    End Property

    Private Sub AddMsgQueue(ByVal Msg As String)
        Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
        Try
            Rw.AcquireWriterLock(-1)
            SyncLock _ThreadMsgQueue
                _ThreadMsgQueue.Enqueue(String.Format("[{0}]{1}", Now.ToString("yyyy-MM-dd HH:mm:ss"), Msg))
            End SyncLock
        Catch ex As Exception

        Finally
            Rw.ReleaseWriterLock()
        End Try


    End Sub

    Private threadTimer As Threading.Timer
    Private threadTimerCallBack As Threading.TimerCallback
    Private _intPeriod As Integer = 3000
    Private _AgentCn As eXperDB.ODBC.DXODBC

    Private _clsQuery As clsQuerys_MultiConnection = Nothing

#Region "Thread Connection"
    Private _CnCPU As eXperDB.ODBC.DXODBC = Nothing
    Private _cnLock As eXperDB.ODBC.DXODBC = Nothing
    Private _cnDisk As eXperDB.ODBC.DXODBC = Nothing
    Private _cnRequest As eXperDB.ODBC.DXODBC = Nothing
    Private _cnSqlRespTm As eXperDB.ODBC.DXODBC = Nothing
    Private _cnCurrentAct As eXperDB.ODBC.DXODBC = Nothing
    Private _cnObject As eXperDB.ODBC.DXODBC = Nothing
    Private _cnBackEnd As eXperDB.ODBC.DXODBC = Nothing
    Private _cnPhysicaliO As eXperDB.ODBC.DXODBC = Nothing
    Private _cnHealth As eXperDB.ODBC.DXODBC = Nothing
#End Region

    ''' <summary>
    ''' 시작
    ''' </summary>
    ''' <param name="AgentCn"></param>
    ''' <param name="intPeriod"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Start(ByVal AgentCn As eXperDB.ODBC.DXODBC, Optional ByVal intPeriod As Integer = 3000) As Boolean
        Try
            If threadTimer IsNot Nothing Then
                Return False
            Else
                _intPeriod = intPeriod
                _AgentCn = AgentCn
                _CnCPU = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnLock = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnDisk = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnRequest = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnSqlRespTm = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnCurrentAct = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnObject = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnBackEnd = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnPhysicaliO = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)
                _cnHealth = New eXperDB.ODBC.DXODBC(_AgentCn.ODBCConninfo, intPeriod)

                _clsQuery = New clsQuerys_MultiConnection(_AgentCn)
                threadTimerCallBack = New Threading.TimerCallback(AddressOf threadTm_Tick)
                threadTimer = New Threading.Timer(threadTimerCallBack, Nothing, 0, _intPeriod)
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Main Thread Start Period =" & _intPeriod)
                AddMsgQueue("Monitoring Start")
                Return True
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Information, "Main Thread Start Error" & ex.ToString)
            AddMsgQueue("Monitoring Start Fail")
            GC.Collect()
            Return False
        End Try
    End Function


    ''' <summary>
    ''' 종료
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub [Stop]()
        Try
            If threadTimer IsNot Nothing Then
                threadTimer.Change(-1, 0)
                threadTimer.Dispose()
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Information, "Main Thread Stop Error" & ex.ToString)
            AddMsgQueue("Monitoring Stop Fail")
        End Try
    End Sub








#Region "Properties"


    Private _infoDataCpuMem As DataTable
    ''' <summary>
    ''' CPU Memory 수집 데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataCpuMem As DataTable
        Get
            ' MSDN 에는 있으나 크게 의미 없어 보여서 사용하지 않음. ReaderLock 으로 Read를 못하도록 막는 로직인거 같으나 
            ' Write 를 쓸때만 막으면 될것 같음. 
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataCpuMem IsNot Nothing Then
                    Return _infoDataCpuMem.Copy
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread CPU/MEM Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try


        End Get
        Set(value As DataTable)
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireWriterLock(-1)
            Try
                _infoDataCpuMem = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Cpu/Mem Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread CPU/MEM Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                Rw.ReleaseWriterLock()
            End Try

        End Set
    End Property

    Private _infoDatalock As New DataTable
    ''' <summary>
    ''' Lock 수집 데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDatalock As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDatalock IsNot Nothing Then
                    Return _infoDatalock.Copy
                Else
                    Return Nothing
                End If


            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Lock Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try

        End Get
        Set(value As DataTable)
            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDatalock = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Lock Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Lock Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    Private _InfoDataDisk As DataTable
    ''' <summary>
    ''' Disk 수집 데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataDisk As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _InfoDataDisk IsNot Nothing Then
                    Return _InfoDataDisk.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Disk Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try

        End Get
        Set(value As DataTable)
            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _InfoDataDisk = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Disk Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Disk Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()

            End Try

        End Set
    End Property

    Private _InfoDataRequest As DataTable
    ''' <summary>
    ''' Disk 수집 데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataRequest As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _InfoDataRequest IsNot Nothing Then
                    Return _InfoDataRequest.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Request Info Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)
            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _InfoDataRequest = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Request Info Write Prop Thread Error" & ex.ToString)
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Request Info Write Prop Exception Error" & ex.ToString)
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    Private _infoDataSQLRespTm As DataTable
    ''' <summary>
    ''' SQL Response Time 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataSQLRespTm As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataSQLRespTm IsNot Nothing Then
                    Return _infoDataSQLRespTm.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread SQL Response Info Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataSQLRespTm = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread SQL Response Info Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread SQL Response Info Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    Private _infoDataCurrentAct As DataTable
    ''' <summary>
    ''' Current Activity 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataCurrentAct As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataCurrentAct IsNot Nothing Then
                    Return _infoDataCurrentAct.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Current Activity Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataCurrentAct = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Current Activity Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Current Activity Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    Private _infoDataObject As DataTable
    ''' <summary>
    ''' Object 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataObject As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataObject IsNot Nothing Then
                    Return _infoDataObject.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Object Read Prop Exception Error" & ex.ToString)
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try

        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataObject = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Object Write Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Object Write Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    Private _infoDataTBspaceinfo As DataTable
    ''' <summary>
    ''' table space 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataTBspaceinfo As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataTBspaceinfo IsNot Nothing Then
                    Return _infoDataTBspaceinfo.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Object Read  prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataTBspaceinfo = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table space Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table space Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    'Private _infoDataTBinfo As New List(Of structTBinfo)
    ' ''' <summary>
    ' '''table Information 수집데이터 정보 
    ' ''' </summary>
    ' ''' <value></value>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Property infoDataTBinfo As List(Of structTBinfo)
    '    Get
    '        Return _infoDataTBinfo
    '    End Get
    '    Set(value As List(Of structTBinfo))

    '        Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
    '        rw.AcquireWriterLock(-1)
    '        Try
    '            _infoDataTBinfo = value
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table Information Write Thread Error" & ex.ToString)
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table Information Write Exception Error" & ex.ToString)
    '        Finally
    '            rw.ReleaseWriterLock()
    '            RaiseEvent GetDataTBinfo()

    '        End Try

    '    End Set
    'End Property

    Private _infoDataTBinfo As DataTable
    ''' <summary>
    '''table Information 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataTBinfo As DataTable
        Get

            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataTBinfo IsNot Nothing Then

                    Return _infoDataTBinfo.Copy
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table Information Read PRop  Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try

        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataTBinfo = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table Information Write prop  Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread table Information Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()

            End Try

        End Set
    End Property


    Private _infoDataIndexinfo As DataTable
    ''' <summary>
    ''' index Information 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataIndexinfo As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataIndexinfo IsNot Nothing Then

                    Return _infoDataIndexinfo.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread index Information Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try

        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataIndexinfo = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread index Information Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread index Information Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    'DBinfo
    Private _infoDataDBinfo As DataTable
    ''' <summary>
    ''' index Information 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataDBinfo As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataDBinfo IsNot Nothing Then
                    Return _infoDataDBinfo.Copy
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread DB information Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataDBinfo = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "DB information Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "DB information Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property



    Private _infoDataBackEnd As DataTable
    ''' <summary>
    ''' BackEnd Information 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataBackend As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)



            Try
                If _infoDataBackEnd IsNot Nothing Then
                    Return _infoDataBackEnd.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread BackEnd information Read prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataBackEnd = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "BackEnd information Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "BackEnd information Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property



    Private _infoDataPhysicaliO As DataTable
    ''' <summary>
    ''' BackEnd Information 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataPhysicaliO As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataPhysicaliO IsNot Nothing Then
                    Return _infoDataPhysicaliO.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Physical I/O information Read  Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataPhysicaliO = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Physical I/O information Write prop  Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Physical I/O information Write Prop  Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property


    Private _infoDataHealth As DataTable
    ''' <summary>
    ''' Health Check 수집데이터 정보 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property infoDataHealth As DataTable
        Get
            Dim Rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            Rw.AcquireReaderLock(-1)

            Try
                If _infoDataHealth IsNot Nothing Then
                    Return _infoDataHealth.Copy
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Thread Health Check information Read Prop Exception Error" & ex.ToString)
                GC.Collect()
                Return Nothing
            Finally
                Rw.ReleaseReaderLock()

            End Try
        End Get
        Set(value As DataTable)

            Dim rw As Threading.ReaderWriterLock = New Threading.ReaderWriterLock
            rw.AcquireWriterLock(-1)
            Try
                _infoDataHealth = value
            Catch ex As Threading.ThreadAbortException
                p_Log.AddMessage(clsLog4Net.enmType.Error, " Health Check information Write Prop Thread Error" & ex.ToString)
                GC.Collect()
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, " Health Check information Write Prop Exception Error" & ex.ToString)
                GC.Collect()
            Finally
                rw.ReleaseWriterLock()
            End Try

        End Set
    End Property



#End Region

#Region "Main Thread"



    ''' <summary>
    ''' 메인 스레드 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub threadTm_Tick()

        If _AgentCn.ConnectionCheck() = True Then
            If _AgentCn.State.Equals(ConnectionState.Open) Then
                ' CPU / MEM 
                infoDataCpuMem = StartThread(_CnCPU, "SELECTCPUMEMINFO", _intPeriod)

                ' StartCpuMem(_intPeriod)
                ' Lock 
                'StartLock(_intPeriod)

                infoDatalock = StartThread(_cnLock, "SELECTLOCKINFO", _intPeriod)


                ' Disk
                'StartDisk(_intPeriod)

                infoDataDisk = StartThread(_cnDisk, "SELECTDISKINFO", _intPeriod)

                ' Request
                'StartRequest(_intPeriod)

                infoDataRequest = StartThread(_cnRequest, "SELECTREQUESTINFO", _intPeriod)

                ' SQL Response Time 
                'StartSQLRespTm(_intPeriod)

                infoDataSQLRespTm = StartThread(_cnSqlRespTm, "SELECTSQLRESPTIME", _intPeriod)

                ' Current Activity 
                'StartCurrentAct(_intPeriod)

                infoDataCurrentAct = StartThread(_cnCurrentAct, "SELECTCURRENTACT", _intPeriod)



                ' Object 
                'StartObject(_intPeriod)

                infoDataObject = StartThread(_cnObject, "SELECTOBJECT", _intPeriod)

                ' Back End 
                'StartBackEnd(_intPeriod)

                infoDataBackend = StartThread(_cnBackEnd, "SELECTBACKEND", _intPeriod)

                ' Physical io
                'StartPhysicaliO(_intPeriod)

                infoDataPhysicaliO = StartThread(_cnPhysicaliO, "SELECTPHYSICALIO", _intPeriod)

                ' Health Check 

                infoDataHealth = StartThread(_cnHealth, "SELECTHEALTH", _intPeriod)
                'StartHealth(_intPeriod)


                ''DB Information
                'startDBinfo(_intPeriod)
                ''tablespace Information
                'startTBspaceinfo(_intPeriod)

                '' 임시 주석 시작 
                ''table Information
                'startTBinfo(_intPeriod)
                ''index Information
                'startIndexinfo(_intPeriod)
                '' 임시 주석 종료 


            Else
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Agent Server Connection is not open! state = " & _AgentCn.State)
                AddMsgQueue("Agent connection cann't not opened")
            End If
        Else
            p_Log.AddMessage(clsLog4Net.enmType.Error, "Agent Server Connection Fail!")
            AddMsgQueue("Agent connection fail!")
        End If





    End Sub





#End Region


#Region "Thread Main"


    Private Function StartThread(ByVal OdbcCn As eXperDB.ODBC.DXODBC, ByVal QueryXmlID As String, ByVal intPeriod As Integer) As DataTable
        Dim rtnDtTable As DataTable = Nothing
        Dim tmpThread As New Threading.Thread(Sub()
                                                  Try
                                                      rtnDtTable = _clsQuery.SelectData(OdbcCn, QueryXmlID)
                                                  Catch ex As Threading.ThreadAbortException
                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, String.Format("{0} Data Request Thread Time Out", QueryXmlID))
                                                      AddMsgQueue(String.Format("{0} Data Request Thread Time Out", QueryXmlID))
                                                      GC.Collect()
                                                  Catch ex As Exception
                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, String.Format("{0} Data Request Thread Exception", QueryXmlID))
                                                      GC.Collect()
                                                  End Try
                                              End Sub)
        Try

            tmpThread.Start()
            tmpThread.Join(intPeriod)
            If tmpThread.IsAlive = True Then
                tmpThread.Abort()
            Else
                If rtnDtTable IsNot Nothing Then
                    Return rtnDtTable ' MakeDataCpuMem(rtnDtTable)
                End If
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, String.Format("{0} Data Exception", QueryXmlID) & vbCrLf & ex.ToString)
            GC.Collect()
        Finally
            If tmpThread IsNot Nothing Then
                tmpThread.DisableComObjectEagerCleanup()
                tmpThread = Nothing
            End If
        End Try
        Return Nothing
    End Function


    Private Class ManualThread
        Public rtnDtTable As DataTable
        Public ManualThread As Threading.Thread
        Public QueueMsg As String = ""
        Public Sub New(ByVal ODbcCn As eXperDB.ODBC.DXODBC, ByVal XMLSQLID As String, ByVal clsQuery As clsQuerys_MultiConnection)
            ManualThread = New Threading.Thread(Sub()
                                                    Try
                                                        rtnDtTable = clsQuery.SelectData(ODbcCn, XMLSQLID)
                                                    Catch ex As Threading.ThreadAbortException
                                                        p_Log.AddMessage(clsLog4Net.enmType.Error, String.Format("{0} Data Request Thread Time Out", XMLSQLID))
                                                        QueueMsg = String.Format("{0} Data Request Thread Time Out", XMLSQLID)
                                                        GC.Collect()
                                                    Catch ex As Exception
                                                        p_Log.AddMessage(clsLog4Net.enmType.Error, String.Format("{0} Data Request Thread Exception", XMLSQLID))
                                                        GC.Collect()
                                                    End Try
                                                End Sub)

        End Sub


    End Class



    Public Function ThreadManual(Optional ByVal intPeriod As Integer = 3000) As Boolean
        If _AgentCn.ConnectionCheck() = True Then
            If _AgentCn.State.Equals(ConnectionState.Open) Then

                'Dim A As New ManualThread(_AgentCn, "SELECTDBINFO", _clsQuery)
                'A.ManualThread.Start()
                'A.ManualThread.Join(intPeriod)
                'If A.ManualThread.IsAlive = True Then
                '    A.ManualThread.Abort()
                'End If

                Dim lstThread As New List(Of ManualThread)
                lstThread.Add(New ManualThread(_AgentCn, "SELECTDBINFO", _clsQuery))
                lstThread.Add(New ManualThread(_AgentCn, "SELECTTBSPACEINFO", _clsQuery))
                lstThread.Add(New ManualThread(_AgentCn, "SELECTTBINFO", _clsQuery))
                lstThread.Add(New ManualThread(_AgentCn, "SELECTINDEXINFO", _clsQuery))

                For Each tmpThread As ManualThread In lstThread
                    tmpThread.ManualThread.Start()
                Next

                For Each tmpThread As ManualThread In lstThread
                    tmpThread.ManualThread.Join(intPeriod)
                    If tmpThread.ManualThread.IsAlive = True Then
                        tmpThread.ManualThread.Abort()
                    End If
                    If tmpThread.QueueMsg <> "" Then
                        AddMsgQueue(tmpThread.QueueMsg)
                    End If

                Next

                Me.infoDataDBinfo = lstThread.Item(0).rtnDtTable
                Me.infoDataTBspaceinfo = lstThread.Item(1).rtnDtTable
                Me.infoDataTBinfo = lstThread.Item(2).rtnDtTable
                Me.infoDataIndexinfo = lstThread.Item(3).rtnDtTable


                Return True

            Else
                p_Log.AddMessage(clsLog4Net.enmType.Error, "Agent Server Connection is not open! state = " & _AgentCn.State)
                AddMsgQueue("Agent connection cann't not opened")
                Return False
            End If
        Else
            p_Log.AddMessage(clsLog4Net.enmType.Error, "Agent Server Connection Fail!")
            AddMsgQueue("Agent connection fail!")
            Return False
        End If



    End Function



#End Region

#Region "OLD"


    '#Region "Events"

    '    Public Event GetDataCpuMem(ByVal dtTable As DataTable)

    '    Public Event GetDataLockinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataDiskinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataRequestInfo(ByVal dtTable As DataTable)

    '    Public Event GetDataSQLRespTmInfo(ByVal dtTable As DataTable)

    '    Public Event GetDataCurrentActinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataDBinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataObjectInfo(ByVal dtTable As DataTable)

    '    Public Event GetDataTBspaceinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataTBinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataIndexinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataBackendinfo(ByVal dtTable As DataTable)

    '    Public Event GetDataPhysicaliOinfo(ByVal dtTable As DataTable)


    '#End Region


    '#Region "CPU/MEM Thread"


    '    ''' <summary>
    '    ''' CPU/MEM Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartCpuMem(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  Try
    '                                                      rtnDtTable = _clsQuery.SelectCpuMemINFO
    '                                                  Catch ex As Threading.ThreadAbortException
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "CPU/MEM Data Request Thread Time Out")
    '                                                      AddMsgQueue("CPU/MEM Data Thread request timeout")
    '                                                      GC.Collect()
    '                                                  Catch ex As Exception
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "CPU/MEM Data Request Thread Exception")
    '                                                      GC.Collect()
    '                                                  End Try
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataCpuMem = rtnDtTable ' MakeDataCpuMem(rtnDtTable)
    '                End If
    '            End If

    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "CPU/MEM Data Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '                tmpThread = Nothing
    '            End If
    '        End Try

    '    End Sub

    '    ' ''' <summary>
    '    ' ''' CPU/MEM Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataCpuMem(ByVal dtTable As DataTable) As List(Of structCpuMem)
    '    '    Dim rtnLst As New List(Of structCpuMem)
    '    '    If dtTable IsNot Nothing Then
    '    '        Try
    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structCpuMem(tmpDtRow)
    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "Lock Thread"

    '    ''' <summary>
    '    ''' Lock Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartLock(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  Try
    '                                                      rtnDtTable = _clsQuery.SelectLockINFO
    '                                                  Catch ex As Threading.ThreadAbortException
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Lock Data Request Thread Time Out")
    '                                                      AddMsgQueue("Lock Data Thread request timeout")
    '                                                      GC.Collect()
    '                                                  Catch ex As Exception
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Lock Data Request Thread Exception")
    '                                                      GC.Collect()
    '                                                  End Try

    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDatalock = rtnDtTable ' MakeDataLock(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Lock Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If
    '        End Try

    '    End Sub


    '    ' ''' <summary>
    '    ' ''' CPU/MEM Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataLock(ByVal dtTable As DataTable) As List(Of structLock)
    '    '    Dim rtnLst As New List(Of structLock)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structLock(tmpDtRow)
    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "Disk Thread"

    '    ''' <summary>
    '    ''' Disk Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartDisk(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  Try
    '                                                      rtnDtTable = _clsQuery.SelectDiskInfo
    '                                                  Catch ex As Threading.ThreadAbortException
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Disk Data Request Thread Time Out")
    '                                                      AddMsgQueue("Disk Data Thread request timeout")
    '                                                      GC.Collect()
    '                                                  Catch ex As Exception
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Disk Data Request Thread Exception")
    '                                                      GC.Collect()
    '                                                  End Try

    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataDisk = rtnDtTable '  MakeDataDisk(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Disk Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If
    '        End Try

    '    End Sub


    '    ' ''' <summary>
    '    ' ''' Disk Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataDisk(ByVal dtTable As DataTable) As List(Of structDisk)
    '    '    Dim rtnLst As New List(Of structDisk)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structDisk(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "Request Info Thread"

    '    ''' <summary>
    '    ''' Request Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartRequest(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  Try
    '                                                      rtnDtTable = _clsQuery.SelectRequestInfo
    '                                                  Catch ex As Threading.ThreadAbortException
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Request Data Request Thread Time Out")
    '                                                      AddMsgQueue("Request Data Thread request timeout")
    '                                                      GC.Collect()
    '                                                  Catch ex As Exception
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Request Data Request Thread Exception")
    '                                                      GC.Collect()
    '                                                  End Try
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataRequest = rtnDtTable '  MakeDataRequest(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Request Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If

    '        End Try

    '    End Sub


    '    ' ''' <summary>
    '    ' ''' Request Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataRequest(ByVal dtTable As DataTable) As List(Of structRequest)
    '    '    Dim rtnLst As New List(Of structRequest)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structRequest(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "SQL Response Time"

    '    ''' <summary>
    '    ''' SQL Response Time Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartSQLRespTm(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  Try
    '                                                      rtnDtTable = _clsQuery.SelectSQLRespTime
    '                                                  Catch ex As Threading.ThreadAbortException
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "SQL Response Data Request Thread Time Out")
    '                                                      AddMsgQueue("SQL Response Data Thread request timeout")
    '                                                      GC.Collect()
    '                                                  Catch ex As Exception
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "SQL Response Data Request Thread Exception")
    '                                                      GC.Collect()
    '                                                  End Try
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataSQLRespTm = rtnDtTable '  MakeDataSQLRespTm(rtnDtTable)
    '                End If


    '            End If
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "SQL Response Time Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If

    '        End Try

    '    End Sub


    '    ' ''' <summary>
    '    ' ''' SQL Response Time Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataSQLRespTm(ByVal dtTable As DataTable) As List(Of structSQLRespTm)
    '    '    Dim rtnLst As New List(Of structSQLRespTm)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structSQLRespTm(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next

    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "Current Activity"

    '    ''' <summary>
    '    ''' Current Activity Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartCurrentAct(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  Try
    '                                                      rtnDtTable = _clsQuery.SelectCurrentAct
    '                                                  Catch ex As Threading.ThreadAbortException
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "Current Activity Data Request Thread Time Out")
    '                                                      AddMsgQueue("Current Activity Data Thread request timeout")
    '                                                      GC.Collect()
    '                                                  Catch ex As Exception
    '                                                      p_Log.AddMessage(clsLog4Net.enmType.Error, "SQL Response Data Request Thread Exception")
    '                                                      GC.Collect()
    '                                                  End Try
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataCurrentAct = rtnDtTable '  MakeDataCurrentAct(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Current Activity Information Request Time Out")
    '            AddMsgQueue("Current Activity Data request timeout")
    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Current Activity Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If

    '        End Try

    '    End Sub


    '    ' ''' <summary>
    '    ' ''' Current Activity Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataCurrentAct(ByVal dtTable As DataTable) As List(Of structCurrentAct)
    '    '    Dim rtnLst As New List(Of structCurrentAct)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structCurrentAct(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next

    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "DB Information"
    '    ''' <summary>
    '    ''' Database information Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub startDBinfo(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectDBinfo()
    '                                              End Sub)
    '        Try
    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataDBinfo = rtnDtTable '  MakeDataDBinfo(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Database Information Request Time Out")
    '            AddMsgQueue("Database Data request timeout")
    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "Database Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If
    '        End Try
    '    End Sub

    '    ' ''' <summary>
    '    ' ''' Database information Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataDBinfo(ByVal dtTable As DataTable) As List(Of structDBinfo)
    '    '    Dim rtnLst As New List(Of structDBinfo)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structDBinfo(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "tablespace Information"
    '    ''' <summary>
    '    ''' tablespace Information Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub startTBspaceinfo(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectTBspaceinfo()
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataTBspaceinfo = rtnDtTable '  MakeDataTBspaceinfo(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "tablespace Information Request Time Out")
    '            AddMsgQueue("TableSpace Data request timeout")
    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "tablespace Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If

    '        End Try

    '    End Sub



    '    ' ''' <summary>
    '    ' ''' tablespace Information Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataTBspaceinfo(ByVal dtTable As DataTable) As List(Of structTBspaceinfo)
    '    '    Dim rtnLst As New List(Of structTBspaceinfo)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structTBspaceinfo(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region


    '#Region "table Information"
    '    ''' <summary>
    '    ''' table Information Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub startTBinfo(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectTBinfo()
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                'If rtnDtTable IsNot Nothing Then
    '                '    infoDataTBinfo = MakeDataTBinfo(rtnDtTable)
    '                'End If
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataTBinfo = rtnDtTable
    '                End If


    '                End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "table Information Request Time Out")
    '            AddMsgQueue("Table Data request timeout")

    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "table Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If

    '        End Try

    '    End Sub



    '    ' ''' <summary>
    '    ' ''' table Information Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataTBinfo(ByVal dtTable As DataTable) As List(Of structTBinfo)
    '    '    Dim rtnLst As New List(Of structTBinfo)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structTBinfo(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "index Information"
    '    ''' <summary>
    '    ''' index Information Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub startIndexinfo(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtndttable = _clsQuery.Selectindexinfo()
    '                                              End Sub)
    '        Try

    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataIndexinfo = rtnDtTable
    '                End If
    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "index Information Request Time Out")
    '            AddMsgQueue("Index Data request timeout")
    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Error, "index Information Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally
    '            If tmpThread IsNot Nothing Then
    '                tmpThread.DisableComObjectEagerCleanup()
    '            End If

    '        End Try

    '    End Sub





    '#End Region

    '#Region "Object"



    '    ''' <summary>
    '    ''' Object Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartObject(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectObject()
    '                                              End Sub)


    '        Try
    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataObject = rtnDtTable '  MakeDataObject(rtnDtTable)
    '                End If

    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "Object Data Request Time Out")
    '            AddMsgQueue("Object Data request timeout")

    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "Object Data Request Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally

    '        End Try

    '    End Sub
    '    ' ''' <summary>
    '    ' ''' Object Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataObject(ByVal dtTable As DataTable) As List(Of structObject)
    '    '    Dim rtnLst As New List(Of structObject)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structObject(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "BackEnd"



    '    ''' <summary>
    '    ''' BackEnd Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartBackEnd(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectBackEnd()
    '                                              End Sub)


    '        Try
    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataBackend = rtnDtTable '  MakeDataBackEnd(rtnDtTable)
    '                End If


    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "BackEnd Data Request Time Out")
    '            AddMsgQueue("Backend Data request timeout")
    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "BackEnd Data Request Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally

    '        End Try

    '    End Sub
    '    ' ''' <summary>
    '    ' ''' BackEnd Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataBackEnd(ByVal dtTable As DataTable) As List(Of structBackEnd)
    '    '    Dim rtnLst As New List(Of structBackEnd)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structBackEnd(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "Physical IO"


    '    ''' <summary>
    '    ''' Physical IO Thread Main 
    '    ''' </summary>
    '    ''' <param name="intPeriod"></param>
    '    ''' <remarks></remarks>
    '    Private Sub StartPhysicaliO(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectPhysicaliO
    '                                              End Sub)
    '        Try
    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataPhysicaliO = rtnDtTable ' MakeDataPhysicaliO(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "Physical IO Data Request Time Out")
    '            AddMsgQueue("Physical I/O Data request timeout")

    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "Physical IO Data Request Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally

    '        End Try

    '    End Sub




    '    ' ''' <summary>
    '    ' ''' Physical IO Make Structure Data 
    '    ' ''' </summary>
    '    ' ''' <param name="dtTable"></param>
    '    ' ''' <returns></returns>
    '    ' ''' <remarks></remarks>
    '    'Private Function MakeDataPhysicaliO(ByVal dtTable As DataTable) As List(Of structPhysicaliO)
    '    '    Dim rtnLst As New List(Of structPhysicaliO)
    '    '    If dtTable IsNot Nothing Then

    '    '        Try


    '    '            For Each tmpDtRow As DataRow In dtTable.Rows
    '    '                Dim tmpStruct As New structPhysicaliO(tmpDtRow)


    '    '                rtnLst.Add(tmpStruct)
    '    '            Next
    '    '        Catch ex As Exception
    '    '            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '    '        End Try

    '    '    End If
    '    '    Return rtnLst
    '    'End Function

    '#End Region

    '#Region "Health Check"
    '    Private Sub StartHealth(ByVal intPeriod As Integer)
    '        Dim rtnDtTable As DataTable = Nothing
    '        Dim tmpThread As New Threading.Thread(Sub()
    '                                                  rtnDtTable = _clsQuery.SelectHealth
    '                                              End Sub)
    '        Try
    '            tmpThread.Start()
    '            tmpThread.Join(intPeriod)
    '            If tmpThread.IsAlive = True Then
    '                tmpThread.Abort()
    '            Else
    '                If rtnDtTable IsNot Nothing Then
    '                    infoDataHealth = rtnDtTable ' MakeDataPhysicaliO(rtnDtTable)
    '                End If
    '            End If
    '        Catch ex As Threading.ThreadAbortException
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "Physical IO Data Request Time Out")
    '            AddMsgQueue("Health Check Data request timeout")

    '            GC.Collect()
    '        Catch ex As Exception
    '            p_Log.AddMessage(clsLog4Net.enmType.Warning, "Physical IO Data Request Exception Error" & vbCrLf & ex.ToString)
    '            GC.Collect()
    '        Finally

    '        End Try

    '    End Sub

    '#End Region

#End Region

End Class