using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPV2
{
    public class Ferrari : Car, IAirCondition
    {
        public string OpenAirCondition()
        {
            Console.WriteLine("Klima Açıldı");
            return "Klime Açıldı";
        }
    }
}
