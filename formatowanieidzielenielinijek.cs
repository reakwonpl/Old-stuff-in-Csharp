using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //System.Console.WriteLine("Siemanko,jak masz na imie?");
           // string imie = System.Console.ReadLine();
            //System.Console.WriteLine("Witaj," + imie + "!");

            System.Console.WriteLine("Formatowanie z C: {0:C}", 777.7777); //formatowanie waluty C
            System.Console.WriteLine("Formatowanie z D2: {0:D2}", 777);     //formatowanie liczb dziesietnych D
            System.Console.WriteLine("Formatowanie z D9: {0:D9}", 777);     //formatowanie notacji wykladniczych E
            System.Console.WriteLine("Formatowanie z E: {0:E}", 777.7777);  //formatowanie z ustaloną liczba miejsc po przecinku F
            System.Console.WriteLine("Formatowanie z F2: {0:F2}", 777.7777);  //ogolne formatowanie G
            System.Console.WriteLine("Formatowanie z F9: {0:F9}", 777.7777);    //podstawowy format liczbowy N
            System.Console.WriteLine("Formatowanie z G: {0:G}", 777.7777);           // Format heksadecymalny X
            System.Console.WriteLine("Formatowanie z N: {0:N}", 777.7777);
            System.Console.WriteLine("Formatowanie z X: {0:X}", 7779);

            System.Console.WriteLine("To jest długi napis, \nktory dzielimy na \nkilka linijek \nzamiast wypisywac od nowa writeline \n:D");
            
///            \a – „dzwonek”, wygenerowany zostanie sygnał dźwiękowy,
 //               \b – „backspace”, skasowanie ostatniego znaku i cofnięcie o jeden znak,
//                  \r – powrót karetki, powrót do początku linii,
//                  \t – tabulacja (odstęp) w poziomie,
//                  \v – tabulacja w pionie,
//              \’ – znak cudzysłowu (łańcuchy zawieramy w znakach cudzysłowu, a czasami jest potrzeba wypisania na ekranie tego znaku, należy wtedy użyć znaku specjalnego),
//                      \\ - znak „backslash”, czyli „\”.
        }
    }
}
