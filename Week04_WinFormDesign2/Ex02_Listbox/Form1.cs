using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex02_Listbox
{
    public partial class Form1 : Form
    {

        List<string> colors = new List<string>()
        {
              "Red",
              "Yellow"
        };

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string item = textBox_Item.Text;
            colors.Add(item);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var color in colors)
            {
                listBox1.Items.Add(color);
            }
        }
    }
}
