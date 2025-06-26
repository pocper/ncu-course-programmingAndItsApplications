using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ex01b_AdvancedLock
{
    public partial class FormEx01b : Form
    {
        public FormEx01b()
        {
            InitializeComponent();
            timer1.Start();
        }

        bool isThrdStopped = false;
        object xFlag = new object();
        Random r = new Random();
        int xA = 0;
        int xB = 0;        
        int xThreshold = 80;

        #region 重點區域
        int _xAlarm = 0;
        int xAlarm
        {
            get 
            {
                lock (xFlag)
                    return _xAlarm;
            }
            set
            {
                int thrdId = Thread.CurrentThread.ManagedThreadId;
                Debug.WriteLine(string.Format("Task {0} try to access xAlarm at {1:hh-mm-ss.sss}", thrdId,DateTime.Now));
                lock (xFlag)
                {
                    Debug.WriteLine(string.Format("Task {0} is modifying the value at {1:hh-mm-ss.sss}", thrdId, DateTime.Now));
                    _xAlarm = value;
                    Thread.Sleep(3000);
                }
                Debug.WriteLine(string.Format("Task {0} release the resource at {1:hh-mm-ss.sss}", thrdId,DateTime.Now));
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_xA.Text = xA.ToString();
            tb_xB.Text = xB.ToString();
            tb_xAlarm.Text = xAlarm.ToString();
        }

        private void buttonStartThrdA_Click(object sender, EventArgs e)
        {
            buttonStartThrdA.Enabled = false;
            Task task = new Task(
                ()=>
                {                    
                    while(!isThrdStopped)
                    {
                        //產生0-100的隨機整數
                        int val = r.Next(0, 100);

                        //透過interlocked進行原子操作
                        Interlocked.Exchange(ref xA, val);

                        if(val>xThreshold)
                        {
                                 xAlarm = val;                         
                        }
                        Thread.Sleep(1000);
                    }
                    int thrdId = Thread.CurrentThread.ManagedThreadId;
                    Debug.WriteLine(string.Format("Task {0} is being terminated",thrdId));
                }
                );
            task.Start();
        }

        private void buttonStartThrdB_Click(object sender, EventArgs e)
        {
            buttonStartThrdB.Enabled = false;
            Task task = new Task(
               () =>
               {
                   while (!isThrdStopped)
                   {
                       //產生0-100的隨機整數
                       int val = r.Next(0, 100);

                       //透過interlocked進行原子操作
                       Interlocked.Exchange(ref xB, val);

                       if (val > xThreshold)
                       {
                           xAlarm = val;
                       }
                       Thread.Sleep(2000);
                   }
                   int thrdId = Thread.CurrentThread.ManagedThreadId;
                   Debug.WriteLine(string.Format("Task {0} is being terminated", thrdId));
               }
               );
            task.Start();
        }
    }
}
