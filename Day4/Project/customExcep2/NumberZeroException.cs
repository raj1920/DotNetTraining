using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customExcep2
{
    internal class NumberZeroException: Exception
    {
        public NumberZeroException(string error): base(error) { }
    }
}
