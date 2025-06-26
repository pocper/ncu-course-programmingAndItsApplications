using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ex03_RegExp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string pattern = textBox_Pattern.Text;

            Regex rx = new Regex(
                    pattern);

            string text = richTextBox_Content.Text;

            MatchCollection matches = rx.Matches(text);

            listBox_Result.Items.Clear();

            // foreach(Match match in matches)
            // {
            //     listBox_Result.Items.Add(match.Value as string);
            // }
            foreach (Match match in matches)
            {
                listBox_Result.Items.Add(matches[0].Value as string);
            }

        }
    }
}
