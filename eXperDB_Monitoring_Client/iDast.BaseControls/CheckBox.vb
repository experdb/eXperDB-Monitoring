Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class CheckBox
    Inherits System.Windows.Forms.CheckBox
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


    Private _LineColor As Color = Color.Gray
    <Category("RoundButton")> _
    Property LineColor As Color
        Get
            Return _LineColor
        End Get
        Set(value As Color)
            If Not _LineColor.Equals(value) Then
                _LineColor = value
                MyBase.Invalidate()

            End If
        End Set
    End Property


    Private _UnCheckFillColor As Color = Color.FromArgb(255, 64, 64, 64)
    <Category("RoundButton")> _
    Property UnCheckFillColor As Color
        Get
            Return _UnCheckFillColor
        End Get
        Set(value As Color)
            If Not _UnCheckFillColor.Equals(value) Then
                _UnCheckFillColor = value
                MyBase.Invalidate()

            End If
        End Set
    End Property


    Private _CheckFillColor As Color = Color.FromArgb(255, 127, 127, 127)
    <Category("RoundButton")> _
    Property CheckFillColor As Color
        Get
            Return _CheckFillColor
        End Get
        Set(value As Color)
            If Not _CheckFillColor.Equals(value) Then
                _CheckFillColor = value
                MyBase.Invalidate()
            End If
        End Set
    End Property

    Private _Radius As Integer = 10
    <Category("RoundButton")> _
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

    Protected Overrides Sub OnPaint(pevent As Windows.Forms.PaintEventArgs)


        If _UseRound = False Then

            MyBase.OnPaint(pevent)
        Else

            MyBase.Appearance = Windows.Forms.Appearance.Button
            MyBase.AutoSize = False
            Dim BaseRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
            Dim intDiameter As Integer = _Radius * 2
            BaseRect.Inflate(-1, -1)

            Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
            grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y, intDiameter, intDiameter), 180, 90)
            grPath.AddLine(New Point(BaseRect.X + _Radius, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y))
            grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - intDiameter, BaseRect.Y, intDiameter, intDiameter), 270, 90)
            grPath.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + _Radius), New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + BaseRect.Height - _Radius))
            grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - intDiameter, BaseRect.Y + BaseRect.Height - intDiameter, intDiameter, intDiameter), 0, 90)
            grPath.AddLine(New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y + BaseRect.Height), New Point(BaseRect.X + _Radius, BaseRect.Y + BaseRect.Height))
            grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y + BaseRect.Height - intDiameter, intDiameter, intDiameter), 90, 90)
            grPath.CloseAllFigures()


            Dim Gr As Graphics = pevent.Graphics
            Gr.Clear(MyBase.BackColor)
            Gr.SmoothingMode = SmoothingMode.AntiAlias


            If MyBase.Checked Then
                Gr.FillPath(New SolidBrush(_CheckFillColor), grPath)
            Else
                Gr.FillPath(New SolidBrush(_UnCheckFillColor), grPath)
            End If

            Gr.DrawPath(New Pen(_LineColor, 1), grPath)





            ' DrawString 
            Dim strText As String = MyBase.Text
            Dim txtRect As Rectangle = BaseRect
            txtRect.Inflate(_Radius / 2 * -1, _Radius / 2 * -1)

            Dim txtSize As SizeF = Gr.MeasureString(strText, MyBase.Font)

            Dim tmpWid As Single = 0
            Dim tmphgt As Single = 0
            Dim NewStr As String = ""


            For Each tmpStr As Char In strText.ToCharArray
                Dim Szf As SizeF = Gr.MeasureString(tmpStr.ToString, MyBase.Font)
                If tmpWid + Szf.Width <= txtRect.Width Then
                    NewStr += tmpStr.ToString
                    tmpWid += Szf.Width
                Else

                    If tmphgt + Szf.Height <= txtRect.Height Then
                        NewStr += vbCrLf & tmpStr.ToString
                        tmpWid = Szf.Width
                        tmphgt += Szf.Height
                    Else
                        Exit For
                    End If
                End If


            Next
            'Dim incHgt As Single = 0
            'For Each tmpStr As String In Split(NewStr, vbCrLf)
            '    Dim szf As SizeF = Gr.MeasureString(tmpStr, MyBase.Font)
            '    Dim tmpL As Single = txtRect.Left + (txtRect.Width - szf.Width) / 2
            '    Gr.DrawString(tmpStr, MyBase.Font, New SolidBrush(MyBase.ForeColor), New Point(tmpL, txtRect.Top + incHgt))
            '    incHgt += szf.Height

            'Next
            Dim txtFormatFlags As Windows.Forms.TextFormatFlags = Windows.Forms.TextFormatFlags.HorizontalCenter Or Windows.Forms.TextFormatFlags.VerticalCenter Or Windows.Forms.TextFormatFlags.WordEllipsis
            Windows.Forms.TextRenderer.DrawText(Gr, MyBase.Text, MyBase.Font, txtRect, MyBase.ForeColor, txtFormatFlags)

 


        End If


    End Sub


    Private Sub OnMouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Cursor = Windows.Forms.Cursors.Hand
    End Sub
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CheckBox
        '
        Me.ResumeLayout(False)

    End Sub
End Class
