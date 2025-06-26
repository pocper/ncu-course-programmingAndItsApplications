using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Week11_Exam
{
    public partial class Form1 : Form
    {
        Thread WorkingThrd = null;

        public Form1()
        {
            InitializeComponent();
        }
        bool isRecording = false;
        bool isPressedRecord = false;
        bool WaveInDone = false;
        double Threshold;

        short[] ch1Data = null;
        short[] ch2Data = null;
        string openedFile = "";
        NAudio.Wave.WaveIn waveIn;
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            isPressedRecord = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "開啟一個檔案";
            openFileDialog.Filter = "txt|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openedFile = openFileDialog.FileName;
            }

            if (!isRecording)
            {
                //Create Wave In device
                waveIn = new NAudio.Wave.WaveIn();

                //Configure Wave format
                NAudio.Wave.WaveFormat waveFormat = new NAudio.Wave.WaveFormat(8000, 16, 2);
                waveIn.WaveFormat = waveFormat;
                waveIn.NumberOfBuffers = 3;
                waveIn.BufferMilliseconds = 100;
                waveIn.DataAvailable += WaveIn_DataAvailable;

                waveIn.StartRecording();
                isRecording = true;


                WorkingThrd = new Thread(this.Working);
                WorkingThrd.Start();

                chart1.Series.Clear();
                chart1.Series.Add("Series1");
                chart1.Series.Add("Series2");
            }
        }

        private void Working()
        {
            while (isPressedRecord)
            {
                if (!String.IsNullOrEmpty(openedFile))
                {
                    if (WaveInDone)
                    {
                        FileStream fileStream = new FileStream(openedFile, FileMode.Append, FileAccess.Write);
                        using (StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8))
                        {
                            for (int i = 0; i < ch1Data.Length; i++)
                            {
                                sw.Write(Convert.ToInt32(ch1Data[i]));
                                sw.Write(" ");
                                sw.Write(Convert.ToInt32(ch2Data[i]));
                            }
                        }
                    }
                    
                }
            }
        }

        private void WaveIn_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            var buf = e.Buffer;
            ch1Data = new short[buf.Length / 4];
            ch2Data = new short[buf.Length / 4];

            for (int i = 0; i < buf.Length / 4; i++)
            {
                ch1Data[i] = BitConverter.ToInt16(buf, i * 4);
                ch2Data[i] = BitConverter.ToInt16(buf, i * 4 + 2);
            }

            double ch1RMS = 0, ch2RMS = 0;

            double temp = 0;
            for (int i = 0; i < ch1Data.Length; i++)
            {
                temp += Math.Pow(ch1Data[i], 2);
            }
            ch1RMS = Math.Sqrt(temp / ch1Data.Length);

            temp = 0;
            for (int i = 0; i < ch2Data.Length; i++)
            {
                temp += Math.Pow(ch2Data[i], 2);
            }
            ch2RMS = Math.Sqrt(temp / ch2Data.Length);
            //SaveVolume(ch1RMS, ch2RMS);

            chart1.Series[0].Points.AddY(ch1RMS);
            chart1.Series[1].Points.AddY(ch2RMS);
            WaveInDone = true;
        }

        private void SaveVolume(double ch1_rms, double ch2_rms)
        {

            if(ch1_rms > Threshold)
            {
                //File.AppendAlltext()
            }
            if(ch2_rms > Threshold)
            {
                //File.AppendAlltext()
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            Threshold = Convert.ToDouble(textBoxThreshold.Text);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        { 
            if (WorkingThrd.IsAlive)
            {
                waveIn.Dispose();
                isRecording = false;
                isPressedRecord = false;
                WaveInDone = false;
                WorkingThrd.Join(200);
            }
        }
    }
}
