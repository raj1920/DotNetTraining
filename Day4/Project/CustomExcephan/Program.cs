using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExcephan
{

    internal class Program
    {
        public void Check(int age)
        {
            if (age <= 18)
            {
                throw new Class1("You are not eligible....");
            }
            else
            {
                Console.WriteLine("You are eligible...");
            }
        }
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Age  ");
            age= Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            try
            {
                program.Check(age);
            }
            catch (Class1 e)
            {

                Console.WriteLine(e.Message);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
