using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class RefactorToGenericMethod<T> where T : IComparable
    {
        public static void MinimumValueByGenerics(T n1, T n2, T n3)
        {
            if (n1.CompareTo(n2) <= 0 && n1.CompareTo(n3) <= 0)
                Console.WriteLine("{0} is minimum", n1);
            else if (n2.CompareTo(n1) <= 0 && n2.CompareTo(n3) <= 0)
                Console.WriteLine("{0} is minimum", n2);
            else
                Console.WriteLine("{0} is minimum", n3);
        }
        
    }
}
