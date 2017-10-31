using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Optional_Parameters
{
    class Program
    {
        public static void PrintValues(string name = "Karim Khafaji", int myValue = 7)
        {
            WriteLine($"Name  = {name}  Number  = {myValue}");

        }

        static void Main(string[] args)
        {

            string name = "Ahmed";
            int value = 15;
            PrintValues();
            PrintValues(name);
            PrintValues(name, value);
            PrintValues(name: "Abdulkarim", myValue: 6);
            ReadKey();



        }
    }
}
