Public Class ValueDescription
    Implements IList(Of ValueDesc)


    Private _List As List(Of ValueDesc)

    Public Sub New()
        _List = New List(Of ValueDesc)

    End Sub

    Public Sub New(ByVal enumType As Type)
        _List = New List(Of ValueDesc)
        Dim Arr As Array = System.Enum.GetValues(enumType)
       
        For Each tmpValue As Integer In Arr
            _List.Add(New ValueDesc(tmpValue, System.Enum.GetName(enumType, tmpValue)))
        Next
    End Sub


    Public Sub New(ByVal dtTable As DataTable, ByVal ValueMember As String, ByVal DescMember As String)
        _List = New List(Of ValueDesc)

        For Each dtRow As DataRow In dtTable.Rows
            _List.Add(New ValueDesc(dtRow.Item(ValueMember), dtRow.Item(DescMember)))
        Next
      
    End Sub


    Public Class ValueDesc
        Private _Value As String
        Private _Description As String
        Public Sub New(ByVal strValue As String, ByVal strDescription As String)
            _Value = strValue
            _Description = strDescription

        End Sub

        ReadOnly Property Value As String
            Get
                Return _Value
            End Get
        End Property
        ReadOnly Property Description As String
            Get
                Return _Description
            End Get
        End Property
    End Class



    Public Sub Add(item As ValueDesc) Implements ICollection(Of ValueDesc).Add
        Me._List.Add(item)
    End Sub

    Public Sub Add(ByVal Value As String, ByVal Description As String)
        Me._List.Add(New ValueDesc(Value, Description))
    End Sub

    Public Sub Clear() Implements ICollection(Of ValueDesc).Clear
        Me._List.Clear()
    End Sub

    Public Function Contains(item As ValueDesc) As Boolean Implements ICollection(Of ValueDesc).Contains
        Return Me._List.Contains(item)
    End Function


    Public Sub CopyTo(array() As ValueDesc, arrayIndex As Integer) Implements ICollection(Of ValueDesc).CopyTo
        Me._List.CopyTo(array, arrayIndex)
    End Sub

    Public ReadOnly Property Count As Integer Implements ICollection(Of ValueDesc).Count
        Get
            Return Me._List.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of ValueDesc).IsReadOnly
        Get
            Return True
        End Get
    End Property

    Public Function Remove(item As ValueDesc) As Boolean Implements ICollection(Of ValueDesc).Remove
        Return Me._List.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of ValueDesc) Implements IEnumerable(Of ValueDesc).GetEnumerator
        Return Me._List.GetEnumerator
    End Function

    Public Function IndexOf(item As ValueDesc) As Integer Implements IList(Of ValueDesc).IndexOf
        Return Me._List.IndexOf(item)
    End Function

    Public Sub Insert(index As Integer, ByVal Value As String, ByVal Description As String)
        Me._List.Insert(index, New ValueDesc(Value, Description))
    End Sub

    Public Sub Insert(index As Integer, item As ValueDesc) Implements IList(Of ValueDesc).Insert
        Me._List.Insert(index, item)
    End Sub
    Default Public Property Item(index As Integer) As ValueDesc Implements IList(Of ValueDesc).Item
        Get
            Return Me._List.Item(index)
        End Get
        Set(value As ValueDesc)
            Me._List.Item(index) = value
        End Set
    End Property

    Public Sub RemoveAt(index As Integer) Implements IList(Of ValueDesc).RemoveAt
        Me._List.RemoveAt(index)
    End Sub


    Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return Me._List.GetEnumerator()

    End Function

    Public Function GetDataTable() As DataTable
        Dim tmpTable As New DataTable
        tmpTable.Columns.Add("VALUE")
        tmpTable.Columns.Add("DESC")
        For Each tmpitm As ValueDesc In Me._List
            tmpTable.Rows.Add(tmpitm.Value, tmpitm.Description)
        Next
        Return tmpTable
    End Function
End Class
