using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = "C:/Users/R/Desktop/Автоматизация BIM проектирования/Lab8";
            string[] path = Directory.GetDirectories(dir);
            string[] files = Directory.GetFiles(dir);

            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine(path[i]);
                foreach (string f in Directory.GetFileSystemEntries(path[i]))
                {
                    Console.WriteLine("  {0}",f);
                }
            }
            for (int j = 0; j < files.Length; j++)
            {
                Console.WriteLine(files[j]);
            }

            Console.ReadKey();


        }
    }
}
