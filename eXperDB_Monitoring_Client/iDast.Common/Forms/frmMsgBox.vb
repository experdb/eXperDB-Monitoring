Public NotInheritable Class frmMsgBox
    Public Sub New(description As String, title As String)
        InitializeComponent()
        Me.TextBoxDescription.Text = description
        Me.Text = title
    End Sub
    Private Sub frmMsgBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 폼의 제목을 설정합니다
        Dim ApplicationTitle As String
        If _myApplication.Title <> "" Then
            ApplicationTitle = _myApplication.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(_myApplication.AssemblyName)
        End If
        Me.Text = String.Format("정보 {0}", ApplicationTitle)
        ' 정보 상자에 표시되는 모든 텍스트를 초기화합니다.
        ' TODO: "프로젝트" 메뉴에서 선택하여 표시되는 프로젝트 속성 대화 상자의 "응용 프로그램" 창에서 응용 프로그램의 
        '    어셈블리 정보를 사용자 지정합니다.
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private _myApplication As ApplicationServices.AssemblyInfo
    Public Shadows Function ShowDialog(myApplication As ApplicationServices.AssemblyInfo) As System.Windows.Forms.DialogResult
        _myApplication = myApplication
        Return MyBase.ShowDialog()
    End Function

End Class
