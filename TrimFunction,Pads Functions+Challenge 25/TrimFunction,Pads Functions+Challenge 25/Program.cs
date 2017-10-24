using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimFunction_Pads_Functions_Challenge_25
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString, myString2;

            char[] mytrimChar = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("Please Enter Your String");
            myString = Console.ReadLine();
            myString = myString.ToLower();
            myString2 = myString.TrimStart(mytrimChar);
            Console.WriteLine($"{myString2}");
            myString2 = myString.TrimEnd(mytrimChar);
            Console.WriteLine($"{myString2}");

            myString2 = myString.PadLeft(25, ' ');
            Console.WriteLine($"{myString2}");
            myString2 = myString.PadRight(25, 'k');
            Console.WriteLine($"{myString2}");

            Console.ReadKey();

            //Q24
            //Change this string from this style "Hello My Dear" to be 
            //in this style "Hello My Dearest" using pads functions only

            //string x , x2, x3, x4;

            //Console.WriteLine("Please Enter Your string");
            //x = Console.ReadLine();
            //x2 = x.PadRight(14, 'e');
            //x3 = x2.PadRight(15, 's');
            //x4 = x3.PadRight(16, 't');
            //Console.WriteLine($"{x4}");
            //Console.ReadKey();




        }
    }
}
