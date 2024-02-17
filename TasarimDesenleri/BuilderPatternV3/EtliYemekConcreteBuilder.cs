using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV3
{
    public class EtliYemekConcreteBuilder : YemekBuilder
    {
        public EtliYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetTuz()
        {
            yemek.Tuz = 40;
        }

        public override void SetYemekAdi()
        {
            yemek.YemekAdi = "Paça Çobası";
        }

        public override void SetYemekTipi()
        {
            yemek.YemekTipi = YemekTipi.Etli;
        }
    }
}
