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

namespace HW
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string check_str = password.Text;
            // upper_character lower_character numbers special_character
            int[]variable=new int[5];
            Regex rx_upper = new Regex(@"[A-Z]");
            MatchCollection upper_characters = rx_upper.Matches(check_str);
            Regex rx_lower = new Regex(@"[a-z]");
            MatchCollection lower_characters = rx_lower.Matches(check_str);
            Regex rx_num = new Regex(@"\d");
            MatchCollection numbers = rx_num.Matches(check_str);
            Regex special_character = new Regex(@"\W");
            MatchCollection specials = special_character.Matches(check_str);
            Regex spaces_reg = new Regex(@"\s");
            MatchCollection spaces = spaces_reg.Matches(check_str);

            foreach(Match character in upper_characters)
            {
                variable[0]+=1;
            }
            foreach(Match character in lower_characters)
            {
                variable[1]+=1;
            }
            foreach(Match num in numbers)
            {
                variable[2]+=1;
            }
            foreach(Match special in specials){
                variable[3]+=1;
            }
            foreach(Match space in spaces){
                variable[4]+=1;
            }

            if(check_str.Length>7&&variable[0]>0&&variable[1]>1&&variable[2]>1&&variable[3]>0&&variable[4]==0){
                MessageBox.Show("OK");
            }
            else{
                password.Text="";
            }

        }
    }
}
