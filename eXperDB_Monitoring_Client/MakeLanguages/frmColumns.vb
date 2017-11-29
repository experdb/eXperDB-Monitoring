Public Class frmColumns

    Private Sub frmColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal Columnvalue As String)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        Dim arrValue As String() = Columnvalue.Split(";")
        For Each tmpStr As String In arrValue

            
            Me.DataGridView1.Rows.Add(tmpStr.Split("|"))
        Next


    End Sub

    Public Function rtnData() As String
        Dim rtnValue As New ArrayList

        For Each tmpRow As DataGridViewRow In Me.DataGridView1.Rows
            If tmpRow.IsNewRow = False Then
                Dim ArrValues As New ArrayList
                For i As Integer = 0 To Me.DataGridView1.Columns.Count - 1
                    ArrValues.Add(tmpRow.Cells(i).Value)
                Next

                rtnValue.Add(String.Join("|", ArrValues.ToArray))
            End If
        Next

        Return String.Join(";", rtnValue.ToArray)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

   
End Class