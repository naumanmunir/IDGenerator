using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    class Math
    {
        public delegate int Pointtomethod(int x, int y);
        public delegate int Lessthanfive(int number);

        public static int add(int x, int y)
        {
            int results = x + y;

            return results;
        }

    }
}
