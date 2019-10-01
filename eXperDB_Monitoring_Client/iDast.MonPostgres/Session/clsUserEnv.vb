Public Class clsUserEnv
    Private _UserID As String
    Private _CFG_CollectPeriod As Integer
    Private _CFG_SirenName As String
    Private _CFG_ServerName As Integer
    Private _CFG_UseDefaultAccount As Integer
    Private _CFG_CPUStyle As Integer
    Private _CFG_MEMStyle As Integer
    Private _CFG_CPUReverse As Integer
    Private _CFG_MEMReverse As Integer
    Private _CFG_CPUStyleDSP As Integer
    Private _CFG_MEMStyleDSP As Integer
    ReadOnly Property CFG_CollectPeriod As Integer
        Get
            Return _CFG_CollectPeriod
        End Get
    End Property
    ReadOnly Property CFG_SirenName As String
        Get
            Return _CFG_SirenName
        End Get
    End Property
    ReadOnly Property CFG_ServerName As Integer
        Get
            Return _CFG_ServerName
        End Get
    End Property
    ReadOnly Property CFG_UseDefaultAccount As Integer
        Get
            Return _CFG_UseDefaultAccount
        End Get
    End Property
    ReadOnly Property CFG_CPUStyle As Integer
        Get
            Return _CFG_CPUStyle
        End Get
    End Property
    ReadOnly Property CFG_MEMStyle As Integer
        Get
            Return _CFG_MEMStyle
        End Get
    End Property
    ReadOnly Property CFG_CPUReverse As Integer
        Get
            Return _CFG_CPUReverse
        End Get
    End Property
    ReadOnly Property CFG_MEMReverse As Integer
        Get
            Return _CFG_MEMReverse
        End Get
    End Property
    ReadOnly Property CFG_CPUStyleDSP As Integer
        Get
            Return _CFG_CPUStyleDSP
        End Get
    End Property
    ReadOnly Property CFG_MEMStyleDSP As Integer
        Get
            Return _CFG_MEMStyleDSP
        End Get
    End Property

    Public Sub New(ByVal UserID As String, ByVal CollectPeriod As Integer, ByVal SirenName As String, ByVal ServerName As Integer, _
                   ByVal UseDefaultAccount As Integer, ByVal CPUStyle As Integer, ByVal MEMStyle As Integer, ByVal CPUReverse As Integer, ByVal MEMReverse As Integer, _
                   ByVal CPUStyleDSP As Integer, ByVal MEMStyleDSP As Integer)
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
            _CFG_CPUStyleDSP = CPUStyleDSP
            _CFG_MEMStyleDSP = MEMStyleDSP
        Catch ex As Exception
            GC.Collect()
        End Try
    End Sub

End Class
