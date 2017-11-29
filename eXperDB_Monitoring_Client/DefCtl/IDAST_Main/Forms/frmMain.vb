Option Explicit On
Imports System.Windows.Forms
Imports System.Windows
Imports System.IO

Public Class frmMain
    Private COC As New ClsObjectCtl
    Private CC As New ClsCrypt
    Private ReadOnly iDAST_Cfg = CurDir() & Path.DirectorySeparatorChar & "Configure.xml"
    Private ReadOnly PkgName = "iDastPkg"

    Private ConformPW As String = String.Empty
    Private Program As String = CurDir() & Path.DirectorySeparatorChar & PkgName
    Private Const DynamicFormSizeTime = 4 '에니메이션형태의 폼사이즈 변경 속도 조절

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

    End Sub

    Private Sub SetMsg(ByVal pMsg As String)
        MsgTSSL.Text = pMsg
        COC.DoEvents()
    End Sub

    Private Sub RunCerti(ByVal pPw As String)
        Try
            '=====================
            'xml 설정정보 확인
            '=====================
            Dim CCC = New ClsConfigureCtl(iDAST_Cfg)

            '인증여부 취득
            Dim xeValue As String = Trim(CCC.getValue("cfgAppender", "Certification"))
            SetMsg("라이센스 정보 취득중...")

            If xeValue = "" Or xeValue Is String.Empty Then
                MsgBox("라이센스 정보를 가져올수 없습니다.", MsgBoxStyle.Critical, "에러")
                Exit Sub
            End If

            '복호화 수행
            xeValue = CC.DecryptString(xeValue, pPw)
            Dim deStr As String() = xeValue.Split(ClsCrypt.FormatDelimeter)
            SetMsg("패스워드 인증 확인중...")

            If xeValue = "" Or xeValue Is String.Empty Then
                MsgBox("패스워드가 불일치합니다.", MsgBoxStyle.Critical, "에러")
                Exit Sub
            End If

            Dim MACADDR As String = deStr(0)
            Dim EXPDATE As String = deStr(1)
            Dim USEMODE As String = deStr(2)
            Dim REGDATE As String = deStr(3)

            'Mac Address 검증
            SetMsg("Mac Address 인증중...")
            Dim MacAddr_DT As DataTable = COC.GetMacAddress
            Dim ChkYn As Boolean = False
            With MacAddr_DT
                For i As Integer = 0 To .Rows.Count - 1
                    If MACADDR = .Rows(i).Item(1).ToString Then
                        ChkYn = True
                        Exit For
                    End If
                Next
                If ChkYn = False Then
                    MsgBox("Mac 주소가 불일치합니다.", MsgBoxStyle.Critical, "에러")
                    Exit Sub
                End If
            End With

            '만료일검증
            SetMsg("만료일 인증중...")
            If EXPDATE <> "UNLIMITED" Then
                If CInt(Format(Now, "yyyyMMdd")) > CInt(EXPDATE) Then
                    MsgBox("만료일자가 넘었습니다." & vbCrLf & _
                           "다시 라이센스를 부여 받아야 합니다.", MsgBoxStyle.Critical, "에러")
                    Exit Sub
                End If
            End If

            ''패치 여부 확인
            'SetMsg("업데이트 정보 확인중...")
            'Dim PatchPgm As String = "PatchForm.exe"
            'Dim CommandLine As String = """" & CurDir() & """"

            'Dim pm As iDaaS.PatchManager = New iDaaS.PatchManager(CommandLine)
            'Dim outMsg As String = pm.getUpdateStatus

            'If outMsg = "STS_PATCH" Then

            '    Dim MsgResult As DialogResult = MessageBox.Show("새로운 업데이트 정보가 있습니다." & vbCrLf & _
            '                                                    "프로그램 업데이트를 시작 하시겠습니까? ", _
            '                                                    "정보", _
            '                                                    MessageBoxButtons.YesNo, _
            '                                                    MessageBoxIcon.Information)
            '    If MsgResult = DialogResult.Yes Then

            '        StartProgram(PatchPgm, CommandLine)

            '        '자기 자신은 종료
            '        Application.Exit()
            '    End If

            'ElseIf outMsg = "STS_READY" Then
            '    '로직이 필요하면 넣을것

            'ElseIf outMsg = "STS_CONFIGERROR " Then
            '    MsgBox("업데이터 서버의 설정정보가 잘못되었습니다." & vbCrLf & _
            '           "관리자의 문의를 바랍니다.", MsgBoxStyle.Critical, "에러")

            'ElseIf outMsg = "STS_REACHMAXCONN" Then
            '    MsgBox("최대 접속자 수를 초과하였습니다", MsgBoxStyle.Critical, "에러")

            'ElseIf outMsg = "STS_NETWORKERROR" Then
            '    MsgBox("네트워크 문제로 업데이트를 실행할수 없습니다." & vbCrLf & _
            '           "관리자의 문의를 바랍니다.", MsgBoxStyle.Critical, "에러")

            'ElseIf outMsg = "STS_SERVERERROR" Then
            '    MsgBox("업데이트 서버의 문제가 발생하였습니다." & vbCrLf & _
            '           "관리자의 문의를 바랍니다.", MsgBoxStyle.Critical, "에러")

            'Else
            '    '정보만 보여주고 진행
            '    MsgBox(outMsg & vbCrLf & _
            '           "업데이트 정보 확인시 예기치 않은 에러가 발생하였습니다" & vbCrLf & _
            '           "관리자의 문의를 바랍니다.", MsgBoxStyle.Critical, "에러")

            'End If

            '윈도우 조절
            SmoothFormSize()

            '모드 확인
            Dim useMd As String() = USEMODE.Split(ClsCrypt.ModeDelimeter)
            For i As Integer = 0 To useMd.Count - 1
                Dim idex As Integer = CInt(useMd(i))
                Select Case idex
                    Case 0
                        ModeCase0.Enabled = True
                    Case 1
                        ModeCase1.Enabled = True
                    Case 2
                        ModeCase2.Enabled = True
                    Case 3
                        ModeCase3.Enabled = True
                    Case 4
                        ModeCase4.Enabled = True
                    Case 5
                        ModeCase5.Enabled = True
                    Case 6
                        ModeCase6.Enabled = True
                    Case 7
                        ModeCase7.Enabled = True
                End Select
            Next

            '패스워드 등록
            ConformPW = pPw
            SetMsg("프로그램을 시작합니다.")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Private Sub OkBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBt.Click
        If CertiPw.Text = String.Empty Then
            MsgBox("인증 암호를 입력하세요!", MsgBoxStyle.Information, "정보")
            CertiPw.Focus()
        Else
            RunCerti(CertiPw.Text)
        End If
    End Sub

    Private Sub SmoothFormSize()

        PasswdToolStrip.Visible = False
        LicenseRTB.Visible = False

        While (True)
            Dim cHight As Integer = ActionGB.Height + StatusStrip1.Height + 30
            If Me.Height <= cHight Then
                Exit While
            End If
            ActionGB.Location = New System.Drawing.Point(0, ActionGB.Location.Y - DynamicFormSizeTime)
            Me.Height = Me.Height - DynamicFormSizeTime
            COC.DoEvents()
        End While
    End Sub

    Private Sub frmCertification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TopMost = True

        Me.Icon = COC.PuplationIco(My.Resources.iResources.idas_exec)
        Me.Text = "Intelligent Database Management"

        CertiPw.TextBox.UseSystemPasswordChar = True
        OkBt.Image = COC.PuplationIco(My.Resources.iResources.key_login).ToBitmap

        ModeCase0.Image = COC.PuplationIco(My.Resources.iResources.Product_For_Oracle).ToBitmap
        ModeCase0.ImageAlign = ContentAlignment.TopCenter

        ModeCase1.Image = COC.PuplationIco(My.Resources.iResources.Product_For_Postgresql).ToBitmap
        ModeCase1.ImageAlign = ContentAlignment.TopCenter

        ModeCase2.Image = COC.PuplationIco(My.Resources.iResources.Product_Data_Migration).ToBitmap
        ModeCase2.ImageAlign = ContentAlignment.TopCenter

        ModeCase3.Image = COC.PuplationIco(My.Resources.iResources.Product_Sql_Name_Mapper).ToBitmap
        ModeCase3.ImageAlign = ContentAlignment.TopCenter

        ModeCase4.Image = COC.PuplationIco(My.Resources.iResources.Product_Ansi_Join_converter).ToBitmap
        ModeCase4.ImageAlign = ContentAlignment.TopCenter

        ModeCase5.Image = COC.PuplationIco(My.Resources.iResources.Product_Crud_Analysor).ToBitmap
        ModeCase5.ImageAlign = ContentAlignment.TopCenter

        ModeCase6.Image = COC.PuplationIco(My.Resources.iResources.Product_Sql_Extractor).ToBitmap
        ModeCase6.ImageAlign = ContentAlignment.TopCenter

        ModeCase7.Image = COC.PuplationIco(My.Resources.iResources.Product_For_MM).ToBitmap
        ModeCase7.ImageAlign = ContentAlignment.TopCenter

        Try
            LicenseRTB.LoadFile("License.rtf")
        Catch ex As Exception
            LicenseRTB.Text = "라이센스 파일을 찾을수 없습니다!"
        End Try

        ModeCase0.Enabled = False
        ModeCase1.Enabled = False
        ModeCase2.Enabled = False
        ModeCase3.Enabled = False
        ModeCase4.Enabled = False
        ModeCase5.Enabled = False
        ModeCase6.Enabled = False
        ModeCase7.Enabled = False

    End Sub

    Private Sub frmCertification_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        CertiPw.Focus()
        MsgTSSL.Text = "iDAST 인증 패스워드를 입력하세요."
    End Sub

    Private Sub CertiPw_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CertiPw.GotFocus
        COC.TxBSelAllGotFocus(Me, CertiPw.TextBox)
    End Sub

    Private Sub ModeCase0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCase0.Click
        'Oracle
        Try
            StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(0, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Private Sub ModeCase1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCase1.Click
        'Tibero
        Try
            'Dim program1 As String = "iDast.MonTibero.exe"
            'StartProgram(program1, ConformPW & " " & iDastGlobal.iDAST_ProgramType(8, 0))
            StartProgram(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "iDast.MonTibero.exe"), ConformPW & " " & iDastGlobal.iDAST_ProgramType(8, 0))
            'StartProgram(program2, ConformPW & " " & iDastGlobal.iDAST_ProgramType(8, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Private Sub ModeCase2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCase2.Click
        Try
            StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(2, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub ModeCase3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCase3.Click
        Try
            StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(3, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub ModeCase4_Click(sender As Object, e As EventArgs) Handles ModeCase4.Click
        Try
            StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(4, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub ModeCase5_Click(sender As Object, e As EventArgs) Handles ModeCase5.Click
        Try
            StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(5, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub ModeCase6_Click(sender As Object, e As EventArgs) Handles ModeCase6.Click
        Try
            StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(6, 0))
        Catch ex As Exception
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub ModeCase7_Click(sender As Object, e As EventArgs) Handles ModeCase7.Click
        Try


            StartProgram(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "DX.Meta.exe"), ConformPW & " " & iDastGlobal.iDAST_ProgramType(7, 0))
            'StartProgram(Program, ConformPW & " " & iDastGlobal.iDAST_ProgramType(7, 0))



        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            MsgBox("Not Found Program Instance!", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub CertiPw_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CertiPw.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            OkBt.PerformClick()
        End If
    End Sub

    Private Sub StartProgram(ByVal pProgram As String, ByVal pCommandLine As String)
        Process.Start(pProgram, pCommandLine)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ModeCase0_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase0.MouseEnter
        SetMsg("Oracle 데이터베이스 모니터링과 관리를 위한 솔루션입니다.")
    End Sub

    Private Sub ModeCase0_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase0.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase1_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase1.MouseEnter
        SetMsg("Tibero 데이터베이스 모니터링과 관리를 위한 솔루션입니다.")
    End Sub

    Private Sub ModeCase1_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase1.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase2_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase2.MouseEnter
        SetMsg("Data Migration 솔루션입니다.")
    End Sub

    Private Sub ModeCase2_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase2.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase3_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase3.MouseEnter
        SetMsg("SQL Name Mapper 솔루션 입니다.")
    End Sub

    Private Sub ModeCase3_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase3.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase4_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase4.MouseEnter
        SetMsg("Ansi Join Converter 솔루션 입니다.")
    End Sub

    Private Sub ModeCase4_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase4.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase5_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase5.MouseEnter
        SetMsg("CRUD&SQL Analysor 솔루션 입니다.")
    End Sub

    Private Sub ModeCase5_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase5.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase6_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase6.MouseEnter
        SetMsg("SQL Extractor On Source 솔루션 입니다.")
    End Sub

    Private Sub ModeCase6_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase6.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

    Private Sub ModeCase7_MouseEnter(sender As Object, e As EventArgs) Handles ModeCase7.MouseEnter
        SetMsg("Meta System 솔루션 입니다.")
    End Sub

    Private Sub ModeCase7_MouseLeave(sender As Object, e As EventArgs) Handles ModeCase7.MouseLeave
        SetMsg("프로그램을 시작합니다.")
    End Sub

End Class