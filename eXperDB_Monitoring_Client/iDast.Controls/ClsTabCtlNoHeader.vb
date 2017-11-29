Public Class ClsTabCtlNoHeader
    Inherits System.Windows.Forms.TabControl

    Private _simpleMode As Boolean = False
    Private _simpleModeInDesign As Boolean = False

    Public Property SimpleMode() As Boolean
        Get
            Return _simpleMode
        End Get
        Set(ByVal value As Boolean)
            _simpleMode = value
            RecreateHandle()
        End Set
    End Property

    Public Property SimpleModeInDesign() As Boolean
        Get
            Return _simpleModeInDesign
        End Get
        Set(ByVal value As Boolean)
            _simpleModeInDesign = value
            RecreateHandle()
        End Set
    End Property

    Public Overrides ReadOnly Property DisplayRectangle() As Rectangle

        Get
            If ((SimpleMode = True) And (Me.DesignMode <> SimpleModeInDesign)) Then

                Return New Rectangle(0, 0, Width, Height)

            Else
                Return MyBase.DisplayRectangle
            End If
        End Get
    End Property


End Class
