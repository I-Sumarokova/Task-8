using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "File";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string path2 = "File/Sum.txt";
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }

            string path3 = "File/Sum.txt";
            using (StreamWriter sw = new StreamWriter(path3, false))
            {
                sw.WriteLine("Массив случайных чисел:");
                int[] array = new int[100];
                Random random = new Random();
                int S = 0;
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    S += array[i];
                    sw.Write("{0} ", array[i]);
                }
                sw.WriteLine("\nСумма чисел равна = {0}", S);
            }

            using (StreamReader sr = new StreamReader(path3))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();

        }

    }
}
