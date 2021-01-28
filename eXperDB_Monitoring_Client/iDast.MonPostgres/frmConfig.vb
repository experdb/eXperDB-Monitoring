Public Class frmConfig

    Private _clsQuery As clsQuerys
    Private _noticeMethod As Integer
    Public Sub New(ByRef odbcConn As eXperDBODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
        _clsQuery = New clsQuerys(odbcConn)
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
        btnSave.Text = p_clsMsgData.fn_GetData("F014")
        btnUserSave.Text = p_clsMsgData.fn_GetData("F014")
        StatusLabel.Text = p_clsMsgData.fn_GetData("M047")

        lblUserID.Text = p_clsMsgData.fn_GetData("F347")
        lblUserName.Text = p_clsMsgData.fn_GetData("F348")
        lblPhone.Text = p_clsMsgData.fn_GetData("F349")
        lblPhone2.Text = p_clsMsgData.fn_GetData("F349") + "2"
        rbUseNoti1.Text = p_clsMsgData.fn_GetData("F922")
        rbUseNoti2.Text = p_clsMsgData.fn_GetData("F922")
        rbUseNoti3.Text = p_clsMsgData.fn_GetData("F922")
        rbUseNoti1.Checked = True
        _noticeMethod = 0
        lblEmail.Text = p_clsMsgData.fn_GetData("F350")
        lblEmpNum.Text = p_clsMsgData.fn_GetData("F364")
        lblDept.Text = p_clsMsgData.fn_GetData("F915")
        btnPassword.Text = p_clsMsgData.fn_GetData("F279")
        lblSound.Text = p_clsMsgData.fn_GetData("F938")

        ' 일반설정 탭 
        'FormMovePanel1.Text = p_clsMsgData.fn_GetData("F022")
        Me.Text = p_clsMsgData.fn_GetData("F022")
        tp1.Text = p_clsMsgData.fn_GetData("F024")
        lblLang.Text = p_clsMsgData.fn_GetData("F023")
        lblCollect.Text = p_clsMsgData.fn_GetData("F190")
        lbGrpRatate.Text = p_clsMsgData.fn_GetData("F243")

        lblHealthCheck.Text = p_clsMsgData.fn_GetData("F189")
        chkNor.Text = p_clsMsgData.fn_GetData("F029")
        chkWar.Text = p_clsMsgData.fn_GetData("F030")
        chkCri.Text = p_clsMsgData.fn_GetData("F031")

        lblShowNm.Text = p_clsMsgData.fn_GetData("F228")
        rbHostnm.Text = p_clsMsgData.fn_GetData("F229")
        rbAlias.Text = p_clsMsgData.fn_GetData("F230")

        lblSQLPlan.Text = p_clsMsgData.fn_GetData("F329")
        chkUseDefaultAccount.Text = p_clsMsgData.fn_GetData("F330")

        ' 스타일 탭
        tp2.Text = p_clsMsgData.fn_GetData("F038")
        lblRaider.Text = p_clsMsgData.fn_GetData("F037")
        lblCpuStyle.Text = p_clsMsgData.fn_GetData("F035")
        lblMemStyle.Text = p_clsMsgData.fn_GetData("F036")
        chkCpuItemReverse.Text = p_clsMsgData.fn_GetData("F039")
        chkMemItemReverse.Text = p_clsMsgData.fn_GetData("F039")

        btnQueryInit.Text = p_clsMsgData.fn_GetData("F226")
        lblRegex.Text = p_clsMsgData.fn_GetData("F209")

        rbCPUHostnm.Text = p_clsMsgData.fn_GetData("F229")
        rbCPUIcon.Text = p_clsMsgData.fn_GetData("F953")
        rbMEMHostnm.Text = p_clsMsgData.fn_GetData("F229")
        rbMEMIcon.Text = p_clsMsgData.fn_GetData("F953")

    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadUserInfo()
        ReadGeneral()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'sb_SaveGeneral()
        'Sb_SaveStyle()
        'sb_SaveSQL()

        If SaveGeneral() = False Then
            return
        End If

        If cmbLang.Text.Equals("Korean") Then
            MsgBox("저장되었습니다. 변경사항을 적용하기 위해 모니터링을 재시작하여 주십시오.")
        Else
            MsgBox("Saving is complete. Please restart to apply the settings.")
        End If
        AccessLog("change_user_conf", 0, "")
    End Sub

    Private Sub sb_SaveSQL()

        Dim ConfigIni As New Common.IniFile(p_AppConfigIni)
        ConfigIni.WriteValue("SQL", "PATTERN", txtRegex.Text)
        'ConfigIni.WriteValue("SQL", "BACKCOLOR", cmbBackColor.Text)
        'ConfigIni.WriteValue("SQL", "COMMENTS", cmbComments.Text)
        'ConfigIni.WriteValue("SQL", "FUNCTIONS", cmbFunctions.Text)
        'ConfigIni.WriteValue("SQL", "KEYWORDS", cmbKeywords.Text)
        'ConfigIni.WriteValue("SQL", "NUMBERS", cmbNumbers.Text)
        'ConfigIni.WriteValue("SQL", "STATEMENTS", cmbStatements.Text)
        'ConfigIni.WriteValue("SQL", "TYPES", cmbTypes.Text)
        'ConfigIni.WriteValue("SQL", "VARIABLES", cmbVariables.Text)
        'ConfigIni.WriteValue("SQL", "STRINGS", cmbStrings.Text)
        'ConfigIni.WriteValue("SQL", "NORMAL", cmbNormal.Text)
    End Sub


    Private Sub Sb_SaveStyle()
        Dim ConfigIni As New Common.IniFile(p_AppConfigIni)
        ConfigIni.WriteValue("STYLE", "CPU", cmbCpuStyle.SelectedValue)
        ConfigIni.WriteValue("STYLE", "MEM", cmbMemStyle.SelectedValue)

        ConfigIni.WriteValue("STYLE", "CPUREVERSE", chkCpuItemReverse.Checked)
        ConfigIni.WriteValue("STYLE", "MEMREVERSE", chkCpuItemReverse.Checked)

        ConfigIni.WriteValue("STYLE", "CPUID", rbCPUIcon.Checked)
        ConfigIni.WriteValue("STYLE", "MEMID", rbMEMIcon.Checked)

    End Sub
    Private Sub sb_SaveGeneral()
        Dim ConfigIni As New Common.IniFile(p_AppConfigIni)
        Dim tmplang As clsEnums.AppLanguage = System.Enum.Parse(GetType(clsEnums.AppLanguage), cmbLang.Text)
        Dim CatNm As String = DirectCast(tmplang.GetType.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
        Dim KeyNm As String = DirectCast(tmplang.GetType.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
        ConfigIni.WriteValue(CatNm, KeyNm, tmplang)
        ConfigIni.WriteValue("General", "ELAPSE", nudCollect.Value * 1000)
        ConfigIni.WriteValue("General", "GRPROTATE", nudGrpRotate.Value * 1000)

        'ConfigIni.WriteValue("General", "CRITICAL", NumericUpDown1.Value * 60000)
        'ConfigIni.WriteValue("General", "FONT", cmbFont.Text)

        ConfigIni.WriteValue("General", "NORMAL_SHOW", IIf(chkNor.Checked, "TRUE", "FALSE"))
        ConfigIni.WriteValue("General", "WARNING_SHOW", IIf(chkWar.Checked, "TRUE", "FALSE"))
        ConfigIni.WriteValue("General", "CRITICAL_SHOW", IIf(chkCri.Checked, "TRUE", "FALSE"))
        If txtSound.Text <> "" AndAlso System.IO.File.Exists(txtSound.Text) Then
            Dim SndDir As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Sounds")

            If System.IO.Directory.Exists(SndDir) = False Then
                My.Computer.FileSystem.CreateDirectory(SndDir)
            End If

            If txtSound.Text <> System.IO.Path.Combine(SndDir, System.IO.Path.GetFileName(txtSound.Text)) Then

                My.Computer.FileSystem.CopyFile(txtSound.Text, System.IO.Path.Combine(SndDir, System.IO.Path.GetFileName(txtSound.Text)), True)
            End If

            ConfigIni.WriteValue("General", "SIREN", System.IO.Path.GetFileName(txtSound.Text))
        End If


        If rbHostnm.Checked = True Then
            ConfigIni.WriteValue("General", "SVRNAME", 0)
        Else
            ConfigIni.WriteValue("General", "SVRNAME", 1)
        End If

        ConfigIni.WriteValue("General", "USEDEFAULTACCOUNT", chkUseDefaultAccount.Checked)

    End Sub

    Private Function SaveGeneral() As Boolean

        If txtSound.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F938")))
            txtUserID.Focus()
            Return False
        End If

        Dim SndDir As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Sounds")
        If System.IO.Directory.Exists(SndDir) = False Then
            My.Computer.FileSystem.CreateDirectory(SndDir)
        End If

        If txtSound.Text <> "" AndAlso System.IO.File.Exists(txtSound.Text) Then
            If txtSound.Text <> System.IO.Path.Combine(SndDir, System.IO.Path.GetFileName(txtSound.Text)) Then
                My.Computer.FileSystem.CopyFile(txtSound.Text, System.IO.Path.Combine(SndDir, System.IO.Path.GetFileName(txtSound.Text)), True)
            End If
        End If

        Dim tmplang As clsEnums.AppLanguage = System.Enum.Parse(GetType(clsEnums.AppLanguage), cmbLang.Text)

        If _clsQuery.InsertMonUserConfig(p_cSession.UserID, tmplang, nudCollect.Value * 1000, System.IO.Path.GetFileName(txtSound.Text), _
                                       IIf(rbHostnm.Checked, 0, 1), chkUseDefaultAccount.Checked, _
                                       cmbCpuStyle.SelectedValue, chkCpuItemReverse.Checked, cmbMemStyle.SelectedValue, chkCpuItemReverse.Checked, _
                                       IIf(rbCPUHostnm.Checked, 0, 1), IIf(rbMEMHostnm.Checked, 0, 1)) = False Then
            MsgBox(p_clsMsgData.fn_GetData("M029"))
            Return False
        End If

        'Double save language
        Dim ConfigIni As New Common.IniFile(p_AppConfigIni)
        Dim CatNm As String = DirectCast(tmplang.GetType.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
        Dim KeyNm As String = DirectCast(tmplang.GetType.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
        ConfigIni.WriteValue("General", "Language", tmplang)

        Return True
    End Function

    Private Sub ReadGeneral()
        Dim clsIni As New Common.IniFile(p_AppConfigIni)

        Dim tmpVal As Integer = clsIni.ReadValue("General", "GRPROTATE", 120000)
        If tmpVal / 1000 < Me.nudGrpRotate.Minimum Then
            nudGrpRotate.Value = nudGrpRotate.Minimum
        Else
            nudGrpRotate.Value = tmpVal / 1000
        End If

        chkNor.Checked = clsIni.ReadValue("General", "NORMAL_SHOW", True)
        chkWar.Checked = clsIni.ReadValue("General", "WARNING_SHOW", True)
        chkCri.Checked = clsIni.ReadValue("General", "CRITICAL_SHOW", True)

        cmbCpuStyle.SetValues(New BaseControls.ValueDescription(GetType(Controls.Raider.RaiderStyle)))
        cmbMemStyle.SetValues(New BaseControls.ValueDescription(GetType(Controls.Raider.RaiderStyle)))

        txtRegex.Text = clsIni.ReadValue("SQL", "PATTERN", "\$[a-zA-Z_\d]*\b")

        Dim dtTable As DataTable = _clsQuery.SelectMonUserConfig(p_cSession.UserID)
        If dtTable Is Nothing Or dtTable.Rows.Count = 0 Then
            LoadDefaultValue()
        End If
        Dim dtRow As DataRow = dtTable.Rows(0)

        Dim AppLang As clsEnums.AppLanguage = Integer.Parse(dtRow.Item("LANGUAGE").ToString())
        Dim strFileLocaton As String = TryCast(AppLang.GetType().GetMember(AppLang.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description

        Dim strPath As String = System.IO.Path.GetDirectoryName(strFileLocaton)
        For Each LangFile As String In System.IO.Directory.GetFiles(strPath, "*.xml")
            cmbLang.Items.Add(System.IO.Path.GetFileNameWithoutExtension(LangFile))
        Next
        cmbLang.Tag = strPath
        cmbLang.Text = System.Enum.GetName(GetType(clsEnums.AppLanguage), AppLang)

        Dim tmpPeriod As Integer = Integer.Parse(dtRow.Item("REFRESH_PERIOD").ToString()) / 1000
        nudCollect.Value = IIf(tmpPeriod < 3 Or tmpPeriod > 120, 3, tmpPeriod)

        If dtRow.Item("SOUND_PATH").ToString() = "" Then
            txtSound.Text = "Siren.wav"
        Else
            txtSound.Text = dtRow.Item("SOUND_PATH").ToString()
        End If

        If Integer.Parse(dtRow.Item("SHOW_ALIAS_TF").ToString()) = 0 Then
            rbHostnm.Checked = True
        Else
            rbAlias.Checked = True
        End If

        chkUseDefaultAccount.Checked = Integer.Parse(dtRow.Item("REG_ACCOUNT_SQLPLAN_TF").ToString())

        cmbCpuStyle.SelectedValue = Integer.Parse(dtRow.Item("STYLE_CPU").ToString())
        chkCpuItemReverse.Checked = Integer.Parse(dtRow.Item("STYLE_CPU_DIRECTION_TF").ToString())
        cmbMemStyle.SelectedValue = Integer.Parse(dtRow.Item("STYLE_MEM").ToString())
        chkMemItemReverse.Checked = Integer.Parse(dtRow.Item("STYLE_MEM_DIRECTION_TF").ToString())

        If Integer.Parse(dtRow.Item("STYLE_CPU_DSP").ToString()) = 0 Then
            rbCPUHostnm.Checked = True
        Else
            rbCPUIcon.Checked = True
        End If

        If Integer.Parse(dtRow.Item("STYLE_MEM_DSP").ToString()) = 0 Then
            rbMEMHostnm.Checked = True
        Else
            rbMEMIcon.Checked = True
        End If

    End Sub

    Private Sub LoadDefaultValue()
        Dim AppLang As clsEnums.AppLanguage = 0
        Dim strFileLocaton As String = TryCast(AppLang.GetType().GetMember(AppLang.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description

        Dim strPath As String = System.IO.Path.GetDirectoryName(strFileLocaton)
        For Each LangFile As String In System.IO.Directory.GetFiles(strPath, "*.xml")
            cmbLang.Items.Add(System.IO.Path.GetFileNameWithoutExtension(LangFile))
        Next
        cmbLang.Tag = strPath
        cmbLang.Text = System.Enum.GetName(GetType(clsEnums.AppLanguage), AppLang)

        nudCollect.Value = 3
        txtSound.Text = "Siren.wav"
        rbHostnm.Checked = True
        rbCPUHostnm.Checked = True
        rbMEMHostnm.Checked = True
        
        chkUseDefaultAccount.Checked = False

        cmbCpuStyle.SelectedIndex = 1
        chkCpuItemReverse.Checked = False
        cmbMemStyle.SelectedIndex = 1
        chkMemItemReverse.Checked = False
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If cmbFont.Text <> "" Then
        '    TextBox1.Font = New Font(cmbFont.Text, TextBox1.Font.Size)
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.DefaultExt = "*.wav"
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtSound.Text = ofd.FileName
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Snd As String = ""
        Try
            If txtSound.Text.Trim <> "" Then
                Dim sndFile As String = System.IO.Path.Combine(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Sounds"), txtSound.Text)
                If System.IO.File.Exists(sndFile) Then
                    My.Computer.Audio.Play(sndFile)
                End If
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub



    Private Sub btnQueryInit_Click(sender As Object, e As EventArgs) Handles btnQueryInit.Click
        'cmbBackColor.Text = "BLACK"
        'cmbComments.Text = "GREEN"
        'cmbFunctions.Text = "MAROON"
        'cmbKeywords.Text = "BLUE"
        'cmbNumbers.Text = "MAGENTA"
        'cmbStatements.Text = "BLUE"
        'cmbTypes.Text = "BROWN"
        'cmbVariables.Text = "MAROON"
        'cmbStrings.Text = "RED"
        'cmbNormal.Text = "GRAY"
    End Sub

    Private Sub tbMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbMain.SelectedIndexChanged
        'tbMain.TabPages(tbMain.SelectedIndex).Font = New Font("굴림체", tbMain.TabPages(tbMain.SelectedIndex).Font.Size, System.Drawing.FontStyle.Bold)
        For i As Integer = 0 To tbMain.TabCount - 1
            If i = tbMain.SelectedIndex Then
                'tbMain.TabPages.Item(i).BackColor = System.Drawing.Color.Gray
            Else
                ' tbMain.TabPages.Item(i).BackColor = System.Drawing.Color.DimGray
            End If
        Next

    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        Dim strkey = fn_GetSerial()
        Dim frmUserPwd As New frmUserPassword(_clsQuery, True)
        frmUserPwd.ShowDialog()
    End Sub


    Private Sub btnUserSave_Click(sender As Object, e As EventArgs) Handles btnUserSave.Click
        'check empty
        If txtUserID.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F347")))
            txtUserID.Focus()
            Return
        End If
        If txtUserName.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F348")))
            txtUserName.Focus()
            Return
        End If

        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        Dim nReturn As Integer = 0
        nReturn = _clsQuery.UpdateUser(txtUserID.Text, txtUserName.Text, txtPhone.Text, txtPhone2.Text, _noticeMethod, txtEmail.Text, txtEmpNum.Text, txtDept.Text, strLocIP)
        Select Case nReturn
            Case -23505
                MsgBox(p_clsMsgData.fn_GetData("M070"))
                txtUserID.Select()
                Return
            Case -1
                MsgBox(p_clsMsgData.fn_GetData("M029"))
                Return
        End Select
        MsgBox(p_clsMsgData.fn_GetData("M082"))
        AccessLog("change_user_info", 0, "")
    End Sub

    Private Sub rbUseNoti1_CheckedChanged(sender As Object, e As EventArgs) Handles rbUseNoti1.CheckedChanged, rbUseNoti2.CheckedChanged, rbUseNoti3.CheckedChanged
        Dim rbTemp As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        Select Case rbTemp.Name
            Case "rbUseNoti1"
                _noticeMethod = 0
            Case "rbUseNoti2"
                _noticeMethod = 1
            Case "rbUseNoti3"
                _noticeMethod = 2
        End Select
    End Sub

#Region "Internal functions"
    Private Function fn_GetSerial() As String
        'Dim strKey As String
        Try
            'Dim odbcCon As eXperDB.ODBC.eXperDBODBC = TryCast(lblSvrLst.Tag, eXperDB.ODBC.eXperDBODBC)
            'Dim ClsQuery As New clsQuerys(odbcCon)
            'Dim dtTable As DataTable = ClsQuery.SelectSerialKey()
            'If dtTable IsNot Nothing Then
            '    Dim dtRow As DataRow = dtTable.Rows(0)
            '    strKey = dtRow.Item("LICDATA")
            '    If strKey.Length < 24 Then
            '        Return ""
            '    End If
            '    Return strKey
            'End If
            Return ""
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return ""
        End Try
    End Function

    Private Sub ReadUserInfo()
        Dim dtTable As DataTable = _clsQuery.SelectMonUserinfo(p_cSession.UserID)
        If dtTable Is Nothing Or dtTable.Rows.Count = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M080"))
        End If
        Dim dtRow As DataRow = dtTable.Rows(0)
        txtUserID.Text = dtRow.Item("USER_ID")
        txtUserName.Text = dtRow.Item("USER_NAME")
        txtPhone.Text = dtRow.Item("USER_PHONE")
        txtPhone2.Text = dtRow.Item("USER_PHONE2")
        If Integer.Parse(dtRow.Item("USER_NOTI_PHONE").ToString()) = 0 Then
            rbUseNoti1.Checked = True
            _noticeMethod = 0
        ElseIf Integer.Parse(dtRow.Item("USER_NOTI_PHONE").ToString()) = 1 Then
            rbUseNoti2.Checked = True
            _noticeMethod = 1
        Else
            rbUseNoti3.Checked = True
            _noticeMethod = 2
        End If
        txtEmail.Text = dtRow.Item("USER_EMAIL")
        txtEmpNum.Text = dtRow.Item("USER_EMPNUM")
        txtDept.Text = dtRow.Item("USER_DEPT_NAME")
    End Sub

    Private Sub AccessLog(ByVal strAccessType As String, ByVal intStatus As Integer, _
                      Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.InsertUserAccessInfo(p_cSession.UserID, strAccessType, intStatus, strLog, strLocIP)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region



End Class