using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podac slowo ");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i] + " ");
            }
        }
    }
}


            //string d = "";
            //  b = b - 1;
           // while (b != -1)
           // {
             //   d += s[b];
             //   b--;
          //  }
          //  Console.WriteLine(d);