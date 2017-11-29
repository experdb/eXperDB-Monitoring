Public Class frmQueryView
    Private _intInstanceID As Integer

    Public Sub New(ByVal strText As String, ByVal strDBNm As String, ByVal intInstID As Integer, ByVal clsAgentInfo As structAgent, ByVal strUser As String)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.


        Me.RichTextBoxQuery1.Tag = strText
        Me.RichTextBoxQuery1.Text = strText
        _intInstanceID = intInstID


        lblDB.Text = p_clsMsgData.fn_GetData("F010")
        lblID.Text = p_clsMsgData.fn_GetData("F008")
        lblPw.Text = p_clsMsgData.fn_GetData("F009")
        btnSearch.Text = p_clsMsgData.fn_GetData("F151")
        If clsAgentInfo Is Nothing Then
            Panel1.Visible = False
            Splitter1.Visible = False
        Else
            clsEMsg = New clsAgentEMsg(clsAgentInfo.AgentIP, clsAgentInfo.AgentPort)
        End If
        txtDB.Text = strDBNm
        txtID.Text = strUser
        ' 설정 정보 읽어 오기 
        Sb_ReadIni()

        Dim rgxVariable As New System.Text.RegularExpressions.Regex(Me.RichTextBoxQuery1.VariableRegex)
        Dim rgxMatches As System.Text.RegularExpressions.MatchCollection = rgxVariable.Matches(strText)
        If rgxMatches.Count = 0 Then
            spnlVariables.Visible = False
            dgvVariables.Visible = False
        Else
            spnlVariables.Visible = True
            dgvVariables.Visible = True
            For Each tmpMatch As System.Text.RegularExpressions.Match In rgxMatches
                Dim intIndex As Integer = Me.RichTextBoxQuery1.Find(tmpMatch.Value, RichTextBoxFinds.MatchCase And RichTextBoxFinds.WholeWord)
                Dim intLine As Integer = Me.RichTextBoxQuery1.GetLineFromCharIndex(intIndex)
                Dim intLineIdx As Integer = intIndex - intLine
                dgvVariables.Rows.Add(tmpMatch.Value, "", intLine)
            Next
        End If

        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseRotationBox = False
        Me.FormControlBox1.UsePowerBox = False

    End Sub

    Private Sub Sb_ReadIni()

        Dim clsIni As New Common.IniFile(p_AppConfigIni)


        Me.RichTextBoxQuery1.VariableRegex = clsIni.ReadValue("SQL", "PATTERN", "\$[a-zA-Z_\d]*\b")
        Me.RichTextBoxQuery1.BackColor = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "BACKCOLOR", "BLACK"))
        Me.RichTextBoxQuery1.Comments = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "COMMENTS", "GREEN"))
        Me.RichTextBoxQuery1.Functions = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "FUNCTIONS", "MAROON"))
        Me.RichTextBoxQuery1.KeyWords = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "KEYWORDS", "BLUE"))
        Me.RichTextBoxQuery1.Numbers = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "NUMBERS", "MAGENTA"))
        Me.RichTextBoxQuery1.StateMents = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "STATEMENTS", "BLUE"))
        Me.RichTextBoxQuery1.Types = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "TYPES", "BROWN"))
        Me.RichTextBoxQuery1.Variables = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "VARIABLES", "MAROON"))
        Me.RichTextBoxQuery1.Strings = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "STRINGS", "RED"))

        Me.RichTextBoxQuery1.ForeColor = System.Drawing.Color.FromName(clsIni.ReadValue("SQL", "NORMAL", "GRAY"))

    End Sub

    Private Sub frmQueryView_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Me.RichTextBoxQuery1.RegexClrChg()
    End Sub

    Private WithEvents clsEMsg As clsAgentEMsg

    Private Sub clsEMsg_Complete(sender As Object, e As Object) Handles clsEMsg.Complete
        Me.Invoke(New MethodInvoker(Sub()
                                        Dim ctlTv As AdvancedDataGridView.TreeGridView = Me.TreeGridView1
                                        ctlTv.Nodes.Clear()

                                        If e.GetType.Equals(GetType(clsAgentEMsg.DX005_REP)) Then
                                            Dim AA As clsAgentEMsg.DX005_REP = DirectCast(e, clsAgentEMsg.DX005_REP)




                                            Dim intNodeSpace As Integer = 6
                                            Dim pNode As AdvancedDataGridView.TreeGridNode = Nothing
                                            For Each tmpStr As clsAgentEMsg.queryplans In AA.DATAS

                                                If pNode Is Nothing Then
                                                    pNode = ctlTv.Nodes.Add(tmpStr.queryplan)
                                                Else
                                                    Dim calcNode As Integer = tmpStr.queryplan.IndexOf("->")
                                                    If calcNode < 0 Then
                                                        pNode.Cells(0).Value += vbCrLf & "  " & tmpStr.queryplan.Trim
                                                    Else
                                                        Dim intLevel As Integer = (calcNode \ intNodeSpace) + 1
                                                        If pNode.Level = intLevel Then
                                                            pNode = pNode.Nodes.Add(tmpStr.queryplan.Substring(calcNode + 2).Trim)
                                                        ElseIf pNode.Level > intLevel Then
                                                            Do Until pNode.Level = intLevel - 1
                                                                pNode = pNode.Parent
                                                            Loop

                                                            pNode = pNode.Nodes.Add(tmpStr.queryplan.Substring(calcNode + 2).Trim)

                                                        End If
                                                    End If
                                                End If
                                                pNode.Expand()

                                            Next

                                            If AA.ERRORS IsNot Nothing Then
                                                ctlTv.Nodes.Add(String.Format("[{0}]{1}", AA.ERRORS._error_cd, AA.ERRORS._error_msg))
                                            End If

                                        Else
                                            If e Is Nothing Or Not e.GetType.Equals(GetType(clsSocket.Results)) Then
                                                ctlTv.Nodes.Add("Result Is Nothing")
                                            Else
                                                ctlTv.Nodes.Add(DirectCast(e, clsSocket.Results).ErrorMsg)
                                            End If

                                        End If

                                        ctlTv.AutoResizeRows()




                                    End Sub))

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtID.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", lblID.Text))
            txtID.Focus()
            Return
        End If

        If txtPW.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", lblPw.Text))
            txtPW.Focus()
            Return
        End If

        If txtDB.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", lblDB.Text))
            txtDB.Focus()
            Return
        End If

        If dgvVariables.Visible = True Then
            For Each tmpRow As DataGridViewRow In dgvVariables.Rows
                If tmpRow.Cells(colValue.Index).Value = "" Then
                    MsgBox(p_clsMsgData.fn_GetData("M001", tmpRow.Cells(colVariable.Index).Value))
                    dgvVariables.Focus()
                    Return
                End If
            Next
        End If

        clsEMsg.SendDX005(_intInstanceID, txtID.Text, txtDB.Text, txtPW.Text, RichTextBoxQuery1.Text)
    End Sub
 

    Private Sub dgvVariables_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVariables.CellValueChanged
        If dgvVariables.IsHandleCreated = True Then
            Dim strText As String = Me.RichTextBoxQuery1.Tag
            Dim rgxPattern As New System.Text.RegularExpressions.Regex(Me.RichTextBoxQuery1.VariableRegex)
            Dim srtMatch As New Hashtable
            For Each tmpRow As DataGridViewRow In dgvVariables.Rows
                If tmpRow.Cells(colValue.Index).Value <> "" Then
                    srtMatch.Add(tmpRow.Cells(colVariable.Index).Value, tmpRow.Cells(colValue.Index).Value)
                End If
            Next

            Dim rgxEvaluator As New System.Text.RegularExpressions.MatchEvaluator(Function(m As System.Text.RegularExpressions.Match)
                                                                                      If srtMatch.Contains(m.Value) Then
                                                                                          Return srtMatch.Item(m.Value)
                                                                                      Else
                                                                                          Return m.Value
                                                                                      End If
                                                                                  End Function)


            Me.RichTextBoxQuery1.Text = rgxPattern.Replace(strText, rgxEvaluator)
           
        End If

    End Sub

     
    Private Sub dgvVariables_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvVariables.CurrentCellChanged
        If dgvVariables.IsHandleCreated And dgvVariables.CurrentRow IsNot Nothing Then
            Dim RTB As Controls.RichTextBoxQuery = Me.RichTextBoxQuery1
            Dim intLine As Integer = dgvVariables.CurrentRow.Cells(colLine.Index).Value
            Dim strFind As String = IIf(dgvVariables.CurrentRow.Cells(colValue.Index).Value = "", dgvVariables.CurrentRow.Cells(colVariable.Index).Value, dgvVariables.CurrentRow.Cells(colValue.Index).Value)


            Dim strLine As String = RTB.Lines(intLine)
            Dim intValue As Integer = -1

            intValue = RTB.Find(strFind, RTB.GetFirstCharIndexFromLine(intLine), RTB.GetFirstCharIndexFromLine(intLine) + strLine.Length, RichTextBoxFinds.MatchCase And RichTextBoxFinds.WholeWord)

            If intValue > 0 Then
                RTB.SelectionStart = intValue
                RTB.SelectionLength = strFind.Length
            End If





            'Dim intVariable As Integer = Me.RichTextBoxQuery1.Find(strVariable, RichTextBoxFinds.MatchCase And RichTextBoxFinds.WholeWord)
            'If intVariable > 0 Then
            '    Dim intLine As Integer = RTB.GetLineFromCharIndex(intVariable)
            '    'Dim stLength As Integer = RTB.GetFirstCharIndexFromLine(intLine)
            '    'Dim stIndex As Integer = stLength - stLength
            '    RTB.SelectionStart = intVariable
            '    RTB.SelectionLength = strVariable.Length

            'Else
            '    intVariable = Me.RichTextBoxQuery1.Find(strValue, RichTextBoxFinds.MatchCase And RichTextBoxFinds.WholeWord)
            '    If intVariable > 0 Then


            '    End If

            'End If


        End If
    End Sub
     
End Class