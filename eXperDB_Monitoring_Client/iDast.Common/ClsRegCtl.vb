Imports Microsoft.Win32

Public Class ClsRegCtl


    Public Sub New()

    End Sub


    '******************************************************************************************
    ' 레지스트리 Load/Save 할때 
    ' 암/복화화 키값을 넣으면 암/복화 기능을 수행함. 넣지않으면 평문
    '******************************************************************************************

    Public Function ReadReg(ByVal RegPath As String, ByVal str As String, ByVal strSecurityKey As String) As String

        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DX\MON", "EXPDT", str)
        'Dim readValue As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DX\MON", str, Nothing)
        'Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DX\MON", str, Nothing)

        Dim clsSec As New clsSecurity(strSecurityKey)

        Dim registryKey As RegistryKey = Nothing
        If (Environment.Is64BitOperatingSystem = True) Then '64비트 판별
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32)
        End If

        'registryKey = registryKey.OpenSubKey("SOFTWARE\\DX\\MON", True)
        registryKey = registryKey.OpenSubKey(RegPath, True)
        If (registryKey Is Nothing) Then
            Return ""
        Else
            If (registryKey.GetValue(str) Is Nothing) Then
                Return ""
            Else
                Return clsSec.Decrypt(registryKey.GetValue(str).ToString())
            End If
        End If

    End Function

    Public Function ReadReg(ByVal RegPath As String, ByVal str As String) As String

        Dim registryKey As RegistryKey = Nothing
        If (Environment.Is64BitOperatingSystem = True) Then '64비트 판별
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32)
        End If

        'registryKey = registryKey.OpenSubKey("SOFTWARE\\DX\\MON", True)
        registryKey = registryKey.OpenSubKey(RegPath, True)
        If (registryKey Is Nothing) Then
            Return ""
        Else
            If (registryKey.GetValue(str) Is Nothing) Then
                Return ""
            Else
                Return registryKey.GetValue(str).ToString()
            End If
        End If

    End Function



    Public Sub WriteReg(ByVal RegPath As String, ByVal rKey As String, ByVal rVal As String, ByVal strSecurityKey As String)

        Dim clsSec As New clsSecurity(strSecurityKey)

        Dim registryKey As RegistryKey = Nothing
        If (Environment.Is64BitOperatingSystem = True) Then '64비트 판별
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32)
        End If

        'Dim regKey As RegistryKey = registryKey.CreateSubKey("SOFTWARE\\DX\\MON", RegistryKeyPermissionCheck.ReadWriteSubTree)
        Dim regKey As RegistryKey = registryKey.CreateSubKey(RegPath, RegistryKeyPermissionCheck.ReadWriteSubTree)
        regKey.SetValue(rKey, clsSec.Encrypt(rVal), RegistryValueKind.String)
        regKey.Close()
        registryKey.Close()

    End Sub


    Public Sub WriteReg(ByVal RegPath As String, ByVal rKey As String, ByVal rVal As String)

        '값을 넣을때는 Encrypt 해서 저장함.

        Dim registryKey As RegistryKey = Nothing
        If (Environment.Is64BitOperatingSystem = True) Then '64비트 판별
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64)
        Else
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32)
        End If

        'Dim regKey As RegistryKey = registryKey.CreateSubKey("SOFTWARE\\DX\\MON", RegistryKeyPermissionCheck.ReadWriteSubTree)
        Dim regKey As RegistryKey = registryKey.CreateSubKey(RegPath, RegistryKeyPermissionCheck.ReadWriteSubTree)
        regKey.SetValue(rKey, rVal, RegistryValueKind.String)
        regKey.Close()
        registryKey.Close()

    End Sub

End Class
