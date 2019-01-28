using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace berlin52
{
    class Program
    {
        static void Main(string[] args) 
        {
            
           //string filePath = "R:\berlin52";
           readIt(@"R:\berlin52.txt");
           System.Console.ReadKey();

            /*
             * 
           string[] lines;
           var list = new List<string>();
           var fileStream = new FileStream(@"R:\berlin52.txt", FileMode.Open, FileAccess.Read);
            using (var sr = new StreamReader(fileStream,Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
          lines = list.ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("[" + lines[i] + "]");
            }
            System.Console.ReadKey();
             */


        }

        public static List<string> readIt(string fileName) 
        {
            List<string> result = new List<string>();

            try {
            StreamReader rd = new StreamReader(fileName,true);

            string line = string.Empty;
            while ((line = rd.ReadLine()) != null)
            {
                if (line != string.Empty)
                {
                    result.Add(line);
                }
            }
            string[] arr = result.ToArray();

           // result.ForEach(Console.WriteLine);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[" + arr[i] + "]");
            }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("problem occured");
                Console.WriteLine(ex.Message);
            }
            return result;
            
        }
    }
}
