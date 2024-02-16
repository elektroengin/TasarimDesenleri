using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPaternV1
{
    /// <summary>
    ///  Sipariş veribilmek içinSiparisManager sınıfının kullanılması gerekir.
    ///  
    /// Müşterinin istediği marka,model,renk ve beygirgücüne sahip bir arabanın sipraişi için
    /// kullanılan methoddur.
    /// 
    /// <param name="marka">Sipariş edilen arabanın markası</param>
    /// <param name="model">Sipariş edilen arabanın modeli</param>
    /// <param name="renk">Sipariş edilen arabanın rengi</param>
    /// <param name="beygirgucu">Sipariş edilen arabanın beygir gücü</param>
    /// 
    /// oluşturulmuş araba nesnesini dönülür. 
    /// eğer istenilen marka araç yoksa method null dönülecektir.
    /// </summary>


    public class SiparisManager
    {
        public SiparisBuilder builder = null;

        public Araba CreateOrder(string marka, string model, string renk, int beygirgucu)
        {
            switch (marka)
            {
                case "Ford":
                    builder = new FordSiparisBuilder();
                    break;
                case "Audi":
                    builder = new AudiSiparisBuilder();
                    break;
                case "Bmw":
                    builder = new BmwSiparisBuilder();
                    break;
                default:
                    Console.WriteLine("Bu marka araç bulunamamıştır.");
                    return null;
            }

            this.builder.Marka = marka;
            this.builder.Model = model;
            this.builder.Renk = renk;
            this.builder.BeygirGucu = beygirgucu;

            return this.builder.ArabaAd;
        }

        public void PrintOder()
        {
            Console.WriteLine("Marka:" + this.builder.ArabaAd.Marka);
            Console.WriteLine("Model:" + this.builder.ArabaAd.Model);
            Console.WriteLine("Renk:" + this.builder.ArabaAd.Renk);
            Console.WriteLine("Beygir Gücü:" + this.builder.ArabaAd.BeygirGucu.ToString());
        }

    }

}
