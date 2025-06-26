using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace _02ParameterizedThreadClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thrd = new Thread(ShowMsg);
            thrd.Start("Hello Threading");

            thrd = new Thread(ShowNum);
            thrd.Start(100);
        }

        static void ShowMsg(object msg)
        {

            Console.WriteLine(msg as string);
        }

        static void ShowNum(object startNumber)
        {
            int thrdID = System.Threading.Thread.CurrentThread.ManagedThreadId;
            int num =(int)startNumber;
            for (int i = num; i <= num+ 5; i++)
            {
                Console.WriteLine(string.Format("thread({0}) do {1}", thrdID, i));
                Thread.Sleep(100);
            }
        }
    }
}
