using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace _21ая_работа
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        int[,] array; // объявление глобального массива для работы с таблицей

        private void Create_Click(object sender, RoutedEventArgs e) // событие для кнопки "Создать"
        {
            if (int.TryParse(ColumnCountTB.Text, out int columnCount)
                && int.TryParse(RawCountTB.Text, out int rawCount))
            {
                array = new int[columnCount, rawCount];

                DataGrid.ItemsSource = VisualArray.ToDataTable(array).DefaultView;
            }
            else
            {
                ColumnCountTB.Clear();

                RawCountTB.Clear();

                MessageBox.Show("Введены некорректные значения!");
            }
        }

        private void CellEditEnding(object sender, System.Windows.Controls.DataGridCellEditEndingEventArgs e)
        {
            int indexComun = e.Column.DisplayIndex; // событие для введения значения изменённой ячейки в массив

            int indexRow = e.Row.GetIndex();

            array[indexRow, indexComun] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
        }

        private void Fill_Click(object sender, RoutedEventArgs e) // событие для кнопки "Заполнить"
        {
            if (int.TryParse(RangeTB.Text, out int range)
                && int.TryParse(ColumnCountTB.Text, out int columnCount)
                && int.TryParse(RawCountTB.Text, out int rawCount))
            {
                array = new int[columnCount, rawCount];

                Random rnd = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(range + 1); // фича от Иванова Михаила 
                    }
                }

                DataGrid.ItemsSource = VisualArray.ToDataTable(array).DefaultView;
            }
            else
            {
                ColumnCountTB.Clear();

                RangeTB.Clear();

                RawCountTB.Clear();

                MessageBox.Show("Введены некорректные значения!");
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e) // событие для кнопки "Расчитать" из задания 1
        {
            if (array != null)
            {
                int sum = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < 3)
                            sum += array[i, j];
                    }
                }

                ResultTB.Text = Math.Round(Math.Cos(sum), 2).ToString();
            }
            else
            {
                MessageBox.Show("Таблица не создана!");
            }
        }

        private void Calculate2_Click(object sender, RoutedEventArgs e) // событие для кнопки "Расчитать" из задания 2
        {
            if (array != null)
            {
                int temp = 0, sum = 0, indexTemp = -1;

                int indexCopy = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum += array[i, j];
                    }

                    if (sum > temp)
                    {
                        temp = sum;

                        indexTemp = j;

                        indexCopy = 0;
                    }
                    if (sum == temp) indexCopy = indexTemp;

                    sum = 0;
                }
                if (indexCopy > 0)
                {
                    Result2TB.Text = (indexCopy + 1).ToString();
                }
                else Result2TB.Text = (indexTemp + 1).ToString();

            }
            else
            {
                MessageBox.Show("Таблица не создана!");
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e) // диалог сохранения файла
        {
            if (array != null)
            {
                SaveFileDialog save = new SaveFileDialog();

                save.DefaultExt = ".txt";

                save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";

                save.FilterIndex = 2;

                save.Title = "Сохранение таблицы";

                if (save.ShowDialog() == true)
                {
                    StreamWriter write = new StreamWriter(save.FileName);
                    
                    write.WriteLine(ColumnCountTB.Text);

                    write.WriteLine(RawCountTB.Text);

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            write.WriteLine(array[i, j]);
                        }
                    }

                    write.Close();
                }
            }
            else MessageBox.Show("Таблица не создана");
        }

        private void Open_Click(object sender, RoutedEventArgs e) // диалог открытия файла
        {
            OpenFileDialog open = new OpenFileDialog();

            open.DefaultExt = ".txt";

            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";

            open.FilterIndex = 2;

            open.Title = "Открытие таблицы";

            if (open.ShowDialog() == true)
            {
                StreamReader read = new StreamReader(open.FileName);

                int columns = Convert.ToInt32(read.ReadLine()),
                    raws = Convert.ToInt32(read.ReadLine());

                array = new int[columns, raws];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Convert.ToInt32(read.ReadLine());
                    }
                }

                read.Close();

                DataGrid.ItemsSource = VisualArray.ToDataTable(array).DefaultView;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close(); // событие для кнопки "Выход"

        private void About_Click(object sender, RoutedEventArgs e) // событие для кнопки "О программе"
        {
            MessageBox.Show("Работа #22.\n\nВыполнил Капустин Максим Викторович.\n\n" +
                "Формулировка задания:\n\n1. Открыть программы, выполненные в практической работе №22. " +
                "\n\n2.Добавить в меню команды сохранить, открыть." +
                "\n\n3.Реализовать сохранение и чтение таблицы из файла." +
                "\n\nДля выбора имени файла использовать системные диалоги OpenDialog, SaveDialog" +
                "\n\n4.Оформить программу комментариями.");
        }

        private void Clean_Click(object sender, RoutedEventArgs e)  // событие для кнопки "Очистить"
        {
            array = null;

            DataGrid.ItemsSource = null;
        }        
    }
}
