using System;
using System.Windows;
using System.Windows.Input;

namespace _25aya_rabota
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Square square;

        private void Window_Initialized(object sender, EventArgs e)
        {
            square = new Square();

            canvas.Children.Add(square.Figure);
        }

        private void SetCoordinatesBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                square.X = Convert.ToInt32(XTB.Text);
                square.Y = Convert.ToInt32(YTB.Text);

                square.MoveToXY(square.X, square.Y);

                square.SLenght = Convert.ToInt32(LenghtTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные координаты!");
                return;
            }
        }

        private void ShowBTN_Click(object sender, RoutedEventArgs e)
        {
            square.Show();
        }

        private void HideBTN_Click(object sender, RoutedEventArgs e)
        {
            square.Hide();
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutBTN_Click(object sender, RoutedEventArgs e)
        {
            if (label.Visibility == Visibility.Visible)
            {
                label.Visibility = Visibility.Hidden;
            }
            else
                label.Visibility = Visibility.Visible;
        }

        private void KeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                LenghtTB.Focusable = XTB.Focusable = YTB.Focusable = false;

                square.Y += 1;
                square.MoveToXY(square.X, square.Y);
            }
            if (e.Key == Key.Down)
            {
                LenghtTB.Focusable = XTB.Focusable = YTB.Focusable = false;
                square.Y -= 1;
                square.MoveToXY(square.X, square.Y);
            }
            if (e.Key == Key.Left)
            {
                LenghtTB.Focusable = XTB.Focusable = YTB.Focusable = false;
                square.X -= 1;
                square.MoveToXY(square.X, square.Y);
            }
            if (e.Key == Key.Right)
            {
                LenghtTB.Focusable = XTB.Focusable = YTB.Focusable = false;
                square.X += 1;
                square.MoveToXY(square.X, square.Y);
            }            
        }
        private void KeyUp_KeyUp(object sender, KeyEventArgs e)
        {
            LenghtTB.Focusable = XTB.Focusable = YTB.Focusable = true;
        }
    }
}
