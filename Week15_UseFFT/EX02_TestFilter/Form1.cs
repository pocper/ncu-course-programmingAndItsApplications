using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Dsp;

namespace EX02_TestFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_Length.SelectedIndex = 1;
            comboBox_SampleRate.SelectedIndex = 1;
        }

        Complex[] generatedData;
        double[] freqData;

        private void button_GenerateSamples_Click(object sender, EventArgs e)
        {
            chart.Series["Original"].Points.Clear();
            chart.Series["Filtered"].Points.Clear();
            float sampleRate = Convert.ToSingle(comboBox_SampleRate.Text);
            int sampleLength = Convert.ToInt32(comboBox_Length.Text);
            int pow = comboBox_Length.SelectedIndex + 10;
            //double genFreq = Convert.ToDouble(textBox_GenFreq.Text);

            double interval = 1.0 / sampleRate;
            double pi = Math.PI;
            freqData = new double[sampleLength / 2];
            for(int i=0;i<freqData.Length;i+=1)
            {
                freqData[i] =  sampleRate / sampleLength * i;
            }

            //Generate original data
            generatedData = new Complex[sampleLength];
            for (int i = 0; i < generatedData.Length; i++)
            {
                double time = interval * i;
                double x = 0;
                //generate uniform freq 
                for (int f = 1; f < sampleRate / 2; f++)
                    x += Math.Sin(2 * pi * f * time);
                generatedData[i] = new Complex() { X = Convert.ToSingle(x), Y = 0 };
            }

            //Clone the data for processing
            Complex[] cloneData = generatedData.Clone() as Complex[];            

            //Plot original data spectrum
            FastFourierTransform.FFT(true, pow, cloneData);
            FixFftResult(cloneData);
            double[] mag_original = GetMagnitude(cloneData, freqData.Length);
            chart.Series["Original"].Points.DataBindXY(freqData, mag_original);
        }
        private void button_DoFilter_Click(object sender, EventArgs e)
        {
            //Clone original data to filtered data (at this moment it is not filtered)
            Complex[] filtered = generatedData.Clone() as Complex[];

            //Do filter
            float sampleRate = Convert.ToSingle(comboBox_SampleRate.Text);
            int pow = comboBox_Length.SelectedIndex + 10;
            float cutoff = Convert.ToSingle(textBox_CutOffFreq.Text);
            float bandwidth = Convert.ToSingle(textBox_bandWidth.Text);

            BiQuadFilter filter = BiQuadFilter.LowPassFilter(sampleRate, cutoff, bandwidth);
            for(int i=0;i<filtered.Length;i++)
            {
                filtered[i].X = filter.Transform(filtered[i].X);
            }

            //plot filtered data spectrum
            FastFourierTransform.FFT(true, pow, filtered);
            FixFftResult(filtered);
            double[] mag_filtered = GetMagnitude(filtered, freqData.Length);
            chart.Series["Filtered"].Points.DataBindXY(freqData, mag_filtered);
        }

        static void FixFftResult(Complex[] data)
        {
            for(int i=0;i<data.Length;i++)
            {
                data[i].X *= 2;
                data[i].Y *= 2;
            }    
        }

        static double[] GetMagnitude(Complex[] data, int length)
        {
            int l = length < data.Length ? length : data.Length;
            double[] m = new double[l];
            for(int i=0;i<l;i++)
            {
                m[i] = Math.Sqrt(Math.Pow(data[i].X, 2) + Math.Pow(data[i].Y, 2));
            }
            return m;

        }


    }
}
