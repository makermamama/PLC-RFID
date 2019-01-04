namespace PLC＿RFID
{
    partial class RFIDAuto
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnComControl = new System.Windows.Forms.Button();
            this.btnPLC = new System.Windows.Forms.Button();
            this.btnMarking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKillPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRFIDCheckIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRFIDWriteIP = new System.Windows.Forms.TextBox();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTagCheck = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEPCpassWord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRFID = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMatchfail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatchSucess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatchSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWritefail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteSuuccess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWriteSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerGetClient = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTags = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTags)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComControl
            // 
            this.btnComControl.Font = new System.Drawing.Font("宋体", 12F);
            this.btnComControl.Location = new System.Drawing.Point(47, 12);
            this.btnComControl.Name = "btnComControl";
            this.btnComControl.Size = new System.Drawing.Size(138, 41);
            this.btnComControl.TabIndex = 0;
            this.btnComControl.Text = "控制盒";
            this.btnComControl.UseVisualStyleBackColor = true;
            this.btnComControl.Click += new System.EventHandler(this.btnComControl_Click);
            // 
            // btnPLC
            // 
            this.btnPLC.Font = new System.Drawing.Font("宋体", 12F);
            this.btnPLC.Location = new System.Drawing.Point(47, 59);
            this.btnPLC.Name = "btnPLC";
            this.btnPLC.Size = new System.Drawing.Size(138, 41);
            this.btnPLC.TabIndex = 1;
            this.btnPLC.Text = "PLC";
            this.btnPLC.UseVisualStyleBackColor = true;
            this.btnPLC.Click += new System.EventHandler(this.btnPLC_Click);
            // 
            // btnMarking
            // 
            this.btnMarking.Font = new System.Drawing.Font("宋体", 12F);
            this.btnMarking.Location = new System.Drawing.Point(202, 12);
            this.btnMarking.Name = "btnMarking";
            this.btnMarking.Size = new System.Drawing.Size(138, 41);
            this.btnMarking.TabIndex = 2;
            this.btnMarking.Text = "喷码机";
            this.btnMarking.UseVisualStyleBackColor = true;
            this.btnMarking.Click += new System.EventHandler(this.btnMarking_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtKillPassword);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtRFIDCheckIP);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtRFIDWriteIP);
            this.panel1.Controls.Add(this.txtWriteData);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnTagCheck);
            this.panel1.Controls.Add(this.txtError);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEPCpassWord);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnRFID);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtMatchfail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMatchSucess);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMatchSum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtWritefail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtWriteSuuccess);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtWriteSum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMarking);
            this.panel1.Controls.Add(this.btnComControl);
            this.panel1.Controls.Add(this.btnPLC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 268);
            this.panel1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(1052, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = " 销毁密码:";
            // 
            // txtKillPassword
            // 
            this.txtKillPassword.Location = new System.Drawing.Point(1146, 121);
            this.txtKillPassword.Name = "txtKillPassword";
            this.txtKillPassword.Size = new System.Drawing.Size(100, 26);
            this.txtKillPassword.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(1052, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "RFID_检测:";
            // 
            // txtRFIDCheckIP
            // 
            this.txtRFIDCheckIP.Location = new System.Drawing.Point(1146, 68);
            this.txtRFIDCheckIP.Name = "txtRFIDCheckIP";
            this.txtRFIDCheckIP.Size = new System.Drawing.Size(100, 26);
            this.txtRFIDCheckIP.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(1052, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "RFID_写入:";
            // 
            // txtRFIDWriteIP
            // 
            this.txtRFIDWriteIP.Location = new System.Drawing.Point(1146, 21);
            this.txtRFIDWriteIP.Name = "txtRFIDWriteIP";
            this.txtRFIDWriteIP.Size = new System.Drawing.Size(100, 26);
            this.txtRFIDWriteIP.TabIndex = 30;
            // 
            // txtWriteData
            // 
            this.txtWriteData.Font = new System.Drawing.Font("宋体", 20F);
            this.txtWriteData.Location = new System.Drawing.Point(129, 162);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.ReadOnly = true;
            this.txtWriteData.Size = new System.Drawing.Size(871, 38);
            this.txtWriteData.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(44, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "写入数据：";
            // 
            // btnTagCheck
            // 
            this.btnTagCheck.Font = new System.Drawing.Font("宋体", 12F);
            this.btnTagCheck.Location = new System.Drawing.Point(202, 59);
            this.btnTagCheck.Name = "btnTagCheck";
            this.btnTagCheck.Size = new System.Drawing.Size(138, 41);
            this.btnTagCheck.TabIndex = 27;
            this.btnTagCheck.Text = "标签检测";
            this.btnTagCheck.UseVisualStyleBackColor = true;
            this.btnTagCheck.Click += new System.EventHandler(this.btnTagCheck_Click);
            // 
            // txtError
            // 
            this.txtError.Font = new System.Drawing.Font("宋体", 20F);
            this.txtError.Location = new System.Drawing.Point(129, 215);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(871, 38);
            this.txtError.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(44, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "错误信息：";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPort.Location = new System.Drawing.Point(701, 112);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 26);
            this.txtPort.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(652, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Port:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 12F);
            this.txtIP.Location = new System.Drawing.Point(448, 112);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(151, 26);
            this.txtIP.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(420, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "IP:";
            // 
            // txtEPCpassWord
            // 
            this.txtEPCpassWord.Font = new System.Drawing.Font("宋体", 12F);
            this.txtEPCpassWord.Location = new System.Drawing.Point(900, 115);
            this.txtEPCpassWord.Name = "txtEPCpassWord";
            this.txtEPCpassWord.Size = new System.Drawing.Size(100, 26);
            this.txtEPCpassWord.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(821, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "锁标密码：";
            // 
            // btnRFID
            // 
            this.btnRFID.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRFID.Location = new System.Drawing.Point(47, 106);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(138, 41);
            this.btnRFID.TabIndex = 16;
            this.btnRFID.Text = "RFID";
            this.btnRFID.UseVisualStyleBackColor = true;
            this.btnRFID.Click += new System.EventHandler(this.btnRFID_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F);
            this.btnClear.Location = new System.Drawing.Point(202, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 41);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMatchfail
            // 
            this.txtMatchfail.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMatchfail.Location = new System.Drawing.Point(900, 68);
            this.txtMatchfail.Name = "txtMatchfail";
            this.txtMatchfail.ReadOnly = true;
            this.txtMatchfail.Size = new System.Drawing.Size(100, 26);
            this.txtMatchfail.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(821, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "匹配失败：";
            // 
            // txtMatchSucess
            // 
            this.txtMatchSucess.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMatchSucess.Location = new System.Drawing.Point(701, 68);
            this.txtMatchSucess.Name = "txtMatchSucess";
            this.txtMatchSucess.ReadOnly = true;
            this.txtMatchSucess.Size = new System.Drawing.Size(100, 26);
            this.txtMatchSucess.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(622, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "匹配成功：";
            // 
            // txtMatchSum
            // 
            this.txtMatchSum.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMatchSum.Location = new System.Drawing.Point(499, 68);
            this.txtMatchSum.Name = "txtMatchSum";
            this.txtMatchSum.ReadOnly = true;
            this.txtMatchSum.Size = new System.Drawing.Size(100, 26);
            this.txtMatchSum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(420, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "匹配总数：";
            // 
            // txtWritefail
            // 
            this.txtWritefail.Font = new System.Drawing.Font("宋体", 12F);
            this.txtWritefail.Location = new System.Drawing.Point(900, 21);
            this.txtWritefail.Name = "txtWritefail";
            this.txtWritefail.ReadOnly = true;
            this.txtWritefail.Size = new System.Drawing.Size(100, 26);
            this.txtWritefail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(821, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "写入失败：";
            // 
            // txtWriteSuuccess
            // 
            this.txtWriteSuuccess.Font = new System.Drawing.Font("宋体", 12F);
            this.txtWriteSuuccess.Location = new System.Drawing.Point(701, 21);
            this.txtWriteSuuccess.Name = "txtWriteSuuccess";
            this.txtWriteSuuccess.ReadOnly = true;
            this.txtWriteSuuccess.Size = new System.Drawing.Size(100, 26);
            this.txtWriteSuuccess.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(622, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "写入成功：";
            // 
            // txtWriteSum
            // 
            this.txtWriteSum.Font = new System.Drawing.Font("宋体", 12F);
            this.txtWriteSum.Location = new System.Drawing.Point(499, 21);
            this.txtWriteSum.Name = "txtWriteSum";
            this.txtWriteSum.ReadOnly = true;
            this.txtWriteSum.Size = new System.Drawing.Size(100, 26);
            this.txtWriteSum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(420, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "写入总数：";
            // 
            // timerGetClient
            // 
            this.timerGetClient.Interval = 5000;
            this.timerGetClient.Tick += new System.EventHandler(this.timerGetClient_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1055, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "写入测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1055, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "检测测试";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTags);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 298);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewTags
            // 
            this.dataGridViewTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTags.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTags.Name = "dataGridViewTags";
            this.dataGridViewTags.RowTemplate.Height = 23;
            this.dataGridViewTags.Size = new System.Drawing.Size(1308, 298);
            this.dataGridViewTags.TabIndex = 0;
            // 
            // RFIDAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RFIDAuto";
            this.Text = "RFID自动打标";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComControl;
        private System.Windows.Forms.Button btnPLC;
        private System.Windows.Forms.Button btnMarking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRFID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMatchfail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatchSucess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatchSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWritefail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteSuuccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWriteSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEPCpassWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timerGetClient;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTagCheck;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRFIDWriteIP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRFIDCheckIP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKillPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTags;
    }
}

