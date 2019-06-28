Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class Panel
    Inherits System.Windows.Forms.Panel

    Private _UseRound As Boolean = False


    <Category("RoundButton")> _
    <DefaultValue(False)> _
    Property UseRound As Boolean
        Get
            Return _UseRound
        End Get
        Set(value As Boolean)
            If Not _UseRound.Equals(value) Then
                _UseRound = value
                MyBase.Invalidate()
            End If
        End Set
    End Property

    Private _Radius As Integer = 10
    <Category("RoundPannel")> _
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


    Private _GraColor As Color = Color.FromArgb(255, 70, 70, 70)
    Property GraColor As Color
        Get
            Return _GraColor
        End Get
        Set(value As Color) '
            If Not _GraColor.Equals(value) Then
                _GraColor = value
                Me.Invalidate()
            End If

        End Set
    End Property

    Protected Overrides Sub OnPaint(e As Windows.Forms.PaintEventArgs)
        If _UseRound = False Then

            MyBase.OnPaint(e)
        Else
            MyBase.AutoSize = False
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

            Dim Gr As Graphics = e.Graphics
            Gr.Clear(MyBase.BackColor)
            Gr.SmoothingMode = SmoothingMode.AntiAlias

            Dim graFille As New System.Drawing.Drawing2D.LinearGradientBrush(BaseRect, _GraColor, _GraColor, 90)


            Gr.FillPath(graFille, grPath)
            'Gr.FillPath(New SolidBrush(_UnCheckFillColor), grPath)

        End If

    End Sub
End Class
