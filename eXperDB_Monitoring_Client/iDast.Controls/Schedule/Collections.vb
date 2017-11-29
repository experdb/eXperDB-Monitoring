Public Class ScheduleColumnCollection
    Inherits CollectionBase

    Private _Parent As ScheduleControl

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Parent As ScheduleControl)
        MyBase.New()
        Me._Parent = Parent
    End Sub

    Friend Event ItemsChanged As Delegates.ItemChangedEventhandler



    Default Property Item(ByVal Index As Integer) As ScheduleColumn
        Get
            Return DirectCast(Me.List.Item(Index), ScheduleColumn)
        End Get
        Set(ByVal value As ScheduleColumn)
            Me.List.Item(Index) = value
        End Set
    End Property


    Public Function Add(ByVal Column As ScheduleColumn) As Integer
        Return Me.List.Add(column)
    End Function

    Public Function Add(ByVal Text As String) As ScheduleColumn
        Dim NewCol As New ScheduleColumn
        NewCol.Text = Text
        SyncLock Me.List.SyncRoot
            Me.List.Add(NewCol)
        End SyncLock

        Return NewCol

    End Function

    Public Sub AddRange(ByVal Columns() As ScheduleColumn)
        If Columns IsNot Nothing Then
            SyncLock Me.List.SyncRoot
                For i As Integer = 0 To Columns.GetUpperBound(0)
                    Me.List.Add(Columns(i))
                Next
            End SyncLock
        End If
    End Sub

    Public Function Contains(ByVal Column As ScheduleColumn) As Boolean
        Return Me.List.Contains(Column)
    End Function

    Public Function IndexOf(ByVal Column As ScheduleColumn) As Integer
        Return Me.List.IndexOf(Column)
    End Function

    Public Sub Insert(ByVal Column As ScheduleColumn, ByVal Index As Integer)
        Me.List.Insert(Index, Column)
    End Sub


    Protected Overrides Sub OnClear()
        MyBase.OnClear()
        For Each Column As ScheduleColumn In Me.List
            Me._remove(Column)
        Next

        RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(-1, Enums.CollectionActions.Clearing, Me.List))

    End Sub

    Protected Overrides Sub OnClearComplete()
        MyBase.OnClearComplete()
        RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(-1, Enums.CollectionActions.Cleared, Nothing))


    End Sub

    Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnInsertComplete(index, value)
        Me._Add(DirectCast(value, ScheduleColumn), index)
        RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(index, Enums.CollectionActions.Added, value))

    End Sub

    Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnRemoveComplete(index, value)
        Me._remove(DirectCast(value, ScheduleColumn))
        RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(index, Enums.CollectionActions.Removed, value))

    End Sub

    Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
        MyBase.OnSetComplete(index, oldValue, newValue)
        Me._remove(DirectCast(oldValue, ScheduleColumn))
        Me._add(DirectCast(newValue, ScheduleColumn), index)
        RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(index, Enums.CollectionActions.Changed, newValue, oldValue))


    End Sub






    Public Sub Remove(ByVal column As ScheduleColumn)
        Me.List.Remove(column)

    End Sub


    Private Sub _add(ByVal Column As ScheduleColumn, ByVal Index As Integer)
        If Not Column.IsParent Then
            Column.SetParent(Me._Parent)
        Else
            Me.Remove(Column)
        End If
    End Sub

    Private Sub _remove(ByVal Column As ScheduleColumn)
        Column.SetParent(Nothing)
    End Sub


End Class


Public Class ScheduleItemCollection
    Inherits CollectionBase

    Private _Parent As ScheduleControl



    Public Sub New(ByVal Parent As ScheduleControl)
        MyBase.New()

        Me._Parent = Parent
    End Sub

    Default Property Item(ByVal Index As Integer) As ScheduleItem

        Get
            Return DirectCast(Me.List.Item(Index), ScheduleItem)
        End Get
        Set(ByVal value As ScheduleItem)
            Me.List.Item(Index) = value
        End Set
    End Property

    Public Function Add(ByVal Item As ScheduleItem) As Integer
        Dim rtnValue As Integer = Me.List.Add(Item)
        If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
        Return rtnValue
    End Function

    Public Function Add(ByVal ScheduleDate As Date, ByVal Text As String) As ScheduleItem
        Dim NewItem As New ScheduleItem(ScheduleDate, Text)


        SyncLock Me.List.SyncRoot
            Me.List.Add(NewItem)
        End SyncLock
        If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
        Return NewItem

    End Function



    Public Function Add(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Text As String, ByVal itemColor As Drawing.Color, ByVal InfoData As Object) As ScheduleItem
        Dim NewItem As New ScheduleItem(FromDate, ToDate, Text, itemColor, InfoData)
        SyncLock Me.List.SyncRoot
            Me.List.Add(NewItem)
        End SyncLock

        If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
        Return NewItem

    End Function



    Public Sub AddRange(ByVal Items() As ScheduleItem)
        If Items IsNot Nothing Then
            SyncLock Me.List.SyncRoot
                For i As Integer = 0 To Items.GetUpperBound(0)
                    Me.List.Add(Items(i))
                Next

            End SyncLock
            If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
        End If
    End Sub

    Public Function Contains(ByVal Item As ScheduleItem) As Boolean
        Return Me.List.Contains(Item)
    End Function

    Public Function IndexOf(ByVal Item As ScheduleItem) As Integer
        Return Me.List.IndexOf(Item)
    End Function

    Public Sub Insert(ByVal Item As ScheduleItem, ByVal Index As Integer)
        Me.List.Insert(Index, Item)
    End Sub


    Protected Overrides Sub OnClear()
        MyBase.OnClear()
        For Each Item As ScheduleItem In Me.List
            Me._remove(Item)
        Next
        If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()


    End Sub

    Protected Overrides Sub OnClearComplete()
        MyBase.OnClearComplete()


    End Sub

    Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnInsertComplete(index, value)
        Me._add(DirectCast(value, ScheduleItem), index)

    End Sub

    Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
        MyBase.OnRemoveComplete(index, value)
        Me._remove(DirectCast(value, ScheduleItem))

    End Sub

    Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
        MyBase.OnSetComplete(index, oldValue, newValue)
        Me._remove(DirectCast(oldValue, ScheduleItem))
        Me._add(DirectCast(newValue, ScheduleItem), index)


    End Sub






    Public Sub Remove(ByVal Item As ScheduleItem)
        Me.List.Remove(Item)

    End Sub


    Private Sub _add(ByVal Item As ScheduleItem, ByVal Index As Integer)
        If Not Item.IsParent Then
            Item.SetParent(Me._Parent)
        Else
            Me.Remove(Item)
        End If
    End Sub

    Private Sub _remove(ByVal item As ScheduleItem)
        item.SetParent(Nothing)
    End Sub





End Class
