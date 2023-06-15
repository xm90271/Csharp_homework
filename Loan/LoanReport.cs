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
    public partial class LoanReport : Form
    {
        public LoanReport(int loanAmount, int loanTermYears, double interestRate, int PMT, int totalPayment, int downPayment)
        {
            InitializeComponent();

            LabAmount.Text = loanAmount.ToString();
            LabLoanTerm.Text = loanTermYears.ToString();
            LabInterestRate.Text = (interestRate * 1200).ToString("N2") + "%";
            LabPMT.Text = PMT.ToString();
            LabTotal.Text = totalPayment.ToString();
        }

    }
}
