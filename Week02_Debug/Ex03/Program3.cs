using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03
{
    class Program3
    {
        static void Main(string[] args)
        {
            //to find minimum of myFunc
            double precise = 0.001;

            double xL = 0;
            double xR = 10;
            double dx = xR - xL;

            double fR = myFunc(xR);
            double fL = myFunc(xL);

            bool isRhsSmall = fR < fL ? true : false;//三元運算子(Ternary operators)

            double xm, fm;

            while (dx > precise)
            {
                xm = (xL + xR) * 0.5;
                fm = myFunc(xm);

                if (isRhsSmall)
                {
                    fL = fm;
                    xL = xm;
                }
                else
                {
                    fR = fm;
                    xR = xm;
                }

                isRhsSmall = fR < fL ? true : false;
                dx = xR - xL;
            }
            xm = (xL + xR) * 0.5;
            fm = myFunc(xm);
            Console.WriteLine(string.Format("Find min value {0} at x = {1}", fm, xm));
            Console.Read();
        }

        static double myFunc(double x)
        {
            double f = Math.Pow(x, 2.0) - 2.8 * x + 5;
            return f;
        }
    }
}
