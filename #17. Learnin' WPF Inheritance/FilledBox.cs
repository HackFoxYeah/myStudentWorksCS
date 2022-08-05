using System.Windows.Media;
using System.Windows.Shapes;

namespace _26aya_rabota
{
    internal class FilledBox : Box
    {
        Rectangle rectangle;
        public FilledBox() // конструктор
        {
            rectangle = new Rectangle()
            {
                Height = 150,
                Width = 100,
                Fill = new SolidColorBrush(Colors.Blue)                
            };
        }     
        
        public double Height 
        {
            get { return rectangle.Height; }
            set { rectangle.Height = value; } 
        }

        public double Width
        {
            get { return rectangle.Width; }
            set { rectangle.Width = value; }
        }
    }
}
