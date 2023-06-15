using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Loan
{
    public partial class labCalTitle : Form
    {

        private int loanAmount;
        private int loanTerm;
        private double interestRate;
        private double downPayment;

        public labCalTitle()
        {
            InitializeComponent();
        }



        private void btnPMT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoan.Text) || !int.TryParse(txtLoan.Text, out loanAmount))
            {
                MessageBox.Show("請輸入有效的貸款金額。");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeadline.Text) || !int.TryParse(txtDeadline.Text, out loanTerm))
            {
                MessageBox.Show("請輸入有效的貸款期限。");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRate.Text) || !double.TryParse(txtRate.Text, out interestRate))
            {
                MessageBox.Show("請輸入有效的貸款利率。");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDownPayment.Text) && !double.TryParse(txtDownPayment.Text, out downPayment))
            {
                MessageBox.Show("請輸入有效的貸款頭期款金額。");
                return;
            }

            int loanAmountWithoutDownPayment = loanAmount - (int)downPayment;
            int loanTermMonths = loanTerm * 12;
            interestRate = interestRate / 1200;
            int PMT = (int)(Financial.Pmt(interestRate, loanTermMonths, loanAmountWithoutDownPayment) * -1);
            MessageBox.Show("月付額：" + PMT.ToString() + "元");
        }

        private void bntTotal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoan.Text) || !int.TryParse(txtLoan.Text, out loanAmount))
            {
                MessageBox.Show("請輸入有效的貸款金額。");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeadline.Text) || !int.TryParse(txtDeadline.Text, out loanTerm))
            {
                MessageBox.Show("請輸入有效的貸款期限。");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRate.Text) || !double.TryParse(txtRate.Text, out interestRate))
            {
                MessageBox.Show("請輸入有效的利率。");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDownPayment.Text) && !double.TryParse(txtDownPayment.Text, out downPayment))
            {
                MessageBox.Show("請輸入有效的頭期款金額。");
                return;
            }

            int loanAmountWithoutDownPayment = loanAmount - (int)downPayment;
            int loanTermMonths = loanTerm * 12;
            interestRate = interestRate / 1200;

            int PMT = (int)(Financial.Pmt(interestRate, loanTermMonths, loanAmountWithoutDownPayment) * -1);
            int totalPayment = PMT * loanTermMonths;

            // Subtract the down payment from the total payment
            totalPayment += (int)downPayment;

            MessageBox.Show("總付款：" + totalPayment.ToString() + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoan.Text) || !int.TryParse(txtLoan.Text, out loanAmount))
            {
                MessageBox.Show("請輸入有效的貸款金額。");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeadline.Text) || !int.TryParse(txtDeadline.Text, out loanTerm))
            {
                MessageBox.Show("請輸入有效的貸款期限。");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRate.Text) || !double.TryParse(txtRate.Text, out interestRate))
            {
                MessageBox.Show("請輸入有效的利率。");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDownPayment.Text) && !double.TryParse(txtDownPayment.Text, out downPayment))
            {
                MessageBox.Show("請輸入有效的頭期款金額。");
                return;
            }

            int loanAmountWithoutDownPayment = loanAmount - (int)downPayment;
            int loanTermMonths = loanTerm * 12;
            interestRate = interestRate / 1200;
            int PMT = (int)(Financial.Pmt(interestRate, loanTermMonths, loanAmountWithoutDownPayment) * -1);
            int totalPayment = PMT * loanTermMonths;

            LoanReport lr = new LoanReport(loanAmount, loanTerm, interestRate, PMT, totalPayment, (int)downPayment);
            lr.Show();
        }
    }

}


