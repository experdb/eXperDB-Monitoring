Imports System.Drawing
Imports System.ComponentModel
 

<DesignTimeVisible(False), _
 ToolboxItem(False), _
 DefaultProperty("Text")> _
Public Class ScheduleItem


    Private _Text As String = String.Empty '
    Private _Parent As ScheduleControl = Nothing
    Private _FDate As Date = CDate(Now.ToShortDateString)
    Private _TDate As Date = CDate(Now.ToShortDateString)
    Private _Rectangle As New Rectangle(0, 0, 0, 0)
    Private _BackColor As System.Drawing.Color = SystemColors.Highlight
    Private _Tag As Object = Nothing
    Private _Key As String = String.Empty

    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(ByVal ScheduleDate As Date, ByVal Text As String)
        Me._FDate = ScheduleDate
        Me._TDate = ScheduleDate
        Me._Text = Text
    End Sub

    Public Sub New(ByVal ScheduleDate As Date, ByVal Text As String, ByVal BackColor As Color)
        Me._FDate = ScheduleDate
        Me._TDate = ScheduleDate
        Me._Text = Text
        Me._BackColor = BackColor
    End Sub

    Public Sub New(ByVal DateFrom As Date, ByVal DateTo As Date, ByVal Text As String)
        Me._FDate = DateFrom
        Me._TDate = DateTo
        Me._Text = Text

    End Sub
    Public Sub New(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Text As String, ByVal BackColor As Color, ByVal infoData As Object)
        Me._FDate = FromDate
        Me._TDate = ToDate
        Me._Text = Text
        Me._BackColor = BackColor
        Me._InfoData = infoData

    End Sub


    Public Property FromDate() As Date
        Get
            Return Me._FDate
        End Get
        Set(ByVal value As Date)
            Me._FDate = CDate(value.ToShortDateString)
        End Set
    End Property

    Public Property ToDate() As Date
        Get
            Return Me._TDate
        End Get
        Set(ByVal value As Date)
            Me._TDate = CDate(value.ToShortDateString)

        End Set
    End Property

    Public Property Text() As String
        Get
            Return Me._Text
        End Get
        Set(ByVal value As String)
            Me._Text = value

        End Set
    End Property

    Public Property BackColor() As Color
        Get
            Return Me._BackColor
        End Get
        Set(ByVal value As Color)
            If Not Me._BackColor.Equals(value) Then
                Me._BackColor = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Me.Bounds)
            End If
        End Set
    End Property

    Public ReadOnly Property IsParent() As Boolean
        Get
            Return Me._Parent IsNot Nothing
        End Get
    End Property

    Public ReadOnly Property Bounds() As Rectangle
        Get
            Return Me._Rectangle
        End Get
    End Property

    Private _infoData As Object = Nothing
    Property InfoData As Object
        Get
            Return _infodata
        End Get
        Set(value As Object)
            _infoData = value
        End Set
    End Property







    Friend Sub SetParent(ByVal Parent As ScheduleControl)
        Me._Parent = Parent

    End Sub
    Friend Sub SetRectangle(ByVal Rect As Rectangle)
        If Me._Rectangle.Equals(Rect) = False Then
            Me._Rectangle = Rect
            If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Rect)
        End If
    End Sub
    Private _ToolTipText As String = ""
    Public Property ToolTipText() As String
        Get
            Return Me._ToolTipText
        End Get
        Set(ByVal value As String)
            Me._ToolTipText = value
        End Set
    End Property

    <Category("Data"), _
       Localizable(False), _
       Bindable(True), _
       DefaultValue(GetType(Object), Nothing), _
       Description("Data to associate with the item"), _
       TypeConverter(GetType(System.ComponentModel.StringConverter))> _
      Public Property Tag() As Object
        Get
            Return Me._Tag
        End Get
        Set(ByVal value As Object)

            Me._Tag = value

        End Set
    End Property

    Public Property Key() As String
        Get
            Return Me._Key
        End Get
        Set(ByVal value As String)
            Me._Key = value
        End Set
    End Property
    Private _visible As Boolean = True
    <DefaultValue(True)> _
    Public Property Visible() As Boolean
        Get
            Return Me._visible
        End Get
        Set(ByVal value As Boolean)
            Me._visible = value
        End Set
    End Property

 
End Class
