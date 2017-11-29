Imports System.Management
Imports System.Collections

Public Class clsLicenseVali

    Private CRC As New ClsRegCtl


    Private DX_P() As String = New String() {"META", "MIGR", "MOORA", "MOTIB", "AUTO", "MIGRE", "MIGRS"}
    Private MS_P() As String = New String() {"NETMETA", "NETMIGR", "NETMOORA", "NETMOTIB", "NETAUTO", "NETMIGRE", "NETMIGRS"}
    Private RegStr() As String = New String() {"SETDT", "HDID", "EXPDT", "RUNDT", "SERL"}
    Private RegPath() As String = New String() {"SOFTWARE\\DX", "SOFTWARE\\DX\\", "SOFTWARE\\MICROSOFT\\"}


    Private DX_META_PRODUCT_CD() As String = New String() {"EMT01", "EMT02", "EMT03"}
    Private DX_PRODUCT_CD() As String = New String() {"EMT", "DMR01", "EMO01", "EMO02", "DAU01", "EMR02", "EMR01"}


    'DtSet.Rows.Add("DX-META For Oracle", "EMT01")
    'DtSet.Rows.Add("DX-META For Tibero", "EMT02")
    'DtSet.Rows.Add("DX-META For PostgreSQL", "EMT03")
    'DtSet.Rows.Add("DX-MIGRATOR", "DMR01")
    'DtSet.Rows.Add("DX-MONITORING For Oracle", "DMO01")
    'DtSet.Rows.Add("DX-MONITORING For Tibero", "DMO02")
    'DtSet.Rows.Add("DX-D'AUTO", "DAU01")



    ''' <summary>
    ''' ABCD
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum eRegCode
        SETDT = 0 '셋팅날짜
        HDID = 1 '하드정보
        EXPDT = 2 '만료날짜
        RUNDT = 3 '실행일자
        SERL = 4 '시리얼키
    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum eRegPath
        DX_KEY = 0 'DX KEY생성
        DX_P_KEY = 1 'DX 제품키 생성
        MS_P_KEY = 2 '마이크로소프트 제풐키 생성
    End Enum

    'Private Enum ProductCode
    '    META = 0 '메타
    '    MIGR = 1 '마이그레이션
    '    MOORA = 2 '모니터링 오라클
    '    MOTIB = 3 '모니터링 티베로
    '    AUTO = 4 '오토메이션
    'End Enum


    Public Function Get_EXPDT(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As String
        Return CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.EXPDT), strSecurityKey)
    End Function
    Public Function Get_HDID(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As String
        Return CRC.ReadReg(RegPath(eRegPath.DX_KEY) & DX_P(ProductCode), RegStr(eRegCode.HDID), strSecurityKey)
    End Function
    Public Function Get_SERL(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As String
        Return CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.SERL), strSecurityKey)
    End Function


    Public Function Get_SETDT(ByVal strSecurityKey As String) As String
        Return CRC.ReadReg(RegPath(eRegPath.DX_KEY), RegStr(eRegCode.SETDT), strSecurityKey)
    End Function

    Public Sub Set_SERL(ByVal strSecurityKey As String, ByVal ProductCode As Integer, ByVal sValue As String)
        CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.SERL), sValue, strSecurityKey)
    End Sub

    Public Sub Set_HDID(ByVal strSecurityKey As String, ByVal ProductCode As Integer, ByVal sValue As String)
        CRC.WriteReg(RegPath(eRegPath.DX_KEY) & DX_P(ProductCode), RegStr(eRegCode.HDID), sValue, strSecurityKey)
    End Sub

    Public Sub Set_EXPDT(ByVal strSecurityKey As String, ByVal ProductCode As Integer, ByVal sValue As String)
        CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.EXPDT), sValue, strSecurityKey)
        CRC.WriteReg(RegPath(eRegPath.MS_P_KEY) & MS_P(ProductCode), RegStr(eRegCode.EXPDT), sValue, strSecurityKey)
    End Sub



    ''' <summary>
    ''' 제품코드 체크
    ''' </summary>
    ''' <param name="ProductCode">제풐코드 index</param>
    ''' <param name="prid">비교할 제품코드</param>
    ''' <returns>True 제품코드 일치함 / False 불일치</returns>
    ''' <remarks></remarks>
    Public Function ProductCdCheck(ByVal ProductCode As Integer, ByVal prid As String) As Boolean

        If (ProductCode = 0) Then
            '1 메타이면
            If (Not MetaModel_Check(prid)) Then
                Return False
            End If
        Else
            '2 메타가 아니면
            If (DX_PRODUCT_CD(ProductCode) <> prid) Then
                Return False
            End If
        End If

        Return True

    End Function
    'Meta 제품모델 번호 체크
    Public Function MetaModel_Check(ByVal prid As String) As Boolean
        For Each Str As String In DX_META_PRODUCT_CD
            If (Str.Equals(prid)) Then
                Return True
            End If
        Next Str
        Return False
    End Function



    ''' <summary>
    ''' 활성화 체크
    ''' </summary>
    ''' <param name="strSecurityKey">암호화키</param>
    ''' <param name="ProductCode">제품코드 index</param>
    ''' <returns>True 활성화됨 / False 활성화된상태가 아님 trial version임. </returns>
    ''' <remarks></remarks>
    Public Function EXP_Check(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As Boolean

        '등록창 띄울때는
        Try
            Dim Reg_DXP_EXPDT As String = Get_EXPDT(strSecurityKey, ProductCode)
            Dim Reg_HDID As String = Get_HDID(strSecurityKey, ProductCode)
            Dim Reg_SERL As String = Get_SERL(strSecurityKey, ProductCode)
            ' Dim regYN As Boolean = False

            Dim reg_SETDT As String = Get_SETDT("WebCash1")
            If (strdtAdd30days(reg_SETDT).Equals(Reg_DXP_EXPDT)) Then
                Return False
            Else
                If (Not Reg_DXP_EXPDT.Equals(String.Empty) And Not Reg_HDID.Equals(String.Empty) And Not Reg_SERL.Equals(String.Empty)) Then
                    Return True
                End If
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try

    End Function

    ''' <summary>
    ''' 하드정보체크
    ''' </summary>
    ''' <param name="strSecurityKey">암호화키</param>
    ''' <param name="ProductCode">제품코드 index</param>
    ''' <returns>True 정보 맞음.</returns>
    ''' <remarks>하드정보체크</remarks>
    Public Function HDID_Check(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As Boolean
        '******************************************************************************************************
        '* INSTALL 시 RegHDID 값과 프로그램 실행했을시 HDID값을 비교
        '******************************************************************************************************
        Dim Reg_HDID As String = CRC.ReadReg(RegPath(eRegPath.DX_KEY), RegStr(eRegCode.HDID), strSecurityKey)
        Dim LOCAL_HDID As String = GetDeviceSerialNumber("C") 'GetVolumeSerialNumber("C")
        If (Reg_HDID <> LOCAL_HDID) Then
            Return False
        End If
        Return True
    End Function

    Public Function GetDeviceSerialNumber(ByVal Drive As String) As String

        Dim DeviceSerialNumber As String = String.Empty
        Try
            Dim Searcher As New ManagementObjectSearcher()
            Dim PrcSrc As ManagementObjectCollection
            Dim Prc As ManagementObject
            'Dim MesStr As String
            Searcher.Query.QueryString = "Select * From Win32_DiskDrive"
            PrcSrc = Searcher.Get
            For Each Prc In PrcSrc
                If (Prc("Index").ToString = "0") Then
                    DeviceSerialNumber = Prc("SerialNumber").ToString.Trim
                End If
                'MesStr = Prc("Index") & "/" & Prc("SerialNumber") & "/" & Prc("DeviceID")
                'MessageBox.Show(MesStr)
            Next
        Catch ex As Exception
            DeviceSerialNumber = GetVolumeSerialNumber(Drive)
        Finally
            If DeviceSerialNumber.Equals(String.Empty) Then
                DeviceSerialNumber = GetVolumeSerialNumber(Drive)
            End If
        End Try

        Return DeviceSerialNumber
    End Function
    ''' <summary>
    ''' 설치일자 체크
    ''' </summary>
    ''' <param name="strSecurityKey">암호화키</param>
    ''' <param name="ProductCode">제품코드 index</param>
    ''' <returns>True 정보 맞음.</returns>
    ''' <remarks>설치일자 체크</remarks>
    Public Function SETDT_Check(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As Boolean
        '******************************************************************************************************
        '* INSTALL시 SETDT값을 비교함.
        '* SETDT 빈공백,8자리,Datetime 유효성검사
        '******************************************************************************************************
        Dim Reg_DX_SETDT As String = CRC.ReadReg(RegPath(eRegPath.DX_KEY), RegStr(eRegCode.SETDT), strSecurityKey)
        Dim Reg_DXP_SETDT As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.SETDT), strSecurityKey)
        Dim Reg_MSP_SETDT As String = CRC.ReadReg(RegPath(eRegPath.MS_P_KEY) & MS_P(ProductCode), RegStr(eRegCode.SETDT), strSecurityKey)

        If Reg_DX_SETDT <> Reg_DXP_SETDT And Reg_DXP_SETDT <> Reg_MSP_SETDT And Reg_DX_SETDT <> Reg_MSP_SETDT Then
            Return False
        End If

        Dim strarr As ArrayList = New ArrayList()
        strarr.Add(Reg_DX_SETDT)
        strarr.Add(Reg_DXP_SETDT)
        strarr.Add(Reg_MSP_SETDT)
        If Date_Check(strarr) = False Then
            Return False
        End If

        Return True
    End Function


    ''' <summary>
    ''' 종료일자 체크
    ''' </summary>
    ''' <param name="strSecurityKey">암호화키</param>
    ''' <param name="ProductCode">제품코드 index</param>
    ''' <returns>True 정보 맞음.</returns>
    ''' <remarks>종료일자 체크</remarks>
    Public Function EXPDT_Check(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As Boolean
        '******************************************************************************************************
        '* INSTALL시 EXPDT값을 비교함.
        '* EXPDT 빈공백,8자리,Datetime 유효성검사
        '******************************************************************************************************
        Dim Reg_DXP_EXPDT As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.EXPDT), strSecurityKey)
        Dim Reg_MSP_EXPDT As String = CRC.ReadReg(RegPath(eRegPath.MS_P_KEY) & MS_P(ProductCode), RegStr(eRegCode.EXPDT), strSecurityKey)

        If (Not Reg_DXP_EXPDT = Reg_MSP_EXPDT) Then
            Return False
        End If

        Dim strarr As ArrayList = New ArrayList()
        strarr.Clear()
        strarr.Add(Reg_DXP_EXPDT)
        strarr.Add(Reg_MSP_EXPDT)

        If Date_Check(strarr) = False Then
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' 실행일자 체크
    ''' </summary>
    ''' <param name="strSecurityKey">암호화키</param>
    ''' <param name="ProductCode">제품코드 index</param>
    ''' <returns>True 정보 맞음.</returns>
    ''' <remarks>실행일자 체크</remarks>
    Public Function RUNDT_Check(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As Boolean

        Dim Reg_DXP_RUNDT As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), strSecurityKey)
        Dim Reg_MSP_RUNDT As String = CRC.ReadReg(RegPath(eRegPath.MS_P_KEY) & MS_P(ProductCode), RegStr(eRegCode.RUNDT), strSecurityKey)
        Dim DtNow = System.DateTime.Now.ToString("yyyyMMdd")


        If (Reg_DXP_RUNDT.Equals(String.Empty) And Reg_MSP_RUNDT.Equals(String.Empty)) Then
            CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), DtNow, strSecurityKey)
            CRC.WriteReg(RegPath(eRegPath.MS_P_KEY) & MS_P(ProductCode), RegStr(eRegCode.RUNDT), Inverse_Date(DtNow), strSecurityKey)
        Else
            'Reg_MSP_RUNDT는 있고 Reg_DXP_RUNDT없으면  Reg_DXP_RUNDT 에 Reg_MSP_RUNDT넣음
            If Not (Reg_MSP_RUNDT.Equals(String.Empty)) And Reg_DXP_RUNDT.Equals(String.Empty) Then
                CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), Inverse_Date(Reg_MSP_RUNDT), strSecurityKey)
            End If

            Dim Reg_DXP_RUNDT_ As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), strSecurityKey)

            Dim strarr As ArrayList = New ArrayList()
            strarr.Clear()
            strarr.Add(Reg_DXP_RUNDT_)
            If Date_Check(strarr) = False Then
                Return False
            End If
        End If

        Return True
    End Function


    '************************************************
    ' LicenseValiation
    '************************************************
    ''' <summary>
    ''' 초기인증체크
    ''' </summary>
    ''' <param name="strSecurityKey"></param>
    ''' <param name="ProductCode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RunCheck(ByVal strSecurityKey As String, ByVal ProductCode As Integer) As Boolean

        Try
            '설치될때 입력됐던 레지스터 값 맞는지 확인

            '--------------------------------------------------------------------------------------
            If (HDID_Check(strSecurityKey, ProductCode) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (하드일련번호)", MsgBoxStyle.Critical, "에러")
                Return False
            End If

            If (SETDT_Check(strSecurityKey, ProductCode) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (설치일자)", MsgBoxStyle.Critical, "에러")
                Return False
            End If

            If (EXPDT_Check(strSecurityKey, ProductCode) = False) Then
                MsgBox("설치정보가 맞지 않습니다. (만료일자)", MsgBoxStyle.Critical, "에러")
                Return False
            End If
            '--------------------------------------------------------------------------------------

            If (RUNDT_Check(strSecurityKey, ProductCode) = False) Then
                MsgBox("최종실행일자 유효성 체크 실패 (최종실행일자)", MsgBoxStyle.Critical, "에러")
                Return False
            End If


            '******************************************************************************************************

            Dim Reg_DXP_RUNDT_ As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), strSecurityKey)
            Dim DtNow = System.DateTime.Now.ToString("yyyyMMdd")
            '최종실행일자가 현재일자보다 크면 오류
            If Reg_DXP_RUNDT_ > DtNow Then
                '시스템 날짜를 변경했거나..
                MsgBox("잘못설치된 프로그램입니다. ", MsgBoxStyle.Critical, "에러")
                Return False
            Else
                '최종사용일자 업데이트
                CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), DtNow, strSecurityKey)
                CRC.WriteReg(RegPath(eRegPath.MS_P_KEY) & MS_P(ProductCode), RegStr(eRegCode.RUNDT), Inverse_Date(DtNow), strSecurityKey)
            End If

            '------------------------------------------------------------------------------

            Dim Reg_DXP_RUNDT_N As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.RUNDT), strSecurityKey)
            Dim Reg_DXP_EXPDT_N As String = CRC.ReadReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), RegStr(eRegCode.EXPDT), strSecurityKey)
            '만료일자보다 최종실행일자가 크면 오류
            If Reg_DXP_EXPDT_N < Reg_DXP_RUNDT_N Then
                MsgBox("잘못설치된 프로그램입니다.", MsgBoxStyle.Critical, "에러")
                ' MenuNaviBar.Visible = False
                Return False
            End If

            '3. 만료일자보다 현재일자가 크면 오류
            If Reg_DXP_EXPDT_N < DtNow Then
                MsgBox("사용기간이 만료되었습니다.", MsgBoxStyle.Critical, "에러")
                ' MenuNaviBar.Visible = False
                Return False
            End If


            '만료일자 최종실행일자 비교
            '만료일자 현재날짜 비교
            '최종실행일자 현재날짜 비교

            ''Reg_DXP_RUNDT가 없으나 MSP_RUNDT가 있고 날짜유효성도 맞으면 현재일자 넣어줌
            'If (Not Reg_MSP_RUNDT.Equals(Reg_MSP_RUNDT)) Then
            '    strarr.Clear()
            '    strarr.Add(Reg_MSP_RUNDT)
            '    If Date_Check(strarr) = True Then
            '        CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), eRegCode.RUNDT, DtNow, strSecurityKey)
            '        CRC.WriteReg(RegPath(eRegPath.MS_P_KEY) & DX_P(ProductCode), eRegCode.RUNDT, Inverse_Date(DtNow), strSecurityKey)
            '    Else
            '        '유효성이 맞지 않으면 

            '    End If
            'End If

            '위에 로직으로 각각 만료일자, 설치일자는 모두 유효하니까
            '가정 Reg_MSP_RUNDT는 삭제되지 않는다는 가정하에

            'Reg_MSP_RUNDT는 있고 Reg_DXP_RUNDT없으면  Reg_DXP_RUNDT 에 Reg_MSP_RUNDT넣음
            'If Not (Reg_MSP_RUNDT.Equals(String.Empty)) And Reg_DXP_RUNDT.Equals(String.Empty) Then
            '    CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), eRegCode.RUNDT, Inverse_Date(Reg_MSP_RUNDT), strSecurityKey)
            'End If
            ''Reg_DXP_RUNDT 는 있고 Reg_MSP_RUNDT 없으면  Reg_MSP_RUNDT 에  Reg_DXP_RUNDT넣음
            'If Not (Reg_DXP_RUNDT.Equals(String.Empty)) And Reg_MSP_RUNDT.Equals(String.Empty) Then
            '    CRC.WriteReg(RegPath(eRegPath.MS_P_KEY) & DX_P(ProductCode), eRegCode.RUNDT, Inverse_Date(Reg_DXP_RUNDT), strSecurityKey)
            'End If

            'Reg_DXP_RUNDT와 Reg_MSP_RUNDT 같지 않으면 Reg_DXP_RUNDT 에 Reg_MSP_RUNDT넣음
            'If Not Reg_DXP_RUNDT.Equals(Reg_MSP_RUNDT) Then
            '    CRC.WriteReg(RegPath(eRegPath.DX_P_KEY) & DX_P(ProductCode), eRegCode.RUNDT, Inverse_Date(Reg_MSP_RUNDT), strSecurityKey)
            'End If


            '2. 실행한 프로그램 DX에서 만료일자, ms 에서 만료일자 확인

            '------------------------------------------------------------------------------
            '------------------------------------------------------------------------------
            '1. 만료일자존재 확인
            'Dim regpath As String = DX_RegPath(regpath.DX_P_KEY) & DX_P(ProductCode)
            'Dim ExpDt As String = clsSeq.Decrypt(CRC.ReadRegistry(regpath, "EXPDT"))
            'If (ExpDt.Equals(String.Empty)) Then
            '    MsgBox("잘못설치된 프로그램입니다. 1 ")
            '    Return False
            'Else
            '    If ExpDt.Length <> 8 Then
            '        MsgBox("잘못설치된 프로그램입니다. 1 " & ExpDt)
            '        Return False
            '    End If
            'End If
            ''------------------------------------------------------------------------------
            '' 2. 최소 수정일자 가져오기, 또는 없으면 등록하기
            '' 최종실행일자 오늘일자로 변경
            'Dim RunDt1 As String = clsSeq.Decrypt(CRC.ReadRegistry("RUNDT"))

            'If (RunDt1.Equals(String.Empty)) Then
            '    '최종사용일자가 없으면 넣어줌
            '    CRC.WriteRegistry("RUNDT", clsSeq.Encrypt(System.DateTime.Now.ToString("yyyyMMdd")))
            'Else
            '    If RunDt1 > System.DateTime.Now.ToString("yyyyMMdd") Then
            '        '시스템 날짜를 변경했거나..
            '        MsgBox("잘못설치된 프로그램입니다. 2 " & RunDt1)
            '        Return False
            '    Else
            '        '최종사용일자 업데이트
            '        CRC.WriteRegistry("RUNDT", clsSeq.Encrypt(System.DateTime.Now.ToString("yyyyMMdd")))
            '    End If
            'End If
            ''------------------------------------------------------------------------------
            ''3. 만료일자 여부확인
            'Dim RunDt2 As String = clsSeq.Decrypt(CRC.ReadRegistry("RUNDT"))
            'If ExpDt < System.DateTime.Now.ToString("yyyyMMdd") Then
            '    MsgBox("사용기간이 만료되었습니다. 3 " & ExpDt)
            '    ' MenuNaviBar.Visible = False
            '    Return False
            'End If

            Return True
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try

    End Function

    '날짜 역순가져오기
    Public Function Inverse_Date(ByVal DtNow As String) As String
        Dim splitChar As Char() = DtNow.ToCharArray()
        Dim strd As String = String.Empty
        For i As Integer = splitChar.Length - 1 To 0 Step -1
            strd += splitChar(i)
        Next
        Return strd
    End Function


    'EXPDT 빈공백,8자리,Datetime 유효성검사
    Public Function Date_Check(ByVal strarr As ArrayList) As Boolean

        For Each Str As String In strarr
            If (Str.Equals(String.Empty)) Then
                Return False
            End If

            If Str.Length <> 8 Then
                Return False
            End If

            Str = Str.Insert(6, "-")
            Str = Str.Insert(4, "-")
            If Not DateTime.TryParse(Str, DateTime.Now) Then
                Return False
            End If
        Next Str

        Return True
    End Function

    '날짜에 30일 추가하는 함수.
    Public Function strdtAdd30days(ByVal strdt As String) As String


        If (strdt.Equals(String.Empty)) Then
            Return ""
        End If
        If strdt.Length <> 8 Then
            Return ""
        End If

        strdt = strdt.Insert(6, "-")
        strdt = strdt.Insert(4, "-")
        Dim dt As New DateTime

        If (DateTime.TryParse(strdt, dt) = False) Then
            Return ""
        End If

        Return dt.AddDays(30).ToString("yyyyMMdd")


    End Function


    '하드정보 가져오기
    Public Function GetVolumeSerialNumber(ByVal Drive As String) As String
        Dim strVolumeSerialNumber As String = String.Empty
        Dim objQuery As New ObjectQuery("SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE Name='" & Drive & ":'")
        Dim mobjSearcher As New ManagementObjectSearcher(objQuery)
        Try
            For Each obj As ManagementObject In mobjSearcher.Get()
                strVolumeSerialNumber = obj("VolumeSerialNumber").ToString()
                Exit For
            Next
        Catch e As Exception
            'MessageBox.Show(e.Message)
            strVolumeSerialNumber = String.Empty
        End Try

        Return strVolumeSerialNumber
    End Function

    '네트워크 체크
    Public Function Net_Check() As Boolean
        Dim p_netcheck As Boolean = False
        'Try
        '    ' If My.Computer.Network.Ping("172.20.50.48") Then
        '    If My.Computer.Network.Ping("www.dataexper.co.kr") Then
        '        p_netcheck = True
        '    Else
        '        p_netcheck = False
        '    End If
        'Catch ex As Exception
        '    p_netcheck = False
        'End Try
        Return p_netcheck
    End Function
End Class
