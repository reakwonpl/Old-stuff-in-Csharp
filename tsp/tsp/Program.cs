using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsp
{
    class Program
    {


 public static int[,] readFile(string path)
    {
          var lines  = System.IO.File.ReadAllLines(path);
          var dimension = int.Parse(lines[0]);
          var point = 0;
          var array = new int[dimension, dimension];

               foreach (var lineOf in lines)
               {
                   var rows = lineOf.Trim().Split(' ');

                   if (lineOf != lines[0])
                   {
                       for (var columns = 0; columns < rows.Length; columns++)
                       {
                           var nextLine = int.Parse(rows[columns]);

                           array[point, columns] = nextLine;
                           array[columns, point] = nextLine;
                       }
                       point++;
                   }
           }
           Console.WriteLine("Executed");
           Console.ReadKey();
           return array;
    }

 public static void display2DArray(int[,] array)
     {
         int rows = array.GetLength(0);
         int columns = array.GetLength(1);

         for (int i = 0; i < rows; i++)
         {
             for (int j = 0; j < columns; j++)
             {
                 Console.Write(string.Format("{0} ", array[i, j]));
             }
             Console.Write(Environment.NewLine + Environment.NewLine);
          }
         Console.ReadKey();
     }

 static void Main(string[] args)
        {
            string pathfile = @"R:\berlin52.txt";
            //readFile(pathfile);
            int[,] array = readFile(pathfile);
            display2DArray(array);

            int quantity = 10;
            var nextArray = new int[quantity, array.GetLength(0) + 1];
            Random r = new Random();
            int rnd;

            long ill = 0;
             long iil = 0;
             long ikl = 0;
             for (int i = 0; i < quantity; i++)
             {
                 for (int j = 0; j < nextArray.GetLength(1);j++ )
                 {
                     nextArray[i, j] = -1;
                 }
             }
                 for (int i = 0; i < quantity; i++)
                 {

                     Console.WriteLine("i:" + iil++);
                     for (int j = 0; j < nextArray.GetLength(1); j++)
                     {
                         Console.WriteLine("j:" + ill++);
                         rnd = r.Next(0, array.GetLength(0));
                         for (int k = 0; k < nextArray.GetLength(1); k++)
                         {
                             Console.WriteLine("k:" + ikl++);
                             if (rnd == nextArray[i, k])
                             {
                                 rnd = r.Next(0, array.GetLength(0));
                                 k = -1;
                             }
                         }
                         nextArray[i, j] = rnd;
                     }
                 }
            Console.WriteLine("XD");
            int specimen = 0;
            int sp1;
            int sp2;
            int sp3;
            int sp4;
            double sum = 0;
            int number = 0;
            int low = 0;
            var distances = new int[quantity];
            int x;
            for (int i = 0; i < quantity; i++)
            {
                sum = 0;
                for (x = 0; x< nextArray.GetLength(1) - 2; x++)
                {
                    sp1 = nextArray[i, x];
                    sp2 = nextArray[i, x + 1];
                    sp3 = array[sp1, sp2];

                    sum += sp3;
                }
                sp4 = array[nextArray[i, x], nextArray[i, 0]];
                number = (int)sum + sp4;
                distances[i] = number;
           }
            for (int i = 0; i < quantity; i++)
            {
                nextArray[i, array.GetLength(1)] = distances[i];
            }
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Specimens " + specimen);
                Console.WriteLine();
                specimen++;
                for (int j = 0; j < nextArray.GetLength(1); j++)
                {
                    Console.Write(" " + nextArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
