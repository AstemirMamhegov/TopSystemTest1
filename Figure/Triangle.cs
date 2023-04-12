using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace TopSystemTest1.Figure
{
    class Triangle : Shape
    {
        private float _sideA;
        private float _sideB;
        private float _sideC;

        public float SideA => _sideA;
        public float SideB => _sideB;
        public float SideC => _sideC;

        public Triangle(float sideA, float sideB, float sideC, Color color) : base(color, "Triangle")
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public Triangle(float Side, Color color) : base(color, "Equilateral Triangle")
        {
            _sideA = _sideB = _sideC = Side;
        }

        public Triangle(float baseSide, float side, Color color) : base(color, "Isosceles Triangle")
        {
            _sideA = _sideB = side;
            _sideC = baseSide;
        }
    }
}
