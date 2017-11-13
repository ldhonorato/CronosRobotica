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
        static Stopwatch stopWatch;
        static bool _writeFile = false;

        SerialPort _serialPort;
        StreamWriter _file;
        string path = @"C:\Users\ldhon\Desktop\Tempos_" + DateTime.Now.Day + "." + DateTime.Now.Month + ".txt";

        public Form1()
        {
            InitializeComponent();
            FillComoBoxCOMs();
            timer1.Start();
            

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

            
        }

        public void UpdateLabelTimer(int sec, int mili)
        {
            labelTimer.Text = String.Format("{0:#,0#}:{1:#,00#}", sec, mili);
        }

        private void TimerInterruption(object sender, EventArgs e)
        {
            if (stopWatch != null)
            {
                TimeSpan ts = stopWatch.Elapsed;
                UpdateLabelTimer(ts.Seconds + (ts.Minutes* 60), ts.Milliseconds);

                if (!stopWatch.IsRunning)
                {
                    if (_writeFile == true)
                    {
                        _file = new System.IO.StreamWriter(path, true);
                        _file.WriteLine(String.Format(">{0:#,0#}:{1:#,00#}", ts.Seconds + (ts.Minutes * 60), ts.Milliseconds));
                        _file.Flush();
                    
                        _file.Close();
                        _writeFile = false;
                    }
                }
            }
        }

        private void COMPortButton(object sender, EventArgs e)
        {
            if (_serialPort == null)
            {
                _serialPort = new SerialPort(comboBoxCOMList.SelectedItem.ToString());
                _serialPort.BaudRate = 115200;
                _serialPort.Parity = Parity.None;
                _serialPort.StopBits = StopBits.One;
                _serialPort.DataBits = 8;
                _serialPort.Handshake = Handshake.None;
                _serialPort.RtsEnable = false;

                _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                _serialPort.Open();

                buttonOpenCOM.Text = "Fechar porta";

                comboBoxCOMList.Enabled = false;
            }
            else
            {
                buttonOpenCOM.Text = "Abrir porta";
                FillComoBoxCOMs();
                comboBoxCOMList.Enabled = true;

                _serialPort.Close();
                _serialPort = null;

            }
            
        }

        private static void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            while (sp.BytesToRead > 0)
            {
                byte data = (byte)sp.ReadByte();

                if (data == 0x5A)
                {
                    stopWatch = new Stopwatch();
                    stopWatch.Start();
                    _writeFile = true;
                }

                if (data == 0xA5)
                {
                    if(stopWatch != null)
                        stopWatch.Stop();
                }
            }
        }


        private void FillComoBoxCOMs()
        {
            comboBoxCOMList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxCOMList.Items.Add(port);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            stopWatch = null;

            UpdateLabelTimer(0, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
