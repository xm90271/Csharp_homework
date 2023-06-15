using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }

        private string name;
        private string eng_name;
        private string sex;
        private string zodiac_signs;
          

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string eng_name = txtEngName.Text;
            string sex = txtSex.Text;
            string zodiac_signs = txtZodiacSigns.Text;
            
            string [] introduction = new string[]
            {
             "Hello, 我是" + name,
             "英文名字是 " + eng_name,
             "性別是," + sex,
             "星座是," + zodiac_signs,
             "很高興認識你。"
            };
            MessageBox.Show(string.Join("\n", introduction), "안녕하세요!");

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string eng_name = txtEngName.Text;
            string sex = txtSex.Text;
            string zodiac_signs = txtZodiacSigns.Text;

            string[] introduction = new string[]
            {
             "Hello, 我是" + name,
             "英文名字是 " + eng_name,
             "性別是," + sex,
             "星座是," + zodiac_signs,
             "很高興認識你。"
            };
            MessageBox.Show(string.Join("\n", introduction), "哈囉~你好嗎~!");
        }
    }
}
