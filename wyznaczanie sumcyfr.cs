using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {  //program wyznacza sumer cyfr liczby naturalnej z przedziału [0,10 do 20] podanej przez uzytkownika
        static int zad1(int liczba)
        {
            if (liczba > 0)
            {
                return (liczba % 10) + zad1(liczba / 10);
            }
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zad1(x));
        }
    }
}
