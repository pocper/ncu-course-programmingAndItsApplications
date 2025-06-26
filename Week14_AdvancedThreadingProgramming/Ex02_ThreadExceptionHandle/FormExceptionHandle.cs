using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex02_DeadLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        string filePath = null;
        int progress = 0;
        bool isTaskCompleted = true;
        string Message = "";

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "csv file|*.csv";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Message = "";
            System.Threading.Tasks.Task task
                = new System.Threading.Tasks.Task( this.SaveData );

            task.Start();           
        }

        private void SaveData()
        {
            isTaskCompleted = false;
            MyDataWriter writer = new MyDataWriter(this.filePath);
            Random r = new Random();
            int k = 0;

            try
            {
                writer.Open();
            }
            catch (Exception ex)
            {
                System.Threading.Interlocked.Exchange(ref Message, ex.ToString());
                isTaskCompleted = true;
                return;
            }

            while (k <= 100)
            {
                int x = r.Next(0, 9999);
                string line = string.Format("{0},{1}", DateTime.Now, x);
                writer.WriteData(line);
                System.Threading.Interlocked.Exchange(ref progress, k);
                System.Threading.Thread.Sleep(50);
                k++;
            }

            writer.Close();
            System.Threading.Thread.Sleep(500);
            isTaskCompleted = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progress;

            buttonSave.Enabled = isTaskCompleted;

            textBox1.Text = Message;
                
        }
    }
}
