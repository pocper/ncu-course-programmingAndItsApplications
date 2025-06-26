using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _06WorkingThreadTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread thrd = null;
        bool isRunning = false;
        bool isStarted = false;
        Thread thrd_changedText = null;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            thrd = new Thread(this.Show);
            thrd.Start();
            isRunning = true;
            isStarted = true;
        }

        private void Show()
        {
            DateTime time = DateTime.Now;
            while (isStarted)
            {
                time = DateTime.Now;
                if (isRunning)
                {
                    if (tb_show.InvokeRequired)
                    {
                        Action action = new Action(() => tb_show.Text = time.ToString("hh:mm:ss"));
                        tb_show.Invoke(action);
                    }
                    else
                    {
                        tb_show.Text = time.ToString("hh:mm:ss");
                    }
                }
                Thread.Sleep(500);
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            isRunning = false;
            isStarted = false;
            thrd.Join(200);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thrd.IsAlive)
            {
                isRunning = false;
                isStarted = false;
                thrd.Join(200);
            }
        }

        private void button_text_Click(object sender, EventArgs e)
        {
            isRunning = false;
            thrd_changedText = new Thread(() => 
            {
                Action action = new Action(() => tb_show.Text = textBox_input.Text);
                tb_show.Invoke(action);
            });
            thrd_changedText.Start();
        }
    }
}
