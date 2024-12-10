using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Task
{
    public class TypeA
    {
        private int F;
        internal int G;
        public int H;

        public TypeA(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }

        public int GetF()
        {
            return F;
        }
    }
}
