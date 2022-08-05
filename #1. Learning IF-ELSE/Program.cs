using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны три числа a, b, c. Если хотя бы одно из них равно нулю, то вычислить
            //сумму этих чисел, если все равны нулю, то вывести сообщение об этом, в противном
            //случае вычислить их произведение.

            Console.WriteLine("Введите три произвольных числа.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0 && c == 0) //Проверка условия: "Все числа равны нулю"
                Console.WriteLine("Все числа равняются нулю.");
            else
                if (a == 0 || b == 0 || c == 0) //Проверка условия: "Хотя бы одно из чисел равно нулю"
                Console.WriteLine("Сумма чисел равна: " + (a + b + c));
            else
                Console.WriteLine("Произведение чисел равно: " + a*b*c);
        }
    }
}
