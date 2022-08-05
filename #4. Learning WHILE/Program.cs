using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите верхний предел суммы чисел.");

            int k = int.Parse(Console.ReadLine()), sum = 0, count = 0;

            Console.WriteLine("Введите последовательность целых чисел.");

            while (sum<k)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x>3&&x<7)
                {
                    sum = sum + x;
                    count = count + 1;
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine($"Сумма равна {sum}, количество переменных равно {count}");

            Console.ReadKey();
        }
    }
}
