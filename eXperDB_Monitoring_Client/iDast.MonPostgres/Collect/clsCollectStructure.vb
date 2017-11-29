'Public Class structCpuMem

'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_CPU_MAIN As Double
'    Private _C03_CPU_LOGICAL_ID As Double
'    Private _C04_CORE_CPU_RATE As Double
'    Private _C05_PGSQL_UTIL_RATE As Double
'    Private _C06_MEM_USED_RATE As Double
'    Private _C07_SWP_USED_RATE As Double
'    Private _C08_MEM_TOTAL_MB As Double
'    Private _C09_MEM_USED_MB As Double
'    Private _C10_MEM_FREE_MB As Double
'    Private _C11_SHM_MB As Double
'    Private _C12_MEM_BUFFERED_MB As Double
'    Private _C13_MEM_CACHED_MB As Double
'    Private _C14_SWP_TOTAL_MB As Double
'    Private _C15_SWP_USED_MB As Double
'    Private _C16_SWP_FREE_MB As Double

'    Public Sub New(ByVal DataRow As DataRow)

'        _C00_INSTANCE_ID = IIf(IsDBNull(DataRow.Item(0)), 0, DataRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(DataRow.Item(1)), DateTime.MinValue, DataRow.Item(1))
'        _C02_CPU_MAIN = Math.Round(IIf(IsDBNull(DataRow.Item(2)), 0.0, DataRow.Item(2)), 2)
'        _C03_CPU_LOGICAL_ID = IIf(IsDBNull(DataRow.Item(3)), 0, DataRow.Item(3))
'        _C04_CORE_CPU_RATE = Math.Round(IIf(IsDBNull(DataRow.Item(4)), 0, DataRow.Item(4)), 2)
'        _C05_PGSQL_UTIL_RATE = Math.Round(IIf(IsDBNull(DataRow.Item(5)), 0, DataRow.Item(5)), 2)
'        _C06_MEM_USED_RATE = Math.Round((IIf(IsDBNull(DataRow.Item(6)), 0, DataRow.Item(6))), 2)
'        _C07_SWP_USED_RATE = Math.Round(IIf(IsDBNull(DataRow.Item(7)), 0.0, DataRow.Item(7)), 2)
'        _C08_MEM_TOTAL_MB = Math.Round(IIf(IsDBNull(DataRow.Item(8)), 0, DataRow.Item(8)), 2)
'        _C09_MEM_USED_MB = Math.Round(IIf(IsDBNull(DataRow.Item(9)), 0, DataRow.Item(9)), 2)
'        _C10_MEM_FREE_MB = Math.Round(IIf(IsDBNull(DataRow.Item(10)), 0, DataRow.Item(10)), 2)
'        _C11_SHM_MB = Math.Round(IIf(IsDBNull(DataRow.Item(11)), 0, DataRow.Item(11)), 2)
'        _C12_MEM_BUFFERED_MB = Math.Round(IIf(IsDBNull(DataRow.Item(12)), 0, DataRow.Item(12)), 2)
'        _C13_MEM_CACHED_MB = Math.Round(IIf(IsDBNull(DataRow.Item(13)), 0, DataRow.Item(13)), 2)
'        _C14_SWP_TOTAL_MB = Math.Round(IIf(IsDBNull(DataRow.Item(14)), 0, DataRow.Item(14)), 2)
'        _C15_SWP_USED_MB = Math.Round(IIf(IsDBNull(DataRow.Item(15)), 0, DataRow.Item(15)), 2)
'        _C16_SWP_FREE_MB = Math.Round(IIf(IsDBNull(DataRow.Item(16)), 0, DataRow.Item(16)), 2)

'    End Sub

'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_CPU_MAIN As Double
'        Get
'            Return _C02_CPU_MAIN
'        End Get
'    End Property

'    ReadOnly Property C03_CPU_LOGICAL_ID As Integer
'        Get
'            Return _C03_CPU_LOGICAL_ID
'        End Get
'    End Property

'    ReadOnly Property C04_CORE_CPU_RATE As Double
'        Get
'            Return _C04_CORE_CPU_RATE
'        End Get
'    End Property

'    ReadOnly Property C05_PGSQL_UTIL_RATE As Double
'        Get
'            Return _C05_PGSQL_UTIL_RATE
'        End Get
'    End Property

'    ReadOnly Property C06_MEM_USED_RATE As Double
'        Get
'            Return _C06_MEM_USED_RATE
'        End Get
'    End Property

'    ReadOnly Property C07_SWP_USED_RATE As Double
'        Get
'            Return _C07_SWP_USED_RATE
'        End Get
'    End Property

'    ReadOnly Property C08_MEM_TOTAL_MB As Double
'        Get
'            Return _C08_MEM_TOTAL_MB
'        End Get
'    End Property

'    ReadOnly Property C09_MEM_USED_MB As Double
'        Get
'            Return _C09_MEM_USED_MB
'        End Get
'    End Property

'    ReadOnly Property C10_MEM_FREE_MB As Double
'        Get
'            Return _C10_MEM_FREE_MB
'        End Get
'    End Property

'    ReadOnly Property C11_SHM_MB As Double
'        Get
'            Return _C11_SHM_MB
'        End Get
'    End Property

'    ReadOnly Property C12_MEM_BUFFERED_MB As Double
'        Get
'            Return _C12_MEM_BUFFERED_MB
'        End Get
'    End Property

'    ReadOnly Property C13_MEM_CACHED_MB As Double
'        Get
'            Return _C13_MEM_CACHED_MB
'        End Get
'    End Property

'    ReadOnly Property C14_SWP_TOTAL_MB As Double
'        Get
'            Return _C14_SWP_TOTAL_MB
'        End Get
'    End Property

'    ReadOnly Property C15_SWP_USED_MB As Double
'        Get
'            Return _C15_SWP_USED_MB
'        End Get
'    End Property

'    ReadOnly Property C16_SWP_FREE_MB As Double
'        Get
'            Return _C16_SWP_FREE_MB
'        End Get
'    End Property

'    'Friend C00_INSTANCE_ID As Integer
'    'Friend C01_CPUMEM As Double
'    'Friend C02_CPU_LOGICAL_ID As Integer
'    'Friend C03_CORE_CPU_RATE As Double
'    'Friend C04_PGSQL_UTIL_RATE As Double
'    'Friend C05_SWP_USED_RATE As Double
'    'Friend C06_PGSQL_USAGE_KB As Double
'    'Friend C07_MEM_TOTAL_KB As Double
'    'Friend C08_MEM_USED_KB As Double
'    'Friend C09_MEM_FREE As Double
'    'Friend C10_SHM_KB As Double
'    'Friend C11_MEM_BUFFERED_KB As Double
'    'Friend C12_MEM_CACHED_KB As Double
'    'Friend C13_SWP_USED_KB As Double
'    'Friend C14_SWP_FREE_KB As Double
'End Class


'Public Class structLock
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_DB_NAME As String
'    Private _C03_QUERY As String
'    Private _C04_BLOCKING_PID As String
'    Private _C05_BLOCKING_USER As String
'    Private _C06_BLOCKING_XACT_START As String
'    Private _C07_BLOCKING_ELAPSED_TIME As String


'    Public Sub New(ByVal DataRow As DataRow)

'        _C00_INSTANCE_ID = IIf(IsDBNull(DataRow.Item(0)), 0, DataRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(DataRow.Item(1)), DateTime.MinValue, DataRow.Item(1))
'        _C02_DB_NAME = IIf(IsDBNull(DataRow.Item(2)), "", DataRow.Item(2))
'        _C03_QUERY = IIf(IsDBNull(DataRow.Item(3)), "", DataRow.Item(3))
'        _C04_BLOCKING_PID = IIf(IsDBNull(DataRow.Item(4)), "", DataRow.Item(4))
'        _C05_BLOCKING_USER = IIf(IsDBNull(DataRow.Item(5)), "", DataRow.Item(5))
'        _C06_BLOCKING_XACT_START = IIf(IsDBNull(DataRow.Item(6)), "", DataRow.Item(6).ToString)
'        _C07_BLOCKING_ELAPSED_TIME = IIf(IsDBNull(DataRow.Item(7)), "", DataRow.Item(7).ToString)


'    End Sub

'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property
'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property
'    ReadOnly Property C02_DB_NAME As String
'        Get
'            Return _C02_DB_NAME
'        End Get
'    End Property
'    ReadOnly Property C03_QUERY As String
'        Get
'            Return _C03_QUERY
'        End Get
'    End Property
'    ReadOnly Property C04_BLOCKING_PID As String
'        Get
'            Return _C04_BLOCKING_PID
'        End Get
'    End Property
'    ReadOnly Property C05_BLOCKING_USER As String
'        Get
'            Return _C05_BLOCKING_USER
'        End Get
'    End Property
'    ReadOnly Property C06_BLOCKING_XACT_START As String
'        Get
'            Return _C06_BLOCKING_XACT_START
'        End Get
'    End Property
'    ReadOnly Property C07_BLOCKING_ELAPSED_TIME As String
'        Get
'            Return _C07_BLOCKING_ELAPSED_TIME
'        End Get
'    End Property

'End Class


'Public Class structDisk
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_IO_DISK_Name As String
'    Private _C03_IO_Busy_Rate As Double
'    Private _C04_IO_Read_KB As Double
'    Private _C05_IO_Write_KB As Double
'    Private _C06_USAGE_Device_Name As String
'    Private _C07_USAGE_Total_KB As Double
'    Private _C08_USAGE_Usage_Rate As Double
'    Private _C09_INSTANCE_NAME As String


'    Public Sub New(ByVal DataRow As DataRow)

'        _C00_INSTANCE_ID = IIf(IsDBNull(DataRow.Item(0)), 0, DataRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(DataRow.Item(1)), DateTime.MinValue, DataRow.Item(1))
'        _C02_IO_DISK_Name = IIf(IsDBNull(DataRow.Item(2)), "", DataRow.Item(2))
'        _C03_IO_Busy_Rate = Math.Round(IIf(IsDBNull(DataRow.Item(3)), 0.0, DataRow.Item(3)), 2)
'        _C04_IO_Read_KB = Math.Round(IIf(IsDBNull(DataRow.Item(4)), 0.0, DataRow.Item(4)), 2)
'        _C05_IO_Write_KB = Math.Round(IIf(IsDBNull(DataRow.Item(5)), 0.0, DataRow.Item(5)), 2)
'        _C06_USAGE_Device_Name = IIf(IsDBNull(DataRow.Item(6)), "", DataRow.Item(6))
'        _C07_USAGE_Total_KB = Math.Round(IIf(IsDBNull(DataRow.Item(7)), 0.0, DataRow.Item(7)), 2)
'        _C08_USAGE_Usage_Rate = Math.Round(IIf(IsDBNull(DataRow.Item(8)), 0.0, DataRow.Item(8)), 2)
'        _C09_INSTANCE_NAME = IIf(IsDBNull(DataRow.Item(9)), "", DataRow.Item(9))

'    End Sub

'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property
'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property
'    ReadOnly Property C02_IO_DISK_Name As String
'        Get
'            Return _C02_IO_DISK_Name
'        End Get
'    End Property
'    ReadOnly Property C03_IO_Busy_Rate As Double
'        Get
'            Return _C03_IO_Busy_Rate
'        End Get
'    End Property
'    ReadOnly Property C04_IO_Read_KB As Double
'        Get
'            Return _C04_IO_Read_KB
'        End Get
'    End Property
'    ReadOnly Property C04_IO_Read_MB As Double
'        Get
'            Return Math.Round(_C04_IO_Read_KB / 1024, 2)
'        End Get
'    End Property
'    ReadOnly Property C05_IO_Write_KB As Double
'        Get
'            Return _C05_IO_Write_KB
'        End Get
'    End Property
'    ReadOnly Property C05_IO_Write_MB As Double
'        Get
'            Return Math.Round(_C05_IO_Write_KB / 1024, 2)
'        End Get
'    End Property
'    ReadOnly Property C06_USAGE_Device_Name As String
'        Get
'            Return _C06_USAGE_Device_Name
'        End Get
'    End Property
'    ReadOnly Property C07_USAGE_Total_KB As Double
'        Get
'            Return _C07_USAGE_Total_KB
'        End Get
'    End Property
'    ReadOnly Property C07_USAGE_Total_MB As Double
'        Get
'            Return Math.Round(_C07_USAGE_Total_KB / 1024, 2)
'        End Get
'    End Property
'    ReadOnly Property C07_USAGE_Total_GB As Double
'        Get
'            Return Math.Round(_C07_USAGE_Total_KB / 1024 / 1024, 2)
'        End Get
'    End Property
'    ReadOnly Property C08_USAGE_Usage_Rate As Double
'        Get
'            Return _C08_USAGE_Usage_Rate
'        End Get
'    End Property


'    ReadOnly Property C09_INSTANCE_NAME As String
'        Get
'            Return _C09_INSTANCE_NAME
'        End Get
'    End Property



'End Class


'Public Class structRequest
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_INSTANCE_NAME As String
'    Private _C03_AGG_READ_TUPLES As ULong
'    Private _C04_AGG_INSERT_TUPLES As ULong
'    Private _C05_AGG_UPDATE_TUPLES As ULong
'    Private _C06_AGG_DELETE_TUPLES As ULong
'    Private _C07_AGG_RETURN_TUPLES As ULong
'    Private _C08_AGG_COMMIT_TUPLES As ULong
'    Private _C09_AGG_ROLLBACK_TUPLES As ULong
'    Private _C10_CUR_BACKEND As ULong
'    Private _C11_ACT_BACKEND As ULong
'    Private _C12_CUR_READ_TUPLES As ULong
'    Private _C13_CUR_INSERT_TUPLES As ULong
'    Private _C14_CUR_UPDATE_TUPLES As ULong
'    Private _C15_CUR_DELETE_TUPLES As ULong
'    Private _C16_CUR_RETURN_TUPLES As ULong
'    Private _C17_CUR_COMMIT_TUPLES As ULong
'    Private _C18_CUR_ROLLBACK_TYPLES As ULong



'    Public Sub New(ByVal DataRow As DataRow)



'        _C00_INSTANCE_ID = IIf(IsDBNull(DataRow.Item(0)), 0, DataRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(DataRow.Item(1)), DateTime.MinValue, DataRow.Item(1))
'        _C02_INSTANCE_NAME = IIf(IsDBNull(DataRow.Item(2)), "", DataRow.Item(2))
'        _C03_AGG_READ_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(3)), 0.0, DataRow.Item(3)), 2))
'        _C04_AGG_INSERT_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(4)), 0.0, DataRow.Item(4)), 2))
'        _C05_AGG_UPDATE_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(5)), 0.0, DataRow.Item(5)), 2))
'        _C06_AGG_DELETE_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(6)), 0.0, DataRow.Item(6)), 2))
'        _C07_AGG_RETURN_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(7)), 0.0, DataRow.Item(7)), 2))
'        _C08_AGG_COMMIT_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(8)), 0.0, DataRow.Item(8)), 2))
'        _C09_AGG_ROLLBACK_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(9)), 0.0, DataRow.Item(9)), 2))
'        _C10_CUR_BACKEND = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(10)), 0.0, DataRow.Item(10)), 2))
'        _C11_ACT_BACKEND = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(11)), 0.0, DataRow.Item(11)), 2))
'        _C12_CUR_READ_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(12)), 0.0, DataRow.Item(12)), 2))
'        _C13_CUR_INSERT_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(13)), 0.0, DataRow.Item(13)), 2))
'        _C14_CUR_UPDATE_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(14)), 0.0, DataRow.Item(14)), 2))
'        _C15_CUR_DELETE_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(15)), 0.0, DataRow.Item(15)), 2))
'        _C16_CUR_RETURN_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(16)), 0.0, DataRow.Item(16)), 2))
'        _C17_CUR_COMMIT_TUPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(17)), 0.0, DataRow.Item(17)), 2))
'        _C18_CUR_ROLLBACK_TYPLES = CULng(Math.Round(IIf(IsDBNull(DataRow.Item(18)), 0.0, DataRow.Item(18)), 2))
'    End Sub

'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_INSTANCE_NAME As String
'        Get
'            Return _C02_INSTANCE_NAME
'        End Get
'    End Property

'    ReadOnly Property C03_AGG_READ_TUPLES As ULong
'        Get
'            Return _C03_AGG_READ_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C04_AGG_INSERT_TUPLES As ULong
'        Get
'            Return _C04_AGG_INSERT_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C05_AGG_UPDATE_TUPLES As ULong
'        Get
'            Return _C05_AGG_UPDATE_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C06_AGG_DELETE_TUPLES As ULong
'        Get
'            Return _C06_AGG_DELETE_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C07_AGG_RETURN_TUPLES As ULong
'        Get
'            Return _C07_AGG_RETURN_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C08_AGG_COMMIT_TUPLES As ULong
'        Get
'            Return _C08_AGG_COMMIT_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C09_AGG_ROLLBACK_TUPLES As ULong
'        Get
'            Return _C09_AGG_ROLLBACK_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C10_CUR_BACKEND As Double
'        Get
'            Return _C10_CUR_BACKEND
'        End Get
'    End Property

'    ReadOnly Property C11_ACT_BACKEND As Double
'        Get
'            Return _C11_ACT_BACKEND
'        End Get
'    End Property

'    ReadOnly Property C12_CUR_READ_TUPLES As ULong
'        Get
'            Return _C12_CUR_READ_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C13_CUR_INSERT_TUPLES As ULong
'        Get
'            Return _C13_CUR_INSERT_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C14_CUR_UPDATE_TUPLES As ULong
'        Get
'            Return _C14_CUR_UPDATE_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C15_CUR_DELETE_TUPLES As ULong
'        Get
'            Return _C15_CUR_DELETE_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C16_CUR_RETURN_TUPLES As ULong
'        Get
'            Return _C16_CUR_RETURN_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C17_CUR_COMMIT_TUPLES As ULong
'        Get
'            Return _C17_CUR_COMMIT_TUPLES
'        End Get
'    End Property

'    ReadOnly Property C18_CUR_ROLLBACK_TYPLES As Double
'        Get
'            Return _C18_CUR_ROLLBACK_TYPLES
'        End Get
'    End Property

'End Class


'Public Class structSQLRespTm
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_MAX_ELAPSED_TIME As Double
'    Private _C03_AVG_ELAPSED_TIME As Double

'    Public Sub New(ByVal dtRow As DataRow)
'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(dtRow.Item(1)), DateTime.MinValue, dtRow.Item(1))
'        _C02_MAX_ELAPSED_TIME = IIf(IsDBNull(dtRow.Item(2)), "", dtRow.Item(2))
'        _C03_AVG_ELAPSED_TIME = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(3)), 0.0, dtRow.Item(3)), 2))
'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_MAX_ELAPSED_TIME As Double
'        Get
'            Return _C02_MAX_ELAPSED_TIME
'        End Get
'    End Property


'    ReadOnly Property C03_AVG_ELAPSED_TIME As Double
'        Get
'            Return _C03_AVG_ELAPSED_TIME
'        End Get
'    End Property



'End Class


'Public Class structCurrentAct
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_DB_NAME As String
'    Private _C03_BACKEND_PID As Integer
'    Private _C04_CONN_USER As String
'    Private _C05_XACT_START As DateTime
'    Private _C06_ELAPSED_TIME As String
'    Private _C07_QUERY As String
'    Public Sub New(ByVal dtRow As DataRow)
'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(dtRow.Item(1)), DateTime.MinValue, dtRow.Item(1))
'        _C02_DB_NAME = IIf(IsDBNull(dtRow.Item(2)), "", dtRow.Item(2))
'        _C03_BACKEND_PID = IIf(IsDBNull(dtRow.Item(3)), 0, dtRow.Item(3))
'        _C04_CONN_USER = IIf(IsDBNull(dtRow.Item(4)), "", dtRow.Item(4))
'        _C05_XACT_START = IIf(IsDBNull(dtRow.Item(5)), DateTime.MinValue, dtRow.Item(5))
'        _C06_ELAPSED_TIME = IIf(IsDBNull(dtRow.Item(6)), "0", dtRow.Item(6))
'        _C07_QUERY = IIf(IsDBNull(dtRow.Item(7)), "", dtRow.Item(7))
'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_DB_NAME As String
'        Get
'            Return _C02_DB_NAME
'        End Get
'    End Property
'    ReadOnly Property C03_BACKEND_PID As Integer
'        Get
'            Return _C03_BACKEND_PID
'        End Get
'    End Property
'    ReadOnly Property C04_CONN_USER As String
'        Get
'            Return _C04_CONN_USER
'        End Get
'    End Property
'    ReadOnly Property C05_XACT_START As DateTime
'        Get
'            Return _C05_XACT_START
'        End Get
'    End Property
'    ReadOnly Property C06_ELAPSED_TIME As String
'        Get
'            Return _C06_ELAPSED_TIME
'        End Get
'    End Property
'    ReadOnly Property C07_QUERY As String
'        Get
'            Return _C07_QUERY
'        End Get
'    End Property




'End Class


' ''' <summary>
' ''' Database information  struct
' ''' </summary>
' ''' <remarks></remarks>
'Public Class structDBinfo
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_DB_NAME As String
'    Private _C02_DB_SIZE_KB As Double
'    Private _C03_TABLE_CNT As Double
'    Private _C04_INDEX_CNT As Double
'    Private _C05_DISK_READ As Double
'    Private _C06_BUFFER_READ As Double
'    Private _C07_HIT_RATIO As Double


'    Public Sub New(ByVal dtRow As DataRow)
'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_DB_NAME = IIf(IsDBNull(dtRow.Item(1)), "", dtRow.Item(1))
'        _C02_DB_SIZE_KB = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(2)), 0.0, dtRow.Item(2)), 2))
'        _C03_TABLE_CNT = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(3)), 0.0, dtRow.Item(3)), 2))
'        _C04_INDEX_CNT = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(4)), 0.0, dtRow.Item(4)), 2))
'        _C05_DISK_READ = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(5)), 0.0, dtRow.Item(5)), 2))
'        _C06_BUFFER_READ = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(6)), 0.0, dtRow.Item(6)), 2))
'        _C07_HIT_RATIO = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(7)), 0.0, dtRow.Item(7)), 2))
'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_DB_NAME As String
'        Get
'            Return _C01_DB_NAME
'        End Get
'    End Property

'    ReadOnly Property C02_DB_SIZE_KB As Double
'        Get
'            Return _C02_DB_SIZE_KB
'        End Get
'    End Property
'    ReadOnly Property C03_TABLE_CNT As Double
'        Get
'            Return _C03_TABLE_CNT
'        End Get
'    End Property
'    ReadOnly Property C04_INDEX_CNT As Double
'        Get
'            Return _C04_INDEX_CNT
'        End Get
'    End Property
'    ReadOnly Property C05_DISK_READ As Double
'        Get
'            Return _C05_DISK_READ
'        End Get
'    End Property
'    ReadOnly Property C06_BUFFER_READ As Double
'        Get
'            Return _C06_BUFFER_READ
'        End Get
'    End Property
'    ReadOnly Property C07_HIT_RATIO As Double
'        Get
'            Return _C07_HIT_RATIO
'        End Get
'    End Property




'End Class


'' ''' <summary>
'' ''' table Information  struct
'' ''' </summary>
'' ''' <remarks></remarks>
''Public Class structTBinfo
''    Private _C00_INSTANCE_ID As Integer
''    Private _C01_DB_NAME As String
''    Private _C02_TABLE_NAME As String
''    Private _C03_TABLE_SIZE As Double
''    Private _C04_INDEX_SIZE As Double
''    Private _C05_INDEX_CNT As Double
''    Private _C06_IS_TOAST As String
''    Private _C07_SEQ_SCAN As Double
''    Private _C08_INDEX_SCAN As Double
''    Private _C09_LIVE_TUPLE_CNT As Double
''    Private _C10_LAST_VACUUM As DateTime


''    Public Sub New(ByVal dtRow As DataRow)
''        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
''        _C01_DB_NAME = IIf(IsDBNull(dtRow.Item(1)), "", dtRow.Item(1))
''        _C02_TABLE_NAME = IIf(IsDBNull(dtRow.Item(2)), "", dtRow.Item(2))
''        _C03_TABLE_SIZE = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(3)), 0.0, dtRow.Item(3)), 2))
''        _C04_INDEX_SIZE = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(4)), 0.0, dtRow.Item(4)), 2))
''        _C05_INDEX_CNT = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(5)), 0.0, dtRow.Item(5)), 2))
''        _C06_IS_TOAST = IIf(IsDBNull(dtRow.Item(6)), "", dtRow.Item(6))
''        _C07_SEQ_SCAN = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(7)), 0.0, dtRow.Item(7)), 2))
''        _C08_INDEX_SCAN = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(8)), 0.0, dtRow.Item(8)), 2))
''        _C09_LIVE_TUPLE_CNT = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(9)), 0.0, dtRow.Item(9)), 2))
''        _C10_LAST_VACUUM = CDate(IIf(IsDBNull(dtRow.Item(10)), DateTime.MinValue, dtRow.Item(10)))
''    End Sub



''    ReadOnly Property C00_INSTANCE_ID As Integer
''        Get
''            Return _C00_INSTANCE_ID
''        End Get
''    End Property

''    ReadOnly Property C01_DB_NAME As String
''        Get
''            Return _C01_DB_NAME
''        End Get
''    End Property

''    ReadOnly Property C02_TABLE_NAME As String
''        Get
''            Return _C02_TABLE_NAME
''        End Get
''    End Property

''    ReadOnly Property C03_TABLE_SIZE As Double
''        Get
''            Return _C03_TABLE_SIZE
''        End Get
''    End Property

''    ReadOnly Property C04_INDEX_SIZE As Double
''        Get
''            Return _C04_INDEX_SIZE
''        End Get
''    End Property

''    ReadOnly Property C05_INDEX_CNT As Double
''        Get
''            Return _C05_INDEX_CNT
''        End Get
''    End Property
''    ReadOnly Property C06_IS_TOAST As String
''        Get
''            Return _C06_IS_TOAST
''        End Get
''    End Property


''    ReadOnly Property C07_SEQ_SCAN As Double
''        Get
''            Return _C07_SEQ_SCAN
''        End Get
''    End Property

''    ReadOnly Property C08_INDEX_SCAN As Double
''        Get
''            Return _C08_INDEX_SCAN
''        End Get
''    End Property

''    ReadOnly Property C09_LIVE_TUPLE_CNT As Double
''        Get
''            Return _C09_LIVE_TUPLE_CNT
''        End Get
''    End Property

''    ReadOnly Property C10_LAST_VACUUM As DateTime
''        Get
''            Return _C10_LAST_VACUUM
''        End Get
''    End Property

''End Class


'' ''' <summary>
'' ''' index Information  struct
'' ''' </summary>
'' ''' <remarks></remarks>
''Public Class structIndexinfo
''    Private _C00_INSTANCE_ID As Integer
''    Private _C01_DB_NAME As String
''    Private _C02_INDEX_NAME As String
''    Private _C03_TABLE_NAME As String
''    Private _C04_INDEX_SIZE_KB As Double
''    Private _C05_INDEX_SCAN_COUNT As Double
''    Private _C06_INDEX_FETCHED_TUPLES As Double
''    Private _C07_SEQ_SCAN_CNT As Double
''    Private _C08_SEQ_TUPLES As Double
''    Private _C09_LIVE_TUPLE_CNT As Double


''    Public Sub New(ByVal dtRow As DataRow)
''        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
''        _C01_DB_NAME = IIf(IsDBNull(dtRow.Item(1)), 0, dtRow.Item(1))
''        _C02_INDEX_NAME = IIf(IsDBNull(dtRow.Item(2)), "", dtRow.Item(2))
''        _C03_TABLE_NAME = IIf(IsDBNull(dtRow.Item(3)), "", dtRow.Item(3))
''        _C04_INDEX_SIZE_KB = CDbl(IIf(IsDBNull(dtRow.Item(4)), 0.0, dtRow.Item(4)))
''        _C05_INDEX_SCAN_COUNT = CDbl(IIf(IsDBNull(dtRow.Item(5)), 0.0, dtRow.Item(5)))
''        _C06_INDEX_FETCHED_TUPLES = CDbl(IIf(IsDBNull(dtRow.Item(6)), 0.0, dtRow.Item(6)))
''        _C07_SEQ_SCAN_CNT = CDbl(IIf(IsDBNull(dtRow.Item(7)), 0.0, dtRow.Item(7)))
''        _C08_SEQ_TUPLES = CDbl(IIf(IsDBNull(dtRow.Item(8)), 0.0, dtRow.Item(8)))
''        _C09_LIVE_TUPLE_CNT = CDbl(IIf(IsDBNull(dtRow.Item(9)), 0.0, dtRow.Item(9)))




''    End Sub



''    ReadOnly Property C00_INSTANCE_ID As Integer
''        Get
''            Return _C00_INSTANCE_ID
''        End Get
''    End Property

''    ReadOnly Property C01_DB_NAME As String
''        Get
''            Return _C01_DB_NAME
''        End Get
''    End Property

''    ReadOnly Property C02_INDEX_NAME As String
''        Get
''            Return _C02_INDEX_NAME
''        End Get
''    End Property



''    ReadOnly Property C03_TABLE_NAME As String
''        Get
''            Return _C03_TABLE_NAME
''        End Get
''    End Property
''    ReadOnly Property C04_INDEX_SIZE_KB As Double
''        Get
''            Return _C04_INDEX_SIZE_KB
''        End Get
''    End Property
''    ReadOnly Property C05_INDEX_SCAN_COUNT As Double
''        Get
''            Return _C05_INDEX_SCAN_COUNT
''        End Get
''    End Property

''    ReadOnly Property C06_INDEX_FETCHED_TUPLES As Double
''        Get
''            Return _C06_INDEX_FETCHED_TUPLES
''        End Get
''    End Property
''    ReadOnly Property C07_SEQ_SCAN_CNT As Double
''        Get
''            Return _C07_SEQ_SCAN_CNT
''        End Get
''    End Property
''    ReadOnly Property C08_SEQ_TUPLES As Double
''        Get
''            Return _C08_SEQ_TUPLES
''        End Get
''    End Property

''    ReadOnly Property C09_LIVE_TUPLE_CNT As Double
''        Get
''            Return -_C09_LIVE_TUPLE_CNT
''        End Get
''    End Property



''End Class


' ''' <summary>
' ''' tablespace Information  struct
' ''' </summary>
' ''' <remarks></remarks>
'Public Class structTBspaceinfo
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_TABLESPACE_NAME As String
'    Private _C02_SIZE As Double
'    Private _C03_LOCATION As String
'    Private _C04_DISK_SIZE As Double
'    Private _C05_DISK_USED As Double

'    Public Sub New(ByVal dtRow As DataRow)
'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_TABLESPACE_NAME = IIf(IsDBNull(dtRow.Item(1)), "", dtRow.Item(1))
'        _C02_SIZE = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(2)), 0.0, dtRow.Item(2)), 2))
'        _C03_LOCATION = IIf(IsDBNull(dtRow.Item(3)), "", dtRow.Item(3))
'        _C04_DISK_SIZE = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(4)), 0.0, dtRow.Item(4)), 2))
'        _C05_DISK_USED = CDbl(Math.Round(IIf(IsDBNull(dtRow.Item(5)), 0.0, dtRow.Item(5)), 2))
'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_TABLESPACE_NAME As String
'        Get
'            Return _C01_TABLESPACE_NAME
'        End Get
'    End Property

'    ReadOnly Property C02_SIZE As Double
'        Get
'            Return _C02_SIZE
'        End Get
'    End Property

'    ReadOnly Property C03_LOCATION As String
'        Get
'            Return _C03_LOCATION
'        End Get
'    End Property
'    ReadOnly Property C04_DISK_SIZE As Double
'        Get
'            Return _C04_DISK_SIZE
'        End Get
'    End Property
'    ReadOnly Property C05_DISK_USED As Double
'        Get
'            Return _C05_DISK_USED
'        End Get
'    End Property


'End Class


'Public Class structObject
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_INDEX_SCAN_CNT As Double
'    Private _C03_SQL_SCAN_CNT As Double

'    Public Sub New(ByVal dtRow As DataRow)
'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(dtRow.Item(1)), DateTime.MinValue, dtRow.Item(1))
'        _C02_INDEX_SCAN_CNT = IIf(IsDBNull(dtRow.Item(2)), 0.0, dtRow.Item(2))
'        _C03_SQL_SCAN_CNT = IIf(IsDBNull(dtRow.Item(3)), 0.0, dtRow.Item(3))
'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_INDEX_SCAN_CNT As String
'        Get
'            Return _C02_INDEX_SCAN_CNT
'        End Get
'    End Property
'    ReadOnly Property C03_SQL_SCAN_CNT As Integer
'        Get
'            Return _C03_SQL_SCAN_CNT
'        End Get
'    End Property



'End Class



'Public Class structBackEnd
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_RNUM As Integer
'    Private _C03_DB_NAME As String
'    Private _C04_PID As Integer
'    Private _C05_CUR_PROC_READ_KB As Double
'    Private _C05_CUR_PROC_WRITE_KB As Double
'    ' _C05_CUR_PROC_READ_KB + _C05_CUR_PROC_WRITE_KB
'    Private _C05_MEM_USAGE_KB As Double
'    Private _C06_CPU_USAGE As Double
'    Private _C07_START_TIME As DateTime
'    Private _C08_ELAPSED_TIME As String
'    Private _C09_SQL As String
'    Private _C10_CONN_NAME As String



'    Public Sub New(ByVal dtRow As DataRow)





'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(dtRow.Item(1)), DateTime.MinValue, dtRow.Item(1))
'        _C02_RNUM = IIf(IsDBNull(dtRow.Item(2)), 0, dtRow.Item(2))
'        _C03_DB_NAME = IIf(IsDBNull(dtRow.Item(3)), "", dtRow.Item(3))
'        _C04_PID = IIf(IsDBNull(dtRow.Item(4)), 0, dtRow.Item(4))
'        _C05_CUR_PROC_READ_KB = IIf(IsDBNull(dtRow.Item(5)), 0.0, dtRow.Item(5))
'        _C05_CUR_PROC_WRITE_KB = IIf(IsDBNull(dtRow.Item(6)), 0.0, dtRow.Item(6))

'        _C06_CPU_USAGE = IIf(IsDBNull(dtRow.Item(7)), 0.0, dtRow.Item(7))
'        _C07_START_TIME = IIf(IsDBNull(dtRow.Item(8)), DateTime.MinValue, dtRow.Item(8))
'        _C08_ELAPSED_TIME = IIf(IsDBNull(dtRow.Item(9)), 0, dtRow.Item(9))
'        _C09_SQL = IIf(IsDBNull(dtRow.Item(10)), "", dtRow.Item(10))
'        _C10_CONN_NAME = IIf(IsDBNull(dtRow.Item(11)), "", dtRow.Item(11))


'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_RNUM As Integer
'        Get
'            Return _C02_RNUM
'        End Get
'    End Property

'    ReadOnly Property C03_DB_NAME As String
'        Get
'            Return _C03_DB_NAME
'        End Get
'    End Property

'    ReadOnly Property C04_PID As Integer
'        Get
'            Return _C04_PID
'        End Get
'    End Property

'    ReadOnly Property C05_CUR_PROC_READ_KB As Double
'        Get
'            Return _C05_CUR_PROC_READ_KB
'        End Get
'    End Property

'    ReadOnly Property C05_CUR_PROC_WRITE_KB As Double
'        Get
'            Return _C05_CUR_PROC_WRITE_KB
'        End Get
'    End Property

'    ReadOnly Property C05_MEM_USAGE_KB As Double
'        Get
'            Return _C05_CUR_PROC_READ_KB + _C05_CUR_PROC_WRITE_KB
'        End Get
'    End Property

'    ReadOnly Property C06_CPU_USAGE As Double
'        Get
'            Return _C06_CPU_USAGE
'        End Get
'    End Property

'    ReadOnly Property C07_START_TIME As DateTime
'        Get
'            Return _C07_START_TIME
'        End Get
'    End Property

'    ReadOnly Property C08_ELAPSED_TIME As String
'        Get
'            Return _C08_ELAPSED_TIME
'        End Get
'    End Property

'    ReadOnly Property C09_SQL As String
'        Get
'            Return _C09_SQL
'        End Get
'    End Property

'    ReadOnly Property C10_CONN_NAME As String
'        Get
'            Return _C10_CONN_NAME
'        End Get
'    End Property
'End Class



'Public Class structPhysicaliO
'    Private _C00_INSTANCE_ID As Integer
'    Private _C01_REG_DATE As DateTime
'    Private _C02_PHY_READ As Double
'    Private _C03_PHY_WRITE As Double



'    Public Sub New(ByVal dtRow As DataRow)
'        _C00_INSTANCE_ID = IIf(IsDBNull(dtRow.Item(0)), 0, dtRow.Item(0))
'        _C01_REG_DATE = IIf(IsDBNull(dtRow.Item(1)), DateTime.MinValue, dtRow.Item(1))
'        _C02_PHY_READ = IIf(IsDBNull(dtRow.Item(2)), 0.0, dtRow.Item(2))
'        _C03_PHY_WRITE = IIf(IsDBNull(dtRow.Item(3)), 0.0, dtRow.Item(3))

'    End Sub



'    ReadOnly Property C00_INSTANCE_ID As Integer
'        Get
'            Return _C00_INSTANCE_ID
'        End Get
'    End Property

'    ReadOnly Property C01_REG_DATE As DateTime
'        Get
'            Return _C01_REG_DATE
'        End Get
'    End Property

'    ReadOnly Property C02_PHY_READ As Double
'        Get
'            Return _C02_PHY_READ
'        End Get
'    End Property

'    ReadOnly Property C03_PHY_WRITE As Double
'        Get
'            Return _C03_PHY_WRITE
'        End Get
'    End Property

'End Class
