using BibliotekaFoRVisulase;
using Lib2;
using LibMas;
using System;
using System.Windows;

namespace прктическаяНомерДва
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] gridArray;

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (gridArray != null)
            {
                textBoxOutput.Text = Convert.ToString(Library2.GetMulti(gridArray));
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
                        column = Convert.ToInt32(textBoxArrLength.Text);
                    Massiv.InitArr(out gridArray, column, random);
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
                    int column = Convert.ToInt32(textBoxArrLength.Text);
                    Massiv.InitArr(out gridArray, column);
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
                dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
            }
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            Massiv.SaveArr(ref gridArray);
            dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            Massiv.OpenArr(ref gridArray);
            dataTable.ItemsSource = VisualArray.ToDataTable(gridArray).DefaultView;
        }
    }
}