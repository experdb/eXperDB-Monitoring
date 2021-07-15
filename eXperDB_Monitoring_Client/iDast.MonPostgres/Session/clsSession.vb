Public Class clsSession

    Private _UserID As String
    Private _UserPassword As String
    Private _isAdmin As String
    Private _loginDt As DateTime
    Private _logoutDt As DateTime
    Private _Status As enumStatus

    ReadOnly Property UserID As String
        Get
            Return _UserID
        End Get
    End Property
    Property UserPassword As String
        Get
            Return _UserPassword
        End Get
        Set(value As String)
            _UserPassword = value
        End Set
    End Property
    ReadOnly Property isAdmin As String
        Get
            Return _isAdmin
        End Get
    End Property
    ReadOnly Property loginDt As String
        Get
            Return _loginDt
        End Get
    End Property
    ReadOnly Property logoutDt As String
        Get
            Return _logoutDt
        End Get
    End Property
    ReadOnly Property Status As String
        Get
            Return _Status
        End Get
    End Property

    Public Sub New(ByVal UserID As String, ByVal UserPassword As String, ByVal isAdmin As Boolean, ByVal loginDt As DateTime)
        Try
            _UserID = UserID
            _UserPassword = UserPassword
            _isAdmin = isAdmin
            _loginDt = loginDt
            _Status = enumStatus.Normal
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

    Private Sub AddPermisions(ByVal permRows As DataRowCollection)
        _Items.Clear()
        For Each permRow As DataRow In permRows
            Dim pi As PermInfo = New PermInfo(Integer.Parse(permRow.Item("GROUP_ID").ToString), Integer.Parse(permRow.Item("PERM_ID").ToString))
            _Items.Add(pi)
        Next
    End Sub

    Public Function loadUserPermission(ByRef clsQuery As clsQuerys) As Boolean
        Try
            Dim dtTablePermission As DataTable = clsQuery.SelectUserPermission(_UserID)
            If dtTablePermission IsNot Nothing AndAlso dtTablePermission.Rows.Count > 0 Then
                p_cSession.AddPermisions(dtTablePermission.Rows)
            End If
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Public Sub logout()
        Try
            _logoutDt = Now
            _Status = enumStatus.Disconnect
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

    ReadOnly Property checkStatus() As Boolean
        Get
            If _Status = enumStatus.Normal Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Enum enumStatus
        Normal
        Disconnect
        SessionError
        [End]
    End Enum


    Private _Items As New List(Of PermInfo)
    ReadOnly Property Items As List(Of PermInfo)
        Get
            Return _Items
        End Get
    End Property

    ReadOnly Property checkPermission(ByVal nGroupID As Integer, ByVal nPermID As Integer) As Boolean
        Get
            For Each PermInfo As PermInfo In _Items
                If PermInfo.nGroupID = nGroupID AndAlso PermInfo.nPermID = nPermID Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property

    Public Function getGroupPermission() As ArrayList
        Dim tmpArray As New ArrayList
        Dim nPrevGroupID = -1
        For Each PermInfo As PermInfo In _Items
            If PermInfo.nGroupID <> nPrevGroupID Then
                tmpArray.Add(PermInfo.nGroupID)
                nPrevGroupID = PermInfo.nGroupID
            End If
        Next
        Return tmpArray
    End Function

    Public Class PermInfo
        Public Sub New(ByVal nGroupID As Integer, ByVal nPermID As Integer)
            _nGroupID = nGroupID
            _nPermID = nPermID
        End Sub

        Private _nGroupID As Integer = -1
        Property nGroupID
            Get
                Return _nGroupID
            End Get
            Set(nGroupID)
                _nGroupID = nGroupID
            End Set
        End Property

        Private _nPermID As Integer
        Property nPermID As Integer
            Get
                Return _nPermID
            End Get
            Set(nPermID As Integer)
                _nPermID = nPermID
            End Set
        End Property

    End Class
End Class
