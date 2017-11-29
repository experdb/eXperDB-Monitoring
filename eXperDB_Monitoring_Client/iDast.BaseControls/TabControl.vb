Public Class TabControl : Inherits System.Windows.Forms.TabControl

    Private _CloseBtn As System.Drawing.Image = My.Resources.Close
    Private _CloseBtnSize As System.Drawing.Size = New Drawing.Size(12, 12)


    Private _LOffset As Integer = 5
    Private _ROffset As Integer = 5

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.ItemSize = New Drawing.Size(150, 21)
        Me.ResumeLayout(False)

    End Sub

    Protected Shadows Property ItemSize As Drawing.Size
        Get
            Return MyBase.ItemSize
        End Get
        Set(value As Drawing.Size)
            If Not MyBase.ItemSize.Equals(value) Then
                MyBase.ItemSize = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _ShowCloseBtn As Boolean = True
    <ComponentModel.DefaultValue(True)> _
    Property ShowCloseBtn() As Boolean
        Get
            Return _ShowCloseBtn
        End Get
        Set(value As Boolean)
            If Not _ShowCloseBtn.Equals(value) Then
                _ShowCloseBtn = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Public Sub New()
        Me.InitializeComponent()
        ' Me.SetStyle(Windows.Forms.ControlStyles.AllPaintingInWmPaint Or Windows.Forms.ControlStyles.OptimizedDoubleBuffer Or Windows.Forms.ControlStyles.ResizeRedraw Or Windows.Forms.ControlStyles.UserPaint, True)
        'Me.SetStyle(Windows.Forms.ControlStyles.SupportsTransparentBackColor, True)

    End Sub

    Protected Overrides Sub OnDrawItem(e As Windows.Forms.DrawItemEventArgs)


        Dim myGr As System.Drawing.Graphics = e.Graphics
        Dim tbPg As Windows.Forms.TabPage = Me.TabPages(e.Index)
        tbPg.Padding = New Windows.Forms.Padding(5)

      


        Dim intSpacingTop As Integer = 0


      
        'Me.TabPages(e.Index).SetBounds(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        If Me.SelectedIndex = e.Index Then
            myGr.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.SystemColors.GradientActiveCaption), e.Bounds)
            intSpacingTop = 2
        Else
            intSpacingTop = 4
        End If

        'If Me.DesignMode = False Then
        '    Dim bckclr As Drawing.Color = System.Drawing.Color.FromArgb(203, 203, 203)
        '    tbPg.BackColor = bckclr
        Dim EmptyArea As System.Drawing.Rectangle = Me.GetTabRect(Me.TabCount - 1)

        e.Graphics.FillRectangle(New System.Drawing.SolidBrush(tbPg.BackColor), New System.Drawing.RectangleF(EmptyArea.X + EmptyArea.Width, EmptyArea.Y - 5, Me.Width - (EmptyArea.X + EmptyArea.Width) + 5, EmptyArea.Height + 5))
        'End If

        'If Me.DesignMode = False AndAlso Me.Parent IsNot Nothing AndAlso Me.Parent.IsHandleCreated = True Then
        'tbPg.BackColor = Me.Parent.BackColor
        'Dim EmptyArea As System.Drawing.Rectangle = Me.GetTabRect(Me.TabCount - 1)
        'e.Graphics.FillRectangle(New System.Drawing.SolidBrush(Drawing.Color.White), New System.Drawing.RectangleF(EmptyArea.X + EmptyArea.Width, EmptyArea.Y - 5, Me.Width - (EmptyArea.X + EmptyArea.Width) + 5, EmptyArea.Height + 5))

        'e.Graphics.FillRectangle(New System.Drawing.SolidBrush(Me.Parent.BackColor), New System.Drawing.RectangleF(EmptyArea.X + EmptyArea.Width, EmptyArea.Y - 5, Me.Width - (EmptyArea.X + EmptyArea.Width) + 5, EmptyArea.Height + 5))
        'End If




        'Dim TempStr As String = Me.TabPages(e.Index).Text
        'TempStr = TruncateString(TempStr, tbPg.Font, e.Bounds.Width, _LOffset, _ROffset + _CloseBtnSize.Width, myGr)
        'Dim txtSize As Drawing.SizeF = myGr.MeasureString(TempStr, tbPg.Font)

        'e.Graphics.DrawString(TempStr, tbPg.Font, New Drawing.SolidBrush(tbPg.ForeColor), New Drawing.Point(e.Bounds.Left + _LOffset, ((e.Bounds.Height - txtSize.Height) / 2) + intSpacingTop))
        'If _ShowCloseBtn = True Then
        '    e.Graphics.DrawImage(_CloseBtn, New Drawing.Rectangle(e.Bounds.Left + e.Bounds.Width - _CloseBtnSize.Width - _ROffset, ((e.Bounds.Height - _CloseBtnSize.Height) / 2 + intSpacingTop), _CloseBtnSize.Width, _CloseBtnSize.Height))
        'End If

        Dim bretImg As Boolean = False
        Dim DrawArea As Drawing.Rectangle = e.Bounds
        If tbPg.ImageIndex > -1 Then
            e.Graphics.DrawImage(Me.ImageList.Images(tbPg.ImageIndex), New Drawing.Rectangle(e.Bounds.Left + _LOffset, (e.Bounds.Height - 16) / 2, 16, 16))
            bretImg = True
            DrawArea = New Drawing.Rectangle(e.Bounds.Left + 16, e.Bounds.Top, e.Bounds.Width - 16, e.Bounds.Height)
        End If

        Dim TempStr As String = Me.TabPages(e.Index).Text
        TempStr = TruncateString(TempStr, tbPg.Font, DrawArea.Width, _LOffset, _ROffset + _CloseBtnSize.Width, myGr)
        Dim txtSize As Drawing.SizeF = myGr.MeasureString(TempStr, tbPg.Font)

        e.Graphics.DrawString(TempStr, tbPg.Font, New Drawing.SolidBrush(tbPg.ForeColor), New Drawing.Point(DrawArea.Left + _LOffset, ((DrawArea.Height - txtSize.Height) / 2) + intSpacingTop))
        If _ShowCloseBtn = True Then
            e.Graphics.DrawImage(_CloseBtn, New Drawing.Rectangle(DrawArea.Left + DrawArea.Width - _CloseBtnSize.Width - _ROffset, ((DrawArea.Height - _CloseBtnSize.Height) / 2 + intSpacingTop), _CloseBtnSize.Width, _CloseBtnSize.Height))
        End If

        MyBase.OnDrawItem(e)
    End Sub

    Public Shared Function TruncateString(ByVal aText As String, ByVal fontVal As Drawing.Font, ByVal aWidth As Integer, ByVal LOffset As Integer, ByVal ROffset As Integer, ByVal aGr As Drawing.Graphics) As String
        Dim Sz As Drawing.SizeF
        Dim Swid, Length As Integer
        Dim Sprint As String = String.Empty

        Try
            Sz = aGr.MeasureString(aText, fontVal)
            Swid = CType(Sz.Width, Integer)
            Length = aText.Length

            While (Length > 0 AndAlso Swid > (aWidth - LOffset - ROffset))
                Sz = aGr.MeasureString(aText.Substring(0, Length), fontVal)
                Swid = CType(Sz.Width, Integer)
                Length -= 1
            End While

            If (Length < aText.Length) Then
                Dim Val As Integer = Length - 3

                If (Val <= 0) Then Sprint = aText.Substring(0, 1) & "..." Else Sprint = aText.Substring(0, Val) & "..."
            Else
                Sprint = aText.Substring(0, Length)
            End If

        Catch ex As Exception
            'DO <c>NOTHING</c>
        End Try

        Return Sprint
    End Function
    Private _AutoCloseTab As Boolean = True
    Public Property AutoCloseTab As Boolean
        Get
            Return _AutoCloseTab
        End Get
        Set(value As Boolean)
            If Not _AutoCloseTab.Equals(value) Then
                _AutoCloseTab = value
            End If
        End Set
    End Property

    Public Event BeforeTabClose(ByVal tabpage As Object, ByVal e As Windows.Forms.MouseEventArgs)
    Public Event AfterTabClose(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs)
    Public Event CloseButtonClick(ByVal tabpage As Object, ByVal e As Windows.Forms.MouseEventArgs)


    Protected Overrides Sub OnMouseDown(e As Windows.Forms.MouseEventArgs)
        If Me.DesignMode Then Return

        If _ShowCloseBtn = True Then
            Try

        
            For i As Integer = 0 To Me.TabPages.Count - 1
                Dim tbPg As Drawing.Rectangle = Me.GetTabRect(i)
                Dim intSpacingTop As Integer = 2

                If Me.SelectedIndex = i Then
                    intSpacingTop = 2
                Else
                    intSpacingTop = 4
                End If

                Dim Rect As New System.Drawing.Rectangle(tbPg.Left + tbPg.Width - _CloseBtnSize.Width - _ROffset, ((tbPg.Height - _CloseBtnSize.Height) / 2 + intSpacingTop), _CloseBtnSize.Width, _CloseBtnSize.Height)

                    If Rect.Contains(e.X, e.Y) = True Then

                        RaiseEvent CloseButtonClick(Me.TabPages(i), e)
                        If _AutoCloseTab = True Then
                            RaiseEvent BeforeTabClose(Me.TabPages(i), e)
                            Me.TabPages.RemoveAt(i)
                            RaiseEvent AfterTabClose(Me, e)
                        End If

                        Exit For
                    End If
                Next
            Catch ex As Exception
                GC.Collect()
            End Try
        End If



        MyBase.OnMouseDown(e)
    End Sub
    'Protected Overrides Sub OnMouseMove(e As Windows.Forms.MouseEventArgs)
    '    For i As Integer = 0 To Me.TabPages.Count - 1
    '        Dim tbPg As Drawing.Rectangle = Me.GetTabRect(i)
    '        Dim intSpacingTop As Integer = 2

    '        If Me.SelectedIndex = i Then
    '            intSpacingTop = 2
    '        Else
    '            intSpacingTop = 4
    '        End If

    '        Dim Rect As New System.Drawing.Rectangle(tbPg.Left + tbPg.Width - _CloseBtnSize.Width - _ROffset, ((tbPg.Height - _CloseBtnSize.Height) / 2 + intSpacingTop), _CloseBtnSize.Width, _CloseBtnSize.Height)

    '        If Rect.Contains(e.X, e.Y) = True Then
    '            Dim myGr As Drawing.Graphics = Me.CreateGraphics
    '            myGr.DrawRectangle(New Drawing.Pen(Drawing.Brushes.Gray), New Drawing.Rectangle(Rect.X - 2, Rect.Y - 2, Rect.Width + 4, Rect.Height + 4))
    '            myGr.DrawRectangle(New Drawing.Pen(Drawing.Brushes.WhiteSmoke), New Drawing.Rectangle(Rect.X - 1, Rect.Y - 1, Rect.Width + 2, Rect.Height + 2))

    '            Exit For
    '        End If
    '    Next
    '    MyBase.OnMouseMove(e)
    'End Sub


    Public Sub CloseTabPage(ByVal TabPage As Windows.Forms.TabPage)
        RaiseEvent CloseButtonClick(TabPage, New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, 0, 0, 0))
        If _AutoCloseTab = True Then
            RaiseEvent BeforeTabClose(TabPage, New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, 0, 0, 0))
            Me.TabPages.Remove(TabPage)
            RaiseEvent AfterTabClose(TabPage, New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, 0, 0, 0))
        End If

    End Sub

    Public Sub CloseTabPage(ByVal idxPage As Integer)
        Dim tmpTp As Windows.Forms.TabPage = Me.TabPages(idxPage)
        Me.CloseTabPage(tmpTp)
    End Sub
End Class
