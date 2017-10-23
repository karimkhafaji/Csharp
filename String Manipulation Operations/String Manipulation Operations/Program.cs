using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Karim Khafaji";
            char[] myCharArray = myString.ToCharArray();

            Console.WriteLine($"The String Length is {myString.Length}\n");

            foreach (char mychar in myCharArray)
            {

                Console.WriteLine($"{mychar}");
            }
            Console.ReadKey();

            //Define a string variable than assign "I am Smart" change the substring "i am "
            // with "He is" ==> "He is Smart"

            //string myString = "I am Smart";
            //myString = myString.Substring(4);
            //myString = "He is" + myString;
            //char[] myChararray = myString.ToCharArray();

            //foreach (char temp in myString)
            //{
            //    Console.WriteLine($"{temp}");

            //}
            //Console.ReadKey();
        }
    }
}
