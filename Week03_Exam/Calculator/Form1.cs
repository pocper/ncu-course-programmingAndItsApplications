using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{

    public partial class Form1 : Form
    {
        int[] num = new int[3];
        internal bool isCE = false;
        internal bool isPlus = false;
        internal bool isEqual = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {//zero
            num[0] = 0;
            RunProgram();
        }

        private void button3_Click(object sender, EventArgs e)
        {//one
            num[0] = 1;
            RunProgram();
        }

        private void button2_Click(object sender, EventArgs e)
        {//two
            num[0] = 2;
            RunProgram();
        }

        private void button1_Click(object sender, EventArgs e)
        {//three
            num[0] = 3;
            RunProgram();
        }

        private void button7_Click(object sender, EventArgs e)
        {//four
            num[0] = 4;
            RunProgram();
        }

        private void button6_Click(object sender, EventArgs e)
        {//five
            num[0] = 5;
            RunProgram();
        }

        private void button5_Click(object sender, EventArgs e)
        {//six
            num[0] = 6;
            RunProgram();
        }

        private void button11_Click(object sender, EventArgs e)
        {//seven
            num[0] = 7;
            RunProgram();
        }

        private void button13_Click(object sender, EventArgs e)
        {//eight
            num[0] = 8;
            RunProgram();
        }

        private void button9_Click(object sender, EventArgs e)
        {//nine
            num[0] = 9;
            RunProgram();
        }

        private void button10_Click(object sender, EventArgs e)
        {//CE
            if (!isCE)
            {
                num[0] = 0;
                num[1] = 0;
                num[2] = 0;
                isPlus = false;
                isEqual = false;
                this.textBox1.Text = "";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {//+
            if (!isPlus)
            {
                isPlus = true;
                num[1] = num[0];
                // RunProgram();
            }

        }
// 埔和國小
        private void button3_Click_1(object sender, EventArgs e)
        {//=
            if (!isEqual)
            {
                isEqual = true;
                if (num[2] == 0)
                {
                    num[2] = num[0] + num[1];
                }
                else
                    num[2] += num[0];

                isPlus = false;

                RunProgram();
            }
        }

        private void RunProgram()
        {
            Display();
        }
        private void Display()
        {
            if (isEqual == true)
            {
                this.textBox1.Text = num[2].ToString();
                isEqual = false;
            }
            else
            {
                this.textBox1.Text = num[0].ToString();
            }

            Console.WriteLine("num0=" + num[0]);
            Console.WriteLine("num1=" + num[1]);
            Console.WriteLine("num2=" + num[2]);
            Console.WriteLine("----");
        }
    }
}
