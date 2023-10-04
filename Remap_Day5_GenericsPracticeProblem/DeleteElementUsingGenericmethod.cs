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
            //int index = Array.IndexOf(array, elementToDelete);
            //if (index != -1)
            //{
            //    T[] newArray = new T[array.Length - 1];
            //    Array.Copy(array, 0, newArray, 0, index);
            //    Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            //    Array.Resize(ref array, newArray.Length);
            //    Array.Copy(newArray, array, newArray.Length);
            //}
            //else
            //{
            //    Console.WriteLine("Element not found in the array.");
            //}
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
