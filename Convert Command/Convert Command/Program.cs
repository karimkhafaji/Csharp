using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Command
{
    class Program
    {
        static void Main(string[] args)
        {

            double myDoublevar = 2500.45D;
            string myStringvar, mySubStringvar;

            myStringvar = Convert.ToString(myDoublevar);
            mySubStringvar = myStringvar.Substring(0, 2);

            Console.WriteLine($"my variable is {myDoublevar} \n");
            Console.WriteLine("my string variable is {0}\n", myStringvar);
            Console.WriteLine("my string variable is {0} \n", mySubStringvar);
            Console.ReadKey();
        }
    }
}
