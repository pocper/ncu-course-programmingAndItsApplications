using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.IO;

namespace Test15
{
    public partial class FormTest14 : Form
    {
        ConcurrentQueue<ItemArg> items = new ConcurrentQueue<ItemArg>();
        bool isStarted = false;
        string ErrorMessage = "";
        bool isFileExsisted = true;
        public FormTest14()
        {
            InitializeComponent();
        }

        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var item = new ItemArg(index++);

            string line = string.Format("{0},{1}", item.Index, item.Time);
            listBox_Content.Items.Add(line);
            if(listBox_Content.Items.Count>5)
                listBox_Content.SelectedIndex = listBox_Content.Items.Count - 1;

            items.Enqueue(item);                
            timer1.Start();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isStarted = true;


            TaskFactory taskFactory = new TaskFactory();
            taskFactory.StartNew(BackgroundWork, "myLog.csv");

            button_Start.Enabled = false;
        }

        void BackgroundWork(object path)
        {
            string filePath= path as string;
            
            while (isStarted)
            {
                if(items.Count > 0)
                {
                    try
                    {
                        #region 不能變動的區域
                        {
                            FileStream fs = new FileStream(filePath, FileMode.Open);
                            StreamWriter writer = new StreamWriter(fs, Encoding.ASCII);
                            do
                            {
                                ItemArg myItem = null;
                                if (items.TryDequeue(out myItem))
                                {
                                    string line = string.Format("{1},{0}", myItem.Index, myItem.Time);
                                    writer.WriteLine(line);
                                }
                            } while (items.Count > 0);
                            writer.Close();
                            fs.Close();
                        }
                        #endregion
                    }
                    catch
                    {
                        timer1.Stop();
                        string msg;
                        if (!File.Exists(filePath))
                            msg = String.Format("找不到{0}檔案", filePath);
                        else
                            msg = String.Format("請關閉{0}", filePath);
                        MessageBox.Show(msg);
                        isStarted = false;
                        isFileExsisted = false;
                    }
                }
                else
                    System.Threading.Thread.Sleep(2000);
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            isStarted = false;
            button_Start.Enabled = true;
            timer1.Stop();
        }
    }
}
