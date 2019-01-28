using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class echo
    {
        string napis;
        public  void WczytajNapis()
        {
            System.Console.WriteLine("podaj napis");
            napis = System.Console.ReadLine();
         }

        public void Napisz()
        {
            System.Console.Write("Napisales ");
            Console.WriteLine(napis);
        }
    }
    class KlasaGlowna
    {
        static void Main()
        {
            echo obiektEcho = new echo();
            obiektEcho.WczytajNapis();
            obiektEcho.Napisz();
            System.Console.ReadLine();
        }
    }
}
