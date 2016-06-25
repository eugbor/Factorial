using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Console.Write("Enter n: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial n! = {0}", fact(c));
            Console.ReadKey();
        }

        public static int fact(int n)
        {
            return (n == 0) ? 1 : n * fact(n - 1);
        }

        //public static int fact(int a)
        //{
        //    int c = 1;
        //    for (int i = 1; i <= a; i++)
        //    {
        //        c = c * i;
        //    }
        //    return c;
        //}
    }
}
