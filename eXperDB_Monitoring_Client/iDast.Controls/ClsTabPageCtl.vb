Imports AdvancedDataGridView

Public Class ClsTabPageCtl
    Private COC As New ClsObjectCtl

    '==================================================
    ' Panel에 TabPage 등록
    '==================================================
    Public Function InitTabpagePutPanel(ByVal pTabPageName As String, _
                                        ByVal pPosionPanel As Panel, _
                                        ByVal pPosionX As Integer, _
                                        ByVal pPosionY As Integer) As MdiTabControl.TabControl

        Dim nTab As MdiTabControl.TabControl = New MdiTabControl.TabControl
        With nTab
            .Alignment = MdiTabControl.TabControl.TabAlignment.Top
            .Location = New System.Drawing.Point(pPosionX, pPosionY)
            .MenuRenderer = Nothing
            .Name = pTabPageName
            .SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
            .TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Medium
            .TabCloseButtonImage = Nothing
            .TabCloseButtonImageDisabled = Nothing
            .TabCloseButtonImageHot = Nothing
            .TabIndex = 1
            .TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
            .BackColor = Color.White
            .Dock = DockStyle.Fill
        End With
        pPosionPanel.Controls.Add(nTab)
        Return nTab
    End Function

    '*****************************************
    'tabpage를 webbroswer로 생성
    '*****************************************
    Public Function AddTabPageAfterWebBroswer(ByVal pTabControl As MdiTabControl.TabControl, _
                                               ByVal pTabTitle As String, _
                                               ByVal pTabCloseButtonVisible As Boolean) As WebBrowser
        Dim TabControl As MdiTabControl.TabControl
        Dim nF As Form = New frmPubWebBrowserView
        Dim outWB As WebBrowser = New WebBrowser
        nF.Text = pTabTitle
        nF.Icon = COC.PuplationIco(eXperDB.Resources.iResources.tab_app)

        For Each ctrl As Control In nF.Controls
            If TypeOf ctrl Is WebBrowser Then
                outWB = ctrl
                Exit For
            End If
        Next
        TabControl = pTabControl
        TabControl.TabCloseButtonVisible = pTabCloseButtonVisible
        TabControl.TabPages.Add(nF)
        Return outWB

    End Function

    '*****************************************
    'tabpage를 datagridview로 생성
    '*****************************************
    Public Function AddTabPageAfterDataGridView(ByVal pTabControl As MdiTabControl.TabControl, _
                                                ByVal pTabTitle As String, _
                                                ByVal pTabCloseButtonVisible As Boolean) As DataGridView
        Dim TabControl As MdiTabControl.TabControl
        Dim nF As frmPubDataGridView = New frmPubDataGridView
        Dim outWB As DataGridView = New DataGridView
        nF.Text = pTabTitle
        nF.Icon = COC.PuplationIco(eXperDB.Resources.iResources.tab_app)

        For Each ctrl As Control In nF.Controls
            If TypeOf ctrl Is DataGridView Then
                outWB = ctrl
                Exit For
            End If
        Next
        TabControl = pTabControl
        TabControl.TabCloseButtonVisible = pTabCloseButtonVisible
        TabControl.TabPages.Add(nF)
        Return outWB
    End Function

    '*****************************************
    'tabpage를 datagridTreeview로 생성
    '*****************************************
    Public Function AddTabPageAfterDataGridTreeView(ByVal pTabControl As MdiTabControl.TabControl, _
                                                ByVal pTabTitle As String, _
                                                ByVal pTabCloseButtonVisible As Boolean) As TreeGridView
        Dim TabControl As MdiTabControl.TabControl
        Dim nF As Form = New frmSQLAnalyzeTreeView
        Dim outWB As TreeGridView = New TreeGridView
        nF.Text = pTabTitle
        nF.Icon = COC.PuplationIco(eXperDB.Resources.iResources.tab_app)

        For Each ctrl As Control In nF.Controls
            If TypeOf ctrl Is TreeGridView Then
                outWB = ctrl
                Exit For
            End If
        Next
        TabControl = pTabControl
        TabControl.TabCloseButtonVisible = pTabCloseButtonVisible
        TabControl.TabPages.Add(nF)
        Return outWB
    End Function

    '*****************************************
    'tabpage를 richtextbox로 생성
    '*****************************************
    Public Function AddTabPageAfterRichTextBoxView(ByVal pTabControl As MdiTabControl.TabControl, _
                                               ByVal pTabTitle As String, _
                                               ByVal pTabCloseButtonVisible As Boolean) As RichTextBox
        Dim TabControl As MdiTabControl.TabControl
        Dim nF As Form = New frmPubRichTextBoxView
        Dim outWB As RichTextBox = New RichTextBox
        nF.Text = pTabTitle
        nF.Icon = COC.PuplationIco(eXperDB.Resources.iResources.tab_app)

        For Each ctrl As Control In nF.Controls
            If TypeOf ctrl Is RichTextBox Then
                outWB = ctrl
                Exit For
            End If
        Next

        TabControl = pTabControl
        TabControl.TabCloseButtonVisible = pTabCloseButtonVisible
        TabControl.Dock = DockStyle.Fill
        TabControl.TabPages.Add(nF)

        Return outWB
    End Function
End Class
