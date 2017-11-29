Imports System.Security
Imports System.IO
Imports System.Management
Imports System.Text


Imports Microsoft.Win32


Public Class frmLicense

    Private CLV As New clsLicenseVali
    Public isCheck As Boolean = False

    Dim Par_SecurityK As String = String.Empty
    Dim Par_productC As Integer = 0

    Dim par_regYN As Boolean
    Dim par_netcheck As Boolean

    Public Sub New(ByVal strSecurityKey As String, ByVal ProductCode As Integer, ByVal regYN As Boolean)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        Par_SecurityK = strSecurityKey
        Par_productC = ProductCode

        par_regYN = regYN
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        If (regYN) Then

            Dim Reg_SERL As String = CLV.Get_SERL("WebCash1", Par_productC)
            Dim NM As String = ""
            If (Reg_SERL <> "") Then
                Dim Array_SERL As String() = Reg_SERL.Split("|")
                NM = Array_SERL(2)
            End If

            Dim sb As New StringBuilder()
            Dim Reg_DXP_EXPDT As String = CLV.Get_EXPDT("WebCash1", Par_productC)

            sb.Append(vbNewLine)
            sb.Append("이 소프트웨어는 다음 사용자에게 사용이 허가되었습니다. " & vbNewLine)
            sb.Append(NM & " 님" & vbNewLine)
            sb.Append(vbNewLine)
            sb.Append("만료날짜는 " & Reg_DXP_EXPDT.Substring(0, 4) & "년 " & Reg_DXP_EXPDT.Substring(4, 2) & "월 " & Reg_DXP_EXPDT.Substring(6, 2) & "일 입니다." & vbNewLine)

            LicenseNote.Text = sb.ToString()
        Else


        End If

    End Sub

    Public Sub New(ByVal strSecurityKey As String, ByVal ProductCode As Integer, ByVal regYN As Boolean, ByVal netcheck As Boolean)

        ' 이 호출은 디자이너에 필요합니다.
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        InitializeComponent()

        Try

            Par_SecurityK = strSecurityKey
            Par_productC = ProductCode
            par_regYN = regYN
            par_netcheck = netcheck

            '활성화여부
            If (regYN) Then
                '활성화상태

                Dim Reg_SERL As String = CLV.Get_SERL("WebCash1", Par_productC)
                Dim NM As String = ""
                If (Reg_SERL <> "") Then
                    Dim Array_SERL As String() = Reg_SERL.Split("|")
                    NM = Array_SERL(2)
                End If

                Dim sb As New StringBuilder()
                Dim Reg_DXP_EXPDT As String = CLV.Get_EXPDT("WebCash1", Par_productC)

                'sb.Append(vbNewLine)
                sb.Append("이 소프트웨어는 다음 사용자에게 사용이 허가되었습니다. " & vbNewLine)
                sb.Append(NM & " 님" & vbNewLine)
                sb.Append(vbNewLine)
                sb.Append("만료날짜는 " & Reg_DXP_EXPDT.Substring(0, 4) & "년 " & Reg_DXP_EXPDT.Substring(4, 2) & "월 " & Reg_DXP_EXPDT.Substring(6, 2) & "일 입니다." & vbNewLine)
                LicenseNote.Text = sb.ToString()

                GroupBox4.Location = New System.Drawing.Point(7, 7)
                GroupBox4.Size = New System.Drawing.Size(499, 86)

                LicenseNote.Location = New System.Drawing.Point(13, 23)
                '     LicenseNote.Size = New System.Drawing.Size(471, 156)

                gubSerialKey.Location = New System.Drawing.Point(8, 102)
                gubSerialKey.Size = New System.Drawing.Size(499, 183)

                gubActive.Location = New System.Drawing.Point(8, 294)
                gubActive.Size = New System.Drawing.Size(499, 61)

                Me.Size = New System.Drawing.Size(530, 402)



                If (netcheck) Then
                    '온라인상태
                    lblEmail.Visible = False
                    LinkLabel1.Visible = False

                    gubActive.Visible = False
                    btnReqActiveCreate.Text = "제품활성화요청"
                    btnActiveBe.Text = "활성화이전요청"
                Else
                    '오프라인상태

                End If


            Else
                '비활성화상태

                If (netcheck) Then
                    '온라인상태
                    lblEmail.Visible = False
                    LinkLabel1.Visible = False
                    gubActive.Visible = False
                    btnReqActiveCreate.Text = "제품활성화요청"
                    btnActiveBe.Text = "활성화이전요청"

                    Dim sb As New StringBuilder()
                    sb.Append(vbNewLine)
                    sb.Append("온라인 상태에서의 인증방법 안내 " & vbNewLine)
                    sb.Append(vbNewLine)
                    sb.Append("1. 구매시 받은 Serial Key를 입력합니다." & vbNewLine)
                    sb.Append(vbNewLine)
                    sb.Append("2. 업체명,사용자,E-mail,연락처를 입력합니다." & vbNewLine)
                    sb.Append(vbNewLine)
                    sb.Append("3. 제품활성화요청버튼을 클릭합니다." & vbNewLine)
                    sb.Append(vbNewLine)
                    sb.Append("4. 인증절차가 마무리되면 만료날짜가 변경됩니다." & vbNewLine)
                    LicenseNote.Text = sb.ToString()

                    GroupBox4.Location = New System.Drawing.Point(7, 7)
                    GroupBox4.Size = New System.Drawing.Size(499, 143)

                    LicenseNote.Location = New System.Drawing.Point(13, 13)

                    gubSerialKey.Location = New System.Drawing.Point(8, 156)
                    gubSerialKey.Size = New System.Drawing.Size(499, 155)

                    Me.Size = New System.Drawing.Size(530, 359)

                Else
                    '오프라인상태(이상태는 현재 폼배치상태임)
                    'Dim OffLineStr As New StringBuilder()
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("오프라인 상태에서의 인증방법 안내 " & vbNewLine)
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("1. 구매시 받은 Serial Key를 입력합니다. " & vbNewLine)
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("2. 업체명,사용자,E-mail,연락처를 입력합니다. " & vbNewLine)
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("3. 활성화요청코드생성 버튼을 클릭합니다. " & vbNewLine)
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("4. 다운받은파일을 메일이 가능한 PC에서 아래의 메일로 보내주십시요 " & vbNewLine)
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("5. 검토후 활성화코드를 보내드립니다. " & vbNewLine)
                    'OffLineStr.Append(vbNewLine)
                    'OffLineStr.Append("6. 회신받은 활성화코드를 넣고 제품활성화버튼을 클릭하면 인증절차가 마무리 됩니다. " & vbNewLine)
                    'LicenseNote.Text = OffLineStr.ToString()

                End If

            End If

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.StartPosition = Windows.Forms.FormStartPosition.CenterParent
            Me.MaximizeBox = False

        Catch ex As Exception
            MsgBox("등록화면에서 오류가 발생하였습니다.", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub frmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim Reg_SERL As String = CLV.Get_SERL("WebCash1", Par_productC)

        If (Reg_SERL <> "") Then

            Dim Array As String() = Reg_SERL.Split("|")

            If (Array.Count = 5) Then
                If (Not Reg_SERL.Equals(String.Empty)) Then
                    'MaskSerialKey.Text = Array(0)
                    txtCompanyNM.Text = Array(1)
                    txtUserNM.Text = Array(2)
                    txtEmail.Text = Array(3)
                    txtPhoneNO.Text = Array(4)
                    ' MaskSerialKey.Enabled = False
                End If
            End If

            End If
        Catch ex As Exception

        End Try

    End Sub


    '시리얼키 유효성검사
    Private Function RunRndCheckDigit(ByRef strValue As String) As Boolean
        Dim RndNo As String = strValue.Substring(strValue.Length - 4, 2)
        Dim ChkValue As String = strValue.Substring(strValue.Length - 2, 2)

        Dim Chrs() As Char = strValue.ToCharArray
        Dim totInt As Integer = 0
        For i As Integer = 0 To Chrs.Length - 3
            totInt += AscW(Chrs(i))
        Next
        If totInt Mod CInt(RndNo) = ChkValue Then
            strValue = strValue.Substring(0, strValue.Length - 4)
            Return True
        Else
            Return False
        End If
    End Function

    '시리얼,입력내용 체크
    Private Function SerialNO_check() As Boolean
        Try

            '-----------------------------------------------------------------------------
            '제품코드 체크
            Dim strvalue As String = MaskSerialKey.Text.Replace("-", "")
            Dim proId As String = strvalue.Substring(0, 2) & strvalue.Substring(4, 2) & strvalue.Substring(2, 1)
            If (Not CLV.ProductCdCheck(Par_productC, proId)) Then
                MsgBox("제품코드가 일치하지 않습니다.", MsgBoxStyle.Critical, "에러")
                Return False
            End If
            '-----------------------------------------------------------------------------


            '------------------------------------------------------------------------------
            '시리얼코드 체크
            If strvalue.Length <> 20 Then
                MsgBox("올바른 시리얼 번호가 아닙니다.", MsgBoxStyle.Critical, "에러")
                Return False
            End If

            If strvalue.Length = 20 Then
                If RunRndCheckDigit(strvalue) = False Then
                    MsgBox("올바른 시리얼 번호가 아닙니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If

                If RunRndCheckDigit(strvalue) = False Then
                    MsgBox("올바른 시리얼 번호가 아닙니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            Else
                MsgBox("시리얼 번호가 적합하지 않습니다.", MsgBoxStyle.Critical, "에러")
                Return False
            End If
            '------------------------------------------------------------------------------


            '------------------------------------------------------------------------------
            '입력문자체크
            If (txtCompanyNM.Text.Length <> 0) And (txtCompanyNM.Text <> "") Then
                If (txtCompanyNM.Text.Contains("|")) Then
                    MsgBox("[업체명] 사용하실수 없는 문자입니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            Else
                MsgBox("[업체명] 을 입력해주십시요", MsgBoxStyle.Critical, "에러")
                Return False
            End If
            If (txtUserNM.Text.Length <> 0) And (txtUserNM.Text <> "") Then
                If (txtUserNM.Text.Contains("|")) Then
                    MsgBox("[사용자] 사용하실수 없는 문자입니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            Else
                MsgBox("[사용자] 를 입력해주십시요", MsgBoxStyle.Critical, "에러")
                Return False
            End If

            If (txtEmail.Text.Length <> 0) And (txtEmail.Text <> "") Then
                If (txtEmail.Text.Contains("|")) Then
                    MsgBox("[E-mail] 사용하실수 없는 문자입니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            Else
                MsgBox("[E-mail] 를 입력해주십시요", MsgBoxStyle.Critical, "에러")
                Return False
            End If

            If (txtPhoneNO.Text.Length <> 0) And (txtPhoneNO.Text <> "") Then
                If (txtPhoneNO.Text.Contains("|")) Then
                    MsgBox("[연락처] 사용하실수 없는 문자입니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            Else
                MsgBox("[연락처] 를 입력해주십시요", MsgBoxStyle.Critical, "에러")
                Return False
            End If
            '------------------------------------------------------------------------------

     
            Return True
        Catch ex As Exception
            MsgBox("인증요청이 실패하였습니다.", MsgBoxStyle.Critical, "에러")
            Return False
        End Try


    End Function

    '활성화요청코드생성 / 활성화요청
    Private Sub btnReqActiveCreate_Click(sender As Object, e As EventArgs) Handles btnReqActiveCreate.Click
        Try

            '시리얼키 유효성검사
            If (SerialNO_check() = False) Then
                Return
            End If

            ' 여기서 다시 하드 비교하고, 설치날짜 비교하는게 맞을꺼같음 그리고 
            ' 오늘날짜로 들어가지는데 이거를 설치날짜로 바꿔서 넣어야 될꺼같음.
            ' 요청날짜는 온라인이면 DB에 들어간 날짜일꺼고, 오프라인이면 메일이나 .dat파일 생성날짜일텐데 굳이 필요없을꺼같음.
            ' 그리고 활성화코드에서도 설치날짜를 비교하게끔 로직 추가하기....


            If (CLV.HDID_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (하드일련번호)", MsgBoxStyle.Critical, "에러")
                Return
            End If

            If (CLV.SETDT_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (설치일자)", MsgBoxStyle.Critical, "에러")
                Return
            End If

            If (CLV.EXPDT_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (만료일자)", MsgBoxStyle.Critical, "에러")
                Return
            End If
            '--------------------------------------------------------------------------------------

            If (CLV.RUNDT_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("최종실행일자 유효성 체크 실패 (최종실행일자)", MsgBoxStyle.Critical, "에러")
                Return
            End If



            Dim LOCAL_HDID As String = CLV.GetVolumeSerialNumber("C")
            Dim ReqDT As String = DateTime.Now.ToString("yyyyMMdd")
            Dim clsSeq As New clsSecurity(Par_SecurityK)
            Dim strvalue As String = MaskSerialKey.Text.Replace("-", "")
            Dim proId As String = strvalue.Substring(0, 2) & strvalue.Substring(4, 2) & strvalue.Substring(2, 1)
            Dim ReqActiveCD As String = clsSeq.Encrypt(MaskSerialKey.Text & "|" & LOCAL_HDID & "|" & proId & "|" & ReqDT & "|" & txtCompanyNM.Text & "|" & txtUserNM.Text & "|" & txtEmail.Text & "|" & txtPhoneNO.Text)


            If (par_netcheck) Then
                '온라인상태

                OnlineLicense(ReqActiveCD, "ACTIVATE")


            Else
                '오프라인
                '혹시몰라서 클립보드에 저장하게 해놨음
                System.Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.Text, CType(ReqActiveCD, Object))
                Dim sb As New StringBuilder()
                sb.Append(ReqActiveCD)
                sb.Append(vbNewLine)


                Dim fdg As New System.Windows.Forms.SaveFileDialog
                fdg.Filter = "dat 파일 (*.dat)|*.dat"
                If fdg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim strFIleNm As String = fdg.FileName

                    If System.IO.File.Exists(strFIleNm) = True Then
                        System.IO.File.Delete(strFIleNm)
                    End If

                    Dim b As New System.IO.StreamWriter(strFIleNm)
                    b.Write(sb)
                    b.Flush()
                    b.Close()

                    MsgBox(strFIleNm & " 생성 완료", MsgBoxStyle.Information, "파일생성")
                    'System.Diagnostics.Process.Start("explorer", strFIleNm)
                    CLV.Set_SERL(Par_SecurityK, Par_productC, MaskSerialKey.Text & "|" & txtCompanyNM.Text & "|" & txtUserNM.Text & "|" & txtEmail.Text & "|" & txtPhoneNO.Text)
                    CLV.Set_HDID(Par_SecurityK, Par_productC, LOCAL_HDID)
                End If

            End If

        Catch ex As Exception
            MsgBox("인증에 실패하였습니다.", MsgBoxStyle.Critical, "에러")
            Return
        End Try

    End Sub

    '이전코드생성 / 이전코드
    Private Sub btnActiveBe_Click(sender As Object, e As EventArgs) Handles btnActiveBe.Click
        Try

            If (SerialNO_check() = False) Then
                Return
            End If

            Dim LOCAL_HDID As String = CLV.GetVolumeSerialNumber("C")
            Dim ReqDT As String = DateTime.Now.ToString("yyyyMMdd")
            Dim clsSeq As New clsSecurity(Par_SecurityK)
            Dim strvalue As String = MaskSerialKey.Text.Replace("-", "")
            Dim proId As String = strvalue.Substring(0, 2) & strvalue.Substring(4, 2) & strvalue.Substring(2, 1)
            Dim ReqActiveCD As String = clsSeq.Encrypt(MaskSerialKey.Text & "|" & LOCAL_HDID & "|" & proId & "|" & ReqDT & "|" & txtCompanyNM.Text & "|" & txtUserNM.Text & "|" & txtEmail.Text & "|" & txtPhoneNO.Text)


            If (par_netcheck) Then
                OnlineLicense(ReqActiveCD, "DEACTIVATE")


            Else
                '오프라인
                '혹시몰라서 클립보드에 저장하게 해놨음
                System.Windows.Forms.Clipboard.SetData(System.Windows.Forms.DataFormats.Text, CType(ReqActiveCD, Object))
                Dim sb As New StringBuilder()
                sb.Append(ReqActiveCD)
                sb.Append(vbNewLine)


                Dim fdg As New System.Windows.Forms.SaveFileDialog
                fdg.Filter = "dat 파일 (*.dat)|*.dat"
                If fdg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim strFIleNm As String = fdg.FileName

                    If System.IO.File.Exists(strFIleNm) = True Then
                        System.IO.File.Delete(strFIleNm)
                    End If

                    Dim b As New System.IO.StreamWriter(strFIleNm)
                    b.Write(sb)
                    b.Flush()
                    b.Close()

                    MsgBox(strFIleNm & " 생성 완료", MsgBoxStyle.Information, "파일생성")
                    'System.Diagnostics.Process.Start("explorer", strFIleNm)

                    CLV.Set_SERL(Par_SecurityK, Par_productC, MaskSerialKey.Text & "|" & txtCompanyNM.Text & "|" & txtUserNM.Text & "|" & txtEmail.Text & "|" & txtPhoneNO.Text)
                    CLV.Set_HDID(Par_SecurityK, Par_productC, LOCAL_HDID)
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    '온라인 활성화요청. 이전코드요청
    Private Sub OnlineLicense(ByVal ReqActiveCD As String, ByVal ACTGUBUN As String)


        Try


            Dim result As System.Net.WebResponse = Nothing

            ' Dim url As String = "http://www.mkex.pe.kr/test.aspx"
            ' Dim url As String = "http://172.20.50.48:9090/admin/activateLicense.act"

            '운영
            'Dim url As String = "https://www.dataexper.co.kr/admin/activateLicense.act"

            '개발
            Dim url As String = "http://172.20.50.48:9090/admin/activateLicense.act"


            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"

            Dim urlencodeStr As String = Uri.EscapeDataString(ReqActiveCD)

            '전달할 파라메타    
            Dim sendData As String = String.Format("MODE={0}&REQCODE={1}", ACTGUBUN, urlencodeStr)
            ' HttpUtility.UrlEncode(sendData, System.Text.Encoding.GetEncoding("UTF-8"))


            Dim buffer As Byte()
            buffer = System.Text.Encoding.[Default].GetBytes(sendData)
            'buffer = System.Text.Encoding.[Default].GetBytes(Uri.EscapeDataString(sendData))
            request.ContentLength = buffer.Length
            Dim sendStream As System.IO.Stream = request.GetRequestStream()
            sendStream.Write(buffer, 0, buffer.Length)
            sendStream.Close()

            result = request.GetResponse
            Dim ReceiveStream As System.IO.Stream = result.GetResponseStream()
            Dim encode As System.Text.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(ReceiveStream, encode)

            Dim read() As Char = New Char((256) - 1) {}
            Dim count As Integer = sr.Read(read, 0, 256)
            ' Console.WriteLine("HTML..." & vbCrLf)
            Dim redstream As String = ""

            While (count > 0)
                Dim str As String = New String(read, 0, count)
                redstream += str
                count = sr.Read(read, 0, 256)

            End While
            '시간계산해서 오래걸리면 끊기
            Dim col As String() = redstream.Replace("{", "").Replace("}", "").Replace("""", "").Split(","c)
            Dim isActive As String() = col(0).Split(":"c)
            Dim ActivateCode As String() = col(1).Split(":"c)

            'MsgBox(isActive(0) & " " & isActive(1) & " " & ActivateCode(0) & " " & ActivateCode(1))


            If (isActive(1) = "N") Then
                MsgBox("인증에 실패하였습니다.", MsgBoxStyle.Critical, "에러")
            Else
                CLV.Set_SERL(Par_SecurityK, Par_productC, MaskSerialKey.Text & "|" & txtCompanyNM.Text & "|" & txtUserNM.Text & "|" & txtEmail.Text & "|" & txtPhoneNO.Text)
                Dim LOCAL_HDID As String = CLV.GetVolumeSerialNumber("C")
                CLV.Set_HDID(Par_SecurityK, Par_productC, LOCAL_HDID)

                ProductActive(ActivateCode(1))
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    '제품활성화 오프라인 전용
    Private Sub btnProductActive_Click(sender As Object, e As EventArgs) Handles btnProductActive.Click
        If (Not par_netcheck) Then

            If (Not txtActiveCD.Text.Equals(String.Empty)) Then
                ProductActive(txtActiveCD.Text)
            Else
                MsgBox("활성화 코드를 입력해주십시요", MsgBoxStyle.Critical, "에러")
            End If



        End If
    End Sub

    '제품활성화키 유효성검사.
    Private Sub ProductActive(ByVal ActiveCD As String)
        Try

            If (CLV.HDID_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (하드일련번호)", MsgBoxStyle.Critical, "에러")
                Return
            End If

            If (CLV.SETDT_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (설치일자)", MsgBoxStyle.Critical, "에러")
                Return
            End If

            If (CLV.EXPDT_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (만료일자)", MsgBoxStyle.Critical, "에러")
                Return
            End If
            '--------------------------------------------------------------------------------------

            If (CLV.RUNDT_Check(Par_SecurityK, Par_productC) = False) Then
                MsgBox("최종실행일자 유효성 체크 실패 (최종실행일자)", MsgBoxStyle.Critical, "에러")
                Return
            End If


            Dim Reg_HDID As String = CLV.Get_HDID("WebCash1", Par_productC)
            Dim Reg_SERL As String = CLV.Get_SERL("WebCash1", Par_productC)
            Dim serl As String = ""
            If (Reg_SERL <> "") Then
                Dim Array_SERL As String() = Reg_SERL.Split("|")
                serl = Array_SERL(0)
            Else
                MsgBox("등록된 시리얼번호가 없습니다.", MsgBoxStyle.Critical, "에러")
                Return
            End If

            Dim clsSeq2 As New clsSecurity("WebCash2")
            Dim reqlis As String = clsSeq2.Decrypt(ActiveCD)

            ' MsgBox(reqlis)
            Dim Array As String() = reqlis.Split("|")

            If (serl <> Array(0)) Then
                ' 시리얼 번호 체크
                MsgBox("시리얼번호가 일치하지 않습니다.", MsgBoxStyle.Critical, "에러")
                Return
            End If

            If (Reg_HDID <> Array(1)) Then
                ' 시리얼 번호 체크
                MsgBox("하드정보가 일치하지 않습니다.", MsgBoxStyle.Critical, "에러")
                Return
            End If

            '검증이 완료되면 만료일자를 변경시켜준다.

            CLV.Set_EXPDT(Par_SecurityK, Par_productC, Array(8))

            isCheck = True
            MsgBox("인증완료되었습니다.", MsgBoxStyle.Information, "인증완료")

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            isCheck = False
            MsgBox("인증에 실패하였습니다.", MsgBoxStyle.Critical, "에러")
            Return
        Finally

        End Try
    End Sub

    Private Sub txtPhoneNO_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtPhoneNO.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Convert.ToChar(System.Windows.Forms.Keys.Back)) Then

            If (Not e.KeyChar = "-"c) Then
                e.Handled = True
            End If

        End If
    End Sub
End Class