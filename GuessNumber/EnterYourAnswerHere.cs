using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class EnterYourAnswerHere : Form
    {
        private frm_GuessNumber parentForm;

        public EnterYourAnswerHere(frm_GuessNumber parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.Activated += (sender, e) => txtAnswerHere.Focus();

            this.ControlBox = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Guess";

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int answer;
            bool isValidNumber = int.TryParse(txtAnswerHere.Text, out answer);

            if (isValidNumber && answer >= 0 && answer <= 100)
            {
                parentForm.CheckGuess(answer);
            }
            else
            {
                MessageBox.Show("Please input number between 1 and 100。", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnEnter.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
