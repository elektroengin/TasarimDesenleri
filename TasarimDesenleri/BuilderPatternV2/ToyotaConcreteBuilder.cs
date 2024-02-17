using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV2
{
    public class ToyotaConcreteBuilder : IArabaBuilder
    {
        public Araba araba;

        public ToyotaConcreteBuilder()
        {
            araba = new Araba();
        }
        public string SetMarka()
        {
            return "Toyato";
        }

        public string SetModel()
        {
            return "Corollo";
        }

        public double SetKm()
        {
            return 1000;
        }

        public bool SetVites()
        {
            return true;
        }
    }
}
