﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}) : ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}", arr[i][j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();

            ////Q24/ define a jagged array that contains these arraies inside of it
            //// a = { 1,5,8,9,6.4,9}
            //// b = { 0,4,3,}
            //// c = { 2,9,3,10} 
            //// and print the result for each arry in a seperate row

            //int[][] arr = new int[3][];

            //arr[0] = new int[7] { 1, 5, 8, 9, 6, 4, 9 };
            //arr[1] = new int[3] { 0, 4, 3 };
            //arr[2] = new int[4] { 2, 9, 3, 10 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //  //  Console.Write("Element({0}) = ", i+1);
            //   Console.Write($"Element({i+1}) : ");

            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        // Console.Write("{0}", arr[i][j] + " ");
            //        Console.Write($"{arr[i][j]}" + " ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.ReadKey();
        }
    }
}
