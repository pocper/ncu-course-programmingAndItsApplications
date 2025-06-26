using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Test03
{
    public partial class FormTest03 : Form
    {
        public FormTest03()
        {
            InitializeComponent();
        }

        private void button_Findwords_Click(object sender, EventArgs e)
        {
            textBox_output1.Clear();
            string Content = textBox_input.Text;
            Regex suffix = new Regex(@"\w+-?\w+(?<=ed)\b");
            MatchCollection suffix_characters = suffix.Matches(Content);
            int counter = 0;
            foreach (Match characters in suffix_characters)
            {
                textBox_output1.Text += String.Format("{0}",characters.Value);

                if (counter != suffix_characters.Count - 1)
                {
                    textBox_output1.Text += ',';
                }
                counter++;
            }
        }

        private void button_SumUpYears_Click(object sender, EventArgs e)
        {
            textBox_output2.Clear();
            string Content = textBox_input.Text;
            Regex AD = new Regex(@"\d{4}\b");
            MatchCollection AD_numbers = AD.Matches(Content);
            int sum = 0;

            foreach (Match numbers in AD_numbers)
            {
                Int32.TryParse(numbers.Value,out int years);
                sum += years;
            }
            textBox_output2.Text += sum.ToString();
        }
    }
}
