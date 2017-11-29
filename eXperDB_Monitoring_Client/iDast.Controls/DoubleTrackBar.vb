Imports System.ComponentModel

Public Class DoubleTrackBarDraw
    Inherits Control

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.Selectable, True)
        Me.SetStyle(ControlStyles.StandardClick, True)
    End Sub

#Region "Common"
    Private _LRPadding As Integer = 10
    <Category("Common")> _
    <Description("컨트롤 좌 우 간격설정")> _
    <DefaultValue(10)> _
    Public Property LRPadding As Integer
        Get
            Return _LRPadding
        End Get
        Set(value As Integer)
            If Not _LRPadding.Equals(value) Then
                _LRPadding = value
                Me.Invalidate()
            End If
        End Set
    End Property
#End Region

#Region "Track"
    Private _TrackColor1 As Color = Color.Lime
    <Category("TRACK")> _
    <Description("첫번째 색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "Lime")> _
    Public Property TrackColor1 As Color
        Get
            Return _TrackColor1
        End Get
        Set(value As Color)
            If Not _TrackColor1.Equals(value) Then
                _TrackColor1 = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackColor2 As Color = Color.Yellow
    <Category("TRACK")> _
    <Description("두번째 색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "Yellow")> _
    Public Property TrackColor2 As Color
        Get
            Return _TrackColor2
        End Get
        Set(value As Color)
            If Not _TrackColor2.Equals(value) Then
                _TrackColor2 = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackColor3 As Color = Color.Red
    <Category("TRACK")> _
    <Description("세번째 색상")> _
     <DefaultValue(GetType(System.Drawing.Color), "Red")> _
    Public Property TrackColor3 As Color
        Get
            Return _TrackColor3
        End Get
        Set(value As Color)
            If Not _TrackColor3.Equals(value) Then
                _TrackColor3 = value
                Me.Invalidate()

            End If

        End Set
    End Property

    Private _TrackHeight As Integer = 5
    <Category("TRACK")> _
    <Description("Track 높이 설정")> _
    <DefaultValue(5)> _
    Public Property TrackHeight As Integer
        Get
            Return _TrackHeight
        End Get
        Set(value As Integer)
            If Not _TrackHeight.Equals(value) Then
                _TrackHeight = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackBorderColor As Color = Color.Gray
    <Category("TRACK")> _
    <Description("Track 테두리 선 색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "Gray")> _
    Public Property TrackBorderColor As Color
        Get
            Return _TrackBorderColor
        End Get
        Set(value As Color)
            If Not _TrackBorderColor.Equals(value) Then
                _TrackBorderColor = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _YPosition As Integer = -1
    <Category("TRACK")> _
    <Description("컨트롤 내부 Track 위치 -1 로 설정시 컨트롤 중앙 자동 배치")> _
    <DefaultValue(-1)> _
    Public Property YPosition As Integer
        Get
            Return _YPosition
        End Get
        Set(value As Integer)
            If Not _YPosition.Equals(value) Then
                _YPosition = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackMinValue As Integer = 0
    <Category("Common")> _
    <Description("최소 표현 값")> _
    <DefaultValue(0)> _
    Property TrackMinValue As Integer
        Get
            Return _TrackMinValue
        End Get
        Set(value As Integer)
            If Not _TrackMinValue.Equals(value) Then
                _TrackMinValue = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackMaxValue As Integer = 100
    <Category("Common")> _
    <Description("최대 표현 값")> _
    <DefaultValue(100)> _
    Property TrackMaxValue As Integer
        Get
            Return _TrackMaxValue
        End Get
        Set(value As Integer)
            If Not _TrackMaxValue.Equals(value) Then
                _TrackMaxValue = value
                Me.Invalidate()
            End If
        End Set
    End Property

#End Region

#Region "TICK"

    Private _TickSpacing As Integer = 10
    <Category("TICK")> _
    <Description("눈금 간격")> _
    <DefaultValue(10)> _
    Public Property TickSpacing As Integer
        Get
            Return _TickSpacing
        End Get
        Set(value As Integer)
            If Not _TickSpacing.Equals(value) Then
                _TickSpacing = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TickColor As Color = Color.Gray
    <Category("TICK")> _
    <Description("눈금 색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "Gray")> _
    Public Property TickColor As Color
        Get
            Return _TickColor
        End Get
        Set(value As Color)
            If Not _TickColor.Equals(value) Then
                _TickColor = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TickWidth As Integer = 2
    <Category("TICK")> _
    <Description("눈금두께")> _
    <DefaultValue(2)> _
    Public Property TickWidth As Integer
        Get
            Return _TickWidth
        End Get
        Set(value As Integer)
            If Not _TickWidth.Equals(value) Then
                _TickWidth = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TickHeight As Integer = 5
    <Category("TICK")> _
    <Description("눈금높이")> _
    <DefaultValue(5)> _
    Public Property TickHeight As Integer
        Get
            Return _TickHeight
        End Get
        Set(value As Integer)
            If Not _TickHeight.Equals(value) Then
                _TickHeight = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackToTickDistance As Integer = 10
    <Category("TICK")> _
    <Description("Track 바닥과 눈금의 간격 거리 - 로 입력시 상단으로 가게 됨.")> _
    <DefaultValue(10)> _
    Public Property TrackToTickInterval As Integer
        Get
            Return _TrackToTickDistance
        End Get
        Set(value As Integer)
            If Not _TrackToTickDistance.Equals(value) Then
                _TrackToTickDistance = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _ShowTick As Boolean = True
    <Category("TICK")> _
    <Description("눈금 표시 여부")> _
    <DefaultValue(True)> _
    Public Property ShowTick As Boolean
        Get
            Return _ShowTick
        End Get
        Set(value As Boolean)
            If Not _ShowTick.Equals(value) Then
                _ShowTick = value
                Me.Invalidate()
            End If
        End Set
    End Property

#End Region

#Region "Caption"
    Private _ShowCaption As Boolean = True
    <Category("CAPTION")> _
    <Description("캡션 보이기")> _
    <DefaultValue(True)> _
    Public Property ShowCaption As Boolean
        Get
            Return _ShowCaption
        End Get
        Set(value As Boolean)
            If Not _ShowCaption.Equals(value) Then
                _ShowCaption = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TrackToCaptionDistance As Integer = 20
    <Category("CAPTION")> _
    <Description("Track 과 Caption 의 간격 -로 입력시 위로 올라감 ")> _
    <DefaultValue(20)> _
    Public Property TrackToCaptionDistance As Integer
        Get
            Return _TrackToCaptionDistance
        End Get
        Set(value As Integer)
            If Not _TrackToCaptionDistance.Equals(value) Then
                _TrackToCaptionDistance = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _CaptionSpacing As Integer = 5
    <Category("CAPTION")> _
    <Description("캡션 간격")> _
    <DefaultValue(5)> _
    Public Property CaptionSpacing As Integer
        Get
            Return _CaptionSpacing
        End Get
        Set(value As Integer)
            If Not _CaptionSpacing.Equals(value) Then
                _CaptionSpacing = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _ValueToCaption As Boolean = True
    <Category("CAPTION")> _
    <Description("Value를 값으로 표시 False로 설정시 Custom Caption을 사용할 수 있음")> _
    <DefaultValue(True)> _
    Public Property ValueToCaption As Boolean
        Get
            Return _ValueToCaption
        End Get
        Set(value As Boolean)
            If Not _ValueToCaption.Equals(value) Then
                _ValueToCaption = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _CustomCaption As String = ""
    <Category("CAPTION")> _
    <Description("사용자정의 CAPTION ValueToCaption이 False로 설정시 사용됨")> _
    <DefaultValue("")> _
    <Editor(GetType(Design.MultilineStringEditor), GetType(Drawing.Design.UITypeEditor))> _
    Public Property CustomCaption As String
        Get
            Return _CustomCaption
        End Get
        Set(value As String)
            If Not _CustomCaption.Equals(value) Then
                _CustomCaption = value
                Me.Invalidate()
            End If
        End Set
    End Property




#End Region

#Region "BAR"


    Private _BarFold As Boolean = True
    <Category("BAR")> _
    <Description("BAR 겹치는지 여부 겹치게 할 경우 SIZE가 절반으로 됨")> _
    <DefaultValue(True)> _
    Property BarFold As Boolean
        Get
            Return _BarFold
        End Get
        Set(value As Boolean)
            If Not _BarFold.Equals(value) Then
                _BarFold = value
                Me.Invalidate()
            End If
        End Set
    End Property
    Private _BarMinValue As Integer = 0

    <Category("BAR")> _
    <Description("작은쪽 VALUE")> _
    Property BarMinValue As Integer
        Get
            Return _BarMinValue
        End Get
        Set(value As Integer)
            If Not _BarMinValue.Equals(value) Then
                _BarMinValue = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _BarMaxValue As Integer = 0
    <Category("BAR")> _
    <Description("큰쪽 VALUE")> _
    Property BarMaxValue As Integer
        Get
            Return _BarMaxValue
        End Get
        Set(value As Integer)
            If Not _BarMaxValue.Equals(value) Then
                _BarMaxValue = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _BarSIze As Size = New Size(14, 15)
    <Category("BAR")> _
    <Description("BAR SIZE BARFOLD 를 True로 설정시 SIZE는 절반으로 그려짐")> _
    <DefaultValue(GetType(Size), "15,15")> _
    Public Property BarSize As Size
        Get
            Return _BarSIze
        End Get
        Set(value As Size)
            If Not _BarSIze.Equals(value) Then
                _BarSIze = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _BarVertex As Integer = 5
    <Category("BAR")> _
    <Description("BAR 삼각형 길이")> _
    <DefaultValue(5)> _
    Public Property BarVertex As Integer
        Get
            Return _BarVertex

        End Get
        Set(value As Integer)
            If Not _BarVertex.Equals(value) Then
                _BarVertex = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Public Enum enmBarDirection
        None = 0
        Bottom = 1
        Up = 2
        Both = 3
    End Enum

    Private _BarDirection As enmBarDirection = enmBarDirection.Bottom
    <Category("BAR")> _
    <Description("방향")> _
    <DefaultValue(GetType(enmBarDirection), "Bottom")> _
    Public Property BarDirection As enmBarDirection
        Get
            Return _BarDirection
        End Get
        Set(value As enmBarDirection)
            If Not _BarDirection.Equals(value) Then
                _BarDirection = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _BarColor As Color = Color.Gray
    <Category("BAR")> _
    <Description("색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "Gray")> _
    Public Property BarColor As Color
        Get
            Return _BarColor

        End Get
        Set(value As Color)
            If Not _BarColor.Equals(value) Then
                _BarColor = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _BarBorderColor As Color = Color.DarkGray
    <Category("BAR")> _
    <Description("테두리색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "DarkGray")> _
    Public Property BarBorderColor As Color
        Get
            Return _BarBorderColor
        End Get
        Set(value As Color)
            If Not _BarBorderColor.Equals(value) Then
                _BarBorderColor = value
                Me.Invalidate()

            End If
        End Set
    End Property


    Private _BarHighLight As Color = Color.AliceBlue
    <Category("BAR")> _
    <Description("선택시 색상")> _
    <DefaultValue(GetType(System.Drawing.Color), "AliceBlue")> _
    Public Property BarHighLight As Color
        Get
            Return _BarHighLight
        End Get
        Set(value As Color)
            If Not _BarHighLight.Equals(value) Then
                _BarHighLight = value
            End If
        End Set
    End Property

#End Region



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)


        sb_DrawTrack(e.Graphics)
        If _ShowTick Then
            sb_DrawTick(e.Graphics)
        End If

        If _ShowCaption Then
            sb_DrawCaption(e.Graphics)
        End If

        sb_DrawBar(e.Graphics)



    End Sub


    Private _LBarRectF As New Drawing2D.GraphicsPath
    Private _RBarRectF As New Drawing2D.GraphicsPath

    Private Sub sb_DrawBar(ByVal gr As Graphics)
        '  *=(0,0)  LT      
        '         *____      
        '         |    |     
        '      LL |  L | LR  
        '         |    |     
        '         |____|     
        '           LB       
        '
        ' *=(0,0)   RT     
        '         *____
        '         |    |
        '      RL |  R | RR 
        '         |    |
        '         |____|
        '       RB0,0 을 기준으로 작성하고 포인트로 이동한다. 

        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath

        If _BarFold Then

            Dim LbarPath As New Drawing2D.GraphicsPath
            Dim RbarPath As New Drawing2D.GraphicsPath
            ' LR
            LbarPath.AddLine(New PointF(_BarSIze.Width / 2, 0), New PointF(_BarSIze.Width / 2, _BarSIze.Height))
            ' RL
            RbarPath.AddLine(New PointF(0, 0), New PointF(0, _BarSIze.Height))
            If _BarDirection And enmBarDirection.Bottom Then
                ' LB
                LbarPath.AddLine(LbarPath.GetLastPoint, New PointF(0, _BarSIze.Height - _BarVertex))
                ' RB 
                RbarPath.AddLine(RbarPath.GetLastPoint, New PointF(_BarSIze.Width / 2, _BarSIze.Height - _BarVertex))
            Else
                ' LB 
                LbarPath.AddLine(LbarPath.GetLastPoint, New PointF(0, _BarSIze.Height))
                ' RB 
                RbarPath.AddLine(RbarPath.GetLastPoint, New PointF(_BarSIze.Width / 2, _BarSIze.Height))
            End If

            If _BarDirection And enmBarDirection.Up Then
                ' LL 
                LbarPath.AddLine(LbarPath.GetLastPoint, New PointF(0, _BarVertex))
                ' RR 
                RbarPath.AddLine(RbarPath.GetLastPoint, New PointF(_BarSIze.Width / 2, _BarVertex))
            Else
                ' LL 
                LbarPath.AddLine(LbarPath.GetLastPoint, New PointF(0, 0))
                ' RR 
                RbarPath.AddLine(RbarPath.GetLastPoint, New PointF(_BarSIze.Width / 2, 0))

            End If

            LbarPath.CloseAllFigures()
            RbarPath.CloseAllFigures()
            ' Draw Left Bar 
            Dim LTr As New Drawing2D.Matrix
            Dim LPt As PointF = GetValuePosition(_BarMinValue, LbarPath.GetBounds, enmAlignHorizon.Right, enmAlignVertical.Middle)

            LTr.Translate(LPt.X, LPt.Y)
            LbarPath.Transform(LTr)
            gr.FillPath(New SolidBrush(_BarColor), LbarPath)
            If _LbarStatus = BarStatus.HighLight Then
                gr.FillPath(New SolidBrush(Color.FromArgb(200, _BarHighLight)), LbarPath)
            End If
            gr.DrawPath(New Pen(_BarBorderColor), LbarPath)
            _LBarRectF = LbarPath

            'Draw Right Bar 
            Dim rPt As PointF = GetValuePosition(_BarMaxValue, RbarPath.GetBounds, enmAlignHorizon.Left, enmAlignVertical.Middle)
            Dim rTr As New Drawing2D.Matrix
            rTr.Translate(rPt.X, rPt.Y)
            RbarPath.Transform(rTr)
            gr.FillPath(New SolidBrush(_BarColor), RbarPath)
            If _RbarStatus = BarStatus.HighLight Then
                gr.FillPath(New SolidBrush(Color.FromArgb(200, _BarHighLight)), RbarPath)
            End If
            gr.DrawPath(New Pen(_BarBorderColor), RbarPath)
            _RBarRectF = RbarPath
        Else
            ' Common 
            Dim BasePath As New System.Drawing.Drawing2D.GraphicsPath

            If _BarDirection And enmBarDirection.Bottom Then
                BasePath.AddLine(New PointF(0, _BarSIze.Height - _BarVertex), New Point(_BarSIze.Width / 2, _BarSIze.Height))
                BasePath.AddLine(BasePath.GetLastPoint, New Point(_BarSIze.Width, _BarSIze.Height - _BarVertex))
            Else
                BasePath.AddLine(New PointF(0, _BarSIze.Height), New PointF(_BarSIze.Width, _BarSIze.Height))
            End If

            If _BarDirection And enmBarDirection.Up Then
                BasePath.AddLine(BasePath.GetLastPoint, New PointF(_BarSIze.Width, _BarVertex))
                BasePath.AddLine(BasePath.GetLastPoint, New PointF(_BarSIze.Width / 2, 0))
                BasePath.AddLine(BasePath.GetLastPoint, New PointF(0, _BarVertex))
            Else
                BasePath.AddLine(BasePath.GetLastPoint, New PointF(_BarSIze.Width, 0))
                BasePath.AddLine(BasePath.GetLastPoint, New PointF(0, 0))
            End If

            BasePath.CloseAllFigures()


            Dim LbarPath As Drawing2D.GraphicsPath = BasePath.Clone
            Dim RBarPath As Drawing2D.GraphicsPath = BasePath.Clone

            ' Draw Left Bar 
            Dim LTr As New Drawing2D.Matrix
            Dim LPt As PointF = GetValuePosition(_BarMinValue, LbarPath.GetBounds, enmAlignHorizon.Middle, enmAlignVertical.Middle)
            LTr.Translate(LPt.X, LPt.Y)
            LbarPath.Transform(LTr)
            gr.FillPath(New SolidBrush(_BarColor), LbarPath)
            If _LbarStatus = BarStatus.HighLight Then
                gr.FillPath(New SolidBrush(Color.FromArgb(128, _BarHighLight)), LbarPath)
            End If
            gr.DrawPath(New Pen(_BarBorderColor), LbarPath)
            _LBarRectF = LbarPath

            ' Draw Right Bar 

            Dim RPt As PointF = GetValuePosition(_BarMaxValue, RBarPath.GetBounds, enmAlignHorizon.Middle, enmAlignVertical.Middle)
            Dim RTr As New Drawing2D.Matrix
            RTr.Translate(RPt.X, RPt.Y)
            RBarPath.Transform(RTr)
            gr.FillPath(New SolidBrush(_BarColor), RBarPath)
            If _RbarStatus = BarStatus.HighLight Then
                gr.FillPath(New SolidBrush(Color.FromArgb(128, _BarHighLight)), RBarPath)
            End If
            gr.DrawPath(New Pen(_BarBorderColor), RBarPath)
            _RBarRectF = RBarPath
        End If


    End Sub

    Private Enum enmAlignHorizon
        Left = 0
        Middle = 1
        Right = 2
    End Enum

    Private Enum enmAlignVertical
        Top = 0
        Middle = 1
        Bottom = 2
    End Enum

    Private ReadOnly Property CalcBarWidth As Single
        Get
            Return Me.Width - (_LRPadding * 2)
        End Get
    End Property

    Private Function GetValuePosition(ByVal value As Integer, ByVal BarBounds As RectangleF, ByVal AlignHorizon As enmAlignHorizon, ByVal AlignVertical As enmAlignVertical) As PointF
        Dim BarY As Single = IIf(_YPosition < 0, (Me.Height) / 2, _YPosition + TrackHeight / 2)
        Dim Barx As Single = _LRPadding
        Dim BarWidth As Single = CalcBarWidth
        Dim SngMinValue As Single = BarWidth * (value / _TrackMaxValue)
        Dim BasePtX As Single = Barx + SngMinValue
        Dim BasePty As Single = BarY
        Dim rtnPt As New PointF(0, 0)

        Select Case AlignHorizon
            Case enmAlignHorizon.Left
                BasePtX = BasePtX
            Case enmAlignHorizon.Middle
                BasePtX -= BarBounds.Width / 2
            Case enmAlignHorizon.Right
                BasePtX -= BarBounds.Width
        End Select


        Select Case AlignVertical
            Case enmAlignVertical.Top
                BasePty = BasePty
            Case enmAlignVertical.Middle
                BasePty -= BarBounds.Height / 2
            Case enmAlignVertical.Bottom
                BasePty -= BarBounds.Height
        End Select
        rtnPt = New PointF(BasePtX, BasePty)
        Return rtnPt


    End Function


    Private Sub sb_DrawTrack(ByVal gr As Graphics)

        Dim BarWidth As Single = CalcBarWidth
        Dim BarHeight As Single = _TrackHeight
        Dim BarY As Single = IIf(_YPosition < 0, (Me.Height - _TrackHeight) / 2, _YPosition)
        Dim Barx As Single = _LRPadding
        Dim SngMinValue As Single = BarWidth * (BarMinValue / (_TrackMaxValue - _TrackMinValue))
        Dim sngMaxValue As Single = BarWidth * (BarMaxValue / (_TrackMaxValue - _TrackMinValue))
        gr.FillRectangle(New SolidBrush(_TrackColor1), Barx, BarY, SngMinValue, BarHeight)
        gr.FillRectangle(New SolidBrush(_TrackColor2), Barx + SngMinValue, BarY, sngMaxValue - SngMinValue, BarHeight)
        gr.FillRectangle(New SolidBrush(_TrackColor3), Barx + sngMaxValue, BarY, BarWidth - sngMaxValue, BarHeight)
        gr.DrawRectangle(New Pen(_TrackBorderColor), Barx, BarY, BarWidth, BarHeight)
    End Sub


    Private Sub sb_DrawTick(ByVal gr As Graphics)
        Dim stX As Single = _LRPadding - (_TickWidth / 2)
        Dim BarSpacing As Single = CalcBarWidth / (_TickSpacing)
        Dim ptY As Single = IIf(_YPosition < 0, (Me.Height - _TrackHeight) / 2, _YPosition) + _TrackHeight + _TrackToTickDistance
        For i As Integer = 0 To _TickSpacing
            gr.FillRectangle(New SolidBrush(_TickColor), stX + (BarSpacing * i), ptY, CSng(_TickWidth), CSng(_TickHeight))
        Next



    End Sub

    Private Sub sb_DrawCaption(ByVal gr As Graphics)
        Dim stX As Single = _LRPadding - (_TickWidth / 2)
        Dim BarSpacing As Single = CalcBarWidth / (_CaptionSpacing)
        Dim ptY As Single = IIf(_YPosition < 0, (Me.Height - _TrackHeight) / 2, _YPosition) + _TrackHeight + _TrackToCaptionDistance
        Dim arrCustom As String() = Split(_CustomCaption, vbCrLf)
        For i As Integer = 0 To _CaptionSpacing
            Dim strValue As String = ""
            If _ValueToCaption = True Then
                strValue = _TrackMinValue + CInt((_TrackMaxValue - _TrackMinValue) / _CaptionSpacing * i)
            Else
                If arrCustom.Length - 1 >= i Then
                    strValue = arrCustom(i).Trim
                Else
                    strValue = ""
                End If
            End If
            If strValue <> "" Then
                Dim strSz As Size = TextRenderer.MeasureText(strValue, MyBase.Font)

                TextRenderer.DrawText(gr, strValue, MyBase.Font, New Rectangle((stX + (BarSpacing * i)) - (strSz.Width / 2), ptY, strSz.Width, strSz.Height), MyBase.ForeColor)
            End If

        Next
    End Sub


    Private Enum BarStatus
        Normal = 0
        HighLight = 1
    End Enum
    Private _LbarStatus As BarStatus = BarStatus.Normal
    Private _RbarStatus As BarStatus = BarStatus.Normal
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)

        MyBase.OnMouseDown(e)




        If Not MyBase.Focused Then MyBase.Focus()

        If e.Button = Windows.Forms.MouseButtons.Left AndAlso e.Clicks = 1 Then

            If _LBarRectF.GetBounds.Contains(e.Location.X, e.Location.Y) Then
                _LbarStatus = BarStatus.HighLight

            Else
                _LbarStatus = BarStatus.Normal
            End If
            If _RBarRectF.GetBounds.Contains(e.Location.X, e.Location.Y) Then
                _RbarStatus = BarStatus.HighLight
            Else
                _RbarStatus = BarStatus.Normal
            End If
            Me.Invalidate()
        Else
            If _LbarStatus = BarStatus.HighLight Or _RbarStatus = BarStatus.HighLight Then
                _LbarStatus = BarStatus.Normal
                _RbarStatus = BarStatus.Normal
                Me.Invalidate()
            End If
        End If

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)


        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim sngTickHalfSpacing As Single = (CalcBarWidth / _TickSpacing) / 2
            If _LbarStatus = BarStatus.HighLight Then

                If _LBarRectF.GetBounds.X - sngTickHalfSpacing > e.X Then
                    _BarMinValue = CalcValue(_BarMinValue, False)
                    ' _BarMinValue -= _TickSpacing
                ElseIf _LBarRectF.GetBounds.X + sngTickHalfSpacing < e.X Then
                    _BarMinValue = CalcValue(_BarMinValue, True)
                    ' _BarMinValue += _TickSpacing
                End If
                If _BarFold = True Then
                    If _BarMinValue > _BarMaxValue Then
                        _BarMinValue = _BarMaxValue
                    End If
                Else
                    If _BarMinValue >= _BarMaxValue Then
                        _BarMinValue = CalcValue(_BarMinValue, False)
                    End If
                End If


            End If
            If _RbarStatus = BarStatus.HighLight Then
                If _RBarRectF.GetBounds.X - sngTickHalfSpacing > e.X Then
                    _BarMaxValue = CalcValue(_BarMaxValue, False)
                    '_BarMaxValue -= _TickSpacing
                ElseIf _RBarRectF.GetBounds.X + sngTickHalfSpacing < e.X Then
                    _BarMaxValue = CalcValue(_BarMaxValue, True)
                    '_BarMaxValue += _TickSpacing
                End If
                If _BarFold = True Then
                    If _BarMaxValue < _BarMinValue Then
                        _BarMaxValue = _BarMinValue
                    End If
                Else
                    If _BarMaxValue <= _BarMinValue Then
                        _BarMaxValue = CalcValue(_BarMaxValue, True)
                    End If
                End If


            End If

            Me.Invalidate()
        End If
    End Sub

    Private Function CalcValue(ByVal Value As Integer, ByVal Increage As Boolean) As Integer
        Dim rtnValue As Integer = Value
        Dim incValue As Integer = (_TrackMaxValue - _TrackMinValue) / _TickSpacing

        If Increage = True Then
            rtnValue += incValue
        Else
            rtnValue -= incValue
        End If

        If rtnValue < _TrackMinValue Then
            rtnValue = _TrackMinValue
        ElseIf rtnValue > _TrackMaxValue Then
            rtnValue = _TrackMaxValue
        End If
        Return rtnValue

    End Function


    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _LbarStatus = BarStatus.Normal
        _RbarStatus = BarStatus.Normal
        Me.Invalidate()

    End Sub


    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
        _LbarStatus = BarStatus.Normal
        _RbarStatus = BarStatus.Normal
        Me.Invalidate()

    End Sub

End Class


