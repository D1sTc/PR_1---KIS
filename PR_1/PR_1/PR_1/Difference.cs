using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    internal class Difference
    {
        double res;
        public Difference(int x, int b)
        {
            res = Power(x, b);
        }
        int Power(int x, int b)
        {
            if (x > b) return x - b;
            else return b - x;
        }
    }
}
