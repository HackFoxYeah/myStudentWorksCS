using System;
using Библиотека_для_15ой_работы;

namespace Пятнадцатая_работа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");

            int inptValue = int.Parse(Console.ReadLine()); //ввод числа 

            if (ClassOne.compareNumbers(inptValue) == 1) Console.WriteLine("1) Первая цифра больше второй");

            else if (ClassOne.compareNumbers(inptValue) == 2) Console.WriteLine("1) Вторая цифра больше первой");

            else  Console.WriteLine("1) Никакая из цифр не больше");

            if (ClassOne.areNumbersEqual(inptValue) == 1) Console.WriteLine("2) Цифры равны");

            else  Console.WriteLine("2) Цифры не равны");

            if (ClassOne.sumMultipleOf3(inptValue) == 1) Console.WriteLine("3) Сумма цифр кратна 3");

            else  Console.WriteLine("3) Сумма цифр не кратна 3");

            Console.ReadKey();
        }
    }
}
