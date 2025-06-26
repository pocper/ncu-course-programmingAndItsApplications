using System;
using System.Collections.Generic;

namespace EX01
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<double> values = new List<double>();

            bool isDone = true;
            while (isDone)
            {
                Console.WriteLine("Input a value or key in 'show result' to compute rms value: ");
                var inputValue = Console.ReadLine();

                if (inputValue == "show result")
                {
                    isDone = false;
                }
                else
                {
                    values.Add(Convert.ToDouble(inputValue));
                }
            }

            double square_sum = 0;
            int count = 0;

            foreach (var value in values)
            {
                square_sum += value * value;
                count++;
            }

            double mean = square_sum / count;
            double rms = Math.Sqrt(mean);
            Console.WriteLine("The rms value of the inputting values is " + rms.ToString());
            Console.Read();
        }
    }
}
