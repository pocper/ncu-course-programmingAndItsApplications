using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Program_4_WinForm : Form
    {
        public Program_4_WinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName = "student_info.csv";
            FileStream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);
            int i = 0;
            while (streamReader.EndOfStream != true)
            {
                if (i > 0){
                    string line = streamReader.ReadLine();

                    string[] elements = line.Split(',');
                    dataGridView1.Rows.Add(elements[0], elements[1], elements[2]);
                }
                i++;
            }
            streamReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string FileName = "student_info.csv";
            FileStream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);
            int i = 0;
            while (streamReader.EndOfStream != true)
            {
                if (i > 0)
                {
                    string line = streamReader.ReadLine();

                    string[] elements = line.Split(',');
                    string[] elements_desh = elements[2].Split('/');
                    dataGridView1.Rows.Add(elements[0], elements[1], string.Format("{2}-{1}-{0}", elements_desh[0], elements_desh[1], elements_desh[2]));
                }
                i++;
            }
            streamReader.Close();
        }
    }
}
