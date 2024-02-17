using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV2
{
    /// <summary>
    /// ConcreteBuilder Sınıfımız
    /// </summary>
    public class OpelConreteBuilder : IArabaBuilder
    {
        public Araba araba;

        public OpelConreteBuilder()
        {
            araba = new Araba();
        }
        public string SetMarka()
        {
            return "Opel";
        }

        public string SetModel()
        {
            return "Astra";
        }

        public double SetKm()
        {
            return 162000;
        }

        public bool SetVites()
        {
            return false;
        }
    }
}
