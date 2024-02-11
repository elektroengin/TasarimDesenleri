using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractV1
{
    public class Bolme : Calculater
    {
        public override decimal Hesapla(int a, int b)
        {
            return a / b;
                 
        }
    }
}
