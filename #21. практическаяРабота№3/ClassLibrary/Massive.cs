using Microsoft.Win32;
using System;
using System.IO;

namespace LibMas
{
    public static class Massiv
    {
        /// <summary>
        /// Метод инициализирует одномерный массив, состоящий из случайных значений.
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
        /// Метод инициализирует одномерный массив, состоящий из нулей.
        /// </summary>        
        /// <param name="column">Длина массива.</param>
        /// <param name="array">Массив, который нужно сгенерировать.</param>
        /// <returns>-</returns>
        public static void InitArr(out int[] array, int column)
        {
            array = new int[column];

            for (int i = 0; i < column; i++)
            {
                array[i] = 0;
            }
        }

        /// <summary>
        /// Метод инициализирует двумерный массив, состоящий из случайных значений.
        /// </summary>
        /// <param name="randMax">Верхний диапазон генерации случайных чисел.</param>
        /// <param name="column">Количество стобцов в массиве.</param>
        /// <param name="array">Массив, который нужно сгенерировать.</param>
        /// <param name="rows">Количество строк в массиве.</param>
        /// <returns>-</returns>
        public static void InitArr(out int[,] array, int column, int rows, int randMax)
        {
            Random rnd = new Random();

            array = new int[rows, column];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = rnd.Next(randMax);
                }
            }
        }

        /// <summary>
        /// Инициализирует двумерный массив, состоящий из нулей.
        /// </summary>        
        /// <param name="column">Количество столбцов в массиве.</param>
        /// <param name="rows">Количество строк в массиве.</param>
        /// <param name="array">Массив, который нужно сгенерировать.</param>
        /// <returns>-</returns>
        public static void InitArr(out int[,] array, int column, int rows)
        {
            array = new int[rows, column];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Метод очищает передаваемый одномерный массив.
        /// </summary> 
        public static void Clear(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        /// <summary>
        /// Метод очищает передаваемый двумерный массив.
        /// </summary> 
        public static void Clear(ref int[,] array)
        {
            /*for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 0;
                }
            }*/
            array = null;
        }

        /// <summary>
        /// Метод сохраняет передаваемый одномерный массив в файл.
        /// </summary> 
        public static void SaveArr(int[] array)
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
        /// Метод сохраняет передаваемый двумерный массив в файл.
        /// </summary> 
        public static void SaveArr(int[,] array)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(save.FileName);

                file.WriteLine(array.GetLength(0) + "\n" + array.GetLength(1));

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        file.WriteLine(array[i, j]);
                    }
                }

                file.Close();
            }
        }

        /// <summary>
        /// Метод открывает файл и записывает данные в передаваемый одномерный массив.
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

        /// <summary>
        /// Метод открывает файл и записывает данные в передаваемый двумерный массив.
        /// </summary> 
        public static void OpenArr(ref int[,] array)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";

            if (open.ShowDialog() == true)
            {
                StreamReader file = new StreamReader(open.FileName);

                int column = Convert.ToInt32(file.ReadLine()),
                    rows = Convert.ToInt32(file.ReadLine());

                array = new int[rows, column];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = Convert.ToInt32(file.ReadLine());
                    }
                }

                file.Close();
            }
        }
    }
}
