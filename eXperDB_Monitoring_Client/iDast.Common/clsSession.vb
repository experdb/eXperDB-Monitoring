Public Class clsSession

    Private _UserID As String
    Private _UserPassword As String
    Private _isAdmin As String
    Private _loginDt As DateTime
    Private _Status As enumStatus

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

    Public Enum enumStatus
        Normal
        Disconnect
        SessionError
        [End]
    End Enum

End Class
