using System;

namespace Работа__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента (х), удоволетворяющего условие 0<x<2PI (от 0 до 6,283), для проведения расчётов.");
            Console.WriteLine(); //Пропуск строки на выводе

            double x = double.Parse(Console.ReadLine()); //Ввод переменных (аргумент, Пи, функции)
            const double PI = 3.1415926535897931;
            double raschetFunc = 0, analitFunc = (PI - x) / 2.0;

            if (0 < x && x < 2 * PI) //Проверка адекватности аргумента для данных формул                    
                for (int n = 1; n <= 100; n++) //цикл
                    raschetFunc = raschetFunc + Math.Sin(n * x) / n;
            else
            {
                Console.WriteLine("Введите число, соответсвующее значению аргумента, удоволетворяющего условие 0<x<2PI");
                Console.WriteLine(); //Пропуск строки на выводе
            }

            if (Math.Abs(analitFunc - raschetFunc) < 0.1) //Сравнение чисел на приблежённое равенство
            {
                Console.WriteLine(); //Пропуск строки на выводе
                Console.WriteLine("Расчёты произведены правильно.");
                Console.WriteLine(); //Пропуск строки на выходе
                Console.WriteLine($"Значение полученное в ходе вычислений по функции: расчётной: {raschetFunc}, аналитической: {analitFunc}");
            }
            else
            {
                Console.WriteLine("Расчёты произведены неправильно.");
            }
        }
    }
}
