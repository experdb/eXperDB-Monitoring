Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Drawing2D

Public Class Raider
    Inherits Control

    Public Enum RaiderStyle
        CirclePoint = 1
        CircleChart = 2
        'RectangleChart = 4
        'RectanglePoint = 8
    End Enum

#Region "Style"
    Private _Style As RaiderStyle = RaiderStyle.CirclePoint

    <Category("RaiderStyle")> _
    Property Style As RaiderStyle

        Get
            Return _Style
        End Get
        Set(value As RaiderStyle)
            If Not _Style.Equals(value) Then
                _Style = value
                Me.Invalidate()
            End If
        End Set
    End Property
#End Region

#Region "Initialize"

    Public Sub New()
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        'MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'MyBase.SetStyle(ControlStyles.Opaque, True)

        MyBase.SetStyle(DoubleBuffered, True)
        'MyBase.DoubleBuffered = True



        'InitAnimation()

        _LinePattern = New Single() {10, 10}

        InitSpinAnimation()
        InitWaveAnimation()


    End Sub

#End Region


#Region "Drawing"

    'Protected Overrides ReadOnly Property CreateParams As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H20
    '        Return cp
    '    End Get
    'End Property
    <STAThread> _
    Protected Overrides Sub OnPaint(e As PaintEventArgs)



        Dim Gr As Graphics = e.Graphics

        Gr.SmoothingMode = SmoothingMode.AntiAlias
        Gr.PixelOffsetMode = PixelOffsetMode.HighQuality

        Gr.Clear(MyBase.BackColor)

        Dim BaseRect As Rectangle = Nothing
        If MyBase.Width > MyBase.Height Then
            BaseRect = New Rectangle((MyBase.Width - MyBase.Height) / 2, 0, MyBase.Height, MyBase.Height)
        Else
            BaseRect = New Rectangle(0, (MyBase.Height - MyBase.Width) / 2, MyBase.Width, MyBase.Width)

        End If



        BaseRect.Inflate(-2, -2)



        Select Case _Style
            Case RaiderStyle.CirclePoint
                DrawAreas(Gr, BaseRect, _Areas)
                DrawLinesCirclePoint(Gr, BaseRect, _items.Count)
                DrawItemsCirclePoint(Gr, BaseRect, _items)

            Case RaiderStyle.CircleChart
                DrawItemsCircleChart(Gr, BaseRect, _items)
                DrawLinesCircleChart(Gr, BaseRect)
                DrawAreas(Gr, BaseRect, _Areas)
                'Case RaiderStyle.RectanglePoint
                '    DrawItemsRectanglePoint(Gr, BaseRect, _items)
                'Case RaiderStyle.RectangleChart
                '    DrawItemsRectangleChart(Gr, BaseRect, _items)
        End Select

        If _UseAnimation = True Then
            If _UseSpinRaider = True Then
                DrawEffectRotate(Gr, BaseRect, _Angle)
            End If

            If _UseWave = True Then
                DrawEffectCircle(Gr, BaseRect, _Width)
            End If
        End If




    End Sub
#End Region

#Region "Line"
    Private _LineColor As Color = Color.WhiteSmoke
    <Category("Line"), Description("색상")> _
    Property LineColor As Color
        Get
            Return _LineColor
        End Get
        Set(value As Color)
            If Not _LineColor.Equals(value) Then
                _LineColor = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _LineOpacity As Integer = 128
    <Category("Line"), Description("투명도 255까지")> _
    Property LineOpacity As Integer
        Get
            Return _LineOpacity
        End Get
        Set(value As Integer)
            If Not _LineOpacity.Equals(value) Then
                If value > 255 Then
                    _LineOpacity = 255
                Else
                    _LineOpacity = value
                End If
                Me.Invalidate()
            End If


        End Set
    End Property
    Private _LinePenStyle As DashStyle = DashStyle.Dash
    <Category("Line")> _
    Property LinePenStyle As DashStyle
        Get
            Return _LinePenStyle
        End Get
        Set(value As DashStyle)
            If Not _LinePenStyle.Equals(value) Then
                _LinePenStyle = value
                If _LinePattern Is Nothing OrElse _LinePattern.Length = 0 Then
                    _LinePattern = New Single() {10, 10}
                End If
                Me.Invalidate()
            End If

        End Set
    End Property
    Private _LinePattern As Single()

    <Category("Line")> _
    Property LinePattern As Single()
        Get
            Return _LinePattern
        End Get
        Set(value As Single())
            If Not _LinePattern.Equals(value) Then
                _LinePattern = value
                Me.Invalidate()
            End If

        End Set
    End Property
    Private Sub DrawLinesCirclePoint(ByVal Gr As Graphics, ByVal BaseRect As Rectangle, ByVal ItmCount As Integer)



        Dim RotateMatr As New Drawing2D.Matrix
        RotateMatr.RotateAt(360 / ItmCount, New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top + (BaseRect.Height / 2)))
        Dim DashPen As New Pen(Color.FromArgb(_LineOpacity, _LineColor.R, _LineColor.G, _LineColor.B))
        If _LinePenStyle <> DashStyle.Solid Then
            DashPen.DashStyle = _LinePenStyle
            DashPen.DashPattern = _LinePattern
        End If




        Dim LinePath As New Drawing2D.GraphicsPath
        LinePath.AddLine(New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top), New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top + (BaseRect.Height / 2)))



        For i As Integer = 0 To ItmCount - 1
            'Gr.DrawPath(DashPen, LinePath)
            LinePath.Transform(RotateMatr)
            Gr.DrawPath(DashPen, LinePath)
        Next

    End Sub

    Private Sub DrawLinesCircleChart(ByVal Gr As Graphics, ByVal BaseRect As Rectangle)

        If _items.Count <= 1 Then Return
        Dim incDegree As Single = 360 / _items.Count

        Dim RotateMatr As New Drawing2D.Matrix
        RotateMatr.RotateAt(incDegree, New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top + (BaseRect.Height / 2)))
        Dim DashPen As New Pen(Color.FromArgb(_LineOpacity, _LineColor.R, _LineColor.G, _LineColor.B))
        If _LinePenStyle <> DashStyle.Solid Then
            DashPen.DashStyle = _LinePenStyle
            DashPen.DashPattern = New Single() {10, 10} ' _LinePattern
        End If



        Dim LinePath As New Drawing2D.GraphicsPath
        LinePath.AddLine(New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top), New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top + BaseRect.Height / 2))
        For i As Integer = 0 To _items.Count - 1
            LinePath.Transform(RotateMatr)
            Gr.DrawPath(DashPen, LinePath)
        Next

    End Sub
#End Region

#Region "item"

    Private _items As New itemsCollection(Me)

    <Category("Item"), _
  Description("레이더 내부 포인트 관련"), _
  DesignerSerializationVisibility(DesignerSerializationVisibility.Content), _
  Editor(GetType(System.ComponentModel.Design.CollectionEditor), GetType(Drawing.Design.UITypeEditor))> _
    ReadOnly Property items() As itemsCollection
        Get
            Return _items
        End Get
    End Property

    Private _ItemReverse As Boolean = False
    <Category("item")> _
    <Description("아이템 역순으로 표시 True 일 경우 100이 크게 그려짐.")> _
    Property ItemReverse As Boolean
        Get
            Return _ItemReverse
        End Get
        Set(value As Boolean)
            If Not _ItemReverse.Equals(value) Then
                _ItemReverse = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private Sub DrawItemsCirclePoint(ByVal pGr As Graphics, ByVal BaseRect As Rectangle, ByVal RaiderItems As itemsCollection)

        For i As Integer = 0 To RaiderItems.Count - 1

            Dim ptItm As RaiderItem = RaiderItems.Item(i)
            Dim ScValue As Single = 0
            If UseSpinRaider = True Then
                ' Raider 계산공식은 추후에 
                RaiderItems.Item(i).IncBeforeBalue(1)
                ptItm = RaiderItems.Item(i)
                ScValue = IIf(ptItm.BefValue = 0, 1, ptItm.BefValue) / 100
            ElseIf UseWave = True Then
                RaiderItems.Item(i).IncBeforeBalue(1)
                ptItm = RaiderItems.Item(i)
                ScValue = IIf(ptItm.BefValue = 0, 1, ptItm.BefValue) / 100

            Else
                ScValue = IIf(ptItm.Value = 0, 1, ptItm.Value) / 100
            End If

            ' Reverse 
            If _ItemReverse = True Then
                ScValue = 1 - ScValue
            End If



            Dim circleRect As New Rectangle(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2 - (ScValue * (BaseRect.Height / 2)), 16, 16)
            circleRect.Offset(New Point(-8, -8))
            Dim CirclePath As New Drawing2D.GraphicsPath()
            CirclePath.AddEllipse(circleRect)
            Dim Rot As New Drawing2D.Matrix()
            Rot.RotateAt((360 / RaiderItems.Count) * i, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2))

            CirclePath.Transform(Rot)


            Dim GraBrush As New Drawing2D.PathGradientBrush(CirclePath)
            GraBrush.CenterPoint = New Point(CirclePath.GetBounds.X + CirclePath.GetBounds.Width / 2, CirclePath.GetBounds.Y + CirclePath.GetBounds.Height / 2)
            If _UseRange = True Then
                For Each tmpRage As RaiderRangeitem In _Ranges
                    ' Reverse 
                    If _ItemReverse = True Then
                        If tmpRage.StartValue / 100 < 1 - ScValue AndAlso tmpRage.EndValue / 100 >= 1 - ScValue Then
                            GraBrush.CenterColor = Color.FromArgb(tmpRage.OpacityIn, tmpRage.GraColorin.R, tmpRage.GraColorin.G, tmpRage.GraColorin.B)
                            GraBrush.SurroundColors = New Color() {Color.FromArgb(tmpRage.OpacityOut, tmpRage.GraColorOut.R, tmpRage.GraColorOut.G, tmpRage.GraColorOut.B)} '{Clr}
                            Exit For
                        End If
                    Else
                        If tmpRage.StartValue / 100 < ScValue AndAlso tmpRage.EndValue / 100 >= ScValue Then
                            GraBrush.CenterColor = Color.FromArgb(tmpRage.OpacityIn, tmpRage.GraColorin.R, tmpRage.GraColorin.G, tmpRage.GraColorin.B)
                            GraBrush.SurroundColors = New Color() {Color.FromArgb(tmpRage.OpacityOut, tmpRage.GraColorOut.R, tmpRage.GraColorOut.G, tmpRage.GraColorOut.B)} '{Clr}
                            Exit For
                        End If
                    End If

                Next



            Else

                GraBrush.CenterColor = Color.FromArgb(ptItm.OpacityIn, ptItm.GraColorin.R, ptItm.GraColorin.G, ptItm.GraColorin.B)
                GraBrush.SurroundColors = New Color() {Color.FromArgb(ptItm.OpacityOut, ptItm.GraColorOut.R, ptItm.GraColorOut.G, ptItm.GraColorOut.B)} '{Clr}
            End If


            pGr.FillPath(GraBrush, CirclePath)

            pGr.DrawString(ptItm.Text, MyBase.Font, New SolidBrush(Color.WhiteSmoke), CirclePath.GetLastPoint)
        Next
        'For i As Integer = 0 To RaiderItems.Count - 1

        '    Dim ptItm As RaiderItem = RaiderItems.Item(i)
        '    Dim circleRect As New Rectangle(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2 - (ptItm.Value / 100 * (BaseRect.Height / 2)), 16, 16)
        '    circleRect.Offset(New Point(-8, -8))
        '    Dim CirclePath As New Drawing2D.GraphicsPath()
        '    CirclePath.AddEllipse(circleRect)
        '    Dim Rot As New Drawing2D.Matrix()
        '    Rot.RotateAt(i * 45, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2))

        '    CirclePath.Transform(Rot)


        '    Dim GraBrush As New Drawing2D.PathGradientBrush(CirclePath)
        '    GraBrush.CenterPoint = New Point(CirclePath.GetBounds.X + CirclePath.GetBounds.Width / 2, CirclePath.GetBounds.Y + CirclePath.GetBounds.Height / 2)
        '    If _UseRange = True Then
        '        For Each tmpRage As RaiderRangeitem In _Ranges
        '            If tmpRage.StartValue <= ptItm.Value AndAlso tmpRage.EndValue > ptItm.Value Then
        '                GraBrush.CenterColor = Color.FromArgb(tmpRage.OpacityIn, tmpRage.GraColorin.R, tmpRage.GraColorin.G, tmpRage.GraColorin.B)
        '                GraBrush.SurroundColors = New Color() {Color.FromArgb(tmpRage.OpacityOut, tmpRage.GraColorOut.R, tmpRage.GraColorOut.G, tmpRage.GraColorOut.B)} '{Clr}
        '                Exit For
        '            End If
        '        Next

        '    Else

        '        GraBrush.CenterColor = Color.FromArgb(ptItm.OpacityIn, ptItm.GraColorin.R, ptItm.GraColorin.G, ptItm.GraColorin.B)
        '        GraBrush.SurroundColors = New Color() {Color.FromArgb(ptItm.OpacityOut, ptItm.GraColorOut.R, ptItm.GraColorOut.G, ptItm.GraColorOut.B)} '{Clr}
        '    End If


        '    pGr.FillPath(GraBrush, CirclePath)

        '    pGr.DrawString(ptItm.Text, MyBase.Font, New SolidBrush(Color.WhiteSmoke), CirclePath.GetLastPoint)
        'Next
    End Sub

    Private Sub DrawItemsCircleChart(ByVal pGr As Graphics, ByVal BaseRect As Rectangle, ByVal RaiderItems As itemsCollection)

        Dim incDegree As Single = 360 / RaiderItems.Count
        For i As Integer = 0 To RaiderItems.Count - 1
            Dim WorkRect As Rectangle = BaseRect
            Dim ptItm As RaiderItem = RaiderItems.Item(i)
            Dim ScValue As Single = 0
            If UseSpinRaider = True Then
                ' Raider 계산공식은 추후에 
                RaiderItems.Item(i).IncBeforeBalue(1)
                ptItm = RaiderItems.Item(i)
                ScValue = IIf(ptItm.BefValue = 0, 1, ptItm.BefValue) / 100
            ElseIf UseWave = True Then
                RaiderItems.Item(i).IncBeforeBalue(1)
                ptItm = RaiderItems.Item(i)
                ScValue = IIf(ptItm.BefValue = 0, 1, ptItm.BefValue) / 100

            Else
                ScValue = IIf(ptItm.Value = 0, 1, ptItm.Value) / 100
            End If

            If _ItemReverse = True Then
                WorkRect.Inflate(CInt((WorkRect.Height / 2 * (ScValue)) * -1), CInt((WorkRect.Height / 2 * (ScValue)) * -1))
            Else
                WorkRect.Inflate(CInt((WorkRect.Height / 2 * (1 - ScValue)) * -1), CInt((WorkRect.Height / 2 * (1 - ScValue)) * -1))
            End If




            'Dim txtPath As New GraphicsPath

            Dim EffectPath As New Drawing2D.GraphicsPath

            If incDegree = 360 Then
                EffectPath.AddEllipse(WorkRect)
                'txtPath.AddString(ptItm.Text, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2 - MyBase.Font.Height), StringFormat.GenericDefault)
            Else
                EffectPath.AddLine(New Point(WorkRect.Left + (WorkRect.Width / 2), WorkRect.Top + (WorkRect.Height / 2)), New Point(WorkRect.Left + (WorkRect.Width / 2), WorkRect.Top + 1))
                EffectPath.AddArc(WorkRect, 270, incDegree)
                'txtPath.AddString(ptItm.Text, MyBase.Font.FontFamily, MyBase.Font.Style, MyBase.Font.Size, New Point(BaseRect.Left + BaseRect.Width / 2 + (BaseRect.Width / 2) / 3, BaseRect.Top + BaseRect.Height / 2 - MyBase.Font.Height / 2D), StringFormat.GenericDefault)
                'Dim txtTr As New Matrix
                'txtTr.RotateAt(-90 + incDegree / 2, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2))

                'txtPath.Transform(txtTr)
            End If



            EffectPath.CloseAllFigures()
            'pGr.DrawPath(New Pen(Brushes.Green, 2), EffectPath)

            Dim tr As New Drawing2D.Matrix
            'tr.Translate(1, -1)
            'EffectPath.Transform(tr)
            'tr.Reset()

            tr.RotateAt(i * incDegree, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2))
            EffectPath.Transform(tr)
            'txtPath.Transform(tr)



            Dim GraBrush As New Drawing2D.PathGradientBrush(EffectPath)
            Dim tmpPen As New Pen(MyBase.BackColor)

            GraBrush.CenterPoint = New Point(WorkRect.Width / 2, WorkRect.Height / 2)
            If _UseRange = True Then
                For Each tmpRage As RaiderRangeitem In _Ranges

                    If tmpRage.StartValue / 100 < ScValue AndAlso tmpRage.EndValue / 100 >= ScValue Then
                        GraBrush.CenterColor = Color.FromArgb(tmpRage.OpacityIn, tmpRage.GraColorin.R, tmpRage.GraColorin.G, tmpRage.GraColorin.B)
                        GraBrush.SurroundColors = New Color() {Color.FromArgb(tmpRage.OpacityOut, tmpRage.GraColorOut.R, tmpRage.GraColorOut.G, tmpRage.GraColorOut.B)} '{Clr}
                        tmpPen = New Pen(tmpRage.GraColorOut)
                        Exit For
                    End If


                Next

            Else

                GraBrush.CenterColor = Color.FromArgb(ptItm.OpacityIn, ptItm.GraColorin.R, ptItm.GraColorin.G, ptItm.GraColorin.B)
                GraBrush.SurroundColors = New Color() {Color.FromArgb(ptItm.OpacityOut, ptItm.GraColorOut.R, ptItm.GraColorOut.G, ptItm.GraColorOut.B)} '{Clr}
                tmpPen = New Pen(ptItm.GraColorOut)
            End If
            'Dim GraBrush As New Drawing2D.LinearGradientBrush(EffectPath.PathPoints(1), EffectPath.GetLastPoint, Color.FromArgb(_AniOpacityOut, _AniColorOut.R, _AniColorOut.G, _AniColorOut.B), Color.FromArgb(_AniOpacityIn, _AniColorIn.R, _AniColorIn.G, _AniColorIn.B))
            pGr.FillPath(GraBrush, EffectPath)
            pGr.DrawPath(tmpPen, EffectPath)



            ' String 


            'Dim txtPt As New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height * 1 / 5)
            'Dim txtPt As New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height * 1 / 9)
            Dim txtPt As Point
            If i = 0 Then
                txtPt = New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height * 1 / 24)
            ElseIf i = (RaiderItems.Count / 2 - 1) Then
                txtPt = New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height * 1 / 8)
            Else
                txtPt = New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height * 1 / 12)
            End If
            Dim CentPt As New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2)
            pGr.DrawRectangle(New Pen(Brushes.Green), New Rectangle(CentPt.X, CentPt.Y, 2, 2))
            Dim dblCos As Double = Math.Cos((incDegree / 2 + (incDegree * i)) * Math.PI / 180)
            Dim dblSin As Double = Math.Sin((incDegree / 2 + (incDegree * i)) * Math.PI / 180)
            txtPt = New Point(dblCos * (txtPt.X - CentPt.X) - dblSin * (txtPt.Y - CentPt.Y) + CentPt.X, _
                                    dblSin * (txtPt.X - CentPt.X) + dblCos * (txtPt.Y - CentPt.Y) + CentPt.Y)
            txtPt.Offset(-1 * (pGr.MeasureString(ptItm.Text, MyBase.Font).Width) / 2, 0)

            pGr.DrawString(ptItm.Text, MyBase.Font, New SolidBrush(MyBase.ForeColor), txtPt)
        Next
    End Sub




#End Region

#Region "Circle"


    Private _Areas As New AreaCollection(Me)

    <Category("Circle"), _
  Description("원 설정"), _
  DesignerSerializationVisibility(DesignerSerializationVisibility.Content), _
  Editor(GetType(System.ComponentModel.Design.CollectionEditor), GetType(Drawing.Design.UITypeEditor))> _
    ReadOnly Property Areas() As AreaCollection
        Get
            Return _Areas
        End Get
    End Property


    Private Sub DrawAreas(ByVal Gr As Graphics, ByVal BaseRect As Rectangle, ByVal AreaItems As AreaCollection)





        If (_Style And RaiderStyle.CircleChart) Or (_Style And RaiderStyle.CirclePoint) Then
            For Each tmpAreaitm As Areaitem In AreaItems
                Dim AreaRect As New Rectangle(BaseRect.Left + (BaseRect.Width - BaseRect.Width * tmpAreaitm.Value / 100) / 2 _
                                   , BaseRect.Top + (BaseRect.Height - BaseRect.Height * tmpAreaitm.Value / 100) / 2 _
                                   , BaseRect.Width * tmpAreaitm.Value / 100 _
                                   , BaseRect.Height * tmpAreaitm.Value / 100)
                If tmpAreaitm.ColorGraUse = True Then

                    Dim CirclePath As New Drawing2D.GraphicsPath()
                    CirclePath.AddEllipse(AreaRect)

                    Dim GraBrush As New Drawing2D.PathGradientBrush(CirclePath)
                    GraBrush.CenterPoint = New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2)
                    GraBrush.CenterColor = Color.FromArgb(tmpAreaitm.OpacityIn, tmpAreaitm.ColorGraIn.R, tmpAreaitm.ColorGraIn.G, tmpAreaitm.ColorGraIn.B)
                    GraBrush.SurroundColors = New Color() {Color.FromArgb(tmpAreaitm.OpacityOut, tmpAreaitm.ColorGraOut.R, tmpAreaitm.ColorGraOut.G, tmpAreaitm.ColorGraOut.B)}
                    Gr.FillEllipse(GraBrush, AreaRect)
                End If
                Dim DashPen As New Pen(Color.FromArgb(tmpAreaitm.LineOpacity, tmpAreaitm.Line.R, tmpAreaitm.Line.G, tmpAreaitm.Line.B), tmpAreaitm.LineWidth)
                If tmpAreaitm.LinePenStyle <> DashStyle.Solid Then
                    DashPen.DashStyle = tmpAreaitm.LinePenStyle
                    DashPen.DashPattern = tmpAreaitm.LinePattern
                End If

                Gr.DrawEllipse(DashPen, AreaRect)
            Next
        Else
            For Each tmpAreaitm As Areaitem In AreaItems

                Dim AreaRect As New Rectangle(BaseRect.Left, BaseRect.Top, BaseRect.Width * tmpAreaitm.Value / 100, BaseRect.Height)
                If tmpAreaitm.ColorGraUse = True Then
                    Dim GraBrush As New Drawing2D.LinearGradientBrush(New Point(BaseRect.Left, BaseRect.Top + BaseRect.Height / 2) _
                                                                      , New Point(BaseRect.Left + BaseRect.Width, BaseRect.Top + BaseRect.Height / 2) _
                                                                      , Color.FromArgb(tmpAreaitm.OpacityIn, tmpAreaitm.ColorGraIn.R, tmpAreaitm.ColorGraIn.G, tmpAreaitm.ColorGraIn.B) _
                                                                      , Color.FromArgb(tmpAreaitm.OpacityOut, tmpAreaitm.ColorGraOut.R, tmpAreaitm.ColorGraOut.G, tmpAreaitm.ColorGraOut.B))
                    Gr.FillRectangle(GraBrush, AreaRect)
                End If

                Gr.DrawLine(New Pen(Color.FromArgb(tmpAreaitm.LineOpacity, tmpAreaitm.Line.R, tmpAreaitm.Line.G, tmpAreaitm.Line.B)), New Point(BaseRect.Left + BaseRect.Width, BaseRect.Top), New Point(BaseRect.Left + BaseRect.Width, BaseRect.Top + BaseRect.Height))
            Next
        End If

    End Sub


#End Region

#Region "Animation"
    Private _AniColorIn As Color = Color.DarkGray
    <Category("Animation"), Description("레이더 그라 안쪽 색상")> _
    Property AniColorin As Color
        Get
            Return _AniColorIn
        End Get
        Set(value As Color)
            If Not _AniColorIn.Equals(value) Then
                _AniColorIn = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _AniOpacityIn As Integer = 128
    <Category("Animation"), Description("레이더 그라 안쪽 투명도")> _
    Property AniOpacityIn As Integer
        Get
            Return _AniOpacityIn
        End Get
        Set(value As Integer)
            If Not _AniOpacityIn.Equals(value) Then
                _AniOpacityIn = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _AniColorOut As Color = Color.White
    <Category("Animation"), Description("레이더 그라 바깥쪽 색상")> _
    Property AniColorOut As Color
        Get
            Return _AniColorOut
        End Get
        Set(value As Color)
            If Not _AniColorOut.Equals(value) Then
                _AniColorOut = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _AniOpacityOut As Integer = 128
    <Category("Animation"), Description("레이더 그라 바깥쪽 투명도")> _
    Property AniOpacityOut As Integer
        Get
            Return _AniOpacityOut
        End Get
        Set(value As Integer)
            If Not _AniOpacityOut.Equals(value) Then
                _AniOpacityOut = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _UseAnimation As Boolean = True
    <Category("Animation"), Description("Animation 사용여부")> _
    Property UseAnimation As Boolean
        Get
            Return _UseAnimation
        End Get
        Set(value As Boolean)
            If Not _UseAnimation.Equals(value) Then
                _UseAnimation = value
                Me.Invalidate()
            End If
        End Set
    End Property




#Region "Spin Animation"


    Private WithEvents TmSpin As New Timer
    Private _Spininterval As Integer = 3000
    Private _SpinIncreageDegree As Single = 3.6
    Private _UseSpinRaider As Boolean = True

    Private Sub InitSpinAnimation()
        TmSpin.Interval = _Spininterval / (360 / _SpinIncreageDegree)

        If _UseSpinRaider = True Then
            TmSpin.Enabled = True
        Else
            TmSpin.Enabled = False
        End If
    End Sub
    <Category("Animation"), Description("돌아가는 레이더 형태")> _
    Property UseSpinRaider As Boolean
        Get
            Return _UseSpinRaider
        End Get
        Set(value As Boolean)
            If Not _UseSpinRaider.Equals(value) Then
                UseWave = False
                _UseSpinRaider = value
                InitSpinAnimation()
            End If

        End Set
    End Property
    <Category("Animation"), Description("레이더 주기")> _
    Property Spininterval As Integer
        Get
            Return _Spininterval
        End Get
        Set(value As Integer)

            If Not _Spininterval.Equals(value) Then
                If value < 3000 Then
                    _Spininterval = 3000
                Else
                    _Spininterval = value
                End If

                InitSpinAnimation()

            End If




        End Set
    End Property
    <Category("Animation"), Description("레이더 회전 각도")> _
    Property SpinIncreageDegree As Single
        Get
            Return _SpinIncreageDegree
        End Get
        Set(value As Single)
            If Not _SpinIncreageDegree.Equals(value) Then
                _SpinIncreageDegree = value
                InitSpinAnimation()
            End If
        End Set
    End Property




    Private _Angle As Single = 0.0
    <STAThread> _
    Private Sub TmSpin_Tick(sender As Object, e As EventArgs) Handles TmSpin.Tick

        _Angle += CSng(3.6)
        If _Angle >= 360 Then
            _Angle = 0
        End If
        Me.Invalidate()

    End Sub


    Private Sub DrawEffectRotate(ByVal Gr As Graphics, ByVal BaseRect As Rectangle, ByVal Degree As Integer)

        Dim EffectPath As New Drawing2D.GraphicsPath

        EffectPath.AddLine(New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top + (BaseRect.Height / 2)), New Point(BaseRect.Left + (BaseRect.Width / 2), 0))
        EffectPath.AddArc(New Rectangle(BaseRect.Left, BaseRect.Top, BaseRect.Width, BaseRect.Height), 270, 45)
        EffectPath.CloseFigure()




        Dim tr As New Drawing2D.Matrix

        tr.RotateAt(Degree, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2))
        EffectPath.Transform(tr)

        'Dim GraBrush As New Drawing2D.PathGradientBrush(EffectPath)

        'GraBrush.CenterPoint = New Point(MyBase.Width / 2, MyBase.Height / 2)
        ' GraBrush.CenterColor = Color.FromArgb(_AniOpacityIn, _AniColorIn.R, _AniColorIn.G, _AniColorIn.B)
        'GraBrush.SurroundColors = New Color() {Color.FromArgb(_AniOpacityOut, _AniColorOut.R, _AniColorOut.G, _AniColorOut.B)}
        Dim GraBrush As New Drawing2D.LinearGradientBrush(EffectPath.PathPoints(1), EffectPath.GetLastPoint, Color.FromArgb(_AniOpacityOut, _AniColorOut.R, _AniColorOut.G, _AniColorOut.B), Color.FromArgb(_AniOpacityIn, _AniColorIn.R, _AniColorIn.G, _AniColorIn.B))


        Gr.FillPath(GraBrush, EffectPath)

        'If Degree Mod 45 = 0 Then
        '    Dim LPath As New Drawing2D.GraphicsPath
        '    LPath.AddLine(New Point(BaseRect.Left + (BaseRect.Width / 2), BaseRect.Top + (BaseRect.Height / 2)), New Point(BaseRect.Left + (BaseRect.Width / 2), 0))
        '    If Not Degree.Equals(315) Then
        '        Dim tmpTr As New Drawing2D.Matrix
        '        tmpTr.RotateAt(Degree + 45, New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2))
        '        LPath.Transform(tmpTr)
        '    End If

        '    Gr.DrawPath(New Pen(Brushes.White, 2), LPath)


        'End If




    End Sub




#End Region

#Region "Wave Animation"



    Private _UseWave As Boolean = False
    <Category("Animation"), Description("퍼지는 레이더 형태")> _
    Property UseWave As Boolean
        Get
            Return _UseWave
        End Get
        Set(value As Boolean)
            If Not _UseWave.Equals(value) Then
                UseSpinRaider = False
                _UseWave = value
                InitWaveAnimation()

            End If

        End Set
    End Property

    Private WithEvents TmWave As New System.Timers.Timer





    Private Sub InitWaveAnimation()

        TmWave.Interval = _WaveInterval / _WaveIncreageCount
        If _UseWave = True Then
            TmWave.Enabled = True
        Else
            TmWave.Enabled = False
        End If
    End Sub





    Private _WaveInterval As Integer = 3000
    <Category("Animation"), Description("레이더 주기")> _
    Property WaveInterval As Integer
        Get
            Return _WaveInterval
        End Get
        Set(value As Integer)
            If Not _WaveInterval.Equals(value) Then
                If value < 3000 Then
                    _WaveInterval = 3000
                Else
                    _WaveInterval = value
                End If
                InitWaveAnimation()

            End If



        End Set
    End Property
    Private _WaveIncreageCount As Integer = 50
    <Category("Animation"), Description("지정된 주기당 그려지는 숫자(Frame)")> _
    Property WaveIncreageCount As Integer
        Get
            Return _WaveIncreageCount
        End Get
        Set(value As Integer)
            If Not _WaveIncreageCount.Equals(value) Then
                _WaveIncreageCount = value
                InitWaveAnimation()
            End If
        End Set
    End Property
    Private _Width As Integer = 1


#End Region


    Private Sub DrawEffectCircle(ByVal Gr As Graphics, ByVal BaseRect As Rectangle, ByVal EffectWidth As Integer)

        Dim EffectRect As New Rectangle(BaseRect.Left + (BaseRect.Width - EffectWidth) / 2, BaseRect.Top + (BaseRect.Height - EffectWidth) / 2, EffectWidth, EffectWidth)
        Dim EffectPath As New Drawing2D.GraphicsPath

        EffectPath.AddEllipse(EffectRect)

        Dim GraBrush As New Drawing2D.PathGradientBrush(EffectPath)
        GraBrush.CenterPoint = New Point(BaseRect.Left + BaseRect.Width / 2, BaseRect.Top + BaseRect.Height / 2)
        GraBrush.CenterColor = Color.FromArgb(_AniOpacityIn, _AniColorIn.R, _AniColorIn.G, _AniColorIn.B)
        GraBrush.SurroundColors = New Color() {Color.FromArgb(_AniOpacityOut, _AniColorOut.R, _AniColorOut.G, _AniColorOut.B)}
        Gr.FillEllipse(GraBrush, EffectRect)


    End Sub

#End Region

#Region "Range"
    Private _UseRange As Boolean = True
    <Category("Range")> _
    Property UseRange As Boolean
        Get
            Return _UseRange
        End Get
        Set(value As Boolean)
            If Not _UseRange.Equals(value) Then
                _UseRange = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _Ranges As New RaiderRangeCollection(Me)
    <Category("Range")> _
<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    <Editor(GetType(System.ComponentModel.Design.CollectionEditor), GetType(Drawing.Design.UITypeEditor))> _
    ReadOnly Property Ranges As RaiderRangeCollection
        Get
            Return _Ranges
        End Get
    End Property

#End Region




    ' Design Time 관련 Property Enable , Disabled 
    Private Sub PropertyReadonly(ByVal Component As Object, ByVal PropertyName As String, ByVal isReadOnly As Boolean)
        ' PropertyReadonly(Me, "BackColor", True)
        Dim desc As PropertyDescriptor = TypeDescriptor.GetProperties(Component.GetType())(PropertyName)
        Dim attrib As ReadOnlyAttribute = desc.Attributes(GetType(ReadOnlyAttribute))
        Dim fldinfo As System.Reflection.FieldInfo = attrib.GetType().GetField("isReadOnly", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        fldinfo.SetValue(attrib, isReadOnly)

    End Sub



    Private Sub TmWave_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmWave.Elapsed
        _Width += MyBase.Width / _WaveIncreageCount
        Dim MaxValue As Integer = IIf(MyBase.Width > MyBase.Height, MyBase.Height, MyBase.Width)


        If _Width >= MaxValue Then


            _Width = 1

        End If


        Me.Invalidate()
    End Sub


    ''' <summary> 
    ''' Find the point on the circumference of a circle 
    ''' </summary> 
    ''' <param name="radius">The radius of the circle</param> 
    ''' <param name="angleInDegrees">The angle of the point to origin</param> 
    ''' <param name="origin">The origin of the circle</param> 
    ''' <returns>Return the point</returns> 
    Private Function PointOnCircle(radius As Single, angleInDegrees As Single, origin As PointF) As PointF
        'Find the x and y using the parametric equation for a circle 
        Dim x As Single = CSng(radius * Math.Cos((angleInDegrees - 90.0F) * Math.PI / 180.0F)) + origin.X
        Dim y As Single = CSng(radius * Math.Sin((angleInDegrees - 90.0F) * Math.PI / 180.0F)) + origin.Y

        'Note : The "- 90f" is only for the proper rotation of the clock. 
        '             * It is not part of the parament equation for a circle 


        'Return the point 
        Return New PointF(x, y)
    End Function

End Class
