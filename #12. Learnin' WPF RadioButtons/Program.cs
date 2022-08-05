using System.Windows;


namespace _16ая_работа
{
    /// Составить программу, которая бы по названию месяца выдавала бы количество в месяце

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstRadioButton_Click(object sender, RoutedEventArgs e)
        {
            int tempVariable = 0;

            tempVariable = radioButton1.IsChecked.Value ? 1 :
            tempVariable = radioButton2.IsChecked.Value ? 2 :
            tempVariable = radioButton3.IsChecked.Value ? 3 :
            tempVariable = radioButton4.IsChecked.Value ? 4 :
            tempVariable = radioButton5.IsChecked.Value ? 5 :
            tempVariable = radioButton6.IsChecked.Value ? 6 :
            tempVariable = radioButton7.IsChecked.Value ? 7 :
            tempVariable = radioButton8.IsChecked.Value ? 8 :
            tempVariable = radioButton9.IsChecked.Value ? 9 :
            tempVariable = radioButton10.IsChecked.Value ? 10 :
            tempVariable = radioButton11.IsChecked.Value ? 11 :
            tempVariable = radioButton12.IsChecked.Value ? 12 : 0;

            switch (tempVariable)
            {
                case 1:
                    textBox1.Text = "Дней: 31";
                    break;
                case 2:
                    textBox1.Text = ("Дней: 28 (ВГ - 29)");
                    break;
                case 3:
                    textBox1.Text = ("Дней: 31");
                    break;
                case 4:
                    textBox1.Text = ("Дней: 30");
                    break;
                case 5:
                    textBox1.Text = ("Дней: 31");
                    break;
                case 6:
                    textBox1.Text = ("Дней: 30");
                    break;
                case 7:
                    textBox1.Text = ("Дней: 31");
                    break;
                case 8:
                    textBox1.Text = ("Дней: 30");
                    break;
                case 9:
                    textBox1.Text = ("Дней: 31");
                    break;
                case 10:
                    textBox1.Text = ("Дней: 30");
                    break;
                case 11:
                    textBox1.Text = ("Дней: 31");
                    break;
                case 12:
                    textBox1.Text = ("Дней: 30");
                    break;
            }
        }

        private void SecondRadioButton_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Clear();
        }

        private void CheckedBox_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked.Value)
            {
                groupBox2.IsEnabled = false; 
                groupBox1.IsEnabled = true;
            }
            else 
            {
                groupBox2.IsEnabled = true;
                groupBox1.IsEnabled = false;
            }
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {      
            textBox2.Text = radioButton1b.IsChecked.Value ? "Дней: 31":
            textBox2.Text = radioButton2b.IsChecked.Value ? "Дней: 28 (ВГ - 29)" :
            textBox2.Text = radioButton3b.IsChecked.Value ? "Дней: 31" :
            textBox2.Text = radioButton4b.IsChecked.Value ? "Дней: 30" :
            textBox2.Text = radioButton5b.IsChecked.Value ? "Дней: 31" :
            textBox2.Text = radioButton6b.IsChecked.Value ? "Дней: 30" :
            textBox2.Text = radioButton7b.IsChecked.Value ? "Дней: 31" :
            textBox2.Text = radioButton8b.IsChecked.Value ? "Дней: 30" :
            textBox2.Text = radioButton9b.IsChecked.Value ? "Дней: 31" :
            textBox2.Text = radioButton10b.IsChecked.Value ? "Дней: 30" :
            textBox2.Text = radioButton11b.IsChecked.Value ? "Дней: 31" :
            textBox2.Text = radioButton12b.IsChecked.Value ? "Дней: 30" : "";
        }

        private void buttonAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работа #18.\nВыполнил Капустин Максим Викторович.\n\nФормулировка задания:\nСоставить программу, которая бы по названию месяца выдавала бы количество в месяце.");
        }

        private void CheckedBox_Check(object sender, RoutedEventArgs e)
        {

        }
    }
}

