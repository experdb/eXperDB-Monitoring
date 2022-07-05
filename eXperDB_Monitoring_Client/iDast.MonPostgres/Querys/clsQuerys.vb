Public Class clsQuerys
    Private _ODBC As eXperDB.ODBC.eXperDBODBC = Nothing
    Public Sub New(ByVal ODBC As eXperDB.ODBC.eXperDBODBC)
        _ODBC = ODBC
    End Sub

    Public Function BeginTran() As Boolean
        Try
            If _ODBC.BeginTran() = True Then
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
            If _ODBC.CommitTran() = True Then
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
            If _ODBC.RollbackTran() = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            GC.Collect()
            Return False
        End Try
    End Function

    Public Function CheckPassword(ByVal strID As String, ByVal strPW As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("CHECKPASSWORD")
            strQuery = String.Format(strQuery, strID, strPW)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 AndAlso dtSet.Tables(0).Rows(0).Item(0) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Database Name List
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDatabaseLIst() As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("GETDATABASELIST")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

        End
    End Function

    ''' <summary>
    ''' Database Schema List 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSchemaLIst() As DataTable
        Try

            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("GETSCHEMALIST")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then

                Return dtSet.Tables(0)
            Else

                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

    End Function


    ''' <summary>
    ''' 수집서버 추가 
    ''' </summary>
    ''' <param name="IP"></param>
    ''' <param name="Port"></param>
    ''' <param name="DBType"></param>
    ''' <param name="User"></param>
    ''' <param name="Pw"></param>
    ''' <param name="Collect"></param>
    ''' <param name="PeriodSec"></param>
    ''' <param name="DBNm"></param>
    ''' <param name="AliasNm"></param>
    ''' <param name="LstIp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function insertServerList(ByVal IP As String, ByVal Port As String, ByVal DBType As String, ByVal User As String, ByVal Pw As String, ByVal Collect As String, ByVal PeriodSec As Integer, ByVal StmtPeriodSec As Integer, ByVal SnapPeriodMin As Integer, ByVal DBNm As String, ByVal AliasNm As String, ByVal LstIp As String, ByVal Schema As String, ByVal HARole As String, ByVal HAHost As String, ByVal HAPort As Integer, ByVal HAREPLHost As String) As Integer
        Try
            If _ODBC Is Nothing Then Return -1
            Dim strQuery As String = p_clsQueryData.fn_GetData("NEXTVAL")
            strQuery = String.Format(strQuery, "INSTANCE_ID")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            Dim intInstance As Integer = -1
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 AndAlso IsDBNull(dtSet.Tables(0).Rows(0).Item(0)) = False Then
                intInstance = dtSet.Tables(0).Rows(0).Item(0)
            Else
                Return -1
            End If
            If intInstance <> -1 Then
                strQuery = p_clsQueryData.fn_GetData("INSERTSERVERLIST")
                strQuery = String.Format(strQuery, intInstance, IP, Port, DBType, User, Pw, Collect, PeriodSec, StmtPeriodSec, SnapPeriodMin, DBNm, AliasNm, LstIp, Schema, HARole, HAHost, HAPort, HAREPLHost)
                If _ODBC.dbExecuteNonQuery(strQuery) > 0 Then
                    insertHealthLimitedList(intInstance, LstIp)
                    Return intInstance
                Else
                    Return -1
                End If
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function
    ''' <summary>
    ''' 수집서버 목록 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectServerList() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing

            Dim strQuery = p_clsQueryData.fn_GetData("SELECTSERVERLIST")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    'Robin-Start SELECTSERVERLISTfor Monitoring group
    ''' <summary>
    ''' 수집서버 목록 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectServerListByGroup() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing

            Dim strQuery = p_clsQueryData.fn_GetData("SELECTSERVERLISTBYGROUP")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    'Robin-Start SelectMonListByGroup for Monitoring group
    ''' <summary>
    ''' 수집서버 목록 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectMonListByGroup(ByVal groupId As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing

            Dim strQuery = p_clsQueryData.fn_GetData("SELECTMONLISTBYGROUP")
            strQuery = String.Format(strQuery, groupId)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' 수집서버 목록 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectGroupName(ByVal groupID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing

            Dim strQuery = p_clsQueryData.fn_GetData("SELECTGROUPNAME")
            strQuery = String.Format(strQuery, IIf(groupID, groupID, "0 or 1=1"))
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Check version
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectSeverVersion() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing

            Dim strQuery = p_clsQueryData.fn_GetData("SELECTSERVERVERSION")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    'Robin-End


    ''' <summary>
    ''' 수집서버 목록 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectServerListAdmin() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing

            Dim strQuery = p_clsQueryData.fn_GetData("SELECTSERVERLISTADMIN")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function


    Public Function UpdateServerList(ByVal InstanceID As Integer, ByVal IP As String, ByVal Port As String, ByVal DBType As String, ByVal User As String, ByVal Pw As String, ByVal Collect As String, ByVal PeriodSec As Integer, ByVal StmtPeriodSec As Integer, ByVal SnapPriodMin As Integer, ByVal DBNm As String, ByVal AliasNm As String, ByVal LstIp As String, ByVal Schema As String, ByVal HARole As String, ByVal HAHost As String, ByVal HAPort As Integer, ByVal HAREPLHost As String, ByVal VirtualIP As String, ByVal VirtualIP2 As String, ByVal ReScanStmt As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATESERVERLIST")
            strQuery = String.Format(strQuery, InstanceID, IP, Port, DBType, User, Pw, Collect, PeriodSec, StmtPeriodSec, SnapPriodMin, DBNm, AliasNm, LstIp, Schema, HARole, HAHost, HAPort, HAREPLHost, VirtualIP, VirtualIP2, ReScanStmt)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            insertHealthLimitedList(InstanceID, LstIp)
            Return rtnValue

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
    'Robin-Start UpdateMonGroup Monitoring group
    Public Function UpdateMonGroup(ByVal InstanceID As Integer, ByVal MonGroup_1 As Integer, ByVal LstIp As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEMONGROUP")
            strQuery = String.Format(strQuery, InstanceID, MonGroup_1, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
    Public Function DeleteMonGroup(ByVal groupId As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEMONLIST")
            strQuery = String.Format(strQuery, groupId)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
    Public Function InsertMonGroup(ByVal InstanceSEQ As Integer, ByVal InstanceID As Integer, ByVal groupId As Integer, ByVal LstIp As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTMONLIST")
            strQuery = String.Format(strQuery, groupId, InstanceSEQ, InstanceID, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
    Public Function UpdateGroup(ByVal groupID As Integer, ByVal groupName As String, ByVal isCoudGroup As Boolean, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEGROUP")
            strQuery = String.Format(strQuery, groupID, groupName, isCoudGroup, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function

    Public Function ResetCloudGroup(ByVal groupID As Integer, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("RESETCLOUDGROUP")
            strQuery = String.Format(strQuery, groupID, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function
     'Robin-end 

    Public Function DeleteServerList(ByVal InstanceID As Integer, ByVal LocIP As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETESERVERLIST")
            strQuery = String.Format(strQuery, InstanceID, LocIP)
            Return _ODBC.dbExecuteNonQuery(strQuery)

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try


    End Function

    Public Function SelectData(ByVal XMLID As String, ByVal ParamValue1 As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData(XMLID)
            If strQuery.Trim = "" Then Return Nothing
            strQuery = String.Format(strQuery, ParamValue1)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, "[" & XMLID & "]" & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectData(ByVal XMLID As String, ParamArray ParamValue1() As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData(XMLID)
            If strQuery.Trim = "" Then Return Nothing
            strQuery = String.Format(strQuery, ParamValue1)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, "[" & XMLID & "]" & ex.ToString)
            Return Nothing
        End Try
    End Function



    'Public Function SelectCpuMemINFO() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCPUMEMINFO")

    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If


    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing

    '    End Try

    'End Function

    ' ''' <summary>
    ' ''' Lock 정보 
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function SelectLockINFO() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKINFO")

    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing

    '    End Try

    'End Function

    ' ''' <summary>
    ' ''' Disk Information DISK I/O , Disk Usage 
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function SelectDiskInfo() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDISKINFO")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function
    ' ''' <summary>
    ' ''' REQUEST INFO , SESSION INFO , DB ACTIVITY(LOGICAL IO)
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function SelectRequestInfo() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREQUESTINFO")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function

    ' ''' <summary>
    ' ''' SQL Response Time 
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function SelectSQLRespTime() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSQLRESPTIME")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try

    'End Function
    ' ''' <summary>
    ' ''' Current Activity 
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function SelectCurrentAct() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCURRENTACT")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function
    ' ''' <summary>
    ' ''' Object Info 
    ' ''' </summary>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function SelectObject() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTOBJECT")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function


    'SELECTDBINFO
    Public Function SelectDBinfo(ByVal intInstancdID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDBINFO")
            strQuery = String.Format(strQuery, intInstancdID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectUserinfo(ByVal intInstancdID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTUSERINFO")
            strQuery = String.Format(strQuery, intInstancdID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function


    ''SELECTTBSPACEINFO
    'Public Function SelectTBspaceinfo() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTTBSPACEINFO")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function


    ''SELECTTBINFO
    'Public Function SelectTBinfo() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTTBINFO")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function


    ''SELECTINDEXINFO
    'Public Function Selectindexinfo() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTINDEXINFO")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception

    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function


    'Public Function SelectBackEnd() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTBACKEND")
    '        Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '        If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '            Return dtSet.Tables(0)
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        Return Nothing
    '    End Try
    'End Function

    'resurrend
    Public Function SelectPhysicaliO(ByVal InstanceID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTPHYSICALIO")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function



    Public Function UpdateHealthLimited(ByVal InstanceID As Integer,
                                     ByVal HchkNM As String,
                                     ByVal Warning As Integer,
                                     ByVal Critical As Integer,
                                     ByVal FixedThreshold As String,
                                     ByVal LastIp As String,
                                     Optional RetentionTime As Integer = 0,
                                     Optional Reserved As String = "") As String
        Try
            'If _ODBC Is Nothing Then Return -1
            'Dim strQuery As String = p_clsQueryData.fn_GetData("NEXTVAL")
            'strQuery = String.Format(strQuery, "INSTANCE_ID")
            'Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            'Dim intInstance As Integer = -1
            'If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 AndAlso IsDBNull(dtSet.Tables(0).Rows(0).Item(0)) = False Then
            '    intInstance = dtSet.Tables(0).Rows(0).Item(0)
            'Else
            '    Return -1
            'End If
            'If intInstance <> -1 Then
            Dim strQuery As String = ""
            strQuery = p_clsQueryData.fn_GetData("UPDATEHEALTHLIMITED")
            strQuery = String.Format(strQuery, InstanceID, HchkNM, Warning, Critical, FixedThreshold, LastIp, RetentionTime, Reserved)
            If _ODBC.dbExecuteNonQuery(strQuery) > 0 Then
                Return 1
            Else
                Return -1
            End If
            'Else
            '    Return -1
            'End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function

    Public Function UpdateHealthLimitedExt(ByVal InstanceID As Integer,
                                 ByVal NotiLevel As Integer,
                                 ByVal NotiGroup As Integer,
                                 ByVal NotiCycle As Integer,
                                 ByVal Business As String,
                                 ByVal LastIp As String) As String
        Try
            Dim strQuery As String = ""
            strQuery = p_clsQueryData.fn_GetData("UPDATEHEALTHLIMITEDEXT")
            strQuery = String.Format(strQuery, InstanceID, NotiGroup, NotiCycle, NotiLevel, Business, LastIp)
            If _ODBC.dbExecuteNonQuery(strQuery) > 0 Then
                Return 1
            Else
                Return -1
            End If
            'Else
            '    Return -1
            'End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function

    Public Function SelectHealthLimited(ByVal InstanceID As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTHEALTHLIMITED")
            strQuery = String.Format(strQuery, InstanceID)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

    End Function


    Public Function ExistsServer(ByVal strIP As String, ByVal strPort As String)
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("EXISTSSERVER")
            strQuery = String.Format(strQuery, strIP, strPort)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 AndAlso dtSet.Tables(0).Rows.Count > 0 Then
                Return dtSet.Tables(0).Rows(0).Item(0)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function insertHealthLimitedList(ByVal intInstancdID As Integer, ByVal strLocaliP As String) As Integer
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTHEALTHLIMITEDLIST")
            strQuery = String.Format(strQuery, intInstancdID, strLocaliP)
            Return _ODBC.dbExecuteNonQuery(strQuery)


        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function SelectHealth(ByVal enmShowSvrNm As clsEnums.ShowName) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTHEALTH")
            strQuery = String.Format(strQuery, enmShowSvrNm)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function UpdateConfig(ByVal intLogSaveDays As Integer, ByVal LstIP As String, ByVal BatchTime As String, ByVal Hchk_Period_sec As String, ByVal Objt_Period_sec As String, ByVal Stmt_Period_sec As String, ByVal intTReportSaveDays As Integer) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATECONFIG")
                strQuery = String.Format(strQuery, intLogSaveDays, LstIP, BatchTime, Hchk_Period_sec, Objt_Period_sec, Stmt_Period_sec, intTReportSaveDays)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function UpdateServerConnInfo(ByVal LstIP As String, ByVal strAgentIP As String, ByVal intAgentPort As Integer) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATESERVERCONNINFO")
                strQuery = String.Format(strQuery, strAgentIP, intAgentPort, LstIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function UpdateSnapshotConfig(ByVal intSnapshotSaveDays As Integer, ByVal intSnapshotTopN As Integer) As Integer
        Try
            Dim nReturn As Integer = 0
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATESNAPSHOTCONFIGTOPN")
                strQuery = String.Format(strQuery, intSnapshotTopN)
                nReturn = _ODBC.dbExecuteNonQuery(strQuery)
                If nReturn >= 0 Then
                    strQuery = p_clsQueryData.fn_GetData("UPDATESNAPSHOTCONFIGRETENTION")
                    strQuery = String.Format(strQuery, intSnapshotSaveDays)
                    nReturn = _ODBC.dbExecuteNonQuery(strQuery)
                    If nReturn >= 0 Then
                        strQuery = p_clsQueryData.fn_GetData("SELECTAPPLYCONF")
                        strQuery = String.Format(strQuery)
                        _ODBC.dbSelect(strQuery)
                    End If
                End If
                Return nReturn
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function UpdatePassword(ByVal UserID As String, ByVal UserPW As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEPASSWORD")
                strQuery = String.Format(strQuery, UserID, UserPW)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' 기본값은 7로 반환한다.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectConfig() As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCONFIG")
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If

            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

    End Function


    Public Function SelectReportCPU(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal enmShowSvrNm As clsEnums.ShowName) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTCPU")
                Dim subQuery As String = ""
                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), enmShowSvrNm.ToString("d"))

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectReportCPUChart(ByVal intInstanceID As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime, Optional pointCount As Integer = 600) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, stDate, edDate)
                Dim interval As String = minutes * 60 / pointCount
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTCPUCHART")
                Dim subQuery As String = ""
                If DateDiff(DateInterval.Day, stDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", stDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", stDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, intInstanceID, subQuery, stDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectReportCPUChartStats(ByVal intInstanceID As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, stDate, edDate)
                Dim strQuery As String = ""
                Dim subQuery As String = ""
                Dim interval As String = ""
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                strQuery = p_clsQueryData.fn_GetData("SELECTREPORTCPUCHARTSTATS")

                'If minutes <= 60 Then 'collect period
                '    interval = "1" '1 min
                'ElseIf minutes > 60 AndAlso minutes <= 240 Then
                '    interval = "60" '1 min
                'ElseIf minutes > 240 AndAlso minutes <= 720 Then
                '    interval = "120" '2 min
                'ElseIf minutes > 720 AndAlso minutes <= 1440 Then
                '    interval = "300" '5 min
                'Else
                '    interval = "1200"
                'End If

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}')", stDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, intInstanceID, _
                         stDate.ToString("yyyyMMdd"), _
                         edDate.ToString("yyyyMMdd"), _
                         stDate.ToString("yyyyMMdd HH:mm:ss"), _
                         edDate.ToString("yyyyMMdd HH:mm:ss"), _
                         interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectReportDisk(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTDISK")
                'Dim subQuery As String = ""

                'If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                '    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                'Else
                '    strQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                'End If

                strQuery = String.Format(strQuery, intInstanceID, StDate.ToString("yyyyMMdd"), StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyyMMdd"), edDate.ToString("yyyy-MM-dd HH:mm:59"))

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectReportDiskChart(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal DiskName As String) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = ""
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTDISKCHARTSTATS")
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount
                'If minutes <= 60 Then 'collect period
                '    interval = "1" '1 min
                'ElseIf minutes > 60 AndAlso minutes <= 240 Then
                '    interval = "60" '1 min
                'ElseIf minutes > 240 AndAlso minutes <= 720 Then
                '    interval = "120" '2 min
                'ElseIf minutes > 720 AndAlso minutes <= 1440 Then
                '    interval = "300" '5 min
                'Else
                '    interval = "1200"
                'End If

                Dim subQuery As String = ""

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), DiskName, interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function


    Public Function SelectReportDiskUsage(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = ""
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTDISKUSAGECHARTSTATS")
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                Dim subQuery As String = ""

                strQuery = String.Format(strQuery, intInstanceID, _
                                         StDate.ToString("yyyyMMdd"), _
                                         edDate.ToString("yyyyMMdd"), _
                                         StDate.ToString("yyyyMMdd HH:mm:ss"), _
                                         edDate.ToString("yyyyMMdd HH:mm:ss"), _
                                         interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    'Public Function SelectReportDBAccess(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


    '    Try
    '        If _ODBC IsNot Nothing Then
    '            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTDBACCESS")
    '            Dim subQuery As String = ""
    '            If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
    '                subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
    '            Else
    '                strQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
    '            End If
    '            strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))

    '            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '                Return dtSet.Tables(0)
    '            Else
    '                Return Nothing
    '            End If
    '        Else
    '            Return Nothing


    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        GC.Collect()
    '        Return Nothing
    '    End Try
    'End Function

    Public Function SelectReportTBAccess(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal enmShowSvrNm As clsEnums.ShowName) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTTBACCESS")
                Dim subQuery As String = ""
                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), enmShowSvrNm.ToString("d"))

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function


    Public Function SelectReportTBAccessStats(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal enmShowSvrNm As clsEnums.ShowName) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = ""
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                'If minutes <= 60 Then 'collect period
                '    interval = "1" '1 min
                'ElseIf minutes > 60 AndAlso minutes <= 240 Then
                '    interval = "60" '1 min
                'ElseIf minutes > 240 AndAlso minutes <= 720 Then
                '    interval = "120" '2 min
                'ElseIf minutes > 720 AndAlso minutes <= 1440 Then
                '    interval = "300" '5 min
                'Else
                '    interval = "1200"
                'End If

                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTTBACCESSSTATS")
                Dim subQuery As String = ""

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))

                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), enmShowSvrNm.ToString("d"), interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing

            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    'Public Function SelectReportSession(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


    '    Try
    '        If _ODBC IsNot Nothing Then
    '            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTSESSION")
    '            Dim subQuery As String = ""
    '            If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
    '                subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
    '            Else
    '                strQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
    '            End If
    '            strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))

    '            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '                Return dtSet.Tables(0)
    '            Else
    '                Return Nothing
    '            End If
    '        Else
    '            Return Nothing


    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        GC.Collect()
    '        Return Nothing
    '    End Try
    'End Function

    Public Function SelectReportSessionChart(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTSESSIONCHART")
                Dim subQuery As String = ""
                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"))

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectReportSessionChartStats(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = ""
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTSESSIONCHARTSTATS")
                Dim subQuery As String = ""
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function


    'Public Function SelectReportTransaction(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


    '    Try
    '        If _ODBC IsNot Nothing Then
    '            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTTRANSACTION")
    '            Dim subQuery As String = ""
    '            If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
    '                subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
    '            Else
    '                strQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
    '            End If
    '            strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))

    '            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
    '            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
    '                Return dtSet.Tables(0)
    '            Else
    '                Return Nothing
    '            End If
    '        Else
    '            Return Nothing


    '        End If
    '    Catch ex As Exception
    '        p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
    '        GC.Collect()
    '        Return Nothing
    '    End Try
    'End Function

    Public Function SelectReportSQL(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal strAgentVer As String, Optional intLimit As Integer = 1000) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                Dim strHint As String = ""
                If ConvDBL(strAgentVer) >= 10.4 Then
                    strQuery = p_clsQueryData.fn_GetData("SELECTREPORTSQLEXT")
                Else
                    strQuery = p_clsQueryData.fn_GetData("SELECTREPORTSQL")
                End If
                Dim subQuery As String = ""

                Dim intDiffDate = DateDiff(DateInterval.Day, StDate.Date, edDate.Date)
                strHint = "/*+" + vbCrLf
                For i As Integer = 0 To intDiffDate
                    Dim HintDate As DateTime = StDate.AddDays(i)
                    strHint += String.Format("IndexScan(e pk_tb_backend_rsc_{0})", HintDate.ToString("yyyyMMdd")) + vbCrLf
                Next
                strHint += "*/"

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"), strHint)
                strQuery += String.Format(" limit {0}", intLimit)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing


            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Sub CancelCommand()
        If _ODBC IsNot Nothing Then
            _ODBC.CancelCommand()
        End If
    End Sub

    Public Function SelectIniFixedThreshold() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTINIFIXEDTHRESHOLD")
            strQuery = String.Format(strQuery)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

    End Function

    ' Add Functions for accumulated chart in detail view
    Public Function SelectInitCPUChart(ByVal intInstanceID As String, ByVal strName As String, ByVal intInterval As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCPUMEMINFOPREV")
                strQuery = String.Format(strQuery, intInstanceID, strName, intInterval)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectInitSQLRespTmChart(ByVal strInstanceID As String, ByVal intDuration As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSQLRESPTIMEPREV")

                strQuery = String.Format(strQuery, strInstanceID, "now() - interval '" + intDuration.ToString() + " minute'")

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectInitPhysicalIOChart(ByVal intInstanceID As Integer) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTPHYSICALIOBEFORE")

                strQuery = String.Format(strQuery, intInstanceID)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectAlertSearch(ByVal StDate As DateTime,
                                      ByVal EdDate As DateTime,
                                      ByVal intInstanceID As String,
                                      ByVal intState As Integer,
                                      ByVal intChecked As Integer,
                                      ByVal enmShowSvrNm As String
                                     ) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTALERTSEARCH")
                Dim subQuery As String = ""

                subQuery = String.Format("AND ALERT.instance_id in ({0})", intInstanceID)

                If intState = 1 Then
                    subQuery += String.Format(" AND ALERT.state = {0}", 300)
                ElseIf intState = 2 Then
                    subQuery += String.Format(" AND ALERT.state = {0}", 200)
                End If
                If intChecked = 1 Then
                    subQuery += String.Format(" AND ALERT.check_user_id IS NOT NULL")
                ElseIf intChecked = 2 Then
                    subQuery += String.Format(" AND ALERT.check_user_id IS NULL")
                End If

                subQuery += String.Format(" ORDER BY ALERT.reg_date DESC, COL.reg_time DESC")
                strQuery = String.Format(strQuery, enmShowSvrNm, StDate.ToString("yyyyMMdd"), EdDate.ToString("yyyyMMdd"), StDate.ToString("yyyy-MM-dd HH:mm:00"), EdDate.ToString("yyyy-MM-dd HH:mm:00"))
                strQuery += subQuery
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function


#Region "HealthDetail"
    Public Function SelectHCHKBufferHitRatio(ByVal InstanceID As Integer, ByVal RegDate As String, ByVal Sequence As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("BUFFERHITRATIO")
            strQuery = String.Format(strQuery, InstanceID, RegDate, Sequence)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

    End Function

    Public Function SelectHCHKActiveConnection(ByVal RegDate As String, ByVal Sequence As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("ACTIVECONNECTION")
            strQuery = String.Format(strQuery, RegDate, Sequence)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

    End Function

    Public Function SelectHCHKCommitRatio(ByVal RegDate As String, ByVal Sequence As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("COMMITRATIO")
            strQuery = String.Format(strQuery, RegDate, Sequence)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectHCHKConnectionFail(ByVal InstanceID As Integer, ByVal RegDate As String, ByVal ActvSeq As Integer, ByVal RscSeq As Integer) As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("CONNECTIONFAIL")
            strQuery = String.Format(strQuery, InstanceID, RegDate, ActvSeq, RscSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKDiskUsage(ByVal RegDate As String, ByVal ObjSeq As String) As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("DISKUSAGE")
            strQuery = String.Format(strQuery, RegDate, ObjSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKLockCnt(ByVal RegDate As String, ByVal ObjSeq As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("LOCKCNT")
            strQuery = String.Format(strQuery, RegDate, ObjSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKLastAnalyze(ByVal instanceID As Integer, ByVal RegDate As String, ByVal ObjSeq As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("LASTANALYZE")
            strQuery = String.Format(strQuery, instanceID, RegDate, ObjSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKLastVacuum(ByVal instanceID As Integer, ByVal RegDate As String, ByVal ObjSeq As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("LASTVACUUM")
            strQuery = String.Format(strQuery, instanceID, RegDate, ObjSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKLongRunSql(ByVal instanceID As Integer, ByVal RegDate As String, ByVal ObjSeq As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("LONGRUNSQL")
            strQuery = String.Format(strQuery, instanceID, RegDate, ObjSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectHCHKTranxIDLECnt(ByVal RegDate As String, ByVal ObjSeq As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("TRAXIDLECNT")
            strQuery = String.Format(strQuery, RegDate, ObjSeq)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKUnusedIndex(ByVal InstanceID As Integer, ByVal RegDate As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("UNUSEDINDEX")
            strQuery = String.Format(strQuery, InstanceID, RegDate)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKInvalidIndex(ByVal InstanceID As Integer, ByVal RegDate As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("INVALIDINDEX")
            strQuery = String.Format(strQuery, InstanceID, RegDate)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKHAStatus(ByVal InstanceID As Integer, ByVal RegDate As String) As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("HASTATUS")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKReplicationSlots(ByVal InstanceID As Integer) As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("REPLICATION_SLOTS")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKVirtualIP(ByVal InstanceID As Integer) As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("VIRTUAL_IP")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectHCHKFrozenMaxAge(ByVal InstanceID As Integer, ByVal RegDate As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("FROZENMAXAGE")
            strQuery = String.Format(strQuery, InstanceID, RegDate)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectSerialKey() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSERIALKEY")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectLicense() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLICENSE")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectServerDate() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSERVERDATE")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
#End Region

#Region "ControlHistory"
    Public Function SelectSessionControlHistory(ByVal intInstanceID As String, ByVal enmShowSvrNm As String) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTBACKENDCONTROLHIST")

                strQuery = String.Format(strQuery, intInstanceID, enmShowSvrNm)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectLockControlHistory(ByVal intInstanceID As String, ByVal enmShowSvrNm As String) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKCONTROLHIST")

                strQuery = String.Format(strQuery, intInstanceID, enmShowSvrNm)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
#End Region
#Region "CheckAlert"
    Public Function UpdatePauseAlert(ByVal InstanceID As Integer, ByVal strHchkName As String, ByVal strPauseTime As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEPAUSEALERT")
            strQuery = String.Format(strQuery, InstanceID, strHchkName, strPauseTime)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function

    Public Function UpdateCheckAlert(ByVal strRegDate As String, ByVal intHchkRegSeq As Integer, ByVal InstanceID As Integer, ByVal strHchkName As String, ByVal User As String, ByVal strCheckComment As String, ByVal strLocalIp As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATECHECKALERT")
            strQuery = String.Format(strQuery, strRegDate, intHchkRegSeq, InstanceID, strHchkName, User, strCheckComment, strLocalIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
    Public Function SelectInitSessionInfoChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal intInterval As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSESSIONINFOPREV")
                Dim subQuery As String = ""

                subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                strQuery = String.Format(strQuery, InstanceID, subQuery, intInterval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectInitObjectChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal intInterval As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTOBJECTPREV")
                Dim subQuery As String = ""

                subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                If StDate = Nothing Then
                    strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "now() - interval '3 minute'", "now()", intInterval)
                Else
                    strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("yyyyMMdd HH:mm:ss") + "'", "'" + edDate.ToString("yyyyMMdd HH:mm:ss") + "'", intInterval)
                End If

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
#End Region

#Region "ChartDetail"

    Public Function SelectDetailSessionInfoChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, Optional pointCount As Integer = 600) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = minutes * 60 / pointCount
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILSESSIONINFO")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, subQuery, "BETWEEN " + "'" + StDate.ToString("yyyyMMdd HH:mm:ss") + "'" + " AND " + "'" + edDate.ToString("yyyyMMdd HH:mm:ss") + "'", interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectDetailObjectChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime, Optional pointCount As Integer = 600) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = minutes * 60 / pointCount
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILOBJECT")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:00") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:59") + "'", interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectDetailCallsChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime, Optional pointCount As Integer = 600) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = minutes * 60 / pointCount
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILCALLS")

                strQuery = String.Format(strQuery, InstanceID, strName, "'" + StDate.ToString("yyyy-MM-dd HH:mm:00") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:59") + "'", interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectDetailSQLRespChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, Optional pointCount As Integer = 600) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = minutes * 60 / pointCount
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILSQLRESPTIME")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:00") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:00") + "'", interval)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectDetailSQLListChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal strAgentVer As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                Dim strHint As String = ""

                If ConvDBL(strAgentVer) >= 10.4 Then
                    strQuery = p_clsQueryData.fn_GetData("SELECTDETAILSQLLISTEXT")
                Else
                    strQuery = p_clsQueryData.fn_GetData("SELECTDETAILSQLLIST")
                End If

                Dim subQuery As String = ""

                Dim intDiffDate = DateDiff(DateInterval.Day, StDate.Date, edDate.Date)
                If intDiffDate = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strHint = "/*+" + vbCrLf
                For i As Integer = 0 To intDiffDate
                    Dim HintDate As DateTime = StDate.AddDays(i)
                    strHint += String.Format("IndexScan(e pk_tb_backend_rsc_{0})", HintDate.ToString("yyyyMMdd")) + vbCrLf
                Next
                strHint += "*/"
                strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:ss") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:ss") + "'", strHint)
                'strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("HH:mm:ss") + "'", "'" + edDate.ToString("HH:mm:ss") + "'")

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectDetailPhysicalIOChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTPHYSICALIODETAIL")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:00") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:59") + "'")

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectLockCount(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal HaveDuration As Boolean, Optional ByVal intDuration As Integer = 3) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKACCUM")
                Dim subQuery As String = ""

                If HaveDuration = True Then
                    If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                        subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                    Else
                        subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                    End If
                    strQuery = String.Format(strQuery, InstanceID, subQuery, "BETWEEN " + "'" + StDate.ToString("HH:mm:ss") + "'" + " AND " + "'" + edDate.ToString("HH:mm:ss") + "'")
                Else
                    subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                    strQuery = String.Format(strQuery, InstanceID, subQuery, ">= (now() - interval '" + intDuration.ToString + " minute')")
                End If

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectLockCountTimeLine(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, Optional pointCount As Integer = 600) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim minutes As Long = DateDiff(DateInterval.Minute, StDate, edDate)
                Dim interval As String = minutes * 60 / pointCount
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKACCUMTIMELINE")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, subQuery, _
                                         "'" + StDate.ToString("yyyy-MM-dd") + "'::date + " + "'" + StDate.ToString("HH:mm:ss") + "'::time",
                                         "'" + edDate.ToString("yyyy-MM-dd") + "'::date + " + "'" + edDate.ToString("HH:mm:ss") + "'::time", interval)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectLockInfoAccum(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal HaveDuration As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKINFOACCUM")
                Dim subQuery As String = ""

                If HaveDuration = True Then
                    If DateDiff(DateInterval.Day, StDate.Date, edDate.Date) = 0 Then
                        subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                    Else
                        subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                    End If
                    strQuery = String.Format(strQuery, InstanceID, subQuery, "BETWEEN " + "'" + StDate.ToString("HH:mm:ss") + "'" + " AND " + "'" + edDate.ToString("HH:mm:ss") + "'")
                Else
                    subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                    strQuery = String.Format(strQuery, InstanceID, subQuery, ">= (now() - interval '3 minute')::time")
                End If

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectReplicationSlave(ByVal InstanceID As String, ByVal strName As String, ByVal isMaster As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""

                If isMaster = True Then
                    strQuery = p_clsQueryData.fn_GetData("SELECTREPLICATIONMASTER")
                Else
                    strQuery = p_clsQueryData.fn_GetData("SELECTREPLICATIONSTANDBY")
                End If

                strQuery = String.Format(strQuery, InstanceID, strName)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectReplication(ByVal InstanceID As String, ByVal isLatest As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPLICATION")
                Dim subQuery As String = ""

                subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                If isLatest = True Then
                    subQuery += vbCrLf
                    subQuery += "AND B.REPL_REG_SEQ = (SELECT MAX(REPL_REG_SEQ) FROM TB_REPLICATION_LAG_INFO C WHERE A.INSTANCE_ID = C.INSTANCE_ID AND B.REG_DATE = C.REG_DATE)"
                End If

                strQuery = String.Format(strQuery, InstanceID, subQuery)


                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectWaitEvent(ByVal InstanceID As String, ByVal minuteFrom As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                strQuery = p_clsQueryData.fn_GetData("SELECTWAITEVENT")
                strQuery = String.Format(strQuery, InstanceID, minuteFrom)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectCheckpoint(ByVal InstanceID As String, ByVal isLatest As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                Dim subQuery As String = ""

                subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"

                If isLatest = True Then
                    strQuery = p_clsQueryData.fn_GetData("SELECTCHECKPOINTLATEST")
                Else
                    strQuery = p_clsQueryData.fn_GetData("SELECTCHECKPOINT")
                End If

                strQuery = String.Format(strQuery, InstanceID, subQuery)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectSessionTopInfo(ByVal InstanceID As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""

                strQuery = p_clsQueryData.fn_GetData("SELECTSESSIONTOPINFO")
                strQuery = String.Format(strQuery, InstanceID)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function
    Public Function SelectStatementsList(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                strQuery = p_clsQueryData.fn_GetData("SELECTSTATEMENTLIST")

                Dim subQuery As String = ""
                Dim subQuery2 As String = ""

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                subQuery2 = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, InstanceID, subQuery, subQuery2)

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectStatementsTop(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal sortType As Integer, ByVal rank As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                strQuery = p_clsQueryData.fn_GetData("SELECTSTATEMENTSTOP")

                Dim subQuery As String = ""
                Dim subQuery2 As String = ""
                Dim subQuery3 As String = ""

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                subQuery2 = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                Select Case sortType
                    Case 1 : subQuery3 = "CALLS DESC, TOTAL_TIME DESC"
                    Case 2 : subQuery3 = "TOTAL_TIME DESC, CALLS DESC"
                    Case 3 : subQuery3 = "CPU_TIME DESC, TOTAL_TIME DESC"
                    Case 4 : subQuery3 = "IO_TIME, CPU_TIME DESC, TOTAL_TIME DESC"
                End Select
                strQuery = String.Format(strQuery, InstanceID, subQuery, subQuery2, subQuery3, rank)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectStatementsCalls(ByVal InstanceID As String, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal strQueries As String, ByVal strQueriesOrder As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSTATEMENTSCALLS")
                Dim subQuery As String = ""
                Dim subQuery2 As String = ""
                Dim subQuery3 As String = ""

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", stDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                subQuery2 = String.Format(" BETWEEN '{0}' AND '{1}'", stDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, InstanceID, subQuery, subQuery2, strQueries, strQueriesOrder)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectAutovacuumWorker(ByVal InstanceID As String, ByVal stDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTAUTOVACUUMWORKER")
                Dim subQuery As String = ""
                Dim subQuery2 As String = ""
                Dim interval As String = ""
                Dim minutes As Long = DateDiff(DateInterval.Minute, stDate, edDate)
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", stDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                subQuery2 = String.Format(" BETWEEN '{0}' AND '{1}'", stDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                strQuery = String.Format(strQuery, InstanceID, subQuery, subQuery2, interval)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectAutovacuumTop(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal rank As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                strQuery = p_clsQueryData.fn_GetData("SELECTAUTOVACUUMTOP")
                strQuery = String.Format(strQuery, InstanceID, StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"), rank)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectAutovacuumCount(ByVal InstanceID As String, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal strTables As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTAUTOVACUUMCOUNT")
                Dim subQuery As String = ""
                Dim subQuery2 As String = ""

                Dim minutes As Long = DateDiff(DateInterval.Minute, stDate, edDate)
                Dim interval As String = ""
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                'If minutes < 120 Then 'collect period
                '    interval = "1" '2 hour 5 min
                'ElseIf minutes > 240 AndAlso minutes <= 720 Then
                '    interval = "600" '4 hour 10 min
                'ElseIf minutes > 720 AndAlso minutes <= 1440 Then
                '    interval = "1200" '12 hour 20 min
                'ElseIf minutes > 1440 AndAlso minutes <= 2880 Then
                '    interval = "1800" '24 hour 30 min
                'Else
                '    interval = "3600" 'over 24 hour 60 min
                'End If

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", stDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                subQuery2 = String.Format(" BETWEEN '{0}'::timestamp AND '{1}'::timestamp", stDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                strQuery = String.Format(strQuery, InstanceID, subQuery, subQuery2, strTables, interval)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectDatabases(ByVal InstanceID As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                strQuery = p_clsQueryData.fn_GetData("SELECTDATABASES")
                strQuery = String.Format(strQuery, InstanceID)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectAutovacuumWraparound(ByVal InstanceID As String, ByVal stDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTAUTOVACUUMWRAPAROUND")
                Dim subQuery As String = ""

                Dim minutes As Long = DateDiff(DateInterval.Minute, stDate, edDate)
                Dim interval As String = ""
                Dim pointCount As Integer = 300

                interval = minutes * 60 / pointCount

                subQuery = String.Format(" BETWEEN '{0}'::timestamp AND '{1}'::timestamp", stDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                strQuery = String.Format(strQuery, InstanceID, subQuery, interval)
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SelectCurrentStatementsDuration(ByVal InstanceID As String, ByVal stDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCURRENTSTATEMENTSDURATION")

                strQuery = String.Format(strQuery, InstanceID, stDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

#End Region

#Region "Alert link"
    ''' <summary>
    ''' Alert link config
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectAlertLinkConfig(Optional ByVal index As Integer = -1) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strSub As String = ""
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTALERTLINKCONFIG")
            If index >= 0 Then
                strSub = " WHERE LINK_TYPE = " + CStr(index)
            End If
            strQuery = String.Format(strQuery, strSub)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try

        End
    End Function

    ''' <summary>
    ''' Set Alert link config
    ''' </summary>
    ''' <param name="DBMSType"></param>
    ''' <param name="IP"></param>
    ''' <param name="Port"></param>
    ''' <param name="User"></param>
    ''' <param name="Pw"></param>
    ''' <param name="Statements"></param>
    ''' <param name="LstIp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function insertAlertLinkConfig(ByVal DBMSType As String, ByVal IP As String, ByVal Port As String, ByVal Database As String, _
                                     ByVal User As String, ByVal Pw As String, _
                                     ByVal Statements As String, ByVal Sender As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return -1
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTALERTLINKCONFIG")
            strQuery = String.Format(strQuery, DBMSType, IP, Port, User, Pw, Database, Statements, Sender, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function

    Public Function SelectMonUserGroup() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTMONUSERGROUP")
            strQuery = String.Format(strQuery)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function InsertMonUserGroup(ByVal strGroupName As String, ByVal strUserID As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return -1
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTMONUSERGROUP")
            strQuery = String.Format(strQuery, strGroupName, strUserID, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function

    Public Function UpdateMonUserGroup(ByVal nGroupID As Integer, ByVal strGroupName As String, ByVal strUserID As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEMONUSERGROUP")
            strQuery = String.Format(strQuery, nGroupID, strGroupName, strUserID, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try

    End Function

    Public Function DeleteMonUserGroup(ByVal nGroupID As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEMONUSERGROUP")
            strQuery = String.Format(strQuery, nGroupID)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function

    Public Function SelectUserByGroup(ByVal GroupID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTUSERBYGROUP")
            strQuery = String.Format(strQuery, GroupID)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function DeleteUserByGroup(ByVal UserID As String, ByVal GroupID As Integer) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEUSERBYGROUP")
            strQuery = String.Format(strQuery, UserID, GroupID)
            Return _ODBC.dbExecuteNonQuery(strQuery)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Public Function SelectNotificationHistory(ByVal StDate As DateTime,
                                  ByVal EdDate As DateTime,
                                  ByVal intInstanceID As String,
                                  ByVal intLevel As Integer,
                                  ByVal strUserID As String,
                                  ByVal strResult As String,
                                  ByVal enmShowSvrNm As String
                                 ) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTNOTIFICATIONHISTORY")
                Dim subQuery As String = ""

                If strUserID.Length > 0 Then
                    subQuery += String.Format(" AND TU.USER_ID = '{0}'", strUserID)
                End If

                If strResult.Length > 0 Then
                    subQuery += String.Format(" AND TA.ISSUCCESS = '{0}'", strResult)
                End If

                strQuery = String.Format(strQuery, enmShowSvrNm, StDate.ToString("yyyy-MM-dd HH:mm:00"), EdDate.ToString("yyyy-MM-dd HH:mm:00"), intInstanceID, intLevel)
                subQuery += String.Format(" ORDER BY COLLECT_DT DESC")
                strQuery += subQuery

                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
            Return Nothing
        End Try
    End Function

    Public Function SetOptions(ByVal sOption As String, ByVal Value As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("SETOPTIONS")
            strQuery = String.Format(strQuery, sOption, Value)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
#End Region

#Region "User"
    ''' <summary>
    ''' Set User
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="UserName"></param>
    ''' <param name="UserPassword"></param>
    ''' <param name="UserPhone"></param>
    ''' <param name="UserEmail"></param>
    ''' <param name="LstIp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function insertUser(ByVal UserID As String, ByVal UserName As String, ByVal UserPassword As String, ByVal UserPhone As String, _
                               ByVal UserPhone2 As String, ByVal PhonIndexForNoti As Integer, ByVal UserEmail As String, ByVal UserEmpNum As String, ByVal Departments As String, _
                               ByVal isAdmin As Boolean, ByVal isLock As Boolean, ByVal ModUser As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return -1
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTUSER")
            strQuery = String.Format(strQuery, UserID, UserName, UserPassword, UserPhone, UserPhone2, PhonIndexForNoti, UserEmail, UserEmpNum, Departments, IIf(isAdmin, "true", "false"), IIf(isLock, "true", "false"), ModUser, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function
    Public Function UpdateUser(ByVal UserID As String, ByVal UserName As String, ByVal UserPhone As String, _
                               ByVal UserPhone2 As String, ByVal PhonIndexForNoti As Integer, ByVal UserEmail As String, ByVal UserEmpNum As String, _
                               ByVal UserDept As String, ByVal LstIp As String, Optional ByVal isAdmin As Integer = -1, Optional ByVal isLock As Integer = 0) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = ""
            If isAdmin >= 0 Then
                strQuery = p_clsQueryData.fn_GetData("UPDATEUSERADMIN")
                strQuery = String.Format(strQuery, UserID, UserName, UserPhone, UserPhone2, PhonIndexForNoti, UserEmail, UserEmpNum, UserDept, isAdmin, isLock, LstIp)
            Else
                strQuery = p_clsQueryData.fn_GetData("UPDATEUSER")
                strQuery = String.Format(strQuery, UserID, UserName, UserPhone, UserPhone2, PhonIndexForNoti, UserEmail, UserEmpNum, UserDept, LstIp)
            End If
            Return _ODBC.dbExecuteNonQuery(strQuery)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function
    Public Function DeleteUser(ByVal UserID As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEUSER")
            strQuery = String.Format(strQuery, UserID, LstIp)
            Return _ODBC.dbExecuteNonQuery(strQuery)

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function
    Public Function SelectUser(ByVal groupID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTUSER")
            strQuery = String.Format(strQuery, groupID)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectPrivileges() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTPRIVILEGES")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectPrivilegesByUser(ByVal UserID As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTPRIVILEGESBYUSER")
            strQuery = String.Format(strQuery, UserID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectAllowIP() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTALLOWIP")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectSecurityConfig() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSECURITYCONFIG")
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function CheckLoginFailCount(ByVal localIP As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("CHECKLOGINFAILCOUNT")
            strQuery = String.Format(strQuery, localIP)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function CheckLogin(ByVal strID As String, ByVal strPW As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("CHECKLOGIN")
            strQuery = String.Format(strQuery, strID, strPW)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function DoLogin(ByVal UserID As String, ByVal LoginDT As DateTime, ByVal strLocIP As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("DOLOGIN")
                strQuery = String.Format(strQuery, UserID, LoginDT.ToString("yyyy-MM-dd HH:mm:ss"), strLocIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function DoLogout(ByVal UserID As String, ByVal strLocIP As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("DOLOGOUT")
                strQuery = String.Format(strQuery, UserID, strLocIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function


    Public Function SetLoginFail(ByVal localIP As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SETLOGINFAIL")
                strQuery = String.Format(strQuery, localIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function
    Public Function ClearLoginFail(ByVal localIP As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("CLEARLOGINFAIL")
                strQuery = String.Format(strQuery, localIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function SelectUserPermission(ByVal strID As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTUSERPERMISSION")
            strQuery = String.Format(strQuery, strID)

            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function


    Public Function UpdateSecurityConfig(ByVal LockAccountFail As Integer, ByVal LockTimeout As Integer, ByVal LockAccountIdle As Integer, _
                                         ByVal isNonAlphaNum As Boolean, ByVal isDumLogin As Boolean, ByVal PasswordLength As Integer, _
                                         ByVal PasswordExpire As Integer, ByVal AlertPasswordExpire As Integer, ByVal strLocIP As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATESECURITYCONFIG")
                strQuery = String.Format(strQuery, LockAccountFail, LockTimeout, LockAccountIdle, isNonAlphaNum, isDumLogin, PasswordLength, _
                                         PasswordExpire, AlertPasswordExpire, strLocIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return -1
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function InsertUserPermission(ByVal UserID As String, ByVal nGroupID As Integer, ByVal nPermID As Integer, ByVal WorkUserID As String, ByVal strLocIP As String) As Boolean
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTUSERPERMISSION")
                strQuery = String.Format(strQuery, UserID, nGroupID, nPermID, WorkUserID, strLocIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function DeleteUserPermission(ByVal UserID As String, ByVal nGroupID As Integer, ByVal nPermID As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEUSERPERMISSION")
            strQuery = String.Format(strQuery, UserID, nGroupID, nPermID)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function

    Public Function SelectMonUserinfo(ByVal UserID As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTMONUSERINFO")
            strQuery = String.Format(strQuery, UserID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function InsertAllowIP(ByVal UserID As String, ByVal IPAddress As String) As Boolean
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTALLOWIP")
                strQuery = String.Format(strQuery, UserID, IPAddress)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function DeleteAllowIP(ByVal UserID As String, ByVal IPAddress As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEALLOWIP")
            strQuery = String.Format(strQuery, UserID, IPAddress)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function

    Public Function CheckAllowIP(ByVal UserID As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("CHECKALLOWIP")
            strQuery = String.Format(strQuery, UserID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
#End Region

#Region "User group"


    ''' <summary>
    ''' Set User
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="UserName"></param>
    ''' <param name="UserPassword"></param>
    ''' <param name="UserPhone"></param>
    ''' <param name="UserEmail"></param>
    ''' <param name="LstIp"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function insertUserGroup(ByVal UserID As String, ByVal GroupID As String, ByVal modUser As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return -1
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTUSERGROUP")
            strQuery = String.Format(strQuery, UserID, GroupID, modUser, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function InsertMonUserConfig(ByVal strUserID As String, ByVal nLanguage As Integer, ByVal nCollectPeriod As Integer, ByVal strSoundPath As String, _
                                       ByVal bShowHostName As Boolean, ByVal bUseAccountSQLPlan As Boolean, ByVal nCPUStyle As Integer, _
                                       ByVal bCPUDirection As Boolean, ByVal nMEMStyle As Integer, ByVal bMEMDirection As Boolean, _
                                       ByVal bCPUStyleDSP As Boolean, ByVal bMEMStyleDSP As Boolean) As Boolean
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTMONUSERCONFIG")
                strQuery = String.Format(strQuery, strUserID, nLanguage, nCollectPeriod, strSoundPath, bShowHostName, bUseAccountSQLPlan, _
                                         nCPUStyle, bCPUDirection, nMEMStyle, bMEMDirection, bCPUStyleDSP, bMEMStyleDSP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function InsertMonUserConfigDefault(ByVal strUserID As String) As Boolean
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTMONUSERCONFIGDEFAULT")
                strQuery = String.Format(strQuery, strUserID)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

    Public Function SelectMonUserConfig(ByVal UserID As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTMONUSERCONFIG")
            strQuery = String.Format(strQuery, UserID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function SelectUserAccessInfo(ByVal StDate As DateTime, ByVal EdDate As DateTime, ByVal UserID As String, _
                                         ByVal UserName As String, ByVal AccessType As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTUSERACCESSINFO")
            Dim strSubQuery As String = ""

            If UserID <> "All" Then
                strSubQuery = " AND A.user_id = '" + UserID + "'"
            End If

            If UserName <> "All" Then
                strSubQuery = " AND U.user_name = '" + UserName + "'"
            End If

            If AccessType <> "All" Then
                strSubQuery = " AND A.access_type = '" + AccessType + "'"
            End If

            strQuery = String.Format(strQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), EdDate.ToString("yyyy-MM-dd HH:mm:59"), strSubQuery)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function InsertUserAccessInfo(ByVal strUserID As String, ByVal strAccessType As String, ByVal intAccessStatus As Integer, ByVal strAccessLog As String, _
                                   ByVal strLocalIP As String, Optional intInstanceID As Integer = -1) As Boolean
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTUSERACCESSINFO")
                strQuery = String.Format(strQuery, strUserID, strAccessType, intInstanceID, intAccessStatus, strAccessLog, strLocalIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function

#End Region
#Region "Snapshot"

    Public Function SelectSnapshotPeriod(ByVal InstanceID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTPERIOD")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectSnapshotList(ByVal InstanceID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTLIST")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function SelectBaselineList(ByVal InstanceID As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTBASELINELIST")
            strQuery = String.Format(strQuery, InstanceID)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function InsertSnapshot(ByVal InstanceID As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTSNAPSHOT")
            strQuery = String.Format(strQuery, InstanceID)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return IIf(rtnValue > 0, True, False)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function
    Public Function InsertBaseline(ByVal InstanceID As Integer, ByVal baselineName As String, ByVal minSnapshot As Integer, ByVal maxSnapshot As Integer, ByVal keepDays As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTBASELINE")
            strQuery = String.Format(strQuery, InstanceID, baselineName, minSnapshot, maxSnapshot, keepDays)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return IIf(rtnValue > 0, True, False)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Public Function SelectCheckBaseline(ByVal InstanceID As Integer, ByVal BaselineName As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCHECKBASELINE")
            strQuery = String.Format(strQuery, InstanceID, BaselineName)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function DeleteBaseline(ByVal InstanceID As Integer, ByVal BaselineName As String) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("DELETEBASELINE")
            strQuery = String.Format(strQuery, InstanceID, BaselineName)
            Return _ODBC.dbExecuteNonQuery(strQuery)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return 0
        End Try
    End Function

    Public Function UpdateBaseline(ByVal InstanceID As Integer, ByVal baselineName As String, ByVal keepDays As Integer) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEBASELINE")
            strQuery = String.Format(strQuery, InstanceID, baselineName, keepDays)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return IIf(rtnValue > 0, True, False)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Public Function selectSnapshotReportSingleSnap(ByVal InstanceID As Integer, ByVal snapFrom As Integer, ByVal snapTo As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTREPORTSINGLESNAP")
            strQuery = String.Format(strQuery, InstanceID, snapFrom, snapTo)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectSnapshotReportSingleBL(ByVal InstanceID As Integer, ByVal baseline As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTREPORTSINGLEBL")
            strQuery = String.Format(strQuery, InstanceID, baseline)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectSnapshotReportCompSnapSnap(ByVal InstanceID As Integer, ByVal snapFrom As Integer, ByVal snapTo As Integer, ByVal snapCompFrom As Integer, ByVal snapCompTo As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTREPORTCOMPSNAPSNAP")
            strQuery = String.Format(strQuery, InstanceID, snapFrom, snapTo, snapCompFrom, snapCompTo)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectSnapshotReportCompSnapBL(ByVal InstanceID As Integer, ByVal snapFrom As Integer, ByVal snapTo As Integer, ByVal baselineComp As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTREPORTCOMPSNAPBL")
            strQuery = String.Format(strQuery, InstanceID, snapFrom, snapTo, baselineComp)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectSnapshotReportCompBLSnap(ByVal InstanceID As Integer, ByVal baseline As String, ByVal snapFrom As Integer, ByVal snapTo As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTREPORTCOMPBLSNAP")
            strQuery = String.Format(strQuery, InstanceID, baseline, snapFrom, snapTo)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectSnapshotReportCompBLBL(ByVal InstanceID As Integer, ByVal baseline As String, ByVal baselineComp As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSNAPSHOTREPORTCOMPBLBL")
            strQuery = String.Format(strQuery, InstanceID, baseline, baselineComp)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectReportItems() As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTITEMS")
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectTrendReport(ByVal InstanceID As String, ByVal startDt As DateTime, ByVal endDt As DateTime, ByVal period As Integer, ByVal arrItems As ArrayList) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim trendType As Integer() = arrItems.ToArray(GetType(Integer))
            Dim strTrends = String.Join(",", trendType)
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTTRENDREPORT")
            'Dim period As String = IIf(isHour = True, "3600", "86400")
            strQuery = String.Format(strQuery, InstanceID, startDt.ToString("yyyy-MM-dd HH:mm:ss"), endDt.ToString("yyyy-MM-dd HH:mm:ss"), strTrends, period)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectTrendReportStmtStat(ByVal InstanceID As String, ByVal startDt As DateTime, ByVal endDt As DateTime, ByVal reportType As Integer, ByVal strName As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTTRENDREPORTSTMTSTAT")
            strQuery = String.Format(strQuery, InstanceID, startDt.ToString("yyyy-MM-dd HH:mm:ss"), endDt.ToString("yyyy-MM-dd HH:mm:ss"), reportType, strName)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectTrendReportLock(ByVal InstanceID As String, ByVal startDt As DateTime, ByVal endDt As DateTime, ByVal reportType As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTTRENDREPORTLOCK")
            strQuery = String.Format(strQuery, InstanceID, startDt.ToString("yyyy-MM-dd HH:mm:ss"), endDt.ToString("yyyy-MM-dd HH:mm:ss"), reportType)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function selectTrendReportQuery(ByVal InstanceID As String, ByVal arrItems As ArrayList) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim trendType As String() = arrItems.ToArray(GetType(String))
            Dim strTrends = "'" + String.Join("','", trendType) + "'"
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTTRENDREPORTQUERY")
            strQuery = String.Format(strQuery, InstanceID, strTrends)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function InsertReportInfo(ByVal strUserID As String, ByVal strAccessType As Integer, ByVal intAccessStatus As Integer, ByVal strAccessLog As String, _
                               ByVal strLocalIP As String, Optional intInstanceID As Integer = -1) As Boolean
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTREPORTINFO")
                strQuery = String.Format(strQuery, strUserID, strAccessType, intInstanceID, intAccessStatus, strAccessLog, strLocalIP)
                Return _ODBC.dbExecuteNonQuery(strQuery)
            Else
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return -1
        End Try
    End Function


    Public Function SelectReportInfo(ByVal instanceID As Integer, ByVal StDate As DateTime, ByVal EdDate As DateTime, ByVal UserID As String, _
                                         ByVal UserName As String, ByVal ReportType As Integer) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTINFO")
            Dim strSubQuery As String = ""

            If UserID <> "All" Then
                strSubQuery += " AND A.user_id = '" + UserID + "'"
            End If

            If UserName <> "All" Then
                strSubQuery += " AND U.user_name = '" + UserName + "'"
            End If

            If ReportType <> 0 Then
                strSubQuery += " AND A.report_type = " + (ReportType).ToString
            End If

            strQuery = String.Format(strQuery, instanceID, StDate.ToString("yyyy-MM-dd HH:mm:00"), EdDate.ToString("yyyy-MM-dd HH:mm:59"), strSubQuery)
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)

            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                Return dtSet.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return Nothing
        End Try
    End Function
#End Region
End Class

