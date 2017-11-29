Imports System.IO
Imports System.Text
Imports System.Xml


Public Class frmCCerti
    Dim CC As New ClsCrypt
    Dim PW As String = "shwotmd"

    Private Sub MakeFileAsCrypt()
        Dim CurrTabpagIdx As Integer = TabControl.SelectedIndex

        If CurrTabpagIdx = 0 Then

            If MacAddress.Text = String.Empty Then
                MsgBox("Mac 주소를 입력하세요!", MsgBoxStyle.Information, "정보")
                MacAddress.Focus()
                Exit Sub
            End If

            If CustPassword.Text = String.Empty Then
                MsgBox("고객암호를 입력하세요!", MsgBoxStyle.Information, "정보")
                CustPassword.Focus()
                Exit Sub
            Else
                '숫자 검증
                If IsNumeric(CustPassword.Text) = False Then
                    MsgBox("고객암호는 숫자로만 조합되어야 합니다!", MsgBoxStyle.Information, "정보")
                    CustPassword.Focus()
                    Exit Sub
                End If
            End If

            If CustPassword.Text <> ReCustPassword.Text Then
                MsgBox("암호확인이 맞지 않습니다!", MsgBoxStyle.Information, "정보")
                ReCustPassword.Focus()
                Exit Sub
            End If

            If UseMode.CheckedItems.Count <= 0 Then
                MsgBox("최소 한가지 이상 권한부여는 필요합니다.", MsgBoxStyle.Information, "정보")
                UseMode.Focus()
                Exit Sub
            End If


            Dim limitDate As String = String.Empty
            If UnlimitedCheckBox.CheckState = CheckState.Checked Then
                limitDate = "UNLIMITED"
            Else
                Dim exf As Date = CType(ExpireDate.Text, Date)
                limitDate = Format(exf, "yyyyMMdd")
            End If


            Dim rd As Date = Now

            '하이픈 제거(2013/09/27, 수정자 : 서상해), Focus이벤트가 일어나지 않을시 하이픈이 제거되지 않는 현상해결
            MacAddress.Text = Replace(Trim(MacAddress.Text), "-", "")

            'Format
            'Mac주소|만료일(yyyymmdd)|사용모드|등록일
            Dim str As String = MacAddress.Text & ClsCrypt.FormatDelimeter & _
                                limitDate & ClsCrypt.FormatDelimeter & _
                                GetCheckListData(UseMode, ClsCrypt.ModeDelimeter) & ClsCrypt.FormatDelimeter & _
                                Format(rd, "yyyyMMdd")

            Try
                CertiString.Text = CC.EncryptString(str, CustPassword.Text)
            Catch ex As Exception
                MsgBox("인증실패!", MsgBoxStyle.Critical, "에러")
                Exit Sub
            End Try

        ElseIf CurrTabpagIdx = 1 Then

            If DeCustPassword.Text = String.Empty Then
                MsgBox("고객암호를 입력하세요!", MsgBoxStyle.Information, "정보")
                Exit Sub
            Else
                '숫자 검증
                If IsNumeric(DeCustPassword.Text) = False Then
                    MsgBox("고객암호는 숫자로만 조합되어야 합니다!", MsgBoxStyle.Information, "정보")
                    DeCustPassword.Focus()
                    Exit Sub
                End If
            End If

            Try

                '복호화 수행
                Dim xeValue As String = CC.DecryptString(DeCertiInfo.Text, DeCustPassword.Text)
                Dim deStr As String() = xeValue.Split(ClsCrypt.FormatDelimeter)

                'Mac주소|만료일(yyyymmdd)|사용모드|등록일

                ResultRTB.Clear()
                '    ResultRTB.Font = New Font(iDastGlobal.iDAST_FontName, iDastGlobal.iDAST_FontSize)
                ResultRTB.AppendText("[MAC 주소] : " & deStr(0) & vbCrLf)
                ResultRTB.AppendText("[만료일  ] : " & deStr(1) & vbCrLf)

                ResultRTB.AppendText("[사용모드] : " & vbCrLf)
                Dim useMd As String() = deStr(2).Split(ClsCrypt.ModeDelimeter)
                For i As Integer = 0 To useMd.Count - 1
                    ResultRTB.AppendText(vbTab & "(권한" & i + 1 & ") " & CC.GetModePhscNm(CInt(useMd(i))) & vbCrLf)
                Next

                ResultRTB.AppendText("[등록일  ] : " & deStr(3) & vbCrLf)

            Catch ex As Exception
                ResultRTB.Clear()
                MsgBox("암호 정보가 상호간 맞지 않습니다.", MsgBoxStyle.Critical, "에러")
                Exit Sub
            End Try

        ElseIf CurrTabpagIdx = 2 Then

            If (UserIdTB.Text = String.Empty) Then
                MsgBox("UserID가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
                UserIdTB.Focus()
                Exit Sub
            ElseIf (PasswordTB.Text = String.Empty) Then
                MsgBox("Password가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
                PasswordTB.Focus()
                Exit Sub
            ElseIf (OdbcDriverCB.SelectedValue = String.Empty) Then
                MsgBox("ODBC Driver 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
                OdbcDriverCB.Focus()
                Exit Sub
            ElseIf (ServerIpTB.Text = String.Empty) Then
                MsgBox("Server IP 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
                ServerIpTB.Focus()
                Exit Sub
            ElseIf (DbNameTB.Text = String.Empty) Then
                MsgBox("Database Name 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
                DbNameTB.Focus()
                Exit Sub
            ElseIf (PortTB.Text = String.Empty) Then
                MsgBox("Port 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
                PortTB.Focus()
                Exit Sub
            End If

            Dim TmpConnInfo As New ClsOdbc.OdbcDbInfo
            TmpConnInfo.USERID = UserIdTB.Text
            TmpConnInfo.USERPW = PasswordTB.Text
            TmpConnInfo.ODBCDRIVER = OdbcDriverCB.SelectedValue.ToString
            TmpConnInfo.SERVERIP = ServerIpTB.Text
            TmpConnInfo.DBNAME = DbNameTB.Text
            TmpConnInfo.PORT = PortTB.Text

            '접속테스트
            '나중에 필요!!!!!!!!!!!

            Dim arrList As New ArrayList
            arrList.Add(TmpConnInfo.USERID)
            arrList.Add(TmpConnInfo.USERPW)
            arrList.Add(TmpConnInfo.ODBCDRIVER)
            arrList.Add(TmpConnInfo.SERVERIP)
            arrList.Add(TmpConnInfo.DBNAME)
            arrList.Add(TmpConnInfo.PORT)

            Dim FileName As String = CurDir() & Path.DirectorySeparatorChar & "anthology" & ".ida"

            Dim CMDC As DX.Migration.Server.Library.ClsMetaDbCtl = New DX.Migration.Server.Library.ClsMetaDbCtl(FileName)

            If (Not CMDC.SetMetaDbInfo(arrList)) Then
                MsgBox("접속정보 저장이 실패했습니다.", MsgBoxStyle.Critical, "에러")
                Exit Sub
            End If

            '수행결과
            arrList.Clear()
            arrList = CMDC.GetMetaDbInfo()
            MetaInfoDisplay(MetaResultRTB, arrList, FileName)

        ElseIf CurrTabpagIdx = 3 Then
            If (TextBox1.Text = String.Empty) Then
                MsgBox("메타시스템 접속정보 파일 경로를 지정하세요.", MsgBoxStyle.Information, "정보")
                Button1.Focus()
                Exit Sub
            End If

            Dim FileName As String = TextBox1.Text
            Dim CMDC As DX.Migration.Server.Library.ClsMetaDbCtl = New DX.Migration.Server.Library.ClsMetaDbCtl(FileName)
            Dim arrList As ArrayList = CMDC.GetMetaDbInfo()
            MetaInfoDisplay(MetaCofRTB, arrList, FileName)
        ElseIf CurrTabpagIdx = 4 Then

            Dim FileName As String = CurDir() & Path.DirectorySeparatorChar & "anthology" & ".ida"
            Dim CMDC As New DX.Common.ClsMetaDbCtl

            For Each tmpRow As DataGridViewRow In Me.DataGridView1.Rows
                Dim BretAppend As Boolean = True
                If tmpRow.Index = 0 Then
                    BretAppend = False
                Else
                    BretAppend = True
                End If
                CMDC.SetMetaDbInfo(FileName, tmpRow.Cells(colDgvAlias.Index).Value, tmpRow.Cells(colDgvDatas.Index).Value, BretAppend)
            Next







        End If

        MsgBox("[" & TabControl.SelectedTab.Text & "]" & " 수행되었습니다.", MsgBoxStyle.Information, "정보")

    End Sub


    Private Sub MetaInfoDisplay(ByVal pRTB As RichTextBox, ByVal pData As ArrayList, ByVal pFile As String)
        pRTB.Clear()
        'pRTB.Font = New Font(iDastGlobal.iDAST_FontName, iDastGlobal.iDAST_FontSize)

        pRTB.AppendText("[User/Schema] : " & pData(0) & vbCrLf)
        pRTB.AppendText("[Password] : " & pData(1) & vbCrLf)
        pRTB.AppendText("[ODBC Driver] : " & pData(2) & vbCrLf)
        pRTB.AppendText("[Server IP] : " & pData(3) & vbCrLf)
        pRTB.AppendText("[Database Name] : " & pData(4) & vbCrLf)
        pRTB.AppendText("[Port] : " & pData(5) & vbCrLf)
        pRTB.AppendText("[File] : " & pFile & vbCrLf)
    End Sub

    Private Function GetCheckListData(ByVal pCheckedListBox As CheckedListBox, ByVal pChr As String) As String
        Dim outData As String = String.Empty
        For i As Integer = 0 To pCheckedListBox.Items.Count - 1
            If pCheckedListBox.GetItemChecked(i) = True Then
                outData = outData & pChr & pCheckedListBox.GetItemText(i)
            End If
        Next
        Return outData.TrimStart(",")
    End Function

    Private Function getOdbcDriverList(ByVal pOdbcDriver(,) As String) As ArrayList
        Dim Array As New ArrayList
        For i = LBound(ClsOdbc.iDAST_OdbcDriver) To UBound(ClsOdbc.iDAST_OdbcDriver)
            Array.Add(New ClsValueDescription(pOdbcDriver(i, 0), pOdbcDriver(i, 1)))
        Next
        Return Array
    End Function

    Private Sub frmCCerti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '버튼 이미지 초기화
        ExecButton.Image = PuplationIco(My.Resources.play).ToBitmap
        CloseButton.Image = PuplationIco(My.Resources.proc_stop).ToBitmap
        GetCerty.Image = PuplationIco(My.Resources.key_login).ToBitmap

        '모드 comboBox 초기화
        With UseMode
            .Items.Clear()
            '.Items.Add(iDastGlobal.iDAST_ProgramType(0, 1), False) 'index = 0
            '.Items.Add(iDastGlobal.iDAST_ProgramType(1, 1), True) 'index = 1
            '.Items.Add(iDastGlobal.iDAST_ProgramType(2, 1), False) 'index = 2
            '.Items.Add(iDastGlobal.iDAST_ProgramType(3, 1), False) 'index = 3
            '.Items.Add(iDastGlobal.iDAST_ProgramType(4, 1), False) 'index = 4
            '.Items.Add(iDastGlobal.iDAST_ProgramType(5, 1), False) 'index = 5
            '.Items.Add(iDastGlobal.iDAST_ProgramType(6, 1), False) 'index = 6
            '.Items.Add(iDastGlobal.iDAST_ProgramType(7, 1), True) 'index = 7
        End With

        With OdbcDriverCB
            .DisplayMember = "Description"
            .ValueMember = "Value"
            .DataSource = getOdbcDriverList(ClsOdbc.iDAST_OdbcDriver)
        End With


        With cmbDB
            .DisplayMember = "Description"
            .ValueMember = "Value"
            .DataSource = getOdbcDriverList(ClsOdbc.iDAST_OdbcDriver)
        End With


        '제한 날짜 제한
        ExpireDate.MinDate = Now

        'Current Tabpage
        TabControl.TabIndex = 0

        '인증
        ExecButton.Enabled = False
        TabControl.Enabled = False
        CertiPw.TextBox.UseSystemPasswordChar = True

    End Sub

    Private Sub ExecButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecButton.Click
        MakeFileAsCrypt()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    '===========================================
    '요기서부터 소스 공유를 해야하는데 못하겠당
    '===========================================
    '숫자 check
    Private Function IsNumeric(ByVal value As String) As Boolean
        For Each _char As Char In value
            If Not [Char].IsNumber(_char) Then
                Return False
            End If
        Next
        Return True
    End Function

    ' 아이콘 리턴
    Function PuplationIco(ByVal pIconName As Icon) As Icon
        Dim img As Icon = pIconName
        Return img
    End Function

    'item GotFocus시 텍스트Box 전체 select
    Private Sub TxBSelAllGotFocus(ByVal pForm As Object, ByVal pText As TextBox)
        Dim TargetTextBox As TextBox = pText
        TargetTextBox.SelectionStart = 0
        TargetTextBox.SelectionLength = Len(TargetTextBox.Text)
    End Sub

    Private Sub MacAddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MacAddress.GotFocus
        TxBSelAllGotFocus(Me, MacAddress)
    End Sub
    '===========================================

    Private Sub MacAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MacAddress.LostFocus
        MacAddress.Text = Replace(Trim(MacAddress.Text), "-", "")
    End Sub

    Private Sub CustPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustPassword.GotFocus
        TxBSelAllGotFocus(Me, CustPassword)
    End Sub

    Private Sub DeCustPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeCustPassword.GotFocus
        TxBSelAllGotFocus(Me, DeCustPassword)
    End Sub

    Private Sub GetCerty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetCerty.Click
        If CertiPw.Text <> PW Then
            MsgBox("인증이 실패하였습니다!", MsgBoxStyle.Information, "정보")
            CertiPw.Focus()
        Else
            ExecButton.Enabled = True
            GetCerty.Enabled = False
            CertiPw.Text = ""
            CertiPw.Enabled = False
            TabControl.Enabled = True
        End If
    End Sub

    Private Sub frmCCerti_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        CertiPw.Focus()
    End Sub

    Private Sub CertiPw_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CertiPw.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            GetCerty_Click(sender, e)
        End If
    End Sub

    Private Sub UnlimitedCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlimitedCheckBox.CheckedChanged
        If UnlimitedCheckBox.CheckState = CheckState.Checked Then
            ExpireDate.Enabled = False
        Else
            ExpireDate.Enabled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = OpenFD()
    End Sub

    Private Function OpenFD() As String
        Dim FilePath As String = String.Empty
        With OpenFileDialog
            .Title = "파일 위치"
            .Filter = "File (*.ida)|*.ida"
            .RestoreDirectory = True
            If (.ShowDialog(Me) = DialogResult.OK) Then
                FilePath = .FileName
            End If
        End With
        Return FilePath
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtUser.Text = String.Empty) Then
            MsgBox("UserID가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
            UserIdTB.Focus()
            Exit Sub
        ElseIf (txtPw.Text = String.Empty) Then
            MsgBox("Password가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
            PasswordTB.Focus()
            Exit Sub
        ElseIf (cmbDB.SelectedValue = String.Empty) Then
            MsgBox("ODBC Driver 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
            OdbcDriverCB.Focus()
            Exit Sub
        ElseIf (txtIP.Text = String.Empty) Then
            MsgBox("Server IP 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
            ServerIpTB.Focus()
            Exit Sub
        ElseIf (txtDB.Text = String.Empty) Then
            MsgBox("Database Name 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
            DbNameTB.Focus()
            Exit Sub
        ElseIf (txtPort.Text = String.Empty) Then
            MsgBox("Port 정보가 입력되지 않았습니다.", MsgBoxStyle.Information, "정보")
            PortTB.Focus()
            Exit Sub
        ElseIf txtAlias.Text = String.Empty Then
            MsgBox("Alias 정보가 입력 되지 않았습니다. ")
            Return
        End If

        Dim TmpConnInfo As New ClsOdbc.OdbcDbInfo
        TmpConnInfo.USERID = txtUser.Text
        TmpConnInfo.USERPW = txtPw.Text
        TmpConnInfo.ODBCDRIVER = cmbDB.SelectedValue.ToString
        TmpConnInfo.SERVERIP = txtIP.Text
        TmpConnInfo.DBNAME = txtDB.Text
        TmpConnInfo.PORT = txtPort.Text

        '접속테스트
        '나중에 필요!!!!!!!!!!!

        Dim arrList As New ArrayList
        arrList.Add(TmpConnInfo.USERID)
        arrList.Add(TmpConnInfo.USERPW)
        arrList.Add(TmpConnInfo.ODBCDRIVER)
        arrList.Add(TmpConnInfo.SERVERIP)
        arrList.Add(TmpConnInfo.DBNAME)
        arrList.Add(TmpConnInfo.PORT)



        Dim CMDC As ClsMetaDbCtl = New ClsMetaDbCtl()
        Dim strEnc As String = String.Join(ClsCrypt.FormatDelimeter, arrList.ToArray())
        Dim strAlias As String = txtAlias.Text

        Me.DataGridView1.Rows.Add(strAlias, strEnc)


         
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Clear()
        Dim FilePath As String = String.Empty
        With OpenFileDialog
            .Title = "파일 위치"
            .Filter = "File (*.*)|*.*"
            .RestoreDirectory = True
            If (.ShowDialog(Me) = DialogResult.OK) Then
                FilePath = .FileName
            End If
        End With


        Dim Cmdc As New DX.Common.ClsMetaDbCtl
        Dim arrAlias As ArrayList = Cmdc.GetMetaDbList(FilePath)
        RichTextBox1.AppendText("[File] : " & FilePath & vbCrLf)
        For Each tmpAlias As String In arrAlias
            RichTextBox1.AppendText("[ALIAS]:" & tmpAlias & vbCrLf)
            Dim pData As ArrayList = Cmdc.GetMetaDbInfo(FilePath, tmpAlias)
            RichTextBox1.AppendText("     [User/Schema] : " & pData(0) & vbCrLf)
            RichTextBox1.AppendText("     [Password] : " & pData(1) & vbCrLf)
            RichTextBox1.AppendText("     [ODBC Driver] : " & pData(2) & vbCrLf)
            RichTextBox1.AppendText("     [Server IP] : " & pData(3) & vbCrLf)
            RichTextBox1.AppendText("     [Database Name] : " & pData(4) & vbCrLf)
            RichTextBox1.AppendText("     [Port] : " & pData(5) & vbCrLf)
        Next

    End Sub
End Class
