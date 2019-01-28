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
            double BMI, Wzrost, Waga;
            Console.WriteLine("Podaj Wzrost");
            Wzrost = double.Parse(Console.ReadLine());
            Wzrost /= 100;
            Console.WriteLine("Podaj Wage");
            Waga = double.Parse(Console.ReadLine());

            BMI = Waga / Math.Pow(Wzrost, 2);
            if (BMI < 18.5)
            {
                Console.WriteLine("Niedowaga");
            }
            else
            {

                if (BMI < 24.9)
                {

                    Console.WriteLine("Waga Prawidlowa");
                }

                else
                {
                    Console.WriteLine("Nadwaga");
                }
                Console.ReadKey();
                
            }
        }
    }
}
