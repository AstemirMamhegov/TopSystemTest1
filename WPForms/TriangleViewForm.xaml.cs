using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TopSystemTest1.Figure;

namespace TopSystemTest1.WPForms
{
    /// <summary>
    /// Interaction logic for TriangleViewForm.xaml
    /// </summary>
    public partial class TriangleViewForm : Window
    {
        public TriangleViewForm()
        {


            InitializeComponent();
        }

        private void TrViewButton_Click(object sender, RoutedEventArgs e)
        {

            double sideA, sideB, sideC;

            if (!double.TryParse(TextBoxSideA.Text, out sideA) || !double.TryParse(TextBoxSideB.Text, out sideB) || !double.TryParse(TextBoxSideC.Text, out sideC))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                MessageBox.Show("These sides cannot form a triangle");
                return;
            }

            Polygon triangle = new Polygon();
            triangle.Stroke = Brushes.Black;
            triangle.Fill = Brushes.LightBlue;
            triangle.HorizontalAlignment = HorizontalAlignment.Left;
            triangle.VerticalAlignment = VerticalAlignment.Center;
            PointCollection points = new PointCollection();
            points.Add(new Point(0, 200)); // triangle base
            points.Add(new Point(sideC, 200));
            double height = Math.Sqrt(Math.Pow(sideA, 2) - Math.Pow((sideC / 2), 2));
            points.Add(new Point(sideC / 2, 100 - height)); // height from base
            triangle.Points = points;
            canvas.Children.Clear();
            canvas.Children.Add(triangle);

        }
    }
}
