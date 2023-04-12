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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TopSystemTest1.Figure;

namespace TopSystemTest1.WPForms
{
    /// <summary>
    /// Interaction logic for ShapeViewForm.xaml
    /// </summary>
    public partial class ShapeViewForm : Window
    {
        ShapeDraw shapeDraw;

        public ShapeViewForm()
        {
            InitializeComponent();
            shapeDraw = new ShapeDraw(canvas);
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxShape.SelectedIndex == -1)
                return;

            if (comboBoxShape.SelectedIndex == 0)
            {
                Color color = new Color();
                color.A = 255;
                color.R = 255;
                color.G = 0;
                color.B = 0;

                float sideA = float.Parse(textBoxSideA.Text);
                float sideB = float.Parse(textBoxSideB.Text);
                float sideC = float.Parse(textBoxSideC.Text);

                Triangle triangle = new Triangle(sideA, sideB, sideC, color);
                shapeDraw.DrawTriangle(triangle);
            }
            else if (comboBoxShape.SelectedIndex == 1)
            {
                Color color = new Color();
                color.A = 255;
                color.R = 255;
                color.G = 0;
                color.B = 0;

                float radius = float.Parse(textBoxSideA.Text);

                Circle circle = new Circle(radius, color);
                shapeDraw.DrawCircle(circle);
            }
            else if (comboBoxShape.SelectedIndex == 2)
            {
                Color color = new Color();
                color.A = 255;
                color.R = 255;
                color.G = 0;
                color.B = 0;

                float sideA = float.Parse(textBoxSideA.Text);
                float sideB = float.Parse(textBoxSideB.Text);

                RectangleShape rectangleShape = new RectangleShape(sideA, sideB, color);
                shapeDraw.DrawRectangle(rectangleShape);
            }

        }

        private void comboBoxShape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxShape.SelectedIndex == 0)
            {
                textBoxSideA.Visibility = Visibility.Visible;
                textBoxSideB.Visibility = Visibility.Visible;
                textBoxSideC.Visibility = Visibility.Visible;
            }
            else if (comboBoxShape.SelectedIndex == 1)
            {
                textBoxSideB.Visibility = Visibility.Hidden;
                textBoxSideC.Visibility = Visibility.Hidden;
            }
            else if (comboBoxShape.SelectedIndex == 2)
            {
                textBoxSideB.Visibility= Visibility.Visible;
                textBoxSideC.Visibility = Visibility.Hidden;
            }
        }
    }
}
