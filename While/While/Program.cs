using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double mySalary = 1020.30, total = 0.0;

            while (i < 15)
            {
                total += mySalary;
                i++;
            }
            Console.WriteLine("My Salary is {0}", total);
            Console.ReadKey();
        }
    }
}
