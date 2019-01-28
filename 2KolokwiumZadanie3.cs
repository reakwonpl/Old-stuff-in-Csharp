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
            Console.WriteLine("Podaj dwie liczby");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int licznik = 0;
            Random los = new Random();
            int[,] tab = new int[50, 50];
            for (int j = 0; j < tab.GetLength(0); j++)
            {
                for (int i = 0; i < tab.GetLength(1); i++)
                {
                    tab[j, i] = los.Next(-100, 101);
                     if (j % 2 != 0)
                         {
                                  tab[j,i] = 1;
                         }
                    if ( tab[j,i] >= x &&  tab[j,i] <= y)
                    {
                        licznik++;
                    }
                     
                }
                
            }
            Console.WriteLine("Ilosc elementow w przedziale {0}",licznik);
       

        }
    }
}

         /*   for (int j = 0; j < tab.GetLength(0); j++)
            {
                for (int i = 0; i < tab.GetLength(1); i++)
                {
                    Console.Write("{0,4}",tab[j, i]);
                }
                Console.WriteLine();  */
            