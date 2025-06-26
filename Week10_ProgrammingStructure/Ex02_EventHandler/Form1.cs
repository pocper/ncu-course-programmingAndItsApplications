using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex02_EventHandler
{
    public partial class Form1 : Form
    {

        Random r = new Random();
        bool isTimerStarted = false;

#if (DelegateCase)
        delegate void GenerateFiveHandler(int value);
        event GenerateFiveHandler FiveGenerated;
#else
        event EventHandler<NumberArgs> MyFiveGenerated;
#endif

        public Form1()
        {
            InitializeComponent();
#if (DelegateCase)
            FiveGenerated += FiveGeneratedEventCome;
#else
            MyFiveGenerated += FiveComing;
#endif
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (!isTimerStarted)
            {
                timer1.Start();
                isTimerStarted = true;
            }
            else
            {
                timer1.Stop();
                isTimerStarted = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rv = r.Next(0, 10);
            tbRandomValue.Text = rv.ToString();

            if(rv == 5)
            {
#if (DelegateCase)
                if (FiveGenerated != null)
                {
                    GenerateFiveHandler localFiveGenerated 
                        = new GenerateFiveHandler(FiveGenerated);          
                    //publish event
                    localFiveGenerated(5);
                }
#else
                if(MyFiveGenerated !=null)
                {
                    var myLocalFiveGenerated = new EventHandler<NumberArgs>(MyFiveGenerated);
                    //publish event
                    NumberArgs ar = new NumberArgs();
                    ar.Value = rv;
                    myLocalFiveGenerated(null, ar);
                }
#endif

            }
        }
#if (DelegateCase)
        private void FiveGeneratedEventCome(int val)
        {
            listBoxLog.Items.Add(DateTime.Now.ToString() + "-->" + val.ToString());
        }
#else
        private void FiveComing(object sendor, NumberArgs args)
        {
            listBoxLog.Items.Add(args.DateTime.ToString() + "-->" + args.Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbRandomValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
#endif
    }
}
