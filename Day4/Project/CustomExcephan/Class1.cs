using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExcephan
{
    internal class Class1 : ApplicationException 
    {
        public Class1(string error): base(error)
        {
          //  Console.WriteLine("Age exception...");
        }
    }
}
