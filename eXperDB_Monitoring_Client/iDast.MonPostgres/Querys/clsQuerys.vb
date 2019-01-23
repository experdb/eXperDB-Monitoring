Public Class clsQuerys
    Private _ODBC As eXperDB.ODBC.eXperDBODBC = Nothing
    Public Sub New(ByVal ODBC As eXperDB.ODBC.eXperDBODBC)
        _ODBC = ODBC
    End Sub

    

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
    Public Function insertServerList(ByVal IP As String, ByVal Port As String, ByVal DBType As String, ByVal User As String, ByVal Pw As String, ByVal Collect As String, ByVal PeriodSec As Integer, ByVal DBNm As String, ByVal AliasNm As String, ByVal LstIp As String, ByVal Schema As String, ByVal HARole As String, ByVal HAHost As String, ByVal HAPort As Integer, ByVal HAREPLHost As String) As Integer
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
                strQuery = String.Format(strQuery, intInstance, IP, Port, DBType, User, Pw, Collect, PeriodSec, DBNm, AliasNm, LstIp, Schema, HARole, HAHost, HAPort, HAREPLHost)
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


    Public Function UpdateServerList(ByVal InstanceID As Integer, ByVal IP As String, ByVal Port As String, ByVal DBType As String, ByVal User As String, ByVal Pw As String, ByVal Collect As String, ByVal PeriodSec As Integer, ByVal DBNm As String, ByVal AliasNm As String, ByVal LstIp As String, ByVal Schema As String, ByVal HARole As String, ByVal HAHost As String, ByVal HAPort As Integer, ByVal HAREPLHost As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATESERVERLIST")
            strQuery = String.Format(strQuery, InstanceID, IP, Port, DBType, User, Pw, Collect, PeriodSec, DBNm, AliasNm, LstIp, Schema, HARole, HAHost, HAPort, HAREPLHost)
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
    Public Function InsertMonGroup(ByVal InstanceID As Integer, ByVal groupId As Integer, ByVal LstIp As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("INSERTMONLIST")
            strQuery = String.Format(strQuery, groupId, InstanceID, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function
    Public Function UpdateGroup(ByVal groupID As Integer, ByVal groupName As String, ByVal LstIp As String) As Integer
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEGROUP")
            strQuery = String.Format(strQuery, groupID, groupName, LstIp)
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
                                     Optional RetentionTime As Integer = 0) As String
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
            strQuery = String.Format(strQuery, InstanceID, HchkNM, Warning, Critical, FixedThreshold, LastIp, RetentionTime)
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

    Public Function UpdateConfig(ByVal intLogSaveDays As Integer, ByVal LstIP As String, ByVal BatchTime As String, ByVal Hchk_Period_sec As String, ByVal Objt_Period_sec As String, ByVal Stmt_Period_sec As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATECONFIG")
                strQuery = String.Format(strQuery, intLogSaveDays, LstIP, BatchTime, Hchk_Period_sec, Objt_Period_sec, Stmt_Period_sec)
                Return _ODBC.dbExecuteNonQuery(strQuery)
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
                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
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

    Public Function SelectReportCPUChart(ByVal intInstanceID As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTCPUCHART")
                Dim subQuery As String = ""
                If DateDiff(DateInterval.Day, stDate, edDate) = 0 Then
                    subQuery = String.Format(" = '{0}'", stDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", stDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, intInstanceID, subQuery, stDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"))

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

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
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
                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
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
                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
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

    Public Function SelectReportSQL(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal strAgentVer As String) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                If ConvDBL(strAgentVer) >= 10.4 Then
                    strQuery = p_clsQueryData.fn_GetData("SELECTREPORTSQLEXT")
                Else
                    strQuery = p_clsQueryData.fn_GetData("SELECTREPORTSQL")
                End If
                Dim subQuery As String = ""

                subQuery = String.Format(" BETWEEN '{0}' AND '{1}'", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:ss"), edDate.ToString("yyyy-MM-dd HH:mm:ss"))

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
    Public Function SelectHCHKUnusedIndex(ByVal RegDate As String, ByVal ObjSeq As String) As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("UNUSEDINDEX")
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
                strQuery = String.Format(strQuery, InstanceID, subQuery, ">= (now() - interval '10 minute')::time AND COL.REG_TIME < (now())::time", intInterval)

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
                    strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "now() - interval '10 minute'", "now()", intInterval)
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

    Public Function SelectDetailSessionInfoChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILSESSIONINFO")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, subQuery, "BETWEEN " + "'" + StDate.ToString("HH:mm:ss") + "'" + " AND " + "'" + edDate.ToString("HH:mm:ss") + "'")

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
    Public Function SelectDetailObjectChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILOBJECT")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:00") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:59") + "'")

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
    Public Function SelectDetailSQLRespChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILSQLRESPTIME")
                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
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
    Public Function SelectDetailSQLListChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal strAgentVer As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = ""
                If ConvDBL(strAgentVer) >= 10.4 Then
                    strQuery = p_clsQueryData.fn_GetData("SELECTDETAILSQLLISTEXT")
                Else
                    strQuery = p_clsQueryData.fn_GetData("SELECTDETAILSQLLIST")
                End If

                Dim subQuery As String = ""

                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:ss") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:ss") + "'")

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

                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
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
    Public Function SelectLockCount(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal HaveDuration As Boolean, Optional ByVal intDuration As Integer = 10) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKACCUM")
                Dim subQuery As String = ""

                If HaveDuration = True Then
                    If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                        subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                    Else
                        subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                    End If
                    strQuery = String.Format(strQuery, InstanceID, subQuery, "BETWEEN " + "'" + StDate.ToString("HH:mm:ss") + "'" + " AND " + "'" + edDate.ToString("HH:mm:ss") + "'")
                Else
                    subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                    strQuery = String.Format(strQuery, InstanceID, subQuery, ">= (now() - interval '" + intDuration.ToString + " minute')::time")
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

    Public Function SelectLockInfoAccum(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal HaveDuration As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTLOCKINFOACCUM")
                Dim subQuery As String = ""

                If HaveDuration = True Then
                    If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                        subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                    Else
                        subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                    End If
                    strQuery = String.Format(strQuery, InstanceID, subQuery, "BETWEEN " + "'" + StDate.ToString("HH:mm:ss") + "'" + " AND " + "'" + edDate.ToString("HH:mm:ss") + "'")
                Else
                    subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                    strQuery = String.Format(strQuery, InstanceID, subQuery, ">= (now() - interval '10 minute')::time")
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
                    subQuery += "AND B.REPL_REG_SEQ = (SELECT MAX(REPL_REG_SEQ) FROM TB_REPLICATION_INFO C WHERE A.INSTANCE_ID = C.INSTANCE_ID AND B.REG_DATE = C.REG_DATE)"
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
#End Region
End Class
