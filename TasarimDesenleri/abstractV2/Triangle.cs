using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractV2
{
    public class Triangle : Shape
    {
        private int _side;
        private int _height;

        public Triangle(int side, int height)
        {
            _side = side;
            _height = height;

        }

        public override int GetArea()
        {
            return (_side * _height) / 2;
        }

        public override int Getperimeter()
        {
            return (_side * 3);
        }
    }
}
