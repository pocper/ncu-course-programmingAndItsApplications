using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01_Selection
{
    public partial class Form1 : Form
    {
        #region co parameters
        bool button1_flag = false;
        #endregion

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1_flag = !button1_flag;
            //if (button1_flag)
            //    button1.BackColor = Color.Red;
            //else
            //    button1.BackColor = Color.Green;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.BackColor = Color.Red;
                comboBox1.Enabled = false;
                checkedListBox1.Enabled = false;
            }
            else
            {
                button1.BackColor = Color.Green;
                comboBox1.Enabled = true;
                checkedListBox1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string line = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string val = item.ToString();
                if (val == "Y")
                    line += dt.Year.ToString();
                if (val == "M")
                    line += dt.Month.ToString();

            }
            textBox1.Text = line;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem.ToString();

            textBox2.Text = "Your selection is "+selectedItem ;

            

        }
    }
}
