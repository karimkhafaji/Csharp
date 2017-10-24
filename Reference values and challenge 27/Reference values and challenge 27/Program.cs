using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_values_and_challenge_27
{
    class Program
    {

        static void MultiplyNum(ref int myVar)
        {
            myVar *= 3;
            Console.WriteLine($"myNumber1 = {myVar}");
        }


        //static void MultipliNum(ref int myVar1, ref int  myVar2)
        //{
        //    myVar1 *= 5; myVar2 *= 5;
        //    Console.WriteLine($"My Variable1 * 5 = {myVar1}");
        //    Console.WriteLine($"My Variable2 * 5 = {myVar2}"+"\n");
        //}


        static void Main(string[] args)
        {

            int myNumber = 5;
            Console.WriteLine($"myNumber2 = {myNumber}");
            MultiplyNum(ref myNumber);
            Console.WriteLine($"myNumber = {myNumber}");
            Console.ReadKey();

            //int myNumber1 = 6, myNumber2 = 4;
            //Console.WriteLine($"My Number1 = {myNumber1}\nMy Number2 = {myNumber2}\n");
            //MultipliNum(ref myNumber1, ref myNumber2);
            //Console.WriteLine($"My ref Number1 = {myNumber1}\nMy ref Number2 = {myNumber2}\n");

            //Console.ReadKey();
            //Q27 define a function that accept two paramerters 
            //as refernce values and change them using multiplication
            //by 4 and print the result before and after multiplication

        }
    }
}
