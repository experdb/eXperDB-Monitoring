Public Class AreaCollection
    Inherits CollectionBase
    Private _Parent As Raider
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Parent As Raider)
        MyBase.New()
        _Parent = Parent
    End Sub
    'Public Delegate Sub ItemChangedEventhandler(ByVal sender As Object, ByVal e As EventArgClass.ItemActionEventArgs)
    'Friend Event ItemsChanged As ItemChangedEventHandler

    Default Property Item(ByVal index As Integer) As Areaitem
        Get
            Return DirectCast(Me.List.Item(index), Areaitem)
        End Get
        Set(value As Areaitem)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Function Add(ByVal item As Areaitem) As Integer
        Return Me.List.Add(item)
    End Function

    Public Function Add(ByVal Text As String) As Areaitem
        Dim NewCircleitem As New Areaitem
        SyncLock Me.List.SyncRoot
            Me.List.Add(NewCircleitem)
        End SyncLock
        Return NewCircleitem
    End Function

    Public Sub AddRange(ByVal items() As Areaitem)
        If items IsNot Nothing Then
            SyncLock Me.List.SyncRoot
                For i As Integer = 0 To items.GetUpperBound(0)
                    Me.List.Add(items(i))
                Next
            End SyncLock
        End If
    End Sub

    Public Function Contains(ByVal item As Areaitem) As Boolean
        Return Me.List.Contains(item)
    End Function

    Public Function IndexOf(ByVal item As Areaitem) As Integer
        Return Me.List.IndexOf(item)
    End Function

    Public Sub Insert(ByVal item As Areaitem, ByVal Index As Integer)
        Me.List.Insert(Index, item)
    End Sub

    Protected Overrides Sub OnClear()
        MyBase.OnClear()
        For Each Column As Areaitem In Me.List
            Me._remove(Column)
        Next

        If _Parent IsNot Nothing Then _Parent.Invalidate()

        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(Nothing, Enums.CollectionActions.Clearing))

    End Sub
    Protected Overrides Sub OnRemove(index As Integer, value As Object)
        MyBase.OnRemove(index, value)
        If _Parent IsNot Nothing Then _Parent.Invalidate()
    End Sub

   

    Protected Overrides Sub OnClearComplete()
        MyBase.OnClearComplete()
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(Nothing, Enums.CollectionActions.Cleared))


    End Sub

    Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnInsertComplete(index, value)
        Me._add(DirectCast(value, Areaitem), index)
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(value, Circleitem), Enums.CollectionActions.Added))

    End Sub

    Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnRemoveComplete(index, value)
        Me._remove(DirectCast(value, Areaitem))
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(value, Circleitem), Enums.CollectionActions.Removed))

    End Sub

    Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
        MyBase.OnSetComplete(index, oldValue, newValue)
        Me._remove(DirectCast(oldValue, Areaitem))
        Me._add(DirectCast(newValue, Areaitem), index)
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(newValue, Circleitem), Enums.CollectionActions.Changed))


    End Sub






    Public Sub Remove(ByVal item As Areaitem)
        Me.List.Remove(item)

    End Sub


    Private Sub _add(ByVal item As Areaitem, ByVal Index As Integer)
        If Not item.isParent Then
            item.SetParent(Me._Parent)
        Else
            Me.Remove(item)
        End If
    End Sub

    Private Sub _remove(ByVal item As Areaitem)
        item.SetParent(Nothing)
    End Sub




End Class
