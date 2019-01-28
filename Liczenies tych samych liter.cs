using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj slowo");
            int licznik = 0;
            string slowo = Console.ReadLine();
            char o = slowo[slowo.Length - 1];
            for (int i = 0; i < slowo.Length; i++)
            {
                if (o == slowo[i]) 
                {
                    licznik++;
                }
            }              
            Console.WriteLine(o + " " + licznik);                    

        }
    }
}
