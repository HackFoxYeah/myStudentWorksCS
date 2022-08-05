using System;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Заполнить_Click(object sender, RoutedEventArgs e)  // 
        {                                                               //
            Random rnd = new Random();                                  //
            int n = 0;                                                  // заполнение
                                                                        // 
            if (int.TryParse(textBox2.Text, out _))                     //   списка
                n = Convert.ToInt32(textBox2.Text);                     //
            else n = 0;                                                 // случайными    
                                                                        //                                                                                                      // 
            for (int i = 0; i < n; i++)                                 // значениями
            {                                                           //
                listBox.Items.Add(rnd.Next(100));                       //
            }                                                           //
        }

        private void Очистить_Click(object sender, RoutedEventArgs e) => listBox.Items.Clear(); // отчистка списка

        private void Удалить_Click(object sender, RoutedEventArgs e)                       // удалить
        {                                                                                  // выделенный 
            if (listBox.SelectedIndex > 0) listBox.Items.RemoveAt(listBox.SelectedIndex);  // элемент из 
        }                                                                                  // списка

        private void Добавить_Click(object sender, RoutedEventArgs e)                                    //
        {                                                                                                // добавить
            if (int.TryParse(textBox3.Text, out int a) || double.TryParse(textBox3.Text, out _))         // 
                listBox.Items.Add(textBox3.Text);                                                        // элемент
                                                                                                         // 
            textBox3.Clear();                                                                            // в 
                                                                                                         //
            textBox3.Focus();                                                                            // список 
        }                                                                                                //

        private void Рассчитать_click(object sender, RoutedEventArgs e)  //
        {                                                                // рассчитать
            double sum = 0;                                              //
                                                                         //   сумму
            for (int i = 0; i < listBox.Items.Count; i++)                // 
            {                                                            // элементов
                sum += Convert.ToDouble(listBox.Items[i]);               // 
            }                                                            //    из                      
            textBox1.Text = Convert.ToString(sum);                       //
        }                                                                //  списка 
    }
}
