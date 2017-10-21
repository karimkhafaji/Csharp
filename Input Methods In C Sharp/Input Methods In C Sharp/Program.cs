using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methods_In_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            int myVar1, myVar2;
            Console.WriteLine("Please Enter Your Name \n");
            myName = Console.ReadLine();
            Console.WriteLine("\nPlease Enter Your First Number\n");
            myVar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Your Entry");
            myVar2 = Console.Read();
            
            Console.WriteLine($"\nHello {myName}");
            Console.WriteLine($"\nYou Entered The Number {myVar1}");
            Console.WriteLine($"\nYour Entry is {myVar2}");
            Console.ReadKey();

        }
    }
}
