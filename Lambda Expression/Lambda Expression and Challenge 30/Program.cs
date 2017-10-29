using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lambda_Expression_and_Challenge_30
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int mynumber = 5;
        //////static int addFunct(int number)
        //////{
        //////    myXnumber += number;
        //////    return myXnumber;
        //////}
        static void Main(string[] args)
        {

            //MyNewNumber n = x => x + mynumber;
            //MyNewNumber n1 = x => x * mynumber;
            //WriteLine($"MyXNumber = {n(3)}\n");
            //WriteLine($"MyXNumber = {n1(4)}\n");

            Func<int, bool> func2 = (x => x % 2 != 0);
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < myArray.Length; i++)
                WriteLine(func2.Invoke(myArray[i]));

            ReadKey();

            ////Q30 : write a Lambda expression example to fine the numbers the bigger than 10 in an array of numbers

            ////Func<int, bool> func2 = (x => x > 10);
            ////int[] myArray = { 6, 8, 9, 10, 15, 20, 22, 29, 30, 35 };
            ////for (int i = 0; i < myArray.Length; i++)
            ////    WriteLine(func2.Invoke(myArray[i]));
            ////     ReadKey();
        }
    }
}
