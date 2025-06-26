using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Ex01_LoadNAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        bool isRecording = false;
        bool isPressed = false;
        double[] RMS = new double[2];//Left Right
        double threshold;

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                //Create Wave In device
                NAudio.Wave.WaveIn waveIn = new NAudio.Wave.WaveIn();

                //Configure Wave format
                NAudio.Wave.WaveFormat waveFormat 
                    = new NAudio.Wave.WaveFormat(8000,16, 2);
                waveIn.WaveFormat = waveFormat;
                waveIn.NumberOfBuffers = 3; //at least TWO
                waveIn.BufferMilliseconds = 100; //the recording period per buffer

                //subscribe the event
                waveIn.DataAvailable += WaveIn_DataAvailable;

                waveIn.StartRecording();
                isRecording = true;
            }


        }

        private void WaveIn_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            byte[] buf = e.Buffer;
            short[] LeftdataByConvert = new short[buf.Length / 4];
            short[] RightdataByConvert = new short[buf.Length / 4];
            string text = "";

            for (int i = 0; i < buf.Length / 4 - 4; i++)
            {
                LeftdataByConvert[i] = BitConverter.ToInt16(buf, i * 4);
                RightdataByConvert[i] = BitConverter.ToInt16(buf, i * 4 + 2);
            }

            chart1.Series["Left"].Points.DataBindY(LeftdataByConvert);
            chart1.Series["Right"].Points.DataBindY(RightdataByConvert);

            RMS[0] = 0;
            RMS[1] = 0;

            for (int i = 0; i < LeftdataByConvert.Length; i++)
            {
                RMS[0] += Math.Pow(LeftdataByConvert[i], 2) / LeftdataByConvert.Length;
                RMS[1] += Math.Pow(RightdataByConvert[i], 2) / RightdataByConvert.Length;
            }

            RMS[0] = Math.Sqrt(RMS[0]);
            RMS[1] = Math.Sqrt(RMS[1]);

            if ((RMS[0] > threshold || RMS[1] > threshold) && isPressed)
            {
                DateTime time = DateTime.Now;

                FileStream fileStream = new FileStream("LOG.txt", FileMode.Append, FileAccess.Write);

                using (StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    if (RMS[0] > threshold)
                    {
                        text += "Left";
                        text += " ";
                        text += time.ToShortTimeString();
                        text += " ";
                        text += RMS[0].ToString();
                        text += Environment.NewLine;
                        sw.Write(text);
                    }

                    if (RMS[1] > threshold)
                    {
                        text += "Right";
                        text += " ";
                        text += time.ToShortTimeString();
                        text += " ";
                        text += RMS[1].ToString();
                        text += Environment.NewLine;
                        sw.Write(text);
                    }
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_LeftRMS.Text = String.Format("{0:0.00}",RMS[0]);
            textBox_RightRMS.Text = String.Format("{0:0.00}", RMS[1]);
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            threshold = Double.Parse(textBox_threshold.Text);
            isPressed = true;
        }
    }
}
