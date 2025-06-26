using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01_ConstructAString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timerUpdateDateTimeString.Start();
        }

        private void timerUpdateDateTimeString_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            //1. use DateTime format
            string dtString = dt.ToString("yyyy-MM-dd HH:mm:ss");

            //2. use string combination
            //string dtString = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString()
                //+ " " + dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" +dt.Second.ToString();

            //3. use string format
            //string dtString = string.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}.{6:000}", dt.Year, dt.Month, dt.Day,dt.Hour,dt.Minute, dt.Second, dt.Millisecond);

            //4. use string builder
            //StringBuilder sb = new StringBuilder();
            //sb.Append(dt.Hour);
            //sb.Append(":");
            //sb.Append(dt.Minute);
            //sb.Append(":");
            //sb.Append(dt.Second);
            //string dtString = sb.ToString();
          
            tb_Date.Text = dtString;

            SplitDateTimeString();

        }


        void SplitDateTimeString()
        {
            string target = tb_Date.Text;

            //method 1: use index and length
            //"yyyy-MM-dd HH:mm:ss"
            // 01234....             <--index

            //string y = target.Substring(0, 4);
            //tbYear.Text = y;
            //string M = target.Substring(5, 2);
            //tbMonth.Text = M;
            //string D = target.Substring(8, 2);
            //tbDay.Text = D;
            //string H = target.Substring(11, 2);
            //tbHour.Text = H;
            //string m = target.Substring(14, 2);
            //tbMinute.Text = m;
            //string s = target.Substring(17, 2);
            //tbSecond.Text = s;

            //method 2: use split char (video)
            //string[] subStrings = target.Split(' ');
            //string[] YMD = subStrings[0].Split('-');
            //string[] Hms = subStrings[1].Split(':');
            //tbYear.Text = YMD[0];
            //tbMonth.Text = YMD[1];
            //tbDay.Text = YMD[2];
            //tbHour.Text = Hms[0];
            //tbMinute.Text = Hms[1];
            //tbSecond.Text = Hms[2];

            //method 2: advanced
            string[] ss = target.Split(new char[] { '-', ' ', ':' });
            tbYear.Text = ss[0];
            tbMonth.Text = ss[1];
            tbDay.Text = ss[2];
            tbHour.Text = ss[3];
            tbMinute.Text = ss[4];
            tbSecond.Text = ss[5];
        }
    }
}
