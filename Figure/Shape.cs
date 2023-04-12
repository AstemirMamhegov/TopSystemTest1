using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TopSystemTest1.Figure
{
    public class Shape
    {
        private Color _color;
        private string _name;

        public Color Color => _color;

        public Shape()
        {
            _color.R = 0;
            _color.G = 0;
            _color.B = 0;
            _name = "New Shape";
        }

        public Shape(Color color, string name)
        {
            this._color = color;
            this._name = name;
        }
    }
}
