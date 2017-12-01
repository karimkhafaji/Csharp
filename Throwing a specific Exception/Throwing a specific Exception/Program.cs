using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Throwing_a_specific_Exception
{
    class Program
    {
        public static void PrintSalary()
        {
            decimal Var1, Var2, totalTax;
            try
            {
                WriteLine("Enter The Total Salary Before Cut Tax");
                Var1 = Convert.ToDecimal(ReadLine());

                WriteLine("Enter The Tax Percent");
                Var2 = Convert.ToDecimal(ReadLine());
                Var2 /= 100;

                totalTax = Var1 * Var2;
                WriteLine($"The Total Tax  Value is {totalTax}");
            }
            catch (FormatException ex1)
            {
                throw new Exception("Salary Format or Tax is not match, Try Again Later", ex1.InnerException);
            }
            
        }
        static void Main(string[] args)
        {
            try
            {
                PrintSalary();
            }
            catch (Exception myEx)
            {
                WriteLine(myEx.Message);
            }

            ReadKey();
        }
    }
}
