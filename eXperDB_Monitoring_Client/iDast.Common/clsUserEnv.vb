Public Class clsUserEnv
    Private _UserID As String
    Private _CFG_CollectPeriod As Integer
    Private _CFG_SirenName As String
    Private _CFG_ServerName As String
    Private _CFG_UseDefaultAccount As Integer
    Private _CFG_CPUStyle As Integer
    Private _CFG_MEMStyle As Integer
    Private _CFG_CPUReverse As Integer
    Private _CFG_MEMReverse As Integer

    Public Sub New(ByVal UserID As String, ByVal CollectPeriod As Integer, ByVal SirenName As String, ByVal ServerName As String, _
                   ByVal UseDefaultAccount As Integer, ByVal CPUStyle As Integer, ByVal MEMStyle As Integer, ByVal CPUReverse As Integer, ByVal MEMReverse As Integer)
        Try
            _UserID = UserID
            _CFG_CollectPeriod = CollectPeriod
            _CFG_SirenName = SirenName
            _CFG_ServerName = ServerName
            _CFG_UseDefaultAccount = UseDefaultAccount
            _CFG_CPUStyle = CPUStyle
            _CFG_MEMStyle = MEMStyle
            _CFG_CPUReverse = CPUReverse
            _CFG_MEMReverse = MEMReverse
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

End Class
