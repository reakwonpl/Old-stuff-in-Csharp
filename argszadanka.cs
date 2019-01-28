using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Brak argumentów programu!");
                return;
            }
            int[] ArrInt = new int[args.Length];
            int count = 0;

            foreach (string element in args)
            {
                ArrInt[count] = Int32.Parse(element);
                ++count;
            }

            Array.Sort(ArrInt);

            for (int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine("{0} ", ArrInt[i]);
            }
        }
    }
}
