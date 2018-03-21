Public NotInheritable Class frmSplashScreen

    'TODO: 프로젝트 디자이너에서 "프로젝트" 메뉴의 "속성"을 선택하여 표시된 "응용 프로그램" 탭에서
    '  이 폼을 응용 프로그램의 시작 화면으로 쉽게 설정할 수 있습니다.


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '응용 프로그램의 어셈블리 정보에 따라 런타임에 대화 상자 텍스트를 설정합니다.  

        'TODO: "프로젝트" 메뉴에서 선택하여 표시된 프로젝트 속성 대화 상자의 "응용 프로그램" 창에서 응용 프로그램의
        '  어셈블리 정보를 사용자 지정합니다.

        '응용 프로그램 제목
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    '응용 프로그램 제목이 없는 경우 확장명 없이 응용 프로그램 이름을 사용합니다.
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        '디자인 타임에 버전 제어에 설정된 텍스트를 서식 지정 문자열로 사용하여 버전 정보의 서식을
        '  지정합니다. 이렇게 하면 필요한 경우 효과적인 지역화가 가능합니다.
        '  다음 코드를 사용하고 버전 제어의 디자인 타임 텍스트를 
        '  "Version {0}.{1:00}.{2}.{3}" 또는 이와 비슷한 형식으로 변경하여 빌드 정보와 수정 정보를 포함할 수 있습니다.
        '  자세한 내용은 도움말의 String.Format()을 참조하십시오.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        '저작권 정보
        'Copyright.Text = My.Application.Info.Copyright

        'Me.TransparencyKey = Color.Black
        'Me.BackColor = Color.Black

    End Sub

End Class
