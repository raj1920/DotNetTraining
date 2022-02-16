using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\Project\Day4\Project\customExcep2\Program.cs",
                               FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs); 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while((str=sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
               // str= sr.ReadLine(); 
            }
            sr.Close(); 
            fs.Close(); 


        }
    }
}
