using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            NCU.MyBox.MyBox myBox1 = new NCU.MyBox.MyBox();
            NCU.MyBox.MyBox myBox2 = new NCU.MyBox.MyBox();
            myBox1.L = 10;
            //NCU.MyBox.MyBox.SetLength(myBox1, 20);
            myBox1.W = 20;
            myBox1.H = 30;
            myBox2.L = 2;
            myBox2.W = 3;
            myBox2.H = 4;

            Console.WriteLine("MyBox1 volume = " + myBox1.GetVolumn().ToString());
            Console.WriteLine("MyBox2 volume = " + myBox2.GetVolumn().ToString());
            Console.ReadKey();
        }
    }

    class MyClass
    {

    }
}
