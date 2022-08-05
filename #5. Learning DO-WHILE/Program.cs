using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0, x = 1;

            Console.WriteLine("Вводите поочердёно неотрицательные целые числа среднее арифметическое которых вы хотите узнать." +
                " Чтобы закончить последовательность, введите любое отрицательное число.");
            do
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 0)
                {
                    sum = sum + x;
                    count = ++count;
                }

            } while (x >= 0);

            /*double avrValue = sum / count;*/
            Console.WriteLine($"Среднее арифметическое неотрицательных чисел равно {sum / count}");

            Console.ReadKey();
        }
    }
}
