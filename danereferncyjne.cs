using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class KlasaPomocnicza
            {
        public int  x;
    }
    class KlasaGlowna
    {  
        static void Main(string[] args)
        {
            KlasaPomocnicza obiekt1 = new KlasaPomocnicza();
            KlasaPomocnicza obiekt2 = new KlasaPomocnicza();

            obiekt1.x = 2;
            obiekt2 = obiekt1;
            obiekt1.x  = obiekt1.x + 8;

            Console.WriteLine("wartość x w obiekcie pierwszym : " + obiekt1.x);
            Console.WriteLine("wartosc x w obiekcie drugim :" + obiekt2.x);


        }   //dane referencyjne 
    }
}
