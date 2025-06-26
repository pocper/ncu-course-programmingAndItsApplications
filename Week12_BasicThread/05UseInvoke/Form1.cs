using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05UseInvoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Random r = new Random();

            int x1 = r.Next(1000, 9999);
            int x2 = r.Next(1000, 9999);

            textBox1Source.Text = x1.ToString();
            textBox2Source.Text = x2.ToString();
            timer1.Start();

        }

        private void buttonNoInvoke_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
           {
               string text = textBox2Source.Text;
               textBox2Dest.Text = text;
           });
            task.Start();
        }

        private void buttonUsingInvoke_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                string text = textBox1Source.Text;

                if (textBox1Dest.InvokeRequired)
                {
                    //如果需要invoke
                    //step 1. 建立一個delegate方法
                    Action updateMethod = new Action(() => textBox1Dest.Text = text);

                    //step 2. 交給元件Invoke去執行delegate方法
                    textBox1Dest.Invoke(updateMethod);
                }
                else
                {
                    //如果不需要，那就直接更新元件吧
                    textBox1Dest.Text = text;
                }
            });
            task.Start();

        }
    }
}
