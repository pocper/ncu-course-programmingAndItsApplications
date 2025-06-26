using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Dsp;

namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] time = new double[1000];
        double[] value = new double[1000];
        double[] freqData = new double[500];

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("data.csv", FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            //string content = streamReader.ReadToEnd();
            //textBox_ReadContent.Text = content;
            int i = 0;
            while (streamReader.EndOfStream != true)
            {
                string line = streamReader.ReadLine();
                string[] temp = line.Split(',');
                time[i] = Convert.ToDouble(temp[0]);
                value[i] = Convert.ToDouble(temp[1]);
                i++;
            }

            streamReader.Close();

            chartTime.Series["Raw"].Points.DataBindXY(time, value);

            for (i = 0; i < freqData.Length; i += 1)
            {
                freqData[i] = 1000 / value.Length * i;
            }
        }

        private void buttonFFT_Click(object sender, EventArgs e)
        {
            Complex[] data = new Complex[1024];

            for (int i = 0; i < data.Length; i++)
            {
                if (i < value.Length)
                    data[i] = new Complex() { X = Convert.ToSingle(value[i]), Y = 0 };
                else
                    data[i] = new Complex() { X = 0, Y = 0 };
            }

            FastFourierTransform.FFT(true, 10, data);

            for (int i = 0; i < data.Length; i++)
            {
                data[i].X *= 2;
                data[i].Y *= 2;
            }


            double[] mag_filtered = GetMagnitude(data, freqData.Length);
            chartFreq.Series["Raw"].Points.DataBindXY(freqData, mag_filtered);
        }

        static double[] GetMagnitude(Complex[] data, int length)
        {
            int l = length < data.Length ? length : data.Length;
            double[] m = new double[l];
            for (int i = 0; i < l; i++)
            {
                m[i] = Math.Sqrt(Math.Pow(data[i].X, 2) + Math.Pow(data[i].Y, 2));
            }
            return m;

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Complex[] Data_filter = new Complex[1024];

            for (int i = 0; i < Data_filter.Length; i++)
            {
                if (i < value.Length)
                    Data_filter[i] = new Complex() { X = Convert.ToSingle(value[i]), Y = 0 };
                else
                    Data_filter[i] = new Complex() { X = 0, Y = 0 };
            }

            Complex[] filtered = Data_filter.Clone() as Complex[];

            //Do filter
            float samplerate = 1000;
            float cutoff = 250;
            float bandwidth = 20;

            BiQuadFilter filter = BiQuadFilter.LowPassFilter(samplerate, cutoff, bandwidth);

            for (int i = 0; i < filtered.Length; i++)
            {
                filtered[i].X = filter.Transform(filtered[i].X);
            }

            //plot filtered data spectrum
            FastFourierTransform.FFT(true, 10, filtered);

            for (int i = 0; i < filtered.Length; i++)
            {
                filtered[i].X *= 2;
                filtered[i].Y *= 2;
            }

            double[] mag_filtered = GetMagnitude(filtered, freqData.Length);
            chartFreq.Series["Filtered"].Points.DataBindXY(freqData, mag_filtered);

            double[] mag_timefiltered = GetMagnitude(filtered, time.Length);
            chartTime.Series["Filtered"].Points.DataBindXY(time, mag_timefiltered);
        }
    }
}
