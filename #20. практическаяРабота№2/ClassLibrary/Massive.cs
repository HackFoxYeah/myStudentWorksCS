using Microsoft.Win32;
using System;
using System.IO;

namespace LibMas
{
    public class Massiv
    {
        /// <summary>
        /// Метод инициализирует массив, состоящий из случайных значений.
        /// </summary>
        /// <param name="randMax">Верхний диапазон генерации случайных чисел.</param>
        /// <param name="column">Длина массива.</param>
        /// <param name="array">Массив, который нужно сгенерировать.</param>
        /// <returns>-</returns>
        public static void InitArr(out int[] array, int column, int randMax)
        {
            Random rnd = new Random();

            array = new int[column];

            for (int i = 0; i < column; i++)
            {
                array[i] = rnd.Next(randMax);
            }
        }

        /// <summary>
        /// Перегрузка метода InitArr, которая инициализирует массив из нулей.
        /// </summary>        
        /// <param name="column">Длина массива.</param>
        /// <param name="array">Массив, который нужно сгенерировать.</param>
        /// <returns>-</returns>
        public static void InitArr(out int[] array, int column)
        {
            /*Random rnd = new Random();*/

            array = new int[column];

            for (int i = 0; i < column; i++)
            {
                array[i] = 0;
            }
        }

        /// <summary>
        /// Метод очищает передаваемый массив.
        /// </summary> 
        public static void Clear(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        /// <summary>
        /// Метод сохраняет передаваемый массив в файл.
        /// </summary> 
        public static void SaveArr(ref int[] array)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(save.FileName);

                file.WriteLine(array.Length);

                for (int i = 0; i < array.Length; i++)
                {
                    file.WriteLine(array[i]);
                }

                file.Close();
            }
        }

        /// <summary>
        /// Метод открывает файл и записывает данные в передаваемый массив.
        /// </summary> 
        public static void OpenArr(ref int[] array)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";

            if (open.ShowDialog() == true)
            {
                StreamReader file = new StreamReader(open.FileName);

                int length = Convert.ToInt32(file.ReadLine());

                array = new int[length];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(file.ReadLine());
                }

                file.Close();
            }
        }
    }
}
