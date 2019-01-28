using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace hehe
{
    class Program
    {
        public static string zamiana(string text)
        {
            string text2 = "";
            int licznik = 0, suma_cyfr = 0, suma_liter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 102 && text[i] <= 107) //ASCII 
                {
                    text2 += (char)(text[i] + 1); //zmiana liter
                }
                else
                {
                    if (text[i] == 75 && licznik != 1)
                    {
                        text2 += (char)(text[i] + 15); //pierwszy litera
                        licznik++;
                    }
                    else
                    {
                        text2 += (char)(text[i]); //tak jak bylo
                    }
                }
                if (text[i] >= 48 && text[i] <= 57) 
                {
                    suma_cyfr++;
                }
                if (text[i] >= 65 && text[i] <= 90 || text[i] >= 97 && text[i] <= 122)
                {
                    suma_liter++;
                }
            }
            Console.WriteLine("Ilośc cyfr: {0}", suma_cyfr);
            Console.WriteLine("Ilośc liter: {0}", suma_liter);
            return text2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            Console.WriteLine(zamiana(tekst)); //odwołanie metoda(zmienna)
        }
    }
}