using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter_and_Challenge_28
{
    class Program
    {
        static int MinValue(int[] myArray2, out int myIndex)
        {

            int minVal = myArray2[0];
            myIndex = 0;

            for (int i = 1; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minVal)
                {
                    minVal = myArray2[i];
                    myIndex = i;
                }
            }
            return minVal;
        }

        //static string print_name(string[] number, out int indix)
        //{
        //    string minval = "Khafaji";
        //    indix = 0;
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (minval == number[i])
        //        {
        //            minval = number[i];
        //            indix = i;
        //        }
        //    }
        //    return minval;
        //}

        static void Main(string[] args)
        {
            int myIndex;
            int[] myArray = { 25, 2, 4, 6, 8, 10, 20, 14, 18, 0, 22 };
            int minVal = MinValue(myArray, out myIndex);
            Console.WriteLine($"The minimum value in myArray is {minVal}\nand the Index value is {myIndex}");

            Console.ReadKey();

            //Q28/ Write a program to use the Out Parameter!!!

            //string[] name = { "Karim", "Ahmad", "Khafaji" };
            //int myidix;
            //string myVar = print_name(name, out myidix);
            //Console.WriteLine($"My Name is : {myVar}\n My Out Index is : {myidix}");
            //Console.ReadKey();

        }
    }
}
