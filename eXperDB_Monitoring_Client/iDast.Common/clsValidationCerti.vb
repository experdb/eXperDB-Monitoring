Public Class ClsValidationCerti
    Private CCC = New ClsConfigureCtl(iDAST_Cfg)
    Private CC As New ClsCrypt
    Private COC As New ClsObjectCtl

    '********************************************************
    '사용자 인증 전체
    '********************************************************
    Public Function RunCerti(ByRef ExpDate As String, ByVal pPw As String) As Boolean

        Try
            'Dim tmpConf As New ClsConfigure()
            Dim xeValue As String = ClsConfigure.GetValues(ClsConfigure.enumConfig.CertKey)
            '인증여부 취득

            If xeValue = "" Or xeValue Is String.Empty Then
                MsgBox("라이센스 정보를 가져올수 없습니다.", MsgBoxStyle.Critical, "에러")
                Return False
            End If


            '복호화 수행
            xeValue = CC.DecryptString(xeValue, pPw)
            Dim deStr As String() = xeValue.Split(ClsCrypt.FormatDelimeter)
            If xeValue = "" Or xeValue Is String.Empty Then
                MsgBox("패스워드가 불일치합니다.", MsgBoxStyle.Critical, "에러")
                Return False
            End If



            Dim strMACADDR As String = deStr(0)
            Dim strEXPDATE As String = deStr(1)
            Dim strUSEMODE As String = deStr(2)
            Dim strREGDATE As String = deStr(3)

            'Mac Address 검증
            Dim MacAddr_DT As System.Data.DataTable = COC.GetMacAddress()
            Dim ChkYn As Boolean = False
            With MacAddr_DT
                For i As Integer = 0 To .Rows.Count - 1
                    If strMACADDR = .Rows(i).Item(1).ToString Then
                        ChkYn = True
                        Exit For
                    End If
                Next
                If ChkYn = False Then
                    MsgBox("Mac 주소가 불일치합니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            End With

            '만료일검증
            If strEXPDATE <> "UNLIMITED" Then
                If CInt(Format(Now, "yyyyMMdd")) > CInt(strEXPDATE) Then
                    MsgBox("만료일자가 넘었습니다." & vbCrLf & _
                           "다시 라이센스를 부여 받아야 합니다.", MsgBoxStyle.Critical, "에러")
                    Return False
                End If
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "에러")
            Return False
        End Try
    End Function

End Class
