using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\andrey\RiderProjects\IT_Tasks\task2\TestText.txt";

            Dictionary<int, int> result = task2(getFileContent(path));

            foreach (int key in result.Keys)
            {
                Console.WriteLine($"{key}: {result[key]}");
            }
        }

        public static string getFileContent(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            return reader.ReadToEnd();
        }

        public static Dictionary<int, int> task2(string input)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            string[] words = input.Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!result.Keys.Contains(words[i].Length))
                {
                    result.Add(words[i].Length, 1);
                }
                else
                {
                    result[words[i].Length]++;
                }
            }
            return result;
        }

    }
}