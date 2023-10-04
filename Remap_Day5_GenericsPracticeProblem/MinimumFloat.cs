using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class MinimumFloat
    {
        public static void FindMinimumFloat(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) <= 0 && num1.CompareTo(num3) <= 0)
                Console.WriteLine("{0} is minimum", num1);
            else if (num2.CompareTo(num1) <= 0 && num2.CompareTo(num3) <= 0)
                Console.WriteLine("{0} is minimum", num2);
            else
                Console.WriteLine("{0} is minimum", num3);
        }
    }
}
