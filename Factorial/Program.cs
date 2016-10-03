using System;
/// <summary>
/// Нахождение факториала (3 способа: рекурсивный и 2 нерекурсивных).
/// </summary>
namespace Factorial
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial n! = {0}", fact(n));
            Console.ReadKey();
        }

        public static int fact(int n)
        {
            return (n == 0) ? 1 : n * fact(n - 1);
        }

        //public static int fact(int n)
        //{
        //    int c = 1;
        //    for (int i = 1; i <= n; c *= i++){}
        //    return c;
        //}

        //public static int fact(int n)
        //{
        //    int c = 1;
        //    for (; n > 0; c *= n--){}
        //    return c;
        //}
    }
}
