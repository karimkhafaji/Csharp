using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyTheyUseTypeDecimalForFinancial_and_banking
{
    class Program
    {
        static void Main(string[] args)
        {
            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;

            Console.WriteLine("\nfloat Value = {0}\ndouble Value = {1}\ndecimal Value = {2}", flVar, dlVar,dcVar);
            Console.ReadKey();
        }
    }
}
