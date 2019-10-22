Public Class DataGridViewPercentageColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewPercentageCell)
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(DataGridViewPercentageCell)) _
                Then
                Throw New InvalidCastException("Must be a DataGridViewPercentageCell")
            End If
            MyBase.CellTemplate = value

        End Set
    End Property

 

End Class

Public Class DataGridViewPercentageCell
    Inherits DataGridViewTextBoxCell

    Dim brushPercent As Brush

    Public Sub New()
        Me.Style.Format = "0%"
    End Sub
    'Private _tmpValue As Object = 0.0
    'Private _Value As Object = 0.0
    'Overloads Property Value As Object
    '    Get
    '        Return _Value
    '    End Get
    '    Set(value As Object)
    '        If Not _Value.Equals(value) Then

    '            _tmpValue = _Value
    '            _Value = value
    '            Dim intInterval As Single = _Value - _tmpValue
    '            If intInterval < 0 Then
    '                intInterval = intInterval * -1
    '            End If

    '            If Me.DataGridView IsNot Nothing AndAlso intInterval > 0 Then
    '                Tm_Animation.Interval = 3000 / intInterval
    '                'Tm_Animation.Interval = 10
    '                Tm_Animation.Start()
    '            End If


    '        End If
    '    End Set
    'End Property


    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return Nothing
        End Get
    End Property


    Private _tmpValue As Double = 0
    Protected Overrides Sub Paint(ByVal graphics As System.Drawing.Graphics, ByVal clipBounds As System.Drawing.Rectangle, ByVal cellBounds As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal cellState As System.Windows.Forms.DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As System.Windows.Forms.DataGridViewCellStyle, ByVal advancedBorderStyle As System.Windows.Forms.DataGridViewAdvancedBorderStyle, ByVal paintParts As System.Windows.Forms.DataGridViewPaintParts)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, "", formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)
        If ThTmAnimation Is Nothing AndAlso _tmpValue <> value Then



            Dim intInterval As Single = value - _tmpValue
            If intInterval < 0 Then
                intInterval = intInterval * -1
            End If

            If Me.DataGridView IsNot Nothing AndAlso intInterval > 0 Then
                If ThTmAnimation IsNot Nothing Then
                    ThTmAnimation.Dispose()
                    ThTmAnimation = Nothing
                End If

                Dim tmCallBack As New Threading.TimerCallback(AddressOf ThTmAnimationMethod)
                ThTmAnimation = New Threading.Timer(tmCallBack, Nothing, 0, CInt(3000 / intInterval))

            End If

        Else
            Dim r As Drawing.Rectangle

            Dim intHeight As Integer = cellStyle.Font.Height * 4 / 5

            r.X = cellBounds.X + 5
            r.Y = cellBounds.Y + (cellBounds.Height - intHeight) / 2
            r.Width = (cellBounds.Width - 10) * (_tmpValue / 100)
            r.Height = intHeight
            'r.X = cellBounds.X + 5
            'r.Y = cellBounds.Y + 5
            'r.Width = (cellBounds.Width - 10) * (_tmpValue / 100)
            'r.Height = cellBounds.Height - 10

            If r.Width > 0 Then
                If Me.brushPercent IsNot Nothing Then
                    Me.brushPercent.Dispose()
                    Me.brushPercent = Nothing
                End If

                Me.brushPercent = New Drawing.Drawing2D.LinearGradientBrush(r, Drawing.Color.White, cellStyle.ForeColor, Drawing.Drawing2D.LinearGradientMode.Vertical)
                graphics.FillRectangle(Me.brushPercent, r)
                graphics.DrawRectangle(Drawing.Pens.DimGray, r)
            End If
        End If



        ''If Me.Tm_Animation.Enabled = False AndAlso _tmpValue <> value Then



        ''    Dim intInterval As Single = value - _tmpValue
        ''    If intInterval < 0 Then
        ''        intInterval = intInterval * -1
        ''    End If

        ''    If Me.DataGridView IsNot Nothing AndAlso intInterval > 0 Then
        ''        Tm_Animation.Interval = 2500 / intInterval
        ''        'Tm_Animation.Interval = 10
        ''        Tm_Animation.Start()
        ''    End If

        ''Else
        ''    Dim r As Drawing.Rectangle

        ''    r.X = cellBounds.X + 5
        ''    r.Y = cellBounds.Y + 5
        ''    r.Width = (cellBounds.Width - 10) * (_tmpValue / 100)
        ''    r.Height = cellBounds.Height - 10

        ''    If r.Width > 0 Then
        ''        If Me.brushPercent IsNot Nothing Then
        ''            Me.brushPercent.Dispose()
        ''            Me.brushPercent = Nothing
        ''        End If

        ''        Me.brushPercent = New Drawing.Drawing2D.LinearGradientBrush(r, Drawing.Color.White, cellStyle.ForeColor, Drawing.Drawing2D.LinearGradientMode.Vertical)
        ''        graphics.FillRectangle(Me.brushPercent, r)
        ''        graphics.DrawRectangle(Drawing.Pens.DimGray, r)
        ''    End If
        ''End If




        ''If _tmpValue > 0 Then
        ''    Dim r As Drawing.Rectangle

        ''    r.X = cellBounds.X + 5
        ''    r.Y = cellBounds.Y + 5
        ''    r.Width = (cellBounds.Width - 10) * (_tmpValue / 100)
        ''    r.Height = cellBounds.Height - 10

        ''    If r.Width > 0 Then
        ''        If Me.brushPercent IsNot Nothing Then
        ''            Me.brushPercent.Dispose()
        ''            Me.brushPercent = Nothing
        ''        End If

        ''        Me.brushPercent = New Drawing.Drawing2D.LinearGradientBrush(r, Drawing.Color.White, cellStyle.ForeColor, Drawing.Drawing2D.LinearGradientMode.Vertical)
        ''        graphics.FillRectangle(Me.brushPercent, r)
        ''        graphics.DrawRectangle(Drawing.Pens.DimGray, r)
        ''    End If
        ''End If
        'If _useCaption Then
        '    MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.None Or DataGridViewPaintParts.ContentForeground)
        'End If
    End Sub


    ''Private WithEvents Tm_Animation As New Timer

    ''Private Sub Tm_Animation_Tick(sender As Object, e As EventArgs) Handles Tm_Animation.Tick
    ''    If Me._tmpValue > Me.Value Then
    ''        Me._tmpValue -= 1
    ''    Else
    ''        Me._tmpValue += 1
    ''    End If
    ''    If Me.DataGridView IsNot Nothing Then
    ''        Me.DataGridView.InvalidateCell(Me)
    ''        If _tmpValue = Value Then
    ''            Tm_Animation.Stop()
    ''        End If
    ''    End If




    ''End Sub
    Private ThTmAnimation As Threading.Timer

    Private Sub ThTmAnimationMethod()
        Try
            If Me._tmpValue > Me.Value Then

                If Me._tmpValue - 1 < Me.Value Then
                    Me._tmpValue = Me.Value
                Else
                    Me._tmpValue -= 1
                End If
            Else
                If Me._tmpValue + 1 > Me.Value Then
                    Me._tmpValue = Me.Value
                Else
                    Me._tmpValue += 1
                End If
            End If


            If Me.DataGridView IsNot Nothing Then
                Me.DataGridView.InvalidateCell(Me)
                If _tmpValue = Value AndAlso Me.DataGridView IsNot Nothing AndAlso ThTmAnimation IsNot Nothing Then

                    ThTmAnimation.Dispose()
                    ThTmAnimation = Nothing
                End If
            End If
        Catch ex As Exception
            GC.Collect()

        End Try

    End Sub


    Protected Overrides Sub Finalize()
        If ThTmAnimation IsNot Nothing Then
            ThTmAnimation.Dispose()
        End If
        ThTmAnimation = Nothing

        ''Tm_Animation.Stop()
        ''Tm_Animation.Enabled = False
        ''Tm_Animation.Dispose()
        ''Tm_Animation = Nothing
        'GC.Collect() 'robin remove GC


        MyBase.Finalize()


    End Sub
End Class