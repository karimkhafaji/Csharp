using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Data_Methods
{
    class Static_Data_and_Methods
    {
        // Static Data at Instance-level.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate;

        //Parameterized Constructor
        public Static_Data_and_Methods(double balance)
        {
            currBalance = balance;

        }

        static Static_Data_and_Methods()
        {
            currInterestRate = 0.5;
        }
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetValue()
        { return currInterestRate; }


    }
}
