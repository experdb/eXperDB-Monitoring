Imports System.Drawing.Drawing2D
<System.ComponentModel.DefaultEvent("ButtonConfigClick")> _
Public Class FormControlBox
    Inherits System.Windows.Forms.Control
    Private _btnSize As Integer = 20
    Private _Spacing As Integer = 1
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.Width = (_btnSize + _Spacing * 2) * _ShowRectCnt + 1
        MyBase.Height = _btnSize + _Spacing * 2
    End Sub
    Private _ShowRectCnt As Integer = 9
    <System.ComponentModel.Category("CUSTOM")> _
    Property ShowRectCnt As Integer
        Get
            Return _ShowRectCnt
        End Get
        Set(value As Integer)
            _ShowRectCnt = value
            Me.OnResize(Nothing)
        End Set
    End Property




    Private _MinBox As Rectangle = Nothing
    Private _MaxBox As Rectangle = Nothing
    Private _CloseBox As Rectangle = Nothing
    Private _DualBox As Rectangle = Nothing
    Private _ConfigBox As Rectangle = Nothing
    Private _LockBox As Rectangle = Nothing
    Private _CriticalBox As Rectangle = Nothing
    Private _RotationBox As Rectangle = Nothing
    Private _PowerBox As Rectangle = Nothing

    Property MinBox As Rectangle
        Get
            Return _MinBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property MaxBox As Rectangle
        Get
            Return _MaxBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property CloseBox As Rectangle
        Get
            Return _CloseBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property DualBox As Rectangle
        Get
            Return _DualBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property ConfigBox As Rectangle
        Get
            Return _ConfigBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property LockBox As Rectangle
        Get
            Return _LockBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property CriticalBox As Rectangle
        Get
            Return _CriticalBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property RotationBox As Rectangle
        Get
            Return _RotationBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property
    Property PowerBox As Rectangle
        Get
            Return _PowerBox
        End Get
        Set(value As Rectangle)
        End Set
    End Property

    Private _UseConfigBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseConfigBox As Boolean
        Get
            Return _UseConfigBox
        End Get
        Set(value As Boolean)
            If Not Me._UseConfigBox.Equals(value) Then
                _UseConfigBox = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _UseMinBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseMinBox As Boolean
        Get
            Return _UseMinBox
        End Get
        Set(value As Boolean)
            If Not Me._UseMinBox.Equals(value) Then
                _UseMinBox = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _UseMaxBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseMaxBox As Boolean
        Get
            Return _UseMaxBox
        End Get
        Set(value As Boolean)
            If Not Me._UseMaxBox.Equals(value) Then
                _UseMaxBox = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _UseDualBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseDualBox As Boolean
        Get
            Return _UseDualBox
        End Get
        Set(value As Boolean)
            If Not _UseDualBox.Equals(value) Then
                _UseDualBox = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _UseLockBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseLockBox As Boolean
        Get
            Return _UseLockBox
        End Get
        Set(value As Boolean)
            If Not _UseLockBox.Equals(value) Then
                _UseLockBox = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _isLock As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property isLock As Boolean
        Get
            Return _isLock
        End Get
        Set(value As Boolean)
            If Not _isLock.Equals(value) Then
                _isLock = value
                Me.Invalidate()

            End If
        End Set
    End Property

    Private _UseCriticalBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseCriticalBox As Boolean
        Get
            Return _UseCriticalBox
        End Get
        Set(value As Boolean)
            If Not _UseCriticalBox.Equals(value) Then
                _UseCriticalBox = value
                Me.Invalidate()

            End If
        End Set
    End Property

    Private _isCritical As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property isCritical As Boolean
        Get
            Return _isCritical
        End Get
        Set(value As Boolean)
            If Not _isCritical.Equals(value) Then
                _isCritical = value
                Me.Invalidate()

            End If
        End Set
    End Property

    Private _UseRotationBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseRotationBox As Boolean
        Get
            Return _UseRotationBox
        End Get
        Set(value As Boolean)
            If Not _UseRotationBox.Equals(value) Then
                _UseRotationBox = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _isRotation As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property isRotation As Boolean
        Get
            Return _isRotation
        End Get
        Set(value As Boolean)
            If Not _isRotation.Equals(value) Then
                _isRotation = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _UsePowerBox As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property UsePowerBox As Boolean
        Get
            Return _UsePowerBox
        End Get
        Set(value As Boolean)
            If Not _UsePowerBox.Equals(value) Then
                _UsePowerBox = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _isPower As Boolean = True
    <System.ComponentModel.Category("CUSTOM")> _
    Property isPower As Boolean
        Get
            Return _isPower
        End Get
        Set(value As Boolean)
            If Not _isPower.Equals(value) Then
                _isPower = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _LEDColor As Color = Color.Lime
    <System.ComponentModel.Category("CUSTOM")> _
    Property LEDColor As Color
        Get
            Return _LEDColor
        End Get
        Set(value As Color)
            If Not _LEDColor.Equals(value) Then
                Me.Invalidate()
            End If
        End Set
    End Property





    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim Gr As Graphics = e.Graphics
        Gr.SmoothingMode = SmoothingMode.AntiAlias
        Gr.Clear(MyBase.BackColor)
        Dim PenClr As Color = MyBase.ForeColor
        Dim BaseRect As New Rectangle(MyBase.Width - _btnSize - _Spacing - 1, _Spacing, _btnSize, _btnSize)

        _CloseBox = BaseRect
        If _UseDualBox = True AndAlso System.Windows.Forms.Screen.AllScreens.Count > 1 Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _DualBox = BaseRect
        Else
            _DualBox = Nothing
        End If
        If _UseMaxBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _MaxBox = BaseRect
        Else
            _MaxBox = Nothing
        End If

        If _UseMinBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _MinBox = BaseRect
        Else
            _MinBox = Nothing
        End If

        If _UseConfigBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _ConfigBox = BaseRect
        Else
            _ConfigBox = Nothing
        End If


        If _UseLockBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _LockBox = BaseRect
        Else
            _LockBox = Nothing
        End If

        If _UseCriticalBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _CriticalBox = BaseRect
        Else
            _CriticalBox = Nothing
        End If


        If _UseRotationBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _RotationBox = BaseRect
        Else
            _RotationBox = Nothing
        End If

        If _UsePowerBox = True Then
            BaseRect.Offset((_btnSize + _Spacing * 2) * -1, 0)
            _PowerBox = BaseRect
        Else
            _PowerBox = Nothing
        End If



        ' Close Box 
        Gr.DrawRectangle(New Pen(PenClr), _CloseBox)
        Dim tmpCloseBox As Rectangle = _CloseBox
        tmpCloseBox.Inflate(-3, -3)
        Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpCloseBox.Left, tmpCloseBox.Top), New Point(tmpCloseBox.Right, tmpCloseBox.Top + tmpCloseBox.Height))
        Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpCloseBox.Left, tmpCloseBox.Top + tmpCloseBox.Height), New Point(tmpCloseBox.Right, tmpCloseBox.Top))


        ' MultiWindow 

        If _UseDualBox = True AndAlso System.Windows.Forms.Screen.AllScreens.Count > 1 Then
            Gr.DrawRectangle(New Pen(PenClr, 1), _DualBox)
            Dim LRect As Rectangle = New Rectangle(_DualBox.Left + 3, _DualBox.Top + 3, (_btnSize / 2 - _Spacing - 3), _btnSize - 3 * 2)


            Gr.DrawRectangle(New Pen(PenClr, 1), LRect)
            Gr.DrawLine(New Pen(PenClr, 2), New Point(LRect.Left, LRect.Top + 2), New Point(LRect.Right, LRect.Top + 2))
            LRect.Offset(LRect.Width + _Spacing * 2, 0)
            Gr.DrawRectangle(New Pen(PenClr, 1), LRect)
            Gr.DrawLine(New Pen(PenClr, 2), New Point(LRect.Left, LRect.Top + 2), New Point(LRect.Right, LRect.Top + 2))


        End If


        ' Max Box
        Gr.DrawRectangle(New Pen(PenClr), _MaxBox)
        If _UseMaxBox = True AndAlso MyBase.FindForm IsNot Nothing Then

            If MyBase.FindForm.WindowState = FormWindowState.Maximized Then

                Dim tmpSmallBox As Rectangle = _MaxBox
                tmpSmallBox.Inflate(-5, -5)
                tmpSmallBox.Offset(2, -2)

                Gr.DrawRectangle(New Pen(PenClr, 1), tmpSmallBox)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpSmallBox.Left, tmpSmallBox.Top + 2), New Point(tmpSmallBox.Right, tmpSmallBox.Top + 2))
                tmpSmallBox.Offset(-4, +4)
                Gr.FillRectangle(New SolidBrush(MyBase.BackColor), tmpSmallBox)
                Gr.DrawRectangle(New Pen(PenClr, 1), tmpSmallBox)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpSmallBox.Left, tmpSmallBox.Top + 2), New Point(tmpSmallBox.Right, tmpSmallBox.Top + 2))
            Else
                Dim tmpMaxBox As Rectangle = _MaxBox
                tmpMaxBox.Inflate(-3, -3)
                Gr.DrawRectangle(New Pen(PenClr, 1), tmpMaxBox)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpMaxBox.Left, tmpMaxBox.Top + 2), New Point(tmpMaxBox.Right, tmpMaxBox.Top + 2))

            End If
        End If

        ' Min Box
        If _UseMinBox = True Then
            Gr.DrawRectangle(New Pen(PenClr), _MinBox)
            Dim tmpMinBox As Rectangle = _MinBox
            tmpMinBox.Inflate(-3, -3)
            Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpMinBox.Left, tmpMinBox.Top + tmpMinBox.Height), New Point(tmpMinBox.Right, tmpMinBox.Top + tmpMinBox.Height))
        End If

        ' Config Box 
        If _UseConfigBox = True Then
            Gr.DrawRectangle(New Pen(PenClr), _ConfigBox)
            Dim tmpConfigBox As Rectangle = _ConfigBox
            tmpConfigBox.Inflate(-2, -2)
            Dim grPath As New Drawing2D.GraphicsPath
            grPath.AddLine(New Point(tmpConfigBox.Left + tmpConfigBox.Width / 2, tmpConfigBox.Top), New Point(tmpConfigBox.Left + tmpConfigBox.Width / 2, tmpConfigBox.Top + tmpConfigBox.Height))
            Gr.DrawPath(New Pen(PenClr, 3), grPath)
            Dim RotateMatr As New Drawing2D.Matrix
            RotateMatr.RotateAt(45, New Point(tmpConfigBox.Left + (tmpConfigBox.Width / 2), tmpConfigBox.Top + (tmpConfigBox.Height / 2)))
            For i As Integer = 0 To 2
                grPath.Transform(RotateMatr)
                Gr.DrawPath(New Pen(PenClr, 3), grPath)
            Next
            tmpConfigBox.Inflate(-3, -3)
            Gr.FillEllipse(New SolidBrush(PenClr), tmpConfigBox)
            tmpConfigBox.Inflate(-2, -2)
            Gr.FillEllipse(New SolidBrush(MyBase.BackColor), tmpConfigBox)


        End If



        ' Lock Box 
        If _UseLockBox = True Then
            Gr.DrawRectangle(New Pen(PenClr), _LockBox)
            Dim tmpgrPAth As New Drawing2D.GraphicsPath

            Dim tmpLockBox As Rectangle = _LockBox
            tmpLockBox.Inflate(-2, -6)
            tmpLockBox.Offset(0, 4)
            Gr.FillRectangle(New SolidBrush(PenClr), tmpLockBox)
            Dim tmpLockBox2 As Rectangle = tmpLockBox
            tmpLockBox2.Inflate(-3, -3)
            Gr.FillEllipse(New SolidBrush(MyBase.BackColor), tmpLockBox2)
            tmpLockBox2.Inflate(1, 1)

            If _isLock = True Then

                tmpLockBox2.Offset(0, -8)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpLockBox2.X, tmpLockBox.Top), New Point(tmpLockBox2.X, tmpLockBox2.Top + 1))
                Gr.DrawArc(New Pen(PenClr, 2), tmpLockBox2, 180, 180)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpLockBox2.X + tmpLockBox2.Width, tmpLockBox2.Top + 1), New Point(tmpLockBox2.X + tmpLockBox2.Width, tmpLockBox.Top))
            Else

                tmpLockBox2.Offset(0, -10)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpLockBox2.X, tmpLockBox.Top - 2), New Point(tmpLockBox2.X, tmpLockBox2.Top + 1))
                Gr.DrawArc(New Pen(PenClr, 2), tmpLockBox2, 180, 180)
                Gr.DrawLine(New Pen(PenClr, 2), New Point(tmpLockBox2.X + tmpLockBox2.Width, tmpLockBox2.Top + 1), New Point(tmpLockBox2.X + tmpLockBox2.Width, tmpLockBox.Top))
            End If

        End If


        If _UseCriticalBox = True Then
            Gr.DrawRectangle(New Pen(PenClr), _CriticalBox)

            Dim tmpCriBox As Rectangle = _CriticalBox
            tmpCriBox.Inflate(-2, -2)
            Dim tmpGrPath As New Drawing2D.GraphicsPath

            tmpGrPath.AddLine(New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y), New Point(tmpCriBox.X, tmpCriBox.Y + 3))
            tmpGrPath.AddLine(New Point(tmpCriBox.X, tmpCriBox.Y + 3), New Point(tmpCriBox.X + 3, tmpCriBox.Y + tmpCriBox.Height - 3))
            tmpGrPath.AddLine(New Point(tmpCriBox.X + 3, tmpCriBox.Y + tmpCriBox.Height - 3), New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y + tmpCriBox.Height))
            tmpGrPath.AddLine(New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y + tmpCriBox.Height), New Point(tmpCriBox.X + tmpCriBox.Width - 3, tmpCriBox.Y + tmpCriBox.Height - 3))
            tmpGrPath.AddLine(New Point(tmpCriBox.X + tmpCriBox.Width - 3, tmpCriBox.Y + tmpCriBox.Height - 3), New Point(tmpCriBox.X + tmpCriBox.Width, tmpCriBox.Y + 3))
            'tmpGrPath.AddLine(New Point(tmpCriBox.X + tmpCriBox.Width, tmpCriBox.Y + 3), New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y))
            tmpGrPath.CloseFigure()




            Gr.FillPath(New SolidBrush(PenClr), tmpGrPath)

            'Gr.DrawLine(New Pen(PenClr), New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y), New Point(tmpCriBox.X, tmpCriBox.Y + 3))
            'Gr.DrawLine(New Pen(PenClr), New Point(tmpCriBox.X, tmpCriBox.Y + 3), New Point(tmpCriBox.X + 3, tmpCriBox.Y + tmpCriBox.Height - 3))
            'Gr.DrawLine(New Pen(PenClr), New Point(tmpCriBox.X + 3, tmpCriBox.Y + tmpCriBox.Height - 3), New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y + tmpCriBox.Height))
            'Gr.DrawLine(New Pen(PenClr), New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y + tmpCriBox.Height), New Point(tmpCriBox.X + tmpCriBox.Width - 3, tmpCriBox.Y + tmpCriBox.Height - 3))
            'Gr.DrawLine(New Pen(PenClr), New Point(tmpCriBox.X + tmpCriBox.Width - 3, tmpCriBox.Y + tmpCriBox.Height - 3), New Point(tmpCriBox.X + tmpCriBox.Width, tmpCriBox.Y + 3))
            'Gr.DrawLine(New Pen(PenClr), New Point(tmpCriBox.X + tmpCriBox.Width, tmpCriBox.Y + 3), New Point(tmpCriBox.X + tmpCriBox.Width / 2, tmpCriBox.Y))
            If _isCritical = True Then
                'Gr.DrawLine(New Pen(BackColor, 2), New Point(tmpCriBox.X + 5, tmpCriBox.Y + 6), New Point(tmpCriBox.X + tmpCriBox.Width / 2 - 1, tmpCriBox.Y + tmpCriBox.Height - 4))
                'Gr.DrawLine(New Pen(BackColor, 2), New Point(tmpCriBox.X + tmpCriBox.Width / 2 - 1, tmpCriBox.Y + tmpCriBox.Height - 4), New Point(tmpCriBox.X + tmpCriBox.Width - 4, tmpCriBox.Y + 4))
                Gr.DrawLine(New Pen(BackColor, 2), New Point(tmpCriBox.X + 5, tmpCriBox.Y + 6), New Point(tmpCriBox.X + tmpCriBox.Width / 2 - 1, tmpCriBox.Y + tmpCriBox.Height - 4))
                Gr.DrawLine(New Pen(BackColor, 2), New Point(tmpCriBox.X + tmpCriBox.Width / 2 - 1, tmpCriBox.Y + tmpCriBox.Height - 4), New Point(tmpCriBox.X + tmpCriBox.Width - 4, tmpCriBox.Y + 4))

            Else

                Gr.DrawLine(New Pen(BackColor, 2), New Point(tmpCriBox.X + 4, tmpCriBox.Y + 4), New Point(tmpCriBox.X + tmpCriBox.Width - 4, tmpCriBox.Y + tmpCriBox.Height - 4))
                Gr.DrawLine(New Pen(BackColor, 2), New Point(tmpCriBox.X + 4, tmpCriBox.Y + tmpCriBox.Height - 4), New Point(tmpCriBox.X + tmpCriBox.Width - 4, tmpCriBox.Y + 4))
            End If


        End If

        ' Rotation Box

        If _UseRotationBox = True Then
            Gr.DrawRectangle(New Pen(PenClr), _RotationBox)
            Dim tmpRotBox As Rectangle = _RotationBox
            Dim tmpGrPath As New GraphicsPath

            tmpRotBox.Inflate(-2, -2)
            tmpGrPath.AddArc(tmpRotBox, 0, -270)

            tmpRotBox.Inflate(-3, -3)
            tmpGrPath.AddArc(tmpRotBox, 140, 180)
            'tmpGrPath.CloseFigure()

            Dim myArray As Point() = {New Point(tmpRotBox.X + tmpRotBox.Width / 2 + 5, 11), New Point(tmpRotBox.X + tmpRotBox.Width / 2 + 1, 11), _
                                      New Point(tmpRotBox.X + tmpRotBox.Width / 2 + 6, 16), New Point(tmpRotBox.X + tmpRotBox.Width / 2 + 8, 11)}
            tmpGrPath.AddLines(myArray)
            tmpGrPath.CloseFigure()
            Gr.DrawPath(New Pen(PenClr, 1), tmpGrPath)
            If _isRotation = True Then
                Gr.FillPath(New SolidBrush(_LEDColor), tmpGrPath)
            Else
                Gr.FillPath(New SolidBrush(BackColor), tmpGrPath)
            End If
            Gr.DrawPath(New Pen(PenClr, 1), tmpGrPath)
        End If

        ' Power Box
        If _UsePowerBox = True Then
            Gr.DrawRectangle(New Pen(PenClr), _PowerBox)
            Dim tmpPwBox As Rectangle = _PowerBox


            Dim tmpGrPath As New GraphicsPath


            tmpPwBox.Inflate(-2, -2)
            tmpGrPath.AddArc(tmpPwBox, 300, 300)
            'Gr.DrawArc(New Pen(Brushes.Red), tmpPwBox, 300, 300)



            tmpPwBox.Inflate(-4, -4)
            tmpGrPath.AddArc(tmpPwBox, 180, -180)
            'Gr.DrawArc(New Pen(Brushes.Red), tmpPwBox, 225, -270)
            tmpGrPath.CloseFigure()

            Dim tmpRect As Rectangle = New Rectangle(_PowerBox.X + _PowerBox.Width / 2 - 2, _PowerBox.Y + 1, 4, 9)

            tmpGrPath.AddRectangle(tmpRect)
            tmpGrPath.CloseFigure()



            If _isPower = True Then
                'Dim GraBrush As New Drawing2D.PathGradientBrush(tmpGrPath)
                'GraBrush.CenterPoint = New Point(_PowerBox.Left + _PowerBox.Width / 2, _PowerBox.Top + _PowerBox.Height / 2)
                'GraBrush.CenterColor = _LEDColor
                'GraBrush.SurroundColors = New Color() {BackColor}

                'Gr.FillPath(GraBrush, tmpGrPath)
                Gr.FillPath(New SolidBrush(_LEDColor), tmpGrPath)
            Else
                Gr.FillPath(New SolidBrush(BackColor), tmpGrPath)
            End If

            Gr.DrawPath(New Pen(PenClr, 1), tmpGrPath)




        End If


        Dim selPt As Point = Me.PointToClient(Control.MousePosition)
        Dim ActSel As New Rectangle(0, 0, 0, 0)
        If _ConfigBox.Contains(selPt) Then
            ActSel = _ConfigBox
        ElseIf _MinBox.Contains(selPt) Then
            ActSel = _MinBox
        ElseIf _MaxBox.Contains(selPt) Then
            ActSel = _MaxBox
        ElseIf _DualBox.Contains(selPt) Then
            ActSel = _DualBox
        ElseIf _CloseBox.Contains(selPt) Then
            ActSel = _CloseBox
        ElseIf _LockBox.Contains(selPt) Then
            ActSel = _LockBox
        ElseIf _CriticalBox.Contains(selPt) Then
            ActSel = _CriticalBox
        ElseIf _RotationBox.Contains(selPt) Then
            ActSel = _RotationBox
        ElseIf _PowerBox.Contains(selPt) Then
            ActSel = _PowerBox
        End If

        If ActSel.Width > 0 Then
            Gr.FillRectangle(New SolidBrush(Color.FromArgb(128, 255, 255, 255)), ActSel)
        End If





    End Sub
    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)

        MyBase.OnMouseMove(e)
        Me.Cursor = Cursors.Default
        Me.Invalidate()
    End Sub
    Public Event ButtonConfigClick(ByVal sender As Object, ByVal e As Rectangle)
    Public Event ButtonLockClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    Public Event ButtonCriticalClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    Public Event ButtonCloseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    Public Event ButtonRotationClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    Public Event ButtonPowerClick(ByVal sender As Object, ByVal e As MouseEventArgs)




    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)

        Dim tmpPt As New Point(e.X, e.Y)
        If Me._ConfigBox.Contains(tmpPt) Then
            RaiseEvent ButtonConfigClick(Me, RectangleToScreen(_ConfigBox))
        ElseIf Me._MinBox.Contains(tmpPt) Then
            MyBase.FindForm.WindowState = FormWindowState.Minimized
        ElseIf Me._MaxBox.Contains(tmpPt) Then


            If MyBase.FindForm.WindowState = FormWindowState.Normal Then
                MyBase.FindForm.WindowState = FormWindowState.Maximized
            Else
                MyBase.FindForm.WindowState = FormWindowState.Normal
            End If
        ElseIf Me._DualBox.Contains(tmpPt) Then
            Dim Bret As Boolean = False
            If MyBase.FindForm.WindowState = FormWindowState.Maximized Then
                MyBase.FindForm.WindowState = FormWindowState.Normal
                Bret = True
            End If

            Dim scPt As Point = MyBase.FindForm.PointToScreen(New Point(e.X, e.Y))
            Dim sc As Screen = System.Windows.Forms.Screen.FromPoint(scPt)
            Dim intSelSc As Integer = -1
            For i As Integer = 0 To System.Windows.Forms.Screen.AllScreens.Count - 1
                Dim tmpSc As Screen = System.Windows.Forms.Screen.AllScreens(i)

                If tmpSc.Equals(sc) Then
                    If i + 1 > System.Windows.Forms.Screen.AllScreens.Count - 1 Then
                        intSelSc = 0
                    Else
                        intSelSc = i + 1
                    End If
                    Exit For
                End If
            Next

            MyBase.FindForm.Location = System.Windows.Forms.Screen.AllScreens(intSelSc).Bounds.Location


            If Bret Then
                MyBase.FindForm.WindowState = FormWindowState.Maximized
            End If

        ElseIf Me._CloseBox.Contains(tmpPt) Then
            RaiseEvent ButtonCloseClick(Me, e)
            If MyBase.FindForm IsNot Nothing Then
                MyBase.FindForm.Close()
            End If

        ElseIf Me._LockBox.Contains(tmpPt) Then
            RaiseEvent ButtonLockClick(Me, e)
        ElseIf Me._CriticalBox.Contains(tmpPt) Then
            RaiseEvent ButtonCriticalClick(Me, e)

        ElseIf Me._RotationBox.Contains(tmpPt) Then
            RaiseEvent ButtonRotationClick(Me, e)

        ElseIf Me._PowerBox.Contains(tmpPt) Then
            RaiseEvent ButtonPowerClick(Me, e)

        End If



    End Sub




    Public Sub New()
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)





        MyBase.SetStyle(DoubleBuffered, True)
    End Sub
End Class
