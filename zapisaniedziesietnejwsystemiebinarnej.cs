using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    { //Program  zapisze podana liczbe dziesietna w systemie binarnym 
        static void zad3(int liczba)
        {
            if (liczba > 0)
            {
                zad3(liczba / 2);
                Console.Write(liczba % 2);
            }
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Podaj liczbę:");
            int n = Convert.ToInt32(Console.ReadLine());
            zad3(n);
            Console.WriteLine();
        }
    }
}
