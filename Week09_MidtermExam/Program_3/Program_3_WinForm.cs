using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Program_3_WinForm : Form
    {
        int[,] A = new int[3, 3];
        int[,] L = new int[3, 3];
        int[,] U = new int[3, 3];

        public Program_3_WinForm()
        {
            InitializeComponent();
            textBox_A.Text =
                "3,-1,2" + Environment.NewLine +
                "6,-1,5" + Environment.NewLine +
                "-9,7,3";
            textBox_L.Text =
                "1,0,0" + Environment.NewLine +
                "2,1,0" + Environment.NewLine +
                "-3,4,1";
            textBox_U.Text =
                "3,-1,2" + Environment.NewLine +
                "0,1,1" + Environment.NewLine +
                "0,0,5";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] elements = textBox_A.Lines[i].Split(',');
                A[i, 0] = Int32.Parse(elements[0]);
                A[i, 1] = Int32.Parse(elements[1]);
                A[i, 2] = Int32.Parse(elements[2]);
            }
            int[,] L1 = new int[3, 3] { { 1, 0, 0 }, { -A[1, 0] / A[0, 0], 1, 0 }, { A[2, 0] / A[0, 0], 0, 1 } };
            int[,] temp1 = Multiply(L1, A);
            int[,] L2 = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, -temp1[2, 2] / temp1[1, 2], 1 } };

            U = Multiply(L2, Multiply(L1, A));
        }

        private int[,] Multiply(int[,] lhs, int[,] rhs)
        {
            //initialize 
            int[,] C = new int[3, 3];
            C.Initialize();

            //calculate
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        C[r, c] += lhs[r, i] * rhs[i, c];
                    }
                }
            }
            return C;
        }
    }
}
