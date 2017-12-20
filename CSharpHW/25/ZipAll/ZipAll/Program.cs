using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;

namespace ZipAll
{
    class Program
    {
        public delegate void ParameterizedThreadStart(Object obj);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory:");
            string path = Console.ReadLine();
            if (!String.IsNullOrEmpty(path))
            {
                string[] dirs = Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);
                switch (dirs.Length)
                {
                    case 0:
                        {
                            Console.WriteLine("directory is empty");
                            break;
                        }
                    case 1:
                        {
                            Zipping(dirs);
                            break;
                        }
                    default:
                        {
                            AssignThreads(dirs);
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("no path has been entered");
            }
        }

        static void AssignThreads(string[] dirs)
        {
            List<string> firstPart = new List<string>();
            List<string> secondPart = new List<string>();
            List<string> thirdPart = new List<string>();
            List<string> fourthPart = new List<string>();
            List<string> fifthPart = new List<string>();
            var partToAdd = 1;

            for (int i = 0; i < dirs.Length; i++)
            {
                switch (partToAdd)
                {
                    case 1:
                        {
                            firstPart.Add(dirs[i]);
                            break;
                        }
                    case 2:
                        {
                            secondPart.Add(dirs[i]);
                            break;
                        }
                    case 3:
                        {
                            thirdPart.Add(dirs[i]);
                            break;
                        }
                    case 4:
                        {
                            fourthPart.Add(dirs[i]);
                            break;
                        }
                    default:
                        {
                            fifthPart.Add(dirs[i]);
                            break;
                        }
                }
                if (partToAdd != 5)
                {
                    partToAdd++;
                }
                else
                {
                    partToAdd = 0;
                }
            }

            Thread thread1 = new Thread(Zipping);
            Thread thread2 = new Thread(Zipping);
            thread1.Start(firstPart);
            thread2.Start(secondPart);

            if (thirdPart.Count != 0)
            {
                Thread thread3 = new Thread(Zipping);
                thread3.Start(thirdPart);
            }
            if (fourthPart.Count != 0)
            {
                Thread thread4 = new Thread(Zipping);
                thread4.Start(fourthPart);
            }
            if (fifthPart.Count != 0)
            {
                Thread thread5 = new Thread(Zipping);
                thread5.Start(fifthPart);
            }

        }

        static void Zipping(Object dirs)
        {
            var files = dirs as List<string>;
            foreach (var dir in files)
            {
                if (!File.Exists(dir + ".zip") && !dir.EndsWith(".zip"))
                {
                    ZipFile.CreateFromDirectory(dir, dir + ".zip");
                }
            }
        }
    }
}
