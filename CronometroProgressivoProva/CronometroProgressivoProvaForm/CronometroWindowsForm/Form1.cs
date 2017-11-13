using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.IO;

namespace CronometroWindowsForm
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch;
        
        int max_minutes;
        int extra_minutes;

        bool timer_finished;
        bool toggle_flag;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer_finished = false;
        }

        public void UpdateLabelTimer(int min, int sec)
        {
            labelTimer.Text = String.Format("{0:#,0#}:{1:#,0#}", min, sec);
        }

        private void TimerInterruption(object sender, EventArgs e)
        {
            if (timer_finished == true)
            {
                if (toggle_flag)
                {
                    labelTimer.Text = "";
                }
                else
                {
                    UpdateLabelTimer(5, 0);
                }

                toggle_flag = !toggle_flag;
            }
            else if (stopWatch != null)
            {
                TimeSpan ts = stopWatch.Elapsed;
                int elapsedMinutes = ts.Minutes;
                int elapsedSeconds = ts.Seconds;

                UpdateLabelTimer((elapsedMinutes + extra_minutes), elapsedSeconds);

                if ((elapsedMinutes + extra_minutes) >= 5)
                {
                    timer_finished = true;
                }
            }
        }

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxInitTimer.Text != "")
            {
                max_minutes = Convert.ToInt32(textBoxInitTimer.Text);
            }
            else
            {
                max_minutes = 5;
            }
            stopWatch = new Stopwatch();
            stopWatch.Start();
            timer_finished = false;
            extra_minutes = 0;
            UpdateLabelTimer(0, 0);

        }

        private void buttonAddOneMinute_Click(object sender, EventArgs e)
        {
            extra_minutes++;
        }

        

    }
}
