using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractV4
{
    public class Circle : Shape
    {
        //Daire hesaplamasında pi*r2 tek değer alıyor yarıçap 
        public Circle(double radius) : base(radius, 0) // base constructor gönderdik
        {
        }

        public override double Area()
        {
            return pi * x * x;
        }
    }
}
