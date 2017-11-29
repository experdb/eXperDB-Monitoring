Namespace Enums
    Public Enum CollectionActions
        [Nothing]
        Added
        Changed
        Cleared
        Clearing
        Removed
    End Enum

End Namespace

Namespace EventArgClass


    Public Class ItemActionEventArgs
        Inherits EventArgs
#Region " Field Declarations "
        Private _Index As Integer = -1
        Private _NewVal As Object = Nothing
        Private _OldVal As Object = Nothing
        Private _Action As Enums.CollectionActions = Enums.CollectionActions.Nothing
#End Region
        Public Sub New(ByVal Index As Integer, ByVal Action As Enums.CollectionActions, ByVal Val As Object, Optional ByVal PrevVal As Object = Nothing)
            Me._Index = Index
            Me._Action = Action
            Me._NewVal = Val
            Me._OldVal = PrevVal


        End Sub

        Public ReadOnly Property Action() As Enums.CollectionActions
            Get
                Return Me._Action
            End Get
        End Property

        Public ReadOnly Property Index() As Integer
            Get
                Return Me._Index
            End Get
        End Property

        Public ReadOnly Property PreviousValue() As Object
            Get
                Return Me._OldVal
            End Get
        End Property

        Public ReadOnly Property Value() As Object
            Get
                Return Me._NewVal
            End Get
        End Property
    End Class

End Namespace

