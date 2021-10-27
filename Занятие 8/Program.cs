using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Занятие_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\User\\Desktop\\Lab8\\";
            if (Directory.Exists(path))
            {
                string[] paths = Directory.GetDirectories(path);
                foreach (string s in paths)
                {
                    Console.WriteLine();
                    Console.WriteLine("Каталоги:");
                    Console.WriteLine(s);
                    Console.WriteLine();

                    Console.WriteLine("Подкаталоги:");
                    string[] path2 = Directory.GetDirectories(s);
                    foreach (string s1 in path2)
                    {
                        Console.Write(s1);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
