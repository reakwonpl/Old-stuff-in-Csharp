using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            string s = Console.ReadLine();

            //zadanie 1.
            //powtarzanie ostatniego znaku 
            char o = s[s.Length - 1];
            for (int i = 0; i < s.Length; i++)
            {
                b++;
                if (o == s[i])
                {
                    a++;
                }
            }
            Console.WriteLine(o + "  " + a);

            //zadanie 2.
            //wczytywanie znakow od uzytkownika i odwracanie
            string d = "";
            b = b - 1;
            while (b != -1)
            {
                d += s[b];
                b--;
            }
            Console.WriteLine(d);

            //zadanie 3.
            //palindrom
            if (s == d)
            {
                Console.WriteLine("podany wyraz jest palindromem");
            }
            else
            {
                Console.WriteLine("podany wyraz nie jest palindromem");
            }

            //zadanie 4.
            //zliczanie cyfr w tekscie 
            int c = 0;
            foreach (int el in s)
            {
                if (el >= '0' && el <= '9')
                {
                    c = c + el;
                }
            }
            Console.WriteLine(c);
        }
    }
}
