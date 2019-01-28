using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        { 
            int licznik = 0;
            int parzyste = 0;
            Random los = new Random();
            int x = los.Next(1, 11);
            Console.WriteLine(x);
            for (int i = 0; i <= x; i++)
            {
                licznik++;
                int y = los.Next(1, 11);
                Console.WriteLine(y);
                if (licznik % 2 == 0)
                {
                    parzyste += y;
                }
            }
          
            Console.WriteLine(parzyste);
           



        }
    }
}
