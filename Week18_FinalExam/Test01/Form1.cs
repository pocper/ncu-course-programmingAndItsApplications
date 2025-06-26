using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string DataDir;
        private void buttonAnalyzed_Click(object sender, EventArgs e)
        {
            listBoxThrdId.Items.Clear();
            ThreadPool.SetMinThreads(3, 3);
            for(int i = 0; i < 10000; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(o => Classify()));
            }
            
        }

        Regex ID = new Regex(@"^\d{9}$");
        Regex Birth = new Regex(@"^\d{4}-\d{2}-\d{2}$");
        Regex PhoneNumber = new Regex(@"^\d{4}-\d{6}$");
        Regex Email = new Regex(@"(?:cc.ncu.edu.tw)|(?:ncu.edu.tw)$");

        int fileNum = 199300001;


        private void ReadFile()
        {
            string workPath = System.Environment.CurrentDirectory;

            DataDir = workPath + "\\data\\";
            string OKDir = workPath+ "\\OK\\";
            string DataName = fileNum.ToString();
            fileNum++;
            string filePath = DataDir + DataName + ".csv";
            string OKPath = OKDir+DataName + ".csv";
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            int i = 0;
            int count = 0;
            while (streamReader.EndOfStream != true)
            {
                string line = streamReader.ReadLine();

                if (i == 0)
                {
                    MatchCollection matches = ID.Matches(line);
                    count += matches.Count;
                }
                else if (i == 1)
                {
                    MatchCollection matches = Birth.Matches(line);
                    count += matches.Count;
                }
                else if (i == 2)
                {
                    MatchCollection matches = PhoneNumber.Matches(line);
                    count += matches.Count;
                }
                else if (i == 3)
                {
                    MatchCollection matches = Email.Matches(line);
                    count += matches.Count;
                }
                i++;
                Console.WriteLine(line);
            }
            streamReader.Close();

            if (count == 4)
            {
                System.IO.File.Move(filePath, OKPath);
                Console.WriteLine("finish!\n");
            }
        }

        private void Classify()
        {
            string str = string.Format("thrd {0} is running",
            System.Threading.Thread.CurrentThread.ManagedThreadId);
            this.BeginInvoke(new MethodInvoker(
                () =>
                {
                    ReadFile();
                    listBoxThrdId.Items.Add(str);
                }
            ));
            Thread.Sleep(20);
        }

    }
}
