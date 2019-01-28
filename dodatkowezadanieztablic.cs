using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halokarthushalo
{
    class Program
    {
        static float Funkcja(int[,] x, Boolean[,] y, int z, int c) //funkcja ktora jako parametry otrzymuje:
        //dwu wymiarowa tablice licz calkowitych int 
            //dwu wymiarowa tablice boolowska boolean
            //dwie liczby calkowie z,c
        {
            Random rand = new Random();  //losowanie
            int wylosowana_2, suma = 0, suma_2 = 0; 
            for (int i = 0; i < x.GetLength(0); i++) 
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = rand.Next(-10, 20); // pierwsza tablica od losowe wartosci -100 do 200 
                    if (i == j || i + j == x.Length - 1)
                    {
                        wylosowana_2 = rand.Next(0, 100);

                        if (wylosowana_2 < 75) //na przekatnych 75% ma miec wartosc -1 
                        {
                            x[i, j] = -1;
                        }
                        else     // pozostałe 25% ma miec wartosc 1 
                        {
                            x[i, j] = 1;
                        }
                    }
                    if (x[i, j] == z || x[i, j] == c) //suma elementow w odpowienich komórkach tablicy booleowskiej
                    {
                        suma++;
                    }
                    if (y[i, j])
                    {
                        suma_2 += x[i, j];
                    }
                }
            }

            return ((float)suma / suma_2);  //stosunek liczby elemementow do obliczonej sumy  
        }
        static void Main(string[] args)
        {
            Random los = new Random();
            int wylosowana;
            Console.WriteLine("Podaj pierwszy parametr");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugi parametr");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wielkość tablicy");
            int n = int.Parse(Console.ReadLine());
            int[,] tab1 = new int[n, n];
            Boolean[,] tab2 = new Boolean[n, n];
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    wylosowana = los.Next(0, 2);
                    if (wylosowana == 1)
                    {
                        tab2[i, j] = true;
                    }
                    else
                    {
                        tab2[i, j] = false;
                    }
                }
            }
            Console.WriteLine(Funkcja(tab1, tab2, a, b));
        }

    }
}