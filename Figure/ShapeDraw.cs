using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TopSystemTest1.Figure
{
    class ShapeDraw
    {
        private Canvas _canvas;

        public ShapeDraw(Canvas canvas)
        {
            _canvas = canvas;
        }

        public void Draw(Shape shape)
        {
            if (shape == null) return;

            if (shape is Circle)
            {
                DrawCircle(shape as Circle);
            }
            else if (shape is Triangle)
            {
                DrawTriangle(shape as Triangle);
            }
            else if (shape is RectangleShape)
            {
                DrawRectangle(shape as RectangleShape);
            }
        }

        public void DrawCircle(Circle circle)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = circle.Diameter;
            ellipse.Height = circle.Diameter;

            ellipse.Fill = new SolidColorBrush(circle.Color);
            Canvas.SetLeft(ellipse, (_canvas.ActualWidth - circle.Diameter) / 2);
            Canvas.SetTop(ellipse, (_canvas.ActualHeight - circle.Diameter) / 2);
            _canvas.Children.Clear();
            _canvas.Children.Add(ellipse);
        }

        public void DrawTriangle(Triangle triangle)
        {
            Polygon polygon = new Polygon();

            float r0 = triangle.SideA;
            float r1 = triangle.SideB;
            float d = triangle.SideC;

            float a = (r0 * r0 - r1 * r1 + d * d) / (2 * d);
            float h = r0 * r0 - a * a;

            Point firstPoint = new Point(0, 0);
            Point secondPoint = new Point(triangle.SideC, 0);

            double p2x = firstPoint.X + a * (secondPoint.X - firstPoint.X) / d;
            double p2y = firstPoint.Y + a * (secondPoint.Y - firstPoint.Y) / d;

            double p3x1 = p2x - Math.Sqrt(h) * (secondPoint.Y - firstPoint.Y) / d;
            double p3y1 = p2y + Math.Sqrt(h) * (secondPoint.X - firstPoint.X) / d;
            double p3x2 = p2x + Math.Sqrt(h) * (secondPoint.Y - firstPoint.Y) / d;
            double p3y2 = p2y - Math.Sqrt(h) * (secondPoint.X - firstPoint.X) / d;

            PointCollection points = new PointCollection();
            points.Add(firstPoint);
            points.Add(secondPoint);
            points.Add(new Point(p3x2, p3y2));


            polygon.Points = points;
            polygon.Fill = new SolidColorBrush(triangle.Color);
            Canvas.SetLeft(polygon, (_canvas.ActualWidth - triangle.SideC) / 2);
            Canvas.SetTop(polygon, (_canvas.ActualHeight - p3y2) / 2);
            _canvas.Children.Clear();
            _canvas.Children.Add(polygon);
        }

        public void DrawRectangle(RectangleShape rectangleShape)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Width = rectangleShape.SideA;
            rectangle.Height = rectangleShape.SideB;

            rectangle.Fill = new SolidColorBrush(rectangleShape.Color);
            Canvas.SetLeft(rectangle, (_canvas.ActualWidth - rectangleShape.SideA) / 2);
            Canvas.SetTop(rectangle, (_canvas.ActualHeight - rectangleShape.SideB) / 2);
            _canvas.Children.Clear();
            _canvas.Children.Add(rectangle);
        }
    }
}
