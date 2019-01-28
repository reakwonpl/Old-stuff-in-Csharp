using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void odejmij(int x, int y)
        {
            Console.WriteLine(x - y);
            
        }
        static double dziel(double a, int b)
        {
            double wynik = 0;
            if (b != 0)
            {
                return (a / b);
            }
            else return (wynik);
        }
        static void dodaj(int c)
        {
            c++;
            Console.WriteLine("Argument z wnetrza metody : " + c);
        }
        static void Wielkie(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab[i].ToUpper();
            }
        }
        static int[] liczby(int rozmiar)
        {
            int[] tabx = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                tabx[i] = i;
            }
            return (tabx); //zwraca tablice
        }
        static void Wielkie(string[,] tabe)
        {
            for (int i = 0; i < tabe.GetLength(0); i++)
            {
                for (int j = 0; j < tabe.GetLength(1); j++)
                {
                    tabe[i, j] = tabe[i, j].ToUpper();
                }
            }
        }

        static int Silnia(int n) //silnia z forem
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
                s = s * i;
            return (s);
        }
        static void Main(string[] args)
        {
            odejmij(4, 3);
            Console.WriteLine(dziel(1.5, 3));
            int d = 5;
            Console.WriteLine("Przed wywolaniem metody : " + d);
            dodaj(d);
            Console.WriteLine("po wywowałniu metody : " + d);

            string[] tab1 = { "jeden", "dwa", "trzy" };

        Wielkie(tab1); // wywołanie metody (tablica argumentem)
            for (int i = 0; i < tab1.Length; i++)
        {
             Console.Write(tab1[i] + " ");
            }


            int[] taby = liczby(8); //wywołanie metody
            for (int i = 0; i < taby.Length; i++)
            {
                Console.WriteLine(taby[i] + " ");
            }


               string[,] tabe = {{ "jeden", "dwa", "trzy" },
                     { "one", "two", "three" }};
            Wielkie(tabe); // wywołanie metody (tablica argumentem)
            for (int i = 0; i < tabe.GetLength(0); i++)
            {
                for (int j = 0; j < tabe.GetLength(1); j++)
                {
                    Console.Write("{0,-8}", tabe[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(Silnia(5));

        }
    }
}
