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
        
        int current_minutes;
        int current_seconds;

        int initial_minutes;

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
                    UpdateLabelTimer(0, 0);
                }

                toggle_flag = !toggle_flag;
            }
            else if (stopWatch != null)
            {
                TimeSpan ts = stopWatch.Elapsed;
                int elapsedMinutes = ts.Minutes;
                int elapsedSeconds = ts.Seconds;

                current_minutes = initial_minutes - elapsedMinutes - 1;
                current_seconds = 59 - elapsedSeconds;

                if (current_minutes < 0 )
                {
                    timer_finished = true;
                    current_minutes = 0;
                    current_seconds = 0;
                }

                UpdateLabelTimer(current_minutes,current_seconds);
            }
        }

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            initial_minutes = Convert.ToInt32(textBoxInitTimer.Text);
            stopWatch = new Stopwatch();
            stopWatch.Start();
            timer_finished = false;
            UpdateLabelTimer(initial_minutes, 0);

        }

        

    }
}
