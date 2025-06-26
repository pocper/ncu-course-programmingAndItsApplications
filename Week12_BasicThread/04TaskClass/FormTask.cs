using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;

namespace _04TaskClass
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
        }

        private void DoSomething()
        {
            System.Threading.Thread.Sleep(500);

            string str = string.Format("thrd {0} is running",
                System.Threading.Thread.CurrentThread.ManagedThreadId);

            this.BeginInvoke(new MethodInvoker(
                () =>
                {
                    listBox1.Items.Add(str);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }
            ));
        }

        private void DoSomething2(object name)
        {
            System.Threading.Thread.Sleep(500);

            string str = string.Format("thrd {0} is running and its name is {1}",
                System.Threading.Thread.CurrentThread.ManagedThreadId, name as string);

            this.BeginInvoke(new MethodInvoker(
                () =>
                {
                    listBox1.Items.Add(str);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }
            ));
        }



        private double GetPower(object x)
        {
            System.Threading.Thread.Sleep(500);
            return Math.Pow((double)x ,2.0);
        }

        private int GetThrdId()
        {
            return System.Threading.Thread.CurrentThread.ManagedThreadId;
        }
        private int GetThrdId(object name)
        {
            System.Threading.Thread.Sleep(500);
            int id = System.Threading.Thread.CurrentThread.ManagedThreadId;

            string str = string.Format("thrd {0} is running and its name is {1}", id, name as string);

            this.BeginInvoke(new MethodInvoker(
                () =>
                {
                    listBox1.Items.Add(str);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }
            ));
            return id;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.SetMaxThreads(
                comboBox1.SelectedIndex + 3, comboBox1.SelectedIndex + 1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //-----------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Task[] tasks = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                tasks[i] = new Task(DoSomething);
                tasks[i].Start();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Task[] tasks = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                //tasks[i] = new Task(DoSomething);
                //tasks[i].Start();
                Task.Factory.StartNew(DoSomething);
            }
            Task task = Task.Factory.StartNew(DoSomething);
        }
        //-----------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "#";
            Task[] tasks = new Task[20];
            for (int i = 0; i < 20; i++)
            {
                tasks[i] = new Task(DoSomething2, name+i.ToString());
                tasks[i].Start();
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = "#";
            System.Threading.Tasks.Parallel.For(0, 20, i => DoSomething2(name + i.ToString()));
        }
        //-----------------------------------------------------
        Random r = new Random();
        private int GetRandom()
        {
            System.Threading.Thread.Sleep(500);
            return r.Next(100);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Task<int>[] tasks = new Task<int>[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = new Task<int>(GetRandom);
                tasks[i].Start();
                //Console.WriteLine(string.Format("Thread {0} got {1}", tasks[i].Id, tasks[i].Result));
            }
            foreach (Task<int> task in tasks)
                Console.WriteLine(string.Format("Thread {0} got {1}", task.Id, task.Result));
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Task<int>[] tasks = new Task<int>[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = new Task<int>(
                        () =>
                        {
                            System.Threading.Thread.Sleep(500);
                            return r.Next(100); 
                        }
                    );
                tasks[i].Start();
            }
            foreach (Task<int> task in tasks)
                Console.WriteLine(string.Format("Thread {0} got {1}", task.Id, task.Result));
        }
        //-----------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            Task<double>[] tasks = new Task<double>[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = new Task<double>(GetPower, Convert.ToDouble(i));
                tasks[i].Start();
               // Console.WriteLine(string.Format("Thread {0} got {1}", tasks[i].Id, tasks[i].Result));
            }
            foreach (Task<double> task in tasks)
                Console.WriteLine(string.Format("Thread {0} got {1}", task.Id, task.Result));
        }
        //偷吃步
        private void button12_Click(object sender, EventArgs e)
        {
            Task<double>[] tasks = new Task<double>[10];
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)//利用scope的有效範圍傳參數
                {
                    tasks[i] = new Task<double>(
                            () =>
                            {
                                return Math.Pow(i, 2);
                            }
                    );
                }
                else//老實傳參數法
                {
                    tasks[i] = new Task<double>(
                        new Func<object,double>( x => Math.Pow((double)x, 2)),//x是以object方式傳入，需要轉型
                            Convert.ToDouble(i)
                    );
                }
                tasks[i].Start();

            }
            foreach (Task<double> task in tasks)
                Console.WriteLine(string.Format("Thread {0} got {1}", task.Id, task.Result));
        }






    }
}
