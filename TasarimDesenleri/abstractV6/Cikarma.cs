using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractV6
{
    public class Cikarma : ICalculater
    {
        public decimal Hesapla(int a, int b)
        {
            return (a - b);
        }
    }
}
