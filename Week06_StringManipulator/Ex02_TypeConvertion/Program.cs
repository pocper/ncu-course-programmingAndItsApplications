using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02_TypeConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new object();
            String s = "Hello World";

            o = s;      

            Box basebox1 = new Box() { L = 20, W = 10, H = 5 };
            HoleBox Holebox2 = new HoleBox() { L = 30, W = 20, H = 15, Diameter = 5 };

            Box box3 = Holebox2;
            HoleBox boxHole = null;

            if(basebox1 is HoleBox)
            {
                //boxHole = (HoleBox) basebox1;
                boxHole = basebox1 as HoleBox;
            }

            string str_height = "10";
            int i_height = 0;

          //  int i = int.Parse(str_height);

            if(int.TryParse(str_height, out i_height))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Failed");
            }



        }
    }
}
