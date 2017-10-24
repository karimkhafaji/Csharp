using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Function_with_String_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            char[] separator = { ' ', 'u' };
            myString = Console.ReadLine();
            string[] myNewWords;
            myNewWords = myString.Split(separator);
            foreach (string word in myNewWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
