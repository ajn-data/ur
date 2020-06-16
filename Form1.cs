using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Threading;

namespace DigitalUr
{
    public partial class Form1 : Form
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        public Form1()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString();
        }

        public void startbtn(object sender, EventArgs e)
        {
            sw.Start();
            dt.Start();
        }

        public void stopbtn(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
            }
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                lblClock.Text = currentTime;
            }
        }
        private void resetbtn(object sender, EventArgs e)
        {
            sw.Reset();
            lblClock.Text = "00:00:00";
        }
    }
}
