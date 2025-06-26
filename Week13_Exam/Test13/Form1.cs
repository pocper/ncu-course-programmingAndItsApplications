using NCU.ME;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test13
{
    public partial class Form1 : Form
    {
        CncAgent agent;
        string time;
        short index = 0;
        int count;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void button_connect_Click(object sender, EventArgs e)
        {
            short h = 0;
            string str;
            
            if (int.TryParse(textBox_count.Text, out count))
            {
                agent = new CncAgent("127.0.0.1", 3099);
                for (short i = index; i < index+3; i++)
                {
                    if (i == count+1) break;

                    if (agent.Connect())
                    {
                        Console.WriteLine("In if");
                        Console.WriteLine("h=" + agent.h);
                        listBox_handle.Items.Add(agent.h);
                        listBox_handle.Refresh();
                        agent.GetSpeed();
                        agent.GetTemp();
                        agent.GetRuntime();
                        str = String.Format("Handle {0} : Speed:{1} Temp:{2} RunTime:{3}", agent.h, agent.spd, agent.temp, agent.sec);
                        listBox_msg.Items.Add(str);
                        listBox_msg.Refresh();
                    }
                }
                index = agent.h;
            }  
        }
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            listBox_handle.Items.Clear();
            listBox_msg.Items.Clear();
            string str= String.Format("{0} Releasing Handle", time);
            listBox_msg.Items.Add(str);
            if (agent != null)
            {
                agent.SetDisconnect(index);
                agent.Dispose();
            }
                
            
            
        }
        

        private void button_release_Click(object sender, EventArgs e)
        {
            CncSimulator simulator = new CncSimulator();
            for (short i = (short)(index - 2); i < index + 1; i++)
            {
                simulator.ReleaseHandle(i);
                string str = String.Format("Releasing Handle {0}", i);
                listBox_msg.Items.Add(str);
                listBox_msg.Refresh();
                listBox_handle.Items.RemoveAt(0);
                listBox_handle.Refresh();
            }
            listBox_handle.Items.Clear();
            index ++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToShortTimeString();
        }
    }
}
