using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class RefactorUsingGenericClass<T> where T : IComparable
    {
        private T x, y, z;

        public RefactorUsingGenericClass(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public T TestMinimum()
        {
            return RefactorUsingGenericClass<T>.TestMinimum(x, y, z);
        }
        public static T TestMinimum(T x, T y, T z)
        {
            T min = x;
            if (y.CompareTo(min) < 0)
            {
                min = y;
            }
            if (z.CompareTo(min) < 0)
            {
                min = z;
            }
            return min;
        }
    }
}
