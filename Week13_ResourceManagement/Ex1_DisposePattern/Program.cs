using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1_DisposePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            myFunc();

            //myDisposableItem.Dispose();

            GC.Collect();

            Console.ReadKey();
        }

        static void myFunc()
        {
            MyDisposableItem myDisposableItem = new MyDisposableItem();
        }
    }
}
