using MyDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEXE
{
    public partial class Form1 : Form
    {
        MyDLL.Game _1A2B_ = new MyDLL.Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_checked_Click(object sender, EventArgs e)
        {
            _1A2B_.Checking += CheckingEventCome;
            _1A2B_.SetAnwser(maskedTextBox_set.Text, maskedTextBox_input.Text);
        }

        private void CheckingEventCome(object sender, GuessResultArgs e)
        {
            textBox_output.Text =e.result;
        }
    }
}
