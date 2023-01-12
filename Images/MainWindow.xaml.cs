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

namespace Images
{    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void buttonEllipse_Click(object sender, RoutedEventArgs e)
        //{
        //    geometryDrawing.Geometry = new EllipseGeometry();
        //}

        //private void buttonRectangle_Click(object sender, RoutedEventArgs e)
        //{
        //    geometryDrawing.Geometry = new RectangleGeometry();
        //}

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            GeometryGroup geometryGroup = new GeometryGroup();
            geometryGroup.Children.Add(new EllipseGeometry(p, 14, 14));
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            //geometryDrawing.Brush = new SolidColorBrush(Colors.White);
            geometryDrawing.Pen = new Pen(Brushes.Gray, 2);
            DrawingImage geometryImage = new DrawingImage(geometryDrawing);
            geometryImage.Freeze();
            Image image = new Image();
            image.Source = geometryImage;
            image.Stretch = Stretch.None;
            image.HorizontalAlignment = HorizontalAlignment.Left;
            this.Content = image;
        }
    }
}
