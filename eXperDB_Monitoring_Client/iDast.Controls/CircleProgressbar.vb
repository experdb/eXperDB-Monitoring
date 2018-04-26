Imports System.Drawing.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class CircleProgressbar
    Inherits Control


    Public _CenterCircleColor As Color = Color.FromArgb(64, 64, 64)
    Public _BaseGaugeColor As Color = Color.FromArgb(50, 237, 19)
    Public _CpuGaugeColor As Color = Color.Blue
    Public _PostgresGaugeColor As Color = Color.Red

    Public _BufferGaugeColor As Color = Color.Yellow
    Public _CacheGaugeColor As Color = Color.Black


    Public _TitlePt As New Point(0, 0)
    Property TitlePt As Point
        Get
            Return _TitlePt
        End Get
        Set(value As Point)
            If Not _TitlePt.Equals(value) Then
                _TitlePt = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _MaxAngle As Integer = 360
    Public Property MaxAngle As Integer
        Get
            Return _MaxAngle
        End Get
        Set(value As Integer)
            If Not _MaxAngle.Equals(value) Then
                _MaxAngle = value
                Me.Invalidate()
            End If


        End Set
    End Property


    <Category("Gauge_Color"), Description("BufferGaugeColor")> _
    Public Property BufferGaugeColor As Color
        Get
            Return _BufferGaugeColor
        End Get
        Set(value As Color)
            If Not _BufferGaugeColor.Equals(value) Then
                _BufferGaugeColor = value
                Me.Invalidate()
            End If

        End Set
    End Property

    <Category("Gauge_Color"), Description("CacheGaugeColor")> _
    Public Property CacheGaugeColor As Color
        Get
            Return _CacheGaugeColor
        End Get
        Set(value As Color)
            If Not _CacheGaugeColor.Equals(value) Then
                _CacheGaugeColor = value
                Me.Invalidate()
            End If

        End Set
    End Property





    <Category("Gauge_Color"), Description("CenterCircleColor")> _
    Public Property CenterCircleColor As Color
        Get
            Return _CenterCircleColor
        End Get
        Set(value As Color)
            If Not _CenterCircleColor.Equals(value) Then
                _CenterCircleColor = value
                Me.Invalidate()
            End If

        End Set
    End Property


    <Category("Gauge_Color"), Description("PostgresGaugeColor")> _
    Public Property PostgresGaugeColor As Color
        Get
            Return _PostgresGaugeColor
        End Get
        Set(value As Color)
            If Not _PostgresGaugeColor.Equals(value) Then
                _PostgresGaugeColor = value
                Me.Invalidate()
            End If

        End Set
    End Property
    <Category("Gauge_Color"), Description("CpuGaugeColor")> _
    Public Property CpuGaugeColor As Color
        Get
            Return _CpuGaugeColor
        End Get
        Set(value As Color)
            If Not _CpuGaugeColor.Equals(value) Then
                _CpuGaugeColor = value
                Me.Invalidate()
            End If

        End Set
    End Property
    '<Category("Gauge_Color"), Description("BaseGaugeColor")> _
    'Public Property BaseGaugeColor As Color
    '    Get
    '        Return _BaseGaugeColor
    '    End Get
    '    Set(value As Color)
    '        If Not _BaseGaugeColor.Equals(value) Then
    '            _BaseGaugeColor = value
    '            Me.Invalidate()
    '        End If

    '    End Set
    'End Property


    Public _CpuGauge_value As Integer = 0
    <Category("Gauge_value"), Description("CpuGauge_value")> _
    Public Property CpuGauge_value As Integer
        Get
            Return _CpuGauge_value
        End Get
        Set(value As Integer)
            If Not _CpuGauge_value.Equals(value) Then

                If value > 100 Then
                    _CpuGauge_value = 100
                Else
                    _CpuGauge_value = value
                End If

                'TmSpin_Ani.Interval = 1
                TmSpin_Ani.Enabled = True
                ' Me.Invalidate()
            Else
                'TmSpin_Ani.Enabled = False
            End If
        End Set
    End Property

    Private _Postgres_value As Integer = 0
    <Category("Gauge_value"), Description("Postgres_value")> _
    Public Property Postgres_value As Integer
        Get
            Return _Postgres_value
        End Get
        Set(value As Integer)
            If Not _Postgres_value.Equals(value) Then
                _Postgres_value = value

                If value > 100 Then
                    _Postgres_value = 100
                Else
                    _Postgres_value = value
                End If

                'TmSpin_Ani.Interval = 1
                TmSpin_Ani.Enabled = True
                ' Me.Invalidate()
            Else
                'TmSpin_Ani.Enabled = False
            End If
        End Set
    End Property





    Private _BufferGauge_value As Integer = 0
    <Category("Gauge_value"), Description("BufferGauge_value")> _
    Public Property BufferGauge_value As Integer
        Get
            Return _BufferGauge_value
        End Get
        Set(value As Integer)
            If Not _BufferGauge_value.Equals(value) Then

                If value > 100 Then
                    _BufferGauge_value = 100
                Else
                    _BufferGauge_value = value
                End If

                'TmSpin_Ani.Interval = 1
                TmSpin_Ani.Enabled = True
                ' Me.Invalidate()
            Else
                'TmSpin_Ani.Enabled = False
            End If
        End Set
    End Property

    Private _CacheGauge_value As Integer = 0
    <Category("Gauge_value"), Description("CacheGauge_value")> _
    Public Property CacheGauge_value As Integer
        Get
            Return _CacheGauge_value
        End Get
        Set(value As Integer)
            If Not _CacheGauge_value.Equals(value) Then

                If value > 100 Then
                    _CacheGauge_value = 100
                Else
                    _CacheGauge_value = value
                End If

                'TmSpin_Ani.Interval = 1
                TmSpin_Ani.Enabled = True
                ' Me.Invalidate()
            Else
                'TmSpin_Ani.Enabled = False
            End If
        End Set
    End Property





    Private _Main_Text As String = "CPU"
    <Category("Main_Text"), Description("Main_Text")> _
    Public Property Main_Text As String
        Get
            Return _Main_Text
        End Get
        Set(value As String)
            If Not _Main_Text.Equals(value) Then
                _Main_Text = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Private _Main_TextUse As Boolean = True
    <Category("Label_Use"), Description("메인텍스트 사용여부")> _
    Property Main_TextUse As Boolean
        Get
            Return _Main_TextUse
        End Get
        Set(value As Boolean)
            _Main_TextUse = value
            Me.Invalidate()
        End Set
    End Property

    Private _Cpu_textUse As Boolean = True
    <Category("Label_Use"), Description("CPU텍스트 사용여부")> _
    Property Cpu_textUse As Boolean
        Get
            Return _Cpu_textUse
        End Get
        Set(value As Boolean)
            _Cpu_textUse = value
            Me.Invalidate()
        End Set
    End Property

    Private _Postgres_textUse As Boolean = True
    <Category("Label_Use"), Description("Postgres텍스트 사용여부")> _
    Property Postgres_textUse As Boolean
        Get
            Return _Postgres_textUse
        End Get
        Set(value As Boolean)
            _Postgres_textUse = value
            Me.Invalidate()
        End Set
    End Property

    Private _Gubun_textUse As Boolean = True
    <Category("Label_Use"), Description("구분텍스트 사용여부")> _
    Property Gubun_textUse As Boolean
        Get
            Return _Gubun_textUse
        End Get
        Set(value As Boolean)
            _Gubun_textUse = value
            Me.Invalidate()
        End Set
    End Property

    Private _Lightning_AnimationUse As Boolean = True
    <Category("Lightning_Animation"), Description("Lightning_Animation 사용여부")> _
    Property Lightning_AnimationUse As Boolean
        Get
            Return _Lightning_AnimationUse
        End Get
        Set(value As Boolean)
            '_Lightning_AnimationUse = value
            If Not _Lightning_AnimationUse.Equals(value) Then
                _Lightning_AnimationUse = value
                InitAnimation()
            End If

        End Set
    End Property
    Private _Gauge_Interval As Integer = 3000
    <Category("Gauge_Interval"), Description("게이지 주기")> _
    Property Gauge_Interval As Integer
        Get
            Return _Gauge_Interval
        End Get
        Set(value As Integer)

            If Not _Gauge_Interval.Equals(value) Then
                If value < 3000 Then
                    _Gauge_Interval = 3000
                Else
                    _Gauge_Interval = value
                End If

                InitGaugeAnimation()

            End If
        End Set
    End Property



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        'MyBase.OnPaint(e)


        Dim BaseRect As Rectangle = Nothing
        If MyBase.Width > MyBase.Height Then
            BaseRect = New Rectangle((MyBase.Width - MyBase.Height) / 2, 0, MyBase.Height, MyBase.Height)
        Else
            BaseRect = New Rectangle(0, (MyBase.Height - MyBase.Width) / 2, MyBase.Width, MyBase.Width)

        End If

        Dim Gr As Graphics = e.Graphics
        Gr.SmoothingMode = SmoothingMode.AntiAlias
        Gr.Clear(MyBase.BackColor)



        If (BaseRect.Width < 100 And BaseRect.Height < 100) Then
            Return
        End If

        Using bmp As Image = New Bitmap(BaseRect.Width, BaseRect.Height)

            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(MyBase.BackColor)
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.PixelOffsetMode = PixelOffsetMode.HighQuality

                'Using backcolor As New SolidBrush(CenterCircleColor)
                '    g.FillRectangle(backcolor, 0, 0, MyBase.Width, MyBase.Height)
                '    g.FillRectangle(New SolidBrush(Color.Cyan), BaseRect)
                'End Using

                'Using brushBase As New SolidBrush(Color.FromArgb(128, 255, 255, 255))
                '    g.FillEllipse(brushBase, GetRectangle(1))
                'End Using

                Dim spacrate As Double = _MaxAngle / 100


                Dim startAngle As Single = -90.0F
                Dim Base_Gauge_sweepAngle_ As Single = Convert.ToSingle(spacrate * 100)


                Dim Cache_Gauge_sweepAngle As Single = Convert.ToSingle(spacrate * _Ani_int5)
                Dim Buffer_Gauge_sweepAngle As Single = Convert.ToSingle(spacrate * _Ani_int4)


                Dim Cpu_Gauge_sweepAngle As Single = Convert.ToSingle(spacrate * _Ani_int2)
                Dim postgres_Gauge_sweepAngle As Single = Convert.ToSingle(spacrate * _Ani_int1)




                Using Center_Circle_Color As New SolidBrush(CenterCircleColor)
                    'Using Base_Gauge_Color As New SolidBrush(BaseGaugeColor)
                    Using Buffer_GaugeColor As New SolidBrush(BufferGaugeColor)
                        Using Cache_GaugeColor As New SolidBrush(CacheGaugeColor)
                            Using Cpu_Gauge_Color As New SolidBrush(CpuGaugeColor)
                                Using postgres_Gauge_Color As New SolidBrush(PostgresGaugeColor)




                                    'g.FillEllipse(Center_Circle_Color, GetRectangle(1))
                                    Dim CircleRect As Rectangle = New Rectangle(0, 0, BaseRect.Width, BaseRect.Height)
                                    CircleRect.Inflate(-5, -5)

                                    '천체
                                    g.FillPie(Center_Circle_Color, CircleRect, startAngle, Base_Gauge_sweepAngle_)

                                    'Cache
                                    g.FillPie(Cache_GaugeColor, CircleRect, startAngle, Cache_Gauge_sweepAngle)

                                    'Buffer
                                    g.FillPie(Buffer_GaugeColor, CircleRect, startAngle, Buffer_Gauge_sweepAngle)

                                    'cpu
                                    g.FillPie(Cpu_Gauge_Color, CircleRect, startAngle, Cpu_Gauge_sweepAngle)

                                    'postgres
                                    g.FillPie(postgres_Gauge_Color, CircleRect, startAngle, postgres_Gauge_sweepAngle)






                                    '================================================================
                                    If Lightning_AnimationUse = True Then
                                        Dim EffectPath As New Drawing2D.GraphicsPath

                                        EffectPath.AddLine(New Point(bmp.Width / 2, bmp.Height / 2), New Point(bmp.Width / 2, 0))
                                        EffectPath.AddArc(CircleRect, startAngle, Cache_Gauge_sweepAngle + Convert.ToSingle(0.1))
                                        EffectPath.CloseFigure()

                                        'Dim tr As New Drawing2D.Matrix

                                        'tr.RotateAt(0, New Point(MyBase.Width / 2, MyBase.Height / 2))
                                        'EffectPath.Transform(tr)

                                        Dim GraBrush As New Drawing2D.PathGradientBrush(EffectPath)

                                        ' GraBrush.SetSigmaBellShape(1, 1)
                                        GraBrush.CenterPoint = New Point(bmp.Width / 2, bmp.Height / 2)
                                        GraBrush.CenterColor = Color.FromArgb(_Angle, 255, 255, 255)
                                        GraBrush.SurroundColors = New Color() {Color.FromArgb(0, 255, 255, 255)}

                                        g.FillPath(GraBrush, EffectPath)
                                    End If


                                    '================================================================

                                    ''가운데원
                                    'g.FillEllipse(Center_Circle_Color, GetRectangle(Convert.ToInt32(BaseRect.Width * 0.78)))
                                    'CircleRect.Inflate(BaseRect.Width * 0.78 * -1, BaseRect.Width * 0.78 * -1)
                                    CircleRect.Inflate(BaseRect.Width * 0.72 * -1, BaseRect.Width * 0.72 * -1)
                                    g.FillEllipse(Center_Circle_Color, CircleRect)

                                    Dim szf As SizeF = Nothing

                                    Dim Cpu_text As String = _Ani_int2 & "%"
                                    Dim Gubun As String = "/"
                                    Dim Postgres_text As String = _Ani_int1 & "%"

                                    Dim CenterStr As Boolean = False

                                    Dim CenterColor As System.Drawing.SolidBrush = New SolidBrush(Color.White)


                                    If Cpu_textUse = False And Gubun_textUse = False And Postgres_textUse = True Then
                                        Gubun = Postgres_text
                                        CenterStr = True
                                        CenterColor = postgres_Gauge_Color

                                    ElseIf Postgres_textUse = False And Gubun_textUse = False And Cpu_textUse = True Then
                                        Gubun = Cpu_text
                                        CenterStr = True
                                        CenterColor = Cpu_Gauge_Color
                                    End If

                                    If (CenterStr) Then
                                        szf = g.MeasureString(Gubun, New Font("Arial", Convert.ToInt32(BaseRect.Width * 0.12), FontStyle.Bold, GraphicsUnit.Pixel))
                                        g.DrawString(Gubun, New Font("Arial", Convert.ToInt32(BaseRect.Width * 0.12),
                                                                 FontStyle.Bold, GraphicsUnit.Pixel), CenterColor, New Point(bmp.Width / 2 - szf.Width / 2, bmp.Height / 2 - szf.Height / 2)) '98, 87
                                    Else
                                        If Cpu_textUse = True Then
                                            szf = g.MeasureString(Cpu_text, New Font("Arial",
                                                                    Convert.ToInt32(BaseRect.Width * 0.12),
                                                                     FontStyle.Bold, GraphicsUnit.Pixel))
                                            g.DrawString(Cpu_text, New Font("Arial",
                                                                    Convert.ToInt32(BaseRect.Width * 0.12),
                                                                     FontStyle.Bold, GraphicsUnit.Pixel), Cpu_Gauge_Color, New Point(bmp.Width / 2 - szf.Width - 2, bmp.Height / 2 - szf.Height / 2)) '59, 87
                                        End If


                                        If Gubun_textUse = True Then
                                            szf = g.MeasureString(Gubun, New Font("Arial",
                                                                    Convert.ToInt32(BaseRect.Width * 0.1),
                                                                     FontStyle.Bold, GraphicsUnit.Pixel))
                                            g.DrawString(Gubun, New Font("Arial",
                                                                    Convert.ToInt32(BaseRect.Width * 0.1),
                                                                     FontStyle.Bold, GraphicsUnit.Pixel), Brushes.White, New Point(bmp.Width / 2 - szf.Width / 2, bmp.Height / 2 - szf.Height / 2)) '98, 87
                                        End If


                                        If Postgres_textUse = True Then
                                            g.DrawString(Postgres_text, New Font("Arial",
                                                                    Convert.ToInt32(BaseRect.Width * 0.12),
                                                                     FontStyle.Bold, GraphicsUnit.Pixel), postgres_Gauge_Color, New Point(bmp.Width / 2 + szf.Width / 4, bmp.Height / 2 - szf.Height / 2))  '106, 87

                                        End If
                                    End If



                                    If Main_TextUse = True Then
                                        Dim txt As String = _Main_Text
                                        g.DrawString(txt, New Font("Arial",
                                                                Convert.ToInt32(BaseRect.Width * 0.14),
                                                                 FontStyle.Bold, GraphicsUnit.Pixel), Brushes.White, _TitlePt)  '106, 87
                                    End If

                                End Using
                            End Using
                        End Using
                    End Using

                    'End Using
                End Using
                e.Graphics.DrawImage(bmp, BaseRect)
            End Using
        End Using
    End Sub



    Private _AniOpacityIn As Integer = 9
    Private _AniOpacityOUT As Integer = 100
    Private _AniColorIn As Color = Color.BlanchedAlmond

    Private _Angle As Integer = 0

    <STAThread> _
    Private Sub TmSpin_Tick(sender As Object, e As EventArgs) Handles TmSpin.Elapsed
        _Angle += 10
        TmSpin.Interval = 1
        If _Angle >= 190 Then

            _Angle = 190

            TmSpin.Stop()
            TmSpin2.Start()

        End If

        Me.Invalidate()

    End Sub

    <STAThread> _
    Private Sub TmSpin2_Tick(sender As Object, e As EventArgs) Handles TmSpin2.Elapsed
        _Angle -= 15
        If _Angle <= 0 Then
            _Angle = 0

            TmSpin2.Stop()
            TmSpin.Interval = 1000
            TmSpin.Start()

        End If

        Me.Invalidate()

    End Sub

    Private _Ani_int1 As Integer = 0
    Private _Ani_int2 As Integer = 0

    Private _Ani_int4 As Integer = 0
    Private _Ani_int5 As Integer = 0

    ' Private _Ani_int3 As Integer = 0
    <STAThread> _
    Private Sub TmSpin_Ani_Tick(sender As Object, e As EventArgs) Handles TmSpin_Ani.Elapsed
        '_Ani_int += 1
        'If _Ani_int >= Postgres_value Then

        '    _Ani_int = Postgres_value

        'End If





        If _Ani_int1 < Postgres_value Then
            _Ani_int1 += 1
        Else
            If _Ani_int1 > Postgres_value Then
                _Ani_int1 -= 1
            Else
                _Ani_int1 = Postgres_value
            End If
        End If

        'If _Ani_int1 >= Postgres_value Then

        '    _Ani_int1 = Postgres_value
        'End If

        If _Ani_int2 < CpuGauge_value Then
            _Ani_int2 += 1
        Else
            If _Ani_int2 > CpuGauge_value Then
                _Ani_int2 -= 1
            Else
                _Ani_int2 = CpuGauge_value
            End If

        End If


        If _Ani_int4 < BufferGauge_value Then
            _Ani_int4 += 1
        Else
            If _Ani_int4 > BufferGauge_value Then
                _Ani_int4 -= 1
            Else
                _Ani_int4 = BufferGauge_value
            End If

        End If

        If _Ani_int5 < CacheGauge_value Then
            _Ani_int5 += 1
        Else
            If _Ani_int5 > CacheGauge_value Then
                _Ani_int5 -= 1
            Else
                _Ani_int5 = CacheGauge_value
            End If

        End If




        'If _Ani_int2 >= CpuGauge_value Then

        '    _Ani_int2 = CpuGauge_value
        'End If
        Me.Invalidate()


        'If _Ani_int2 = CpuGauge_value AndAlso _Ani_int1 = Postgres_value Then
        '    TmSpin_Ani.Enabled = False
        'End If



    End Sub


    Private WithEvents TmSpin As System.Timers.Timer = New System.Timers.Timer()
    Private WithEvents TmSpin2 As System.Timers.Timer = New System.Timers.Timer()

    Private WithEvents TmSpin_Ani As System.Timers.Timer = New System.Timers.Timer()

    Private Sub InitAnimation()
        'If TmSpin Is Nothing Then
        '    TmSpin = New Timer
        '    'TmSpin_Ani = New Timer
        'Else
        '    TmSpin.Enabled = False
        'End If

        ''AddHandler TmSpin.Tick, AddressOf TmSpin_Tick

        ''TmSpin_Ani.Interval = 1

        'TmSpin.Enabled = True
        'TmSpin_Ani.Enabled = True


        If _Lightning_AnimationUse = True Then
            'TmSpin = New Timer
            TmSpin.Interval = 1
            TmSpin.Enabled = True
        Else
            TmSpin.Enabled = False
        End If

    End Sub
    Private Sub InitGaugeAnimation()
        'TmSpin_Ani.Interval = 1
        TmSpin_Ani.Interval = _Gauge_Interval / 100
        TmSpin_Ani.Enabled = True
    End Sub

    '기존사각형위치값정의
    'Private Function GetRectangle(offset As Integer) As Rectangle

    '    Dim BaseRect As Rectangle = Nothing
    '    If MyBase.Width > MyBase.Height Then
    '        BaseRect = New Rectangle((((MyBase.Width - MyBase.Height) / 2) + offset), 0 + offset, MyBase.Height - offset * 2, MyBase.Height - offset * 2)
    '    Else
    '        BaseRect = New Rectangle(0 + offset, ((MyBase.Height - MyBase.Width) / 2) + offset, MyBase.Width - offset * 2, MyBase.Width - offset * 2)
    '    End If

    '    Return BaseRect
    '    'Return New Rectangle(offset, offset, Me.Width - offset * 2, Me.Height - offset * 2)
    'End Function

    Public Sub New()
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        MyBase.SetStyle(DoubleBuffered, True)

        InitAnimation()
        InitGaugeAnimation()
    End Sub


End Class
