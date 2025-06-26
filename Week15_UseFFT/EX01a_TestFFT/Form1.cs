using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NAudio.Dsp;



namespace EX01a_TestFFT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = @"D:\OneDrive - 國立中央大學\Course\ME3099程式設計與應用\Exercises_上課範例\Week15\2Hz 16Samples.csv";
            string[] lines = File.ReadAllLines(file);

            Complex[] data = new Complex[lines.Length-1];

            for(int i=1;i<lines.Length;i++)
            {
                string[] elements = lines[i].Split(',');
                data[i-1].X = float.Parse(elements[2]);
            }

            FastFourierTransform.FFT(true, 4, data);

            for (int i = 1; i < data.Length; i++)
            {
                data[i].X *= 2;
                data[i].Y *= 2;
            }


        }
    }
}
