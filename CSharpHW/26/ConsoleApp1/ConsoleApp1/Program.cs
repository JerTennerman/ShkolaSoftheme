using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory:");
            var path = Console.ReadLine();
            if (!string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Enter line to find:");
                var lineToChange = Console.ReadLine();
                if (string.IsNullOrEmpty(lineToChange))
                {
                    Console.WriteLine("invalid line");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Enter new line:");
                var newLine = Console.ReadLine();
                if (string.IsNullOrEmpty(newLine))
                {
                    Console.WriteLine("Invalid new line");
                    Console.ReadKey();
                    return;
                }
                string[] dirs = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
                switch (dirs.Length)
                {
                    case 0:
                        {
                            Console.WriteLine("dorectory got no .txt files");
                            break;
                        }
                    case 1:
                        {
                            Changer(dirs[0], lineToChange, newLine);
                            break;
                        }
                    default:
                        {
                            TaskManager(dirs, lineToChange, newLine);
                            break;
                        }
                }
            }
        }

        static void TaskManager(string[] directories, string lineToChange, string newLine)
        {
            var taskCounter = 0;
            List<Task> Tasks = new List<Task>();

            for (int i = 0; i < directories.Length; i++)
            {
                if (Tasks.Count != taskCounter)
                {
                    Tasks[taskCounter].Wait();
                    Tasks[taskCounter] = new Task(() => Changer(directories[i], lineToChange, newLine));
                }
                else
                {
                    Tasks.Add(new Task(() => Changer(directories[i], lineToChange, newLine)));
                }
                Tasks[taskCounter].Start();

                if (taskCounter == Environment.ProcessorCount)
                {
                    taskCounter = 0;
                }
                else
                {
                    taskCounter++;
                }
            }

            Task.WaitAll(Tasks.ToArray());
        }

        static void Changer(string directory, string lineToChange, string newLine)
        {
            string text = File.ReadAllText(directory);
            text = text.Replace(lineToChange, newLine);
            File.WriteAllText(directory, text);
        }
    }
}
