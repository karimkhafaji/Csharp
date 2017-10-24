using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Value_Function_and_challenge_26
{
    class Program
    {
        static int MinValue(int[] myArray2)
        {
            int minVal = myArray2[0];
            for (int i = 1; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minVal)
                    minVal = myArray2[i];
            }
            return minVal;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 11, 10, 3, 6, 0, 8, 9, 3, 50, 2 };
            int minVal = MinValue(myArray);
            Console.WriteLine($"The minimum value in myArray is {minVal}");
            Console.ReadKey();


            ////Q26/ Define a function to find the avarage
            ////of a student that has 7 grades and print the
            ////result in the void main

            //static int derage(int[] array1)
            //{
            //    int number = 0;
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        number = array1[i] + number;
            //    }

            //    return number / 7;
            //}


            //static void Main(string[] args)
            //{
            //    int[] arr = { 10, 20, 30, 40, 50, 60, 70 };

            //    int hesab = derage(arr);
            //    Console.WriteLine(hesab);
            //    Console.ReadKey();

        }
    }
}
