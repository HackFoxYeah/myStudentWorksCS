using System;

namespace Капустин_9_работа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите А");
            int a = int.Parse(Console.ReadLine());
            int[] dim = new int[n];
          
            Random rnd = new Random();

            for (int i = 0; i < dim.Length; i++)
            {
                dim[i] = rnd.Next(100);
            }

            int min = dim[0], max = dim[0];

            for (int i = 0; i < dim.Length; i++)
            {
                if (dim[i] < min && dim[i] % a == 0)
                {
                    min = dim[i];
                }
            }

            for (int i = 0; i < dim.Length; i++)
            {
                if (dim[i] > max && dim[i] % 2 == 0)
                {
                    max = dim[i];
                }
            }

            Console.WriteLine($"Минимальное число, кратное А это {min}, максимальное число, кратное 2 это {max}");
            Console.ReadKey();
        }
    }
}
