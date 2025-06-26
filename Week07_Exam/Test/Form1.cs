using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Test
{
    public partial class Form1 : Form
    {
        string SelectedPath = null;
        string SavedPath = null;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "開啟一個文字檔";
            dialog.Filter = "txt|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedPath = dialog.FileName;

                if (System.IO.File.Exists(SelectedPath) == false)
                {
                    textBox_select.Text = "File doest not exist";
                    return;
                }

                System.IO.FileInfo fi = new System.IO.FileInfo(SelectedPath);
                SelectedPath = fi.FullName;
                textBox_select.Text = SelectedPath;
            }
        }

        private void ReadContent(string FilePath, int num)
        {
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            int i = 1;
            while (streamReader.EndOfStream != true)
            {
                string line = streamReader.ReadLine();
                if (i == num)
                {
                    Regex X_values = new Regex(@"(?<=X=)-?\d{0,}.\d{0,}");
                    MatchCollection X_value = X_values.Matches(line);
                    Regex Y_values = new Regex(@"(?<=Y=)-?\d{0,}.\d{0,}");
                    MatchCollection Y_value = Y_values.Matches(line);
                    Regex Z_values = new Regex(@"(?<=Z=)-?\d{0,}.\d{0,}");
                    MatchCollection Z_value = Z_values.Matches(line);

                    textBox_X.Text = X_value[0].Value;
                    textBox_Y.Text = Y_value[0].Value;
                    textBox_Z.Text = Z_value[0].Value;
                }
                i++;
            }
            streamReader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SelectedPath != null && textBox_No.Text != "")
            {
                ReadContent(SelectedPath, Convert.ToInt32(textBox_No.Text));
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "儲存一個二禁制檔";
            dialog.Filter = "bin|*.bin";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SavedPath = dialog.FileName;
                textBox_save.Text = SavedPath;
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            if (SavedPath != null && SelectedPath != null)
            {
                ConvertContent();
            }
        }

        private void ConvertContent()
        {
            FileStream fileStream_save = new FileStream(SelectedPath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader_save = new StreamReader(fileStream_save, Encoding.UTF8);

            double X, Y, Z;
            double R, theta, phi;

            FileStream fileStream_convert = new FileStream(SavedPath, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fileStream_convert, Encoding.UTF8);

            while (streamReader_save.EndOfStream != true)
            {
                string line = streamReader_save.ReadLine();

                Regex X_values = new Regex(@"(?<=X=)-?\d{0,}.\d{0,}");
                MatchCollection X_value = X_values.Matches(line);
                Regex Y_values = new Regex(@"(?<=Y=)-?\d{0,}.\d{0,}");
                MatchCollection Y_value = Y_values.Matches(line);
                Regex Z_values = new Regex(@"(?<=Z=)-?\d{0,}.\d{0,}");
                MatchCollection Z_value = Z_values.Matches(line);

                X = Convert.ToDouble(X_value[0].Value);
                Y = Convert.ToDouble(Y_value[0].Value);
                Z = Convert.ToDouble(Z_value[0].Value);

                R = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
                theta = Math.Atan2(Y, X) * 180 / Math.PI;
                phi = Math.Atan2(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)), Z) * 180 / Math.PI;

                bw.Write((short)Math.Truncate(R));
                bw.Write((int)Math.Truncate((R * 10000) % 10000));

                bw.Write((short)Math.Truncate(theta));
                bw.Write((int)Math.Truncate((theta * 10000) % 10000));

                bw.Write((short)Math.Truncate(phi));
                bw.Write((int)Math.Truncate((phi * 10000) % 10000));
            }
            bw.Close();
            streamReader_save.Close();
        }
    }
}
