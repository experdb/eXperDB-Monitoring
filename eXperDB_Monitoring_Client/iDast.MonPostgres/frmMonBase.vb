Public Class frmMonBase

#Region "Warning"
    ''' <summary>
    ''' 경고 메시지 공통 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub sb_CriticalShow(ByVal svrLst As SortedList)
        Dim arrFrms As New ArrayList
        Dim hstWarning As New Hashtable
        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmCritical) IsNot Nothing AndAlso hstWarning.Item(DirectCast(tmpFrm, frmCritical).Tag.ToString) Is Nothing Then
                hstWarning.Add(DirectCast(tmpFrm, frmCritical).Tag.ToString, DirectCast(tmpFrm, frmCritical).Tag.ToString)
            End If
        Next

        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmMonBase) IsNot Nothing Then
                If hstWarning.Item(tmpFrm.Handle.ToString) Is Nothing Then
                    Dim strSvrLst As String = ""
                    If tmpFrm.GetType.Equals(GetType(frmMonMain)) Then
                        For Each tmpStr As String In svrLst.Values
                            If strSvrLst = "" Then
                                strSvrLst = tmpStr
                            Else
                                strSvrLst += " , " & tmpStr
                            End If
                        Next
                    ElseIf tmpFrm.GetType.Equals(GetType(frmMonDetail)) Then
                        If svrLst.Item(DirectCast(tmpFrm, frmMonDetail).InstanceID) IsNot Nothing Then
                            strSvrLst = svrLst.Item(DirectCast(tmpFrm, frmMonDetail).InstanceID)
                        End If

                    ElseIf tmpFrm.GetType.Equals(GetType(frmMonActInfo)) Then
                        If svrLst.Item(DirectCast(tmpFrm, frmMonActInfo).InstanceID) IsNot Nothing Then
                            strSvrLst = svrLst.Item(DirectCast(tmpFrm, frmMonActInfo).InstanceID)
                        End If
                    End If
                    If strSvrLst <> "" Then
                        Dim A As New frmCritical(strSvrLst)
                        A.Location = tmpFrm.Location
                        A.StartPosition = FormStartPosition.Manual
                        A.Size = tmpFrm.Size
                        A.Tag = tmpFrm.Handle.ToString
                        arrFrms.Add(A)
                    End If
                End If

            End If
        Next

        For Each tmpFrm As frmCritical In arrFrms
            Dim sc As Screen = Screen.FromPoint(tmpFrm.Location)
            tmpFrm.Show()
        Next

    End Sub

    Public Sub sb_CriticalClose()
        Dim arrFrms As New ArrayList
        For Each tmpFrm As Form In Application.OpenForms
            If TryCast(tmpFrm, frmCritical) IsNot Nothing Then
                arrFrms.Add(tmpFrm)
            End If
        Next

        For Each tmpFrm As frmCritical In arrFrms
            tmpFrm.Close()
        Next


    End Sub

#End Region




#Region "Form Events"

    Public Event FormControlConfig(ByVal e As Rectangle)
    Public Event FormControlRotation(ByVal e As Boolean)
    Public Event FormControlPower(ByVal e As Boolean)



#End Region




    Private Sub FormControlBox1_ButtonConfigClick(sender As Object, e As Rectangle) Handles FormControlBox1.ButtonConfigClick

        RaiseEvent FormControlConfig(e)
    End Sub



    Private Sub frmMonBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Property isLock As Boolean
        Get
            Return Me.FormControlBox1.isLock
        End Get
        Set(value As Boolean)
            Me.FormControlBox1.isLock = value
            If value.Equals(True) Then
                tmLock.Enabled = False
            Else
                tmLock.Enabled = True
            End If
        End Set
    End Property



    Property ShowCritical As Boolean
        Get
            Return Me.FormControlBox1.isCritical
        End Get
        Set(value As Boolean)
            Me.FormControlBox1.isCritical = value
            If value = False Then
                sb_CriticalClose()

            End If
        End Set
    End Property




    Private Sub tmLock_Tick(sender As Object, e As EventArgs) Handles tmLock.Tick
        If Me.isLock.Equals(False) Then
            Me.isLock = True
        End If

        tmLock.Enabled = False
    End Sub

    Private Sub FormControlBox1_ButtonCriticalClick(sender As Object, e As MouseEventArgs) Handles FormControlBox1.ButtonCriticalClick
        Me.ShowCritical = Not DirectCast(sender, FormControlBox).isCritical


    End Sub

    Private Sub FormControlBox1_ButtonLockClick(sender As Object, e As MouseEventArgs) Handles FormControlBox1.ButtonLockClick
        If Me.isLock = False Then
            Me.isLock = True
        End If
    End Sub

    Private _BaseHeight As Integer = 900
    Property BaseHeight As Integer
        Get
            Return _BaseHeight
        End Get
        Set(value As Integer)
            _BaseHeight = value
        End Set

    End Property

    Private _UseResizeFont As Boolean = True
    Property UseResizeFont As Boolean
        Get
            Return _UseResizeFont
        End Get
        Set(value As Boolean)
            _UseResizeFont = value
        End Set

    End Property

    Private Sub frmMonBase_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        FontSizeChange()

    End Sub





    Private Sub frmMonBase_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Created = True AndAlso Me.IsHandleCreated AndAlso Me._UseResizeFont = True Then
            FontSizeChange()
        End If
        '  Me.ShowCritical

    End Sub


    Private Sub FontSizeChange()
        If Me.Height <> _BaseHeight Then
            Dim scfnt As Single = Me.Height / _BaseHeight
            If scfnt = 1 Then Return
            Dim srtCtlLst As New SortedList(Of String, Integer)
            GetFontSize(srtCtlLst, Me)
            Me.SuspendLayout()
            For Each tmpStr As String In srtCtlLst.Keys
                Dim tmpCtls As Control() = Me.Controls.Find(tmpStr, True)
                For Each tmpCtl As Control In tmpCtls


                    Select Case tmpCtl.GetType
                        Case GetType(BaseControls.GroupBox)
                            Dim custCtl As BaseControls.GroupBox = CType(tmpCtl, BaseControls.GroupBox)
                            custCtl.TitleFont = New Font(custCtl.TitleFont.Name, custCtl.TitleFont.Size * scfnt, custCtl.TitleFont.Style)
                        Case GetType(System.Windows.Forms.DataVisualization.Charting.Chart)
                            Dim tmpChart As DataVisualization.Charting.Chart = tmpCtl
                            For Each tmpChartArea As DataVisualization.Charting.ChartArea In tmpChart.ChartAreas
                                For Each tmpAxis As DataVisualization.Charting.Axis In tmpChartArea.Axes
                                    tmpAxis.TitleFont = New Font(tmpAxis.TitleFont.Name, tmpAxis.TitleFont.Size * scfnt, tmpAxis.TitleFont.Style)
                                    tmpAxis.LabelStyle.Font = New Font(tmpAxis.TitleFont.Name, tmpAxis.LabelStyle.Font.Size * scfnt, tmpAxis.LabelStyle.Font.Style)
                                Next

                            Next

                            For Each tmpSeries As DataVisualization.Charting.Series In tmpChart.Series
                                tmpSeries.Font = New Font(tmpSeries.Font.Name, tmpSeries.Font.Size * scfnt, tmpSeries.Font.Style)

                            Next

                            For Each tmpChartArea As DataVisualization.Charting.Legend In tmpChart.Legends
                                tmpChartArea.Font = New Font(tmpChartArea.Font.Name, tmpChartArea.Font.Size * scfnt, tmpChartArea.Font.Style)

                            Next
                    End Select

                 


                    tmpCtl.Font = New Font(tmpCtl.Font.Name, tmpCtl.Font.Size * scfnt, tmpCtl.Font.Style)


                    Select Case tmpCtl.GetType
                        Case GetType(BaseControls.DataGridView)
                            DirectCast(tmpCtl, BaseControls.DataGridView).ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing

                            DirectCast(tmpCtl, BaseControls.DataGridView).AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
                            DirectCast(tmpCtl, BaseControls.DataGridView).ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                    End Select
                Next
            Next
            Me.ResumeLayout()

            _BaseHeight = Me.Height
        End If

    End Sub


    Private Sub GetFontSize(ByRef SrtLst As SortedList(Of String, Integer), ByVal frm As Form)
        For Each tmpCtl As Control In frm.Controls
            SrtLst.Add(tmpCtl.Name, tmpCtl.Font.Height)
            If tmpCtl.Controls.Count > 0 Then
                GetFontSize(SrtLst, tmpCtl)
            End If
        Next
    End Sub

    Private Sub GetFontSize(ByRef SrtLst As SortedList(Of String, Integer), ByVal ctl As Control)
        For Each tmpCtl As Control In ctl.Controls

            If tmpCtl.Name <> "" Then
                If SrtLst.Keys.IndexOf(tmpCtl.Name) < 0 _
                    AndAlso Not tmpCtl.GetType().Equals(GetType(Windows.Forms.SplitContainer)) _
                    AndAlso Not tmpCtl.GetType().Equals(GetType(Windows.Forms.TableLayoutPanel)) Then
                    SrtLst.Add(tmpCtl.Name, tmpCtl.Font.Height)
                End If

                If tmpCtl.Controls.Count > 0 Then
                    GetFontSize(SrtLst, tmpCtl)

                End If
            End If
        Next
    End Sub



    Private Sub FormControlBox1_ButtonRotationClick(sender As Object, e As MouseEventArgs) Handles FormControlBox1.ButtonRotationClick
        FormControlBox1.isRotation = Not FormControlBox1.isRotation
        RaiseEvent FormControlRotation(FormControlBox1.isRotation)
    End Sub
    Private Sub FormControlBox1_ButtonPowerClick(sender As Object, e As MouseEventArgs) Handles FormControlBox1.ButtonPowerClick
        FormControlBox1.isPower = Not FormControlBox1.isPower
        RaiseEvent FormControlPower(FormControlBox1.isPower)
    End Sub
    Private _tooltip As ToolTip = New ToolTip()
    Private Sub FormControlBox1_MouseHover(sender As Object, e As EventArgs) Handles FormControlBox1.MouseHover
        Dim selPt As Point = FormControlBox1.PointToClient(Control.MousePosition)
        Dim ActSel As String = ""
        If FormControlBox1.ConfigBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F300")
        ElseIf FormControlBox1.MinBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F301")
        ElseIf FormControlBox1.MaxBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F302")
        ElseIf FormControlBox1.DualBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F303")
        ElseIf FormControlBox1.CloseBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F304")
        ElseIf FormControlBox1.LockBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F305")
        ElseIf FormControlBox1.CriticalBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F306")
        ElseIf FormControlBox1.RotationBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F307")
        ElseIf FormControlBox1.PowerBox.Contains(selPt) Then
            ActSel = p_clsMsgData.fn_GetData("F308")
        End If

        _tooltip.SetToolTip(FormControlBox1, ActSel)
    End Sub
End Class