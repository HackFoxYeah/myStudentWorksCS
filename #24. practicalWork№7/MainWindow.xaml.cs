using PairLibrary;
using System;
using System.Windows;
using System.Windows.Media;

namespace practWork_7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Money _firstMoney = new(0, 0),
             _secondMoney = new(0, 0),
              _thirdMoney = new(0, 0);     

        /// <summary>
        /// Задаёт данные из текстбокса в указанный объект.
        /// </summary>       
        /// <param name="moneyObj">Экземпляр класса Money.</param>
        void SetOrDrop(ref Money moneyObj)
        {
            string[] tempRubKop = textBoxFF.Text.Split(' ');

            string rubles,
                  kopecks;

            if (tempRubKop.Length == 1)
            {
                rubles = tempRubKop[0];
                kopecks = "0";
            }
            else if (tempRubKop.Length == 2)
            {
                rubles = tempRubKop[0];
                kopecks = tempRubKop[1];
            }
            else
            {
                rubles = string.Empty;
                kopecks = string.Empty;
            }

            try
            {
                moneyObj = new Money(int.Parse(rubles), int.Parse(kopecks));

                label1.Foreground = Brushes.Gray;

                textBoxFF.Clear();
            }
            catch (Exception)
            {
                if (!int.TryParse(rubles, out _))
                    textBoxFF.BorderBrush = Brushes.Red;

                if (!int.TryParse(kopecks, out _) || int.Parse(kopecks) > 99)
                    label1.Foreground = Brushes.Red;

                return;
            }
        }

        private void ButtonSetFirst_Click(object sender, RoutedEventArgs e)
        {
            SetOrDrop(ref _firstMoney);
        }

        private void ButtonSetSecond_Click(object sender, RoutedEventArgs e)
        {
            SetOrDrop(ref _secondMoney);
        }

        private void ButtonSetThird_Click(object sender, RoutedEventArgs e)
        {
            SetOrDrop(ref _thirdMoney);
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e)
        {
            var result = _firstMoney + _secondMoney + _thirdMoney;
            textBoxResults.Text += $"  >>>  Сумма пар денежных сумм - ({result.Rubles} руб, {result.Kopecks} коп). \n\n";
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = _firstMoney.Subtract(_secondMoney);
                
                textBoxResults.Text += $"  >>>  Разница первой и второй пар \n" +
                                       $"{null,-12}денежных сумм - ({result.Rubles} руб, {result.Kopecks} коп). \n\n";
            }
            catch (Exception)
            {
                textBoxResults.Text += $"  >>>  Результатом подсчёта является \n" +
                                       $"{null,-12}отрицательная денежная сумма. \n\n";
            }
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            textBoxResults.Text += $"  >>>  Первая пара - ({_firstMoney.Rubles} руб, {_firstMoney.Kopecks} коп),\n" +
                                   $"{null,-12}вторая пара - ({_secondMoney.Rubles} руб, {_secondMoney.Kopecks} коп),\n" +
                                   $"{null,-12}третья пара - ({_thirdMoney.Rubles} руб, {_thirdMoney.Kopecks} коп). \n\n";
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №7. Выполнил Капустин Максим ИСП-31.\n" +
                            "Текст задания: Использовать класс Pair (пара чисел). " +
                            "Определить класс-наследник Money с характеристиками: рубли и копейки.\n" +
                            "Переопределить операцию сложения и определить методы вычитания и деления денежных сумм.");
        }

        private void ButtonIncrement_Click(object sender, RoutedEventArgs e)
        {
            _secondMoney.GetBigger();
             _firstMoney.GetBigger();
             _thirdMoney.GetBigger();

            ButtonShow_Click(sender, e);
        }

        private void ButtonDevision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = int.Parse(textBoxValue.Text);

                _firstMoney.Division(value);
                _secondMoney.Division(value);
                _thirdMoney.Division(value);

                ButtonShow_Click(sender, e);

                textBoxValue.BorderBrush = Brushes.Gray;

                textBoxValue.Clear();
            }
            catch (Exception)
            {
                if (!int.TryParse(textBoxValue.Text, out _))
                    textBoxValue.BorderBrush = Brushes.Red;

                return;
            }
        }

        private void ButtonSetZero_Click(object sender, RoutedEventArgs e)
        {
             _firstMoney = new Money(0, 0);
            _secondMoney = new Money(0, 0);
             _thirdMoney = new Money(0, 0);

            ButtonShow_Click(sender, e);
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}