using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EX01_lock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        #region data member
        bool isSrcThrdRunning = false;
        bool isCopyingThrdRunning = false;
        Random r = new Random();
        //int[] generatedData = new int[10];
        int[] sourceBuffer = new int[10];
        int[] destBuffer = new int[10];
        object _lockTarget = new object();
        #endregion

        private void buttonNoLock_Click(object sender, EventArgs e)
        {
            if (isSrcThrdRunning == true)
            {
                isSrcThrdRunning = false;
                isCopyingThrdRunning = false;
                return;
            }
            else
            {                
                isSrcThrdRunning = true;
                //產生工作執行緒複製資料到source buffer

                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("執行緒A: 工作開始");
                    isCopyingThrdRunning = true;

                    while (isSrcThrdRunning)
                    {
                        //產生資料
                        Console.WriteLine("執行緒A: 產生新資料");                        
                        List<int> generatedData = new List<int>();
                        for (int i = 0; i < 10; i++)
                            generatedData.Add(r.Next(0, 99));

                        Console.WriteLine("執行緒A: 資料儲存中");
                        for (int i = 0; i < 10; i++)
                        {
                            Thread.Sleep(r.Next(500, 2000));//使用sleep模擬工作負載ㄖ
                            sourceBuffer[i] = generatedData[i];
                        }
                        Console.WriteLine("執行緒A: 資料儲存結束，暫停5秒");
                        Thread.Sleep(5000);
                    }
                    isSrcThrdRunning = false;
                    Console.WriteLine("執行緒A: 工作結束");
                });

                while (isCopyingThrdRunning == false) ;

                //產生工作執行緒將source buffer複製到dest buffer
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("執行緒B: 工作開始");
                    while (isCopyingThrdRunning)
                    {
                        Console.WriteLine("執行緒B: 資料複製中");
                        for (int i = 0; i < 10; i++)
                        {
                            destBuffer[i] = sourceBuffer[i];
                        }
                        Thread.Sleep(1000);
                    }
                    isCopyingThrdRunning = false;
                    Console.WriteLine("執行緒B: 工作結束");
                });
            }
        }


        private void buttonUseLock_Click(object sender, EventArgs e)
        {
            if (isSrcThrdRunning == true)
            {
                isSrcThrdRunning = false;
                isCopyingThrdRunning = false;
                return;
            }
            else
            {
                Console.WriteLine("執行緒A: 工作開始");
                isSrcThrdRunning = true;
                //產生工作執行緒複製資料到source buffer

                Task.Factory.StartNew(() =>
                {
                    isCopyingThrdRunning = true;

                    while (isSrcThrdRunning)
                    {
                        Console.WriteLine("執行緒A: 產生新資料");
                        //產生資料
                        List<int> generatedData = new List<int>();
                        for (int i = 0; i < 10; i++)
                            generatedData.Add(r.Next(0, 99));

                        Console.WriteLine("執行緒A: 資料儲存中, 使用lock鎖定資料");
                        lock (_lockTarget)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                Thread.Sleep(r.Next(500, 2000));//使用sleep模擬工作負載
                                sourceBuffer[i] = generatedData[i];
                            }                            
                        }
                        Console.WriteLine("執行緒A: 解除鎖定");
                        Console.WriteLine("執行緒A: 資料儲存結束，暫停5秒");
                        Thread.Sleep(5000);
                    }
                    isSrcThrdRunning = false;
                    Console.WriteLine("執行緒A: 工作結束");
                });

                while (isCopyingThrdRunning == false) ;

                //產生工作執行緒將source buffer複製到dest buffer
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("執行緒B: 工作開始");
                    while (isCopyingThrdRunning)
                    {
                        Console.WriteLine("執行緒B: 準備資料複製中, 若資料鎖定會暫停");
                        lock (_lockTarget)
                        {
                            Console.WriteLine("執行緒B: 資料複製進行中");
                            for (int i = 0; i < 10; i++)
                            {
                                destBuffer[i] = sourceBuffer[i];
                            }
                        }
                        Thread.Sleep(1000);
                    }
                    isCopyingThrdRunning = false;
                    Console.WriteLine("執行緒B: 工作結束");
                });
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            listBoxSource.Items.Clear();
            foreach (var item in sourceBuffer)
                listBoxSource.Items.Add(item.ToString());

            listBoxCopied.Items.Clear();
            foreach (var item in destBuffer)
                listBoxCopied.Items.Add(item.ToString());
        }
    }
}
