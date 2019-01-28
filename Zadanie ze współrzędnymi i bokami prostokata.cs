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
            Console.WriteLine("Podaj współrzędną osi X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną osi Y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długosc boku a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długosc boku b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak do wypełnienia figury");
               string s = Console.ReadLine();
               Console.WriteLine("");
             for (int i = 1; i <= y; i++)
            {
                Console.WriteLine();
            }
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= b; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            
            }
        }
    }
}
