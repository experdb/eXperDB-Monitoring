Public Class Treeview
    Inherits Windows.Forms.TreeView

    Dim m_BretChkAct As Boolean = False

    'Protected Overrides Sub OnAfterCheck(e As Windows.Forms.TreeViewEventArgs)
    '    MyBase.OnAfterCheck(e)
    '    If Me.CheckBoxes = True Then

    '        'For Each tmpNode As System.Windows.Forms.TreeNode In e.Node.Nodes
    '        '    tmpNode.Checked = e.Node.Checked
    '        'Next



    '        'Dim arrNodes As Array = FindText(e.Node.Text)
    '        'For Each tmpNode As System.Windows.Forms.TreeNode In arrNodes
    '        '    If tmpNode.FullPath <> e.Node.FullPath Then
    '        '        If tmpNode.Checked <> e.Node.Checked Then
    '        '            tmpNode.Checked = e.Node.Checked
    '        '        End If

    '        '    End If
    '        'Next
    '    End If

    'End Sub

   

     
    Protected Overrides Sub OnAfterSelect(e As Windows.Forms.TreeViewEventArgs)

        Dim selNode As Windows.Forms.TreeNode = e.Node
        selNode.SelectedImageIndex = selNode.ImageIndex
        MyBase.OnAfterSelect(e)
    End Sub

     

    Public Function GetCheckedNodes(Optional ByVal Checked As Boolean = True) As Array
        Dim rtnArr As New ArrayList
        Dim arrPnodes As New ArrayList

        For Each tmpNode As Windows.Forms.TreeNode In Me.Nodes
            If tmpNode.Checked = True Then
                rtnArr.Add(tmpNode)
            End If
            If Me.hasChild(tmpNode) = True Then
                arrPnodes.Add(tmpNode)
            End If
        Next


        For Each pNode As Windows.Forms.TreeNode In arrPnodes
            Dim tmpArr As Array = Me.GetCheckedNodes(pNode, Checked)
            For Each tmpChildNode As Windows.Forms.TreeNode In tmpArr
                rtnArr.Add(tmpChildNode)
            Next
        Next

        Return rtnArr.ToArray

    End Function
    Public Function GetCheckedNodes(ByVal pNode As Windows.Forms.TreeNode, Optional ByVal Checked As Boolean = True) As Array
        Dim rtnArr As New ArrayList
        Dim arrPNodes As New ArrayList
        For Each tmpNode As Windows.Forms.TreeNode In pNode.Nodes
            If tmpNode.Checked = True Then
                rtnArr.Add(tmpNode)
            End If
            If Me.hasChild(tmpNode) = True Then
                arrPNodes.Add(tmpNode)
            End If
        Next

        For Each tmpNode As Windows.Forms.TreeNode In arrPNodes
            Dim tmpArr As Array = Me.GetCheckedNodes(tmpNode, Checked)
            For Each tmpChildNode As Windows.Forms.TreeNode In tmpArr
                rtnArr.Add(tmpChildNode)
            Next
        Next
        Return rtnArr.ToArray
    End Function


    Public Function FindText(ByVal strText As String, Optional ByVal CompareText As Boolean = True, Optional ByVal CompleteText As Boolean = False) As Array
        Dim rtnArr As New ArrayList
        Dim arrPnodes As New ArrayList

        For Each tmpNode As Windows.Forms.TreeNode In Me.Nodes

            If CompleteText = True Then
                If tmpNode.Text = strText Then
                    rtnArr.Add(tmpNode)
                End If
            Else
                If CompareText = True Then
                    If tmpNode.Text.ToUpper.IndexOf(strText.ToUpper) > -1 Then
                        rtnArr.Add(tmpNode)
                    End If
                Else
                    If tmpNode.Text.IndexOf(strText) > -1 Then
                        rtnArr.Add(tmpNode)
                    End If
                End If
            End If
            'Dim ChildNode As Windows.Forms.TreeNode = tmpNode.FirstNode
            'If Not ChildNode Is Nothing Then
            If Me.hasChild(tmpNode) = True Then
                arrPnodes.Add(tmpNode)
                'Dim tmpArr As Array = Me.FindText(tmpNode, strText, CompareText, CompleteText)
                'For Each tmpChildNode As Windows.Forms.TreeNode In tmpArr
                '    rtnArr.Add(tmpChildNode)
                'Next
            End If

        Next


        For Each tmpNode As Windows.Forms.TreeNode In arrPnodes
            Dim tmpArr As Array = Me.FindText(tmpNode, strText, CompareText, CompleteText)
            For Each tmpChildNode As Windows.Forms.TreeNode In tmpArr
                rtnArr.Add(tmpChildNode)
            Next
        Next

        'If rtnArr.Count = 0 Then
        '    Return Nothing
        'Else
        Return rtnArr.ToArray
        'End If

    End Function

    Private Function FindText(ByVal stNode As Windows.Forms.TreeNode, ByVal strText As String, Optional ByVal CompareText As Boolean = True, Optional ByVal CompleteText As Boolean = False) As Array
        Dim rtnArr As New ArrayList
        Dim arrPNodes As New ArrayList
        For Each tmpNode As Windows.Forms.TreeNode In stNode.Nodes


            If CompleteText = True Then
                If tmpNode.Text = strText Then
                    rtnArr.Add(tmpNode)
                End If
            Else
                If CompareText = True Then
                    If tmpNode.Text.ToUpper.IndexOf(strText.ToUpper) > -1 Then
                        rtnArr.Add(tmpNode)
                    End If
                Else
                    If tmpNode.Text.IndexOf(strText) > -1 Then
                        rtnArr.Add(tmpNode)
                    End If
                End If
            End If
            'Dim ChildNode As Windows.Forms.TreeNode = tmpNode.FirstNode
            If Me.hasChild(tmpNode) = True Then '  Not ChildNode Is Nothing Then
                arrPNodes.Add(tmpNode)
                'Dim tmpArr As Array = Me.FindText(tmpNode, strText, CompareText, CompleteText)
                'If Not tmpArr Is Nothing Then
                '    For Each tmpChildNode As Windows.Forms.TreeNode In tmpArr
                '        rtnArr.Add(tmpChildNode)
                '    Next
                'End If
            End If


        Next
        For Each tmpNode As Windows.Forms.TreeNode In arrPnodes
            Dim tmpArr As Array = Me.FindText(tmpNode, strText, CompareText, CompleteText)
            For Each tmpChildNode As Windows.Forms.TreeNode In tmpArr
                rtnArr.Add(tmpChildNode)
            Next
        Next

        'If rtnArr.Count = 0 Then
        '    Return Nothing
        'Else
        Return rtnArr.ToArray
        'End If


    End Function

    Public Function hasChild(ByVal tvNode As Windows.Forms.TreeNode) As Boolean
        If tvNode.FirstNode Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function GetSrtlstFindText(ByVal strTxt As String, Optional ByVal CompareText As Boolean = True, Optional ByVal CompleteText As Boolean = False) As SortedList
        Dim srtLst As New SortedList
        Dim arrNodes As Array = Me.FindText(strTxt, CompareText, CompleteText)
        For Each PartNode As Windows.Forms.TreeNode In arrNodes
            Dim srtKey As String = PartNode.Text.ToUpper
            Dim tmparrNodes As New ArrayList
            If srtLst.Item(srtKey) Is Nothing Then
                tmparrNodes.Add(PartNode)
                srtLst.Add(srtKey, tmparrNodes)
            Else
                tmparrNodes = srtLst.Item(srtKey)
                tmparrNodes.Add(PartNode)
                srtLst.Item(srtKey) = tmparrNodes
            End If
        Next

        Return srtLst
    End Function
    Public Function GetSrtlstFindText(ByVal arrstrTxt As Array, Optional ByVal CompareText As Boolean = True, Optional ByVal CompleteText As Boolean = False) As SortedList
        Dim srtLst As New SortedList
        For Each strText As String In arrstrTxt
            Dim arrNodes As Array = Me.FindText(strText, CompareText, CompleteText)
            For Each PartNode As Windows.Forms.TreeNode In arrNodes
                Dim srtKey As String = PartNode.Text.ToUpper
                Dim tmparrNodes As New ArrayList
                If srtLst.Item(srtKey) Is Nothing Then
                    tmparrNodes.Add(PartNode)
                    srtLst.Add(srtKey, tmparrNodes)
                Else
                    tmparrNodes = srtLst.Item(srtKey)
                    tmparrNodes.Add(PartNode)
                    srtLst.Item(srtKey) = tmparrNodes
                End If
            Next
        Next


        Return srtLst
    End Function

    Public Function GetSrtlstPatentNodes() As SortedList
        Dim PNodes As Array = GetParentNodes()
        Dim srtLst As New SortedList
        For Each tmpNode As Windows.Forms.TreeNode In PNodes
            Dim srtKey As String = tmpNode.Text.ToUpper
            If srtLst.Item(srtKey) Is Nothing Then
                srtLst.Add(srtKey, tmpNode)
            End If
        Next

        Return srtLst
    End Function


    Public Function GetParentNodes() As Array
        Dim pNodes As New ArrayList
        For Each tmpNode As Windows.Forms.TreeNode In Me.Nodes
            If Me.hasChild(tmpNode) = True Then
                pNodes.Add(tmpNode)

            End If
        Next

        Dim arrNodes As ArrayList = pNodes.Clone
        For Each TopNode As Windows.Forms.TreeNode In pNodes
            Dim tmpArr As Array = fn_GetPnodes(TopNode)

            For Each tmpNode As Windows.Forms.TreeNode In tmpArr
                arrNodes.Add(tmpNode)
            Next

        Next

        Return arrNodes.ToArray

    End Function

    Private Function fn_GetPnodes(ByVal Pnode As Windows.Forms.TreeNode) As Array
        Dim pNodes As New ArrayList


        For Each tmpNode As Windows.Forms.TreeNode In Pnode.Nodes
            If Me.hasChild(tmpNode) = True Then
                pNodes.Add(tmpNode)
            End If
        Next

        Dim arrNodes As ArrayList = pNodes.Clone

        For Each Topnode As Windows.Forms.TreeNode In pNodes
            Dim tmpArr As Array = fn_GetPnodes(Topnode)
            For Each tmpNode As Windows.Forms.TreeNode In tmpArr
                arrNodes.Add(tmpNode)
            Next
        Next


        Return arrNodes.ToArray



    End Function
     
    Protected Overrides Sub OnMouseDown(e As Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.SelectedNode = Me.GetNodeAt(New Drawing.Point(e.X, e.Y))
        End If
        MyBase.OnMouseDown(e)
    End Sub


    Public Function AddNodeUsingPath(ByVal TreePath As String, ByVal objTag As Object, Optional ByVal ImgIdx As Integer = -1) As Windows.Forms.TreeNode
        Dim arrNodeNms As String() = TreePath.Split(Me.PathSeparator)
        Dim pNode As Windows.Forms.TreeNode = Nothing
        For i As Integer = 0 To arrNodeNms.Count - 2
            Dim tmpStr As String = arrNodeNms(i)
            Dim cNode As Windows.Forms.TreeNode = Nothing
            If pNode Is Nothing Then
                Dim FndNodes As Windows.Forms.TreeNode() = Me.Nodes.Find(tmpStr, False)
                If FndNodes.Count > 0 Then
                    cNode = FndNodes(0)
                Else
                    cNode = Me.Nodes.Add(tmpStr, tmpStr, ImgIdx)
                End If

            Else
                Dim FndNodes As Windows.Forms.TreeNode() = pNode.Nodes.Find(String.Format("{0}{1}{2}", pNode.FullPath, Me.PathSeparator, tmpStr), False)
                If FndNodes.Count > 0 Then
                    cNode = FndNodes(0)
                Else
                    cNode = pNode.Nodes.Add(String.Format("{0}{1}{2}", pNode.FullPath, Me.PathSeparator, tmpStr), tmpStr, ImgIdx)
                End If

            End If
            pNode = cNode
        Next
        Dim strNodeNm As String = arrNodeNms(arrNodeNms.Count - 1)
        If pNode IsNot Nothing Then
            Dim fNode As Windows.Forms.TreeNode() = pNode.Nodes.Find(String.Format("{0}{1}{2}", pNode.FullPath, Me.PathSeparator, strNodeNm), False)
            Dim LastNode As Windows.Forms.TreeNode = Nothing
            If fNode.Count > 0 Then
                LastNode = fNode(0)
                LastNode.Tag = objTag
            Else
                LastNode = pNode.Nodes.Add(String.Format("{0}{1}{2}", pNode.FullPath, Me.PathSeparator, strNodeNm), strNodeNm, ImgIdx)
                LastNode.Tag = objTag
            End If
            Return LastNode
        
        Else
            Dim cNode As Windows.Forms.TreeNode = Me.Nodes.Add(strNodeNm, strNodeNm, ImgIdx)
            cNode.Tag = objTag
            Return cNode
        End If

    End Function



    Protected Overrides Sub OnDrawNode(e As Windows.Forms.DrawTreeNodeEventArgs)
        MyBase.OnDrawNode(e)
        Dim rect As Drawing.Rectangle = e.Node.Bounds
        Dim tv As Treeview = Me

        Dim intIndentLen As Integer = tv.Indent
        Dim ImgSize As New Drawing.Size(0, 0)
        If tv.ImageList IsNot Nothing Then
            ImgSize = tv.ImageList.ImageSize
        End If




        Dim NodeArea As New Drawing.Rectangle(e.Node.Bounds.Left - intIndentLen - ImgSize.Width, e.Node.Bounds.Top, intIndentLen, e.Bounds.Height)
        NodeArea.Offset(-4, 0)
        Dim DrawNodeArea As New Drawing.Rectangle(NodeArea.Left + NodeArea.Width / 2 - 4, NodeArea.Top + NodeArea.Height / 2 - 4, 8, 8)

        ' e.Graphics.DrawRectangle(New Pen(Brushes.Blue), NodeArea)
        'e.Graphics.DrawLine(New Pen(Brushes.Black), New Point(NodeArea.Left + NodeArea.Width / 2, NodeArea.Top), New Point(NodeArea.Left + NodeArea.Width / 2, NodeArea.Bottom))
        'e.Graphics.DrawLine(New Pen(Brushes.Gray), New Point(NodeArea.Left, NodeArea.Top + NodeArea.Height / 2), New Point(NodeArea.Right, NodeArea.Top + NodeArea.Height / 2))
        If e.Node.GetNodeCount(False) > 0 Then

            If e.Node.IsExpanded Then
                e.Graphics.FillPolygon(New Drawing.SolidBrush(Drawing.SystemColors.WindowText), New Drawing.PointF() _
                                                                                {New Drawing.PointF(DrawNodeArea.Left, DrawNodeArea.Bottom), _
                                                                                 New Drawing.PointF(DrawNodeArea.Right, DrawNodeArea.Bottom), _
                                                                                 New Drawing.PointF(DrawNodeArea.Right, DrawNodeArea.Top), _
                                                                                 New Drawing.PointF(DrawNodeArea.Left, DrawNodeArea.Bottom) _
                                                                                })

            Else

                'e.Graphics.FillPolygon(New SolidBrush(SystemColors.GrayText), New Point() _
                '                                                                {New Point(DrawNodeArea.Left, DrawNodeArea.Top), _
                '                                                                 New Point(DrawNodeArea.Left, DrawNodeArea.Bottom), _
                '                                                                 New Point(DrawNodeArea.Right, DrawNodeArea.Top), _
                '                                                                 New Point(DrawNodeArea.Left, DrawNodeArea.Top) _
                '                                                                })

                e.Graphics.DrawPolygon(New Drawing.Pen(Drawing.SystemColors.GrayText), New Drawing.PointF() _
                                                                              {New Drawing.PointF(DrawNodeArea.Left, DrawNodeArea.Top), _
                                                                               New Drawing.PointF(DrawNodeArea.Left, DrawNodeArea.Bottom), _
                                                                               New Drawing.PointF(DrawNodeArea.Right, DrawNodeArea.Top + DrawNodeArea.Height / 2), _
                                                                               New Drawing.PointF(DrawNodeArea.Left, DrawNodeArea.Top) _
                                                                              })
            End If
        End If



        Dim ImgArea As New Drawing.Rectangle(e.Node.Bounds.Left - ImgSize.Width, e.Node.Bounds.Top, ImgSize.Width, e.Bounds.Height)
        ImgArea.Offset(-4, 0)
        ImgArea.Inflate(-1, -1)


        If tv.ImageList IsNot Nothing Then
            Dim tmpImg As Drawing.Image = Nothing
            If e.Node.ImageIndex >= 0 AndAlso tv.ImageList.Images.Count > e.Node.ImageIndex Then

                tmpImg = tv.ImageList.Images(e.Node.ImageIndex)
            Else
                If tv.ImageList.Images.Count > 0 Then
                    tmpImg = tv.ImageList.Images(0)
                End If
            End If
            If tmpImg IsNot Nothing Then
                e.Graphics.DrawImage(tmpImg, ImgArea)
            End If
        End If


        'e.Graphics.DrawRectangle(New Pen(Brushes.Orange), ImgArea)


        'e.Graphics.DrawRectangle(New Pen(Brushes.Red), rect)
       

        If e.Node.IsSelected Then
            e.Graphics.FillRectangle(Drawing.SystemBrushes.Highlight, rect)
            Windows.Forms.TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont, e.Node.Bounds, Drawing.SystemColors.HighlightText, Drawing.SystemColors.Highlight, Windows.Forms.TextFormatFlags.Default Or Windows.Forms.TextFormatFlags.VerticalCenter)
        Else
            Windows.Forms.TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont, e.Node.Bounds, e.Node.ForeColor, e.Node.BackColor, Windows.Forms.TextFormatFlags.Default Or Windows.Forms.TextFormatFlags.VerticalCenter)
        End If



    End Sub


End Class
