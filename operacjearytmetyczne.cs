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
            string x ;
            string y;
            double wynikdodawania;
            double wynikodejmowania;
            double wynikdzielenia;
            double wynikmnozenia;
            double wynikprocentowy;

            Console.WriteLine("Podaj pierwszą liczbę");
            x = Console.ReadLine();
            Console.WriteLine("podaj druga liczbę");
            y = Console.ReadLine();
            wynikdodawania = double.Parse(x) + double.Parse(y);
            wynikodejmowania = double.Parse(x) - double.Parse(y);
            wynikmnozenia = double.Parse(x) * double.Parse(y);
            wynikdzielenia = double.Parse(x) / double.Parse(y);
            wynikprocentowy = double.Parse(x) % double.Parse(y); //modulo cos jak dzielenie tylko pokazuje reszte 
            Console.WriteLine("Wynik dodawania : {0}", wynikdodawania);
            Console.WriteLine("Wynik odejmowania : {0}", wynikodejmowania);
            Console.WriteLine("wynik mnozenia : {0}", wynikmnozenia);
            Console.WriteLine("Wynik dzielenia : {0}", wynikdzielenia);
            Console.WriteLine("wynik modulo : {0}", wynikprocentowy);

              

        }
    }
}
