Public Class DataGridViewMultiColorTextBoxColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewMultiColorTextBoxCell)
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(DataGridViewMultiColorTextBoxCell)) _
                Then
                Throw New InvalidCastException("Must be a DataGridViewPercentageCell")
            End If
            MyBase.CellTemplate = value

        End Set
    End Property



End Class

Public Class DataGridViewMultiColorTextBoxCell
    Inherits DataGridViewTextBoxCell


    Public Sub New()
        MyBase.New()

    End Sub


    Public Class ColorInfo
        Public Sub New(ByVal Color As Color, ByVal StartIndex As Integer, ByVal Length As Integer)
            _Color = Color
            _StartIndex = StartIndex
            _Length = Length
        End Sub
        Friend Sub New(ByVal DGVCell As DataGridViewMultiColorTextBoxCell, ByVal Color As Color, ByVal StartIndex As Integer, ByVal Length As Integer)
            Me.New(Color, StartIndex, Length)
            _Parent = DGVCell

        End Sub
        Private _Parent As DataGridViewMultiColorTextBoxCell = Nothing
        Public Sub SetParent(ByVal DGVCell As DataGridViewMultiColorTextBoxCell)
            _Parent = DGVCell
        End Sub
        Private _Color As Color
        Property Color As Color
            Get
                Return _Color
            End Get
            Set(value As Color)
                If Not _Color.Equals(value) Then
                    _Color = value
                    If _Parent IsNot Nothing AndAlso _Parent.DataGridView IsNot Nothing Then _Parent.DataGridView.InvalidateCell(_Parent)

                End If
            End Set
        End Property

        Private _StartIndex As Integer
        Property StartIndex As Integer
            Get
                Return _StartIndex
            End Get
            Set(value As Integer)
                If Not _StartIndex.Equals(value) Then
                    _StartIndex = value
                    If _Parent IsNot Nothing AndAlso _Parent.DataGridView IsNot Nothing Then _Parent.DataGridView.InvalidateCell(_Parent)
                End If
            End Set
        End Property

        Private _Length As Integer
        Property Length As Integer
            Get
                Return _Length
            End Get
            Set(value As Integer)
                If Not _Length.Equals(value) Then
                    If _Parent IsNot Nothing AndAlso _Parent.DataGridView IsNot Nothing Then _Parent.DataGridView.InvalidateCell(_Parent)
                End If
            End Set
        End Property



    End Class

    Private _ColorInfos As New SortedList
    Private _Invalidate As Boolean = True
    Public Sub SetColors(ByVal ParamArray ColorInfos As ColorInfo())
        _ColorInfos.Clear()
        _Invalidate = False
        For Each tmpClrinfo As ColorInfo In ColorInfos
            AddColor(tmpClrinfo)
        Next
        _Invalidate = True
        Me.DataGridView.InvalidateCell(Me)
    End Sub



    Public Sub AddColor(ByVal colorInfo As ColorInfo)
        If _ColorInfos.Item(colorInfo.StartIndex) Is Nothing Then
            _ColorInfos.Add(colorInfo.StartIndex, colorInfo)
        Else
            _ColorInfos.Item(colorInfo.StartIndex) = colorInfo
        End If
        If _Invalidate = True Then
            Me.DataGridView.InvalidateCell(Me)
        End If

    End Sub




    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return Nothing
        End Get
    End Property
    Private Function TruncateString(ByVal aText As String, ByVal fontVal As Drawing.Font, ByVal aWidth As Integer, ByVal LOffset As Integer, ByVal ROffset As Integer, ByVal aGr As Drawing.Graphics) As String
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

    Protected Overrides Sub Paint(ByVal graphics As System.Drawing.Graphics, ByVal clipBounds As System.Drawing.Rectangle, ByVal cellBounds As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal cellState As System.Windows.Forms.DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As System.Windows.Forms.DataGridViewCellStyle, ByVal advancedBorderStyle As System.Windows.Forms.DataGridViewAdvancedBorderStyle, ByVal paintParts As System.Windows.Forms.DataGridViewPaintParts)
        'MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, "", formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)




        If cellBounds.Width > 0 AndAlso cellBounds.Height > 0 And value IsNot Nothing Then
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, "", formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)
            Dim Gr As Graphics = graphics
            Dim GrRect As Rectangle = cellBounds
            GrRect.Inflate(-1, -1)



            Dim ShowValue As String = TruncateString(value, Me.DataGridView.DefaultCellStyle.Font, GrRect.Width, 1, 1, Gr)
            Dim tmpStr As String = ShowValue
            If Not value.Equals(ShowValue) Then
                tmpStr = tmpStr.Substring(0, tmpStr.Length - 3)
            End If
            Dim MaxSzf As SizeF = Gr.MeasureString(ShowValue, Me.DataGridView.DefaultCellStyle.Font)

            Dim stPT As New Point(GrRect.X, GrRect.Top + (GrRect.Height - MaxSzf.Height) / 2)

            For i As Integer = 0 To tmpStr.ToCharArray.Count - 1
                Dim drTxt As String
                Dim Clr As Color = Me.DataGridView.DefaultCellStyle.ForeColor
                If _ColorInfos.Item(i - 1) IsNot Nothing Then
                    Dim clrinfo As ColorInfo = DirectCast(_ColorInfos.Item(i - 1), ColorInfo)
                    Clr = clrinfo.Color
                    drTxt = tmpStr.ToCharArray(i, IIf(tmpStr.ToCharArray.Count - i > clrinfo.Length, clrinfo.Length, tmpStr.ToCharArray.Count - i))
                    i += clrinfo.Length - 1

                Else
                    drTxt = tmpStr.ToCharArray(i, 1)

                End If
                Gr.DrawString(drTxt, Me.DataGridView.DefaultCellStyle.Font, New SolidBrush(Clr), stPT)

                Dim szf As SizeF = Gr.MeasureString(drTxt, Me.DataGridView.DefaultCellStyle.Font, (MaxSzf.Width / ShowValue.Length) * drTxt.Length, Drawing.StringFormat.GenericDefault)
                stPT.Offset(szf.ToSize.Width, 0)
            Next

            If Not value.Equals(ShowValue) Then
                Gr.DrawString("...", Me.DataGridView.DefaultCellStyle.Font, New SolidBrush(Me.DataGridView.DefaultCellStyle.ForeColor), stPT)
            End If


        Else
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)
        End If



    End Sub


End Class
