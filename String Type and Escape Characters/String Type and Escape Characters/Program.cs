using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Type_and_Escape_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            //\' \" \\ \0 \a \b \n \r \t \v \f

            string myString = "Karim said\n \"This is a good start\"\a and I think...";

            Console.WriteLine("{0}", myString);
            Console.ReadKey();

        }
    }
}
