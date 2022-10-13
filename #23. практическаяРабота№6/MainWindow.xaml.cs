using PairLib;
using System.Windows;

namespace практическаяРабота_6
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Pair _firstPair = new Pair(0, 0),
             _secondPair = new Pair(0, 0),
             _thirdPair = new Pair(0, 0);

        private void ButtonSetFirst_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _firstPair = new Pair(int.Parse(textBoxFF.Text), int.Parse(textBoxSF.Text));
            }
            catch (System.Exception)
            {
                return;
            }
        }

        private void ButtonSetSecond_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _secondPair = new Pair(int.Parse(textBoxFF.Text), int.Parse(textBoxSF.Text));
            }
            catch (System.Exception)
            {
                return;
            }

        }

        private void ButtonSetThird_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _thirdPair = new Pair(int.Parse(textBoxFF.Text), int.Parse(textBoxSF.Text));
            }
            catch (System.Exception)
            {
                return;
            }
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e)
        {
            textBoxResults.Text += $"  >>>  Сумма пар чисел - ({(_firstPair + _secondPair + _thirdPair).FirstValue}," +
                                   $" {(_firstPair + _secondPair + _thirdPair).SecondValue}). \n\n";
        }

        private void ButtonGetZero_Click(object sender, RoutedEventArgs e)
        {
            _firstPair = _secondPair = _thirdPair = new Pair(0, 0);
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №6. \nТекст задания: Создать класс Pair (пара чисел). Создать необходимые методы и свойства. " +
                "\r\nОпределить методы метод сложения полей и операцию сложения пар (а, b) + (с, d) = (а + c, b + d). Создать перегруженные методы для увеличения полей на 1," +
                " сложения трех пар чисел.", "О программе");
        }

        private void ButtonIncrement_Click(object sender, RoutedEventArgs e)
        {
            _secondPair.GetBigger();
            _firstPair.GetBigger();
            _thirdPair.GetBigger();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            textBoxResults.Text += $"  >>>  Первая пара - ({_firstPair.FirstValue}, {_firstPair.SecondValue}),\n" +
                                   $"            вторая пара - ({_secondPair.FirstValue}, {_secondPair.SecondValue}),\n" +
                                   $"            третья пара - ({_thirdPair.FirstValue}, {_thirdPair.SecondValue}). \n\n";
        }
    }
}