using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Methods
{
    partial class EmployeesPart
    {
        public string name = "Karim Khafaji";
        public string address = "Bischo";
        public string department = "Financial Dept.";
        public int age = 24;

        partial void MyAge();

        public EmployeesPart() { }
    }
}
