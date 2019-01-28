using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
   
    class Fib
    {

        /// <summary>
        /// Oblicza n-ty wyraz ciagu Fibonacciego
        /// </summary>
        /// <param name="n">n (pierwszy wyraz ma index 1)</param>
        /// <returns>n-ty wyraz ciagu Fibonacciego</returns>
        public static int fib(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }

        
        static void Main(string[] args)
        {
            String line;
            int n;

            Console.WriteLine("Podaj, ktory wyraz ciagu Fibonacciego obliczyc");
            line = Console.ReadLine();
            n = int.Parse(line);

            Console.WriteLine(n + "-ty wyraz ciagu Fibonacciego: " + fib(n));
        }
    }
}