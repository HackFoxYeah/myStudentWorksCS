using System;
using System.Windows;
using System.Windows.Controls;


namespace _16ая_работа
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e) //событие для кнопки Calc SP 
        {
            int firstTBx, secondTBy;

            if (firstTextBox.Text != "" && secondTextBox.Text != "" && int.TryParse(firstTextBox.Text, out firstTBx) && int.TryParse(secondTextBox.Text, out secondTBy)) //Защита от ввода некорректных значений
            {
                thirdTextBox.Text = Convert.ToString(firstTBx * secondTBy);

                fourthTextBox.Text = Convert.ToString((firstTBx * 2) + (secondTBy * 2));
            }
            else MessageBox.Show("Вы ввели некорректные данные.");
        }

        private void Do_reverse_Click(object sender, RoutedEventArgs e) //событие для кнопки Do rvrs (Do reverse)
        {
            int thirdrstTBx;

            if  (fifthTextBox.Text != "" && int.TryParse(fifthTextBox.Text, out thirdrstTBx)) //Защита от ввода некорректных значений
            {
                int x1 = thirdrstTBx, x2, x3, x4;
                x2 = x1 % 10;
                x1 /= 10;
                x3 = x1 % 10;
                x1 /= 10;
                x4 = x1 % 10;

                sixthTextBox.Text = $"{x2}{x3}{x4}";
            }
            else MessageBox.Show("Вы ввели некорректные данные.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //событие для кнопки Exit
        {
            Close();
        }

        private void To_Default1_Click(object sender, RoutedEventArgs e) //событие для кнопки Canc. 1
        {
            firstTextBox.Clear();

            secondTextBox.Clear();

            thirdTextBox.Clear();

            fourthTextBox.Clear();

            firstTextBox.Focus();
        }

        private void To_Default2_Click(object sender, RoutedEventArgs e) //событие для кнопки Canc. 2
        {
            fifthTextBox.Clear();

            sixthTextBox.Clear();

            fifthTextBox.Focus();
        }

        private void About_Click(object sender, RoutedEventArgs e) //событие для кнопки About
        {
            MessageBox.Show("Работа #17.\nВыполнил Капустин Максим Викторович.\n\nФормулировка задания:\n1) Даны стороны прямоугольника a и b. Найти его площадь, периметр.\n2) Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.");
        }

        private void FirstTextBox_TextChanged(object sender, TextChangedEventArgs e) //событие для поля с текстом firstTextBox
        {
            thirdTextBox.Clear();
            fourthTextBox.Clear();
        }

        private void SecondTextBox_TextChanged(object sender, TextChangedEventArgs e) //событие для поля с текстом secondTextBox
        {
            thirdTextBox.Clear();
            fourthTextBox.Clear();
        }

        private void FifthTextBox_TextChanged(object sender, TextChangedEventArgs e) //событие для поля с текстом fifthTextBox
        {
            sixthTextBox.Clear();
        }
    }
}
