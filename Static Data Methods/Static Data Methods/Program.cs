using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Data_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Static_Data_and_Methods s1 = new Static_Data_and_Methods(50);
            Static_Data_and_Methods s2 = new Static_Data_and_Methods(100);

            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", Static_Data_and_Methods.GetValue());
            Static_Data_and_Methods.SetInterestRate(0.7);

            //Even If we make new object, this does NOT ’reset’ the interest rate.
            Static_Data_and_Methods s3 = new Static_Data_and_Methods(2000);
            Console.WriteLine("Interest Rate is: {0}", Static_Data_and_Methods.GetValue());
            Console.ReadLine();

        }
    }
}
