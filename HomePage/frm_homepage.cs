using Hello;
using Loan;
using MyCalculator;
using POS;
using Student_StructForm;
using GuessNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Alarm;

namespace HomePage
{
    public partial class frm_homepage : Form
    {
        // // 定義一個變數儲存現在的視窗
        private Form currentForm;

        public frm_homepage()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            //如果有開啟視窗,則關閉舊的窗口
            if (currentForm != null)
            {
                currentForm.Close();
            }

            //設置新視窗為當前要開啟的窗口
            currentForm = form;


            //將父窗口設為groupBox3
            // 將開啟的新窗口設置為groupBox3的控件
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.ControlBox = true;
            form.Dock = DockStyle.Fill;
            groupBox3.Controls.Add(form);
            groupBox3.Tag = form;

            //顯示新視窗
            form.Show();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            HelloForm hf = new HelloForm();
            OpenForm(hf);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            labCalTitle labCalTitle = new labCalTitle();
            OpenForm(labCalTitle);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frm_POS pos = new frm_POS();
            OpenForm(pos);
        }

        private void btnStructForm_Click(object sender, EventArgs e)
        {
            frm_Student_StructForm Student_StructForm = new frm_Student_StructForm();
            OpenForm(Student_StructForm);
        }

        private void btnMyCalculator_Click(object sender, EventArgs e)
        {
            Frm_MyCalculator frm_MyCalculator = new Frm_MyCalculator();
            OpenForm(frm_MyCalculator);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
          frm_GuessNumber frm_GuessNumber = new frm_GuessNumber();
            OpenForm(frm_GuessNumber);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            frm_Alarm frm_Alarm = new frm_Alarm();
            OpenForm(frm_Alarm);
        }
    }
}
