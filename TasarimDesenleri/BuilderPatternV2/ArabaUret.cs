using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV2
{
    /// <summary>
    /// Director Classımız
    /// </summary>
    public class ArabaUret
    {
        public Araba Uret(IArabaBuilder builder)
        {
            Araba araba = new Araba();

            araba.Marka = builder.SetMarka(); 
            araba.Model = builder.SetModel();
            araba.Km = builder.SetKm();
            araba.Vites = builder.SetVites();

            return araba;
        }
    }
}
