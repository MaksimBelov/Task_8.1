using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к каталогу для вывода его содержимого:");
            string path = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Содержимое указанного каталога:");
            string[] filesParentDir = Directory.GetFiles(path);
            foreach (string f in filesParentDir)
            {
                Console.WriteLine(f);
            }
            string[] subDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (string i in subDirectories)
            {
                Console.WriteLine(i);
                string[] files =  Directory.GetFiles(i);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
            }
            Console.ReadKey();
        }
    }
}
