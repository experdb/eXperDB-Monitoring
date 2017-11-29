Imports System.Drawing
Imports System.ComponentModel
<DesignTimeVisible(False), _
 ToolboxItem(False), _
 DefaultProperty("Text")> _
Public Class ScheduleColumn
    Implements ICloneable

    Private _Text As String = String.Empty
    Private _Tag As Object = Nothing
    Private _Parent As ScheduleControl = Nothing
    Private _Rectangle As New Rectangle(0, 0, 0, 0)
    Private _BackColor As System.Drawing.Color = SystemColors.Window



    Private _AlignFlags As ContentAlignment = ContentAlignment.MiddleCenter
    Property AlignFlags As ContentAlignment
        Get
            Return _AlignFlags
        End Get
        Set(value As ContentAlignment)
            If Not _AlignFlags.Equals(value) Then
                _AlignFlags = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Me.Bounds)
            End If
        End Set
    End Property


    Private _ForeColor As Color = SystemColors.ControlText
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

    Private _Font As Font = SystemFonts.DefaultFont
    Property Font As Font
        Get
            Return _Font
        End Get
        Set(value As Font)
            If Not _Font.Equals(value) Then
                _Font = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Me.Bounds)
            End If
        End Set
    End Property


    Property ForeColor As Color
        Get
            Return _ForeColor
        End Get
        Set(value As Color)
            If Not _forecolor.equals(value) Then
                _forecolor = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Me.Bounds)

            End If
        End Set
    End Property
    Public Property Text() As String
        Get
            Return Me._Text
        End Get
        Set(ByVal value As String)
            If Not Me._Text.Equals(value) Then
                Me._Text = value
                If Me._Rectangle.Width > 0 Then
                    If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Me._Rectangle)
                End If

            End If
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
            If Not Me._Tag.Equals(value) Then
                Me._Tag = value
            End If
        End Set
    End Property
    <Browsable(False)> _
    Public ReadOnly Property Index() As Integer
        Get
            If Me._Parent IsNot Nothing Then Return Me._Parent.Columns.IndexOf(Me)
            Return -1
        End Get
    End Property

    Friend Sub SetParent(ByVal Parent As ScheduleControl)
        Me._Parent = Parent

    End Sub

    Public ReadOnly Property IsParent() As Boolean
        Get
            Return Me._Parent IsNot Nothing
        End Get
    End Property


    Friend Sub SetRectangle(ByVal Rect As Rectangle)
        If Me._Rectangle.Equals(Rect) = False Then
            Me._Rectangle = Rect
            'If Me._Parent IsNot Nothing Then Me._Parent.Invalidate(Rect)
        End If
    End Sub

    Public ReadOnly Property Bounds() As Rectangle
        Get
            Return Me._Rectangle
        End Get
    End Property


    Public Function Clone() As Object Implements System.ICloneable.Clone

        Dim NewCol As New ScheduleColumn
        NewCol.Text = Me._Text

        Return NewCol

    End Function




    Public Sub New()
        Me._init()

    End Sub

    Private Sub _init()
        'If Me.IsParent = True Then
        '    If Me._Parent.AutoDate Then
        '        Me._Parent.StartDate.AddDays(Me._Parent.Columns.IndexOf(Me))
        '    End If
        'End If
    End Sub

    Public Sub Remove()
        If Me._Parent IsNot Nothing Then Me._Parent.Columns.Remove(Me)
    End Sub
    Private _ColumnDate As Date
    ReadOnly Property ColumnDate As Date
        Get
            Return _ColumnDate
        End Get
    End Property
    Public Sub SetDate(ByVal Dt As Date)
        _ColumnDate = Dt
    End Sub







    Private _itemHeaderFont As Font = SystemFonts.DefaultFont
    Property itemHeaderFont As Font
        Get
            Return _itemHeaderFont
        End Get
        Set(value As Font)
            If Not _itemHeaderFont.Equals(value) Then
                _itemHeaderFont = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
            End If
        End Set
    End Property

    Private _itemHeaderForeColor As Color = SystemColors.ControlText
    Property itemHeaderForeColor As Color
        Get
            Return _itemHeaderForeColor
        End Get
        Set(value As Color)
            If Not _itemHeaderForeColor.Equals(value) Then
                _itemHeaderForeColor = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()

            End If
        End Set
    End Property


    Private _ItemHeaderText As String = ""
    Property ItemHeaderText As String
        Get
            Return _ItemHeaderText
        End Get
        Set(value As String)
            If Not _ItemHeaderText.Equals(value) Then
                _ItemHeaderText = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
            End If
        End Set
    End Property
    Private _ItemHeaderBackColor As Color = Color.AliceBlue
    Property itemHeaderBackColor As Color
        Get
            Return _ItemHeaderBackColor
        End Get
        Set(value As Color)
            If Not _ItemHeaderBackColor.Equals(value) Then
                _ItemHeaderBackColor = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
            End If
        End Set
    End Property


    Private _ItemHeaderAlignFlags As ContentAlignment = ContentAlignment.TopLeft
    Property ItemHeaderAlignFlags As ContentAlignment
        Get
            Return _ItemHeaderAlignFlags
        End Get
        Set(value As ContentAlignment)
            If Not _ItemHeaderAlignFlags.Equals(value) Then
                _ItemHeaderAlignFlags = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
            End If
        End Set
    End Property
    Private _OverlayClr As Boolean = False
    Property OverlayClr As Boolean
        Get
            Return _OverlayClr
        End Get
        Set(value As Boolean)
            If Not _OverlayClr.Equals(value) Then
                _OverlayClr = value
                If Me._Parent IsNot Nothing Then Me._Parent.Invalidate()
            End If
        End Set
    End Property



End Class
