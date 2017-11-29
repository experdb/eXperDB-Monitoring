Option Explicit On
Imports System.IO
Imports System.Data.OleDb
Imports AdvancedDataGridView
Imports System.Data.Odbc
Imports DX.Controls
Imports DX.Database.ClsOdbc
Imports DX.Database

Public Class frmMIGLogin

    Private COC As New ClsObjectCtl
    Private CGC As New ClsGridCtl
    Private CC As New ClsCrypt

    Private List As SortedList
    Private da As OleDbDataAdapter = New OleDbDataAdapter
    Private TmpConnInfo As New OdbcDbInfo
    Private TmpConnHistory As New modLoaderGlobal.OdbcConnHist
    Private DbConnectBool As Boolean = False

    Private conn As ClsCommonConn
    Private CLH As New ClsLoginHist(ClsConfigure.GetValues(ClsConfigure.enumConfig.UserFilePath) & Path.DirectorySeparatorChar & "LogHist", "LogAnyDbHistMeta.ida")

    Public Function getConnInfo() As OdbcDbInfo
        Return TmpConnInfo
    End Function

    Public Function getConn() As ClsCommonConn
        Return conn
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim tnsEntry As OraTnsEntry = Nothing
        Dim TmpSID As String = String.Empty
        Dim TmpRealSID As String = String.Empty

        If UsernameTextBox.Text = String.Empty Then
            MsgBox("사용자ID를 입력하세요!", MsgBoxStyle.Information, "정보")
            Me.DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        ElseIf PasswordTextBox.Text = String.Empty Then
            MsgBox("사용자 Password를 입력하세요!", MsgBoxStyle.Information, "정보")
            Me.DialogResult = Windows.Forms.DialogResult.None
            Exit Sub
        ElseIf (OdbcDriverCB.SelectedValue = String.Empty) Then
            MsgBox("ODBC Driver 정보가 입력되지 않았습니다.", MsgBoxStyle.Critical, "에러")
            Me.DialogResult = Windows.Forms.DialogResult.None
            OdbcDriverCB.Focus()
            Exit Sub
        ElseIf (ServerIpTB.Text = String.Empty) Then
            MsgBox("Server IP 정보가 입력되지 않았습니다.", MsgBoxStyle.Critical, "에러")
            Me.DialogResult = Windows.Forms.DialogResult.None
            ServerIpTB.Focus()
            Exit Sub
        ElseIf (DbNameTB.Text = String.Empty) Then
            MsgBox("Database Name 정보가 입력되지 않았습니다.", MsgBoxStyle.Critical, "에러")
            Me.DialogResult = Windows.Forms.DialogResult.None
            DbNameTB.Focus()
            Exit Sub
        ElseIf (PortTB.Text = String.Empty And OdbcDriverCB.SelectedValue <> iDAST_OdbcDriver(3, 0)) Then
            MsgBox("Port 정보가 입력되지 않았습니다.", MsgBoxStyle.Critical, "에러")
            Me.DialogResult = Windows.Forms.DialogResult.None
            PortTB.Focus()
            Exit Sub
        End If

        Try
            TmpConnInfo.USERTYPE = ClsCrypt.iDAST_ProgramType(2, 0)
            TmpConnInfo.USERID = UsernameTextBox.Text
            TmpConnInfo.USERPW = PasswordTextBox.Text
            TmpConnInfo.ODBCDRIVER = OdbcDriverCB.SelectedValue
            TmpConnInfo.SERVERIP = ServerIpTB.Text
            TmpConnInfo.DBNAME = DbNameTB.Text
            TmpConnInfo.PORT = PortTB.Text
            If SchemaNmTB.Enabled = True Then
                TmpConnInfo.SCHEMA_NAME = SchemaNmTB.Text
            Else
                TmpConnInfo.SCHEMA_NAME = UsernameTextBox.Text
            End If


            '히스토리 struct에 등록
            TmpConnHistory.ConnInfo = TmpConnInfo

            StartStatus()
            ExecBW.RunWorkerAsync()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub ExecBW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ExecBW.DoWork
        Try
            If ExecBW.CancellationPending Then
                Exit Sub
            End If
            conn = ClsCreateDbConn.CreateConnection(TmpConnInfo)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmMIGLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If ExecBW.IsBusy = True Then
        '    MsgBox("처리중에는 닫을수 없습니다.", MsgBoxStyle.Information, "정보")
        '    e.Cancel = True
        'End If

        Try
            If Me.DialogResult = Windows.Forms.DialogResult.None Then
                e.Cancel = True
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '이미지 초기화
        Me.Icon = COC.PuplationIco(DX.Resources.iResources.user)
        RefreshTSB.Image = COC.PuplationIco(DX.Resources.iResources.refresh).ToBitmap()
        DeleteTSB.Image = COC.PuplationIco(DX.Resources.iResources.odelete).ToBitmap()

        '기본접속은 TNS으로
        'FillOraConnInfo.CONTYPE = "TNS"

        Try
            'Grouping 박스 초기화
            Dim _Columns(,) As String = {{"USERID", "유저ID"}, _
                                         {"SERVERIP", "서버 IP"}, _
                                         {"DBNAME", "데이터베이스명"}, _
                                         {"PORT", "포트"}}
            Dim Columns As New ArrayList
            For i = LBound(_Columns) To UBound(_Columns)
                Columns.Add(New ClsValueDescription(_Columns(i, 0), _Columns(i, 1)))
            Next
            With GroupingTSCB.ComboBox
                .DisplayMember = "Description"
                .ValueMember = "Value"
                .DataSource = Columns
            End With

            With OdbcDriverCB
                .DisplayMember = "Description"
                .ValueMember = "Value"
                .DataSource = ClsOdbc.getOdbcDriverList(iDAST_OdbcDriver)
                .SelectedIndex = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Private Sub DisplayLoginHist()

        Try
            StartStatus()
            '로그인히스트로 가져오기
            InitLoginHistTGV()

            If CLH.getExistLoginFile = True Then
                MakeTreeGridView(GroupingTSCB.ComboBox.SelectedValue)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "에러")
        Finally
            StopStatus()
        End Try

    End Sub

    Private Sub MakeTreeGridView(ByVal pGroupByColumn As String)
        Dim befProgramType As Integer = iDAST_CurrentProgramType
        'iDAST_CurrentProgramType = iDast.Common.ClsCrypt.iDAST_ProgramType(2, 0)
        Dim tSourceTable As DataTable = CLH.PopluateLoginHistory
        Dim dv As New DataView(tSourceTable)
        Dim dtGroup As DataTable = dv.ToTable(True, New String() {pGroupByColumn})

        With LoginHistTGV
            Dim boldFont As Font = New Font(.DefaultCellStyle.Font, FontStyle.Bold)
            .Nodes.Clear()
            For Each dr As DataRow In dtGroup.Rows
                Dim node As TreeGridNode = .Nodes.Add(dr(0), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                node.Image = COC.PuplationIco(DX.Resources.iResources.ptable).ToBitmap
                node.DefaultCellStyle.Font = boldFont
                For Each row As DataRow In tSourceTable.Select(pGroupByColumn & "=" & "'" & dr(0) & "'")
                    Dim cNode As TreeGridNode = node.Nodes.Add(Nothing, row("USERTYPE"), row("USERID"), row("ODBCDRIVER"), row("SERVERIP"), row("DBNAME"), row("PORT"), row("PASSWD"), row("SCHEMA_NAME"), row("REGDT"), row("DELKEY"))
                    cNode.Image = COC.PuplationIco(DX.Resources.iResources.key_login).ToBitmap
                Next
                node.Expand()
            Next
            'iDAST_CurrentProgramType = befProgramType
        End With

    End Sub

    Private Sub HistoyLoginDataToObject()

        With LoginHistTGV.CurrentRow

            '마스터 treenode는 접속 데이터가 아니므로 초기화
            If .Cells(0).Value <> "" Then
                UsernameTextBox.Text = String.Empty
                PasswordTextBox.Text = String.Empty
                PortTB.Text = String.Empty

            Else

                '사용자ID
                UsernameTextBox.Text = .Cells(2).Value

                '패스워드
                PasswordTextBox.Text = .Cells(7).Value

                '서버IP
                ServerIpTB.Text = .Cells(4).Value


                'ODBC Driver
                OdbcDriverCB.SelectedValue = .Cells(3).Value

                '스키마 이름
                SchemaNmTB.Text = .Cells(8).Value

                '서버 포트
                PortTB.Text = .Cells(6).Value

                'DB 이름
                DbNameTB.Text = .Cells(5).Value


                If .Cells(7).Value <> "" Then
                    SavePwCB.Checked = True
                Else
                    SavePwCB.Checked = False
                End If

            End If

        End With

    End Sub

    Private Sub InitLoginHistTGV()
        With LoginHistTGV
            With .Columns(0)
                .HeaderText = "그룹"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(1)
                .HeaderText = "프로그램 타입"
                .Visible = False
            End With
            With .Columns(2)
                .HeaderText = "유저ID"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns(3)
                .HeaderText = "DB타입"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns(4)
                .HeaderText = "호스트"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns(5)
                .HeaderText = "서비스명"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns(6)
                .HeaderText = "포트"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns(7)
                .HeaderText = "패스워드"
                .Visible = False
            End With
            With .Columns(8)
                .HeaderText = "스키마"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            With .Columns(9)
                .HeaderText = "변경일"
                .Visible = False
            End With
            With .Columns(10)
                .HeaderText = "삭제키"
                .Visible = False
            End With
        End With

    End Sub

    Private Sub UsernameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.GotFocus
        COC.TxBSelAllGotFocus(Me, UsernameTextBox)
    End Sub

    Private Sub PasswordTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.GotFocus
        COC.TxBSelAllGotFocus(Me, PasswordTextBox)
    End Sub

    Private Sub ExecBW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ExecBW.RunWorkerCompleted
        Try
            '백그라운드 프로세스 종료
            ExecBW.Dispose()
            If conn.isOpenConn = ConnectionState.Open Then
                Dim befProgramType As Integer = iDAST_CurrentProgramType
                'iDAST_CurrentProgramType = iDast.Common.ClsCrypt.iDAST_ProgramType(2, 0)

                '접속history에 갱신
                CLH.UpdateLoginHistory(TmpConnHistory, SavePwCB.CheckState)

                'iDAST_CurrentProgramType = befProgramType
                '접속되면 세팅
                TmpConnInfo = Nothing
                DbConnectBool = True
                Me.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            'If conn IsNot Nothing Then
            '    conn.Close()
            'End If
            StopStatus()
        End Try
    End Sub

    Public Function isDbConnect() As Boolean
        Return DbConnectBool
    End Function

    Private Sub StartStatus()
        Me.Cursor = Cursors.WaitCursor
        OK.Enabled = False
        Cancel.Enabled = False
    End Sub

    Private Sub StopStatus()
        Me.Cursor = Cursors.Default
        OK.Enabled = True
        Cancel.Enabled = True
    End Sub

    Private Sub GroupingTSCB_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupingTSCB.SelectedIndexChanged
        DisplayLoginHist()
    End Sub

    Private Sub RefreshTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTSB.Click
        DisplayLoginHist()
    End Sub

    Private Sub LoginHistTGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LoginHistTGV.CellClick
        If e.RowIndex >= 0 Then
            HistoyLoginDataToObject()
        End If
    End Sub

    Private Sub LoginHistTGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LoginHistTGV.CellDoubleClick
        If e.RowIndex >= 0 And LoginHistTGV.CurrentRow.Cells(0).Value = "" Then
            OK.PerformClick()
        End If

    End Sub

    Private Sub DeleteTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTSB.Click
        If LoginHistTGV.Nodes.Count > 0 Then
            '데이터 삭제
            For Each row As DataGridViewRow In LoginHistTGV.SelectedRows
                CLH.DeleteData(row.Cells(10).Value)
            Next
            '새로고침
            DisplayLoginHist()
        End If
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RefreshTSB.PerformClick()
    End Sub

    Private Sub OdbcDriverCB_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles OdbcDriverCB.SelectedIndexChanged
        'If OdbcDriverCB.SelectedIndex = 1 Or OdbcDriverCB.SelectedIndex = 2 Then
        PortTB.Enabled = True
        If OdbcDriverCB.SelectedValue = iDAST_OdbcDriver(1, 0) Or OdbcDriverCB.SelectedValue = iDAST_OdbcDriver(2, 0) Then
            SchemaNmTB.Enabled = True
            ServerIpTB.MaxLength = 15
        ElseIf OdbcDriverCB.SelectedValue = iDAST_OdbcDriver(3, 0) Then
            SchemaNmTB.Enabled = True
            'PortTB.Enabled = False
            ServerIpTB.MaxLength = 100
        ElseIf OdbcDriverCB.SelectedValue = iDAST_OdbcDriver(0, 0) Then
            SchemaNmTB.Enabled = False
            ServerIpTB.MaxLength = 15
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged
        Try
            If OdbcDriverCB.Text = iDAST_OdbcDriver(0, 1) Then
                SchemaNmTB.Text = UsernameTextBox.Text
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
     
End Class
