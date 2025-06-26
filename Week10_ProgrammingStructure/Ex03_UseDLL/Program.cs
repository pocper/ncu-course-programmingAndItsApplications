using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCU.MyBox;

namespace Ex03_UseDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to go on");
            Console.ReadKey();

            MyBox mybox = new MyBox();
            mybox.L = 10;
            mybox.W = 20;
            mybox.H = 5;
            int vol = mybox.GetVolumn();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
