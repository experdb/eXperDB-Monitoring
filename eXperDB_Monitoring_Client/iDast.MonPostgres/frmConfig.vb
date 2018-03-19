Public Class frmConfig

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
      

    End Sub


    Private Sub initForm()
        btnSave.Text = p_clsMsgData.fn_GetData("F014")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")



        ' 일반설정 탭 
        'FormMovePanel1.Text = p_clsMsgData.fn_GetData("F022")
        Me.Text = p_clsMsgData.fn_GetData("F022")
        StatusLabel.Text = p_clsMsgData.fn_GetData("F022")
        tp1.Text = p_clsMsgData.fn_GetData("F024")
        lblLang.Text = p_clsMsgData.fn_GetData("F023")

        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        Dim AppLang As clsEnums.AppLanguage = clsIni.ReadValue("General", "Language", clsEnums.AppLanguage.Korean)
        Dim strFileLocaton As String = TryCast(AppLang.GetType().GetMember(AppLang.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description

        lblCollect.Text = p_clsMsgData.fn_GetData("F190")
        lbGrpRatate.Text = p_clsMsgData.fn_GetData("F243")
        Dim tmpVal As Integer = clsIni.ReadValue("General", "ELAPSE", 3000)
        If tmpVal / 1000 < Me.nudCollect.Minimum Then
            nudCollect.Value = nudCollect.Minimum
        Else
            nudCollect.Value = tmpVal / 1000
        End If

        tmpVal = clsIni.ReadValue("General", "GRPROTATE", 120000)
        If tmpVal / 1000 < Me.nudGrpRotate.Minimum Then
            nudGrpRotate.Value = nudGrpRotate.Minimum
        Else
            nudGrpRotate.Value = tmpVal / 1000
        End If


        lblFont.Text = p_clsMsgData.fn_GetData("F191")

        Dim strPath As String = System.IO.Path.GetDirectoryName(strFileLocaton)
        For Each LangFile As String In System.IO.Directory.GetFiles(strPath, "*.xml")
            cmbLang.Items.Add(System.IO.Path.GetFileNameWithoutExtension(LangFile))
        Next
        cmbLang.Tag = strPath
        cmbLang.Text = System.Enum.GetName(GetType(clsEnums.AppLanguage), AppLang)


        lblHealthCheck.Text = p_clsMsgData.fn_GetData("F189")
        chkNor.Text = p_clsMsgData.fn_GetData("F029")
        chkWar.Text = p_clsMsgData.fn_GetData("F030")
        chkCri.Text = p_clsMsgData.fn_GetData("F031")

        chkNor.Checked = clsIni.ReadValue("General", "NORMAL_SHOW", True)
        chkWar.Checked = clsIni.ReadValue("General", "WARNING_SHOW", True)
        chkCri.Checked = clsIni.ReadValue("General", "CRITICAL_SHOW", True)


        TextBox2.Text = clsIni.ReadValue("General", "SIREN", "Siren.wav")

        lblShowNm.Text = p_clsMsgData.fn_GetData("F228")
        rbHostnm.Text = p_clsMsgData.fn_GetData("F229")
        rbAlias.Text = p_clsMsgData.fn_GetData("F230")

        If clsIni.ReadValue("General", "SVRNAME", 0) = 0 Then
            rbHostnm.Checked = True
        Else
            rbAlias.Checked = True
        End If


        ' 스타일 탭
        tp2.Text = p_clsMsgData.fn_GetData("F038")
        lblRaider.Text = p_clsMsgData.fn_GetData("F037")
        lblCpuStyle.Text = p_clsMsgData.fn_GetData("F035")
        lblMemStyle.Text = p_clsMsgData.fn_GetData("F036")
        chkCpuItemReverse.Text = p_clsMsgData.fn_GetData("F039")
        chkMemItemReverse.Text = p_clsMsgData.fn_GetData("F039")

        cmbCpuStyle.SetValues(New BaseControls.ValueDescription(GetType(Controls.Raider.RaiderStyle)))
        cmbMemStyle.SetValues(New BaseControls.ValueDescription(GetType(Controls.Raider.RaiderStyle)))

        cmbCpuStyle.SelectedValue = clsIni.ReadValue("STYLE", "CPU", 2)
        cmbMemStyle.SelectedValue = clsIni.ReadValue("STYLE", "MEM", 2)

        chkCpuItemReverse.Checked = clsIni.ReadValue("STYLE", "CPUREVERSE", False)
        chkMemItemReverse.Checked = clsIni.ReadValue("STYLE", "MEMREVERSE", False)



        Dim clsFonts As New System.Drawing.Text.InstalledFontCollection()
        For Each tmpFont As FontFamily In clsFonts.Families
            cmbFont.Items.Add(tmpFont.Name)
        Next


        cmbFont.Text = p_Font

        tp1.BackColor = System.Drawing.Color.Gray
        tp2.BackColor = System.Drawing.Color.DimGray
        ' SQL TAB 

        btnQueryInit.Text = p_clsMsgData.fn_GetData("F226")

        'tpSQL.Text = p_clsMsgData.fn_GetData("F208")
        lblRegex.Text = p_clsMsgData.fn_GetData("F209")
        'lblBackColor.Text = p_clsMsgData.fn_GetData("F210")
        'lblComments.Text = p_clsMsgData.fn_GetData("F211")
        'lblFunctions.Text = p_clsMsgData.fn_GetData("F212")
        'lblKeywords.Text = p_clsMsgData.fn_GetData("F213")
        'lblNumbers.Text = p_clsMsgData.fn_GetData("F214")
        'lblStatements.Text = p_clsMsgData.fn_GetData("F215")
        'lblTypes.Text = p_clsMsgData.fn_GetData("F216")
        'lblVariables.Text = p_clsMsgData.fn_GetData("F217")
        'lblStrings.Text = p_clsMsgData.fn_GetData("F218")
        'lblNormal.Text = p_clsMsgData.fn_GetData("F220")


        txtRegex.Text = clsIni.ReadValue("SQL", "PATTERN", "\$[a-zA-Z_\d]*\b")
        'cmbBackColor.Text = clsIni.ReadValue("SQL", "BACKCOLOR", "BLACK")
        'cmbComments.Text = clsIni.ReadValue("SQL", "COMMENTS", "GREEN")
        'cmbFunctions.Text = clsIni.ReadValue("SQL", "FUNCTIONS", "MAROON")
        'cmbKeywords.Text = clsIni.ReadValue("SQL", "KEYWORDS", "BLUE")
        'cmbNumbers.Text = clsIni.ReadValue("SQL", "NUMBERS", "MAGENTA")
        'cmbStatements.Text = clsIni.ReadValue("SQL", "STATEMENTS", "BLUE")
        'cmbTypes.Text = clsIni.ReadValue("SQL", "TYPES", "BROWN")
        'cmbVariables.Text = clsIni.ReadValue("SQL", "VARIABLES", "MAROON")
        'cmbStrings.Text = clsIni.ReadValue("SQL", "STRINGS", "RED")
        'cmbNormal.Text = clsIni.ReadValue("SQL", "NORMAL", "GRAY")


        'Me.RichTextBoxQuery1.BackColor = System.Drawing.Color.FromName(cmbBackColor.Text)
        'Me.RichTextBoxQuery1.Comments = System.Drawing.Color.FromName(cmbComments.Text)
        'Me.RichTextBoxQuery1.Functions = System.Drawing.Color.FromName(cmbFunctions.Text)
        'Me.RichTextBoxQuery1.KeyWords = System.Drawing.Color.FromName(cmbKeywords.Text)
        'Me.RichTextBoxQuery1.Numbers = System.Drawing.Color.FromName(cmbNumbers.Text)
        'Me.RichTextBoxQuery1.StateMents = System.Drawing.Color.FromName(cmbStatements.Text)
        'Me.RichTextBoxQuery1.Types = System.Drawing.Color.FromName(cmbTypes.Text)
        'Me.RichTextBoxQuery1.Variables = System.Drawing.Color.FromName(cmbVariables.Text)
        'Me.RichTextBoxQuery1.Strings = System.Drawing.Color.FromName(cmbStrings.Text)
        'Me.RichTextBoxQuery1.ForeColor = System.Drawing.Color.FromName(cmbNormal.Text)





        'modCommon.FontChange(Me, p_Font)



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        sb_SaveGeneral()
        Sb_SaveStyle()

        sb_SaveSQL()

        MsgBox("저장이 완료되었습니다. 모니터링을 재시작하여 주십시오.")
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
        ConfigIni.WriteValue("General", "FONT", cmbFont.Text)

        ConfigIni.WriteValue("General", "NORMAL_SHOW", IIf(chkNor.Checked, "TRUE", "FALSE"))
        ConfigIni.WriteValue("General", "WARNING_SHOW", IIf(chkWar.Checked, "TRUE", "FALSE"))
        ConfigIni.WriteValue("General", "CRITICAL_SHOW", IIf(chkCri.Checked, "TRUE", "FALSE"))
        If TextBox2.Text <> "" AndAlso System.IO.File.Exists(TextBox2.Text) Then
            Dim SndDir As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Sounds")

            If System.IO.Directory.Exists(SndDir) = False Then
                My.Computer.FileSystem.CreateDirectory(SndDir)
            End If

            If TextBox2.Text <> System.IO.Path.Combine(SndDir, System.IO.Path.GetFileName(TextBox2.Text)) Then

                My.Computer.FileSystem.CopyFile(TextBox2.Text, System.IO.Path.Combine(SndDir, System.IO.Path.GetFileName(TextBox2.Text)), True)
            End If

            ConfigIni.WriteValue("General", "SIREN", System.IO.Path.GetFileName(TextBox2.Text))
        End If


        If rbHostnm.Checked = True Then
            ConfigIni.WriteValue("General", "SVRNAME", 0)
        Else
            ConfigIni.WriteValue("General", "SVRNAME", 1)
        End If








    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFont.SelectedIndexChanged
        If cmbFont.Text <> "" Then
            TextBox1.Font = New Font(cmbFont.Text, TextBox1.Font.Size)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.DefaultExt = "*.wav"
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TextBox2.Text = ofd.FileName
        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Snd As String = ""

        If TextBox2.Text.Trim <> "" Then
            Dim sndFile As String = System.IO.Path.Combine(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Sounds"), TextBox2.Text)
            If System.IO.File.Exists(sndFile) Then
                My.Computer.Audio.Play(sndFile)
            End If
        End If

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
                tbMain.TabPages.Item(i).BackColor = System.Drawing.Color.Gray
            Else
                tbMain.TabPages.Item(i).BackColor = System.Drawing.Color.DimGray
            End If
        Next
    End Sub

End Class