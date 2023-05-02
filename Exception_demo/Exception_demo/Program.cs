using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int k = 10;
            Console.WriteLine("enter number to be divided with");
            int[] a=new int[5];

            try
            {
                int i = int.Parse(Console.ReadLine());
                int s = k / i;
                a[10] = 5;
                Console.WriteLine("enter i");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block");

            }
            Console.WriteLine("remaining program");
        }
    }
}
