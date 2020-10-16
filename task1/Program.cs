using System;

namespace task1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("set width \n");
            int w = Int32.Parse(Console.ReadLine());
            Console.Write("set height \n");
            int h = Int32.Parse(Console.ReadLine());

            int[,] matrix = GetMatrix(w, h);

            int[] res = Task(h, w, matrix);

            Console.Write($"count: {res[0]}|summ: {res[1]}");


        }

        public static int[] Task(int h, int w, int[,] matrix)
        {
            int summ = 0;
            int count = 0;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (matrix[i, j] % 3 == 0)
                    {
                        summ += matrix[i, j];
                    }

                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return new []{count, summ};
        }
        
        public static int[,] GetMatrix(int w, int h)
        {
            int[,] matrix = new int[h, w]; 

            for (int i = 0; i < h; i++)
            {
                string[] line = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < w; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            return matrix;
        }

    }
}