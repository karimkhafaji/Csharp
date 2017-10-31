using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Palindrome_Function
{
    class Program
    {
        public static bool x(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {

            string[] myArray = { "civic", "deified", "deleveled", "Perls", "Is", "Not", "A", "Palindrome", "" };

            foreach (string word in myArray)
            {
                WriteLine("{0} = {1}", word, x(word));
            }
            ReadKey();
        }
    }
}
