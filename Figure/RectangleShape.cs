using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TopSystemTest1.Figure
{
    class RectangleShape : Shape
    {
        private float _sideA;
        private float _sideB;

        public float SideA => _sideA;
        public float SideB => _sideB;

        public RectangleShape(float sideA, float sideB, Color color) : base(color, "Rectangle")
        {
            _sideA = sideA;
            _sideB = sideB;
        }
    }
}
