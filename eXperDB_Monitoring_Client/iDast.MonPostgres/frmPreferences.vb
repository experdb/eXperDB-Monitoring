Imports System.Net

Public Class frmPreferences
    Private _setInitTap = -1
    Private _openForm As System.Windows.Forms.UserControl
    Private _menuIndex = -1
    Private _odbcConn As eXperDBODBC
    Public Sub New(ByRef odbcConn As eXperDBODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        initform()

        _odbcConn = odbcConn
    End Sub

    Public Sub initform()

        ' 일반설정 탭 
        Me.Text = p_clsMsgData.fn_GetData("F916")
        Me.StatusLabel.Text = p_clsMsgData.fn_GetData("M087")
    End Sub

    Public Function GetCriticalThreshold_1(ByVal Normal As Integer, ByVal Warning As Integer) As String
        Dim CriticalThreshold As String = String.Empty

        If Normal = Warning Then
            If Normal = 100 Then
                CriticalThreshold = "9"
            ElseIf Normal = 0 Then
                CriticalThreshold = "2"
            Else
                CriticalThreshold = "0"
            End If
        Else
            If Normal = 0 AndAlso Warning = 100 Then
                CriticalThreshold = "1"
            Else
                CriticalThreshold = "0"
            End If

        End If

        Return CriticalThreshold
    End Function

    Public Function GetLocalIP() As String
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
        Dim IpAddr() As IPAddress = ipEntry.AddressList
        Dim ip As String = String.Empty

        For Each addr As IPAddress In ipEntry.AddressList
            If addr.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Dim ipAddress As String = addr.ToString
                ip = ipAddress
                Exit For
            End If
        Next

        If ip = "" Then
            Throw New Exception("No 10. IP found!")
        End If

        Return ip

    End Function

    Private Sub frmPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initMenu()

        Dim arg = New DataGridViewCellEventArgs(0, 1)
        dgvMenu.Rows(0).Selected = False
        dgvMenu.Rows(1).Selected = True
        dgvMenu_CellClick(dgvMenu, arg)
    End Sub
    Private Sub initMenu()
        Try
            dgvMenu.ShowLines = False
            dgvMenu.HideExpandeIcon = True

            'Dim topNodeServer As AdvancedDataGridView.TreeGridNode = dgvMenu.Nodes.Add(p_clsMsgData.fn_GetData("F911"))
            'topNodeServer.Image = mnuImgLst.Images(0)
            'topNodeServer.Cells(0).Value = p_clsMsgData.fn_GetData("F911")

            'Dim childNode As AdvancedDataGridView.TreeGridNode = topNodeServer.Nodes.Add(p_clsMsgData.fn_GetData("F912"))
            'childNode.Cells(0).Value = p_clsMsgData.fn_GetData("F912")
            'childNode.Height = 35
            'childNode = topNodeServer.Nodes.Add(p_clsMsgData.fn_GetData("F287"))
            'childNode.Cells(0).Value = p_clsMsgData.fn_GetData("F287")
            'childNode.Height = 35

            Dim childNode As AdvancedDataGridView.TreeGridNode
            Dim topNodeUserMan As AdvancedDataGridView.TreeGridNode = dgvMenu.Nodes.Add(p_clsMsgData.fn_GetData("F916"))
            topNodeUserMan.Image = mnuImgLst.Images(1)
            topNodeUserMan.Cells(0).Value = p_clsMsgData.fn_GetData("F916")

            childNode = topNodeUserMan.Nodes.Add(p_clsMsgData.fn_GetData("F913"))
            childNode.Cells(0).Value = p_clsMsgData.fn_GetData("F913")
            childNode.Height = 35
            childNode = topNodeUserMan.Nodes.Add(p_clsMsgData.fn_GetData("F914"))
            childNode.Cells(0).Value = p_clsMsgData.fn_GetData("F914")
            childNode.Height = 35
            childNode = topNodeUserMan.Nodes.Add(p_clsMsgData.fn_GetData("F941"))
            childNode.Cells(0).Value = p_clsMsgData.fn_GetData("F941")
            childNode.Height = 35
            childNode = topNodeUserMan.Nodes.Add(p_clsMsgData.fn_GetData("F917"))
            childNode.Cells(0).Value = p_clsMsgData.fn_GetData("F917")
            childNode.Height = 35

            'topNodeServer.Height = 45
            topNodeUserMan.Height = 45

            'topNodeServer.Expand()
            topNodeUserMan.Expand()
        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub

    Private Sub dgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If e.RowIndex <= 0 Then
            dgvMenu.Rows(e.RowIndex).Selected = False
            dgvMenu.Rows(1).Selected = True
            openForms(1)
            Return
        End If
        ' Check Whether expanding/collapsing by user clicking or by logic
        openForms(e.RowIndex)

    End Sub

    Private Sub openForms(ByVal index As Integer)
        If _openForm IsNot Nothing Then
            If index = _menuIndex Then Return
            If _menuIndex = 2 AndAlso DirectCast(_openForm, UserSecurity).valueChanged = True Then
                If MsgBox(p_clsMsgData.fn_GetData("M076"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                    DirectCast(_openForm, UserSecurity).Apply()
                End If
            End If
            _openForm.Dispose()
            tlpForms.Controls.Remove(_openForm)
        End If
        _menuIndex = index
        Select Case index
            Case 0 To 1
                Dim usrManagement As New UserManagement(_odbcConn)
                usrManagement.Dock = DockStyle.Fill
                usrManagement.BorderStyle = BorderStyle.FixedSingle
                usrManagement.Name = "UserManagement"
                usrManagement.Width = tlpForms.Width
                usrManagement.Height = tlpForms.Height
                tlpForms.Controls.Add(usrManagement, 0, 0)
                _openForm = usrManagement
            Case 2
                Dim usrSecurity As New UserSecurity(_odbcConn)
                usrSecurity.Dock = DockStyle.Fill
                usrSecurity.BorderStyle = BorderStyle.FixedSingle
                usrSecurity.Name = "UserManagement"
                usrSecurity.Width = tlpForms.Width
                usrSecurity.Height = tlpForms.Height
                tlpForms.Controls.Add(usrSecurity, 0, 0)
                _openForm = usrSecurity
            Case 3
                Dim usrAlertGroup As New UserAlertGroup(_odbcConn)
                usrAlertGroup.Dock = DockStyle.Fill
                usrAlertGroup.BorderStyle = BorderStyle.FixedSingle
                usrAlertGroup.Name = "UserManagement"
                usrAlertGroup.Width = tlpForms.Width
                usrAlertGroup.Height = tlpForms.Height
                tlpForms.Controls.Add(usrAlertGroup, 0, 0)
                _openForm = usrAlertGroup
            Case 4
                Dim usrAccessHistory As New UserAccessHistory(_odbcConn)
                usrAccessHistory.Dock = DockStyle.Fill
                usrAccessHistory.BorderStyle = BorderStyle.FixedSingle
                usrAccessHistory.Name = "UserManagement"
                usrAccessHistory.Width = tlpForms.Width
                usrAccessHistory.Height = tlpForms.Height
                tlpForms.Controls.Add(usrAccessHistory, 0, 0)
                _openForm = usrAccessHistory
            Case Else
        End Select

    End Sub
End Class