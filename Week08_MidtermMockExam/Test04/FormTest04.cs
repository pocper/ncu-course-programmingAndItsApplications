using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test04
{
    public partial class FormTest04 : Form
    {
        string file = null;
        public FormTest04()
        {
            InitializeComponent();
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "開啟一個wav檔";
            dialog.Filter = "wav|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                file = dialog.FileName;

                System.IO.FileInfo fi = new System.IO.FileInfo(file);
                textBox_size.Text = (fi.Length/1024).ToString();
                textBox_date.Text = fi.CreationTime.ToShortDateString();
            }
        }
    }
}
