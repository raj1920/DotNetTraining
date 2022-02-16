using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Filexcpy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream src = null;
            StreamReader sr = null;
            try
            {
                FileStream tar = new FileStream(@"E:\Project\Day4\Project\Filexcpy\rt1.txt", FileMode.Create, FileAccess.Write);
                src = new FileStream(@"E:\Project\Day4\Project\Filexcpy\rt.txt",FileMode.Open,FileAccess.Read);
                sr = new StreamReader(src); 
                StreamWriter sr2 = new StreamWriter(tar);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = string.Empty;
                while((str = sr.ReadLine()) != null)
                {
                   sr2.WriteLine(str);
                }  
                sr.Close();
                sr2.WriteLine();
                sr2.Close();
                Console.WriteLine("File Copied Succesfully...");
            } catch (NullReferenceException ex)
            {
                Console.WriteLine("Object Not Initialized...");
            } 
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("*** File Not Found ***");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
