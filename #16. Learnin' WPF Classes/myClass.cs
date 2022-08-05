using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _25aya_rabota
{
    class Square
    {
        public Square()
        {
            X = Y = 0;

            SFill = Brushes.White;

            rectangle = new Rectangle();

            rectangle.Fill = SFill;

            rectangle.Height = rectangle.Width = 3;

            rectangle.Margin = new Thickness(X, Y, 0, 0);
        }

        Rectangle rectangle;

        private Brush fill;

        private double lenght;

        public int X { get; set; }

        public int Y { get; set; }

        public Rectangle Figure
        {
            get { return rectangle; }
        }

        public double SLenght
        {
            get { return lenght; }
            set { lenght = value; rectangle.Width = rectangle.Height = lenght; }
        }
        public Brush SFill
        {
            get { return fill; }
            set { fill = value; rectangle.Fill = fill; rectangle.Stroke = fill; } //TOFIX
        }

        public void Show()
        {
            rectangle.Visibility = Visibility.Visible;
        }

        public void Hide()
        {
            rectangle.Visibility = Visibility.Hidden;
        }

        public void MoveToXY(int x, int y)
        {
            X = x; Y = y;

            Canvas.SetLeft(rectangle, X);
            Canvas.SetTop(rectangle, Y);
        }
    }
}
