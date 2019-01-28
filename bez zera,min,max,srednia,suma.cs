using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            double a = 0;
            int max = 0;
            int min = 0;

         int  licznik = 0;
            while (x != 0)
            {      
                Console.WriteLine("podaj liczbe");
                x = int.Parse(Console.ReadLine());
                a = a + x;
                licznik++;  
        
                if ( x > max ) 
        {
            max = x;
        }
        else if (x < min ) 
        {
            min = x;
        }
              
             } 
            double srednia = a / (licznik - 1);
            Console.WriteLine("Srednia wynosi : {0}", srednia);
     Console.WriteLine("maks to {0}",max);
        Console.WriteLine("min to {0}", min);
        int suma = min + max;
        Console.WriteLine("Suma liczb maksymalnych i minimalnych wynosi {0}", suma);
       }

      }                

    }

