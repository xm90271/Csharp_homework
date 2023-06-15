namespace Loan
{
    partial class labCalTitle
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
            this.labamount = new System.Windows.Forms.Label();
            this.labDeadLine = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.bntTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labamount
            // 
            this.labamount.AutoSize = true;
            this.labamount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labamount.Location = new System.Drawing.Point(69, 67);
            this.labamount.Name = "labamount";
            this.labamount.Size = new System.Drawing.Size(86, 24);
            this.labamount.TabIndex = 0;
            this.labamount.Text = "貸款金額";
            // 
            // labDeadLine
            // 
            this.labDeadLine.AutoSize = true;
            this.labDeadLine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDeadLine.Location = new System.Drawing.Point(69, 113);
            this.labDeadLine.Name = "labDeadLine";
            this.labDeadLine.Size = new System.Drawing.Size(79, 24);
            this.labDeadLine.TabIndex = 1;
            this.labDeadLine.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(69, 158);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(77, 24);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%)";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(69, 205);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(67, 24);
            this.labDownPayment.TabIndex = 3;
            this.labDownPayment.Text = "頭期款";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(171, 67);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 22);
            this.txtLoan.TabIndex = 4;
            // 
            // txtDeadline
            // 
            this.txtDeadline.Location = new System.Drawing.Point(171, 115);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(100, 22);
            this.txtDeadline.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(171, 158);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 6;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(171, 205);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 22);
            this.txtDownPayment.TabIndex = 7;
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(90, 298);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(97, 51);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // bntTotal
            // 
            this.bntTotal.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntTotal.Location = new System.Drawing.Point(229, 298);
            this.bntTotal.Name = "bntTotal";
            this.bntTotal.Size = new System.Drawing.Size(97, 51);
            this.bntTotal.TabIndex = 9;
            this.bntTotal.Text = "總付款";
            this.bntTotal.UseVisualStyleBackColor = true;
            this.bntTotal.Click += new System.EventHandler(this.bntTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(370, 298);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(97, 51);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labCalTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.bntTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labDeadLine);
            this.Controls.Add(this.labamount);
            this.Name = "labCalTitle";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labamount;
        private System.Windows.Forms.Label labDeadLine;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button bntTotal;
        private System.Windows.Forms.Button btnReport;
    }
}

