using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] tab = new int[10];
            int suma = 0;
            int max = tab[0], min = tab[0],mniejsza=0,wieksza=0;

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(-10, 10);
                Console.Write("   {0}; ", tab[i]);
                suma += tab[i]; 
                   
            }
            Console.WriteLine();
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];

                }
                else if (tab[i] < min)
                {
                    min = tab[i];
                }
                
            }
                Console.WriteLine("Najmniejsza wylosowana liczba to {0}", min);
                Console.WriteLine("Najwieksza wylosowana liczba  to {0}", max);
                Console.WriteLine("Srednia wynosi {0}",tab.Average());
             
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] > tab.Average())
                    {
                        
                       // Console.WriteLine("Liczb wiekszych od sredniej jest {0}", wieksza);
                        wieksza++;

                    }
                    else if (tab[i] < tab.Average())
                    {
                      
                        //Console.WriteLine("Liczb mniejszych od sredniej jest {0}", mniejsza);
                        mniejsza++;

                    }
                  
                }
                Console.WriteLine("Liczb wiekszych od sredniej jest {0}", wieksza);
                Console.WriteLine("Liczb mniejszych od sredniej jest {0}", mniejsza);
        
                
                

        }
    }
}

