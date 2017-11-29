using iDaaS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iDaaS
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : Form
    {
        delegate void SetMainFormCallback(string text);
        delegate void SetLbInfoCallback(string text);
        delegate void SetLbLogCallback(string text);
        delegate void SetLbPercentageCallback(string text);        
        delegate void SetLbStatusTextCallback(string text);
        delegate void SetpbTaskPercentageCallback(int percentage);
        delegate void SetpbTaskVisibleCallback(Boolean isSet);
        delegate void SetpbTaskStyleCallback(ProgressBarStyle style);
        delegate void SetpbTaskMarqueeCallback(int speed);
        delegate void SetpbTaskEnabledCallback(Boolean isSet);
        delegate void SetbtnFuncEnabledCallback(Boolean isSet);
        delegate void SetbtnFuncTextCallback(string text);
        delegate void SetbtnFuncClickEventCallback(EventHandler hand, Boolean isAttach);
        delegate void SetbtnExitVisibleCallback(Boolean isSet);
        delegate void SetTbMainCallBack(string text, Boolean isAppend);
        
        PatchManager pm;
        Thread workerThread;
        StringBuilder sbLog;
        private DateTime lastUpdate;
        private double lastbytes;
        /// <summary>
        /// Test용 생성자. Test 이외의 용도로 호출하지 말 것.
        /// </summary>
        public MainForm():this("E:\\previous Desktop Data\\patchtest_client")
        {
            Debug.WriteLine("Start TestMode");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strDestPath">메인 프로그램의 root 디렉토리</param>
        /// <param name="strDestVer">
        /// <para>메인 프로그램의 버전. </para>
        /// <para>형식은 iDaaSPkg_x_x_x_xxx으로, 메인 버전의 데이터만을 필요로 한다.</para>
        /// <para>ex) 1.0.0.190버전일 경우 iDaaSPkg_1_x_x_xxx </para>
        /// <para>    2.0.1.120버전의 경우 iDaaSPkg_2_x_x_xxx </para>
        /// </param>
        public MainForm(string strPath)
        {
            InitializeComponent();
            btnFunc.Enabled = false;
            sbLog = new StringBuilder();
            
            pm = new PatchManager(strPath);
            workerThread = new Thread(pm.DoWork);

            // Start the worker thread.
            pm.ValidateEndEvent += endValidate;
            pm.DownProgressChangedEvent += downProgressChanged;
            pm.DownProgressCompletedEvent += downProgressCompleted;
            pm.ConfApplyEvent += confApply;
            pm.FileApplyEvent += fileApply;
            pm.FileApplyCompletedEvent += endFileApply;
            pm.ConfApplyCompletedEvent += endConfApply;
            pm.WorkCompletedEvent += workComplete;
            lbLog.Click += lbLog_Click;

            picMain.Image = Properties.Resources.main;
            SetLbStatusText(Msg.DEF_WAIT);
            if (pm.isConfigGenuine())
            {
                if (pm.isServerAvailable())
                {
                    SetLbStatusText(Msg.DEF_READY);
                    picStatus.Image = Properties.Resources.OK;

                    btnFunc.Enabled = true;
                }
                else
                {
                    SetLbStatusText(MsgERR.ERR_NETWORK);
                    picStatus.Image = Properties.Resources.ERROR;
                }
            }
            else 
            {
                SetLbStatusText(MsgERR.ERR_SETTING);
                picStatus.Image = Properties.Resources.ERROR;
            }
        }
        void endValidate(object sender, ValidateEndEventArgs e)
        {
            Debug.WriteLine("ValidateEnd");
            SetpbTaskStyle(ProgressBarStyle.Continuous);
            SetpbTaskMarquee(0);
            
            if(e.isError)
                MessageBox.Show(MsgERR.ERR_RUN + "\n" + Msg.DEF_RESTART);
        }
        void downProgressChanged(object sender, DownProgressChangedEventArgs e)
        {
            SetpbTaskPercentage(e.Percentage);
            string strPercent="";
            string strUnit = "KB";
            int unitVal=1024;

            DateTime now = DateTime.Now;
            TimeSpan interval = now - lastUpdate;
            if (interval.Milliseconds > 500 || e.Percentage == 100)
            {
                double timeDiff = interval.TotalSeconds;
                double sizeDiff = e.bytesIn - lastbytes;
                double speed = Math.Floor((double)(sizeDiff) / timeDiff);
                lastbytes = e.bytesIn;
                lastUpdate = now;
                setLbInfoText(Msg.DEF_DOWNLOADING);
                
                if (e.progressMaxValue > (1000 * 1000))
                {
                    strUnit = "MB";
                    unitVal = 1024 * 1024;
                }
                strPercent = (Math.Round(Math.Round(e.bytesIn, 1) / unitVal)) + strUnit + "/" +
                    (Math.Round(Math.Round(e.progressMaxValue,0) / unitVal)) + strUnit;
                double tempSpeed = Math.Round(Math.Round(speed, 2) / (1024));
                if(tempSpeed>1020)
                    SetLbPercentageText(strPercent + " (" + (Math.Round(Math.Round(speed, 2) / (1024 * 1024))) + " MB/s)");
                else
                    SetLbPercentageText(strPercent + " (" + (Math.Round(Math.Round(speed, 2) / (1024 ))) + " KB/s)");
                setMainFormText("( " + e.Percentage + "% ) "+Msg.DEF_TITLE);
            }
        }
        
        void downProgressCompleted(object sender, DownProgressCompletedEventArgs e)
        {
            Debug.WriteLine("DownProgressCompleted");
            SetbtnFuncEnabled(false);
            SetpbTaskPercentage(100);
            setLbInfoText(Msg.DEF_COMMITTING);
            sbLog.AppendLine(System.DateTime.Today.ToString() + " - " + Msg.DEF_DOWNLOAD);
        }
        void confApply(object sender, ConfApplyEventArgs e)
        {
            Debug.WriteLine("ConfApply");
            string strApply = Msg.DEF_SETCOMMIT+" : " + e.applyMsg;
            sbLog.AppendLine(strApply);
            setLbInfoText(strApply);
        }
        void fileApply(object sender, FileApplyEventArgs e)
        {
            Debug.WriteLine("FileApply");
            string strApply = "";
            if (e.step == FileApplyEventArgs.STEP_COPY)
            {
                strApply = Msg.DEF_FILECOMMIT+" : " + e.applyMsg;
                sbLog.Append(strApply);
                setLbInfoText(strApply);
            }
            else
            {
                if (e.isError)
                    sbLog.AppendLine(" - " + MsgERR.ERR_FAIL + " : \n" + e.applyMsg);
                else
                    sbLog.AppendLine(" - " + Msg.DEF_SUCCESS);
            }
            
        }
        void endConfApply(object sender, ConfApplyCompletedEventArgs e)
        {
            Debug.WriteLine("ConfApplyCompleted");
            string result = "";
            if (!e.isError)
            {
                sbLog.AppendLine(System.DateTime.Today.ToString() + " - " + Msg.DEF_SETCONFCOMPLETE);
                result = Msg.DEF_SETCOMPLETE+"\n"+Msg.DEF_RESTART;                
            }
            else
            {
                if (e.errorMsg.Trim().Equals(""))
                    result = MsgERR.ERR_RUN + "\n" + Msg.DEF_RESTART;
                else
                {
                    result = MsgERR.ERR_FOLLOW + " : \n" + e.errorMsg;
                    
                }
                SetLbStatusText(MsgForm.PROBLEM);
                picStatus.Image = Properties.Resources.ERROR;
            }
            setLbInfoText(MsgForm.COMPLETE);            
            MessageBox.Show(result);
            SetbtnFuncClickEvent(btnFunc_Click, false);
            SetbtnFuncClickEvent(btnFunc_Click_Cancel, false);            
            SetbtnFuncEnabled(true);
            SetbtnFuncText(MsgForm.CLOSE);
            SetbtnFuncClickEvent(btnFunc_Click_Exit, true);
            setLbLogText(MsgForm.LOG);
        }        
        void endFileApply(object sender, FileApplyCompletedEventArgs e)
        {
            sbLog.AppendLine(System.DateTime.Today.ToString() + " - " + e.errorMsg);
            /*
            Debug.WriteLine("FileApplyCompleted");
            string result = "";
            if (!e.isError)
            {
                result = "업데이트가 성공적으로 완료되었습니다.";
            }
            else 
            {
                if (e.errorMsg.Trim().Equals(""))
                    result = "실행 중 문제가 발생하였습니다.\n프로그램을 다시 실행해 주세요.";
                else
                    result = "다음과 같은 에러가 발생하였습니다 : \n" + e.errorMsg;
            }
            setLbInfoText("업데이트 완료");
            sbLog.AppendLine(result);
            MessageBox.Show(result);//.Temp.ToString());
            Application.Exit();*/
        }
        void workComplete(object sender, WorkCompletedEventArgs e)
        {
            Debug.WriteLine("WorkCompletedEvent");
            string result = "";
            if (!e.isError)
            {
                SetLbStatusText(MsgForm.COMPLETEUP);
                result = Msg.DEF_SETCOMPLETE+".\n"+Msg.DEF_RESTART;        
            }
            else
            {
                SetLbStatusText(MsgForm.PROBLEM);
                picStatus.Image = Properties.Resources.ERROR;
                if (e.errorMsg.Trim().Equals(""))
                    result = MsgERR.ERR_RUN+"\n" + Msg.DEF_RESTART;
                else
                    result = e.errorMsg;
            }
            MessageBox.Show(result);//.Temp.ToString());
            if (e.isError)
                sbLog.AppendLine(System.DateTime.Today.ToString() + " - "+e.errorMsg);
            sbLog.AppendLine(System.DateTime.Today.ToString() + " - " + Msg.DEF_PROCCOMPLETE);
            SetbtnFuncClickEvent(btnFunc_Click, false);
            SetbtnFuncClickEvent(btnFunc_Click_Cancel,false);
            SetbtnFuncEnabled(true);
            SetbtnFuncText(MsgForm.CLOSE);
            SetbtnFuncClickEvent(btnFunc_Click_Exit, true);
            setLbLogText(MsgForm.LOG);            
        }
        private void btnFunc_Click_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnFunc_Click_Cancel(object sender, EventArgs e)
        {
            sbLog.AppendLine(MsgForm.CANCEL);
            SetLbStatusText(MsgForm.UPDATECANCEL);
            picStatus.Image = Properties.Resources.ERROR;
            workerThread.Abort();
            SetpbTaskStyle(ProgressBarStyle.Continuous);
            SetpbTaskPercentage(100);
            SetpbTaskMarquee(0);
            MessageBox.Show(Msg.DEF_CANCEL);
            SetbtnFuncClickEvent(btnFunc_Click, false);
            SetbtnFuncClickEvent(btnFunc_Click_Cancel, false);
            SetbtnFuncEnabled(true);
            SetbtnFuncText(MsgForm.CLOSE);
            SetbtnFuncClickEvent(btnFunc_Click_Exit, true);
            
            setLbLogText(MsgForm.LOG);            
        }
        private void btnFunc_Click(object sender, EventArgs e)
        {
            SetpbTaskVisible(true);
            SetpbTaskStyle(ProgressBarStyle.Marquee);
            SetpbTaskMarquee(50);
            SetpbTaskEnabled(true);
            SetLbStatusText(MsgForm.UPDATEPROGRESS);
            setLbInfoText(MsgForm.DATAWAIT);
            SetbtnFuncText(MsgForm.CANCEL);
            SetbtnFuncClickEvent(btnFunc_Click, false);
            SetbtnFuncClickEvent(btnFunc_Click_Cancel, true);
            SetbtnExitVisible(false);
            sbLog.AppendLine(System.DateTime.Today.ToString() + " - " + Msg.DEF_PROCSTART);
            workerThread.Start();
        }
        private void lbLog_Click(object sender, EventArgs e)
        {
            LogForm lf = new LogForm(sbLog);
            lf.ShowDialog(this);
        }
        private void setMainFormText(string text)
        {
            if (this.InvokeRequired)
            {
                SetMainFormCallback d = new SetMainFormCallback(setMainFormText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text = text;
                this.Update();
            }
        }
        private void setLbInfoText(string text)
        {
            if (this.lbInfo.InvokeRequired)
            {
                SetLbInfoCallback d = new SetLbInfoCallback(setLbInfoText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbInfo.Text = text;
                this.lbInfo.Update();
            }
        }
        private void setLbLogText(string text)
        {
            if (this.lbLog.InvokeRequired)
            {
                SetLbLogCallback d = new SetLbLogCallback(setLbLogText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbLog.Text = text;
                this.lbLog.Update();
            }
        }
        private void SetLbPercentageText(string text)
        {
            if (this.lbPercentage.InvokeRequired)
            {
                SetLbPercentageCallback d = new SetLbPercentageCallback(SetLbPercentageText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbPercentage.Text = text;
                this.lbPercentage.Update();
            }
        }
        private void SetLbStatusText(string text)
        {
            if (this.lbStatus.InvokeRequired)
            {
                SetLbStatusTextCallback d = new SetLbStatusTextCallback(SetLbStatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbStatus.Text = text;
                this.lbStatus.Update();
            }
        }
        private void SetpbTaskPercentage(int percentage)
        {
            if (this.pbTask.InvokeRequired)
            {
                SetpbTaskPercentageCallback d = new SetpbTaskPercentageCallback(SetpbTaskPercentage);
                this.Invoke(d, new object[] { percentage});
            }
            else
            {
                this.pbTask.Value = percentage;
            }
        }        
        private void SetpbTaskVisible(Boolean isSet)
        {
            if (this.pbTask.InvokeRequired)
            {
                SetpbTaskVisibleCallback d = new SetpbTaskVisibleCallback(SetpbTaskVisible);
                this.Invoke(d, new object[] { isSet });
            }
            else
            {
                this.pbTask.Visible = isSet;
            }
        }        
        private void SetpbTaskStyle(ProgressBarStyle style)
        {
            if (this.pbTask.InvokeRequired)
            {
                SetpbTaskStyleCallback d = new SetpbTaskStyleCallback(SetpbTaskStyle);
                this.Invoke(d, new object[] { style });
            }
            else
            {
                this.pbTask.Style = style;
            }
        }
        private void SetpbTaskMarquee(int speed)
        {
            if (this.pbTask.InvokeRequired)
            {
                SetpbTaskMarqueeCallback d = new SetpbTaskMarqueeCallback(SetpbTaskMarquee);
                this.Invoke(d, new object[] { speed });
            }
            else
            {
                this.pbTask.MarqueeAnimationSpeed = speed;//.Value = percentage;
            }
        }
        private void SetpbTaskEnabled(Boolean isSet)
        {
            if (this.pbTask.InvokeRequired)
            {
                SetpbTaskEnabledCallback d = new SetpbTaskEnabledCallback(SetpbTaskEnabled);
                this.Invoke(d, new object[] { isSet });
            }
            else
            {
                this.pbTask.Enabled = isSet;
            }
        }
        private void SetbtnFuncEnabled(Boolean isSet)
        {
            if (this.btnFunc.InvokeRequired)
            {
                SetbtnFuncEnabledCallback d = new SetbtnFuncEnabledCallback(SetbtnFuncEnabled);
                this.Invoke(d, new object[] { isSet });
            }
            else
            {
                this.btnFunc.Enabled = isSet;
            }
        }
        private void SetbtnFuncText(string text)
        {
            if (this.btnFunc.InvokeRequired)
            {
                SetbtnFuncTextCallback d = new SetbtnFuncTextCallback(SetbtnFuncText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.btnFunc.Text = text;
            }
        }
        private void SetbtnFuncClickEvent(EventHandler hand, Boolean isAttach)//
        {
            if (this.btnFunc.InvokeRequired)
            {
                SetbtnFuncClickEventCallback d = new SetbtnFuncClickEventCallback(SetbtnFuncClickEvent);
                this.Invoke(d, new object[] { hand,isAttach });
            }
            else
            {
                if(isAttach)
                    this.btnFunc.Click += hand;
                else
                    this.btnFunc.Click -= hand;
            }
        }
        private void SetbtnExitVisible(Boolean isSet)
        {
            if (this.btnExit.InvokeRequired)
            {
                SetbtnExitVisibleCallback d = new SetbtnExitVisibleCallback(SetbtnExitVisible);
                this.Invoke(d, new object[] { isSet });
            }
            else
            {
                this.btnExit.Visible = isSet;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
