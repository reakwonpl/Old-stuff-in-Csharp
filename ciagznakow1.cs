using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 0;
            char vod;
            Console.WriteLine("Podaj ciag znakow");
            string S = Console.ReadLine();
            vod = S[S.Length - 1];
            

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == vod)
                {
                    licznik++;
                }
               
            }
            Console.WriteLine(licznik);
        }
    }
}
