' Copyright (C) 2007 A.J.Bauer
'
'  This software is provided as-is, without any express or implied
'  warranty.  In no event will the authors be held liable for any damages
'  arising from the use of this software.

'  Permission is granted to anyone to use this software for any purpose,
'  including commercial applications, and to alter it and redistribute it
'  freely, subject to the following restrictions:
'  1. The origin of this software must not be misrepresented; you must not
'     claim that you wrote the original software. if you use this software
'     in a product, an acknowledgment in the product documentation would be
'     appreciated but is not required.
'  2. Altered source versions must be plainly marked as such, and must not be
'     misrepresented as being the original software.
'  3. This notice may not be removed or altered from any source distribution.
'
' -----------------------------------------------------------------------------------
' Copyright (C) 2012 Code Artist
' 
' Added several improvement to original code created by A.J.Bauer.
' Visit: http://codearteng.blogspot.com for more information on change history.
'
' -----------------------------------------------------------------------------------

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Diagnostics
Imports System.Collections

''' <summary>
''' <para>AGauge - Copyright (C) 2007 A.J.Bauer</para>
''' <link>http://www.codeproject.com/Articles/17559/A-fast-and-performing-gauge</link>
''' </summary>
<ToolboxBitmapAttribute(GetType(ctlGauge), "AGauge.AGauge.bmp"), DefaultEvent("ValueInRangeChanged"), Description("Displays a value on an analog gauge. Raises an event if the value enters one of the definable ranges.")> _
Partial Public Class ctlGauge
    Inherits Control
#Region "Private Fields"

    Private fontBoundY1 As [Single]
    Private fontBoundY2 As [Single]
    Private gaugeBitmap As Bitmap
    Private drawGaugeBackground As [Boolean] = True

    Private m_value As [Single]
    Private m_Center As New Point(100, 100)
    Private m_MinValue As [Single] = -100
    Private m_MaxValue As [Single] = 400

    Private m_BaseArcColor As Color = Color.Gray
    Private m_BaseArcRadius As Int32 = 80
    Private m_BaseArcStart As Int32 = 135
    Private m_BaseArcSweep As Int32 = 270
    Private m_BaseArcWidth As Int32 = 2

    Private m_ScaleLinesInterColor As Color = Color.Black
    Private m_ScaleLinesInterInnerRadius As Int32 = 73
    Private m_ScaleLinesInterOuterRadius As Int32 = 80
    Private m_ScaleLinesInterWidth As Int32 = 1

    Private m_ScaleLinesMinorTicks As Int32 = 9
    Private m_ScaleLinesMinorColor As Color = Color.Gray
    Private m_ScaleLinesMinorInnerRadius As Int32 = 75
    Private m_ScaleLinesMinorOuterRadius As Int32 = 80
    Private m_ScaleLinesMinorWidth As Int32 = 1

    Private m_ScaleLinesMajorStepValue As [Single] = 50.0F
    Private m_ScaleLinesMajorColor As Color = Color.Black
    Private m_ScaleLinesMajorInnerRadius As Int32 = 70
    Private m_ScaleLinesMajorOuterRadius As Int32 = 80
    Private m_ScaleLinesMajorWidth As Int32 = 2

    Private m_ScaleNumbersRadius As Int32 = 95
    Private m_ScaleNumbersColor As Color = Color.Black
    Private m_ScaleNumbersFormat As [String]
    Private m_ScaleNumbersStartScaleLine As Int32
    Private m_ScaleNumbersStepScaleLines As Int32 = 1
    Private m_ScaleNumbersRotation As Int32

    Private m_NeedleType As NeedleType
    Private m_NeedleRadius As Int32 = 80
    Private m_NeedleColor1 As AGaugeNeedleColor = AGaugeNeedleColor.Gray
    Private m_NeedleColor2 As Color = Color.DimGray
    Private m_NeedleWidth As Int32 = 2

#End Region

#Region "EventHandler"

    <Description("This event is raised when gauge value changed.")> _
    Public Event ValueChanged As EventHandler
    Private Sub OnValueChanged()
        'Dim e As EventHandler = ValueChanged
        'RaiseEvent e(Me, Nothing)
        RaiseEvent ValueChanged(Me, Nothing)
    End Sub

    <Description("This event is raised if the value is entering or leaving defined range.")> _
    Public Event ValueInRangeChanged As EventHandler(Of ValueInRangeChangedEventArgs)
    Private Sub OnValueInRangeChanged(range As AGaugeRange, value As [Single])
        'Dim e As EventHandler(Of ValueInRangeChangedEventArgs) = ValueInRangeChanged
        'RaiseEvent e(Me, New ValueInRangeChangedEventArgs(range, value, range.InRange))
        RaiseEvent ValueInRangeChanged(Me, New ValueInRangeChangedEventArgs(range, value, range.InRange))
    End Sub

#End Region

#Region "Hidden and overridden inherited properties"

    Public Shadows Property AllowDrop() As [Boolean]
        Get
            Return False
        End Get
        'Do Nothing 
        Set(value As [Boolean])
        End Set
    End Property
    Public Shadows Property AutoSize() As [Boolean]
        Get
            Return False
        End Get
        'Do Nothing 
        Set(value As [Boolean])
        End Set
    End Property
    Public Shadows Property ForeColor() As [Boolean]
        Get
            Return False
        End Get
        'Do Nothing 
        Set(value As [Boolean])
        End Set
    End Property
    Public Shadows Property ImeMode() As [Boolean]
        Get
            Return False
        End Get
        'Do Nothing 
        Set(value As [Boolean])
        End Set
    End Property
    Public Overrides Property BackColor() As System.Drawing.Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As System.Drawing.Color)
            MyBase.BackColor = value
            drawGaugeBackground = True
            Refresh()
        End Set
    End Property
    Public Overrides Property Font() As System.Drawing.Font
        Get
            Return MyBase.Font
        End Get
        Set(value As System.Drawing.Font)
            MyBase.Font = value
            drawGaugeBackground = True
            Refresh()
        End Set
    End Property
    Public Overrides Property BackgroundImageLayout() As System.Windows.Forms.ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As System.Windows.Forms.ImageLayout)
            MyBase.BackgroundImageLayout = value
            drawGaugeBackground = True
            Refresh()
        End Set
    End Property

#End Region

    Public Sub New()
        'InitializeComponent()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        _GaugeRanges = New AGaugeRangeCollection(Me)
        _GaugeLabels = New AGaugeLabelCollection(Me)

        'Default Values
        Size = New Size(205, 180)
    End Sub




#Region "Properties"

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("Gauge value.")> _
    Public Property Value() As [Single]
        Get
            Return m_value
        End Get
        Set(value As [Single])
            value = Math.Min(Math.Max(value, m_MinValue), m_MaxValue)
            If m_value <> value Then
                m_value = value
                OnValueChanged()

                If Me.DesignMode Then
                    drawGaugeBackground = True
                End If

                For Each ptrRange As AGaugeRange In _GaugeRanges
                    If (m_value >= ptrRange.StartValue) AndAlso (m_value <= ptrRange.EndValue) Then
                        'Entering Range
                        If Not ptrRange.InRange Then
                            ptrRange.InRange = True
                            OnValueInRangeChanged(ptrRange, m_value)
                        End If
                    Else
                        'Leaving Range
                        If ptrRange.InRange Then
                            ptrRange.InRange = False
                            OnValueInRangeChanged(ptrRange, m_value)
                        End If
                    End If
                Next
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("Gauge Ranges.")> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property GaugeRanges() As AGaugeRangeCollection
        Get
            Return _GaugeRanges
        End Get
    End Property
    Private _GaugeRanges As AGaugeRangeCollection

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("Gauge Labels.")> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property GaugeLabels() As AGaugeLabelCollection
        Get
            Return _GaugeLabels
        End Get
    End Property
    Private _GaugeLabels As AGaugeLabelCollection

#Region "<< Gauge Base >>"

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The center of the gauge (in the control's client area).")> _
    Public Property Center() As Point
        Get
            Return m_Center
        End Get
        Set(value As Point)
            If m_Center <> value Then
                m_Center = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The color of the base arc.")> _
    Public Property BaseArcColor() As Color
        Get
            Return m_BaseArcColor
        End Get
        Set(value As Color)
            If m_BaseArcColor <> value Then
                m_BaseArcColor = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The radius of the base arc.")> _
    Public Property BaseArcRadius() As Int32
        Get
            Return m_BaseArcRadius
        End Get
        Set(value As Int32)
            If m_BaseArcRadius <> value Then
                m_BaseArcRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The start angle of the base arc.")> _
    Public Property BaseArcStart() As Int32
        Get
            Return m_BaseArcStart
        End Get
        Set(value As Int32)
            If m_BaseArcStart <> value Then
                m_BaseArcStart = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The sweep angle of the base arc.")> _
    Public Property BaseArcSweep() As Int32
        Get
            Return m_BaseArcSweep
        End Get
        Set(value As Int32)
            If m_BaseArcSweep <> value Then
                m_BaseArcSweep = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The width of the base arc.")> _
    Public Property BaseArcWidth() As Int32
        Get
            Return m_BaseArcWidth
        End Get
        Set(value As Int32)
            If m_BaseArcWidth <> value Then
                m_BaseArcWidth = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

#End Region

#Region "<< Gauge Scale >>"

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The minimum value to show on the scale.")> _
    Public Property MinValue() As [Single]
        Get
            Return m_MinValue
        End Get
        Set(value As [Single])
            If (m_MinValue <> value) AndAlso (value < m_MaxValue) Then
                m_MinValue = value
                m_value = Math.Min(Math.Max(m_value, m_MinValue), m_MaxValue)
                m_ScaleLinesMajorStepValue = Math.Min(m_ScaleLinesMajorStepValue, m_MaxValue - m_MinValue)
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The maximum value to show on the scale.")> _
    Public Property MaxValue() As [Single]
        Get
            Return m_MaxValue
        End Get
        Set(value As [Single])
            If (m_MaxValue <> value) AndAlso (value > m_MinValue) Then
                m_MaxValue = value
                m_value = Math.Min(Math.Max(m_value, m_MinValue), m_MaxValue)
                m_ScaleLinesMajorStepValue = Math.Min(m_ScaleLinesMajorStepValue, m_MaxValue - m_MinValue)
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The color of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")> _
    Public Property ScaleLinesInterColor() As Color
        Get
            Return m_ScaleLinesInterColor
        End Get
        Set(value As Color)
            If m_ScaleLinesInterColor <> value Then
                m_ScaleLinesInterColor = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The inner radius of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")> _
    Public Property ScaleLinesInterInnerRadius() As Int32
        Get
            Return m_ScaleLinesInterInnerRadius
        End Get
        Set(value As Int32)
            If m_ScaleLinesInterInnerRadius <> value Then
                m_ScaleLinesInterInnerRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The outer radius of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")> _
    Public Property ScaleLinesInterOuterRadius() As Int32
        Get
            Return m_ScaleLinesInterOuterRadius
        End Get
        Set(value As Int32)
            If m_ScaleLinesInterOuterRadius <> value Then
                m_ScaleLinesInterOuterRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The width of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")> _
    Public Property ScaleLinesInterWidth() As Int32
        Get
            Return m_ScaleLinesInterWidth
        End Get
        Set(value As Int32)
            If m_ScaleLinesInterWidth <> value Then
                m_ScaleLinesInterWidth = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The number of minor scale lines.")> _
    Public Property ScaleLinesMinorTicks() As Int32
        Get
            Return m_ScaleLinesMinorTicks
        End Get
        Set(value As Int32)
            If m_ScaleLinesMinorTicks <> value Then
                m_ScaleLinesMinorTicks = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The color of the minor scale lines.")> _
    Public Property ScaleLinesMinorColor() As Color
        Get
            Return m_ScaleLinesMinorColor
        End Get
        Set(value As Color)
            If m_ScaleLinesMinorColor <> value Then
                m_ScaleLinesMinorColor = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The inner radius of the minor scale lines.")> _
    Public Property ScaleLinesMinorInnerRadius() As Int32
        Get
            Return m_ScaleLinesMinorInnerRadius
        End Get
        Set(value As Int32)
            If m_ScaleLinesMinorInnerRadius <> value Then
                m_ScaleLinesMinorInnerRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The outer radius of the minor scale lines.")> _
    Public Property ScaleLinesMinorOuterRadius() As Int32
        Get
            Return m_ScaleLinesMinorOuterRadius
        End Get
        Set(value As Int32)
            If m_ScaleLinesMinorOuterRadius <> value Then
                m_ScaleLinesMinorOuterRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The width of the minor scale lines.")> _
    Public Property ScaleLinesMinorWidth() As Int32
        Get
            Return m_ScaleLinesMinorWidth
        End Get
        Set(value As Int32)
            If m_ScaleLinesMinorWidth <> value Then
                m_ScaleLinesMinorWidth = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The step value of the major scale lines.")> _
    Public Property ScaleLinesMajorStepValue() As [Single]
        Get
            Return m_ScaleLinesMajorStepValue
        End Get
        Set(value As [Single])
            If (m_ScaleLinesMajorStepValue <> value) AndAlso (value > 0) Then
                m_ScaleLinesMajorStepValue = Math.Min(value, m_MaxValue - m_MinValue)
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The color of the major scale lines.")> _
    Public Property ScaleLinesMajorColor() As Color
        Get
            Return m_ScaleLinesMajorColor
        End Get
        Set(value As Color)
            If m_ScaleLinesMajorColor <> value Then
                m_ScaleLinesMajorColor = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The inner radius of the major scale lines.")> _
    Public Property ScaleLinesMajorInnerRadius() As Int32
        Get
            Return m_ScaleLinesMajorInnerRadius
        End Get
        Set(value As Int32)
            If m_ScaleLinesMajorInnerRadius <> value Then
                m_ScaleLinesMajorInnerRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The outer radius of the major scale lines.")> _
    Public Property ScaleLinesMajorOuterRadius() As Int32
        Get
            Return m_ScaleLinesMajorOuterRadius
        End Get
        Set(value As Int32)
            If m_ScaleLinesMajorOuterRadius <> value Then
                m_ScaleLinesMajorOuterRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The width of the major scale lines.")> _
    Public Property ScaleLinesMajorWidth() As Int32
        Get
            Return m_ScaleLinesMajorWidth
        End Get
        Set(value As Int32)
            If m_ScaleLinesMajorWidth <> value Then
                m_ScaleLinesMajorWidth = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

#End Region

#Region "<< Gauge Scale Numbers >>"

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The radius of the scale numbers.")> _
    Public Property ScaleNumbersRadius() As Int32
        Get
            Return m_ScaleNumbersRadius
        End Get
        Set(value As Int32)
            If m_ScaleNumbersRadius <> value Then
                m_ScaleNumbersRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The color of the scale numbers.")> _
    Public Property ScaleNumbersColor() As Color
        Get
            Return m_ScaleNumbersColor
        End Get
        Set(value As Color)
            If m_ScaleNumbersColor <> value Then
                m_ScaleNumbersColor = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The format of the scale numbers.")> _
    Public Property ScaleNumbersFormat() As [String]
        Get
            Return m_ScaleNumbersFormat
        End Get
        Set(value As [String])
            If m_ScaleNumbersFormat <> value Then
                m_ScaleNumbersFormat = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The number of the scale line to start writing numbers next to.")> _
    Public Property ScaleNumbersStartScaleLine() As Int32
        Get
            Return m_ScaleNumbersStartScaleLine
        End Get
        Set(value As Int32)
            If m_ScaleNumbersStartScaleLine <> value Then
                m_ScaleNumbersStartScaleLine = Math.Max(value, 1)
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The number of scale line steps for writing numbers.")> _
    Public Property ScaleNumbersStepScaleLines() As Int32
        Get
            Return m_ScaleNumbersStepScaleLines
        End Get
        Set(value As Int32)
            If m_ScaleNumbersStepScaleLines <> value Then
                m_ScaleNumbersStepScaleLines = Math.Max(value, 1)
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The angle relative to the tangent of the base arc at a scale line that is used to rotate numbers. set to 0 for no rotation or e.g. set to 90.")> _
    Public Property ScaleNumbersRotation() As Int32
        Get
            Return m_ScaleNumbersRotation
        End Get
        Set(value As Int32)
            If m_ScaleNumbersRotation <> value Then
                m_ScaleNumbersRotation = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

#End Region

#Region "<< Gauge Needle >>"

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The type of the needle, currently only type 0 and 1 are supported. Type 0 looks nicers but if you experience performance problems you might consider using type 1.")> _
    Public Property NeedleType() As NeedleType
        Get
            Return m_NeedleType
        End Get
        Set(value As NeedleType)
            If m_NeedleType <> value Then
                m_NeedleType = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The radius of the needle.")> _
    Public Property NeedleRadius() As Int32
        Get
            Return m_NeedleRadius
        End Get
        Set(value As Int32)
            If m_NeedleRadius <> value Then
                m_NeedleRadius = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The first color of the needle.")> _
    Public Property NeedleColor1() As AGaugeNeedleColor
        Get
            Return m_NeedleColor1
        End Get
        Set(value As AGaugeNeedleColor)
            If m_NeedleColor1 <> value Then
                m_NeedleColor1 = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The second color of the needle.")> _
    Public Property NeedleColor2() As Color
        Get
            Return m_NeedleColor2
        End Get
        Set(value As Color)
            If m_NeedleColor2 <> value Then
                m_NeedleColor2 = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge"), System.ComponentModel.Description("The width of the needle.")> _
    Public Property NeedleWidth() As Int32
        Get
            Return m_NeedleWidth
        End Get
        Set(value As Int32)
            If m_NeedleWidth <> value Then
                m_NeedleWidth = value
                drawGaugeBackground = True
                Refresh()
            End If
        End Set
    End Property

#End Region

    '#Region "<< Gauge Progress >>"

    '    Private _ShowProgress As Boolean = False
    '    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge Progress"), System.ComponentModel.Description("프로그래스바")> _
    '    Public Property ShowProgress() As Boolean
    '        Get
    '            Return _ShowProgress
    '        End Get
    '        Set(value As Boolean)
    '            If Not _ShowProgress.Equals(value) Then
    '                _ShowProgress = value
    '                drawGaugeBackground = True
    '                Refresh()
    '            End If
    '        End Set
    '    End Property

    '    Private _ProgressPosition As Point = New Point(0, 0)
    '    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge Progress"), System.ComponentModel.Description("프로그레스바 시작점")> _
    '    Public Property ProgressPosition As Point
    '        Get
    '            Return _ProgressPosition
    '        End Get
    '        Set(value As Point)
    '            If Not _ProgressPosition.Equals(value) Then
    '                _ProgressPosition = value
    '                drawGaugeBackground = True
    '                Refresh()

    '            End If
    '        End Set
    '    End Property
    '    Private _ProgressSize As Size = New Size(100, 20)
    '    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("AGauge Progress"), System.ComponentModel.Description("프로그레스바 크기")> _
    '    Public Property ProgressSize As Size
    '        Get
    '            Return _ProgressSize
    '        End Get
    '        Set(value As Size)
    '            If Not _ProgressSize.Equals(value) Then
    '                _ProgressSize = value
    '                drawGaugeBackground = True
    '                Refresh()
    '            End If
    '        End Set
    '    End Property

    '#End Region

#End Region

#Region "Helper"

    Private Sub FindFontBounds()
        'find upper and lower bounds for numeric characters
        Dim c1 As Int32
        Dim c2 As Int32
        Dim boundfound As [Boolean]
        Dim b As Bitmap
        Dim g As Graphics
        Dim backBrush As New SolidBrush(Color.White)
        Dim foreBrush As New SolidBrush(Color.Black)
        Dim boundingBox As SizeF

        b = New Bitmap(5, 5)
        g = Graphics.FromImage(b)
        boundingBox = g.MeasureString("0123456789", Font, -1, StringFormat.GenericTypographic)
        b = New Bitmap(CType(Math.Truncate(boundingBox.Width), Int32), CType(Math.Truncate(boundingBox.Height), Int32))
        g = Graphics.FromImage(b)
        g.FillRectangle(backBrush, 0.0F, 0.0F, boundingBox.Width, boundingBox.Height)
        g.DrawString("0123456789", Font, foreBrush, 0.0F, 0.0F, StringFormat.GenericTypographic)

        fontBoundY1 = 0
        fontBoundY2 = 0
        c1 = 0
        boundfound = False
        While (c1 < b.Height) AndAlso (Not boundfound)
            c2 = 0
            While (c2 < b.Width) AndAlso (Not boundfound)
                If b.GetPixel(c2, c1) <> backBrush.Color Then
                    fontBoundY1 = c1
                    boundfound = True
                End If
                c2 += 1
            End While
            c1 += 1
        End While

        c1 = b.Height - 1
        boundfound = False
        While (0 < c1) AndAlso (Not boundfound)
            c2 = 0
            While (c2 < b.Width) AndAlso (Not boundfound)
                If b.GetPixel(c2, c1) <> backBrush.Color Then
                    fontBoundY2 = c1
                    boundfound = True
                End If
                c2 += 1
            End While
            c1 -= 1
        End While
    End Sub

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Sub RepaintControl()
        drawGaugeBackground = True
        Refresh()
    End Sub

#End Region

#Region "Base member overrides"

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If (Width < 10) OrElse (Height < 10) Then
            Return
        End If

        If drawGaugeBackground Then
            drawGaugeBackground = False

            FindFontBounds()

            gaugeBitmap = New Bitmap(Width, Height, e.Graphics)
            Dim ggr As Graphics = Graphics.FromImage(gaugeBitmap)
            ggr.FillRectangle(New SolidBrush(BackColor), ClientRectangle)

            If BackgroundImage IsNot Nothing Then
                Select Case BackgroundImageLayout
                    Case ImageLayout.Center
                        ggr.DrawImageUnscaled(BackgroundImage, Width \ 2 - BackgroundImage.Width \ 2, Height \ 2 - BackgroundImage.Height \ 2)
                        Exit Select
                    Case ImageLayout.None
                        ggr.DrawImageUnscaled(BackgroundImage, 0, 0)
                        Exit Select
                    Case ImageLayout.Stretch
                        ggr.DrawImage(BackgroundImage, 0, 0, Width, Height)
                        Exit Select
                    Case ImageLayout.Tile
                        Dim pixelOffsetX As Int32 = 0
                        Dim pixelOffsetY As Int32 = 0
                        While pixelOffsetX < Width
                            pixelOffsetY = 0
                            While pixelOffsetY < Height
                                ggr.DrawImageUnscaled(BackgroundImage, pixelOffsetX, pixelOffsetY)
                                pixelOffsetY += BackgroundImage.Height
                            End While
                            pixelOffsetX += BackgroundImage.Width
                        End While
                        Exit Select
                    Case ImageLayout.Zoom
                        If CType(BackgroundImage.Width \ Width, [Single]) < CType(BackgroundImage.Height \ Height, [Single]) Then
                            ggr.DrawImage(BackgroundImage, 0, 0, Height, Height)
                        Else
                            ggr.DrawImage(BackgroundImage, 0, 0, Width, Width)
                        End If
                        Exit Select
                End Select
            End If

            ggr.SmoothingMode = SmoothingMode.HighQuality
            ggr.PixelOffsetMode = PixelOffsetMode.HighQuality

            Dim gp As New GraphicsPath()
            Dim rangeStartAngle As [Single]
            Dim rangeSweepAngle As [Single]

            For Each ptrRange As AGaugeRange In _GaugeRanges
                If ptrRange.EndValue > ptrRange.StartValue Then
                    rangeStartAngle = m_BaseArcStart + (ptrRange.StartValue - m_MinValue) * m_BaseArcSweep / (m_MaxValue - m_MinValue)
                    rangeSweepAngle = (ptrRange.EndValue - ptrRange.StartValue) * m_BaseArcSweep / (m_MaxValue - m_MinValue)
                    gp.Reset()
                    gp.AddPie(New Rectangle(m_Center.X - ptrRange.OuterRadius, m_Center.Y - ptrRange.OuterRadius, 2 * ptrRange.OuterRadius, 2 * ptrRange.OuterRadius), rangeStartAngle, rangeSweepAngle)
                    gp.Reverse()
                    gp.AddPie(New Rectangle(m_Center.X - ptrRange.InnerRadius, m_Center.Y - ptrRange.InnerRadius, 2 * ptrRange.InnerRadius, 2 * ptrRange.InnerRadius), rangeStartAngle, rangeSweepAngle)
                    gp.Reverse()
                    ggr.SetClip(gp)
                    ggr.FillPie(New SolidBrush(ptrRange.Color), New Rectangle(m_Center.X - ptrRange.OuterRadius, m_Center.Y - ptrRange.OuterRadius, 2 * ptrRange.OuterRadius, 2 * ptrRange.OuterRadius), rangeStartAngle, rangeSweepAngle)
                End If
            Next

            ggr.SetClip(ClientRectangle)
            If m_BaseArcRadius > 0 Then
                ggr.DrawArc(New Pen(m_BaseArcColor, m_BaseArcWidth), New Rectangle(m_Center.X - m_BaseArcRadius, m_Center.Y - m_BaseArcRadius, 2 * m_BaseArcRadius, 2 * m_BaseArcRadius), m_BaseArcStart, m_BaseArcSweep)
            End If

            Dim valueText As [String] = ""
            Dim boundingBox As SizeF
            Dim countValue As [Single] = 0
            Dim counter1 As Int32 = 0
            While countValue <= (m_MaxValue - m_MinValue)
                valueText = (m_MinValue + countValue).ToString(m_ScaleNumbersFormat)
                ggr.ResetTransform()
                boundingBox = ggr.MeasureString(valueText, Font, -1, StringFormat.GenericTypographic)

                gp.Reset()
                gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesMajorOuterRadius, m_Center.Y - m_ScaleLinesMajorOuterRadius, 2 * m_ScaleLinesMajorOuterRadius, 2 * m_ScaleLinesMajorOuterRadius))
                gp.Reverse()
                gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesMajorInnerRadius, m_Center.Y - m_ScaleLinesMajorInnerRadius, 2 * m_ScaleLinesMajorInnerRadius, 2 * m_ScaleLinesMajorInnerRadius))
                gp.Reverse()
                ggr.SetClip(gp)

                ggr.DrawLine(New Pen(m_ScaleLinesMajorColor, m_ScaleLinesMajorWidth), CType(Center.X, [Single]), CType(Center.Y, [Single]), CType(Center.X + 2 * m_ScaleLinesMajorOuterRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0), [Single]), CType(Center.Y + 2 * m_ScaleLinesMajorOuterRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0), [Single]))

                gp.Reset()
                gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesMinorOuterRadius, m_Center.Y - m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius))
                gp.Reverse()
                gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesMinorInnerRadius, m_Center.Y - m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius))
                gp.Reverse()
                ggr.SetClip(gp)

                If countValue < (m_MaxValue - m_MinValue) Then
                    For counter2 As Int32 = 1 To m_ScaleLinesMinorTicks
                        If ((m_ScaleLinesMinorTicks Mod 2) = 1) AndAlso (CType(m_ScaleLinesMinorTicks \ 2, Int32) + 1 = counter2) Then
                            gp.Reset()
                            gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesInterOuterRadius, m_Center.Y - m_ScaleLinesInterOuterRadius, 2 * m_ScaleLinesInterOuterRadius, 2 * m_ScaleLinesInterOuterRadius))
                            gp.Reverse()
                            gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesInterInnerRadius, m_Center.Y - m_ScaleLinesInterInnerRadius, 2 * m_ScaleLinesInterInnerRadius, 2 * m_ScaleLinesInterInnerRadius))
                            gp.Reverse()
                            ggr.SetClip(gp)

                            ggr.DrawLine(New Pen(m_ScaleLinesInterColor, m_ScaleLinesInterWidth), CType(Center.X, [Single]), CType(Center.Y, [Single]), CType(Center.X + 2 * m_ScaleLinesInterOuterRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (CType((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue, [Single]) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0), [Single]), CType(Center.Y + 2 * m_ScaleLinesInterOuterRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (CType((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue, [Single]) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0), [Single]))

                            gp.Reset()
                            gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesMinorOuterRadius, m_Center.Y - m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius))
                            gp.Reverse()
                            gp.AddEllipse(New Rectangle(m_Center.X - m_ScaleLinesMinorInnerRadius, m_Center.Y - m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius))
                            gp.Reverse()
                            ggr.SetClip(gp)
                        Else
                            ggr.DrawLine(New Pen(m_ScaleLinesMinorColor, m_ScaleLinesMinorWidth), CType(Center.X, [Single]), CType(Center.Y, [Single]), CType(Center.X + 2 * m_ScaleLinesMinorOuterRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (CType((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue, [Single]) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0), [Single]), CType(Center.Y + 2 * m_ScaleLinesMinorOuterRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (CType((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue, [Single]) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0), [Single]))
                        End If
                    Next
                End If

                ggr.SetClip(ClientRectangle)

                If m_ScaleNumbersRotation <> 0 Then
                    ggr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
                    ggr.RotateTransform(90.0F + m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue))
                End If

                ggr.TranslateTransform(CType(Center.X + m_ScaleNumbersRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0F), [Single]), CType(Center.Y + m_ScaleNumbersRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0F), [Single]), System.Drawing.Drawing2D.MatrixOrder.Append)


                If counter1 >= ScaleNumbersStartScaleLine - 1 Then
                    ggr.DrawString(valueText, Font, New SolidBrush(m_ScaleNumbersColor), -boundingBox.Width / 2, -fontBoundY1 - (fontBoundY2 - fontBoundY1 + 1) / 2, StringFormat.GenericTypographic)
                End If

                countValue += m_ScaleLinesMajorStepValue
                counter1 += 1
            End While

            ggr.ResetTransform()
            ggr.SetClip(ClientRectangle)

            If m_ScaleNumbersRotation <> 0 Then
                ggr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            End If

            For Each ptrGaugeLabel As AGaugeLabel In _GaugeLabels
                If Not [String].IsNullOrEmpty(ptrGaugeLabel.Text) Then
                    ggr.DrawString(ptrGaugeLabel.Text, ptrGaugeLabel.Font, New SolidBrush(ptrGaugeLabel.Color), ptrGaugeLabel.Position.X, ptrGaugeLabel.Position.Y, StringFormat.GenericTypographic)
                End If
            Next
        End If

        e.Graphics.DrawImageUnscaled(gaugeBitmap, 0, 0)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

        Dim brushAngle As [Single] = CType(Math.Truncate(m_BaseArcStart + (m_value - m_MinValue) * m_BaseArcSweep / (m_MaxValue - m_MinValue)), Int32) Mod 360
        Dim needleAngle As [Double] = brushAngle * Math.PI / 180

        Select Case m_NeedleType
            Case NeedleType.Advance
                Dim points As PointF() = New PointF(2) {}
                Dim brush1 As Brush = Brushes.White
                Dim brush2 As Brush = Brushes.White
                Dim brush3 As Brush = Brushes.White
                Dim brush4 As Brush = Brushes.White

                Dim brushBucket As Brush = Brushes.White
                Dim subcol As Int32 = CType(Math.Truncate(((brushAngle + 225) Mod 180) * 100 / 180), Int32)
                Dim subcol2 As Int32 = CType(Math.Truncate(((brushAngle + 135) Mod 180) * 100 / 180), Int32)

                e.Graphics.FillEllipse(New SolidBrush(m_NeedleColor2), Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                Select Case m_NeedleColor1
                    Case AGaugeNeedleColor.Gray
                        brush1 = New SolidBrush(Color.FromArgb(80 + subcol, 80 + subcol, 80 + subcol))
                        brush2 = New SolidBrush(Color.FromArgb(180 - subcol, 180 - subcol, 180 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(80 + subcol2, 80 + subcol2, 80 + subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(180 - subcol2, 180 - subcol2, 180 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Gray, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                    Case AGaugeNeedleColor.Red
                        brush1 = New SolidBrush(Color.FromArgb(145 + subcol, subcol, subcol))
                        brush2 = New SolidBrush(Color.FromArgb(245 - subcol, 100 - subcol, 100 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(145 + subcol2, subcol2, subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(245 - subcol2, 100 - subcol2, 100 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Red, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                    Case AGaugeNeedleColor.Green
                        brush1 = New SolidBrush(Color.FromArgb(subcol, 145 + subcol, subcol))
                        brush2 = New SolidBrush(Color.FromArgb(100 - subcol, 245 - subcol, 100 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(subcol2, 145 + subcol2, subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(100 - subcol2, 245 - subcol2, 100 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Green, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                    Case AGaugeNeedleColor.Blue
                        brush1 = New SolidBrush(Color.FromArgb(subcol, subcol, 145 + subcol))
                        brush2 = New SolidBrush(Color.FromArgb(100 - subcol, 100 - subcol, 245 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(subcol2, subcol2, 145 + subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(100 - subcol2, 100 - subcol2, 245 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Blue, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                    Case AGaugeNeedleColor.Magenta
                        brush1 = New SolidBrush(Color.FromArgb(subcol, 145 + subcol, 145 + subcol))
                        brush2 = New SolidBrush(Color.FromArgb(100 - subcol, 245 - subcol, 245 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(subcol2, 145 + subcol2, 145 + subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(100 - subcol2, 245 - subcol2, 245 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Magenta, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                    Case AGaugeNeedleColor.Violet
                        brush1 = New SolidBrush(Color.FromArgb(145 + subcol, subcol, 145 + subcol))
                        brush2 = New SolidBrush(Color.FromArgb(245 - subcol, 100 - subcol, 245 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(145 + subcol2, subcol2, 145 + subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(245 - subcol2, 100 - subcol2, 245 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Violet, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                    Case AGaugeNeedleColor.Yellow
                        brush1 = New SolidBrush(Color.FromArgb(145 + subcol, 145 + subcol, subcol))
                        brush2 = New SolidBrush(Color.FromArgb(245 - subcol, 245 - subcol, 100 - subcol))
                        brush3 = New SolidBrush(Color.FromArgb(145 + subcol2, 145 + subcol2, subcol2))
                        brush4 = New SolidBrush(Color.FromArgb(245 - subcol2, 245 - subcol2, 100 - subcol2))
                        e.Graphics.DrawEllipse(Pens.Violet, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)
                        Exit Select
                End Select

                If Math.Floor(CType(((brushAngle + 225) Mod 360) / 180.0, [Single])) = 0 Then
                    brushBucket = brush1
                    brush1 = brush2
                    brush2 = brushBucket
                End If

                If Math.Floor(CType(((brushAngle + 135) Mod 360) / 180.0, [Single])) = 0 Then
                    brush4 = brush3
                End If

                points(0).X = CType(Center.X + m_NeedleRadius * Math.Cos(needleAngle), [Single])
                points(0).Y = CType(Center.Y + m_NeedleRadius * Math.Sin(needleAngle), [Single])
                points(1).X = CType(Center.X - (m_NeedleRadius \ 20) * Math.Cos(needleAngle), [Single])
                points(1).Y = CType(Center.Y - (m_NeedleRadius \ 20) * Math.Sin(needleAngle), [Single])
                points(2).X = CType(Center.X - (m_NeedleRadius \ 5) * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle + Math.PI / 2), [Single])
                points(2).Y = CType(Center.Y - (m_NeedleRadius \ 5) * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle + Math.PI / 2), [Single])
                e.Graphics.FillPolygon(brush1, points)

                points(2).X = CType(Center.X - (m_NeedleRadius \ 5) * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle - Math.PI / 2), [Single])
                points(2).Y = CType(Center.Y - (m_NeedleRadius \ 5) * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle - Math.PI / 2), [Single])
                e.Graphics.FillPolygon(brush2, points)

                points(0).X = CType(Center.X - (m_NeedleRadius \ 20 - 1) * Math.Cos(needleAngle), [Single])
                points(0).Y = CType(Center.Y - (m_NeedleRadius \ 20 - 1) * Math.Sin(needleAngle), [Single])
                points(1).X = CType(Center.X - (m_NeedleRadius \ 5) * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle + Math.PI / 2), [Single])
                points(1).Y = CType(Center.Y - (m_NeedleRadius \ 5) * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle + Math.PI / 2), [Single])
                points(2).X = CType(Center.X - (m_NeedleRadius \ 5) * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle - Math.PI / 2), [Single])
                points(2).Y = CType(Center.Y - (m_NeedleRadius \ 5) * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle - Math.PI / 2), [Single])
                e.Graphics.FillPolygon(brush4, points)

                points(0).X = CType(Center.X - (m_NeedleRadius \ 20) * Math.Cos(needleAngle), [Single])
                points(0).Y = CType(Center.Y - (m_NeedleRadius \ 20) * Math.Sin(needleAngle), [Single])
                points(1).X = CType(Center.X + m_NeedleRadius * Math.Cos(needleAngle), [Single])
                points(1).Y = CType(Center.Y + m_NeedleRadius * Math.Sin(needleAngle), [Single])

                e.Graphics.DrawLine(New Pen(m_NeedleColor2), Center.X, Center.Y, points(0).X, points(0).Y)
                e.Graphics.DrawLine(New Pen(m_NeedleColor2), Center.X, Center.Y, points(1).X, points(1).Y)
                Exit Select
            Case NeedleType.Simple
                Dim startPoint As New Point(CType(Math.Truncate(Center.X - (m_NeedleRadius \ 8) * Math.Cos(needleAngle)), Int32), CType(Math.Truncate(Center.Y - (m_NeedleRadius \ 8) * Math.Sin(needleAngle)), Int32))
                Dim endPoint As New Point(CType(Math.Truncate(Center.X + m_NeedleRadius * Math.Cos(needleAngle)), Int32), CType(Math.Truncate(Center.Y + m_NeedleRadius * Math.Sin(needleAngle)), Int32))

                e.Graphics.FillEllipse(New SolidBrush(m_NeedleColor2), Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6)

                Select Case m_NeedleColor1
                    Case AGaugeNeedleColor.Gray
                        e.Graphics.DrawLine(New Pen(Color.DarkGray, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.DarkGray, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                    Case AGaugeNeedleColor.Red
                        e.Graphics.DrawLine(New Pen(Color.Red, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.Red, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                    Case AGaugeNeedleColor.Green
                        e.Graphics.DrawLine(New Pen(Color.Green, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.Green, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                    Case AGaugeNeedleColor.Blue
                        e.Graphics.DrawLine(New Pen(Color.Blue, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.Blue, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                    Case AGaugeNeedleColor.Magenta
                        e.Graphics.DrawLine(New Pen(Color.Magenta, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.Magenta, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                    Case AGaugeNeedleColor.Violet
                        e.Graphics.DrawLine(New Pen(Color.Violet, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.Violet, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                    Case AGaugeNeedleColor.Yellow
                        e.Graphics.DrawLine(New Pen(Color.Yellow, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y)
                        e.Graphics.DrawLine(New Pen(Color.Yellow, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y)
                        Exit Select
                End Select
                Exit Select
        End Select
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        drawGaugeBackground = True
        Refresh()
    End Sub

#End Region

End Class

#Region "[ Gauge Range ]"
Public Class AGaugeRangeCollection
    Inherits CollectionBase
    Private Owner As ctlGauge
    Public Sub New(sender As ctlGauge)
        Owner = sender
    End Sub

    Default Public ReadOnly Property Item(index As Integer) As AGaugeRange
        Get
            Return DirectCast(List(index), AGaugeRange)
        End Get
    End Property
    Public Function Contains(itemType As AGaugeRange) As Boolean
        Return List.Contains(itemType)
    End Function
    Public Function Add(itemType As AGaugeRange) As Integer
        itemType.SetOwner(Owner)
        If String.IsNullOrEmpty(itemType.Name) Then
            itemType.Name = GetUniqueName()
        End If
        Return List.Add(itemType)
    End Function
    Public Sub Remove(itemType As AGaugeRange)
        List.Remove(itemType)
    End Sub
    Public Sub Insert(index As Integer, itemType As AGaugeRange)
        itemType.SetOwner(Owner)
        If String.IsNullOrEmpty(itemType.Name) Then
            itemType.Name = GetUniqueName()
        End If
        List.Insert(index, itemType)
    End Sub
    Public Function IndexOf(itemType As AGaugeRange) As Integer
        Return List.IndexOf(itemType)
    End Function
    Public Function FindByName(name As String) As AGaugeRange
        For Each ptrRange As AGaugeRange In List
            If ptrRange.Name = name Then
                Return ptrRange
            End If
        Next
        Return Nothing
    End Function

    Protected Overrides Sub OnInsert(index As Integer, value As Object)
        If String.IsNullOrEmpty(DirectCast(value, AGaugeRange).Name) Then
            DirectCast(value, AGaugeRange).Name = GetUniqueName()
        End If
        MyBase.OnInsert(index, value)
        DirectCast(value, AGaugeRange).SetOwner(Owner)
    End Sub
    Protected Overrides Sub OnRemove(index As Integer, value As Object)
        If Owner IsNot Nothing Then
            Owner.RepaintControl()
        End If
    End Sub
    Protected Overrides Sub OnClear()
        If Owner IsNot Nothing Then
            Owner.RepaintControl()
        End If
    End Sub

    Private Function GetUniqueName() As String
        Const Prefix As String = "GaugeRange"
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
Public Class AGaugeRange
    Public Sub New()
    End Sub
    Public Sub New(color__1 As Color, startValue As [Single], endValue As [Single], innerRadius__2 As Int32, outerRadius__3 As Int32)
        Color = color__1
        _StartValue = startValue
        _EndValue = endValue
        InnerRadius = innerRadius__2
        OuterRadius = outerRadius__3
    End Sub

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Design"), System.ComponentModel.DisplayName("(Name)"), System.ComponentModel.Description("Instance Name.")> _
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String

    <System.ComponentModel.Browsable(False)> _
    Public Property InRange() As [Boolean]
        Get
            Return m_InRange
        End Get
        Set(value As [Boolean])
            m_InRange = Value
        End Set
    End Property
    Private m_InRange As [Boolean]

    Private Owner As ctlGauge
    <System.ComponentModel.Browsable(False)> _
    Public Sub SetOwner(value As ctlGauge)
        Owner = value
    End Sub
    Private Sub NotifyOwner()
        If Owner IsNot Nothing Then
            Owner.RepaintControl()
        End If
    End Sub

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("The color of the range.")> _
    Public Property Color() As Color
        Get
            Return _Color
        End Get
        Set(value As Color)
            _Color = value
            NotifyOwner()
        End Set
    End Property
    Private _Color As Color

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Limits"), System.ComponentModel.Description("The start value of the range, must be less than RangeEndValue.")> _
    Public Property StartValue() As [Single]
        Get
            Return _StartValue
        End Get
        Set(value As [Single])
            If Owner IsNot Nothing Then
                If value < Owner.MinValue Then
                    value = Owner.MinValue
                End If
                If value > Owner.MaxValue Then
                    value = Owner.MaxValue
                End If
            End If
            _StartValue = value
            NotifyOwner()
        End Set
    End Property

    Private _StartValue As [Single]

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Limits"), System.ComponentModel.Description("The end value of the range. Must be greater than RangeStartValue.")> _
    Public Property EndValue() As [Single]
        Get
            Return _EndValue
        End Get
        Set(value As [Single])
            If Owner IsNot Nothing Then
                If value < Owner.MinValue Then
                    value = Owner.MinValue
                End If
                If value > Owner.MaxValue Then
                    value = Owner.MaxValue
                End If
            End If
            _EndValue = value
            NotifyOwner()
        End Set
    End Property

    Private _EndValue As [Single]

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("The inner radius of the range.")> _
    Public Property InnerRadius() As Int32
        Get
            Return _InnerRadius
        End Get
        Set(value As Int32)
            If value > 0 Then
                _InnerRadius = value
                NotifyOwner()
            End If
        End Set
    End Property
    Private _InnerRadius As Int32 = 1

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("The outer radius of the range.")> _
    Public Property OuterRadius() As Int32
        Get
            Return _OuterRadius
        End Get
        Set(value As Int32)
            If value > 0 Then
                _OuterRadius = value
                NotifyOwner()
            End If
        End Set
    End Property
    Private _OuterRadius As Int32 = 2
End Class
#End Region

#Region "[ Gauge Label ]"
Public Class AGaugeLabelCollection
    Inherits CollectionBase
    Private Owner As ctlGauge
    Public Sub New(sender As ctlGauge)
        Owner = sender
    End Sub

    Default Public ReadOnly Property Item(index As Integer) As AGaugeLabel
        Get
            Return DirectCast(List(index), AGaugeLabel)
        End Get
    End Property
    Public Function Contains(itemType As AGaugeLabel) As Boolean
        Return List.Contains(itemType)
    End Function
    Public Function Add(itemType As AGaugeLabel) As Integer
        itemType.SetOwner(Owner)
        If String.IsNullOrEmpty(itemType.Name) Then
            itemType.Name = GetUniqueName()
        End If
        Return List.Add(itemType)
    End Function
    Public Sub Remove(itemType As AGaugeLabel)
        List.Remove(itemType)
    End Sub
    Public Sub Insert(index As Integer, itemType As AGaugeLabel)
        itemType.SetOwner(Owner)
        If String.IsNullOrEmpty(itemType.Name) Then
            itemType.Name = GetUniqueName()
        End If
        List.Insert(index, itemType)
    End Sub
    Public Function IndexOf(itemType As AGaugeLabel) As Integer
        Return List.IndexOf(itemType)
    End Function
    Public Function FindByName(name As String) As AGaugeLabel
        For Each ptrRange As AGaugeLabel In List
            If ptrRange.Name = name Then
                Return ptrRange
            End If
        Next
        Return Nothing
    End Function

    Protected Overrides Sub OnInsert(index As Integer, value As Object)
        If String.IsNullOrEmpty(DirectCast(value, AGaugeLabel).Name) Then
            DirectCast(value, AGaugeLabel).Name = GetUniqueName()
        End If
        MyBase.OnInsert(index, value)
        DirectCast(value, AGaugeLabel).SetOwner(Owner)
    End Sub
    Protected Overrides Sub OnRemove(index As Integer, value As Object)
        If Owner IsNot Nothing Then
            Owner.RepaintControl()
        End If
    End Sub
    Protected Overrides Sub OnClear()
        If Owner IsNot Nothing Then
            Owner.RepaintControl()
        End If
    End Sub

    Private Function GetUniqueName() As String
        Const Prefix As String = "GaugeLabel"
        Dim index As Integer = 1
        While Me.Count <> 0
            For x As Integer = 0 To Me.Count - 1
                If Me(x).Name = (Prefix & index.ToString()) Then
                    Continue For
                Else
                    Return Prefix & index.ToString()
                End If
            Next
            index += 1
        End While


        Return Prefix & index.ToString()
    End Function
End Class
Public Class AGaugeLabel
    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Design"), System.ComponentModel.DisplayName("(Name)"), System.ComponentModel.Description("Instance Name.")> _
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String

    Private Owner As ctlGauge
    <System.ComponentModel.Browsable(False)> _
    Public Sub SetOwner(value As ctlGauge)
        Owner = value
    End Sub
    Private Sub NotifyOwner()
        If Owner IsNot Nothing Then
            Owner.RepaintControl()
        End If
    End Sub

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("The color of the caption text.")> _
    Public Property Color() As Color
        Get
            Return _Color
        End Get
        Set(value As Color)
            _Color = value
            NotifyOwner()
        End Set
    End Property
    Private _Color As Color = Color.FromKnownColor(KnownColor.WindowText)

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("The text of the caption.")> _
    Public Property Text() As [String]
        Get
            Return _Text
        End Get
        Set(value As [String])
            _Text = value
            NotifyOwner()
        End Set
    End Property
    Private _Text As [String]

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("The position of the caption.")> _
    Public Property Position() As Point
        Get
            Return _Position
        End Get
        Set(value As Point)
            _Position = value
            NotifyOwner()
        End Set
    End Property
    Private _Position As Point

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("Font of Text.")> _
    Public Property Font() As Font
        Get
            Return _Font
        End Get
        Set(value As Font)
            _Font = value
            NotifyOwner()
        End Set
    End Property
    Private _Font As Font = System.Windows.Forms.Control.DefaultFont

    Public Sub ResetFont()
        _Font = DefaultFont
    End Sub
    Private Function ShouldSerializeFont() As [Boolean]
        Return (_Font IsNot DefaultFont)
    End Function
    Private Shared DefaultFont As Font = System.Windows.Forms.Control.DefaultFont
End Class
#End Region

#Region "[ Gauge Enum ]"

''' <summary>
''' First needle color
''' </summary>
Public Enum AGaugeNeedleColor
    Gray = 0
    Red = 1
    Green = 2
    Blue = 3
    Yellow = 4
    Violet = 5
    Magenta = 6
End Enum

Public Enum NeedleType
    Advance
    Simple
End Enum

#End Region

' ''' <summary>
' ''' Event argument for <see cref="ValueInRangeChanged"/> event.
' ''' </summary>
Public Class ValueInRangeChangedEventArgs
    Inherits EventArgs
    ''' <summary>
    ''' Affected GaugeRange
    ''' </summary>
    Public Property Range() As AGaugeRange
        Get
            Return m_Range
        End Get
        Private Set(value As AGaugeRange)
            m_Range = Value
        End Set
    End Property
    Private m_Range As AGaugeRange
    ''' <summary>
    ''' Gauge Value
    ''' </summary>
    Public Property Value() As [Single]
        Get
            Return m_Value
        End Get
        Private Set(value As [Single])
            m_Value = Value
        End Set
    End Property
    Private m_Value As [Single]
    ''' <summary>
    ''' True if value is within current range.
    ''' </summary>
    Public Property InRange() As Boolean
        Get
            Return m_InRange
        End Get
        Private Set(value As Boolean)
            m_InRange = Value
        End Set
    End Property
    Private m_InRange As Boolean
    Public Sub New(range As AGaugeRange, value As [Single], inRange As Boolean)
        Me.Range = range
        Me.Value = value
        Me.InRange = inRange
    End Sub
End Class
 

