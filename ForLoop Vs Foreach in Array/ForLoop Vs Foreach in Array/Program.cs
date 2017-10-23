using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_Vs_Foreach_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] myFullName = { "Karim", "Ahmad", "Khafaji" };
            int myArraylength = myFullName.Length;

            for (int i = 0; i < myArraylength; i++)
            {
                myFullName[2] = "Ahmad";
                Console.Write($"{myFullName[i]}" + " ");

            }
            Console.WriteLine("\nMy Array Length is " + $"{myArraylength}");

            //foreach (string myname in myFullName)
            //{
            //    myname = "Ahmed";
            //    Console.Write($"{myname}" + " ");

            //}
            Console.ReadKey();
        }
    }
}
