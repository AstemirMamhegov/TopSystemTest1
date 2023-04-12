using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TopSystemTest1.Figure
{
    class Circle : Shape
    {
        private float _radius;

        public float Radius => _radius;
        public float Diameter => _radius * 2;

        public Circle(float radius, Color color) : base(color, "Circle")
        {
            _radius = radius;
        }
    }
}
