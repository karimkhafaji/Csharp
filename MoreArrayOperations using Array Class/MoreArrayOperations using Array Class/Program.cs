using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MoreArrayOperations_using_Array_Class
{
    class Program
    {
        static void x()
        {
            WriteLine("Working with the Class System.Array");

            //Initialzie item at Startup
            int[] myNumbers = new[] { 11, 2, 31, 14, 5 };

            //1//Array Rank ...

            WriteLine("\nThe Rank of My Array ={0}\n", myNumbers.Rank);

            //2//Print out Numbers in declared order
            WriteLine("Here is The Array");

            for (int i = myNumbers.GetLowerBound(0); i <= myNumbers.GetUpperBound(0); i++)
            {
                //Print a Number
                Write(myNumbers[i] + "\n");
            }



            //3//sort them ...
            Array.Sort(myNumbers);
            WriteLine("\n\nThe Sorted Array = ");

            //...and Print them.
            for (int i = 0; i < myNumbers.Length; i++)
            {

                Write(myNumbers[i] + "\n");
            }
            WriteLine("\n");




            //4//Reverse them
            Array.Reverse(myNumbers);
            WriteLine("\n\nThe Reversed Array =");
            //...and Print them.
            for (int i = 0; i < myNumbers.Length; i++) 
            {
                Write(myNumbers[i] + "\n");

            }
            WriteLine("\n");


            //5//Clear out all but the final number.
            WriteLine("Cleared out all but ...");
            Array.Clear(myNumbers, 1, 3);
            for (int i = 0; i < myNumbers.Length; i++)
            {
                 WriteLine(myNumbers[i] + "\n");
                //oder//WriteLine("{0}\n", myNumbers[i]);
                //or//WriteLine($"{myNumbers[i]}" + "\n");
            }


            //6//to convert all to something else

            string[] array2 = Array.ConvertAll(myNumbers, element => element.ToString());

            //write string array.

            WriteLine(string.Join(";", array2));

        }
        static void Main(string[] args)
        {
            x();
            ReadKey();
        }
    }
}
