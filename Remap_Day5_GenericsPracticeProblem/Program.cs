using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day5_GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any program");
            Console.WriteLine("1. Delete element from array of integer, double and char.\n" +
                "2. Delete element using genenric method\n" +
                "3. Delete element using generic class\n" +
                "4. Find minimum integer.\n" +
                "5. Find minimum float.\n" +
                "6. Find minimum string.\n" +
                "7. Find minimum by generic method.\n" +
                "8. Find minimum by generic class");
            int option = Convert.ToInt32(Console.ReadLine());
            int[] intArr = { 1, 2, 3 };
            double[] doubleArr = { 20.67, 56.32, 23.98 };
            char[] charArr = { 'a', 'b', 'c', 'd' };
            Console.WriteLine("enter the number you want to delete from array");
            int intInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the decimal value you want to delete from array");
            double doubleInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the char value you want to delete from array");
            char charInput = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case 1:
                    intArr = DeleteArray.DeleteMethod(intArr, intInput);
                    doubleArr = DeleteArray.DeleteMethod(doubleArr, doubleInput);
                    charArr = DeleteArray.DeleteMethod(charArr, charInput);
                    ArrayOfIntDoubleAndChar.ToPrint(intArr);
                    ArrayOfIntDoubleAndChar.ToPrint(doubleArr);
                    ArrayOfIntDoubleAndChar.ToPrint(charArr);
                    break;
                case 2:
                    intArr = DeleteElementUsingGenericmethod.DeleteMethod(intArr, intInput);
                    doubleArr = DeleteElementUsingGenericmethod.DeleteMethod(doubleArr, doubleInput);
                    charArr = DeleteElementUsingGenericmethod.DeleteMethod(charArr, charInput);
                    ArrayOfIntDoubleAndChar.ToPrint(intArr);
                    ArrayOfIntDoubleAndChar.ToPrint(doubleArr);
                    ArrayOfIntDoubleAndChar.ToPrint(charArr);
                    break;
                case 3:
                    intArr = DeleteElementUsingGenericClass<int>.DeleteMethod(intArr, intInput);
                    doubleArr = DeleteElementUsingGenericClass<double>.DeleteMethod(doubleArr, doubleInput);
                    charArr = DeleteElementUsingGenericClass<char>.DeleteMethod(charArr, charInput);
                    ArrayOfIntDoubleAndChar.ToPrint(intArr);
                    ArrayOfIntDoubleAndChar.ToPrint(doubleArr);
                    ArrayOfIntDoubleAndChar.ToPrint(charArr);
                    break;
                case 4:
                    Console.WriteLine("Enter 3 numbers");
                    int first = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());
                    int third = Convert.ToInt32(Console.ReadLine());
                    MinimumInteger.FindMinimumInteger(first, second, third);
                    break;
                case 5:
                    Console.WriteLine("Enter 3 numbers");
                    float n1 = float.Parse(Console.ReadLine());
                    float n2 = float.Parse(Console.ReadLine());
                    float n3 = float.Parse(Console.ReadLine());
                    MinimumFloat.FindMinimumFloat(n1, n2, n3);
                    break;
                case 6:
                    //string x = "abc", y = "hgf", z = "kgy";
                    MinimumString.FindMinimumString("abc", "bcd", "khu");
                    break;
                case 7:
                    RefactorToGenericMethod<int>.MinimumValueByGenerics(21, 31, 78);
                    RefactorToGenericMethod<double>.MinimumValueByGenerics(10.5, 4.7, 31.2);
                    RefactorToGenericMethod<string>.MinimumValueByGenerics("abd", "ghj", "acf");
                    break;
                case 8:
                    // Test cases with integers
                    int result1 = RefactorUsingGenericClass<int>.TestMinimum(15, 10, 5);
                    Console.WriteLine("Test case 1 with integers: Max number at first position: " + result1);

                    int result2 = RefactorUsingGenericClass<int>.TestMinimum(5, 15, 10);
                    Console.WriteLine("Test case 2 with integers: Max number at second position: " + result2);

                    int result3 = RefactorUsingGenericClass<int>.TestMinimum(10, 5, 15);
                    Console.WriteLine("Test case 3 with integers: Max number at third position: " + result3);

                    // Test cases with strings
                    string result4 = RefactorUsingGenericClass<string>.TestMinimum("banana", "apple", "cherry");
                    Console.WriteLine("Test case 1 with strings: Max string at first position: " + result4);

                    string result5 = RefactorUsingGenericClass<string>.TestMinimum("apple", "cherry", "banana");
                    Console.WriteLine("Test case 2 with strings: Max string at second position: " + result5);

                    string result6 = RefactorUsingGenericClass<string>.TestMinimum("cherry", "banana", "apple");
                    Console.WriteLine("Test case 3 with strings: Max string at third position: " + result6);

                    // Test cases using the generic class
                    RefactorUsingGenericClass<int> maxInt = new RefactorUsingGenericClass<int>(15, 10, 5);
                    int result7 = maxInt.TestMinimum();
                    Console.WriteLine("Test case using the generic class with integers: Max number at first position: " + result7);

                    RefactorUsingGenericClass<string> maxString = new RefactorUsingGenericClass<string>("banana", "apple", "cherry");
                    string result8 = maxString.TestMinimum();
                    Console.WriteLine("Test case using the generic class with strings: Max string at first position: " + result8);
                    break;
            }
            Console.ReadLine();

        }
    }
}
