using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace _03ThreadPool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                Thread thrd = new Thread(DoSomething);
                thrd.Start();
            }

        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ThreadPool.SetMaxThreads(3, 3);
            for (int i = 0; i < 20; i++)
                ThreadPool.QueueUserWorkItem(new WaitCallback(o => DoSomething()));
        }

        private void DoSomething()
        {
            string str = string.Format("thrd {0} is running",
                System.Threading.Thread.CurrentThread.ManagedThreadId);
            this.BeginInvoke(new MethodInvoker(
                () =>
                {
                    listBox1.Items.Add(str);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }
            ));
            Thread.Sleep(20);
        }


    }
}
