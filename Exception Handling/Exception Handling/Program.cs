using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] myArray = { "Karim", "Majid", "Yahya", "Monier" };

                for (int i = 0; i < 4; i++)
                    WriteLine(myArray[i]);

                WriteLine("Enter Your Number");
                decimal myDeci = Convert.ToDecimal(ReadLine());

                int x = 10, y = 0;
                int z = x / y;
            }
            //catch (Exception ex)
            //{
            //    WriteLine("\n" + ex.Message);
            //}
            catch (IndexOutOfRangeException ex1)
            {
                WriteLine(ex1.ToString());
            }
            catch (FormatException fx1)
            {
                WriteLine(fx1.Message);
            }
            catch (DivideByZeroException cx)
            {
                WriteLine(cx.Message);
            }
            catch (Exception exall)
            {
                WriteLine(exall.ToString());
            }
            finally
            {
                WriteLine("Hello");
            }


            ReadKey();
        }
    }
}
