namespace Student_StructForm
{
    partial class frm_Student_StructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.labShowGarde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labMinMaxGrade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(100, 88);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(100, 146);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(52, 24);
            this.labChi.TabIndex = 1;
            this.labChi.Text = "國文:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(100, 200);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(52, 24);
            this.labEng.TabIndex = 2;
            this.labEng.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(100, 259);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(52, 24);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(165, 259);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 22);
            this.txtMath.TabIndex = 5;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(165, 200);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 22);
            this.txtEng.TabIndex = 6;
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(165, 146);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(100, 22);
            this.txtChi.TabIndex = 7;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(84, 336);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(101, 50);
            this.btnSaveData.TabIndex = 8;
            this.btnSaveData.Text = "儲存";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(218, 336);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(101, 50);
            this.btnShowData.TabIndex = 9;
            this.btnShowData.Text = "顯示儲存內容";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // labShowGarde
            // 
            this.labShowGarde.AutoSize = true;
            this.labShowGarde.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowGarde.Location = new System.Drawing.Point(6, 0);
            this.labShowGarde.Name = "labShowGarde";
            this.labShowGarde.Size = new System.Drawing.Size(41, 20);
            this.labShowGarde.TabIndex = 10;
            this.labShowGarde.Text = "成績";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShowGarde);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(428, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 213);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labMinMaxGrade);
            this.groupBox2.Location = new System.Drawing.Point(428, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // labMinMaxGrade
            // 
            this.labMinMaxGrade.AutoSize = true;
            this.labMinMaxGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMinMaxGrade.Location = new System.Drawing.Point(7, 22);
            this.labMinMaxGrade.Name = "labMinMaxGrade";
            this.labMinMaxGrade.Size = new System.Drawing.Size(0, 20);
            this.labMinMaxGrade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "最高分/最低分科目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Student_StructForm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Label labShowGarde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labMinMaxGrade;
    }
}

