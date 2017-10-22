using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_19
{
    class Program
    {
        static void Main(string[] args)
        {

            //* //Q19/ Define 4 variables 
            //*1 - First Name
            //* 2 - Last Name
            // * 3 - Salary
            // * 4 - TaxRate = 0.07
            // * 5 - Enter all these values from the console window and then
            //  * Find the salary for 12 month and cut the TaxRate for 12 months and print the salary
            //  * in this form
            //  * Welcome fName, LName
            //  * Your Salary for 12 months is #$
            // *You paid TaxRate for 12 months  #$
            // * Good Bye

            string var1, var2; decimal var3, var4, var5;
            Console.WriteLine("Enter first name\n");
            var1 = Console.ReadLine();
            Console.WriteLine("\nEnter last name\n");
            var2 = Console.ReadLine();
            Console.WriteLine("\nEnter your salary");
            var3 = Convert.ToDecimal(Console.ReadLine());
            var4 = var3 * 12;
            var5 = var4 * 0.07m /100;
            Console.WriteLine($"\n{var1} {var2}\n\nYour salary={var3}$ Salary for 12 Months ={var4}$ Taxrate For 12 Months ={var5}$\n\nGOOD BYE");
            Console.ReadKey();
        }
    }
}
