using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Saver
{
    public partial class ScreenSaverForm : Form
    {
        private Timer timer;
        private Image image;
        private int x, y;
        private int directionX = 1;
        private int directionY = 1;

        public ScreenSaverForm()
        {
            //設置全螢幕
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            DoubleBuffered = true;

            // 設置定時
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;


            image = Properties.Resources.winter;


            x = (Screen.PrimaryScreen.Bounds.Width - image.Width) / 2;
            y = (Screen.PrimaryScreen.Bounds.Height - image.Height) / 2;


            timer.Start();


            this.MouseMove += ScreenSaverForm_MouseMove;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            x += directionX;
            y += directionY;


            if (x <= 0 || x + image.Width >= Screen.PrimaryScreen.Bounds.Width)
                directionX *= -1;
            if (y <= 0 || y + image.Height >= Screen.PrimaryScreen.Bounds.Height)
                directionY *= -1;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.DrawImage(image, x, y);

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Stop();

            this.Close();
        }

    }
}
