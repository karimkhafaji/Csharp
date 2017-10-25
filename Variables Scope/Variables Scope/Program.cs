using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope
{
    class Program
    {
        static string myString2;
        static void printMyString()
        {
            string myString = "My String inside the printMyString Method ";
            Console.WriteLine($"{myString}");
            Console.WriteLine($"\t{ myString2}");

        }

        static void Main(string[] args)
        {
            string myString = "My String inside the Main Method";
            myString2 = "Global myString variable";
            printMyString();

            Console.WriteLine($"\n{myString}");
            Console.WriteLine($"\t{ myString2}");
            Console.ReadKey();


        }
    }
}
