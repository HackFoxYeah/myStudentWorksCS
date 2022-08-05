using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow() => InitializeComponent();

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)                           //
        {                                                                                             // 
                                                                                                      //
            TextBoxOutput.Clear();                                                                    // 
                                                                                                      // описание 
            TextBoxOutput2.Clear();                                                                   //
                                                                                                      //
            if (int.TryParse(TextBoxInput.Text, out int n))                                           //
            {                                                                                         //
                int multiplyBy = 1;                                                                   // события
                                                                                                      //
                Random rnd = new Random();                                                            //
                                                                                                      //
                for (int i = 0; i < n; i++)                                                           //
                {                                                                                     // 
                    multiplyBy = rnd.Next(0, n + 1);                                                  //
                                                                                                      //
                    TextBoxOutput.Text = TextBoxOutput.Text + " " + Convert.ToString(multiplyBy);     // для кнопки 
                                                                                                      //
                    multiplyBy *= multiplyBy;                                                         //
                }                                                                                     //
                                                                                                      //
                TextBoxOutput2.Text = Convert.ToString(multiplyBy);                                   //
                                                                                                      //
                TextBoxInput.Clear();                                                                 // рассчитать
            }                                                                                         //
            else                                                                                      //
            {                                                                                         //
                MessageBox.Show("Всего-лишь требовалось ввести число, вы серьёзно?");                 //
                                                                                                      //
                TextBoxInput.Clear();                                                                 //
            }                                                                                         //
        }                                                                                             //

        private void About_Click(object sender, RoutedEventArgs e) // кнопка о программе 
        {
            MessageBox.Show("\t\t\t  Работа #20.\n\t\n\n\t\t       Формулировка задания:\n    Найти произведение n целых случайных чисел X, распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close(); // кнопка выход        
    }
}
