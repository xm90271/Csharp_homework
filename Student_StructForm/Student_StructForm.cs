using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_StructForm
{
    public partial class frm_Student_StructForm : Form
    {
        string GradeData = "成績\n\n";

        public frm_Student_StructForm()
        {
            InitializeComponent();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtChi.Text, out int chiGrade) || !int.TryParse(txtEng.Text, out int engGrade) || !int.TryParse(txtMath.Text, out int mathGrade))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("輸入非數字/有欄位尚未填入", "警告");
                return;
            }

            GradeData = "成績\n\n";

            Student stu;
            stu.Name = txtName.Text;
            stu.ChiGrade = int.Parse(txtChi.Text);
            stu.EngGrade = int.Parse(txtEng.Text);
            stu.MathGrade = int.Parse(txtMath.Text);

            GradeData += "姓名 : " + stu.Name + "\n" + "國文 : " + stu.ChiGrade + "分" + "\n" + "英文 : " + stu.EngGrade + "分" + "\n" + "數學 : " + stu.MathGrade + "分";

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GradeData))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("請先儲存資料", "警告");
                return;
            }

            int chiGrade, engGrade, mathGrade;

            if (!int.TryParse(txtChi.Text, out chiGrade) || !int.TryParse(txtEng.Text, out engGrade) || !int.TryParse(txtMath.Text, out mathGrade))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("請先儲存資料", "警告");
                return;
            }
            labShowGarde.Text = GradeData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GradeData))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("請先儲存資料", "警告");
                return;
            }

            int chiGrade, engGrade, mathGrade;

            if (!int.TryParse(txtChi.Text, out chiGrade) || !int.TryParse(txtEng.Text, out engGrade) || !int.TryParse(txtMath.Text, out mathGrade))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("請先儲存資料", "警告");
                return;
            }

            Dictionary<string, int> grades = new Dictionary<string, int>()
    {
        { "國文", chiGrade },
        { "英文", engGrade },
        { "數學", mathGrade }
    };

            int maxGrade = grades.Values.Max();
            int minGrade = grades.Values.Min();
            string maxSubject = grades.FirstOrDefault(x => x.Value == maxGrade).Key;
            string minSubject = grades.FirstOrDefault(x => x.Value == minGrade).Key;

            labMinMaxGrade.Text = $"最高科目成績為: {maxSubject} {maxGrade}分\n";
            labMinMaxGrade.Text += $"最低科目成績為: {minSubject} {minGrade}分";
        }

    }
}
