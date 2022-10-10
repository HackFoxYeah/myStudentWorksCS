using BibliotekaFoRVisulase;
using Lib2;
using LibMas;
using System;
using System.Windows;

namespace практическаяРабота_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Глобальный массив, основа таблицы.
        /// </summary>
        int[,] gridArray;

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                label111.Visibility = Visibility.Hidden;

                int k = Convert.ToInt32(textBoxOutput_Copy1.Text);

                Library3.SumNMulty(gridArray, k, out int sum, out int multy);

                textBoxOutput_Copy.Text = sum.ToString();
                textBoxOutput.Text = multy.ToString();
            }
            catch (Exception)
            {
                label111.Visibility = Visibility.Visible;
                return;
            }
        }

        private void buttonRandFill_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxRandom.Text != "")
            {
                try
                {
                    label111.Visibility = Visibility.Hidden;
                    int random = Convert.ToInt32(textBoxRandom.Text),
                        rows = Convert.ToInt32(textBoxArrLength.Text),
                        column = Convert.ToInt32(textBoxColumn.Text);

                    Massiv.InitArr(out gridArray, column, rows, random);
                    dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
                }
                catch (Exception)
                {
                    label111.Visibility = Visibility.Visible;
                    return;
                }
            }
            else
            {
                try
                {
                    label111.Visibility = Visibility.Hidden;
                    int rows = Convert.ToInt32(textBoxArrLength.Text),
                        column = Convert.ToInt32(textBoxColumn.Text);
                    Massiv.InitArr(out gridArray, column, rows);
                    dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
                }
                catch (Exception)
                {
                    label111.Visibility = Visibility.Visible;
                    return;
                }
            }
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            if (gridArray != null)
            {
                Massiv.Clear(ref gridArray);
                dataTable.ItemsSource = null;               
            }
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            Massiv.SaveArr(gridArray);
            dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            Massiv.OpenArr(ref gridArray);
            dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
        }

        private void dataTable_CellEditEnding(object sender, System.Windows.Controls.DataGridCellEditEndingEventArgs e)
        {
            int indColumn = e.Column.DisplayIndex,
            indRow = e.Row.GetIndex();
            gridArray[indRow, indColumn] = Convert.ToInt32(((System.Windows.Controls.TextBox)e.EditingElement).Text);
        }

        private void menuItemButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
