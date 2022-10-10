using Lib_2;
using System;
using System.Windows;

namespace практическаяРабота_1
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try // проверка ввода 
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели некорректные значения!");
                return;
            }

            int upperIndex = Convert.ToInt32(textBox1.Text),
                lowerIndex = Convert.ToInt32(textBox2.Text),
                k = Convert.ToInt32(textBox3.Text);

            string numbers = Lib.RandNumsK(upperIndex, lowerIndex, k, out int sum, out int kol); // присваивание значения функции в переменную

            textBox4.Text = sum.ToString(); // вывод суммы
            textBox5.Text = kol.ToString(); // вывод кол-ва чисел
            textBox6.Text = numbers; // вывод последовательности чисел
        }

        private void Exit_Click(object sender, RoutedEventArgs e) // событие "закрытие приложения"
        {
            Close();
        }

        private void About_CLick(object sender, RoutedEventArgs e) // событие "о программе"
        {
            MessageBox.Show("Практическая работа №1\n Работу выполнил студент группы ИСП-31 Капустин Максим");
        }
    }
}