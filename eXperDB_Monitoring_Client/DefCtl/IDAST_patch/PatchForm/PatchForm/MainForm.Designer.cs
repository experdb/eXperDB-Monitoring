namespace iDaaS
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFunc = new System.Windows.Forms.Button();
            this.pbTask = new System.Windows.Forms.ProgressBar();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lbLog = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(360, 304);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(98, 22);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "업데이트 실행";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // pbTask
            // 
            this.pbTask.Location = new System.Drawing.Point(12, 192);
            this.pbTask.Name = "pbTask";
            this.pbTask.Size = new System.Drawing.Size(454, 18);
            this.pbTask.TabIndex = 5;
            // 
            // pnStatus
            // 
            this.pnStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatus.Controls.Add(this.picStatus);
            this.pnStatus.Controls.Add(this.lbStatus);
            this.pnStatus.Location = new System.Drawing.Point(12, 238);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(454, 52);
            this.pnStatus.TabIndex = 8;
            // 
            // picStatus
            // 
            this.picStatus.Image = global::iDaaS.Properties.Resources.ERROR;
            this.picStatus.Location = new System.Drawing.Point(12, 13);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(23, 30);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatus.TabIndex = 12;
            this.picStatus.TabStop = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(43, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 12);
            this.lbStatus.TabIndex = 11;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(12, 219);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(0, 12);
            this.lbPercentage.TabIndex = 9;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 171);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 12);
            this.lbInfo.TabIndex = 10;
            // 
            // picMain
            // 
            this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMain.Location = new System.Drawing.Point(12, 26);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(454, 132);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 11;
            this.picMain.TabStop = false;
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLog.Location = new System.Drawing.Point(23, 309);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(0, 12);
            this.lbLog.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 22);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "닫기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 345);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pbTask);
            this.Controls.Add(this.btnFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "i-Dast Update Program";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.ProgressBar pbTask;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Button btnExit;
    }
}

