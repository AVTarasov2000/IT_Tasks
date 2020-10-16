using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace task2Library
{
    public class File
    {

        private string Path { get; }


        public File(string path)
        {
            this.Path = path;
        }

        public string getFileContent()
        {
            FileStream file = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            return reader.ReadToEnd();
        }
        
        public Dictionary<int, int> task2()
        {
            
            Dictionary<int, int> result = new Dictionary<int, int>();
            string[] words = getFileContent().Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);
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