Imports System.Windows.Forms.DataVisualization.Charting

' ===========================================
' ------------- 요약정보 --------------------
' ChartArea : 차트가 그려지는 영역
' Legend : 차트에 표시되는 범례
' Series : 실제로 표시되는 차트 
' Title : 추가적으로 표시되는 내용
' StripLine : 그리기 영역에 표시되는 선으로 범위별 색상 혹은 간격별 출 추가 평균치 같은 부분을 표시 할 때 사용한다. 
' ===========================================
'-------------- 구조 -----------------------
' ChartArea , Legend , Series , Title 은 모두 각각 개별로 존재하게 된다. 
' ChartArea 에 Legend , Series , Title 을 모두 넣어서 사용하는 방식이 기본이됨. 
' ChartArea 에는 Axis 라고 축과 관련된 설정을 하여 주는 부분이 별도로 존재하게됨. 축에서 간격이나 값을 변경 할 수 있다. 
' X 축은 기본적으로 시간으로 표시 하게 되어있다. 현재 시스템에서 날짜를 넘겨 주게 되어있으나 X 축에는 Date.toOADate로 Double 형식으로 넘겨서 받아 처리.
' ToolStrip에 많은 부분이 있음 자동으로 생성하는 ToolTIP 메뉴에 TAG 에 ChartArea 명칭이나 Series 명칭이 담겨져 있다. 
' ToolStrip의 PreFix Word 
'   ts명칭 : tsGRP + ChartArea명칭 (멀티차트에서 사용하는 부분으로 FIND 로 찾기 편하게 하기 위하여 강제로 셋팅됨
'            tsSER + Series 명칭   (                       "                                                  )
' Legend 의 PreFix Word
'   LEG + ChartArea 명칭 
' ChartArea는 기본적으로 1개 이상이 있어야 그리기가 가능하여 할 수 없이 DEFAREA라는 기본을 한개 두었음
'     DEFAREA 가 기본베이스 이고 추가로 추가될때마다 기본적으로 명칭은 AREA + SEQ Number로 설정함. 
' 멀티 차트의 경우 AddSeriesWithArea 를 참고 하고 옵션으로 AREA 명칭을 넣을 수 있다. 
'     * 사용자가 혼란스러울 수도 있어서 AREA 는 밖으로 노출 시키지 않으려고 하였으나 불가결한 사정으로 AREA를 외부로 노출하게됨.
'        불가결한 경우는 다중차트를 생성 하였으나 선을 여러개 그리고자 하는 경우 그리고자 하는 영역을 찾을 방법이 없어서 외부로 노출됨. 
' 함수에 AreaName이 Parameter 가 있는 경우 멀티차트로 인식하고 단일 차트를 표시 하는 경우는 무시하여도 상관 없음.
' MSChartControl 다운로드 
'      http://www.microsoft.com/ko-kr/download/details.aspx?id=14422 (2013.09.11 기준) 
'      Microsoft Download Center 에서 Microsoft Chart Controls 로 검색하면 나옴 
' MS Chart COntrol Sample 경로 
'      http://archive.msdn.microsoft.com/mschart  (2013.09.11 기준) 
'      구글에서 Samples Environment for Microsoft Chart Controls  검색시 나옴.


Public Class ctlChartEx

#Region "Initilize & Declare "
    ' ''' <summary>
    ' ''' 차트별 Point 값 제한 변수 
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private _MaxPointCount As Integer = 1200

    ''' <summary>
    ''' Y축 영역을 그리기 위한 배열 Name Key값이 없어서 강제로 넣어줌 Key Value 로 담아두는 변수
    ''' </summary>
    ''' <remarks></remarks>
    Private _srtStripNm As New SortedList

    ''' <summary>
    ''' 메뉴 차트영역별 그리기 사용여부 , tsChart Visible Change 이벤트에서 변경됨
    ''' </summary>
    ''' <remarks></remarks>
    Private _UseGroupMenu As Boolean = False

    ''' <summary>
    ''' 데이터가 지속적으로 발생하는 경우 중간에 출력을 위하거나 사용자가 데이터를 보기위하여 일시 중지시 사용하는 이벤트 결과 값 변수 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ActType
        ''' <summary>
        ''' 시작 Flag
        ''' </summary>
        ''' <remarks></remarks>
        Play = 0
        ''' <summary>
        ''' 중지 Flag
        ''' </summary>
        ''' <remarks></remarks>
        Pause = 1
    End Enum

    ''' <summary>
    ''' 생성자
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        ' ZoomType을 None으로 설정 
        Me.mnuZoomType.SelectedIndex = 0
        ' 멀티 차트 선택 메뉴를 없앤다. Design 타임에서 보이기 때문에 초기에는 없앰 
        Me.tsCharts.Visible = False


        MainChart.ApplyPaletteColors()


        Me.mnuChartMenu.Renderer = New A



    End Sub


    Private Class A
        Inherits ToolStripRenderer

        Protected Overrides Sub OnRenderItemBackground(e As ToolStripItemRenderEventArgs)
            'MyBase.OnRenderItemBackground(e) 
        End Sub

    End Class
#End Region

#Region "Properties"

    ' ''' <summary>
    ' ''' 차트 Point의 최대 개수를 지정. 초과시 과거 데이터부터 삭제됩니다.
    ' ''' </summary>
    ' ''' <value></value>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    '<System.ComponentModel.Category("Custom") _
    ', System.ComponentModel.DefaultValue(CInt(1200)) _
    ', System.ComponentModel.Description("Points의 최대 개수를 지정합니다.")> _
    'Property MaxPointCount() As Integer
    '    Get
    '        Return _MaxPointCount
    '    End Get
    '    Set(value As Integer)
    '        _MaxPointCount = value
    '    End Set
    'End Property


    ''' <summary>
    ''' 차트의 Title을 설정 설정하지 않을 경우 보이지 않음 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.Category("Custom") _
    , System.ComponentModel.Description("차트의 메인 타이틀 명칭")> _
    Property Title() As String
        Get
            Return Me.MainChart.Titles(0).Text
        End Get
        Set(value As String)
            ' TITle이 설정되지 않았을 경우 보기를 끈다. 화면을 조금더 키우기 위함.
            If value = String.Empty Or value.Equals("") Then
                Me.MainChart.Titles(0).Visible = False
            Else
                Me.MainChart.Titles(0).Visible = True
            End If
            ' TItle 항목 삽입 
            Me.MainChart.Titles(0).Text = value
        End Set
    End Property

    <System.ComponentModel.Category("Custom") _
    , System.ComponentModel.Description("상단 메뉴 보이기/숨기기")> _
    Property MenuVisible As Boolean
        Get
            Return mnuChartMenu.Visible
        End Get
        Set(value As Boolean)
            'If Not mnuChartMenu.Visible.Equals(value) Then
            mnuChartMenu.Visible = value
            Me.Invalidate()

            ' End If
        End Set
    End Property



    Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)

            MyBase.BackColor = value
            Me.MainChart.BackColor = MyBase.BackColor
            Me.mnuChartMenu.BackColor = MyBase.BackColor
        End Set
    End Property

    <System.ComponentModel.BindableAttribute(True)> _
    Property BorderSkin As System.Windows.Forms.DataVisualization.Charting.BorderSkin
        Get
            Return Me.MainChart.BorderSkin
        End Get
        Set(value As System.Windows.Forms.DataVisualization.Charting.BorderSkin)
            If Not Me.MainChart.BorderSkin.Equals(value) Then
                Me.MainChart.BorderSkin = value

            End If
        End Set
    End Property

#End Region

#Region "Event & Handler"




#Region "Event Handler"



    ''' <summary>
    ''' 메뉴에서 값보기 선택시 보여지기  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ShowLabelClick(sender As Object, e As EventArgs)

        Dim tsItm As ToolStripMenuItem = DirectCast(sender, ToolStripItem)
        Dim series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Item(tsItm.Tag.ToString.ToUpper)
        series.IsValueShownAsLabel = tsItm.CheckState

    End Sub


    ''' <summary>
    ''' 메뉴에서 범례보기 선택시 보이기 여부 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ShowLegendClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim tsItm As ToolStripMenuItem = DirectCast(sender, ToolStripItem)
        Dim series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Item(tsItm.Tag.ToString.ToUpper)

        series.Enabled = tsItm.CheckState

    End Sub

    Public Sub ShowLegend(ByVal SeriesNm As String, ByVal ShowValue As Boolean)

        For Each tmpItm As ToolStripMenuItem In tsShowLegend.DropDownItems
            If tmpItm.Tag.ToString.ToUpper.Equals(SeriesNm.ToString.ToUpper) Then
                tmpItm.CheckState = IIf(ShowValue, 1, 0)
                Dim series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Item(SeriesNm.ToUpper)
                series.Enabled = ShowValue
            End If
        Next

        Me.MainChart.ChartAreas(0).RecalculateAxesScale()


    End Sub

    Public Sub SeriesClear()
        Try



            Me.MainChart.Series.Clear()
            tsShowLegend.DropDownItems.Clear()
            tsShowMean.DropDownItems.Clear()
            Dim rmItm As New ArrayList
            For Each tmpMenitm As Object In tsShowValue.DropDownItems
                If Not tmpMenitm.Equals(tsShowValueDeSel) AndAlso Not tmpMenitm.Equals(tsShowValueSep1) Then
                    'tsShowValue.DropDownItems.Remove(tmpMenitm)
                    rmItm.Add(tmpMenitm)
                End If
            Next

            For i As Integer = 0 To rmItm.Count - 1
                tsShowValue.DropDownItems.Remove(rmItm.Item(i))
            Next

        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub

    ''' <summary>
    ''' 메뉴에서 평균(Mean)보기 선택시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ShowMeanClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim tsItm As ToolStripMenuItem = DirectCast(sender, ToolStripItem)

        If tsItm.Checked = True Then

            For Each tmpItm As ToolStripMenuItem In Me.tsShowMean.DropDownItems
                If Not tmpItm.Equals(tsItm) AndAlso tmpItm.Checked = True Then
                    tmpItm.Checked = False
                End If
            Next

            UpdateMean(tsItm.Tag.ToString.ToUpper, False)
        Else
            UpdateMean(tsItm.Tag.ToString.ToUpper, True)
        End If


    End Sub

    ''' <summary>
    ''' 멀티 차트 보기 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ShowChartClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim tsItm As ToolStripMenuItem = DirectCast(sender, ToolStripItem)

        If Me.MainChart.ChartAreas(tsItm.Tag) IsNot Nothing Then
            Dim tmpChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea = MainChart.ChartAreas(tsItm.Tag)
            tmpChartArea.Visible = tsItm.Checked

        End If

    End Sub


#End Region

#Region "ToolStrip MenuItem"

    ''' <summary>
    ''' 프린터 설정관련 페이지 팝업
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsPrintPageSetup_Click(sender As Object, e As EventArgs) Handles tsPrintPageSetup.Click
        Try

            MainChart.Printing.PageSetup()

        Catch ex As Exception
            GC.Collect()

        End Try
    End Sub

    ''' <summary>
    ''' 프린터 미리보기 관련 페이지 팝업 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsPrintPreview_Click(sender As Object, e As EventArgs) Handles tsPrintPreview.Click
        Try

            Dim pFormTopMost As Boolean = Me.ParentForm.TopMost
            Me.ParentForm.TopMost = False
            MainChart.Printing.PrintPreview()
            Me.ParentForm.TopMost = pFormTopMost

        Catch ex As Exception
            GC.Collect()

        End Try

    End Sub

    ''' <summary>
    ''' 인소 버튼 클릭 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsPrint_Click(sender As Object, e As EventArgs) Handles tsPrint.Click
        Try
            ' 출력 상자 관련 페이지를 띄울지 결정한다. 
            MainChart.Printing.Print(True)
        Catch ex As Exception
            GC.Collect()

        End Try

    End Sub


    ''' <summary>
    ''' Zoom X , Y , X and Y 에 대한 설정 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuZoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mnuZoomType.SelectedIndexChanged


        Dim cmbZoomType As ToolStripComboBox = DirectCast(sender, ToolStripComboBox)
        For Each tmpChart As System.Windows.Forms.DataVisualization.Charting.ChartArea In Me.MainChart.ChartAreas


            If cmbZoomType.Text = "X" Or cmbZoomType.Text = "ALL" Then ' X 
                tmpChart.CursorX.IsUserEnabled = True
                tmpChart.CursorX.IsUserSelectionEnabled = True
                tmpChart.CursorX.IntervalType = DateTimeIntervalType.Seconds
                tmpChart.AxisX.ScaleView.Zoomable = True


            Else
                tmpChart.CursorX.IsUserEnabled = False
                tmpChart.CursorX.IsUserSelectionEnabled = False
                tmpChart.AxisX.ScaleView.Zoomable = False
            End If

            If cmbZoomType.Text = "Y" Or cmbZoomType.Text = "ALL" Then
                tmpChart.CursorY.IsUserEnabled = True
                tmpChart.CursorY.IsUserSelectionEnabled = True
                tmpChart.AxisY.ScaleView.Zoomable = True
            Else
                tmpChart.CursorY.IsUserEnabled = False
                tmpChart.CursorY.IsUserSelectionEnabled = False
                tmpChart.AxisY.ScaleView.Zoomable = False
            End If

        Next
        Me.MainChart.Focus()
        Return
    End Sub

    ''' <summary>
    ''' Zoom 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuZoomReset_Click(sender As Object, e As EventArgs) Handles mnuZoomReset.Click
        For Each tmpArea As System.Windows.Forms.DataVisualization.Charting.ChartArea In Me.MainChart.ChartAreas
            tmpArea.AxisX.ScaleView.ZoomReset(0)
            tmpArea.AxisY.ScaleView.ZoomReset(0)
        Next


    End Sub


    ''' <summary>
    ''' 일지정지/시작 버튼 클릭시 이미지 , 텍스트 및 이벤트 발생 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuPause_Click(sender As Object, e As EventArgs) Handles mnuPause.Click
        'Dim coc As New ClsObjectCtl
        If sender.tag = ActType.Play Then
            sender.tag = ActType.Pause
            mnuPause.Image = eXperDB.Resources.iResources.Start
            mnuPause.ToolTipText = "Play"
            mnuPause.Text = "시작"
            RaiseEvent ActChange(Me, ActType.Pause)
        Else
            sender.tag = ActType.Play
            mnuPause.Image = eXperDB.Resources.iResources.pause1
            mnuPause.ToolTipText = "Pause"
            mnuPause.Text = "일시정지"
            RaiseEvent ActChange(Me, ActType.Play)

        End If
    End Sub

    ''' <summary>
    ''' 전체선택 해제 메뉴 선택
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsShowValueDeSel_Click(sender As Object, e As EventArgs) Handles tsShowValueDeSel.Click
        For Each tmpMenu As Object In Me.tsShowValue.DropDownItems
            If TypeOf tmpMenu Is ToolStripMenuItem Then
                Dim tmpItm As ToolStripMenuItem = tmpMenu
                If tmpItm.HasDropDownItems = True Then
                    For Each tmpmenu2 As ToolStripMenuItem In tmpItm.DropDownItems
                        If tmpmenu2.CheckOnClick = True Then
                            tmpmenu2.Checked = False
                            ShowLabelClick(tmpmenu2, Nothing)
                        End If
                    Next
                Else
                    If tmpItm.CheckOnClick = True Then
                        tmpItm.Checked = False
                        ShowLabelClick(tmpItm, Nothing)
                    End If
                End If

            End If

        Next
    End Sub


    ''' <summary>
    ''' 멀티 차트 보이기 숨기기
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsCharts_VisibleChanged(sender As Object, e As EventArgs) Handles tsCharts.VisibleChanged
        If DesignMode = False Then

            setToolstripMenu()
        End If


    End Sub

#End Region


    ''' <summary>
    ''' 사용자 발생 이벤트 Play , Pause 클릭시 발생함. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event ActChange(ByVal sender As Object, ByVal e As ActType)

    Public Sub ShowMaxValue(ByVal Show As Boolean)
        For Each tmpSeries As Series In Me.MainChart.Series
            If tmpSeries.Points.Count > 0 Then
                Dim tmpDtPt As DataPoint = tmpSeries.Points.FindMaxByValue
                If Show = True Then
                    tmpDtPt.MarkerStyle = MarkerStyle.Star10
                    tmpDtPt.MarkerSize = 15
                    tmpDtPt.MarkerBorderColor = Color.WhiteSmoke
                    tmpDtPt.MarkerBorderWidth = 1
                    tmpDtPt.Label = tmpDtPt.YValues(0)
                Else
                    tmpDtPt.MarkerStyle = MarkerStyle.None
                    tmpDtPt.Label = ""
                End If
            End If

        Next
    End Sub

    Public Sub ShowMaxValue(ByVal strSeries As String)
        If Me.MainChart.Series(strSeries).Points.Count > 0 Then
            Dim tmpDtPt As DataPoint = Me.MainChart.Series(strSeries).Points.FindMaxByValue
            If tmpDtPt.MarkerStyle = MarkerStyle.None Then
                tmpDtPt.MarkerStyle = MarkerStyle.Star10
                tmpDtPt.MarkerSize = 15
                tmpDtPt.MarkerBorderColor = Color.WhiteSmoke
                tmpDtPt.MarkerBorderWidth = 1
                tmpDtPt.Label = tmpDtPt.YValues(0)
            Else
                tmpDtPt.MarkerStyle = MarkerStyle.None
                tmpDtPt.Label = ""
            End If
        End If

    End Sub

    Public Sub ShowMinValue(ByVal Show As Boolean)
        For Each tmpSeries As Series In Me.MainChart.Series
            If tmpSeries.Points.Count > 0 Then
                Dim tmpDtPt As DataPoint = tmpSeries.Points.FindMinByValue
                If Show = True Then
                    tmpDtPt.MarkerStyle = MarkerStyle.Star10
                    tmpDtPt.MarkerSize = 15
                    tmpDtPt.MarkerBorderColor = Color.WhiteSmoke
                    tmpDtPt.MarkerBorderWidth = 1
                    tmpDtPt.Label = tmpDtPt.YValues(0)
                Else
                    tmpDtPt.MarkerStyle = MarkerStyle.None
                    tmpDtPt.Label = ""
                End If
            End If

        Next
    End Sub

    Public Sub ShowMinValue(ByVal strSeries As String)
        If Me.MainChart.Series(strSeries).Points.Count > 0 Then
            Dim tmpDtPt As DataPoint = Me.MainChart.Series(strSeries).Points.FindMinByValue
            If tmpDtPt.MarkerStyle = MarkerStyle.None Then
                tmpDtPt.MarkerStyle = MarkerStyle.Star10
                tmpDtPt.MarkerSize = 15
                tmpDtPt.MarkerBorderColor = Color.WhiteSmoke
                tmpDtPt.MarkerBorderWidth = 1
                tmpDtPt.Label = tmpDtPt.YValues(0)
            Else
                tmpDtPt.MarkerStyle = MarkerStyle.None
                tmpDtPt.Label = ""
            End If
        End If

    End Sub

    ''' <summary>
    ''' 차트 마우스 클릭 이벤트 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ctlChart_MouseDown(sender As Object, e As MouseEventArgs) Handles MainChart.MouseDown
        ' 컨트롤 좌표에서 선택된 것을 객체를 가져온다. 
        Dim result As System.Windows.Forms.DataVisualization.Charting.HitTestResult = MainChart.HitTest(e.X, e.Y)
        ' 마우스 왼쪽 더블클릭을 했을 경우 
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso e.Clicks = 2 Then

            If result.ChartElementType = ChartElementType.LegendItem Then

                Dim lgdCell As DataVisualization.Charting.LegendCell = result.SubObject
                Dim lgd As System.Windows.Forms.DataVisualization.Charting.LegendItem = result.Object
                If lgdCell IsNot Nothing Then
                    Select Case lgdCell.CellType

                        Case DataVisualization.Charting.LegendCellType.SeriesSymbol

                            ' 색상 정보 창을 연다. 
                            Dim A As New System.Windows.Forms.ColorDialog
                            '기존 색상을 설정한다. 
                            A.Color = MainChart.Series(lgd.SeriesName).Color
                            ' 선택 완료 일 경우 
                            If A.ShowDialog = DialogResult.OK Then
                                ' 데이터의 색상을 변경한다. 
                                MainChart.Series(lgd.SeriesName).Color = A.Color
                            End If
                        Case DataVisualization.Charting.LegendCellType.Text

                            Select Case lgdCell.Legend.CellColumns(lgd.Cells.IndexOf(lgdCell.Name)).Text.ToUpper.Substring(0, 4)
                                Case "#MAX"
                                    ShowMaxValue(lgd.SeriesName)
                                Case "#MIN"
                                    ShowMinValue(lgd.SeriesName)

                            End Select


                    End Select
                End If
            End If

        ElseIf e.Button = Windows.Forms.MouseButtons.Left AndAlso e.Clicks = 1 Then
            ' 포인트를 선택 하거나 포인트 라벨을 선택 하였을 경우 보이고 끈다 
            If result.ChartElementType = DataVisualization.Charting.ChartElementType.DataPoint Or result.ChartElementType = DataVisualization.Charting.ChartElementType.DataPointLabel Then
                Dim selPoint As System.Windows.Forms.DataVisualization.Charting.DataPoint = CType(result.Object, System.Windows.Forms.DataVisualization.Charting.DataPoint)
                If selPoint.IsValueShownAsLabel = False Then
                    selPoint.Label = String.Format("Time: {0}{1}Value:{2}", Date.FromOADate(selPoint.XValue).ToString("HH:mm:ss"), vbCrLf, selPoint.YValues(0))
                    selPoint.IsValueShownAsLabel = True
                Else
                    selPoint.Label = ""
                    selPoint.IsValueShownAsLabel = False
                End If


            End If
            'ElseIf e.Button = Windows.Forms.MouseButtons.Left AndAlso e.Clicks = 1 Then
            '    ' 컨트롤 좌표에서 선택된 것을 객체를 가져온다. 
            '    Dim result As System.Windows.Forms.DataVisualization.Charting.HitTestResult = MainChart.HitTest(e.X, e.Y)
            '    ' 선택된 객체가 범례일 경우 
            '    If TypeOf result.Object Is System.Windows.Forms.DataVisualization.Charting.ChartArea Then

            '        Dim selArea As System.Windows.Forms.DataVisualization.Charting.ChartArea = result.Object


            '    End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then


            ' 선택된 ChartArea를 메뉴의 TAG에 넣는다. 
            If TypeOf result.Object Is System.Windows.Forms.DataVisualization.Charting.LegendItem Then
                Dim legend As System.Windows.Forms.DataVisualization.Charting.LegendItem = result.Object
                Dim strSer As String = legend.SeriesName
                mnuPopUpLegend.Tag = MainChart.Series(strSer).ChartArea
            ElseIf TypeOf result.Object Is System.Windows.Forms.DataVisualization.Charting.Legend Then
                Dim legend As System.Windows.Forms.DataVisualization.Charting.Legend = result.Object
                mnuPopUpLegend.Tag = legend.DockedToChartArea
            ElseIf TypeOf result.Object Is System.Windows.Forms.DataVisualization.Charting.ChartArea Then
                Dim selArea As System.Windows.Forms.DataVisualization.Charting.ChartArea = result.Object
                mnuPopUpLegend.Tag = selArea.Name
            Else
                If result.ChartArea IsNot Nothing Then
                    mnuPopUpLegend.Tag = result.ChartArea.Name
                End If

            End If

        End If


    End Sub



#End Region

#Region "Methods"


#Region "TItle"

    ''' <summary>
    ''' 단일 차트 사용시 Y 축 Title 입력
    ''' </summary>
    ''' <param name="TItle">표시내용</param>
    ''' <remarks>DEFAREA 라고 기본 설정 차트 그리기 영역에 설정됨</remarks>
    Public Sub SetAxisYTitle(ByVal TItle As String)
        Me.MainChart.ChartAreas("DEFAREA").AxisY.Title = TItle

    End Sub

    ''' <summary>
    ''' 멀티 차트 사용시 Y 축 Title 입력
    ''' </summary>
    ''' <param name="AreaName">그리기영역 명칭</param>
    ''' <param name="Title">표시내용</param>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Public Sub SetAxisYTitle(ByVal AreaName As String, ByVal Title As String)
        MainChart.ChartAreas(AreaName).AxisY.Title = Title
    End Sub

    ''' <summary>
    ''' 단일 차트 사용시 X 축 TItle 입력
    ''' </summary>
    ''' <param name="TItle"></param>
    ''' <remarks></remarks>
    Public Sub SetAxisXTitle(ByVal TItle As String)
        Me.MainChart.ChartAreas("DEFAREA").AxisX.Title = TItle
        ' 타이틀 변경시 해당하는 메뉴의 항목을 모두 변경함. 
        tsMenuAllAreaNmChange("DEFAREA", TItle)
    End Sub

    ''' <summary>
    ''' 멀티차트 사용시 X 축 Title 입력
    ''' </summary>
    ''' <param name="Title"></param>
    ''' <remarks></remarks>
    Public Sub SetAxisXTitle(ByVal AreaName As String, ByVal Title As String)
        MainChart.ChartAreas(AreaName).AxisX.Title = Title
        ' 타이틀 변경시 해당하는 메뉴의 항목을 모두 변경함. 
        tsMenuAllAreaNmChange(AreaName, Title)
    End Sub
    ''' <summary>
    ''' 단일 차트용 Y 축 한계 값 
    ''' </summary>
    ''' <param name="Value">자동설정시 -1</param>
    ''' <remarks></remarks>
    Public Sub SetAxisYMaximum(ByVal Value As Integer)
        MainChart.ChartAreas("DEFAREA").AxisY.Maximum = Value
    End Sub
    ''' <summary>
    ''' 멀티차트용 Y 축 한계값
    ''' </summary>
    ''' <param name="AreaName"></param>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetAxisYMaximum(ByVal AreaName As String, ByVal Value As Integer)
        MainChart.ChartAreas(AreaName).AxisY.Maximum = Value
    End Sub
#End Region


#Region "Common"

#Region "ToolStripItem 관련 "

    ''' <summary>
    ''' 다중 멀티에서 ToolStrip에 표시된 차트 이름을 모두 변경한다. 
    ''' </summary>
    ''' <param name="strAreaNm">그리기영역</param>
    ''' <param name="Title">내용</param>
    ''' <remarks>기본 + 멀티 모두 사용</remarks>
    Private Sub tsMenuAllAreaNmChange(ByVal strAreaNm As String, ByVal Title As String)

        ' 멀티차트에서 차트 목록 표시 메뉴 
        Dim tmpItm As ToolStripItem() = tsCharts.DropDownItems.Find("tsGRP" & strAreaNm, False)
        If tmpItm.Count > 0 Then
            tmpItm(0).Text = Title
        End If

        ' 값보기 메뉴 차트 목록 표시 
        tmpItm = tsShowValue.DropDownItems.Find("tsGRP" & strAreaNm, False)
        If tmpItm.Count > 0 Then
            tmpItm(0).Text = Title
        End If

        ' 차트 항목 보기 메뉴 표시 
        tmpItm = tsShowLegend.DropDownItems.Find("tsGRP" & strAreaNm, False)
        If tmpItm.Count > 0 Then
            tmpItm(0).Text = Title
        End If
        ' 평균 보기 메뉴 표시 
        tmpItm = tsShowMean.DropDownItems.Find("tsGRP" & strAreaNm, False)
        If tmpItm.Count > 0 Then
            tmpItm(0).Text = Title
        End If

    End Sub

#End Region

#Region "평균(mean) 관련"


    ''' <summary>
    ''' 화면에 기본으로 선택될 Series를 선택한다. 
    ''' </summary>
    ''' <param name="strSeries">Series 명칭</param>
    ''' <remarks>기본 + 멀티 모두 사용</remarks>
    Public Sub SetDefaultMean(ByVal strSeries As String)
        For Each tmpItm As ToolStripMenuItem In Me.tsShowMean.DropDownItems
            If tmpItm.Tag IsNot Nothing AndAlso tmpItm.Tag.ToString.ToUpper = strSeries.ToUpper Then
                tmpItm.Checked = True
                UpdateMean(strSeries.ToUpper, False)
            End If
        Next
    End Sub

    ''' <summary>
    ''' 평균값 라인을 갱신한다. 한번에 한개만 가능하도록 함. 여러개 할 경우 보기도 힘들고 AddSeries에서 해당하는 값들을 모두 생성처리해야함. 
    ''' </summary>
    ''' <param name="strSeries">테이터영역 이름</param>
    ''' <param name="Init">초기화여부</param>
    ''' <remarks>기본 + 멀티 모두 사</remarks>
    Private Sub UpdateMean(ByVal strSeries As String, ByVal Init As Boolean)
        Dim selSeries As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Item(strSeries.ToUpper)
        Dim MeanLine As System.Windows.Forms.DataVisualization.Charting.StripLine = MainChart.ChartAreas(selSeries.ChartArea).AxisY.StripLines(0)

        '초기화가 아닐경우 
        If Init = False Then

            ' 데이터 영역을 가져온다. 

            ' 자체 함수를 사용하여 평균값을 가져온다. 
            Dim dblMean As Double = 0
            If selSeries.Points.Count > 0 Then
                dblMean = MainChart.DataManipulator.Statistics.Mean(selSeries.Name)
            Else
                dblMean = 0
            End If

            ' 선의 위치를 조정한다. 
            MeanLine.IntervalOffset = dblMean
            ' 선의 주석을 단다. 
            MeanLine.Text = selSeries.LegendText & " : " & dblMean.ToString("N1")
            ' 선 택상을 변경한다. 
            MeanLine.BorderColor = Color.Red
            ' 평균라인의 재갱신을 위하여 Tag에 String으로 해당 값을 보여준다. 
            MeanLine.Tag = selSeries.Name
        Else
            ' 데이터 영역이 없을 경우 초기화
            ' 라인을 0으로 옮기면 선이 사라짐 
            MeanLine.IntervalOffset = 0
            ' 텍스를 삭제 
            MeanLine.Text = ""
            ' 평균라인을 재갱신하고 위한 Tag 초기화 
            MeanLine.Tag = ""
        End If

    End Sub

#End Region

#Region "Strip Line(Y 축 범위별 색상 표시) "


    ''' <summary>
    ''' Y축 백그라운드로 지정된 Y 값의 범위에 색상을 넣는다. 
    ''' </summary>
    ''' <param name="KeyName">Key Name</param>
    ''' <param name="Text">표시 문자</param>
    ''' <param name="LineColor">라인 색상</param>
    ''' <param name="FromValue">시작 범위</param>
    ''' <param name="ToValue">종료 범위</param>
    ''' <remarks>SetStripeLine("KEY1","첫번째키",Color.red,0,10)</remarks>
    Public Sub SetStripeLine(ByVal KeyName As String, ByVal Text As String, ByVal LineColor As System.Drawing.Color, ByVal FromValue As Double, ByVal ToValue As Double)
        Dim tmpStripLine As System.Windows.Forms.DataVisualization.Charting.StripLine = Nothing
        ' 혹시 사용자가 From To를 잘못 넣었을 것을 대비하여 수치 변경 
        If ToValue < FromValue Then
            Dim tmpValue As Double = FromValue
            FromValue = ToValue
            ToValue = tmpValue
        End If

        ' 등록된 값이 없을 경우 새로 생성 
        If Me._srtStripNm.Item(KeyName.ToUpper) Is Nothing Then
            ' 신규 객체 생성 
            tmpStripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
            ' 문자 관련 좌측으로 몰아준다. 
            tmpStripLine.TextLineAlignment = StringAlignment.Near
            tmpStripLine.TextAlignment = StringAlignment.Near
            tmpStripLine.TextOrientation = DataVisualization.Charting.TextOrientation.Auto
            ' 선색상을 맞춘다. 
            tmpStripLine.BorderColor = LineColor
            ' 선두께 사이의 색상을 맞춘다. 
            tmpStripLine.BackColor = LineColor
            ' 선의 시작 위치 
            tmpStripLine.IntervalOffset = FromValue
            ' 선의 끝위치 
            tmpStripLine.StripWidth = ToValue - FromValue
            tmpStripLine.Text = Text


            ' 차트 그리기 영역에 데이터를 추가한다. 
            Me.MainChart.ChartAreas("DEFAREA").AxisY.StripLines.Add(tmpStripLine)
            ' 전역 변수에 명칭으로 라인을 넣는다. 명칭이 설정되지 않아서 Sortedlist를 사용함 
            _srtStripNm.Add(KeyName.ToUpper, tmpStripLine)

        Else
            ' 등록된 값이 있을 경우 기존 데이터 수정
            tmpStripLine = _srtStripNm.Item(KeyName.ToUpper)
            ' 기등록 데이터로 현재 있는 위치 Index를 가져온다. 
            Dim intIdx As Integer = Me.MainChart.ChartAreas("DEFAREA").AxisY.StripLines.IndexOf(tmpStripLine)
            ' 기등록 라인정보를 가져와서 변경한다. 
            tmpStripLine = Me.MainChart.ChartAreas("DEFAREA").AxisY.StripLines.Item(intIdx)
            tmpStripLine.BorderColor = LineColor
            tmpStripLine.BackColor = LineColor
            tmpStripLine.IntervalOffset = FromValue
            tmpStripLine.StripWidth = ToValue - FromValue
            ' 전역 변수에 변경된 값을 넣는다. 
            _srtStripNm.Item(KeyName.ToUpper) = tmpStripLine

            tmpStripLine.Text = Text
            ' 기존에 있던 INdex에 덮어 씌운다. 
            Me.MainChart.ChartAreas("DEFAREA").AxisY.StripLines(intIdx) = tmpStripLine


        End If

    End Sub

    ''' <summary>
    ''' 멀티 차트용 Y축 백그라운드로 지정된 Y 값의 범위에 색상을 넣는다. 
    ''' </summary>
    ''' <param name="KeyName">Key Name</param>
    ''' <param name="Text">표시 문자</param>
    ''' <param name="LineColor">라인 색상</param>
    ''' <param name="FromValue">시작 범위</param>
    ''' <param name="ToValue">종료 범위</param>
    ''' <remarks>SetStripeLine("KEY1","첫번째키",Color.red,0,10)</remarks>
    Public Sub SetStripeLine(ByVal SeriesNm As String, ByVal KeyName As String, ByVal Text As String, ByVal LineColor As System.Drawing.Color, ByVal FromValue As Double, ByVal ToValue As Double)
        Dim tmpStripLine As System.Windows.Forms.DataVisualization.Charting.StripLine = Nothing
        ' 혹시 사용자가 From To를 잘못 넣었을 것을 대비하여 수치 변경 
        If ToValue < FromValue Then
            Dim tmpValue As Double = FromValue
            FromValue = ToValue
            ToValue = tmpValue
        End If


        ' Series 가 속한 Chart 그리기 영역을 가져온다 
        Dim strAreaNm As String = Me.MainChart.Series(SeriesNm.ToUpper).ChartArea


        ' 등록된 값이 없을 경우 새로 생성 
        If Me._srtStripNm.Item(KeyName.ToUpper) Is Nothing Then
            ' 신규 객체 생성 
            tmpStripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine
            ' 문자 관련 좌측으로 몰아준다. 
            tmpStripLine.TextLineAlignment = StringAlignment.Near
            tmpStripLine.TextAlignment = StringAlignment.Near
            tmpStripLine.TextOrientation = DataVisualization.Charting.TextOrientation.Auto
            ' 선색상을 맞춘다. 
            tmpStripLine.BorderColor = LineColor
            ' 선두께 사이의 색상을 맞춘다. 
            tmpStripLine.BackColor = LineColor
            ' 선의 시작 위치 
            tmpStripLine.IntervalOffset = FromValue
            ' 선의 끝위치 
            tmpStripLine.StripWidth = ToValue - FromValue
            tmpStripLine.Text = Text

            ' 차트 그리기 영역에 데이터를 추가한다. 
            Me.MainChart.ChartAreas(strAreaNm).AxisY.StripLines.Add(tmpStripLine)
            ' 전역 변수에 명칭으로 라인을 넣는다. 명칭이 설정되지 않아서 Sortedlist를 사용함 
            _srtStripNm.Add(KeyName.ToUpper, tmpStripLine)

        Else
            ' 등록된 값이 있을 경우 기존 데이터 수정
            tmpStripLine = _srtStripNm.Item(KeyName.ToUpper)
            ' 기등록 데이터로 현재 있는 위치 Index를 가져온다. 
            Dim intIdx As Integer = Me.MainChart.ChartAreas(strAreaNm).AxisY.StripLines.IndexOf(tmpStripLine)
            ' 기등록 라인정보를 가져와서 변경한다. 
            tmpStripLine = Me.MainChart.ChartAreas(strAreaNm).AxisY.StripLines.Item(intIdx)
            tmpStripLine.BorderColor = LineColor
            tmpStripLine.BackColor = LineColor
            tmpStripLine.IntervalOffset = FromValue
            tmpStripLine.StripWidth = ToValue - FromValue
            ' 전역 변수에 변경된 값을 넣는다. 
            _srtStripNm.Item(KeyName.ToUpper) = tmpStripLine

            tmpStripLine.Text = Text
            ' 기존에 있던 INdex에 덮어 씌운다. 
            Me.MainChart.ChartAreas(strAreaNm).AxisY.StripLines(intIdx) = tmpStripLine


        End If

    End Sub


#End Region


    ''' <summary>
    ''' 단일 차트용 데이터 영역을 삽입한다. 
    ''' </summary>
    ''' <param name="SeriesName">데이터명칭KEY</param>
    ''' <param name="strTitle">범례 표시 이름 </param>
    ''' <param name="LineColor">선택적 인수 차트 범례 색상 </param>
    ''' <remarks>DEFAREA 라고 기본 설정 차트 그리기 영역에 설정됨</remarks>
    Public Sub AddSeries(ByVal SeriesName As String, ByVal strTitle As String, Optional ByVal LineColor As System.Drawing.Color = Nothing, Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line, Optional ByVal YAxisType As AxisType = AxisType.Primary)
        ' 데이터 영역 삽입 
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Add(SeriesName.ToUpper)
        Series.LabelForeColor = Color.FromArgb(170, 170, 170)
        ' 범례 이름 삽입 
        Series.LegendText = strTitle
        ' 차트가 그려질 영역 선택 
        Series.ChartArea = "DEFAREA"
        ' 차트 유형 선택 
        Series.ChartType = ChartType
        ' 범례가 그려질 대상을 선택 
        Series.Legend = "DEFLEGEND"
        ' X 축의 좌표를 시간으로 설정 
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        ' X 좌표의 INDEX를 자동으로 함 (ZOOM에서 드래그 단위를 위함 설정 안할 경우 X 축은 ZOOM이 되지 않는다.) 
        Series.IsXValueIndexed = False
        ' 표시 축 설정 
        Series.YAxisType = YAxisType
        ' 사용자 설정 데이터로 중간에 값이 없으면 0으로 자동 삽입 
        Series.CustomProperties = "EmptyPointValue=Zero"
        If Not IsNothing(LineColor) Then
            Series.Color = LineColor
        End If


        Series.BorderWidth = 2
        '컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
        setToolstripMenu(SeriesName, strTitle)


    End Sub
    ''' <summary>
    ''' 단일 차트용 데이터 DataRows 를 삽입
    ''' </summary>
    ''' <param name="SeriesName"></param>
    ''' <param name="strTitle"></param>
    ''' <param name="DataSource"></param>
    ''' <param name="XMember"></param>
    ''' <param name="YMember"></param>
    ''' <param name="LineCOlor"></param>
    ''' <param name="ChartType"></param>
    ''' <remarks></remarks>
    Public Sub AddSeries(ByVal SeriesName As String, ByVal strTitle As String, ByVal DataSource As DataTable, ByVal XMember As String, ByVal YMember As String, Optional ByVal LineCOlor As System.Drawing.Color = Nothing, Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line, Optional ByVal YAxisType As AxisType = AxisType.Primary)
        ' 데이터 영역 삽입 
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Add(SeriesName.ToUpper)
        Series.LabelForeColor = Color.FromArgb(170, 170, 170)
        ' 범례 이름 삽입 
        Series.LegendText = strTitle
        ' 차트가 그려질 영역 선택 
        Series.ChartArea = "DEFAREA"
        ' 차트 유형 선택 
        Series.ChartType = ChartType
        ' 범례가 그려질 대상을 선택 
        Series.Legend = "DEFLEGEND"
        ' X 축의 좌표를 시간으로 설정 
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        ' X 좌표의 INDEX를 자동으로 함 (ZOOM에서 드래그 단위를 위함 설정 안할 경우 X 축은 ZOOM이 되지 않는다.) 
        Series.IsXValueIndexed = True
        ' 표시 축 설정 
        Series.YAxisType = YAxisType
        ' 사용자 설정 데이터로 중간에 값이 없으면 0으로 자동 삽입 
        Series.CustomProperties = "EmptyPointValue=Zero"
        If Not IsNothing(LineCOlor) Then
            Series.Color = LineCOlor
        End If
        '컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
        setToolstripMenu(SeriesName, strTitle)
        Me.MainChart.DataSource = DataSource
        Series.XValueMember = XMember
        Series.YValueMembers = YMember

    End Sub
    ''' <summary>
    ''' 멀티 차트용 데이터 DataRows 를 삽입
    ''' </summary>
    ''' <param name="SeriesName"></param>
    ''' <param name="strTitle"></param>
    ''' <param name="DataSource"></param>
    ''' <param name="XMember"></param>
    ''' <param name="YMember"></param>
    ''' <param name="LineCOlor"></param>
    ''' <param name="ChartType"></param>
    ''' <remarks></remarks>
    Public Sub AddSeries(ByVal AreaName As String, ByVal SeriesName As String, ByVal strTitle As String, ByVal DataSource As DataTable, ByVal XMember As String, ByVal YMember As String, Optional ByVal LineCOlor As System.Drawing.Color = Nothing, Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line, Optional ByVal YAxisType As AxisType = AxisType.Primary)

        ' 데이터 영역 삽입 
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Add(SeriesName.ToUpper)
        Series.LabelForeColor = Color.FromArgb(170, 170, 170)
        ' 범례 이름 삽입 
        Series.LegendText = strTitle
        ' 차트가 그려질 영역 선택 
        Series.ChartArea = AreaName
        ' 차트 유형 선택 
        Series.ChartType = ChartType
        ' 범례가 그려질 대상을 선택 
        Series.Legend = "LEG" & AreaName
        ' X 축의 좌표를 시간으로 설정 
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        ' X 좌표의 INDEX를 자동으로 함 (ZOOM에서 드래그 단위를 위함 설정 안할 경우 X 축은 ZOOM이 되지 않는다.) 
        Series.IsXValueIndexed = True
        ' 표시 축 설정 
        Series.YAxisType = YAxisType
        ' 사용자 설정 데이터로 중간에 값이 없으면 0으로 자동 삽입 
        Series.CustomProperties = "EmptyPointValue=Zero"
        If Not IsNothing(LineCOlor) Then
            Series.Color = LineCOlor
        End If
        '컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
        setToolstripMenu(SeriesName, strTitle)
        Me.MainChart.DataSource = DataSource
        Series.XValueMember = XMember
        Series.YValueMembers = YMember

    End Sub

    Public Sub AddPieSeries(ByVal SeriesName As String, ByVal strTitle As String, Optional ByVal LineCOlor As System.Drawing.Color = Nothing)
        ' 데이터 영역 삽입 
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Add(SeriesName.ToUpper)
        ' 범례 이름 삽입 
        Series.LegendText = strTitle
        ' 차트가 그려질 영역 선택 
        Series.ChartArea = "DEFAREA"
        ' 차트 유형 선택 
        Series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Me.MainChart.ChartAreas(Series.ChartArea).Area3DStyle.Enable3D = True
        ' 범례가 그려질 대상을 선택 
        Series.Legend = "DEFLEGEND"
        ' X 축의 좌표를 시간으로 설정 
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        ' X 좌표의 INDEX를 자동으로 함 (ZOOM에서 드래그 단위를 위함 설정 안할 경우 X 축은 ZOOM이 되지 않는다.) 
        Series.IsXValueIndexed = True
        ' 사용자 설정 데이터로 중간에 값이 없으면 0으로 자동 삽입 
        Series.CustomProperties = "EmptyPointValue=Zero"
        If Not IsNothing(LineCOlor) Then
            Series.Color = LineCOlor
        End If
        '컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
        setToolstripMenu(SeriesName, strTitle)


    End Sub

    Public Sub AddPiePoints(ByVal strSeries As String, ByVal yValue As Double, ByVal Label As String)
        Dim selSeries As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series(strSeries.ToUpper)
        If selSeries IsNot Nothing Then

            Dim tmpIdx As Integer = selSeries.Points.AddY(yValue)
            Dim tmpPt As System.Windows.Forms.DataVisualization.Charting.DataPoint = selSeries.Points(tmpIdx)
            MainChart.ApplyPaletteColors()


            selSeries.Points(tmpIdx).CustomProperties = String.Format("PieLabelStyle=Outside, PieLineColor={0}\,{1}\,{2}", tmpPt.Color.R, tmpPt.Color.G, tmpPt.Color.B)
            tmpPt.LegendText = Label
            tmpPt.LabelBackColor = tmpPt.Color
            tmpPt.LabelBorderColor = tmpPt.Color

            tmpPt.Label = "#LEGENDTEXT #PERCENT"

        End If
    End Sub

    ''' <summary>
    ''' 멀티 차트용 데이터 영역을 삽입한다. 
    ''' </summary>
    ''' <param name="AreaName">해당 데이터가 그려질 Area 명칭</param>
    ''' <param name="SeriesName">데이터명칭KEY</param>
    ''' <param name="strTitle">범례 표시 이름 </param>
    ''' <param name="LineColor">선택적 인수 차트 범례 색상 </param>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Public Sub AddSeries(ByVal AreaName As String, ByVal SeriesName As String, ByVal strTitle As String, Optional ByVal LineColor As System.Drawing.Color = Nothing, Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line, Optional ByVal YAxisType As AxisType = AxisType.Primary)

        AddSeriesEx(AreaName, "LEG" & AreaName, SeriesName, strTitle, LineColor, ChartType, YAxisType)

    End Sub

    ''' <summary>
    ''' 멀티차트용 영역 및 데이터 일괄 생성 
    ''' 무조건 Area를 재 생성하므로 Area에 Series를 추가하고 싶다면 AddSeries (areaname....)으로 시작하는 함수를 호출 
    ''' </summary>
    ''' <param name="SeriesName">데이터명칭KEY</param>
    ''' <param name="LineColor">선택적 인수 차트 범례 색상 </param>
    ''' <param name="AreaVisible">추가후 바로 보일지 여부</param>
    ''' <param name="AreaName">영역명을 지칭 지칭하지 않을 경우 AREA + 순번으로 자동으로 됨.</param>
    ''' <returns>생성된 영역명칭</returns>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Private Function AddSeriesWithArea(ByVal SeriesName As String, ByVal xTitle As String, ByVal yTitle As String, Optional ByVal LineColor As System.Drawing.Color = Nothing, Optional ByVal AreaVisible As Boolean = False, Optional ByVal AreaName As String = "", Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line) As String
        ' 현재 일시 사용 중지 (2013-09-10)
        ' 영역 생성 
        Dim strNewAreaNm As String = AddArea(AreaVisible, AreaName, xTitle, yTitle)
        ' 영역에 표시될 범례 생성 
        Dim strNewLegendNm As String = AddLegend(strNewAreaNm)
        ' 생성된 영역과 범례에 데이터 
        AddSeries(strNewAreaNm, strNewLegendNm, SeriesName, xTitle, LineColor, ChartType)
        ' 멀티차트 표시용 차트쪽에 메뉴 표시 
        Dim tmpTsItm As ToolStripMenuItem = tsCharts.DropDownItems.Add(xTitle, Nothing, AddressOf ShowChartClick)
        tmpTsItm.Name = "tsGRP" & strNewAreaNm.ToUpper
        tmpTsItm.Checked = AreaVisible
        tmpTsItm.CheckOnClick = True
        tmpTsItm.Tag = strNewAreaNm

        ' 멀티차트인지 구별하는 것으로 Initialize시에는 Visible 이 없다가 본 함수를 한번이라도 타게되면 멀티 차트를 사용하겠다는 것으로 인식하고 
        ' 숨겨진 메뉴를 꺼낸다. 
        If tsCharts.Visible = False Then
            tsCharts.Visible = True
        End If
        ' 생성된 신규 차트 그리기 영역명칭 반환 
        Return strNewAreaNm

    End Function

    ''' <summary>
    ''' 멀티차트용 영역   생성 
    ''' 무조건 Area를 재 생성하므로 Area에 Series를 추가하고 싶다면 AddSeries (areaname....)으로 시작하는 함수를 호출 
    ''' </summary>
    ''' <param name="AreaVisible">추가후 바로 보일지 여부</param>
    ''' <param name="AreaName">영역명을 지칭 지칭하지 않을 경우 AREA + 순번으로 자동으로 됨.</param>
    ''' <returns>생성된 영역명칭</returns>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Public Function AddArea(ByVal xTitle As String, ByVal yTitle As String, Optional ByVal AreaVisible As Boolean = False, Optional ByVal AreaName As String = "") As String
        ' 영역 생성 
        Dim strNewAreaNm As String = AddArea(AreaVisible, AreaName, xTitle, yTitle)
        ' 영역에 표시될 범례 생성 
        Dim strNewLegendNm As String = AddLegend(strNewAreaNm)

        ' 멀티차트 표시용 차트쪽에 메뉴 표시 
        Dim tmpTsItm As ToolStripMenuItem = tsCharts.DropDownItems.Add(xTitle, Nothing, AddressOf ShowChartClick)
        tmpTsItm.Name = "tsGRP" & strNewAreaNm.ToUpper
        tmpTsItm.Checked = AreaVisible
        tmpTsItm.CheckOnClick = True
        tmpTsItm.Tag = strNewAreaNm

        ' 멀티차트인지 구별하는 것으로 Initialize시에는 Visible 이 없다가 본 함수를 한번이라도 타게되면 멀티 차트를 사용하겠다는 것으로 인식하고 
        ' 숨겨진 메뉴를 꺼낸다. 
        If tsCharts.Visible = False Then
            _UseGroupMenu = True
            tsCharts.Visible = True
        End If
        ' 생성된 신규 차트 그리기 영역명칭 반환 
        Return strNewAreaNm

    End Function
    ''' <summary>
    ''' 멀티차트용 영역   생성 
    ''' 무조건 Area를 재 생성하므로 Area에 Series를 추가하고 싶다면 AddSeries (areaname....)으로 시작하는 함수를 호출 
    ''' </summary>
    ''' <param name="AreaVisible">추가후 바로 보일지 여부</param>
    ''' <param name="AreaName">영역명을 지칭 지칭하지 않을 경우 AREA + 순번으로 자동으로 됨.</param>
    ''' <returns>생성된 영역명칭</returns>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Public Function AddAreaEx(ByVal xTitle As String, ByVal yTitle As String, Optional ByVal AreaVisible As Boolean = False, Optional ByVal AreaName As String = "") As String
        ' 영역 생성 
        Dim strNewAreaNm As String = AddArea(AreaVisible, AreaName, xTitle, yTitle)
        Dim defLegend As System.Windows.Forms.DataVisualization.Charting.Legend = Me.MainChart.Legends(0)
        Dim defChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea = Me.MainChart.ChartAreas(0)
        Dim StripLine1 As System.Windows.Forms.DataVisualization.Charting.StripLine = defChartArea.AxisY.StripLines(0)
        'Dim defVerticalAnnotation As System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation = Me.MainChart.Annotations(0)


        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = Me.MainChart.ChartAreas(strNewAreaNm)
        '
        'MainChart
        '
        Me.MainChart.BackColor = System.Drawing.Color.Black
        ChartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical
        ChartArea1.AxisX.IntervalAutoMode = defChartArea.AxisX.IntervalAutoMode
        ChartArea1.AxisX.IsMarginVisible = defChartArea.AxisX.IsMarginVisible
        ChartArea1.AxisX.LabelStyle.ForeColor = defChartArea.AxisX.LabelStyle.ForeColor
        ChartArea1.AxisX.LabelStyle.Format = defChartArea.AxisX.LabelStyle.Format
        ChartArea1.AxisX.LabelStyle.Interval = defChartArea.AxisX.LabelStyle.Interval
        ChartArea1.AxisX.LabelStyle.IntervalOffset = defChartArea.AxisX.LabelStyle.IntervalOffset
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = defChartArea.AxisX.LabelStyle.IntervalOffsetType
        ChartArea1.AxisX.LabelStyle.IntervalType = defChartArea.AxisX.LabelStyle.IntervalType
        ChartArea1.AxisX.LineColor = defChartArea.AxisX.LineColor
        ChartArea1.AxisX.MajorGrid.Interval = defChartArea.AxisX.MajorGrid.Interval
        ChartArea1.AxisX.MajorGrid.LineColor = defChartArea.AxisX.MajorGrid.LineColor
        ChartArea1.AxisX.MajorGrid.LineDashStyle = defChartArea.AxisX.MajorGrid.LineDashStyle
        ChartArea1.AxisX.ScrollBar.ButtonColor = defChartArea.AxisX.ScrollBar.ButtonColor
        ChartArea1.AxisX.TitleForeColor = defChartArea.AxisX.TitleForeColor

        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        ChartArea1.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea1.AxisX.LabelStyle.Interval = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        ChartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))

        ChartArea1.AxisY.StripLines.Add(StripLine1)
        ChartArea1.AxisY.TitleForeColor = defChartArea.AxisY.TitleForeColor
        ChartArea1.AxisX.TitleForeColor = Color.Yellow
        ChartArea1.AxisX.TitleFont = New Font("Gulim", 10.0!, System.Drawing.FontStyle.Regular)
        'ChartArea1.AxisY.Enabled = AxisEnabled.Auto
        ChartArea1.AxisY2.Enabled = AxisEnabled.Auto
        ChartArea1.BackColor = defChartArea.BackColor
        ChartArea1.BorderColor = defChartArea.BorderColor

        ' 영역에 표시될 범례 생성 
        Dim strNewLegendNm As String = AddLegend(strNewAreaNm)
        Dim tmpLegend As System.Windows.Forms.DataVisualization.Charting.Legend = Me.MainChart.Legends(strNewLegendNm)
        tmpLegend.Alignment = defLegend.Alignment
        tmpLegend.Alignment = System.Drawing.StringAlignment.Far
        tmpLegend.BackColor = System.Drawing.Color.Black
        tmpLegend.CellColumns(0) = defLegend.CellColumns(0)
        tmpLegend.CellColumns(1) = defLegend.CellColumns(1)
        tmpLegend.CellColumns(2) = defLegend.CellColumns(2)
        tmpLegend.CellColumns(3) = defLegend.CellColumns(3)
        tmpLegend.CellColumns(4) = defLegend.CellColumns(4)
        tmpLegend.CellColumns(5) = defLegend.CellColumns(5)
        tmpLegend.Docking = defLegend.Docking
        tmpLegend.ForeColor = defLegend.ForeColor
        tmpLegend.HeaderSeparator = defLegend.HeaderSeparator
        tmpLegend.HeaderSeparatorColor = defLegend.HeaderSeparatorColor
        tmpLegend.IsDockedInsideChartArea = defLegend.IsDockedInsideChartArea
        tmpLegend.ItemColumnSeparator = defLegend.ItemColumnSeparator
        tmpLegend.ItemColumnSeparatorColor = defLegend.ItemColumnSeparatorColor
        tmpLegend.TitleForeColor = defLegend.TitleForeColor
        tmpLegend.TitleSeparatorColor = defLegend.TitleSeparatorColor

        ' 멀티차트 표시용 차트쪽에 메뉴 표시 
        Dim tmpTsItm As ToolStripMenuItem = tsCharts.DropDownItems.Add(xTitle, Nothing, AddressOf ShowChartClick)
        tmpTsItm.Name = "tsGRP" & strNewAreaNm.ToUpper
        tmpTsItm.Checked = AreaVisible
        tmpTsItm.CheckOnClick = True
        tmpTsItm.Tag = strNewAreaNm

        ' 멀티차트인지 구별하는 것으로 Initialize시에는 Visible 이 없다가 본 함수를 한번이라도 타게되면 멀티 차트를 사용하겠다는 것으로 인식하고 
        ' 숨겨진 메뉴를 꺼낸다. 
        If tsCharts.Visible = False Then
            _UseGroupMenu = True
            tsCharts.Visible = True
        End If
        ' 생성된 신규 차트 그리기 영역명칭 반환 
        Return strNewAreaNm

    End Function
    ''' <summary>
    ''' 멀티차트용 그리기영역 생성 (DEFAREA가 Clone 되지 않아서 해당하는 값을 프로그램으로 생성) 
    ''' </summary>
    ''' <param name="bretAreaVisible">화면에 표시 될지 여부</param>
    ''' <param name="AreaName">그리기영역명칭</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AddAreaEx(ByVal bretAreaVisible As Boolean,
                               ByVal AreaName As String,
                               ByVal ChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea,
                               Optional ByVal XTitle As String = "",
                               Optional ByVal YTitle As String = "") As String
        Dim strAreaName As String = ""
        If AreaName <> "" Then
            ' 기존에 등록된 데이터가 없을 경우 
            strAreaName = AreaName.ToUpper
        Else
            ' 명칭이 지정되지 않은 경우 AREA + 순번을 생성 
            strAreaName = "AREA" & Me.MainChart.ChartAreas.Count
        End If

        ' 차트 ChartArea Collection 에 추가함. 
        MainChart.ChartAreas.Add(ChartArea)
        ' 생성된 차트 이름 반환 
        Return ChartArea.Name
    End Function

    ''' <summary>
    ''' 멀티차트용 데이터 영역을 삽입한다. 
    ''' </summary>
    ''' <param name="AreaNm">그려질 영역 명칭</param>
    ''' <param name="LengendNm">데이터가 표시될 범례 명칭</param>
    ''' <param name="SeriesName">영역이름 Key값</param>
    ''' <param name="strTitle">차트 Title </param>
    ''' <param name="LineColor">선택적 인수 차트 범례 색상 </param>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Private Sub AddSeries(ByVal AreaNm As String, ByVal LengendNm As String, ByVal SeriesName As String, ByVal strTitle As String, Optional ByVal LineColor As System.Drawing.Color = Nothing, Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line, Optional ByVal YAxisType As AxisType = AxisType.Primary)
        ' 데이터 영역 삽입 
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Add(SeriesName.ToUpper)
        Series.LabelForeColor = Color.FromArgb(170, 170, 170)
        ' 범례 이름 삽입 
        Series.LegendText = strTitle
        ' 차트가 그려질 영역 선택 
        Series.ChartArea = AreaNm
        ' 차트 유형 선택 
        Series.ChartType = ChartType
        ' 범례가 그려질 대상을 선택 
        Series.Legend = LengendNm
        ' X 축의 좌표를 시간으로 설정 
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        ' X 좌표의 INDEX를 자동으로 함 (ZOOM에서 드래그 단위를 위함 설정 안할 경우 X 축은 ZOOM이 되지 않는다.) 
        Series.IsXValueIndexed = True
        ' 사용자 설정 데이터로 중간에 값이 없으면 0으로 자동 삽입 
        Series.CustomProperties = "EmptyPointValue=Zero"
        If Not IsNothing(LineColor) Then
            Series.Color = LineColor
        End If
        ' 표시 축 설정 
        Series.YAxisType = YAxisType
        '컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
        setToolstripMenu(SeriesName, strTitle)

    End Sub
    ''' <summary>
    ''' 멀티차트용 데이터 영역을 삽입한다. 
    ''' </summary>
    ''' <param name="AreaNm">그려질 영역 명칭</param>
    ''' <param name="LengendNm">데이터가 표시될 범례 명칭</param>
    ''' <param name="SeriesName">영역이름 Key값</param>
    ''' <param name="strTitle">차트 Title </param>
    ''' <param name="LineColor">선택적 인수 차트 범례 색상 </param>
    ''' <remarks>멀티차트에서 사용하는 것으로 각각 개별 그리기 영역에 설정됨</remarks>
    Private Sub AddSeriesEx(ByVal AreaNm As String, ByVal LengendNm As String, ByVal SeriesName As String, ByVal strTitle As String, Optional ByVal LineColor As System.Drawing.Color = Nothing, Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line, Optional ByVal YAxisType As AxisType = AxisType.Primary)
        ' 데이터 영역 삽입 
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series.Add(SeriesName.ToUpper)
        Series.LabelForeColor = Color.FromArgb(170, 170, 170)
        ' 범례 이름 삽입 
        Series.LegendText = strTitle
        ' 차트가 그려질 영역 선택 
        Series.ChartArea = AreaNm
        ' 차트 유형 선택 
        Series.ChartType = ChartType
        ' 범례가 그려질 대상을 선택 
        Series.Legend = LengendNm
        ' X 축의 좌표를 시간으로 설정 
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        ' X 좌표의 INDEX를 자동으로 함 (ZOOM에서 드래그 단위를 위함 설정 안할 경우 X 축은 ZOOM이 되지 않는다.) 
        Series.IsXValueIndexed = False
        ' 사용자 설정 데이터로 중간에 값이 없으면 0으로 자동 삽입 
        Series.CustomProperties = "EmptyPointValue=Zero"
        If Not IsNothing(LineColor) Then
            Series.Color = LineColor
        End If
        ' 표시 축 설정 
        Series.YAxisType = YAxisType
        Series.BorderWidth = 2
        '컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
        setToolstripMenu(SeriesName, strTitle)

    End Sub



    ''' <summary>
    ''' 멀티차트용 그리기영역 생성 (DEFAREA가 Clone 되지 않아서 해당하는 값을 프로그램으로 생성) 
    ''' </summary>
    ''' <param name="bretAreaVisible">화면에 표시 될지 여부</param>
    ''' <param name="AreaName">그리기영역명칭</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AddArea(ByVal bretAreaVisible As Boolean, Optional ByVal AreaName As String = "", Optional ByVal XTitle As String = "", Optional ByVal YTitle As String = "") As String
        Dim strAreaName As String = ""
        'If AreaName <> "" AndAlso Me.MainChart.ChartAreas(AreaName.ToUpper) Is Nothing Then
        If AreaName <> "" Then
            ' 기존에 등록된 데이터가 없을 경우 
            strAreaName = AreaName.ToUpper
        Else
            ' 명칭이 지정되지 않은 경우 AREA + 순번을 생성 
            strAreaName = "AREA" & Me.MainChart.ChartAreas.Count
        End If
        ' 신규 그리기 영역 생성 
        Dim tmpChartArea As New System.Windows.Forms.DataVisualization.Charting.ChartArea(strAreaName)
        ' 평균값 표시를 위한 Stripe Line 생성 
        Dim tmpStripLine As New System.Windows.Forms.DataVisualization.Charting.StripLine()
        ' 평균 표시 설정 값
        With tmpStripLine
            .BackColor = System.Drawing.Color.White
            .BorderColor = System.Drawing.Color.Red
            .TextAlignment = System.Drawing.StringAlignment.Center
            .TextLineAlignment = System.Drawing.StringAlignment.Far
        End With

        ' 그리기 영역 설정 
        With tmpChartArea
            .AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
            .AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
            .AxisX.IsMarginVisible = False
            .AxisX.LabelStyle.Format = "HH:mm:ss"
            .AxisX.LabelStyle.Interval = 0.0R
            .AxisX.LabelStyle.IntervalOffset = 0.0R
            .AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
            .AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
            .AxisX.MajorGrid.Interval = 0.0R
            .AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
            .AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
            .AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
            .AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash

            .AxisY.StripLines.Add(tmpStripLine)
            .Visible = bretAreaVisible
            .AxisX.Title = XTitle
            .AxisY.Title = YTitle
        End With
        ' 차트 ChartArea Collection 에 추가함. 
        MainChart.ChartAreas.Add(tmpChartArea)
        ' 생성된 차트 이름 반환 
        Return tmpChartArea.Name
    End Function

    ''' <summary>
    ''' 멀티차트용 범례 생성 
    ''' </summary>
    ''' <param name="strArea">그리기 영역 명칭</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AddLegend(ByVal strArea As String) As String
        ' LEG 로 PREFIX 
        Dim tmpLegend As New System.Windows.Forms.DataVisualization.Charting.Legend("LEG" & strArea.ToUpper)
        With tmpLegend

            Dim LegendCellColumn1 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
            Dim LegendCellColumn2 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
            Dim LegendCellColumn3 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
            Dim LegendCellColumn4 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
            Dim LegendCellColumn5 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
            Dim LegendCellColumn6 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()

            LegendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol
            LegendCellColumn1.HeaderText = "Color"
            LegendCellColumn1.Name = "colColor"
            LegendCellColumn2.HeaderText = "Title"
            LegendCellColumn2.Name = "colNm"
            LegendCellColumn3.HeaderText = "Min."
            LegendCellColumn3.Name = "colMin"
            LegendCellColumn3.Text = "#MIN{N1}"
            LegendCellColumn4.HeaderText = "Max."
            LegendCellColumn4.Name = "colMax"
            LegendCellColumn4.Text = "#MAX{N1}"
            LegendCellColumn5.HeaderText = "Avg."
            LegendCellColumn5.Name = "colMean"
            LegendCellColumn5.Text = "#AVG{N1}"
            LegendCellColumn6.HeaderText = "Value"
            LegendCellColumn6.MaximumWidth = 0
            LegendCellColumn6.Name = "colValue"
            LegendCellColumn6.Text = "#LAST"
            .CellColumns.Add(LegendCellColumn1)
            .CellColumns.Add(LegendCellColumn2)
            .CellColumns.Add(LegendCellColumn3)
            .CellColumns.Add(LegendCellColumn4)
            .CellColumns.Add(LegendCellColumn5)
            .CellColumns.Add(LegendCellColumn6)

            tmpLegend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
            tmpLegend.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine
            tmpLegend.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine
            ' Legend 가 표시될 그리기 영역 
            .DockedToChartArea = strArea
            .Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
            .HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine
            .IsDockedInsideChartArea = False
            .ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine
        End With
        ' Legend Collection 추가한다. 
        MainChart.Legends.Add(tmpLegend)

        Return tmpLegend.Name

    End Function


    ''' <summary>
    ''' 좌표를 추가합니다. 
    ''' </summary>
    ''' <param name="strSeries"></param>
    ''' <param name="xValue">Datetime 을 ToOADate로 변환하여 데이터 삽입</param>
    ''' <param name="yValue">Y 값</param>
    ''' <remarks>기본 + 멀티 모두 사용</remarks>
    Public Sub AddPoints(ByVal strSeries As String, ByVal xValue As Double, ByVal yValue As Double)
        Dim selSeries As System.Windows.Forms.DataVisualization.Charting.Series = Me.MainChart.Series(strSeries.ToUpper)
        If selSeries IsNot Nothing Then
            selSeries.Points.AddXY(xValue, yValue)

            Dim meanLine As System.Windows.Forms.DataVisualization.Charting.StripLine = MainChart.ChartAreas(selSeries.ChartArea).AxisY.StripLines(0)
            If meanLine.Tag IsNot Nothing AndAlso meanLine.Tag <> String.Empty AndAlso meanLine.Tag.ToString = strSeries.ToUpper Then
                UpdateMean(strSeries, False)
            End If

            ' 최대 차트 표현 개수를 넘을 경우 넘어간 숫자 만큼 삭제한다.
            'If Me._MaxPointCount < selSeries.Points.Count Then
            '    For i As Integer = selSeries.Points.Count - Me._MaxPointCount - 1 To 0 Step -1
            '        selSeries.Points.RemoveAt(i)
            '    Next
            'End If
        End If
    End Sub


    ''' <summary>
    ''' 최종 X 값을 가져온다. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLastXValue() As Double
        If Me.MainChart.Series(0).Points.Count > 0 Then
            Dim dblXValue As Double = Me.MainChart.Series(0).Points(Me.MainChart.Series(0).Points.Count - 1).XValue
            Return dblXValue
        Else
            Return 0
        End If
    End Function





    ''' <summary>
    ''' 단일 차트용 이벤트 핸들러 등록
    ''' 그냥 메뉴에 DropDown 으로 뿌린다. 
    ''' </summary>
    ''' <param name="strSeriesName"></param>
    ''' <param name="strTitle"></param>
    ''' <remarks></remarks>
    Private Sub AddMenuSeries(ByVal strSeriesName As String, ByVal strTitle As String)
        Dim tsItm As ToolStripMenuItem = tsShowValue.DropDownItems.Add(strTitle, Nothing, AddressOf ShowLabelClick)
        tsItm.Name = "tsSer" & strSeriesName
        tsItm.Checked = False
        tsItm.CheckOnClick = True
        ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
        tsItm.Tag = strSeriesName.ToUpper

        ' 컨트롤 메뉴바 범례보기 동기화 이벤트 핸들러 등록 
        tsItm = tsShowLegend.DropDownItems.Add(strTitle, Nothing, AddressOf ShowLegendClick)
        tsItm.Name = "tsSer" & strSeriesName
        tsItm.Checked = True
        tsItm.CheckOnClick = True
        tsItm.CheckState = CheckState.Checked
        ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
        tsItm.Tag = strSeriesName.ToUpper

        ' 컨트롤 메뉴바 평균보기 동기화 이벤트 핸들러 등록 
        tsItm = tsShowMean.DropDownItems.Add(strTitle, Nothing, AddressOf ShowMeanClick)
        tsItm.Name = "tsSer" & strSeriesName
        tsItm.Checked = True
        tsItm.CheckOnClick = True
        tsItm.CheckState = CheckState.Unchecked
        ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
        tsItm.Tag = strSeriesName.ToUpper
    End Sub

    ''' <summary>
    ''' 멀치 차트용 이벤트 핸들러 등록 
    ''' </summary>
    ''' <param name="strAreaName"></param>
    ''' <param name="strSeriesName"></param>
    ''' <param name="strTitle"></param>
    ''' <remarks></remarks>
    Private Sub AddMenuSeries(ByVal strAreaName As String, ByVal strSeriesName As String, ByVal strTitle As String)
        ' 없을 경우GROUP 만든다. 
        AddMenuGroup(strAreaName, MainChart.ChartAreas(strAreaName).AxisX.Title)
        Dim tsItm As ToolStripMenuItem = Nothing
        Dim arritm As ToolStripItem() = tsShowValue.DropDownItems.Find("tsGRP" & strAreaName, False)
        If arritm.Count > 0 Then
            tsItm = DirectCast(arritm(0), ToolStripMenuItem).DropDownItems.Add(strTitle, Nothing, AddressOf ShowLabelClick)
            tsItm.Name = "tsSer" & strSeriesName
            tsItm.Checked = False
            tsItm.CheckOnClick = True
            ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
            tsItm.Tag = strSeriesName.ToUpper
        End If

        ' 컨트롤 메뉴바 범례보기 동기화 이벤트 핸들러 등록 
        arritm = tsShowLegend.DropDownItems.Find("tsGRP" & strAreaName, False)
        If arritm.Count > 0 Then
            tsItm = DirectCast(arritm(0), ToolStripMenuItem).DropDownItems.Add(strTitle, Nothing, AddressOf ShowLegendClick)
            tsItm.Name = "tsSer" & strSeriesName
            tsItm.Checked = True
            tsItm.CheckOnClick = True
            tsItm.CheckState = CheckState.Checked
            ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
            tsItm.Tag = strSeriesName.ToUpper
        End If


        ' 컨트롤 메뉴바 평균보기 동기화 이벤트 핸들러 등록 
        arritm = tsShowMean.DropDownItems.Find("tsGRP" & strAreaName, False)
        If arritm.Count > 0 Then
            tsItm = DirectCast(arritm(0), ToolStripMenuItem).DropDownItems.Add(strTitle, Nothing, AddressOf ShowMeanClick)
            tsItm.Name = "tsSer" & strSeriesName
            tsItm.Checked = True
            tsItm.CheckOnClick = True
            tsItm.CheckState = CheckState.Unchecked
            ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
            tsItm.Tag = strSeriesName.ToUpper
        End If

    End Sub

    ''' <summary>
    ''' 멀티 차트용 차트별 메뉴를 만든다.
    ''' </summary>
    ''' <param name="strAreaName"></param>
    ''' <param name="strTitle"></param>
    ''' <remarks></remarks>
    Private Sub AddMenuGroup(ByVal strAreaName As String, ByVal strTitle As String)

        strAreaName = strAreaName.ToUpper
        Dim tsItm As ToolStripMenuItem = Nothing
        Dim arritm As ToolStripItem() = Nothing
        arritm = tsShowValue.DropDownItems.Find("tsGRP" & strAreaName, False)
        If arritm.Count = 0 Then
            tsItm = tsShowValue.DropDownItems.Add(strTitle)
            tsItm.Name = "tsGRP" & strAreaName
            ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
            tsItm.Tag = strAreaName
        End If

        arritm = tsShowLegend.DropDownItems.Find("tsGRP" & strAreaName, False)
        If arritm.Count = 0 Then
            ' 컨트롤 메뉴바 범례보기 동기화 이벤트 핸들러 등록 
            tsItm = tsShowLegend.DropDownItems.Add(strTitle)
            tsItm.Name = "tsGRP" & strAreaName
            ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
            tsItm.Tag = strAreaName
        End If
        arritm = tsShowMean.DropDownItems.Find("tsGRP" & strAreaName, False)
        If arritm.Count = 0 Then
            ' 컨트롤 메뉴바 평균보기 동기화 이벤트 핸들러 등록 
            tsItm = tsShowMean.DropDownItems.Add(strTitle)
            tsItm.Name = "tsGRP" & strAreaName
            ' Tag에 해당하는 데이터 영역 명칭을 넣는다. 
            tsItm.Tag = strAreaName
        End If


    End Sub

    ''' <summary>
    ''' 멀티 차트 최초 생성시 Initialize 위함 tsChart Visible 이 켜지면 해당 부분을 타서 기존에 Default 에 그려져 있던 Series 를 등록함.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub setToolstripMenu()

        ' 초기화 
        tsShowMean.DropDownItems.Clear()
        tsShowLegend.DropDownItems.Clear()
        For i As Integer = tsShowValue.DropDownItems.Count - 1 To 2 Step -1
            tsShowValue.DropDownItems.RemoveAt(i)
        Next

        ' 그룹 사용 안할 경우 (차트가 한개일 경우 )
        If _UseGroupMenu = False Then
            For Each tmpSeries As System.Windows.Forms.DataVisualization.Charting.Series In MainChart.Series
                Dim strTItle As String = tmpSeries.LegendText
                Dim strSeriesName As String = tmpSeries.Name.ToUpper
                AddMenuSeries(strSeriesName, strTItle)
            Next
        Else
            ' 현재 Area의 모든 정보를 삽입한다. 
            For Each tmpArea As System.Windows.Forms.DataVisualization.Charting.ChartArea In MainChart.ChartAreas
                Dim strTItle As String = tmpArea.AxisX.Title
                Dim strAreaName As String = tmpArea.Name.ToUpper
                AddMenuGroup(strAreaName, strTItle)
            Next

            For Each tmpSeries As System.Windows.Forms.DataVisualization.Charting.Series In MainChart.Series
                Dim strArea As String = tmpSeries.ChartArea.ToUpper
                Dim strTitle As String = tmpSeries.LegendText
                Dim strSeriesName As String = tmpSeries.Name.ToUpper
                AddMenuSeries(strArea, strSeriesName, strTitle)

            Next
        End If



    End Sub


    ''' <summary>
    '''    컨트롤 메뉴바 값보기 동기화 이벤트 핸들러 등록 
    ''' </summary>
    ''' <param name="strSeriesName"></param>
    ''' <param name="strTitle"></param>
    ''' <remarks></remarks>
    Private Sub setToolstripMenu(ByVal strSeriesName As String, ByVal strTitle As String)


        Dim tmpToolStrip As New ToolStripMenuItem
        If _UseGroupMenu = False Then
            AddMenuSeries(strSeriesName, strTitle)
        Else
            Dim strAreaNm As String = MainChart.Series(strSeriesName.ToUpper).ChartArea
            AddMenuSeries(strAreaNm, strSeriesName, strTitle)
        End If


    End Sub


#End Region

#End Region
















    ' ''' <summary>
    ' ''' 준비중 
    ' ''' </summary>
    ' ''' <param name="sender"></param>
    ' ''' <param name="ev"></param>
    ' ''' <remarks></remarks>
    'Private Sub pd_PrintPage(sender As Object, ev As System.Drawing.Printing.PrintPageEventArgs)

    '    ' VB 프린트 모듈 추가 페이지 여부 확인 
    '    ev.HasMorePages = True

    '    ' 차트 사이즈 계산 
    '    Dim chartPosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, MainChart.Size.Width, MainChart.Size.Height)


    '    Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / CSng(chartPosition.Width)
    '    Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
    '    ' Infinity(무한증가값) log나 기타 수학 함수 혹은 0으로 나누었을 때 값이 1.#INF로 나옴 
    '    If Single.IsInfinity(chartWidthScale) Then chartWidthScale = 1
    '    If Single.IsInfinity(chartHeightScale) Then chartHeightScale = 1

    '    chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
    '    chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))

    '    ' Check if chart view was already set
    '    If Double.IsNaN(MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Position) Then
    '        ' Reset page index
    '        printingPageIndex = 0

    '        ' Set view
    '        MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Position = MainChart.ChartAreas(_SelAreaName).AxisX.Minimum
    '        MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Size = 2
    '        MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.SizeType = DataVisualization.Charting.DateTimeIntervalType.Minutes
    '    End If



    '    ' Draw chart on the printer graphisc
    '    MainChart.Printing.PrintPaint(ev.Graphics, chartPosition)

    '    ' Scroll to the next view (2 months)
    '    Dim currentPosition As Double = MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Position
    '    MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType.LargeIncrement)

    '    ' Check if position was scrolled
    '    If currentPosition >= (MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Position - 1.0) Then
    '        ' No more pages
    '        ev.HasMorePages = False

    '        ' Restore view state
    '        MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Position = Double.NaN
    '        MainChart.ChartAreas(_SelAreaName).AxisX.ScaleView.Size = Double.NaN


    '    End If

    'End Sub
    ' Page index
    'Private printingPageIndex As Integer = 0

    'Private Sub tsPrintMultiPage_Click(sender As Object, e As EventArgs) Handles tsPrintMultiPage.Click
    '    MsgBox("준비중입니다.")
    '    Return


    '    'MainChart.Printing.PrintDocument = New System.Drawing.Printing.PrintDocument()
    '    'AddHandler MainChart.Printing.PrintDocument.PrintPage, AddressOf pd_PrintPage


    '    'Dim pFormTopMost As Boolean = Me.ParentForm.TopMost
    '    'Me.ParentForm.TopMost = False
    '    'MainChart.Printing.PrintPreview()
    '    'Me.ParentForm.TopMost = pFormTopMost
    'End Sub



    Private Sub MainChart_Click(sender As Object, e As EventArgs) Handles MainChart.Click

    End Sub
    ''' <summary>
    ''' 창이 열릴때 메뉴 활성  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuPopUpLegend_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuPopUpLegend.Opening
        mnuPopUpLegend.Enabled = False

        If mnuPopUpLegend.Tag IsNot Nothing AndAlso TypeOf mnuPopUpLegend.Tag Is String AndAlso mnuPopUpLegend.Tag <> String.Empty Then
            mnuPopUpLegend.Enabled = True
            Dim strChartArea As String = mnuPopUpLegend.Tag
            ' 범례에서 선택된 Chart Area의 명칭으로 사용되고 있는 범례를 선택한다. 
            Dim tmpLegend As System.Windows.Forms.DataVisualization.Charting.Legend = fn_FindLegendByAreaNm(strChartArea)
            ' Align 메뉴 Start
            ' Align 메뉴 초기화 
            mnuPopupAlignTop.Checked = False
            mnuPopupAlignLeft.Checked = False
            mnuPopupAlignRght.Checked = False
            mnuPopupAlignBottom.Checked = False
            ' Align 메뉴 설정 
            Select Case tmpLegend.Docking
                Case DataVisualization.Charting.Docking.Top : mnuPopupAlignTop.Checked = True
                Case DataVisualization.Charting.Docking.Left : mnuPopupAlignLeft.Checked = True
                Case DataVisualization.Charting.Docking.Right : mnuPopupAlignRght.Checked = True
                Case DataVisualization.Charting.Docking.Bottom : mnuPopupAlignBottom.Checked = True
            End Select
            ' Align 메뉴 End

            ' 숨기기 Start 
            mnuPopupHidden.Checked = IIf(tmpLegend.Enabled, False, True)
            ' 숨기기 End 

            ' Cell 항목 Start 
            ' 색상과 Title 명은 무조건 보이게함.
            ' Visible은 없고 Manimum Size를 0 이나 Auto로 설정함. 
            If tmpLegend.CellColumns(CInt(mnuPopupMin.Tag)).MaximumWidth = 0 Then
                mnuPopupMin.Checked = False
            Else
                mnuPopupMin.Checked = True
            End If

            If tmpLegend.CellColumns(CInt(mnuPopupMax.Tag)).MaximumWidth = 0 Then
                mnuPopupMax.Checked = False
            Else
                mnuPopupMax.Checked = True
            End If

            If tmpLegend.CellColumns(CInt(mnuPopupMEAN.Tag)).MaximumWidth = 0 Then
                mnuPopupMEAN.Checked = False
            Else
                mnuPopupMEAN.Checked = True
            End If

            If tmpLegend.CellColumns(CInt(mnuPopupVAL.Tag)).MaximumWidth = 0 Then
                mnuPopupVAL.Checked = False
            Else
                mnuPopupVAL.Checked = True
            End If
            ' Cell 항목 End 

        End If
    End Sub
    ''' <summary>
    ''' 맞춤 클릭시
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuPopupAlign_Click(sender As Object, e As EventArgs) Handles mnuPopupAlignTop.Click _
                                                                                    , mnuPopupAlignLeft.Click _
                                                                                    , mnuPopupAlignRght.Click _
                                                                                    , mnuPopupAlignBottom.Click
        If DirectCast(sender, ToolStripMenuItem).Checked = True Then
            For Each tmpItm As ToolStripMenuItem In Me.mnuPopupAligns.DropDownItems
                If Not tmpItm.Equals(sender) AndAlso tmpItm.Checked = True Then
                    tmpItm.Checked = False
                End If
            Next
            ' 각각의 4개 메뉴 태그에 숫자를 지정하여 놓았음 Top = 0 Right = 1 Bottom = 2 Left = 3 Docking과 동일함. 
            Dim strArea As String = mnuPopUpLegend.Tag

            fn_FindLegendByAreaNm(strArea).Docking = DirectCast(sender, ToolStripMenuItem).Tag


        End If
    End Sub

    ''' <summary>
    ''' 명명된 Chart Area가 사용되는 범례를 가져온다. 한개의 차트에 한개의 범레를 표시할 경우 사용된다. 
    ''' </summary>
    ''' <param name="AreaName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fn_FindLegendByAreaNm(ByVal AreaName As String) As System.Windows.Forms.DataVisualization.Charting.Legend
        For Each tmpLegend As System.Windows.Forms.DataVisualization.Charting.Legend In Me.MainChart.Legends
            If tmpLegend.DockedToChartArea = AreaName Then
                Return tmpLegend
            End If
        Next

        Return Nothing
    End Function



    Private Sub mnuPopupHidden_Click(sender As Object, e As EventArgs) Handles mnuPopupHidden.Click
        Dim strArea As String = mnuPopUpLegend.Tag

        fn_FindLegendByAreaNm(strArea).Enabled = IIf(DirectCast(sender, ToolStripMenuItem).Checked, False, True)


    End Sub

    Private Sub mnuPopupValue_Click(sender As Object, e As EventArgs) Handles mnuPopupMin.Click _
                                                                            , mnuPopupMax.Click _
                                                                            , mnuPopupMEAN.Click _
                                                                            , mnuPopupVAL.Click

        Dim strMaxWidthValue As Integer
        Dim tsitm As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        ' -1(Auto)로 설정하면 값이 자동으로 조절되고 0 으로 설정하면 값이 보이지 않음 Visivl Property 가 없음 
        If tsitm.Checked = True Then
            strMaxWidthValue = -1
        Else
            strMaxWidthValue = 0
        End If
        ' 범례에서 선택된 Chart Area의 명칭으로 사용되고 있는 범례를 선택한다. 
        Dim tmpLegend As System.Windows.Forms.DataVisualization.Charting.Legend = fn_FindLegendByAreaNm(mnuPopUpLegend.Tag)

        tmpLegend.CellColumns(CInt(tsitm.Tag)).MaximumWidth = strMaxWidthValue




    End Sub

    ''' <summary>
    ''' 보이기 숨기기 
    ''' </summary>
    ''' <param name="Bool"></param>
    ''' <param name="ChartAreaNm"></param>
    ''' <remarks></remarks>
    Public Sub ShowLegend(ByVal Bool As Boolean, Optional ByVal ChartAreaNm As String = "DEFAREA")
        If ChartAreaNm.Trim <> "" Then
            fn_FindLegendByAreaNm(ChartAreaNm).Enabled = Bool
        End If
    End Sub

    ''' <summary>
    ''' 범계 Docking 위치 
    ''' </summary>
    ''' <param name="ChartAreaNm"></param>
    ''' <remarks></remarks>
    Public Sub DockLegend(ByVal Dock As System.Windows.Forms.DataVisualization.Charting.Docking, Optional ByVal ChartAreaNm As String = "DEFAREA")
        If ChartAreaNm.Trim <> "" Then
            fn_FindLegendByAreaNm(ChartAreaNm).Docking = Dock
        End If
    End Sub
    Public Enum CellValues
        Color = 0
        Title = 1
        Min = 2
        Max = 3
        Mean = 4
        Value = 5
    End Enum
    ''' <summary>
    ''' 단일 차트용 범례 항목  보이기 숨기기 
    ''' </summary>
    ''' <param name="Items"></param>
    ''' <remarks></remarks>
    Public Sub ShowLegendCells(ByVal Show As Boolean, ParamArray Items() As CellValues)
        For Each itm As CellValues In Items
            MainChart.Legends("DEFLEGEND").CellColumns(CInt(itm)).MaximumWidth = IIf(Show, -1, 0)


        Next
    End Sub
    ''' <summary>
    ''' 멀티 차트용 레전드 항목 보이기 숨기기
    ''' </summary>
    ''' <param name="ChartAreaNm"></param>
    ''' <param name="Items"></param>
    ''' <remarks></remarks>
    Public Sub ShowLegendCells(ByVal ChartAreaNm As String, ByVal Show As Boolean, ByVal ParamArray Items() As CellValues)

        For Each itm As CellValues In Items
            MainChart.Legends(ChartAreaNm).CellColumns(CInt(itm)).MaximumWidth = IIf(Show, -1, 0)


        Next
    End Sub


    Private _DataSource As DataTable = Nothing
    Property DataSource As DataTable
        Get
            Return _DataSource
        End Get
        Set(value As DataTable)
            If value IsNot Nothing AndAlso Not _DataSource.Equals(value) Then
                _DataSource = value
            End If
        End Set
    End Property

    Public Sub DataBindXY(ByVal SeriesName As String, ByVal XValue As Collections.IEnumerable, ByVal XField As String, ByVal YValue As Collections.IEnumerable, ByVal YField As String)
        MainChart.Series(SeriesName).Points.DataBindXY(XValue, XField, YValue, YField)
    End Sub


    Public Function GetSeries(ByVal SeriesNm As String) As Boolean
        If MainChart.Series.IndexOf(SeriesNm.ToUpper) < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Clear()
        For Each tmpSeries As DataVisualization.Charting.Series In Me.MainChart.Series
            tmpSeries.Points.Clear()
        Next

    End Sub


    Public Sub SetAxisY2(ByVal LineColor As Color)
        Me.MainChart.ChartAreas(0).AxisY2.LineColor = LineColor
        Me.MainChart.ChartAreas(0).AxisY2.LabelStyle.ForeColor = LineColor
    End Sub
    Public Sub SetAxisY2ChartArea(ByVal LineColor As Color, ByVal index As Integer)
        Me.MainChart.ChartAreas(index).AxisY2.LineColor = LineColor
        Me.MainChart.ChartAreas(index).AxisY2.LabelStyle.ForeColor = LineColor
    End Sub


    Private _YSpacing As Integer = 5
    <System.ComponentModel.DefaultValue(5)> _
    Property YSpacing As Integer
        Get
            Return _YSpacing
        End Get
        Set(value As Integer)
            If Not _YSpacing.Equals(value) Then
                _YSpacing = value
                AutoGridYSpacing()
            End If

        End Set
    End Property

    Public Sub AutoGridYSpacing()

        Dim maxPri As Double = Me.MainChart.ChartAreas(0).AxisY.Maximum
        If maxPri > 0 Then

            Dim intPri As Integer = maxPri \ 5
            intPri += 1
            Me.MainChart.ChartAreas(0).AxisY.Maximum = intPri * 5
            Me.MainChart.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            Me.MainChart.ChartAreas(0).AxisY.Interval = Me.MainChart.ChartAreas(0).AxisY.Maximum / 5
        End If
        Dim maxSec As Double = Me.MainChart.ChartAreas(0).AxisY2.Maximum
        If maxSec > 0 Then
            Dim intSec As Integer = maxSec \ 5
            intSec += 1
            Me.MainChart.ChartAreas(0).AxisY2.Maximum = intSec * 5
            Me.MainChart.ChartAreas(0).AxisY2.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            Me.MainChart.ChartAreas(0).AxisY2.Interval = Me.MainChart.ChartAreas(0).AxisY2.Maximum / 5
        End If
    End Sub

    Public Sub SetMaximumAxisY(ByVal Value As Integer)
        Me.MainChart.ChartAreas(0).AxisY.Maximum = Value
    End Sub
    Public Sub SetMaximumAxisY2(ByVal Value As Integer)
        Me.MainChart.ChartAreas(0).AxisY2.Maximum = Value
    End Sub
    Public Sub SetMinimumAxisX(ByVal xValue As Double)
        Me.MainChart.ChartAreas(0).AxisX.Minimum = xValue
    End Sub
    Public Sub SetMaximumAxisX(ByVal xValue As Double)
        Me.MainChart.ChartAreas(0).AxisX.Maximum = xValue
    End Sub

    Public Sub SetMaximumAxisYChartArea(ByVal Value As Integer, ByVal strAreaName As String)
        Me.MainChart.ChartAreas(strAreaName).AxisY.Maximum = Value
    End Sub
    Public Sub SetMaximumAxisY2ChartArea(ByVal Value As Integer, ByVal strAreaName As String)
        Me.MainChart.ChartAreas(strAreaName).AxisY2.Maximum = Value
    End Sub
    Public Sub SetMinimumAxisXChartArea(ByVal xValue As Double, ByVal AreaIndex As Integer)
        Me.MainChart.ChartAreas(AreaIndex).AxisX.Minimum = xValue
    End Sub
    Public Sub SetMaximumAxisXChartArea(ByVal xValue As Double, ByVal AreaIndex As Integer)
        Me.MainChart.ChartAreas(AreaIndex).AxisX.Maximum = xValue
    End Sub


    Public Function GetMinimumAxisX() As Double
        Return Me.MainChart.ChartAreas(0).AxisX.Minimum
    End Function
    Public Function GetMaximumAxisX()
        Return Me.MainChart.ChartAreas(0).AxisX.Maximum
    End Function

    Public Function GetMinimumAxisXChartArea(ByVal AreaIndex As Integer) As Double
        Return Me.MainChart.ChartAreas(AreaIndex).AxisX.Minimum
    End Function
    Public Function GetMaximumAxisXChartArea(ByVal AreaIndex As Integer)
        Return Me.MainChart.ChartAreas(AreaIndex).AxisX.Maximum
    End Function
    Sub SetInnerPlotPosition()
        Dim ChartBorderLeft As Integer = 100 'Pixels on the left
        Dim ChartBorderRight As Integer = 100 'Pixels on the right
        Dim ChartBorderTop As Integer = 0 'Pixels on the top
        Dim ChartBorderBottom As Integer = 40 'Pixels on the bottom

        Me.MainChart.ChartAreas(0).InnerPlotPosition.X = CSng(ChartBorderLeft / Me.MainChart.Width) * 100 'Left border
        Me.MainChart.ChartAreas(0).InnerPlotPosition.Y = CSng(ChartBorderTop / Me.MainChart.Height) * 100 'Top Border
        Me.MainChart.ChartAreas(0).InnerPlotPosition.Width = CSng((Me.MainChart.Width - ChartBorderLeft - ChartBorderRight) / Me.MainChart.Width) * 100
        Me.MainChart.ChartAreas(0).InnerPlotPosition.Height = CSng((Me.MainChart.Height - ChartBorderTop - ChartBorderBottom) / Me.MainChart.Height) * 100

    End Sub
    Sub SetInnerPlotPositionChartArea(ByVal AreaIndex As Integer, ByVal intCount As Integer)
        Dim ChartBorderLeft As Integer = 100 'Pixels on the left
        Dim ChartBorderRight As Integer = 100 'Pixels on the right
        Dim ChartBorderTop As Integer = 100 * intCount 'Pixels on the top
        Dim ChartBorderBottom As Integer = 120 * intCount 'Pixels on the bottom

        'Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.X = CSng(ChartBorderLeft / Me.MainChart.Width) * 100  'Left border 
        'Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Y = CSng(ChartBorderTop / Me.MainChart.Height) * 100  'Top Border
        'Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Width = CSng((Me.MainChart.Width - ChartBorderLeft - ChartBorderRight) / Me.MainChart.Width) * 100
        'Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Height = CSng((Me.MainChart.Height - ChartBorderTop - ChartBorderBottom) / Me.MainChart.Height) * 100

        Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.X = CSng(ChartBorderLeft / Me.MainChart.Width) * 100  'Left border 
        Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Y = 10  'Top Border
        Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Width = CSng((Me.MainChart.Width - ChartBorderLeft - ChartBorderRight) / Me.MainChart.Width) * 100
        Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Height = 80

        Me.MainChart.ChartAreas(AreaIndex).Position.X = CSng(0 / Me.MainChart.Width) * 100  'Left border 
        Me.MainChart.ChartAreas(AreaIndex).Position.Y = CSng(0 / Me.MainChart.Height) * 100  'Top Border
        Me.MainChart.ChartAreas(AreaIndex).Position.Width = CSng((Me.MainChart.Width - 0 - 0) / Me.MainChart.Width) * 100
        Me.MainChart.ChartAreas(AreaIndex).Position.Height = CSng((Me.MainChart.Height - 0 - 0) / Me.MainChart.Height) * 100

    End Sub

    Sub SetInnerPlotXPositionChartArea(ByVal AreaIndex As Integer, ByVal intCount As Integer)
        Dim ChartBorderLeft As Integer = 100 'Pixels on the left
        Dim ChartBorderRight As Integer = 100 'Pixels on the right

        Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.X = CSng(ChartBorderLeft / Me.MainChart.Width) * 100  'Left border 
        Me.MainChart.ChartAreas(AreaIndex).InnerPlotPosition.Width = CSng((Me.MainChart.Width - ChartBorderLeft - ChartBorderRight) / Me.MainChart.Width) * 100

        Me.MainChart.ChartAreas(AreaIndex).Position.X = CSng(0 / Me.MainChart.Width) * 100  'Left border 
        Me.MainChart.ChartAreas(AreaIndex).Position.Width = CSng((Me.MainChart.Width - 0 - 0) / Me.MainChart.Width) * 100
    End Sub


    Private Sub MainChart_CursorPositionChanged(sender As Object, e As CursorEventArgs) Handles MainChart.CursorPositionChanged
        If Double.IsNaN(e.NewPosition) Then Return
        Dim stDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionStart)
        Dim edDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionEnd)
        If stDt > edDt Then
            Dim tmpDt As DateTime
            tmpDt = stDt
            stDt = edDt
            edDt = tmpDt
        End If

        If DateDiff(DateInterval.Minute, stDt, edDt) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return
        Else
            If DateDiff(DateInterval.Minute, stDt, edDt) > 120 Then
                MsgBox(p_clsMsgData.fn_GetData("M015"))
                Return
            End If
        End If

        Dim ctlChartEx As DataVisualization.Charting.Chart = DirectCast(sender, DataVisualization.Charting.Chart)
        ctlChartEx.ChartAreas(2).CursorX.SetSelectionPosition(e.ChartArea.CursorX.SelectionStart, e.ChartArea.CursorX.SelectionEnd)
        ctlChartEx.ChartAreas(2).CursorX.SetCursorPosition(e.ChartArea.CursorX.SelectionStart)
        'ctlChartEx.ChartAreas(1).CursorX.SetSelectionPosition(-1, -1)
        'ctlChartEx.ChartAreas(1).CursorX.SetCursorPosition(-1)
    End Sub
End Class
