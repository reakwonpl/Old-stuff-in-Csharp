using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string s = Console.ReadLine();
            int a = 0;
            foreach (int liczba in s)
            {
                if (liczba >= '0' && liczba <= '9')
                {
                    a += (liczba - 48) ;
                }
            }
            Console.WriteLine("Wynik {0} ", a);
        }
    }
}
