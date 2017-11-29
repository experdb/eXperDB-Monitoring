Public Class clsQuerys_MultiConnection
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
                If _ODBC.dbExecuteNonQuery(strQuery) = True Then
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

    Public Function SelectData(ByVal ODBCCn As eXperDB.ODBC.DXODBC, ByVal XMLID As String) As DataTable
        Try
            If ODBCCn Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData(XMLID)
            If strQuery.Trim = "" Then Return Nothing
            Dim dtSet As DataSet = ODBCCn.dbSelect(strQuery)
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

    'Public Function SelectPhysicaliO() As DataTable
    '    Try
    '        If _ODBC Is Nothing Then Return Nothing
    '        Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTPHYSICALIO")
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



    Public Function UpdateHealthLimited(ByVal InstanceID As Integer,
                                     ByVal HchkNM As String,
                                     ByVal Warning As Integer,
                                     ByVal Critical As Integer,
                                     ByVal Fixed As String,
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
            strQuery = String.Format(strQuery, InstanceID, HchkNM, Warning, Critical, Fixed, LastIp)
            If _ODBC.dbExecuteNonQuery(strQuery) = True Then
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
            Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
            If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
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

    Public Function SelectHealth() As DataTable
        Try
            If _ODBC Is Nothing Then Return Nothing
            Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTHEALTH")

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

    Public Function UpdateConfigKeepDays(ByVal intLogSaveDays As Integer, ByVal LstIP As String, ByVal BatchTime As String) As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("UPDATECONFIGKEEPDAYS")
                strQuery = String.Format(strQuery, intLogSaveDays, LstIP, BatchTime)
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
    Public Function SelectConfigKeepDays() As Integer
        Try
            If _ODBC IsNot Nothing Then
                Dim strQuery As String = p_clsQueryData.fn_GetData("SELECTCONFIGKEEPDAYS")
                Dim dtSet As DataSet = _ODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    Return dtSet.Tables(0).Rows(0).Item(0)
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




End Class
