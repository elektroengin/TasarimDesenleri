using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV3
{
    public class SebzeliYemekConcreteBuilder : YemekBuilder
    {
        public SebzeliYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetTuz()
        {
            yemek.Tuz = 60;
        }

        public override void SetYemekAdi()
        {
            yemek.YemekAdi = "Beyaz Lahana";
        }

        public override void SetYemekTipi()
        {
            yemek.YemekTipi = YemekTipi.Sebzeli;
        }
    }
}
