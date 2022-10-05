namespace WorkTimer
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbtnExit = new System.Windows.Forms.PictureBox();
            this.picbtnHome = new System.Windows.Forms.PictureBox();
            this.groupBox_Btns = new System.Windows.Forms.GroupBox();
            this.btnSetWorkingDuration = new System.Windows.Forms.Button();
            this.btnSetMolaDuration = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.timerCTime = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerWorkingUser = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.lbl_ReamingTime = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnHome)).BeginInit();
            this.groupBox_Btns.SuspendLayout();
            this.groupBox_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblCurrentDate);
            this.panelTop.Controls.Add(this.lblCurrentTime);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.picbtnExit);
            this.panelTop.Controls.Add(this.picbtnHome);
            this.panelTop.Location = new System.Drawing.Point(12, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(775, 33);
            this.panelTop.TabIndex = 0;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentDate.Location = new System.Drawing.Point(433, 11);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(31, 17);
            this.lblCurrentDate.TabIndex = 2;
            this.lblCurrentDate.Text = "Null";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentTime.Location = new System.Drawing.Point(339, 2);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(98, 28);
            this.lblCurrentTime.TabIndex = 2;
            this.lblCurrentTime.Text = "HH:mm:ss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work Timer";
            // 
            // picbtnExit
            // 
            this.picbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbtnExit.Image = global::WorkTimer.Properties.Resources.close;
            this.picbtnExit.Location = new System.Drawing.Point(748, 6);
            this.picbtnExit.Name = "picbtnExit";
            this.picbtnExit.Size = new System.Drawing.Size(24, 24);
            this.picbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbtnExit.TabIndex = 1;
            this.picbtnExit.TabStop = false;
            this.picbtnExit.Click += new System.EventHandler(this.picbtnExit_Click);
            // 
            // picbtnHome
            // 
            this.picbtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbtnHome.Image = global::WorkTimer.Properties.Resources.icon;
            this.picbtnHome.Location = new System.Drawing.Point(3, 6);
            this.picbtnHome.Name = "picbtnHome";
            this.picbtnHome.Size = new System.Drawing.Size(24, 24);
            this.picbtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbtnHome.TabIndex = 0;
            this.picbtnHome.TabStop = false;
            // 
            // groupBox_Btns
            // 
            this.groupBox_Btns.Controls.Add(this.btnSetWorkingDuration);
            this.groupBox_Btns.Controls.Add(this.btnSetMolaDuration);
            this.groupBox_Btns.Controls.Add(this.btn_Reset);
            this.groupBox_Btns.Controls.Add(this.btn_StartStop);
            this.groupBox_Btns.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_Btns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox_Btns.Location = new System.Drawing.Point(15, 66);
            this.groupBox_Btns.Name = "groupBox_Btns";
            this.groupBox_Btns.Size = new System.Drawing.Size(170, 363);
            this.groupBox_Btns.TabIndex = 1;
            this.groupBox_Btns.TabStop = false;
            this.groupBox_Btns.Text = "Hızlı İşlemler";
            // 
            // btnSetWorkingDuration
            // 
            this.btnSetWorkingDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorkingDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnSetWorkingDuration.Location = new System.Drawing.Point(23, 195);
            this.btnSetWorkingDuration.Name = "btnSetWorkingDuration";
            this.btnSetWorkingDuration.Size = new System.Drawing.Size(124, 63);
            this.btnSetWorkingDuration.TabIndex = 0;
            this.btnSetWorkingDuration.Text = "Çalışma Süresi";
            this.btnSetWorkingDuration.UseVisualStyleBackColor = true;
            this.btnSetWorkingDuration.Click += new System.EventHandler(this.btnSetWorkingDuration_Click);
            // 
            // btnSetMolaDuration
            // 
            this.btnSetMolaDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMolaDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnSetMolaDuration.Location = new System.Drawing.Point(23, 279);
            this.btnSetMolaDuration.Name = "btnSetMolaDuration";
            this.btnSetMolaDuration.Size = new System.Drawing.Size(124, 41);
            this.btnSetMolaDuration.TabIndex = 0;
            this.btnSetMolaDuration.Text = "Mola Süresi";
            this.btnSetMolaDuration.UseVisualStyleBackColor = true;
            this.btnSetMolaDuration.Click += new System.EventHandler(this.btnSetMolaDuration_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btn_Reset.Location = new System.Drawing.Point(23, 130);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(124, 41);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Sıfırla";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btn_StartStop.Location = new System.Drawing.Point(23, 59);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(124, 41);
            this.btn_StartStop.TabIndex = 0;
            this.btn_StartStop.Text = "Başlat";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // timerCTime
            // 
            this.timerCTime.Interval = 1000;
            this.timerCTime.Tick += new System.EventHandler(this.timerCTime_Tick);
            // 
            // timerWorkingUser
            // 
            this.timerWorkingUser.Interval = 10;
            this.timerWorkingUser.Tick += new System.EventHandler(this.timerWorkingUser_Tick);
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.lbl_ReamingTime);
            this.groupBox_Status.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_Status.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox_Status.Location = new System.Drawing.Point(215, 66);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(337, 363);
            this.groupBox_Status.TabIndex = 1;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Durum: Çalışma";
            // 
            // lbl_ReamingTime
            // 
            this.lbl_ReamingTime.AutoSize = true;
            this.lbl_ReamingTime.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ReamingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lbl_ReamingTime.Location = new System.Drawing.Point(52, 59);
            this.lbl_ReamingTime.Name = "lbl_ReamingTime";
            this.lbl_ReamingTime.Size = new System.Drawing.Size(233, 62);
            this.lbl_ReamingTime.TabIndex = 2;
            this.lbl_ReamingTime.Text = "HH:mm:ss";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Status);
            this.Controls.Add(this.groupBox_Btns);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Timer";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnHome)).EndInit();
            this.groupBox_Btns.ResumeLayout(false);
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picbtnHome;
        private System.Windows.Forms.PictureBox picbtnExit;
        private System.Windows.Forms.GroupBox groupBox_Btns;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Timer timerWorkingUser;
        private System.Windows.Forms.Button btnSetWorkingDuration;
        private System.Windows.Forms.Button btnSetMolaDuration;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private System.Windows.Forms.Label lbl_ReamingTime;
    }
}

