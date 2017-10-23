using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Of_String_and_Array_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullName = { "KaRiM", "Ahmad", "Khafaji" };

            int myArrayLength = myFullName.Length;

            for (int i = 0; i < myArrayLength; i++)
            {
                Console.Write($"{myFullName[i]}" + " ");
            }
            Console.WriteLine("\n\nMy Array Length is "+ $"{myArrayLength}");
            Console.ReadKey();
        }
    }
}
