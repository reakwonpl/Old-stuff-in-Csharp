using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static double a, b, c, obl_delta, x1, x2;
        public static void wprowadz()
        {
            Console.WriteLine("Podaj współczynniki równania kwadratowego \n");
            a = 0;

            while (a == 0)
            {
                Console.WriteLine("a: \n");
                a = System.Int32.Parse(Console.ReadLine());
                //Console.WriteLine("Błąd ,a nie może wynosić 0! ");
                Console.WriteLine("b: \n");
                b = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("c: \n");
                c = System.Int32.Parse(Console.ReadLine());
                if (a == 0)
                    Console.WriteLine("Błąd! a nie może wynosić 0");
            }



        }
        public static double delta(double a, double b, double c)
        {
            obl_delta = (b * b) - 4 * a * c;
            Console.WriteLine("Delta wynosi: " + obl_delta + " \n");
            return obl_delta;
        }

        public static void x()
        {
            if (obl_delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Dla delty równej 0: \nx1 i x2 wynoszą: " + x1);
            }
            else if (obl_delta > 0)
            {
                x1 = (-b - Math.Sqrt(obl_delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(obl_delta)) / (2 * a);
                Console.WriteLine("Dla delty większej niż 0:\nx1 = " + x1 + " \nx2 = " + x2);
            }
        }

        public static void ix()
        {
            double Re, Im;

            if (obl_delta < 0)
            {
                Re = (-b / (2 * a));
                Im = (Math.Sqrt(-obl_delta)) / (2 * a);

                Console.WriteLine("" + Re + "-" + Im + "i");
                Console.WriteLine("" + Re + "+" + Im + "i");
            }
        }

        static void Main(string[] args)
        {
            wprowadz();
            Console.WriteLine(a + " " + b + " " + c);
            delta(a, b, c);
            x();
            ix();
            //x1 = x(obl_delta, x1);
            //x2 = x(obl_delta, x1, x2);
            Console.ReadKey();
        }
    }
}