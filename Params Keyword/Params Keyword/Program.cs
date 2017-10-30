using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Params_Keyword
{
    class Program

        
    {
        static double CalculateAverage(params double[] values)
        {
            WriteLine("You Sent me {0}", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        //static int mymixnumber(params int[] mymix)
        //{
        //    Write(" \n you sent me [{0}] value =»", mymix.Length);
        //    int MIX = 0;
        //    if (mymix.Length == 0)
        //        return MIX;
        //    for (int i = 0; i < mymix.Length; i++)
        //        MIX = mymix.Max();
        //    return MIX;
        //}

        static void Main(string[] args)
        {
            double average;

            // ... We can pass arguments

            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            WriteLine("The Average of Data is : {0}\n", average);
            //WriteLine(); or this way to add an empty row

            // ... We can pass an array of doubles

            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            WriteLine("The Average of Data is : {0}\n", average);
            //WriteLine(); or this way to add an empty row

            // ... Average of 0 is 0!

            WriteLine("The Average of Data is : {0}", CalculateAverage());
            ReadKey();

            //Q31/ write a function that accept different number of
            //values and find the greatest number among these and the same with an array
            //and once again but dont send any arguments and return the value 0


            //int max;

            //max = mymixnumber(5, 3, 2, 7, 9, 11, 15);
            //WriteLine(" the max value is = {0}\n", max);

            //int[] max2 = { 5, 2, 7, 9 };
            //max = mymixnumber(max2);
            //WriteLine(" the mix nomber is = {0}\n ", max);

            //WriteLine(" the mix nomber is = {0} ", mymixnumber());
            //ReadKey();

        }
    }
}
