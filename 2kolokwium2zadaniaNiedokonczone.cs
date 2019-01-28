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
            int suma = 0;
          
            int cotrzecia = 0;
            int licznik = 0;
            int licznik2 = 0;
            int sredniawszystkich = 0;
             Console.WriteLine("Siema podaj liczbe");
             int x = 0;
          do
             {
                  x = int.Parse(Console.ReadLine());
                  licznik2++;
                 if (x > 0)
                 {
                     licznik++;
                     suma += x;
                 }
                 if (licznik2 % 3 == 0)
                 {
                     cotrzecia += x;
                 }
             } while (x != 0);
                Console.WriteLine("Suma co trzecich wynosi {0}", cotrzecia);
                Console.WriteLine("Suma wszystkich wynosi dodatnich {0}", suma);
                sredniawszystkich = suma / licznik2;
                Console.WriteLine("Srednia wszystkich wynosi {0}", sredniawszystkich);
                Console.WriteLine("Stosunek średniej wszystkich liczb dodatnich do sumy co trzecich wynosi : {0} / {1}", sredniawszystkich, cotrzecia);






        }
    }
}



  
          //  do
           // {
             //  int x = int.Parse(Console.ReadLine());
             // licznik++;
             //   if (x > 0)
             //   {
             //       suma += x;
              //  }
              //  if (licznik % 3 == 0)
              //  {
             //       cotrzecia += x;
              //  }
          //  } while (x != 0);