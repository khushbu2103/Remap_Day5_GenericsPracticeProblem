using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class MinimumInteger
    {
        public static void FindMinimumInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) <= 0 && first.CompareTo(third) <= 0)
                Console.WriteLine("{0} is minimum", first);
            else if (second.CompareTo(first) <= 0 && second.CompareTo(third) <= 0)
                Console.WriteLine("{0} is minimum", second);
            else
                Console.WriteLine("{0} is minimum", third);

        }
    }
}
