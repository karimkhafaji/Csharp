using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Variables
{
    class ReadOnlyFields
    {
        public static readonly double pi;

        static ReadOnlyFields()
        {
            pi = 3.14;
        }
    }
}
