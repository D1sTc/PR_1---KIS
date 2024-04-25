using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    internal class KmLargerPlanet
    {
        public double res;
        public KmLargerPlanet(int x, int b)
        {
            res = Power(x, b);
        }
        int Power(int x, int b)
        {
            if (x < b) return b;
            else return x;
        }
    }
}
