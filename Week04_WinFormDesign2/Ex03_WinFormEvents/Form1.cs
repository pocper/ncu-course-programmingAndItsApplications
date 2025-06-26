using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex03_WinFormEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            // var Size = this.ClientSize;
            int H = this.Height;
            int W = this.Width;
            Console.WriteLine("Size: " + W.ToString() + " , " + H.ToString());
            
        }
    }
}
