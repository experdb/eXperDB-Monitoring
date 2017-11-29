'Public Class iDastList
'    Private _DataSize As Integer = 1024
'    Public Sub New(ByVal DataSize As Integer)
'        _DataSize = DataSize
'    End Sub
'    Dim _Datas As KeyValue()
'    Property Datas As KeyValue()
'        Get
'            Return _Datas
'        End Get
'        Set(value As KeyValue())
'            _Datas = value
'        End Set
'    End Property

'    Public Sub Add(ByVal Key As Double, ByVal Value As Object)

'        Dim A As New KeyValue(Key, Value)

'        If _Datas Is Nothing Then
'            ReDim _Datas(0)
'            _Datas(0) = A
'        Else

'            Dim cDatas As KeyValue() = _Datas.Clone

'            If cDatas.Length >= _DataSize Then
'                Dim tmpData(_DataSize - 1) As KeyValue
'                Array.Copy(cDatas, 1, tmpData, 0, _DataSize - 1)
'                cDatas = tmpData
'            Else
'                ReDim Preserve cDatas(cDatas.Length)
'            End If


'            cDatas(cDatas.Length - 1) = A
'            _Datas = cDatas


'        End If
'    End Sub

'    Public Function GetKey(ByVal Index As Integer) As Double
'        If _Datas IsNot Nothing AndAlso Index > -1 Then
'            Return _Datas(Index).Key
'        Else
'            Return 0
'        End If


'    End Function
'    Public Function Item(ByVal Key As Double) As Object
'        If _Datas Is Nothing Then Return Nothing
'        Dim idx As Integer = IndexofKey(Key)
'        If idx < 0 Then
'            Return Nothing
'        Else
'            Return _Datas(idx).Value
'        End If

'    End Function
'    Private _tmpKey As Double
'    Public Function IndexofKey(ByVal Key As Double) As Integer
'        If _Datas Is Nothing Then Return -1
'        _tmpKey = Key
'        Dim rtnIdx As Integer = -1
'        rtnIdx = Array.FindIndex(Of KeyValue)(_Datas, AddressOf FndIdx)
'        _tmpKey = 0.0

'        Return rtnIdx

'    End Function
'    Private Function FndIdx(ByVal s As KeyValue) As Boolean
'        If s.Key = _tmpKey Then
'            Return True
'        Else
'            Return False
'        End If
'    End Function


'    ReadOnly Property Count As Integer
'        Get
'            If _Datas Is Nothing Then
'                Return 0
'            Else
'                Return _Datas.Count
'            End If
'        End Get
'    End Property

'    Public Class KeyValue
'        Public ReadOnly Key As Double
'        Public ReadOnly Value As Object
'        Public Sub New(ByVal dblKey As Double, ByVal objValue As Object)
'            Key = dblKey
'            Value = objValue
'        End Sub
'    End Class

'    Private Sub New(ByVal DataSize As Integer, ByVal Datas As KeyValue())
'        _DataSize = DataSize
'        _Datas = Datas
'    End Sub

'    Public Function Clone() As iDastList


'        Dim A As New iDastList(_DataSize, _Datas.Clone)

'        Return A

'    End Function




''End Class
