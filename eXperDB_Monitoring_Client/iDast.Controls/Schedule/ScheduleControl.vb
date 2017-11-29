Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D



Public Class ScheduleControl
    Inherits Control

#Region "Field Declare"
    'Private _ColumnCount As Integer = 7
    Private _StDate As Date = CDate(Now.ToShortDateString)
    'Private _HdrBuffer As Integer = 20
    Private _CellSpacing As Integer = 1



    Private _Items As New ScheduleItemCollection(Me)
    Private _Columns As New ScheduleColumnCollection(Me)
    Private _AutoDate As Boolean = True

#End Region

#Region "Constructor"
    Public Sub New()

        MyBase.New()
        Me._init()



    End Sub
#End Region

#Region "Properties"
    <Category("Data"), _
    Description("The Columns of the control."), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Content), _
    Editor(GetType(System.ComponentModel.Design.CollectionEditor), GetType(Drawing.Design.UITypeEditor))> _
    Public ReadOnly Property Columns() As ScheduleColumnCollection
        Get
            Return Me._Columns
        End Get
    End Property
    <Category("DateData")> _
    Public Property AutoDate() As Boolean
        Get
            Return Me._AutoDate
        End Get
        Set(ByVal value As Boolean)
            Me._AutoDate = value
        End Set
    End Property

    <Category("DateData")> _
    Public Property StartDate() As Date
        Get
            Return Me._StDate
        End Get
        Set(ByVal value As Date)
            If Not Me._StDate.Equals(value) Then

                Me._StDate = CDate(value.ToShortDateString)
                Me.Invalidate()

            End If
        End Set
    End Property


    ReadOnly Property EndDate As Date
        Get
            Return Me._StDate.AddDays(Me._Columns.Count - 1)
        End Get
    End Property

    <Category("Data"), _
   Description("The Item of the control."), _
   DesignerSerializationVisibility(DesignerSerializationVisibility.Content), _
   Editor(GetType(System.ComponentModel.Design.CollectionEditor), GetType(Drawing.Design.UITypeEditor))> _
    Public ReadOnly Property Items() As ScheduleItemCollection
        Get
            Return Me._Items
        End Get

    End Property


    Private _ColumnHeight As Integer = 20
    Property ColumnHeight As Integer
        Get
            Return _ColumnHeight
        End Get
        Set(value As Integer)
            If Not _ColumnHeight.Equals(value) Then
                _ColumnHeight = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _RowHeight As Integer = 20
    Property RowHeight As Integer
        Get
            Return _RowHeight
        End Get
        Set(value As Integer)
            If Not _RowHeight.Equals(value) Then
                _RowHeight = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _HeaderBackColor As Color = SystemColors.Control
    Property HeaderBackColor As Color
        Get
            Return _HeaderBackColor
        End Get
        Set(value As Color)
            If Not _HeaderBackColor.Equals(value) Then
                _HeaderBackColor = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _AlignFlags As ContentAlignment = ContentAlignment.MiddleCenter
    Property AlignFlags As ContentAlignment
        Get
            Return _AlignFlags
        End Get
        Set(value As ContentAlignment)
            If Not _AlignFlags.Equals(value) Then
                _AlignFlags = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _GridColor As Color = Color.WhiteSmoke
    Property GridColor As Color
        Get
            Return _GridColor
        End Get
        Set(value As Color)
            If Not _gridcolor.equals(value) Then
                _gridcolor = value
                Me.Invalidate()

            End If
        End Set
    End Property



    Private _BorderColor As Color = Color.Black
    Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            If Not _Bordercolor.equals(value) Then
                _Bordercolor = value
                Me.Invalidate()

            End If
        End Set
    End Property


#End Region





#Region "Methods"
    Private Sub _init()

        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        'MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'MyBase.SetStyle(ControlStyles.Opaque, True)

        MyBase.SetStyle(DoubleBuffered, True)
        'MyBase.DoubleBuffered = True





        MyBase.Font = System.Drawing.SystemFonts.DefaultFont
        MyBase.BackColor = SystemColors.Window
        MyBase.ForeColor = SystemColors.WindowText
        Me._StDate = CDate(Now.ToShortDateString)
        '_tooltip.SetToolTip(Me, "")



    End Sub

#End Region




    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        'Try
        Dim Gr As Graphics = e.Graphics
        Dim Rect As Rectangle = Me.ClientRectangle

        Gr.Clear(MyBase.BackColor)
        Gr.DrawRectangle(New Pen(_BorderColor), Rect)


        _generateHeaderRect()
        _generateSubHeaderRect()

        _generateDataRect()



        Me._drawColumnHeaders(Gr, Rect)
        Me._drawSubTitle(Gr, Rect)

        Me._drawGridLine(Gr, Rect)


        Me._drawData(Gr)

        Me._drawDataOverlay(Gr, Rect)

        'Catch ex As Exception
        '    MsgBox(ex.ToString)

        'End Try


    End Sub
    Private Sub _drawColumnHeaders(ByVal aGr As Graphics, ByVal Rect As Rectangle)
        If _ColumnHeight > 0 Then



            aGr.FillRectangle(New SolidBrush(SystemColors.Control), _
                            Rect.Left + Me._CellSpacing, _
                            Rect.Top + Me._CellSpacing, _
                            Rect.Width - (Me._CellSpacing * 2), _
                            Me._ColumnHeight)
        End If

        If Me._Columns.Count > 0 Then
            Dim colWidth As Integer = ((Me.Width - (Me._CellSpacing * (Me._Columns.Count - 1) * 2)) / Me._Columns.Count)

            For i As Integer = 0 To Me._Columns.Count - 1
                Dim SCCol As ScheduleColumn = Me._Columns.Item(i)

                Dim ColRect As New Rectangle(((Me._CellSpacing * 2) + colWidth) * i + Me._CellSpacing, Me._CellSpacing, colWidth, Me._ColumnHeight)
                SCCol.SetRectangle(ColRect)
                'aGr.DrawRectangle(New Pen(Brushes.Red), ColRect)
                If _ColumnHeight > 0 AndAlso (ColRect.Left < (Rect.Left + Rect.Width - (Me._CellSpacing * 2))) Then
                    ControlPaint.DrawButton(aGr, ColRect, ButtonState.Normal)
                    aGr.FillRectangle(New SolidBrush(_HeaderBackColor), ColRect)
                    TextRenderer.DrawText(aGr, SCCol.Text, SCCol.Font, ColRect, SCCol.ForeColor, ContentAlignToTextFormatFlag(SCCol.AlignFlags))


                End If
                'Dim tmpRect As New Rectangle(ColRect.X, ColRect.Bottom + Me._CellSpacing, ColRect.Width, Rect.Height - (ColRect.Height + Me._CellSpacing * 2))
                'aGr.FillRectangle(New SolidBrush(SCCol.BackColor), tmpRect)

                
                ' TextRenderer.DrawText(aGr, SCCol.ItemHeaderText, SCCol.itemHeaderFont, tmpRect, Color.FromArgb(SCCol.itemHeaderForeColor.A, SCCol.itemHeaderForeColor.R, SCCol.itemHeaderForeColor.G, SCCol.itemHeaderForeColor.B), ContentAlignToTextFormatFlag(SCCol.ItemHeaderAlignFlags))


            Next
        End If


    End Sub


    Private _SubTitleHeight As Integer = 20

    Property SubTitleHeight As Integer
        Get
            Return _SubTitleHeight
        End Get
        Set(value As Integer)
            If Not _SubTitleHeight.Equals(value) Then
                _SubTitleHeight = value
                Me.Invalidate()
            End If
        End Set
    End Property
    Private Sub _drawDataOverlay(ByVal Gr As Graphics, ByVal Rect As Rectangle)
        If Me._Columns.Count > 0 Then
            For i As Integer = 0 To Me._Columns.Count - 1
                Dim SCCol As ScheduleColumn = Me._Columns(i)
                If SCCol.OverlayClr = True Then
                    Dim colBounds As Rectangle = SCCol.Bounds
                    Dim tmpRect As New Rectangle(colBounds.X, colBounds.Bottom + Me._CellSpacing, colBounds.Width, Rect.Height - (colBounds.Height + Me._CellSpacing * 2))
                    Gr.FillRectangle(New SolidBrush(Color.FromArgb(90, Color.Gray)), tmpRect)
                End If



            Next
        End If
    End Sub
    Private Sub _drawSubTitle(ByVal Gr As Graphics, ByVal Rect As Rectangle)
        If _SubTitleHeight > 0 Then

            ' Gr.FillRectangle(New SolidBrush(Color.Red), New Rectangle(_HeaderRect.X, _HeaderRect.Y + _HeaderRect.Height + _CellSpacing, _HeaderRect.Width, _SubTitleHeight))
        End If

        If Me._Columns.Count > 0 Then
            For i As Integer = 0 To Me._Columns.Count - 1
                Dim SCCol As ScheduleColumn = Me._Columns(i)
                Dim colBounds As Rectangle = SCCol.Bounds
                Dim tmpRect As New Rectangle(colBounds.X, colBounds.Bottom + Me._CellSpacing, colBounds.Width, Rect.Height - (colBounds.Height + Me._CellSpacing * 2))
                Gr.FillRectangle(New SolidBrush(SCCol.BackColor), tmpRect)


                Dim SubTitleRect As Rectangle = New Rectangle(colBounds.X, colBounds.Y + colBounds.Height + _CellSpacing, colBounds.Width, _SubTitleHeight)
                Gr.FillRectangle(New SolidBrush(SCCol.itemHeaderBackColor), SubTitleRect)
                TextRenderer.DrawText(Gr, SCCol.ItemHeaderText, SCCol.itemHeaderFont, SubTitleRect, SCCol.itemHeaderForeColor, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordEllipsis)

            Next
        End If


    End Sub

    Private Sub _drawData(ByVal Gr As Graphics)
        Gr.Clip = New Region(Me._DataRect)
        'Gr.Clip = New Region(New Rectangle(Rect.Left + 2, Rect.Top + 2 + Me._HdrBuffer, Rect.Width - 2, Rect.Height - Me._HdrBuffer - 2))


        If Me.Items.Count > 0 Then
            Dim MaxRectPosition As Integer = -1
            Dim colWidth As Integer = Me.Columns(0).Bounds.Width
            Dim baseDt As Date = Me._StDate



            For i As Integer = 0 To Me.Items.Count - 1

                Dim dtitem As ScheduleItem = Me.Items(i)
                If dtitem.Visible = False Then
                    Dim itmRect As New Rectangle(0, 0, 0, 0)
                    dtitem.SetRectangle(itmRect)

                Else
                    Dim frColidx As Integer = DateDiff(DateInterval.Day, baseDt, IIf(dtitem.FromDate < baseDt, baseDt, dtitem.FromDate))
                    Dim toColidx As Integer = DateDiff(DateInterval.Day, baseDt, IIf(dtitem.ToDate > EndDate, EndDate, dtitem.ToDate))
                    If frColidx > toColidx Then
                        toColidx = frColidx
                    End If

                    Dim itmRect As New Rectangle(0, 0, 0, 0)
                    itmRect.X = Me.Columns(frColidx).Bounds.Left
                    itmRect.Width = Me.Columns(toColidx).Bounds.Right - itmRect.X - Me._CellSpacing
                    Dim EmptyArea As Boolean = False
                    Dim intRow As Integer = 0
                    Do Until EmptyArea
                        Dim tmpY As Integer = Me._DataRect.Y + (Me._CellSpacing * 2) + (intRow * (Me._RowHeight + (Me._CellSpacing * 2)) + ((Me._RowHeight + (Me._CellSpacing * 2)) / 2))
                        Dim tmpEmptyArea As Boolean = True
                        For j As Integer = frColidx To toColidx

                            Dim tmpX As Integer = Me.Columns(j).Bounds.Left + (colWidth / 2)

                            For k As Integer = 0 To i - 1
                                Dim tmpItm As ScheduleItem = Me.Items(k)
                                If tmpItm.Bounds.Width <> 0 Then
                                    If tmpItm.Bounds.Contains(tmpX, tmpY) = True Then
                                        tmpEmptyArea = False
                                        Exit For
                                    End If
                                End If

                            Next
                            If tmpEmptyArea = False Then
                                Exit For
                            End If

                        Next
                        If tmpEmptyArea = True Then
                            EmptyArea = True
                        Else
                            intRow += 1
                        End If
                    Loop
                    itmRect.Y = Me._DataRect.Y + Me._CellSpacing + ((Me._RowHeight + (Me._CellSpacing * 2)) * intRow)
                    itmRect.Height = _RowHeight

                    If MaxRectPosition < itmRect.Y + itmRect.Height + Me._CellSpacing Then
                        MaxRectPosition = itmRect.Y + itmRect.Height + Me._CellSpacing
                    End If
                    dtitem.SetRectangle(itmRect)
                    ' Item Gradatation 
                    'Dim NewBrush As New LinearGradientBrush(itmRect, Color.White, dtitem.BackColor, LinearGradientMode.Vertical)
                    'Gr.FillRectangle(NewBrush, itmRect)

                    ' Round Rectangle 
                    Dim intDiameter As Integer = (_RowHeight \ 4) * 2
                    Dim grPath As New GraphicsPath
                    grPath.AddArc(New Rectangle(itmRect.Left, itmRect.Top, intDiameter, intDiameter), 180, 90)
                    grPath.AddArc(New Rectangle(itmRect.Right - intDiameter, itmRect.Top, intDiameter, intDiameter), 270, 90)
                    grPath.AddArc(New Rectangle(itmRect.Right - intDiameter, itmRect.Bottom - intDiameter, intDiameter, intDiameter), 0, 90)
                    grPath.AddArc(New Rectangle(itmRect.Left, itmRect.Bottom - intDiameter, intDiameter, intDiameter), 90, 90)
                    grPath.CloseAllFigures()


                    Gr.FillPath(New SolidBrush(Color.FromArgb(180, dtitem.BackColor.R, dtitem.BackColor.G, dtitem.BackColor.B)), grPath)
                    Gr.DrawPath(New Pen(dtitem.BackColor), grPath)
                    'Gr.FillRectangle(New SolidBrush(dtitem.BackColor), itmRect)


                    'Gr.DrawRectangle(New Pen(Color.FromArgb(240, 240, 240), 1.0F), itmRect)
                    TextRenderer.DrawText(Gr, dtitem.Text, MyBase.Font, itmRect, MyBase.ForeColor, ContentAlignToTextFormatFlag(_AlignFlags))
                End If
            Next

            If Me.Dock = DockStyle.Fill Then
                If Me.Height < MaxRectPosition + Me._RowHeight + (Me._CellSpacing * 2) Then
                    Me.Height = MaxRectPosition + Me._RowHeight + (Me._CellSpacing * 2)
                End If

            Else
                Me.Height = MaxRectPosition + Me._RowHeight + (Me._CellSpacing * 2)
            End If

        End If


    End Sub


    Private _HeaderRect As Rectangle
    Private _DataRect As Rectangle
    Private _SubTitleRect As Rectangle

    Private Sub _generateHeaderRect()
        Dim Rect As Rectangle = Me.ClientRectangle

        Me._HeaderRect = New Rectangle(Rect.Left + Me._CellSpacing, Rect.Top + Me._CellSpacing, Rect.Width - (Me._CellSpacing * 2), Me._ColumnHeight + Me._CellSpacing)
    End Sub

    Private Sub _generateSubHeaderRect()
        Dim Rect As Rectangle = Me.ClientRectangle
        Me._SubTitleRect = New Rectangle(Rect.Left + Me._CellSpacing, Rect.Top + Me._ColumnHeight + (Me._CellSpacing * 2), Rect.Width - (Me._CellSpacing * 2), _SubTitleHeight)

    End Sub

    Private Sub _generateDataRect()
        Dim Rect As Rectangle = Me.ClientRectangle


        Me._DataRect = New Rectangle(Rect.Left + Me._CellSpacing, Rect.Top + Me._ColumnHeight + (Me._CellSpacing * 2) + _SubTitleHeight, Rect.Width - (Me._CellSpacing * 2), Rect.Height - Me._ColumnHeight - (Me._CellSpacing * 2))
    End Sub

    Private Sub _drawGridLine(ByVal Gr As Graphics, ByVal Rect As Rectangle)
        Gr.Clip = New Region(Rect)
        For i As Integer = 0 To Me._Columns.Count - 2
            Dim colRect As Rectangle = Me._Columns.Item(i).Bounds
            Dim newpen As New Pen(_GridColor, 1.0F)
            ' newpen.DashStyle = Drawing2D.DashStyle.Dash
            Gr.DrawLine(newpen, colRect.Right + Me._CellSpacing, Me._CellSpacing, colRect.Right + Me._CellSpacing, Rect.Bottom)
        Next
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender">ScheduleColumn</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event ColumnHeaderClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender">ScheduleItem</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event ItemClick(ByVal sender As Object, ByVal e As MouseEventArgs)

    Public Event SubTitleClick(ByVal sender As Object, ByVal e As MouseEventArgs)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender">ScheduleColumn</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event ColumnHeaderDBLClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender">ScheduleItem</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event ItemDBLClick(ByVal sender As Object, ByVal e As MouseEventArgs)
    Public Event SubTitleDBLClick(ByVal sender As Object, ByVal e As MouseEventArgs)



    Private _SelItmIdx As Integer = -1
    Private _SelColIdx As Integer = -1
    '<Browsable(False)> _
    Public ReadOnly Property SelectedColumnIndex() As Integer
        Get
            Return Me._SelColIdx
        End Get
    End Property

    Public ReadOnly Property SelectedItemIndex() As Integer
        Get
            Return Me._SelItmIdx
        End Get
    End Property

    Protected Overrides Sub OnLocationChanged(e As EventArgs)
        MyBase.OnLocationChanged(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)


        Me._SelItmIdx = -1
        Me._SelColIdx = -1



        If _HeaderRect.Contains(e.X, e.Y) = True Then
            Dim selIdx As Integer = -1
            For i As Integer = 0 To Me._Columns.Count - 1
                Dim tmpRect As Rectangle = Me._Columns.Item(i).Bounds
                If tmpRect.Contains(e.X, e.Y) Then
                    selIdx = i
                    Exit For

                End If
            Next
            Me._SelColIdx = selIdx
            If selIdx > -1 Then
                If e.Clicks = 1 Then
                    RaiseEvent ColumnHeaderClick(Me, e)
                Else
                    RaiseEvent ColumnHeaderDBLClick(Me, e)
                End If

            End If
        ElseIf _SubTitleRect.Contains(e.X, e.Y) = True Then
            Dim selidx As Integer = -1
            For i As Integer = 0 To Me._Columns.Count - 1
                Dim tmpRect As Rectangle = Me.Columns.Item(i).Bounds
                tmpRect.Offset(0, _ColumnHeight + _CellSpacing)
                tmpRect.Height = _SubTitleHeight
                If tmpRect.Contains(e.X, e.Y) = True Then
                    selidx = i
                    Exit For
                End If
            Next

            Me._SelColIdx = selidx
            If selidx > -1 Then
                If e.Clicks = 1 Then
                    RaiseEvent SubTitleClick(Me, e)
                Else
                    RaiseEvent SubTitleDBLClick(Me, e)
                End If
            End If

        ElseIf _DataRect.Contains(e.X, e.Y) = True Then
            Dim selIdx As Integer = -1
            For i As Integer = 0 To Me._Columns.Count - 1
                Dim tmpRect As Rectangle = Me._Columns.Item(i).Bounds
                If tmpRect.Contains(e.X, Me._CellSpacing) Then
                    selIdx = i
                    Exit For

                End If
            Next
            Me._SelColIdx = selIdx
            Dim itmidx As Integer = -1
            For i As Integer = 0 To Me._Items.Count - 1
                Dim tmpRect As Rectangle = Me._Items.Item(i).Bounds
                If tmpRect.Contains(e.X, e.Y) Then
                    itmidx = i
                    Exit For
                End If
            Next



            Me._SelItmIdx = itmidx
            If itmidx > -1 Then
                If e.Clicks = 1 Then
                    RaiseEvent ItemClick(Me, e)
                Else
                    RaiseEvent ItemDBLClick(Me, e)

                End If


            End If

        End If







    End Sub


    'Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
    '    MyBase.OnGotFocus(e)


    '    Me.Invalidate(Me.ClientRectangle)

    'End Sub

    'Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
    '    MyBase.OnLostFocus(e)
    '    Me.Invalidate(Me.ClientRectangle)
    'End Sub
    Private _tooltip As ToolTip
    
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)


        If Me._tooltip IsNot Nothing AndAlso Me._ShowToolTip AndAlso Me.Items.Count > 0 Then
            For i As Integer = 0 To Items.Count - 1
                If Items.Item(i).Bounds.Contains(e.X, e.Y) = True Then
                    Dim strToolTip As String = Me.Items(i).ToolTipText

                    If Not Me._tooltip.GetToolTip(Me).Equals(strToolTip) Then
                        Me._tooltip.SetToolTip(Me, strToolTip)
                    End If
                End If
            Next
        End If

        MyBase.OnMouseMove(e)

    End Sub

    Private _ShowToolTip As Boolean = True
    Public Property ShowToolTip() As Boolean
        Get
            Return Me._ShowToolTip
        End Get
        Set(ByVal value As Boolean)
            Me._ShowToolTip = value
        End Set
    End Property
    Protected Overrides Sub OnMouseWheel(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseWheel(e)

    End Sub

    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        MyBase.OnClick(e)
        Me.Focus()

    End Sub


    Private Function ContentAlignToTextFormatFlag(ByVal Align As ContentAlignment) As TextFormatFlags

        Dim FormatFlag As New TextFormatFlags

        Select Case Align
            Case ContentAlignment.TopLeft
                FormatFlag = TextFormatFlags.Left Or TextFormatFlags.Top
            Case ContentAlignment.TopCenter
                FormatFlag = TextFormatFlags.Top Or TextFormatFlags.HorizontalCenter
            Case ContentAlignment.TopRight
                FormatFlag = TextFormatFlags.Top Or TextFormatFlags.Right
            Case ContentAlignment.MiddleLeft
                FormatFlag = TextFormatFlags.VerticalCenter Or TextFormatFlags.Left
            Case ContentAlignment.MiddleCenter
                FormatFlag = TextFormatFlags.VerticalCenter Or TextFormatFlags.HorizontalCenter
            Case ContentAlignment.MiddleRight
                FormatFlag = TextFormatFlags.VerticalCenter Or TextFormatFlags.Right
            Case ContentAlignment.BottomLeft
                FormatFlag = TextFormatFlags.Bottom Or TextFormatFlags.Left
            Case ContentAlignment.BottomCenter
                FormatFlag = TextFormatFlags.Bottom Or TextFormatFlags.HorizontalCenter
            Case ContentAlignment.BottomRight
                FormatFlag = TextFormatFlags.Bottom Or TextFormatFlags.Right
        End Select
        FormatFlag = FormatFlag Or TextFormatFlags.WordEllipsis
        Return FormatFlag
    End Function

    Private Sub ScheduleControl_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Refresh()
    End Sub


    Public Sub SetToolTipCtl(ByVal ToolTipCtl As ToolTip)
        Me._tooltip = ToolTipCtl
    End Sub
End Class
