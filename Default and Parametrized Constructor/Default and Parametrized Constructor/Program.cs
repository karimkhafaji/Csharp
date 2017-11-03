using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Default_and_Parametrized_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName = "Monier Sammo", myName2 = "Majid Dabl";
            int age2 = 26;

            Person myObj = new Person();
            myObj.PrintValues();

            WriteLine();
            Person myObj2 = new Person(myName, age2);
            myObj2.PrintValues();

            WriteLine();
            Person myObj3 = new Person(myName2);
            myObj3.PrintValues();

            ReadKey();
        }
    }
}
