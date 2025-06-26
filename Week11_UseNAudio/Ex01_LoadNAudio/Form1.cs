using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        bool isRMS = false;
        int square = 0;
        double RMS;

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                //Create Wave In device
                NAudio.Wave.WaveIn waveIn = new NAudio.Wave.WaveIn();

                //Configure Wave format
                NAudio.Wave.WaveFormat waveFormat 
                    = new NAudio.Wave.WaveFormat(8000,16, 1);
                waveIn.WaveFormat = waveFormat;
                waveIn.NumberOfBuffers = 3; //at least TWO
                waveIn.BufferMilliseconds = 1000; //the recording period per buffer

                //subscribe the event
                waveIn.DataAvailable += WaveIn_DataAvailable;

                waveIn.StartRecording();
                isRecording = true;
            }


        }

        private void WaveIn_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            /*C++
            void* buf;
            short* data = (short*)buf;
            */

            byte[] buf = e.Buffer;
            int bufLength = e.BytesRecorded;
            short[] dataFromPtr = new short[buf.Length / 2];
            //short[] dataByConvert = new short[buf.Length / 2];

            //way 1. use pointer
            IntPtr ptr = Marshal.AllocHGlobal(buf.Length);
            Marshal.Copy(buf, 0, ptr, buf.Length);
            Marshal.Copy(ptr, dataFromPtr, 0, dataFromPtr.Length);
            Marshal.FreeHGlobal(ptr);

            //way 2. use bit convert
            //for (int i = 0; i < dataFromPtr.Length; i++)
            //{
            //    dataByConvert[i] = BitConverter.ToInt16(buf, i * 2);
            //}

            chart1.Series[0].Points.DataBindY(dataFromPtr);
            if (isRMS)
            {
                RMS = 0;
                foreach (short i in dataFromPtr)
                {
                    RMS += i * i / dataFromPtr.Length;
                }
                RMS = Math.Sqrt(RMS);
                isRMS = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_RMS.Text = String.Format("{0:0.00}",RMS);
            isRMS = true;
        }
    }
}
