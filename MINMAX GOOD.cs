using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MIN, MAX;
            Console.WriteLine("Podaj trzy liczby całkowite");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            if (A > B)
                MIN = B;
            else
                MIN = A;
            if (MIN > C)
                MIN = C;
            if (B > A)
                MAX = B;
            else
                MAX = B;
            if (MAX < C)
                MAX = C;
            Console.WriteLine("Maksymana wartość to {0}", MAX);
            Console.WriteLine("Minimalna Wartość to {0}", MIN);
            Console.ReadKey();
        }
    }
}
