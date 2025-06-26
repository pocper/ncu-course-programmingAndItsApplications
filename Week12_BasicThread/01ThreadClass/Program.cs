using System;

using System.Threading;

namespace _01ThreadClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thrd = null;

            Console.WriteLine("=== Phase 1 ===");

            thrd = new Thread(ShowMsg);
            thrd.Start();                   

            thrd = new Thread(
                () => Console.WriteLine("Show 'Hi' "));
            thrd.Start();
            
            Console.WriteLine("Press any key...");
            Console.ReadKey();

            //---------------------------------------------------------
            Console.WriteLine("=== Phase 2 ===");            

            thrd = new Thread(ShowNum);
            thrd.Start();

            ShowNum();//main thread #1

            Console.WriteLine("Press any key...");
            Console.ReadKey();

            //---------------------------------------------------------
            Console.WriteLine("=== Phase 3 ===");           

            Console.WriteLine("=== USE JOIN ===");
            Thread thrd2 = new Thread(ShowNum);
            Thread thrd3 = new Thread(ShowNum);
            thrd2.Start();
            thrd3.Start();
            thrd2.Join();
            thrd3.Join();
            ShowNum();//main thread #1
            Console.ReadKey();
        }

        static void ShowMsg()
        {
            Thread.Sleep(10);
            Console.WriteLine("Hello thread");
        }

        static void ShowNum()
        {
            int thrdID = System.Threading.Thread.CurrentThread.ManagedThreadId;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(string.Format("thread({0}) do {1}", thrdID, i));
                Thread.Sleep(100);
            }
        }
    }
}
