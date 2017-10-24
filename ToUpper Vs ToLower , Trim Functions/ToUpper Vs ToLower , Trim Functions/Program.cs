using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper_Vs_ToLower___Trim_Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString, myString2;

            //myString2 = myString.ToUpper();
            //Console.WriteLine($"{myString2}");
            //myString2 = myString.Tolower();
            //Console.WriteLine($"{myString2}");

            char[] mytrimChar = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("Please Enter Your String");
            myString = Console.ReadLine();
            myString = myString.ToLower();
            myString2 = myString.Trim(mytrimChar);
            Console.WriteLine($"{myString2}");

            Console.ReadKey();
        }
    }
}
