Public Class RaiderRangeCollection
    Inherits CollectionBase
    Private Owner As Raider
    Public Sub New(sender As Raider)
        Owner = sender
    End Sub

    Default Public ReadOnly Property Item(index As Integer) As RaiderRangeitem
        Get
            Return DirectCast(List(index), RaiderRangeitem)
        End Get
    End Property
    Public Function Contains(itemType As RaiderRangeitem) As Boolean
        Return List.Contains(itemType)
    End Function
    Public Function Add(itemType As RaiderRangeitem) As Integer
        itemType.SetOwner(Owner)
        If String.IsNullOrEmpty(itemType.Name) Then
            itemType.Name = GetUniqueName()
        End If
        Return List.Add(itemType)
    End Function
    Public Sub Remove(itemType As RaiderRangeitem)
        List.Remove(itemType)
    End Sub
    Public Sub Insert(index As Integer, itemType As RaiderRangeitem)
        itemType.SetOwner(Owner)
        If String.IsNullOrEmpty(itemType.Name) Then
            itemType.Name = GetUniqueName()
        End If
        List.Insert(index, itemType)
    End Sub
    Public Function IndexOf(itemType As RaiderRangeitem) As Integer
        Return List.IndexOf(itemType)
    End Function
    Public Function FindByName(name As String) As RaiderRangeitem
        For Each ptrRange As RaiderRangeitem In List
            If ptrRange.Name = name Then
                Return ptrRange
            End If
        Next
        Return Nothing
    End Function

    Protected Overrides Sub OnInsert(index As Integer, value As Object)
        If String.IsNullOrEmpty(DirectCast(value, RaiderRangeitem).Name) Then
            DirectCast(value, RaiderRangeitem).Name = GetUniqueName()
        End If
        MyBase.OnInsert(index, value)
        DirectCast(value, RaiderRangeitem).SetOwner(Owner)
    End Sub
    Protected Overrides Sub OnRemove(index As Integer, value As Object)
        If Owner IsNot Nothing Then
            Owner.Invalidate()
        End If
    End Sub
    Protected Overrides Sub OnClear()
        If Owner IsNot Nothing Then
            Owner.Invalidate()
        End If
    End Sub

    Private Function GetUniqueName() As String
        Const Prefix As String = "RaiderGauge"
        Dim index As Integer = 1
        Dim valid As Boolean
        While Me.Count <> 0
            valid = True
            For x As Integer = 0 To Me.Count - 1
                If Me(x).Name = (Prefix & index.ToString()) Then
                    valid = False
                    Exit For
                End If
            Next
            If valid Then
                Exit While
            End If
            index += 1
        End While


        Return Prefix & index.ToString()
    End Function
End Class
