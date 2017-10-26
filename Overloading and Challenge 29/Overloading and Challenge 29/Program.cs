using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_and_Challenge_29
{
    class Program
    {
        public static int printNumber(int myNumber)
        {

            return myNumber;
        }
        public static double printNumber(double myNumber)
        {
            return myNumber;
        }



        //public static int MinValue(int[] myArray)
        //{
        //    int minval = myArray[0];
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (myArray[i] < minval)
        //            minval = myArray[i];

        //    }
        //    return minval;
        //}
        //public static double MinValue(double minval)
        //{
        //    return minval;
        //}

        static void Main(string[] args)
        {
            int myNumber = 9;
            Console.Write($"{printNumber(myNumber)}");
            Console.ReadKey();

            //int[] myArray1 = { 16, 20, 22, 5, 8, 9, 12, 30, 33, 45};
            //double minNumb = MinValue(myArray1);
            //Console.WriteLine($"The Minimum Number is {MinValue(minNumb)}");
            //Console.ReadKey();

            //Q29
            //Define two functions using overloading concepts to return the minimum value of an 
            //array with 10 numbers once as integer and once as double value and print the result
        }
    }
}
