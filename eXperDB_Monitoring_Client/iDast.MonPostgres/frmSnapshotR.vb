Public Class frmSnapshotR

    Private _clsQuery As clsQuerys
    Private _collapseHeight As Integer
    Private _GrpLst As List(Of GroupInfo)
    Private WithEvents _ProgresForm As frmProgres

    Private _instanceID As Integer
    Private _snapshotFrom As String
    Private _snapshotTo As String
    Private _snapshotComFrom As String
    Private _snapshotComTo As String
    Private _baseline As String
    Private _baselineCom As String
    Private _reportMode As Integer
    Private _Result As Boolean
    Private _dtTable As DataTable

    Public Sub New(ByRef odbcConn As eXperDBODBC, ByVal GrpLst As List(Of GroupInfo))

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
        _clsQuery = New clsQuerys(odbcConn)
        _GrpLst = GrpLst

        For Each tmpGrp As GroupInfo In GrpLst
            For Each tmpSvr As GroupInfo.ServerInfo In tmpGrp.Items
                cmbClusters.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
            Next
        Next

        Me.ttChart.SetToolTip(Me.btnConfig, p_clsMsgData.fn_GetData("M102"))
        Me.ttChart.SetToolTip(Me.btnFrom, p_clsMsgData.fn_GetData("F963"))
        Me.ttChart.SetToolTip(Me.btnTo, p_clsMsgData.fn_GetData("F963"))
        Me.ttChart.SetToolTip(Me.btnComFrom, p_clsMsgData.fn_GetData("F963"))
        Me.ttChart.SetToolTip(Me.btnComTo, p_clsMsgData.fn_GetData("F963"))
    End Sub


    'Private Sub initForm()
    '    btnSave.Text = p_clsMsgData.fn_GetData("F014")
    '    btnUserSave.Text = p_clsMsgData.fn_GetData("F014")
    '    StatusLabel.Text = p_clsMsgData.fn_GetData("M047")

    '    lblUserID.Text = p_clsMsgData.fn_GetData("F347")
    '    lblUserName.Text = p_clsMsgData.fn_GetData("F348")
    '    lblPhone.Text = p_clsMsgData.fn_GetData("F349")
    '    lblPhone2.Text = p_clsMsgData.fn_GetData("F349") + "2"
    '    rbUseNoti1.Text = p_clsMsgData.fn_GetData("F922")
    '    rbUseNoti2.Text = p_clsMsgData.fn_GetData("F922")
    '    rbUseNoti1.Checked = True
    '    lblEmail.Text = p_clsMsgData.fn_GetData("F350")
    '    lblDept.Text = p_clsMsgData.fn_GetData("F915")
    '    btnPassword.Text = p_clsMsgData.fn_GetData("F279")


    '    ' 일반설정 탭 
    '    'FormMovePanel1.Text = p_clsMsgData.fn_GetData("F022")
    '    Me.Text = p_clsMsgData.fn_GetData("F022")
    '    tp1.Text = p_clsMsgData.fn_GetData("F024")
    '    lblLang.Text = p_clsMsgData.fn_GetData("F023")

    '    Dim clsIni As New Common.IniFile(p_AppConfigIni)
    '    Dim AppLang As clsEnums.AppLanguage = clsIni.ReadValue("General", "Language", clsEnums.AppLanguage.Korean)
    '    Dim strFileLocaton As String = TryCast(AppLang.GetType().GetMember(AppLang.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description

    '    lblCollect.Text = p_clsMsgData.fn_GetData("F190")
    '    lbGrpRatate.Text = p_clsMsgData.fn_GetData("F243")
    '    Dim tmpVal As Integer = clsIni.ReadValue("General", "ELAPSE", 3000)
    '    If tmpVal / 1000 < Me.nudCollect.Minimum Then
    '        nudCollect.Value = nudCollect.Minimum
    '    Else
    '        nudCollect.Value = tmpVal / 1000
    '    End If

    '    tmpVal = clsIni.ReadValue("General", "GRPROTATE", 120000)
    '    If tmpVal / 1000 < Me.nudGrpRotate.Minimum Then
    '        nudGrpRotate.Value = nudGrpRotate.Minimum
    '    Else
    '        nudGrpRotate.Value = tmpVal / 1000
    '    End If


    '    Dim strPath As String = System.IO.Path.GetDirectoryName(strFileLocaton)
    '    For Each LangFile As String In System.IO.Directory.GetFiles(strPath, "*.xml")
    '        cmbLang.Items.Add(System.IO.Path.GetFileNameWithoutExtension(LangFile))
    '    Next
    '    cmbLang.Tag = strPath
    '    cmbLang.Text = System.Enum.GetName(GetType(clsEnums.AppLanguage), AppLang)


    '    lblHealthCheck.Text = p_clsMsgData.fn_GetData("F189")
    '    chkNor.Text = p_clsMsgData.fn_GetData("F029")
    '    chkWar.Text = p_clsMsgData.fn_GetData("F030")
    '    chkCri.Text = p_clsMsgData.fn_GetData("F031")

    '    chkNor.Checked = clsIni.ReadValue("General", "NORMAL_SHOW", True)
    '    chkWar.Checked = clsIni.ReadValue("General", "WARNING_SHOW", True)
    '    chkCri.Checked = clsIni.ReadValue("General", "CRITICAL_SHOW", True)


    '    txtSound.Text = clsIni.ReadValue("General", "SIREN", "Siren.wav")

    '    lblShowNm.Text = p_clsMsgData.fn_GetData("F228")
    '    rbHostnm.Text = p_clsMsgData.fn_GetData("F229")
    '    rbAlias.Text = p_clsMsgData.fn_GetData("F230")

    '    If clsIni.ReadValue("General", "SVRNAME", 0) = 0 Then
    '        rbHostnm.Checked = True
    '    Else
    '        rbAlias.Checked = True
    '    End If

    '    lblSQLPlan.Text = p_clsMsgData.fn_GetData("F329")
    '    chkUseDefaultAccount.Text = p_clsMsgData.fn_GetData("F330")

    '    ' 스타일 탭
    '    tp2.Text = p_clsMsgData.fn_GetData("F038")
    '    lblRaider.Text = p_clsMsgData.fn_GetData("F037")
    '    lblCpuStyle.Text = p_clsMsgData.fn_GetData("F035")
    '    lblMemStyle.Text = p_clsMsgData.fn_GetData("F036")
    '    chkCpuItemReverse.Text = p_clsMsgData.fn_GetData("F039")
    '    chkMemItemReverse.Text = p_clsMsgData.fn_GetData("F039")

    '    cmbCpuStyle.SetValues(New BaseControls.ValueDescription(GetType(Controls.Raider.RaiderStyle)))
    '    cmbMemStyle.SetValues(New BaseControls.ValueDescription(GetType(Controls.Raider.RaiderStyle)))

    '    cmbCpuStyle.SelectedValue = clsIni.ReadValue("STYLE", "CPU", 2)
    '    cmbMemStyle.SelectedValue = clsIni.ReadValue("STYLE", "MEM", 2)

    '    chkCpuItemReverse.Checked = clsIni.ReadValue("STYLE", "CPUREVERSE", False)
    '    chkMemItemReverse.Checked = clsIni.ReadValue("STYLE", "MEMREVERSE", False)

    '    chkUseDefaultAccount.Checked = clsIni.ReadValue("General", "USEDEFAULTACCOUNT", False)

    '    'Dim clsFonts As New System.Drawing.Text.InstalledFontCollection()
    '    'For Each tmpFont As FontFamily In clsFonts.Families
    '    '    cmbFont.Items.Add(tmpFont.Name)
    '    'Next


    '    'cmbFont.Text = p_Font

    '    'tp1.BackColor = System.Drawing.Color.Gray
    '    'tp2.BackColor = System.Drawing.Color.DimGray
    '    ' SQL TAB 

    '    btnQueryInit.Text = p_clsMsgData.fn_GetData("F226")

    '    'tpSQL.Text = p_clsMsgData.fn_GetData("F208")
    '    lblRegex.Text = p_clsMsgData.fn_GetData("F209")
    '    'lblBackColor.Text = p_clsMsgData.fn_GetData("F210")
    '    'lblComments.Text = p_clsMsgData.fn_GetData("F211")
    '    'lblFunctions.Text = p_clsMsgData.fn_GetData("F212")
    '    'lblKeywords.Text = p_clsMsgData.fn_GetData("F213")
    '    'lblNumbers.Text = p_clsMsgData.fn_GetData("F214")
    '    'lblStatements.Text = p_clsMsgData.fn_GetData("F215")
    '    'lblTypes.Text = p_clsMsgData.fn_GetData("F216")
    '    'lblVariables.Text = p_clsMsgData.fn_GetData("F217")
    '    'lblStrings.Text = p_clsMsgData.fn_GetData("F218")
    '    'lblNormal.Text = p_clsMsgData.fn_GetData("F220")


    '    txtRegex.Text = clsIni.ReadValue("SQL", "PATTERN", "\$[a-zA-Z_\d]*\b")
    '    'cmbBackColor.Text = clsIni.ReadValue("SQL", "BACKCOLOR", "BLACK")
    '    'cmbComments.Text = clsIni.ReadValue("SQL", "COMMENTS", "GREEN")
    '    'cmbFunctions.Text = clsIni.ReadValue("SQL", "FUNCTIONS", "MAROON")
    '    'cmbKeywords.Text = clsIni.ReadValue("SQL", "KEYWORDS", "BLUE")
    '    'cmbNumbers.Text = clsIni.ReadValue("SQL", "NUMBERS", "MAGENTA")
    '    'cmbStatements.Text = clsIni.ReadValue("SQL", "STATEMENTS", "BLUE")
    '    'cmbTypes.Text = clsIni.ReadValue("SQL", "TYPES", "BROWN")
    '    'cmbVariables.Text = clsIni.ReadValue("SQL", "VARIABLES", "MAROON")
    '    'cmbStrings.Text = clsIni.ReadValue("SQL", "STRINGS", "RED")
    '    'cmbNormal.Text = clsIni.ReadValue("SQL", "NORMAL", "GRAY")


    '    'Me.RichTextBoxQuery1.BackColor = System.Drawing.Color.FromName(cmbBackColor.Text)
    '    'Me.RichTextBoxQuery1.Comments = System.Drawing.Color.FromName(cmbComments.Text)
    '    'Me.RichTextBoxQuery1.Functions = System.Drawing.Color.FromName(cmbFunctions.Text)
    '    'Me.RichTextBoxQuery1.KeyWords = System.Drawing.Color.FromName(cmbKeywords.Text)
    '    'Me.RichTextBoxQuery1.Numbers = System.Drawing.Color.FromName(cmbNumbers.Text)
    '    'Me.RichTextBoxQuery1.StateMents = System.Drawing.Color.FromName(cmbStatements.Text)
    '    'Me.RichTextBoxQuery1.Types = System.Drawing.Color.FromName(cmbTypes.Text)
    '    'Me.RichTextBoxQuery1.Variables = System.Drawing.Color.FromName(cmbVariables.Text)
    '    'Me.RichTextBoxQuery1.Strings = System.Drawing.Color.FromName(cmbStrings.Text)
    '    'Me.RichTextBoxQuery1.ForeColor = System.Drawing.Color.FromName(cmbNormal.Text)





    '    'modCommon.FontChange(Me, p_Font)



    'End Sub


    Private Sub initForm()
        btnGenerate.Text = p_clsMsgData.fn_GetData("F956", "Report")
        StatusLabel.Text = p_clsMsgData.fn_GetData("M096")

        radReportType1.Checked = True
        radComReportType1.Checked = True
    End Sub

    Private Sub frmSnapshotR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        tlpSnapshot2.Visible = False
        _collapseHeight = tlpSnapshot2.Height
        tlpSnapShot.Height = tlpSnapShot.Height - _collapseHeight
        Me.Height = Me.Height - _collapseHeight
    End Sub

#Region "Internal functions"

    Private Sub ReportLog(ByVal intAccessType As Integer, ByVal intStatus As Integer, _
                      Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.InsertReportInfo(p_cSession.UserID, intAccessType, intStatus, strLog, strLocIP, intInstanceID)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub chkCompare_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompare.CheckedChanged
        If chkCompare.Checked = True Then
            tlpSnapshot2.Visible = True
            tlpSnapShot.Height = tlpSnapShot.Height + _collapseHeight
            Me.Height = Me.Height + _collapseHeight
        Else
            tlpSnapshot2.Visible = False
            tlpSnapShot.Height = tlpSnapShot.Height - _collapseHeight
            Me.Height = Me.Height - _collapseHeight
        End If
    End Sub

    Private Sub radReportType_CheckedChanged(sender As Object, e As EventArgs) Handles radReportType1.CheckedChanged, radReportType2.CheckedChanged
        If radReportType1.Checked = True Then
            lblReportTo.Visible = true
            txtSnapTo.Visible = True
            btnTo.Visible = True
            lblReportFrom.Text = "From"
        Else
            lblReportTo.Visible = False
            txtSnapTo.Visible = False
            btnTo.Visible = False
            lblReportFrom.Text = "Baseline"
        End If
        txtSnapFrom.Text = ""
        txtSnapFrom.Tag = ""
    End Sub

    Private Sub radComReportType_CheckedChanged(sender As Object, e As EventArgs) Handles radComReportType1.CheckedChanged, radComReportType2.CheckedChanged
        If radComReportType1.Checked = True Then
            lblComReportTo.Visible = True
            txtComSnapTo.Visible = True
            btnComTo.Visible = True
            lblComReportFrom.Text = "From"
        Else
            lblComReportTo.Visible = False
            txtComSnapTo.Visible = False
            btnComTo.Visible = False
            lblComReportFrom.Text = "Baseline"
        End If
        txtComSnapFrom.Text = ""
        txtComSnapFrom.Tag = ""
    End Sub

    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles btnFrom.Click, btnTo.Click, btnComFrom.Click, btnComTo.Click
        Dim btnTemp = DirectCast(sender, System.Windows.Forms.Button)
        Dim snapIndex As Integer
        Dim isSnapshot As Boolean
        Select Case btnTemp.Name
            Case "btnFrom"
                snapIndex = 0
                isSnapshot = radReportType1.Checked
            Case "btnTo"
                snapIndex = 1
                isSnapshot = radReportType1.Checked
            Case "btnComFrom"
                snapIndex = 2
                isSnapshot = radComReportType1.Checked
            Case "btnComTo"
                snapIndex = 3
                isSnapshot = radComReportType1.Checked
        End Select

        Dim intInstance As Integer = cmbClusters.SelectedValue
        Dim frmSnapList As New frmSnapshotList(_clsQuery, intInstance, isSnapshot)
        frmSnapList.Location = MousePosition()
        If frmSnapList.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim snapshot As Integer = 0
            Dim snapshottime As String = ""
            Dim baselinename As String = ""
            Dim minsnapshot As Integer = 0
            Dim mintime As String = ""
            Dim maxsnapshot As Integer = 0
            Dim maxtime As String = ""
            frmSnapList.rtnValue(snapshot, snapshottime, baselinename, minsnapshot, mintime, maxsnapshot, maxtime)
            Select Case btnTemp.Name
                Case "btnFrom"
                    If isSnapshot Then
                        txtSnapFrom.Text = snapshottime
                        txtSnapFrom.Tag = snapshot
                    Else
                        txtSnapFrom.Text = baselinename
                        txtSnapFrom.Tag = baselinename
                    End If
                Case "btnTo"
                    txtSnapTo.Text = snapshottime
                    txtSnapTo.Tag = snapshot
                Case "btnComFrom"
                    If isSnapshot Then
                        txtComSnapFrom.Text = snapshottime
                        txtComSnapFrom.Tag = snapshot
                    Else
                        txtComSnapFrom.Text = baselinename
                        txtComSnapFrom.Tag = baselinename
                    End If
                Case "btnComTo"
                    txtComSnapTo.Text = snapshottime
                    txtComSnapTo.Tag = snapshot
            End Select
        End If
    End Sub


    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim frmSnapshot As New frmSnapshot(_clsQuery, _GrpLst, cmbClusters.SelectedValue)
        frmSnapshot.ShowDialog()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim frmReportHistory As New frmReportHistory(_clsQuery, _GrpLst, cmbClusters.SelectedValue)
        frmReportHistory.ShowDialog()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        makeProgress()
    End Sub


    Private Sub makeProgress()
        Threading.Thread.Sleep(10)
        If _ProgresForm Is Nothing Then
            _ProgresForm = New frmProgres()
            _ProgresForm.Owner = Me
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
        _ProgresForm.Show()
        Me.BringToFront()
        Me.Activate()

        '''''''''''''''''''''''''''''''''''''''''''
        'set global variable for background worker'
        '''''''''''''''''''''''''''''''''''''''''''
        _instanceID = cmbClusters.SelectedValue

        'Single
        _snapshotFrom = txtSnapFrom.Tag
        _snapshotTo = txtSnapTo.Tag
        _baseline = txtSnapFrom.Tag

        If _snapshotFrom > _snapshotTo Then
            Dim swap = _snapshotFrom
            _snapshotFrom = _snapshotTo
            _snapshotTo = swap
        End If

        'Compare
        _snapshotComFrom = txtComSnapFrom.Tag
        _snapshotComTo = txtComSnapTo.Tag
        _baselineCom = txtComSnapFrom.Tag

        If _snapshotComFrom > _snapshotComTo Then
            Dim swap = _snapshotComFrom
            _snapshotComFrom = _snapshotComTo
            _snapshotComTo = swap
        End If

        If chkCompare.Checked Then
            If radReportType1.Checked = True And radComReportType1.Checked = True Then
                _reportMode = 3
            ElseIf radReportType1.Checked = True And radComReportType1.Checked = False Then
                _reportMode = 4
            ElseIf radReportType1.Checked = False And radComReportType1.Checked = True Then
                _reportMode = 5
            ElseIf radReportType1.Checked = False And radComReportType1.Checked = False Then
                _reportMode = 6
            End If
        Else
            If radReportType1.Checked = True Then
                _reportMode = 1
            Else
                _reportMode = 2
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''
        If bgmanual.IsBusy = True Then
            bgmanual.CancelAsync()
            Return
        End If
        bgmanual.RunWorkerAsync()
    End Sub

    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        bgmanual.ReportProgress(0)
        GenerateReport()
        bgmanual.ReportProgress(100)
    End Sub

    Private Sub bgmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgmanual.ProgressChanged
        Select Case e.ProgressPercentage
            Case 100
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("Complete")
                End If
        End Select
    End Sub

    Private Sub bgmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgmanual.RunWorkerCompleted
        If _dtTable Is Nothing Then
            MsgBox(p_clsMsgData.fn_GetData("M104"))
            If _ProgresForm IsNot Nothing Then
                _ProgresForm.Close()
            End If
            Return
        End If
        _ProgresForm.Close()

        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.html"
        Select Case _reportMode
            Case 1
                fsd.FileName = cmbClusters.SelectedItem(0) + "_" + txtSnapFrom.Text + "_" + txtSnapTo.Text
            Case 2
                fsd.FileName = cmbClusters.SelectedItem(0) + "_" + txtSnapFrom.Text
            Case 3
                fsd.FileName = cmbClusters.SelectedItem(0) + "_" + txtSnapFrom.Text + "_" + txtSnapTo.Text + "_&_" + txtComSnapFrom.Text + "_" + txtComSnapTo.Text
            Case 4
                fsd.FileName = cmbClusters.SelectedItem(0) + "_" + txtSnapFrom.Text + "_" + txtSnapTo.Text + "_&_" + txtComSnapFrom.Text
            Case 5
                fsd.FileName = cmbClusters.SelectedItem(0) + "_" + txtSnapFrom.Text + "_&_" + txtComSnapFrom.Text + "_" + txtComSnapTo.Text
            Case 6
                fsd.FileName = cmbClusters.SelectedItem(0) + "_" + txtSnapFrom.Text + "_&_" + txtComSnapFrom.Text
        End Select

        Dim logStr As String = fsd.FileName
        ReportLog(0, 0, logStr, _instanceID)
        
        fsd.FileName = fsd.FileName.Replace(":", String.Empty).Replace("-", String.Empty).Replace(" ", String.Empty)
        fsd.Filter = "HTML Files|*.html"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strHtmlFile As String = fsd.FileName
            My.Computer.FileSystem.WriteAllText(fsd.FileName, _dtTable.Rows(0).Item("REPORT"), True)
            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strHtmlFile)
            End If
        End If
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        _ProgresForm = Nothing
    End Sub

    Private Sub GenerateReport()
        Try
            Select Case _reportMode
                Case 1
                    _dtTable = _clsQuery.selectSnapshotReportSingleSnap(_instanceID, _snapshotFrom, _snapshotTo)
                Case 2
                    _dtTable = _clsQuery.selectSnapshotReportSingleBL(_instanceID, _baseline)
                Case 3
                    _dtTable = _clsQuery.selectSnapshotReportCompSnapSnap(_instanceID, _snapshotFrom, _snapshotTo, _snapshotComFrom, _snapshotComTo)
                Case 4
                    _dtTable = _clsQuery.selectSnapshotReportCompSnapBL(_instanceID, _snapshotFrom, _snapshotTo, _baselineCom)
                Case 5
                    _dtTable = _clsQuery.selectSnapshotReportCompBLSnap(_instanceID, _baseline, _snapshotComFrom, _snapshotComTo)
                Case 6
                    _dtTable = _clsQuery.selectSnapshotReportCompBLBL(_instanceID, _baseline, _baselineCom)
            End Select

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub frmSnapshotR_Move(sender As Object, e As EventArgs) Handles Me.Move
        If _ProgresForm IsNot Nothing Then
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
    End Sub
End Class


