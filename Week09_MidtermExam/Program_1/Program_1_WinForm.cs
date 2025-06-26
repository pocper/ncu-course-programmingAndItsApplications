using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Program_1_WinForm : Form
    {
        string openedFile = null;
        public Program_1_WinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "開啟一個PNG檔案";
            openFileDialog.Filter = "PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openedFile = openFileDialog.FileName;
                textBox_FileName.Text = openedFile;

                if (File.Exists(openedFile))
                    ReadContent(openedFile);
                else
                    textBox_FileName.Text = "File does not exist!";
            }
        }

        private void ReadContent(string openedFile)
        {
            int i = 0;
            byte[] Data = File.ReadAllBytes(openedFile);
            foreach (byte s in Data)
            {
                
                textBox_ReadBytes.Text += string.Format("{0}",s);
                i++;
                if (i == 9)
                {
                    break;
                }
                else
                {
                    textBox_ReadBytes.Text += ',';
                }
            }
        }
    }
}
