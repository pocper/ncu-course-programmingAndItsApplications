using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Program_2
{
    
    public partial class Program_2_WinForm : Form
    {
        bool mouseClick = false;
        public Program_2_WinForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button_setPassword_Click(object sender, EventArgs e)
        {
            string password = maskedTextBox_set.Text;

            Regex CheckedFirstCond = new Regex(@"[a-zA-Z0-9]");
            MatchCollection FirstCond = CheckedFirstCond.Matches(password);

            if (FirstCond.Count != password.Length)
            {
                textBox_show.ForeColor = Color.Red;
                textBox_show.Text = password;
                return;
            }
            int contiChar = 0, contiDigit = 0;
            Regex CheckedChar = new Regex(@"[a-zA-Z]");
            Regex CheckedDigit = new Regex(@"[0-9]");
            foreach (char s in password)
            {
                MatchCollection match_char = CheckedChar.Matches(s.ToString());
                if (match_char.Count == 1)
                {
                    contiChar ++;
                }
                else
                {
                    contiChar = 0;
                }

                MatchCollection match_digit = CheckedDigit.Matches(s.ToString());
                if (match_digit.Count == 1)
                {
                    contiDigit ++;
                }
                else
                {
                    contiDigit = 0;
                }

                if (contiChar > 1 || contiDigit > 1)
                {
                    textBox_show.ForeColor = Color.Red;
                    textBox_show.Text = password;
                    return;
                }
            }

         
            textBox_show.Text = password;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mouseClick)
            {
                maskedTextBox_set.PasswordChar = '\0';
            }
            else
            {
                maskedTextBox_set.PasswordChar = '*';
            }
        }

        private void button_show_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClick = true;
        }

        private void button_show_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClick = false;
        }
    }
}
