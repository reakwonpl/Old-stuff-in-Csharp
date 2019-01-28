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
            float F, C;
            Console.WriteLine("Podaj temperature w stopniach Celcjusza");
            C = float.Parse(Console.ReadLine());
            F = 1.8F * (float)C + 32.0F;
            Console.WriteLine(" {0} Stopni Fahrenheita", F);
            Console.ReadKey();
        }
    }
}
