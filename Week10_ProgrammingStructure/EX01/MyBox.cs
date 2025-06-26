using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCU.MyBox
{
    public class MyBox
    {
        public int L=10;
        public int W;
        public int H;
        public int GetVolumn()
        {
 
            return L * W * H;
        }

        static int GetArea(MyBox b)
        {
            return (b.L * b.W + b.W * b.H + b.H * b.L) * 2;

        }
    }
}
