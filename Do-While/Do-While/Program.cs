using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {

            double mySalary = 2000, total = 0.0;

            int i = 0;

            do
            {
                total += mySalary; //total = total + mySalary
                i++;
                Console.WriteLine("i value equal {0}", i);

            }
            while (i < 10);
            Console.WriteLine("Salary value equal {0}", total);
            Console.ReadKey();
        }
    }
}
