using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/R/Desktop/Автоматизация BIM проектирования/Lab8/Lab8.2/Lab8.2.txt";
            #region//if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //DirectoryInfo dir = new DirectoryInfo(path);
            //{
            //    if (!dir.Exists)
            //    {
            //        dir.Create();
            //    }
            //}
            #endregion
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.WriteLine(array[i]);
                    Console.WriteLine(array[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                int[] lines = new int[10];
                int Sum=0;
                for (int i = 0; i < 10; i++)
                {
                    lines[i] = Convert.ToByte(sr.ReadLine());
                    Sum += lines[i];
                }
                Console.WriteLine();
                Console.WriteLine(Sum);
                Console.ReadKey();
            }
        }
    }
}
