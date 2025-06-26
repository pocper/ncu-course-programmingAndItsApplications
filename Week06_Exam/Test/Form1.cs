using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Regex X_values = new Regex(@"(?<=[A-Z]\d{2}X)-?\d{1,}.\d{0,}");
            Regex Y_values = new Regex(@"(?<=.Y)-?\d{1,}.\d{0,}");
            Regex X_values1 = new Regex(@"(?<=X)-?\d{1,}.\d{0,}");
            Regex Y_values1 = new Regex(@"(?<=Y)-?\d{1,}.\d{0,}");
            string str = "";
            foreach (string lines in input_txt.Lines)
            {
                MatchCollection X_value = X_values.Matches(lines);
                MatchCollection Y_value = Y_values.Matches(lines);
                MatchCollection X_value1 = X_values1.Matches(lines);
                MatchCollection Y_value1 = Y_values1.Matches(lines);
                if (X_value.Count != 0)
                {
                    str = String.Format("({0:0.000},{1:0.000})\n", float.Parse(X_value[0].Value), float.Parse(Y_value[0].Value));
                }
                else if (X_value1.Count != 0)
                {
                    str = String.Format("({0:0.000},{1:0.000})\n", float.Parse(X_value1[0].Value), float.Parse(Y_value1[0].Value));
                }
                else
                {
                    str = "NA\n";
                }
                output_txt.AppendText(str);
            }
        }

    }
}
