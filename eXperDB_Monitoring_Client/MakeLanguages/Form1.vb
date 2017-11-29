Imports System.Xml
Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TreeView1.Nodes.Clear()



        Dim Ofd As New FolderBrowserDialog
        Ofd.SelectedPath = Button1.Tag

        If Ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Button1.Tag = Ofd.SelectedPath
            Dim files As String() = System.IO.Directory.GetFiles(Ofd.SelectedPath, "*.xml")
            For Each File As String In files
                Dim pNode As TreeNode = TreeView1.Nodes.Add(File)

                For Each tmpStr As String In TextBox3.Text.Split(",")
                    pNode.Nodes.Add(tmpStr)
                Next
                pNode.ExpandAll()
            Next
        End If


    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each pNode As TreeNode In TreeView1.Nodes
            Dim dtSet As New DataSet
            dtSet.ReadXml(pNode.Text)
            pNode.Tag = dtSet
        Next


        'Dim chkItms As ArrayList = CheckItem(TreeView1)
        Dim dtTable As New DataTable
        Dim tmpKeyCol As DataColumn = dtTable.Columns.Add()
        tmpKeyCol.ColumnName = TextBox2.Text
        tmpKeyCol.Caption = TextBox2.Text
        For Each chkItms As TreeNode In TreeView1.Nodes
            For Each chkItm As TreeNode In chkItms.Nodes
                If Not chkItm.Text.Equals(tmpKeyCol.ColumnName) Then
                    Dim tmpCol As DataColumn = dtTable.Columns.Add()
                    tmpCol.Caption = System.IO.Path.GetFileName(chkItm.Parent.Text) & "|" & chkItm.Text
                    tmpCol.ColumnName = System.IO.Path.GetFileName(chkItm.Parent.Text) & "|" & chkItm.Text
                     
                End If

            Next
        Next

        'Dim keynode As TreeNode = Nothing
        'For Each chkitm As TreeNode In chkItms
        '    If TextBox2.Text.Equals(chkitm.Text) Then
        '        keynode = chkitm
        '        Exit For
        '    End If
        'Next



        For Each pNode As TreeNode In TreeView1.Nodes
            Dim dtSet As DataSet = pNode.Tag
            Dim dtKey As DataTable = dtSet.Tables(0)
            For Each tmpRow As DataRow In dtKey.Rows
                If IsDBNull(tmpRow.Item(TextBox2.Text)) = False AndAlso dtTable.Select(TextBox2.Text & "='" & tmpRow.Item(TextBox2.Text) & "'").Count = 0 Then
                    Dim NewRow As DataRow = dtTable.Rows.Add()
                    NewRow.Item(TextBox2.Text) = tmpRow.Item(TextBox2.Text)
                    

                    For Each chkitms As TreeNode In TreeView1.Nodes
                        For Each tmp1 As TreeNode In chkitms.Nodes
                            If Not tmp1.Text.Equals(TextBox2.Text) Then
                                Dim AA As DataTable = DirectCast(tmp1.Parent.Tag, DataSet).Tables(0)
                                Dim bb As DataRow() = AA.Select(TextBox2.Text & "='" & NewRow.Item(TextBox2.Text) & "'")
                                If bb.Count > 0 Then
                                    If AA.Columns.Contains(tmp1.Text) = True Then
                                        NewRow.Item(System.IO.Path.GetFileName(tmp1.Parent.Text) & "|" & tmp1.Text) = bb(0).Item(tmp1.Text)
                                    End If

                                End If


                            End If
                        Next
                    Next

                End If


            Next
        Next



        DataGridView1.DataSource = dtTable





    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Me.DataGridView1.Rows.Count > 0 AndAlso MsgBox("혹시 모르니까 저장 할래?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Button2.PerformClick()
        End If
    End Sub


    'Private Function CheckItem(ByVal tv As TreeView) As ArrayList
    '    Dim rtnLst As New ArrayList
    '    For Each TopNode As TreeNode In tv.Nodes
    '        For Each cNode As TreeNode In TopNode.Nodes
    '            If cNode.Checked = True Then
    '                rtnLst.Add(cNode)
    '            End If
    '        Next
    '    Next
    '    Return rtnLst
    'End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim A As New IniFile(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "SETUP.ini"))
        Button1.Tag = A.ReadValue("SETUP", "PATH", My.Application.Info.DirectoryPath)
        TextBox3.Text = A.ReadValue("SETUP", "XMLDATAS", "ID,PARAMS,DESC,DATA,COMMENTS,CATEGORY,COLUMNS,VALUECAST")
        TextBox2.Text = A.ReadValue("SETUP", "MATCH", "ID")
        TextBox4.Text = A.ReadValue("SETUP", "CDATA", "DATA")
        TextBox5.Text = A.ReadValue("SETUP", "COLUMNS", "COLUMNS")
        TextBox6.Text = A.ReadValue("SETUP", "VALUECAST", "VALUECAST")




    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            ListBox1.Items.Clear()
            SrtLst.Clear()
            Dim search As String = TextBox1.Text

            For Each tmpRow As DataGridViewRow In DataGridView1.Rows
                For Each tmpColumn As DataGridViewColumn In DataGridView1.Columns
                    If IsDBNull(tmpRow.Cells(tmpColumn.Index).Value) = False AndAlso tmpRow.Cells(tmpColumn.Index).Value IsNot Nothing Then
                        If tmpRow.Cells(tmpColumn.Index).Value.ToString.ToUpper Like search.ToUpper Then
                            Dim int As Integer = ListBox1.Items.Add(tmpRow.Cells(TextBox2.Text).Value)
                            SrtLst.Add(tmpRow)
                        End If
                    End If

                Next
            Next
        End If
    End Sub

    Dim SrtLst As New ArrayList
     

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If SrtLst.Count > 0 And ListBox1.SelectedIndex >= 0 Then
            DataGridView1.ClearSelection()

            Dim tmpRow As DataGridViewRow = SrtLst.Item(ListBox1.SelectedIndex)
            DataGridView1.Rows(tmpRow.Index).Selected = True
            DataGridView1.FirstDisplayedScrollingRowIndex = tmpRow.Index
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim A As New IniFile(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "SETUP.ini"))
        A.WriteValue("SETUP", "PATH", Button1.Tag)
        A.WriteValue("SETUP", "XMLDATAS", TextBox3.Text)
        A.WriteValue("SETUP", "MATCH", TextBox2.Text)
        A.WriteValue("SETUP", "CDATA", TextBox4.Text)
        A.WriteValue("SETUP", "COLUMNS", TextBox5.Text)
        A.WriteValue("SETUP", "VALUECAST", TextBox6.Text)


        For Each tmpNode As TreeNode In TreeView1.Nodes
            Dim dtSet As DataSet = tmpNode.Tag
            dtSet.Tables(0).Rows.Clear()
            For Each tmpstr As String In Me.TextBox3.Text.Split(",")
                If tmpstr.Trim <> "" Then
                    If dtSet.Tables(0).Columns.Contains(tmpstr) = False Then
                        dtSet.Tables(0).Columns.Add(tmpstr)
                    End If
                End If
            Next



            Dim dtTable As DataTable = dtSet.Tables(0)

            Dim FullNm As String = tmpNode.Text
            Dim Filenm As String = System.IO.Path.GetFileName(FullNm)
            For Each tmpRow As DataGridViewRow In DataGridView1.Rows
                Dim ID As String = tmpRow.Cells(TextBox2.Text).Value
                Dim dtRow As DataRow = dtTable.Rows.Add()
                dtRow.Item(TextBox2.Text) = ID
                For Each tmpColumn As DataGridViewColumn In DataGridView1.Columns
                    If Not tmpColumn.Name.Equals(TextBox2.Text) AndAlso tmpColumn.Name.Split("|")(0) = Filenm Then
                        Dim val As String = IIf(IsDBNull(tmpRow.Cells(tmpColumn.Index).Value), "", tmpRow.Cells(tmpColumn.Index).Value)
                        'If tmpColumn.Name.ToUpper.Split("|")(1) = TextBox4.Text.ToUpper Then
                        '    val = String.Format("<![CDATA[{0}]]>", val)
                        'End If
                        dtRow.Item(tmpColumn.Name.Split("|")(1)) = val '  IIf(IsDBNull(tmpRow.Cells(tmpColumn.Index).Value), "", tmpRow.Cells(tmpColumn.Index).Value)
                    End If
                Next
            Next
            Dim backfile As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(tmpNode.Text), System.IO.Path.GetFileNameWithoutExtension(tmpNode.Text) & ".bak")

            'If System.IO.File.Exists(backfile) Then
            '    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(backfile, FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
            'End If

            'Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(tmpNode.Text, backfile)
            'Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(tmpNode.Text, FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)

            'Dim str As New System.IO.MemoryStream
            Dim xmltxtwri As New XmlTextWriter(tmpNode.Text, Encoding.UTF8)
            xmltxtwri.WriteStartDocument()
            xmltxtwri.Flush()
            xmltxtwri.Close()
            Dim fs As System.IO.StreamWriter = New System.IO.StreamWriter(tmpNode.Text, True)
            fs.WriteLine()
            Dim strValue As String = dtSet.GetXml
            'For Each tmpStr As String In TextBox4.Text.Split(",")
            '    Dim Rgx As New RegularExpressions.Regex(String.Format("<{0}>(?>\n|[^*]|\*+[^*/])*?\**</{0}>", tmpStr), RegularExpressions.RegexOptions.IgnoreCase)
            '    strValue = Rgx.Replace(strValue, AddressOf InsertCDATASections)
            'Next
            strValue = strValue.Replace(String.Format("<{0}>", TextBox4.Text), String.Format("<{0}><![CDATA[", TextBox4.Text))
            strValue = strValue.Replace(String.Format("</{0}>", TextBox4.Text), String.Format("]]></{0}>", TextBox4.Text))

            fs.Write(strValue)
            '(?>\n|[^*]|\*+[^*/])*?\**

            'dtSet.WriteXml(fs)


            fs.Flush()
            fs.Close()





        Next
        MsgBox("저장 완료 ")

        Button3.PerformClick()



    End Sub





    Public Function InsertCDATASections(ByVal fs As RegularExpressions.Match) As String



        Dim tmpA As String = fs.ToString.Replace("<DATA>", "<DATA><![CDATA[")
        tmpA = tmpA.Replace("</DATA>", "]]></DATA>")

        Return tmpA

    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
       
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Dim colIdx As Integer = DirectCast(sender, DataGridView).CurrentCell.ColumnIndex
        Dim rowidx As Integer = DirectCast(sender, DataGridView).CurrentCell.RowIndex
        If DirectCast(sender, DataGridView).Columns(colIdx).DataPropertyName.IndexOf("|") > 0 Then
            If DirectCast(sender, DataGridView).Columns(colIdx).DataPropertyName.Split("|")(1).ToUpper = TextBox5.Text.ToUpper Then
                Dim frmColumn As New frmColumns(DirectCast(sender, DataGridView).Rows(rowidx).Cells(colIdx).Value)
                If frmColumn.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim strData As String = frmColumn.rtnData()
                    DirectCast(sender, DataGridView).Rows(rowidx).Cells(colIdx).Value = strData
                End If
            ElseIf DirectCast(sender, DataGridView).Columns(colIdx).DataPropertyName.Split("|")(1).ToUpper = TextBox6.Text.ToUpper Then
                Dim frmCast As New frmValueMatch(DirectCast(sender, DataGridView).Rows(rowidx).Cells(colIdx).Value)
                If frmCast.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim strData As String = frmCast.rtnData()
                    DirectCast(sender, DataGridView).Rows(rowidx).Cells(colIdx).Value = strData
                End If

            End If
        End If

    End Sub
End Class
