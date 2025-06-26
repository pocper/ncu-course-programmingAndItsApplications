using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Form1 : Form
    {
        NCU.ME.Box.Box myBox = new NCU.ME.Box.Box();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            myBox.W = Int32.Parse(textBox_Width.Text);
            myBox.L = Int32.Parse(textBox_Length.Text);
            timer1.Start();
        }

        private void SizeChangedEventCome(object sender, NCU.ME.Box.SizeChangedArgs args)
        {
            listBoxLog.Items.Add(String.Format("{0} {1} {2}", args.ChangedTime, args.ChangedType, args.Value));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(textBox_Length.Text!=myBox.L.ToString()|| textBox_Width.Text != myBox.W.ToString())
            {
                myBox.SizeChanged += SizeChangedEventCome;
                myBox.L = Int32.Parse(textBox_Length.Text);
                myBox.W = Int32.Parse(textBox_Width.Text);
            }
        }
    }
}
