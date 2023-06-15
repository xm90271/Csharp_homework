using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class frm_Alarm : Form
    {
        private DateTime targetTime;
        private bool isTimerRunning;
        private Timer updateTimeTimer;

        public frm_Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labCurrentTime.Text = currentTime.ToString("HH:mm:ss");

            if (currentTime >= targetTime)
            {
                timer1.Stop();
                MessageBox.Show("時間到了!!!");

                isTimerRunning = false;
            }
        }

        private void updateTimeTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labCurrentTime.Text = currentTime.ToString("HH:mm:ss");
        }

        private void frm_Alarm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            isTimerRunning = false;
            timer1.Enabled = false;
            labCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");


            updateTimeTimer = new Timer();
            updateTimeTimer.Interval = 1000;
            updateTimeTimer.Tick += updateTimeTimer_Tick;
            updateTimeTimer.Start();
        }

        private void chkboxSetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            if (checkbox.Checked)
            {
                if (!isTimerRunning)
                {
                    if (DateTime.TryParseExact(txtInputTime.Text, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime inputTime))
                    {
                        DateTime currentTime = DateTime.Now;
                        DateTime targetDateTime = DateTime.Today + inputTime.TimeOfDay;

                        if (targetDateTime < currentTime)
                        {
                            targetDateTime = targetDateTime.AddDays(1);
                        }

                        TimeSpan timeRemaining = targetDateTime - currentTime;

                        timer1.Enabled = true;
                        isTimerRunning = true;
                        targetTime = targetDateTime;

                        MessageBox.Show("已成功建立鬧鐘");
                    }
                    else
                    {
                        MessageBox.Show("格式錯誤,請輸入___時:___分:___秒");
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("已經有設立的鬧鐘。是否要覆蓋舊的鬧鐘?", "確認覆蓋", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        timer1.Stop();
                        isTimerRunning = false;

                        if (DateTime.TryParseExact(txtInputTime.Text, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime inputTime))
                        {
                            DateTime currentTime = DateTime.Now;
                            DateTime targetDateTime = DateTime.Today + inputTime.TimeOfDay;

                            if (targetDateTime < currentTime)
                            {
                                targetDateTime = targetDateTime.AddDays(1);
                            }

                            TimeSpan timeRemaining = targetDateTime - currentTime;

                            timer1.Enabled = true;
                            isTimerRunning = true;
                            targetTime = targetDateTime;

                            MessageBox.Show("已成功建立鬧鐘");
                        }
                        else
                        {
                            MessageBox.Show("格式錯誤,請輸入___時:___分:___秒。");
                        }
                    }
                }
            }
            else
            {
                timer1.Stop();
                isTimerRunning = false;
            }
        }

    }
}



