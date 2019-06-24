Namespace My

    ' MyApplication에 대해 다음 이벤트를 사용할 수 있습니다.
    ' 
    ' Startup: 응용 프로그램이 시작되고 시작 폼이 만들어지기 전에 발생합니다.
    ' Shutdown: 모든 응용 프로그램 폼이 닫힌 후에 발생합니다. 이 이벤트는 응용 프로그램이 비정상적으로 종료되는 경우에는 발생하지 않습니다.
    ' UnhandledException: 응용 프로그램에서 처리되지 않은 예외가 발생하는 경우 이 이벤트가 발생합니다.
    ' StartupNextInstance: 단일 인스턴스 응용 프로그램을 시작할 때 해당 응용 프로그램이 이미 활성 상태인 경우 발생합니다. 
    ' NetworkAvailabilityChanged: 네트워크가 연결되거나 연결이 끊어질 때 발생합니다.
    Partial Friend Class MyApplication

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            p_Log.AddMessage(clsLog4Net.enmType.Information, "isNetworkAvailable=" & e.IsNetworkAvailable)
        End Sub



        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown

        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup

            ' 설정된 Language를 가져온다. 
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            ' move to frmSvrLst >>>>
            Dim strSection As String = Common.ClsConfigure.fn_rtnComponentCategory(GetType(clsEnums.AppLanguage))
            Dim strKey As String = Common.ClsConfigure.fn_rtnComponentDescription(GetType(clsEnums.AppLanguage))
            Dim AppLang As clsEnums.AppLanguage = clsIni.ReadValue(strSection, strKey, clsEnums.AppLanguage.Korean)
            Dim strFileLocaton As String = Common.ClsConfigure.fn_rtnComponentDescription(AppLang.GetType.GetMember(AppLang.ToString)(0)) '  TryCast(AppLang.GetType().GetMember(AppLang.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description

            Dim strFilePathNm As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, strFileLocaton)

            '  설정된 Language를 가져와서 DataSet에 넣는다.
            ' 로컬에 기본으로 떨구고 필요시 별도의 Language 파일을 만들어서 불러올 수 있도록 함. 
            p_clsMsgData = New clsXmlData(strFilePathNm)
            ' move to frmSvrLst <<<<<
            ' 쿼리 XML 파일을 가져와서 Dataset에 넣는다. 
            ' Query는 Resource에 들어가 있다.  
            p_clsQueryData = New clsXmlData(New System.IO.StringReader(My.Resources.Querys))


            'p_CriticalInterval = clsIni.ReadValue("General", "CRITICAL", 300000)

            'ConfigIni.WriteValue("General","FONT",ComboBox1.Text) 
            p_Font = clsIni.ReadValue("General", "FONT", "Arial")


            p_ShowName = clsIni.ReadValue("General", "SVRNAME", 0)


        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            p_Log.AddMessage(clsLog4Net.enmType.Error, "[" & e.ExitApplication & "]" & e.Exception.ToString)
        End Sub


    End Class


End Namespace


