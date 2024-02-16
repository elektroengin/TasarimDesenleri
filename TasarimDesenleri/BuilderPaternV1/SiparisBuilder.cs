using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPaternV1
{
    /// <summary>
    /// Sipariş sürecinde konfigurasyon için kullanılacak methodlar
    /// bu sınıf içinde tanımlanacaktır. Belirli bir maka arabanın sipariş için
    /// altsınıflarının oluşturulması gerekmektedir.
    /// </summary>
    public abstract class SiparisBuilder
    {
        public Araba araba;

        public SiparisBuilder()
        {
        }

        public Araba ArabaAd
        {
            get
            {
                if (araba == null) { araba = new Araba(); }
                return araba;
            }
        }

        public abstract string Marka { set; }

        public abstract string Model { set; }
        public abstract string Renk { set; }

        public abstract int BeygirGucu { set; }
    }
}
