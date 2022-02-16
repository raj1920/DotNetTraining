using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[] { 1, 2, 3, 4 };  
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            try
            {
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Size is Small....");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); 
            }
            

        }
    }
}
