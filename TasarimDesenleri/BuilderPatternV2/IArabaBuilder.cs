using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV2
{
    public interface IArabaBuilder
    {
        public string SetMarka();
        public string SetModel();
        public double SetKm();
        public bool SetVites();
    }
}
