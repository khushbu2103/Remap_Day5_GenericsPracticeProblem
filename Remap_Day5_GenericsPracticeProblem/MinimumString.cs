using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class MinimumString
    {
        public static void FindMinimumString(string x, string y, string z)
        {
            if (x.CompareTo(y) <= 0 && x.CompareTo(z) <= 0)
                Console.WriteLine("{0} is minimum", x);
            else if (y.CompareTo(x) <= 0 && y.CompareTo(z) <= 0)
                Console.WriteLine("{0} is minimum");
            else
                Console.WriteLine("{0} is minimun");
        }
    }
}
