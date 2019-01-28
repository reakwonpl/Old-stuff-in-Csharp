using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podac liczbe");
            int x = int.Parse(Console.ReadLine());
            int licznik = 0;
            int licznik2 = 0;
            int[] tab = new int[32];
            for (int i = 0; i < tab.Length; i++)
            {
                if (x > 0)
                {
                    tab[i] = x % 2;
                    if (x != 0)
                    {
                        licznik++;
                    }
                    x /= 2;
                }
                if (x < 0)
                {
                    tab[i] = -(x % 2);
                    if (x != 0)
                    {
                        licznik++;
                    }
                    x /= 2;
                }
            }
            Array.Reverse(tab);
            for (int i = tab.Length - licznik; i < tab.Length; i++)
            {
                if (x < 0 && licznik2 == 0)
                {
                    Console.WriteLine("1.");
                    licznik2++;
                }
                Console.Write(tab[i]);
            }
            Console.WriteLine();
        }
    }
}
