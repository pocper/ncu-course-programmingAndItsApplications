using System;
using System.Threading;
namespace Ex02
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Task: Display Fibonacci Sequence
            // for example:   0, 1, 1, 2, 3, 5, 8, 13, 21
            // the index are  0  1  2  3  4  5  6   7   8
            Console.Write("Input an index of Fibonacci Sequence: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int index = Console.Read() - Convert.ToInt32('0');// error

            int value = F(index);
            Console.WriteLine(string.Format("The value is {0}", value.ToString()));
            // Thread.Sleep(2000);
            string a = Console.ReadLine();
            // Thread.Sleep(2000);
             Console.WriteLine(a);
        }

        static int F(int idx)
        {
            int value = 0;

            if (idx <= 2)
            {
                value = 1;
            }
            else
            {
                value = F(idx - 1) + F(idx - 2);
            }

            return value;
        }
    }
}
