using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing_Parent_Code
{
    //the abstract base class

    abstract class Employees
    {
        public Employees(string name = "Karim Khafaji")
        { EmpName = name; }

        public string EmpName { get; set; }

        public abstract void PrintName();
    }


    #region HumRe class
    class HumRe : Employees
    {
        public HumRe() { }
        public HumRe(string name) : base(name) { }
        public override void PrintName()
        {
            Console.WriteLine("Print name {0} from the Hum Resources class", EmpName);
        }
    }
    #endregion

    #region HumRe
    class Finance : HumRe
    {
        public new string EmpName { get; set; }

        public new void PrintName()
        {
            Console.WriteLine("\nPrint a Finance Employee Name\n ");
        }
    }
    #endregion
}
