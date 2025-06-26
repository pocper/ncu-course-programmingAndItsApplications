using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Ex03_DataStructPattern
{
    public partial class Form1 : Form
    {
        #region data member / attribute
        CoParameters CoParameters = new CoParameters();
        #endregion

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void button_SelectRed_Click(object sender, EventArgs e)
        {
            this.CoParameters.AssignedJob = 0;
            //this.textBox_ShowJob.Text = "Red"; //不建議這麼做
        }

        private void button_SelectGreen_Click(object sender, EventArgs e)
        {
            CoParameters.AssignedJob = 1;
            //this.textBox_ShowJob.Text = "Green"; //不建議這麼做
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!CoParameters.isStarted)
            {
                CoParameters.isStarted = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (!CoParameters.isResetStarted)
                CoParameters.isResetStarted = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Thread thrd = new Thread(DoRobotJob);

            switch (CoParameters.AssignedJob)
            {
                case 0:
                    this.textBox_ShowJob.Text = "Red";
                    break;
                case 1:
                    this.textBox_ShowJob.Text = "Green";
                    break;
                default:
                    this.textBox_ShowJob.Text = "Red";
                    break;
            }
            buttonStart.Enabled = CoParameters.isStarted ? false : true;

            if (CoParameters.isStarted && CoParameters.RobotStatus == RobotStatus.Idle)
            {
                CoParameters.ExecutedJob = CoParameters.AssignedJob;
                CoParameters.isResetStarted = false;

                //執行過程
                thrd.Start();
            }

            if (CoParameters.isResetStarted == true)
            {
                timer1.Stop();
                thrd.Abort();
                // CoParameters.AssignedJob = 0;
                CoParameters.ExecutedJob = 0;
                CoParameters.isStarted = false;
                CoParameters.RobotStatus = RobotStatus.Idle;
                CoParameters.RobotPosition = RobotPosition.Origin;
                CoParameters.InitTime = DateTime.Now;
                CoParameters.EndTime = DateTime.Now;

                thrd = new Thread(DoRobotJob);
            }

            if (CoParameters.RobotStatus == RobotStatus.Idle)
            {
                TimeSpan ts = (CoParameters.EndTime - CoParameters.InitTime);
                textBox_CycleTime.Text = ts.TotalSeconds.ToString();
            }
            else
            {
                TimeSpan ts = (DateTime.Now - CoParameters.InitTime);
                textBox_CycleTime.Text = ts.TotalSeconds.ToString();
            }

            label_Position.Text = CoParameters.RobotPosition.ToString();
            label_Status.Text = CoParameters.RobotStatus.ToString();

            timer1.Start();

        }

        private void DoRobotJob()
        {
            CoParameters.InitTime = DateTime.Now;
            switch (CoParameters.ExecutedJob)
            {
                case 0:
                    CoParameters.RobotStatus = RobotStatus.Moving;
                    Thread.Sleep(5000);
                    CoParameters.RobotPosition = RobotPosition.RedStorage;
                    CoParameters.RobotStatus = RobotStatus.Pickup;
                    Thread.Sleep(2000);
                    CoParameters.RobotStatus = RobotStatus.Moving;
                    Thread.Sleep(8000);
                    CoParameters.RobotPosition = RobotPosition.Port;
                    CoParameters.RobotStatus = RobotStatus.Place;
                    Thread.Sleep(2000);
                    CoParameters.RobotStatus = RobotStatus.Moving;
                    Thread.Sleep(7000);
                    CoParameters.RobotPosition = RobotPosition.Origin;
                    CoParameters.RobotStatus = RobotStatus.Idle;
                    break;
                case 1:
                    CoParameters.RobotStatus = RobotStatus.Moving;
                    Thread.Sleep(8000);
                    CoParameters.RobotPosition = RobotPosition.GreenStorage;
                    CoParameters.RobotStatus = RobotStatus.Pickup;
                    Thread.Sleep(2000);
                    CoParameters.RobotStatus = RobotStatus.Moving;
                    Thread.Sleep(5000);
                    CoParameters.RobotPosition = RobotPosition.Port;
                    CoParameters.RobotStatus = RobotStatus.Place;
                    Thread.Sleep(2000);
                    CoParameters.RobotStatus = RobotStatus.Moving;
                    Thread.Sleep(7000);
                    CoParameters.RobotPosition = RobotPosition.Origin;
                    CoParameters.RobotStatus = RobotStatus.Idle;
                    break;

            }

            //執行結束
            CoParameters.EndTime = DateTime.Now;
            CoParameters.isStarted = false;
        }
    }
}
