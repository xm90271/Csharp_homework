namespace Alarm
{
    partial class frm_Alarm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxSetAlarm = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labCurrentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkboxSetAlarm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInputTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(185, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // chkboxSetAlarm
            // 
            this.chkboxSetAlarm.AutoSize = true;
            this.chkboxSetAlarm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkboxSetAlarm.Location = new System.Drawing.Point(161, 177);
            this.chkboxSetAlarm.Name = "chkboxSetAlarm";
            this.chkboxSetAlarm.Size = new System.Drawing.Size(15, 14);
            this.chkboxSetAlarm.TabIndex = 4;
            this.chkboxSetAlarm.UseVisualStyleBackColor = true;
            this.chkboxSetAlarm.CheckedChanged += new System.EventHandler(this.chkboxSetAlarm_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(182, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set Alarm";
            // 
            // txtInputTime
            // 
            this.txtInputTime.Location = new System.Drawing.Point(170, 100);
            this.txtInputTime.Name = "txtInputTime";
            this.txtInputTime.Size = new System.Drawing.Size(147, 29);
            this.txtInputTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alarm Time :";
            // 
            // labCurrentTime
            // 
            this.labCurrentTime.AutoSize = true;
            this.labCurrentTime.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCurrentTime.Location = new System.Drawing.Point(98, 41);
            this.labCurrentTime.Name = "labCurrentTime";
            this.labCurrentTime.Size = new System.Drawing.Size(204, 40);
            this.labCurrentTime.TabIndex = 1;
            this.labCurrentTime.Text = "CurrentTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labCurrentTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Alarm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.frm_Alarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labCurrentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkboxSetAlarm;
    }
}

