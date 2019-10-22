Public Class itemsCollection
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

    Default Property Item(ByVal index As Integer) As RaiderItem
        Get
            Return DirectCast(Me.List.Item(index), Raideritem)
        End Get
        Set(value As RaiderItem)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Function Add(ByVal item As RaiderItem) As Integer
        Return Me.List.Add(item)
    End Function

    Public Function Add(ByVal Name As String, ByVal Text As String) As RaiderItem
        Dim NewRaideritem As New RaiderItem
        NewRaideritem.Name = Name
        NewRaideritem.Text = Text
        SyncLock Me.List.SyncRoot
            Me.List.Add(NewRaideritem)
        End SyncLock
        Return NewRaideritem
    End Function

    Public Function Add(ByVal Name As String, ByVal Text As String, ByVal Image As Image, ByVal Seq As String) As RaiderItem
        Dim NewRaideritem As New RaiderItem
        NewRaideritem.Name = Name
        NewRaideritem.Text = Text
        NewRaideritem.Image = Image
        NewRaideritem.Seq = Seq
        SyncLock Me.List.SyncRoot
            Me.List.Add(NewRaideritem)
        End SyncLock
        Return NewRaideritem
    End Function

    Public Sub AddRange(ByVal items() As RaiderItem)
        If items IsNot Nothing Then
            SyncLock Me.List.SyncRoot
                For i As Integer = 0 To items.GetUpperBound(0)
                    Me.List.Add(items(i))
                Next
            End SyncLock
        End If
    End Sub

    Public Function Contains(ByVal item As RaiderItem) As Boolean
        Return Me.List.Contains(item)
    End Function

    Public Function IndexOf(ByVal item As RaiderItem) As Integer
        Return Me.List.IndexOf(item)
    End Function

    Public Function IndexOf(ByVal Name As String) As Integer
        For i As Integer = 0 To Me.List.Count - 1

            Dim tmpitm As RaiderItem = Me.List(i)
            If tmpitm.Name.Equals(Name) Then
                Return i
            End If
        Next
        Return -1

    End Function

    Public Sub Insert(ByVal item As RaiderItem, ByVal Index As Integer)
        Me.List.Insert(Index, item)
    End Sub

    Protected Overrides Sub OnClear()
        MyBase.OnClear()
        For Each Column As Raideritem In Me.List
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
        Me._add(DirectCast(value, Raideritem), index)
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(value, Raideritem), Enums.CollectionActions.Added))

    End Sub

    Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnRemoveComplete(index, value)
        Me._remove(DirectCast(value, Raideritem))
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(value, Raideritem), Enums.CollectionActions.Removed))

    End Sub

    Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
        MyBase.OnSetComplete(index, oldValue, newValue)
        Me._remove(DirectCast(oldValue, Raideritem))
        Me._add(DirectCast(newValue, Raideritem), index)
        'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(newValue, Raideritem), Enums.CollectionActions.Changed))


    End Sub






    Public Sub Remove(ByVal item As RaiderItem)
        Me.List.Remove(item)

    End Sub


    Private Sub _add(ByVal item As RaiderItem, ByVal Index As Integer)
        If Not item.isParent Then
            item.SetParent(Me._Parent)
        Else
            Me.Remove(item)
        End If
    End Sub

    Private Sub _remove(ByVal item As RaiderItem)
        item.SetParent(Nothing)
    End Sub




End Class
