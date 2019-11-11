Imports System.Data

Public Class eXperDBODBC
    Private _Log As New clsLog4Net
    Private _ODBCConnInfo As structConnection

    ReadOnly Property State() As ConnectionState
        Get
            Return _ODBCConnection.State
        End Get
    End Property

    ReadOnly Property isTranscation() As Boolean
        Get
            Return _Transcation IsNot Nothing
        End Get
    End Property

    ReadOnly Property ODBCConninfo As structConnection
        Get
            Return _ODBCConnInfo
        End Get
    End Property

    Public Enum enumODBCType
        <System.ComponentModel.Category("ORACLE") _
        , System.ComponentModel.Description("{Idast ODBC For Oracle}")> _
        Oracle = 0
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL UNICODE}")> _
        PostgreUnicode = 10
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL}")> _
        PostgreStandard = 11
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL ANSI}")> _
        PostgreANSI = 12
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL ANSI};sslmode=require")> _
        PostgreSSL = 13

        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL UNICODE(X64)}")> _
        PostgreUnicodeX64 = 15
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL(X64)}")> _
        PostgreStandardX64 = 16
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL ANSI(X64)}")> _
        PostgreANSIX64 = 17
        <System.ComponentModel.Category("POSTGRESQL") _
        , System.ComponentModel.Description("{PostgreSQL ANSI(X64)};sslmode=require")> _
        PostgreSSLX64 = 18

        <System.ComponentModel.Category("MSSQL") _
        , System.ComponentModel.Description("{SQL Server}")> _
        MSSQL = 20
        <System.ComponentModel.Category("SYBASE ASE") _
        , System.ComponentModel.Description("{SYBASE ASE ODBC DRIVER}")>
        SYBASEASE = 30
        <System.ComponentModel.Category("SYBASE IQ") _
        , System.ComponentModel.Description("{Adaptive Server IQ}")>
        SYBASEIQ = 31
        <System.ComponentModel.Category("DB2") _
        , System.ComponentModel.Description("{IBM DB2 ODBC DRIVER}")>
        DB2 = 40
        <System.ComponentModel.Category("TIBERO") _
            , System.ComponentModel.Description("{Tibero 5 ODBC Driver}")> _
        TIBERO = 50
    End Enum



    Private WithEvents _ODBCConnection As System.Data.Odbc.OdbcConnection
    Private _DBCommand As System.Data.Odbc.OdbcCommand

    Public Sub New(ByVal ODBCType As enumODBCType, ByVal IP As String, ByVal Port As Integer, ByVal ID As String, ByVal Password As String, ByVal SID As String)

        Dim tmpConnInfo As New structConnection(ODBCType, IP, Port, ID, SID, Password)
        _ODBCConnInfo = tmpConnInfo
        _ODBCConnection = New Data.Odbc.OdbcConnection

        _ODBCConnection.ConnectionString = tmpConnInfo.ConnectionString
    End Sub

    Public Sub New(ByVal ODBCTypeName As String, ByVal IP As String, ByVal Port As Integer, ByVal ID As String, ByVal Password As String, ByVal SID As String)

        Dim tmpConnInfo As New structConnection(ODBCTypeName, IP, Port, ID, SID, Password)
        _ODBCConnInfo = tmpConnInfo
        _ODBCConnection = New Data.Odbc.OdbcConnection

        _ODBCConnection.ConnectionString = tmpConnInfo.ConnectionString
    End Sub

    Public Sub New(ByVal ODbcConn As structConnection, Optional ByVal CommandTimeOut As Integer = 3)
        _ODBCConnInfo = ODbcConn
        _ODBCConnection = New Data.Odbc.OdbcConnection
        _ODBCConnection.ConnectionString = ODbcConn.ConnectionString

    End Sub


    Public Function ConnectionCheck() As Boolean
        If _ODBCConnection IsNot Nothing AndAlso _ODBCConnection.ConnectionString <> "" Then
            Try
                If _ODBCConnInfo.UserID.Trim = "" Or _ODBCConnInfo.Password.Trim = "" Then
                    Return False
                End If
                Do While DirectCast(_ODBCConnection, Data.Odbc.OdbcConnection).State = ConnectionState.Connecting
                    System.Threading.Thread.Sleep(200)
                Loop

                If DirectCast(_ODBCConnection, Data.Odbc.OdbcConnection).State <> ConnectionState.Open Then
                    _ODBCConnection.Open()
                End If

                If DirectCast(_ODBCConnection, Data.Odbc.OdbcConnection).State = ConnectionState.Open Then
                    'Dim tmpConn As New Data.Odbc.OdbcConnection
                    'tmpConn.ConnectionString = _ODBCConnInfo.ConnectionString

                    'Try
                    '    tmpConn.Open()
                    '    If tmpConn.State = ConnectionState.Open Then
                    '        Return True
                    '    Else
                    '        Return False
                    '    End If
                    'Catch ex As Exception
                    '    Return False
                    'Finally
                    '    If tmpConn IsNot Nothing Then
                    '        tmpConn.Dispose()
                    '    End If


                    'End Try


                    Dim rtnValue As Boolean = False

                    Dim thConnect As New Threading.Thread(Sub()

                                                              Try
                                                                  If _DBCommand IsNot Nothing Then
                                                                      Debug.Print("CONN : " & _DBCommand.CommandText)
                                                                  End If
                                                                  _DBCommand = New Data.Odbc.OdbcCommand(_ODBCConnInfo.DummyQuery, _ODBCConnection)
                                                                  _DBCommand.CommandType = Data.CommandType.Text

                                                                  rtnValue = _DBCommand.ExecuteReader.HasRows

                                                              Catch ex As Threading.ThreadAbortException

                                                                  _Log.AddMessage(clsLog4Net.enmType.Information, ex.ToString)
                                                                  GC.Collect()
                                                              Catch ex As Data.Odbc.OdbcException
                                                                  If DirectCast(ex.Errors(0), Data.Odbc.OdbcError).SQLState = "HY000" Then
                                                                      If _DBCommand IsNot Nothing Then
                                                                          _DBCommand.Dispose()
                                                                          _DBCommand = Nothing
                                                                      End If
                                                                      _ODBCConnection.Close()
                                                                      _ODBCConnection.Dispose()
                                                                      GC.Collect()
                                                                  End If
                                                              Catch ex As Exception

                                                                  _Log.AddMessage(clsLog4Net.enmType.Information, ex.ToString)
                                                                  GC.Collect()
                                                              Finally
                                                                  If _DBCommand IsNot Nothing Then
                                                                      _DBCommand.Dispose()
                                                                      _DBCommand = Nothing
                                                                  End If

                                                              End Try
                                                          End Sub)


                    thConnect.Start()
                    thConnect.Join(2000)
                    If thConnect.IsAlive Then
                        _DBCommand.Cancel()
                        thConnect.Abort()
                        _Log.AddMessage(clsLog4Net.enmType.Error, Now.ToString("yyyy-MM-dd HH:mm:ss") & "Connection Fail!")
                        GC.Collect()
                        Return False
                    Else
                        Return True
                    End If

                Else
                    Dim cnt As Integer = 0
                    Do While DirectCast(_ODBCConnection, Data.Odbc.OdbcConnection).State = ConnectionState.Connecting
                        System.Threading.Thread.Sleep(100)
                        cnt += 1
                        If cnt = 10 Then
                            Exit Do
                        End If
                    Loop

                    If _ODBCConnection.State <> ConnectionState.Open Then
                        _Log.AddMessage(clsLog4Net.enmType.Error, Now.ToString("yyyy-MM-dd HH:mm:ss") & "Create Connection")
                        _ODBCConnection.Dispose()
                        _ODBCConnection = New Data.Odbc.OdbcConnection(_ODBCConnInfo.ConnectionString)
                    End If
                    Return False

                End If
            Catch ex As Exception
                GC.Collect()
                Return False
            End Try
        Else
            _Log.AddMessage(clsLog4Net.enmType.Error, Now.ToString("yyyy-MM-dd HH:mm:ss") & "Create Connection")
            _ODBCConnection = New Data.Odbc.OdbcConnection(_ODBCConnInfo.ConnectionString)
        End If

        Return False
    End Function





    Public Function dbSelect(ByVal Query As String, ByVal ParamArray Parameter() As Object) As DataSet
        ' Dim Cmd As Data.Odbc.OdbcCommand = Nothing
        Dim rtndtset As New DataSet
        Try

            If _ODBCConnection.State <> ConnectionState.Open Then
                If ConnectionCheck() = False Then
                    Return Nothing
                End If
            End If
            _DBCommand = New Data.Odbc.OdbcCommand(Query, _ODBCConnection)
            _DBCommand.CommandType = Data.CommandType.Text
            If Parameter IsNot Nothing Then
                For Each tmpPara As Data.Odbc.OdbcParameter In Parameter
                    _DBCommand.Parameters.Add(tmpPara)
                Next
            End If

            If _DBCommand IsNot Nothing Then
                Dim dtAdaptor As New Data.Odbc.OdbcDataAdapter(_DBCommand)
                dtAdaptor.Fill(rtndtset)
            End If
        Catch ex As Threading.ThreadAbortException
            'If _DBCommand IsNot Nothing Then
            '    _DBCommand.Cancel()
            '    _Log.AddMessage(clsLog4Net.enmType.Information, ex.ToString)
            'End If
            GC.Collect()
        Catch ex As Data.Odbc.OdbcException
            If DirectCast(ex.Errors(0), Data.Odbc.OdbcError).SQLState = "HY000" Then
                If _DBCommand IsNot Nothing Then
                    _DBCommand.Dispose()
                    _DBCommand = Nothing
                End If
                _ODBCConnection.Close()
                _ODBCConnection.Dispose()
                GC.Collect()
            End If
        Catch ex As Exception
            _Log.AddMessage(clsLog4Net.enmType.Information, ex.ToString)
            If _DBCommand IsNot Nothing Then
                _DBCommand.Cancel()
                _DBCommand.Dispose()
                _DBCommand = Nothing
            End If


            GC.Collect()
        Finally
            If _DBCommand IsNot Nothing Then
                _DBCommand.Dispose()
                _DBCommand = Nothing
            End If

        End Try

        Return rtndtset

    End Function


    ''' <summary>
    ''' SELECT를 제외한 실행되는 쿼리를 실행한다. Update, Insert , Delete 
    ''' </summary>
    ''' <param name="Query"></param>
    ''' <param name="Parameter"></param>
    ''' <returns>영향 받은 열수 </returns>
    ''' <remarks></remarks>
    Public Function dbExecuteNonQuery(ByVal Query As String, ByVal ParamArray Parameter() As System.Data.Odbc.OdbcParameter) As Integer



        Dim rtnResult As Integer = -1


        Try
            If Me.State <> ConnectionState.Open Then
                If ConnectionCheck() = False Then
                    Return Nothing
                End If
            End If

            _DBCommand = New Data.Odbc.OdbcCommand(Query, _ODBCConnection)
            _DBCommand.CommandType = Data.CommandType.Text
            If Parameter IsNot Nothing Then
                For Each tmpPara As Data.Odbc.OdbcParameter In Parameter
                    _DBCommand.Parameters.Add(tmpPara)
                Next
            End If
            If _Transcation IsNot Nothing Then
                _DBCommand.Transaction = _Transcation
            End If

            rtnResult = _DBCommand.ExecuteNonQuery

        Catch ex As Threading.ThreadAbortException
            If _DBCommand IsNot Nothing Then
                _DBCommand.Cancel()
            End If
            _Log.AddMessage(clsLog4Net.enmType.Information, ex.ToString)
            rtnResult = -1
            GC.Collect()
        Catch ex As Data.Odbc.OdbcException
            If _DBCommand IsNot Nothing Then
                _DBCommand.Cancel()
            End If
            _Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Select Case ex.Errors(0).SQLState
                Case 23505
                    rtnResult = -23505
                Case Else
                    rtnResult = -1
            End Select
            GC.Collect()
        Catch ex As Exception
            If _DBCommand IsNot Nothing Then
                _DBCommand.Cancel()
            End If
            _Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            rtnResult = -1
            GC.Collect()
        Finally
            _DBCommand.Dispose()
            _DBCommand = Nothing

        End Try
        Return rtnResult


    End Function

    Private _Transcation As Object = Nothing

    Public Function BeginTran() As Boolean
        Try
            If _ODBCConnection.State = ConnectionState.Open Then
                _Transcation = _ODBCConnection.BeginTransaction
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            GC.Collect()
            Return False
        End Try

    End Function

    Public Function CommitTran() As Boolean
        Try
            If _ODBCConnection.State = ConnectionState.Open AndAlso _Transcation IsNot Nothing Then
                _Transcation.Commit()
                _Transcation = Nothing
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            GC.Collect()
            Return False
        End Try

    End Function

    Public Function RollbackTran() As Boolean
        Try
            If _ODBCConnection.State = ConnectionState.Open AndAlso _Transcation IsNot Nothing Then
                DirectCast(_Transcation, System.Data.Odbc.OdbcTransaction).Rollback()
                _Transcation = Nothing
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            GC.Collect()
            Return False
        End Try

    End Function


    Private Delegate Sub DelegateSetMessage(ByVal strMsg As String)



    Public Sub CancelCommand()
        If _DBCommand IsNot Nothing Then
            _DBCommand.Cancel()
            _DBCommand.Dispose()
            _DBCommand = Nothing
        End If
    End Sub






End Class

 