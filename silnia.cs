using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    { //robienie silni przez rekurencje czyli odwolanie do czegos 
        static int Silnia(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Silnia(x));
        }
    }
}
