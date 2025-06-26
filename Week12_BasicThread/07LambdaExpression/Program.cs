using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace _07LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[] { "1", "2", "3" };
            int[] data = Array.ConvertAll(lines, myParse);

            int[] data2 = Array.ConvertAll(lines, (x) => { return int.Parse(x); } );

            Thread thrd = new Thread(
                () =>
                {
                    int[] data3 = Array.ConvertAll(lines, myParse);
                    foreach (var v in data3)
                        Console.WriteLine(v.ToString());
                }
            );
            thrd.Start();

            Console.ReadKey();

        }

        static int myParse(string str)
        {
            return int.Parse(str);
        }
    }
}
