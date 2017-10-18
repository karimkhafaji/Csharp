using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            //string myanimal = "cat";

            //switch (myanimal)
            //{
            //    case "canary":
            //        Console.WriteLine("my animal is canary");
            //        break;
            //    case "camel":
            //        Console.WriteLine("my animal is camel");
            //        break;
            //    case "cat":
            //        Console.WriteLine("my animal is cat");
            //        break;
            //    default:
            //        Console.WriteLine("no one");
            //        break;

            //}
            //Console.ReadKey();


            int myvar = 15;

            switch (myvar)
            {
                case 10:
                   Console.WriteLine("my variable number is 10");
                    break;
                case 7:
                    Console.WriteLine("my variable number is 7");
                    break;
                case 4:
                    Console.WriteLine("my variable number is 4");
                   break;
               default:
                   Console.WriteLine("no one");
                   break;

            }
            Console.ReadKey();
        }
    }
}
