using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Foreach_and_Challenge_23
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 5;
            int[] myNumber = new int[myArraySize] { 1, 5, 8, 9, 7 };
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("My Number" + " " +(i+1) + "=" +$"{myNumber[i]}");

            //}
            int i = 0;
            
            foreach (int item in myNumber)
            {
                i++;
                Console.WriteLine("My Number is " + (i) + "=" + $"{item}");

            }
            Console.ReadKey();

            //Q23/ Define an array of 15 elements and use foreach to iterate 14 elements only


            //const int myArraysSize = 15;
            //int[] myArray = new int[myArraysSize] { 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90 };
            //int i = 0;

            //foreach (int item in myArray)
            //{
            //    i++;
            //    if (i > 14)
            //    {
            //        break;

            //    }
            //    Console.WriteLine("My Number is " + $"{i}" + "=" + $"{item}");

            //}
            //    Console.ReadKey();
        }
     }
 }
