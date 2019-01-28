using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromek
{
    class Program
    {
                
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Podaj ciąg znaków");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) //Odwrócenie 
            {
                revs += s[i].ToString(); // wprowadzanie podanego wyrazu do zmiennej rev
            }
            if (revs == s) // sprawdzanie palindorma 
            {
                Console.WriteLine("Tak jest palindromem  ", s, revs);
            }
            else
            {
                Console.WriteLine("Nie jest palindromem ", s, revs);
            }
            Console.ReadKey();
        
        }
    }
}
