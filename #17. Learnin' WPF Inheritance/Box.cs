using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _26aya_rabota
{
    internal class Box : StraightLine
    {
        Rectangle rectangle;
        public Box() // конструктор
        {
            rectangle = new Rectangle()
            {
                Height = 100,
                Width = 150,
                Fill = new SolidColorBrush(Color.FromArgb(0, 255, 0, 0)), // прозрачная кисть
                StrokeThickness = 2.5
            };
        }

        public Brush fill = new SolidColorBrush(Colors.Blue);
        public Brush SFill
        {
            get { return fill; }
            set { fill = value; rectangle.Fill = fill; }
        }

        public new Brush stroke = new SolidColorBrush(Colors.White);

        public new void MoveToXY(double x, double y)
        {
            X = x;
            Y = y;
            Canvas.SetLeft(rectangle, X);
            Canvas.SetTop(rectangle, Y);
        }

        public new void Hide()
        {
            rectangle.Visibility = Visibility.Hidden;
        }

        public new void Show()
        {
            rectangle.Visibility = Visibility.Visible;
        }

        public new double X { get; set; }

        public new double Y { get; set; }

        public new Brush SStroke // Свойство "цвет линии"
        {
            get { return stroke; }
            set { stroke = value; rectangle.Stroke = stroke; }
        }

        public Rectangle RectangleFigure // Свойство "получение ссылки на объект"
        {
            get { return rectangle; }
        }
    }
}
