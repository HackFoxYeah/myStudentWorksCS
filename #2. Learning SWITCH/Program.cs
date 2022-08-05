using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа__4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Введите три целых числа day, mount, year, соответствующие определенной
            //дате. Выведите название месяца и количество дней месяца, учитывая
            //особенности високосного года.

            Console.WriteLine("Введите поочерёдно числа, соответствующие определённой дате. Например: 12.07.2024 - 12, 07, 2024");

            int day = int.Parse(Console.ReadLine()); //Ввод чисел
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            switch (month) //начало оператора выбора
            {
                case 1:
                    Console.WriteLine("Месяц: Январь, дней: 31");
                    break;

                case 2:
                    if (year % 4 == 0) //учёт високосного года
                        Console.WriteLine("Месяц: Февраль, дней: 29");
                    else
                        Console.WriteLine("Месяц: Февраль, дней: 28");
                    break;

                case 3:
                    Console.WriteLine("Месяц: Март, дней: 31");
                    break;

                case 4:
                    Console.WriteLine("Месяц: Апрель, дней: 30");
                    break;

                case 5:
                    Console.WriteLine("Месяц: Май, дней: 31");
                    break;

                case 6:
                    Console.WriteLine("Месяц: Июнь, дней: 30");
                    break;

                case 7:
                    Console.WriteLine("Месяц: Июль, дней: 31");
                    break;

                case 8:
                    Console.WriteLine("Месяц: Август, дней: 31");
                    break;

                case 9:
                    Console.WriteLine("Месяц: Сентябрь, дней: 30");
                    break;

                case 10:
                    Console.WriteLine("Месяц: Октябрь, дней: 31");
                    break;

                case 11:
                    Console.WriteLine("Месяц: Ноябрь, дней: 30");
                    break;

                case 12:
                    Console.WriteLine("Месяц: Декабрь, дней: 31");
                    break;

                default: //выход за допустимые значения месяца
                    Console.WriteLine("Месяца с таким номером не существует, пожалуйста, перепроверьте данные и введите числа заново.");
                    break;
            }
        }
    }
}
