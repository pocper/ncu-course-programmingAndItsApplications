using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test02
{
    public partial class FormTest02 : Form
    {
        public FormTest02()
        {
            InitializeComponent();
            timer1.Start();
            PB.Maximum = 128;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Int32.TryParse(TB.Text,out int value))
            {
                if (value > -1 && value < 129)
                {
                    if (value < 70)
                        PB.ForeColor = Color.Green;
                    else if (value >= 70 && value <= 100)
                        PB.ForeColor = Color.Yellow;
                    else
                        PB.ForeColor = Color.Red;

                    PB.Value = value;
                }
            }
        }
    }
}
