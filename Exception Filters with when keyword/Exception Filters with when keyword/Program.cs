using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exception_Filters_with_when_keyword
{
    class Program
    {
        public static void PrintSalary()
        {
            decimal Var1, tax, totalTax, salary;
            try
            {
                WriteLine("Enter The Total Salary Before Cut Tax");
                Var1 = Convert.ToDecimal(ReadLine());
                if (Var1 < 1000)
                    throw new Exception ("The Salary is less than 1000€");

                WriteLine("Enter The Tax Percent");
                tax = Convert.ToDecimal(ReadLine());
                if (tax == 0)
                    throw new Exception("Tax must not be a Zero");

                tax /= 100;
                totalTax = Var1 * tax;
                salary = Var1 - totalTax;
                WriteLine($"The Total Tax  Value is {totalTax}$ and The Net Salary is {salary}$");
            }
            catch (FormatException ex1)
            {
                throw new Exception("Salary Format or Tax format is not match, Try Again Later", ex1.InnerException);
            }

        }
        static void Main(string[] args)
        {
            try
            {
                PrintSalary();
            }
            catch (Exception myEx)when(myEx.Message.Equals("The Salary is less than 1000€"))
            {
                WriteLine("This Salary has no Taxes");
            }
            catch (Exception myEx) when (myEx.Message.Equals("Tax must not be a Zero"))
            {
                WriteLine("You entered a zero value for Tax");
            }
            catch (Exception myEx)
            {
                WriteLine(myEx.Message);
            }

             ReadKey();

        
        }
        
    }
}
