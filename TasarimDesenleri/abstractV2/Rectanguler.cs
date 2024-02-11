using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractV2
{
    public class Rectanguler : Shape
    {
        private int _shortside;
        private int _longside;

        public Rectanguler (int shortSide, int longSide)
        {
            _shortside = shortSide;
            _longside = longSide;
        }

        public override int GetArea()
        {
            return _shortside * _longside;
        }

        public override int Getperimeter()
        {
            return 2 * (_shortside + _longside);
        }
    }
}
