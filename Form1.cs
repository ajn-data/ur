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
using System.Timers;
using System.Media;

namespace DigitalUr
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timerAlarm;
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        private int totalSeconds;
        public Form1()
        {
            InitializeComponent();
            timerAlarm = new System.Timers.Timer();
            timerAlarm.Interval = 1000;
            timerAlarm.Elapsed += Timer_Elapsed;
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);

            for (int i = 0; i < 60; i++)
            {
                this.cbMinutes.Items.Add(i.ToString());
                this.cbSeconds.Items.Add(i.ToString());
            }
            this.cbMinutes.SelectedIndex = 59;
            this.cbSeconds.SelectedIndex = 59;
        }

        public void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timerAlarm.Stop();
                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\alexa\Downloads\Alarm.wav";
                    player.PlayLooping();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btnAddTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            timerAlarm.Start();
            lblAlarm.Text = "Active";
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            timerAlarm.Stop();
            lblAlarm.Text = "Inactive";
        }

        private void lblAlarm_Click(object sender, EventArgs e)
        {

        }

        private void cdStart_Click(object sender, EventArgs e)
        {
            this.cdStart.Enabled = false;
            this.cdStop.Enabled = true;

            int minutes = int.Parse(this.cbMinutes.SelectedItem.ToString());
            int seconds = int.Parse(this.cbSeconds.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;

            this.cdTimer.Enabled = true;
        }

        private void cdStop_Click(object sender, EventArgs e)
        {
            this.cdStop.Enabled = false;
            this.cdStart.Enabled = true;

            totalSeconds = 0;
            this.cdTimer.Enabled = false;
        }

        private void cdTimer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                this.cdDisplay.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.cdTimer.Stop();
            }
        }
    }
} 

