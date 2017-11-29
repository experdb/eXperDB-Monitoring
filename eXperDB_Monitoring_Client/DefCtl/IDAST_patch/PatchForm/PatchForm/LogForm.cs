using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iDaaS
{
    public partial class LogForm : Form
    {
        StringBuilder sbLog;
        public LogForm(StringBuilder sbLog)
        {
            InitializeComponent();
            this.sbLog = sbLog;

        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            this.tbLog.Text = sbLog.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog(); //개체 생성
            SF.Filter = "로그 파일 (*.log)|*.log"; //필터
            SF.AddExtension = true;
            
            if (SF.ShowDialog() == DialogResult.OK)
            //대화상자의 응답이 OK라면
            {
                string strSavePath = SF.FileName;
                //FileStream fsLog = null;
                StreamWriter swLog = null;
                try
                {
                    //fsLog = new FileStream(strSavePath, FileMode.OpenOrCreate, FileAccess.Write);
                    swLog = new StreamWriter(strSavePath, false, Encoding.UTF8);//(fsLog, false, Encoding.UTF8);
                    swLog.Write(sbLog);
                    swLog.Close();
                    MessageBox.Show(strSavePath+" 에 로그를 저장했습니다.");
                }
                catch
                {
                    MessageBox.Show("오류로 인하여 로그를 저장할 수 없습니다.");
                }
                /*Stream stream = File.OpenRead(@"C:\Csharp\test.txt)");
                //스트림리더 객체 생성, 인코딩은 시스템 설정 값으로
                StreamReader streamReader = new StreamReader(stream, Encoding.Default);
                string str;
                int i = 0;

                //스트림라이터 객체 생성, 인코딩은 시스템 설정 값으로 지정.
                //true는 기존 파일에 내용 더하기, false는 새로운 내용으로 덮어쓰기.
                StreamWriter streamWriter = new StreamWriter(@"C:\Csharp\test2.txt", false, Encoding.Default);
                //스트림을 다 읽어들이면 null을 반환합니다.
                while ((str = streamReader.ReadLine()) != null)*/

            }
        }
    }
}
