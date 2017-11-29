Imports System.Data
''' <summary>
''' XML을 내부의 데이터셋으로 저장한다  PARAMS의 항목이 반드시 있어야함. 
''' </summary>
''' <remarks></remarks>
Public Class clsXmlData

    ''' <summary>
    ''' 클래스 내부 전용 데이터 테이블
    ''' </summary>
    ''' <remarks></remarks>
    Private _dtData As DataTable = Nothing

    ''' <summary>
    ''' 내부에서 키로 사용할 필드명 
    ''' </summary>
    ''' <remarks></remarks>
    Private _KeyField As String = String.Empty

    ''' <summary>
    ''' 내부에서 데이터로 내보낼 필드명 
    ''' </summary>
    ''' <remarks></remarks>
    Private _DataField As String = String.Empty
    ''' <summary>
    ''' 생성자
    ''' </summary>
    ''' <param name="FileNm">XML파일 경로</param>
    ''' <param name="KeyField">키로사용할 필드</param>
    ''' <param name="DataField">데이터로 사용할 필드</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal FileNm As String, Optional ByVal KeyField As String = "ID", Optional ByVal DataField As String = "DATA")
        Try

        
            If System.IO.File.Exists(FileNm) Then
                Dim dtSet As New DataSet
                dtSet.ReadXml(FileNm)
                If dtSet.Tables(0) IsNot Nothing Then
                    _dtData = dtSet.Tables(0)
                End If

            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try
        _KeyField = KeyField
        _DataField = DataField

    End Sub
    ''' <summary>
    ''' 생성자
    ''' </summary>
    ''' <param name="txtReader">String형태의 경우 TextReader형태로 전달</param>
    ''' <param name="KeyField">키로사용할 필드`</param>
    ''' <param name="DataField">데이터로 사용할 필드</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal txtReader As System.IO.TextReader, Optional ByVal KeyField As String = "ID", Optional ByVal DataField As String = "DATA")
        Try

        
            Dim dtSet As New DataSet
            dtSet.ReadXml(txtReader)
            If dtSet.Tables(0) IsNot Nothing Then
                _dtData = dtSet.Tables(0)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try

        _KeyField = KeyField
        _DataField = DataField

    End Sub
    ''' <summary>
    ''' 키로사용할 필드 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property KeyField As String
        Get
            Return _KeyField
        End Get
        Set(value As String)
            _KeyField = value
        End Set
    End Property
    ''' <summary>
    ''' 데이터로 사용할 필드
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property DataField As String
        Get
            Return _DataField
        End Get
        Set(value As String)
            _DataField = value
        End Set
    End Property
     
    ''' <summary>
    ''' 설정된 데이터의 값을 가져온다. 
    ''' </summary>
    ''' <param name="Code">키로검색되는 항목</param>
    ''' <param name="Params">문자열 자동변경하여줌. Params 설정과 동일해야함. </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fn_GetData(ByVal Code As String, ByVal ParamArray Params() As String) As String
        Try


            If _dtData IsNot Nothing Then
                Dim dtRows As DataRow() = _dtData.Select(_KeyField & "='" & Code & "'")
                If dtRows IsNot Nothing AndAlso dtRows.Count > 0 Then
                    ' 숫자형식이므로 Null일 경우 0 을 반환 하고 문자일 경우도 0으로 만들어 준다. 
                    Dim intParamCnt As Integer = 0
                    If _dtData.Columns("PARAMS") IsNot Nothing Then
                        intParamCnt = IIf(IsDBNull(dtRows(0).Item("PARAMS")), 0, IIf(IsNumeric(dtRows(0).Item("PARAMS")), dtRows(0).Item("PARAMS"), 0))
                    End If

                    Dim strMsgData As String = dtRows(0).Item(_DataField)
                    If strMsgData <> "" Then
                        strMsgData = strMsgData.Replace("\n", Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
                        If intParamCnt <= 0 OrElse Not Params.Count.Equals(intParamCnt) Then
                            Return strMsgData
                        Else
                            Return String.Format(strMsgData, Params)
                        End If
                    Else
                        Return ""
                    End If
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try
        Return ""
    End Function

    Public Function fn_GetSpecificData(ByVal Code As String, ByVal ReturnField As String) As String
        Try


            If _dtData IsNot Nothing Then
                Dim dtRows As DataRow() = _dtData.Select(_KeyField & "='" & Code & "'")
                If dtRows IsNot Nothing AndAlso dtRows.Count > 0 Then
                    Dim strMsgData As String = dtRows(0).Item(ReturnField)
                    strMsgData = strMsgData.Replace("\n", Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
                    If strMsgData <> "" Then
                        Return strMsgData
                    Else
                        Return ""
                    End If
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try
        Return ""
    End Function

End Class
