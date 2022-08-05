using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _26aya_rabota
{   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        StraightLine straightLine; // Объявление полей 
        Box box;
        FilledBox filledBox;

        private void Window_Initialized(object sender, EventArgs e) // событие "инициализация окна"
        {
            straightLine = new StraightLine() // Создание объектов
            {
                SStroke = new SolidColorBrush(Colors.Red)
            };           

            box = new Box()
            {
                SStroke = new SolidColorBrush(Colors.Green)                
            };           

            filledBox = new FilledBox()
            {
                SFill = new SolidColorBrush(Colors.Blue)                
            };

            canvas.Children.Add(box.RectangleFigure);
            canvas.Children.Add(straightLine.LineFigure);
            canvas.Children.Add(filledBox.RectangleFigure);
        }

        private void MoveLine_Click(object sender, RoutedEventArgs e) // Событие, реализующие перемещение линии по клику
        {
            try // Проверка ввода
            {
                straightLine.MoveToXY(double.Parse(XTB.Text), double.Parse(YTB.Text));
            }
            catch (Exception)
            {
                box.MoveToXY(1234, 1234);
                straightLine.MoveToXY(1234, 1234);
                filledBox.MoveToXY(1234, 1234);
                errorLabel.Visibility = Visibility.Visible;
                return;
            }
            errorLabel.Visibility = Visibility.Hidden;
        }

        private void BoxMoveBTN_Click(object sender, RoutedEventArgs e) // Событие, реализующие перемещение четырёхугольника по клику
        {
            try // Проверка ввода
            {
                box.MoveToXY(double.Parse(XTB.Text), double.Parse(YTB.Text));
            }
            catch (Exception)
            {
                box.MoveToXY(1234, 1234);
                straightLine.MoveToXY(1234, 1234);
                filledBox.MoveToXY(1234, 1234);
                errorLabel.Visibility = Visibility.Visible;
                return;
            }
            errorLabel.Visibility = Visibility.Hidden;
        }

        private void FilledBoxMove_Click(object sender, RoutedEventArgs e) // Событие, реализующие перемещение
                                                                           // заполненного четырёхугольника по клику
        {
            try // Проверка ввода
            {
                filledBox.MoveToXY(double.Parse(XTB.Text), double.Parse(YTB.Text));
            }
            catch (Exception)
            {
                box.MoveToXY(1234, 1234);
                straightLine.MoveToXY(1234, 1234);
                filledBox.MoveToXY(1234, 1234);
                errorLabel.Visibility = Visibility.Visible;
                return;
            }
            errorLabel.Visibility = Visibility.Hidden;
        }

        private void UpBTN_Click(object sender, RoutedEventArgs e) // Событие, реализующее перемещение
                                                                   // объектов по нажатию кнопки "Вверх"
        {
            straightLine.Y += 2;
            Canvas.SetTop(straightLine.LineFigure, straightLine.Y);
            box.Y += 2;            
            Canvas.SetTop(box.RectangleFigure, box.Y);
            filledBox.Y += 2;
            Canvas.SetTop(filledBox.RectangleFigure, filledBox.Y);
        }

        private void RightBTN_Click(object sender, RoutedEventArgs e) // Событие, реализующее перемещение
                                                                      // объектов по нажатию кнопки "Вправо"
        {
            straightLine.X += 2;
            Canvas.SetLeft(straightLine.LineFigure, straightLine.X);
            box.X += 2;
            Canvas.SetLeft(box.RectangleFigure, box.X);
            filledBox.X += 2;
            Canvas.SetLeft(filledBox.RectangleFigure, filledBox.X);
        }

        private void DownBTN_Click(object sender, RoutedEventArgs e) // Событие, реализующее перемещение
                                                                     // объектов по нажатию кнопки "Вниз"
        {
            straightLine.Y -= 2;
            Canvas.SetTop(straightLine.LineFigure, straightLine.Y);
            box.Y -= 2;
            Canvas.SetTop(box.RectangleFigure, box.Y);
            filledBox.Y -= 2;
            Canvas.SetTop(filledBox.RectangleFigure, filledBox.Y);
        }

        private void LeftBTN_Click(object sender, RoutedEventArgs e) // Событие, реализующее перемещение
                                                                     // объектов по нажатию кнопки "Влево"
        {
            straightLine.X -= 2;
            Canvas.SetLeft(straightLine.LineFigure, straightLine.X);
            box.X -= 2;
            Canvas.SetLeft(box.RectangleFigure, box.X);
            filledBox.X -= 2;
            Canvas.SetLeft(filledBox.RectangleFigure, filledBox.X);
        }

        private void AboutBTN_Click(object sender, RoutedEventArgs e) // Событие, реализующее отображение
                                                                      // сведений о программе                                                                       
        {
            if (errorLabelAbout.Visibility == Visibility.Hidden) 
            {
                errorLabelAbout.Visibility = Visibility.Visible;
            }
            else
            {
                errorLabelAbout.Visibility = Visibility.Hidden;
            }
        }

        private void ShowBTN_Click(object sender, RoutedEventArgs e) // Показать фигуры
        {
            straightLine.Show();
            box.Show();
            filledBox.Show();
        }

        private void HideBTN_Click(object sender, RoutedEventArgs e) // Скрыть фигуры
        {
            straightLine.Hide();
            box.Hide();
            filledBox.Hide();
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e) // Выход
        {
            Close();
        }
    }
}
