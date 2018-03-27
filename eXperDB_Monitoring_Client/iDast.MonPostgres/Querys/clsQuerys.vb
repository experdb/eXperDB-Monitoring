Public Class clsQuerys
    Private _ODBC As eXperDB.ODBC.DXODBC = Nothing
    Public Sub New(ByVal ODBC As eXperDB.ODBC.DXODBC)
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
    Public Function insertServerList(ByVal IP As String, ByVal Port As String, ByVal DBType As String, ByVal User As String, ByVal Pw As String, ByVal Collect As String, ByVal PeriodSec As Integer, ByVal DBNm As String, ByVal AliasNm As String, ByVal LstIp As String, ByVal Schema As String) As Integer
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
                strQuery = String.Format(strQuery, intInstance, IP, Port, DBType, User, Pw, Collect, PeriodSec, DBNm, AliasNm, LstIp, Schema)
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


    Public Function UpdateServerList(ByVal InstanceID As Integer, ByVal IP As String, ByVal Port As String, ByVal DBType As String, ByVal User As String, ByVal Pw As String, ByVal Collect As String, ByVal PeriodSec As Integer, ByVal DBNm As String, ByVal AliasNm As String, ByVal LstIp As String, ByVal Schema As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATESERVERLIST")
            strQuery = String.Format(strQuery, InstanceID, IP, Port, DBType, User, Pw, Collect, PeriodSec, DBNm, AliasNm, LstIp, Schema)
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
    Public Function UpdateGroup(ByVal groupID As Integer, ByVal groupName As String, ByVal LstIp As String) As Boolean
        Try
            If _ODBC Is Nothing Then Return False
            Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATEGROUP")
            strQuery = String.Format(strQuery, groupID, groupName, LstIp)
            Dim rtnValue As Integer = _ODBC.dbExecuteNonQuery(strQuery)
            Return rtnValue

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
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


    ''SELECTDBINFO
    'Public Function SelectDBinfo() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDBINFO")
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
                                     ByVal LastIp As String) As String
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
            strQuery = String.Format(strQuery, InstanceID, HchkNM, Warning, Critical, FixedThreshold, LastIp)
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

    Public Function UpdateConfig(ByVal intLogSaveDays As Integer, ByVal LstIP As String, ByVal BatchTime As String, ByVal Hchk_Period_sec As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATECONFIG")
                strQuery = String.Format(strQuery, intLogSaveDays, LstIP, BatchTime, Hchk_Period_sec)
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
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTDISKCHART")
                Dim subQuery As String = ""
                If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                    subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                Else
                    subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                End If
                strQuery = String.Format(strQuery, intInstanceID, subQuery, StDate.ToString("yyyy-MM-dd HH:mm:00"), edDate.ToString("yyyy-MM-dd HH:mm:59"), DiskName)

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

    Public Function SelectReportSQL(ByVal intInstanceID As Integer, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable


        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTREPORTSQL")
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
    Public Function SelectInitCPUChart(ByVal intInstanceID As Integer, ByVal strName As String) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCPUMEMINFOBEFORE")

                strQuery = String.Format(strQuery, intInstanceID, strName)
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
    Public Function SelectInitSQLRespTmChart(ByVal intInstanceID As Integer) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSQLRESPTIMEBEFORE")

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
    Public Function SelectAlertSearch(ByVal strDay As String,
                                      ByVal StDate As String,
                                      ByVal EdDate As String,
                                      ByVal intInstanceID As Integer,
                                      ByVal intState As Integer,
                                      ByVal intChecked As Integer,
                                      ByVal enmShowSvrNm As String
                                     ) As DataTable

        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTALERTSEARCH")
                Dim subQuery As String = ""

                If intInstanceID > 0 Then
                    subQuery = String.Format("AND ALERT.instance_id = {0}", intInstanceID)
                End If
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
                strQuery = String.Format(strQuery, enmShowSvrNm, strDay, StDate, EdDate)
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

    Public Function SelectHCHKConnectionFail(ByVal InstanceID As Integer, ByVal RegDate As String, ByVal ObjSeq As Integer, ByVal ActvSeq As Integer, ByVal RscSeq As Integer) As DataTable

        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("CONNECTIONFAIL")
            strQuery = String.Format(strQuery, InstanceID, RegDate, ObjSeq, ActvSeq, RscSeq)
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
#End Region

#Region "ChartDetail"
    Public Function SelectInitSessionInfoChart(ByVal InstanceID As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal HaveDuration As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTSESSIONINFOBEFORE")
                Dim subQuery As String = ""

                If HaveDuration = True Then
                    If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                        subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                    Else
                        subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                    End If
                    strQuery = String.Format(strQuery, InstanceID, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:ss") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:ss") + "'")
                Else
                    subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                    strQuery = String.Format(strQuery, InstanceID, subQuery, "now() - interval '10 minute'", "now()")
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
    Public Function SelectInitObjectChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime, ByVal HaveDuration As Boolean) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTOBJECTBEFORE")
                Dim subQuery As String = ""

                If HaveDuration = True Then
                    If DateDiff(DateInterval.Day, StDate, edDate) = 0 Then
                        subQuery = String.Format(" = '{0}'", StDate.ToString("yyyyMMdd"))
                    Else
                        subQuery = String.Format(" IN ('{0}','{1}')", StDate.ToString("yyyyMMdd"), edDate.ToString("yyyyMMdd"))
                    End If
                    strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "'" + StDate.ToString("yyyy-MM-dd HH:mm:00") + "'", "'" + edDate.ToString("yyyy-MM-dd HH:mm:59") + "'")
                Else
                    subQuery = " = TO_CHAR(NOW(),'YYYYMMDD')"
                    strQuery = String.Format(strQuery, InstanceID, strName, subQuery, "now() - interval '10 minute'", "now()")
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
    Public Function SelectDetailSQLListChart(ByVal InstanceID As String, ByVal strName As String, ByVal StDate As DateTime, ByVal edDate As DateTime) As DataTable
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTDETAILSQLLIST")
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
#End Region
End Class
