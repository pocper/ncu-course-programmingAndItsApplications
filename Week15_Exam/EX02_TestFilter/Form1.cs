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
using NAudio.Wave;



namespace EX02_TestFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_stop.Enabled = false;
            button_DoFilter.Enabled = false;
        }

        float[] freqData;
        float[] filtered;
        bool isRecording = false;

        long sampleLength;
        int pow;

        string path = Directory.GetCurrentDirectory();
        string RecordFileName = "Origin.wav";
        string FilterFileName;
        string OutputFileName = "Filtered.wav";

        string loadLocation;
        string saveLocation;

        WaveFileWriter writer = null;
        NAudio.Wave.WaveIn waveIn = null;

        int sampleRate;
        int bitDepth;
        int channels;

        private void button_DoFilter_Click(object sender, EventArgs e)
        {
            button_DoFilter.Enabled = false;

            SaveOutput();
            DrawOutputData();

            button_DoFilter.Enabled = true;
        }

        private void button_Record_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                sampleRate = 44100;
                bitDepth = 16;
                channels = 1;

                //Create Wave In device
                waveIn = new NAudio.Wave.WaveIn();

                //Configure Wave format
                NAudio.Wave.WaveFormat waveFormat = new NAudio.Wave.WaveFormat(sampleRate, bitDepth, channels);
                waveIn.WaveFormat = waveFormat;
                waveIn.NumberOfBuffers = 3; //at least TWO
                waveIn.BufferMilliseconds = 1000; //the recording period per buffer

                saveLocation = path + "\\" + RecordFileName;
                writer = new WaveFileWriter(saveLocation, waveFormat);

                //subscribe the event
                waveIn.DataAvailable += WaveIn_DataAvailable;

                waveIn.StartRecording();

                isRecording = true;
                button_Record.Enabled = false;
                button_stop.Enabled = true;
            }
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_Record.Enabled = true;
            button_stop.Enabled = false;
            isRecording = false;

            if (waveIn != null)
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
            }

            if (writer != null)
            {
                writer.Dispose();
                writer = null;
            }
        }

        private void SaveInputData(string path)
        {
            byte[] buffer;
            using (WaveFileReader reader = new WaveFileReader(path))
            {
                sampleRate = reader.WaveFormat.SampleRate;
                bitDepth = reader.WaveFormat.BitsPerSample;
                channels = reader.WaveFormat.Channels;

                sampleLength = reader.Length;
                freqData = new float[sampleLength / 4];
                buffer = new byte[sampleLength];

                IWaveProvider stream32 = new Wave16ToFloatProvider(reader);
                while (reader.Position < reader.Length)
                {
                    try
                    {
                        stream32.Read(buffer, 0, buffer.Length);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                reader.Close();
            }

            for (int i = 0; i < freqData.Length / 4; i++)
                freqData[i] = BitConverter.ToSingle(buffer, i * 4);

        }
        private void SaveOutput()
        {
            filtered = new float[freqData.Length];
            filtered = freqData;
            float cutoff = Convert.ToSingle(textBox_CutOffFreq.Text);
            float bandwidth = Convert.ToSingle(textBox_bandWidth.Text);

            loadLocation = path + "\\" + OutputFileName;

            BiQuadFilter filter = BiQuadFilter.LowPassFilter(sampleRate, cutoff, bandwidth);
            NAudio.Wave.WaveFormat waveFormat = new NAudio.Wave.WaveFormat(sampleRate, bitDepth, channels);
            byte[] bytes = new byte[freqData.Length * 4];
            byte[] temp = new byte[4];

            using (WaveFileWriter writer = new WaveFileWriter(loadLocation, waveFormat))
            {
                for (int i = 0; i < freqData.Length; i++)
                {
                    filtered[i] = filter.Transform(filtered[i]);
                    //Array.Copy(BitConverter.GetBytes(filtered[i]), bytes, i * 4);
                    //temp = BitConverter.GetBytes(100000*filtered[i]);

                    //for (int j = 0; j < 4; j++)
                    //    bytes[4 * i + j] = temp[j];
                    //bytes[4 * i] = Convert.ToByte(filtered[i]);
                    //4 byte to 2 byte and to 1 byte
                    
                }

                //writer.Write(bytes, 0, bytes.Length);
                writer.WriteSamples(filtered, 0, filtered.Length);
                writer.Close();
            }
        }

        private void DrawInputData()
        {
            chart_original.Series["Original"].Points.Clear();
            Complex[] inputData = new Complex[sampleLength / 4];
            for (int i = 0; i < freqData.Length; i++)
                inputData[i] = new Complex() { X = freqData[i], Y = 0 };

            pow = Convert.ToInt32(Math.Ceiling(Math.Log(freqData.Length / 4, 2)));

            Complex[] cloneData = inputData;
            FastFourierTransform.FFT(true, pow, cloneData);
            FixFftResult(cloneData);
            double[] mag_original = GetMagnitude(cloneData, cloneData.Length);

            chart_original.Series["Original"].Points.DataBindXY(freqData, mag_original);
        }

        private void DrawOutputData()
        {
            chart_filter.Series["Filtered"].Points.Clear();
            Complex[] outputData = new Complex[sampleLength / 4];
            for (int i = 0; i < freqData.Length; i++)
                outputData[i] = new Complex() { X = filtered[i], Y = 0 };

            pow = Convert.ToInt32(Math.Ceiling(Math.Log(freqData.Length / 4, 2)));

            Complex[] cloneData = outputData;
            FastFourierTransform.FFT(true, pow, cloneData);
            FixFftResult(cloneData);
            double[] mag_filtered = GetMagnitude(cloneData, cloneData.Length);

            chart_filter.Series["Filtered"].Points.DataBindXY(freqData, mag_filtered);
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            chart_original.Series["Original"].Points.Clear();
            chart_filter.Series["Filtered"].Points.Clear();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "儲存wav檔";
            dialog.Filter = "wav|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilterFileName = dialog.FileName;

                if (System.IO.File.Exists(FilterFileName) == false)
                    return;
                SaveInputData(FilterFileName);
                DrawInputData();
                button_DoFilter.Enabled = true;
            }
        }

        static void FixFftResult(Complex[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i].X *= 2;
                data[i].Y *= 2;
            }
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
    }
}



