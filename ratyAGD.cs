using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            float LiczbaRat, CenaTowaru,Rata,Oprocentowanie;
            Console.WriteLine("Podaj liczbe rat (od 6-48)");
           LiczbaRat = float.Parse(Console.ReadLine());

           if (LiczbaRat < 6)
           {

               Console.WriteLine("Błąd,prosze podać dane jeszcze raz");
           }
            if (LiczbaRat <= 12) {
                Oprocentowanie = 0.025F;
            }
            if (LiczbaRat <= 24)
            {
                Oprocentowanie = 0.050F;
            }
            if (LiczbaRat <= 48)
            {
                Oprocentowanie = 0.1F;
            }
                     
               Console.WriteLine("Podaj cene towaru");
               CenaTowaru = float.Parse(Console.ReadLine());
               if (CenaTowaru > 10000)
               {
                   Console.WriteLine("Błąd,prosze podać dane jeszcze raz");
               }
               if (CenaTowaru < 100)
               {
                   Console.WriteLine("Błąd,prosze podać dane jeszcze raz");
               }
               Rata = LiczbaRat / (CenaTowaru * Oprocentowanie);
               Console.WriteLine("Twoja Rata wynosi {0}", Rata);

            
             }

        }
    }

