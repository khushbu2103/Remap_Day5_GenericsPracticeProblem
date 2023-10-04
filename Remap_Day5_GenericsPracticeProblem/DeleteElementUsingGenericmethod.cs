using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class DeleteElementUsingGenericmethod
    {
        public static T[] DeleteMethod<T>(T[] arr, T num)
        {
            
            int len = arr.Length;
            T[] newArr = new T[len - 1];
            int ind = 0;
            bool existNum = false;
            for (int i = 0; i < len; i++)
            {
                if (arr[i].Equals(num) == true)
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
                if (arr[i].Equals(num) == false)
                {
                    newArr[ind] = arr[i];
                    ind++;
                }
            }
            return newArr;
        }
    }
}
