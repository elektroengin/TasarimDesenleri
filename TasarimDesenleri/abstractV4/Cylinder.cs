using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractV4
{
    public class Cylinder : Shape
    {
        public Cylinder(double radius, double height) : base(radius, height)
        {
        }

        public override double Area()
        {
            return 2 * pi * x * (y + x);
        }
    }
}
