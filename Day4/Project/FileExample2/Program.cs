using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\Project\Day4\Project\FileExample2\rt.txt",
                             FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Dotnet Files concept going on...");
            sw.AutoFlush = true;
            Console.WriteLine("File create successfully....");

        }
    }
}
