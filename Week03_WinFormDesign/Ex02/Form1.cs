using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ShowDate_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DateTime dt = DateTime.Now;
            this.textBox_ShowMsg.Text = dt.ToShortDateString();
            textBox_ShowMsg.BackColor = Color.Cyan;
        }

        private void button_ShowTime_Click(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            //this.textBox_ShowMsg.Text = dt.ToShortTimeString();
            timer1.Start();
            textBox_ShowMsg.BackColor = Color.White;
        }

        internal int count = 0;
        internal DateTime StartTime = DateTime.Now;
        internal DateTime EndTime = DateTime.Now;
        private void timer1_Tick(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            TimeSpan dt = EndTime - StartTime;
            if (TimeSpan.Compare(dt, new TimeSpan(0, 0, 2)) == 1)
            {
                count++;
                StartTime = DateTime.Now;
            }
            switch (count)
            {
                case 0:
                    BackColor = Color.Red;
                    break;
                case 1:
                    BackColor = Color.Orange;
                    break;
                case 2:
                    BackColor = Color.Yellow;
                    break;
                case 3:
                    BackColor = Color.Green;
                    break;
                case 4:
                    BackColor = Color.Blue;
                    break;
                case 5:
                    BackColor = Color.Cyan;
                    break;
                case 6:
                    BackColor = Color.Purple;
                    break;

            }
            if (count > 6)
            {
                count = 0;
            }
            this.textBox_ShowMsg.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
