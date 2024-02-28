using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPV1
{
    public abstract class Car
    {
        public string Run()
        {
            return "Araba Çalıştırıldı";
        }

        public abstract string OpenAirCondition();
    }
}
