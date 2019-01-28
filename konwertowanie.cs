using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Podaj liczbe");
            string napis = System.Console.ReadLine();
            int x = System.Convert.ToInt32(napis);
            int wynik = x * 2;
            Console.WriteLine("Liczba " + x + " pomnozona przez 2" + " równa się " + wynik);
        }
    }
}
