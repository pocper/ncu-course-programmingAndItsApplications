using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01_MyWinForm
{
    public partial class MyWinForm : Form
    {
        public MyWinForm()
        {
            InitializeComponent();

            //button_StartTask.Text = "123";
        }

        private void button_StartTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button_Start is clicked.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
