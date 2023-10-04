using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class DeleteArray
    {
        public static int[] DeleteMethod(int[] arr, int num)
        {
            int len = arr.Length;
            int[] newArr = new int[len-1];
            int ind = 0;
            bool existNum = false;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == num)
                {
                    existNum = true;
                }
            }
            if (!existNum)
            {
                Console.WriteLine("No such number exist in the given array");
                return arr;
            }
            for (int i = 0; i < len; i++)
            {
                if (arr[i] != num)
                {
                    newArr[ind] = arr[i];
                    ind++;
                }
            }
            return newArr;
        }
        public static double[] DeleteMethod(double[] arr, double num2)
        {
            int len = arr.Length;
            double[] newArr = new double[len - 1];
            int ind = 0;
            bool existNum = false;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == num2)
                {
                    existNum = true;
                }
            }
            if (!existNum)
            {
                Console.WriteLine("No such decimal number exist in the given array");
                return arr;
            }
            for (int i = 0; i < len; i++)
            {
                if (arr[i] != num2)
                {
                    newArr[ind] = arr[i];
                    ind++;
                }
            }
            return newArr;
        }

        public static char[] DeleteMethod(char[] arr, char num2)
        {
            int len = arr.Length;
            char[] newArr = new char[len - 1];
            int ind = 0;
            bool existNum = false;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == num2)
                {
                    existNum = true;
                }
            }
            if (!existNum)
            {
                Console.WriteLine("No such character exist in the given array");
                return arr;
            }
            for (int i = 0; i < len; i++)
            {
                if (arr[i] != num2)
                {
                    newArr[ind] = arr[i];
                    ind++;
                }
            }
            return newArr;
        }
    }
}
