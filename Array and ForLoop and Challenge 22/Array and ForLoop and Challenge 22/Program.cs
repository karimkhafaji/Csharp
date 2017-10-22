using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_ForLoop_and_Challenge_22
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 5;
            int[] myNumbers = { 1, 5, 8, 9, 7 };
            int[] myNumbers2 = new int[myArraySize];
            int[] myNumbers3 = new int[myArraySize] { 1, 5, 8, 9, 7 };

            for (int i = 0; i < 5; i++)
                Console.WriteLine("My numbers " + (i + 1) + "= " + $"{myNumbers[i]}");
            Console.ReadKey();

            //Q22/ Define an array of int type and find the max value
            //int Max;
            //int[] myNumber = {10, 20, 30, 90, 50, 60 };

            //for (int i = 0; i < 6; i++)
            //    Console.WriteLine("My Number" + (i+1) + " = " + $"{ myNumber[i]}");

            //Max = myNumber.Max();
            //Console.WriteLine($"\n\tMax Number is {Max}");
            //Console.ReadKey();


        }
    }
}
