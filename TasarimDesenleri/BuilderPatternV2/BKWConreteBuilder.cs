using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV2
{
    public class BKWConreteBuilder : IArabaBuilder
    {
        public Araba araba;

        public BKWConreteBuilder()
        {
            araba = new Araba();
        }
        public string SetMarka()
        {
            return "BMW";
        }

        public string SetModel()
        {
            return "i20";
        }

        public double SetKm()
        {
            return 15000;
        }

        public bool SetVites()
        {
            return false;
        }
    }
}
