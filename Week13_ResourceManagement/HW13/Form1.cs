using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyDataWriter writer;
        private void button_open_Click(object sender, EventArgs e)
        {
            string file = "";

            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;

                if (System.IO.File.Exists(file) == false)
                {
                    return;
                }
            }

            writer = new MyDataWriter(file);
            writer.Open();

            button_open.Enabled = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            if (writer != null)
                writer.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (writer != null)
                writer.Dispose();
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            writer.WriteData(textBox.Text);
            textBox.Clear();
        }
    }
}
