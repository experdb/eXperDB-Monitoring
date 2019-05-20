Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Threading
Imports System.Text

Public Class Form1
    Inherits Form

    Public Enum GetWndConsts
        GW_HWNDFIRST = 0
        GW_HWNDLAST = 1
        GW_HWNDNEXT = 2
        GW_HWNDPREV = 3
        GW_OWNER = 4
        GW_CHILD = 5
        GW_ENABLEDPOPUP = 6
        GW_MAX = 6
    End Enum
    Private Const REGISTRYPATH As String = "HKEY_LOCAL_MACHINE\Software\K4M\eXperDB.Monitoring\Settings"
    Private Const APPNAME As String = "eXperDB.Monitoring.exe"
    <DllImport("user32")> _
    Public Shared Function FindWindow(lpClassName As [String], lpWindowName As [String]) As IntPtr
    End Function
    <DllImport("user32")> _
    Private Shared Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal lclassName As String, ByVal windowTitle As String) As IntPtr
    End Function
    <DllImport("user32")> _
    Private Shared Function SetForegroundWindow(ByVal hwnd As Long) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=False, CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=False, CharSet:=CharSet.Unicode)>
    Private Shared Function GetWindow(ByVal hwnd As IntPtr, ByVal wCmd As GetWndConsts) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=False, CharSet:=CharSet.Unicode)>
    Public Shared Function GetWindowText(hWnd As IntPtr, lpString As StringBuilder, nMaxCount As Integer) As Integer
    End Function


    Private Const BM_CLICK As Integer = &HF5
    Private Const WM_LBUTTONDOWN As Integer = &H201

    Public Sub New()
        
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        Dim strHostname As String = vbEmpty
        Dim isLoadded As Boolean = False


        Dim proc As Process = Nothing

        For Each p As Process In Process.GetProcesses()
            If p.ProcessName = "eXperDB.Monitoring" Then
                proc = p
                isLoadded = True
                Exit For
            End If
        Next

        If proc Is Nothing Then
            Dim installPath = My.Computer.Registry.GetValue(REGISTRYPATH, "InstallPath", Nothing) + "\" + APPNAME
            proc = Process.Start(installPath)
            Threading.Thread.Sleep(3000)
        End If
        Dim hWnd As System.IntPtr = proc.MainWindowHandle()
        If hWnd <> IntPtr.Zero Then
            SetForegroundWindow(hWnd)

            Dim hWndMain As System.IntPtr = FindWindowEx(hWnd, IntPtr.Zero, Nothing, Nothing)
            Dim hWndFirstTab As System.IntPtr = FindWindowEx(hWndMain, IntPtr.Zero, Nothing, Nothing)
            Dim hWndConnectButton As System.IntPtr = GetWindow(GetWindow(GetWindow(GetWindow(hWndFirstTab, GetWndConsts.GW_CHILD), GetWndConsts.GW_HWNDNEXT), GetWndConsts.GW_HWNDNEXT), GetWndConsts.GW_CHILD)

            SendMessage(hWndConnectButton, BM_CLICK, 0, 0)

            Threading.Thread.Sleep(100)

            Dim hWndSecondTab As System.IntPtr = GetWindow(hWndFirstTab, GetWndConsts.GW_HWNDNEXT)
            Dim hWndStartButton As System.IntPtr = GetWindow(GetWindow(GetWindow(hWndSecondTab, GetWndConsts.GW_CHILD), GetWndConsts.GW_HWNDNEXT), GetWndConsts.GW_CHILD)

            SendMessage(hWndStartButton, BM_CLICK, 0, 0)
        End If

        If clArgs.Count() >= 2 Then
            strHostname = clArgs(1)
            If isLoadded = False Then
                Threading.Thread.Sleep(800)
            End If

            For Each p As Process In Process.GetProcesses()
                If p.ProcessName = "eXperDB.Monitoring" Then
                    proc = p
                    Exit For
                End If
            Next

            hWnd = proc.MainWindowHandle()

            Dim hWndSvrList As System.IntPtr = GetWindow(GetWindow(GetWindow(GetWindow(GetWindow(GetWindow(GetWindow(GetWindow(hWnd, GetWndConsts.GW_CHILD), GetWndConsts.GW_CHILD), GetWndConsts.GW_CHILD), GetWndConsts.GW_HWNDNEXT), GetWndConsts.GW_CHILD), GetWndConsts.GW_HWNDNEXT), GetWndConsts.GW_CHILD), GetWndConsts.GW_CHILD)
            Dim hWndHost As System.IntPtr = GetWindow(hWndSvrList, GetWndConsts.GW_CHILD)
            Dim Caption As New System.Text.StringBuilder(256)
            Dim strHost As String = Nothing
            Dim hWndTargetHost As System.IntPtr = Nothing
            GetWindowText(hWndHost, Caption, Caption.Capacity)

            While (hWndHost <> Nothing)
                GetWindowText(hWndHost, Caption, Caption.Capacity)
                If Caption.ToString = " " + strHostname Then
                    strHost = Caption.ToString
                    hWndTargetHost = hWndHost
                End If
                hWndHost = GetWindow(hWndHost, GetWndConsts.GW_HWNDNEXT)
            End While

            If strHost IsNot Nothing Then
                Threading.Thread.Sleep(300)
                Dim lnglParam As String = (Location.Y * &H10000) + Location.X
                SendMessage(hWndTargetHost, WM_LBUTTONDOWN, 1&, lnglParam)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.Close()
    End Sub
End Class
