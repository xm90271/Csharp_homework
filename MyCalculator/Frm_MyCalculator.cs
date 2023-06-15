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

namespace MyCalculator
{
    public partial class Frm_MyCalculator : Form
    {
        public Frm_MyCalculator()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = num1 + num2;
                labAnswer.Text = result.ToString();
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = num1 - num2;
                labAnswer.Text = result.ToString();
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = num1 * num2;
                labAnswer.Text = result.ToString();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);

                if (num2 != 0)
                {
                    double result = num1 / num2;
                    labAnswer.Text = result.ToString();
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("除數不能為零", "錯誤");
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrEmpty(txtNum2.Text))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("兩個欄位都需要填入數字", "");
                return false;
            }

            if (!double.TryParse(txtNum1.Text, out _) || !double.TryParse(txtNum2.Text, out _))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("兩個欄位都需要填入數字", "");
                return false;
            }

            return true;
        }


    }
}
