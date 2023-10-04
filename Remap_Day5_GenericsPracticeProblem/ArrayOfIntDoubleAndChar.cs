using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class ArrayOfIntDoubleAndChar
    {
       
        public static void ToPrint(int[] intarray)
        {
            Console.WriteLine("\nInteger array Elements");
            foreach (int i in intarray)
            {
                Console.Write(i + " ");
            }
        }
        public static void ToPrint(double[] doublearray)
        {
            Console.WriteLine("\nDouble array Elements");
            foreach (double d in doublearray)
            {
                Console.Write(d + " ");
            }
        }
        public static void ToPrint(char[] chararray)
        {
            Console.WriteLine("\nChar array Elements");
            foreach (char  c in chararray)
            {
                Console.Write(c + " ");
            }
        }

    }
}
