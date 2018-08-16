Imports System.ComponentModel
Imports System.Drawing.Drawing2D
<System.ComponentModel.DefaultEvent("SelectedChanged")> _
Public Class Progress3D
    Inherits System.Windows.Forms.Control

    Private _MaxLevel As Integer = 4

    Private _Spacing As Integer = 1

    Private _Items As New Progress3DItemCollection(Me)

    Private _HeadText As String = ""

    Private _HeadText2 As String = ""

    Private _SubText As String = ""

    Private _SubText2 As String = ""

    Private _Margin As Integer = 10

    Private _Radius As Integer = 10

    Private _isSelected As Boolean = False
    Property isSelected As Boolean
        Get
            Return _isSelected
        End Get
        Set(value As Boolean)
            If Not _isSelected.Equals(value) Then
                _isSelected = value
                Me.Invalidate()
            End If
        End Set
    End Property
    Public Property HeadText() As String
        Get
            Return _HeadText
        End Get
        Set(value As String)
            _HeadText = value
        End Set
    End Property
    Public Property HeadText2() As String
        Get
            Return _HeadText2
        End Get
        Set(value As String)
            _HeadText2 = value
        End Set
    End Property
    Public Property SubText() As String
        Get
            Return _SubText
        End Get
        Set(value As String)
            _SubText = value
        End Set
    End Property
    Public Property SubText2() As String
        Get
            Return _SubText2
        End Get
        Set(value As String)
            _SubText2 = value
        End Set
    End Property


    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)


        Dim tmpEvent As New SelectEventArgs(Not _isSelected, e)
        RaiseEvent SelectedChanged(Me, tmpEvent)

        If tmpEvent.Cancel = False Then
            isSelected = Not isSelected
        End If


    End Sub

    Public Class SelectEventArgs
        Inherits EventArgs
        Private _mEvent As MouseEventArgs
        Public Sub New(ByVal Selected As Boolean, ByVal mEvent As MouseEventArgs)
            MyBase.New()
            _Selected = Selected
            _mEvent = mEvent
        End Sub
        Private _Selected As Boolean
        ReadOnly Property Selected As Boolean
            Get
                Return _Selected
            End Get
        End Property

        Private _Cancel As Boolean = False
        Property Cancel As Boolean
            Get
                Return _Cancel
            End Get
            Set(value As Boolean)
                _Cancel = value
            End Set
        End Property
        ReadOnly Property MouseEvent As MouseEventArgs
            Get
                Return _mEvent
            End Get
        End Property

    End Class

    Public Event SelectedChanged(ByVal sender As Object, ByVal e As SelectEventArgs)




    Public Sub New()
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)
        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        MyBase.SetStyle(DoubleBuffered, True)

        Dim DisplayHeight = Screen.AllScreens(0).WorkingArea.Height
        If DisplayHeight >= 1080 Then
            '_Margin = 18
            _Margin = 12
        ElseIf DisplayHeight >= 900 And DisplayHeight < 1080 Then
            '_Margin = 15
            _Margin = 10
        Else
            '_Margin = 11
            _Margin = 7
        End If

    End Sub


    <Category("Item"), _
        Description("Color Item"), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content), _
        Editor(GetType(System.ComponentModel.Design.CollectionEditor), GetType(Drawing.Design.UITypeEditor))> _
    ReadOnly Property Items As Progress3DItemCollection
        Get
            Return _Items
        End Get
    End Property

#Region "Animation "
    Private _UseAnimation As Boolean = False
    Property UseAnimation As Boolean
        Get
            Return _UseAnimation
        End Get
        Set(value As Boolean)
            If Not _UseAnimation.Equals(value) Then
                _UseAnimation = value
                InitAnimation()

            End If

        End Set
    End Property

    Private Sub InitAnimation()
        TmAni.Interval = 200
        If _UseAnimation = True Then
            TmAni.Start()
        Else
            TmAni.Stop()
        End If
    End Sub

    Private WithEvents TmAni As New Timer

    Private Sub TmAni_Tick(sender As Object, e As EventArgs) Handles TmAni.Tick
        Me.Invalidate()
        Dim BretTmEnabled As Boolean = False
        For i As Integer = 0 To _Items.Count - 1
            If _Items(i).AniCheck = True Then
                BretTmEnabled = True
                Exit For
            End If
        Next
        If BretTmEnabled = False Then
            TmAni.Stop()
        End If
    End Sub

    Private _Warning As Boolean = False
    Property Warning() As Boolean
        Get
            Return _Warning
        End Get
        Set(value As Boolean)
            If Not _Warning.Equals(value) Then
                _Warning = value
                If _Warning = True Then
                    Tm.Interval = 120
                    Tm.Start()
                Else
                    Tm.Stop()
                    Me.Invalidate()
                End If
            End If
        End Set
    End Property
    Private _WarningColor As Color = Color.FromArgb(255, 80, 80)
    Property WarningColor As Color
        Get
            Return _WarningColor
        End Get
        Set(value As Color)
            If Not _WarningColor.Equals(value) Then
                _WarningColor = value
            End If
        End Set
    End Property
    Private WithEvents Tm As New Timer
    Private _WOpacity As Integer = 30
    Private Sub Tm_Tick(sender As Object, e As EventArgs) Handles Tm.Tick
        _WOpacity += 8
        If _WOpacity > 160 Then
            _WOpacity = 50
        End If
        Me.Invalidate()
    End Sub
#End Region

    Private _BefValue As Integer = 0
    Private _Value As Integer = 0
    <Category("Data")> _
    Property Value As Integer
        Get
            Return _Value

        End Get
        Set(value As Integer)
            If Not _Value.Equals(value) Then
                If value >= _Items.Count Then
                    value = Items.Count
                End If
                _BefValue = _Value
                _Value = value
                SetItemChecked(value)
                InitAnimation()
                Me.Invalidate()
            End If
        End Set
    End Property


    Private Sub SetItemChecked(ByVal intValue As Integer)
        For i As Integer = 0 To Me._Items.Count - 1
            If intValue - 1 >= i Then
                Me._Items(i).Checked = True
            Else
                Me._Items(i).Checked = False
            End If
        Next

    End Sub



    Private _BorderColor As Color = Color.Black
    <Category("Design")> _
    Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            If Not _BorderColor.Equals(value) Then
                _BorderColor = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _UseTitle As Boolean = False
    <Category("Data")> _
    Property UseTitle As Boolean
        Get
            Return _UseTitle
        End Get
        Set(value As Boolean)
            If Not _UseTitle.Equals(value) Then
                _UseTitle = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _FillColor As Color = Color.FromArgb(255, 38, 38, 38)
    <Category("Design")> _
    Property FillColor As Color
        Get
            Return _FillColor
        End Get
        Set(value As Color)
            If Not _FillColor.Equals(value) Then
                _FillColor = value
                MyBase.Invalidate()

            End If
        End Set
    End Property


    <Category("Design")> _
    Property Radius As Integer
        Get
            Return _Radius
        End Get
        Set(value As Integer)
            If Not _Radius.Equals(value) Then
                _Radius = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _grPath As System.Drawing.Drawing2D.GraphicsPath
    Private Function DrawBorder(ByVal pGr As Graphics) As Rectangle
        Dim BaseRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
        Dim intDiameter As Integer = _Radius * 2
        BaseRect.Inflate(-2, -2)





        Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
        grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y, intDiameter, intDiameter), 180, 90)
        grPath.AddLine(New Point(BaseRect.X + _Radius, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y))
        grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - intDiameter, BaseRect.Y, intDiameter, intDiameter), 270, 90)
        grPath.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + _Radius), New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + BaseRect.Height - _Radius))
        grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - intDiameter, BaseRect.Y + BaseRect.Height - intDiameter, intDiameter, intDiameter), 0, 90)
        grPath.AddLine(New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y + BaseRect.Height), New Point(BaseRect.X + _Radius, BaseRect.Y + BaseRect.Height))
        grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y + BaseRect.Height - intDiameter, intDiameter, intDiameter), 90, 90)
        grPath.CloseAllFigures()
        Dim szf As New SizeF

        If _UseTitle Then
            szf = pGr.MeasureString(MyBase.Text, MyBase.Font)
            'grPath.AddString(Me._HeadText, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size, New Point(BaseRect.X + _Radius + BaseRect.Width / 4 + 2, BaseRect.Y + 5), System.Drawing.StringFormat.GenericDefault)
            grPath.AddString(MyBase.Text, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size - 1, New Point(BaseRect.X + _Radius + BaseRect.Width / 4 - 3, BaseRect.Y + 5), System.Drawing.StringFormat.GenericDefault)
            grPath.AddLine(New Point(BaseRect.X + _Radius + BaseRect.Width / 4, BaseRect.Y + (BaseRect.Height * 1 / 3) + 4), New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y + (BaseRect.Height * 1 / 3) + 4))
            'grPath.AddLine(New Point(BaseRect.X + _Radius + BaseRect.Width / 4, BaseRect.Y + (BaseRect.Height * 2 / 3)), New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y + (BaseRect.Height * 2 / 3)))
            grPath.AddString(Me._SubText, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size - 4, New Point(BaseRect.X + _Radius + BaseRect.Width / 4, BaseRect.Y + (BaseRect.Height * 3 / 4)), System.Drawing.StringFormat.GenericDefault)
            'grPath.AddString(Me._SubText2, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size - 3, New Point(BaseRect.X + _Radius + BaseRect.Width / 4, BaseRect.Y + (BaseRect.Height / 3 + 1) + 5 + (BaseRect.Height / 4)), System.Drawing.StringFormat.GenericDefault)

        End If

        pGr.FillPath(New SolidBrush(_FillColor), grPath)
        pGr.DrawPath(New Pen(MyBase.ForeColor, 1), grPath)
        'pGr.DrawPath(New Pen(Color.FromArgb(255, 255, 255, 255), 1), grPath)

        If _UseSelected = True AndAlso isSelected = True Then
            pGr.FillPath(New SolidBrush(Color.FromArgb(30, 255, 255, 255)), grPath)

        End If
        _grPath = grPath


        '        Return New Rectangle(BaseRect.Left + 1, BaseRect.Y + szf.Height + 1, BaseRect.Width - 2, BaseRect.Height - szf.Height - 2)
        Return New Rectangle(BaseRect.Left + 1, BaseRect.Y + _Margin + _Radius, BaseRect.Width - 14, BaseRect.Height - _Radius - _Margin)

    End Function

    Private _UseSelected As Boolean = True
    Property UseSelected As Boolean
        Get
            Return _UseSelected
        End Get
        Set(value As Boolean)
            If Not _UseAnimation.Equals(value) Then
                _UseSelected = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim Gr As Graphics = e.Graphics

        Gr.SmoothingMode = SmoothingMode.AntiAlias
        Gr.Clear(MyBase.BackColor)

        Dim BaseRect As Rectangle = DrawBorder(Gr)
        BaseRect.Inflate(-5, -5)
        If BaseRect.Width < 5 Or BaseRect.Height < 5 Then Return

        'Dim LvHeight As Integer = (BaseRect.Height - (_Spacing * _Items.Count)) / (_Items.Count + 1)
        Dim LvHeight As Integer = (BaseRect.Height) / (_Items.Count) + 2

        'Dim BaseElRect As New Rectangle(BaseRect.Left, BaseRect.Top + BaseRect.Height - LvHeight, BaseRect.Width / 4, LvHeight)
        Dim BaseElRect As New Rectangle(BaseRect.Left, BaseRect.Top + BaseRect.Height - LvHeight, BaseRect.Width / 4, LvHeight)

        Dim El1 As Rectangle = BaseElRect
        Dim El2 As Rectangle = El1 : El2.Offset(0, -1 * LvHeight)
        Dim HRect As New Rectangle(El1.Left, El2.Top + (El2.Height / 2), El1.Width, LvHeight)

        Dim FillPath As New Drawing2D.GraphicsPath
        'FillPath.AddArc(El1, 0, 180)
        FillPath.AddLine(New Point(El1.Right, El1.Top + El1.Height / 2), New Point(El1.Left, El1.Top + El1.Height / 2))
        FillPath.AddLine(New Point(El1.Left, El1.Top + El1.Height / 2), New Point(El2.Left, El2.Top + El2.Height / 2))
        FillPath.AddLine(New Point(El2.Right, El2.Top + El2.Height / 2), New Point(El1.Right, El1.Top + El1.Height / 2))
        'FillPath.AddEllipse(El2)
        FillPath.FillMode = Drawing2D.FillMode.Winding
        FillPath.Flatten()

        Dim LinePath As New Drawing2D.GraphicsPath
        'LinePath.AddArc(El1, 0, 180)
        LinePath.AddLine(New Point(El1.Right, El1.Top + El1.Height / 2), New Point(El1.Left, El1.Top + El1.Height / 2))
        LinePath.AddLine(New Point(El1.Left, El1.Top + El1.Height / 2), New Point(El2.Left, El2.Top + El2.Height / 2))
        'LinePath.AddEllipse(El2)
        LinePath.AddLine(New Point(El2.Right, El2.Top + El2.Height / 2), New Point(El1.Right, El1.Top + El1.Height / 2))
        Dim OffsetMatrix As New Drawing2D.Matrix
        OffsetMatrix.Translate(0, -1 * (LvHeight + _Spacing))

        For i As Integer = 0 To _Items.Count - 1

            Dim tmpItm As Progress3DItem = _Items(i)
            If i <= _Value - 1 Then
                If UseAnimation = True Then
                    Gr.FillPath(New SolidBrush(Color.FromArgb(tmpItm.AniOpacity, tmpItm.FillColor)), FillPath)
                    If tmpItm.AniCheck = True Then
                        _Items(i).SetEffect(30)
                    End If
                Else
                    'Dim initRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
                    'initRect.Inflate(-2, -2)
                    'Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
                    'grPath.AddString(Me._HeadText, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size, New Point(initRect.X + _Radius + initRect.Width / 4 + 2, initRect.Y + 5), System.Drawing.StringFormat.GenericDefault)
                    ''Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.FillOpacity, IIf(Me._HeadText = "P", Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 255, 255, 0)))), grPath)
                    'Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.FillOpacity, IIf(Me._HeadText <> "P", IIf(Me._HeadText = "S", Color.FromArgb(255, 255, 255, 0), Color.DodgerBlue), Color.FromArgb(255, 0, 255, 0)))), grPath)
                    Gr.FillPath(New SolidBrush(Color.FromArgb(tmpItm.FillOpacity, tmpItm.FillColor)), FillPath)
                End If

                Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.LineOpacity, tmpItm.LineColor)), LinePath)
            Else
                If _UseAnimation = True Then
                    If _Items(i).AniCheck = True Then
                        Gr.FillPath(New SolidBrush(Color.FromArgb(tmpItm.AniOpacity, tmpItm.FillColor)), FillPath)
                        _Items(i).SetEffect(30)
                    End If
                    Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.LineOpacity, _BorderColor)), LinePath)
                Else
                    'Dim initRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
                    'initRect.Inflate(-2, -2)
                    'Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
                    'grPath.AddString(Me._HeadText, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size, New Point(initRect.X + _Radius + initRect.Width / 4 + 2, initRect.Y + 5), System.Drawing.StringFormat.GenericDefault)
                    ''Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.FillOpacity, IIf(Me._HeadText = "P", Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 255, 255, 0)))), grPath)
                    'Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.FillOpacity, IIf(Me._HeadText <> "P", IIf(Me._HeadText = "S", Color.FromArgb(255, 255, 255, 0), Color.DodgerBlue), Color.FromArgb(255, 0, 255, 0)))), grPath)
                    Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.LineOpacity, _BorderColor)), LinePath)
                End If

            End If

            Dim initRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
            initRect.Inflate(-2, -2)
            Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
            grPath.AddString(Me._HeadText, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size - 4, New Point(initRect.X + _Radius + initRect.Width / 4, initRect.Y + 32), System.Drawing.StringFormat.GenericDefault)
            Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.FillOpacity, IIf(Me._HeadText <> "Primary", IIf(Me._HeadText = "Standby", Color.FromArgb(255, 255, 255, 0), Color.DodgerBlue), Color.FromArgb(255, 0, 255, 0)))), grPath)
            Dim grPath2 As New System.Drawing.Drawing2D.GraphicsPath
            initRect.Inflate(-90, 0)
            'If _HeadText <> _HeadText2 Then
            '    grPath2.AddString(Me._HeadText2, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size - 4, New Point(initRect.X + _Radius + initRect.Width / 4, initRect.Y + 32), System.Drawing.StringFormat.GenericDefault)
            '    Gr.DrawPath(New Pen(Color.FromArgb(tmpItm.FillOpacity, IIf(Me._HeadText2 <> "Primary", IIf(Me._HeadText2 = "Standby", Color.FromArgb(255, 255, 255, 0), Color.DodgerBlue), Color.FromArgb(255, 0, 255, 0)))), grPath2)
            'End If

            ' 변경뒤에 다음 값을 위하여 OFFSET 
            FillPath.Transform(OffsetMatrix)
            LinePath.Transform(OffsetMatrix)
        Next
        If _Warning = True Then
            Gr.FillPath(New SolidBrush(Color.FromArgb(_WOpacity, _WarningColor.R, _WarningColor.G, _WarningColor.B)), _grPath)
            _grPath.Dispose()
        End If

    End Sub

    Public Class Progress3DItemCollection
        Inherits CollectionBase
        Private _Parent As Progress3D
        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal Parent As Progress3D)
            MyBase.New()
            _Parent = Parent
        End Sub
        'Public Delegate Sub ItemChangedEventhandler(ByVal sender As Object, ByVal e As EventArgClass.ItemActionEventArgs)
        'Friend Event ItemsChanged As ItemChangedEventHandler

        Default Property Item(ByVal index As Integer) As Progress3DItem
            Get
                Return DirectCast(Me.List.Item(index), Progress3DItem)
            End Get
            Set(value As Progress3DItem)
                Me.List.Item(index) = value
            End Set
        End Property

        Public Function Add(ByVal item As Progress3DItem) As Integer
            Return Me.List.Add(item)
        End Function

        Public Function Add(ByVal Text As String) As Progress3DItem
            Dim NewRaideritem As New Progress3DItem
            NewRaideritem.Name = GetUniqueName()

            SyncLock Me.List.SyncRoot
                Me.List.Add(NewRaideritem)
            End SyncLock
            Return NewRaideritem
        End Function

        Public Sub AddRange(ByVal items() As Progress3DItem)
            If items IsNot Nothing Then
                SyncLock Me.List.SyncRoot
                    For i As Integer = 0 To items.GetUpperBound(0)
                        Me.List.Add(items(i))
                    Next
                End SyncLock
            End If
        End Sub

        Public Function Contains(ByVal item As Progress3DItem) As Boolean
            Return Me.List.Contains(item)
        End Function

        Public Function IndexOf(ByVal item As Progress3DItem) As Integer
            Return Me.List.IndexOf(item)
        End Function

        Public Sub Insert(ByVal item As Progress3DItem, ByVal Index As Integer)
            Me.List.Insert(Index, item)
        End Sub

        Protected Overrides Sub OnClear()
            MyBase.OnClear()
            For Each Column As Progress3DItem In Me.List
                Me._remove(Column)
            Next

            'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(Nothing, Enums.CollectionActions.Clearing))

        End Sub

        Protected Overrides Sub OnClearComplete()
            MyBase.OnClearComplete()
            'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(Nothing, Enums.CollectionActions.Cleared))


        End Sub

        Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
            MyBase.OnInsertComplete(index, value)
            Me._add(DirectCast(value, Progress3DItem), index)
            'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(value, Raideritem), Enums.CollectionActions.Added))

        End Sub

        Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
            MyBase.OnRemoveComplete(index, value)
            Me._remove(DirectCast(value, Progress3DItem))
            'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(value, Raideritem), Enums.CollectionActions.Removed))

        End Sub

        Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
            MyBase.OnSetComplete(index, oldValue, newValue)
            Me._remove(DirectCast(oldValue, Progress3DItem))
            Me._add(DirectCast(newValue, Progress3DItem), index)
            'RaiseEvent ItemsChanged(Me, New EventArgClass.ItemActionEventArgs(DirectCast(newValue, Raideritem), Enums.CollectionActions.Changed))


        End Sub






        Public Sub Remove(ByVal item As Progress3DItem)
            Me.List.Remove(item)

        End Sub


        Private Sub _add(ByVal item As Progress3DItem, ByVal Index As Integer)
            If Not item.isParent Then
                item.SetParent(Me._Parent)
            Else
                Me.Remove(item)
            End If
        End Sub

        Private Sub _remove(ByVal item As Progress3DItem)
            item.SetParent(Nothing)
        End Sub



        Private Function GetUniqueName() As String
            Const Prefix As String = "Progress3DRange"
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

    Public Class Progress3DItem


        Public Sub New()

        End Sub
        Private _Name As String
        <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Design"), System.ComponentModel.DisplayName("(Name)"), System.ComponentModel.Description("Instance Name.")> _
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(value As String)
                _Name = value
            End Set
        End Property


        Private _FillColor As Color = Color.WhiteSmoke

        Property FillColor As Color
            Get
                Return _FillColor
            End Get
            Set(value As Color)
                _FillColor = value
                If _parent IsNot Nothing Then _parent.Invalidate()
            End Set
        End Property


        Private _FillOpacity As Integer = 180
        Property FillOpacity As Integer
            Get
                Return _FillOpacity
            End Get
            Set(value As Integer)
                If Not _FillOpacity.Equals(value) Then
                    _FillOpacity = value
                    If _parent IsNot Nothing Then _parent.Invalidate()
                End If
            End Set
        End Property



        Private _LineColor As Color = Drawing.Color.WhiteSmoke
        Property LineColor As Color
            Get
                Return _LineColor
            End Get
            Set(value As Color)
                If Not _LineColor.Equals(value) Then
                    _LineColor = value
                    If _parent IsNot Nothing Then _parent.Invalidate()
                End If
            End Set
        End Property


        Private _LineOpacity As Integer = 220
        Property LineOpacity As Integer
            Get
                Return _LineOpacity
            End Get
            Set(value As Integer)
                If Not _LineOpacity.Equals(value) Then
                    _LineOpacity = value
                    If _parent IsNot Nothing Then _parent.Invalidate()
                End If
            End Set
        End Property


        Private _parent As Progress3D = Nothing
        Public Sub SetParent(ByVal parent As Progress3D)
            _parent = parent
        End Sub
        ReadOnly Property isParent() As Boolean
            Get
                Return _parent IsNot Nothing
            End Get
        End Property
        Private _Checked As Boolean = False

        Property Checked As Boolean
            Get
                Return _Checked
            End Get
            Set(value As Boolean)
                _Checked = value
            End Set
        End Property


        Private _AniOpacity As Integer = 0
        ReadOnly Property AniOpacity As Integer
            Get
                Return _AniOpacity
            End Get
        End Property

        Friend Sub SetEffect(ByVal Value As Integer)
            If Checked = True Then
                _AniOpacity += Value
                If _AniOpacity >= _FillOpacity Then
                    _AniOpacity = _FillOpacity
                End If
            Else
                _AniOpacity -= Value
                If _AniOpacity <= 0 Then
                    _AniOpacity = 0
                End If
            End If
        End Sub

        Friend Function AniCheck() As Boolean
            If Checked = True Then
                If _AniOpacity = _FillOpacity Then
                    Return False
                Else
                    Return True
                End If
            Else
                If _AniOpacity = 0 Then
                    Return False
                Else
                    Return True
                End If
            End If
        End Function

    End Class



    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Progress3D
        '
        Me.ResumeLayout(False)

    End Sub

    Private Sub OnMouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Cursor = Windows.Forms.Cursors.Hand
    End Sub
End Class






