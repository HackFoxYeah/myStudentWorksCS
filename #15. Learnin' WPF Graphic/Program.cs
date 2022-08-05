using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _23aya_rabota
{
    public partial class MainWindow : Window{
        public MainWindow() => InitializeComponent();
        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
        private void CreateShape_Click(object sender, RoutedEventArgs e){
            if (white.IsChecked == true || white1.IsChecked == true){
                canvas.Children.Clear();

                Polygon polygonO = new Polygon(){
                    Fill = Brushes.White,
                    StrokeThickness = 4
                };

                polygonO.Points.Add(new Point(65, 20));  // 1             
                polygonO.Points.Add(new Point(65, 200)); // 2
                polygonO.Points.Add(new Point(100, 200));// 3
                polygonO.Points.Add(new Point(100, 155));// 4
                polygonO.Points.Add(new Point(150, 200));// 5
                polygonO.Points.Add(new Point(175, 175));// 6 
                polygonO.Points.Add(new Point(100, 110));// 7
                polygonO.Points.Add(new Point(175, 50)); // 8
                polygonO.Points.Add(new Point(150, 20)); // 9
                polygonO.Points.Add(new Point(100, 65)); // 10
                polygonO.Points.Add(new Point(100, 20)); // 11

                canvas.Children.Add(polygonO);

                Rectangle rectanngle1 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.White,
                    StrokeThickness = 4
                };

                Rectangle rectanngle2 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.White,
                    StrokeThickness = 4
                };

                Rectangle rectanngle3 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.White,
                    StrokeThickness = 4
                };

                Rectangle rectanngle4 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.White,
                    StrokeThickness = 4
                };

                RotateTransform rotate = new RotateTransform(90);
                rectanngle4.LayoutTransform = rotate;

                RotateTransform rotate1 = new RotateTransform(90);
                rectanngle3.LayoutTransform = rotate;

                canvas.Children.Add(rectanngle1);
                canvas.Children.Add(rectanngle2);
                canvas.Children.Add(rectanngle3);
                canvas.Children.Add(rectanngle4);

                Canvas.SetLeft(rectanngle1, 217);
                Canvas.SetTop(rectanngle1, 175);

                Canvas.SetLeft(rectanngle2, 217);
                Canvas.SetTop(rectanngle2, 20);

                Canvas.SetLeft(rectanngle3, 292);
                Canvas.SetTop(rectanngle3, 20);

                Canvas.SetLeft(rectanngle4, 217);
                Canvas.SetTop(rectanngle4, 20);

                Polygon polygonT = new Polygon(){
                    Fill = Brushes.White,
                    StrokeThickness = 4
                };

                polygonT.Points.Add(new Point(400, 20));  // 1                                                      
                polygonT.Points.Add(new Point(400, 180)); // 2
                polygonT.Points.Add(new Point(365, 180)); // 3
                polygonT.Points.Add(new Point(365, 200)); // 4
                polygonT.Points.Add(new Point(460, 200)); // 5
                polygonT.Points.Add(new Point(460, 180)); // 6 
                polygonT.Points.Add(new Point(425, 180)); // 7                                                      
                polygonT.Points.Add(new Point(425, 20));  // 8

                canvas.Children.Add(polygonT);
            }
            else if (red.IsChecked == true || red1.IsChecked == true){
                canvas.Children.Clear();

                Polygon polygonO = new Polygon(){
                    Fill = Brushes.Red,
                    StrokeThickness = 4
                };

                polygonO.Points.Add(new Point(65, 20));  // 1             
                polygonO.Points.Add(new Point(65, 200)); // 2
                polygonO.Points.Add(new Point(100, 200));// 3
                polygonO.Points.Add(new Point(100, 155));// 4
                polygonO.Points.Add(new Point(150, 200));// 5
                polygonO.Points.Add(new Point(175, 175));// 6 
                polygonO.Points.Add(new Point(100, 110));// 7
                polygonO.Points.Add(new Point(175, 50)); // 8
                polygonO.Points.Add(new Point(150, 20)); // 9
                polygonO.Points.Add(new Point(100, 65)); // 10
                polygonO.Points.Add(new Point(100, 20)); // 11

                canvas.Children.Add(polygonO);

                Rectangle rectanngle1 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.Red,
                    StrokeThickness = 4
                };

                Rectangle rectanngle2 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.Red,
                    StrokeThickness = 4
                };

                Rectangle rectanngle3 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.Red,
                    StrokeThickness = 4
                };

                Rectangle rectanngle4 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.Red,
                    StrokeThickness = 4
                };

                RotateTransform rotate = new RotateTransform(90);
                rectanngle4.LayoutTransform = rotate;

                RotateTransform rotate1 = new RotateTransform(90);
                rectanngle3.LayoutTransform = rotate;

                canvas.Children.Add(rectanngle1);
                canvas.Children.Add(rectanngle2);
                canvas.Children.Add(rectanngle3);
                canvas.Children.Add(rectanngle4);

                Canvas.SetLeft(rectanngle1, 217);
                Canvas.SetTop(rectanngle1, 175);

                Canvas.SetLeft(rectanngle2, 217);
                Canvas.SetTop(rectanngle2, 20);

                Canvas.SetLeft(rectanngle3, 292);
                Canvas.SetTop(rectanngle3, 20);

                Canvas.SetLeft(rectanngle4, 217);
                Canvas.SetTop(rectanngle4, 20);

                Polygon polygonT = new Polygon(){
                    Fill = Brushes.Red,
                    StrokeThickness = 4
                };

                polygonT.Points.Add(new Point(400, 20));  // 1                                                      
                polygonT.Points.Add(new Point(400, 180)); // 2
                polygonT.Points.Add(new Point(365, 180)); // 3
                polygonT.Points.Add(new Point(365, 200)); // 4
                polygonT.Points.Add(new Point(460, 200)); // 5
                polygonT.Points.Add(new Point(460, 180)); // 6 
                polygonT.Points.Add(new Point(425, 180)); // 7                                                      
                polygonT.Points.Add(new Point(425, 20));  // 8

                canvas.Children.Add(polygonT);
            }
            else if (green.IsChecked == true || green1.IsChecked == true){
                canvas.Children.Clear();

                Polygon polygonO = new Polygon(){
                    Fill = Brushes.Green,
                    StrokeThickness = 4
                };

                polygonO.Points.Add(new Point(65, 20));  // 1             
                polygonO.Points.Add(new Point(65, 200)); // 2
                polygonO.Points.Add(new Point(100, 200));// 3
                polygonO.Points.Add(new Point(100, 155));// 4
                polygonO.Points.Add(new Point(150, 200));// 5
                polygonO.Points.Add(new Point(175, 175));// 6 
                polygonO.Points.Add(new Point(100, 110));// 7
                polygonO.Points.Add(new Point(175, 50)); // 8
                polygonO.Points.Add(new Point(150, 20)); // 9
                polygonO.Points.Add(new Point(100, 65)); // 10
                polygonO.Points.Add(new Point(100, 20)); // 11

                canvas.Children.Add(polygonO);

                Rectangle rectanngle1 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.Green,
                    StrokeThickness = 4
                };

                Rectangle rectanngle2 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.Green,
                    StrokeThickness = 4
                };

                Rectangle rectanngle3 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.Green,
                    StrokeThickness = 4
                };

                Rectangle rectanngle4 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.Green,
                    StrokeThickness = 4
                };

                RotateTransform rotate = new RotateTransform(90);
                rectanngle4.LayoutTransform = rotate;

                RotateTransform rotate1 = new RotateTransform(90);
                rectanngle3.LayoutTransform = rotate;

                canvas.Children.Add(rectanngle1);
                canvas.Children.Add(rectanngle2);
                canvas.Children.Add(rectanngle3);
                canvas.Children.Add(rectanngle4);

                Canvas.SetLeft(rectanngle1, 217);
                Canvas.SetTop(rectanngle1, 175);

                Canvas.SetLeft(rectanngle2, 217);
                Canvas.SetTop(rectanngle2, 20);

                Canvas.SetLeft(rectanngle3, 292);
                Canvas.SetTop(rectanngle3, 20);

                Canvas.SetLeft(rectanngle4, 217);
                Canvas.SetTop(rectanngle4, 20);

                Polygon polygonT = new Polygon(){
                    Fill = Brushes.Green,
                    StrokeThickness = 4
                };

                polygonT.Points.Add(new Point(400, 20));  // 1                                                      
                polygonT.Points.Add(new Point(400, 180)); // 2
                polygonT.Points.Add(new Point(365, 180)); // 3
                polygonT.Points.Add(new Point(365, 200)); // 4
                polygonT.Points.Add(new Point(460, 200)); // 5
                polygonT.Points.Add(new Point(460, 180)); // 6 
                polygonT.Points.Add(new Point(425, 180)); // 7                                                      
                polygonT.Points.Add(new Point(425, 20));  // 8

                canvas.Children.Add(polygonT);
            }
            else if (blue.IsChecked == true || blue1.IsChecked == true){
                canvas.Children.Clear();

                Polygon polygonO = new Polygon(){
                    Fill = Brushes.Blue,
                    StrokeThickness = 4
                };

                polygonO.Points.Add(new Point(65, 20));   // 1             
                polygonO.Points.Add(new Point(65, 200));  // 2
                polygonO.Points.Add(new Point(100, 200)); // 3
                polygonO.Points.Add(new Point(100, 155)); // 4
                polygonO.Points.Add(new Point(150, 200)); // 5
                polygonO.Points.Add(new Point(175, 175)); // 6 
                polygonO.Points.Add(new Point(100, 110)); // 7
                polygonO.Points.Add(new Point(175, 50));  // 8
                polygonO.Points.Add(new Point(150, 20));  // 9
                polygonO.Points.Add(new Point(100, 65));  // 10
                polygonO.Points.Add(new Point(100, 20));  // 11

                canvas.Children.Add(polygonO);

                Rectangle rectanngle1 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.Blue,
                    StrokeThickness = 4
                };

                Rectangle rectanngle2 = new Rectangle(){
                    Height = 25,
                    Width = 100,
                    Fill = Brushes.Blue,
                    StrokeThickness = 4
                };

                Rectangle rectanngle3 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.Blue,
                    StrokeThickness = 4
                };

                Rectangle rectanngle4 = new Rectangle(){
                    Height = 25,
                    Width = 180,
                    Fill = Brushes.Blue,
                    StrokeThickness = 4
                };

                RotateTransform rotate = new RotateTransform(90);
                rectanngle4.LayoutTransform = rotate;

                RotateTransform rotate1 = new RotateTransform(90);
                rectanngle3.LayoutTransform = rotate;

                canvas.Children.Add(rectanngle1);
                canvas.Children.Add(rectanngle2);
                canvas.Children.Add(rectanngle3);
                canvas.Children.Add(rectanngle4);

                Canvas.SetLeft(rectanngle1, 217);
                Canvas.SetTop(rectanngle1, 175);

                Canvas.SetLeft(rectanngle2, 217);
                Canvas.SetTop(rectanngle2, 20);

                Canvas.SetLeft(rectanngle3, 292);
                Canvas.SetTop(rectanngle3, 20);

                Canvas.SetLeft(rectanngle4, 217);
                Canvas.SetTop(rectanngle4, 20);

                Polygon polygonT = new Polygon()
                {
                    Fill = Brushes.Blue,
                    StrokeThickness = 4
                };

                polygonT.Points.Add(new Point(400, 20));  // 1                                                      
                polygonT.Points.Add(new Point(400, 180)); // 2
                polygonT.Points.Add(new Point(365, 180)); // 3
                polygonT.Points.Add(new Point(365, 200)); // 4
                polygonT.Points.Add(new Point(460, 200)); // 5
                polygonT.Points.Add(new Point(460, 180)); // 6 
                polygonT.Points.Add(new Point(425, 180)); // 7                                                      
                polygonT.Points.Add(new Point(425, 20));  // 8

                canvas.Children.Add(polygonT);
            }
        }

        private void about_Click(object sender, RoutedEventArgs e){
            MessageBox.Show("Работа №23. " +
                            "\nЦель: написать слово \"КОТ\", используя разные графические примитивы." +
                            "\nВыполнил студент группы ИСП-21 Капустин Максим");
        }

        private void delete_Click(object sender, RoutedEventArgs e){
            canvas.Children.Clear();
        }

        private void green1_Click(object sender, RoutedEventArgs e){
            green.IsChecked = true;
            green1.IsChecked = true;
        }

        private void blue1_Click(object sender, RoutedEventArgs e){
            blue.IsChecked = true;
            blue1.IsChecked = true;
        }

        private void red1_Click(object sender, RoutedEventArgs e){
            red.IsChecked = true;
            red1.IsChecked = true;
        }

        private void white1_Click(object sender, RoutedEventArgs e){
            white.IsChecked = true;
            white1.IsChecked = true;
        }       
    }
}
