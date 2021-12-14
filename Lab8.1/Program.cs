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
            #region
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo d in drives)
            //{
            //    Console.WriteLine("Название диска {0}", d.Name);
            //    if (d.IsReady)
            //    {
            //        Console.WriteLine("Объём диска {0}", d.TotalSize);
            //        Console.WriteLine("Объём свободного пространства {0}", d.AvailableFreeSpace);
            //        Console.WriteLine();
            //    }
            //    Console.ReadKey();
            //}
            //string path = "Logs2/Log.txt";
            //if (!Directory.Exists(path))
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
            //if (!File.Exists(path)) 
            //{
            //    File.Create(path);
            //}
            //using (StreamWriter sw = new StreamWriter(path, true))
            //{
            //    sw.WriteLine("Старт программы");
            //    sw.WriteLine("Ошибка программы");
            //}
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}
            //Console.ReadLine();
            //Console.ReadKey();
            #endregion
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
