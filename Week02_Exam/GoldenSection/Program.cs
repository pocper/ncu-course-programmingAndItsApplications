using System;

namespace GoldenSection
{
    class Program
    {
        /* ------------------------------------------------
          find root of value using golden section algorithm
           ------------------------------------------------ */
        static void Main(string[] args)
        {
            //get a value from user
            Console.WriteLine("Input a value between 0 and 10 to find its root: ");
            string line = Console.ReadLine();
            double value = 0;
            while (true)
            {
                if (double.TryParse(line, out value))
                    if (value >= 0 || value <= 10)
                        break;
                Console.WriteLine("Please input a numerical value between 0 and 10: ");
                line = Console.ReadLine();
            }
            value = Convert.ToInt32(line);
            Console.WriteLine(value);
            //prepare golden section parameters
            double gr = 0.5 * (3.0 - Math.Sqrt(5.0)); //golden ratio
            double eps = 1e-5; //allowable error
            double xl = 0, xu = 10;//define upper and lower boundaries
            double fl = Func(xl, value);
            double fu = Func(xu, value);
            double x1 = (1 - gr) * xl + gr * xu;
            double x2 = gr * xl + (1 - gr) * xu;
            double f1 = Func(x1, value);
            double f2 = Func(x2, value);

            while ((xu - xl) > eps)
            {
                if (Math.Abs(f1) < Math.Abs(f2))
                {
                    xu = x2;
                    fu = f2;

                    x2 = x1;
                    f2 = f1;

                    x1 = (1 - gr) * xl + gr * xu;
                    f1 = Func(x1, value);
                }
                else
                {
                    xl = x1;
                    fl = f1;

                    x1 = x2;
                    f1 = f2;

                    x2 = gr * xl + (1 - gr) * xu;
                    f2 = Func(x2, value);
                }
            }
            double xm = 0.5 * (xu + xl);
            Console.WriteLine("The root of [" + value.ToString() + "] is " + xm.ToString());
            Console.ReadKey();
        }

        static double Func(double x, double tar)
        {
            return x * x - tar;
        }
    }
}
