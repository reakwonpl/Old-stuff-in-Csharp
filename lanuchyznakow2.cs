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
            
            Console.WriteLine("Podaj ciag znakow");
            string S = Console.ReadLine();
             for (int i = S.Length - 1; i >=0; i--)
             {
              Console.WriteLine(S[i]);
             }
        }
    }
}
