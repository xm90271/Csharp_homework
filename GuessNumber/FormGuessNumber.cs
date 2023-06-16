using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class frm_GuessNumber : Form
    {
        private int answer;
        private int rangeMin;
        private int rangeMax;
        private Random random;

        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public frm_GuessNumber()
        {
            InitializeComponent();
            random = new Random();
            GenerateNewAnswer(); // Generate the initial answer
        }

        private void GenerateNewAnswer()
        {
            answer = random.Next(1, 101);
            rangeMin = 1;
            rangeMax = 100;
            labHint.Text = "Please select a number between" + rangeMin + " and " + rangeMax;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            EnterYourAnswerHere answerForm = new EnterYourAnswerHere(this);
            answerForm.TopMost = true;
            answerForm.StartPosition = FormStartPosition.Manual;
            answerForm.Location = new Point(550, 550);
            answerForm.Show();

            GenerateNewAnswer();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The answer ：" + answer, "");
        }

        public void CheckGuess(int guess)
        {
            if (guess < rangeMin || guess > rangeMax)
            {
                MessageBox.Show("Please input a number between " + rangeMin + " and " + rangeMax + ".", "Error");
                return;
            }

            if (guess == answer)
            {
                MessageBox.Show("Bingo! You win!", "");
                GenerateNewAnswer(); 
            }
            else if (guess < answer)
            {
                rangeMin = guess;
                labHint.Text = "Too small! Enter a number between " + rangeMin + " and " + rangeMax;
            }
            else
            {
                rangeMax = guess;
                labHint.Text = "Too large! Enter a number between " + rangeMin + " and " + rangeMax;
            }
        }
    }
}
