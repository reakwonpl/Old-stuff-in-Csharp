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
            double dochód, podatek;
            Console.WriteLine("Podaj dochód");
            dochód = double.Parse(Console.ReadLine());
            if (dochód <= 85528)
            {
                podatek = (dochód * 0.18) - 556.02;
            }
            else
            {
                podatek = 14839 + 0.32 * (dochód - 85528);
            }
            if(podatek<0)
            {
                podatek = 0;
            }
            Console.WriteLine("Podatek od dochodu wynosi {0}", podatek);
            Console.ReadKey();

        }
    }
}
