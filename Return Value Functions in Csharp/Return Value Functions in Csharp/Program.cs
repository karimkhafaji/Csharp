using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Value_Functions_in_Csharp
{
    class Program
    {
        //static void addNumbers(int myFirstNumber, int mySecondNumber)
        //{
        //    int temp = myFirstNumber + mySecondNumber;
        //    Console.WriteLine($"{temp}");

        //}

        static int addNumbers2(int myFirstNumber, int mySecondNumber)
            {
            int temp = myFirstNumber + mySecondNumber;
            return temp;

            }

        static void Main(string[] args)
        {
            int myVar1 = 5, myVar2 = 3, temp;

            temp = addNumbers2(myVar1,myVar2);

            //addNumbers(myVar1, myVar2);

            Console.WriteLine($"{temp}");
            Console.ReadKey();
        }
    }
}
