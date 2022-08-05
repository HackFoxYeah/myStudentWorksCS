using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kol = 0;
            int[,] dim = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < dim.GetLength(0); i++)
            {
                for (int j = 0; j < dim.GetLength(1); j++)
                {
                    dim[j, i] = rnd.Next(11);
                }
            }

            Console.WriteLine("Нечётные числа, содержащиеся в матрице");
            Console.WriteLine();

            for (int i = 0; i < dim.GetLength(0); i++)
            {
                for (int j = 0; j < dim.GetLength(1); j++)
                {
                    if (dim[i, j] % 2 != 0)
                    {
                        Console.Write(" " + dim[i, j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
