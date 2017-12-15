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

            for (int i = 0; i < dirs.Length; i++)
            {
                if (i % 5 == 0)
                {
                    fifthPart.Add(dirs[i]);
                }
                else if (i % 4 == 0)
                {
                    fourthPart.Add(dirs[i]);
                }
                else if (i % 3 == 0)
                {
                    thirdPart.Add(dirs[i]);
                }
                else if (i % 2 == 0)
                {
                    secondPart.Add(dirs[i]);
                }
                else
                {
                    firstPart.Add(dirs[i]);
                }
            }

            Thread thread1 = new Thread(Zipping);
            Thread thread2 = new Thread(Zipping);
            Thread thread3 = new Thread(Zipping);
            Thread thread4 = new Thread(Zipping);
            Thread thread5 = new Thread(Zipping);

            thread1.Start(firstPart.ToArray());
            thread5.Start(fifthPart.ToArray());
            if(secondPart!=null)
            {
                thread2.Start(secondPart.ToArray());
            }
            if(thirdPart!=null)
            {
                thread3.Start(thirdPart.ToArray());
            }
            if(fourthPart!=null)
            {
                thread4.Start(fourthPart.ToArray());
            }

        }

        static void Zipping(Object dirs)
        {
            var files = dirs as string[];
            foreach (var dir in files)
            {
                if (!File.Exists(dir + ".zip") && !dir.EndsWith(".zip"))
                {
                    try
                    {
                        ZipFile.CreateFromDirectory(dir, dir + ".zip", CompressionLevel.Fastest, true);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
